#include "pch-cpp.hpp"

#ifndef _MSC_VER
# include <alloca.h>
#else
# include <malloc.h>
#endif


#include <limits>
#include <stdint.h>


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

// System.Action`1<UnityEngine.Font>
struct Action_1_tC07E78969BFFC97261F80F4C08915A046DFDD9C7;
// System.Collections.Generic.List`1<UnityEngine.CanvasGroup>
struct List_1_t34AA4AF4E7352129CA58045901530E41445AC16D;
// System.Collections.Generic.List`1<UnityEngine.UI.Image>
struct List_1_t815A476B0A21E183042059E705F9E505478CD8AE;
// System.Collections.Generic.List`1<UnityEngine.UI.Dropdown/DropdownItem>
struct List_1_t4CFF6A6E1A912AE4990A34B2AA4A1FE2C9FB0033;
// UnityEngine.UI.CoroutineTween.TweenRunner`1<UnityEngine.UI.CoroutineTween.ColorTween>
struct TweenRunner_1_tD84B9953874682FCC36990AF2C54D748293908F3;
// UnityEngine.UI.CoroutineTween.TweenRunner`1<UnityEngine.UI.CoroutineTween.FloatTween>
struct TweenRunner_1_t428873023FD8831B6DCE3CBD53ADD7D37AC8222D;
// UnityEngine.Events.UnityAction`1<System.Single>
struct UnityAction_1_t50101DC7058B3235A520FF57E827D51694843FBB;
// UnityEngine.Events.UnityEvent`1<System.Single>
struct UnityEvent_1_t84B4EA1A2A00DEAC63B85AFAA89EBF67CA749DBC;
// AllIn1VfxToolkit.Demo.Scripts.All1VfxDemoEffect[]
struct All1VfxDemoEffectU5BU5D_tD3184435C9CE408F891FAB389BD269C827C7213F;
// AllIn1VfxToolkit.Demo.Scripts.All1VfxDemoEffectCollection[]
struct All1VfxDemoEffectCollectionU5BU5D_tA9660853E3FEE15A3B3F92BA64013878E31747FC;
// System.Char[]
struct CharU5BU5D_t7B7FC5BC8091AA3B9CB0B29CDD80B5EE9254AA34;
// UnityEngine.Color[]
struct ColorU5BU5D_t358DD89F511301E663AD9157305B94A2DEFF8834;
// System.Delegate[]
struct DelegateU5BU5D_t677D8FE08A5F99E8EE49150B73966CD6E9BF7DB8;
// UnityEngine.GameObject[]
struct GameObjectU5BU5D_tA88FC1A1FC9D4D73D0B3984D4B0ECE88F4C47642;
// System.IntPtr[]
struct IntPtrU5BU5D_t27FC72B0409D75AAF33EC42498E8094E95FEE9A6;
// System.Object[]
struct ObjectU5BU5D_tC1F4EE0DB0B7300255F5FD4AF64FE4C585CF5ADE;
// UnityEngine.UI.Selectable[]
struct SelectableU5BU5D_tECF9F5BDBF0652A937D18F10C883EFDAE2E62535;
// System.Diagnostics.StackTrace[]
struct StackTraceU5BU5D_t4AD999C288CB6D1F38A299D12B1598D606588971;
// UnityEngine.UI.Text[]
struct TextU5BU5D_t16DD1967B137EC602803C77DBB246B05B3D0275F;
// UnityEngine.UIVertex[]
struct UIVertexU5BU5D_tE3D523C48DFEBC775876720DE2539A79FB7E5E5A;
// UnityEngine.Vector2[]
struct Vector2U5BU5D_tE0F58A2D6D8592B5EC37D9CDEF09103A02E5D7FA;
// UnityEngine.Vector3[]
struct Vector3U5BU5D_t5FB88EAA33E46838BDC2ABDAEA3E8727491CB9E4;
// AllIn1VfxToolkit.Demo.Scripts.All1DemoDropdownScroller
struct All1DemoDropdownScroller_t33876BB20D6CD2D697A869AC5FA7B0B4165FAAD1;
// AllIn1VfxToolkit.Demo.Scripts.All1DemoMouseLocker
struct All1DemoMouseLocker_t24728648D9602EC4431794A5CB77192DBB2F1A1B;
// AllIn1VfxToolkit.Demo.Scripts.All1DemoProjectileObstacle
struct All1DemoProjectileObstacle_t3447F820D7618A5E02F662177938AD4A57ECBBE1;
// AllIn1VfxToolkit.Demo.Scripts.All1DemoSceneColor
struct All1DemoSceneColor_t88AAEE683C473BDFBB9BDB8A0390F9F981928A09;
// AllIn1VfxToolkit.Demo.Scripts.All1VfxDemoEffect
struct All1VfxDemoEffect_t66A278FEFF55B095702CEE911709440057966E75;
// AllIn1VfxToolkit.Demo.Scripts.All1VfxDemoEffectCollection
struct All1VfxDemoEffectCollection_tE355DD3FC1A635D51B056A1524F452ACFC312C7E;
// AllIn1VfxToolkit.Demo.Scripts.AllIn1AutoRotate
struct AllIn1AutoRotate_t85B144A09CA74C1EAE0DD3FE1CE5DFC4518CE80F;
// AllIn1VfxToolkit.Demo.Scripts.AllIn1CanvasFader
struct AllIn1CanvasFader_tB4AA563ED5CFF1F6FC9B974944AA53A94532162A;
// AllIn1VfxToolkit.Demo.Scripts.AllIn1ChangeAllChildTextFonts
struct AllIn1ChangeAllChildTextFonts_t11C8807E2A6936E92C06EFAD7E046BE279C4E433;
// AllIn1VfxToolkit.Demo.Scripts.AllIn1DemoProjectile
struct AllIn1DemoProjectile_tA36F8B6BF3163732D0C981065AF301449C4AAE69;
// AllIn1VfxToolkit.Demo.Scripts.AllIn1DemoScaleTween
struct AllIn1DemoScaleTween_t513A5592D7B99AAE00D3C297524793A01504CCD0;
// AllIn1VfxToolkit.Demo.Scripts.AllIn1DoShake
struct AllIn1DoShake_t4AC8F2F9DF4B14734088C6754E9692F1B74275B1;
// AllIn1VfxToolkit.Demo.Scripts.AllIn1MouseRotate
struct AllIn1MouseRotate_t83F7508F651802AEF83D151F967CBEA41AEF7935;
// AllIn1VfxToolkit.Demo.Scripts.AllIn1Shaker
struct AllIn1Shaker_t4540E312EAE72C5A4E5F184AFEC3099E91179295;
// AllIn1VfxToolkit.Demo.Scripts.AllIn1TimeControl
struct AllIn1TimeControl_tD27F0B4D919AD681DB84DE2277471ABFF29C38DC;
// AllIn1VfxToolkit.Demo.Scripts.AllIn1VfxAutoDestroy
struct AllIn1VfxAutoDestroy_t3C768037E70E7C4C499E0BCA0036CB1913BA6D95;
// AllIn1VfxToolkit.Demo.Scripts.AllIn1VfxDemoController
struct AllIn1VfxDemoController_tDBA0E647E412D7CE6715A6976DB1E1A5722F6892;
// AllIn1VfxToolkit.Demo.Scripts.AllIn1VfxFadeLight
struct AllIn1VfxFadeLight_t063DC487D234F37F3E1D51B46CE77FE9983E238C;
// AllIn1VfxToolkit.Demo.Scripts.AllIn1VfxParticleSystemTime
struct AllIn1VfxParticleSystemTime_t1EE72855BC01A8A9547DB7A4C30287E1CDF7E9EF;
// UnityEngine.UI.AnimationTriggers
struct AnimationTriggers_tF38CA7FA631709E096B57D732668D86081F44C11;
// System.AsyncCallback
struct AsyncCallback_tA7921BEF974919C46FF8F9D9867C567B200BB0EA;
// UnityEngine.Behaviour
struct Behaviour_t1A3DDDCF73B4627928FBFE02ED52B7251777DBD9;
// UnityEngine.UI.Button
struct Button_tA893FC15AB26E1439AC25BDCA7079530587BB65D;
// UnityEngine.Camera
struct Camera_tC44E094BAB53AFC8A014C6F9CFCE11F4FC38006C;
// UnityEngine.Canvas
struct Canvas_t2B7E56B7BDC287962E092755372E214ACB6393EA;
// UnityEngine.CanvasGroup
struct CanvasGroup_t6912220105AB4A288A2FD882D163D7218EAA577F;
// UnityEngine.CanvasRenderer
struct CanvasRenderer_tCF8ABE659F7C3A6ED0D99A988D0BDFB651310F0E;
// UnityEngine.Collider
struct Collider_t5E81E43C2ECA0209A7C4528E84A632712D192B02;
// UnityEngine.Component
struct Component_t62FBC8D2420DA4BE9037AFE430740F6B3EECA684;
// UnityEngine.Coroutine
struct Coroutine_t899D5232EF542CB8BA70AF9ECEECA494FAA9CCB7;
// System.DelegateData
struct DelegateData_t17DD30660E330C49381DAA99F934BE75CB11F288;
// UnityEngine.UI.Dropdown
struct Dropdown_t099F5232BB75810BC79EED6E27DDCED46C3BCD96;
// UnityEngine.Font
struct Font_tB53D3F362CB1A0B92307B362826F212AE2D2A6A9;
// UnityEngine.UI.FontData
struct FontData_t0F1E9B3ED8136CD40782AC9A6AFB69CAD127C738;
// UnityEngine.GameObject
struct GameObject_tC000A2E1A7CF1E10FD7BA08863287C072207C319;
// UnityEngine.UI.Graphic
struct Graphic_tF07D777035055CF93BA5F46F77ED5EDFEFF9AE24;
// System.IAsyncResult
struct IAsyncResult_tC9F97BF36FCF122D29D3101D80642278297BF370;
// System.Collections.IDictionary
struct IDictionary_t99871C56B8EC2452AC5C4CF3831695E617B89D3A;
// System.Collections.IEnumerator
struct IEnumerator_t5956F3AFB7ECF1117E3BC5890E7FC7B7F7A04105;
// UnityEngine.UI.Image
struct Image_t4021FF27176E44BFEDDCBE43C7FE6B713EC70D3C;
// UnityEngine.Events.InvokableCallList
struct InvokableCallList_tB7C66AA0C00F9C102C8BDC17A144E569AC7527A9;
// UnityEngine.Light
struct Light_tA2F349FE839781469A0344CF6039B51512394275;
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
// UnityEngine.ParticleSystem
struct ParticleSystem_t2F526CCDBD3512879B3FCBE04BCAB20D7B4F391E;
// UnityEngine.Events.PersistentCallGroup
struct PersistentCallGroup_t9A1D83DA2BA3118C103FA87D93CE92557A956FDC;
// UnityEngine.UI.RectMask2D
struct RectMask2D_tD909811991B341D752E4C978C89EFB80FA7A2B15;
// UnityEngine.RectTransform
struct RectTransform_t8A6A306FB29A6C8C22010CF9040E319753571072;
// UnityEngine.Renderer
struct Renderer_t58147AB5B00224FE1460FD47542DC0DA7EC9378C;
// UnityEngine.Rigidbody
struct Rigidbody_t101F2E2F9F16E765A77429B2DE4527D2047A887A;
// System.Runtime.Serialization.SafeSerializationManager
struct SafeSerializationManager_tDE44F029589A028F8A3053C5C06153FAB4AAE29F;
// UnityEngine.ScriptableObject
struct ScriptableObject_t4361E08CEBF052C650D3666C7CEC37EB31DE116A;
// UnityEngine.UI.Selectable
struct Selectable_t34088A3677CC9D344F81B0D91999D8C5963D7DBD;
// UnityEngine.UI.Slider
struct Slider_tBF39A11CC24CBD3F8BD728982ACAEAE43989B51A;
// UnityEngine.Sprite
struct Sprite_t5B10B1178EC2E6F53D33FFD77557F31C08A51ED9;
// System.String
struct String_t;
// UnityEngine.UI.Text
struct Text_t6A2339DA6C05AE2646FC1A6C8FCC127391BE7FA1;
// UnityEngine.TextGenerator
struct TextGenerator_t893F256D3587633108E00E5731CDC5A77AFF1B70;
// UnityEngine.Texture2D
struct Texture2D_t9B604D0D8E28032123641A7E7338FA872E2698BF;
// UnityEngine.Transform
struct Transform_tA8193BB29D4D2C7EC04918F3ED1816345186C3F1;
// UnityEngine.Events.UnityAction
struct UnityAction_t22E545F8BE0A62EE051C6A83E209587A0DB1C099;
// UnityEngine.UI.VertexHelper
struct VertexHelper_tDE8B67D3B076061C4F8DF325B0D63ED2E5367E55;
// System.Void
struct Void_t700C6383A2A510C2CF4DD86DABD5CA9FF70ADAC5;
// AllIn1VfxToolkit.Demo.Scripts.AllIn1VfxDemoController/<CurrentEffectLabelTweenEffectCR>d__38
struct U3CCurrentEffectLabelTweenEffectCRU3Ed__38_t35025879B5382AE5E6D1D27E9F51C6920712C86D;
// UnityEngine.UI.Button/ButtonClickedEvent
struct ButtonClickedEvent_tE6D6D94ED8100451CF00D2BED1FB2253F37BB14F;
// UnityEngine.Camera/CameraCallback
struct CameraCallback_tD9E7B69E561CE2EFDEEDB0E7F1406AC52247160D;
// UnityEngine.UI.Dropdown/DropdownEvent
struct DropdownEvent_tEB2C75C3DBC789936B31D9A979FD62E047846CFB;
// UnityEngine.UI.Dropdown/OptionData
struct OptionData_t5F665DC13C1E4307727D66ECC1100B3A77E3E857;
// UnityEngine.UI.Dropdown/OptionDataList
struct OptionDataList_t524EBDB7A2B178269FD5B4740108D0EC6404B4B6;
// UnityEngine.Font/FontTextureRebuildCallback
struct FontTextureRebuildCallback_tBF11A511EBD8D237A1C5885D460B42A45DDBB2DB;
// UnityEngine.UI.MaskableGraphic/CullStateChangedEvent
struct CullStateChangedEvent_t9B69755DEBEF041C3CC15C3604610BDD72856BD4;
// UnityEngine.UI.Slider/SliderEvent
struct SliderEvent_t312D89AE02E00DD965D68D6F7F813BDF455FD780;

IL2CPP_EXTERN_C RuntimeClass* AllIn1Shaker_t4540E312EAE72C5A4E5F184AFEC3099E91179295_il2cpp_TypeInfo_var;
IL2CPP_EXTERN_C RuntimeClass* Debug_tEB68BCBEB8EFD60F8043C67146DC05E7F50F374B_il2cpp_TypeInfo_var;
IL2CPP_EXTERN_C RuntimeClass* IDisposable_t099785737FC6A1E3699919A94109383715A8D807_il2cpp_TypeInfo_var;
IL2CPP_EXTERN_C RuntimeClass* IEnumerator_t5956F3AFB7ECF1117E3BC5890E7FC7B7F7A04105_il2cpp_TypeInfo_var;
IL2CPP_EXTERN_C RuntimeClass* NotSupportedException_tB9D89F0E9470A2C423D239D7C68EE0CFD77F9339_il2cpp_TypeInfo_var;
IL2CPP_EXTERN_C RuntimeClass* Object_tF2F3778131EFF286AF62B7B013A170F95A91571A_il2cpp_TypeInfo_var;
IL2CPP_EXTERN_C RuntimeClass* Transform_tA8193BB29D4D2C7EC04918F3ED1816345186C3F1_il2cpp_TypeInfo_var;
IL2CPP_EXTERN_C RuntimeClass* U3CCurrentEffectLabelTweenEffectCRU3Ed__38_t35025879B5382AE5E6D1D27E9F51C6920712C86D_il2cpp_TypeInfo_var;
IL2CPP_EXTERN_C RuntimeClass* UnityAction_1_t50101DC7058B3235A520FF57E827D51694843FBB_il2cpp_TypeInfo_var;
IL2CPP_EXTERN_C String_t* _stringLiteral006976E56695070D63E145217B701EDEE8895C82;
IL2CPP_EXTERN_C String_t* _stringLiteral16DD21BE77B115D392226EB71A2D3A9FDC29E3F0;
IL2CPP_EXTERN_C String_t* _stringLiteral4780AF940655CB59AF49F6344DA95EC30E32AA8A;
IL2CPP_EXTERN_C String_t* _stringLiteral493129A97A0C654B32ECBC950426300104965D7F;
IL2CPP_EXTERN_C String_t* _stringLiteral5FD7ACA76D20D20DB889E633C51EEB14ED85007F;
IL2CPP_EXTERN_C String_t* _stringLiteral88BEE283254D7094E258B3A88730F4CC4F1E4AC7;
IL2CPP_EXTERN_C String_t* _stringLiteral8E09F6971F42D87127E76A675589BE96CC2160A7;
IL2CPP_EXTERN_C String_t* _stringLiteral9DED1F98F6124037784F89A7135F9F6F303C3B60;
IL2CPP_EXTERN_C String_t* _stringLiteralAAAA401E86E41E6120BB9E96B9892141CF5A81F8;
IL2CPP_EXTERN_C String_t* _stringLiteralEDE8C4DF1715CFC71A5D1502BBF477C021B0A6BE;
IL2CPP_EXTERN_C String_t* _stringLiteralF12CEF824BF74FB0B0A862C961B9E80A0783D802;
IL2CPP_EXTERN_C String_t* _stringLiteralF5D8EF422ABD0284BA3EEB3BF58FBA9313575F4E;
IL2CPP_EXTERN_C String_t* _stringLiteralFC6687DC37346CD2569888E29764F727FAF530E0;
IL2CPP_EXTERN_C const RuntimeMethod* AllIn1TimeControl_U3CStartU3Eb__13_0_m41C786ED0E2119466A425777F89C052C183CBAAF_RuntimeMethod_var;
IL2CPP_EXTERN_C const RuntimeMethod* Component_GetComponentInChildren_TisText_t6A2339DA6C05AE2646FC1A6C8FCC127391BE7FA1_mFB5C182E24F496A866F116D3F75CBD8616A46AB3_RuntimeMethod_var;
IL2CPP_EXTERN_C const RuntimeMethod* Component_GetComponent_TisAllIn1DemoProjectile_tA36F8B6BF3163732D0C981065AF301449C4AAE69_mDC2B3DDAC7100EB3664EFDDE053CE3955615FC3E_RuntimeMethod_var;
IL2CPP_EXTERN_C const RuntimeMethod* Component_GetComponent_TisAllIn1DemoScaleTween_t513A5592D7B99AAE00D3C297524793A01504CCD0_m3EE927F72C328FCE7176EA4E296BFBD5B69CEF6C_RuntimeMethod_var;
IL2CPP_EXTERN_C const RuntimeMethod* Component_GetComponent_TisAllIn1MouseRotate_t83F7508F651802AEF83D151F967CBEA41AEF7935_m76825A01424AB21D31BE24D85F3B8FB30434AD51_RuntimeMethod_var;
IL2CPP_EXTERN_C const RuntimeMethod* Component_GetComponent_TisCanvasGroup_t6912220105AB4A288A2FD882D163D7218EAA577F_mFED0C73400AFB37A709212A6C61F9BF44DBB88C4_RuntimeMethod_var;
IL2CPP_EXTERN_C const RuntimeMethod* Component_GetComponent_TisDropdown_t099F5232BB75810BC79EED6E27DDCED46C3BCD96_m94BE8DA5A001258F5191A0C3A4B3EED5467BF931_RuntimeMethod_var;
IL2CPP_EXTERN_C const RuntimeMethod* Component_GetComponent_TisLight_tA2F349FE839781469A0344CF6039B51512394275_m78431E28004B9C0FF3A712F157BFEDF8D42E36EA_RuntimeMethod_var;
IL2CPP_EXTERN_C const RuntimeMethod* Component_GetComponent_TisParticleSystem_t2F526CCDBD3512879B3FCBE04BCAB20D7B4F391E_m91CE0171326B90198E69EAFA60F45473CAC6E0C3_RuntimeMethod_var;
IL2CPP_EXTERN_C const RuntimeMethod* Component_GetComponent_TisRigidbody_t101F2E2F9F16E765A77429B2DE4527D2047A887A_m9DC24AA806B0B65E917751F7A3AFDB58861157CE_RuntimeMethod_var;
IL2CPP_EXTERN_C const RuntimeMethod* Component_GetComponentsInChildren_TisText_t6A2339DA6C05AE2646FC1A6C8FCC127391BE7FA1_m7556907CF90B895FDFBEC11100A5F7AD5FAF1AA6_RuntimeMethod_var;
IL2CPP_EXTERN_C const RuntimeMethod* GameObject_GetComponent_TisAllIn1TimeControl_tD27F0B4D919AD681DB84DE2277471ABFF29C38DC_mF3263778C546C37B9E1DFF39316D8D702990DD5E_RuntimeMethod_var;
IL2CPP_EXTERN_C const RuntimeMethod* Object_Instantiate_TisGameObject_tC000A2E1A7CF1E10FD7BA08863287C072207C319_m81B599A0051F8F4543E5C73A11585E96E940943B_RuntimeMethod_var;
IL2CPP_EXTERN_C const RuntimeMethod* Object_Instantiate_TisGameObject_tC000A2E1A7CF1E10FD7BA08863287C072207C319_mF131D53AB04E75E849487A7ACF79A8B27527F4B8_RuntimeMethod_var;
IL2CPP_EXTERN_C const RuntimeMethod* U3CCurrentEffectLabelTweenEffectCRU3Ed__38_System_Collections_IEnumerator_Reset_m8D9441A9D2421A712769A540219C18C2C05D7FC4_RuntimeMethod_var;
IL2CPP_EXTERN_C const RuntimeMethod* UnityAction_1__ctor_m8CACADCAC18230FB18DF7A6BEC3D9EAD93FEDC3B_RuntimeMethod_var;
IL2CPP_EXTERN_C const RuntimeMethod* UnityEvent_1_AddListener_mA73838FBF3836695F5183B32B797E9499BA5E59C_RuntimeMethod_var;
struct Delegate_t_marshaled_com;
struct Delegate_t_marshaled_pinvoke;
struct Exception_t_marshaled_com;
struct Exception_t_marshaled_pinvoke;

struct All1VfxDemoEffectU5BU5D_tD3184435C9CE408F891FAB389BD269C827C7213F;
struct All1VfxDemoEffectCollectionU5BU5D_tA9660853E3FEE15A3B3F92BA64013878E31747FC;
struct ColorU5BU5D_t358DD89F511301E663AD9157305B94A2DEFF8834;
struct GameObjectU5BU5D_tA88FC1A1FC9D4D73D0B3984D4B0ECE88F4C47642;
struct TextU5BU5D_t16DD1967B137EC602803C77DBB246B05B3D0275F;

IL2CPP_EXTERN_C_BEGIN
IL2CPP_EXTERN_C_END

#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

// <Module>
struct U3CModuleU3E_tAB9C6A8F708A35FF54F77742C8A8906B500F8D97 
{
public:

public:
};


// System.Object

struct Il2CppArrayBounds;

// System.Array


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

// UnityEngine.Events.UnityEvent`1<System.Single>
struct UnityEvent_1_t84B4EA1A2A00DEAC63B85AFAA89EBF67CA749DBC  : public UnityEventBase_tBB43047292084BA63C5CBB1A379A8BB88611C6FB
{
public:
	// System.Object[] UnityEngine.Events.UnityEvent`1::m_InvokeArray
	ObjectU5BU5D_tC1F4EE0DB0B7300255F5FD4AF64FE4C585CF5ADE* ___m_InvokeArray_3;

public:
	inline static int32_t get_offset_of_m_InvokeArray_3() { return static_cast<int32_t>(offsetof(UnityEvent_1_t84B4EA1A2A00DEAC63B85AFAA89EBF67CA749DBC, ___m_InvokeArray_3)); }
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


// UnityEngine.DrivenRectTransformTracker
struct DrivenRectTransformTracker_t7DAF937E47C63B899C7BA0E9B0F206AAB4D85AC2 
{
public:
	union
	{
		struct
		{
		};
		uint8_t DrivenRectTransformTracker_t7DAF937E47C63B899C7BA0E9B0F206AAB4D85AC2__padding[1];
	};

public:
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


// UnityEngine.UI.SpriteState
struct SpriteState_t9024961148433175CE2F3D9E8E9239A8B1CAB15E 
{
public:
	// UnityEngine.Sprite UnityEngine.UI.SpriteState::m_HighlightedSprite
	Sprite_t5B10B1178EC2E6F53D33FFD77557F31C08A51ED9 * ___m_HighlightedSprite_0;
	// UnityEngine.Sprite UnityEngine.UI.SpriteState::m_PressedSprite
	Sprite_t5B10B1178EC2E6F53D33FFD77557F31C08A51ED9 * ___m_PressedSprite_1;
	// UnityEngine.Sprite UnityEngine.UI.SpriteState::m_SelectedSprite
	Sprite_t5B10B1178EC2E6F53D33FFD77557F31C08A51ED9 * ___m_SelectedSprite_2;
	// UnityEngine.Sprite UnityEngine.UI.SpriteState::m_DisabledSprite
	Sprite_t5B10B1178EC2E6F53D33FFD77557F31C08A51ED9 * ___m_DisabledSprite_3;

public:
	inline static int32_t get_offset_of_m_HighlightedSprite_0() { return static_cast<int32_t>(offsetof(SpriteState_t9024961148433175CE2F3D9E8E9239A8B1CAB15E, ___m_HighlightedSprite_0)); }
	inline Sprite_t5B10B1178EC2E6F53D33FFD77557F31C08A51ED9 * get_m_HighlightedSprite_0() const { return ___m_HighlightedSprite_0; }
	inline Sprite_t5B10B1178EC2E6F53D33FFD77557F31C08A51ED9 ** get_address_of_m_HighlightedSprite_0() { return &___m_HighlightedSprite_0; }
	inline void set_m_HighlightedSprite_0(Sprite_t5B10B1178EC2E6F53D33FFD77557F31C08A51ED9 * value)
	{
		___m_HighlightedSprite_0 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___m_HighlightedSprite_0), (void*)value);
	}

	inline static int32_t get_offset_of_m_PressedSprite_1() { return static_cast<int32_t>(offsetof(SpriteState_t9024961148433175CE2F3D9E8E9239A8B1CAB15E, ___m_PressedSprite_1)); }
	inline Sprite_t5B10B1178EC2E6F53D33FFD77557F31C08A51ED9 * get_m_PressedSprite_1() const { return ___m_PressedSprite_1; }
	inline Sprite_t5B10B1178EC2E6F53D33FFD77557F31C08A51ED9 ** get_address_of_m_PressedSprite_1() { return &___m_PressedSprite_1; }
	inline void set_m_PressedSprite_1(Sprite_t5B10B1178EC2E6F53D33FFD77557F31C08A51ED9 * value)
	{
		___m_PressedSprite_1 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___m_PressedSprite_1), (void*)value);
	}

	inline static int32_t get_offset_of_m_SelectedSprite_2() { return static_cast<int32_t>(offsetof(SpriteState_t9024961148433175CE2F3D9E8E9239A8B1CAB15E, ___m_SelectedSprite_2)); }
	inline Sprite_t5B10B1178EC2E6F53D33FFD77557F31C08A51ED9 * get_m_SelectedSprite_2() const { return ___m_SelectedSprite_2; }
	inline Sprite_t5B10B1178EC2E6F53D33FFD77557F31C08A51ED9 ** get_address_of_m_SelectedSprite_2() { return &___m_SelectedSprite_2; }
	inline void set_m_SelectedSprite_2(Sprite_t5B10B1178EC2E6F53D33FFD77557F31C08A51ED9 * value)
	{
		___m_SelectedSprite_2 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___m_SelectedSprite_2), (void*)value);
	}

	inline static int32_t get_offset_of_m_DisabledSprite_3() { return static_cast<int32_t>(offsetof(SpriteState_t9024961148433175CE2F3D9E8E9239A8B1CAB15E, ___m_DisabledSprite_3)); }
	inline Sprite_t5B10B1178EC2E6F53D33FFD77557F31C08A51ED9 * get_m_DisabledSprite_3() const { return ___m_DisabledSprite_3; }
	inline Sprite_t5B10B1178EC2E6F53D33FFD77557F31C08A51ED9 ** get_address_of_m_DisabledSprite_3() { return &___m_DisabledSprite_3; }
	inline void set_m_DisabledSprite_3(Sprite_t5B10B1178EC2E6F53D33FFD77557F31C08A51ED9 * value)
	{
		___m_DisabledSprite_3 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___m_DisabledSprite_3), (void*)value);
	}
};

// Native definition for P/Invoke marshalling of UnityEngine.UI.SpriteState
struct SpriteState_t9024961148433175CE2F3D9E8E9239A8B1CAB15E_marshaled_pinvoke
{
	Sprite_t5B10B1178EC2E6F53D33FFD77557F31C08A51ED9 * ___m_HighlightedSprite_0;
	Sprite_t5B10B1178EC2E6F53D33FFD77557F31C08A51ED9 * ___m_PressedSprite_1;
	Sprite_t5B10B1178EC2E6F53D33FFD77557F31C08A51ED9 * ___m_SelectedSprite_2;
	Sprite_t5B10B1178EC2E6F53D33FFD77557F31C08A51ED9 * ___m_DisabledSprite_3;
};
// Native definition for COM marshalling of UnityEngine.UI.SpriteState
struct SpriteState_t9024961148433175CE2F3D9E8E9239A8B1CAB15E_marshaled_com
{
	Sprite_t5B10B1178EC2E6F53D33FFD77557F31C08A51ED9 * ___m_HighlightedSprite_0;
	Sprite_t5B10B1178EC2E6F53D33FFD77557F31C08A51ED9 * ___m_PressedSprite_1;
	Sprite_t5B10B1178EC2E6F53D33FFD77557F31C08A51ED9 * ___m_SelectedSprite_2;
	Sprite_t5B10B1178EC2E6F53D33FFD77557F31C08A51ED9 * ___m_DisabledSprite_3;
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


// UnityEngine.UI.ColorBlock
struct ColorBlock_t04DFBB97B4772D2E00FD17ED2E3E6590E6916955 
{
public:
	// UnityEngine.Color UnityEngine.UI.ColorBlock::m_NormalColor
	Color_tF40DAF76C04FFECF3FE6024F85A294741C9CC659  ___m_NormalColor_0;
	// UnityEngine.Color UnityEngine.UI.ColorBlock::m_HighlightedColor
	Color_tF40DAF76C04FFECF3FE6024F85A294741C9CC659  ___m_HighlightedColor_1;
	// UnityEngine.Color UnityEngine.UI.ColorBlock::m_PressedColor
	Color_tF40DAF76C04FFECF3FE6024F85A294741C9CC659  ___m_PressedColor_2;
	// UnityEngine.Color UnityEngine.UI.ColorBlock::m_SelectedColor
	Color_tF40DAF76C04FFECF3FE6024F85A294741C9CC659  ___m_SelectedColor_3;
	// UnityEngine.Color UnityEngine.UI.ColorBlock::m_DisabledColor
	Color_tF40DAF76C04FFECF3FE6024F85A294741C9CC659  ___m_DisabledColor_4;
	// System.Single UnityEngine.UI.ColorBlock::m_ColorMultiplier
	float ___m_ColorMultiplier_5;
	// System.Single UnityEngine.UI.ColorBlock::m_FadeDuration
	float ___m_FadeDuration_6;

public:
	inline static int32_t get_offset_of_m_NormalColor_0() { return static_cast<int32_t>(offsetof(ColorBlock_t04DFBB97B4772D2E00FD17ED2E3E6590E6916955, ___m_NormalColor_0)); }
	inline Color_tF40DAF76C04FFECF3FE6024F85A294741C9CC659  get_m_NormalColor_0() const { return ___m_NormalColor_0; }
	inline Color_tF40DAF76C04FFECF3FE6024F85A294741C9CC659 * get_address_of_m_NormalColor_0() { return &___m_NormalColor_0; }
	inline void set_m_NormalColor_0(Color_tF40DAF76C04FFECF3FE6024F85A294741C9CC659  value)
	{
		___m_NormalColor_0 = value;
	}

	inline static int32_t get_offset_of_m_HighlightedColor_1() { return static_cast<int32_t>(offsetof(ColorBlock_t04DFBB97B4772D2E00FD17ED2E3E6590E6916955, ___m_HighlightedColor_1)); }
	inline Color_tF40DAF76C04FFECF3FE6024F85A294741C9CC659  get_m_HighlightedColor_1() const { return ___m_HighlightedColor_1; }
	inline Color_tF40DAF76C04FFECF3FE6024F85A294741C9CC659 * get_address_of_m_HighlightedColor_1() { return &___m_HighlightedColor_1; }
	inline void set_m_HighlightedColor_1(Color_tF40DAF76C04FFECF3FE6024F85A294741C9CC659  value)
	{
		___m_HighlightedColor_1 = value;
	}

	inline static int32_t get_offset_of_m_PressedColor_2() { return static_cast<int32_t>(offsetof(ColorBlock_t04DFBB97B4772D2E00FD17ED2E3E6590E6916955, ___m_PressedColor_2)); }
	inline Color_tF40DAF76C04FFECF3FE6024F85A294741C9CC659  get_m_PressedColor_2() const { return ___m_PressedColor_2; }
	inline Color_tF40DAF76C04FFECF3FE6024F85A294741C9CC659 * get_address_of_m_PressedColor_2() { return &___m_PressedColor_2; }
	inline void set_m_PressedColor_2(Color_tF40DAF76C04FFECF3FE6024F85A294741C9CC659  value)
	{
		___m_PressedColor_2 = value;
	}

	inline static int32_t get_offset_of_m_SelectedColor_3() { return static_cast<int32_t>(offsetof(ColorBlock_t04DFBB97B4772D2E00FD17ED2E3E6590E6916955, ___m_SelectedColor_3)); }
	inline Color_tF40DAF76C04FFECF3FE6024F85A294741C9CC659  get_m_SelectedColor_3() const { return ___m_SelectedColor_3; }
	inline Color_tF40DAF76C04FFECF3FE6024F85A294741C9CC659 * get_address_of_m_SelectedColor_3() { return &___m_SelectedColor_3; }
	inline void set_m_SelectedColor_3(Color_tF40DAF76C04FFECF3FE6024F85A294741C9CC659  value)
	{
		___m_SelectedColor_3 = value;
	}

	inline static int32_t get_offset_of_m_DisabledColor_4() { return static_cast<int32_t>(offsetof(ColorBlock_t04DFBB97B4772D2E00FD17ED2E3E6590E6916955, ___m_DisabledColor_4)); }
	inline Color_tF40DAF76C04FFECF3FE6024F85A294741C9CC659  get_m_DisabledColor_4() const { return ___m_DisabledColor_4; }
	inline Color_tF40DAF76C04FFECF3FE6024F85A294741C9CC659 * get_address_of_m_DisabledColor_4() { return &___m_DisabledColor_4; }
	inline void set_m_DisabledColor_4(Color_tF40DAF76C04FFECF3FE6024F85A294741C9CC659  value)
	{
		___m_DisabledColor_4 = value;
	}

	inline static int32_t get_offset_of_m_ColorMultiplier_5() { return static_cast<int32_t>(offsetof(ColorBlock_t04DFBB97B4772D2E00FD17ED2E3E6590E6916955, ___m_ColorMultiplier_5)); }
	inline float get_m_ColorMultiplier_5() const { return ___m_ColorMultiplier_5; }
	inline float* get_address_of_m_ColorMultiplier_5() { return &___m_ColorMultiplier_5; }
	inline void set_m_ColorMultiplier_5(float value)
	{
		___m_ColorMultiplier_5 = value;
	}

	inline static int32_t get_offset_of_m_FadeDuration_6() { return static_cast<int32_t>(offsetof(ColorBlock_t04DFBB97B4772D2E00FD17ED2E3E6590E6916955, ___m_FadeDuration_6)); }
	inline float get_m_FadeDuration_6() const { return ___m_FadeDuration_6; }
	inline float* get_address_of_m_FadeDuration_6() { return &___m_FadeDuration_6; }
	inline void set_m_FadeDuration_6(float value)
	{
		___m_FadeDuration_6 = value;
	}
};

struct ColorBlock_t04DFBB97B4772D2E00FD17ED2E3E6590E6916955_StaticFields
{
public:
	// UnityEngine.UI.ColorBlock UnityEngine.UI.ColorBlock::defaultColorBlock
	ColorBlock_t04DFBB97B4772D2E00FD17ED2E3E6590E6916955  ___defaultColorBlock_7;

public:
	inline static int32_t get_offset_of_defaultColorBlock_7() { return static_cast<int32_t>(offsetof(ColorBlock_t04DFBB97B4772D2E00FD17ED2E3E6590E6916955_StaticFields, ___defaultColorBlock_7)); }
	inline ColorBlock_t04DFBB97B4772D2E00FD17ED2E3E6590E6916955  get_defaultColorBlock_7() const { return ___defaultColorBlock_7; }
	inline ColorBlock_t04DFBB97B4772D2E00FD17ED2E3E6590E6916955 * get_address_of_defaultColorBlock_7() { return &___defaultColorBlock_7; }
	inline void set_defaultColorBlock_7(ColorBlock_t04DFBB97B4772D2E00FD17ED2E3E6590E6916955  value)
	{
		___defaultColorBlock_7 = value;
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

// UnityEngine.CursorLockMode
struct CursorLockMode_t247B41EE9632E4AD759EDADDB351AE0075162D04 
{
public:
	// System.Int32 UnityEngine.CursorLockMode::value__
	int32_t ___value___2;

public:
	inline static int32_t get_offset_of_value___2() { return static_cast<int32_t>(offsetof(CursorLockMode_t247B41EE9632E4AD759EDADDB351AE0075162D04, ___value___2)); }
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

// UnityEngine.Space
struct Space_t568D704D2B0AAC3E5894DDFF13DB2E02E2CD539E 
{
public:
	// System.Int32 UnityEngine.Space::value__
	int32_t ___value___2;

public:
	inline static int32_t get_offset_of_value___2() { return static_cast<int32_t>(offsetof(Space_t568D704D2B0AAC3E5894DDFF13DB2E02E2CD539E, ___value___2)); }
	inline int32_t get_value___2() const { return ___value___2; }
	inline int32_t* get_address_of_value___2() { return &___value___2; }
	inline void set_value___2(int32_t value)
	{
		___value___2 = value;
	}
};


// AllIn1VfxToolkit.Demo.Scripts.AllIn1VfxDemoController/<CurrentEffectLabelTweenEffectCR>d__38
struct U3CCurrentEffectLabelTweenEffectCRU3Ed__38_t35025879B5382AE5E6D1D27E9F51C6920712C86D  : public RuntimeObject
{
public:
	// System.Int32 AllIn1VfxToolkit.Demo.Scripts.AllIn1VfxDemoController/<CurrentEffectLabelTweenEffectCR>d__38::<>1__state
	int32_t ___U3CU3E1__state_0;
	// System.Object AllIn1VfxToolkit.Demo.Scripts.AllIn1VfxDemoController/<CurrentEffectLabelTweenEffectCR>d__38::<>2__current
	RuntimeObject * ___U3CU3E2__current_1;
	// AllIn1VfxToolkit.Demo.Scripts.AllIn1VfxDemoController AllIn1VfxToolkit.Demo.Scripts.AllIn1VfxDemoController/<CurrentEffectLabelTweenEffectCR>d__38::<>4__this
	AllIn1VfxDemoController_tDBA0E647E412D7CE6715A6976DB1E1A5722F6892 * ___U3CU3E4__this_2;
	// UnityEngine.Color AllIn1VfxToolkit.Demo.Scripts.AllIn1VfxDemoController/<CurrentEffectLabelTweenEffectCR>d__38::<startColor>5__2
	Color_tF40DAF76C04FFECF3FE6024F85A294741C9CC659  ___U3CstartColorU3E5__2_3;

public:
	inline static int32_t get_offset_of_U3CU3E1__state_0() { return static_cast<int32_t>(offsetof(U3CCurrentEffectLabelTweenEffectCRU3Ed__38_t35025879B5382AE5E6D1D27E9F51C6920712C86D, ___U3CU3E1__state_0)); }
	inline int32_t get_U3CU3E1__state_0() const { return ___U3CU3E1__state_0; }
	inline int32_t* get_address_of_U3CU3E1__state_0() { return &___U3CU3E1__state_0; }
	inline void set_U3CU3E1__state_0(int32_t value)
	{
		___U3CU3E1__state_0 = value;
	}

	inline static int32_t get_offset_of_U3CU3E2__current_1() { return static_cast<int32_t>(offsetof(U3CCurrentEffectLabelTweenEffectCRU3Ed__38_t35025879B5382AE5E6D1D27E9F51C6920712C86D, ___U3CU3E2__current_1)); }
	inline RuntimeObject * get_U3CU3E2__current_1() const { return ___U3CU3E2__current_1; }
	inline RuntimeObject ** get_address_of_U3CU3E2__current_1() { return &___U3CU3E2__current_1; }
	inline void set_U3CU3E2__current_1(RuntimeObject * value)
	{
		___U3CU3E2__current_1 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___U3CU3E2__current_1), (void*)value);
	}

	inline static int32_t get_offset_of_U3CU3E4__this_2() { return static_cast<int32_t>(offsetof(U3CCurrentEffectLabelTweenEffectCRU3Ed__38_t35025879B5382AE5E6D1D27E9F51C6920712C86D, ___U3CU3E4__this_2)); }
	inline AllIn1VfxDemoController_tDBA0E647E412D7CE6715A6976DB1E1A5722F6892 * get_U3CU3E4__this_2() const { return ___U3CU3E4__this_2; }
	inline AllIn1VfxDemoController_tDBA0E647E412D7CE6715A6976DB1E1A5722F6892 ** get_address_of_U3CU3E4__this_2() { return &___U3CU3E4__this_2; }
	inline void set_U3CU3E4__this_2(AllIn1VfxDemoController_tDBA0E647E412D7CE6715A6976DB1E1A5722F6892 * value)
	{
		___U3CU3E4__this_2 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___U3CU3E4__this_2), (void*)value);
	}

	inline static int32_t get_offset_of_U3CstartColorU3E5__2_3() { return static_cast<int32_t>(offsetof(U3CCurrentEffectLabelTweenEffectCRU3Ed__38_t35025879B5382AE5E6D1D27E9F51C6920712C86D, ___U3CstartColorU3E5__2_3)); }
	inline Color_tF40DAF76C04FFECF3FE6024F85A294741C9CC659  get_U3CstartColorU3E5__2_3() const { return ___U3CstartColorU3E5__2_3; }
	inline Color_tF40DAF76C04FFECF3FE6024F85A294741C9CC659 * get_address_of_U3CstartColorU3E5__2_3() { return &___U3CstartColorU3E5__2_3; }
	inline void set_U3CstartColorU3E5__2_3(Color_tF40DAF76C04FFECF3FE6024F85A294741C9CC659  value)
	{
		___U3CstartColorU3E5__2_3 = value;
	}
};


// UnityEngine.UI.Image/FillMethod
struct FillMethod_tC37E5898D113A8FBF25A6AB6FBA451CC51E211E2 
{
public:
	// System.Int32 UnityEngine.UI.Image/FillMethod::value__
	int32_t ___value___2;

public:
	inline static int32_t get_offset_of_value___2() { return static_cast<int32_t>(offsetof(FillMethod_tC37E5898D113A8FBF25A6AB6FBA451CC51E211E2, ___value___2)); }
	inline int32_t get_value___2() const { return ___value___2; }
	inline int32_t* get_address_of_value___2() { return &___value___2; }
	inline void set_value___2(int32_t value)
	{
		___value___2 = value;
	}
};


// UnityEngine.UI.Image/Type
struct Type_tDCB08AB7425CAB70C1E46CC341F877423B5A5E12 
{
public:
	// System.Int32 UnityEngine.UI.Image/Type::value__
	int32_t ___value___2;

public:
	inline static int32_t get_offset_of_value___2() { return static_cast<int32_t>(offsetof(Type_tDCB08AB7425CAB70C1E46CC341F877423B5A5E12, ___value___2)); }
	inline int32_t get_value___2() const { return ___value___2; }
	inline int32_t* get_address_of_value___2() { return &___value___2; }
	inline void set_value___2(int32_t value)
	{
		___value___2 = value;
	}
};


// UnityEngine.UI.Navigation/Mode
struct Mode_t3113FDF05158BBA1DFC78D7F69E4C1D25135CB0F 
{
public:
	// System.Int32 UnityEngine.UI.Navigation/Mode::value__
	int32_t ___value___2;

public:
	inline static int32_t get_offset_of_value___2() { return static_cast<int32_t>(offsetof(Mode_t3113FDF05158BBA1DFC78D7F69E4C1D25135CB0F, ___value___2)); }
	inline int32_t get_value___2() const { return ___value___2; }
	inline int32_t* get_address_of_value___2() { return &___value___2; }
	inline void set_value___2(int32_t value)
	{
		___value___2 = value;
	}
};


// UnityEngine.UI.Selectable/Transition
struct Transition_t1FC449676815A798E758D32E8BE6DC0A2511DF14 
{
public:
	// System.Int32 UnityEngine.UI.Selectable/Transition::value__
	int32_t ___value___2;

public:
	inline static int32_t get_offset_of_value___2() { return static_cast<int32_t>(offsetof(Transition_t1FC449676815A798E758D32E8BE6DC0A2511DF14, ___value___2)); }
	inline int32_t get_value___2() const { return ___value___2; }
	inline int32_t* get_address_of_value___2() { return &___value___2; }
	inline void set_value___2(int32_t value)
	{
		___value___2 = value;
	}
};


// UnityEngine.UI.Slider/Direction
struct Direction_tFC329DCFF9844C052301C90100CA0F5FA9C65961 
{
public:
	// System.Int32 UnityEngine.UI.Slider/Direction::value__
	int32_t ___value___2;

public:
	inline static int32_t get_offset_of_value___2() { return static_cast<int32_t>(offsetof(Direction_tFC329DCFF9844C052301C90100CA0F5FA9C65961, ___value___2)); }
	inline int32_t get_value___2() const { return ___value___2; }
	inline int32_t* get_address_of_value___2() { return &___value___2; }
	inline void set_value___2(int32_t value)
	{
		___value___2 = value;
	}
};


// UnityEngine.UI.Slider/SliderEvent
struct SliderEvent_t312D89AE02E00DD965D68D6F7F813BDF455FD780  : public UnityEvent_1_t84B4EA1A2A00DEAC63B85AFAA89EBF67CA749DBC
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


// UnityEngine.GameObject
struct GameObject_tC000A2E1A7CF1E10FD7BA08863287C072207C319  : public Object_tF2F3778131EFF286AF62B7B013A170F95A91571A
{
public:

public:
};


// UnityEngine.Material
struct Material_t8927C00353A72755313F046D0CE85178AE8218EE  : public Object_tF2F3778131EFF286AF62B7B013A170F95A91571A
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

// UnityEngine.UI.Navigation
struct Navigation_t1CF0FFB22C0357CD64714FB7A40A275F899D363A 
{
public:
	// UnityEngine.UI.Navigation/Mode UnityEngine.UI.Navigation::m_Mode
	int32_t ___m_Mode_0;
	// System.Boolean UnityEngine.UI.Navigation::m_WrapAround
	bool ___m_WrapAround_1;
	// UnityEngine.UI.Selectable UnityEngine.UI.Navigation::m_SelectOnUp
	Selectable_t34088A3677CC9D344F81B0D91999D8C5963D7DBD * ___m_SelectOnUp_2;
	// UnityEngine.UI.Selectable UnityEngine.UI.Navigation::m_SelectOnDown
	Selectable_t34088A3677CC9D344F81B0D91999D8C5963D7DBD * ___m_SelectOnDown_3;
	// UnityEngine.UI.Selectable UnityEngine.UI.Navigation::m_SelectOnLeft
	Selectable_t34088A3677CC9D344F81B0D91999D8C5963D7DBD * ___m_SelectOnLeft_4;
	// UnityEngine.UI.Selectable UnityEngine.UI.Navigation::m_SelectOnRight
	Selectable_t34088A3677CC9D344F81B0D91999D8C5963D7DBD * ___m_SelectOnRight_5;

public:
	inline static int32_t get_offset_of_m_Mode_0() { return static_cast<int32_t>(offsetof(Navigation_t1CF0FFB22C0357CD64714FB7A40A275F899D363A, ___m_Mode_0)); }
	inline int32_t get_m_Mode_0() const { return ___m_Mode_0; }
	inline int32_t* get_address_of_m_Mode_0() { return &___m_Mode_0; }
	inline void set_m_Mode_0(int32_t value)
	{
		___m_Mode_0 = value;
	}

	inline static int32_t get_offset_of_m_WrapAround_1() { return static_cast<int32_t>(offsetof(Navigation_t1CF0FFB22C0357CD64714FB7A40A275F899D363A, ___m_WrapAround_1)); }
	inline bool get_m_WrapAround_1() const { return ___m_WrapAround_1; }
	inline bool* get_address_of_m_WrapAround_1() { return &___m_WrapAround_1; }
	inline void set_m_WrapAround_1(bool value)
	{
		___m_WrapAround_1 = value;
	}

	inline static int32_t get_offset_of_m_SelectOnUp_2() { return static_cast<int32_t>(offsetof(Navigation_t1CF0FFB22C0357CD64714FB7A40A275F899D363A, ___m_SelectOnUp_2)); }
	inline Selectable_t34088A3677CC9D344F81B0D91999D8C5963D7DBD * get_m_SelectOnUp_2() const { return ___m_SelectOnUp_2; }
	inline Selectable_t34088A3677CC9D344F81B0D91999D8C5963D7DBD ** get_address_of_m_SelectOnUp_2() { return &___m_SelectOnUp_2; }
	inline void set_m_SelectOnUp_2(Selectable_t34088A3677CC9D344F81B0D91999D8C5963D7DBD * value)
	{
		___m_SelectOnUp_2 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___m_SelectOnUp_2), (void*)value);
	}

	inline static int32_t get_offset_of_m_SelectOnDown_3() { return static_cast<int32_t>(offsetof(Navigation_t1CF0FFB22C0357CD64714FB7A40A275F899D363A, ___m_SelectOnDown_3)); }
	inline Selectable_t34088A3677CC9D344F81B0D91999D8C5963D7DBD * get_m_SelectOnDown_3() const { return ___m_SelectOnDown_3; }
	inline Selectable_t34088A3677CC9D344F81B0D91999D8C5963D7DBD ** get_address_of_m_SelectOnDown_3() { return &___m_SelectOnDown_3; }
	inline void set_m_SelectOnDown_3(Selectable_t34088A3677CC9D344F81B0D91999D8C5963D7DBD * value)
	{
		___m_SelectOnDown_3 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___m_SelectOnDown_3), (void*)value);
	}

	inline static int32_t get_offset_of_m_SelectOnLeft_4() { return static_cast<int32_t>(offsetof(Navigation_t1CF0FFB22C0357CD64714FB7A40A275F899D363A, ___m_SelectOnLeft_4)); }
	inline Selectable_t34088A3677CC9D344F81B0D91999D8C5963D7DBD * get_m_SelectOnLeft_4() const { return ___m_SelectOnLeft_4; }
	inline Selectable_t34088A3677CC9D344F81B0D91999D8C5963D7DBD ** get_address_of_m_SelectOnLeft_4() { return &___m_SelectOnLeft_4; }
	inline void set_m_SelectOnLeft_4(Selectable_t34088A3677CC9D344F81B0D91999D8C5963D7DBD * value)
	{
		___m_SelectOnLeft_4 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___m_SelectOnLeft_4), (void*)value);
	}

	inline static int32_t get_offset_of_m_SelectOnRight_5() { return static_cast<int32_t>(offsetof(Navigation_t1CF0FFB22C0357CD64714FB7A40A275F899D363A, ___m_SelectOnRight_5)); }
	inline Selectable_t34088A3677CC9D344F81B0D91999D8C5963D7DBD * get_m_SelectOnRight_5() const { return ___m_SelectOnRight_5; }
	inline Selectable_t34088A3677CC9D344F81B0D91999D8C5963D7DBD ** get_address_of_m_SelectOnRight_5() { return &___m_SelectOnRight_5; }
	inline void set_m_SelectOnRight_5(Selectable_t34088A3677CC9D344F81B0D91999D8C5963D7DBD * value)
	{
		___m_SelectOnRight_5 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___m_SelectOnRight_5), (void*)value);
	}
};

// Native definition for P/Invoke marshalling of UnityEngine.UI.Navigation
struct Navigation_t1CF0FFB22C0357CD64714FB7A40A275F899D363A_marshaled_pinvoke
{
	int32_t ___m_Mode_0;
	int32_t ___m_WrapAround_1;
	Selectable_t34088A3677CC9D344F81B0D91999D8C5963D7DBD * ___m_SelectOnUp_2;
	Selectable_t34088A3677CC9D344F81B0D91999D8C5963D7DBD * ___m_SelectOnDown_3;
	Selectable_t34088A3677CC9D344F81B0D91999D8C5963D7DBD * ___m_SelectOnLeft_4;
	Selectable_t34088A3677CC9D344F81B0D91999D8C5963D7DBD * ___m_SelectOnRight_5;
};
// Native definition for COM marshalling of UnityEngine.UI.Navigation
struct Navigation_t1CF0FFB22C0357CD64714FB7A40A275F899D363A_marshaled_com
{
	int32_t ___m_Mode_0;
	int32_t ___m_WrapAround_1;
	Selectable_t34088A3677CC9D344F81B0D91999D8C5963D7DBD * ___m_SelectOnUp_2;
	Selectable_t34088A3677CC9D344F81B0D91999D8C5963D7DBD * ___m_SelectOnDown_3;
	Selectable_t34088A3677CC9D344F81B0D91999D8C5963D7DBD * ___m_SelectOnLeft_4;
	Selectable_t34088A3677CC9D344F81B0D91999D8C5963D7DBD * ___m_SelectOnRight_5;
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


// UnityEngine.Events.UnityAction`1<System.Single>
struct UnityAction_1_t50101DC7058B3235A520FF57E827D51694843FBB  : public MulticastDelegate_t
{
public:

public:
};


// AllIn1VfxToolkit.Demo.Scripts.All1VfxDemoEffect
struct All1VfxDemoEffect_t66A278FEFF55B095702CEE911709440057966E75  : public ScriptableObject_t4361E08CEBF052C650D3666C7CEC37EB31DE116A
{
public:
	// System.Boolean AllIn1VfxToolkit.Demo.Scripts.All1VfxDemoEffect::onlyOneAtATime
	bool ___onlyOneAtATime_4;
	// System.Boolean AllIn1VfxToolkit.Demo.Scripts.All1VfxDemoEffect::canBePlayedAgain
	bool ___canBePlayedAgain_5;
	// System.Single AllIn1VfxToolkit.Demo.Scripts.All1VfxDemoEffect::randomSpreadRadius
	float ___randomSpreadRadius_6;
	// System.Single AllIn1VfxToolkit.Demo.Scripts.All1VfxDemoEffect::cooldown
	float ___cooldown_7;
	// System.Boolean AllIn1VfxToolkit.Demo.Scripts.All1VfxDemoEffect::isShootProjectile
	bool ___isShootProjectile_8;
	// UnityEngine.GameObject AllIn1VfxToolkit.Demo.Scripts.All1VfxDemoEffect::effectPrefab
	GameObject_tC000A2E1A7CF1E10FD7BA08863287C072207C319 * ___effectPrefab_9;
	// System.Boolean AllIn1VfxToolkit.Demo.Scripts.All1VfxDemoEffect::spawnTouchingFloor
	bool ___spawnTouchingFloor_10;
	// System.Single AllIn1VfxToolkit.Demo.Scripts.All1VfxDemoEffect::projectileSpeed
	float ___projectileSpeed_11;
	// UnityEngine.GameObject AllIn1VfxToolkit.Demo.Scripts.All1VfxDemoEffect::projectilePrefab
	GameObject_tC000A2E1A7CF1E10FD7BA08863287C072207C319 * ___projectilePrefab_12;
	// UnityEngine.GameObject AllIn1VfxToolkit.Demo.Scripts.All1VfxDemoEffect::muzzleFlashPrefab
	GameObject_tC000A2E1A7CF1E10FD7BA08863287C072207C319 * ___muzzleFlashPrefab_13;
	// UnityEngine.GameObject AllIn1VfxToolkit.Demo.Scripts.All1VfxDemoEffect::impactPrefab
	GameObject_tC000A2E1A7CF1E10FD7BA08863287C072207C319 * ___impactPrefab_14;
	// System.Boolean AllIn1VfxToolkit.Demo.Scripts.All1VfxDemoEffect::doCameraShake
	bool ___doCameraShake_15;
	// System.Single AllIn1VfxToolkit.Demo.Scripts.All1VfxDemoEffect::mainEffectShakeAmount
	float ___mainEffectShakeAmount_16;
	// System.Single AllIn1VfxToolkit.Demo.Scripts.All1VfxDemoEffect::projectileImpactShakeAmount
	float ___projectileImpactShakeAmount_17;
	// UnityEngine.Vector3 AllIn1VfxToolkit.Demo.Scripts.All1VfxDemoEffect::positionOffset
	Vector3_t65B972D6A585A0A5B63153CF1177A90D3C90D65E  ___positionOffset_18;
	// System.Single AllIn1VfxToolkit.Demo.Scripts.All1VfxDemoEffect::scaleMultiplier
	float ___scaleMultiplier_19;

public:
	inline static int32_t get_offset_of_onlyOneAtATime_4() { return static_cast<int32_t>(offsetof(All1VfxDemoEffect_t66A278FEFF55B095702CEE911709440057966E75, ___onlyOneAtATime_4)); }
	inline bool get_onlyOneAtATime_4() const { return ___onlyOneAtATime_4; }
	inline bool* get_address_of_onlyOneAtATime_4() { return &___onlyOneAtATime_4; }
	inline void set_onlyOneAtATime_4(bool value)
	{
		___onlyOneAtATime_4 = value;
	}

	inline static int32_t get_offset_of_canBePlayedAgain_5() { return static_cast<int32_t>(offsetof(All1VfxDemoEffect_t66A278FEFF55B095702CEE911709440057966E75, ___canBePlayedAgain_5)); }
	inline bool get_canBePlayedAgain_5() const { return ___canBePlayedAgain_5; }
	inline bool* get_address_of_canBePlayedAgain_5() { return &___canBePlayedAgain_5; }
	inline void set_canBePlayedAgain_5(bool value)
	{
		___canBePlayedAgain_5 = value;
	}

	inline static int32_t get_offset_of_randomSpreadRadius_6() { return static_cast<int32_t>(offsetof(All1VfxDemoEffect_t66A278FEFF55B095702CEE911709440057966E75, ___randomSpreadRadius_6)); }
	inline float get_randomSpreadRadius_6() const { return ___randomSpreadRadius_6; }
	inline float* get_address_of_randomSpreadRadius_6() { return &___randomSpreadRadius_6; }
	inline void set_randomSpreadRadius_6(float value)
	{
		___randomSpreadRadius_6 = value;
	}

	inline static int32_t get_offset_of_cooldown_7() { return static_cast<int32_t>(offsetof(All1VfxDemoEffect_t66A278FEFF55B095702CEE911709440057966E75, ___cooldown_7)); }
	inline float get_cooldown_7() const { return ___cooldown_7; }
	inline float* get_address_of_cooldown_7() { return &___cooldown_7; }
	inline void set_cooldown_7(float value)
	{
		___cooldown_7 = value;
	}

	inline static int32_t get_offset_of_isShootProjectile_8() { return static_cast<int32_t>(offsetof(All1VfxDemoEffect_t66A278FEFF55B095702CEE911709440057966E75, ___isShootProjectile_8)); }
	inline bool get_isShootProjectile_8() const { return ___isShootProjectile_8; }
	inline bool* get_address_of_isShootProjectile_8() { return &___isShootProjectile_8; }
	inline void set_isShootProjectile_8(bool value)
	{
		___isShootProjectile_8 = value;
	}

	inline static int32_t get_offset_of_effectPrefab_9() { return static_cast<int32_t>(offsetof(All1VfxDemoEffect_t66A278FEFF55B095702CEE911709440057966E75, ___effectPrefab_9)); }
	inline GameObject_tC000A2E1A7CF1E10FD7BA08863287C072207C319 * get_effectPrefab_9() const { return ___effectPrefab_9; }
	inline GameObject_tC000A2E1A7CF1E10FD7BA08863287C072207C319 ** get_address_of_effectPrefab_9() { return &___effectPrefab_9; }
	inline void set_effectPrefab_9(GameObject_tC000A2E1A7CF1E10FD7BA08863287C072207C319 * value)
	{
		___effectPrefab_9 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___effectPrefab_9), (void*)value);
	}

	inline static int32_t get_offset_of_spawnTouchingFloor_10() { return static_cast<int32_t>(offsetof(All1VfxDemoEffect_t66A278FEFF55B095702CEE911709440057966E75, ___spawnTouchingFloor_10)); }
	inline bool get_spawnTouchingFloor_10() const { return ___spawnTouchingFloor_10; }
	inline bool* get_address_of_spawnTouchingFloor_10() { return &___spawnTouchingFloor_10; }
	inline void set_spawnTouchingFloor_10(bool value)
	{
		___spawnTouchingFloor_10 = value;
	}

	inline static int32_t get_offset_of_projectileSpeed_11() { return static_cast<int32_t>(offsetof(All1VfxDemoEffect_t66A278FEFF55B095702CEE911709440057966E75, ___projectileSpeed_11)); }
	inline float get_projectileSpeed_11() const { return ___projectileSpeed_11; }
	inline float* get_address_of_projectileSpeed_11() { return &___projectileSpeed_11; }
	inline void set_projectileSpeed_11(float value)
	{
		___projectileSpeed_11 = value;
	}

	inline static int32_t get_offset_of_projectilePrefab_12() { return static_cast<int32_t>(offsetof(All1VfxDemoEffect_t66A278FEFF55B095702CEE911709440057966E75, ___projectilePrefab_12)); }
	inline GameObject_tC000A2E1A7CF1E10FD7BA08863287C072207C319 * get_projectilePrefab_12() const { return ___projectilePrefab_12; }
	inline GameObject_tC000A2E1A7CF1E10FD7BA08863287C072207C319 ** get_address_of_projectilePrefab_12() { return &___projectilePrefab_12; }
	inline void set_projectilePrefab_12(GameObject_tC000A2E1A7CF1E10FD7BA08863287C072207C319 * value)
	{
		___projectilePrefab_12 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___projectilePrefab_12), (void*)value);
	}

	inline static int32_t get_offset_of_muzzleFlashPrefab_13() { return static_cast<int32_t>(offsetof(All1VfxDemoEffect_t66A278FEFF55B095702CEE911709440057966E75, ___muzzleFlashPrefab_13)); }
	inline GameObject_tC000A2E1A7CF1E10FD7BA08863287C072207C319 * get_muzzleFlashPrefab_13() const { return ___muzzleFlashPrefab_13; }
	inline GameObject_tC000A2E1A7CF1E10FD7BA08863287C072207C319 ** get_address_of_muzzleFlashPrefab_13() { return &___muzzleFlashPrefab_13; }
	inline void set_muzzleFlashPrefab_13(GameObject_tC000A2E1A7CF1E10FD7BA08863287C072207C319 * value)
	{
		___muzzleFlashPrefab_13 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___muzzleFlashPrefab_13), (void*)value);
	}

	inline static int32_t get_offset_of_impactPrefab_14() { return static_cast<int32_t>(offsetof(All1VfxDemoEffect_t66A278FEFF55B095702CEE911709440057966E75, ___impactPrefab_14)); }
	inline GameObject_tC000A2E1A7CF1E10FD7BA08863287C072207C319 * get_impactPrefab_14() const { return ___impactPrefab_14; }
	inline GameObject_tC000A2E1A7CF1E10FD7BA08863287C072207C319 ** get_address_of_impactPrefab_14() { return &___impactPrefab_14; }
	inline void set_impactPrefab_14(GameObject_tC000A2E1A7CF1E10FD7BA08863287C072207C319 * value)
	{
		___impactPrefab_14 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___impactPrefab_14), (void*)value);
	}

	inline static int32_t get_offset_of_doCameraShake_15() { return static_cast<int32_t>(offsetof(All1VfxDemoEffect_t66A278FEFF55B095702CEE911709440057966E75, ___doCameraShake_15)); }
	inline bool get_doCameraShake_15() const { return ___doCameraShake_15; }
	inline bool* get_address_of_doCameraShake_15() { return &___doCameraShake_15; }
	inline void set_doCameraShake_15(bool value)
	{
		___doCameraShake_15 = value;
	}

	inline static int32_t get_offset_of_mainEffectShakeAmount_16() { return static_cast<int32_t>(offsetof(All1VfxDemoEffect_t66A278FEFF55B095702CEE911709440057966E75, ___mainEffectShakeAmount_16)); }
	inline float get_mainEffectShakeAmount_16() const { return ___mainEffectShakeAmount_16; }
	inline float* get_address_of_mainEffectShakeAmount_16() { return &___mainEffectShakeAmount_16; }
	inline void set_mainEffectShakeAmount_16(float value)
	{
		___mainEffectShakeAmount_16 = value;
	}

	inline static int32_t get_offset_of_projectileImpactShakeAmount_17() { return static_cast<int32_t>(offsetof(All1VfxDemoEffect_t66A278FEFF55B095702CEE911709440057966E75, ___projectileImpactShakeAmount_17)); }
	inline float get_projectileImpactShakeAmount_17() const { return ___projectileImpactShakeAmount_17; }
	inline float* get_address_of_projectileImpactShakeAmount_17() { return &___projectileImpactShakeAmount_17; }
	inline void set_projectileImpactShakeAmount_17(float value)
	{
		___projectileImpactShakeAmount_17 = value;
	}

	inline static int32_t get_offset_of_positionOffset_18() { return static_cast<int32_t>(offsetof(All1VfxDemoEffect_t66A278FEFF55B095702CEE911709440057966E75, ___positionOffset_18)); }
	inline Vector3_t65B972D6A585A0A5B63153CF1177A90D3C90D65E  get_positionOffset_18() const { return ___positionOffset_18; }
	inline Vector3_t65B972D6A585A0A5B63153CF1177A90D3C90D65E * get_address_of_positionOffset_18() { return &___positionOffset_18; }
	inline void set_positionOffset_18(Vector3_t65B972D6A585A0A5B63153CF1177A90D3C90D65E  value)
	{
		___positionOffset_18 = value;
	}

	inline static int32_t get_offset_of_scaleMultiplier_19() { return static_cast<int32_t>(offsetof(All1VfxDemoEffect_t66A278FEFF55B095702CEE911709440057966E75, ___scaleMultiplier_19)); }
	inline float get_scaleMultiplier_19() const { return ___scaleMultiplier_19; }
	inline float* get_address_of_scaleMultiplier_19() { return &___scaleMultiplier_19; }
	inline void set_scaleMultiplier_19(float value)
	{
		___scaleMultiplier_19 = value;
	}
};


// AllIn1VfxToolkit.Demo.Scripts.All1VfxDemoEffectCollection
struct All1VfxDemoEffectCollection_tE355DD3FC1A635D51B056A1524F452ACFC312C7E  : public ScriptableObject_t4361E08CEBF052C650D3666C7CEC37EB31DE116A
{
public:
	// AllIn1VfxToolkit.Demo.Scripts.All1VfxDemoEffect[] AllIn1VfxToolkit.Demo.Scripts.All1VfxDemoEffectCollection::demoEffectCollection
	All1VfxDemoEffectU5BU5D_tD3184435C9CE408F891FAB389BD269C827C7213F* ___demoEffectCollection_4;

public:
	inline static int32_t get_offset_of_demoEffectCollection_4() { return static_cast<int32_t>(offsetof(All1VfxDemoEffectCollection_tE355DD3FC1A635D51B056A1524F452ACFC312C7E, ___demoEffectCollection_4)); }
	inline All1VfxDemoEffectU5BU5D_tD3184435C9CE408F891FAB389BD269C827C7213F* get_demoEffectCollection_4() const { return ___demoEffectCollection_4; }
	inline All1VfxDemoEffectU5BU5D_tD3184435C9CE408F891FAB389BD269C827C7213F** get_address_of_demoEffectCollection_4() { return &___demoEffectCollection_4; }
	inline void set_demoEffectCollection_4(All1VfxDemoEffectU5BU5D_tD3184435C9CE408F891FAB389BD269C827C7213F* value)
	{
		___demoEffectCollection_4 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___demoEffectCollection_4), (void*)value);
	}
};


// UnityEngine.Behaviour
struct Behaviour_t1A3DDDCF73B4627928FBFE02ED52B7251777DBD9  : public Component_t62FBC8D2420DA4BE9037AFE430740F6B3EECA684
{
public:

public:
};


// UnityEngine.Collider
struct Collider_t5E81E43C2ECA0209A7C4528E84A632712D192B02  : public Component_t62FBC8D2420DA4BE9037AFE430740F6B3EECA684
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


// UnityEngine.ParticleSystem
struct ParticleSystem_t2F526CCDBD3512879B3FCBE04BCAB20D7B4F391E  : public Component_t62FBC8D2420DA4BE9037AFE430740F6B3EECA684
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


// UnityEngine.Rigidbody
struct Rigidbody_t101F2E2F9F16E765A77429B2DE4527D2047A887A  : public Component_t62FBC8D2420DA4BE9037AFE430740F6B3EECA684
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


// UnityEngine.CanvasGroup
struct CanvasGroup_t6912220105AB4A288A2FD882D163D7218EAA577F  : public Behaviour_t1A3DDDCF73B4627928FBFE02ED52B7251777DBD9
{
public:

public:
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


// AllIn1VfxToolkit.Demo.Scripts.All1DemoDropdownScroller
struct All1DemoDropdownScroller_t33876BB20D6CD2D697A869AC5FA7B0B4165FAAD1  : public MonoBehaviour_t37A501200D970A8257124B0EAE00A0FF3DDC354A
{
public:
	// System.Int32 AllIn1VfxToolkit.Demo.Scripts.All1DemoDropdownScroller::dropdownElementCount
	int32_t ___dropdownElementCount_4;
	// UnityEngine.KeyCode AllIn1VfxToolkit.Demo.Scripts.All1DemoDropdownScroller::nextDropdownElementKey
	int32_t ___nextDropdownElementKey_5;
	// UnityEngine.UI.Dropdown AllIn1VfxToolkit.Demo.Scripts.All1DemoDropdownScroller::dropdown
	Dropdown_t099F5232BB75810BC79EED6E27DDCED46C3BCD96 * ___dropdown_6;

public:
	inline static int32_t get_offset_of_dropdownElementCount_4() { return static_cast<int32_t>(offsetof(All1DemoDropdownScroller_t33876BB20D6CD2D697A869AC5FA7B0B4165FAAD1, ___dropdownElementCount_4)); }
	inline int32_t get_dropdownElementCount_4() const { return ___dropdownElementCount_4; }
	inline int32_t* get_address_of_dropdownElementCount_4() { return &___dropdownElementCount_4; }
	inline void set_dropdownElementCount_4(int32_t value)
	{
		___dropdownElementCount_4 = value;
	}

	inline static int32_t get_offset_of_nextDropdownElementKey_5() { return static_cast<int32_t>(offsetof(All1DemoDropdownScroller_t33876BB20D6CD2D697A869AC5FA7B0B4165FAAD1, ___nextDropdownElementKey_5)); }
	inline int32_t get_nextDropdownElementKey_5() const { return ___nextDropdownElementKey_5; }
	inline int32_t* get_address_of_nextDropdownElementKey_5() { return &___nextDropdownElementKey_5; }
	inline void set_nextDropdownElementKey_5(int32_t value)
	{
		___nextDropdownElementKey_5 = value;
	}

	inline static int32_t get_offset_of_dropdown_6() { return static_cast<int32_t>(offsetof(All1DemoDropdownScroller_t33876BB20D6CD2D697A869AC5FA7B0B4165FAAD1, ___dropdown_6)); }
	inline Dropdown_t099F5232BB75810BC79EED6E27DDCED46C3BCD96 * get_dropdown_6() const { return ___dropdown_6; }
	inline Dropdown_t099F5232BB75810BC79EED6E27DDCED46C3BCD96 ** get_address_of_dropdown_6() { return &___dropdown_6; }
	inline void set_dropdown_6(Dropdown_t099F5232BB75810BC79EED6E27DDCED46C3BCD96 * value)
	{
		___dropdown_6 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___dropdown_6), (void*)value);
	}
};


// AllIn1VfxToolkit.Demo.Scripts.All1DemoMouseLocker
struct All1DemoMouseLocker_t24728648D9602EC4431794A5CB77192DBB2F1A1B  : public MonoBehaviour_t37A501200D970A8257124B0EAE00A0FF3DDC354A
{
public:
	// UnityEngine.KeyCode AllIn1VfxToolkit.Demo.Scripts.All1DemoMouseLocker::mouseLockerKey
	int32_t ___mouseLockerKey_4;
	// UnityEngine.UI.Image AllIn1VfxToolkit.Demo.Scripts.All1DemoMouseLocker::lockButtonImage
	Image_t4021FF27176E44BFEDDCBE43C7FE6B713EC70D3C * ___lockButtonImage_5;
	// UnityEngine.Color AllIn1VfxToolkit.Demo.Scripts.All1DemoMouseLocker::lockButtonColor
	Color_tF40DAF76C04FFECF3FE6024F85A294741C9CC659  ___lockButtonColor_6;
	// AllIn1VfxToolkit.Demo.Scripts.AllIn1MouseRotate AllIn1VfxToolkit.Demo.Scripts.All1DemoMouseLocker::allIn1MouseRotate
	AllIn1MouseRotate_t83F7508F651802AEF83D151F967CBEA41AEF7935 * ___allIn1MouseRotate_7;
	// AllIn1VfxToolkit.Demo.Scripts.AllIn1DemoScaleTween AllIn1VfxToolkit.Demo.Scripts.All1DemoMouseLocker::lockedTween
	AllIn1DemoScaleTween_t513A5592D7B99AAE00D3C297524793A01504CCD0 * ___lockedTween_8;
	// UnityEngine.UI.Text AllIn1VfxToolkit.Demo.Scripts.All1DemoMouseLocker::pausedButtonText
	Text_t6A2339DA6C05AE2646FC1A6C8FCC127391BE7FA1 * ___pausedButtonText_9;
	// System.Boolean AllIn1VfxToolkit.Demo.Scripts.All1DemoMouseLocker::currentlyLocked
	bool ___currentlyLocked_10;

public:
	inline static int32_t get_offset_of_mouseLockerKey_4() { return static_cast<int32_t>(offsetof(All1DemoMouseLocker_t24728648D9602EC4431794A5CB77192DBB2F1A1B, ___mouseLockerKey_4)); }
	inline int32_t get_mouseLockerKey_4() const { return ___mouseLockerKey_4; }
	inline int32_t* get_address_of_mouseLockerKey_4() { return &___mouseLockerKey_4; }
	inline void set_mouseLockerKey_4(int32_t value)
	{
		___mouseLockerKey_4 = value;
	}

	inline static int32_t get_offset_of_lockButtonImage_5() { return static_cast<int32_t>(offsetof(All1DemoMouseLocker_t24728648D9602EC4431794A5CB77192DBB2F1A1B, ___lockButtonImage_5)); }
	inline Image_t4021FF27176E44BFEDDCBE43C7FE6B713EC70D3C * get_lockButtonImage_5() const { return ___lockButtonImage_5; }
	inline Image_t4021FF27176E44BFEDDCBE43C7FE6B713EC70D3C ** get_address_of_lockButtonImage_5() { return &___lockButtonImage_5; }
	inline void set_lockButtonImage_5(Image_t4021FF27176E44BFEDDCBE43C7FE6B713EC70D3C * value)
	{
		___lockButtonImage_5 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___lockButtonImage_5), (void*)value);
	}

	inline static int32_t get_offset_of_lockButtonColor_6() { return static_cast<int32_t>(offsetof(All1DemoMouseLocker_t24728648D9602EC4431794A5CB77192DBB2F1A1B, ___lockButtonColor_6)); }
	inline Color_tF40DAF76C04FFECF3FE6024F85A294741C9CC659  get_lockButtonColor_6() const { return ___lockButtonColor_6; }
	inline Color_tF40DAF76C04FFECF3FE6024F85A294741C9CC659 * get_address_of_lockButtonColor_6() { return &___lockButtonColor_6; }
	inline void set_lockButtonColor_6(Color_tF40DAF76C04FFECF3FE6024F85A294741C9CC659  value)
	{
		___lockButtonColor_6 = value;
	}

	inline static int32_t get_offset_of_allIn1MouseRotate_7() { return static_cast<int32_t>(offsetof(All1DemoMouseLocker_t24728648D9602EC4431794A5CB77192DBB2F1A1B, ___allIn1MouseRotate_7)); }
	inline AllIn1MouseRotate_t83F7508F651802AEF83D151F967CBEA41AEF7935 * get_allIn1MouseRotate_7() const { return ___allIn1MouseRotate_7; }
	inline AllIn1MouseRotate_t83F7508F651802AEF83D151F967CBEA41AEF7935 ** get_address_of_allIn1MouseRotate_7() { return &___allIn1MouseRotate_7; }
	inline void set_allIn1MouseRotate_7(AllIn1MouseRotate_t83F7508F651802AEF83D151F967CBEA41AEF7935 * value)
	{
		___allIn1MouseRotate_7 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___allIn1MouseRotate_7), (void*)value);
	}

	inline static int32_t get_offset_of_lockedTween_8() { return static_cast<int32_t>(offsetof(All1DemoMouseLocker_t24728648D9602EC4431794A5CB77192DBB2F1A1B, ___lockedTween_8)); }
	inline AllIn1DemoScaleTween_t513A5592D7B99AAE00D3C297524793A01504CCD0 * get_lockedTween_8() const { return ___lockedTween_8; }
	inline AllIn1DemoScaleTween_t513A5592D7B99AAE00D3C297524793A01504CCD0 ** get_address_of_lockedTween_8() { return &___lockedTween_8; }
	inline void set_lockedTween_8(AllIn1DemoScaleTween_t513A5592D7B99AAE00D3C297524793A01504CCD0 * value)
	{
		___lockedTween_8 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___lockedTween_8), (void*)value);
	}

	inline static int32_t get_offset_of_pausedButtonText_9() { return static_cast<int32_t>(offsetof(All1DemoMouseLocker_t24728648D9602EC4431794A5CB77192DBB2F1A1B, ___pausedButtonText_9)); }
	inline Text_t6A2339DA6C05AE2646FC1A6C8FCC127391BE7FA1 * get_pausedButtonText_9() const { return ___pausedButtonText_9; }
	inline Text_t6A2339DA6C05AE2646FC1A6C8FCC127391BE7FA1 ** get_address_of_pausedButtonText_9() { return &___pausedButtonText_9; }
	inline void set_pausedButtonText_9(Text_t6A2339DA6C05AE2646FC1A6C8FCC127391BE7FA1 * value)
	{
		___pausedButtonText_9 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___pausedButtonText_9), (void*)value);
	}

	inline static int32_t get_offset_of_currentlyLocked_10() { return static_cast<int32_t>(offsetof(All1DemoMouseLocker_t24728648D9602EC4431794A5CB77192DBB2F1A1B, ___currentlyLocked_10)); }
	inline bool get_currentlyLocked_10() const { return ___currentlyLocked_10; }
	inline bool* get_address_of_currentlyLocked_10() { return &___currentlyLocked_10; }
	inline void set_currentlyLocked_10(bool value)
	{
		___currentlyLocked_10 = value;
	}
};


// AllIn1VfxToolkit.Demo.Scripts.All1DemoProjectileObstacle
struct All1DemoProjectileObstacle_t3447F820D7618A5E02F662177938AD4A57ECBBE1  : public MonoBehaviour_t37A501200D970A8257124B0EAE00A0FF3DDC354A
{
public:
	// UnityEngine.GameObject[] AllIn1VfxToolkit.Demo.Scripts.All1DemoProjectileObstacle::projectileObstacles
	GameObjectU5BU5D_tA88FC1A1FC9D4D73D0B3984D4B0ECE88F4C47642* ___projectileObstacles_4;
	// UnityEngine.UI.Dropdown AllIn1VfxToolkit.Demo.Scripts.All1DemoProjectileObstacle::projectileObstacleDropdown
	Dropdown_t099F5232BB75810BC79EED6E27DDCED46C3BCD96 * ___projectileObstacleDropdown_5;

public:
	inline static int32_t get_offset_of_projectileObstacles_4() { return static_cast<int32_t>(offsetof(All1DemoProjectileObstacle_t3447F820D7618A5E02F662177938AD4A57ECBBE1, ___projectileObstacles_4)); }
	inline GameObjectU5BU5D_tA88FC1A1FC9D4D73D0B3984D4B0ECE88F4C47642* get_projectileObstacles_4() const { return ___projectileObstacles_4; }
	inline GameObjectU5BU5D_tA88FC1A1FC9D4D73D0B3984D4B0ECE88F4C47642** get_address_of_projectileObstacles_4() { return &___projectileObstacles_4; }
	inline void set_projectileObstacles_4(GameObjectU5BU5D_tA88FC1A1FC9D4D73D0B3984D4B0ECE88F4C47642* value)
	{
		___projectileObstacles_4 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___projectileObstacles_4), (void*)value);
	}

	inline static int32_t get_offset_of_projectileObstacleDropdown_5() { return static_cast<int32_t>(offsetof(All1DemoProjectileObstacle_t3447F820D7618A5E02F662177938AD4A57ECBBE1, ___projectileObstacleDropdown_5)); }
	inline Dropdown_t099F5232BB75810BC79EED6E27DDCED46C3BCD96 * get_projectileObstacleDropdown_5() const { return ___projectileObstacleDropdown_5; }
	inline Dropdown_t099F5232BB75810BC79EED6E27DDCED46C3BCD96 ** get_address_of_projectileObstacleDropdown_5() { return &___projectileObstacleDropdown_5; }
	inline void set_projectileObstacleDropdown_5(Dropdown_t099F5232BB75810BC79EED6E27DDCED46C3BCD96 * value)
	{
		___projectileObstacleDropdown_5 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___projectileObstacleDropdown_5), (void*)value);
	}
};


// AllIn1VfxToolkit.Demo.Scripts.All1DemoSceneColor
struct All1DemoSceneColor_t88AAEE683C473BDFBB9BDB8A0390F9F981928A09  : public MonoBehaviour_t37A501200D970A8257124B0EAE00A0FF3DDC354A
{
public:
	// UnityEngine.Color[] AllIn1VfxToolkit.Demo.Scripts.All1DemoSceneColor::sceneColors
	ColorU5BU5D_t358DD89F511301E663AD9157305B94A2DEFF8834* ___sceneColors_4;
	// UnityEngine.Camera AllIn1VfxToolkit.Demo.Scripts.All1DemoSceneColor::targetCamera
	Camera_tC44E094BAB53AFC8A014C6F9CFCE11F4FC38006C * ___targetCamera_5;
	// System.Single AllIn1VfxToolkit.Demo.Scripts.All1DemoSceneColor::cameraColorMult
	float ___cameraColorMult_6;
	// UnityEngine.MeshRenderer AllIn1VfxToolkit.Demo.Scripts.All1DemoSceneColor::floorMeshRenderer
	MeshRenderer_tCD983A2F635E12BCB0BAA2E635D96A318757908B * ___floorMeshRenderer_7;
	// System.Single AllIn1VfxToolkit.Demo.Scripts.All1DemoSceneColor::floorColorMult
	float ___floorColorMult_8;
	// System.Single AllIn1VfxToolkit.Demo.Scripts.All1DemoSceneColor::fogColorMult
	float ___fogColorMult_9;
	// UnityEngine.UI.Dropdown AllIn1VfxToolkit.Demo.Scripts.All1DemoSceneColor::sceneColorDropdown
	Dropdown_t099F5232BB75810BC79EED6E27DDCED46C3BCD96 * ___sceneColorDropdown_10;
	// UnityEngine.Material AllIn1VfxToolkit.Demo.Scripts.All1DemoSceneColor::floorMaterial
	Material_t8927C00353A72755313F046D0CE85178AE8218EE * ___floorMaterial_11;

public:
	inline static int32_t get_offset_of_sceneColors_4() { return static_cast<int32_t>(offsetof(All1DemoSceneColor_t88AAEE683C473BDFBB9BDB8A0390F9F981928A09, ___sceneColors_4)); }
	inline ColorU5BU5D_t358DD89F511301E663AD9157305B94A2DEFF8834* get_sceneColors_4() const { return ___sceneColors_4; }
	inline ColorU5BU5D_t358DD89F511301E663AD9157305B94A2DEFF8834** get_address_of_sceneColors_4() { return &___sceneColors_4; }
	inline void set_sceneColors_4(ColorU5BU5D_t358DD89F511301E663AD9157305B94A2DEFF8834* value)
	{
		___sceneColors_4 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___sceneColors_4), (void*)value);
	}

	inline static int32_t get_offset_of_targetCamera_5() { return static_cast<int32_t>(offsetof(All1DemoSceneColor_t88AAEE683C473BDFBB9BDB8A0390F9F981928A09, ___targetCamera_5)); }
	inline Camera_tC44E094BAB53AFC8A014C6F9CFCE11F4FC38006C * get_targetCamera_5() const { return ___targetCamera_5; }
	inline Camera_tC44E094BAB53AFC8A014C6F9CFCE11F4FC38006C ** get_address_of_targetCamera_5() { return &___targetCamera_5; }
	inline void set_targetCamera_5(Camera_tC44E094BAB53AFC8A014C6F9CFCE11F4FC38006C * value)
	{
		___targetCamera_5 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___targetCamera_5), (void*)value);
	}

	inline static int32_t get_offset_of_cameraColorMult_6() { return static_cast<int32_t>(offsetof(All1DemoSceneColor_t88AAEE683C473BDFBB9BDB8A0390F9F981928A09, ___cameraColorMult_6)); }
	inline float get_cameraColorMult_6() const { return ___cameraColorMult_6; }
	inline float* get_address_of_cameraColorMult_6() { return &___cameraColorMult_6; }
	inline void set_cameraColorMult_6(float value)
	{
		___cameraColorMult_6 = value;
	}

	inline static int32_t get_offset_of_floorMeshRenderer_7() { return static_cast<int32_t>(offsetof(All1DemoSceneColor_t88AAEE683C473BDFBB9BDB8A0390F9F981928A09, ___floorMeshRenderer_7)); }
	inline MeshRenderer_tCD983A2F635E12BCB0BAA2E635D96A318757908B * get_floorMeshRenderer_7() const { return ___floorMeshRenderer_7; }
	inline MeshRenderer_tCD983A2F635E12BCB0BAA2E635D96A318757908B ** get_address_of_floorMeshRenderer_7() { return &___floorMeshRenderer_7; }
	inline void set_floorMeshRenderer_7(MeshRenderer_tCD983A2F635E12BCB0BAA2E635D96A318757908B * value)
	{
		___floorMeshRenderer_7 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___floorMeshRenderer_7), (void*)value);
	}

	inline static int32_t get_offset_of_floorColorMult_8() { return static_cast<int32_t>(offsetof(All1DemoSceneColor_t88AAEE683C473BDFBB9BDB8A0390F9F981928A09, ___floorColorMult_8)); }
	inline float get_floorColorMult_8() const { return ___floorColorMult_8; }
	inline float* get_address_of_floorColorMult_8() { return &___floorColorMult_8; }
	inline void set_floorColorMult_8(float value)
	{
		___floorColorMult_8 = value;
	}

	inline static int32_t get_offset_of_fogColorMult_9() { return static_cast<int32_t>(offsetof(All1DemoSceneColor_t88AAEE683C473BDFBB9BDB8A0390F9F981928A09, ___fogColorMult_9)); }
	inline float get_fogColorMult_9() const { return ___fogColorMult_9; }
	inline float* get_address_of_fogColorMult_9() { return &___fogColorMult_9; }
	inline void set_fogColorMult_9(float value)
	{
		___fogColorMult_9 = value;
	}

	inline static int32_t get_offset_of_sceneColorDropdown_10() { return static_cast<int32_t>(offsetof(All1DemoSceneColor_t88AAEE683C473BDFBB9BDB8A0390F9F981928A09, ___sceneColorDropdown_10)); }
	inline Dropdown_t099F5232BB75810BC79EED6E27DDCED46C3BCD96 * get_sceneColorDropdown_10() const { return ___sceneColorDropdown_10; }
	inline Dropdown_t099F5232BB75810BC79EED6E27DDCED46C3BCD96 ** get_address_of_sceneColorDropdown_10() { return &___sceneColorDropdown_10; }
	inline void set_sceneColorDropdown_10(Dropdown_t099F5232BB75810BC79EED6E27DDCED46C3BCD96 * value)
	{
		___sceneColorDropdown_10 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___sceneColorDropdown_10), (void*)value);
	}

	inline static int32_t get_offset_of_floorMaterial_11() { return static_cast<int32_t>(offsetof(All1DemoSceneColor_t88AAEE683C473BDFBB9BDB8A0390F9F981928A09, ___floorMaterial_11)); }
	inline Material_t8927C00353A72755313F046D0CE85178AE8218EE * get_floorMaterial_11() const { return ___floorMaterial_11; }
	inline Material_t8927C00353A72755313F046D0CE85178AE8218EE ** get_address_of_floorMaterial_11() { return &___floorMaterial_11; }
	inline void set_floorMaterial_11(Material_t8927C00353A72755313F046D0CE85178AE8218EE * value)
	{
		___floorMaterial_11 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___floorMaterial_11), (void*)value);
	}
};


// AllIn1VfxToolkit.Demo.Scripts.AllIn1AutoRotate
struct AllIn1AutoRotate_t85B144A09CA74C1EAE0DD3FE1CE5DFC4518CE80F  : public MonoBehaviour_t37A501200D970A8257124B0EAE00A0FF3DDC354A
{
public:
	// System.Single AllIn1VfxToolkit.Demo.Scripts.AllIn1AutoRotate::rotationSpeed
	float ___rotationSpeed_4;
	// UnityEngine.Vector3 AllIn1VfxToolkit.Demo.Scripts.AllIn1AutoRotate::rotationAxis
	Vector3_t65B972D6A585A0A5B63153CF1177A90D3C90D65E  ___rotationAxis_5;

public:
	inline static int32_t get_offset_of_rotationSpeed_4() { return static_cast<int32_t>(offsetof(AllIn1AutoRotate_t85B144A09CA74C1EAE0DD3FE1CE5DFC4518CE80F, ___rotationSpeed_4)); }
	inline float get_rotationSpeed_4() const { return ___rotationSpeed_4; }
	inline float* get_address_of_rotationSpeed_4() { return &___rotationSpeed_4; }
	inline void set_rotationSpeed_4(float value)
	{
		___rotationSpeed_4 = value;
	}

	inline static int32_t get_offset_of_rotationAxis_5() { return static_cast<int32_t>(offsetof(AllIn1AutoRotate_t85B144A09CA74C1EAE0DD3FE1CE5DFC4518CE80F, ___rotationAxis_5)); }
	inline Vector3_t65B972D6A585A0A5B63153CF1177A90D3C90D65E  get_rotationAxis_5() const { return ___rotationAxis_5; }
	inline Vector3_t65B972D6A585A0A5B63153CF1177A90D3C90D65E * get_address_of_rotationAxis_5() { return &___rotationAxis_5; }
	inline void set_rotationAxis_5(Vector3_t65B972D6A585A0A5B63153CF1177A90D3C90D65E  value)
	{
		___rotationAxis_5 = value;
	}
};


// AllIn1VfxToolkit.Demo.Scripts.AllIn1CanvasFader
struct AllIn1CanvasFader_tB4AA563ED5CFF1F6FC9B974944AA53A94532162A  : public MonoBehaviour_t37A501200D970A8257124B0EAE00A0FF3DDC354A
{
public:
	// UnityEngine.KeyCode AllIn1VfxToolkit.Demo.Scripts.AllIn1CanvasFader::fadeToggleKey
	int32_t ___fadeToggleKey_4;
	// System.Single AllIn1VfxToolkit.Demo.Scripts.AllIn1CanvasFader::tweenSpeed
	float ___tweenSpeed_5;
	// AllIn1VfxToolkit.Demo.Scripts.AllIn1DemoScaleTween AllIn1VfxToolkit.Demo.Scripts.AllIn1CanvasFader::hideUiButtonTween
	AllIn1DemoScaleTween_t513A5592D7B99AAE00D3C297524793A01504CCD0 * ___hideUiButtonTween_6;
	// System.Boolean AllIn1VfxToolkit.Demo.Scripts.AllIn1CanvasFader::isTweening
	bool ___isTweening_7;
	// System.Single AllIn1VfxToolkit.Demo.Scripts.AllIn1CanvasFader::currentAlpha
	float ___currentAlpha_8;
	// System.Single AllIn1VfxToolkit.Demo.Scripts.AllIn1CanvasFader::targetAlpha
	float ___targetAlpha_9;
	// UnityEngine.CanvasGroup AllIn1VfxToolkit.Demo.Scripts.AllIn1CanvasFader::canvasGroup
	CanvasGroup_t6912220105AB4A288A2FD882D163D7218EAA577F * ___canvasGroup_10;
	// System.Boolean AllIn1VfxToolkit.Demo.Scripts.AllIn1CanvasFader::hideUiButtonTweenNotNull
	bool ___hideUiButtonTweenNotNull_11;

public:
	inline static int32_t get_offset_of_fadeToggleKey_4() { return static_cast<int32_t>(offsetof(AllIn1CanvasFader_tB4AA563ED5CFF1F6FC9B974944AA53A94532162A, ___fadeToggleKey_4)); }
	inline int32_t get_fadeToggleKey_4() const { return ___fadeToggleKey_4; }
	inline int32_t* get_address_of_fadeToggleKey_4() { return &___fadeToggleKey_4; }
	inline void set_fadeToggleKey_4(int32_t value)
	{
		___fadeToggleKey_4 = value;
	}

	inline static int32_t get_offset_of_tweenSpeed_5() { return static_cast<int32_t>(offsetof(AllIn1CanvasFader_tB4AA563ED5CFF1F6FC9B974944AA53A94532162A, ___tweenSpeed_5)); }
	inline float get_tweenSpeed_5() const { return ___tweenSpeed_5; }
	inline float* get_address_of_tweenSpeed_5() { return &___tweenSpeed_5; }
	inline void set_tweenSpeed_5(float value)
	{
		___tweenSpeed_5 = value;
	}

	inline static int32_t get_offset_of_hideUiButtonTween_6() { return static_cast<int32_t>(offsetof(AllIn1CanvasFader_tB4AA563ED5CFF1F6FC9B974944AA53A94532162A, ___hideUiButtonTween_6)); }
	inline AllIn1DemoScaleTween_t513A5592D7B99AAE00D3C297524793A01504CCD0 * get_hideUiButtonTween_6() const { return ___hideUiButtonTween_6; }
	inline AllIn1DemoScaleTween_t513A5592D7B99AAE00D3C297524793A01504CCD0 ** get_address_of_hideUiButtonTween_6() { return &___hideUiButtonTween_6; }
	inline void set_hideUiButtonTween_6(AllIn1DemoScaleTween_t513A5592D7B99AAE00D3C297524793A01504CCD0 * value)
	{
		___hideUiButtonTween_6 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___hideUiButtonTween_6), (void*)value);
	}

	inline static int32_t get_offset_of_isTweening_7() { return static_cast<int32_t>(offsetof(AllIn1CanvasFader_tB4AA563ED5CFF1F6FC9B974944AA53A94532162A, ___isTweening_7)); }
	inline bool get_isTweening_7() const { return ___isTweening_7; }
	inline bool* get_address_of_isTweening_7() { return &___isTweening_7; }
	inline void set_isTweening_7(bool value)
	{
		___isTweening_7 = value;
	}

	inline static int32_t get_offset_of_currentAlpha_8() { return static_cast<int32_t>(offsetof(AllIn1CanvasFader_tB4AA563ED5CFF1F6FC9B974944AA53A94532162A, ___currentAlpha_8)); }
	inline float get_currentAlpha_8() const { return ___currentAlpha_8; }
	inline float* get_address_of_currentAlpha_8() { return &___currentAlpha_8; }
	inline void set_currentAlpha_8(float value)
	{
		___currentAlpha_8 = value;
	}

	inline static int32_t get_offset_of_targetAlpha_9() { return static_cast<int32_t>(offsetof(AllIn1CanvasFader_tB4AA563ED5CFF1F6FC9B974944AA53A94532162A, ___targetAlpha_9)); }
	inline float get_targetAlpha_9() const { return ___targetAlpha_9; }
	inline float* get_address_of_targetAlpha_9() { return &___targetAlpha_9; }
	inline void set_targetAlpha_9(float value)
	{
		___targetAlpha_9 = value;
	}

	inline static int32_t get_offset_of_canvasGroup_10() { return static_cast<int32_t>(offsetof(AllIn1CanvasFader_tB4AA563ED5CFF1F6FC9B974944AA53A94532162A, ___canvasGroup_10)); }
	inline CanvasGroup_t6912220105AB4A288A2FD882D163D7218EAA577F * get_canvasGroup_10() const { return ___canvasGroup_10; }
	inline CanvasGroup_t6912220105AB4A288A2FD882D163D7218EAA577F ** get_address_of_canvasGroup_10() { return &___canvasGroup_10; }
	inline void set_canvasGroup_10(CanvasGroup_t6912220105AB4A288A2FD882D163D7218EAA577F * value)
	{
		___canvasGroup_10 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___canvasGroup_10), (void*)value);
	}

	inline static int32_t get_offset_of_hideUiButtonTweenNotNull_11() { return static_cast<int32_t>(offsetof(AllIn1CanvasFader_tB4AA563ED5CFF1F6FC9B974944AA53A94532162A, ___hideUiButtonTweenNotNull_11)); }
	inline bool get_hideUiButtonTweenNotNull_11() const { return ___hideUiButtonTweenNotNull_11; }
	inline bool* get_address_of_hideUiButtonTweenNotNull_11() { return &___hideUiButtonTweenNotNull_11; }
	inline void set_hideUiButtonTweenNotNull_11(bool value)
	{
		___hideUiButtonTweenNotNull_11 = value;
	}
};


// AllIn1VfxToolkit.Demo.Scripts.AllIn1ChangeAllChildTextFonts
struct AllIn1ChangeAllChildTextFonts_t11C8807E2A6936E92C06EFAD7E046BE279C4E433  : public MonoBehaviour_t37A501200D970A8257124B0EAE00A0FF3DDC354A
{
public:
	// UnityEngine.Font AllIn1VfxToolkit.Demo.Scripts.AllIn1ChangeAllChildTextFonts::newFont
	Font_tB53D3F362CB1A0B92307B362826F212AE2D2A6A9 * ___newFont_4;
	// System.Boolean AllIn1VfxToolkit.Demo.Scripts.AllIn1ChangeAllChildTextFonts::changeFontOnStart
	bool ___changeFontOnStart_5;

public:
	inline static int32_t get_offset_of_newFont_4() { return static_cast<int32_t>(offsetof(AllIn1ChangeAllChildTextFonts_t11C8807E2A6936E92C06EFAD7E046BE279C4E433, ___newFont_4)); }
	inline Font_tB53D3F362CB1A0B92307B362826F212AE2D2A6A9 * get_newFont_4() const { return ___newFont_4; }
	inline Font_tB53D3F362CB1A0B92307B362826F212AE2D2A6A9 ** get_address_of_newFont_4() { return &___newFont_4; }
	inline void set_newFont_4(Font_tB53D3F362CB1A0B92307B362826F212AE2D2A6A9 * value)
	{
		___newFont_4 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___newFont_4), (void*)value);
	}

	inline static int32_t get_offset_of_changeFontOnStart_5() { return static_cast<int32_t>(offsetof(AllIn1ChangeAllChildTextFonts_t11C8807E2A6936E92C06EFAD7E046BE279C4E433, ___changeFontOnStart_5)); }
	inline bool get_changeFontOnStart_5() const { return ___changeFontOnStart_5; }
	inline bool* get_address_of_changeFontOnStart_5() { return &___changeFontOnStart_5; }
	inline void set_changeFontOnStart_5(bool value)
	{
		___changeFontOnStart_5 = value;
	}
};


// AllIn1VfxToolkit.Demo.Scripts.AllIn1DemoProjectile
struct AllIn1DemoProjectile_tA36F8B6BF3163732D0C981065AF301449C4AAE69  : public MonoBehaviour_t37A501200D970A8257124B0EAE00A0FF3DDC354A
{
public:
	// System.Single AllIn1VfxToolkit.Demo.Scripts.AllIn1DemoProjectile::inaccurateAmount
	float ___inaccurateAmount_4;
	// UnityEngine.GameObject AllIn1VfxToolkit.Demo.Scripts.AllIn1DemoProjectile::currentImpactPrefab
	GameObject_tC000A2E1A7CF1E10FD7BA08863287C072207C319 * ___currentImpactPrefab_5;
	// UnityEngine.Transform AllIn1VfxToolkit.Demo.Scripts.AllIn1DemoProjectile::currentHierarchyParent
	Transform_tA8193BB29D4D2C7EC04918F3ED1816345186C3F1 * ___currentHierarchyParent_6;
	// System.Boolean AllIn1VfxToolkit.Demo.Scripts.AllIn1DemoProjectile::doImpactSpawn
	bool ___doImpactSpawn_7;
	// System.Boolean AllIn1VfxToolkit.Demo.Scripts.AllIn1DemoProjectile::doShake
	bool ___doShake_8;
	// System.Single AllIn1VfxToolkit.Demo.Scripts.AllIn1DemoProjectile::shakeAmountOnImpact
	float ___shakeAmountOnImpact_9;
	// System.Single AllIn1VfxToolkit.Demo.Scripts.AllIn1DemoProjectile::impactScaleSize
	float ___impactScaleSize_10;

public:
	inline static int32_t get_offset_of_inaccurateAmount_4() { return static_cast<int32_t>(offsetof(AllIn1DemoProjectile_tA36F8B6BF3163732D0C981065AF301449C4AAE69, ___inaccurateAmount_4)); }
	inline float get_inaccurateAmount_4() const { return ___inaccurateAmount_4; }
	inline float* get_address_of_inaccurateAmount_4() { return &___inaccurateAmount_4; }
	inline void set_inaccurateAmount_4(float value)
	{
		___inaccurateAmount_4 = value;
	}

	inline static int32_t get_offset_of_currentImpactPrefab_5() { return static_cast<int32_t>(offsetof(AllIn1DemoProjectile_tA36F8B6BF3163732D0C981065AF301449C4AAE69, ___currentImpactPrefab_5)); }
	inline GameObject_tC000A2E1A7CF1E10FD7BA08863287C072207C319 * get_currentImpactPrefab_5() const { return ___currentImpactPrefab_5; }
	inline GameObject_tC000A2E1A7CF1E10FD7BA08863287C072207C319 ** get_address_of_currentImpactPrefab_5() { return &___currentImpactPrefab_5; }
	inline void set_currentImpactPrefab_5(GameObject_tC000A2E1A7CF1E10FD7BA08863287C072207C319 * value)
	{
		___currentImpactPrefab_5 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___currentImpactPrefab_5), (void*)value);
	}

	inline static int32_t get_offset_of_currentHierarchyParent_6() { return static_cast<int32_t>(offsetof(AllIn1DemoProjectile_tA36F8B6BF3163732D0C981065AF301449C4AAE69, ___currentHierarchyParent_6)); }
	inline Transform_tA8193BB29D4D2C7EC04918F3ED1816345186C3F1 * get_currentHierarchyParent_6() const { return ___currentHierarchyParent_6; }
	inline Transform_tA8193BB29D4D2C7EC04918F3ED1816345186C3F1 ** get_address_of_currentHierarchyParent_6() { return &___currentHierarchyParent_6; }
	inline void set_currentHierarchyParent_6(Transform_tA8193BB29D4D2C7EC04918F3ED1816345186C3F1 * value)
	{
		___currentHierarchyParent_6 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___currentHierarchyParent_6), (void*)value);
	}

	inline static int32_t get_offset_of_doImpactSpawn_7() { return static_cast<int32_t>(offsetof(AllIn1DemoProjectile_tA36F8B6BF3163732D0C981065AF301449C4AAE69, ___doImpactSpawn_7)); }
	inline bool get_doImpactSpawn_7() const { return ___doImpactSpawn_7; }
	inline bool* get_address_of_doImpactSpawn_7() { return &___doImpactSpawn_7; }
	inline void set_doImpactSpawn_7(bool value)
	{
		___doImpactSpawn_7 = value;
	}

	inline static int32_t get_offset_of_doShake_8() { return static_cast<int32_t>(offsetof(AllIn1DemoProjectile_tA36F8B6BF3163732D0C981065AF301449C4AAE69, ___doShake_8)); }
	inline bool get_doShake_8() const { return ___doShake_8; }
	inline bool* get_address_of_doShake_8() { return &___doShake_8; }
	inline void set_doShake_8(bool value)
	{
		___doShake_8 = value;
	}

	inline static int32_t get_offset_of_shakeAmountOnImpact_9() { return static_cast<int32_t>(offsetof(AllIn1DemoProjectile_tA36F8B6BF3163732D0C981065AF301449C4AAE69, ___shakeAmountOnImpact_9)); }
	inline float get_shakeAmountOnImpact_9() const { return ___shakeAmountOnImpact_9; }
	inline float* get_address_of_shakeAmountOnImpact_9() { return &___shakeAmountOnImpact_9; }
	inline void set_shakeAmountOnImpact_9(float value)
	{
		___shakeAmountOnImpact_9 = value;
	}

	inline static int32_t get_offset_of_impactScaleSize_10() { return static_cast<int32_t>(offsetof(AllIn1DemoProjectile_tA36F8B6BF3163732D0C981065AF301449C4AAE69, ___impactScaleSize_10)); }
	inline float get_impactScaleSize_10() const { return ___impactScaleSize_10; }
	inline float* get_address_of_impactScaleSize_10() { return &___impactScaleSize_10; }
	inline void set_impactScaleSize_10(float value)
	{
		___impactScaleSize_10 = value;
	}
};


// AllIn1VfxToolkit.Demo.Scripts.AllIn1DemoScaleTween
struct AllIn1DemoScaleTween_t513A5592D7B99AAE00D3C297524793A01504CCD0  : public MonoBehaviour_t37A501200D970A8257124B0EAE00A0FF3DDC354A
{
public:
	// System.Single AllIn1VfxToolkit.Demo.Scripts.AllIn1DemoScaleTween::maxTweenScale
	float ___maxTweenScale_4;
	// System.Single AllIn1VfxToolkit.Demo.Scripts.AllIn1DemoScaleTween::minTweenScale
	float ___minTweenScale_5;
	// System.Single AllIn1VfxToolkit.Demo.Scripts.AllIn1DemoScaleTween::tweenSpeed
	float ___tweenSpeed_6;
	// System.Boolean AllIn1VfxToolkit.Demo.Scripts.AllIn1DemoScaleTween::isTweening
	bool ___isTweening_7;
	// System.Single AllIn1VfxToolkit.Demo.Scripts.AllIn1DemoScaleTween::currentScale
	float ___currentScale_8;
	// UnityEngine.Vector3 AllIn1VfxToolkit.Demo.Scripts.AllIn1DemoScaleTween::scaleToApply
	Vector3_t65B972D6A585A0A5B63153CF1177A90D3C90D65E  ___scaleToApply_9;

public:
	inline static int32_t get_offset_of_maxTweenScale_4() { return static_cast<int32_t>(offsetof(AllIn1DemoScaleTween_t513A5592D7B99AAE00D3C297524793A01504CCD0, ___maxTweenScale_4)); }
	inline float get_maxTweenScale_4() const { return ___maxTweenScale_4; }
	inline float* get_address_of_maxTweenScale_4() { return &___maxTweenScale_4; }
	inline void set_maxTweenScale_4(float value)
	{
		___maxTweenScale_4 = value;
	}

	inline static int32_t get_offset_of_minTweenScale_5() { return static_cast<int32_t>(offsetof(AllIn1DemoScaleTween_t513A5592D7B99AAE00D3C297524793A01504CCD0, ___minTweenScale_5)); }
	inline float get_minTweenScale_5() const { return ___minTweenScale_5; }
	inline float* get_address_of_minTweenScale_5() { return &___minTweenScale_5; }
	inline void set_minTweenScale_5(float value)
	{
		___minTweenScale_5 = value;
	}

	inline static int32_t get_offset_of_tweenSpeed_6() { return static_cast<int32_t>(offsetof(AllIn1DemoScaleTween_t513A5592D7B99AAE00D3C297524793A01504CCD0, ___tweenSpeed_6)); }
	inline float get_tweenSpeed_6() const { return ___tweenSpeed_6; }
	inline float* get_address_of_tweenSpeed_6() { return &___tweenSpeed_6; }
	inline void set_tweenSpeed_6(float value)
	{
		___tweenSpeed_6 = value;
	}

	inline static int32_t get_offset_of_isTweening_7() { return static_cast<int32_t>(offsetof(AllIn1DemoScaleTween_t513A5592D7B99AAE00D3C297524793A01504CCD0, ___isTweening_7)); }
	inline bool get_isTweening_7() const { return ___isTweening_7; }
	inline bool* get_address_of_isTweening_7() { return &___isTweening_7; }
	inline void set_isTweening_7(bool value)
	{
		___isTweening_7 = value;
	}

	inline static int32_t get_offset_of_currentScale_8() { return static_cast<int32_t>(offsetof(AllIn1DemoScaleTween_t513A5592D7B99AAE00D3C297524793A01504CCD0, ___currentScale_8)); }
	inline float get_currentScale_8() const { return ___currentScale_8; }
	inline float* get_address_of_currentScale_8() { return &___currentScale_8; }
	inline void set_currentScale_8(float value)
	{
		___currentScale_8 = value;
	}

	inline static int32_t get_offset_of_scaleToApply_9() { return static_cast<int32_t>(offsetof(AllIn1DemoScaleTween_t513A5592D7B99AAE00D3C297524793A01504CCD0, ___scaleToApply_9)); }
	inline Vector3_t65B972D6A585A0A5B63153CF1177A90D3C90D65E  get_scaleToApply_9() const { return ___scaleToApply_9; }
	inline Vector3_t65B972D6A585A0A5B63153CF1177A90D3C90D65E * get_address_of_scaleToApply_9() { return &___scaleToApply_9; }
	inline void set_scaleToApply_9(Vector3_t65B972D6A585A0A5B63153CF1177A90D3C90D65E  value)
	{
		___scaleToApply_9 = value;
	}
};


// AllIn1VfxToolkit.Demo.Scripts.AllIn1DoShake
struct AllIn1DoShake_t4AC8F2F9DF4B14734088C6754E9692F1B74275B1  : public MonoBehaviour_t37A501200D970A8257124B0EAE00A0FF3DDC354A
{
public:
	// System.Single AllIn1VfxToolkit.Demo.Scripts.AllIn1DoShake::shakeAmount
	float ___shakeAmount_4;
	// System.Boolean AllIn1VfxToolkit.Demo.Scripts.AllIn1DoShake::doShakeOnStart
	bool ___doShakeOnStart_5;
	// System.Single AllIn1VfxToolkit.Demo.Scripts.AllIn1DoShake::shakeOnStartDelay
	float ___shakeOnStartDelay_6;

public:
	inline static int32_t get_offset_of_shakeAmount_4() { return static_cast<int32_t>(offsetof(AllIn1DoShake_t4AC8F2F9DF4B14734088C6754E9692F1B74275B1, ___shakeAmount_4)); }
	inline float get_shakeAmount_4() const { return ___shakeAmount_4; }
	inline float* get_address_of_shakeAmount_4() { return &___shakeAmount_4; }
	inline void set_shakeAmount_4(float value)
	{
		___shakeAmount_4 = value;
	}

	inline static int32_t get_offset_of_doShakeOnStart_5() { return static_cast<int32_t>(offsetof(AllIn1DoShake_t4AC8F2F9DF4B14734088C6754E9692F1B74275B1, ___doShakeOnStart_5)); }
	inline bool get_doShakeOnStart_5() const { return ___doShakeOnStart_5; }
	inline bool* get_address_of_doShakeOnStart_5() { return &___doShakeOnStart_5; }
	inline void set_doShakeOnStart_5(bool value)
	{
		___doShakeOnStart_5 = value;
	}

	inline static int32_t get_offset_of_shakeOnStartDelay_6() { return static_cast<int32_t>(offsetof(AllIn1DoShake_t4AC8F2F9DF4B14734088C6754E9692F1B74275B1, ___shakeOnStartDelay_6)); }
	inline float get_shakeOnStartDelay_6() const { return ___shakeOnStartDelay_6; }
	inline float* get_address_of_shakeOnStartDelay_6() { return &___shakeOnStartDelay_6; }
	inline void set_shakeOnStartDelay_6(float value)
	{
		___shakeOnStartDelay_6 = value;
	}
};


// AllIn1VfxToolkit.Demo.Scripts.AllIn1MouseRotate
struct AllIn1MouseRotate_t83F7508F651802AEF83D151F967CBEA41AEF7935  : public MonoBehaviour_t37A501200D970A8257124B0EAE00A0FF3DDC354A
{
public:
	// UnityEngine.Transform AllIn1VfxToolkit.Demo.Scripts.AllIn1MouseRotate::objectToRotate
	Transform_tA8193BB29D4D2C7EC04918F3ED1816345186C3F1 * ___objectToRotate_4;
	// System.Single AllIn1VfxToolkit.Demo.Scripts.AllIn1MouseRotate::rotationSpeedHorizontal
	float ___rotationSpeedHorizontal_5;
	// System.Single AllIn1VfxToolkit.Demo.Scripts.AllIn1MouseRotate::translateVerticalSpeed
	float ___translateVerticalSpeed_6;
	// System.Single AllIn1VfxToolkit.Demo.Scripts.AllIn1MouseRotate::translateScrollSpeed
	float ___translateScrollSpeed_7;
	// System.Boolean AllIn1VfxToolkit.Demo.Scripts.AllIn1MouseRotate::lockCursor
	bool ___lockCursor_8;
	// UnityEngine.KeyCode AllIn1VfxToolkit.Demo.Scripts.AllIn1MouseRotate::lockCursorKeyCode
	int32_t ___lockCursorKeyCode_9;
	// AllIn1VfxToolkit.Demo.Scripts.AllIn1DemoScaleTween AllIn1VfxToolkit.Demo.Scripts.AllIn1MouseRotate::hideUiButtonTween
	AllIn1DemoScaleTween_t513A5592D7B99AAE00D3C297524793A01504CCD0 * ___hideUiButtonTween_10;
	// UnityEngine.UI.Image AllIn1VfxToolkit.Demo.Scripts.AllIn1MouseRotate::lockedButtonImage
	Image_t4021FF27176E44BFEDDCBE43C7FE6B713EC70D3C * ___lockedButtonImage_11;
	// UnityEngine.UI.Text AllIn1VfxToolkit.Demo.Scripts.AllIn1MouseRotate::lockedButtonText
	Text_t6A2339DA6C05AE2646FC1A6C8FCC127391BE7FA1 * ___lockedButtonText_12;
	// UnityEngine.Color AllIn1VfxToolkit.Demo.Scripts.AllIn1MouseRotate::lockedButtonColor
	Color_tF40DAF76C04FFECF3FE6024F85A294741C9CC659  ___lockedButtonColor_13;
	// System.Boolean AllIn1VfxToolkit.Demo.Scripts.AllIn1MouseRotate::cursorIsLocked
	bool ___cursorIsLocked_14;
	// System.Single AllIn1VfxToolkit.Demo.Scripts.AllIn1MouseRotate::maxHeight
	float ___maxHeight_15;
	// System.Single AllIn1VfxToolkit.Demo.Scripts.AllIn1MouseRotate::maxZoom
	float ___maxZoom_16;
	// System.Single AllIn1VfxToolkit.Demo.Scripts.AllIn1MouseRotate::minZoom
	float ___minZoom_17;
	// UnityEngine.Vector3 AllIn1VfxToolkit.Demo.Scripts.AllIn1MouseRotate::currPosition
	Vector3_t65B972D6A585A0A5B63153CF1177A90D3C90D65E  ___currPosition_18;
	// System.Single AllIn1VfxToolkit.Demo.Scripts.AllIn1MouseRotate::dt
	float ___dt_19;

public:
	inline static int32_t get_offset_of_objectToRotate_4() { return static_cast<int32_t>(offsetof(AllIn1MouseRotate_t83F7508F651802AEF83D151F967CBEA41AEF7935, ___objectToRotate_4)); }
	inline Transform_tA8193BB29D4D2C7EC04918F3ED1816345186C3F1 * get_objectToRotate_4() const { return ___objectToRotate_4; }
	inline Transform_tA8193BB29D4D2C7EC04918F3ED1816345186C3F1 ** get_address_of_objectToRotate_4() { return &___objectToRotate_4; }
	inline void set_objectToRotate_4(Transform_tA8193BB29D4D2C7EC04918F3ED1816345186C3F1 * value)
	{
		___objectToRotate_4 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___objectToRotate_4), (void*)value);
	}

	inline static int32_t get_offset_of_rotationSpeedHorizontal_5() { return static_cast<int32_t>(offsetof(AllIn1MouseRotate_t83F7508F651802AEF83D151F967CBEA41AEF7935, ___rotationSpeedHorizontal_5)); }
	inline float get_rotationSpeedHorizontal_5() const { return ___rotationSpeedHorizontal_5; }
	inline float* get_address_of_rotationSpeedHorizontal_5() { return &___rotationSpeedHorizontal_5; }
	inline void set_rotationSpeedHorizontal_5(float value)
	{
		___rotationSpeedHorizontal_5 = value;
	}

	inline static int32_t get_offset_of_translateVerticalSpeed_6() { return static_cast<int32_t>(offsetof(AllIn1MouseRotate_t83F7508F651802AEF83D151F967CBEA41AEF7935, ___translateVerticalSpeed_6)); }
	inline float get_translateVerticalSpeed_6() const { return ___translateVerticalSpeed_6; }
	inline float* get_address_of_translateVerticalSpeed_6() { return &___translateVerticalSpeed_6; }
	inline void set_translateVerticalSpeed_6(float value)
	{
		___translateVerticalSpeed_6 = value;
	}

	inline static int32_t get_offset_of_translateScrollSpeed_7() { return static_cast<int32_t>(offsetof(AllIn1MouseRotate_t83F7508F651802AEF83D151F967CBEA41AEF7935, ___translateScrollSpeed_7)); }
	inline float get_translateScrollSpeed_7() const { return ___translateScrollSpeed_7; }
	inline float* get_address_of_translateScrollSpeed_7() { return &___translateScrollSpeed_7; }
	inline void set_translateScrollSpeed_7(float value)
	{
		___translateScrollSpeed_7 = value;
	}

	inline static int32_t get_offset_of_lockCursor_8() { return static_cast<int32_t>(offsetof(AllIn1MouseRotate_t83F7508F651802AEF83D151F967CBEA41AEF7935, ___lockCursor_8)); }
	inline bool get_lockCursor_8() const { return ___lockCursor_8; }
	inline bool* get_address_of_lockCursor_8() { return &___lockCursor_8; }
	inline void set_lockCursor_8(bool value)
	{
		___lockCursor_8 = value;
	}

	inline static int32_t get_offset_of_lockCursorKeyCode_9() { return static_cast<int32_t>(offsetof(AllIn1MouseRotate_t83F7508F651802AEF83D151F967CBEA41AEF7935, ___lockCursorKeyCode_9)); }
	inline int32_t get_lockCursorKeyCode_9() const { return ___lockCursorKeyCode_9; }
	inline int32_t* get_address_of_lockCursorKeyCode_9() { return &___lockCursorKeyCode_9; }
	inline void set_lockCursorKeyCode_9(int32_t value)
	{
		___lockCursorKeyCode_9 = value;
	}

	inline static int32_t get_offset_of_hideUiButtonTween_10() { return static_cast<int32_t>(offsetof(AllIn1MouseRotate_t83F7508F651802AEF83D151F967CBEA41AEF7935, ___hideUiButtonTween_10)); }
	inline AllIn1DemoScaleTween_t513A5592D7B99AAE00D3C297524793A01504CCD0 * get_hideUiButtonTween_10() const { return ___hideUiButtonTween_10; }
	inline AllIn1DemoScaleTween_t513A5592D7B99AAE00D3C297524793A01504CCD0 ** get_address_of_hideUiButtonTween_10() { return &___hideUiButtonTween_10; }
	inline void set_hideUiButtonTween_10(AllIn1DemoScaleTween_t513A5592D7B99AAE00D3C297524793A01504CCD0 * value)
	{
		___hideUiButtonTween_10 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___hideUiButtonTween_10), (void*)value);
	}

	inline static int32_t get_offset_of_lockedButtonImage_11() { return static_cast<int32_t>(offsetof(AllIn1MouseRotate_t83F7508F651802AEF83D151F967CBEA41AEF7935, ___lockedButtonImage_11)); }
	inline Image_t4021FF27176E44BFEDDCBE43C7FE6B713EC70D3C * get_lockedButtonImage_11() const { return ___lockedButtonImage_11; }
	inline Image_t4021FF27176E44BFEDDCBE43C7FE6B713EC70D3C ** get_address_of_lockedButtonImage_11() { return &___lockedButtonImage_11; }
	inline void set_lockedButtonImage_11(Image_t4021FF27176E44BFEDDCBE43C7FE6B713EC70D3C * value)
	{
		___lockedButtonImage_11 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___lockedButtonImage_11), (void*)value);
	}

	inline static int32_t get_offset_of_lockedButtonText_12() { return static_cast<int32_t>(offsetof(AllIn1MouseRotate_t83F7508F651802AEF83D151F967CBEA41AEF7935, ___lockedButtonText_12)); }
	inline Text_t6A2339DA6C05AE2646FC1A6C8FCC127391BE7FA1 * get_lockedButtonText_12() const { return ___lockedButtonText_12; }
	inline Text_t6A2339DA6C05AE2646FC1A6C8FCC127391BE7FA1 ** get_address_of_lockedButtonText_12() { return &___lockedButtonText_12; }
	inline void set_lockedButtonText_12(Text_t6A2339DA6C05AE2646FC1A6C8FCC127391BE7FA1 * value)
	{
		___lockedButtonText_12 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___lockedButtonText_12), (void*)value);
	}

	inline static int32_t get_offset_of_lockedButtonColor_13() { return static_cast<int32_t>(offsetof(AllIn1MouseRotate_t83F7508F651802AEF83D151F967CBEA41AEF7935, ___lockedButtonColor_13)); }
	inline Color_tF40DAF76C04FFECF3FE6024F85A294741C9CC659  get_lockedButtonColor_13() const { return ___lockedButtonColor_13; }
	inline Color_tF40DAF76C04FFECF3FE6024F85A294741C9CC659 * get_address_of_lockedButtonColor_13() { return &___lockedButtonColor_13; }
	inline void set_lockedButtonColor_13(Color_tF40DAF76C04FFECF3FE6024F85A294741C9CC659  value)
	{
		___lockedButtonColor_13 = value;
	}

	inline static int32_t get_offset_of_cursorIsLocked_14() { return static_cast<int32_t>(offsetof(AllIn1MouseRotate_t83F7508F651802AEF83D151F967CBEA41AEF7935, ___cursorIsLocked_14)); }
	inline bool get_cursorIsLocked_14() const { return ___cursorIsLocked_14; }
	inline bool* get_address_of_cursorIsLocked_14() { return &___cursorIsLocked_14; }
	inline void set_cursorIsLocked_14(bool value)
	{
		___cursorIsLocked_14 = value;
	}

	inline static int32_t get_offset_of_maxHeight_15() { return static_cast<int32_t>(offsetof(AllIn1MouseRotate_t83F7508F651802AEF83D151F967CBEA41AEF7935, ___maxHeight_15)); }
	inline float get_maxHeight_15() const { return ___maxHeight_15; }
	inline float* get_address_of_maxHeight_15() { return &___maxHeight_15; }
	inline void set_maxHeight_15(float value)
	{
		___maxHeight_15 = value;
	}

	inline static int32_t get_offset_of_maxZoom_16() { return static_cast<int32_t>(offsetof(AllIn1MouseRotate_t83F7508F651802AEF83D151F967CBEA41AEF7935, ___maxZoom_16)); }
	inline float get_maxZoom_16() const { return ___maxZoom_16; }
	inline float* get_address_of_maxZoom_16() { return &___maxZoom_16; }
	inline void set_maxZoom_16(float value)
	{
		___maxZoom_16 = value;
	}

	inline static int32_t get_offset_of_minZoom_17() { return static_cast<int32_t>(offsetof(AllIn1MouseRotate_t83F7508F651802AEF83D151F967CBEA41AEF7935, ___minZoom_17)); }
	inline float get_minZoom_17() const { return ___minZoom_17; }
	inline float* get_address_of_minZoom_17() { return &___minZoom_17; }
	inline void set_minZoom_17(float value)
	{
		___minZoom_17 = value;
	}

	inline static int32_t get_offset_of_currPosition_18() { return static_cast<int32_t>(offsetof(AllIn1MouseRotate_t83F7508F651802AEF83D151F967CBEA41AEF7935, ___currPosition_18)); }
	inline Vector3_t65B972D6A585A0A5B63153CF1177A90D3C90D65E  get_currPosition_18() const { return ___currPosition_18; }
	inline Vector3_t65B972D6A585A0A5B63153CF1177A90D3C90D65E * get_address_of_currPosition_18() { return &___currPosition_18; }
	inline void set_currPosition_18(Vector3_t65B972D6A585A0A5B63153CF1177A90D3C90D65E  value)
	{
		___currPosition_18 = value;
	}

	inline static int32_t get_offset_of_dt_19() { return static_cast<int32_t>(offsetof(AllIn1MouseRotate_t83F7508F651802AEF83D151F967CBEA41AEF7935, ___dt_19)); }
	inline float get_dt_19() const { return ___dt_19; }
	inline float* get_address_of_dt_19() { return &___dt_19; }
	inline void set_dt_19(float value)
	{
		___dt_19 = value;
	}
};


// AllIn1VfxToolkit.Demo.Scripts.AllIn1Shaker
struct AllIn1Shaker_t4540E312EAE72C5A4E5F184AFEC3099E91179295  : public MonoBehaviour_t37A501200D970A8257124B0EAE00A0FF3DDC354A
{
public:
	// UnityEngine.Vector3 AllIn1VfxToolkit.Demo.Scripts.AllIn1Shaker::maximumTranslationShake
	Vector3_t65B972D6A585A0A5B63153CF1177A90D3C90D65E  ___maximumTranslationShake_4;
	// UnityEngine.Vector3 AllIn1VfxToolkit.Demo.Scripts.AllIn1Shaker::maximumAngularShake
	Vector3_t65B972D6A585A0A5B63153CF1177A90D3C90D65E  ___maximumAngularShake_5;
	// System.Single AllIn1VfxToolkit.Demo.Scripts.AllIn1Shaker::shakeFrequency
	float ___shakeFrequency_6;
	// System.Single AllIn1VfxToolkit.Demo.Scripts.AllIn1Shaker::shakeSmoothingExponent
	float ___shakeSmoothingExponent_7;
	// System.Single AllIn1VfxToolkit.Demo.Scripts.AllIn1Shaker::shakeRecoverPerSecond
	float ___shakeRecoverPerSecond_8;
	// System.Single AllIn1VfxToolkit.Demo.Scripts.AllIn1Shaker::currentShakeAmount
	float ___currentShakeAmount_10;
	// System.Single AllIn1VfxToolkit.Demo.Scripts.AllIn1Shaker::seed
	float ___seed_11;

public:
	inline static int32_t get_offset_of_maximumTranslationShake_4() { return static_cast<int32_t>(offsetof(AllIn1Shaker_t4540E312EAE72C5A4E5F184AFEC3099E91179295, ___maximumTranslationShake_4)); }
	inline Vector3_t65B972D6A585A0A5B63153CF1177A90D3C90D65E  get_maximumTranslationShake_4() const { return ___maximumTranslationShake_4; }
	inline Vector3_t65B972D6A585A0A5B63153CF1177A90D3C90D65E * get_address_of_maximumTranslationShake_4() { return &___maximumTranslationShake_4; }
	inline void set_maximumTranslationShake_4(Vector3_t65B972D6A585A0A5B63153CF1177A90D3C90D65E  value)
	{
		___maximumTranslationShake_4 = value;
	}

	inline static int32_t get_offset_of_maximumAngularShake_5() { return static_cast<int32_t>(offsetof(AllIn1Shaker_t4540E312EAE72C5A4E5F184AFEC3099E91179295, ___maximumAngularShake_5)); }
	inline Vector3_t65B972D6A585A0A5B63153CF1177A90D3C90D65E  get_maximumAngularShake_5() const { return ___maximumAngularShake_5; }
	inline Vector3_t65B972D6A585A0A5B63153CF1177A90D3C90D65E * get_address_of_maximumAngularShake_5() { return &___maximumAngularShake_5; }
	inline void set_maximumAngularShake_5(Vector3_t65B972D6A585A0A5B63153CF1177A90D3C90D65E  value)
	{
		___maximumAngularShake_5 = value;
	}

	inline static int32_t get_offset_of_shakeFrequency_6() { return static_cast<int32_t>(offsetof(AllIn1Shaker_t4540E312EAE72C5A4E5F184AFEC3099E91179295, ___shakeFrequency_6)); }
	inline float get_shakeFrequency_6() const { return ___shakeFrequency_6; }
	inline float* get_address_of_shakeFrequency_6() { return &___shakeFrequency_6; }
	inline void set_shakeFrequency_6(float value)
	{
		___shakeFrequency_6 = value;
	}

	inline static int32_t get_offset_of_shakeSmoothingExponent_7() { return static_cast<int32_t>(offsetof(AllIn1Shaker_t4540E312EAE72C5A4E5F184AFEC3099E91179295, ___shakeSmoothingExponent_7)); }
	inline float get_shakeSmoothingExponent_7() const { return ___shakeSmoothingExponent_7; }
	inline float* get_address_of_shakeSmoothingExponent_7() { return &___shakeSmoothingExponent_7; }
	inline void set_shakeSmoothingExponent_7(float value)
	{
		___shakeSmoothingExponent_7 = value;
	}

	inline static int32_t get_offset_of_shakeRecoverPerSecond_8() { return static_cast<int32_t>(offsetof(AllIn1Shaker_t4540E312EAE72C5A4E5F184AFEC3099E91179295, ___shakeRecoverPerSecond_8)); }
	inline float get_shakeRecoverPerSecond_8() const { return ___shakeRecoverPerSecond_8; }
	inline float* get_address_of_shakeRecoverPerSecond_8() { return &___shakeRecoverPerSecond_8; }
	inline void set_shakeRecoverPerSecond_8(float value)
	{
		___shakeRecoverPerSecond_8 = value;
	}

	inline static int32_t get_offset_of_currentShakeAmount_10() { return static_cast<int32_t>(offsetof(AllIn1Shaker_t4540E312EAE72C5A4E5F184AFEC3099E91179295, ___currentShakeAmount_10)); }
	inline float get_currentShakeAmount_10() const { return ___currentShakeAmount_10; }
	inline float* get_address_of_currentShakeAmount_10() { return &___currentShakeAmount_10; }
	inline void set_currentShakeAmount_10(float value)
	{
		___currentShakeAmount_10 = value;
	}

	inline static int32_t get_offset_of_seed_11() { return static_cast<int32_t>(offsetof(AllIn1Shaker_t4540E312EAE72C5A4E5F184AFEC3099E91179295, ___seed_11)); }
	inline float get_seed_11() const { return ___seed_11; }
	inline float* get_address_of_seed_11() { return &___seed_11; }
	inline void set_seed_11(float value)
	{
		___seed_11 = value;
	}
};

struct AllIn1Shaker_t4540E312EAE72C5A4E5F184AFEC3099E91179295_StaticFields
{
public:
	// AllIn1VfxToolkit.Demo.Scripts.AllIn1Shaker AllIn1VfxToolkit.Demo.Scripts.AllIn1Shaker::i
	AllIn1Shaker_t4540E312EAE72C5A4E5F184AFEC3099E91179295 * ___i_9;

public:
	inline static int32_t get_offset_of_i_9() { return static_cast<int32_t>(offsetof(AllIn1Shaker_t4540E312EAE72C5A4E5F184AFEC3099E91179295_StaticFields, ___i_9)); }
	inline AllIn1Shaker_t4540E312EAE72C5A4E5F184AFEC3099E91179295 * get_i_9() const { return ___i_9; }
	inline AllIn1Shaker_t4540E312EAE72C5A4E5F184AFEC3099E91179295 ** get_address_of_i_9() { return &___i_9; }
	inline void set_i_9(AllIn1Shaker_t4540E312EAE72C5A4E5F184AFEC3099E91179295 * value)
	{
		___i_9 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___i_9), (void*)value);
	}
};


// AllIn1VfxToolkit.Demo.Scripts.AllIn1TimeControl
struct AllIn1TimeControl_tD27F0B4D919AD681DB84DE2277471ABFF29C38DC  : public MonoBehaviour_t37A501200D970A8257124B0EAE00A0FF3DDC354A
{
public:
	// UnityEngine.KeyCode AllIn1VfxToolkit.Demo.Scripts.AllIn1TimeControl::increaseTimeScale
	int32_t ___increaseTimeScale_4;
	// UnityEngine.KeyCode AllIn1VfxToolkit.Demo.Scripts.AllIn1TimeControl::increaseTimeScaleAlt
	int32_t ___increaseTimeScaleAlt_5;
	// UnityEngine.KeyCode AllIn1VfxToolkit.Demo.Scripts.AllIn1TimeControl::decreaseTimeScale
	int32_t ___decreaseTimeScale_6;
	// UnityEngine.KeyCode AllIn1VfxToolkit.Demo.Scripts.AllIn1TimeControl::decreaseTimeScaleAlt
	int32_t ___decreaseTimeScaleAlt_7;
	// UnityEngine.KeyCode AllIn1VfxToolkit.Demo.Scripts.AllIn1TimeControl::pauseKey
	int32_t ___pauseKey_8;
	// System.Single AllIn1VfxToolkit.Demo.Scripts.AllIn1TimeControl::timeScaleInterval
	float ___timeScaleInterval_9;
	// UnityEngine.UI.Slider AllIn1VfxToolkit.Demo.Scripts.AllIn1TimeControl::timeScaleSlider
	Slider_tBF39A11CC24CBD3F8BD728982ACAEAE43989B51A * ___timeScaleSlider_10;
	// UnityEngine.UI.Image AllIn1VfxToolkit.Demo.Scripts.AllIn1TimeControl::pausedButtonImage
	Image_t4021FF27176E44BFEDDCBE43C7FE6B713EC70D3C * ___pausedButtonImage_11;
	// UnityEngine.Color AllIn1VfxToolkit.Demo.Scripts.AllIn1TimeControl::pausedButtonColor
	Color_tF40DAF76C04FFECF3FE6024F85A294741C9CC659  ___pausedButtonColor_12;
	// System.Boolean AllIn1VfxToolkit.Demo.Scripts.AllIn1TimeControl::timeScaleSliderNotNull
	bool ___timeScaleSliderNotNull_13;
	// System.Single AllIn1VfxToolkit.Demo.Scripts.AllIn1TimeControl::lastChangeTime
	float ___lastChangeTime_14;
	// AllIn1VfxToolkit.Demo.Scripts.AllIn1DemoScaleTween AllIn1VfxToolkit.Demo.Scripts.AllIn1TimeControl::pausedButtonTween
	AllIn1DemoScaleTween_t513A5592D7B99AAE00D3C297524793A01504CCD0 * ___pausedButtonTween_15;
	// UnityEngine.UI.Text AllIn1VfxToolkit.Demo.Scripts.AllIn1TimeControl::pausedButtonText
	Text_t6A2339DA6C05AE2646FC1A6C8FCC127391BE7FA1 * ___pausedButtonText_16;

public:
	inline static int32_t get_offset_of_increaseTimeScale_4() { return static_cast<int32_t>(offsetof(AllIn1TimeControl_tD27F0B4D919AD681DB84DE2277471ABFF29C38DC, ___increaseTimeScale_4)); }
	inline int32_t get_increaseTimeScale_4() const { return ___increaseTimeScale_4; }
	inline int32_t* get_address_of_increaseTimeScale_4() { return &___increaseTimeScale_4; }
	inline void set_increaseTimeScale_4(int32_t value)
	{
		___increaseTimeScale_4 = value;
	}

	inline static int32_t get_offset_of_increaseTimeScaleAlt_5() { return static_cast<int32_t>(offsetof(AllIn1TimeControl_tD27F0B4D919AD681DB84DE2277471ABFF29C38DC, ___increaseTimeScaleAlt_5)); }
	inline int32_t get_increaseTimeScaleAlt_5() const { return ___increaseTimeScaleAlt_5; }
	inline int32_t* get_address_of_increaseTimeScaleAlt_5() { return &___increaseTimeScaleAlt_5; }
	inline void set_increaseTimeScaleAlt_5(int32_t value)
	{
		___increaseTimeScaleAlt_5 = value;
	}

	inline static int32_t get_offset_of_decreaseTimeScale_6() { return static_cast<int32_t>(offsetof(AllIn1TimeControl_tD27F0B4D919AD681DB84DE2277471ABFF29C38DC, ___decreaseTimeScale_6)); }
	inline int32_t get_decreaseTimeScale_6() const { return ___decreaseTimeScale_6; }
	inline int32_t* get_address_of_decreaseTimeScale_6() { return &___decreaseTimeScale_6; }
	inline void set_decreaseTimeScale_6(int32_t value)
	{
		___decreaseTimeScale_6 = value;
	}

	inline static int32_t get_offset_of_decreaseTimeScaleAlt_7() { return static_cast<int32_t>(offsetof(AllIn1TimeControl_tD27F0B4D919AD681DB84DE2277471ABFF29C38DC, ___decreaseTimeScaleAlt_7)); }
	inline int32_t get_decreaseTimeScaleAlt_7() const { return ___decreaseTimeScaleAlt_7; }
	inline int32_t* get_address_of_decreaseTimeScaleAlt_7() { return &___decreaseTimeScaleAlt_7; }
	inline void set_decreaseTimeScaleAlt_7(int32_t value)
	{
		___decreaseTimeScaleAlt_7 = value;
	}

	inline static int32_t get_offset_of_pauseKey_8() { return static_cast<int32_t>(offsetof(AllIn1TimeControl_tD27F0B4D919AD681DB84DE2277471ABFF29C38DC, ___pauseKey_8)); }
	inline int32_t get_pauseKey_8() const { return ___pauseKey_8; }
	inline int32_t* get_address_of_pauseKey_8() { return &___pauseKey_8; }
	inline void set_pauseKey_8(int32_t value)
	{
		___pauseKey_8 = value;
	}

	inline static int32_t get_offset_of_timeScaleInterval_9() { return static_cast<int32_t>(offsetof(AllIn1TimeControl_tD27F0B4D919AD681DB84DE2277471ABFF29C38DC, ___timeScaleInterval_9)); }
	inline float get_timeScaleInterval_9() const { return ___timeScaleInterval_9; }
	inline float* get_address_of_timeScaleInterval_9() { return &___timeScaleInterval_9; }
	inline void set_timeScaleInterval_9(float value)
	{
		___timeScaleInterval_9 = value;
	}

	inline static int32_t get_offset_of_timeScaleSlider_10() { return static_cast<int32_t>(offsetof(AllIn1TimeControl_tD27F0B4D919AD681DB84DE2277471ABFF29C38DC, ___timeScaleSlider_10)); }
	inline Slider_tBF39A11CC24CBD3F8BD728982ACAEAE43989B51A * get_timeScaleSlider_10() const { return ___timeScaleSlider_10; }
	inline Slider_tBF39A11CC24CBD3F8BD728982ACAEAE43989B51A ** get_address_of_timeScaleSlider_10() { return &___timeScaleSlider_10; }
	inline void set_timeScaleSlider_10(Slider_tBF39A11CC24CBD3F8BD728982ACAEAE43989B51A * value)
	{
		___timeScaleSlider_10 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___timeScaleSlider_10), (void*)value);
	}

	inline static int32_t get_offset_of_pausedButtonImage_11() { return static_cast<int32_t>(offsetof(AllIn1TimeControl_tD27F0B4D919AD681DB84DE2277471ABFF29C38DC, ___pausedButtonImage_11)); }
	inline Image_t4021FF27176E44BFEDDCBE43C7FE6B713EC70D3C * get_pausedButtonImage_11() const { return ___pausedButtonImage_11; }
	inline Image_t4021FF27176E44BFEDDCBE43C7FE6B713EC70D3C ** get_address_of_pausedButtonImage_11() { return &___pausedButtonImage_11; }
	inline void set_pausedButtonImage_11(Image_t4021FF27176E44BFEDDCBE43C7FE6B713EC70D3C * value)
	{
		___pausedButtonImage_11 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___pausedButtonImage_11), (void*)value);
	}

	inline static int32_t get_offset_of_pausedButtonColor_12() { return static_cast<int32_t>(offsetof(AllIn1TimeControl_tD27F0B4D919AD681DB84DE2277471ABFF29C38DC, ___pausedButtonColor_12)); }
	inline Color_tF40DAF76C04FFECF3FE6024F85A294741C9CC659  get_pausedButtonColor_12() const { return ___pausedButtonColor_12; }
	inline Color_tF40DAF76C04FFECF3FE6024F85A294741C9CC659 * get_address_of_pausedButtonColor_12() { return &___pausedButtonColor_12; }
	inline void set_pausedButtonColor_12(Color_tF40DAF76C04FFECF3FE6024F85A294741C9CC659  value)
	{
		___pausedButtonColor_12 = value;
	}

	inline static int32_t get_offset_of_timeScaleSliderNotNull_13() { return static_cast<int32_t>(offsetof(AllIn1TimeControl_tD27F0B4D919AD681DB84DE2277471ABFF29C38DC, ___timeScaleSliderNotNull_13)); }
	inline bool get_timeScaleSliderNotNull_13() const { return ___timeScaleSliderNotNull_13; }
	inline bool* get_address_of_timeScaleSliderNotNull_13() { return &___timeScaleSliderNotNull_13; }
	inline void set_timeScaleSliderNotNull_13(bool value)
	{
		___timeScaleSliderNotNull_13 = value;
	}

	inline static int32_t get_offset_of_lastChangeTime_14() { return static_cast<int32_t>(offsetof(AllIn1TimeControl_tD27F0B4D919AD681DB84DE2277471ABFF29C38DC, ___lastChangeTime_14)); }
	inline float get_lastChangeTime_14() const { return ___lastChangeTime_14; }
	inline float* get_address_of_lastChangeTime_14() { return &___lastChangeTime_14; }
	inline void set_lastChangeTime_14(float value)
	{
		___lastChangeTime_14 = value;
	}

	inline static int32_t get_offset_of_pausedButtonTween_15() { return static_cast<int32_t>(offsetof(AllIn1TimeControl_tD27F0B4D919AD681DB84DE2277471ABFF29C38DC, ___pausedButtonTween_15)); }
	inline AllIn1DemoScaleTween_t513A5592D7B99AAE00D3C297524793A01504CCD0 * get_pausedButtonTween_15() const { return ___pausedButtonTween_15; }
	inline AllIn1DemoScaleTween_t513A5592D7B99AAE00D3C297524793A01504CCD0 ** get_address_of_pausedButtonTween_15() { return &___pausedButtonTween_15; }
	inline void set_pausedButtonTween_15(AllIn1DemoScaleTween_t513A5592D7B99AAE00D3C297524793A01504CCD0 * value)
	{
		___pausedButtonTween_15 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___pausedButtonTween_15), (void*)value);
	}

	inline static int32_t get_offset_of_pausedButtonText_16() { return static_cast<int32_t>(offsetof(AllIn1TimeControl_tD27F0B4D919AD681DB84DE2277471ABFF29C38DC, ___pausedButtonText_16)); }
	inline Text_t6A2339DA6C05AE2646FC1A6C8FCC127391BE7FA1 * get_pausedButtonText_16() const { return ___pausedButtonText_16; }
	inline Text_t6A2339DA6C05AE2646FC1A6C8FCC127391BE7FA1 ** get_address_of_pausedButtonText_16() { return &___pausedButtonText_16; }
	inline void set_pausedButtonText_16(Text_t6A2339DA6C05AE2646FC1A6C8FCC127391BE7FA1 * value)
	{
		___pausedButtonText_16 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___pausedButtonText_16), (void*)value);
	}
};


// AllIn1VfxToolkit.Demo.Scripts.AllIn1VfxAutoDestroy
struct AllIn1VfxAutoDestroy_t3C768037E70E7C4C499E0BCA0036CB1913BA6D95  : public MonoBehaviour_t37A501200D970A8257124B0EAE00A0FF3DDC354A
{
public:
	// System.Single AllIn1VfxToolkit.Demo.Scripts.AllIn1VfxAutoDestroy::destroyTime
	float ___destroyTime_4;

public:
	inline static int32_t get_offset_of_destroyTime_4() { return static_cast<int32_t>(offsetof(AllIn1VfxAutoDestroy_t3C768037E70E7C4C499E0BCA0036CB1913BA6D95, ___destroyTime_4)); }
	inline float get_destroyTime_4() const { return ___destroyTime_4; }
	inline float* get_address_of_destroyTime_4() { return &___destroyTime_4; }
	inline void set_destroyTime_4(float value)
	{
		___destroyTime_4 = value;
	}
};


// AllIn1VfxToolkit.Demo.Scripts.AllIn1VfxDemoController
struct AllIn1VfxDemoController_tDBA0E647E412D7CE6715A6976DB1E1A5722F6892  : public MonoBehaviour_t37A501200D970A8257124B0EAE00A0FF3DDC354A
{
public:
	// System.Int32 AllIn1VfxToolkit.Demo.Scripts.AllIn1VfxDemoController::startingCollectionIndex
	int32_t ___startingCollectionIndex_4;
	// System.Int32 AllIn1VfxToolkit.Demo.Scripts.AllIn1VfxDemoController::startingEffectIndex
	int32_t ___startingEffectIndex_5;
	// AllIn1VfxToolkit.Demo.Scripts.All1VfxDemoEffectCollection[] AllIn1VfxToolkit.Demo.Scripts.AllIn1VfxDemoController::effectsToSpawnCollections
	All1VfxDemoEffectCollectionU5BU5D_tA9660853E3FEE15A3B3F92BA64013878E31747FC* ___effectsToSpawnCollections_6;
	// UnityEngine.GameObject AllIn1VfxToolkit.Demo.Scripts.AllIn1VfxDemoController::projectileBasePrefab
	GameObject_tC000A2E1A7CF1E10FD7BA08863287C072207C319 * ___projectileBasePrefab_7;
	// UnityEngine.GameObject AllIn1VfxToolkit.Demo.Scripts.AllIn1VfxDemoController::projectileSceneSetupObject
	GameObject_tC000A2E1A7CF1E10FD7BA08863287C072207C319 * ___projectileSceneSetupObject_8;
	// UnityEngine.Transform AllIn1VfxToolkit.Demo.Scripts.AllIn1VfxDemoController::projectileSpawnPoint
	Transform_tA8193BB29D4D2C7EC04918F3ED1816345186C3F1 * ___projectileSpawnPoint_9;
	// UnityEngine.KeyCode AllIn1VfxToolkit.Demo.Scripts.AllIn1VfxDemoController::playEffectKey
	int32_t ___playEffectKey_10;
	// UnityEngine.KeyCode AllIn1VfxToolkit.Demo.Scripts.AllIn1VfxDemoController::nextEffectKey
	int32_t ___nextEffectKey_11;
	// UnityEngine.KeyCode AllIn1VfxToolkit.Demo.Scripts.AllIn1VfxDemoController::nextEffectKeyAlt
	int32_t ___nextEffectKeyAlt_12;
	// UnityEngine.KeyCode AllIn1VfxToolkit.Demo.Scripts.AllIn1VfxDemoController::previousEffectKey
	int32_t ___previousEffectKey_13;
	// UnityEngine.KeyCode AllIn1VfxToolkit.Demo.Scripts.AllIn1VfxDemoController::previousEffectKeyAlt
	int32_t ___previousEffectKeyAlt_14;
	// UnityEngine.UI.Text AllIn1VfxToolkit.Demo.Scripts.AllIn1VfxDemoController::currentEffectLabel
	Text_t6A2339DA6C05AE2646FC1A6C8FCC127391BE7FA1 * ___currentEffectLabel_15;
	// UnityEngine.UI.Button AllIn1VfxToolkit.Demo.Scripts.AllIn1VfxDemoController::playEffectButton
	Button_tA893FC15AB26E1439AC25BDCA7079530587BB65D * ___playEffectButton_16;
	// UnityEngine.GameObject AllIn1VfxToolkit.Demo.Scripts.AllIn1VfxDemoController::playEffectInstructionsGo
	GameObject_tC000A2E1A7CF1E10FD7BA08863287C072207C319 * ___playEffectInstructionsGo_17;
	// UnityEngine.UI.Button AllIn1VfxToolkit.Demo.Scripts.AllIn1VfxDemoController::nextEffectButton
	Button_tA893FC15AB26E1439AC25BDCA7079530587BB65D * ___nextEffectButton_18;
	// UnityEngine.UI.Button AllIn1VfxToolkit.Demo.Scripts.AllIn1VfxDemoController::previousEffectButton
	Button_tA893FC15AB26E1439AC25BDCA7079530587BB65D * ___previousEffectButton_19;
	// UnityEngine.Transform AllIn1VfxToolkit.Demo.Scripts.AllIn1VfxDemoController::groundSpawnTransform
	Transform_tA8193BB29D4D2C7EC04918F3ED1816345186C3F1 * ___groundSpawnTransform_20;
	// UnityEngine.Transform AllIn1VfxToolkit.Demo.Scripts.AllIn1VfxDemoController::cameraPivotTransform
	Transform_tA8193BB29D4D2C7EC04918F3ED1816345186C3F1 * ___cameraPivotTransform_21;
	// System.Single AllIn1VfxToolkit.Demo.Scripts.AllIn1VfxDemoController::camPivotHeightSmoothing
	float ___camPivotHeightSmoothing_22;
	// UnityEngine.GameObject AllIn1VfxToolkit.Demo.Scripts.AllIn1VfxDemoController::projectileEffectUI
	GameObject_tC000A2E1A7CF1E10FD7BA08863287C072207C319 * ___projectileEffectUI_23;
	// UnityEngine.GameObject AllIn1VfxToolkit.Demo.Scripts.AllIn1VfxDemoController::normalEffectUI
	GameObject_tC000A2E1A7CF1E10FD7BA08863287C072207C319 * ___normalEffectUI_24;
	// AllIn1VfxToolkit.Demo.Scripts.All1VfxDemoEffect AllIn1VfxToolkit.Demo.Scripts.AllIn1VfxDemoController::currDemoEffect
	All1VfxDemoEffect_t66A278FEFF55B095702CEE911709440057966E75 * ___currDemoEffect_25;
	// System.Int32 AllIn1VfxToolkit.Demo.Scripts.AllIn1VfxDemoController::currDemoCollectionIndex
	int32_t ___currDemoCollectionIndex_26;
	// System.Int32 AllIn1VfxToolkit.Demo.Scripts.AllIn1VfxDemoController::currDemoEffectIndex
	int32_t ___currDemoEffectIndex_27;
	// System.Int32 AllIn1VfxToolkit.Demo.Scripts.AllIn1VfxDemoController::currentEffectPlays
	int32_t ___currentEffectPlays_28;
	// AllIn1VfxToolkit.Demo.Scripts.AllIn1DemoScaleTween AllIn1VfxToolkit.Demo.Scripts.AllIn1VfxDemoController::currLabelTween
	AllIn1DemoScaleTween_t513A5592D7B99AAE00D3C297524793A01504CCD0 * ___currLabelTween_29;
	// AllIn1VfxToolkit.Demo.Scripts.AllIn1DemoScaleTween AllIn1VfxToolkit.Demo.Scripts.AllIn1VfxDemoController::playButtTween
	AllIn1DemoScaleTween_t513A5592D7B99AAE00D3C297524793A01504CCD0 * ___playButtTween_30;
	// AllIn1VfxToolkit.Demo.Scripts.AllIn1DemoScaleTween AllIn1VfxToolkit.Demo.Scripts.AllIn1VfxDemoController::nextButtTween
	AllIn1DemoScaleTween_t513A5592D7B99AAE00D3C297524793A01504CCD0 * ___nextButtTween_31;
	// AllIn1VfxToolkit.Demo.Scripts.AllIn1DemoScaleTween AllIn1VfxToolkit.Demo.Scripts.AllIn1VfxDemoController::prevButtTween
	AllIn1DemoScaleTween_t513A5592D7B99AAE00D3C297524793A01504CCD0 * ___prevButtTween_32;
	// System.Single AllIn1VfxToolkit.Demo.Scripts.AllIn1VfxDemoController::timeSinceEffectPlay
	float ___timeSinceEffectPlay_33;
	// AllIn1VfxToolkit.Demo.Scripts.AllIn1TimeControl AllIn1VfxToolkit.Demo.Scripts.AllIn1VfxDemoController::allIn1TimeControl
	AllIn1TimeControl_tD27F0B4D919AD681DB84DE2277471ABFF29C38DC * ___allIn1TimeControl_34;

public:
	inline static int32_t get_offset_of_startingCollectionIndex_4() { return static_cast<int32_t>(offsetof(AllIn1VfxDemoController_tDBA0E647E412D7CE6715A6976DB1E1A5722F6892, ___startingCollectionIndex_4)); }
	inline int32_t get_startingCollectionIndex_4() const { return ___startingCollectionIndex_4; }
	inline int32_t* get_address_of_startingCollectionIndex_4() { return &___startingCollectionIndex_4; }
	inline void set_startingCollectionIndex_4(int32_t value)
	{
		___startingCollectionIndex_4 = value;
	}

	inline static int32_t get_offset_of_startingEffectIndex_5() { return static_cast<int32_t>(offsetof(AllIn1VfxDemoController_tDBA0E647E412D7CE6715A6976DB1E1A5722F6892, ___startingEffectIndex_5)); }
	inline int32_t get_startingEffectIndex_5() const { return ___startingEffectIndex_5; }
	inline int32_t* get_address_of_startingEffectIndex_5() { return &___startingEffectIndex_5; }
	inline void set_startingEffectIndex_5(int32_t value)
	{
		___startingEffectIndex_5 = value;
	}

	inline static int32_t get_offset_of_effectsToSpawnCollections_6() { return static_cast<int32_t>(offsetof(AllIn1VfxDemoController_tDBA0E647E412D7CE6715A6976DB1E1A5722F6892, ___effectsToSpawnCollections_6)); }
	inline All1VfxDemoEffectCollectionU5BU5D_tA9660853E3FEE15A3B3F92BA64013878E31747FC* get_effectsToSpawnCollections_6() const { return ___effectsToSpawnCollections_6; }
	inline All1VfxDemoEffectCollectionU5BU5D_tA9660853E3FEE15A3B3F92BA64013878E31747FC** get_address_of_effectsToSpawnCollections_6() { return &___effectsToSpawnCollections_6; }
	inline void set_effectsToSpawnCollections_6(All1VfxDemoEffectCollectionU5BU5D_tA9660853E3FEE15A3B3F92BA64013878E31747FC* value)
	{
		___effectsToSpawnCollections_6 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___effectsToSpawnCollections_6), (void*)value);
	}

	inline static int32_t get_offset_of_projectileBasePrefab_7() { return static_cast<int32_t>(offsetof(AllIn1VfxDemoController_tDBA0E647E412D7CE6715A6976DB1E1A5722F6892, ___projectileBasePrefab_7)); }
	inline GameObject_tC000A2E1A7CF1E10FD7BA08863287C072207C319 * get_projectileBasePrefab_7() const { return ___projectileBasePrefab_7; }
	inline GameObject_tC000A2E1A7CF1E10FD7BA08863287C072207C319 ** get_address_of_projectileBasePrefab_7() { return &___projectileBasePrefab_7; }
	inline void set_projectileBasePrefab_7(GameObject_tC000A2E1A7CF1E10FD7BA08863287C072207C319 * value)
	{
		___projectileBasePrefab_7 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___projectileBasePrefab_7), (void*)value);
	}

	inline static int32_t get_offset_of_projectileSceneSetupObject_8() { return static_cast<int32_t>(offsetof(AllIn1VfxDemoController_tDBA0E647E412D7CE6715A6976DB1E1A5722F6892, ___projectileSceneSetupObject_8)); }
	inline GameObject_tC000A2E1A7CF1E10FD7BA08863287C072207C319 * get_projectileSceneSetupObject_8() const { return ___projectileSceneSetupObject_8; }
	inline GameObject_tC000A2E1A7CF1E10FD7BA08863287C072207C319 ** get_address_of_projectileSceneSetupObject_8() { return &___projectileSceneSetupObject_8; }
	inline void set_projectileSceneSetupObject_8(GameObject_tC000A2E1A7CF1E10FD7BA08863287C072207C319 * value)
	{
		___projectileSceneSetupObject_8 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___projectileSceneSetupObject_8), (void*)value);
	}

	inline static int32_t get_offset_of_projectileSpawnPoint_9() { return static_cast<int32_t>(offsetof(AllIn1VfxDemoController_tDBA0E647E412D7CE6715A6976DB1E1A5722F6892, ___projectileSpawnPoint_9)); }
	inline Transform_tA8193BB29D4D2C7EC04918F3ED1816345186C3F1 * get_projectileSpawnPoint_9() const { return ___projectileSpawnPoint_9; }
	inline Transform_tA8193BB29D4D2C7EC04918F3ED1816345186C3F1 ** get_address_of_projectileSpawnPoint_9() { return &___projectileSpawnPoint_9; }
	inline void set_projectileSpawnPoint_9(Transform_tA8193BB29D4D2C7EC04918F3ED1816345186C3F1 * value)
	{
		___projectileSpawnPoint_9 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___projectileSpawnPoint_9), (void*)value);
	}

	inline static int32_t get_offset_of_playEffectKey_10() { return static_cast<int32_t>(offsetof(AllIn1VfxDemoController_tDBA0E647E412D7CE6715A6976DB1E1A5722F6892, ___playEffectKey_10)); }
	inline int32_t get_playEffectKey_10() const { return ___playEffectKey_10; }
	inline int32_t* get_address_of_playEffectKey_10() { return &___playEffectKey_10; }
	inline void set_playEffectKey_10(int32_t value)
	{
		___playEffectKey_10 = value;
	}

	inline static int32_t get_offset_of_nextEffectKey_11() { return static_cast<int32_t>(offsetof(AllIn1VfxDemoController_tDBA0E647E412D7CE6715A6976DB1E1A5722F6892, ___nextEffectKey_11)); }
	inline int32_t get_nextEffectKey_11() const { return ___nextEffectKey_11; }
	inline int32_t* get_address_of_nextEffectKey_11() { return &___nextEffectKey_11; }
	inline void set_nextEffectKey_11(int32_t value)
	{
		___nextEffectKey_11 = value;
	}

	inline static int32_t get_offset_of_nextEffectKeyAlt_12() { return static_cast<int32_t>(offsetof(AllIn1VfxDemoController_tDBA0E647E412D7CE6715A6976DB1E1A5722F6892, ___nextEffectKeyAlt_12)); }
	inline int32_t get_nextEffectKeyAlt_12() const { return ___nextEffectKeyAlt_12; }
	inline int32_t* get_address_of_nextEffectKeyAlt_12() { return &___nextEffectKeyAlt_12; }
	inline void set_nextEffectKeyAlt_12(int32_t value)
	{
		___nextEffectKeyAlt_12 = value;
	}

	inline static int32_t get_offset_of_previousEffectKey_13() { return static_cast<int32_t>(offsetof(AllIn1VfxDemoController_tDBA0E647E412D7CE6715A6976DB1E1A5722F6892, ___previousEffectKey_13)); }
	inline int32_t get_previousEffectKey_13() const { return ___previousEffectKey_13; }
	inline int32_t* get_address_of_previousEffectKey_13() { return &___previousEffectKey_13; }
	inline void set_previousEffectKey_13(int32_t value)
	{
		___previousEffectKey_13 = value;
	}

	inline static int32_t get_offset_of_previousEffectKeyAlt_14() { return static_cast<int32_t>(offsetof(AllIn1VfxDemoController_tDBA0E647E412D7CE6715A6976DB1E1A5722F6892, ___previousEffectKeyAlt_14)); }
	inline int32_t get_previousEffectKeyAlt_14() const { return ___previousEffectKeyAlt_14; }
	inline int32_t* get_address_of_previousEffectKeyAlt_14() { return &___previousEffectKeyAlt_14; }
	inline void set_previousEffectKeyAlt_14(int32_t value)
	{
		___previousEffectKeyAlt_14 = value;
	}

	inline static int32_t get_offset_of_currentEffectLabel_15() { return static_cast<int32_t>(offsetof(AllIn1VfxDemoController_tDBA0E647E412D7CE6715A6976DB1E1A5722F6892, ___currentEffectLabel_15)); }
	inline Text_t6A2339DA6C05AE2646FC1A6C8FCC127391BE7FA1 * get_currentEffectLabel_15() const { return ___currentEffectLabel_15; }
	inline Text_t6A2339DA6C05AE2646FC1A6C8FCC127391BE7FA1 ** get_address_of_currentEffectLabel_15() { return &___currentEffectLabel_15; }
	inline void set_currentEffectLabel_15(Text_t6A2339DA6C05AE2646FC1A6C8FCC127391BE7FA1 * value)
	{
		___currentEffectLabel_15 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___currentEffectLabel_15), (void*)value);
	}

	inline static int32_t get_offset_of_playEffectButton_16() { return static_cast<int32_t>(offsetof(AllIn1VfxDemoController_tDBA0E647E412D7CE6715A6976DB1E1A5722F6892, ___playEffectButton_16)); }
	inline Button_tA893FC15AB26E1439AC25BDCA7079530587BB65D * get_playEffectButton_16() const { return ___playEffectButton_16; }
	inline Button_tA893FC15AB26E1439AC25BDCA7079530587BB65D ** get_address_of_playEffectButton_16() { return &___playEffectButton_16; }
	inline void set_playEffectButton_16(Button_tA893FC15AB26E1439AC25BDCA7079530587BB65D * value)
	{
		___playEffectButton_16 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___playEffectButton_16), (void*)value);
	}

	inline static int32_t get_offset_of_playEffectInstructionsGo_17() { return static_cast<int32_t>(offsetof(AllIn1VfxDemoController_tDBA0E647E412D7CE6715A6976DB1E1A5722F6892, ___playEffectInstructionsGo_17)); }
	inline GameObject_tC000A2E1A7CF1E10FD7BA08863287C072207C319 * get_playEffectInstructionsGo_17() const { return ___playEffectInstructionsGo_17; }
	inline GameObject_tC000A2E1A7CF1E10FD7BA08863287C072207C319 ** get_address_of_playEffectInstructionsGo_17() { return &___playEffectInstructionsGo_17; }
	inline void set_playEffectInstructionsGo_17(GameObject_tC000A2E1A7CF1E10FD7BA08863287C072207C319 * value)
	{
		___playEffectInstructionsGo_17 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___playEffectInstructionsGo_17), (void*)value);
	}

	inline static int32_t get_offset_of_nextEffectButton_18() { return static_cast<int32_t>(offsetof(AllIn1VfxDemoController_tDBA0E647E412D7CE6715A6976DB1E1A5722F6892, ___nextEffectButton_18)); }
	inline Button_tA893FC15AB26E1439AC25BDCA7079530587BB65D * get_nextEffectButton_18() const { return ___nextEffectButton_18; }
	inline Button_tA893FC15AB26E1439AC25BDCA7079530587BB65D ** get_address_of_nextEffectButton_18() { return &___nextEffectButton_18; }
	inline void set_nextEffectButton_18(Button_tA893FC15AB26E1439AC25BDCA7079530587BB65D * value)
	{
		___nextEffectButton_18 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___nextEffectButton_18), (void*)value);
	}

	inline static int32_t get_offset_of_previousEffectButton_19() { return static_cast<int32_t>(offsetof(AllIn1VfxDemoController_tDBA0E647E412D7CE6715A6976DB1E1A5722F6892, ___previousEffectButton_19)); }
	inline Button_tA893FC15AB26E1439AC25BDCA7079530587BB65D * get_previousEffectButton_19() const { return ___previousEffectButton_19; }
	inline Button_tA893FC15AB26E1439AC25BDCA7079530587BB65D ** get_address_of_previousEffectButton_19() { return &___previousEffectButton_19; }
	inline void set_previousEffectButton_19(Button_tA893FC15AB26E1439AC25BDCA7079530587BB65D * value)
	{
		___previousEffectButton_19 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___previousEffectButton_19), (void*)value);
	}

	inline static int32_t get_offset_of_groundSpawnTransform_20() { return static_cast<int32_t>(offsetof(AllIn1VfxDemoController_tDBA0E647E412D7CE6715A6976DB1E1A5722F6892, ___groundSpawnTransform_20)); }
	inline Transform_tA8193BB29D4D2C7EC04918F3ED1816345186C3F1 * get_groundSpawnTransform_20() const { return ___groundSpawnTransform_20; }
	inline Transform_tA8193BB29D4D2C7EC04918F3ED1816345186C3F1 ** get_address_of_groundSpawnTransform_20() { return &___groundSpawnTransform_20; }
	inline void set_groundSpawnTransform_20(Transform_tA8193BB29D4D2C7EC04918F3ED1816345186C3F1 * value)
	{
		___groundSpawnTransform_20 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___groundSpawnTransform_20), (void*)value);
	}

	inline static int32_t get_offset_of_cameraPivotTransform_21() { return static_cast<int32_t>(offsetof(AllIn1VfxDemoController_tDBA0E647E412D7CE6715A6976DB1E1A5722F6892, ___cameraPivotTransform_21)); }
	inline Transform_tA8193BB29D4D2C7EC04918F3ED1816345186C3F1 * get_cameraPivotTransform_21() const { return ___cameraPivotTransform_21; }
	inline Transform_tA8193BB29D4D2C7EC04918F3ED1816345186C3F1 ** get_address_of_cameraPivotTransform_21() { return &___cameraPivotTransform_21; }
	inline void set_cameraPivotTransform_21(Transform_tA8193BB29D4D2C7EC04918F3ED1816345186C3F1 * value)
	{
		___cameraPivotTransform_21 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___cameraPivotTransform_21), (void*)value);
	}

	inline static int32_t get_offset_of_camPivotHeightSmoothing_22() { return static_cast<int32_t>(offsetof(AllIn1VfxDemoController_tDBA0E647E412D7CE6715A6976DB1E1A5722F6892, ___camPivotHeightSmoothing_22)); }
	inline float get_camPivotHeightSmoothing_22() const { return ___camPivotHeightSmoothing_22; }
	inline float* get_address_of_camPivotHeightSmoothing_22() { return &___camPivotHeightSmoothing_22; }
	inline void set_camPivotHeightSmoothing_22(float value)
	{
		___camPivotHeightSmoothing_22 = value;
	}

	inline static int32_t get_offset_of_projectileEffectUI_23() { return static_cast<int32_t>(offsetof(AllIn1VfxDemoController_tDBA0E647E412D7CE6715A6976DB1E1A5722F6892, ___projectileEffectUI_23)); }
	inline GameObject_tC000A2E1A7CF1E10FD7BA08863287C072207C319 * get_projectileEffectUI_23() const { return ___projectileEffectUI_23; }
	inline GameObject_tC000A2E1A7CF1E10FD7BA08863287C072207C319 ** get_address_of_projectileEffectUI_23() { return &___projectileEffectUI_23; }
	inline void set_projectileEffectUI_23(GameObject_tC000A2E1A7CF1E10FD7BA08863287C072207C319 * value)
	{
		___projectileEffectUI_23 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___projectileEffectUI_23), (void*)value);
	}

	inline static int32_t get_offset_of_normalEffectUI_24() { return static_cast<int32_t>(offsetof(AllIn1VfxDemoController_tDBA0E647E412D7CE6715A6976DB1E1A5722F6892, ___normalEffectUI_24)); }
	inline GameObject_tC000A2E1A7CF1E10FD7BA08863287C072207C319 * get_normalEffectUI_24() const { return ___normalEffectUI_24; }
	inline GameObject_tC000A2E1A7CF1E10FD7BA08863287C072207C319 ** get_address_of_normalEffectUI_24() { return &___normalEffectUI_24; }
	inline void set_normalEffectUI_24(GameObject_tC000A2E1A7CF1E10FD7BA08863287C072207C319 * value)
	{
		___normalEffectUI_24 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___normalEffectUI_24), (void*)value);
	}

	inline static int32_t get_offset_of_currDemoEffect_25() { return static_cast<int32_t>(offsetof(AllIn1VfxDemoController_tDBA0E647E412D7CE6715A6976DB1E1A5722F6892, ___currDemoEffect_25)); }
	inline All1VfxDemoEffect_t66A278FEFF55B095702CEE911709440057966E75 * get_currDemoEffect_25() const { return ___currDemoEffect_25; }
	inline All1VfxDemoEffect_t66A278FEFF55B095702CEE911709440057966E75 ** get_address_of_currDemoEffect_25() { return &___currDemoEffect_25; }
	inline void set_currDemoEffect_25(All1VfxDemoEffect_t66A278FEFF55B095702CEE911709440057966E75 * value)
	{
		___currDemoEffect_25 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___currDemoEffect_25), (void*)value);
	}

	inline static int32_t get_offset_of_currDemoCollectionIndex_26() { return static_cast<int32_t>(offsetof(AllIn1VfxDemoController_tDBA0E647E412D7CE6715A6976DB1E1A5722F6892, ___currDemoCollectionIndex_26)); }
	inline int32_t get_currDemoCollectionIndex_26() const { return ___currDemoCollectionIndex_26; }
	inline int32_t* get_address_of_currDemoCollectionIndex_26() { return &___currDemoCollectionIndex_26; }
	inline void set_currDemoCollectionIndex_26(int32_t value)
	{
		___currDemoCollectionIndex_26 = value;
	}

	inline static int32_t get_offset_of_currDemoEffectIndex_27() { return static_cast<int32_t>(offsetof(AllIn1VfxDemoController_tDBA0E647E412D7CE6715A6976DB1E1A5722F6892, ___currDemoEffectIndex_27)); }
	inline int32_t get_currDemoEffectIndex_27() const { return ___currDemoEffectIndex_27; }
	inline int32_t* get_address_of_currDemoEffectIndex_27() { return &___currDemoEffectIndex_27; }
	inline void set_currDemoEffectIndex_27(int32_t value)
	{
		___currDemoEffectIndex_27 = value;
	}

	inline static int32_t get_offset_of_currentEffectPlays_28() { return static_cast<int32_t>(offsetof(AllIn1VfxDemoController_tDBA0E647E412D7CE6715A6976DB1E1A5722F6892, ___currentEffectPlays_28)); }
	inline int32_t get_currentEffectPlays_28() const { return ___currentEffectPlays_28; }
	inline int32_t* get_address_of_currentEffectPlays_28() { return &___currentEffectPlays_28; }
	inline void set_currentEffectPlays_28(int32_t value)
	{
		___currentEffectPlays_28 = value;
	}

	inline static int32_t get_offset_of_currLabelTween_29() { return static_cast<int32_t>(offsetof(AllIn1VfxDemoController_tDBA0E647E412D7CE6715A6976DB1E1A5722F6892, ___currLabelTween_29)); }
	inline AllIn1DemoScaleTween_t513A5592D7B99AAE00D3C297524793A01504CCD0 * get_currLabelTween_29() const { return ___currLabelTween_29; }
	inline AllIn1DemoScaleTween_t513A5592D7B99AAE00D3C297524793A01504CCD0 ** get_address_of_currLabelTween_29() { return &___currLabelTween_29; }
	inline void set_currLabelTween_29(AllIn1DemoScaleTween_t513A5592D7B99AAE00D3C297524793A01504CCD0 * value)
	{
		___currLabelTween_29 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___currLabelTween_29), (void*)value);
	}

	inline static int32_t get_offset_of_playButtTween_30() { return static_cast<int32_t>(offsetof(AllIn1VfxDemoController_tDBA0E647E412D7CE6715A6976DB1E1A5722F6892, ___playButtTween_30)); }
	inline AllIn1DemoScaleTween_t513A5592D7B99AAE00D3C297524793A01504CCD0 * get_playButtTween_30() const { return ___playButtTween_30; }
	inline AllIn1DemoScaleTween_t513A5592D7B99AAE00D3C297524793A01504CCD0 ** get_address_of_playButtTween_30() { return &___playButtTween_30; }
	inline void set_playButtTween_30(AllIn1DemoScaleTween_t513A5592D7B99AAE00D3C297524793A01504CCD0 * value)
	{
		___playButtTween_30 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___playButtTween_30), (void*)value);
	}

	inline static int32_t get_offset_of_nextButtTween_31() { return static_cast<int32_t>(offsetof(AllIn1VfxDemoController_tDBA0E647E412D7CE6715A6976DB1E1A5722F6892, ___nextButtTween_31)); }
	inline AllIn1DemoScaleTween_t513A5592D7B99AAE00D3C297524793A01504CCD0 * get_nextButtTween_31() const { return ___nextButtTween_31; }
	inline AllIn1DemoScaleTween_t513A5592D7B99AAE00D3C297524793A01504CCD0 ** get_address_of_nextButtTween_31() { return &___nextButtTween_31; }
	inline void set_nextButtTween_31(AllIn1DemoScaleTween_t513A5592D7B99AAE00D3C297524793A01504CCD0 * value)
	{
		___nextButtTween_31 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___nextButtTween_31), (void*)value);
	}

	inline static int32_t get_offset_of_prevButtTween_32() { return static_cast<int32_t>(offsetof(AllIn1VfxDemoController_tDBA0E647E412D7CE6715A6976DB1E1A5722F6892, ___prevButtTween_32)); }
	inline AllIn1DemoScaleTween_t513A5592D7B99AAE00D3C297524793A01504CCD0 * get_prevButtTween_32() const { return ___prevButtTween_32; }
	inline AllIn1DemoScaleTween_t513A5592D7B99AAE00D3C297524793A01504CCD0 ** get_address_of_prevButtTween_32() { return &___prevButtTween_32; }
	inline void set_prevButtTween_32(AllIn1DemoScaleTween_t513A5592D7B99AAE00D3C297524793A01504CCD0 * value)
	{
		___prevButtTween_32 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___prevButtTween_32), (void*)value);
	}

	inline static int32_t get_offset_of_timeSinceEffectPlay_33() { return static_cast<int32_t>(offsetof(AllIn1VfxDemoController_tDBA0E647E412D7CE6715A6976DB1E1A5722F6892, ___timeSinceEffectPlay_33)); }
	inline float get_timeSinceEffectPlay_33() const { return ___timeSinceEffectPlay_33; }
	inline float* get_address_of_timeSinceEffectPlay_33() { return &___timeSinceEffectPlay_33; }
	inline void set_timeSinceEffectPlay_33(float value)
	{
		___timeSinceEffectPlay_33 = value;
	}

	inline static int32_t get_offset_of_allIn1TimeControl_34() { return static_cast<int32_t>(offsetof(AllIn1VfxDemoController_tDBA0E647E412D7CE6715A6976DB1E1A5722F6892, ___allIn1TimeControl_34)); }
	inline AllIn1TimeControl_tD27F0B4D919AD681DB84DE2277471ABFF29C38DC * get_allIn1TimeControl_34() const { return ___allIn1TimeControl_34; }
	inline AllIn1TimeControl_tD27F0B4D919AD681DB84DE2277471ABFF29C38DC ** get_address_of_allIn1TimeControl_34() { return &___allIn1TimeControl_34; }
	inline void set_allIn1TimeControl_34(AllIn1TimeControl_tD27F0B4D919AD681DB84DE2277471ABFF29C38DC * value)
	{
		___allIn1TimeControl_34 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___allIn1TimeControl_34), (void*)value);
	}
};


// AllIn1VfxToolkit.Demo.Scripts.AllIn1VfxFadeLight
struct AllIn1VfxFadeLight_t063DC487D234F37F3E1D51B46CE77FE9983E238C  : public MonoBehaviour_t37A501200D970A8257124B0EAE00A0FF3DDC354A
{
public:
	// System.Single AllIn1VfxToolkit.Demo.Scripts.AllIn1VfxFadeLight::fadeDuration
	float ___fadeDuration_4;
	// System.Boolean AllIn1VfxToolkit.Demo.Scripts.AllIn1VfxFadeLight::destroyWhenFaded
	bool ___destroyWhenFaded_5;
	// UnityEngine.Light AllIn1VfxToolkit.Demo.Scripts.AllIn1VfxFadeLight::targetLight
	Light_tA2F349FE839781469A0344CF6039B51512394275 * ___targetLight_6;
	// System.Single AllIn1VfxToolkit.Demo.Scripts.AllIn1VfxFadeLight::animationRatioRemaining
	float ___animationRatioRemaining_7;
	// System.Single AllIn1VfxToolkit.Demo.Scripts.AllIn1VfxFadeLight::iniLightIntensity
	float ___iniLightIntensity_8;

public:
	inline static int32_t get_offset_of_fadeDuration_4() { return static_cast<int32_t>(offsetof(AllIn1VfxFadeLight_t063DC487D234F37F3E1D51B46CE77FE9983E238C, ___fadeDuration_4)); }
	inline float get_fadeDuration_4() const { return ___fadeDuration_4; }
	inline float* get_address_of_fadeDuration_4() { return &___fadeDuration_4; }
	inline void set_fadeDuration_4(float value)
	{
		___fadeDuration_4 = value;
	}

	inline static int32_t get_offset_of_destroyWhenFaded_5() { return static_cast<int32_t>(offsetof(AllIn1VfxFadeLight_t063DC487D234F37F3E1D51B46CE77FE9983E238C, ___destroyWhenFaded_5)); }
	inline bool get_destroyWhenFaded_5() const { return ___destroyWhenFaded_5; }
	inline bool* get_address_of_destroyWhenFaded_5() { return &___destroyWhenFaded_5; }
	inline void set_destroyWhenFaded_5(bool value)
	{
		___destroyWhenFaded_5 = value;
	}

	inline static int32_t get_offset_of_targetLight_6() { return static_cast<int32_t>(offsetof(AllIn1VfxFadeLight_t063DC487D234F37F3E1D51B46CE77FE9983E238C, ___targetLight_6)); }
	inline Light_tA2F349FE839781469A0344CF6039B51512394275 * get_targetLight_6() const { return ___targetLight_6; }
	inline Light_tA2F349FE839781469A0344CF6039B51512394275 ** get_address_of_targetLight_6() { return &___targetLight_6; }
	inline void set_targetLight_6(Light_tA2F349FE839781469A0344CF6039B51512394275 * value)
	{
		___targetLight_6 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___targetLight_6), (void*)value);
	}

	inline static int32_t get_offset_of_animationRatioRemaining_7() { return static_cast<int32_t>(offsetof(AllIn1VfxFadeLight_t063DC487D234F37F3E1D51B46CE77FE9983E238C, ___animationRatioRemaining_7)); }
	inline float get_animationRatioRemaining_7() const { return ___animationRatioRemaining_7; }
	inline float* get_address_of_animationRatioRemaining_7() { return &___animationRatioRemaining_7; }
	inline void set_animationRatioRemaining_7(float value)
	{
		___animationRatioRemaining_7 = value;
	}

	inline static int32_t get_offset_of_iniLightIntensity_8() { return static_cast<int32_t>(offsetof(AllIn1VfxFadeLight_t063DC487D234F37F3E1D51B46CE77FE9983E238C, ___iniLightIntensity_8)); }
	inline float get_iniLightIntensity_8() const { return ___iniLightIntensity_8; }
	inline float* get_address_of_iniLightIntensity_8() { return &___iniLightIntensity_8; }
	inline void set_iniLightIntensity_8(float value)
	{
		___iniLightIntensity_8 = value;
	}
};


// AllIn1VfxToolkit.Demo.Scripts.AllIn1VfxParticleSystemTime
struct AllIn1VfxParticleSystemTime_t1EE72855BC01A8A9547DB7A4C30287E1CDF7E9EF  : public MonoBehaviour_t37A501200D970A8257124B0EAE00A0FF3DDC354A
{
public:
	// System.Boolean AllIn1VfxToolkit.Demo.Scripts.AllIn1VfxParticleSystemTime::updateEveryFrame
	bool ___updateEveryFrame_4;
	// UnityEngine.Vector2 AllIn1VfxToolkit.Demo.Scripts.AllIn1VfxParticleSystemTime::simulationTimeRange
	Vector2_tBB32F2736AEC229A7BFBCE18197EC0F6AC7EC2D9  ___simulationTimeRange_5;
	// UnityEngine.ParticleSystem AllIn1VfxToolkit.Demo.Scripts.AllIn1VfxParticleSystemTime::targetPs
	ParticleSystem_t2F526CCDBD3512879B3FCBE04BCAB20D7B4F391E * ___targetPs_6;
	// System.Boolean AllIn1VfxToolkit.Demo.Scripts.AllIn1VfxParticleSystemTime::isValid
	bool ___isValid_7;

public:
	inline static int32_t get_offset_of_updateEveryFrame_4() { return static_cast<int32_t>(offsetof(AllIn1VfxParticleSystemTime_t1EE72855BC01A8A9547DB7A4C30287E1CDF7E9EF, ___updateEveryFrame_4)); }
	inline bool get_updateEveryFrame_4() const { return ___updateEveryFrame_4; }
	inline bool* get_address_of_updateEveryFrame_4() { return &___updateEveryFrame_4; }
	inline void set_updateEveryFrame_4(bool value)
	{
		___updateEveryFrame_4 = value;
	}

	inline static int32_t get_offset_of_simulationTimeRange_5() { return static_cast<int32_t>(offsetof(AllIn1VfxParticleSystemTime_t1EE72855BC01A8A9547DB7A4C30287E1CDF7E9EF, ___simulationTimeRange_5)); }
	inline Vector2_tBB32F2736AEC229A7BFBCE18197EC0F6AC7EC2D9  get_simulationTimeRange_5() const { return ___simulationTimeRange_5; }
	inline Vector2_tBB32F2736AEC229A7BFBCE18197EC0F6AC7EC2D9 * get_address_of_simulationTimeRange_5() { return &___simulationTimeRange_5; }
	inline void set_simulationTimeRange_5(Vector2_tBB32F2736AEC229A7BFBCE18197EC0F6AC7EC2D9  value)
	{
		___simulationTimeRange_5 = value;
	}

	inline static int32_t get_offset_of_targetPs_6() { return static_cast<int32_t>(offsetof(AllIn1VfxParticleSystemTime_t1EE72855BC01A8A9547DB7A4C30287E1CDF7E9EF, ___targetPs_6)); }
	inline ParticleSystem_t2F526CCDBD3512879B3FCBE04BCAB20D7B4F391E * get_targetPs_6() const { return ___targetPs_6; }
	inline ParticleSystem_t2F526CCDBD3512879B3FCBE04BCAB20D7B4F391E ** get_address_of_targetPs_6() { return &___targetPs_6; }
	inline void set_targetPs_6(ParticleSystem_t2F526CCDBD3512879B3FCBE04BCAB20D7B4F391E * value)
	{
		___targetPs_6 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___targetPs_6), (void*)value);
	}

	inline static int32_t get_offset_of_isValid_7() { return static_cast<int32_t>(offsetof(AllIn1VfxParticleSystemTime_t1EE72855BC01A8A9547DB7A4C30287E1CDF7E9EF, ___isValid_7)); }
	inline bool get_isValid_7() const { return ___isValid_7; }
	inline bool* get_address_of_isValid_7() { return &___isValid_7; }
	inline void set_isValid_7(bool value)
	{
		___isValid_7 = value;
	}
};


// UnityEngine.EventSystems.UIBehaviour
struct UIBehaviour_tD1C6E2D542222546D68510ECE74036EFBC3C3B0E  : public MonoBehaviour_t37A501200D970A8257124B0EAE00A0FF3DDC354A
{
public:

public:
};


// UnityEngine.UI.Graphic
struct Graphic_tF07D777035055CF93BA5F46F77ED5EDFEFF9AE24  : public UIBehaviour_tD1C6E2D542222546D68510ECE74036EFBC3C3B0E
{
public:
	// UnityEngine.Material UnityEngine.UI.Graphic::m_Material
	Material_t8927C00353A72755313F046D0CE85178AE8218EE * ___m_Material_6;
	// UnityEngine.Color UnityEngine.UI.Graphic::m_Color
	Color_tF40DAF76C04FFECF3FE6024F85A294741C9CC659  ___m_Color_7;
	// System.Boolean UnityEngine.UI.Graphic::m_SkipLayoutUpdate
	bool ___m_SkipLayoutUpdate_8;
	// System.Boolean UnityEngine.UI.Graphic::m_SkipMaterialUpdate
	bool ___m_SkipMaterialUpdate_9;
	// System.Boolean UnityEngine.UI.Graphic::m_RaycastTarget
	bool ___m_RaycastTarget_10;
	// UnityEngine.Vector4 UnityEngine.UI.Graphic::m_RaycastPadding
	Vector4_tA56A37FC5661BCC89C3DDC24BE12BA5BCB6A02C7  ___m_RaycastPadding_11;
	// UnityEngine.RectTransform UnityEngine.UI.Graphic::m_RectTransform
	RectTransform_t8A6A306FB29A6C8C22010CF9040E319753571072 * ___m_RectTransform_12;
	// UnityEngine.CanvasRenderer UnityEngine.UI.Graphic::m_CanvasRenderer
	CanvasRenderer_tCF8ABE659F7C3A6ED0D99A988D0BDFB651310F0E * ___m_CanvasRenderer_13;
	// UnityEngine.Canvas UnityEngine.UI.Graphic::m_Canvas
	Canvas_t2B7E56B7BDC287962E092755372E214ACB6393EA * ___m_Canvas_14;
	// System.Boolean UnityEngine.UI.Graphic::m_VertsDirty
	bool ___m_VertsDirty_15;
	// System.Boolean UnityEngine.UI.Graphic::m_MaterialDirty
	bool ___m_MaterialDirty_16;
	// UnityEngine.Events.UnityAction UnityEngine.UI.Graphic::m_OnDirtyLayoutCallback
	UnityAction_t22E545F8BE0A62EE051C6A83E209587A0DB1C099 * ___m_OnDirtyLayoutCallback_17;
	// UnityEngine.Events.UnityAction UnityEngine.UI.Graphic::m_OnDirtyVertsCallback
	UnityAction_t22E545F8BE0A62EE051C6A83E209587A0DB1C099 * ___m_OnDirtyVertsCallback_18;
	// UnityEngine.Events.UnityAction UnityEngine.UI.Graphic::m_OnDirtyMaterialCallback
	UnityAction_t22E545F8BE0A62EE051C6A83E209587A0DB1C099 * ___m_OnDirtyMaterialCallback_19;
	// UnityEngine.Mesh UnityEngine.UI.Graphic::m_CachedMesh
	Mesh_t2F5992DBA650D5862B43D3823ACD997132A57DA6 * ___m_CachedMesh_22;
	// UnityEngine.Vector2[] UnityEngine.UI.Graphic::m_CachedUvs
	Vector2U5BU5D_tE0F58A2D6D8592B5EC37D9CDEF09103A02E5D7FA* ___m_CachedUvs_23;
	// UnityEngine.UI.CoroutineTween.TweenRunner`1<UnityEngine.UI.CoroutineTween.ColorTween> UnityEngine.UI.Graphic::m_ColorTweenRunner
	TweenRunner_1_tD84B9953874682FCC36990AF2C54D748293908F3 * ___m_ColorTweenRunner_24;
	// System.Boolean UnityEngine.UI.Graphic::<useLegacyMeshGeneration>k__BackingField
	bool ___U3CuseLegacyMeshGenerationU3Ek__BackingField_25;

public:
	inline static int32_t get_offset_of_m_Material_6() { return static_cast<int32_t>(offsetof(Graphic_tF07D777035055CF93BA5F46F77ED5EDFEFF9AE24, ___m_Material_6)); }
	inline Material_t8927C00353A72755313F046D0CE85178AE8218EE * get_m_Material_6() const { return ___m_Material_6; }
	inline Material_t8927C00353A72755313F046D0CE85178AE8218EE ** get_address_of_m_Material_6() { return &___m_Material_6; }
	inline void set_m_Material_6(Material_t8927C00353A72755313F046D0CE85178AE8218EE * value)
	{
		___m_Material_6 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___m_Material_6), (void*)value);
	}

	inline static int32_t get_offset_of_m_Color_7() { return static_cast<int32_t>(offsetof(Graphic_tF07D777035055CF93BA5F46F77ED5EDFEFF9AE24, ___m_Color_7)); }
	inline Color_tF40DAF76C04FFECF3FE6024F85A294741C9CC659  get_m_Color_7() const { return ___m_Color_7; }
	inline Color_tF40DAF76C04FFECF3FE6024F85A294741C9CC659 * get_address_of_m_Color_7() { return &___m_Color_7; }
	inline void set_m_Color_7(Color_tF40DAF76C04FFECF3FE6024F85A294741C9CC659  value)
	{
		___m_Color_7 = value;
	}

	inline static int32_t get_offset_of_m_SkipLayoutUpdate_8() { return static_cast<int32_t>(offsetof(Graphic_tF07D777035055CF93BA5F46F77ED5EDFEFF9AE24, ___m_SkipLayoutUpdate_8)); }
	inline bool get_m_SkipLayoutUpdate_8() const { return ___m_SkipLayoutUpdate_8; }
	inline bool* get_address_of_m_SkipLayoutUpdate_8() { return &___m_SkipLayoutUpdate_8; }
	inline void set_m_SkipLayoutUpdate_8(bool value)
	{
		___m_SkipLayoutUpdate_8 = value;
	}

	inline static int32_t get_offset_of_m_SkipMaterialUpdate_9() { return static_cast<int32_t>(offsetof(Graphic_tF07D777035055CF93BA5F46F77ED5EDFEFF9AE24, ___m_SkipMaterialUpdate_9)); }
	inline bool get_m_SkipMaterialUpdate_9() const { return ___m_SkipMaterialUpdate_9; }
	inline bool* get_address_of_m_SkipMaterialUpdate_9() { return &___m_SkipMaterialUpdate_9; }
	inline void set_m_SkipMaterialUpdate_9(bool value)
	{
		___m_SkipMaterialUpdate_9 = value;
	}

	inline static int32_t get_offset_of_m_RaycastTarget_10() { return static_cast<int32_t>(offsetof(Graphic_tF07D777035055CF93BA5F46F77ED5EDFEFF9AE24, ___m_RaycastTarget_10)); }
	inline bool get_m_RaycastTarget_10() const { return ___m_RaycastTarget_10; }
	inline bool* get_address_of_m_RaycastTarget_10() { return &___m_RaycastTarget_10; }
	inline void set_m_RaycastTarget_10(bool value)
	{
		___m_RaycastTarget_10 = value;
	}

	inline static int32_t get_offset_of_m_RaycastPadding_11() { return static_cast<int32_t>(offsetof(Graphic_tF07D777035055CF93BA5F46F77ED5EDFEFF9AE24, ___m_RaycastPadding_11)); }
	inline Vector4_tA56A37FC5661BCC89C3DDC24BE12BA5BCB6A02C7  get_m_RaycastPadding_11() const { return ___m_RaycastPadding_11; }
	inline Vector4_tA56A37FC5661BCC89C3DDC24BE12BA5BCB6A02C7 * get_address_of_m_RaycastPadding_11() { return &___m_RaycastPadding_11; }
	inline void set_m_RaycastPadding_11(Vector4_tA56A37FC5661BCC89C3DDC24BE12BA5BCB6A02C7  value)
	{
		___m_RaycastPadding_11 = value;
	}

	inline static int32_t get_offset_of_m_RectTransform_12() { return static_cast<int32_t>(offsetof(Graphic_tF07D777035055CF93BA5F46F77ED5EDFEFF9AE24, ___m_RectTransform_12)); }
	inline RectTransform_t8A6A306FB29A6C8C22010CF9040E319753571072 * get_m_RectTransform_12() const { return ___m_RectTransform_12; }
	inline RectTransform_t8A6A306FB29A6C8C22010CF9040E319753571072 ** get_address_of_m_RectTransform_12() { return &___m_RectTransform_12; }
	inline void set_m_RectTransform_12(RectTransform_t8A6A306FB29A6C8C22010CF9040E319753571072 * value)
	{
		___m_RectTransform_12 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___m_RectTransform_12), (void*)value);
	}

	inline static int32_t get_offset_of_m_CanvasRenderer_13() { return static_cast<int32_t>(offsetof(Graphic_tF07D777035055CF93BA5F46F77ED5EDFEFF9AE24, ___m_CanvasRenderer_13)); }
	inline CanvasRenderer_tCF8ABE659F7C3A6ED0D99A988D0BDFB651310F0E * get_m_CanvasRenderer_13() const { return ___m_CanvasRenderer_13; }
	inline CanvasRenderer_tCF8ABE659F7C3A6ED0D99A988D0BDFB651310F0E ** get_address_of_m_CanvasRenderer_13() { return &___m_CanvasRenderer_13; }
	inline void set_m_CanvasRenderer_13(CanvasRenderer_tCF8ABE659F7C3A6ED0D99A988D0BDFB651310F0E * value)
	{
		___m_CanvasRenderer_13 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___m_CanvasRenderer_13), (void*)value);
	}

	inline static int32_t get_offset_of_m_Canvas_14() { return static_cast<int32_t>(offsetof(Graphic_tF07D777035055CF93BA5F46F77ED5EDFEFF9AE24, ___m_Canvas_14)); }
	inline Canvas_t2B7E56B7BDC287962E092755372E214ACB6393EA * get_m_Canvas_14() const { return ___m_Canvas_14; }
	inline Canvas_t2B7E56B7BDC287962E092755372E214ACB6393EA ** get_address_of_m_Canvas_14() { return &___m_Canvas_14; }
	inline void set_m_Canvas_14(Canvas_t2B7E56B7BDC287962E092755372E214ACB6393EA * value)
	{
		___m_Canvas_14 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___m_Canvas_14), (void*)value);
	}

	inline static int32_t get_offset_of_m_VertsDirty_15() { return static_cast<int32_t>(offsetof(Graphic_tF07D777035055CF93BA5F46F77ED5EDFEFF9AE24, ___m_VertsDirty_15)); }
	inline bool get_m_VertsDirty_15() const { return ___m_VertsDirty_15; }
	inline bool* get_address_of_m_VertsDirty_15() { return &___m_VertsDirty_15; }
	inline void set_m_VertsDirty_15(bool value)
	{
		___m_VertsDirty_15 = value;
	}

	inline static int32_t get_offset_of_m_MaterialDirty_16() { return static_cast<int32_t>(offsetof(Graphic_tF07D777035055CF93BA5F46F77ED5EDFEFF9AE24, ___m_MaterialDirty_16)); }
	inline bool get_m_MaterialDirty_16() const { return ___m_MaterialDirty_16; }
	inline bool* get_address_of_m_MaterialDirty_16() { return &___m_MaterialDirty_16; }
	inline void set_m_MaterialDirty_16(bool value)
	{
		___m_MaterialDirty_16 = value;
	}

	inline static int32_t get_offset_of_m_OnDirtyLayoutCallback_17() { return static_cast<int32_t>(offsetof(Graphic_tF07D777035055CF93BA5F46F77ED5EDFEFF9AE24, ___m_OnDirtyLayoutCallback_17)); }
	inline UnityAction_t22E545F8BE0A62EE051C6A83E209587A0DB1C099 * get_m_OnDirtyLayoutCallback_17() const { return ___m_OnDirtyLayoutCallback_17; }
	inline UnityAction_t22E545F8BE0A62EE051C6A83E209587A0DB1C099 ** get_address_of_m_OnDirtyLayoutCallback_17() { return &___m_OnDirtyLayoutCallback_17; }
	inline void set_m_OnDirtyLayoutCallback_17(UnityAction_t22E545F8BE0A62EE051C6A83E209587A0DB1C099 * value)
	{
		___m_OnDirtyLayoutCallback_17 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___m_OnDirtyLayoutCallback_17), (void*)value);
	}

	inline static int32_t get_offset_of_m_OnDirtyVertsCallback_18() { return static_cast<int32_t>(offsetof(Graphic_tF07D777035055CF93BA5F46F77ED5EDFEFF9AE24, ___m_OnDirtyVertsCallback_18)); }
	inline UnityAction_t22E545F8BE0A62EE051C6A83E209587A0DB1C099 * get_m_OnDirtyVertsCallback_18() const { return ___m_OnDirtyVertsCallback_18; }
	inline UnityAction_t22E545F8BE0A62EE051C6A83E209587A0DB1C099 ** get_address_of_m_OnDirtyVertsCallback_18() { return &___m_OnDirtyVertsCallback_18; }
	inline void set_m_OnDirtyVertsCallback_18(UnityAction_t22E545F8BE0A62EE051C6A83E209587A0DB1C099 * value)
	{
		___m_OnDirtyVertsCallback_18 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___m_OnDirtyVertsCallback_18), (void*)value);
	}

	inline static int32_t get_offset_of_m_OnDirtyMaterialCallback_19() { return static_cast<int32_t>(offsetof(Graphic_tF07D777035055CF93BA5F46F77ED5EDFEFF9AE24, ___m_OnDirtyMaterialCallback_19)); }
	inline UnityAction_t22E545F8BE0A62EE051C6A83E209587A0DB1C099 * get_m_OnDirtyMaterialCallback_19() const { return ___m_OnDirtyMaterialCallback_19; }
	inline UnityAction_t22E545F8BE0A62EE051C6A83E209587A0DB1C099 ** get_address_of_m_OnDirtyMaterialCallback_19() { return &___m_OnDirtyMaterialCallback_19; }
	inline void set_m_OnDirtyMaterialCallback_19(UnityAction_t22E545F8BE0A62EE051C6A83E209587A0DB1C099 * value)
	{
		___m_OnDirtyMaterialCallback_19 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___m_OnDirtyMaterialCallback_19), (void*)value);
	}

	inline static int32_t get_offset_of_m_CachedMesh_22() { return static_cast<int32_t>(offsetof(Graphic_tF07D777035055CF93BA5F46F77ED5EDFEFF9AE24, ___m_CachedMesh_22)); }
	inline Mesh_t2F5992DBA650D5862B43D3823ACD997132A57DA6 * get_m_CachedMesh_22() const { return ___m_CachedMesh_22; }
	inline Mesh_t2F5992DBA650D5862B43D3823ACD997132A57DA6 ** get_address_of_m_CachedMesh_22() { return &___m_CachedMesh_22; }
	inline void set_m_CachedMesh_22(Mesh_t2F5992DBA650D5862B43D3823ACD997132A57DA6 * value)
	{
		___m_CachedMesh_22 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___m_CachedMesh_22), (void*)value);
	}

	inline static int32_t get_offset_of_m_CachedUvs_23() { return static_cast<int32_t>(offsetof(Graphic_tF07D777035055CF93BA5F46F77ED5EDFEFF9AE24, ___m_CachedUvs_23)); }
	inline Vector2U5BU5D_tE0F58A2D6D8592B5EC37D9CDEF09103A02E5D7FA* get_m_CachedUvs_23() const { return ___m_CachedUvs_23; }
	inline Vector2U5BU5D_tE0F58A2D6D8592B5EC37D9CDEF09103A02E5D7FA** get_address_of_m_CachedUvs_23() { return &___m_CachedUvs_23; }
	inline void set_m_CachedUvs_23(Vector2U5BU5D_tE0F58A2D6D8592B5EC37D9CDEF09103A02E5D7FA* value)
	{
		___m_CachedUvs_23 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___m_CachedUvs_23), (void*)value);
	}

	inline static int32_t get_offset_of_m_ColorTweenRunner_24() { return static_cast<int32_t>(offsetof(Graphic_tF07D777035055CF93BA5F46F77ED5EDFEFF9AE24, ___m_ColorTweenRunner_24)); }
	inline TweenRunner_1_tD84B9953874682FCC36990AF2C54D748293908F3 * get_m_ColorTweenRunner_24() const { return ___m_ColorTweenRunner_24; }
	inline TweenRunner_1_tD84B9953874682FCC36990AF2C54D748293908F3 ** get_address_of_m_ColorTweenRunner_24() { return &___m_ColorTweenRunner_24; }
	inline void set_m_ColorTweenRunner_24(TweenRunner_1_tD84B9953874682FCC36990AF2C54D748293908F3 * value)
	{
		___m_ColorTweenRunner_24 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___m_ColorTweenRunner_24), (void*)value);
	}

	inline static int32_t get_offset_of_U3CuseLegacyMeshGenerationU3Ek__BackingField_25() { return static_cast<int32_t>(offsetof(Graphic_tF07D777035055CF93BA5F46F77ED5EDFEFF9AE24, ___U3CuseLegacyMeshGenerationU3Ek__BackingField_25)); }
	inline bool get_U3CuseLegacyMeshGenerationU3Ek__BackingField_25() const { return ___U3CuseLegacyMeshGenerationU3Ek__BackingField_25; }
	inline bool* get_address_of_U3CuseLegacyMeshGenerationU3Ek__BackingField_25() { return &___U3CuseLegacyMeshGenerationU3Ek__BackingField_25; }
	inline void set_U3CuseLegacyMeshGenerationU3Ek__BackingField_25(bool value)
	{
		___U3CuseLegacyMeshGenerationU3Ek__BackingField_25 = value;
	}
};

struct Graphic_tF07D777035055CF93BA5F46F77ED5EDFEFF9AE24_StaticFields
{
public:
	// UnityEngine.Material UnityEngine.UI.Graphic::s_DefaultUI
	Material_t8927C00353A72755313F046D0CE85178AE8218EE * ___s_DefaultUI_4;
	// UnityEngine.Texture2D UnityEngine.UI.Graphic::s_WhiteTexture
	Texture2D_t9B604D0D8E28032123641A7E7338FA872E2698BF * ___s_WhiteTexture_5;
	// UnityEngine.Mesh UnityEngine.UI.Graphic::s_Mesh
	Mesh_t2F5992DBA650D5862B43D3823ACD997132A57DA6 * ___s_Mesh_20;
	// UnityEngine.UI.VertexHelper UnityEngine.UI.Graphic::s_VertexHelper
	VertexHelper_tDE8B67D3B076061C4F8DF325B0D63ED2E5367E55 * ___s_VertexHelper_21;

public:
	inline static int32_t get_offset_of_s_DefaultUI_4() { return static_cast<int32_t>(offsetof(Graphic_tF07D777035055CF93BA5F46F77ED5EDFEFF9AE24_StaticFields, ___s_DefaultUI_4)); }
	inline Material_t8927C00353A72755313F046D0CE85178AE8218EE * get_s_DefaultUI_4() const { return ___s_DefaultUI_4; }
	inline Material_t8927C00353A72755313F046D0CE85178AE8218EE ** get_address_of_s_DefaultUI_4() { return &___s_DefaultUI_4; }
	inline void set_s_DefaultUI_4(Material_t8927C00353A72755313F046D0CE85178AE8218EE * value)
	{
		___s_DefaultUI_4 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___s_DefaultUI_4), (void*)value);
	}

	inline static int32_t get_offset_of_s_WhiteTexture_5() { return static_cast<int32_t>(offsetof(Graphic_tF07D777035055CF93BA5F46F77ED5EDFEFF9AE24_StaticFields, ___s_WhiteTexture_5)); }
	inline Texture2D_t9B604D0D8E28032123641A7E7338FA872E2698BF * get_s_WhiteTexture_5() const { return ___s_WhiteTexture_5; }
	inline Texture2D_t9B604D0D8E28032123641A7E7338FA872E2698BF ** get_address_of_s_WhiteTexture_5() { return &___s_WhiteTexture_5; }
	inline void set_s_WhiteTexture_5(Texture2D_t9B604D0D8E28032123641A7E7338FA872E2698BF * value)
	{
		___s_WhiteTexture_5 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___s_WhiteTexture_5), (void*)value);
	}

	inline static int32_t get_offset_of_s_Mesh_20() { return static_cast<int32_t>(offsetof(Graphic_tF07D777035055CF93BA5F46F77ED5EDFEFF9AE24_StaticFields, ___s_Mesh_20)); }
	inline Mesh_t2F5992DBA650D5862B43D3823ACD997132A57DA6 * get_s_Mesh_20() const { return ___s_Mesh_20; }
	inline Mesh_t2F5992DBA650D5862B43D3823ACD997132A57DA6 ** get_address_of_s_Mesh_20() { return &___s_Mesh_20; }
	inline void set_s_Mesh_20(Mesh_t2F5992DBA650D5862B43D3823ACD997132A57DA6 * value)
	{
		___s_Mesh_20 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___s_Mesh_20), (void*)value);
	}

	inline static int32_t get_offset_of_s_VertexHelper_21() { return static_cast<int32_t>(offsetof(Graphic_tF07D777035055CF93BA5F46F77ED5EDFEFF9AE24_StaticFields, ___s_VertexHelper_21)); }
	inline VertexHelper_tDE8B67D3B076061C4F8DF325B0D63ED2E5367E55 * get_s_VertexHelper_21() const { return ___s_VertexHelper_21; }
	inline VertexHelper_tDE8B67D3B076061C4F8DF325B0D63ED2E5367E55 ** get_address_of_s_VertexHelper_21() { return &___s_VertexHelper_21; }
	inline void set_s_VertexHelper_21(VertexHelper_tDE8B67D3B076061C4F8DF325B0D63ED2E5367E55 * value)
	{
		___s_VertexHelper_21 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___s_VertexHelper_21), (void*)value);
	}
};


// UnityEngine.UI.Selectable
struct Selectable_t34088A3677CC9D344F81B0D91999D8C5963D7DBD  : public UIBehaviour_tD1C6E2D542222546D68510ECE74036EFBC3C3B0E
{
public:
	// System.Boolean UnityEngine.UI.Selectable::m_EnableCalled
	bool ___m_EnableCalled_6;
	// UnityEngine.UI.Navigation UnityEngine.UI.Selectable::m_Navigation
	Navigation_t1CF0FFB22C0357CD64714FB7A40A275F899D363A  ___m_Navigation_7;
	// UnityEngine.UI.Selectable/Transition UnityEngine.UI.Selectable::m_Transition
	int32_t ___m_Transition_8;
	// UnityEngine.UI.ColorBlock UnityEngine.UI.Selectable::m_Colors
	ColorBlock_t04DFBB97B4772D2E00FD17ED2E3E6590E6916955  ___m_Colors_9;
	// UnityEngine.UI.SpriteState UnityEngine.UI.Selectable::m_SpriteState
	SpriteState_t9024961148433175CE2F3D9E8E9239A8B1CAB15E  ___m_SpriteState_10;
	// UnityEngine.UI.AnimationTriggers UnityEngine.UI.Selectable::m_AnimationTriggers
	AnimationTriggers_tF38CA7FA631709E096B57D732668D86081F44C11 * ___m_AnimationTriggers_11;
	// System.Boolean UnityEngine.UI.Selectable::m_Interactable
	bool ___m_Interactable_12;
	// UnityEngine.UI.Graphic UnityEngine.UI.Selectable::m_TargetGraphic
	Graphic_tF07D777035055CF93BA5F46F77ED5EDFEFF9AE24 * ___m_TargetGraphic_13;
	// System.Boolean UnityEngine.UI.Selectable::m_GroupsAllowInteraction
	bool ___m_GroupsAllowInteraction_14;
	// System.Int32 UnityEngine.UI.Selectable::m_CurrentIndex
	int32_t ___m_CurrentIndex_15;
	// System.Boolean UnityEngine.UI.Selectable::<isPointerInside>k__BackingField
	bool ___U3CisPointerInsideU3Ek__BackingField_16;
	// System.Boolean UnityEngine.UI.Selectable::<isPointerDown>k__BackingField
	bool ___U3CisPointerDownU3Ek__BackingField_17;
	// System.Boolean UnityEngine.UI.Selectable::<hasSelection>k__BackingField
	bool ___U3ChasSelectionU3Ek__BackingField_18;
	// System.Collections.Generic.List`1<UnityEngine.CanvasGroup> UnityEngine.UI.Selectable::m_CanvasGroupCache
	List_1_t34AA4AF4E7352129CA58045901530E41445AC16D * ___m_CanvasGroupCache_19;

public:
	inline static int32_t get_offset_of_m_EnableCalled_6() { return static_cast<int32_t>(offsetof(Selectable_t34088A3677CC9D344F81B0D91999D8C5963D7DBD, ___m_EnableCalled_6)); }
	inline bool get_m_EnableCalled_6() const { return ___m_EnableCalled_6; }
	inline bool* get_address_of_m_EnableCalled_6() { return &___m_EnableCalled_6; }
	inline void set_m_EnableCalled_6(bool value)
	{
		___m_EnableCalled_6 = value;
	}

	inline static int32_t get_offset_of_m_Navigation_7() { return static_cast<int32_t>(offsetof(Selectable_t34088A3677CC9D344F81B0D91999D8C5963D7DBD, ___m_Navigation_7)); }
	inline Navigation_t1CF0FFB22C0357CD64714FB7A40A275F899D363A  get_m_Navigation_7() const { return ___m_Navigation_7; }
	inline Navigation_t1CF0FFB22C0357CD64714FB7A40A275F899D363A * get_address_of_m_Navigation_7() { return &___m_Navigation_7; }
	inline void set_m_Navigation_7(Navigation_t1CF0FFB22C0357CD64714FB7A40A275F899D363A  value)
	{
		___m_Navigation_7 = value;
		Il2CppCodeGenWriteBarrier((void**)&(((&___m_Navigation_7))->___m_SelectOnUp_2), (void*)NULL);
		#if IL2CPP_ENABLE_STRICT_WRITE_BARRIERS
		Il2CppCodeGenWriteBarrier((void**)&(((&___m_Navigation_7))->___m_SelectOnDown_3), (void*)NULL);
		#endif
		#if IL2CPP_ENABLE_STRICT_WRITE_BARRIERS
		Il2CppCodeGenWriteBarrier((void**)&(((&___m_Navigation_7))->___m_SelectOnLeft_4), (void*)NULL);
		#endif
		#if IL2CPP_ENABLE_STRICT_WRITE_BARRIERS
		Il2CppCodeGenWriteBarrier((void**)&(((&___m_Navigation_7))->___m_SelectOnRight_5), (void*)NULL);
		#endif
	}

	inline static int32_t get_offset_of_m_Transition_8() { return static_cast<int32_t>(offsetof(Selectable_t34088A3677CC9D344F81B0D91999D8C5963D7DBD, ___m_Transition_8)); }
	inline int32_t get_m_Transition_8() const { return ___m_Transition_8; }
	inline int32_t* get_address_of_m_Transition_8() { return &___m_Transition_8; }
	inline void set_m_Transition_8(int32_t value)
	{
		___m_Transition_8 = value;
	}

	inline static int32_t get_offset_of_m_Colors_9() { return static_cast<int32_t>(offsetof(Selectable_t34088A3677CC9D344F81B0D91999D8C5963D7DBD, ___m_Colors_9)); }
	inline ColorBlock_t04DFBB97B4772D2E00FD17ED2E3E6590E6916955  get_m_Colors_9() const { return ___m_Colors_9; }
	inline ColorBlock_t04DFBB97B4772D2E00FD17ED2E3E6590E6916955 * get_address_of_m_Colors_9() { return &___m_Colors_9; }
	inline void set_m_Colors_9(ColorBlock_t04DFBB97B4772D2E00FD17ED2E3E6590E6916955  value)
	{
		___m_Colors_9 = value;
	}

	inline static int32_t get_offset_of_m_SpriteState_10() { return static_cast<int32_t>(offsetof(Selectable_t34088A3677CC9D344F81B0D91999D8C5963D7DBD, ___m_SpriteState_10)); }
	inline SpriteState_t9024961148433175CE2F3D9E8E9239A8B1CAB15E  get_m_SpriteState_10() const { return ___m_SpriteState_10; }
	inline SpriteState_t9024961148433175CE2F3D9E8E9239A8B1CAB15E * get_address_of_m_SpriteState_10() { return &___m_SpriteState_10; }
	inline void set_m_SpriteState_10(SpriteState_t9024961148433175CE2F3D9E8E9239A8B1CAB15E  value)
	{
		___m_SpriteState_10 = value;
		Il2CppCodeGenWriteBarrier((void**)&(((&___m_SpriteState_10))->___m_HighlightedSprite_0), (void*)NULL);
		#if IL2CPP_ENABLE_STRICT_WRITE_BARRIERS
		Il2CppCodeGenWriteBarrier((void**)&(((&___m_SpriteState_10))->___m_PressedSprite_1), (void*)NULL);
		#endif
		#if IL2CPP_ENABLE_STRICT_WRITE_BARRIERS
		Il2CppCodeGenWriteBarrier((void**)&(((&___m_SpriteState_10))->___m_SelectedSprite_2), (void*)NULL);
		#endif
		#if IL2CPP_ENABLE_STRICT_WRITE_BARRIERS
		Il2CppCodeGenWriteBarrier((void**)&(((&___m_SpriteState_10))->___m_DisabledSprite_3), (void*)NULL);
		#endif
	}

	inline static int32_t get_offset_of_m_AnimationTriggers_11() { return static_cast<int32_t>(offsetof(Selectable_t34088A3677CC9D344F81B0D91999D8C5963D7DBD, ___m_AnimationTriggers_11)); }
	inline AnimationTriggers_tF38CA7FA631709E096B57D732668D86081F44C11 * get_m_AnimationTriggers_11() const { return ___m_AnimationTriggers_11; }
	inline AnimationTriggers_tF38CA7FA631709E096B57D732668D86081F44C11 ** get_address_of_m_AnimationTriggers_11() { return &___m_AnimationTriggers_11; }
	inline void set_m_AnimationTriggers_11(AnimationTriggers_tF38CA7FA631709E096B57D732668D86081F44C11 * value)
	{
		___m_AnimationTriggers_11 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___m_AnimationTriggers_11), (void*)value);
	}

	inline static int32_t get_offset_of_m_Interactable_12() { return static_cast<int32_t>(offsetof(Selectable_t34088A3677CC9D344F81B0D91999D8C5963D7DBD, ___m_Interactable_12)); }
	inline bool get_m_Interactable_12() const { return ___m_Interactable_12; }
	inline bool* get_address_of_m_Interactable_12() { return &___m_Interactable_12; }
	inline void set_m_Interactable_12(bool value)
	{
		___m_Interactable_12 = value;
	}

	inline static int32_t get_offset_of_m_TargetGraphic_13() { return static_cast<int32_t>(offsetof(Selectable_t34088A3677CC9D344F81B0D91999D8C5963D7DBD, ___m_TargetGraphic_13)); }
	inline Graphic_tF07D777035055CF93BA5F46F77ED5EDFEFF9AE24 * get_m_TargetGraphic_13() const { return ___m_TargetGraphic_13; }
	inline Graphic_tF07D777035055CF93BA5F46F77ED5EDFEFF9AE24 ** get_address_of_m_TargetGraphic_13() { return &___m_TargetGraphic_13; }
	inline void set_m_TargetGraphic_13(Graphic_tF07D777035055CF93BA5F46F77ED5EDFEFF9AE24 * value)
	{
		___m_TargetGraphic_13 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___m_TargetGraphic_13), (void*)value);
	}

	inline static int32_t get_offset_of_m_GroupsAllowInteraction_14() { return static_cast<int32_t>(offsetof(Selectable_t34088A3677CC9D344F81B0D91999D8C5963D7DBD, ___m_GroupsAllowInteraction_14)); }
	inline bool get_m_GroupsAllowInteraction_14() const { return ___m_GroupsAllowInteraction_14; }
	inline bool* get_address_of_m_GroupsAllowInteraction_14() { return &___m_GroupsAllowInteraction_14; }
	inline void set_m_GroupsAllowInteraction_14(bool value)
	{
		___m_GroupsAllowInteraction_14 = value;
	}

	inline static int32_t get_offset_of_m_CurrentIndex_15() { return static_cast<int32_t>(offsetof(Selectable_t34088A3677CC9D344F81B0D91999D8C5963D7DBD, ___m_CurrentIndex_15)); }
	inline int32_t get_m_CurrentIndex_15() const { return ___m_CurrentIndex_15; }
	inline int32_t* get_address_of_m_CurrentIndex_15() { return &___m_CurrentIndex_15; }
	inline void set_m_CurrentIndex_15(int32_t value)
	{
		___m_CurrentIndex_15 = value;
	}

	inline static int32_t get_offset_of_U3CisPointerInsideU3Ek__BackingField_16() { return static_cast<int32_t>(offsetof(Selectable_t34088A3677CC9D344F81B0D91999D8C5963D7DBD, ___U3CisPointerInsideU3Ek__BackingField_16)); }
	inline bool get_U3CisPointerInsideU3Ek__BackingField_16() const { return ___U3CisPointerInsideU3Ek__BackingField_16; }
	inline bool* get_address_of_U3CisPointerInsideU3Ek__BackingField_16() { return &___U3CisPointerInsideU3Ek__BackingField_16; }
	inline void set_U3CisPointerInsideU3Ek__BackingField_16(bool value)
	{
		___U3CisPointerInsideU3Ek__BackingField_16 = value;
	}

	inline static int32_t get_offset_of_U3CisPointerDownU3Ek__BackingField_17() { return static_cast<int32_t>(offsetof(Selectable_t34088A3677CC9D344F81B0D91999D8C5963D7DBD, ___U3CisPointerDownU3Ek__BackingField_17)); }
	inline bool get_U3CisPointerDownU3Ek__BackingField_17() const { return ___U3CisPointerDownU3Ek__BackingField_17; }
	inline bool* get_address_of_U3CisPointerDownU3Ek__BackingField_17() { return &___U3CisPointerDownU3Ek__BackingField_17; }
	inline void set_U3CisPointerDownU3Ek__BackingField_17(bool value)
	{
		___U3CisPointerDownU3Ek__BackingField_17 = value;
	}

	inline static int32_t get_offset_of_U3ChasSelectionU3Ek__BackingField_18() { return static_cast<int32_t>(offsetof(Selectable_t34088A3677CC9D344F81B0D91999D8C5963D7DBD, ___U3ChasSelectionU3Ek__BackingField_18)); }
	inline bool get_U3ChasSelectionU3Ek__BackingField_18() const { return ___U3ChasSelectionU3Ek__BackingField_18; }
	inline bool* get_address_of_U3ChasSelectionU3Ek__BackingField_18() { return &___U3ChasSelectionU3Ek__BackingField_18; }
	inline void set_U3ChasSelectionU3Ek__BackingField_18(bool value)
	{
		___U3ChasSelectionU3Ek__BackingField_18 = value;
	}

	inline static int32_t get_offset_of_m_CanvasGroupCache_19() { return static_cast<int32_t>(offsetof(Selectable_t34088A3677CC9D344F81B0D91999D8C5963D7DBD, ___m_CanvasGroupCache_19)); }
	inline List_1_t34AA4AF4E7352129CA58045901530E41445AC16D * get_m_CanvasGroupCache_19() const { return ___m_CanvasGroupCache_19; }
	inline List_1_t34AA4AF4E7352129CA58045901530E41445AC16D ** get_address_of_m_CanvasGroupCache_19() { return &___m_CanvasGroupCache_19; }
	inline void set_m_CanvasGroupCache_19(List_1_t34AA4AF4E7352129CA58045901530E41445AC16D * value)
	{
		___m_CanvasGroupCache_19 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___m_CanvasGroupCache_19), (void*)value);
	}
};

struct Selectable_t34088A3677CC9D344F81B0D91999D8C5963D7DBD_StaticFields
{
public:
	// UnityEngine.UI.Selectable[] UnityEngine.UI.Selectable::s_Selectables
	SelectableU5BU5D_tECF9F5BDBF0652A937D18F10C883EFDAE2E62535* ___s_Selectables_4;
	// System.Int32 UnityEngine.UI.Selectable::s_SelectableCount
	int32_t ___s_SelectableCount_5;

public:
	inline static int32_t get_offset_of_s_Selectables_4() { return static_cast<int32_t>(offsetof(Selectable_t34088A3677CC9D344F81B0D91999D8C5963D7DBD_StaticFields, ___s_Selectables_4)); }
	inline SelectableU5BU5D_tECF9F5BDBF0652A937D18F10C883EFDAE2E62535* get_s_Selectables_4() const { return ___s_Selectables_4; }
	inline SelectableU5BU5D_tECF9F5BDBF0652A937D18F10C883EFDAE2E62535** get_address_of_s_Selectables_4() { return &___s_Selectables_4; }
	inline void set_s_Selectables_4(SelectableU5BU5D_tECF9F5BDBF0652A937D18F10C883EFDAE2E62535* value)
	{
		___s_Selectables_4 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___s_Selectables_4), (void*)value);
	}

	inline static int32_t get_offset_of_s_SelectableCount_5() { return static_cast<int32_t>(offsetof(Selectable_t34088A3677CC9D344F81B0D91999D8C5963D7DBD_StaticFields, ___s_SelectableCount_5)); }
	inline int32_t get_s_SelectableCount_5() const { return ___s_SelectableCount_5; }
	inline int32_t* get_address_of_s_SelectableCount_5() { return &___s_SelectableCount_5; }
	inline void set_s_SelectableCount_5(int32_t value)
	{
		___s_SelectableCount_5 = value;
	}
};


// UnityEngine.UI.Button
struct Button_tA893FC15AB26E1439AC25BDCA7079530587BB65D  : public Selectable_t34088A3677CC9D344F81B0D91999D8C5963D7DBD
{
public:
	// UnityEngine.UI.Button/ButtonClickedEvent UnityEngine.UI.Button::m_OnClick
	ButtonClickedEvent_tE6D6D94ED8100451CF00D2BED1FB2253F37BB14F * ___m_OnClick_20;

public:
	inline static int32_t get_offset_of_m_OnClick_20() { return static_cast<int32_t>(offsetof(Button_tA893FC15AB26E1439AC25BDCA7079530587BB65D, ___m_OnClick_20)); }
	inline ButtonClickedEvent_tE6D6D94ED8100451CF00D2BED1FB2253F37BB14F * get_m_OnClick_20() const { return ___m_OnClick_20; }
	inline ButtonClickedEvent_tE6D6D94ED8100451CF00D2BED1FB2253F37BB14F ** get_address_of_m_OnClick_20() { return &___m_OnClick_20; }
	inline void set_m_OnClick_20(ButtonClickedEvent_tE6D6D94ED8100451CF00D2BED1FB2253F37BB14F * value)
	{
		___m_OnClick_20 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___m_OnClick_20), (void*)value);
	}
};


// UnityEngine.UI.Dropdown
struct Dropdown_t099F5232BB75810BC79EED6E27DDCED46C3BCD96  : public Selectable_t34088A3677CC9D344F81B0D91999D8C5963D7DBD
{
public:
	// UnityEngine.RectTransform UnityEngine.UI.Dropdown::m_Template
	RectTransform_t8A6A306FB29A6C8C22010CF9040E319753571072 * ___m_Template_20;
	// UnityEngine.UI.Text UnityEngine.UI.Dropdown::m_CaptionText
	Text_t6A2339DA6C05AE2646FC1A6C8FCC127391BE7FA1 * ___m_CaptionText_21;
	// UnityEngine.UI.Image UnityEngine.UI.Dropdown::m_CaptionImage
	Image_t4021FF27176E44BFEDDCBE43C7FE6B713EC70D3C * ___m_CaptionImage_22;
	// UnityEngine.UI.Text UnityEngine.UI.Dropdown::m_ItemText
	Text_t6A2339DA6C05AE2646FC1A6C8FCC127391BE7FA1 * ___m_ItemText_23;
	// UnityEngine.UI.Image UnityEngine.UI.Dropdown::m_ItemImage
	Image_t4021FF27176E44BFEDDCBE43C7FE6B713EC70D3C * ___m_ItemImage_24;
	// System.Int32 UnityEngine.UI.Dropdown::m_Value
	int32_t ___m_Value_25;
	// UnityEngine.UI.Dropdown/OptionDataList UnityEngine.UI.Dropdown::m_Options
	OptionDataList_t524EBDB7A2B178269FD5B4740108D0EC6404B4B6 * ___m_Options_26;
	// UnityEngine.UI.Dropdown/DropdownEvent UnityEngine.UI.Dropdown::m_OnValueChanged
	DropdownEvent_tEB2C75C3DBC789936B31D9A979FD62E047846CFB * ___m_OnValueChanged_27;
	// System.Single UnityEngine.UI.Dropdown::m_AlphaFadeSpeed
	float ___m_AlphaFadeSpeed_28;
	// UnityEngine.GameObject UnityEngine.UI.Dropdown::m_Dropdown
	GameObject_tC000A2E1A7CF1E10FD7BA08863287C072207C319 * ___m_Dropdown_29;
	// UnityEngine.GameObject UnityEngine.UI.Dropdown::m_Blocker
	GameObject_tC000A2E1A7CF1E10FD7BA08863287C072207C319 * ___m_Blocker_30;
	// System.Collections.Generic.List`1<UnityEngine.UI.Dropdown/DropdownItem> UnityEngine.UI.Dropdown::m_Items
	List_1_t4CFF6A6E1A912AE4990A34B2AA4A1FE2C9FB0033 * ___m_Items_31;
	// UnityEngine.UI.CoroutineTween.TweenRunner`1<UnityEngine.UI.CoroutineTween.FloatTween> UnityEngine.UI.Dropdown::m_AlphaTweenRunner
	TweenRunner_1_t428873023FD8831B6DCE3CBD53ADD7D37AC8222D * ___m_AlphaTweenRunner_32;
	// System.Boolean UnityEngine.UI.Dropdown::validTemplate
	bool ___validTemplate_33;

public:
	inline static int32_t get_offset_of_m_Template_20() { return static_cast<int32_t>(offsetof(Dropdown_t099F5232BB75810BC79EED6E27DDCED46C3BCD96, ___m_Template_20)); }
	inline RectTransform_t8A6A306FB29A6C8C22010CF9040E319753571072 * get_m_Template_20() const { return ___m_Template_20; }
	inline RectTransform_t8A6A306FB29A6C8C22010CF9040E319753571072 ** get_address_of_m_Template_20() { return &___m_Template_20; }
	inline void set_m_Template_20(RectTransform_t8A6A306FB29A6C8C22010CF9040E319753571072 * value)
	{
		___m_Template_20 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___m_Template_20), (void*)value);
	}

	inline static int32_t get_offset_of_m_CaptionText_21() { return static_cast<int32_t>(offsetof(Dropdown_t099F5232BB75810BC79EED6E27DDCED46C3BCD96, ___m_CaptionText_21)); }
	inline Text_t6A2339DA6C05AE2646FC1A6C8FCC127391BE7FA1 * get_m_CaptionText_21() const { return ___m_CaptionText_21; }
	inline Text_t6A2339DA6C05AE2646FC1A6C8FCC127391BE7FA1 ** get_address_of_m_CaptionText_21() { return &___m_CaptionText_21; }
	inline void set_m_CaptionText_21(Text_t6A2339DA6C05AE2646FC1A6C8FCC127391BE7FA1 * value)
	{
		___m_CaptionText_21 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___m_CaptionText_21), (void*)value);
	}

	inline static int32_t get_offset_of_m_CaptionImage_22() { return static_cast<int32_t>(offsetof(Dropdown_t099F5232BB75810BC79EED6E27DDCED46C3BCD96, ___m_CaptionImage_22)); }
	inline Image_t4021FF27176E44BFEDDCBE43C7FE6B713EC70D3C * get_m_CaptionImage_22() const { return ___m_CaptionImage_22; }
	inline Image_t4021FF27176E44BFEDDCBE43C7FE6B713EC70D3C ** get_address_of_m_CaptionImage_22() { return &___m_CaptionImage_22; }
	inline void set_m_CaptionImage_22(Image_t4021FF27176E44BFEDDCBE43C7FE6B713EC70D3C * value)
	{
		___m_CaptionImage_22 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___m_CaptionImage_22), (void*)value);
	}

	inline static int32_t get_offset_of_m_ItemText_23() { return static_cast<int32_t>(offsetof(Dropdown_t099F5232BB75810BC79EED6E27DDCED46C3BCD96, ___m_ItemText_23)); }
	inline Text_t6A2339DA6C05AE2646FC1A6C8FCC127391BE7FA1 * get_m_ItemText_23() const { return ___m_ItemText_23; }
	inline Text_t6A2339DA6C05AE2646FC1A6C8FCC127391BE7FA1 ** get_address_of_m_ItemText_23() { return &___m_ItemText_23; }
	inline void set_m_ItemText_23(Text_t6A2339DA6C05AE2646FC1A6C8FCC127391BE7FA1 * value)
	{
		___m_ItemText_23 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___m_ItemText_23), (void*)value);
	}

	inline static int32_t get_offset_of_m_ItemImage_24() { return static_cast<int32_t>(offsetof(Dropdown_t099F5232BB75810BC79EED6E27DDCED46C3BCD96, ___m_ItemImage_24)); }
	inline Image_t4021FF27176E44BFEDDCBE43C7FE6B713EC70D3C * get_m_ItemImage_24() const { return ___m_ItemImage_24; }
	inline Image_t4021FF27176E44BFEDDCBE43C7FE6B713EC70D3C ** get_address_of_m_ItemImage_24() { return &___m_ItemImage_24; }
	inline void set_m_ItemImage_24(Image_t4021FF27176E44BFEDDCBE43C7FE6B713EC70D3C * value)
	{
		___m_ItemImage_24 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___m_ItemImage_24), (void*)value);
	}

	inline static int32_t get_offset_of_m_Value_25() { return static_cast<int32_t>(offsetof(Dropdown_t099F5232BB75810BC79EED6E27DDCED46C3BCD96, ___m_Value_25)); }
	inline int32_t get_m_Value_25() const { return ___m_Value_25; }
	inline int32_t* get_address_of_m_Value_25() { return &___m_Value_25; }
	inline void set_m_Value_25(int32_t value)
	{
		___m_Value_25 = value;
	}

	inline static int32_t get_offset_of_m_Options_26() { return static_cast<int32_t>(offsetof(Dropdown_t099F5232BB75810BC79EED6E27DDCED46C3BCD96, ___m_Options_26)); }
	inline OptionDataList_t524EBDB7A2B178269FD5B4740108D0EC6404B4B6 * get_m_Options_26() const { return ___m_Options_26; }
	inline OptionDataList_t524EBDB7A2B178269FD5B4740108D0EC6404B4B6 ** get_address_of_m_Options_26() { return &___m_Options_26; }
	inline void set_m_Options_26(OptionDataList_t524EBDB7A2B178269FD5B4740108D0EC6404B4B6 * value)
	{
		___m_Options_26 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___m_Options_26), (void*)value);
	}

	inline static int32_t get_offset_of_m_OnValueChanged_27() { return static_cast<int32_t>(offsetof(Dropdown_t099F5232BB75810BC79EED6E27DDCED46C3BCD96, ___m_OnValueChanged_27)); }
	inline DropdownEvent_tEB2C75C3DBC789936B31D9A979FD62E047846CFB * get_m_OnValueChanged_27() const { return ___m_OnValueChanged_27; }
	inline DropdownEvent_tEB2C75C3DBC789936B31D9A979FD62E047846CFB ** get_address_of_m_OnValueChanged_27() { return &___m_OnValueChanged_27; }
	inline void set_m_OnValueChanged_27(DropdownEvent_tEB2C75C3DBC789936B31D9A979FD62E047846CFB * value)
	{
		___m_OnValueChanged_27 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___m_OnValueChanged_27), (void*)value);
	}

	inline static int32_t get_offset_of_m_AlphaFadeSpeed_28() { return static_cast<int32_t>(offsetof(Dropdown_t099F5232BB75810BC79EED6E27DDCED46C3BCD96, ___m_AlphaFadeSpeed_28)); }
	inline float get_m_AlphaFadeSpeed_28() const { return ___m_AlphaFadeSpeed_28; }
	inline float* get_address_of_m_AlphaFadeSpeed_28() { return &___m_AlphaFadeSpeed_28; }
	inline void set_m_AlphaFadeSpeed_28(float value)
	{
		___m_AlphaFadeSpeed_28 = value;
	}

	inline static int32_t get_offset_of_m_Dropdown_29() { return static_cast<int32_t>(offsetof(Dropdown_t099F5232BB75810BC79EED6E27DDCED46C3BCD96, ___m_Dropdown_29)); }
	inline GameObject_tC000A2E1A7CF1E10FD7BA08863287C072207C319 * get_m_Dropdown_29() const { return ___m_Dropdown_29; }
	inline GameObject_tC000A2E1A7CF1E10FD7BA08863287C072207C319 ** get_address_of_m_Dropdown_29() { return &___m_Dropdown_29; }
	inline void set_m_Dropdown_29(GameObject_tC000A2E1A7CF1E10FD7BA08863287C072207C319 * value)
	{
		___m_Dropdown_29 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___m_Dropdown_29), (void*)value);
	}

	inline static int32_t get_offset_of_m_Blocker_30() { return static_cast<int32_t>(offsetof(Dropdown_t099F5232BB75810BC79EED6E27DDCED46C3BCD96, ___m_Blocker_30)); }
	inline GameObject_tC000A2E1A7CF1E10FD7BA08863287C072207C319 * get_m_Blocker_30() const { return ___m_Blocker_30; }
	inline GameObject_tC000A2E1A7CF1E10FD7BA08863287C072207C319 ** get_address_of_m_Blocker_30() { return &___m_Blocker_30; }
	inline void set_m_Blocker_30(GameObject_tC000A2E1A7CF1E10FD7BA08863287C072207C319 * value)
	{
		___m_Blocker_30 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___m_Blocker_30), (void*)value);
	}

	inline static int32_t get_offset_of_m_Items_31() { return static_cast<int32_t>(offsetof(Dropdown_t099F5232BB75810BC79EED6E27DDCED46C3BCD96, ___m_Items_31)); }
	inline List_1_t4CFF6A6E1A912AE4990A34B2AA4A1FE2C9FB0033 * get_m_Items_31() const { return ___m_Items_31; }
	inline List_1_t4CFF6A6E1A912AE4990A34B2AA4A1FE2C9FB0033 ** get_address_of_m_Items_31() { return &___m_Items_31; }
	inline void set_m_Items_31(List_1_t4CFF6A6E1A912AE4990A34B2AA4A1FE2C9FB0033 * value)
	{
		___m_Items_31 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___m_Items_31), (void*)value);
	}

	inline static int32_t get_offset_of_m_AlphaTweenRunner_32() { return static_cast<int32_t>(offsetof(Dropdown_t099F5232BB75810BC79EED6E27DDCED46C3BCD96, ___m_AlphaTweenRunner_32)); }
	inline TweenRunner_1_t428873023FD8831B6DCE3CBD53ADD7D37AC8222D * get_m_AlphaTweenRunner_32() const { return ___m_AlphaTweenRunner_32; }
	inline TweenRunner_1_t428873023FD8831B6DCE3CBD53ADD7D37AC8222D ** get_address_of_m_AlphaTweenRunner_32() { return &___m_AlphaTweenRunner_32; }
	inline void set_m_AlphaTweenRunner_32(TweenRunner_1_t428873023FD8831B6DCE3CBD53ADD7D37AC8222D * value)
	{
		___m_AlphaTweenRunner_32 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___m_AlphaTweenRunner_32), (void*)value);
	}

	inline static int32_t get_offset_of_validTemplate_33() { return static_cast<int32_t>(offsetof(Dropdown_t099F5232BB75810BC79EED6E27DDCED46C3BCD96, ___validTemplate_33)); }
	inline bool get_validTemplate_33() const { return ___validTemplate_33; }
	inline bool* get_address_of_validTemplate_33() { return &___validTemplate_33; }
	inline void set_validTemplate_33(bool value)
	{
		___validTemplate_33 = value;
	}
};

struct Dropdown_t099F5232BB75810BC79EED6E27DDCED46C3BCD96_StaticFields
{
public:
	// UnityEngine.UI.Dropdown/OptionData UnityEngine.UI.Dropdown::s_NoOptionData
	OptionData_t5F665DC13C1E4307727D66ECC1100B3A77E3E857 * ___s_NoOptionData_35;

public:
	inline static int32_t get_offset_of_s_NoOptionData_35() { return static_cast<int32_t>(offsetof(Dropdown_t099F5232BB75810BC79EED6E27DDCED46C3BCD96_StaticFields, ___s_NoOptionData_35)); }
	inline OptionData_t5F665DC13C1E4307727D66ECC1100B3A77E3E857 * get_s_NoOptionData_35() const { return ___s_NoOptionData_35; }
	inline OptionData_t5F665DC13C1E4307727D66ECC1100B3A77E3E857 ** get_address_of_s_NoOptionData_35() { return &___s_NoOptionData_35; }
	inline void set_s_NoOptionData_35(OptionData_t5F665DC13C1E4307727D66ECC1100B3A77E3E857 * value)
	{
		___s_NoOptionData_35 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___s_NoOptionData_35), (void*)value);
	}
};


// UnityEngine.UI.MaskableGraphic
struct MaskableGraphic_t0DB59E37E3C8AD2F5A4FB7FB091630CB21370CCE  : public Graphic_tF07D777035055CF93BA5F46F77ED5EDFEFF9AE24
{
public:
	// System.Boolean UnityEngine.UI.MaskableGraphic::m_ShouldRecalculateStencil
	bool ___m_ShouldRecalculateStencil_26;
	// UnityEngine.Material UnityEngine.UI.MaskableGraphic::m_MaskMaterial
	Material_t8927C00353A72755313F046D0CE85178AE8218EE * ___m_MaskMaterial_27;
	// UnityEngine.UI.RectMask2D UnityEngine.UI.MaskableGraphic::m_ParentMask
	RectMask2D_tD909811991B341D752E4C978C89EFB80FA7A2B15 * ___m_ParentMask_28;
	// System.Boolean UnityEngine.UI.MaskableGraphic::m_Maskable
	bool ___m_Maskable_29;
	// System.Boolean UnityEngine.UI.MaskableGraphic::m_IsMaskingGraphic
	bool ___m_IsMaskingGraphic_30;
	// System.Boolean UnityEngine.UI.MaskableGraphic::m_IncludeForMasking
	bool ___m_IncludeForMasking_31;
	// UnityEngine.UI.MaskableGraphic/CullStateChangedEvent UnityEngine.UI.MaskableGraphic::m_OnCullStateChanged
	CullStateChangedEvent_t9B69755DEBEF041C3CC15C3604610BDD72856BD4 * ___m_OnCullStateChanged_32;
	// System.Boolean UnityEngine.UI.MaskableGraphic::m_ShouldRecalculate
	bool ___m_ShouldRecalculate_33;
	// System.Int32 UnityEngine.UI.MaskableGraphic::m_StencilValue
	int32_t ___m_StencilValue_34;
	// UnityEngine.Vector3[] UnityEngine.UI.MaskableGraphic::m_Corners
	Vector3U5BU5D_t5FB88EAA33E46838BDC2ABDAEA3E8727491CB9E4* ___m_Corners_35;

public:
	inline static int32_t get_offset_of_m_ShouldRecalculateStencil_26() { return static_cast<int32_t>(offsetof(MaskableGraphic_t0DB59E37E3C8AD2F5A4FB7FB091630CB21370CCE, ___m_ShouldRecalculateStencil_26)); }
	inline bool get_m_ShouldRecalculateStencil_26() const { return ___m_ShouldRecalculateStencil_26; }
	inline bool* get_address_of_m_ShouldRecalculateStencil_26() { return &___m_ShouldRecalculateStencil_26; }
	inline void set_m_ShouldRecalculateStencil_26(bool value)
	{
		___m_ShouldRecalculateStencil_26 = value;
	}

	inline static int32_t get_offset_of_m_MaskMaterial_27() { return static_cast<int32_t>(offsetof(MaskableGraphic_t0DB59E37E3C8AD2F5A4FB7FB091630CB21370CCE, ___m_MaskMaterial_27)); }
	inline Material_t8927C00353A72755313F046D0CE85178AE8218EE * get_m_MaskMaterial_27() const { return ___m_MaskMaterial_27; }
	inline Material_t8927C00353A72755313F046D0CE85178AE8218EE ** get_address_of_m_MaskMaterial_27() { return &___m_MaskMaterial_27; }
	inline void set_m_MaskMaterial_27(Material_t8927C00353A72755313F046D0CE85178AE8218EE * value)
	{
		___m_MaskMaterial_27 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___m_MaskMaterial_27), (void*)value);
	}

	inline static int32_t get_offset_of_m_ParentMask_28() { return static_cast<int32_t>(offsetof(MaskableGraphic_t0DB59E37E3C8AD2F5A4FB7FB091630CB21370CCE, ___m_ParentMask_28)); }
	inline RectMask2D_tD909811991B341D752E4C978C89EFB80FA7A2B15 * get_m_ParentMask_28() const { return ___m_ParentMask_28; }
	inline RectMask2D_tD909811991B341D752E4C978C89EFB80FA7A2B15 ** get_address_of_m_ParentMask_28() { return &___m_ParentMask_28; }
	inline void set_m_ParentMask_28(RectMask2D_tD909811991B341D752E4C978C89EFB80FA7A2B15 * value)
	{
		___m_ParentMask_28 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___m_ParentMask_28), (void*)value);
	}

	inline static int32_t get_offset_of_m_Maskable_29() { return static_cast<int32_t>(offsetof(MaskableGraphic_t0DB59E37E3C8AD2F5A4FB7FB091630CB21370CCE, ___m_Maskable_29)); }
	inline bool get_m_Maskable_29() const { return ___m_Maskable_29; }
	inline bool* get_address_of_m_Maskable_29() { return &___m_Maskable_29; }
	inline void set_m_Maskable_29(bool value)
	{
		___m_Maskable_29 = value;
	}

	inline static int32_t get_offset_of_m_IsMaskingGraphic_30() { return static_cast<int32_t>(offsetof(MaskableGraphic_t0DB59E37E3C8AD2F5A4FB7FB091630CB21370CCE, ___m_IsMaskingGraphic_30)); }
	inline bool get_m_IsMaskingGraphic_30() const { return ___m_IsMaskingGraphic_30; }
	inline bool* get_address_of_m_IsMaskingGraphic_30() { return &___m_IsMaskingGraphic_30; }
	inline void set_m_IsMaskingGraphic_30(bool value)
	{
		___m_IsMaskingGraphic_30 = value;
	}

	inline static int32_t get_offset_of_m_IncludeForMasking_31() { return static_cast<int32_t>(offsetof(MaskableGraphic_t0DB59E37E3C8AD2F5A4FB7FB091630CB21370CCE, ___m_IncludeForMasking_31)); }
	inline bool get_m_IncludeForMasking_31() const { return ___m_IncludeForMasking_31; }
	inline bool* get_address_of_m_IncludeForMasking_31() { return &___m_IncludeForMasking_31; }
	inline void set_m_IncludeForMasking_31(bool value)
	{
		___m_IncludeForMasking_31 = value;
	}

	inline static int32_t get_offset_of_m_OnCullStateChanged_32() { return static_cast<int32_t>(offsetof(MaskableGraphic_t0DB59E37E3C8AD2F5A4FB7FB091630CB21370CCE, ___m_OnCullStateChanged_32)); }
	inline CullStateChangedEvent_t9B69755DEBEF041C3CC15C3604610BDD72856BD4 * get_m_OnCullStateChanged_32() const { return ___m_OnCullStateChanged_32; }
	inline CullStateChangedEvent_t9B69755DEBEF041C3CC15C3604610BDD72856BD4 ** get_address_of_m_OnCullStateChanged_32() { return &___m_OnCullStateChanged_32; }
	inline void set_m_OnCullStateChanged_32(CullStateChangedEvent_t9B69755DEBEF041C3CC15C3604610BDD72856BD4 * value)
	{
		___m_OnCullStateChanged_32 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___m_OnCullStateChanged_32), (void*)value);
	}

	inline static int32_t get_offset_of_m_ShouldRecalculate_33() { return static_cast<int32_t>(offsetof(MaskableGraphic_t0DB59E37E3C8AD2F5A4FB7FB091630CB21370CCE, ___m_ShouldRecalculate_33)); }
	inline bool get_m_ShouldRecalculate_33() const { return ___m_ShouldRecalculate_33; }
	inline bool* get_address_of_m_ShouldRecalculate_33() { return &___m_ShouldRecalculate_33; }
	inline void set_m_ShouldRecalculate_33(bool value)
	{
		___m_ShouldRecalculate_33 = value;
	}

	inline static int32_t get_offset_of_m_StencilValue_34() { return static_cast<int32_t>(offsetof(MaskableGraphic_t0DB59E37E3C8AD2F5A4FB7FB091630CB21370CCE, ___m_StencilValue_34)); }
	inline int32_t get_m_StencilValue_34() const { return ___m_StencilValue_34; }
	inline int32_t* get_address_of_m_StencilValue_34() { return &___m_StencilValue_34; }
	inline void set_m_StencilValue_34(int32_t value)
	{
		___m_StencilValue_34 = value;
	}

	inline static int32_t get_offset_of_m_Corners_35() { return static_cast<int32_t>(offsetof(MaskableGraphic_t0DB59E37E3C8AD2F5A4FB7FB091630CB21370CCE, ___m_Corners_35)); }
	inline Vector3U5BU5D_t5FB88EAA33E46838BDC2ABDAEA3E8727491CB9E4* get_m_Corners_35() const { return ___m_Corners_35; }
	inline Vector3U5BU5D_t5FB88EAA33E46838BDC2ABDAEA3E8727491CB9E4** get_address_of_m_Corners_35() { return &___m_Corners_35; }
	inline void set_m_Corners_35(Vector3U5BU5D_t5FB88EAA33E46838BDC2ABDAEA3E8727491CB9E4* value)
	{
		___m_Corners_35 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___m_Corners_35), (void*)value);
	}
};


// UnityEngine.UI.Slider
struct Slider_tBF39A11CC24CBD3F8BD728982ACAEAE43989B51A  : public Selectable_t34088A3677CC9D344F81B0D91999D8C5963D7DBD
{
public:
	// UnityEngine.RectTransform UnityEngine.UI.Slider::m_FillRect
	RectTransform_t8A6A306FB29A6C8C22010CF9040E319753571072 * ___m_FillRect_20;
	// UnityEngine.RectTransform UnityEngine.UI.Slider::m_HandleRect
	RectTransform_t8A6A306FB29A6C8C22010CF9040E319753571072 * ___m_HandleRect_21;
	// UnityEngine.UI.Slider/Direction UnityEngine.UI.Slider::m_Direction
	int32_t ___m_Direction_22;
	// System.Single UnityEngine.UI.Slider::m_MinValue
	float ___m_MinValue_23;
	// System.Single UnityEngine.UI.Slider::m_MaxValue
	float ___m_MaxValue_24;
	// System.Boolean UnityEngine.UI.Slider::m_WholeNumbers
	bool ___m_WholeNumbers_25;
	// System.Single UnityEngine.UI.Slider::m_Value
	float ___m_Value_26;
	// UnityEngine.UI.Slider/SliderEvent UnityEngine.UI.Slider::m_OnValueChanged
	SliderEvent_t312D89AE02E00DD965D68D6F7F813BDF455FD780 * ___m_OnValueChanged_27;
	// UnityEngine.UI.Image UnityEngine.UI.Slider::m_FillImage
	Image_t4021FF27176E44BFEDDCBE43C7FE6B713EC70D3C * ___m_FillImage_28;
	// UnityEngine.Transform UnityEngine.UI.Slider::m_FillTransform
	Transform_tA8193BB29D4D2C7EC04918F3ED1816345186C3F1 * ___m_FillTransform_29;
	// UnityEngine.RectTransform UnityEngine.UI.Slider::m_FillContainerRect
	RectTransform_t8A6A306FB29A6C8C22010CF9040E319753571072 * ___m_FillContainerRect_30;
	// UnityEngine.Transform UnityEngine.UI.Slider::m_HandleTransform
	Transform_tA8193BB29D4D2C7EC04918F3ED1816345186C3F1 * ___m_HandleTransform_31;
	// UnityEngine.RectTransform UnityEngine.UI.Slider::m_HandleContainerRect
	RectTransform_t8A6A306FB29A6C8C22010CF9040E319753571072 * ___m_HandleContainerRect_32;
	// UnityEngine.Vector2 UnityEngine.UI.Slider::m_Offset
	Vector2_tBB32F2736AEC229A7BFBCE18197EC0F6AC7EC2D9  ___m_Offset_33;
	// UnityEngine.DrivenRectTransformTracker UnityEngine.UI.Slider::m_Tracker
	DrivenRectTransformTracker_t7DAF937E47C63B899C7BA0E9B0F206AAB4D85AC2  ___m_Tracker_34;
	// System.Boolean UnityEngine.UI.Slider::m_DelayedUpdateVisuals
	bool ___m_DelayedUpdateVisuals_35;

public:
	inline static int32_t get_offset_of_m_FillRect_20() { return static_cast<int32_t>(offsetof(Slider_tBF39A11CC24CBD3F8BD728982ACAEAE43989B51A, ___m_FillRect_20)); }
	inline RectTransform_t8A6A306FB29A6C8C22010CF9040E319753571072 * get_m_FillRect_20() const { return ___m_FillRect_20; }
	inline RectTransform_t8A6A306FB29A6C8C22010CF9040E319753571072 ** get_address_of_m_FillRect_20() { return &___m_FillRect_20; }
	inline void set_m_FillRect_20(RectTransform_t8A6A306FB29A6C8C22010CF9040E319753571072 * value)
	{
		___m_FillRect_20 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___m_FillRect_20), (void*)value);
	}

	inline static int32_t get_offset_of_m_HandleRect_21() { return static_cast<int32_t>(offsetof(Slider_tBF39A11CC24CBD3F8BD728982ACAEAE43989B51A, ___m_HandleRect_21)); }
	inline RectTransform_t8A6A306FB29A6C8C22010CF9040E319753571072 * get_m_HandleRect_21() const { return ___m_HandleRect_21; }
	inline RectTransform_t8A6A306FB29A6C8C22010CF9040E319753571072 ** get_address_of_m_HandleRect_21() { return &___m_HandleRect_21; }
	inline void set_m_HandleRect_21(RectTransform_t8A6A306FB29A6C8C22010CF9040E319753571072 * value)
	{
		___m_HandleRect_21 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___m_HandleRect_21), (void*)value);
	}

	inline static int32_t get_offset_of_m_Direction_22() { return static_cast<int32_t>(offsetof(Slider_tBF39A11CC24CBD3F8BD728982ACAEAE43989B51A, ___m_Direction_22)); }
	inline int32_t get_m_Direction_22() const { return ___m_Direction_22; }
	inline int32_t* get_address_of_m_Direction_22() { return &___m_Direction_22; }
	inline void set_m_Direction_22(int32_t value)
	{
		___m_Direction_22 = value;
	}

	inline static int32_t get_offset_of_m_MinValue_23() { return static_cast<int32_t>(offsetof(Slider_tBF39A11CC24CBD3F8BD728982ACAEAE43989B51A, ___m_MinValue_23)); }
	inline float get_m_MinValue_23() const { return ___m_MinValue_23; }
	inline float* get_address_of_m_MinValue_23() { return &___m_MinValue_23; }
	inline void set_m_MinValue_23(float value)
	{
		___m_MinValue_23 = value;
	}

	inline static int32_t get_offset_of_m_MaxValue_24() { return static_cast<int32_t>(offsetof(Slider_tBF39A11CC24CBD3F8BD728982ACAEAE43989B51A, ___m_MaxValue_24)); }
	inline float get_m_MaxValue_24() const { return ___m_MaxValue_24; }
	inline float* get_address_of_m_MaxValue_24() { return &___m_MaxValue_24; }
	inline void set_m_MaxValue_24(float value)
	{
		___m_MaxValue_24 = value;
	}

	inline static int32_t get_offset_of_m_WholeNumbers_25() { return static_cast<int32_t>(offsetof(Slider_tBF39A11CC24CBD3F8BD728982ACAEAE43989B51A, ___m_WholeNumbers_25)); }
	inline bool get_m_WholeNumbers_25() const { return ___m_WholeNumbers_25; }
	inline bool* get_address_of_m_WholeNumbers_25() { return &___m_WholeNumbers_25; }
	inline void set_m_WholeNumbers_25(bool value)
	{
		___m_WholeNumbers_25 = value;
	}

	inline static int32_t get_offset_of_m_Value_26() { return static_cast<int32_t>(offsetof(Slider_tBF39A11CC24CBD3F8BD728982ACAEAE43989B51A, ___m_Value_26)); }
	inline float get_m_Value_26() const { return ___m_Value_26; }
	inline float* get_address_of_m_Value_26() { return &___m_Value_26; }
	inline void set_m_Value_26(float value)
	{
		___m_Value_26 = value;
	}

	inline static int32_t get_offset_of_m_OnValueChanged_27() { return static_cast<int32_t>(offsetof(Slider_tBF39A11CC24CBD3F8BD728982ACAEAE43989B51A, ___m_OnValueChanged_27)); }
	inline SliderEvent_t312D89AE02E00DD965D68D6F7F813BDF455FD780 * get_m_OnValueChanged_27() const { return ___m_OnValueChanged_27; }
	inline SliderEvent_t312D89AE02E00DD965D68D6F7F813BDF455FD780 ** get_address_of_m_OnValueChanged_27() { return &___m_OnValueChanged_27; }
	inline void set_m_OnValueChanged_27(SliderEvent_t312D89AE02E00DD965D68D6F7F813BDF455FD780 * value)
	{
		___m_OnValueChanged_27 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___m_OnValueChanged_27), (void*)value);
	}

	inline static int32_t get_offset_of_m_FillImage_28() { return static_cast<int32_t>(offsetof(Slider_tBF39A11CC24CBD3F8BD728982ACAEAE43989B51A, ___m_FillImage_28)); }
	inline Image_t4021FF27176E44BFEDDCBE43C7FE6B713EC70D3C * get_m_FillImage_28() const { return ___m_FillImage_28; }
	inline Image_t4021FF27176E44BFEDDCBE43C7FE6B713EC70D3C ** get_address_of_m_FillImage_28() { return &___m_FillImage_28; }
	inline void set_m_FillImage_28(Image_t4021FF27176E44BFEDDCBE43C7FE6B713EC70D3C * value)
	{
		___m_FillImage_28 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___m_FillImage_28), (void*)value);
	}

	inline static int32_t get_offset_of_m_FillTransform_29() { return static_cast<int32_t>(offsetof(Slider_tBF39A11CC24CBD3F8BD728982ACAEAE43989B51A, ___m_FillTransform_29)); }
	inline Transform_tA8193BB29D4D2C7EC04918F3ED1816345186C3F1 * get_m_FillTransform_29() const { return ___m_FillTransform_29; }
	inline Transform_tA8193BB29D4D2C7EC04918F3ED1816345186C3F1 ** get_address_of_m_FillTransform_29() { return &___m_FillTransform_29; }
	inline void set_m_FillTransform_29(Transform_tA8193BB29D4D2C7EC04918F3ED1816345186C3F1 * value)
	{
		___m_FillTransform_29 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___m_FillTransform_29), (void*)value);
	}

	inline static int32_t get_offset_of_m_FillContainerRect_30() { return static_cast<int32_t>(offsetof(Slider_tBF39A11CC24CBD3F8BD728982ACAEAE43989B51A, ___m_FillContainerRect_30)); }
	inline RectTransform_t8A6A306FB29A6C8C22010CF9040E319753571072 * get_m_FillContainerRect_30() const { return ___m_FillContainerRect_30; }
	inline RectTransform_t8A6A306FB29A6C8C22010CF9040E319753571072 ** get_address_of_m_FillContainerRect_30() { return &___m_FillContainerRect_30; }
	inline void set_m_FillContainerRect_30(RectTransform_t8A6A306FB29A6C8C22010CF9040E319753571072 * value)
	{
		___m_FillContainerRect_30 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___m_FillContainerRect_30), (void*)value);
	}

	inline static int32_t get_offset_of_m_HandleTransform_31() { return static_cast<int32_t>(offsetof(Slider_tBF39A11CC24CBD3F8BD728982ACAEAE43989B51A, ___m_HandleTransform_31)); }
	inline Transform_tA8193BB29D4D2C7EC04918F3ED1816345186C3F1 * get_m_HandleTransform_31() const { return ___m_HandleTransform_31; }
	inline Transform_tA8193BB29D4D2C7EC04918F3ED1816345186C3F1 ** get_address_of_m_HandleTransform_31() { return &___m_HandleTransform_31; }
	inline void set_m_HandleTransform_31(Transform_tA8193BB29D4D2C7EC04918F3ED1816345186C3F1 * value)
	{
		___m_HandleTransform_31 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___m_HandleTransform_31), (void*)value);
	}

	inline static int32_t get_offset_of_m_HandleContainerRect_32() { return static_cast<int32_t>(offsetof(Slider_tBF39A11CC24CBD3F8BD728982ACAEAE43989B51A, ___m_HandleContainerRect_32)); }
	inline RectTransform_t8A6A306FB29A6C8C22010CF9040E319753571072 * get_m_HandleContainerRect_32() const { return ___m_HandleContainerRect_32; }
	inline RectTransform_t8A6A306FB29A6C8C22010CF9040E319753571072 ** get_address_of_m_HandleContainerRect_32() { return &___m_HandleContainerRect_32; }
	inline void set_m_HandleContainerRect_32(RectTransform_t8A6A306FB29A6C8C22010CF9040E319753571072 * value)
	{
		___m_HandleContainerRect_32 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___m_HandleContainerRect_32), (void*)value);
	}

	inline static int32_t get_offset_of_m_Offset_33() { return static_cast<int32_t>(offsetof(Slider_tBF39A11CC24CBD3F8BD728982ACAEAE43989B51A, ___m_Offset_33)); }
	inline Vector2_tBB32F2736AEC229A7BFBCE18197EC0F6AC7EC2D9  get_m_Offset_33() const { return ___m_Offset_33; }
	inline Vector2_tBB32F2736AEC229A7BFBCE18197EC0F6AC7EC2D9 * get_address_of_m_Offset_33() { return &___m_Offset_33; }
	inline void set_m_Offset_33(Vector2_tBB32F2736AEC229A7BFBCE18197EC0F6AC7EC2D9  value)
	{
		___m_Offset_33 = value;
	}

	inline static int32_t get_offset_of_m_Tracker_34() { return static_cast<int32_t>(offsetof(Slider_tBF39A11CC24CBD3F8BD728982ACAEAE43989B51A, ___m_Tracker_34)); }
	inline DrivenRectTransformTracker_t7DAF937E47C63B899C7BA0E9B0F206AAB4D85AC2  get_m_Tracker_34() const { return ___m_Tracker_34; }
	inline DrivenRectTransformTracker_t7DAF937E47C63B899C7BA0E9B0F206AAB4D85AC2 * get_address_of_m_Tracker_34() { return &___m_Tracker_34; }
	inline void set_m_Tracker_34(DrivenRectTransformTracker_t7DAF937E47C63B899C7BA0E9B0F206AAB4D85AC2  value)
	{
		___m_Tracker_34 = value;
	}

	inline static int32_t get_offset_of_m_DelayedUpdateVisuals_35() { return static_cast<int32_t>(offsetof(Slider_tBF39A11CC24CBD3F8BD728982ACAEAE43989B51A, ___m_DelayedUpdateVisuals_35)); }
	inline bool get_m_DelayedUpdateVisuals_35() const { return ___m_DelayedUpdateVisuals_35; }
	inline bool* get_address_of_m_DelayedUpdateVisuals_35() { return &___m_DelayedUpdateVisuals_35; }
	inline void set_m_DelayedUpdateVisuals_35(bool value)
	{
		___m_DelayedUpdateVisuals_35 = value;
	}
};


// UnityEngine.UI.Image
struct Image_t4021FF27176E44BFEDDCBE43C7FE6B713EC70D3C  : public MaskableGraphic_t0DB59E37E3C8AD2F5A4FB7FB091630CB21370CCE
{
public:
	// UnityEngine.Sprite UnityEngine.UI.Image::m_Sprite
	Sprite_t5B10B1178EC2E6F53D33FFD77557F31C08A51ED9 * ___m_Sprite_37;
	// UnityEngine.Sprite UnityEngine.UI.Image::m_OverrideSprite
	Sprite_t5B10B1178EC2E6F53D33FFD77557F31C08A51ED9 * ___m_OverrideSprite_38;
	// UnityEngine.UI.Image/Type UnityEngine.UI.Image::m_Type
	int32_t ___m_Type_39;
	// System.Boolean UnityEngine.UI.Image::m_PreserveAspect
	bool ___m_PreserveAspect_40;
	// System.Boolean UnityEngine.UI.Image::m_FillCenter
	bool ___m_FillCenter_41;
	// UnityEngine.UI.Image/FillMethod UnityEngine.UI.Image::m_FillMethod
	int32_t ___m_FillMethod_42;
	// System.Single UnityEngine.UI.Image::m_FillAmount
	float ___m_FillAmount_43;
	// System.Boolean UnityEngine.UI.Image::m_FillClockwise
	bool ___m_FillClockwise_44;
	// System.Int32 UnityEngine.UI.Image::m_FillOrigin
	int32_t ___m_FillOrigin_45;
	// System.Single UnityEngine.UI.Image::m_AlphaHitTestMinimumThreshold
	float ___m_AlphaHitTestMinimumThreshold_46;
	// System.Boolean UnityEngine.UI.Image::m_Tracked
	bool ___m_Tracked_47;
	// System.Boolean UnityEngine.UI.Image::m_UseSpriteMesh
	bool ___m_UseSpriteMesh_48;
	// System.Single UnityEngine.UI.Image::m_PixelsPerUnitMultiplier
	float ___m_PixelsPerUnitMultiplier_49;
	// System.Single UnityEngine.UI.Image::m_CachedReferencePixelsPerUnit
	float ___m_CachedReferencePixelsPerUnit_50;

public:
	inline static int32_t get_offset_of_m_Sprite_37() { return static_cast<int32_t>(offsetof(Image_t4021FF27176E44BFEDDCBE43C7FE6B713EC70D3C, ___m_Sprite_37)); }
	inline Sprite_t5B10B1178EC2E6F53D33FFD77557F31C08A51ED9 * get_m_Sprite_37() const { return ___m_Sprite_37; }
	inline Sprite_t5B10B1178EC2E6F53D33FFD77557F31C08A51ED9 ** get_address_of_m_Sprite_37() { return &___m_Sprite_37; }
	inline void set_m_Sprite_37(Sprite_t5B10B1178EC2E6F53D33FFD77557F31C08A51ED9 * value)
	{
		___m_Sprite_37 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___m_Sprite_37), (void*)value);
	}

	inline static int32_t get_offset_of_m_OverrideSprite_38() { return static_cast<int32_t>(offsetof(Image_t4021FF27176E44BFEDDCBE43C7FE6B713EC70D3C, ___m_OverrideSprite_38)); }
	inline Sprite_t5B10B1178EC2E6F53D33FFD77557F31C08A51ED9 * get_m_OverrideSprite_38() const { return ___m_OverrideSprite_38; }
	inline Sprite_t5B10B1178EC2E6F53D33FFD77557F31C08A51ED9 ** get_address_of_m_OverrideSprite_38() { return &___m_OverrideSprite_38; }
	inline void set_m_OverrideSprite_38(Sprite_t5B10B1178EC2E6F53D33FFD77557F31C08A51ED9 * value)
	{
		___m_OverrideSprite_38 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___m_OverrideSprite_38), (void*)value);
	}

	inline static int32_t get_offset_of_m_Type_39() { return static_cast<int32_t>(offsetof(Image_t4021FF27176E44BFEDDCBE43C7FE6B713EC70D3C, ___m_Type_39)); }
	inline int32_t get_m_Type_39() const { return ___m_Type_39; }
	inline int32_t* get_address_of_m_Type_39() { return &___m_Type_39; }
	inline void set_m_Type_39(int32_t value)
	{
		___m_Type_39 = value;
	}

	inline static int32_t get_offset_of_m_PreserveAspect_40() { return static_cast<int32_t>(offsetof(Image_t4021FF27176E44BFEDDCBE43C7FE6B713EC70D3C, ___m_PreserveAspect_40)); }
	inline bool get_m_PreserveAspect_40() const { return ___m_PreserveAspect_40; }
	inline bool* get_address_of_m_PreserveAspect_40() { return &___m_PreserveAspect_40; }
	inline void set_m_PreserveAspect_40(bool value)
	{
		___m_PreserveAspect_40 = value;
	}

	inline static int32_t get_offset_of_m_FillCenter_41() { return static_cast<int32_t>(offsetof(Image_t4021FF27176E44BFEDDCBE43C7FE6B713EC70D3C, ___m_FillCenter_41)); }
	inline bool get_m_FillCenter_41() const { return ___m_FillCenter_41; }
	inline bool* get_address_of_m_FillCenter_41() { return &___m_FillCenter_41; }
	inline void set_m_FillCenter_41(bool value)
	{
		___m_FillCenter_41 = value;
	}

	inline static int32_t get_offset_of_m_FillMethod_42() { return static_cast<int32_t>(offsetof(Image_t4021FF27176E44BFEDDCBE43C7FE6B713EC70D3C, ___m_FillMethod_42)); }
	inline int32_t get_m_FillMethod_42() const { return ___m_FillMethod_42; }
	inline int32_t* get_address_of_m_FillMethod_42() { return &___m_FillMethod_42; }
	inline void set_m_FillMethod_42(int32_t value)
	{
		___m_FillMethod_42 = value;
	}

	inline static int32_t get_offset_of_m_FillAmount_43() { return static_cast<int32_t>(offsetof(Image_t4021FF27176E44BFEDDCBE43C7FE6B713EC70D3C, ___m_FillAmount_43)); }
	inline float get_m_FillAmount_43() const { return ___m_FillAmount_43; }
	inline float* get_address_of_m_FillAmount_43() { return &___m_FillAmount_43; }
	inline void set_m_FillAmount_43(float value)
	{
		___m_FillAmount_43 = value;
	}

	inline static int32_t get_offset_of_m_FillClockwise_44() { return static_cast<int32_t>(offsetof(Image_t4021FF27176E44BFEDDCBE43C7FE6B713EC70D3C, ___m_FillClockwise_44)); }
	inline bool get_m_FillClockwise_44() const { return ___m_FillClockwise_44; }
	inline bool* get_address_of_m_FillClockwise_44() { return &___m_FillClockwise_44; }
	inline void set_m_FillClockwise_44(bool value)
	{
		___m_FillClockwise_44 = value;
	}

	inline static int32_t get_offset_of_m_FillOrigin_45() { return static_cast<int32_t>(offsetof(Image_t4021FF27176E44BFEDDCBE43C7FE6B713EC70D3C, ___m_FillOrigin_45)); }
	inline int32_t get_m_FillOrigin_45() const { return ___m_FillOrigin_45; }
	inline int32_t* get_address_of_m_FillOrigin_45() { return &___m_FillOrigin_45; }
	inline void set_m_FillOrigin_45(int32_t value)
	{
		___m_FillOrigin_45 = value;
	}

	inline static int32_t get_offset_of_m_AlphaHitTestMinimumThreshold_46() { return static_cast<int32_t>(offsetof(Image_t4021FF27176E44BFEDDCBE43C7FE6B713EC70D3C, ___m_AlphaHitTestMinimumThreshold_46)); }
	inline float get_m_AlphaHitTestMinimumThreshold_46() const { return ___m_AlphaHitTestMinimumThreshold_46; }
	inline float* get_address_of_m_AlphaHitTestMinimumThreshold_46() { return &___m_AlphaHitTestMinimumThreshold_46; }
	inline void set_m_AlphaHitTestMinimumThreshold_46(float value)
	{
		___m_AlphaHitTestMinimumThreshold_46 = value;
	}

	inline static int32_t get_offset_of_m_Tracked_47() { return static_cast<int32_t>(offsetof(Image_t4021FF27176E44BFEDDCBE43C7FE6B713EC70D3C, ___m_Tracked_47)); }
	inline bool get_m_Tracked_47() const { return ___m_Tracked_47; }
	inline bool* get_address_of_m_Tracked_47() { return &___m_Tracked_47; }
	inline void set_m_Tracked_47(bool value)
	{
		___m_Tracked_47 = value;
	}

	inline static int32_t get_offset_of_m_UseSpriteMesh_48() { return static_cast<int32_t>(offsetof(Image_t4021FF27176E44BFEDDCBE43C7FE6B713EC70D3C, ___m_UseSpriteMesh_48)); }
	inline bool get_m_UseSpriteMesh_48() const { return ___m_UseSpriteMesh_48; }
	inline bool* get_address_of_m_UseSpriteMesh_48() { return &___m_UseSpriteMesh_48; }
	inline void set_m_UseSpriteMesh_48(bool value)
	{
		___m_UseSpriteMesh_48 = value;
	}

	inline static int32_t get_offset_of_m_PixelsPerUnitMultiplier_49() { return static_cast<int32_t>(offsetof(Image_t4021FF27176E44BFEDDCBE43C7FE6B713EC70D3C, ___m_PixelsPerUnitMultiplier_49)); }
	inline float get_m_PixelsPerUnitMultiplier_49() const { return ___m_PixelsPerUnitMultiplier_49; }
	inline float* get_address_of_m_PixelsPerUnitMultiplier_49() { return &___m_PixelsPerUnitMultiplier_49; }
	inline void set_m_PixelsPerUnitMultiplier_49(float value)
	{
		___m_PixelsPerUnitMultiplier_49 = value;
	}

	inline static int32_t get_offset_of_m_CachedReferencePixelsPerUnit_50() { return static_cast<int32_t>(offsetof(Image_t4021FF27176E44BFEDDCBE43C7FE6B713EC70D3C, ___m_CachedReferencePixelsPerUnit_50)); }
	inline float get_m_CachedReferencePixelsPerUnit_50() const { return ___m_CachedReferencePixelsPerUnit_50; }
	inline float* get_address_of_m_CachedReferencePixelsPerUnit_50() { return &___m_CachedReferencePixelsPerUnit_50; }
	inline void set_m_CachedReferencePixelsPerUnit_50(float value)
	{
		___m_CachedReferencePixelsPerUnit_50 = value;
	}
};

struct Image_t4021FF27176E44BFEDDCBE43C7FE6B713EC70D3C_StaticFields
{
public:
	// UnityEngine.Material UnityEngine.UI.Image::s_ETC1DefaultUI
	Material_t8927C00353A72755313F046D0CE85178AE8218EE * ___s_ETC1DefaultUI_36;
	// UnityEngine.Vector2[] UnityEngine.UI.Image::s_VertScratch
	Vector2U5BU5D_tE0F58A2D6D8592B5EC37D9CDEF09103A02E5D7FA* ___s_VertScratch_51;
	// UnityEngine.Vector2[] UnityEngine.UI.Image::s_UVScratch
	Vector2U5BU5D_tE0F58A2D6D8592B5EC37D9CDEF09103A02E5D7FA* ___s_UVScratch_52;
	// UnityEngine.Vector3[] UnityEngine.UI.Image::s_Xy
	Vector3U5BU5D_t5FB88EAA33E46838BDC2ABDAEA3E8727491CB9E4* ___s_Xy_53;
	// UnityEngine.Vector3[] UnityEngine.UI.Image::s_Uv
	Vector3U5BU5D_t5FB88EAA33E46838BDC2ABDAEA3E8727491CB9E4* ___s_Uv_54;
	// System.Collections.Generic.List`1<UnityEngine.UI.Image> UnityEngine.UI.Image::m_TrackedTexturelessImages
	List_1_t815A476B0A21E183042059E705F9E505478CD8AE * ___m_TrackedTexturelessImages_55;
	// System.Boolean UnityEngine.UI.Image::s_Initialized
	bool ___s_Initialized_56;

public:
	inline static int32_t get_offset_of_s_ETC1DefaultUI_36() { return static_cast<int32_t>(offsetof(Image_t4021FF27176E44BFEDDCBE43C7FE6B713EC70D3C_StaticFields, ___s_ETC1DefaultUI_36)); }
	inline Material_t8927C00353A72755313F046D0CE85178AE8218EE * get_s_ETC1DefaultUI_36() const { return ___s_ETC1DefaultUI_36; }
	inline Material_t8927C00353A72755313F046D0CE85178AE8218EE ** get_address_of_s_ETC1DefaultUI_36() { return &___s_ETC1DefaultUI_36; }
	inline void set_s_ETC1DefaultUI_36(Material_t8927C00353A72755313F046D0CE85178AE8218EE * value)
	{
		___s_ETC1DefaultUI_36 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___s_ETC1DefaultUI_36), (void*)value);
	}

	inline static int32_t get_offset_of_s_VertScratch_51() { return static_cast<int32_t>(offsetof(Image_t4021FF27176E44BFEDDCBE43C7FE6B713EC70D3C_StaticFields, ___s_VertScratch_51)); }
	inline Vector2U5BU5D_tE0F58A2D6D8592B5EC37D9CDEF09103A02E5D7FA* get_s_VertScratch_51() const { return ___s_VertScratch_51; }
	inline Vector2U5BU5D_tE0F58A2D6D8592B5EC37D9CDEF09103A02E5D7FA** get_address_of_s_VertScratch_51() { return &___s_VertScratch_51; }
	inline void set_s_VertScratch_51(Vector2U5BU5D_tE0F58A2D6D8592B5EC37D9CDEF09103A02E5D7FA* value)
	{
		___s_VertScratch_51 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___s_VertScratch_51), (void*)value);
	}

	inline static int32_t get_offset_of_s_UVScratch_52() { return static_cast<int32_t>(offsetof(Image_t4021FF27176E44BFEDDCBE43C7FE6B713EC70D3C_StaticFields, ___s_UVScratch_52)); }
	inline Vector2U5BU5D_tE0F58A2D6D8592B5EC37D9CDEF09103A02E5D7FA* get_s_UVScratch_52() const { return ___s_UVScratch_52; }
	inline Vector2U5BU5D_tE0F58A2D6D8592B5EC37D9CDEF09103A02E5D7FA** get_address_of_s_UVScratch_52() { return &___s_UVScratch_52; }
	inline void set_s_UVScratch_52(Vector2U5BU5D_tE0F58A2D6D8592B5EC37D9CDEF09103A02E5D7FA* value)
	{
		___s_UVScratch_52 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___s_UVScratch_52), (void*)value);
	}

	inline static int32_t get_offset_of_s_Xy_53() { return static_cast<int32_t>(offsetof(Image_t4021FF27176E44BFEDDCBE43C7FE6B713EC70D3C_StaticFields, ___s_Xy_53)); }
	inline Vector3U5BU5D_t5FB88EAA33E46838BDC2ABDAEA3E8727491CB9E4* get_s_Xy_53() const { return ___s_Xy_53; }
	inline Vector3U5BU5D_t5FB88EAA33E46838BDC2ABDAEA3E8727491CB9E4** get_address_of_s_Xy_53() { return &___s_Xy_53; }
	inline void set_s_Xy_53(Vector3U5BU5D_t5FB88EAA33E46838BDC2ABDAEA3E8727491CB9E4* value)
	{
		___s_Xy_53 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___s_Xy_53), (void*)value);
	}

	inline static int32_t get_offset_of_s_Uv_54() { return static_cast<int32_t>(offsetof(Image_t4021FF27176E44BFEDDCBE43C7FE6B713EC70D3C_StaticFields, ___s_Uv_54)); }
	inline Vector3U5BU5D_t5FB88EAA33E46838BDC2ABDAEA3E8727491CB9E4* get_s_Uv_54() const { return ___s_Uv_54; }
	inline Vector3U5BU5D_t5FB88EAA33E46838BDC2ABDAEA3E8727491CB9E4** get_address_of_s_Uv_54() { return &___s_Uv_54; }
	inline void set_s_Uv_54(Vector3U5BU5D_t5FB88EAA33E46838BDC2ABDAEA3E8727491CB9E4* value)
	{
		___s_Uv_54 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___s_Uv_54), (void*)value);
	}

	inline static int32_t get_offset_of_m_TrackedTexturelessImages_55() { return static_cast<int32_t>(offsetof(Image_t4021FF27176E44BFEDDCBE43C7FE6B713EC70D3C_StaticFields, ___m_TrackedTexturelessImages_55)); }
	inline List_1_t815A476B0A21E183042059E705F9E505478CD8AE * get_m_TrackedTexturelessImages_55() const { return ___m_TrackedTexturelessImages_55; }
	inline List_1_t815A476B0A21E183042059E705F9E505478CD8AE ** get_address_of_m_TrackedTexturelessImages_55() { return &___m_TrackedTexturelessImages_55; }
	inline void set_m_TrackedTexturelessImages_55(List_1_t815A476B0A21E183042059E705F9E505478CD8AE * value)
	{
		___m_TrackedTexturelessImages_55 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___m_TrackedTexturelessImages_55), (void*)value);
	}

	inline static int32_t get_offset_of_s_Initialized_56() { return static_cast<int32_t>(offsetof(Image_t4021FF27176E44BFEDDCBE43C7FE6B713EC70D3C_StaticFields, ___s_Initialized_56)); }
	inline bool get_s_Initialized_56() const { return ___s_Initialized_56; }
	inline bool* get_address_of_s_Initialized_56() { return &___s_Initialized_56; }
	inline void set_s_Initialized_56(bool value)
	{
		___s_Initialized_56 = value;
	}
};


// UnityEngine.UI.Text
struct Text_t6A2339DA6C05AE2646FC1A6C8FCC127391BE7FA1  : public MaskableGraphic_t0DB59E37E3C8AD2F5A4FB7FB091630CB21370CCE
{
public:
	// UnityEngine.UI.FontData UnityEngine.UI.Text::m_FontData
	FontData_t0F1E9B3ED8136CD40782AC9A6AFB69CAD127C738 * ___m_FontData_36;
	// System.String UnityEngine.UI.Text::m_Text
	String_t* ___m_Text_37;
	// UnityEngine.TextGenerator UnityEngine.UI.Text::m_TextCache
	TextGenerator_t893F256D3587633108E00E5731CDC5A77AFF1B70 * ___m_TextCache_38;
	// UnityEngine.TextGenerator UnityEngine.UI.Text::m_TextCacheForLayout
	TextGenerator_t893F256D3587633108E00E5731CDC5A77AFF1B70 * ___m_TextCacheForLayout_39;
	// System.Boolean UnityEngine.UI.Text::m_DisableFontTextureRebuiltCallback
	bool ___m_DisableFontTextureRebuiltCallback_41;
	// UnityEngine.UIVertex[] UnityEngine.UI.Text::m_TempVerts
	UIVertexU5BU5D_tE3D523C48DFEBC775876720DE2539A79FB7E5E5A* ___m_TempVerts_42;

public:
	inline static int32_t get_offset_of_m_FontData_36() { return static_cast<int32_t>(offsetof(Text_t6A2339DA6C05AE2646FC1A6C8FCC127391BE7FA1, ___m_FontData_36)); }
	inline FontData_t0F1E9B3ED8136CD40782AC9A6AFB69CAD127C738 * get_m_FontData_36() const { return ___m_FontData_36; }
	inline FontData_t0F1E9B3ED8136CD40782AC9A6AFB69CAD127C738 ** get_address_of_m_FontData_36() { return &___m_FontData_36; }
	inline void set_m_FontData_36(FontData_t0F1E9B3ED8136CD40782AC9A6AFB69CAD127C738 * value)
	{
		___m_FontData_36 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___m_FontData_36), (void*)value);
	}

	inline static int32_t get_offset_of_m_Text_37() { return static_cast<int32_t>(offsetof(Text_t6A2339DA6C05AE2646FC1A6C8FCC127391BE7FA1, ___m_Text_37)); }
	inline String_t* get_m_Text_37() const { return ___m_Text_37; }
	inline String_t** get_address_of_m_Text_37() { return &___m_Text_37; }
	inline void set_m_Text_37(String_t* value)
	{
		___m_Text_37 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___m_Text_37), (void*)value);
	}

	inline static int32_t get_offset_of_m_TextCache_38() { return static_cast<int32_t>(offsetof(Text_t6A2339DA6C05AE2646FC1A6C8FCC127391BE7FA1, ___m_TextCache_38)); }
	inline TextGenerator_t893F256D3587633108E00E5731CDC5A77AFF1B70 * get_m_TextCache_38() const { return ___m_TextCache_38; }
	inline TextGenerator_t893F256D3587633108E00E5731CDC5A77AFF1B70 ** get_address_of_m_TextCache_38() { return &___m_TextCache_38; }
	inline void set_m_TextCache_38(TextGenerator_t893F256D3587633108E00E5731CDC5A77AFF1B70 * value)
	{
		___m_TextCache_38 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___m_TextCache_38), (void*)value);
	}

	inline static int32_t get_offset_of_m_TextCacheForLayout_39() { return static_cast<int32_t>(offsetof(Text_t6A2339DA6C05AE2646FC1A6C8FCC127391BE7FA1, ___m_TextCacheForLayout_39)); }
	inline TextGenerator_t893F256D3587633108E00E5731CDC5A77AFF1B70 * get_m_TextCacheForLayout_39() const { return ___m_TextCacheForLayout_39; }
	inline TextGenerator_t893F256D3587633108E00E5731CDC5A77AFF1B70 ** get_address_of_m_TextCacheForLayout_39() { return &___m_TextCacheForLayout_39; }
	inline void set_m_TextCacheForLayout_39(TextGenerator_t893F256D3587633108E00E5731CDC5A77AFF1B70 * value)
	{
		___m_TextCacheForLayout_39 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___m_TextCacheForLayout_39), (void*)value);
	}

	inline static int32_t get_offset_of_m_DisableFontTextureRebuiltCallback_41() { return static_cast<int32_t>(offsetof(Text_t6A2339DA6C05AE2646FC1A6C8FCC127391BE7FA1, ___m_DisableFontTextureRebuiltCallback_41)); }
	inline bool get_m_DisableFontTextureRebuiltCallback_41() const { return ___m_DisableFontTextureRebuiltCallback_41; }
	inline bool* get_address_of_m_DisableFontTextureRebuiltCallback_41() { return &___m_DisableFontTextureRebuiltCallback_41; }
	inline void set_m_DisableFontTextureRebuiltCallback_41(bool value)
	{
		___m_DisableFontTextureRebuiltCallback_41 = value;
	}

	inline static int32_t get_offset_of_m_TempVerts_42() { return static_cast<int32_t>(offsetof(Text_t6A2339DA6C05AE2646FC1A6C8FCC127391BE7FA1, ___m_TempVerts_42)); }
	inline UIVertexU5BU5D_tE3D523C48DFEBC775876720DE2539A79FB7E5E5A* get_m_TempVerts_42() const { return ___m_TempVerts_42; }
	inline UIVertexU5BU5D_tE3D523C48DFEBC775876720DE2539A79FB7E5E5A** get_address_of_m_TempVerts_42() { return &___m_TempVerts_42; }
	inline void set_m_TempVerts_42(UIVertexU5BU5D_tE3D523C48DFEBC775876720DE2539A79FB7E5E5A* value)
	{
		___m_TempVerts_42 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___m_TempVerts_42), (void*)value);
	}
};

struct Text_t6A2339DA6C05AE2646FC1A6C8FCC127391BE7FA1_StaticFields
{
public:
	// UnityEngine.Material UnityEngine.UI.Text::s_DefaultText
	Material_t8927C00353A72755313F046D0CE85178AE8218EE * ___s_DefaultText_40;

public:
	inline static int32_t get_offset_of_s_DefaultText_40() { return static_cast<int32_t>(offsetof(Text_t6A2339DA6C05AE2646FC1A6C8FCC127391BE7FA1_StaticFields, ___s_DefaultText_40)); }
	inline Material_t8927C00353A72755313F046D0CE85178AE8218EE * get_s_DefaultText_40() const { return ___s_DefaultText_40; }
	inline Material_t8927C00353A72755313F046D0CE85178AE8218EE ** get_address_of_s_DefaultText_40() { return &___s_DefaultText_40; }
	inline void set_s_DefaultText_40(Material_t8927C00353A72755313F046D0CE85178AE8218EE * value)
	{
		___s_DefaultText_40 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___s_DefaultText_40), (void*)value);
	}
};

#ifdef __clang__
#pragma clang diagnostic pop
#endif
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
// UnityEngine.Color[]
struct ColorU5BU5D_t358DD89F511301E663AD9157305B94A2DEFF8834  : public RuntimeArray
{
public:
	ALIGN_FIELD (8) Color_tF40DAF76C04FFECF3FE6024F85A294741C9CC659  m_Items[1];

public:
	inline Color_tF40DAF76C04FFECF3FE6024F85A294741C9CC659  GetAt(il2cpp_array_size_t index) const
	{
		IL2CPP_ARRAY_BOUNDS_CHECK(index, (uint32_t)(this)->max_length);
		return m_Items[index];
	}
	inline Color_tF40DAF76C04FFECF3FE6024F85A294741C9CC659 * GetAddressAt(il2cpp_array_size_t index)
	{
		IL2CPP_ARRAY_BOUNDS_CHECK(index, (uint32_t)(this)->max_length);
		return m_Items + index;
	}
	inline void SetAt(il2cpp_array_size_t index, Color_tF40DAF76C04FFECF3FE6024F85A294741C9CC659  value)
	{
		IL2CPP_ARRAY_BOUNDS_CHECK(index, (uint32_t)(this)->max_length);
		m_Items[index] = value;
	}
	inline Color_tF40DAF76C04FFECF3FE6024F85A294741C9CC659  GetAtUnchecked(il2cpp_array_size_t index) const
	{
		return m_Items[index];
	}
	inline Color_tF40DAF76C04FFECF3FE6024F85A294741C9CC659 * GetAddressAtUnchecked(il2cpp_array_size_t index)
	{
		return m_Items + index;
	}
	inline void SetAtUnchecked(il2cpp_array_size_t index, Color_tF40DAF76C04FFECF3FE6024F85A294741C9CC659  value)
	{
		m_Items[index] = value;
	}
};
// UnityEngine.UI.Text[]
struct TextU5BU5D_t16DD1967B137EC602803C77DBB246B05B3D0275F  : public RuntimeArray
{
public:
	ALIGN_FIELD (8) Text_t6A2339DA6C05AE2646FC1A6C8FCC127391BE7FA1 * m_Items[1];

public:
	inline Text_t6A2339DA6C05AE2646FC1A6C8FCC127391BE7FA1 * GetAt(il2cpp_array_size_t index) const
	{
		IL2CPP_ARRAY_BOUNDS_CHECK(index, (uint32_t)(this)->max_length);
		return m_Items[index];
	}
	inline Text_t6A2339DA6C05AE2646FC1A6C8FCC127391BE7FA1 ** GetAddressAt(il2cpp_array_size_t index)
	{
		IL2CPP_ARRAY_BOUNDS_CHECK(index, (uint32_t)(this)->max_length);
		return m_Items + index;
	}
	inline void SetAt(il2cpp_array_size_t index, Text_t6A2339DA6C05AE2646FC1A6C8FCC127391BE7FA1 * value)
	{
		IL2CPP_ARRAY_BOUNDS_CHECK(index, (uint32_t)(this)->max_length);
		m_Items[index] = value;
		Il2CppCodeGenWriteBarrier((void**)m_Items + index, (void*)value);
	}
	inline Text_t6A2339DA6C05AE2646FC1A6C8FCC127391BE7FA1 * GetAtUnchecked(il2cpp_array_size_t index) const
	{
		return m_Items[index];
	}
	inline Text_t6A2339DA6C05AE2646FC1A6C8FCC127391BE7FA1 ** GetAddressAtUnchecked(il2cpp_array_size_t index)
	{
		return m_Items + index;
	}
	inline void SetAtUnchecked(il2cpp_array_size_t index, Text_t6A2339DA6C05AE2646FC1A6C8FCC127391BE7FA1 * value)
	{
		m_Items[index] = value;
		Il2CppCodeGenWriteBarrier((void**)m_Items + index, (void*)value);
	}
};
// AllIn1VfxToolkit.Demo.Scripts.All1VfxDemoEffectCollection[]
struct All1VfxDemoEffectCollectionU5BU5D_tA9660853E3FEE15A3B3F92BA64013878E31747FC  : public RuntimeArray
{
public:
	ALIGN_FIELD (8) All1VfxDemoEffectCollection_tE355DD3FC1A635D51B056A1524F452ACFC312C7E * m_Items[1];

public:
	inline All1VfxDemoEffectCollection_tE355DD3FC1A635D51B056A1524F452ACFC312C7E * GetAt(il2cpp_array_size_t index) const
	{
		IL2CPP_ARRAY_BOUNDS_CHECK(index, (uint32_t)(this)->max_length);
		return m_Items[index];
	}
	inline All1VfxDemoEffectCollection_tE355DD3FC1A635D51B056A1524F452ACFC312C7E ** GetAddressAt(il2cpp_array_size_t index)
	{
		IL2CPP_ARRAY_BOUNDS_CHECK(index, (uint32_t)(this)->max_length);
		return m_Items + index;
	}
	inline void SetAt(il2cpp_array_size_t index, All1VfxDemoEffectCollection_tE355DD3FC1A635D51B056A1524F452ACFC312C7E * value)
	{
		IL2CPP_ARRAY_BOUNDS_CHECK(index, (uint32_t)(this)->max_length);
		m_Items[index] = value;
		Il2CppCodeGenWriteBarrier((void**)m_Items + index, (void*)value);
	}
	inline All1VfxDemoEffectCollection_tE355DD3FC1A635D51B056A1524F452ACFC312C7E * GetAtUnchecked(il2cpp_array_size_t index) const
	{
		return m_Items[index];
	}
	inline All1VfxDemoEffectCollection_tE355DD3FC1A635D51B056A1524F452ACFC312C7E ** GetAddressAtUnchecked(il2cpp_array_size_t index)
	{
		return m_Items + index;
	}
	inline void SetAtUnchecked(il2cpp_array_size_t index, All1VfxDemoEffectCollection_tE355DD3FC1A635D51B056A1524F452ACFC312C7E * value)
	{
		m_Items[index] = value;
		Il2CppCodeGenWriteBarrier((void**)m_Items + index, (void*)value);
	}
};
// AllIn1VfxToolkit.Demo.Scripts.All1VfxDemoEffect[]
struct All1VfxDemoEffectU5BU5D_tD3184435C9CE408F891FAB389BD269C827C7213F  : public RuntimeArray
{
public:
	ALIGN_FIELD (8) All1VfxDemoEffect_t66A278FEFF55B095702CEE911709440057966E75 * m_Items[1];

public:
	inline All1VfxDemoEffect_t66A278FEFF55B095702CEE911709440057966E75 * GetAt(il2cpp_array_size_t index) const
	{
		IL2CPP_ARRAY_BOUNDS_CHECK(index, (uint32_t)(this)->max_length);
		return m_Items[index];
	}
	inline All1VfxDemoEffect_t66A278FEFF55B095702CEE911709440057966E75 ** GetAddressAt(il2cpp_array_size_t index)
	{
		IL2CPP_ARRAY_BOUNDS_CHECK(index, (uint32_t)(this)->max_length);
		return m_Items + index;
	}
	inline void SetAt(il2cpp_array_size_t index, All1VfxDemoEffect_t66A278FEFF55B095702CEE911709440057966E75 * value)
	{
		IL2CPP_ARRAY_BOUNDS_CHECK(index, (uint32_t)(this)->max_length);
		m_Items[index] = value;
		Il2CppCodeGenWriteBarrier((void**)m_Items + index, (void*)value);
	}
	inline All1VfxDemoEffect_t66A278FEFF55B095702CEE911709440057966E75 * GetAtUnchecked(il2cpp_array_size_t index) const
	{
		return m_Items[index];
	}
	inline All1VfxDemoEffect_t66A278FEFF55B095702CEE911709440057966E75 ** GetAddressAtUnchecked(il2cpp_array_size_t index)
	{
		return m_Items + index;
	}
	inline void SetAtUnchecked(il2cpp_array_size_t index, All1VfxDemoEffect_t66A278FEFF55B095702CEE911709440057966E75 * value)
	{
		m_Items[index] = value;
		Il2CppCodeGenWriteBarrier((void**)m_Items + index, (void*)value);
	}
};


// !!0 UnityEngine.Component::GetComponent<System.Object>()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR RuntimeObject * Component_GetComponent_TisRuntimeObject_m69D9C576D6DD024C709E29EEADBC8041299A3AA7_gshared (Component_t62FBC8D2420DA4BE9037AFE430740F6B3EECA684 * __this, const RuntimeMethod* method);
// !!0 UnityEngine.Component::GetComponentInChildren<System.Object>()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR RuntimeObject * Component_GetComponentInChildren_TisRuntimeObject_mB377B32275A969E0D1A738DBC693DE8EB3593642_gshared (Component_t62FBC8D2420DA4BE9037AFE430740F6B3EECA684 * __this, const RuntimeMethod* method);
// !!0[] UnityEngine.Component::GetComponentsInChildren<System.Object>()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR ObjectU5BU5D_tC1F4EE0DB0B7300255F5FD4AF64FE4C585CF5ADE* Component_GetComponentsInChildren_TisRuntimeObject_mCA5B356D4B0824C6DE60A8E90E6A6D4188C56C2F_gshared (Component_t62FBC8D2420DA4BE9037AFE430740F6B3EECA684 * __this, const RuntimeMethod* method);
// !!0 UnityEngine.Object::Instantiate<System.Object>(!!0,UnityEngine.Vector3,UnityEngine.Quaternion)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR RuntimeObject * Object_Instantiate_TisRuntimeObject_mB05DEC51C29EF5BB8BD17D055E80217F11E571AA_gshared (RuntimeObject * ___original0, Vector3_t65B972D6A585A0A5B63153CF1177A90D3C90D65E  ___position1, Quaternion_t6D28618CF65156D4A0AD747370DDFD0C514A31B4  ___rotation2, const RuntimeMethod* method);
// System.Void UnityEngine.Events.UnityAction`1<System.Single>::.ctor(System.Object,System.IntPtr)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void UnityAction_1__ctor_m8CACADCAC18230FB18DF7A6BEC3D9EAD93FEDC3B_gshared (UnityAction_1_t50101DC7058B3235A520FF57E827D51694843FBB * __this, RuntimeObject * ___object0, intptr_t ___method1, const RuntimeMethod* method);
// System.Void UnityEngine.Events.UnityEvent`1<System.Single>::AddListener(UnityEngine.Events.UnityAction`1<!0>)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void UnityEvent_1_AddListener_mA73838FBF3836695F5183B32B797E9499BA5E59C_gshared (UnityEvent_1_t84B4EA1A2A00DEAC63B85AFAA89EBF67CA749DBC * __this, UnityAction_1_t50101DC7058B3235A520FF57E827D51694843FBB * ___call0, const RuntimeMethod* method);
// !!0 UnityEngine.GameObject::GetComponent<System.Object>()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR RuntimeObject * GameObject_GetComponent_TisRuntimeObject_mCE43118393A796C759AC5D43257AB2330881767D_gshared (GameObject_tC000A2E1A7CF1E10FD7BA08863287C072207C319 * __this, const RuntimeMethod* method);
// !!0 UnityEngine.Object::Instantiate<System.Object>(!!0,UnityEngine.Transform)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR RuntimeObject * Object_Instantiate_TisRuntimeObject_mD211EB15E9E128684605B4CC7277F10840F8E8CF_gshared (RuntimeObject * ___original0, Transform_tA8193BB29D4D2C7EC04918F3ED1816345186C3F1 * ___parent1, const RuntimeMethod* method);

// !!0 UnityEngine.Component::GetComponent<UnityEngine.UI.Dropdown>()
inline Dropdown_t099F5232BB75810BC79EED6E27DDCED46C3BCD96 * Component_GetComponent_TisDropdown_t099F5232BB75810BC79EED6E27DDCED46C3BCD96_m94BE8DA5A001258F5191A0C3A4B3EED5467BF931 (Component_t62FBC8D2420DA4BE9037AFE430740F6B3EECA684 * __this, const RuntimeMethod* method)
{
	return ((  Dropdown_t099F5232BB75810BC79EED6E27DDCED46C3BCD96 * (*) (Component_t62FBC8D2420DA4BE9037AFE430740F6B3EECA684 *, const RuntimeMethod*))Component_GetComponent_TisRuntimeObject_m69D9C576D6DD024C709E29EEADBC8041299A3AA7_gshared)(__this, method);
}
// System.Boolean UnityEngine.Input::GetKeyDown(UnityEngine.KeyCode)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR bool Input_GetKeyDown_m476116696E71771641BBECBAB1A4C55E69018220 (int32_t ___key0, const RuntimeMethod* method);
// System.Void AllIn1VfxToolkit.Demo.Scripts.All1DemoDropdownScroller::NextDropdownElements()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void All1DemoDropdownScroller_NextDropdownElements_mEC886856D74B765E2ED403061C8AD0F0BD99A0D9 (All1DemoDropdownScroller_t33876BB20D6CD2D697A869AC5FA7B0B4165FAAD1 * __this, const RuntimeMethod* method);
// System.Int32 UnityEngine.UI.Dropdown::get_value()
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR int32_t Dropdown_get_value_mFBF47E0C72050C5CB96B8B6D33F41BA2D1368F26_inline (Dropdown_t099F5232BB75810BC79EED6E27DDCED46C3BCD96 * __this, const RuntimeMethod* method);
// System.Void UnityEngine.UI.Dropdown::set_value(System.Int32)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Dropdown_set_value_mE4418D205D53F8A3AD23B957D1A8CD71489CB3B9 (Dropdown_t099F5232BB75810BC79EED6E27DDCED46C3BCD96 * __this, int32_t ___value0, const RuntimeMethod* method);
// System.Void UnityEngine.MonoBehaviour::.ctor()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void MonoBehaviour__ctor_mC0995D847F6A95B1A553652636C38A2AA8B13BED (MonoBehaviour_t37A501200D970A8257124B0EAE00A0FF3DDC354A * __this, const RuntimeMethod* method);
// !!0 UnityEngine.Component::GetComponent<AllIn1VfxToolkit.Demo.Scripts.AllIn1MouseRotate>()
inline AllIn1MouseRotate_t83F7508F651802AEF83D151F967CBEA41AEF7935 * Component_GetComponent_TisAllIn1MouseRotate_t83F7508F651802AEF83D151F967CBEA41AEF7935_m76825A01424AB21D31BE24D85F3B8FB30434AD51 (Component_t62FBC8D2420DA4BE9037AFE430740F6B3EECA684 * __this, const RuntimeMethod* method)
{
	return ((  AllIn1MouseRotate_t83F7508F651802AEF83D151F967CBEA41AEF7935 * (*) (Component_t62FBC8D2420DA4BE9037AFE430740F6B3EECA684 *, const RuntimeMethod*))Component_GetComponent_TisRuntimeObject_m69D9C576D6DD024C709E29EEADBC8041299A3AA7_gshared)(__this, method);
}
// !!0 UnityEngine.Component::GetComponent<AllIn1VfxToolkit.Demo.Scripts.AllIn1DemoScaleTween>()
inline AllIn1DemoScaleTween_t513A5592D7B99AAE00D3C297524793A01504CCD0 * Component_GetComponent_TisAllIn1DemoScaleTween_t513A5592D7B99AAE00D3C297524793A01504CCD0_m3EE927F72C328FCE7176EA4E296BFBD5B69CEF6C (Component_t62FBC8D2420DA4BE9037AFE430740F6B3EECA684 * __this, const RuntimeMethod* method)
{
	return ((  AllIn1DemoScaleTween_t513A5592D7B99AAE00D3C297524793A01504CCD0 * (*) (Component_t62FBC8D2420DA4BE9037AFE430740F6B3EECA684 *, const RuntimeMethod*))Component_GetComponent_TisRuntimeObject_m69D9C576D6DD024C709E29EEADBC8041299A3AA7_gshared)(__this, method);
}
// !!0 UnityEngine.Component::GetComponentInChildren<UnityEngine.UI.Text>()
inline Text_t6A2339DA6C05AE2646FC1A6C8FCC127391BE7FA1 * Component_GetComponentInChildren_TisText_t6A2339DA6C05AE2646FC1A6C8FCC127391BE7FA1_mFB5C182E24F496A866F116D3F75CBD8616A46AB3 (Component_t62FBC8D2420DA4BE9037AFE430740F6B3EECA684 * __this, const RuntimeMethod* method)
{
	return ((  Text_t6A2339DA6C05AE2646FC1A6C8FCC127391BE7FA1 * (*) (Component_t62FBC8D2420DA4BE9037AFE430740F6B3EECA684 *, const RuntimeMethod*))Component_GetComponentInChildren_TisRuntimeObject_mB377B32275A969E0D1A738DBC693DE8EB3593642_gshared)(__this, method);
}
// System.Void AllIn1VfxToolkit.Demo.Scripts.All1DemoMouseLocker::DoMouseLockToggle()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void All1DemoMouseLocker_DoMouseLockToggle_m99670B369CE1EEA9F3B802CD46CC1212BB2EA58D (All1DemoMouseLocker_t24728648D9602EC4431794A5CB77192DBB2F1A1B * __this, const RuntimeMethod* method);
// System.Void UnityEngine.Behaviour::set_enabled(System.Boolean)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Behaviour_set_enabled_mDE415591B28853D1CD764C53CB499A2142247F32 (Behaviour_t1A3DDDCF73B4627928FBFE02ED52B7251777DBD9 * __this, bool ___value0, const RuntimeMethod* method);
// System.Void AllIn1VfxToolkit.Demo.Scripts.AllIn1DemoScaleTween::ScaleUpTween()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void AllIn1DemoScaleTween_ScaleUpTween_m003B3BF936F501523FB03E83AA493B449CDF2D3F (AllIn1DemoScaleTween_t513A5592D7B99AAE00D3C297524793A01504CCD0 * __this, const RuntimeMethod* method);
// UnityEngine.Color UnityEngine.Color::get_white()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR Color_tF40DAF76C04FFECF3FE6024F85A294741C9CC659  Color_get_white_mB21E47D20959C3AEC41AF8BA04F63AC89FAF319E (const RuntimeMethod* method);
// System.Void AllIn1VfxToolkit.Demo.Scripts.All1DemoProjectileObstacle::DropdownValueChanged()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void All1DemoProjectileObstacle_DropdownValueChanged_mE17B634DBC2F7611FE3EFF197EACA44FE7889500 (All1DemoProjectileObstacle_t3447F820D7618A5E02F662177938AD4A57ECBBE1 * __this, const RuntimeMethod* method);
// System.Void AllIn1VfxToolkit.Demo.Scripts.All1DemoProjectileObstacle::SetProjectileObstacleN(System.Int32)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void All1DemoProjectileObstacle_SetProjectileObstacleN_m683D166F4AE24C5C93368366CBD018818DC36A82 (All1DemoProjectileObstacle_t3447F820D7618A5E02F662177938AD4A57ECBBE1 * __this, int32_t ___nIndex0, const RuntimeMethod* method);
// System.Void UnityEngine.GameObject::SetActive(System.Boolean)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void GameObject_SetActive_mCF1EEF2A314F3AE85DA581FF52EB06ACEF2FFF86 (GameObject_tC000A2E1A7CF1E10FD7BA08863287C072207C319 * __this, bool ___value0, const RuntimeMethod* method);
// UnityEngine.Material UnityEngine.Renderer::get_material()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR Material_t8927C00353A72755313F046D0CE85178AE8218EE * Renderer_get_material_mE6B01125502D08EE0D6DFE2EAEC064AD9BB31804 (Renderer_t58147AB5B00224FE1460FD47542DC0DA7EC9378C * __this, const RuntimeMethod* method);
// System.Void AllIn1VfxToolkit.Demo.Scripts.All1DemoSceneColor::DropdownValueChanged()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void All1DemoSceneColor_DropdownValueChanged_m3D9554F73E4A726406620014DAFED1EFB803C477 (All1DemoSceneColor_t88AAEE683C473BDFBB9BDB8A0390F9F981928A09 * __this, const RuntimeMethod* method);
// System.Void AllIn1VfxToolkit.Demo.Scripts.All1DemoSceneColor::SetSceneColor(System.Int32)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void All1DemoSceneColor_SetSceneColor_mF57B16A5F719B8A2AE936303FCFE588ECC83562C (All1DemoSceneColor_t88AAEE683C473BDFBB9BDB8A0390F9F981928A09 * __this, int32_t ___nIndex0, const RuntimeMethod* method);
// UnityEngine.Color UnityEngine.Color::op_Multiply(UnityEngine.Color,System.Single)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR Color_tF40DAF76C04FFECF3FE6024F85A294741C9CC659  Color_op_Multiply_m1A1E7DECD013FBEB99018CEDDC30B8A7CF99941D (Color_tF40DAF76C04FFECF3FE6024F85A294741C9CC659  ___a0, float ___b1, const RuntimeMethod* method);
// System.Void UnityEngine.Camera::set_backgroundColor(UnityEngine.Color)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Camera_set_backgroundColor_m7083574094F4031F3289444E1AF4CBC4FEDACFCF (Camera_tC44E094BAB53AFC8A014C6F9CFCE11F4FC38006C * __this, Color_tF40DAF76C04FFECF3FE6024F85A294741C9CC659  ___value0, const RuntimeMethod* method);
// System.Void UnityEngine.Material::set_color(UnityEngine.Color)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Material_set_color_mC3C88E2389B7132EBF3EB0D1F040545176B795C0 (Material_t8927C00353A72755313F046D0CE85178AE8218EE * __this, Color_tF40DAF76C04FFECF3FE6024F85A294741C9CC659  ___value0, const RuntimeMethod* method);
// System.Void UnityEngine.RenderSettings::set_fogColor(UnityEngine.Color)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void RenderSettings_set_fogColor_mC46154762710EFAA869A4E972C16D1FE9B0EA01F (Color_tF40DAF76C04FFECF3FE6024F85A294741C9CC659  ___value0, const RuntimeMethod* method);
// System.Void UnityEngine.ScriptableObject::.ctor()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void ScriptableObject__ctor_m8DAE6CDCFA34E16F2543B02CC3669669FF203063 (ScriptableObject_t4361E08CEBF052C650D3666C7CEC37EB31DE116A * __this, const RuntimeMethod* method);
// UnityEngine.Transform UnityEngine.Component::get_transform()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR Transform_tA8193BB29D4D2C7EC04918F3ED1816345186C3F1 * Component_get_transform_mE8496EBC45BEB1BADB5F314960F1DF1C952FA11F (Component_t62FBC8D2420DA4BE9037AFE430740F6B3EECA684 * __this, const RuntimeMethod* method);
// System.Single UnityEngine.Time::get_deltaTime()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR float Time_get_deltaTime_mCC15F147DA67F38C74CE408FB5D7FF4A87DA2290 (const RuntimeMethod* method);
// UnityEngine.Vector3 UnityEngine.Vector3::op_Multiply(UnityEngine.Vector3,System.Single)
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR Vector3_t65B972D6A585A0A5B63153CF1177A90D3C90D65E  Vector3_op_Multiply_m9EA3D18290418D7B410C7D11C4788C13BFD2C30A_inline (Vector3_t65B972D6A585A0A5B63153CF1177A90D3C90D65E  ___a0, float ___d1, const RuntimeMethod* method);
// System.Void UnityEngine.Transform::Rotate(UnityEngine.Vector3,UnityEngine.Space)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Transform_Rotate_m61816C8A09C86A5E157EA89965A9CC0510A1B378 (Transform_tA8193BB29D4D2C7EC04918F3ED1816345186C3F1 * __this, Vector3_t65B972D6A585A0A5B63153CF1177A90D3C90D65E  ___eulers0, int32_t ___relativeTo1, const RuntimeMethod* method);
// UnityEngine.Vector3 UnityEngine.Vector3::get_up()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR Vector3_t65B972D6A585A0A5B63153CF1177A90D3C90D65E  Vector3_get_up_m38AECA68388D446CFADDD022B0B867293044EA50 (const RuntimeMethod* method);
// !!0 UnityEngine.Component::GetComponent<UnityEngine.CanvasGroup>()
inline CanvasGroup_t6912220105AB4A288A2FD882D163D7218EAA577F * Component_GetComponent_TisCanvasGroup_t6912220105AB4A288A2FD882D163D7218EAA577F_mFED0C73400AFB37A709212A6C61F9BF44DBB88C4 (Component_t62FBC8D2420DA4BE9037AFE430740F6B3EECA684 * __this, const RuntimeMethod* method)
{
	return ((  CanvasGroup_t6912220105AB4A288A2FD882D163D7218EAA577F * (*) (Component_t62FBC8D2420DA4BE9037AFE430740F6B3EECA684 *, const RuntimeMethod*))Component_GetComponent_TisRuntimeObject_m69D9C576D6DD024C709E29EEADBC8041299A3AA7_gshared)(__this, method);
}
// System.Void UnityEngine.CanvasGroup::set_alpha(System.Single)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void CanvasGroup_set_alpha_m522B58BDF64D87252B0D43D254FF3A4D5993DC53 (CanvasGroup_t6912220105AB4A288A2FD882D163D7218EAA577F * __this, float ___value0, const RuntimeMethod* method);
// System.Boolean UnityEngine.Object::op_Inequality(UnityEngine.Object,UnityEngine.Object)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR bool Object_op_Inequality_mE1F187520BD83FB7D86A6D850710C4D42B864E90 (Object_tF2F3778131EFF286AF62B7B013A170F95A91571A * ___x0, Object_tF2F3778131EFF286AF62B7B013A170F95A91571A * ___y1, const RuntimeMethod* method);
// System.Void AllIn1VfxToolkit.Demo.Scripts.AllIn1CanvasFader::HideUiButtonPressed()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void AllIn1CanvasFader_HideUiButtonPressed_mC8306AED561C3C7A4DDEEC13AD337619505C1449 (AllIn1CanvasFader_tB4AA563ED5CFF1F6FC9B974944AA53A94532162A * __this, const RuntimeMethod* method);
// System.Single UnityEngine.Time::get_unscaledDeltaTime()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR float Time_get_unscaledDeltaTime_m2C153F1E5C77C6AF655054BC6C76D0C334C0DC84 (const RuntimeMethod* method);
// System.Single UnityEngine.Mathf::MoveTowards(System.Single,System.Single,System.Single)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR float Mathf_MoveTowards_mE0689B09DD10CD59A01EE9E24880A5BA495FD321 (float ___current0, float ___target1, float ___maxDelta2, const RuntimeMethod* method);
// System.Void AllIn1VfxToolkit.Demo.Scripts.AllIn1CanvasFader::MakeCanvasVisibleTween()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void AllIn1CanvasFader_MakeCanvasVisibleTween_mD7238298C5D747BFC25E233801AAF81A101C91D2 (AllIn1CanvasFader_tB4AA563ED5CFF1F6FC9B974944AA53A94532162A * __this, const RuntimeMethod* method);
// System.Void AllIn1VfxToolkit.Demo.Scripts.AllIn1CanvasFader::MakeCanvasInvisibleTween()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void AllIn1CanvasFader_MakeCanvasInvisibleTween_m001BA461382558D8E3AEC6418DE3C17C7DF0E689 (AllIn1CanvasFader_tB4AA563ED5CFF1F6FC9B974944AA53A94532162A * __this, const RuntimeMethod* method);
// System.Void AllIn1VfxToolkit.Demo.Scripts.AllIn1ChangeAllChildTextFonts::ChangeFonts()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void AllIn1ChangeAllChildTextFonts_ChangeFonts_mB06662F5F27E476D347C0612929950C47594238E (AllIn1ChangeAllChildTextFonts_t11C8807E2A6936E92C06EFAD7E046BE279C4E433 * __this, const RuntimeMethod* method);
// !!0[] UnityEngine.Component::GetComponentsInChildren<UnityEngine.UI.Text>()
inline TextU5BU5D_t16DD1967B137EC602803C77DBB246B05B3D0275F* Component_GetComponentsInChildren_TisText_t6A2339DA6C05AE2646FC1A6C8FCC127391BE7FA1_m7556907CF90B895FDFBEC11100A5F7AD5FAF1AA6 (Component_t62FBC8D2420DA4BE9037AFE430740F6B3EECA684 * __this, const RuntimeMethod* method)
{
	return ((  TextU5BU5D_t16DD1967B137EC602803C77DBB246B05B3D0275F* (*) (Component_t62FBC8D2420DA4BE9037AFE430740F6B3EECA684 *, const RuntimeMethod*))Component_GetComponentsInChildren_TisRuntimeObject_mCA5B356D4B0824C6DE60A8E90E6A6D4188C56C2F_gshared)(__this, method);
}
// System.Void UnityEngine.UI.Text::set_font(UnityEngine.Font)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Text_set_font_m10F529719C942343F7B963D28480A20940CD0B52 (Text_t6A2339DA6C05AE2646FC1A6C8FCC127391BE7FA1 * __this, Font_tB53D3F362CB1A0B92307B362826F212AE2D2A6A9 * ___value0, const RuntimeMethod* method);
// System.Void AllIn1VfxToolkit.Demo.Scripts.AllIn1DemoProjectile::ApplyPrecisionOffsetToProjectileDir(UnityEngine.Vector3&)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void AllIn1DemoProjectile_ApplyPrecisionOffsetToProjectileDir_mE59DA1BEDF26DDC6211A3B705215FD804E1C6E50 (AllIn1DemoProjectile_tA36F8B6BF3163732D0C981065AF301449C4AAE69 * __this, Vector3_t65B972D6A585A0A5B63153CF1177A90D3C90D65E * ___projectileDir0, const RuntimeMethod* method);
// !!0 UnityEngine.Component::GetComponent<UnityEngine.Rigidbody>()
inline Rigidbody_t101F2E2F9F16E765A77429B2DE4527D2047A887A * Component_GetComponent_TisRigidbody_t101F2E2F9F16E765A77429B2DE4527D2047A887A_m9DC24AA806B0B65E917751F7A3AFDB58861157CE (Component_t62FBC8D2420DA4BE9037AFE430740F6B3EECA684 * __this, const RuntimeMethod* method)
{
	return ((  Rigidbody_t101F2E2F9F16E765A77429B2DE4527D2047A887A * (*) (Component_t62FBC8D2420DA4BE9037AFE430740F6B3EECA684 *, const RuntimeMethod*))Component_GetComponent_TisRuntimeObject_m69D9C576D6DD024C709E29EEADBC8041299A3AA7_gshared)(__this, method);
}
// System.Void UnityEngine.Rigidbody::set_velocity(UnityEngine.Vector3)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Rigidbody_set_velocity_m8DC0988916EB38DFD7D4584830B41D79140BF18D (Rigidbody_t101F2E2F9F16E765A77429B2DE4527D2047A887A * __this, Vector3_t65B972D6A585A0A5B63153CF1177A90D3C90D65E  ___value0, const RuntimeMethod* method);
// System.Single UnityEngine.Random::Range(System.Single,System.Single)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR float Random_Range_mC15372D42A9ABDCAC3DE82E114D60A40C9C311D2 (float ___minInclusive0, float ___maxInclusive1, const RuntimeMethod* method);
// UnityEngine.Vector3 UnityEngine.Transform::get_position()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR Vector3_t65B972D6A585A0A5B63153CF1177A90D3C90D65E  Transform_get_position_m40A8A9895568D56FFC687B57F30E8D53CB5EA341 (Transform_tA8193BB29D4D2C7EC04918F3ED1816345186C3F1 * __this, const RuntimeMethod* method);
// UnityEngine.Quaternion UnityEngine.Quaternion::get_identity()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR Quaternion_t6D28618CF65156D4A0AD747370DDFD0C514A31B4  Quaternion_get_identity_mF2E565DBCE793A1AE6208056D42CA7C59D83A702 (const RuntimeMethod* method);
// !!0 UnityEngine.Object::Instantiate<UnityEngine.GameObject>(!!0,UnityEngine.Vector3,UnityEngine.Quaternion)
inline GameObject_tC000A2E1A7CF1E10FD7BA08863287C072207C319 * Object_Instantiate_TisGameObject_tC000A2E1A7CF1E10FD7BA08863287C072207C319_m81B599A0051F8F4543E5C73A11585E96E940943B (GameObject_tC000A2E1A7CF1E10FD7BA08863287C072207C319 * ___original0, Vector3_t65B972D6A585A0A5B63153CF1177A90D3C90D65E  ___position1, Quaternion_t6D28618CF65156D4A0AD747370DDFD0C514A31B4  ___rotation2, const RuntimeMethod* method)
{
	return ((  GameObject_tC000A2E1A7CF1E10FD7BA08863287C072207C319 * (*) (GameObject_tC000A2E1A7CF1E10FD7BA08863287C072207C319 *, Vector3_t65B972D6A585A0A5B63153CF1177A90D3C90D65E , Quaternion_t6D28618CF65156D4A0AD747370DDFD0C514A31B4 , const RuntimeMethod*))Object_Instantiate_TisRuntimeObject_mB05DEC51C29EF5BB8BD17D055E80217F11E571AA_gshared)(___original0, ___position1, ___rotation2, method);
}
// UnityEngine.Transform UnityEngine.GameObject::get_transform()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR Transform_tA8193BB29D4D2C7EC04918F3ED1816345186C3F1 * GameObject_get_transform_m16A80BB92B6C8C5AB696E447014D45EDF1E4DE34 (GameObject_tC000A2E1A7CF1E10FD7BA08863287C072207C319 * __this, const RuntimeMethod* method);
// System.Void UnityEngine.Transform::set_parent(UnityEngine.Transform)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Transform_set_parent_mEAE304E1A804E8B83054CEECB5BF1E517196EC13 (Transform_tA8193BB29D4D2C7EC04918F3ED1816345186C3F1 * __this, Transform_tA8193BB29D4D2C7EC04918F3ED1816345186C3F1 * ___value0, const RuntimeMethod* method);
// UnityEngine.Vector3 UnityEngine.Transform::get_localScale()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR Vector3_t65B972D6A585A0A5B63153CF1177A90D3C90D65E  Transform_get_localScale_mD9DF6CA81108C2A6002B5EA2BE25A6CD2723D046 (Transform_tA8193BB29D4D2C7EC04918F3ED1816345186C3F1 * __this, const RuntimeMethod* method);
// System.Void UnityEngine.Transform::set_localScale(UnityEngine.Vector3)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Transform_set_localScale_mF4D1611E48D1BA7566A1E166DC2DACF3ADD8BA3A (Transform_tA8193BB29D4D2C7EC04918F3ED1816345186C3F1 * __this, Vector3_t65B972D6A585A0A5B63153CF1177A90D3C90D65E  ___value0, const RuntimeMethod* method);
// System.Void AllIn1VfxToolkit.Demo.Scripts.AllIn1Shaker::DoCameraShake(System.Single)
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR void AllIn1Shaker_DoCameraShake_m9B27491C1A4577C33D283B3CDD03BDCFC87E0AA2_inline (AllIn1Shaker_t4540E312EAE72C5A4E5F184AFEC3099E91179295 * __this, float ___shakeAmount0, const RuntimeMethod* method);
// UnityEngine.GameObject UnityEngine.Component::get_gameObject()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR GameObject_tC000A2E1A7CF1E10FD7BA08863287C072207C319 * Component_get_gameObject_m55DC35B149AFB9157582755383BA954655FE0C5B (Component_t62FBC8D2420DA4BE9037AFE430740F6B3EECA684 * __this, const RuntimeMethod* method);
// System.Void UnityEngine.Object::Destroy(UnityEngine.Object)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Object_Destroy_m3EEDB6ECD49A541EC826EA8E1C8B599F7AF67D30 (Object_tF2F3778131EFF286AF62B7B013A170F95A91571A * ___obj0, const RuntimeMethod* method);
// System.Single UnityEngine.Mathf::Lerp(System.Single,System.Single,System.Single)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR float Mathf_Lerp_m8A2A50B945F42D579EDF44D5EE79E85A4DA59616 (float ___a0, float ___b1, float ___t2, const RuntimeMethod* method);
// System.Void AllIn1VfxToolkit.Demo.Scripts.AllIn1DemoScaleTween::UpdateScaleToApply()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void AllIn1DemoScaleTween_UpdateScaleToApply_m688865C2BB9A65CF7688CEB3B9503A63D6EB3B39 (AllIn1DemoScaleTween_t513A5592D7B99AAE00D3C297524793A01504CCD0 * __this, const RuntimeMethod* method);
// System.Void AllIn1VfxToolkit.Demo.Scripts.AllIn1DemoScaleTween::ApplyScale()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void AllIn1DemoScaleTween_ApplyScale_m6EFE20A94BEFC57A22B9C461CE2D1C1B5DEFBBA0 (AllIn1DemoScaleTween_t513A5592D7B99AAE00D3C297524793A01504CCD0 * __this, const RuntimeMethod* method);
// UnityEngine.Vector3 UnityEngine.Vector3::get_one()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR Vector3_t65B972D6A585A0A5B63153CF1177A90D3C90D65E  Vector3_get_one_m9CDE5C456038B133ED94402673859EC37B1C1CCB (const RuntimeMethod* method);
// System.Void AllIn1VfxToolkit.Demo.Scripts.AllIn1DoShake::DoShake()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void AllIn1DoShake_DoShake_m0D1D05BDBC47163E08804BD28C1C08B3BF7EAF2F (AllIn1DoShake_t4AC8F2F9DF4B14734088C6754E9692F1B74275B1 * __this, const RuntimeMethod* method);
// System.Void UnityEngine.MonoBehaviour::Invoke(System.String,System.Single)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void MonoBehaviour_Invoke_m4AAB759653B1C6FB0653527F4DDC72D1E9162CC4 (MonoBehaviour_t37A501200D970A8257124B0EAE00A0FF3DDC354A * __this, String_t* ___methodName0, float ___time1, const RuntimeMethod* method);
// System.Void UnityEngine.Debug::LogError(System.Object)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Debug_LogError_m8850D65592770A364D494025FF3A73E8D4D70485 (RuntimeObject * ___message0, const RuntimeMethod* method);
// System.Void AllIn1VfxToolkit.Demo.Scripts.AllIn1MouseRotate::ToggleCursorLocked()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void AllIn1MouseRotate_ToggleCursorLocked_mEF8E417B9A724B07D679584F2EE05952639E5008 (AllIn1MouseRotate_t83F7508F651802AEF83D151F967CBEA41AEF7935 * __this, const RuntimeMethod* method);
// System.Single UnityEngine.Time::get_timeSinceLevelLoad()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR float Time_get_timeSinceLevelLoad_m47A90DE6CB3A3180D64F0049290BC72C186FC7FB (const RuntimeMethod* method);
// System.Void AllIn1VfxToolkit.Demo.Scripts.AllIn1MouseRotate::CamRotateAroundYAxis()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void AllIn1MouseRotate_CamRotateAroundYAxis_mA30E0E6AD63C90C496F0D7ED653BC445F516EFF6 (AllIn1MouseRotate_t83F7508F651802AEF83D151F967CBEA41AEF7935 * __this, const RuntimeMethod* method);
// System.Void AllIn1VfxToolkit.Demo.Scripts.AllIn1MouseRotate::CamHeightTranslate()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void AllIn1MouseRotate_CamHeightTranslate_m35076E6F1672942612AF42A7809C419CD178EB83 (AllIn1MouseRotate_t83F7508F651802AEF83D151F967CBEA41AEF7935 * __this, const RuntimeMethod* method);
// System.Void AllIn1VfxToolkit.Demo.Scripts.AllIn1MouseRotate::CamZoom()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void AllIn1MouseRotate_CamZoom_mD897B81122550EFDDBE6DBD8B459F471C0448FE3 (AllIn1MouseRotate_t83F7508F651802AEF83D151F967CBEA41AEF7935 * __this, const RuntimeMethod* method);
// System.Single UnityEngine.Input::GetAxis(System.String)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR float Input_GetAxis_m939297DEB2ECF8D8D09AD66EB69979AAD2B62326 (String_t* ___axisName0, const RuntimeMethod* method);
// System.Void UnityEngine.Transform::RotateAround(UnityEngine.Vector3,UnityEngine.Vector3,System.Single)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Transform_RotateAround_m1F93A7A1807BE407BD23EC1BA49F03AD22FCE4BE (Transform_tA8193BB29D4D2C7EC04918F3ED1816345186C3F1 * __this, Vector3_t65B972D6A585A0A5B63153CF1177A90D3C90D65E  ___point0, Vector3_t65B972D6A585A0A5B63153CF1177A90D3C90D65E  ___axis1, float ___angle2, const RuntimeMethod* method);
// System.Single UnityEngine.Mathf::Clamp(System.Single,System.Single,System.Single)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR float Mathf_Clamp_m2416F3B785C8F135863E3D17E5B0CB4174797B87 (float ___value0, float ___min1, float ___max2, const RuntimeMethod* method);
// System.Void UnityEngine.Transform::set_position(UnityEngine.Vector3)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Transform_set_position_mB169E52D57EEAC1E3F22C5395968714E4F00AC91 (Transform_tA8193BB29D4D2C7EC04918F3ED1816345186C3F1 * __this, Vector3_t65B972D6A585A0A5B63153CF1177A90D3C90D65E  ___value0, const RuntimeMethod* method);
// System.Void UnityEngine.Transform::LookAt(UnityEngine.Transform)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Transform_LookAt_m49185D782014D16DA747C1296BEBAC3FB3CEDC1F (Transform_tA8193BB29D4D2C7EC04918F3ED1816345186C3F1 * __this, Transform_tA8193BB29D4D2C7EC04918F3ED1816345186C3F1 * ___target0, const RuntimeMethod* method);
// UnityEngine.Vector3 UnityEngine.Transform::get_forward()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR Vector3_t65B972D6A585A0A5B63153CF1177A90D3C90D65E  Transform_get_forward_mD850B9ECF892009E3485408DC0D375165B7BF053 (Transform_tA8193BB29D4D2C7EC04918F3ED1816345186C3F1 * __this, const RuntimeMethod* method);
// System.Single UnityEngine.Vector3::Distance(UnityEngine.Vector3,UnityEngine.Vector3)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR float Vector3_Distance_mB648A79E4A1BAAFBF7B029644638C0D715480677 (Vector3_t65B972D6A585A0A5B63153CF1177A90D3C90D65E  ___a0, Vector3_t65B972D6A585A0A5B63153CF1177A90D3C90D65E  ___b1, const RuntimeMethod* method);
// UnityEngine.Vector3 UnityEngine.Vector3::get_zero()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR Vector3_t65B972D6A585A0A5B63153CF1177A90D3C90D65E  Vector3_get_zero_m1A8F7993167785F750B6B01762D22C2597C84EF6 (const RuntimeMethod* method);
// UnityEngine.Vector3 UnityEngine.Vector3::op_Addition(UnityEngine.Vector3,UnityEngine.Vector3)
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR Vector3_t65B972D6A585A0A5B63153CF1177A90D3C90D65E  Vector3_op_Addition_mEE4F672B923CCB184C39AABCA33443DB218E50E0_inline (Vector3_t65B972D6A585A0A5B63153CF1177A90D3C90D65E  ___a0, Vector3_t65B972D6A585A0A5B63153CF1177A90D3C90D65E  ___b1, const RuntimeMethod* method);
// System.Void UnityEngine.Cursor::set_lockState(UnityEngine.CursorLockMode)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Cursor_set_lockState_mC0739186A04F4C278F02E8C1714D99B491E3A217 (int32_t ___value0, const RuntimeMethod* method);
// System.Void UnityEngine.Cursor::set_visible(System.Boolean)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Cursor_set_visible_m4747F0DC20D06D1932EC740C5CCC738C1664903D (bool ___value0, const RuntimeMethod* method);
// System.Single UnityEngine.Random::get_value()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR float Random_get_value_m9AEBC7DF0BB6C57C928B0798349A7D3C0B3FB872 (const RuntimeMethod* method);
// System.Single AllIn1VfxToolkit.Demo.Scripts.AllIn1Shaker::SmoothShakeToApply()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR float AllIn1Shaker_SmoothShakeToApply_m065EF3B4107227CC0A34BE5D6705AC8C9BEF1B51 (AllIn1Shaker_t4540E312EAE72C5A4E5F184AFEC3099E91179295 * __this, const RuntimeMethod* method);
// System.Void AllIn1VfxToolkit.Demo.Scripts.AllIn1Shaker::ShakePosition(System.Single)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void AllIn1Shaker_ShakePosition_m6D224766E11F16B1E03AE695EAEE113F4189F9DA (AllIn1Shaker_t4540E312EAE72C5A4E5F184AFEC3099E91179295 * __this, float ___shake0, const RuntimeMethod* method);
// System.Void AllIn1VfxToolkit.Demo.Scripts.AllIn1Shaker::ShakeRotation(System.Single)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void AllIn1Shaker_ShakeRotation_m44044FF4F0B4F1436D52B1E6285C2D98A8815AE0 (AllIn1Shaker_t4540E312EAE72C5A4E5F184AFEC3099E91179295 * __this, float ___shake0, const RuntimeMethod* method);
// System.Single UnityEngine.Mathf::Clamp01(System.Single)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR float Mathf_Clamp01_m2296D75F0F1292D5C8181C57007A1CA45F440C4C (float ___value0, const RuntimeMethod* method);
// System.Single UnityEngine.Time::get_time()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR float Time_get_time_m1A186074B1FCD448AB13A4B9D715AB9ED0B40844 (const RuntimeMethod* method);
// System.Single UnityEngine.Mathf::PerlinNoise(System.Single,System.Single)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR float Mathf_PerlinNoise_mBCF172821FEB8FAD7E7CF7F7982018846E702519 (float ___x0, float ___y1, const RuntimeMethod* method);
// System.Void UnityEngine.Vector3::.ctor(System.Single,System.Single,System.Single)
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR void Vector3__ctor_m57495F692C6CE1CEF278CAD9A98221165D37E636_inline (Vector3_t65B972D6A585A0A5B63153CF1177A90D3C90D65E * __this, float ___x0, float ___y1, float ___z2, const RuntimeMethod* method);
// UnityEngine.Quaternion UnityEngine.Quaternion::Euler(UnityEngine.Vector3)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR Quaternion_t6D28618CF65156D4A0AD747370DDFD0C514A31B4  Quaternion_Euler_m887ABE4F4DD563351E9874D63922C2F53969BBAB (Vector3_t65B972D6A585A0A5B63153CF1177A90D3C90D65E  ___euler0, const RuntimeMethod* method);
// System.Void UnityEngine.Transform::set_localRotation(UnityEngine.Quaternion)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Transform_set_localRotation_m1A9101457EC4653AFC93FCC4065A29F2C78FA62C (Transform_tA8193BB29D4D2C7EC04918F3ED1816345186C3F1 * __this, Quaternion_t6D28618CF65156D4A0AD747370DDFD0C514A31B4  ___value0, const RuntimeMethod* method);
// System.Void UnityEngine.Transform::set_localPosition(UnityEngine.Vector3)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Transform_set_localPosition_m2A2B0033EF079077FAE7C65196078EAF5D041AFC (Transform_tA8193BB29D4D2C7EC04918F3ED1816345186C3F1 * __this, Vector3_t65B972D6A585A0A5B63153CF1177A90D3C90D65E  ___value0, const RuntimeMethod* method);
// System.Void AllIn1VfxToolkit.Demo.Scripts.AllIn1TimeControl::UpdateTimeScaleUI()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void AllIn1TimeControl_UpdateTimeScaleUI_mB22071568FDC2263BFFB70F080D426D15F549ABA (AllIn1TimeControl_tD27F0B4D919AD681DB84DE2277471ABFF29C38DC * __this, const RuntimeMethod* method);
// UnityEngine.UI.Slider/SliderEvent UnityEngine.UI.Slider::get_onValueChanged()
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR SliderEvent_t312D89AE02E00DD965D68D6F7F813BDF455FD780 * Slider_get_onValueChanged_m7F480C569A6D668952BE1436691850D13825E129_inline (Slider_tBF39A11CC24CBD3F8BD728982ACAEAE43989B51A * __this, const RuntimeMethod* method);
// System.Void UnityEngine.Events.UnityAction`1<System.Single>::.ctor(System.Object,System.IntPtr)
inline void UnityAction_1__ctor_m8CACADCAC18230FB18DF7A6BEC3D9EAD93FEDC3B (UnityAction_1_t50101DC7058B3235A520FF57E827D51694843FBB * __this, RuntimeObject * ___object0, intptr_t ___method1, const RuntimeMethod* method)
{
	((  void (*) (UnityAction_1_t50101DC7058B3235A520FF57E827D51694843FBB *, RuntimeObject *, intptr_t, const RuntimeMethod*))UnityAction_1__ctor_m8CACADCAC18230FB18DF7A6BEC3D9EAD93FEDC3B_gshared)(__this, ___object0, ___method1, method);
}
// System.Void UnityEngine.Events.UnityEvent`1<System.Single>::AddListener(UnityEngine.Events.UnityAction`1<!0>)
inline void UnityEvent_1_AddListener_mA73838FBF3836695F5183B32B797E9499BA5E59C (UnityEvent_1_t84B4EA1A2A00DEAC63B85AFAA89EBF67CA749DBC * __this, UnityAction_1_t50101DC7058B3235A520FF57E827D51694843FBB * ___call0, const RuntimeMethod* method)
{
	((  void (*) (UnityEvent_1_t84B4EA1A2A00DEAC63B85AFAA89EBF67CA749DBC *, UnityAction_1_t50101DC7058B3235A520FF57E827D51694843FBB *, const RuntimeMethod*))UnityEvent_1_AddListener_mA73838FBF3836695F5183B32B797E9499BA5E59C_gshared)(__this, ___call0, method);
}
// System.Void AllIn1VfxToolkit.Demo.Scripts.AllIn1TimeControl::ChangeTimeScale(System.Single)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void AllIn1TimeControl_ChangeTimeScale_mE4FA5449A14375E70158BA48654537CA487D8BF1 (AllIn1TimeControl_tD27F0B4D919AD681DB84DE2277471ABFF29C38DC * __this, float ___changeAmount0, const RuntimeMethod* method);
// System.Single UnityEngine.Time::get_timeScale()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR float Time_get_timeScale_m082A05928ED5917AA986FAA6106E79D8446A26F4 (const RuntimeMethod* method);
// System.Single UnityEngine.Time::get_unscaledTime()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR float Time_get_unscaledTime_m85A3479E3D78D05FEDEEFEF36944AC5EF9B31258 (const RuntimeMethod* method);
// System.Boolean UnityEngine.Input::GetKey(UnityEngine.KeyCode)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR bool Input_GetKey_mFDD450A4C61F2930928B12287FFBD1ACCB71E429 (int32_t ___key0, const RuntimeMethod* method);
// System.Void UnityEngine.Time::set_timeScale(System.Single)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Time_set_timeScale_m1987DE9E74FC6C0126CE4F59A6293E3B85BD01EA (float ___value0, const RuntimeMethod* method);
// System.Void UnityEngine.Object::Destroy(UnityEngine.Object,System.Single)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Object_Destroy_mAAAA103F4911E9FA18634BF9605C28559F5E2AC7 (Object_tF2F3778131EFF286AF62B7B013A170F95A91571A * ___obj0, float ___t1, const RuntimeMethod* method);
// !!0 UnityEngine.GameObject::GetComponent<AllIn1VfxToolkit.Demo.Scripts.AllIn1TimeControl>()
inline AllIn1TimeControl_tD27F0B4D919AD681DB84DE2277471ABFF29C38DC * GameObject_GetComponent_TisAllIn1TimeControl_tD27F0B4D919AD681DB84DE2277471ABFF29C38DC_mF3263778C546C37B9E1DFF39316D8D702990DD5E (GameObject_tC000A2E1A7CF1E10FD7BA08863287C072207C319 * __this, const RuntimeMethod* method)
{
	return ((  AllIn1TimeControl_tD27F0B4D919AD681DB84DE2277471ABFF29C38DC * (*) (GameObject_tC000A2E1A7CF1E10FD7BA08863287C072207C319 *, const RuntimeMethod*))GameObject_GetComponent_TisRuntimeObject_mCE43118393A796C759AC5D43257AB2330881767D_gshared)(__this, method);
}
// System.Void AllIn1VfxToolkit.Demo.Scripts.AllIn1VfxDemoController::SetupAndInstantiateCurrentEffect()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void AllIn1VfxDemoController_SetupAndInstantiateCurrentEffect_mFFCD7DA958AB68D709C5B0328AD5FBE8416157AC (AllIn1VfxDemoController_tDBA0E647E412D7CE6715A6976DB1E1A5722F6892 * __this, const RuntimeMethod* method);
// System.Void AllIn1VfxToolkit.Demo.Scripts.AllIn1VfxDemoController::PlayCurrentEffect(System.Boolean)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void AllIn1VfxDemoController_PlayCurrentEffect_m12550E66ED360BD359AA42CC05C3BB622EC6BD6F (AllIn1VfxDemoController_tDBA0E647E412D7CE6715A6976DB1E1A5722F6892 * __this, bool ___isAfterSetupAndInstantiateEffect0, const RuntimeMethod* method);
// System.Void AllIn1VfxToolkit.Demo.Scripts.AllIn1VfxDemoController::ChangeCurrentEffect(System.Int32)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void AllIn1VfxDemoController_ChangeCurrentEffect_m95CF6E65BB2B2454A3F15DCBC9D222E15D23D3C5 (AllIn1VfxDemoController_tDBA0E647E412D7CE6715A6976DB1E1A5722F6892 * __this, int32_t ___changeAmount0, const RuntimeMethod* method);
// UnityEngine.Vector3 UnityEngine.Vector3::Lerp(UnityEngine.Vector3,UnityEngine.Vector3,System.Single)
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR Vector3_t65B972D6A585A0A5B63153CF1177A90D3C90D65E  Vector3_Lerp_m8E095584FFA10CF1D3EABCD04F4C83FB82EC5524_inline (Vector3_t65B972D6A585A0A5B63153CF1177A90D3C90D65E  ___a0, Vector3_t65B972D6A585A0A5B63153CF1177A90D3C90D65E  ___b1, float ___t2, const RuntimeMethod* method);
// System.Void AllIn1VfxToolkit.Demo.Scripts.AllIn1VfxDemoController::CooldownHandling()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void AllIn1VfxDemoController_CooldownHandling_mE5F21D70CDA54F109AD1FE91FA75C00FED112BC3 (AllIn1VfxDemoController_tDBA0E647E412D7CE6715A6976DB1E1A5722F6892 * __this, const RuntimeMethod* method);
// System.Void UnityEngine.UI.Selectable::set_interactable(System.Boolean)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Selectable_set_interactable_mE6F57D33A9E0484377174D0F490C4372BF7F0D40 (Selectable_t34088A3677CC9D344F81B0D91999D8C5963D7DBD * __this, bool ___value0, const RuntimeMethod* method);
// System.Void AllIn1VfxToolkit.Demo.Scripts.AllIn1VfxDemoController::DestroyAllChildren()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void AllIn1VfxDemoController_DestroyAllChildren_mAD6FDC80DDC9B8DA3E39DC364065D4C06DD9373D (AllIn1VfxDemoController_tDBA0E647E412D7CE6715A6976DB1E1A5722F6892 * __this, const RuntimeMethod* method);
// System.Void UnityEngine.Transform::set_forward(UnityEngine.Vector3)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Transform_set_forward_mAE46B156F55F2F90AB495B17F7C20BF59A5D7D4D (Transform_tA8193BB29D4D2C7EC04918F3ED1816345186C3F1 * __this, Vector3_t65B972D6A585A0A5B63153CF1177A90D3C90D65E  ___value0, const RuntimeMethod* method);
// !!0 UnityEngine.Component::GetComponent<AllIn1VfxToolkit.Demo.Scripts.AllIn1DemoProjectile>()
inline AllIn1DemoProjectile_tA36F8B6BF3163732D0C981065AF301449C4AAE69 * Component_GetComponent_TisAllIn1DemoProjectile_tA36F8B6BF3163732D0C981065AF301449C4AAE69_mDC2B3DDAC7100EB3664EFDDE053CE3955615FC3E (Component_t62FBC8D2420DA4BE9037AFE430740F6B3EECA684 * __this, const RuntimeMethod* method)
{
	return ((  AllIn1DemoProjectile_tA36F8B6BF3163732D0C981065AF301449C4AAE69 * (*) (Component_t62FBC8D2420DA4BE9037AFE430740F6B3EECA684 *, const RuntimeMethod*))Component_GetComponent_TisRuntimeObject_m69D9C576D6DD024C709E29EEADBC8041299A3AA7_gshared)(__this, method);
}
// System.Void AllIn1VfxToolkit.Demo.Scripts.AllIn1DemoProjectile::Initialize(UnityEngine.Transform,UnityEngine.Vector3,System.Single,UnityEngine.GameObject,System.Single)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void AllIn1DemoProjectile_Initialize_m29AD8CA03A3D10AC02561210397C78477FFF618D (AllIn1DemoProjectile_tA36F8B6BF3163732D0C981065AF301449C4AAE69 * __this, Transform_tA8193BB29D4D2C7EC04918F3ED1816345186C3F1 * ___hierarchyParent0, Vector3_t65B972D6A585A0A5B63153CF1177A90D3C90D65E  ___projectileDir1, float ___speed2, GameObject_tC000A2E1A7CF1E10FD7BA08863287C072207C319 * ___impactPrefab3, float ___impactScaleSize4, const RuntimeMethod* method);
// System.Void AllIn1VfxToolkit.Demo.Scripts.AllIn1DemoProjectile::AddScreenShakeOnImpact(System.Single)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void AllIn1DemoProjectile_AddScreenShakeOnImpact_mA99E3BAE9DB9CDD1AE8B57B87816713C30A39A00 (AllIn1DemoProjectile_tA36F8B6BF3163732D0C981065AF301449C4AAE69 * __this, float ___projectileImpactShakeAmount0, const RuntimeMethod* method);
// !!0 UnityEngine.Object::Instantiate<UnityEngine.GameObject>(!!0,UnityEngine.Transform)
inline GameObject_tC000A2E1A7CF1E10FD7BA08863287C072207C319 * Object_Instantiate_TisGameObject_tC000A2E1A7CF1E10FD7BA08863287C072207C319_mF131D53AB04E75E849487A7ACF79A8B27527F4B8 (GameObject_tC000A2E1A7CF1E10FD7BA08863287C072207C319 * ___original0, Transform_tA8193BB29D4D2C7EC04918F3ED1816345186C3F1 * ___parent1, const RuntimeMethod* method)
{
	return ((  GameObject_tC000A2E1A7CF1E10FD7BA08863287C072207C319 * (*) (GameObject_tC000A2E1A7CF1E10FD7BA08863287C072207C319 *, Transform_tA8193BB29D4D2C7EC04918F3ED1816345186C3F1 *, const RuntimeMethod*))Object_Instantiate_TisRuntimeObject_mD211EB15E9E128684605B4CC7277F10840F8E8CF_gshared)(___original0, ___parent1, method);
}
// UnityEngine.Quaternion UnityEngine.Transform::get_rotation()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR Quaternion_t6D28618CF65156D4A0AD747370DDFD0C514A31B4  Transform_get_rotation_m4AA3858C00DF4C9614B80352558C4C37D08D2200 (Transform_tA8193BB29D4D2C7EC04918F3ED1816345186C3F1 * __this, const RuntimeMethod* method);
// System.Collections.IEnumerator AllIn1VfxToolkit.Demo.Scripts.AllIn1VfxDemoController::CurrentEffectLabelTweenEffectCR()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR RuntimeObject* AllIn1VfxDemoController_CurrentEffectLabelTweenEffectCR_mB5404E4C1AE89D1FE94871E9CDC0C4F0189BC9E5 (AllIn1VfxDemoController_tDBA0E647E412D7CE6715A6976DB1E1A5722F6892 * __this, const RuntimeMethod* method);
// UnityEngine.Coroutine UnityEngine.MonoBehaviour::StartCoroutine(System.Collections.IEnumerator)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR Coroutine_t899D5232EF542CB8BA70AF9ECEECA494FAA9CCB7 * MonoBehaviour_StartCoroutine_m3E33706D38B23CDD179E99BAD61E32303E9CC719 (MonoBehaviour_t37A501200D970A8257124B0EAE00A0FF3DDC354A * __this, RuntimeObject* ___routine0, const RuntimeMethod* method);
// System.Void AllIn1VfxToolkit.Demo.Scripts.AllIn1TimeControl::CurrentEffectChanged()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void AllIn1TimeControl_CurrentEffectChanged_m542665C5D595FAA5213CD7984D171A557ABFC6C8 (AllIn1TimeControl_tD27F0B4D919AD681DB84DE2277471ABFF29C38DC * __this, const RuntimeMethod* method);
// System.Void AllIn1VfxToolkit.Demo.Scripts.AllIn1VfxDemoController::ComputeValidEffectAndCollectionIndex()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void AllIn1VfxDemoController_ComputeValidEffectAndCollectionIndex_m82A2A0050B50175B6B86231A7946C65BA1162AAF (AllIn1VfxDemoController_tDBA0E647E412D7CE6715A6976DB1E1A5722F6892 * __this, const RuntimeMethod* method);
// System.String UnityEngine.Object::get_name()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR String_t* Object_get_name_m0C7BC870ED2F0DC5A2FB09628136CD7D1CB82CFB (Object_tF2F3778131EFF286AF62B7B013A170F95A91571A * __this, const RuntimeMethod* method);
// System.Void AllIn1VfxToolkit.Demo.Scripts.AllIn1VfxDemoController/<CurrentEffectLabelTweenEffectCR>d__38::.ctor(System.Int32)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void U3CCurrentEffectLabelTweenEffectCRU3Ed__38__ctor_m1B9000091C421AFD651FC198D57793EB6F85CF1B (U3CCurrentEffectLabelTweenEffectCRU3Ed__38_t35025879B5382AE5E6D1D27E9F51C6920712C86D * __this, int32_t ___U3CU3E1__state0, const RuntimeMethod* method);
// System.Collections.IEnumerator UnityEngine.Transform::GetEnumerator()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR RuntimeObject* Transform_GetEnumerator_mBA0E884A69F0AA05FCB69F4EE5F700177F75DD7E (Transform_tA8193BB29D4D2C7EC04918F3ED1816345186C3F1 * __this, const RuntimeMethod* method);
// !!0 UnityEngine.Component::GetComponent<UnityEngine.Light>()
inline Light_tA2F349FE839781469A0344CF6039B51512394275 * Component_GetComponent_TisLight_tA2F349FE839781469A0344CF6039B51512394275_m78431E28004B9C0FF3A712F157BFEDF8D42E36EA (Component_t62FBC8D2420DA4BE9037AFE430740F6B3EECA684 * __this, const RuntimeMethod* method)
{
	return ((  Light_tA2F349FE839781469A0344CF6039B51512394275 * (*) (Component_t62FBC8D2420DA4BE9037AFE430740F6B3EECA684 *, const RuntimeMethod*))Component_GetComponent_TisRuntimeObject_m69D9C576D6DD024C709E29EEADBC8041299A3AA7_gshared)(__this, method);
}
// System.Single UnityEngine.Light::get_intensity()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR float Light_get_intensity_mFABC9E1EA23E954E1072233C33C2211D64262326 (Light_tA2F349FE839781469A0344CF6039B51512394275 * __this, const RuntimeMethod* method);
// System.Void UnityEngine.Light::set_intensity(System.Single)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Light_set_intensity_m372D5B9494809AFAD717B2707957DD1478C52DFC (Light_tA2F349FE839781469A0344CF6039B51512394275 * __this, float ___value0, const RuntimeMethod* method);
// System.Void AllIn1VfxToolkit.Demo.Scripts.AllIn1VfxParticleSystemTime::SetSimulationTime()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void AllIn1VfxParticleSystemTime_SetSimulationTime_mD07C485CA96C3C04CAB8389FFCBDE81E2B522268 (AllIn1VfxParticleSystemTime_t1EE72855BC01A8A9547DB7A4C30287E1CDF7E9EF * __this, const RuntimeMethod* method);
// System.Boolean UnityEngine.Object::op_Equality(UnityEngine.Object,UnityEngine.Object)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR bool Object_op_Equality_mEE9EC7EB5C7DC3E95B94AB904E1986FC4D566D54 (Object_tF2F3778131EFF286AF62B7B013A170F95A91571A * ___x0, Object_tF2F3778131EFF286AF62B7B013A170F95A91571A * ___y1, const RuntimeMethod* method);
// !!0 UnityEngine.Component::GetComponent<UnityEngine.ParticleSystem>()
inline ParticleSystem_t2F526CCDBD3512879B3FCBE04BCAB20D7B4F391E * Component_GetComponent_TisParticleSystem_t2F526CCDBD3512879B3FCBE04BCAB20D7B4F391E_m91CE0171326B90198E69EAFA60F45473CAC6E0C3 (Component_t62FBC8D2420DA4BE9037AFE430740F6B3EECA684 * __this, const RuntimeMethod* method)
{
	return ((  ParticleSystem_t2F526CCDBD3512879B3FCBE04BCAB20D7B4F391E * (*) (Component_t62FBC8D2420DA4BE9037AFE430740F6B3EECA684 *, const RuntimeMethod*))Component_GetComponent_TisRuntimeObject_m69D9C576D6DD024C709E29EEADBC8041299A3AA7_gshared)(__this, method);
}
// System.String System.String::Concat(System.String,System.String,System.String)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR String_t* String_Concat_m89EAB4C6A96B0E5C3F87300D6BE78D386B9EFC44 (String_t* ___str00, String_t* ___str11, String_t* ___str22, const RuntimeMethod* method);
// System.Void UnityEngine.ParticleSystem::Simulate(System.Single,System.Boolean,System.Boolean)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void ParticleSystem_Simulate_mC2F2E060D7CE94D4936BA995C49827231DF5F1F8 (ParticleSystem_t2F526CCDBD3512879B3FCBE04BCAB20D7B4F391E * __this, float ___t0, bool ___withChildren1, bool ___restart2, const RuntimeMethod* method);
// UnityEngine.Vector2 UnityEngine.Vector2::get_zero()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR Vector2_tBB32F2736AEC229A7BFBCE18197EC0F6AC7EC2D9  Vector2_get_zero_m621041B9DF5FAE86C1EF4CB28C224FEA089CB828 (const RuntimeMethod* method);
// System.Void System.Object::.ctor()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Object__ctor_m88880E0413421D13FD95325EDCE231707CE1F405 (RuntimeObject * __this, const RuntimeMethod* method);
// System.Void AllIn1VfxToolkit.Demo.Scripts.AllIn1DemoScaleTween::ScaleDownTween()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void AllIn1DemoScaleTween_ScaleDownTween_m7D782A48F0D5A8096F6ABED9BE22B118A3DD0B4B (AllIn1DemoScaleTween_t513A5592D7B99AAE00D3C297524793A01504CCD0 * __this, const RuntimeMethod* method);
// System.Void UnityEngine.Color::.ctor(System.Single,System.Single,System.Single,System.Single)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Color__ctor_m679019E6084BF7A6F82590F66F5F695F6A50ECC5 (Color_tF40DAF76C04FFECF3FE6024F85A294741C9CC659 * __this, float ___r0, float ___g1, float ___b2, float ___a3, const RuntimeMethod* method);
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
// System.Void AllIn1VfxToolkit.Demo.Scripts.All1DemoDropdownScroller::Start()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void All1DemoDropdownScroller_Start_mA45C334554B9051A9D1CA05D5456DDA03C4FD4DC (All1DemoDropdownScroller_t33876BB20D6CD2D697A869AC5FA7B0B4165FAAD1 * __this, const RuntimeMethod* method)
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Component_GetComponent_TisDropdown_t099F5232BB75810BC79EED6E27DDCED46C3BCD96_m94BE8DA5A001258F5191A0C3A4B3EED5467BF931_RuntimeMethod_var);
		s_Il2CppMethodInitialized = true;
	}
	{
		// dropdown = GetComponent<Dropdown>();
		Dropdown_t099F5232BB75810BC79EED6E27DDCED46C3BCD96 * L_0;
		L_0 = Component_GetComponent_TisDropdown_t099F5232BB75810BC79EED6E27DDCED46C3BCD96_m94BE8DA5A001258F5191A0C3A4B3EED5467BF931(__this, /*hidden argument*/Component_GetComponent_TisDropdown_t099F5232BB75810BC79EED6E27DDCED46C3BCD96_m94BE8DA5A001258F5191A0C3A4B3EED5467BF931_RuntimeMethod_var);
		__this->set_dropdown_6(L_0);
		// }
		return;
	}
}
// System.Void AllIn1VfxToolkit.Demo.Scripts.All1DemoDropdownScroller::Update()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void All1DemoDropdownScroller_Update_m6B44730366B677534483AA924AC7E7A7B19EE96B (All1DemoDropdownScroller_t33876BB20D6CD2D697A869AC5FA7B0B4165FAAD1 * __this, const RuntimeMethod* method)
{
	{
		// if(Input.GetKeyDown(nextDropdownElementKey)) NextDropdownElements();
		int32_t L_0 = __this->get_nextDropdownElementKey_5();
		bool L_1;
		L_1 = Input_GetKeyDown_m476116696E71771641BBECBAB1A4C55E69018220(L_0, /*hidden argument*/NULL);
		if (!L_1)
		{
			goto IL_0013;
		}
	}
	{
		// if(Input.GetKeyDown(nextDropdownElementKey)) NextDropdownElements();
		All1DemoDropdownScroller_NextDropdownElements_mEC886856D74B765E2ED403061C8AD0F0BD99A0D9(__this, /*hidden argument*/NULL);
	}

IL_0013:
	{
		// }
		return;
	}
}
// System.Void AllIn1VfxToolkit.Demo.Scripts.All1DemoDropdownScroller::NextDropdownElements()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void All1DemoDropdownScroller_NextDropdownElements_mEC886856D74B765E2ED403061C8AD0F0BD99A0D9 (All1DemoDropdownScroller_t33876BB20D6CD2D697A869AC5FA7B0B4165FAAD1 * __this, const RuntimeMethod* method)
{
	int32_t V_0 = 0;
	{
		// int nextValue = dropdown.value + 1;
		Dropdown_t099F5232BB75810BC79EED6E27DDCED46C3BCD96 * L_0 = __this->get_dropdown_6();
		NullCheck(L_0);
		int32_t L_1;
		L_1 = Dropdown_get_value_mFBF47E0C72050C5CB96B8B6D33F41BA2D1368F26_inline(L_0, /*hidden argument*/NULL);
		V_0 = ((int32_t)il2cpp_codegen_add((int32_t)L_1, (int32_t)1));
		// if(nextValue < 0) nextValue = dropdownElementCount - 1;
		int32_t L_2 = V_0;
		if ((((int32_t)L_2) >= ((int32_t)0)))
		{
			goto IL_001b;
		}
	}
	{
		// if(nextValue < 0) nextValue = dropdownElementCount - 1;
		int32_t L_3 = __this->get_dropdownElementCount_4();
		V_0 = ((int32_t)il2cpp_codegen_subtract((int32_t)L_3, (int32_t)1));
	}

IL_001b:
	{
		// if(nextValue >= dropdownElementCount) nextValue = 0;
		int32_t L_4 = V_0;
		int32_t L_5 = __this->get_dropdownElementCount_4();
		if ((((int32_t)L_4) < ((int32_t)L_5)))
		{
			goto IL_0026;
		}
	}
	{
		// if(nextValue >= dropdownElementCount) nextValue = 0;
		V_0 = 0;
	}

IL_0026:
	{
		// dropdown.value = nextValue;
		Dropdown_t099F5232BB75810BC79EED6E27DDCED46C3BCD96 * L_6 = __this->get_dropdown_6();
		int32_t L_7 = V_0;
		NullCheck(L_6);
		Dropdown_set_value_mE4418D205D53F8A3AD23B957D1A8CD71489CB3B9(L_6, L_7, /*hidden argument*/NULL);
		// }
		return;
	}
}
// System.Void AllIn1VfxToolkit.Demo.Scripts.All1DemoDropdownScroller::.ctor()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void All1DemoDropdownScroller__ctor_mE8AF04552DD9A9C432A6B0B422A3C755ECD9B4F6 (All1DemoDropdownScroller_t33876BB20D6CD2D697A869AC5FA7B0B4165FAAD1 * __this, const RuntimeMethod* method)
{
	{
		// [SerializeField] private KeyCode nextDropdownElementKey = KeyCode.M;
		__this->set_nextDropdownElementKey_5(((int32_t)109));
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
// System.Void AllIn1VfxToolkit.Demo.Scripts.All1DemoMouseLocker::Start()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void All1DemoMouseLocker_Start_mDE0660B774976AE27A97ED1639C087C0D6C7CBC4 (All1DemoMouseLocker_t24728648D9602EC4431794A5CB77192DBB2F1A1B * __this, const RuntimeMethod* method)
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Component_GetComponentInChildren_TisText_t6A2339DA6C05AE2646FC1A6C8FCC127391BE7FA1_mFB5C182E24F496A866F116D3F75CBD8616A46AB3_RuntimeMethod_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Component_GetComponent_TisAllIn1DemoScaleTween_t513A5592D7B99AAE00D3C297524793A01504CCD0_m3EE927F72C328FCE7176EA4E296BFBD5B69CEF6C_RuntimeMethod_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Component_GetComponent_TisAllIn1MouseRotate_t83F7508F651802AEF83D151F967CBEA41AEF7935_m76825A01424AB21D31BE24D85F3B8FB30434AD51_RuntimeMethod_var);
		s_Il2CppMethodInitialized = true;
	}
	{
		// allIn1MouseRotate = GetComponent<AllIn1MouseRotate>();
		AllIn1MouseRotate_t83F7508F651802AEF83D151F967CBEA41AEF7935 * L_0;
		L_0 = Component_GetComponent_TisAllIn1MouseRotate_t83F7508F651802AEF83D151F967CBEA41AEF7935_m76825A01424AB21D31BE24D85F3B8FB30434AD51(__this, /*hidden argument*/Component_GetComponent_TisAllIn1MouseRotate_t83F7508F651802AEF83D151F967CBEA41AEF7935_m76825A01424AB21D31BE24D85F3B8FB30434AD51_RuntimeMethod_var);
		__this->set_allIn1MouseRotate_7(L_0);
		// lockedTween = lockButtonImage.GetComponent<AllIn1DemoScaleTween>();
		Image_t4021FF27176E44BFEDDCBE43C7FE6B713EC70D3C * L_1 = __this->get_lockButtonImage_5();
		NullCheck(L_1);
		AllIn1DemoScaleTween_t513A5592D7B99AAE00D3C297524793A01504CCD0 * L_2;
		L_2 = Component_GetComponent_TisAllIn1DemoScaleTween_t513A5592D7B99AAE00D3C297524793A01504CCD0_m3EE927F72C328FCE7176EA4E296BFBD5B69CEF6C(L_1, /*hidden argument*/Component_GetComponent_TisAllIn1DemoScaleTween_t513A5592D7B99AAE00D3C297524793A01504CCD0_m3EE927F72C328FCE7176EA4E296BFBD5B69CEF6C_RuntimeMethod_var);
		__this->set_lockedTween_8(L_2);
		// pausedButtonText = lockButtonImage.GetComponentInChildren<Text>();
		Image_t4021FF27176E44BFEDDCBE43C7FE6B713EC70D3C * L_3 = __this->get_lockButtonImage_5();
		NullCheck(L_3);
		Text_t6A2339DA6C05AE2646FC1A6C8FCC127391BE7FA1 * L_4;
		L_4 = Component_GetComponentInChildren_TisText_t6A2339DA6C05AE2646FC1A6C8FCC127391BE7FA1_mFB5C182E24F496A866F116D3F75CBD8616A46AB3(L_3, /*hidden argument*/Component_GetComponentInChildren_TisText_t6A2339DA6C05AE2646FC1A6C8FCC127391BE7FA1_mFB5C182E24F496A866F116D3F75CBD8616A46AB3_RuntimeMethod_var);
		__this->set_pausedButtonText_9(L_4);
		// }
		return;
	}
}
// System.Void AllIn1VfxToolkit.Demo.Scripts.All1DemoMouseLocker::Update()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void All1DemoMouseLocker_Update_m534EB1EA702024482E03FF8D433681BEBE85FF25 (All1DemoMouseLocker_t24728648D9602EC4431794A5CB77192DBB2F1A1B * __this, const RuntimeMethod* method)
{
	{
		// if(Input.GetKeyDown(mouseLockerKey)) DoMouseLockToggle();
		int32_t L_0 = __this->get_mouseLockerKey_4();
		bool L_1;
		L_1 = Input_GetKeyDown_m476116696E71771641BBECBAB1A4C55E69018220(L_0, /*hidden argument*/NULL);
		if (!L_1)
		{
			goto IL_0013;
		}
	}
	{
		// if(Input.GetKeyDown(mouseLockerKey)) DoMouseLockToggle();
		All1DemoMouseLocker_DoMouseLockToggle_m99670B369CE1EEA9F3B802CD46CC1212BB2EA58D(__this, /*hidden argument*/NULL);
	}

IL_0013:
	{
		// }
		return;
	}
}
// System.Void AllIn1VfxToolkit.Demo.Scripts.All1DemoMouseLocker::DoMouseLockToggle()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void All1DemoMouseLocker_DoMouseLockToggle_m99670B369CE1EEA9F3B802CD46CC1212BB2EA58D (All1DemoMouseLocker_t24728648D9602EC4431794A5CB77192DBB2F1A1B * __this, const RuntimeMethod* method)
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&_stringLiteral006976E56695070D63E145217B701EDEE8895C82);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&_stringLiteral493129A97A0C654B32ECBC950426300104965D7F);
		s_Il2CppMethodInitialized = true;
	}
	{
		// currentlyLocked = !currentlyLocked;
		bool L_0 = __this->get_currentlyLocked_10();
		__this->set_currentlyLocked_10((bool)((((int32_t)L_0) == ((int32_t)0))? 1 : 0));
		// allIn1MouseRotate.enabled = !currentlyLocked;
		AllIn1MouseRotate_t83F7508F651802AEF83D151F967CBEA41AEF7935 * L_1 = __this->get_allIn1MouseRotate_7();
		bool L_2 = __this->get_currentlyLocked_10();
		NullCheck(L_1);
		Behaviour_set_enabled_mDE415591B28853D1CD764C53CB499A2142247F32(L_1, (bool)((((int32_t)L_2) == ((int32_t)0))? 1 : 0), /*hidden argument*/NULL);
		// lockedTween.ScaleUpTween();
		AllIn1DemoScaleTween_t513A5592D7B99AAE00D3C297524793A01504CCD0 * L_3 = __this->get_lockedTween_8();
		NullCheck(L_3);
		AllIn1DemoScaleTween_ScaleUpTween_m003B3BF936F501523FB03E83AA493B449CDF2D3F(L_3, /*hidden argument*/NULL);
		// if(currentlyLocked)
		bool L_4 = __this->get_currentlyLocked_10();
		if (!L_4)
		{
			goto IL_0058;
		}
	}
	{
		// pausedButtonText.text = "Unlock Camera";
		Text_t6A2339DA6C05AE2646FC1A6C8FCC127391BE7FA1 * L_5 = __this->get_pausedButtonText_9();
		NullCheck(L_5);
		VirtActionInvoker1< String_t* >::Invoke(75 /* System.Void UnityEngine.UI.Text::set_text(System.String) */, L_5, _stringLiteral493129A97A0C654B32ECBC950426300104965D7F);
		// lockButtonImage.color = lockButtonColor;
		Image_t4021FF27176E44BFEDDCBE43C7FE6B713EC70D3C * L_6 = __this->get_lockButtonImage_5();
		Color_tF40DAF76C04FFECF3FE6024F85A294741C9CC659  L_7 = __this->get_lockButtonColor_6();
		NullCheck(L_6);
		VirtActionInvoker1< Color_tF40DAF76C04FFECF3FE6024F85A294741C9CC659  >::Invoke(23 /* System.Void UnityEngine.UI.Graphic::set_color(UnityEngine.Color) */, L_6, L_7);
		// }
		return;
	}

IL_0058:
	{
		// pausedButtonText.text = "Lock Camera";
		Text_t6A2339DA6C05AE2646FC1A6C8FCC127391BE7FA1 * L_8 = __this->get_pausedButtonText_9();
		NullCheck(L_8);
		VirtActionInvoker1< String_t* >::Invoke(75 /* System.Void UnityEngine.UI.Text::set_text(System.String) */, L_8, _stringLiteral006976E56695070D63E145217B701EDEE8895C82);
		// lockButtonImage.color = Color.white;
		Image_t4021FF27176E44BFEDDCBE43C7FE6B713EC70D3C * L_9 = __this->get_lockButtonImage_5();
		Color_tF40DAF76C04FFECF3FE6024F85A294741C9CC659  L_10;
		L_10 = Color_get_white_mB21E47D20959C3AEC41AF8BA04F63AC89FAF319E(/*hidden argument*/NULL);
		NullCheck(L_9);
		VirtActionInvoker1< Color_tF40DAF76C04FFECF3FE6024F85A294741C9CC659  >::Invoke(23 /* System.Void UnityEngine.UI.Graphic::set_color(UnityEngine.Color) */, L_9, L_10);
		// }
		return;
	}
}
// System.Void AllIn1VfxToolkit.Demo.Scripts.All1DemoMouseLocker::.ctor()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void All1DemoMouseLocker__ctor_m10814BA7FD1755A375FD6D8538B4E3C679694722 (All1DemoMouseLocker_t24728648D9602EC4431794A5CB77192DBB2F1A1B * __this, const RuntimeMethod* method)
{
	{
		// [SerializeField] private KeyCode mouseLockerKey = KeyCode.L;
		__this->set_mouseLockerKey_4(((int32_t)108));
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
// System.Void AllIn1VfxToolkit.Demo.Scripts.All1DemoProjectileObstacle::Start()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void All1DemoProjectileObstacle_Start_m8E715434031A164453716AD25FCD84F5C222AF26 (All1DemoProjectileObstacle_t3447F820D7618A5E02F662177938AD4A57ECBBE1 * __this, const RuntimeMethod* method)
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Component_GetComponent_TisDropdown_t099F5232BB75810BC79EED6E27DDCED46C3BCD96_m94BE8DA5A001258F5191A0C3A4B3EED5467BF931_RuntimeMethod_var);
		s_Il2CppMethodInitialized = true;
	}
	{
		// projectileObstacleDropdown = GetComponent<Dropdown>();
		Dropdown_t099F5232BB75810BC79EED6E27DDCED46C3BCD96 * L_0;
		L_0 = Component_GetComponent_TisDropdown_t099F5232BB75810BC79EED6E27DDCED46C3BCD96_m94BE8DA5A001258F5191A0C3A4B3EED5467BF931(__this, /*hidden argument*/Component_GetComponent_TisDropdown_t099F5232BB75810BC79EED6E27DDCED46C3BCD96_m94BE8DA5A001258F5191A0C3A4B3EED5467BF931_RuntimeMethod_var);
		__this->set_projectileObstacleDropdown_5(L_0);
		// DropdownValueChanged();
		All1DemoProjectileObstacle_DropdownValueChanged_mE17B634DBC2F7611FE3EFF197EACA44FE7889500(__this, /*hidden argument*/NULL);
		// }
		return;
	}
}
// System.Void AllIn1VfxToolkit.Demo.Scripts.All1DemoProjectileObstacle::DropdownValueChanged()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void All1DemoProjectileObstacle_DropdownValueChanged_mE17B634DBC2F7611FE3EFF197EACA44FE7889500 (All1DemoProjectileObstacle_t3447F820D7618A5E02F662177938AD4A57ECBBE1 * __this, const RuntimeMethod* method)
{
	{
		// SetProjectileObstacleN(projectileObstacleDropdown.value);
		Dropdown_t099F5232BB75810BC79EED6E27DDCED46C3BCD96 * L_0 = __this->get_projectileObstacleDropdown_5();
		NullCheck(L_0);
		int32_t L_1;
		L_1 = Dropdown_get_value_mFBF47E0C72050C5CB96B8B6D33F41BA2D1368F26_inline(L_0, /*hidden argument*/NULL);
		All1DemoProjectileObstacle_SetProjectileObstacleN_m683D166F4AE24C5C93368366CBD018818DC36A82(__this, L_1, /*hidden argument*/NULL);
		// }
		return;
	}
}
// System.Void AllIn1VfxToolkit.Demo.Scripts.All1DemoProjectileObstacle::SetProjectileObstacleN(System.Int32)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void All1DemoProjectileObstacle_SetProjectileObstacleN_m683D166F4AE24C5C93368366CBD018818DC36A82 (All1DemoProjectileObstacle_t3447F820D7618A5E02F662177938AD4A57ECBBE1 * __this, int32_t ___nIndex0, const RuntimeMethod* method)
{
	int32_t V_0 = 0;
	{
		// for(int i = 0; i < projectileObstacles.Length; i++) projectileObstacles[i].SetActive(i == nIndex);
		V_0 = 0;
		goto IL_0019;
	}

IL_0004:
	{
		// for(int i = 0; i < projectileObstacles.Length; i++) projectileObstacles[i].SetActive(i == nIndex);
		GameObjectU5BU5D_tA88FC1A1FC9D4D73D0B3984D4B0ECE88F4C47642* L_0 = __this->get_projectileObstacles_4();
		int32_t L_1 = V_0;
		NullCheck(L_0);
		int32_t L_2 = L_1;
		GameObject_tC000A2E1A7CF1E10FD7BA08863287C072207C319 * L_3 = (L_0)->GetAt(static_cast<il2cpp_array_size_t>(L_2));
		int32_t L_4 = V_0;
		int32_t L_5 = ___nIndex0;
		NullCheck(L_3);
		GameObject_SetActive_mCF1EEF2A314F3AE85DA581FF52EB06ACEF2FFF86(L_3, (bool)((((int32_t)L_4) == ((int32_t)L_5))? 1 : 0), /*hidden argument*/NULL);
		// for(int i = 0; i < projectileObstacles.Length; i++) projectileObstacles[i].SetActive(i == nIndex);
		int32_t L_6 = V_0;
		V_0 = ((int32_t)il2cpp_codegen_add((int32_t)L_6, (int32_t)1));
	}

IL_0019:
	{
		// for(int i = 0; i < projectileObstacles.Length; i++) projectileObstacles[i].SetActive(i == nIndex);
		int32_t L_7 = V_0;
		GameObjectU5BU5D_tA88FC1A1FC9D4D73D0B3984D4B0ECE88F4C47642* L_8 = __this->get_projectileObstacles_4();
		NullCheck(L_8);
		if ((((int32_t)L_7) < ((int32_t)((int32_t)((int32_t)(((RuntimeArray*)L_8)->max_length))))))
		{
			goto IL_0004;
		}
	}
	{
		// }
		return;
	}
}
// System.Void AllIn1VfxToolkit.Demo.Scripts.All1DemoProjectileObstacle::.ctor()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void All1DemoProjectileObstacle__ctor_mDCE80B5AC1ADCF4FF1377B40DCCA4F3A414F01B3 (All1DemoProjectileObstacle_t3447F820D7618A5E02F662177938AD4A57ECBBE1 * __this, const RuntimeMethod* method)
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
// System.Void AllIn1VfxToolkit.Demo.Scripts.All1DemoSceneColor::Start()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void All1DemoSceneColor_Start_mC8436C481433FFD9878C8BF384B33BF9545BC611 (All1DemoSceneColor_t88AAEE683C473BDFBB9BDB8A0390F9F981928A09 * __this, const RuntimeMethod* method)
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Component_GetComponent_TisDropdown_t099F5232BB75810BC79EED6E27DDCED46C3BCD96_m94BE8DA5A001258F5191A0C3A4B3EED5467BF931_RuntimeMethod_var);
		s_Il2CppMethodInitialized = true;
	}
	{
		// sceneColorDropdown = GetComponent<Dropdown>();
		Dropdown_t099F5232BB75810BC79EED6E27DDCED46C3BCD96 * L_0;
		L_0 = Component_GetComponent_TisDropdown_t099F5232BB75810BC79EED6E27DDCED46C3BCD96_m94BE8DA5A001258F5191A0C3A4B3EED5467BF931(__this, /*hidden argument*/Component_GetComponent_TisDropdown_t099F5232BB75810BC79EED6E27DDCED46C3BCD96_m94BE8DA5A001258F5191A0C3A4B3EED5467BF931_RuntimeMethod_var);
		__this->set_sceneColorDropdown_10(L_0);
		// floorMaterial = floorMeshRenderer.material;
		MeshRenderer_tCD983A2F635E12BCB0BAA2E635D96A318757908B * L_1 = __this->get_floorMeshRenderer_7();
		NullCheck(L_1);
		Material_t8927C00353A72755313F046D0CE85178AE8218EE * L_2;
		L_2 = Renderer_get_material_mE6B01125502D08EE0D6DFE2EAEC064AD9BB31804(L_1, /*hidden argument*/NULL);
		__this->set_floorMaterial_11(L_2);
		// DropdownValueChanged();
		All1DemoSceneColor_DropdownValueChanged_m3D9554F73E4A726406620014DAFED1EFB803C477(__this, /*hidden argument*/NULL);
		// }
		return;
	}
}
// System.Void AllIn1VfxToolkit.Demo.Scripts.All1DemoSceneColor::DropdownValueChanged()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void All1DemoSceneColor_DropdownValueChanged_m3D9554F73E4A726406620014DAFED1EFB803C477 (All1DemoSceneColor_t88AAEE683C473BDFBB9BDB8A0390F9F981928A09 * __this, const RuntimeMethod* method)
{
	{
		// SetSceneColor(sceneColorDropdown.value);
		Dropdown_t099F5232BB75810BC79EED6E27DDCED46C3BCD96 * L_0 = __this->get_sceneColorDropdown_10();
		NullCheck(L_0);
		int32_t L_1;
		L_1 = Dropdown_get_value_mFBF47E0C72050C5CB96B8B6D33F41BA2D1368F26_inline(L_0, /*hidden argument*/NULL);
		All1DemoSceneColor_SetSceneColor_mF57B16A5F719B8A2AE936303FCFE588ECC83562C(__this, L_1, /*hidden argument*/NULL);
		// }
		return;
	}
}
// System.Void AllIn1VfxToolkit.Demo.Scripts.All1DemoSceneColor::SetSceneColor(System.Int32)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void All1DemoSceneColor_SetSceneColor_mF57B16A5F719B8A2AE936303FCFE588ECC83562C (All1DemoSceneColor_t88AAEE683C473BDFBB9BDB8A0390F9F981928A09 * __this, int32_t ___nIndex0, const RuntimeMethod* method)
{
	{
		// targetCamera.backgroundColor = sceneColors[nIndex] * cameraColorMult;
		Camera_tC44E094BAB53AFC8A014C6F9CFCE11F4FC38006C * L_0 = __this->get_targetCamera_5();
		ColorU5BU5D_t358DD89F511301E663AD9157305B94A2DEFF8834* L_1 = __this->get_sceneColors_4();
		int32_t L_2 = ___nIndex0;
		NullCheck(L_1);
		int32_t L_3 = L_2;
		Color_tF40DAF76C04FFECF3FE6024F85A294741C9CC659  L_4 = (L_1)->GetAt(static_cast<il2cpp_array_size_t>(L_3));
		float L_5 = __this->get_cameraColorMult_6();
		Color_tF40DAF76C04FFECF3FE6024F85A294741C9CC659  L_6;
		L_6 = Color_op_Multiply_m1A1E7DECD013FBEB99018CEDDC30B8A7CF99941D(L_4, L_5, /*hidden argument*/NULL);
		NullCheck(L_0);
		Camera_set_backgroundColor_m7083574094F4031F3289444E1AF4CBC4FEDACFCF(L_0, L_6, /*hidden argument*/NULL);
		// floorMaterial.color = sceneColors[nIndex] * floorColorMult;
		Material_t8927C00353A72755313F046D0CE85178AE8218EE * L_7 = __this->get_floorMaterial_11();
		ColorU5BU5D_t358DD89F511301E663AD9157305B94A2DEFF8834* L_8 = __this->get_sceneColors_4();
		int32_t L_9 = ___nIndex0;
		NullCheck(L_8);
		int32_t L_10 = L_9;
		Color_tF40DAF76C04FFECF3FE6024F85A294741C9CC659  L_11 = (L_8)->GetAt(static_cast<il2cpp_array_size_t>(L_10));
		float L_12 = __this->get_floorColorMult_8();
		Color_tF40DAF76C04FFECF3FE6024F85A294741C9CC659  L_13;
		L_13 = Color_op_Multiply_m1A1E7DECD013FBEB99018CEDDC30B8A7CF99941D(L_11, L_12, /*hidden argument*/NULL);
		NullCheck(L_7);
		Material_set_color_mC3C88E2389B7132EBF3EB0D1F040545176B795C0(L_7, L_13, /*hidden argument*/NULL);
		// RenderSettings.fogColor = sceneColors[nIndex] * fogColorMult;
		ColorU5BU5D_t358DD89F511301E663AD9157305B94A2DEFF8834* L_14 = __this->get_sceneColors_4();
		int32_t L_15 = ___nIndex0;
		NullCheck(L_14);
		int32_t L_16 = L_15;
		Color_tF40DAF76C04FFECF3FE6024F85A294741C9CC659  L_17 = (L_14)->GetAt(static_cast<il2cpp_array_size_t>(L_16));
		float L_18 = __this->get_fogColorMult_9();
		Color_tF40DAF76C04FFECF3FE6024F85A294741C9CC659  L_19;
		L_19 = Color_op_Multiply_m1A1E7DECD013FBEB99018CEDDC30B8A7CF99941D(L_17, L_18, /*hidden argument*/NULL);
		RenderSettings_set_fogColor_mC46154762710EFAA869A4E972C16D1FE9B0EA01F(L_19, /*hidden argument*/NULL);
		// }
		return;
	}
}
// System.Void AllIn1VfxToolkit.Demo.Scripts.All1DemoSceneColor::.ctor()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void All1DemoSceneColor__ctor_mF91FD56B16A1DDAED1F9159BE3B9DF9A372464C1 (All1DemoSceneColor_t88AAEE683C473BDFBB9BDB8A0390F9F981928A09 * __this, const RuntimeMethod* method)
{
	{
		// [SerializeField] private float cameraColorMult = 1f;
		__this->set_cameraColorMult_6((1.0f));
		// [SerializeField] private float floorColorMult = 1f;
		__this->set_floorColorMult_8((1.0f));
		// [SerializeField] private float fogColorMult = 1f;
		__this->set_fogColorMult_9((1.0f));
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
// System.Void AllIn1VfxToolkit.Demo.Scripts.All1VfxDemoEffect::.ctor()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void All1VfxDemoEffect__ctor_mCF9CA53176CC2BE5E64211F959FF2A122765C7CB (All1VfxDemoEffect_t66A278FEFF55B095702CEE911709440057966E75 * __this, const RuntimeMethod* method)
{
	{
		// public bool canBePlayedAgain = true;
		__this->set_canBePlayedAgain_5((bool)1);
		// public float cooldown = 0.25f;
		__this->set_cooldown_7((0.25f));
		// public float projectileSpeed = 15f;
		__this->set_projectileSpeed_11((15.0f));
		// public float mainEffectShakeAmount = 1f;
		__this->set_mainEffectShakeAmount_16((1.0f));
		// [Header("Only if Shoot Projectile")] public float projectileImpactShakeAmount = 1f;
		__this->set_projectileImpactShakeAmount_17((1.0f));
		// public float scaleMultiplier = 1f;
		__this->set_scaleMultiplier_19((1.0f));
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
// System.Void AllIn1VfxToolkit.Demo.Scripts.All1VfxDemoEffectCollection::.ctor()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void All1VfxDemoEffectCollection__ctor_m114F50DD9D4289DEA79723ABF94F73828E91765E (All1VfxDemoEffectCollection_tE355DD3FC1A635D51B056A1524F452ACFC312C7E * __this, const RuntimeMethod* method)
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
// System.Void AllIn1VfxToolkit.Demo.Scripts.AllIn1AutoRotate::Update()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void AllIn1AutoRotate_Update_m65C0CEF535AD492B0321A27FA4C4F7A930B38F42 (AllIn1AutoRotate_t85B144A09CA74C1EAE0DD3FE1CE5DFC4518CE80F * __this, const RuntimeMethod* method)
{
	{
		// transform.Rotate(rotationAxis * (rotationSpeed * Time.deltaTime), Space.Self);
		Transform_tA8193BB29D4D2C7EC04918F3ED1816345186C3F1 * L_0;
		L_0 = Component_get_transform_mE8496EBC45BEB1BADB5F314960F1DF1C952FA11F(__this, /*hidden argument*/NULL);
		Vector3_t65B972D6A585A0A5B63153CF1177A90D3C90D65E  L_1 = __this->get_rotationAxis_5();
		float L_2 = __this->get_rotationSpeed_4();
		float L_3;
		L_3 = Time_get_deltaTime_mCC15F147DA67F38C74CE408FB5D7FF4A87DA2290(/*hidden argument*/NULL);
		Vector3_t65B972D6A585A0A5B63153CF1177A90D3C90D65E  L_4;
		L_4 = Vector3_op_Multiply_m9EA3D18290418D7B410C7D11C4788C13BFD2C30A_inline(L_1, ((float)il2cpp_codegen_multiply((float)L_2, (float)L_3)), /*hidden argument*/NULL);
		NullCheck(L_0);
		Transform_Rotate_m61816C8A09C86A5E157EA89965A9CC0510A1B378(L_0, L_4, 1, /*hidden argument*/NULL);
		// }
		return;
	}
}
// System.Void AllIn1VfxToolkit.Demo.Scripts.AllIn1AutoRotate::.ctor()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void AllIn1AutoRotate__ctor_m071BFEDD294D332BE7B2BC3BD9D2BDF8D3787DED (AllIn1AutoRotate_t85B144A09CA74C1EAE0DD3FE1CE5DFC4518CE80F * __this, const RuntimeMethod* method)
{
	{
		// [SerializeField] private float rotationSpeed = 30f;
		__this->set_rotationSpeed_4((30.0f));
		// [SerializeField] private Vector3 rotationAxis = Vector3.up;
		Vector3_t65B972D6A585A0A5B63153CF1177A90D3C90D65E  L_0;
		L_0 = Vector3_get_up_m38AECA68388D446CFADDD022B0B867293044EA50(/*hidden argument*/NULL);
		__this->set_rotationAxis_5(L_0);
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
// System.Void AllIn1VfxToolkit.Demo.Scripts.AllIn1CanvasFader::Start()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void AllIn1CanvasFader_Start_mE5906B9877D52D29D74E495D8294B2E6750C4933 (AllIn1CanvasFader_tB4AA563ED5CFF1F6FC9B974944AA53A94532162A * __this, const RuntimeMethod* method)
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Component_GetComponent_TisCanvasGroup_t6912220105AB4A288A2FD882D163D7218EAA577F_mFED0C73400AFB37A709212A6C61F9BF44DBB88C4_RuntimeMethod_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Object_tF2F3778131EFF286AF62B7B013A170F95A91571A_il2cpp_TypeInfo_var);
		s_Il2CppMethodInitialized = true;
	}
	{
		// canvasGroup = GetComponent<CanvasGroup>();
		CanvasGroup_t6912220105AB4A288A2FD882D163D7218EAA577F * L_0;
		L_0 = Component_GetComponent_TisCanvasGroup_t6912220105AB4A288A2FD882D163D7218EAA577F_mFED0C73400AFB37A709212A6C61F9BF44DBB88C4(__this, /*hidden argument*/Component_GetComponent_TisCanvasGroup_t6912220105AB4A288A2FD882D163D7218EAA577F_mFED0C73400AFB37A709212A6C61F9BF44DBB88C4_RuntimeMethod_var);
		__this->set_canvasGroup_10(L_0);
		// canvasGroup.alpha = 1f;
		CanvasGroup_t6912220105AB4A288A2FD882D163D7218EAA577F * L_1 = __this->get_canvasGroup_10();
		NullCheck(L_1);
		CanvasGroup_set_alpha_m522B58BDF64D87252B0D43D254FF3A4D5993DC53(L_1, (1.0f), /*hidden argument*/NULL);
		// hideUiButtonTweenNotNull = hideUiButtonTween != null;
		AllIn1DemoScaleTween_t513A5592D7B99AAE00D3C297524793A01504CCD0 * L_2 = __this->get_hideUiButtonTween_6();
		IL2CPP_RUNTIME_CLASS_INIT(Object_tF2F3778131EFF286AF62B7B013A170F95A91571A_il2cpp_TypeInfo_var);
		bool L_3;
		L_3 = Object_op_Inequality_mE1F187520BD83FB7D86A6D850710C4D42B864E90(L_2, (Object_tF2F3778131EFF286AF62B7B013A170F95A91571A *)NULL, /*hidden argument*/NULL);
		__this->set_hideUiButtonTweenNotNull_11(L_3);
		// }
		return;
	}
}
// System.Void AllIn1VfxToolkit.Demo.Scripts.AllIn1CanvasFader::Update()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void AllIn1CanvasFader_Update_m5D191C36EE95F47D4CB32D5C31E9D7D09CF475B7 (AllIn1CanvasFader_tB4AA563ED5CFF1F6FC9B974944AA53A94532162A * __this, const RuntimeMethod* method)
{
	{
		// if(Input.GetKeyDown(fadeToggleKey)) HideUiButtonPressed();
		int32_t L_0 = __this->get_fadeToggleKey_4();
		bool L_1;
		L_1 = Input_GetKeyDown_m476116696E71771641BBECBAB1A4C55E69018220(L_0, /*hidden argument*/NULL);
		if (!L_1)
		{
			goto IL_0013;
		}
	}
	{
		// if(Input.GetKeyDown(fadeToggleKey)) HideUiButtonPressed();
		AllIn1CanvasFader_HideUiButtonPressed_mC8306AED561C3C7A4DDEEC13AD337619505C1449(__this, /*hidden argument*/NULL);
	}

IL_0013:
	{
		// if(!isTweening) return;
		bool L_2 = __this->get_isTweening_7();
		if (L_2)
		{
			goto IL_001c;
		}
	}
	{
		// if(!isTweening) return;
		return;
	}

IL_001c:
	{
		// currentAlpha = Mathf.MoveTowards(currentAlpha, targetAlpha, Time.unscaledDeltaTime * tweenSpeed);
		float L_3 = __this->get_currentAlpha_8();
		float L_4 = __this->get_targetAlpha_9();
		float L_5;
		L_5 = Time_get_unscaledDeltaTime_m2C153F1E5C77C6AF655054BC6C76D0C334C0DC84(/*hidden argument*/NULL);
		float L_6 = __this->get_tweenSpeed_5();
		float L_7;
		L_7 = Mathf_MoveTowards_mE0689B09DD10CD59A01EE9E24880A5BA495FD321(L_3, L_4, ((float)il2cpp_codegen_multiply((float)L_5, (float)L_6)), /*hidden argument*/NULL);
		__this->set_currentAlpha_8(L_7);
		// canvasGroup.alpha = currentAlpha;
		CanvasGroup_t6912220105AB4A288A2FD882D163D7218EAA577F * L_8 = __this->get_canvasGroup_10();
		float L_9 = __this->get_currentAlpha_8();
		NullCheck(L_8);
		CanvasGroup_set_alpha_m522B58BDF64D87252B0D43D254FF3A4D5993DC53(L_8, L_9, /*hidden argument*/NULL);
		// if(targetAlpha == currentAlpha) isTweening = false;
		float L_10 = __this->get_targetAlpha_9();
		float L_11 = __this->get_currentAlpha_8();
		if ((!(((float)L_10) == ((float)L_11))))
		{
			goto IL_0065;
		}
	}
	{
		// if(targetAlpha == currentAlpha) isTweening = false;
		__this->set_isTweening_7((bool)0);
	}

IL_0065:
	{
		// }
		return;
	}
}
// System.Void AllIn1VfxToolkit.Demo.Scripts.AllIn1CanvasFader::HideUiButtonPressed()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void AllIn1CanvasFader_HideUiButtonPressed_mC8306AED561C3C7A4DDEEC13AD337619505C1449 (AllIn1CanvasFader_tB4AA563ED5CFF1F6FC9B974944AA53A94532162A * __this, const RuntimeMethod* method)
{
	{
		// if(currentAlpha < 0.01f) MakeCanvasVisibleTween();
		float L_0 = __this->get_currentAlpha_8();
		if ((!(((float)L_0) < ((float)(0.00999999978f)))))
		{
			goto IL_0015;
		}
	}
	{
		// if(currentAlpha < 0.01f) MakeCanvasVisibleTween();
		AllIn1CanvasFader_MakeCanvasVisibleTween_mD7238298C5D747BFC25E233801AAF81A101C91D2(__this, /*hidden argument*/NULL);
		goto IL_001b;
	}

IL_0015:
	{
		// else MakeCanvasInvisibleTween();
		AllIn1CanvasFader_MakeCanvasInvisibleTween_m001BA461382558D8E3AEC6418DE3C17C7DF0E689(__this, /*hidden argument*/NULL);
	}

IL_001b:
	{
		// if(hideUiButtonTweenNotNull) hideUiButtonTween.ScaleUpTween();
		bool L_1 = __this->get_hideUiButtonTweenNotNull_11();
		if (!L_1)
		{
			goto IL_002e;
		}
	}
	{
		// if(hideUiButtonTweenNotNull) hideUiButtonTween.ScaleUpTween();
		AllIn1DemoScaleTween_t513A5592D7B99AAE00D3C297524793A01504CCD0 * L_2 = __this->get_hideUiButtonTween_6();
		NullCheck(L_2);
		AllIn1DemoScaleTween_ScaleUpTween_m003B3BF936F501523FB03E83AA493B449CDF2D3F(L_2, /*hidden argument*/NULL);
	}

IL_002e:
	{
		// }
		return;
	}
}
// System.Void AllIn1VfxToolkit.Demo.Scripts.AllIn1CanvasFader::MakeCanvasVisibleTween()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void AllIn1CanvasFader_MakeCanvasVisibleTween_mD7238298C5D747BFC25E233801AAF81A101C91D2 (AllIn1CanvasFader_tB4AA563ED5CFF1F6FC9B974944AA53A94532162A * __this, const RuntimeMethod* method)
{
	{
		// isTweening = true;
		__this->set_isTweening_7((bool)1);
		// targetAlpha = 1f;
		__this->set_targetAlpha_9((1.0f));
		// }
		return;
	}
}
// System.Void AllIn1VfxToolkit.Demo.Scripts.AllIn1CanvasFader::MakeCanvasInvisibleTween()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void AllIn1CanvasFader_MakeCanvasInvisibleTween_m001BA461382558D8E3AEC6418DE3C17C7DF0E689 (AllIn1CanvasFader_tB4AA563ED5CFF1F6FC9B974944AA53A94532162A * __this, const RuntimeMethod* method)
{
	{
		// isTweening = true;
		__this->set_isTweening_7((bool)1);
		// targetAlpha = 0f;
		__this->set_targetAlpha_9((0.0f));
		// }
		return;
	}
}
// System.Void AllIn1VfxToolkit.Demo.Scripts.AllIn1CanvasFader::.ctor()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void AllIn1CanvasFader__ctor_m94FCC451FFDDB17E514B4EC85F6E258C85EDCB78 (AllIn1CanvasFader_tB4AA563ED5CFF1F6FC9B974944AA53A94532162A * __this, const RuntimeMethod* method)
{
	{
		// [SerializeField] private KeyCode fadeToggleKey = KeyCode.U;
		__this->set_fadeToggleKey_4(((int32_t)117));
		// [SerializeField] private float tweenSpeed = 1f;
		__this->set_tweenSpeed_5((1.0f));
		// private float currentAlpha = 1f;
		__this->set_currentAlpha_8((1.0f));
		// private float targetAlpha = 1f;
		__this->set_targetAlpha_9((1.0f));
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
// System.Void AllIn1VfxToolkit.Demo.Scripts.AllIn1ChangeAllChildTextFonts::Start()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void AllIn1ChangeAllChildTextFonts_Start_m314ECC4424435751F34BBDD348CE94D755A877B9 (AllIn1ChangeAllChildTextFonts_t11C8807E2A6936E92C06EFAD7E046BE279C4E433 * __this, const RuntimeMethod* method)
{
	{
		// if(changeFontOnStart) ChangeFonts();
		bool L_0 = __this->get_changeFontOnStart_5();
		if (!L_0)
		{
			goto IL_000e;
		}
	}
	{
		// if(changeFontOnStart) ChangeFonts();
		AllIn1ChangeAllChildTextFonts_ChangeFonts_mB06662F5F27E476D347C0612929950C47594238E(__this, /*hidden argument*/NULL);
	}

IL_000e:
	{
		// }
		return;
	}
}
// System.Void AllIn1VfxToolkit.Demo.Scripts.AllIn1ChangeAllChildTextFonts::ChangeFonts()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void AllIn1ChangeAllChildTextFonts_ChangeFonts_mB06662F5F27E476D347C0612929950C47594238E (AllIn1ChangeAllChildTextFonts_t11C8807E2A6936E92C06EFAD7E046BE279C4E433 * __this, const RuntimeMethod* method)
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Component_GetComponentsInChildren_TisText_t6A2339DA6C05AE2646FC1A6C8FCC127391BE7FA1_m7556907CF90B895FDFBEC11100A5F7AD5FAF1AA6_RuntimeMethod_var);
		s_Il2CppMethodInitialized = true;
	}
	TextU5BU5D_t16DD1967B137EC602803C77DBB246B05B3D0275F* V_0 = NULL;
	int32_t V_1 = 0;
	{
		// Text[] canvasTexts = GetComponentsInChildren<Text>();
		TextU5BU5D_t16DD1967B137EC602803C77DBB246B05B3D0275F* L_0;
		L_0 = Component_GetComponentsInChildren_TisText_t6A2339DA6C05AE2646FC1A6C8FCC127391BE7FA1_m7556907CF90B895FDFBEC11100A5F7AD5FAF1AA6(__this, /*hidden argument*/Component_GetComponentsInChildren_TisText_t6A2339DA6C05AE2646FC1A6C8FCC127391BE7FA1_m7556907CF90B895FDFBEC11100A5F7AD5FAF1AA6_RuntimeMethod_var);
		V_0 = L_0;
		// for(int i = 0; i < canvasTexts.Length; i++) canvasTexts[i].font = newFont;
		V_1 = 0;
		goto IL_001d;
	}

IL_000b:
	{
		// for(int i = 0; i < canvasTexts.Length; i++) canvasTexts[i].font = newFont;
		TextU5BU5D_t16DD1967B137EC602803C77DBB246B05B3D0275F* L_1 = V_0;
		int32_t L_2 = V_1;
		NullCheck(L_1);
		int32_t L_3 = L_2;
		Text_t6A2339DA6C05AE2646FC1A6C8FCC127391BE7FA1 * L_4 = (L_1)->GetAt(static_cast<il2cpp_array_size_t>(L_3));
		Font_tB53D3F362CB1A0B92307B362826F212AE2D2A6A9 * L_5 = __this->get_newFont_4();
		NullCheck(L_4);
		Text_set_font_m10F529719C942343F7B963D28480A20940CD0B52(L_4, L_5, /*hidden argument*/NULL);
		// for(int i = 0; i < canvasTexts.Length; i++) canvasTexts[i].font = newFont;
		int32_t L_6 = V_1;
		V_1 = ((int32_t)il2cpp_codegen_add((int32_t)L_6, (int32_t)1));
	}

IL_001d:
	{
		// for(int i = 0; i < canvasTexts.Length; i++) canvasTexts[i].font = newFont;
		int32_t L_7 = V_1;
		TextU5BU5D_t16DD1967B137EC602803C77DBB246B05B3D0275F* L_8 = V_0;
		NullCheck(L_8);
		if ((((int32_t)L_7) < ((int32_t)((int32_t)((int32_t)(((RuntimeArray*)L_8)->max_length))))))
		{
			goto IL_000b;
		}
	}
	{
		// }
		return;
	}
}
// System.Void AllIn1VfxToolkit.Demo.Scripts.AllIn1ChangeAllChildTextFonts::.ctor()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void AllIn1ChangeAllChildTextFonts__ctor_m6B5B986A3611EE7714788DE48313BC61C958973F (AllIn1ChangeAllChildTextFonts_t11C8807E2A6936E92C06EFAD7E046BE279C4E433 * __this, const RuntimeMethod* method)
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
// System.Void AllIn1VfxToolkit.Demo.Scripts.AllIn1DemoProjectile::Initialize(UnityEngine.Transform,UnityEngine.Vector3,System.Single,UnityEngine.GameObject,System.Single)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void AllIn1DemoProjectile_Initialize_m29AD8CA03A3D10AC02561210397C78477FFF618D (AllIn1DemoProjectile_tA36F8B6BF3163732D0C981065AF301449C4AAE69 * __this, Transform_tA8193BB29D4D2C7EC04918F3ED1816345186C3F1 * ___hierarchyParent0, Vector3_t65B972D6A585A0A5B63153CF1177A90D3C90D65E  ___projectileDir1, float ___speed2, GameObject_tC000A2E1A7CF1E10FD7BA08863287C072207C319 * ___impactPrefab3, float ___impactScaleSize4, const RuntimeMethod* method)
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Component_GetComponent_TisRigidbody_t101F2E2F9F16E765A77429B2DE4527D2047A887A_m9DC24AA806B0B65E917751F7A3AFDB58861157CE_RuntimeMethod_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Object_tF2F3778131EFF286AF62B7B013A170F95A91571A_il2cpp_TypeInfo_var);
		s_Il2CppMethodInitialized = true;
	}
	{
		// currentHierarchyParent = hierarchyParent;
		Transform_tA8193BB29D4D2C7EC04918F3ED1816345186C3F1 * L_0 = ___hierarchyParent0;
		__this->set_currentHierarchyParent_6(L_0);
		// currentImpactPrefab = impactPrefab;
		GameObject_tC000A2E1A7CF1E10FD7BA08863287C072207C319 * L_1 = ___impactPrefab3;
		__this->set_currentImpactPrefab_5(L_1);
		// doImpactSpawn = currentImpactPrefab != null;
		GameObject_tC000A2E1A7CF1E10FD7BA08863287C072207C319 * L_2 = __this->get_currentImpactPrefab_5();
		IL2CPP_RUNTIME_CLASS_INIT(Object_tF2F3778131EFF286AF62B7B013A170F95A91571A_il2cpp_TypeInfo_var);
		bool L_3;
		L_3 = Object_op_Inequality_mE1F187520BD83FB7D86A6D850710C4D42B864E90(L_2, (Object_tF2F3778131EFF286AF62B7B013A170F95A91571A *)NULL, /*hidden argument*/NULL);
		__this->set_doImpactSpawn_7(L_3);
		// this.impactScaleSize = impactScaleSize;
		float L_4 = ___impactScaleSize4;
		__this->set_impactScaleSize_10(L_4);
		// ApplyPrecisionOffsetToProjectileDir(ref projectileDir);
		AllIn1DemoProjectile_ApplyPrecisionOffsetToProjectileDir_mE59DA1BEDF26DDC6211A3B705215FD804E1C6E50(__this, (Vector3_t65B972D6A585A0A5B63153CF1177A90D3C90D65E *)(&___projectileDir1), /*hidden argument*/NULL);
		// GetComponent<Rigidbody>().velocity = projectileDir * speed;
		Rigidbody_t101F2E2F9F16E765A77429B2DE4527D2047A887A * L_5;
		L_5 = Component_GetComponent_TisRigidbody_t101F2E2F9F16E765A77429B2DE4527D2047A887A_m9DC24AA806B0B65E917751F7A3AFDB58861157CE(__this, /*hidden argument*/Component_GetComponent_TisRigidbody_t101F2E2F9F16E765A77429B2DE4527D2047A887A_m9DC24AA806B0B65E917751F7A3AFDB58861157CE_RuntimeMethod_var);
		Vector3_t65B972D6A585A0A5B63153CF1177A90D3C90D65E  L_6 = ___projectileDir1;
		float L_7 = ___speed2;
		Vector3_t65B972D6A585A0A5B63153CF1177A90D3C90D65E  L_8;
		L_8 = Vector3_op_Multiply_m9EA3D18290418D7B410C7D11C4788C13BFD2C30A_inline(L_6, L_7, /*hidden argument*/NULL);
		NullCheck(L_5);
		Rigidbody_set_velocity_m8DC0988916EB38DFD7D4584830B41D79140BF18D(L_5, L_8, /*hidden argument*/NULL);
		// }
		return;
	}
}
// System.Void AllIn1VfxToolkit.Demo.Scripts.AllIn1DemoProjectile::AddScreenShakeOnImpact(System.Single)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void AllIn1DemoProjectile_AddScreenShakeOnImpact_mA99E3BAE9DB9CDD1AE8B57B87816713C30A39A00 (AllIn1DemoProjectile_tA36F8B6BF3163732D0C981065AF301449C4AAE69 * __this, float ___projectileImpactShakeAmount0, const RuntimeMethod* method)
{
	{
		// doShake = true;
		__this->set_doShake_8((bool)1);
		// shakeAmountOnImpact = projectileImpactShakeAmount;
		float L_0 = ___projectileImpactShakeAmount0;
		__this->set_shakeAmountOnImpact_9(L_0);
		// }
		return;
	}
}
// System.Void AllIn1VfxToolkit.Demo.Scripts.AllIn1DemoProjectile::ApplyPrecisionOffsetToProjectileDir(UnityEngine.Vector3&)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void AllIn1DemoProjectile_ApplyPrecisionOffsetToProjectileDir_mE59DA1BEDF26DDC6211A3B705215FD804E1C6E50 (AllIn1DemoProjectile_tA36F8B6BF3163732D0C981065AF301449C4AAE69 * __this, Vector3_t65B972D6A585A0A5B63153CF1177A90D3C90D65E * ___projectileDir0, const RuntimeMethod* method)
{
	{
		// projectileDir.x += Random.Range(-inaccurateAmount, inaccurateAmount);
		Vector3_t65B972D6A585A0A5B63153CF1177A90D3C90D65E * L_0 = ___projectileDir0;
		float* L_1 = L_0->get_address_of_x_2();
		float* L_2 = L_1;
		float L_3 = *((float*)L_2);
		float L_4 = __this->get_inaccurateAmount_4();
		float L_5 = __this->get_inaccurateAmount_4();
		float L_6;
		L_6 = Random_Range_mC15372D42A9ABDCAC3DE82E114D60A40C9C311D2(((-L_4)), L_5, /*hidden argument*/NULL);
		*((float*)L_2) = (float)((float)il2cpp_codegen_add((float)L_3, (float)L_6));
		// projectileDir.y += Random.Range(-inaccurateAmount, inaccurateAmount);
		Vector3_t65B972D6A585A0A5B63153CF1177A90D3C90D65E * L_7 = ___projectileDir0;
		float* L_8 = L_7->get_address_of_y_3();
		float* L_9 = L_8;
		float L_10 = *((float*)L_9);
		float L_11 = __this->get_inaccurateAmount_4();
		float L_12 = __this->get_inaccurateAmount_4();
		float L_13;
		L_13 = Random_Range_mC15372D42A9ABDCAC3DE82E114D60A40C9C311D2(((-L_11)), L_12, /*hidden argument*/NULL);
		*((float*)L_9) = (float)((float)il2cpp_codegen_add((float)L_10, (float)L_13));
		// projectileDir.z += Random.Range(-inaccurateAmount, inaccurateAmount);
		Vector3_t65B972D6A585A0A5B63153CF1177A90D3C90D65E * L_14 = ___projectileDir0;
		float* L_15 = L_14->get_address_of_z_4();
		float* L_16 = L_15;
		float L_17 = *((float*)L_16);
		float L_18 = __this->get_inaccurateAmount_4();
		float L_19 = __this->get_inaccurateAmount_4();
		float L_20;
		L_20 = Random_Range_mC15372D42A9ABDCAC3DE82E114D60A40C9C311D2(((-L_18)), L_19, /*hidden argument*/NULL);
		*((float*)L_16) = (float)((float)il2cpp_codegen_add((float)L_17, (float)L_20));
		// }
		return;
	}
}
// System.Void AllIn1VfxToolkit.Demo.Scripts.AllIn1DemoProjectile::OnTriggerEnter(UnityEngine.Collider)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void AllIn1DemoProjectile_OnTriggerEnter_m93EF993276EA6DDCE73AAD9EA1824811C88368DA (AllIn1DemoProjectile_tA36F8B6BF3163732D0C981065AF301449C4AAE69 * __this, Collider_t5E81E43C2ECA0209A7C4528E84A632712D192B02 * ___other0, const RuntimeMethod* method)
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&AllIn1Shaker_t4540E312EAE72C5A4E5F184AFEC3099E91179295_il2cpp_TypeInfo_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Object_Instantiate_TisGameObject_tC000A2E1A7CF1E10FD7BA08863287C072207C319_m81B599A0051F8F4543E5C73A11585E96E940943B_RuntimeMethod_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Object_tF2F3778131EFF286AF62B7B013A170F95A91571A_il2cpp_TypeInfo_var);
		s_Il2CppMethodInitialized = true;
	}
	{
		// if(doImpactSpawn)
		bool L_0 = __this->get_doImpactSpawn_7();
		if (!L_0)
		{
			goto IL_004a;
		}
	}
	{
		// Transform t = Instantiate(currentImpactPrefab, transform.position, Quaternion.identity).transform;
		GameObject_tC000A2E1A7CF1E10FD7BA08863287C072207C319 * L_1 = __this->get_currentImpactPrefab_5();
		Transform_tA8193BB29D4D2C7EC04918F3ED1816345186C3F1 * L_2;
		L_2 = Component_get_transform_mE8496EBC45BEB1BADB5F314960F1DF1C952FA11F(__this, /*hidden argument*/NULL);
		NullCheck(L_2);
		Vector3_t65B972D6A585A0A5B63153CF1177A90D3C90D65E  L_3;
		L_3 = Transform_get_position_m40A8A9895568D56FFC687B57F30E8D53CB5EA341(L_2, /*hidden argument*/NULL);
		Quaternion_t6D28618CF65156D4A0AD747370DDFD0C514A31B4  L_4;
		L_4 = Quaternion_get_identity_mF2E565DBCE793A1AE6208056D42CA7C59D83A702(/*hidden argument*/NULL);
		IL2CPP_RUNTIME_CLASS_INIT(Object_tF2F3778131EFF286AF62B7B013A170F95A91571A_il2cpp_TypeInfo_var);
		GameObject_tC000A2E1A7CF1E10FD7BA08863287C072207C319 * L_5;
		L_5 = Object_Instantiate_TisGameObject_tC000A2E1A7CF1E10FD7BA08863287C072207C319_m81B599A0051F8F4543E5C73A11585E96E940943B(L_1, L_3, L_4, /*hidden argument*/Object_Instantiate_TisGameObject_tC000A2E1A7CF1E10FD7BA08863287C072207C319_m81B599A0051F8F4543E5C73A11585E96E940943B_RuntimeMethod_var);
		NullCheck(L_5);
		Transform_tA8193BB29D4D2C7EC04918F3ED1816345186C3F1 * L_6;
		L_6 = GameObject_get_transform_m16A80BB92B6C8C5AB696E447014D45EDF1E4DE34(L_5, /*hidden argument*/NULL);
		// t.parent = currentHierarchyParent;
		Transform_tA8193BB29D4D2C7EC04918F3ED1816345186C3F1 * L_7 = L_6;
		Transform_tA8193BB29D4D2C7EC04918F3ED1816345186C3F1 * L_8 = __this->get_currentHierarchyParent_6();
		NullCheck(L_7);
		Transform_set_parent_mEAE304E1A804E8B83054CEECB5BF1E517196EC13(L_7, L_8, /*hidden argument*/NULL);
		// t.localScale *= impactScaleSize;
		Transform_tA8193BB29D4D2C7EC04918F3ED1816345186C3F1 * L_9 = L_7;
		NullCheck(L_9);
		Vector3_t65B972D6A585A0A5B63153CF1177A90D3C90D65E  L_10;
		L_10 = Transform_get_localScale_mD9DF6CA81108C2A6002B5EA2BE25A6CD2723D046(L_9, /*hidden argument*/NULL);
		float L_11 = __this->get_impactScaleSize_10();
		Vector3_t65B972D6A585A0A5B63153CF1177A90D3C90D65E  L_12;
		L_12 = Vector3_op_Multiply_m9EA3D18290418D7B410C7D11C4788C13BFD2C30A_inline(L_10, L_11, /*hidden argument*/NULL);
		NullCheck(L_9);
		Transform_set_localScale_mF4D1611E48D1BA7566A1E166DC2DACF3ADD8BA3A(L_9, L_12, /*hidden argument*/NULL);
	}

IL_004a:
	{
		// if(doShake) AllIn1Shaker.i.DoCameraShake(shakeAmountOnImpact);
		bool L_13 = __this->get_doShake_8();
		if (!L_13)
		{
			goto IL_0062;
		}
	}
	{
		// if(doShake) AllIn1Shaker.i.DoCameraShake(shakeAmountOnImpact);
		AllIn1Shaker_t4540E312EAE72C5A4E5F184AFEC3099E91179295 * L_14 = ((AllIn1Shaker_t4540E312EAE72C5A4E5F184AFEC3099E91179295_StaticFields*)il2cpp_codegen_static_fields_for(AllIn1Shaker_t4540E312EAE72C5A4E5F184AFEC3099E91179295_il2cpp_TypeInfo_var))->get_i_9();
		float L_15 = __this->get_shakeAmountOnImpact_9();
		NullCheck(L_14);
		AllIn1Shaker_DoCameraShake_m9B27491C1A4577C33D283B3CDD03BDCFC87E0AA2_inline(L_14, L_15, /*hidden argument*/NULL);
	}

IL_0062:
	{
		// Destroy(gameObject);
		GameObject_tC000A2E1A7CF1E10FD7BA08863287C072207C319 * L_16;
		L_16 = Component_get_gameObject_m55DC35B149AFB9157582755383BA954655FE0C5B(__this, /*hidden argument*/NULL);
		IL2CPP_RUNTIME_CLASS_INIT(Object_tF2F3778131EFF286AF62B7B013A170F95A91571A_il2cpp_TypeInfo_var);
		Object_Destroy_m3EEDB6ECD49A541EC826EA8E1C8B599F7AF67D30(L_16, /*hidden argument*/NULL);
		// }
		return;
	}
}
// System.Void AllIn1VfxToolkit.Demo.Scripts.AllIn1DemoProjectile::.ctor()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void AllIn1DemoProjectile__ctor_mA8326E745A078FCBD8E4CF19579B56928AD443EF (AllIn1DemoProjectile_tA36F8B6BF3163732D0C981065AF301449C4AAE69 * __this, const RuntimeMethod* method)
{
	{
		// [SerializeField] private float inaccurateAmount = 0.05f;
		__this->set_inaccurateAmount_4((0.0500000007f));
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
// System.Void AllIn1VfxToolkit.Demo.Scripts.AllIn1DemoScaleTween::Update()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void AllIn1DemoScaleTween_Update_m379EACC044E5A8D400C62DBE8E109063A16B02D2 (AllIn1DemoScaleTween_t513A5592D7B99AAE00D3C297524793A01504CCD0 * __this, const RuntimeMethod* method)
{
	{
		// if(!isTweening) return;
		bool L_0 = __this->get_isTweening_7();
		if (L_0)
		{
			goto IL_0009;
		}
	}
	{
		// if(!isTweening) return;
		return;
	}

IL_0009:
	{
		// currentScale = Mathf.Lerp(currentScale, 1f, Time.unscaledDeltaTime * tweenSpeed);
		float L_1 = __this->get_currentScale_8();
		float L_2;
		L_2 = Time_get_unscaledDeltaTime_m2C153F1E5C77C6AF655054BC6C76D0C334C0DC84(/*hidden argument*/NULL);
		float L_3 = __this->get_tweenSpeed_6();
		float L_4;
		L_4 = Mathf_Lerp_m8A2A50B945F42D579EDF44D5EE79E85A4DA59616(L_1, (1.0f), ((float)il2cpp_codegen_multiply((float)L_2, (float)L_3)), /*hidden argument*/NULL);
		__this->set_currentScale_8(L_4);
		// UpdateScaleToApply();
		AllIn1DemoScaleTween_UpdateScaleToApply_m688865C2BB9A65CF7688CEB3B9503A63D6EB3B39(__this, /*hidden argument*/NULL);
		// ApplyScale();
		AllIn1DemoScaleTween_ApplyScale_m6EFE20A94BEFC57A22B9C461CE2D1C1B5DEFBBA0(__this, /*hidden argument*/NULL);
		// if(Mathf.Abs(currentScale - 1f) < 0.02f) isTweening = false;
		float L_5 = __this->get_currentScale_8();
		float L_6;
		L_6 = fabsf(((float)il2cpp_codegen_subtract((float)L_5, (float)(1.0f))));
		if ((!(((float)L_6) < ((float)(0.0199999996f)))))
		{
			goto IL_0056;
		}
	}
	{
		// if(Mathf.Abs(currentScale - 1f) < 0.02f) isTweening = false;
		__this->set_isTweening_7((bool)0);
	}

IL_0056:
	{
		// }
		return;
	}
}
// System.Void AllIn1VfxToolkit.Demo.Scripts.AllIn1DemoScaleTween::UpdateScaleToApply()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void AllIn1DemoScaleTween_UpdateScaleToApply_m688865C2BB9A65CF7688CEB3B9503A63D6EB3B39 (AllIn1DemoScaleTween_t513A5592D7B99AAE00D3C297524793A01504CCD0 * __this, const RuntimeMethod* method)
{
	{
		// scaleToApply.x = currentScale;
		Vector3_t65B972D6A585A0A5B63153CF1177A90D3C90D65E * L_0 = __this->get_address_of_scaleToApply_9();
		float L_1 = __this->get_currentScale_8();
		L_0->set_x_2(L_1);
		// scaleToApply.y = currentScale;
		Vector3_t65B972D6A585A0A5B63153CF1177A90D3C90D65E * L_2 = __this->get_address_of_scaleToApply_9();
		float L_3 = __this->get_currentScale_8();
		L_2->set_y_3(L_3);
		// }
		return;
	}
}
// System.Void AllIn1VfxToolkit.Demo.Scripts.AllIn1DemoScaleTween::ApplyScale()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void AllIn1DemoScaleTween_ApplyScale_m6EFE20A94BEFC57A22B9C461CE2D1C1B5DEFBBA0 (AllIn1DemoScaleTween_t513A5592D7B99AAE00D3C297524793A01504CCD0 * __this, const RuntimeMethod* method)
{
	{
		// transform.localScale = scaleToApply;
		Transform_tA8193BB29D4D2C7EC04918F3ED1816345186C3F1 * L_0;
		L_0 = Component_get_transform_mE8496EBC45BEB1BADB5F314960F1DF1C952FA11F(__this, /*hidden argument*/NULL);
		Vector3_t65B972D6A585A0A5B63153CF1177A90D3C90D65E  L_1 = __this->get_scaleToApply_9();
		NullCheck(L_0);
		Transform_set_localScale_mF4D1611E48D1BA7566A1E166DC2DACF3ADD8BA3A(L_0, L_1, /*hidden argument*/NULL);
		// }
		return;
	}
}
// System.Void AllIn1VfxToolkit.Demo.Scripts.AllIn1DemoScaleTween::ScaleUpTween()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void AllIn1DemoScaleTween_ScaleUpTween_m003B3BF936F501523FB03E83AA493B449CDF2D3F (AllIn1DemoScaleTween_t513A5592D7B99AAE00D3C297524793A01504CCD0 * __this, const RuntimeMethod* method)
{
	{
		// isTweening = true;
		__this->set_isTweening_7((bool)1);
		// currentScale = maxTweenScale;
		float L_0 = __this->get_maxTweenScale_4();
		__this->set_currentScale_8(L_0);
		// UpdateScaleToApply();
		AllIn1DemoScaleTween_UpdateScaleToApply_m688865C2BB9A65CF7688CEB3B9503A63D6EB3B39(__this, /*hidden argument*/NULL);
		// }
		return;
	}
}
// System.Void AllIn1VfxToolkit.Demo.Scripts.AllIn1DemoScaleTween::ScaleDownTween()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void AllIn1DemoScaleTween_ScaleDownTween_m7D782A48F0D5A8096F6ABED9BE22B118A3DD0B4B (AllIn1DemoScaleTween_t513A5592D7B99AAE00D3C297524793A01504CCD0 * __this, const RuntimeMethod* method)
{
	{
		// isTweening = true;
		__this->set_isTweening_7((bool)1);
		// currentScale = minTweenScale;
		float L_0 = __this->get_minTweenScale_5();
		__this->set_currentScale_8(L_0);
		// UpdateScaleToApply();
		AllIn1DemoScaleTween_UpdateScaleToApply_m688865C2BB9A65CF7688CEB3B9503A63D6EB3B39(__this, /*hidden argument*/NULL);
		// }
		return;
	}
}
// System.Void AllIn1VfxToolkit.Demo.Scripts.AllIn1DemoScaleTween::.ctor()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void AllIn1DemoScaleTween__ctor_m9A4B9CD4AADBB71448104CC75873FDE2DDA03F00 (AllIn1DemoScaleTween_t513A5592D7B99AAE00D3C297524793A01504CCD0 * __this, const RuntimeMethod* method)
{
	{
		// [SerializeField] private float maxTweenScale = 2.0f;
		__this->set_maxTweenScale_4((2.0f));
		// [SerializeField] private float minTweenScale = 0.8f;
		__this->set_minTweenScale_5((0.800000012f));
		// [SerializeField] private float tweenSpeed = 15f;
		__this->set_tweenSpeed_6((15.0f));
		// private float currentScale = 1f;
		__this->set_currentScale_8((1.0f));
		// private Vector3 scaleToApply = Vector3.one;
		Vector3_t65B972D6A585A0A5B63153CF1177A90D3C90D65E  L_0;
		L_0 = Vector3_get_one_m9CDE5C456038B133ED94402673859EC37B1C1CCB(/*hidden argument*/NULL);
		__this->set_scaleToApply_9(L_0);
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
// System.Void AllIn1VfxToolkit.Demo.Scripts.AllIn1DoShake::Start()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void AllIn1DoShake_Start_mD98BA672346BDA00F68675C58A6DA4D96A6E38AF (AllIn1DoShake_t4AC8F2F9DF4B14734088C6754E9692F1B74275B1 * __this, const RuntimeMethod* method)
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&_stringLiteralEDE8C4DF1715CFC71A5D1502BBF477C021B0A6BE);
		s_Il2CppMethodInitialized = true;
	}
	{
		// if(doShakeOnStart)
		bool L_0 = __this->get_doShakeOnStart_5();
		if (!L_0)
		{
			goto IL_002d;
		}
	}
	{
		// if(shakeOnStartDelay < Time.deltaTime) DoShake();
		float L_1 = __this->get_shakeOnStartDelay_6();
		float L_2;
		L_2 = Time_get_deltaTime_mCC15F147DA67F38C74CE408FB5D7FF4A87DA2290(/*hidden argument*/NULL);
		if ((!(((float)L_1) < ((float)L_2))))
		{
			goto IL_001c;
		}
	}
	{
		// if(shakeOnStartDelay < Time.deltaTime) DoShake();
		AllIn1DoShake_DoShake_m0D1D05BDBC47163E08804BD28C1C08B3BF7EAF2F(__this, /*hidden argument*/NULL);
		return;
	}

IL_001c:
	{
		// else Invoke(nameof(DoShake), shakeOnStartDelay);
		float L_3 = __this->get_shakeOnStartDelay_6();
		MonoBehaviour_Invoke_m4AAB759653B1C6FB0653527F4DDC72D1E9162CC4(__this, _stringLiteralEDE8C4DF1715CFC71A5D1502BBF477C021B0A6BE, L_3, /*hidden argument*/NULL);
	}

IL_002d:
	{
		// }
		return;
	}
}
// System.Void AllIn1VfxToolkit.Demo.Scripts.AllIn1DoShake::DoShake()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void AllIn1DoShake_DoShake_m0D1D05BDBC47163E08804BD28C1C08B3BF7EAF2F (AllIn1DoShake_t4AC8F2F9DF4B14734088C6754E9692F1B74275B1 * __this, const RuntimeMethod* method)
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&AllIn1Shaker_t4540E312EAE72C5A4E5F184AFEC3099E91179295_il2cpp_TypeInfo_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Debug_tEB68BCBEB8EFD60F8043C67146DC05E7F50F374B_il2cpp_TypeInfo_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Object_tF2F3778131EFF286AF62B7B013A170F95A91571A_il2cpp_TypeInfo_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&_stringLiteral8E09F6971F42D87127E76A675589BE96CC2160A7);
		s_Il2CppMethodInitialized = true;
	}
	{
		// if(AllIn1Shaker.i != null) AllIn1Shaker.i.DoCameraShake(shakeAmount);
		AllIn1Shaker_t4540E312EAE72C5A4E5F184AFEC3099E91179295 * L_0 = ((AllIn1Shaker_t4540E312EAE72C5A4E5F184AFEC3099E91179295_StaticFields*)il2cpp_codegen_static_fields_for(AllIn1Shaker_t4540E312EAE72C5A4E5F184AFEC3099E91179295_il2cpp_TypeInfo_var))->get_i_9();
		IL2CPP_RUNTIME_CLASS_INIT(Object_tF2F3778131EFF286AF62B7B013A170F95A91571A_il2cpp_TypeInfo_var);
		bool L_1;
		L_1 = Object_op_Inequality_mE1F187520BD83FB7D86A6D850710C4D42B864E90(L_0, (Object_tF2F3778131EFF286AF62B7B013A170F95A91571A *)NULL, /*hidden argument*/NULL);
		if (!L_1)
		{
			goto IL_001e;
		}
	}
	{
		// if(AllIn1Shaker.i != null) AllIn1Shaker.i.DoCameraShake(shakeAmount);
		AllIn1Shaker_t4540E312EAE72C5A4E5F184AFEC3099E91179295 * L_2 = ((AllIn1Shaker_t4540E312EAE72C5A4E5F184AFEC3099E91179295_StaticFields*)il2cpp_codegen_static_fields_for(AllIn1Shaker_t4540E312EAE72C5A4E5F184AFEC3099E91179295_il2cpp_TypeInfo_var))->get_i_9();
		float L_3 = __this->get_shakeAmount_4();
		NullCheck(L_2);
		AllIn1Shaker_DoCameraShake_m9B27491C1A4577C33D283B3CDD03BDCFC87E0AA2_inline(L_2, L_3, /*hidden argument*/NULL);
		return;
	}

IL_001e:
	{
		// else Debug.LogError($"No AllIn1Shaker found. Please add one to the scene");
		IL2CPP_RUNTIME_CLASS_INIT(Debug_tEB68BCBEB8EFD60F8043C67146DC05E7F50F374B_il2cpp_TypeInfo_var);
		Debug_LogError_m8850D65592770A364D494025FF3A73E8D4D70485(_stringLiteral8E09F6971F42D87127E76A675589BE96CC2160A7, /*hidden argument*/NULL);
		// }
		return;
	}
}
// System.Void AllIn1VfxToolkit.Demo.Scripts.AllIn1DoShake::.ctor()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void AllIn1DoShake__ctor_m38B1C515D37768D70ACEAD77726C93C0DFC4BB2D (AllIn1DoShake_t4AC8F2F9DF4B14734088C6754E9692F1B74275B1 * __this, const RuntimeMethod* method)
{
	{
		// [SerializeField] private float shakeAmount = 0.15f;
		__this->set_shakeAmount_4((0.150000006f));
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
// System.Void AllIn1VfxToolkit.Demo.Scripts.AllIn1MouseRotate::Start()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void AllIn1MouseRotate_Start_mB26EDA6AB5FCDFDCFD07FE88164E78454A8BD36D (AllIn1MouseRotate_t83F7508F651802AEF83D151F967CBEA41AEF7935 * __this, const RuntimeMethod* method)
{
	{
		// if(lockCursor) cursorIsLocked = false;
		bool L_0 = __this->get_lockCursor_8();
		if (!L_0)
		{
			goto IL_0011;
		}
	}
	{
		// if(lockCursor) cursorIsLocked = false;
		__this->set_cursorIsLocked_14((bool)0);
		goto IL_0018;
	}

IL_0011:
	{
		// else cursorIsLocked = true;
		__this->set_cursorIsLocked_14((bool)1);
	}

IL_0018:
	{
		// ToggleCursorLocked();
		AllIn1MouseRotate_ToggleCursorLocked_mEF8E417B9A724B07D679584F2EE05952639E5008(__this, /*hidden argument*/NULL);
		// }
		return;
	}
}
// System.Void AllIn1VfxToolkit.Demo.Scripts.AllIn1MouseRotate::Update()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void AllIn1MouseRotate_Update_mF445E3358C7D59A75BF7F7BA3684A57054C04039 (AllIn1MouseRotate_t83F7508F651802AEF83D151F967CBEA41AEF7935 * __this, const RuntimeMethod* method)
{
	{
		// if(Time.timeSinceLevelLoad < 0.5f) return; //We wait a few moments to allow scene to fully load up
		float L_0;
		L_0 = Time_get_timeSinceLevelLoad_m47A90DE6CB3A3180D64F0049290BC72C186FC7FB(/*hidden argument*/NULL);
		if ((!(((float)L_0) < ((float)(0.5f)))))
		{
			goto IL_000d;
		}
	}
	{
		// if(Time.timeSinceLevelLoad < 0.5f) return; //We wait a few moments to allow scene to fully load up
		return;
	}

IL_000d:
	{
		// dt = Time.unscaledDeltaTime;
		float L_1;
		L_1 = Time_get_unscaledDeltaTime_m2C153F1E5C77C6AF655054BC6C76D0C334C0DC84(/*hidden argument*/NULL);
		__this->set_dt_19(L_1);
		// CamRotateAroundYAxis();
		AllIn1MouseRotate_CamRotateAroundYAxis_mA30E0E6AD63C90C496F0D7ED653BC445F516EFF6(__this, /*hidden argument*/NULL);
		// currPosition = objectToRotate.position;
		Transform_tA8193BB29D4D2C7EC04918F3ED1816345186C3F1 * L_2 = __this->get_objectToRotate_4();
		NullCheck(L_2);
		Vector3_t65B972D6A585A0A5B63153CF1177A90D3C90D65E  L_3;
		L_3 = Transform_get_position_m40A8A9895568D56FFC687B57F30E8D53CB5EA341(L_2, /*hidden argument*/NULL);
		__this->set_currPosition_18(L_3);
		// CamHeightTranslate();
		AllIn1MouseRotate_CamHeightTranslate_m35076E6F1672942612AF42A7809C419CD178EB83(__this, /*hidden argument*/NULL);
		// CamZoom();
		AllIn1MouseRotate_CamZoom_mD897B81122550EFDDBE6DBD8B459F471C0448FE3(__this, /*hidden argument*/NULL);
		// if(Input.GetKeyDown(lockCursorKeyCode)) ToggleCursorLocked();
		int32_t L_4 = __this->get_lockCursorKeyCode_9();
		bool L_5;
		L_5 = Input_GetKeyDown_m476116696E71771641BBECBAB1A4C55E69018220(L_4, /*hidden argument*/NULL);
		if (!L_5)
		{
			goto IL_004e;
		}
	}
	{
		// if(Input.GetKeyDown(lockCursorKeyCode)) ToggleCursorLocked();
		AllIn1MouseRotate_ToggleCursorLocked_mEF8E417B9A724B07D679584F2EE05952639E5008(__this, /*hidden argument*/NULL);
	}

IL_004e:
	{
		// }
		return;
	}
}
// System.Void AllIn1VfxToolkit.Demo.Scripts.AllIn1MouseRotate::CamRotateAroundYAxis()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void AllIn1MouseRotate_CamRotateAroundYAxis_mA30E0E6AD63C90C496F0D7ED653BC445F516EFF6 (AllIn1MouseRotate_t83F7508F651802AEF83D151F967CBEA41AEF7935 * __this, const RuntimeMethod* method)
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&_stringLiteral88BEE283254D7094E258B3A88730F4CC4F1E4AC7);
		s_Il2CppMethodInitialized = true;
	}
	float V_0 = 0.0f;
	{
		// float mouseInputX = Input.GetAxis("Mouse X") * dt * 10f * rotationSpeedHorizontal;
		float L_0;
		L_0 = Input_GetAxis_m939297DEB2ECF8D8D09AD66EB69979AAD2B62326(_stringLiteral88BEE283254D7094E258B3A88730F4CC4F1E4AC7, /*hidden argument*/NULL);
		float L_1 = __this->get_dt_19();
		float L_2 = __this->get_rotationSpeedHorizontal_5();
		V_0 = ((float)il2cpp_codegen_multiply((float)((float)il2cpp_codegen_multiply((float)((float)il2cpp_codegen_multiply((float)L_0, (float)L_1)), (float)(10.0f))), (float)L_2));
		// objectToRotate.RotateAround(transform.position, Vector3.up, mouseInputX);
		Transform_tA8193BB29D4D2C7EC04918F3ED1816345186C3F1 * L_3 = __this->get_objectToRotate_4();
		Transform_tA8193BB29D4D2C7EC04918F3ED1816345186C3F1 * L_4;
		L_4 = Component_get_transform_mE8496EBC45BEB1BADB5F314960F1DF1C952FA11F(__this, /*hidden argument*/NULL);
		NullCheck(L_4);
		Vector3_t65B972D6A585A0A5B63153CF1177A90D3C90D65E  L_5;
		L_5 = Transform_get_position_m40A8A9895568D56FFC687B57F30E8D53CB5EA341(L_4, /*hidden argument*/NULL);
		Vector3_t65B972D6A585A0A5B63153CF1177A90D3C90D65E  L_6;
		L_6 = Vector3_get_up_m38AECA68388D446CFADDD022B0B867293044EA50(/*hidden argument*/NULL);
		float L_7 = V_0;
		NullCheck(L_3);
		Transform_RotateAround_m1F93A7A1807BE407BD23EC1BA49F03AD22FCE4BE(L_3, L_5, L_6, L_7, /*hidden argument*/NULL);
		// }
		return;
	}
}
// System.Void AllIn1VfxToolkit.Demo.Scripts.AllIn1MouseRotate::CamHeightTranslate()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void AllIn1MouseRotate_CamHeightTranslate_m35076E6F1672942612AF42A7809C419CD178EB83 (AllIn1MouseRotate_t83F7508F651802AEF83D151F967CBEA41AEF7935 * __this, const RuntimeMethod* method)
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&_stringLiteral16DD21BE77B115D392226EB71A2D3A9FDC29E3F0);
		s_Il2CppMethodInitialized = true;
	}
	float V_0 = 0.0f;
	{
		// float mouseInputY = Input.GetAxis("Mouse Y") * dt * translateVerticalSpeed;
		float L_0;
		L_0 = Input_GetAxis_m939297DEB2ECF8D8D09AD66EB69979AAD2B62326(_stringLiteral16DD21BE77B115D392226EB71A2D3A9FDC29E3F0, /*hidden argument*/NULL);
		float L_1 = __this->get_dt_19();
		float L_2 = __this->get_translateVerticalSpeed_6();
		V_0 = ((float)il2cpp_codegen_multiply((float)((float)il2cpp_codegen_multiply((float)L_0, (float)L_1)), (float)L_2));
		// currPosition.y = Mathf.Clamp(currPosition.y + mouseInputY, 0.25f, maxHeight);
		Vector3_t65B972D6A585A0A5B63153CF1177A90D3C90D65E * L_3 = __this->get_address_of_currPosition_18();
		Vector3_t65B972D6A585A0A5B63153CF1177A90D3C90D65E * L_4 = __this->get_address_of_currPosition_18();
		float L_5 = L_4->get_y_3();
		float L_6 = V_0;
		float L_7 = __this->get_maxHeight_15();
		float L_8;
		L_8 = Mathf_Clamp_m2416F3B785C8F135863E3D17E5B0CB4174797B87(((float)il2cpp_codegen_add((float)L_5, (float)L_6)), (0.25f), L_7, /*hidden argument*/NULL);
		L_3->set_y_3(L_8);
		// objectToRotate.position = currPosition;
		Transform_tA8193BB29D4D2C7EC04918F3ED1816345186C3F1 * L_9 = __this->get_objectToRotate_4();
		Vector3_t65B972D6A585A0A5B63153CF1177A90D3C90D65E  L_10 = __this->get_currPosition_18();
		NullCheck(L_9);
		Transform_set_position_mB169E52D57EEAC1E3F22C5395968714E4F00AC91(L_9, L_10, /*hidden argument*/NULL);
		// objectToRotate.LookAt(transform);
		Transform_tA8193BB29D4D2C7EC04918F3ED1816345186C3F1 * L_11 = __this->get_objectToRotate_4();
		Transform_tA8193BB29D4D2C7EC04918F3ED1816345186C3F1 * L_12;
		L_12 = Component_get_transform_mE8496EBC45BEB1BADB5F314960F1DF1C952FA11F(__this, /*hidden argument*/NULL);
		NullCheck(L_11);
		Transform_LookAt_m49185D782014D16DA747C1296BEBAC3FB3CEDC1F(L_11, L_12, /*hidden argument*/NULL);
		// }
		return;
	}
}
// System.Void AllIn1VfxToolkit.Demo.Scripts.AllIn1MouseRotate::CamZoom()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void AllIn1MouseRotate_CamZoom_mD897B81122550EFDDBE6DBD8B459F471C0448FE3 (AllIn1MouseRotate_t83F7508F651802AEF83D151F967CBEA41AEF7935 * __this, const RuntimeMethod* method)
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&_stringLiteralFC6687DC37346CD2569888E29764F727FAF530E0);
		s_Il2CppMethodInitialized = true;
	}
	float V_0 = 0.0f;
	Vector3_t65B972D6A585A0A5B63153CF1177A90D3C90D65E  V_1;
	memset((&V_1), 0, sizeof(V_1));
	{
		// float mouseInputWheel = Input.GetAxis("Mouse ScrollWheel") * dt * 100f * translateScrollSpeed;
		float L_0;
		L_0 = Input_GetAxis_m939297DEB2ECF8D8D09AD66EB69979AAD2B62326(_stringLiteralFC6687DC37346CD2569888E29764F727FAF530E0, /*hidden argument*/NULL);
		float L_1 = __this->get_dt_19();
		float L_2 = __this->get_translateScrollSpeed_7();
		V_0 = ((float)il2cpp_codegen_multiply((float)((float)il2cpp_codegen_multiply((float)((float)il2cpp_codegen_multiply((float)L_0, (float)L_1)), (float)(100.0f))), (float)L_2));
		// Vector3 currZoomVector = objectToRotate.forward * mouseInputWheel;
		Transform_tA8193BB29D4D2C7EC04918F3ED1816345186C3F1 * L_3 = __this->get_objectToRotate_4();
		NullCheck(L_3);
		Vector3_t65B972D6A585A0A5B63153CF1177A90D3C90D65E  L_4;
		L_4 = Transform_get_forward_mD850B9ECF892009E3485408DC0D375165B7BF053(L_3, /*hidden argument*/NULL);
		float L_5 = V_0;
		Vector3_t65B972D6A585A0A5B63153CF1177A90D3C90D65E  L_6;
		L_6 = Vector3_op_Multiply_m9EA3D18290418D7B410C7D11C4788C13BFD2C30A_inline(L_4, L_5, /*hidden argument*/NULL);
		V_1 = L_6;
		// if(mouseInputWheel > 0 && Vector3.Distance(transform.position, objectToRotate.position) <= maxZoom) currZoomVector = Vector3.zero;
		float L_7 = V_0;
		if ((!(((float)L_7) > ((float)(0.0f)))))
		{
			goto IL_0064;
		}
	}
	{
		Transform_tA8193BB29D4D2C7EC04918F3ED1816345186C3F1 * L_8;
		L_8 = Component_get_transform_mE8496EBC45BEB1BADB5F314960F1DF1C952FA11F(__this, /*hidden argument*/NULL);
		NullCheck(L_8);
		Vector3_t65B972D6A585A0A5B63153CF1177A90D3C90D65E  L_9;
		L_9 = Transform_get_position_m40A8A9895568D56FFC687B57F30E8D53CB5EA341(L_8, /*hidden argument*/NULL);
		Transform_tA8193BB29D4D2C7EC04918F3ED1816345186C3F1 * L_10 = __this->get_objectToRotate_4();
		NullCheck(L_10);
		Vector3_t65B972D6A585A0A5B63153CF1177A90D3C90D65E  L_11;
		L_11 = Transform_get_position_m40A8A9895568D56FFC687B57F30E8D53CB5EA341(L_10, /*hidden argument*/NULL);
		float L_12;
		L_12 = Vector3_Distance_mB648A79E4A1BAAFBF7B029644638C0D715480677(L_9, L_11, /*hidden argument*/NULL);
		float L_13 = __this->get_maxZoom_16();
		if ((!(((float)L_12) <= ((float)L_13))))
		{
			goto IL_0064;
		}
	}
	{
		// if(mouseInputWheel > 0 && Vector3.Distance(transform.position, objectToRotate.position) <= maxZoom) currZoomVector = Vector3.zero;
		Vector3_t65B972D6A585A0A5B63153CF1177A90D3C90D65E  L_14;
		L_14 = Vector3_get_zero_m1A8F7993167785F750B6B01762D22C2597C84EF6(/*hidden argument*/NULL);
		V_1 = L_14;
		goto IL_0095;
	}

IL_0064:
	{
		// else if(mouseInputWheel < 0 && Vector3.Distance(transform.position, objectToRotate.position) >= minZoom) currZoomVector = Vector3.zero;
		float L_15 = V_0;
		if ((!(((float)L_15) < ((float)(0.0f)))))
		{
			goto IL_0095;
		}
	}
	{
		Transform_tA8193BB29D4D2C7EC04918F3ED1816345186C3F1 * L_16;
		L_16 = Component_get_transform_mE8496EBC45BEB1BADB5F314960F1DF1C952FA11F(__this, /*hidden argument*/NULL);
		NullCheck(L_16);
		Vector3_t65B972D6A585A0A5B63153CF1177A90D3C90D65E  L_17;
		L_17 = Transform_get_position_m40A8A9895568D56FFC687B57F30E8D53CB5EA341(L_16, /*hidden argument*/NULL);
		Transform_tA8193BB29D4D2C7EC04918F3ED1816345186C3F1 * L_18 = __this->get_objectToRotate_4();
		NullCheck(L_18);
		Vector3_t65B972D6A585A0A5B63153CF1177A90D3C90D65E  L_19;
		L_19 = Transform_get_position_m40A8A9895568D56FFC687B57F30E8D53CB5EA341(L_18, /*hidden argument*/NULL);
		float L_20;
		L_20 = Vector3_Distance_mB648A79E4A1BAAFBF7B029644638C0D715480677(L_17, L_19, /*hidden argument*/NULL);
		float L_21 = __this->get_minZoom_17();
		if ((!(((float)L_20) >= ((float)L_21))))
		{
			goto IL_0095;
		}
	}
	{
		// else if(mouseInputWheel < 0 && Vector3.Distance(transform.position, objectToRotate.position) >= minZoom) currZoomVector = Vector3.zero;
		Vector3_t65B972D6A585A0A5B63153CF1177A90D3C90D65E  L_22;
		L_22 = Vector3_get_zero_m1A8F7993167785F750B6B01762D22C2597C84EF6(/*hidden argument*/NULL);
		V_1 = L_22;
	}

IL_0095:
	{
		// currPosition += currZoomVector;
		Vector3_t65B972D6A585A0A5B63153CF1177A90D3C90D65E  L_23 = __this->get_currPosition_18();
		Vector3_t65B972D6A585A0A5B63153CF1177A90D3C90D65E  L_24 = V_1;
		Vector3_t65B972D6A585A0A5B63153CF1177A90D3C90D65E  L_25;
		L_25 = Vector3_op_Addition_mEE4F672B923CCB184C39AABCA33443DB218E50E0_inline(L_23, L_24, /*hidden argument*/NULL);
		__this->set_currPosition_18(L_25);
		// objectToRotate.position = currPosition;
		Transform_tA8193BB29D4D2C7EC04918F3ED1816345186C3F1 * L_26 = __this->get_objectToRotate_4();
		Vector3_t65B972D6A585A0A5B63153CF1177A90D3C90D65E  L_27 = __this->get_currPosition_18();
		NullCheck(L_26);
		Transform_set_position_mB169E52D57EEAC1E3F22C5395968714E4F00AC91(L_26, L_27, /*hidden argument*/NULL);
		// }
		return;
	}
}
// System.Void AllIn1VfxToolkit.Demo.Scripts.AllIn1MouseRotate::ToggleCursorLocked()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void AllIn1MouseRotate_ToggleCursorLocked_mEF8E417B9A724B07D679584F2EE05952639E5008 (AllIn1MouseRotate_t83F7508F651802AEF83D151F967CBEA41AEF7935 * __this, const RuntimeMethod* method)
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&_stringLiteral9DED1F98F6124037784F89A7135F9F6F303C3B60);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&_stringLiteralF12CEF824BF74FB0B0A862C961B9E80A0783D802);
		s_Il2CppMethodInitialized = true;
	}
	{
		// cursorIsLocked = !cursorIsLocked;
		bool L_0 = __this->get_cursorIsLocked_14();
		__this->set_cursorIsLocked_14((bool)((((int32_t)L_0) == ((int32_t)0))? 1 : 0));
		// hideUiButtonTween.ScaleUpTween();
		AllIn1DemoScaleTween_t513A5592D7B99AAE00D3C297524793A01504CCD0 * L_1 = __this->get_hideUiButtonTween_10();
		NullCheck(L_1);
		AllIn1DemoScaleTween_ScaleUpTween_m003B3BF936F501523FB03E83AA493B449CDF2D3F(L_1, /*hidden argument*/NULL);
		// if(cursorIsLocked)
		bool L_2 = __this->get_cursorIsLocked_14();
		if (!L_2)
		{
			goto IL_0050;
		}
	}
	{
		// Cursor.lockState = CursorLockMode.Locked;
		Cursor_set_lockState_mC0739186A04F4C278F02E8C1714D99B491E3A217(1, /*hidden argument*/NULL);
		// Cursor.visible = false;
		Cursor_set_visible_m4747F0DC20D06D1932EC740C5CCC738C1664903D((bool)0, /*hidden argument*/NULL);
		// lockedButtonImage.color = lockedButtonColor;
		Image_t4021FF27176E44BFEDDCBE43C7FE6B713EC70D3C * L_3 = __this->get_lockedButtonImage_11();
		Color_tF40DAF76C04FFECF3FE6024F85A294741C9CC659  L_4 = __this->get_lockedButtonColor_13();
		NullCheck(L_3);
		VirtActionInvoker1< Color_tF40DAF76C04FFECF3FE6024F85A294741C9CC659  >::Invoke(23 /* System.Void UnityEngine.UI.Graphic::set_color(UnityEngine.Color) */, L_3, L_4);
		// lockedButtonText.text = "Unlock Cursor";
		Text_t6A2339DA6C05AE2646FC1A6C8FCC127391BE7FA1 * L_5 = __this->get_lockedButtonText_12();
		NullCheck(L_5);
		VirtActionInvoker1< String_t* >::Invoke(75 /* System.Void UnityEngine.UI.Text::set_text(System.String) */, L_5, _stringLiteral9DED1F98F6124037784F89A7135F9F6F303C3B60);
		// }
		return;
	}

IL_0050:
	{
		// Cursor.lockState = CursorLockMode.None;
		Cursor_set_lockState_mC0739186A04F4C278F02E8C1714D99B491E3A217(0, /*hidden argument*/NULL);
		// Cursor.visible = true;
		Cursor_set_visible_m4747F0DC20D06D1932EC740C5CCC738C1664903D((bool)1, /*hidden argument*/NULL);
		// lockedButtonImage.color = Color.white;
		Image_t4021FF27176E44BFEDDCBE43C7FE6B713EC70D3C * L_6 = __this->get_lockedButtonImage_11();
		Color_tF40DAF76C04FFECF3FE6024F85A294741C9CC659  L_7;
		L_7 = Color_get_white_mB21E47D20959C3AEC41AF8BA04F63AC89FAF319E(/*hidden argument*/NULL);
		NullCheck(L_6);
		VirtActionInvoker1< Color_tF40DAF76C04FFECF3FE6024F85A294741C9CC659  >::Invoke(23 /* System.Void UnityEngine.UI.Graphic::set_color(UnityEngine.Color) */, L_6, L_7);
		// lockedButtonText.text = "Lock Cursor";
		Text_t6A2339DA6C05AE2646FC1A6C8FCC127391BE7FA1 * L_8 = __this->get_lockedButtonText_12();
		NullCheck(L_8);
		VirtActionInvoker1< String_t* >::Invoke(75 /* System.Void UnityEngine.UI.Text::set_text(System.String) */, L_8, _stringLiteralF12CEF824BF74FB0B0A862C961B9E80A0783D802);
		// }
		return;
	}
}
// System.Void AllIn1VfxToolkit.Demo.Scripts.AllIn1MouseRotate::.ctor()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void AllIn1MouseRotate__ctor_m4A4813E1C77101A2D08E08071C27F3D1CD84624F (AllIn1MouseRotate_t83F7508F651802AEF83D151F967CBEA41AEF7935 * __this, const RuntimeMethod* method)
{
	{
		// [SerializeField] private float rotationSpeedHorizontal = 10f;
		__this->set_rotationSpeedHorizontal_5((10.0f));
		// [SerializeField] private float translateVerticalSpeed = 5f;
		__this->set_translateVerticalSpeed_6((5.0f));
		// [SerializeField] private float translateScrollSpeed = 2f;
		__this->set_translateScrollSpeed_7((2.0f));
		// [SerializeField] private float maxHeight = 40f;
		__this->set_maxHeight_15((40.0f));
		// [SerializeField] private float maxZoom = 2f;
		__this->set_maxZoom_16((2.0f));
		// [SerializeField] private float minZoom = 40f;
		__this->set_minZoom_17((40.0f));
		// private Vector3 currPosition = Vector3.zero;
		Vector3_t65B972D6A585A0A5B63153CF1177A90D3C90D65E  L_0;
		L_0 = Vector3_get_zero_m1A8F7993167785F750B6B01762D22C2597C84EF6(/*hidden argument*/NULL);
		__this->set_currPosition_18(L_0);
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
// System.Void AllIn1VfxToolkit.Demo.Scripts.AllIn1Shaker::Awake()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void AllIn1Shaker_Awake_m010B263E82EF7E36DE0F45DDE44BFCE8285A819F (AllIn1Shaker_t4540E312EAE72C5A4E5F184AFEC3099E91179295 * __this, const RuntimeMethod* method)
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&AllIn1Shaker_t4540E312EAE72C5A4E5F184AFEC3099E91179295_il2cpp_TypeInfo_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Object_tF2F3778131EFF286AF62B7B013A170F95A91571A_il2cpp_TypeInfo_var);
		s_Il2CppMethodInitialized = true;
	}
	{
		// if (i != null && i != this) Destroy(gameObject);
		AllIn1Shaker_t4540E312EAE72C5A4E5F184AFEC3099E91179295 * L_0 = ((AllIn1Shaker_t4540E312EAE72C5A4E5F184AFEC3099E91179295_StaticFields*)il2cpp_codegen_static_fields_for(AllIn1Shaker_t4540E312EAE72C5A4E5F184AFEC3099E91179295_il2cpp_TypeInfo_var))->get_i_9();
		IL2CPP_RUNTIME_CLASS_INIT(Object_tF2F3778131EFF286AF62B7B013A170F95A91571A_il2cpp_TypeInfo_var);
		bool L_1;
		L_1 = Object_op_Inequality_mE1F187520BD83FB7D86A6D850710C4D42B864E90(L_0, (Object_tF2F3778131EFF286AF62B7B013A170F95A91571A *)NULL, /*hidden argument*/NULL);
		if (!L_1)
		{
			goto IL_0027;
		}
	}
	{
		AllIn1Shaker_t4540E312EAE72C5A4E5F184AFEC3099E91179295 * L_2 = ((AllIn1Shaker_t4540E312EAE72C5A4E5F184AFEC3099E91179295_StaticFields*)il2cpp_codegen_static_fields_for(AllIn1Shaker_t4540E312EAE72C5A4E5F184AFEC3099E91179295_il2cpp_TypeInfo_var))->get_i_9();
		IL2CPP_RUNTIME_CLASS_INIT(Object_tF2F3778131EFF286AF62B7B013A170F95A91571A_il2cpp_TypeInfo_var);
		bool L_3;
		L_3 = Object_op_Inequality_mE1F187520BD83FB7D86A6D850710C4D42B864E90(L_2, __this, /*hidden argument*/NULL);
		if (!L_3)
		{
			goto IL_0027;
		}
	}
	{
		// if (i != null && i != this) Destroy(gameObject);
		GameObject_tC000A2E1A7CF1E10FD7BA08863287C072207C319 * L_4;
		L_4 = Component_get_gameObject_m55DC35B149AFB9157582755383BA954655FE0C5B(__this, /*hidden argument*/NULL);
		IL2CPP_RUNTIME_CLASS_INIT(Object_tF2F3778131EFF286AF62B7B013A170F95A91571A_il2cpp_TypeInfo_var);
		Object_Destroy_m3EEDB6ECD49A541EC826EA8E1C8B599F7AF67D30(L_4, /*hidden argument*/NULL);
		goto IL_002d;
	}

IL_0027:
	{
		// else  i = this;
		((AllIn1Shaker_t4540E312EAE72C5A4E5F184AFEC3099E91179295_StaticFields*)il2cpp_codegen_static_fields_for(AllIn1Shaker_t4540E312EAE72C5A4E5F184AFEC3099E91179295_il2cpp_TypeInfo_var))->set_i_9(__this);
	}

IL_002d:
	{
		// seed = Random.value;
		float L_5;
		L_5 = Random_get_value_m9AEBC7DF0BB6C57C928B0798349A7D3C0B3FB872(/*hidden argument*/NULL);
		__this->set_seed_11(L_5);
		// }
		return;
	}
}
// System.Void AllIn1VfxToolkit.Demo.Scripts.AllIn1Shaker::Update()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void AllIn1Shaker_Update_mB6CEA62DB3F3A7A7C8725A67C45D39CB8A12E919 (AllIn1Shaker_t4540E312EAE72C5A4E5F184AFEC3099E91179295 * __this, const RuntimeMethod* method)
{
	float V_0 = 0.0f;
	{
		// float shake = SmoothShakeToApply();
		float L_0;
		L_0 = AllIn1Shaker_SmoothShakeToApply_m065EF3B4107227CC0A34BE5D6705AC8C9BEF1B51(__this, /*hidden argument*/NULL);
		V_0 = L_0;
		// ShakePosition(shake);
		float L_1 = V_0;
		AllIn1Shaker_ShakePosition_m6D224766E11F16B1E03AE695EAEE113F4189F9DA(__this, L_1, /*hidden argument*/NULL);
		// ShakeRotation(shake);
		float L_2 = V_0;
		AllIn1Shaker_ShakeRotation_m44044FF4F0B4F1436D52B1E6285C2D98A8815AE0(__this, L_2, /*hidden argument*/NULL);
		// currentShakeAmount = Mathf.Clamp01(currentShakeAmount - shakeRecoverPerSecond * Time.deltaTime);
		float L_3 = __this->get_currentShakeAmount_10();
		float L_4 = __this->get_shakeRecoverPerSecond_8();
		float L_5;
		L_5 = Time_get_deltaTime_mCC15F147DA67F38C74CE408FB5D7FF4A87DA2290(/*hidden argument*/NULL);
		float L_6;
		L_6 = Mathf_Clamp01_m2296D75F0F1292D5C8181C57007A1CA45F440C4C(((float)il2cpp_codegen_subtract((float)L_3, (float)((float)il2cpp_codegen_multiply((float)L_4, (float)L_5)))), /*hidden argument*/NULL);
		__this->set_currentShakeAmount_10(L_6);
		// }
		return;
	}
}
// System.Single AllIn1VfxToolkit.Demo.Scripts.AllIn1Shaker::SmoothShakeToApply()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR float AllIn1Shaker_SmoothShakeToApply_m065EF3B4107227CC0A34BE5D6705AC8C9BEF1B51 (AllIn1Shaker_t4540E312EAE72C5A4E5F184AFEC3099E91179295 * __this, const RuntimeMethod* method)
{
	{
		// float shake = Mathf.Pow(currentShakeAmount, shakeSmoothingExponent);
		float L_0 = __this->get_currentShakeAmount_10();
		float L_1 = __this->get_shakeSmoothingExponent_7();
		float L_2;
		L_2 = powf(L_0, L_1);
		// return shake;
		return L_2;
	}
}
// System.Void AllIn1VfxToolkit.Demo.Scripts.AllIn1Shaker::ShakeRotation(System.Single)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void AllIn1Shaker_ShakeRotation_m44044FF4F0B4F1436D52B1E6285C2D98A8815AE0 (AllIn1Shaker_t4540E312EAE72C5A4E5F184AFEC3099E91179295 * __this, float ___shake0, const RuntimeMethod* method)
{
	{
		// transform.localRotation = Quaternion.Euler(new Vector3(
		//     maximumAngularShake.x * (Mathf.PerlinNoise(seed + 3, Time.time * shakeFrequency) * 2 - 1),
		//     maximumAngularShake.y * (Mathf.PerlinNoise(seed + 4, Time.time * shakeFrequency) * 2 - 1),
		//     maximumAngularShake.z * (Mathf.PerlinNoise(seed + 5, Time.time * shakeFrequency) * 2 - 1)
		// ) * shake);
		Transform_tA8193BB29D4D2C7EC04918F3ED1816345186C3F1 * L_0;
		L_0 = Component_get_transform_mE8496EBC45BEB1BADB5F314960F1DF1C952FA11F(__this, /*hidden argument*/NULL);
		Vector3_t65B972D6A585A0A5B63153CF1177A90D3C90D65E * L_1 = __this->get_address_of_maximumAngularShake_5();
		float L_2 = L_1->get_x_2();
		float L_3 = __this->get_seed_11();
		float L_4;
		L_4 = Time_get_time_m1A186074B1FCD448AB13A4B9D715AB9ED0B40844(/*hidden argument*/NULL);
		float L_5 = __this->get_shakeFrequency_6();
		float L_6;
		L_6 = Mathf_PerlinNoise_mBCF172821FEB8FAD7E7CF7F7982018846E702519(((float)il2cpp_codegen_add((float)L_3, (float)(3.0f))), ((float)il2cpp_codegen_multiply((float)L_4, (float)L_5)), /*hidden argument*/NULL);
		Vector3_t65B972D6A585A0A5B63153CF1177A90D3C90D65E * L_7 = __this->get_address_of_maximumAngularShake_5();
		float L_8 = L_7->get_y_3();
		float L_9 = __this->get_seed_11();
		float L_10;
		L_10 = Time_get_time_m1A186074B1FCD448AB13A4B9D715AB9ED0B40844(/*hidden argument*/NULL);
		float L_11 = __this->get_shakeFrequency_6();
		float L_12;
		L_12 = Mathf_PerlinNoise_mBCF172821FEB8FAD7E7CF7F7982018846E702519(((float)il2cpp_codegen_add((float)L_9, (float)(4.0f))), ((float)il2cpp_codegen_multiply((float)L_10, (float)L_11)), /*hidden argument*/NULL);
		Vector3_t65B972D6A585A0A5B63153CF1177A90D3C90D65E * L_13 = __this->get_address_of_maximumAngularShake_5();
		float L_14 = L_13->get_z_4();
		float L_15 = __this->get_seed_11();
		float L_16;
		L_16 = Time_get_time_m1A186074B1FCD448AB13A4B9D715AB9ED0B40844(/*hidden argument*/NULL);
		float L_17 = __this->get_shakeFrequency_6();
		float L_18;
		L_18 = Mathf_PerlinNoise_mBCF172821FEB8FAD7E7CF7F7982018846E702519(((float)il2cpp_codegen_add((float)L_15, (float)(5.0f))), ((float)il2cpp_codegen_multiply((float)L_16, (float)L_17)), /*hidden argument*/NULL);
		Vector3_t65B972D6A585A0A5B63153CF1177A90D3C90D65E  L_19;
		memset((&L_19), 0, sizeof(L_19));
		Vector3__ctor_m57495F692C6CE1CEF278CAD9A98221165D37E636_inline((&L_19), ((float)il2cpp_codegen_multiply((float)L_2, (float)((float)il2cpp_codegen_subtract((float)((float)il2cpp_codegen_multiply((float)L_6, (float)(2.0f))), (float)(1.0f))))), ((float)il2cpp_codegen_multiply((float)L_8, (float)((float)il2cpp_codegen_subtract((float)((float)il2cpp_codegen_multiply((float)L_12, (float)(2.0f))), (float)(1.0f))))), ((float)il2cpp_codegen_multiply((float)L_14, (float)((float)il2cpp_codegen_subtract((float)((float)il2cpp_codegen_multiply((float)L_18, (float)(2.0f))), (float)(1.0f))))), /*hidden argument*/NULL);
		float L_20 = ___shake0;
		Vector3_t65B972D6A585A0A5B63153CF1177A90D3C90D65E  L_21;
		L_21 = Vector3_op_Multiply_m9EA3D18290418D7B410C7D11C4788C13BFD2C30A_inline(L_19, L_20, /*hidden argument*/NULL);
		Quaternion_t6D28618CF65156D4A0AD747370DDFD0C514A31B4  L_22;
		L_22 = Quaternion_Euler_m887ABE4F4DD563351E9874D63922C2F53969BBAB(L_21, /*hidden argument*/NULL);
		NullCheck(L_0);
		Transform_set_localRotation_m1A9101457EC4653AFC93FCC4065A29F2C78FA62C(L_0, L_22, /*hidden argument*/NULL);
		// }
		return;
	}
}
// System.Void AllIn1VfxToolkit.Demo.Scripts.AllIn1Shaker::ShakePosition(System.Single)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void AllIn1Shaker_ShakePosition_m6D224766E11F16B1E03AE695EAEE113F4189F9DA (AllIn1Shaker_t4540E312EAE72C5A4E5F184AFEC3099E91179295 * __this, float ___shake0, const RuntimeMethod* method)
{
	{
		// transform.localPosition = new Vector3(
		//     maximumTranslationShake.x * (Mathf.PerlinNoise(seed, Time.time * shakeFrequency) * 2 - 1),
		//     maximumTranslationShake.y * (Mathf.PerlinNoise(seed + 1, Time.time * shakeFrequency) * 2 - 1),
		//     maximumTranslationShake.z * (Mathf.PerlinNoise(seed + 2, Time.time * shakeFrequency) * 2 - 1)
		// ) * shake;
		Transform_tA8193BB29D4D2C7EC04918F3ED1816345186C3F1 * L_0;
		L_0 = Component_get_transform_mE8496EBC45BEB1BADB5F314960F1DF1C952FA11F(__this, /*hidden argument*/NULL);
		Vector3_t65B972D6A585A0A5B63153CF1177A90D3C90D65E * L_1 = __this->get_address_of_maximumTranslationShake_4();
		float L_2 = L_1->get_x_2();
		float L_3 = __this->get_seed_11();
		float L_4;
		L_4 = Time_get_time_m1A186074B1FCD448AB13A4B9D715AB9ED0B40844(/*hidden argument*/NULL);
		float L_5 = __this->get_shakeFrequency_6();
		float L_6;
		L_6 = Mathf_PerlinNoise_mBCF172821FEB8FAD7E7CF7F7982018846E702519(L_3, ((float)il2cpp_codegen_multiply((float)L_4, (float)L_5)), /*hidden argument*/NULL);
		Vector3_t65B972D6A585A0A5B63153CF1177A90D3C90D65E * L_7 = __this->get_address_of_maximumTranslationShake_4();
		float L_8 = L_7->get_y_3();
		float L_9 = __this->get_seed_11();
		float L_10;
		L_10 = Time_get_time_m1A186074B1FCD448AB13A4B9D715AB9ED0B40844(/*hidden argument*/NULL);
		float L_11 = __this->get_shakeFrequency_6();
		float L_12;
		L_12 = Mathf_PerlinNoise_mBCF172821FEB8FAD7E7CF7F7982018846E702519(((float)il2cpp_codegen_add((float)L_9, (float)(1.0f))), ((float)il2cpp_codegen_multiply((float)L_10, (float)L_11)), /*hidden argument*/NULL);
		Vector3_t65B972D6A585A0A5B63153CF1177A90D3C90D65E * L_13 = __this->get_address_of_maximumTranslationShake_4();
		float L_14 = L_13->get_z_4();
		float L_15 = __this->get_seed_11();
		float L_16;
		L_16 = Time_get_time_m1A186074B1FCD448AB13A4B9D715AB9ED0B40844(/*hidden argument*/NULL);
		float L_17 = __this->get_shakeFrequency_6();
		float L_18;
		L_18 = Mathf_PerlinNoise_mBCF172821FEB8FAD7E7CF7F7982018846E702519(((float)il2cpp_codegen_add((float)L_15, (float)(2.0f))), ((float)il2cpp_codegen_multiply((float)L_16, (float)L_17)), /*hidden argument*/NULL);
		Vector3_t65B972D6A585A0A5B63153CF1177A90D3C90D65E  L_19;
		memset((&L_19), 0, sizeof(L_19));
		Vector3__ctor_m57495F692C6CE1CEF278CAD9A98221165D37E636_inline((&L_19), ((float)il2cpp_codegen_multiply((float)L_2, (float)((float)il2cpp_codegen_subtract((float)((float)il2cpp_codegen_multiply((float)L_6, (float)(2.0f))), (float)(1.0f))))), ((float)il2cpp_codegen_multiply((float)L_8, (float)((float)il2cpp_codegen_subtract((float)((float)il2cpp_codegen_multiply((float)L_12, (float)(2.0f))), (float)(1.0f))))), ((float)il2cpp_codegen_multiply((float)L_14, (float)((float)il2cpp_codegen_subtract((float)((float)il2cpp_codegen_multiply((float)L_18, (float)(2.0f))), (float)(1.0f))))), /*hidden argument*/NULL);
		float L_20 = ___shake0;
		Vector3_t65B972D6A585A0A5B63153CF1177A90D3C90D65E  L_21;
		L_21 = Vector3_op_Multiply_m9EA3D18290418D7B410C7D11C4788C13BFD2C30A_inline(L_19, L_20, /*hidden argument*/NULL);
		NullCheck(L_0);
		Transform_set_localPosition_m2A2B0033EF079077FAE7C65196078EAF5D041AFC(L_0, L_21, /*hidden argument*/NULL);
		// }
		return;
	}
}
// System.Void AllIn1VfxToolkit.Demo.Scripts.AllIn1Shaker::DoCameraShake(System.Single)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void AllIn1Shaker_DoCameraShake_m9B27491C1A4577C33D283B3CDD03BDCFC87E0AA2 (AllIn1Shaker_t4540E312EAE72C5A4E5F184AFEC3099E91179295 * __this, float ___shakeAmount0, const RuntimeMethod* method)
{
	{
		// currentShakeAmount = shakeAmount;
		float L_0 = ___shakeAmount0;
		__this->set_currentShakeAmount_10(L_0);
		// }
		return;
	}
}
// System.Void AllIn1VfxToolkit.Demo.Scripts.AllIn1Shaker::.ctor()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void AllIn1Shaker__ctor_mE12D59D2A0A9F6DF40EEE8FA0E56F03B8E7339CA (AllIn1Shaker_t4540E312EAE72C5A4E5F184AFEC3099E91179295 * __this, const RuntimeMethod* method)
{
	{
		// [SerializeField] Vector3 maximumTranslationShake = Vector3.one;
		Vector3_t65B972D6A585A0A5B63153CF1177A90D3C90D65E  L_0;
		L_0 = Vector3_get_one_m9CDE5C456038B133ED94402673859EC37B1C1CCB(/*hidden argument*/NULL);
		__this->set_maximumTranslationShake_4(L_0);
		// [SerializeField] Vector3 maximumAngularShake = Vector3.one * 15;
		Vector3_t65B972D6A585A0A5B63153CF1177A90D3C90D65E  L_1;
		L_1 = Vector3_get_one_m9CDE5C456038B133ED94402673859EC37B1C1CCB(/*hidden argument*/NULL);
		Vector3_t65B972D6A585A0A5B63153CF1177A90D3C90D65E  L_2;
		L_2 = Vector3_op_Multiply_m9EA3D18290418D7B410C7D11C4788C13BFD2C30A_inline(L_1, (15.0f), /*hidden argument*/NULL);
		__this->set_maximumAngularShake_5(L_2);
		// [SerializeField] float shakeFrequency = 25;
		__this->set_shakeFrequency_6((25.0f));
		// [SerializeField] float shakeSmoothingExponent = 1;
		__this->set_shakeSmoothingExponent_7((1.0f));
		// [SerializeField] float shakeRecoverPerSecond = 1;
		__this->set_shakeRecoverPerSecond_8((1.0f));
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
// System.Void AllIn1VfxToolkit.Demo.Scripts.AllIn1TimeControl::Start()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void AllIn1TimeControl_Start_m75BD50BC4CCD93A138461DE867D7855C4BDC2BBC (AllIn1TimeControl_tD27F0B4D919AD681DB84DE2277471ABFF29C38DC * __this, const RuntimeMethod* method)
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&AllIn1TimeControl_U3CStartU3Eb__13_0_m41C786ED0E2119466A425777F89C052C183CBAAF_RuntimeMethod_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Component_GetComponentInChildren_TisText_t6A2339DA6C05AE2646FC1A6C8FCC127391BE7FA1_mFB5C182E24F496A866F116D3F75CBD8616A46AB3_RuntimeMethod_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Component_GetComponent_TisAllIn1DemoScaleTween_t513A5592D7B99AAE00D3C297524793A01504CCD0_m3EE927F72C328FCE7176EA4E296BFBD5B69CEF6C_RuntimeMethod_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Object_tF2F3778131EFF286AF62B7B013A170F95A91571A_il2cpp_TypeInfo_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&UnityAction_1__ctor_m8CACADCAC18230FB18DF7A6BEC3D9EAD93FEDC3B_RuntimeMethod_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&UnityAction_1_t50101DC7058B3235A520FF57E827D51694843FBB_il2cpp_TypeInfo_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&UnityEvent_1_AddListener_mA73838FBF3836695F5183B32B797E9499BA5E59C_RuntimeMethod_var);
		s_Il2CppMethodInitialized = true;
	}
	{
		// timeScaleSliderNotNull = timeScaleSlider != null;
		Slider_tBF39A11CC24CBD3F8BD728982ACAEAE43989B51A * L_0 = __this->get_timeScaleSlider_10();
		IL2CPP_RUNTIME_CLASS_INIT(Object_tF2F3778131EFF286AF62B7B013A170F95A91571A_il2cpp_TypeInfo_var);
		bool L_1;
		L_1 = Object_op_Inequality_mE1F187520BD83FB7D86A6D850710C4D42B864E90(L_0, (Object_tF2F3778131EFF286AF62B7B013A170F95A91571A *)NULL, /*hidden argument*/NULL);
		__this->set_timeScaleSliderNotNull_13(L_1);
		// pausedButtonTween = pausedButtonImage.GetComponent<AllIn1DemoScaleTween>();
		Image_t4021FF27176E44BFEDDCBE43C7FE6B713EC70D3C * L_2 = __this->get_pausedButtonImage_11();
		NullCheck(L_2);
		AllIn1DemoScaleTween_t513A5592D7B99AAE00D3C297524793A01504CCD0 * L_3;
		L_3 = Component_GetComponent_TisAllIn1DemoScaleTween_t513A5592D7B99AAE00D3C297524793A01504CCD0_m3EE927F72C328FCE7176EA4E296BFBD5B69CEF6C(L_2, /*hidden argument*/Component_GetComponent_TisAllIn1DemoScaleTween_t513A5592D7B99AAE00D3C297524793A01504CCD0_m3EE927F72C328FCE7176EA4E296BFBD5B69CEF6C_RuntimeMethod_var);
		__this->set_pausedButtonTween_15(L_3);
		// pausedButtonText = pausedButtonImage.GetComponentInChildren<Text>();
		Image_t4021FF27176E44BFEDDCBE43C7FE6B713EC70D3C * L_4 = __this->get_pausedButtonImage_11();
		NullCheck(L_4);
		Text_t6A2339DA6C05AE2646FC1A6C8FCC127391BE7FA1 * L_5;
		L_5 = Component_GetComponentInChildren_TisText_t6A2339DA6C05AE2646FC1A6C8FCC127391BE7FA1_mFB5C182E24F496A866F116D3F75CBD8616A46AB3(L_4, /*hidden argument*/Component_GetComponentInChildren_TisText_t6A2339DA6C05AE2646FC1A6C8FCC127391BE7FA1_mFB5C182E24F496A866F116D3F75CBD8616A46AB3_RuntimeMethod_var);
		__this->set_pausedButtonText_16(L_5);
		// UpdateTimeScaleUI();
		AllIn1TimeControl_UpdateTimeScaleUI_mB22071568FDC2263BFFB70F080D426D15F549ABA(__this, /*hidden argument*/NULL);
		// if(timeScaleSliderNotNull) timeScaleSlider.onValueChanged.AddListener(delegate { ChangeTimeScale(timeScaleSlider.value - Time.timeScale); });
		bool L_6 = __this->get_timeScaleSliderNotNull_13();
		if (!L_6)
		{
			goto IL_005e;
		}
	}
	{
		// if(timeScaleSliderNotNull) timeScaleSlider.onValueChanged.AddListener(delegate { ChangeTimeScale(timeScaleSlider.value - Time.timeScale); });
		Slider_tBF39A11CC24CBD3F8BD728982ACAEAE43989B51A * L_7 = __this->get_timeScaleSlider_10();
		NullCheck(L_7);
		SliderEvent_t312D89AE02E00DD965D68D6F7F813BDF455FD780 * L_8;
		L_8 = Slider_get_onValueChanged_m7F480C569A6D668952BE1436691850D13825E129_inline(L_7, /*hidden argument*/NULL);
		UnityAction_1_t50101DC7058B3235A520FF57E827D51694843FBB * L_9 = (UnityAction_1_t50101DC7058B3235A520FF57E827D51694843FBB *)il2cpp_codegen_object_new(UnityAction_1_t50101DC7058B3235A520FF57E827D51694843FBB_il2cpp_TypeInfo_var);
		UnityAction_1__ctor_m8CACADCAC18230FB18DF7A6BEC3D9EAD93FEDC3B(L_9, __this, (intptr_t)((intptr_t)AllIn1TimeControl_U3CStartU3Eb__13_0_m41C786ED0E2119466A425777F89C052C183CBAAF_RuntimeMethod_var), /*hidden argument*/UnityAction_1__ctor_m8CACADCAC18230FB18DF7A6BEC3D9EAD93FEDC3B_RuntimeMethod_var);
		NullCheck(L_8);
		UnityEvent_1_AddListener_mA73838FBF3836695F5183B32B797E9499BA5E59C(L_8, L_9, /*hidden argument*/UnityEvent_1_AddListener_mA73838FBF3836695F5183B32B797E9499BA5E59C_RuntimeMethod_var);
	}

IL_005e:
	{
		// }
		return;
	}
}
// System.Void AllIn1VfxToolkit.Demo.Scripts.AllIn1TimeControl::Update()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void AllIn1TimeControl_Update_m6ACDAC076FB12AD1165F2326A017A170C7810D5B (AllIn1TimeControl_tD27F0B4D919AD681DB84DE2277471ABFF29C38DC * __this, const RuntimeMethod* method)
{
	float V_0 = 0.0f;
	{
		// if(Input.GetKeyDown(increaseTimeScale) || Input.GetKeyDown(increaseTimeScaleAlt)) ChangeTimeScale(timeScaleInterval);
		int32_t L_0 = __this->get_increaseTimeScale_4();
		bool L_1;
		L_1 = Input_GetKeyDown_m476116696E71771641BBECBAB1A4C55E69018220(L_0, /*hidden argument*/NULL);
		if (L_1)
		{
			goto IL_001a;
		}
	}
	{
		int32_t L_2 = __this->get_increaseTimeScaleAlt_5();
		bool L_3;
		L_3 = Input_GetKeyDown_m476116696E71771641BBECBAB1A4C55E69018220(L_2, /*hidden argument*/NULL);
		if (!L_3)
		{
			goto IL_0026;
		}
	}

IL_001a:
	{
		// if(Input.GetKeyDown(increaseTimeScale) || Input.GetKeyDown(increaseTimeScaleAlt)) ChangeTimeScale(timeScaleInterval);
		float L_4 = __this->get_timeScaleInterval_9();
		AllIn1TimeControl_ChangeTimeScale_mE4FA5449A14375E70158BA48654537CA487D8BF1(__this, L_4, /*hidden argument*/NULL);
	}

IL_0026:
	{
		// if(Input.GetKeyDown(decreaseTimeScale) || Input.GetKeyDown(decreaseTimeScaleAlt)) ChangeTimeScale(-timeScaleInterval);
		int32_t L_5 = __this->get_decreaseTimeScale_6();
		bool L_6;
		L_6 = Input_GetKeyDown_m476116696E71771641BBECBAB1A4C55E69018220(L_5, /*hidden argument*/NULL);
		if (L_6)
		{
			goto IL_0040;
		}
	}
	{
		int32_t L_7 = __this->get_decreaseTimeScaleAlt_7();
		bool L_8;
		L_8 = Input_GetKeyDown_m476116696E71771641BBECBAB1A4C55E69018220(L_7, /*hidden argument*/NULL);
		if (!L_8)
		{
			goto IL_004d;
		}
	}

IL_0040:
	{
		// if(Input.GetKeyDown(decreaseTimeScale) || Input.GetKeyDown(decreaseTimeScaleAlt)) ChangeTimeScale(-timeScaleInterval);
		float L_9 = __this->get_timeScaleInterval_9();
		AllIn1TimeControl_ChangeTimeScale_mE4FA5449A14375E70158BA48654537CA487D8BF1(__this, ((-L_9)), /*hidden argument*/NULL);
	}

IL_004d:
	{
		// if(Input.GetKeyDown(pauseKey))
		int32_t L_10 = __this->get_pauseKey_8();
		bool L_11;
		L_11 = Input_GetKeyDown_m476116696E71771641BBECBAB1A4C55E69018220(L_10, /*hidden argument*/NULL);
		if (!L_11)
		{
			goto IL_0090;
		}
	}
	{
		// if(Time.timeScale < 0.01f) ChangeTimeScale(1f - Time.timeScale);
		float L_12;
		L_12 = Time_get_timeScale_m082A05928ED5917AA986FAA6106E79D8446A26F4(/*hidden argument*/NULL);
		if ((!(((float)L_12) < ((float)(0.00999999978f)))))
		{
			goto IL_0079;
		}
	}
	{
		// if(Time.timeScale < 0.01f) ChangeTimeScale(1f - Time.timeScale);
		float L_13;
		L_13 = Time_get_timeScale_m082A05928ED5917AA986FAA6106E79D8446A26F4(/*hidden argument*/NULL);
		AllIn1TimeControl_ChangeTimeScale_mE4FA5449A14375E70158BA48654537CA487D8BF1(__this, ((float)il2cpp_codegen_subtract((float)(1.0f), (float)L_13)), /*hidden argument*/NULL);
		goto IL_0085;
	}

IL_0079:
	{
		// else ChangeTimeScale(-Time.timeScale);
		float L_14;
		L_14 = Time_get_timeScale_m082A05928ED5917AA986FAA6106E79D8446A26F4(/*hidden argument*/NULL);
		AllIn1TimeControl_ChangeTimeScale_mE4FA5449A14375E70158BA48654537CA487D8BF1(__this, ((-L_14)), /*hidden argument*/NULL);
	}

IL_0085:
	{
		// pausedButtonTween.ScaleUpTween();
		AllIn1DemoScaleTween_t513A5592D7B99AAE00D3C297524793A01504CCD0 * L_15 = __this->get_pausedButtonTween_15();
		NullCheck(L_15);
		AllIn1DemoScaleTween_ScaleUpTween_m003B3BF936F501523FB03E83AA493B449CDF2D3F(L_15, /*hidden argument*/NULL);
	}

IL_0090:
	{
		// float timeScaleChangeInterval = 0.1f;
		V_0 = (0.100000001f);
		// if(!(Time.unscaledTime - lastChangeTime > timeScaleChangeInterval)) return;
		float L_16;
		L_16 = Time_get_unscaledTime_m85A3479E3D78D05FEDEEFEF36944AC5EF9B31258(/*hidden argument*/NULL);
		float L_17 = __this->get_lastChangeTime_14();
		float L_18 = V_0;
		if ((((float)((float)il2cpp_codegen_subtract((float)L_16, (float)L_17))) > ((float)L_18)))
		{
			goto IL_00a6;
		}
	}
	{
		// if(!(Time.unscaledTime - lastChangeTime > timeScaleChangeInterval)) return;
		return;
	}

IL_00a6:
	{
		// if(Input.GetKey(increaseTimeScale) || Input.GetKey(increaseTimeScaleAlt)) ChangeTimeScale(timeScaleInterval);
		int32_t L_19 = __this->get_increaseTimeScale_4();
		bool L_20;
		L_20 = Input_GetKey_mFDD450A4C61F2930928B12287FFBD1ACCB71E429(L_19, /*hidden argument*/NULL);
		if (L_20)
		{
			goto IL_00c0;
		}
	}
	{
		int32_t L_21 = __this->get_increaseTimeScaleAlt_5();
		bool L_22;
		L_22 = Input_GetKey_mFDD450A4C61F2930928B12287FFBD1ACCB71E429(L_21, /*hidden argument*/NULL);
		if (!L_22)
		{
			goto IL_00cc;
		}
	}

IL_00c0:
	{
		// if(Input.GetKey(increaseTimeScale) || Input.GetKey(increaseTimeScaleAlt)) ChangeTimeScale(timeScaleInterval);
		float L_23 = __this->get_timeScaleInterval_9();
		AllIn1TimeControl_ChangeTimeScale_mE4FA5449A14375E70158BA48654537CA487D8BF1(__this, L_23, /*hidden argument*/NULL);
	}

IL_00cc:
	{
		// if(Input.GetKey(decreaseTimeScale) || Input.GetKey(decreaseTimeScaleAlt)) ChangeTimeScale(-timeScaleInterval);
		int32_t L_24 = __this->get_decreaseTimeScale_6();
		bool L_25;
		L_25 = Input_GetKey_mFDD450A4C61F2930928B12287FFBD1ACCB71E429(L_24, /*hidden argument*/NULL);
		if (L_25)
		{
			goto IL_00e6;
		}
	}
	{
		int32_t L_26 = __this->get_decreaseTimeScaleAlt_7();
		bool L_27;
		L_27 = Input_GetKey_mFDD450A4C61F2930928B12287FFBD1ACCB71E429(L_26, /*hidden argument*/NULL);
		if (!L_27)
		{
			goto IL_00f3;
		}
	}

IL_00e6:
	{
		// if(Input.GetKey(decreaseTimeScale) || Input.GetKey(decreaseTimeScaleAlt)) ChangeTimeScale(-timeScaleInterval);
		float L_28 = __this->get_timeScaleInterval_9();
		AllIn1TimeControl_ChangeTimeScale_mE4FA5449A14375E70158BA48654537CA487D8BF1(__this, ((-L_28)), /*hidden argument*/NULL);
	}

IL_00f3:
	{
		// }
		return;
	}
}
// System.Void AllIn1VfxToolkit.Demo.Scripts.AllIn1TimeControl::ChangeTimeScale(System.Single)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void AllIn1TimeControl_ChangeTimeScale_mE4FA5449A14375E70158BA48654537CA487D8BF1 (AllIn1TimeControl_tD27F0B4D919AD681DB84DE2277471ABFF29C38DC * __this, float ___changeAmount0, const RuntimeMethod* method)
{
	{
		// Time.timeScale = Mathf.Clamp(Time.timeScale + changeAmount, 0.0f, 1f);
		float L_0;
		L_0 = Time_get_timeScale_m082A05928ED5917AA986FAA6106E79D8446A26F4(/*hidden argument*/NULL);
		float L_1 = ___changeAmount0;
		float L_2;
		L_2 = Mathf_Clamp_m2416F3B785C8F135863E3D17E5B0CB4174797B87(((float)il2cpp_codegen_add((float)L_0, (float)L_1)), (0.0f), (1.0f), /*hidden argument*/NULL);
		Time_set_timeScale_m1987DE9E74FC6C0126CE4F59A6293E3B85BD01EA(L_2, /*hidden argument*/NULL);
		// lastChangeTime = Time.unscaledTime;
		float L_3;
		L_3 = Time_get_unscaledTime_m85A3479E3D78D05FEDEEFEF36944AC5EF9B31258(/*hidden argument*/NULL);
		__this->set_lastChangeTime_14(L_3);
		// UpdateTimeScaleUI();
		AllIn1TimeControl_UpdateTimeScaleUI_mB22071568FDC2263BFFB70F080D426D15F549ABA(__this, /*hidden argument*/NULL);
		// }
		return;
	}
}
// System.Void AllIn1VfxToolkit.Demo.Scripts.AllIn1TimeControl::UpdateTimeScaleUI()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void AllIn1TimeControl_UpdateTimeScaleUI_mB22071568FDC2263BFFB70F080D426D15F549ABA (AllIn1TimeControl_tD27F0B4D919AD681DB84DE2277471ABFF29C38DC * __this, const RuntimeMethod* method)
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&_stringLiteral4780AF940655CB59AF49F6344DA95EC30E32AA8A);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&_stringLiteralAAAA401E86E41E6120BB9E96B9892141CF5A81F8);
		s_Il2CppMethodInitialized = true;
	}
	{
		// if(timeScaleSliderNotNull) timeScaleSlider.value = Time.timeScale;
		bool L_0 = __this->get_timeScaleSliderNotNull_13();
		if (!L_0)
		{
			goto IL_0018;
		}
	}
	{
		// if(timeScaleSliderNotNull) timeScaleSlider.value = Time.timeScale;
		Slider_tBF39A11CC24CBD3F8BD728982ACAEAE43989B51A * L_1 = __this->get_timeScaleSlider_10();
		float L_2;
		L_2 = Time_get_timeScale_m082A05928ED5917AA986FAA6106E79D8446A26F4(/*hidden argument*/NULL);
		NullCheck(L_1);
		VirtActionInvoker1< float >::Invoke(47 /* System.Void UnityEngine.UI.Slider::set_value(System.Single) */, L_1, L_2);
	}

IL_0018:
	{
		// if(Time.timeScale < 0.01f)
		float L_3;
		L_3 = Time_get_timeScale_m082A05928ED5917AA986FAA6106E79D8446A26F4(/*hidden argument*/NULL);
		if ((!(((float)L_3) < ((float)(0.00999999978f)))))
		{
			goto IL_0046;
		}
	}
	{
		// pausedButtonText.text = "Unpause";
		Text_t6A2339DA6C05AE2646FC1A6C8FCC127391BE7FA1 * L_4 = __this->get_pausedButtonText_16();
		NullCheck(L_4);
		VirtActionInvoker1< String_t* >::Invoke(75 /* System.Void UnityEngine.UI.Text::set_text(System.String) */, L_4, _stringLiteral4780AF940655CB59AF49F6344DA95EC30E32AA8A);
		// pausedButtonImage.color = pausedButtonColor;
		Image_t4021FF27176E44BFEDDCBE43C7FE6B713EC70D3C * L_5 = __this->get_pausedButtonImage_11();
		Color_tF40DAF76C04FFECF3FE6024F85A294741C9CC659  L_6 = __this->get_pausedButtonColor_12();
		NullCheck(L_5);
		VirtActionInvoker1< Color_tF40DAF76C04FFECF3FE6024F85A294741C9CC659  >::Invoke(23 /* System.Void UnityEngine.UI.Graphic::set_color(UnityEngine.Color) */, L_5, L_6);
		// }
		return;
	}

IL_0046:
	{
		// pausedButtonText.text = "Pause";
		Text_t6A2339DA6C05AE2646FC1A6C8FCC127391BE7FA1 * L_7 = __this->get_pausedButtonText_16();
		NullCheck(L_7);
		VirtActionInvoker1< String_t* >::Invoke(75 /* System.Void UnityEngine.UI.Text::set_text(System.String) */, L_7, _stringLiteralAAAA401E86E41E6120BB9E96B9892141CF5A81F8);
		// pausedButtonImage.color = Color.white;
		Image_t4021FF27176E44BFEDDCBE43C7FE6B713EC70D3C * L_8 = __this->get_pausedButtonImage_11();
		Color_tF40DAF76C04FFECF3FE6024F85A294741C9CC659  L_9;
		L_9 = Color_get_white_mB21E47D20959C3AEC41AF8BA04F63AC89FAF319E(/*hidden argument*/NULL);
		NullCheck(L_8);
		VirtActionInvoker1< Color_tF40DAF76C04FFECF3FE6024F85A294741C9CC659  >::Invoke(23 /* System.Void UnityEngine.UI.Graphic::set_color(UnityEngine.Color) */, L_8, L_9);
		// }
		return;
	}
}
// System.Void AllIn1VfxToolkit.Demo.Scripts.AllIn1TimeControl::PauseUiButton()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void AllIn1TimeControl_PauseUiButton_m6883E3CC47AB26B38E8D2DC42D883D03217F5F51 (AllIn1TimeControl_tD27F0B4D919AD681DB84DE2277471ABFF29C38DC * __this, const RuntimeMethod* method)
{
	{
		// if(Time.timeScale < 0.01f) Time.timeScale = 1f;
		float L_0;
		L_0 = Time_get_timeScale_m082A05928ED5917AA986FAA6106E79D8446A26F4(/*hidden argument*/NULL);
		if ((!(((float)L_0) < ((float)(0.00999999978f)))))
		{
			goto IL_0018;
		}
	}
	{
		// if(Time.timeScale < 0.01f) Time.timeScale = 1f;
		Time_set_timeScale_m1987DE9E74FC6C0126CE4F59A6293E3B85BD01EA((1.0f), /*hidden argument*/NULL);
		goto IL_0022;
	}

IL_0018:
	{
		// else Time.timeScale = 0f;
		Time_set_timeScale_m1987DE9E74FC6C0126CE4F59A6293E3B85BD01EA((0.0f), /*hidden argument*/NULL);
	}

IL_0022:
	{
		// UpdateTimeScaleUI();
		AllIn1TimeControl_UpdateTimeScaleUI_mB22071568FDC2263BFFB70F080D426D15F549ABA(__this, /*hidden argument*/NULL);
		// }
		return;
	}
}
// System.Void AllIn1VfxToolkit.Demo.Scripts.AllIn1TimeControl::CurrentEffectChanged()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void AllIn1TimeControl_CurrentEffectChanged_m542665C5D595FAA5213CD7984D171A557ABFC6C8 (AllIn1TimeControl_tD27F0B4D919AD681DB84DE2277471ABFF29C38DC * __this, const RuntimeMethod* method)
{
	{
		// if(Time.timeScale < 0.01f)
		float L_0;
		L_0 = Time_get_timeScale_m082A05928ED5917AA986FAA6106E79D8446A26F4(/*hidden argument*/NULL);
		if ((!(((float)L_0) < ((float)(0.00999999978f)))))
		{
			goto IL_001c;
		}
	}
	{
		// Time.timeScale = 0.1f;
		Time_set_timeScale_m1987DE9E74FC6C0126CE4F59A6293E3B85BD01EA((0.100000001f), /*hidden argument*/NULL);
		// UpdateTimeScaleUI();
		AllIn1TimeControl_UpdateTimeScaleUI_mB22071568FDC2263BFFB70F080D426D15F549ABA(__this, /*hidden argument*/NULL);
	}

IL_001c:
	{
		// }
		return;
	}
}
// System.Void AllIn1VfxToolkit.Demo.Scripts.AllIn1TimeControl::.ctor()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void AllIn1TimeControl__ctor_mCF510D21341AC72EE0BE3783A3ED402192BF7F1C (AllIn1TimeControl_tD27F0B4D919AD681DB84DE2277471ABFF29C38DC * __this, const RuntimeMethod* method)
{
	{
		// [SerializeField] private KeyCode increaseTimeScale = KeyCode.UpArrow;
		__this->set_increaseTimeScale_4(((int32_t)273));
		// [SerializeField] private KeyCode increaseTimeScaleAlt = KeyCode.W;
		__this->set_increaseTimeScaleAlt_5(((int32_t)119));
		// [SerializeField] private KeyCode decreaseTimeScale = KeyCode.DownArrow;
		__this->set_decreaseTimeScale_6(((int32_t)274));
		// [SerializeField] private KeyCode decreaseTimeScaleAlt = KeyCode.S;
		__this->set_decreaseTimeScaleAlt_7(((int32_t)115));
		// [SerializeField] private KeyCode pauseKey = KeyCode.P;
		__this->set_pauseKey_8(((int32_t)112));
		// [SerializeField, Range(0f, 1f)] private float timeScaleInterval = 0.05f;
		__this->set_timeScaleInterval_9((0.0500000007f));
		MonoBehaviour__ctor_mC0995D847F6A95B1A553652636C38A2AA8B13BED(__this, /*hidden argument*/NULL);
		return;
	}
}
// System.Void AllIn1VfxToolkit.Demo.Scripts.AllIn1TimeControl::<Start>b__13_0(System.Single)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void AllIn1TimeControl_U3CStartU3Eb__13_0_m41C786ED0E2119466A425777F89C052C183CBAAF (AllIn1TimeControl_tD27F0B4D919AD681DB84DE2277471ABFF29C38DC * __this, float ___U3Cp0U3E0, const RuntimeMethod* method)
{
	{
		// if(timeScaleSliderNotNull) timeScaleSlider.onValueChanged.AddListener(delegate { ChangeTimeScale(timeScaleSlider.value - Time.timeScale); });
		Slider_tBF39A11CC24CBD3F8BD728982ACAEAE43989B51A * L_0 = __this->get_timeScaleSlider_10();
		NullCheck(L_0);
		float L_1;
		L_1 = VirtFuncInvoker0< float >::Invoke(46 /* System.Single UnityEngine.UI.Slider::get_value() */, L_0);
		float L_2;
		L_2 = Time_get_timeScale_m082A05928ED5917AA986FAA6106E79D8446A26F4(/*hidden argument*/NULL);
		AllIn1TimeControl_ChangeTimeScale_mE4FA5449A14375E70158BA48654537CA487D8BF1(__this, ((float)il2cpp_codegen_subtract((float)L_1, (float)L_2)), /*hidden argument*/NULL);
		// if(timeScaleSliderNotNull) timeScaleSlider.onValueChanged.AddListener(delegate { ChangeTimeScale(timeScaleSlider.value - Time.timeScale); });
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
// System.Void AllIn1VfxToolkit.Demo.Scripts.AllIn1VfxAutoDestroy::Start()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void AllIn1VfxAutoDestroy_Start_m30E383FB7B738348489E47EFA6C11B646CBAA4B1 (AllIn1VfxAutoDestroy_t3C768037E70E7C4C499E0BCA0036CB1913BA6D95 * __this, const RuntimeMethod* method)
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Object_tF2F3778131EFF286AF62B7B013A170F95A91571A_il2cpp_TypeInfo_var);
		s_Il2CppMethodInitialized = true;
	}
	{
		// Destroy(gameObject, destroyTime);
		GameObject_tC000A2E1A7CF1E10FD7BA08863287C072207C319 * L_0;
		L_0 = Component_get_gameObject_m55DC35B149AFB9157582755383BA954655FE0C5B(__this, /*hidden argument*/NULL);
		float L_1 = __this->get_destroyTime_4();
		IL2CPP_RUNTIME_CLASS_INIT(Object_tF2F3778131EFF286AF62B7B013A170F95A91571A_il2cpp_TypeInfo_var);
		Object_Destroy_mAAAA103F4911E9FA18634BF9605C28559F5E2AC7(L_0, L_1, /*hidden argument*/NULL);
		// }
		return;
	}
}
// System.Void AllIn1VfxToolkit.Demo.Scripts.AllIn1VfxAutoDestroy::.ctor()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void AllIn1VfxAutoDestroy__ctor_m936A3EAF3A10BD4CE85BC86E4EE0D5716B2167DC (AllIn1VfxAutoDestroy_t3C768037E70E7C4C499E0BCA0036CB1913BA6D95 * __this, const RuntimeMethod* method)
{
	{
		// [SerializeField] private float destroyTime = 1f;
		__this->set_destroyTime_4((1.0f));
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
// System.Void AllIn1VfxToolkit.Demo.Scripts.AllIn1VfxDemoController::Start()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void AllIn1VfxDemoController_Start_mC607B1B9A838ECF8532E70952B9CC1EBAEB88FDE (AllIn1VfxDemoController_tDBA0E647E412D7CE6715A6976DB1E1A5722F6892 * __this, const RuntimeMethod* method)
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Component_GetComponent_TisAllIn1DemoScaleTween_t513A5592D7B99AAE00D3C297524793A01504CCD0_m3EE927F72C328FCE7176EA4E296BFBD5B69CEF6C_RuntimeMethod_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&GameObject_GetComponent_TisAllIn1TimeControl_tD27F0B4D919AD681DB84DE2277471ABFF29C38DC_mF3263778C546C37B9E1DFF39316D8D702990DD5E_RuntimeMethod_var);
		s_Il2CppMethodInitialized = true;
	}
	{
		// projectileSceneSetupObject.SetActive(false);
		GameObject_tC000A2E1A7CF1E10FD7BA08863287C072207C319 * L_0 = __this->get_projectileSceneSetupObject_8();
		NullCheck(L_0);
		GameObject_SetActive_mCF1EEF2A314F3AE85DA581FF52EB06ACEF2FFF86(L_0, (bool)0, /*hidden argument*/NULL);
		// currDemoCollectionIndex = startingCollectionIndex;
		int32_t L_1 = __this->get_startingCollectionIndex_4();
		__this->set_currDemoCollectionIndex_26(L_1);
		// currDemoEffectIndex = startingEffectIndex;
		int32_t L_2 = __this->get_startingEffectIndex_5();
		__this->set_currDemoEffectIndex_27(L_2);
		// currLabelTween = currentEffectLabel.GetComponent<AllIn1DemoScaleTween>();
		Text_t6A2339DA6C05AE2646FC1A6C8FCC127391BE7FA1 * L_3 = __this->get_currentEffectLabel_15();
		NullCheck(L_3);
		AllIn1DemoScaleTween_t513A5592D7B99AAE00D3C297524793A01504CCD0 * L_4;
		L_4 = Component_GetComponent_TisAllIn1DemoScaleTween_t513A5592D7B99AAE00D3C297524793A01504CCD0_m3EE927F72C328FCE7176EA4E296BFBD5B69CEF6C(L_3, /*hidden argument*/Component_GetComponent_TisAllIn1DemoScaleTween_t513A5592D7B99AAE00D3C297524793A01504CCD0_m3EE927F72C328FCE7176EA4E296BFBD5B69CEF6C_RuntimeMethod_var);
		__this->set_currLabelTween_29(L_4);
		// playButtTween = playEffectButton.GetComponent<AllIn1DemoScaleTween>();
		Button_tA893FC15AB26E1439AC25BDCA7079530587BB65D * L_5 = __this->get_playEffectButton_16();
		NullCheck(L_5);
		AllIn1DemoScaleTween_t513A5592D7B99AAE00D3C297524793A01504CCD0 * L_6;
		L_6 = Component_GetComponent_TisAllIn1DemoScaleTween_t513A5592D7B99AAE00D3C297524793A01504CCD0_m3EE927F72C328FCE7176EA4E296BFBD5B69CEF6C(L_5, /*hidden argument*/Component_GetComponent_TisAllIn1DemoScaleTween_t513A5592D7B99AAE00D3C297524793A01504CCD0_m3EE927F72C328FCE7176EA4E296BFBD5B69CEF6C_RuntimeMethod_var);
		__this->set_playButtTween_30(L_6);
		// nextButtTween = nextEffectButton.GetComponent<AllIn1DemoScaleTween>();
		Button_tA893FC15AB26E1439AC25BDCA7079530587BB65D * L_7 = __this->get_nextEffectButton_18();
		NullCheck(L_7);
		AllIn1DemoScaleTween_t513A5592D7B99AAE00D3C297524793A01504CCD0 * L_8;
		L_8 = Component_GetComponent_TisAllIn1DemoScaleTween_t513A5592D7B99AAE00D3C297524793A01504CCD0_m3EE927F72C328FCE7176EA4E296BFBD5B69CEF6C(L_7, /*hidden argument*/Component_GetComponent_TisAllIn1DemoScaleTween_t513A5592D7B99AAE00D3C297524793A01504CCD0_m3EE927F72C328FCE7176EA4E296BFBD5B69CEF6C_RuntimeMethod_var);
		__this->set_nextButtTween_31(L_8);
		// prevButtTween = previousEffectButton.GetComponent<AllIn1DemoScaleTween>();
		Button_tA893FC15AB26E1439AC25BDCA7079530587BB65D * L_9 = __this->get_previousEffectButton_19();
		NullCheck(L_9);
		AllIn1DemoScaleTween_t513A5592D7B99AAE00D3C297524793A01504CCD0 * L_10;
		L_10 = Component_GetComponent_TisAllIn1DemoScaleTween_t513A5592D7B99AAE00D3C297524793A01504CCD0_m3EE927F72C328FCE7176EA4E296BFBD5B69CEF6C(L_9, /*hidden argument*/Component_GetComponent_TisAllIn1DemoScaleTween_t513A5592D7B99AAE00D3C297524793A01504CCD0_m3EE927F72C328FCE7176EA4E296BFBD5B69CEF6C_RuntimeMethod_var);
		__this->set_prevButtTween_32(L_10);
		// allIn1TimeControl = gameObject.GetComponent<AllIn1TimeControl>();
		GameObject_tC000A2E1A7CF1E10FD7BA08863287C072207C319 * L_11;
		L_11 = Component_get_gameObject_m55DC35B149AFB9157582755383BA954655FE0C5B(__this, /*hidden argument*/NULL);
		NullCheck(L_11);
		AllIn1TimeControl_tD27F0B4D919AD681DB84DE2277471ABFF29C38DC * L_12;
		L_12 = GameObject_GetComponent_TisAllIn1TimeControl_tD27F0B4D919AD681DB84DE2277471ABFF29C38DC_mF3263778C546C37B9E1DFF39316D8D702990DD5E(L_11, /*hidden argument*/GameObject_GetComponent_TisAllIn1TimeControl_tD27F0B4D919AD681DB84DE2277471ABFF29C38DC_mF3263778C546C37B9E1DFF39316D8D702990DD5E_RuntimeMethod_var);
		__this->set_allIn1TimeControl_34(L_12);
		// SetupAndInstantiateCurrentEffect();
		AllIn1VfxDemoController_SetupAndInstantiateCurrentEffect_mFFCD7DA958AB68D709C5B0328AD5FBE8416157AC(__this, /*hidden argument*/NULL);
		// }
		return;
	}
}
// System.Void AllIn1VfxToolkit.Demo.Scripts.AllIn1VfxDemoController::Update()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void AllIn1VfxDemoController_Update_m3AECAF06C1922308926AD73CC1523E5993B96EB4 (AllIn1VfxDemoController_tDBA0E647E412D7CE6715A6976DB1E1A5722F6892 * __this, const RuntimeMethod* method)
{
	{
		// if(currDemoEffect.canBePlayedAgain && Input.GetKeyDown(playEffectKey)) PlayCurrentEffect();
		All1VfxDemoEffect_t66A278FEFF55B095702CEE911709440057966E75 * L_0 = __this->get_currDemoEffect_25();
		NullCheck(L_0);
		bool L_1 = L_0->get_canBePlayedAgain_5();
		if (!L_1)
		{
			goto IL_0021;
		}
	}
	{
		int32_t L_2 = __this->get_playEffectKey_10();
		bool L_3;
		L_3 = Input_GetKeyDown_m476116696E71771641BBECBAB1A4C55E69018220(L_2, /*hidden argument*/NULL);
		if (!L_3)
		{
			goto IL_0021;
		}
	}
	{
		// if(currDemoEffect.canBePlayedAgain && Input.GetKeyDown(playEffectKey)) PlayCurrentEffect();
		AllIn1VfxDemoController_PlayCurrentEffect_m12550E66ED360BD359AA42CC05C3BB622EC6BD6F(__this, (bool)0, /*hidden argument*/NULL);
	}

IL_0021:
	{
		// if(Input.GetKeyDown(nextEffectKey) || Input.GetKeyDown(nextEffectKeyAlt)) ChangeCurrentEffect(1);
		int32_t L_4 = __this->get_nextEffectKey_11();
		bool L_5;
		L_5 = Input_GetKeyDown_m476116696E71771641BBECBAB1A4C55E69018220(L_4, /*hidden argument*/NULL);
		if (L_5)
		{
			goto IL_003b;
		}
	}
	{
		int32_t L_6 = __this->get_nextEffectKeyAlt_12();
		bool L_7;
		L_7 = Input_GetKeyDown_m476116696E71771641BBECBAB1A4C55E69018220(L_6, /*hidden argument*/NULL);
		if (!L_7)
		{
			goto IL_0044;
		}
	}

IL_003b:
	{
		// if(Input.GetKeyDown(nextEffectKey) || Input.GetKeyDown(nextEffectKeyAlt)) ChangeCurrentEffect(1);
		AllIn1VfxDemoController_ChangeCurrentEffect_m95CF6E65BB2B2454A3F15DCBC9D222E15D23D3C5(__this, 1, /*hidden argument*/NULL);
		goto IL_0065;
	}

IL_0044:
	{
		// else if(Input.GetKeyDown(previousEffectKey) || Input.GetKeyDown(previousEffectKeyAlt)) ChangeCurrentEffect(-1);
		int32_t L_8 = __this->get_previousEffectKey_13();
		bool L_9;
		L_9 = Input_GetKeyDown_m476116696E71771641BBECBAB1A4C55E69018220(L_8, /*hidden argument*/NULL);
		if (L_9)
		{
			goto IL_005e;
		}
	}
	{
		int32_t L_10 = __this->get_previousEffectKeyAlt_14();
		bool L_11;
		L_11 = Input_GetKeyDown_m476116696E71771641BBECBAB1A4C55E69018220(L_10, /*hidden argument*/NULL);
		if (!L_11)
		{
			goto IL_0065;
		}
	}

IL_005e:
	{
		// else if(Input.GetKeyDown(previousEffectKey) || Input.GetKeyDown(previousEffectKeyAlt)) ChangeCurrentEffect(-1);
		AllIn1VfxDemoController_ChangeCurrentEffect_m95CF6E65BB2B2454A3F15DCBC9D222E15D23D3C5(__this, (-1), /*hidden argument*/NULL);
	}

IL_0065:
	{
		// if(currDemoEffect.spawnTouchingFloor) cameraPivotTransform.position = Vector3.Lerp(cameraPivotTransform.position, new Vector3(0f, 0.1f, 0f), Time.unscaledDeltaTime * camPivotHeightSmoothing);
		All1VfxDemoEffect_t66A278FEFF55B095702CEE911709440057966E75 * L_12 = __this->get_currDemoEffect_25();
		NullCheck(L_12);
		bool L_13 = L_12->get_spawnTouchingFloor_10();
		if (!L_13)
		{
			goto IL_00ad;
		}
	}
	{
		// if(currDemoEffect.spawnTouchingFloor) cameraPivotTransform.position = Vector3.Lerp(cameraPivotTransform.position, new Vector3(0f, 0.1f, 0f), Time.unscaledDeltaTime * camPivotHeightSmoothing);
		Transform_tA8193BB29D4D2C7EC04918F3ED1816345186C3F1 * L_14 = __this->get_cameraPivotTransform_21();
		Transform_tA8193BB29D4D2C7EC04918F3ED1816345186C3F1 * L_15 = __this->get_cameraPivotTransform_21();
		NullCheck(L_15);
		Vector3_t65B972D6A585A0A5B63153CF1177A90D3C90D65E  L_16;
		L_16 = Transform_get_position_m40A8A9895568D56FFC687B57F30E8D53CB5EA341(L_15, /*hidden argument*/NULL);
		Vector3_t65B972D6A585A0A5B63153CF1177A90D3C90D65E  L_17;
		memset((&L_17), 0, sizeof(L_17));
		Vector3__ctor_m57495F692C6CE1CEF278CAD9A98221165D37E636_inline((&L_17), (0.0f), (0.100000001f), (0.0f), /*hidden argument*/NULL);
		float L_18;
		L_18 = Time_get_unscaledDeltaTime_m2C153F1E5C77C6AF655054BC6C76D0C334C0DC84(/*hidden argument*/NULL);
		float L_19 = __this->get_camPivotHeightSmoothing_22();
		Vector3_t65B972D6A585A0A5B63153CF1177A90D3C90D65E  L_20;
		L_20 = Vector3_Lerp_m8E095584FFA10CF1D3EABCD04F4C83FB82EC5524_inline(L_16, L_17, ((float)il2cpp_codegen_multiply((float)L_18, (float)L_19)), /*hidden argument*/NULL);
		NullCheck(L_14);
		Transform_set_position_mB169E52D57EEAC1E3F22C5395968714E4F00AC91(L_14, L_20, /*hidden argument*/NULL);
	}

IL_00ad:
	{
		// if(!currDemoEffect.spawnTouchingFloor) cameraPivotTransform.position = Vector3.Lerp(cameraPivotTransform.position, new Vector3(0f, 2f, 0f), Time.unscaledDeltaTime * camPivotHeightSmoothing);
		All1VfxDemoEffect_t66A278FEFF55B095702CEE911709440057966E75 * L_21 = __this->get_currDemoEffect_25();
		NullCheck(L_21);
		bool L_22 = L_21->get_spawnTouchingFloor_10();
		if (L_22)
		{
			goto IL_00f5;
		}
	}
	{
		// if(!currDemoEffect.spawnTouchingFloor) cameraPivotTransform.position = Vector3.Lerp(cameraPivotTransform.position, new Vector3(0f, 2f, 0f), Time.unscaledDeltaTime * camPivotHeightSmoothing);
		Transform_tA8193BB29D4D2C7EC04918F3ED1816345186C3F1 * L_23 = __this->get_cameraPivotTransform_21();
		Transform_tA8193BB29D4D2C7EC04918F3ED1816345186C3F1 * L_24 = __this->get_cameraPivotTransform_21();
		NullCheck(L_24);
		Vector3_t65B972D6A585A0A5B63153CF1177A90D3C90D65E  L_25;
		L_25 = Transform_get_position_m40A8A9895568D56FFC687B57F30E8D53CB5EA341(L_24, /*hidden argument*/NULL);
		Vector3_t65B972D6A585A0A5B63153CF1177A90D3C90D65E  L_26;
		memset((&L_26), 0, sizeof(L_26));
		Vector3__ctor_m57495F692C6CE1CEF278CAD9A98221165D37E636_inline((&L_26), (0.0f), (2.0f), (0.0f), /*hidden argument*/NULL);
		float L_27;
		L_27 = Time_get_unscaledDeltaTime_m2C153F1E5C77C6AF655054BC6C76D0C334C0DC84(/*hidden argument*/NULL);
		float L_28 = __this->get_camPivotHeightSmoothing_22();
		Vector3_t65B972D6A585A0A5B63153CF1177A90D3C90D65E  L_29;
		L_29 = Vector3_Lerp_m8E095584FFA10CF1D3EABCD04F4C83FB82EC5524_inline(L_25, L_26, ((float)il2cpp_codegen_multiply((float)L_27, (float)L_28)), /*hidden argument*/NULL);
		NullCheck(L_23);
		Transform_set_position_mB169E52D57EEAC1E3F22C5395968714E4F00AC91(L_23, L_29, /*hidden argument*/NULL);
	}

IL_00f5:
	{
		// CooldownHandling();
		AllIn1VfxDemoController_CooldownHandling_mE5F21D70CDA54F109AD1FE91FA75C00FED112BC3(__this, /*hidden argument*/NULL);
		// }
		return;
	}
}
// System.Void AllIn1VfxToolkit.Demo.Scripts.AllIn1VfxDemoController::CooldownHandling()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void AllIn1VfxDemoController_CooldownHandling_mE5F21D70CDA54F109AD1FE91FA75C00FED112BC3 (AllIn1VfxDemoController_tDBA0E647E412D7CE6715A6976DB1E1A5722F6892 * __this, const RuntimeMethod* method)
{
	Button_tA893FC15AB26E1439AC25BDCA7079530587BB65D * G_B4_0 = NULL;
	Button_tA893FC15AB26E1439AC25BDCA7079530587BB65D * G_B3_0 = NULL;
	int32_t G_B5_0 = 0;
	Button_tA893FC15AB26E1439AC25BDCA7079530587BB65D * G_B5_1 = NULL;
	{
		// if(!currDemoEffect.canBePlayedAgain) return;
		All1VfxDemoEffect_t66A278FEFF55B095702CEE911709440057966E75 * L_0 = __this->get_currDemoEffect_25();
		NullCheck(L_0);
		bool L_1 = L_0->get_canBePlayedAgain_5();
		if (L_1)
		{
			goto IL_000e;
		}
	}
	{
		// if(!currDemoEffect.canBePlayedAgain) return;
		return;
	}

IL_000e:
	{
		// timeSinceEffectPlay += Time.deltaTime;
		float L_2 = __this->get_timeSinceEffectPlay_33();
		float L_3;
		L_3 = Time_get_deltaTime_mCC15F147DA67F38C74CE408FB5D7FF4A87DA2290(/*hidden argument*/NULL);
		__this->set_timeSinceEffectPlay_33(((float)il2cpp_codegen_add((float)L_2, (float)L_3)));
		// playEffectButton.interactable = currentEffectPlays < 1 || timeSinceEffectPlay >= currDemoEffect.cooldown;
		Button_tA893FC15AB26E1439AC25BDCA7079530587BB65D * L_4 = __this->get_playEffectButton_16();
		int32_t L_5 = __this->get_currentEffectPlays_28();
		G_B3_0 = L_4;
		if ((((int32_t)L_5) < ((int32_t)1)))
		{
			G_B4_0 = L_4;
			goto IL_0047;
		}
	}
	{
		float L_6 = __this->get_timeSinceEffectPlay_33();
		All1VfxDemoEffect_t66A278FEFF55B095702CEE911709440057966E75 * L_7 = __this->get_currDemoEffect_25();
		NullCheck(L_7);
		float L_8 = L_7->get_cooldown_7();
		G_B5_0 = ((((int32_t)((!(((float)L_6) >= ((float)L_8)))? 1 : 0)) == ((int32_t)0))? 1 : 0);
		G_B5_1 = G_B3_0;
		goto IL_0048;
	}

IL_0047:
	{
		G_B5_0 = 1;
		G_B5_1 = G_B4_0;
	}

IL_0048:
	{
		NullCheck(G_B5_1);
		Selectable_set_interactable_mE6F57D33A9E0484377174D0F490C4372BF7F0D40(G_B5_1, (bool)G_B5_0, /*hidden argument*/NULL);
		// }
		return;
	}
}
// System.Void AllIn1VfxToolkit.Demo.Scripts.AllIn1VfxDemoController::PlayCurrentEffect(System.Boolean)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void AllIn1VfxDemoController_PlayCurrentEffect_m12550E66ED360BD359AA42CC05C3BB622EC6BD6F (AllIn1VfxDemoController_tDBA0E647E412D7CE6715A6976DB1E1A5722F6892 * __this, bool ___isAfterSetupAndInstantiateEffect0, const RuntimeMethod* method)
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&AllIn1Shaker_t4540E312EAE72C5A4E5F184AFEC3099E91179295_il2cpp_TypeInfo_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Component_GetComponent_TisAllIn1DemoProjectile_tA36F8B6BF3163732D0C981065AF301449C4AAE69_mDC2B3DDAC7100EB3664EFDDE053CE3955615FC3E_RuntimeMethod_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Object_Instantiate_TisGameObject_tC000A2E1A7CF1E10FD7BA08863287C072207C319_m81B599A0051F8F4543E5C73A11585E96E940943B_RuntimeMethod_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Object_Instantiate_TisGameObject_tC000A2E1A7CF1E10FD7BA08863287C072207C319_mF131D53AB04E75E849487A7ACF79A8B27527F4B8_RuntimeMethod_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Object_tF2F3778131EFF286AF62B7B013A170F95A91571A_il2cpp_TypeInfo_var);
		s_Il2CppMethodInitialized = true;
	}
	Transform_tA8193BB29D4D2C7EC04918F3ED1816345186C3F1 * V_0 = NULL;
	Transform_tA8193BB29D4D2C7EC04918F3ED1816345186C3F1 * V_1 = NULL;
	AllIn1DemoProjectile_tA36F8B6BF3163732D0C981065AF301449C4AAE69 * V_2 = NULL;
	{
		// if(currentEffectPlays > 0 && timeSinceEffectPlay < currDemoEffect.cooldown) return; //Return if on cooldown and not first play
		int32_t L_0 = __this->get_currentEffectPlays_28();
		if ((((int32_t)L_0) <= ((int32_t)0)))
		{
			goto IL_001d;
		}
	}
	{
		float L_1 = __this->get_timeSinceEffectPlay_33();
		All1VfxDemoEffect_t66A278FEFF55B095702CEE911709440057966E75 * L_2 = __this->get_currDemoEffect_25();
		NullCheck(L_2);
		float L_3 = L_2->get_cooldown_7();
		if ((!(((float)L_1) < ((float)L_3))))
		{
			goto IL_001d;
		}
	}
	{
		// if(currentEffectPlays > 0 && timeSinceEffectPlay < currDemoEffect.cooldown) return; //Return if on cooldown and not first play
		return;
	}

IL_001d:
	{
		// if(!isAfterSetupAndInstantiateEffect && Time.timeSinceLevelLoad > 0.1f) playButtTween.ScaleUpTween();
		bool L_4 = ___isAfterSetupAndInstantiateEffect0;
		if (L_4)
		{
			goto IL_0037;
		}
	}
	{
		float L_5;
		L_5 = Time_get_timeSinceLevelLoad_m47A90DE6CB3A3180D64F0049290BC72C186FC7FB(/*hidden argument*/NULL);
		if ((!(((float)L_5) > ((float)(0.100000001f)))))
		{
			goto IL_0037;
		}
	}
	{
		// if(!isAfterSetupAndInstantiateEffect && Time.timeSinceLevelLoad > 0.1f) playButtTween.ScaleUpTween();
		AllIn1DemoScaleTween_t513A5592D7B99AAE00D3C297524793A01504CCD0 * L_6 = __this->get_playButtTween_30();
		NullCheck(L_6);
		AllIn1DemoScaleTween_ScaleUpTween_m003B3BF936F501523FB03E83AA493B449CDF2D3F(L_6, /*hidden argument*/NULL);
	}

IL_0037:
	{
		// if(!isAfterSetupAndInstantiateEffect && currDemoEffect.onlyOneAtATime) DestroyAllChildren();
		bool L_7 = ___isAfterSetupAndInstantiateEffect0;
		if (L_7)
		{
			goto IL_004d;
		}
	}
	{
		All1VfxDemoEffect_t66A278FEFF55B095702CEE911709440057966E75 * L_8 = __this->get_currDemoEffect_25();
		NullCheck(L_8);
		bool L_9 = L_8->get_onlyOneAtATime_4();
		if (!L_9)
		{
			goto IL_004d;
		}
	}
	{
		// if(!isAfterSetupAndInstantiateEffect && currDemoEffect.onlyOneAtATime) DestroyAllChildren();
		AllIn1VfxDemoController_DestroyAllChildren_mAD6FDC80DDC9B8DA3E39DC364065D4C06DD9373D(__this, /*hidden argument*/NULL);
	}

IL_004d:
	{
		// timeSinceEffectPlay = 0f;
		__this->set_timeSinceEffectPlay_33((0.0f));
		// Transform tempTransform = null;
		V_0 = (Transform_tA8193BB29D4D2C7EC04918F3ED1816345186C3F1 *)NULL;
		// if(currDemoEffect.isShootProjectile)
		All1VfxDemoEffect_t66A278FEFF55B095702CEE911709440057966E75 * L_10 = __this->get_currDemoEffect_25();
		NullCheck(L_10);
		bool L_11 = L_10->get_isShootProjectile_8();
		if (!L_11)
		{
			goto IL_01de;
		}
	}
	{
		// if(currDemoEffect.muzzleFlashPrefab != null)
		All1VfxDemoEffect_t66A278FEFF55B095702CEE911709440057966E75 * L_12 = __this->get_currDemoEffect_25();
		NullCheck(L_12);
		GameObject_tC000A2E1A7CF1E10FD7BA08863287C072207C319 * L_13 = L_12->get_muzzleFlashPrefab_13();
		IL2CPP_RUNTIME_CLASS_INIT(Object_tF2F3778131EFF286AF62B7B013A170F95A91571A_il2cpp_TypeInfo_var);
		bool L_14;
		L_14 = Object_op_Inequality_mE1F187520BD83FB7D86A6D850710C4D42B864E90(L_13, (Object_tF2F3778131EFF286AF62B7B013A170F95A91571A *)NULL, /*hidden argument*/NULL);
		if (!L_14)
		{
			goto IL_00e7;
		}
	}
	{
		// tempTransform = Instantiate(currDemoEffect.muzzleFlashPrefab, projectileSpawnPoint.position, Quaternion.identity).transform;
		All1VfxDemoEffect_t66A278FEFF55B095702CEE911709440057966E75 * L_15 = __this->get_currDemoEffect_25();
		NullCheck(L_15);
		GameObject_tC000A2E1A7CF1E10FD7BA08863287C072207C319 * L_16 = L_15->get_muzzleFlashPrefab_13();
		Transform_tA8193BB29D4D2C7EC04918F3ED1816345186C3F1 * L_17 = __this->get_projectileSpawnPoint_9();
		NullCheck(L_17);
		Vector3_t65B972D6A585A0A5B63153CF1177A90D3C90D65E  L_18;
		L_18 = Transform_get_position_m40A8A9895568D56FFC687B57F30E8D53CB5EA341(L_17, /*hidden argument*/NULL);
		Quaternion_t6D28618CF65156D4A0AD747370DDFD0C514A31B4  L_19;
		L_19 = Quaternion_get_identity_mF2E565DBCE793A1AE6208056D42CA7C59D83A702(/*hidden argument*/NULL);
		IL2CPP_RUNTIME_CLASS_INIT(Object_tF2F3778131EFF286AF62B7B013A170F95A91571A_il2cpp_TypeInfo_var);
		GameObject_tC000A2E1A7CF1E10FD7BA08863287C072207C319 * L_20;
		L_20 = Object_Instantiate_TisGameObject_tC000A2E1A7CF1E10FD7BA08863287C072207C319_m81B599A0051F8F4543E5C73A11585E96E940943B(L_16, L_18, L_19, /*hidden argument*/Object_Instantiate_TisGameObject_tC000A2E1A7CF1E10FD7BA08863287C072207C319_m81B599A0051F8F4543E5C73A11585E96E940943B_RuntimeMethod_var);
		NullCheck(L_20);
		Transform_tA8193BB29D4D2C7EC04918F3ED1816345186C3F1 * L_21;
		L_21 = GameObject_get_transform_m16A80BB92B6C8C5AB696E447014D45EDF1E4DE34(L_20, /*hidden argument*/NULL);
		V_0 = L_21;
		// tempTransform.localRotation = Quaternion.identity;
		Transform_tA8193BB29D4D2C7EC04918F3ED1816345186C3F1 * L_22 = V_0;
		Quaternion_t6D28618CF65156D4A0AD747370DDFD0C514A31B4  L_23;
		L_23 = Quaternion_get_identity_mF2E565DBCE793A1AE6208056D42CA7C59D83A702(/*hidden argument*/NULL);
		NullCheck(L_22);
		Transform_set_localRotation_m1A9101457EC4653AFC93FCC4065A29F2C78FA62C(L_22, L_23, /*hidden argument*/NULL);
		// tempTransform.forward = projectileSpawnPoint.forward;
		Transform_tA8193BB29D4D2C7EC04918F3ED1816345186C3F1 * L_24 = V_0;
		Transform_tA8193BB29D4D2C7EC04918F3ED1816345186C3F1 * L_25 = __this->get_projectileSpawnPoint_9();
		NullCheck(L_25);
		Vector3_t65B972D6A585A0A5B63153CF1177A90D3C90D65E  L_26;
		L_26 = Transform_get_forward_mD850B9ECF892009E3485408DC0D375165B7BF053(L_25, /*hidden argument*/NULL);
		NullCheck(L_24);
		Transform_set_forward_mAE46B156F55F2F90AB495B17F7C20BF59A5D7D4D(L_24, L_26, /*hidden argument*/NULL);
		// tempTransform.parent = transform;
		Transform_tA8193BB29D4D2C7EC04918F3ED1816345186C3F1 * L_27 = V_0;
		Transform_tA8193BB29D4D2C7EC04918F3ED1816345186C3F1 * L_28;
		L_28 = Component_get_transform_mE8496EBC45BEB1BADB5F314960F1DF1C952FA11F(__this, /*hidden argument*/NULL);
		NullCheck(L_27);
		Transform_set_parent_mEAE304E1A804E8B83054CEECB5BF1E517196EC13(L_27, L_28, /*hidden argument*/NULL);
		// tempTransform.localScale *= currDemoEffect.scaleMultiplier;
		Transform_tA8193BB29D4D2C7EC04918F3ED1816345186C3F1 * L_29 = V_0;
		Transform_tA8193BB29D4D2C7EC04918F3ED1816345186C3F1 * L_30 = L_29;
		NullCheck(L_30);
		Vector3_t65B972D6A585A0A5B63153CF1177A90D3C90D65E  L_31;
		L_31 = Transform_get_localScale_mD9DF6CA81108C2A6002B5EA2BE25A6CD2723D046(L_30, /*hidden argument*/NULL);
		All1VfxDemoEffect_t66A278FEFF55B095702CEE911709440057966E75 * L_32 = __this->get_currDemoEffect_25();
		NullCheck(L_32);
		float L_33 = L_32->get_scaleMultiplier_19();
		Vector3_t65B972D6A585A0A5B63153CF1177A90D3C90D65E  L_34;
		L_34 = Vector3_op_Multiply_m9EA3D18290418D7B410C7D11C4788C13BFD2C30A_inline(L_31, L_33, /*hidden argument*/NULL);
		NullCheck(L_30);
		Transform_set_localScale_mF4D1611E48D1BA7566A1E166DC2DACF3ADD8BA3A(L_30, L_34, /*hidden argument*/NULL);
	}

IL_00e7:
	{
		// Transform projectileBase = Instantiate(projectileBasePrefab, projectileSpawnPoint.position, Quaternion.identity).transform;
		GameObject_tC000A2E1A7CF1E10FD7BA08863287C072207C319 * L_35 = __this->get_projectileBasePrefab_7();
		Transform_tA8193BB29D4D2C7EC04918F3ED1816345186C3F1 * L_36 = __this->get_projectileSpawnPoint_9();
		NullCheck(L_36);
		Vector3_t65B972D6A585A0A5B63153CF1177A90D3C90D65E  L_37;
		L_37 = Transform_get_position_m40A8A9895568D56FFC687B57F30E8D53CB5EA341(L_36, /*hidden argument*/NULL);
		Quaternion_t6D28618CF65156D4A0AD747370DDFD0C514A31B4  L_38;
		L_38 = Quaternion_get_identity_mF2E565DBCE793A1AE6208056D42CA7C59D83A702(/*hidden argument*/NULL);
		IL2CPP_RUNTIME_CLASS_INIT(Object_tF2F3778131EFF286AF62B7B013A170F95A91571A_il2cpp_TypeInfo_var);
		GameObject_tC000A2E1A7CF1E10FD7BA08863287C072207C319 * L_39;
		L_39 = Object_Instantiate_TisGameObject_tC000A2E1A7CF1E10FD7BA08863287C072207C319_m81B599A0051F8F4543E5C73A11585E96E940943B(L_35, L_37, L_38, /*hidden argument*/Object_Instantiate_TisGameObject_tC000A2E1A7CF1E10FD7BA08863287C072207C319_m81B599A0051F8F4543E5C73A11585E96E940943B_RuntimeMethod_var);
		NullCheck(L_39);
		Transform_tA8193BB29D4D2C7EC04918F3ED1816345186C3F1 * L_40;
		L_40 = GameObject_get_transform_m16A80BB92B6C8C5AB696E447014D45EDF1E4DE34(L_39, /*hidden argument*/NULL);
		V_1 = L_40;
		// projectileBase.forward = projectileSpawnPoint.forward;
		Transform_tA8193BB29D4D2C7EC04918F3ED1816345186C3F1 * L_41 = V_1;
		Transform_tA8193BB29D4D2C7EC04918F3ED1816345186C3F1 * L_42 = __this->get_projectileSpawnPoint_9();
		NullCheck(L_42);
		Vector3_t65B972D6A585A0A5B63153CF1177A90D3C90D65E  L_43;
		L_43 = Transform_get_forward_mD850B9ECF892009E3485408DC0D375165B7BF053(L_42, /*hidden argument*/NULL);
		NullCheck(L_41);
		Transform_set_forward_mAE46B156F55F2F90AB495B17F7C20BF59A5D7D4D(L_41, L_43, /*hidden argument*/NULL);
		// projectileBase.parent = transform;
		Transform_tA8193BB29D4D2C7EC04918F3ED1816345186C3F1 * L_44 = V_1;
		Transform_tA8193BB29D4D2C7EC04918F3ED1816345186C3F1 * L_45;
		L_45 = Component_get_transform_mE8496EBC45BEB1BADB5F314960F1DF1C952FA11F(__this, /*hidden argument*/NULL);
		NullCheck(L_44);
		Transform_set_parent_mEAE304E1A804E8B83054CEECB5BF1E517196EC13(L_44, L_45, /*hidden argument*/NULL);
		// projectileBase.localRotation = Quaternion.identity;
		Transform_tA8193BB29D4D2C7EC04918F3ED1816345186C3F1 * L_46 = V_1;
		Quaternion_t6D28618CF65156D4A0AD747370DDFD0C514A31B4  L_47;
		L_47 = Quaternion_get_identity_mF2E565DBCE793A1AE6208056D42CA7C59D83A702(/*hidden argument*/NULL);
		NullCheck(L_46);
		Transform_set_localRotation_m1A9101457EC4653AFC93FCC4065A29F2C78FA62C(L_46, L_47, /*hidden argument*/NULL);
		// tempTransform = Instantiate(currDemoEffect.projectilePrefab, projectileSpawnPoint.position, Quaternion.identity).transform;
		All1VfxDemoEffect_t66A278FEFF55B095702CEE911709440057966E75 * L_48 = __this->get_currDemoEffect_25();
		NullCheck(L_48);
		GameObject_tC000A2E1A7CF1E10FD7BA08863287C072207C319 * L_49 = L_48->get_projectilePrefab_12();
		Transform_tA8193BB29D4D2C7EC04918F3ED1816345186C3F1 * L_50 = __this->get_projectileSpawnPoint_9();
		NullCheck(L_50);
		Vector3_t65B972D6A585A0A5B63153CF1177A90D3C90D65E  L_51;
		L_51 = Transform_get_position_m40A8A9895568D56FFC687B57F30E8D53CB5EA341(L_50, /*hidden argument*/NULL);
		Quaternion_t6D28618CF65156D4A0AD747370DDFD0C514A31B4  L_52;
		L_52 = Quaternion_get_identity_mF2E565DBCE793A1AE6208056D42CA7C59D83A702(/*hidden argument*/NULL);
		GameObject_tC000A2E1A7CF1E10FD7BA08863287C072207C319 * L_53;
		L_53 = Object_Instantiate_TisGameObject_tC000A2E1A7CF1E10FD7BA08863287C072207C319_m81B599A0051F8F4543E5C73A11585E96E940943B(L_49, L_51, L_52, /*hidden argument*/Object_Instantiate_TisGameObject_tC000A2E1A7CF1E10FD7BA08863287C072207C319_m81B599A0051F8F4543E5C73A11585E96E940943B_RuntimeMethod_var);
		NullCheck(L_53);
		Transform_tA8193BB29D4D2C7EC04918F3ED1816345186C3F1 * L_54;
		L_54 = GameObject_get_transform_m16A80BB92B6C8C5AB696E447014D45EDF1E4DE34(L_53, /*hidden argument*/NULL);
		V_0 = L_54;
		// tempTransform.localRotation = Quaternion.identity;
		Transform_tA8193BB29D4D2C7EC04918F3ED1816345186C3F1 * L_55 = V_0;
		Quaternion_t6D28618CF65156D4A0AD747370DDFD0C514A31B4  L_56;
		L_56 = Quaternion_get_identity_mF2E565DBCE793A1AE6208056D42CA7C59D83A702(/*hidden argument*/NULL);
		NullCheck(L_55);
		Transform_set_localRotation_m1A9101457EC4653AFC93FCC4065A29F2C78FA62C(L_55, L_56, /*hidden argument*/NULL);
		// tempTransform.forward = projectileSpawnPoint.forward;
		Transform_tA8193BB29D4D2C7EC04918F3ED1816345186C3F1 * L_57 = V_0;
		Transform_tA8193BB29D4D2C7EC04918F3ED1816345186C3F1 * L_58 = __this->get_projectileSpawnPoint_9();
		NullCheck(L_58);
		Vector3_t65B972D6A585A0A5B63153CF1177A90D3C90D65E  L_59;
		L_59 = Transform_get_forward_mD850B9ECF892009E3485408DC0D375165B7BF053(L_58, /*hidden argument*/NULL);
		NullCheck(L_57);
		Transform_set_forward_mAE46B156F55F2F90AB495B17F7C20BF59A5D7D4D(L_57, L_59, /*hidden argument*/NULL);
		// tempTransform.parent = projectileBase;
		Transform_tA8193BB29D4D2C7EC04918F3ED1816345186C3F1 * L_60 = V_0;
		Transform_tA8193BB29D4D2C7EC04918F3ED1816345186C3F1 * L_61 = V_1;
		NullCheck(L_60);
		Transform_set_parent_mEAE304E1A804E8B83054CEECB5BF1E517196EC13(L_60, L_61, /*hidden argument*/NULL);
		// AllIn1DemoProjectile tempProjectileInstance = projectileBase.GetComponent<AllIn1DemoProjectile>();
		Transform_tA8193BB29D4D2C7EC04918F3ED1816345186C3F1 * L_62 = V_1;
		NullCheck(L_62);
		AllIn1DemoProjectile_tA36F8B6BF3163732D0C981065AF301449C4AAE69 * L_63;
		L_63 = Component_GetComponent_TisAllIn1DemoProjectile_tA36F8B6BF3163732D0C981065AF301449C4AAE69_mDC2B3DDAC7100EB3664EFDDE053CE3955615FC3E(L_62, /*hidden argument*/Component_GetComponent_TisAllIn1DemoProjectile_tA36F8B6BF3163732D0C981065AF301449C4AAE69_mDC2B3DDAC7100EB3664EFDDE053CE3955615FC3E_RuntimeMethod_var);
		V_2 = L_63;
		// tempProjectileInstance.Initialize(transform, projectileSpawnPoint.forward, currDemoEffect.projectileSpeed, currDemoEffect.impactPrefab, currDemoEffect.scaleMultiplier);
		AllIn1DemoProjectile_tA36F8B6BF3163732D0C981065AF301449C4AAE69 * L_64 = V_2;
		Transform_tA8193BB29D4D2C7EC04918F3ED1816345186C3F1 * L_65;
		L_65 = Component_get_transform_mE8496EBC45BEB1BADB5F314960F1DF1C952FA11F(__this, /*hidden argument*/NULL);
		Transform_tA8193BB29D4D2C7EC04918F3ED1816345186C3F1 * L_66 = __this->get_projectileSpawnPoint_9();
		NullCheck(L_66);
		Vector3_t65B972D6A585A0A5B63153CF1177A90D3C90D65E  L_67;
		L_67 = Transform_get_forward_mD850B9ECF892009E3485408DC0D375165B7BF053(L_66, /*hidden argument*/NULL);
		All1VfxDemoEffect_t66A278FEFF55B095702CEE911709440057966E75 * L_68 = __this->get_currDemoEffect_25();
		NullCheck(L_68);
		float L_69 = L_68->get_projectileSpeed_11();
		All1VfxDemoEffect_t66A278FEFF55B095702CEE911709440057966E75 * L_70 = __this->get_currDemoEffect_25();
		NullCheck(L_70);
		GameObject_tC000A2E1A7CF1E10FD7BA08863287C072207C319 * L_71 = L_70->get_impactPrefab_14();
		All1VfxDemoEffect_t66A278FEFF55B095702CEE911709440057966E75 * L_72 = __this->get_currDemoEffect_25();
		NullCheck(L_72);
		float L_73 = L_72->get_scaleMultiplier_19();
		NullCheck(L_64);
		AllIn1DemoProjectile_Initialize_m29AD8CA03A3D10AC02561210397C78477FFF618D(L_64, L_65, L_67, L_69, L_71, L_73, /*hidden argument*/NULL);
		// if(currDemoEffect.doCameraShake) tempProjectileInstance.AddScreenShakeOnImpact(currDemoEffect.projectileImpactShakeAmount);
		All1VfxDemoEffect_t66A278FEFF55B095702CEE911709440057966E75 * L_74 = __this->get_currDemoEffect_25();
		NullCheck(L_74);
		bool L_75 = L_74->get_doCameraShake_15();
		if (!L_75)
		{
			goto IL_02bb;
		}
	}
	{
		// if(currDemoEffect.doCameraShake) tempProjectileInstance.AddScreenShakeOnImpact(currDemoEffect.projectileImpactShakeAmount);
		AllIn1DemoProjectile_tA36F8B6BF3163732D0C981065AF301449C4AAE69 * L_76 = V_2;
		All1VfxDemoEffect_t66A278FEFF55B095702CEE911709440057966E75 * L_77 = __this->get_currDemoEffect_25();
		NullCheck(L_77);
		float L_78 = L_77->get_projectileImpactShakeAmount_17();
		NullCheck(L_76);
		AllIn1DemoProjectile_AddScreenShakeOnImpact_mA99E3BAE9DB9CDD1AE8B57B87816713C30A39A00(L_76, L_78, /*hidden argument*/NULL);
		// }
		goto IL_02bb;
	}

IL_01de:
	{
		// tempTransform = Instantiate(currDemoEffect.effectPrefab, transform).transform;
		All1VfxDemoEffect_t66A278FEFF55B095702CEE911709440057966E75 * L_79 = __this->get_currDemoEffect_25();
		NullCheck(L_79);
		GameObject_tC000A2E1A7CF1E10FD7BA08863287C072207C319 * L_80 = L_79->get_effectPrefab_9();
		Transform_tA8193BB29D4D2C7EC04918F3ED1816345186C3F1 * L_81;
		L_81 = Component_get_transform_mE8496EBC45BEB1BADB5F314960F1DF1C952FA11F(__this, /*hidden argument*/NULL);
		IL2CPP_RUNTIME_CLASS_INIT(Object_tF2F3778131EFF286AF62B7B013A170F95A91571A_il2cpp_TypeInfo_var);
		GameObject_tC000A2E1A7CF1E10FD7BA08863287C072207C319 * L_82;
		L_82 = Object_Instantiate_TisGameObject_tC000A2E1A7CF1E10FD7BA08863287C072207C319_mF131D53AB04E75E849487A7ACF79A8B27527F4B8(L_80, L_81, /*hidden argument*/Object_Instantiate_TisGameObject_tC000A2E1A7CF1E10FD7BA08863287C072207C319_mF131D53AB04E75E849487A7ACF79A8B27527F4B8_RuntimeMethod_var);
		NullCheck(L_82);
		Transform_tA8193BB29D4D2C7EC04918F3ED1816345186C3F1 * L_83;
		L_83 = GameObject_get_transform_m16A80BB92B6C8C5AB696E447014D45EDF1E4DE34(L_82, /*hidden argument*/NULL);
		V_0 = L_83;
		// if(!currDemoEffect.spawnTouchingFloor) tempTransform.localPosition = Vector3.zero;
		All1VfxDemoEffect_t66A278FEFF55B095702CEE911709440057966E75 * L_84 = __this->get_currDemoEffect_25();
		NullCheck(L_84);
		bool L_85 = L_84->get_spawnTouchingFloor_10();
		if (L_85)
		{
			goto IL_0214;
		}
	}
	{
		// if(!currDemoEffect.spawnTouchingFloor) tempTransform.localPosition = Vector3.zero;
		Transform_tA8193BB29D4D2C7EC04918F3ED1816345186C3F1 * L_86 = V_0;
		Vector3_t65B972D6A585A0A5B63153CF1177A90D3C90D65E  L_87;
		L_87 = Vector3_get_zero_m1A8F7993167785F750B6B01762D22C2597C84EF6(/*hidden argument*/NULL);
		NullCheck(L_86);
		Transform_set_localPosition_m2A2B0033EF079077FAE7C65196078EAF5D041AFC(L_86, L_87, /*hidden argument*/NULL);
		goto IL_0225;
	}

IL_0214:
	{
		// else tempTransform.position = groundSpawnTransform.position;
		Transform_tA8193BB29D4D2C7EC04918F3ED1816345186C3F1 * L_88 = V_0;
		Transform_tA8193BB29D4D2C7EC04918F3ED1816345186C3F1 * L_89 = __this->get_groundSpawnTransform_20();
		NullCheck(L_89);
		Vector3_t65B972D6A585A0A5B63153CF1177A90D3C90D65E  L_90;
		L_90 = Transform_get_position_m40A8A9895568D56FFC687B57F30E8D53CB5EA341(L_89, /*hidden argument*/NULL);
		NullCheck(L_88);
		Transform_set_position_mB169E52D57EEAC1E3F22C5395968714E4F00AC91(L_88, L_90, /*hidden argument*/NULL);
	}

IL_0225:
	{
		// tempTransform.localRotation = currDemoEffect.effectPrefab.transform.rotation;
		Transform_tA8193BB29D4D2C7EC04918F3ED1816345186C3F1 * L_91 = V_0;
		All1VfxDemoEffect_t66A278FEFF55B095702CEE911709440057966E75 * L_92 = __this->get_currDemoEffect_25();
		NullCheck(L_92);
		GameObject_tC000A2E1A7CF1E10FD7BA08863287C072207C319 * L_93 = L_92->get_effectPrefab_9();
		NullCheck(L_93);
		Transform_tA8193BB29D4D2C7EC04918F3ED1816345186C3F1 * L_94;
		L_94 = GameObject_get_transform_m16A80BB92B6C8C5AB696E447014D45EDF1E4DE34(L_93, /*hidden argument*/NULL);
		NullCheck(L_94);
		Quaternion_t6D28618CF65156D4A0AD747370DDFD0C514A31B4  L_95;
		L_95 = Transform_get_rotation_m4AA3858C00DF4C9614B80352558C4C37D08D2200(L_94, /*hidden argument*/NULL);
		NullCheck(L_91);
		Transform_set_localRotation_m1A9101457EC4653AFC93FCC4065A29F2C78FA62C(L_91, L_95, /*hidden argument*/NULL);
		// if(currDemoEffect.canBePlayedAgain && currDemoEffect.randomSpreadRadius > 0f && currentEffectPlays > 0)
		All1VfxDemoEffect_t66A278FEFF55B095702CEE911709440057966E75 * L_96 = __this->get_currDemoEffect_25();
		NullCheck(L_96);
		bool L_97 = L_96->get_canBePlayedAgain_5();
		if (!L_97)
		{
			goto IL_02bb;
		}
	}
	{
		All1VfxDemoEffect_t66A278FEFF55B095702CEE911709440057966E75 * L_98 = __this->get_currDemoEffect_25();
		NullCheck(L_98);
		float L_99 = L_98->get_randomSpreadRadius_6();
		if ((!(((float)L_99) > ((float)(0.0f)))))
		{
			goto IL_02bb;
		}
	}
	{
		int32_t L_100 = __this->get_currentEffectPlays_28();
		if ((((int32_t)L_100) <= ((int32_t)0)))
		{
			goto IL_02bb;
		}
	}
	{
		// tempTransform.position += new Vector3(Random.Range(-currDemoEffect.randomSpreadRadius, currDemoEffect.randomSpreadRadius), 0f,
		//     Random.Range(-currDemoEffect.randomSpreadRadius, currDemoEffect.randomSpreadRadius));
		Transform_tA8193BB29D4D2C7EC04918F3ED1816345186C3F1 * L_101 = V_0;
		Transform_tA8193BB29D4D2C7EC04918F3ED1816345186C3F1 * L_102 = L_101;
		NullCheck(L_102);
		Vector3_t65B972D6A585A0A5B63153CF1177A90D3C90D65E  L_103;
		L_103 = Transform_get_position_m40A8A9895568D56FFC687B57F30E8D53CB5EA341(L_102, /*hidden argument*/NULL);
		All1VfxDemoEffect_t66A278FEFF55B095702CEE911709440057966E75 * L_104 = __this->get_currDemoEffect_25();
		NullCheck(L_104);
		float L_105 = L_104->get_randomSpreadRadius_6();
		All1VfxDemoEffect_t66A278FEFF55B095702CEE911709440057966E75 * L_106 = __this->get_currDemoEffect_25();
		NullCheck(L_106);
		float L_107 = L_106->get_randomSpreadRadius_6();
		float L_108;
		L_108 = Random_Range_mC15372D42A9ABDCAC3DE82E114D60A40C9C311D2(((-L_105)), L_107, /*hidden argument*/NULL);
		All1VfxDemoEffect_t66A278FEFF55B095702CEE911709440057966E75 * L_109 = __this->get_currDemoEffect_25();
		NullCheck(L_109);
		float L_110 = L_109->get_randomSpreadRadius_6();
		All1VfxDemoEffect_t66A278FEFF55B095702CEE911709440057966E75 * L_111 = __this->get_currDemoEffect_25();
		NullCheck(L_111);
		float L_112 = L_111->get_randomSpreadRadius_6();
		float L_113;
		L_113 = Random_Range_mC15372D42A9ABDCAC3DE82E114D60A40C9C311D2(((-L_110)), L_112, /*hidden argument*/NULL);
		Vector3_t65B972D6A585A0A5B63153CF1177A90D3C90D65E  L_114;
		memset((&L_114), 0, sizeof(L_114));
		Vector3__ctor_m57495F692C6CE1CEF278CAD9A98221165D37E636_inline((&L_114), L_108, (0.0f), L_113, /*hidden argument*/NULL);
		Vector3_t65B972D6A585A0A5B63153CF1177A90D3C90D65E  L_115;
		L_115 = Vector3_op_Addition_mEE4F672B923CCB184C39AABCA33443DB218E50E0_inline(L_103, L_114, /*hidden argument*/NULL);
		NullCheck(L_102);
		Transform_set_position_mB169E52D57EEAC1E3F22C5395968714E4F00AC91(L_102, L_115, /*hidden argument*/NULL);
	}

IL_02bb:
	{
		// tempTransform.localScale *= currDemoEffect.scaleMultiplier;
		Transform_tA8193BB29D4D2C7EC04918F3ED1816345186C3F1 * L_116 = V_0;
		Transform_tA8193BB29D4D2C7EC04918F3ED1816345186C3F1 * L_117 = L_116;
		NullCheck(L_117);
		Vector3_t65B972D6A585A0A5B63153CF1177A90D3C90D65E  L_118;
		L_118 = Transform_get_localScale_mD9DF6CA81108C2A6002B5EA2BE25A6CD2723D046(L_117, /*hidden argument*/NULL);
		All1VfxDemoEffect_t66A278FEFF55B095702CEE911709440057966E75 * L_119 = __this->get_currDemoEffect_25();
		NullCheck(L_119);
		float L_120 = L_119->get_scaleMultiplier_19();
		Vector3_t65B972D6A585A0A5B63153CF1177A90D3C90D65E  L_121;
		L_121 = Vector3_op_Multiply_m9EA3D18290418D7B410C7D11C4788C13BFD2C30A_inline(L_118, L_120, /*hidden argument*/NULL);
		NullCheck(L_117);
		Transform_set_localScale_mF4D1611E48D1BA7566A1E166DC2DACF3ADD8BA3A(L_117, L_121, /*hidden argument*/NULL);
		// tempTransform.position += currDemoEffect.positionOffset;
		Transform_tA8193BB29D4D2C7EC04918F3ED1816345186C3F1 * L_122 = V_0;
		Transform_tA8193BB29D4D2C7EC04918F3ED1816345186C3F1 * L_123 = L_122;
		NullCheck(L_123);
		Vector3_t65B972D6A585A0A5B63153CF1177A90D3C90D65E  L_124;
		L_124 = Transform_get_position_m40A8A9895568D56FFC687B57F30E8D53CB5EA341(L_123, /*hidden argument*/NULL);
		All1VfxDemoEffect_t66A278FEFF55B095702CEE911709440057966E75 * L_125 = __this->get_currDemoEffect_25();
		NullCheck(L_125);
		Vector3_t65B972D6A585A0A5B63153CF1177A90D3C90D65E  L_126 = L_125->get_positionOffset_18();
		Vector3_t65B972D6A585A0A5B63153CF1177A90D3C90D65E  L_127;
		L_127 = Vector3_op_Addition_mEE4F672B923CCB184C39AABCA33443DB218E50E0_inline(L_124, L_126, /*hidden argument*/NULL);
		NullCheck(L_123);
		Transform_set_position_mB169E52D57EEAC1E3F22C5395968714E4F00AC91(L_123, L_127, /*hidden argument*/NULL);
		// if(!isAfterSetupAndInstantiateEffect && currDemoEffect.doCameraShake) AllIn1Shaker.i.DoCameraShake(currDemoEffect.mainEffectShakeAmount);
		bool L_128 = ___isAfterSetupAndInstantiateEffect0;
		if (L_128)
		{
			goto IL_0318;
		}
	}
	{
		All1VfxDemoEffect_t66A278FEFF55B095702CEE911709440057966E75 * L_129 = __this->get_currDemoEffect_25();
		NullCheck(L_129);
		bool L_130 = L_129->get_doCameraShake_15();
		if (!L_130)
		{
			goto IL_0318;
		}
	}
	{
		// if(!isAfterSetupAndInstantiateEffect && currDemoEffect.doCameraShake) AllIn1Shaker.i.DoCameraShake(currDemoEffect.mainEffectShakeAmount);
		AllIn1Shaker_t4540E312EAE72C5A4E5F184AFEC3099E91179295 * L_131 = ((AllIn1Shaker_t4540E312EAE72C5A4E5F184AFEC3099E91179295_StaticFields*)il2cpp_codegen_static_fields_for(AllIn1Shaker_t4540E312EAE72C5A4E5F184AFEC3099E91179295_il2cpp_TypeInfo_var))->get_i_9();
		All1VfxDemoEffect_t66A278FEFF55B095702CEE911709440057966E75 * L_132 = __this->get_currDemoEffect_25();
		NullCheck(L_132);
		float L_133 = L_132->get_mainEffectShakeAmount_16();
		NullCheck(L_131);
		AllIn1Shaker_DoCameraShake_m9B27491C1A4577C33D283B3CDD03BDCFC87E0AA2_inline(L_131, L_133, /*hidden argument*/NULL);
	}

IL_0318:
	{
		// currentEffectPlays++;
		int32_t L_134 = __this->get_currentEffectPlays_28();
		__this->set_currentEffectPlays_28(((int32_t)il2cpp_codegen_add((int32_t)L_134, (int32_t)1)));
		// }
		return;
	}
}
// System.Void AllIn1VfxToolkit.Demo.Scripts.AllIn1VfxDemoController::ChangeCurrentEffect(System.Int32)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void AllIn1VfxDemoController_ChangeCurrentEffect_m95CF6E65BB2B2454A3F15DCBC9D222E15D23D3C5 (AllIn1VfxDemoController_tDBA0E647E412D7CE6715A6976DB1E1A5722F6892 * __this, int32_t ___changeAmount0, const RuntimeMethod* method)
{
	{
		// if(changeAmount < 0) prevButtTween.ScaleUpTween();
		int32_t L_0 = ___changeAmount0;
		if ((((int32_t)L_0) >= ((int32_t)0)))
		{
			goto IL_0011;
		}
	}
	{
		// if(changeAmount < 0) prevButtTween.ScaleUpTween();
		AllIn1DemoScaleTween_t513A5592D7B99AAE00D3C297524793A01504CCD0 * L_1 = __this->get_prevButtTween_32();
		NullCheck(L_1);
		AllIn1DemoScaleTween_ScaleUpTween_m003B3BF936F501523FB03E83AA493B449CDF2D3F(L_1, /*hidden argument*/NULL);
		goto IL_0020;
	}

IL_0011:
	{
		// else if(changeAmount > 0) nextButtTween.ScaleUpTween();
		int32_t L_2 = ___changeAmount0;
		if ((((int32_t)L_2) <= ((int32_t)0)))
		{
			goto IL_0020;
		}
	}
	{
		// else if(changeAmount > 0) nextButtTween.ScaleUpTween();
		AllIn1DemoScaleTween_t513A5592D7B99AAE00D3C297524793A01504CCD0 * L_3 = __this->get_nextButtTween_31();
		NullCheck(L_3);
		AllIn1DemoScaleTween_ScaleUpTween_m003B3BF936F501523FB03E83AA493B449CDF2D3F(L_3, /*hidden argument*/NULL);
	}

IL_0020:
	{
		// StartCoroutine(CurrentEffectLabelTweenEffectCR());
		RuntimeObject* L_4;
		L_4 = AllIn1VfxDemoController_CurrentEffectLabelTweenEffectCR_mB5404E4C1AE89D1FE94871E9CDC0C4F0189BC9E5(__this, /*hidden argument*/NULL);
		Coroutine_t899D5232EF542CB8BA70AF9ECEECA494FAA9CCB7 * L_5;
		L_5 = MonoBehaviour_StartCoroutine_m3E33706D38B23CDD179E99BAD61E32303E9CC719(__this, L_4, /*hidden argument*/NULL);
		// currDemoEffectIndex += changeAmount;
		int32_t L_6 = __this->get_currDemoEffectIndex_27();
		int32_t L_7 = ___changeAmount0;
		__this->set_currDemoEffectIndex_27(((int32_t)il2cpp_codegen_add((int32_t)L_6, (int32_t)L_7)));
		// SetupAndInstantiateCurrentEffect();
		AllIn1VfxDemoController_SetupAndInstantiateCurrentEffect_mFFCD7DA958AB68D709C5B0328AD5FBE8416157AC(__this, /*hidden argument*/NULL);
		// allIn1TimeControl.CurrentEffectChanged();
		AllIn1TimeControl_tD27F0B4D919AD681DB84DE2277471ABFF29C38DC * L_8 = __this->get_allIn1TimeControl_34();
		NullCheck(L_8);
		AllIn1TimeControl_CurrentEffectChanged_m542665C5D595FAA5213CD7984D171A557ABFC6C8(L_8, /*hidden argument*/NULL);
		// }
		return;
	}
}
// System.Void AllIn1VfxToolkit.Demo.Scripts.AllIn1VfxDemoController::SetupAndInstantiateCurrentEffect()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void AllIn1VfxDemoController_SetupAndInstantiateCurrentEffect_mFFCD7DA958AB68D709C5B0328AD5FBE8416157AC (AllIn1VfxDemoController_tDBA0E647E412D7CE6715A6976DB1E1A5722F6892 * __this, const RuntimeMethod* method)
{
	Text_t6A2339DA6C05AE2646FC1A6C8FCC127391BE7FA1 * G_B2_0 = NULL;
	Text_t6A2339DA6C05AE2646FC1A6C8FCC127391BE7FA1 * G_B1_0 = NULL;
	String_t* G_B3_0 = NULL;
	Text_t6A2339DA6C05AE2646FC1A6C8FCC127391BE7FA1 * G_B3_1 = NULL;
	{
		// DestroyAllChildren();
		AllIn1VfxDemoController_DestroyAllChildren_mAD6FDC80DDC9B8DA3E39DC364065D4C06DD9373D(__this, /*hidden argument*/NULL);
		// currentEffectPlays = 0;
		__this->set_currentEffectPlays_28(0);
		// ComputeValidEffectAndCollectionIndex();
		AllIn1VfxDemoController_ComputeValidEffectAndCollectionIndex_m82A2A0050B50175B6B86231A7946C65BA1162AAF(__this, /*hidden argument*/NULL);
		// currDemoEffect = effectsToSpawnCollections[currDemoCollectionIndex].demoEffectCollection[currDemoEffectIndex];
		All1VfxDemoEffectCollectionU5BU5D_tA9660853E3FEE15A3B3F92BA64013878E31747FC* L_0 = __this->get_effectsToSpawnCollections_6();
		int32_t L_1 = __this->get_currDemoCollectionIndex_26();
		NullCheck(L_0);
		int32_t L_2 = L_1;
		All1VfxDemoEffectCollection_tE355DD3FC1A635D51B056A1524F452ACFC312C7E * L_3 = (L_0)->GetAt(static_cast<il2cpp_array_size_t>(L_2));
		NullCheck(L_3);
		All1VfxDemoEffectU5BU5D_tD3184435C9CE408F891FAB389BD269C827C7213F* L_4 = L_3->get_demoEffectCollection_4();
		int32_t L_5 = __this->get_currDemoEffectIndex_27();
		NullCheck(L_4);
		int32_t L_6 = L_5;
		All1VfxDemoEffect_t66A278FEFF55B095702CEE911709440057966E75 * L_7 = (L_4)->GetAt(static_cast<il2cpp_array_size_t>(L_6));
		__this->set_currDemoEffect_25(L_7);
		// projectileSceneSetupObject.SetActive(currDemoEffect.isShootProjectile);
		GameObject_tC000A2E1A7CF1E10FD7BA08863287C072207C319 * L_8 = __this->get_projectileSceneSetupObject_8();
		All1VfxDemoEffect_t66A278FEFF55B095702CEE911709440057966E75 * L_9 = __this->get_currDemoEffect_25();
		NullCheck(L_9);
		bool L_10 = L_9->get_isShootProjectile_8();
		NullCheck(L_8);
		GameObject_SetActive_mCF1EEF2A314F3AE85DA581FF52EB06ACEF2FFF86(L_8, L_10, /*hidden argument*/NULL);
		// projectileEffectUI.SetActive(currDemoEffect.isShootProjectile);
		GameObject_tC000A2E1A7CF1E10FD7BA08863287C072207C319 * L_11 = __this->get_projectileEffectUI_23();
		All1VfxDemoEffect_t66A278FEFF55B095702CEE911709440057966E75 * L_12 = __this->get_currDemoEffect_25();
		NullCheck(L_12);
		bool L_13 = L_12->get_isShootProjectile_8();
		NullCheck(L_11);
		GameObject_SetActive_mCF1EEF2A314F3AE85DA581FF52EB06ACEF2FFF86(L_11, L_13, /*hidden argument*/NULL);
		// normalEffectUI.SetActive(!currDemoEffect.isShootProjectile);
		GameObject_tC000A2E1A7CF1E10FD7BA08863287C072207C319 * L_14 = __this->get_normalEffectUI_24();
		All1VfxDemoEffect_t66A278FEFF55B095702CEE911709440057966E75 * L_15 = __this->get_currDemoEffect_25();
		NullCheck(L_15);
		bool L_16 = L_15->get_isShootProjectile_8();
		NullCheck(L_14);
		GameObject_SetActive_mCF1EEF2A314F3AE85DA581FF52EB06ACEF2FFF86(L_14, (bool)((((int32_t)L_16) == ((int32_t)0))? 1 : 0), /*hidden argument*/NULL);
		// currentEffectLabel.text = currDemoEffect.isShootProjectile ? currDemoEffect.projectilePrefab.name : currDemoEffect.effectPrefab.name;
		Text_t6A2339DA6C05AE2646FC1A6C8FCC127391BE7FA1 * L_17 = __this->get_currentEffectLabel_15();
		All1VfxDemoEffect_t66A278FEFF55B095702CEE911709440057966E75 * L_18 = __this->get_currDemoEffect_25();
		NullCheck(L_18);
		bool L_19 = L_18->get_isShootProjectile_8();
		G_B1_0 = L_17;
		if (L_19)
		{
			G_B2_0 = L_17;
			goto IL_009c;
		}
	}
	{
		All1VfxDemoEffect_t66A278FEFF55B095702CEE911709440057966E75 * L_20 = __this->get_currDemoEffect_25();
		NullCheck(L_20);
		GameObject_tC000A2E1A7CF1E10FD7BA08863287C072207C319 * L_21 = L_20->get_effectPrefab_9();
		NullCheck(L_21);
		String_t* L_22;
		L_22 = Object_get_name_m0C7BC870ED2F0DC5A2FB09628136CD7D1CB82CFB(L_21, /*hidden argument*/NULL);
		G_B3_0 = L_22;
		G_B3_1 = G_B1_0;
		goto IL_00ac;
	}

IL_009c:
	{
		All1VfxDemoEffect_t66A278FEFF55B095702CEE911709440057966E75 * L_23 = __this->get_currDemoEffect_25();
		NullCheck(L_23);
		GameObject_tC000A2E1A7CF1E10FD7BA08863287C072207C319 * L_24 = L_23->get_projectilePrefab_12();
		NullCheck(L_24);
		String_t* L_25;
		L_25 = Object_get_name_m0C7BC870ED2F0DC5A2FB09628136CD7D1CB82CFB(L_24, /*hidden argument*/NULL);
		G_B3_0 = L_25;
		G_B3_1 = G_B2_0;
	}

IL_00ac:
	{
		NullCheck(G_B3_1);
		VirtActionInvoker1< String_t* >::Invoke(75 /* System.Void UnityEngine.UI.Text::set_text(System.String) */, G_B3_1, G_B3_0);
		// playEffectButton.gameObject.SetActive(currDemoEffect.canBePlayedAgain);
		Button_tA893FC15AB26E1439AC25BDCA7079530587BB65D * L_26 = __this->get_playEffectButton_16();
		NullCheck(L_26);
		GameObject_tC000A2E1A7CF1E10FD7BA08863287C072207C319 * L_27;
		L_27 = Component_get_gameObject_m55DC35B149AFB9157582755383BA954655FE0C5B(L_26, /*hidden argument*/NULL);
		All1VfxDemoEffect_t66A278FEFF55B095702CEE911709440057966E75 * L_28 = __this->get_currDemoEffect_25();
		NullCheck(L_28);
		bool L_29 = L_28->get_canBePlayedAgain_5();
		NullCheck(L_27);
		GameObject_SetActive_mCF1EEF2A314F3AE85DA581FF52EB06ACEF2FFF86(L_27, L_29, /*hidden argument*/NULL);
		// playEffectInstructionsGo.SetActive(currDemoEffect.canBePlayedAgain);
		GameObject_tC000A2E1A7CF1E10FD7BA08863287C072207C319 * L_30 = __this->get_playEffectInstructionsGo_17();
		All1VfxDemoEffect_t66A278FEFF55B095702CEE911709440057966E75 * L_31 = __this->get_currDemoEffect_25();
		NullCheck(L_31);
		bool L_32 = L_31->get_canBePlayedAgain_5();
		NullCheck(L_30);
		GameObject_SetActive_mCF1EEF2A314F3AE85DA581FF52EB06ACEF2FFF86(L_30, L_32, /*hidden argument*/NULL);
		// PlayCurrentEffect(true);
		AllIn1VfxDemoController_PlayCurrentEffect_m12550E66ED360BD359AA42CC05C3BB622EC6BD6F(__this, (bool)1, /*hidden argument*/NULL);
		// }
		return;
	}
}
// System.Void AllIn1VfxToolkit.Demo.Scripts.AllIn1VfxDemoController::ComputeValidEffectAndCollectionIndex()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void AllIn1VfxDemoController_ComputeValidEffectAndCollectionIndex_m82A2A0050B50175B6B86231A7946C65BA1162AAF (AllIn1VfxDemoController_tDBA0E647E412D7CE6715A6976DB1E1A5722F6892 * __this, const RuntimeMethod* method)
{
	int32_t V_0 = 0;
	{
		// int demoEffectOperation = 0; // 0 means no operation, 1 means assign first collection effect, 2 means last collection effect
		V_0 = 0;
		// if(currDemoEffectIndex < 0)
		int32_t L_0 = __this->get_currDemoEffectIndex_27();
		if ((((int32_t)L_0) >= ((int32_t)0)))
		{
			goto IL_001d;
		}
	}
	{
		// currDemoCollectionIndex--;
		int32_t L_1 = __this->get_currDemoCollectionIndex_26();
		__this->set_currDemoCollectionIndex_26(((int32_t)il2cpp_codegen_subtract((int32_t)L_1, (int32_t)1)));
		// demoEffectOperation = 2;
		V_0 = 2;
		// }
		goto IL_0049;
	}

IL_001d:
	{
		// else if(currDemoEffectIndex >= effectsToSpawnCollections[currDemoCollectionIndex].demoEffectCollection.Length)
		int32_t L_2 = __this->get_currDemoEffectIndex_27();
		All1VfxDemoEffectCollectionU5BU5D_tA9660853E3FEE15A3B3F92BA64013878E31747FC* L_3 = __this->get_effectsToSpawnCollections_6();
		int32_t L_4 = __this->get_currDemoCollectionIndex_26();
		NullCheck(L_3);
		int32_t L_5 = L_4;
		All1VfxDemoEffectCollection_tE355DD3FC1A635D51B056A1524F452ACFC312C7E * L_6 = (L_3)->GetAt(static_cast<il2cpp_array_size_t>(L_5));
		NullCheck(L_6);
		All1VfxDemoEffectU5BU5D_tD3184435C9CE408F891FAB389BD269C827C7213F* L_7 = L_6->get_demoEffectCollection_4();
		NullCheck(L_7);
		if ((((int32_t)L_2) < ((int32_t)((int32_t)((int32_t)(((RuntimeArray*)L_7)->max_length))))))
		{
			goto IL_0049;
		}
	}
	{
		// currDemoCollectionIndex++;
		int32_t L_8 = __this->get_currDemoCollectionIndex_26();
		__this->set_currDemoCollectionIndex_26(((int32_t)il2cpp_codegen_add((int32_t)L_8, (int32_t)1)));
		// demoEffectOperation = 1;
		V_0 = 1;
	}

IL_0049:
	{
		// if(currDemoCollectionIndex < 0)
		int32_t L_9 = __this->get_currDemoCollectionIndex_26();
		if ((((int32_t)L_9) >= ((int32_t)0)))
		{
			goto IL_0066;
		}
	}
	{
		// currDemoCollectionIndex = effectsToSpawnCollections.Length - 1;
		All1VfxDemoEffectCollectionU5BU5D_tA9660853E3FEE15A3B3F92BA64013878E31747FC* L_10 = __this->get_effectsToSpawnCollections_6();
		NullCheck(L_10);
		__this->set_currDemoCollectionIndex_26(((int32_t)il2cpp_codegen_subtract((int32_t)((int32_t)((int32_t)(((RuntimeArray*)L_10)->max_length))), (int32_t)1)));
		// demoEffectOperation = 2;
		V_0 = 2;
		// }
		goto IL_007f;
	}

IL_0066:
	{
		// else if(currDemoCollectionIndex >= effectsToSpawnCollections.Length)
		int32_t L_11 = __this->get_currDemoCollectionIndex_26();
		All1VfxDemoEffectCollectionU5BU5D_tA9660853E3FEE15A3B3F92BA64013878E31747FC* L_12 = __this->get_effectsToSpawnCollections_6();
		NullCheck(L_12);
		if ((((int32_t)L_11) < ((int32_t)((int32_t)((int32_t)(((RuntimeArray*)L_12)->max_length))))))
		{
			goto IL_007f;
		}
	}
	{
		// currDemoCollectionIndex = 0;
		__this->set_currDemoCollectionIndex_26(0);
		// demoEffectOperation = 1;
		V_0 = 1;
	}

IL_007f:
	{
		// if(demoEffectOperation > 0)
		int32_t L_13 = V_0;
		if ((((int32_t)L_13) <= ((int32_t)0)))
		{
			goto IL_00af;
		}
	}
	{
		// if(demoEffectOperation == 1) currDemoEffectIndex = 0;
		int32_t L_14 = V_0;
		if ((!(((uint32_t)L_14) == ((uint32_t)1))))
		{
			goto IL_008f;
		}
	}
	{
		// if(demoEffectOperation == 1) currDemoEffectIndex = 0;
		__this->set_currDemoEffectIndex_27(0);
		return;
	}

IL_008f:
	{
		// else if(demoEffectOperation == 2) currDemoEffectIndex = effectsToSpawnCollections[currDemoCollectionIndex].demoEffectCollection.Length - 1;
		int32_t L_15 = V_0;
		if ((!(((uint32_t)L_15) == ((uint32_t)2))))
		{
			goto IL_00af;
		}
	}
	{
		// else if(demoEffectOperation == 2) currDemoEffectIndex = effectsToSpawnCollections[currDemoCollectionIndex].demoEffectCollection.Length - 1;
		All1VfxDemoEffectCollectionU5BU5D_tA9660853E3FEE15A3B3F92BA64013878E31747FC* L_16 = __this->get_effectsToSpawnCollections_6();
		int32_t L_17 = __this->get_currDemoCollectionIndex_26();
		NullCheck(L_16);
		int32_t L_18 = L_17;
		All1VfxDemoEffectCollection_tE355DD3FC1A635D51B056A1524F452ACFC312C7E * L_19 = (L_16)->GetAt(static_cast<il2cpp_array_size_t>(L_18));
		NullCheck(L_19);
		All1VfxDemoEffectU5BU5D_tD3184435C9CE408F891FAB389BD269C827C7213F* L_20 = L_19->get_demoEffectCollection_4();
		NullCheck(L_20);
		__this->set_currDemoEffectIndex_27(((int32_t)il2cpp_codegen_subtract((int32_t)((int32_t)((int32_t)(((RuntimeArray*)L_20)->max_length))), (int32_t)1)));
	}

IL_00af:
	{
		// }
		return;
	}
}
// System.Collections.IEnumerator AllIn1VfxToolkit.Demo.Scripts.AllIn1VfxDemoController::CurrentEffectLabelTweenEffectCR()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR RuntimeObject* AllIn1VfxDemoController_CurrentEffectLabelTweenEffectCR_mB5404E4C1AE89D1FE94871E9CDC0C4F0189BC9E5 (AllIn1VfxDemoController_tDBA0E647E412D7CE6715A6976DB1E1A5722F6892 * __this, const RuntimeMethod* method)
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&U3CCurrentEffectLabelTweenEffectCRU3Ed__38_t35025879B5382AE5E6D1D27E9F51C6920712C86D_il2cpp_TypeInfo_var);
		s_Il2CppMethodInitialized = true;
	}
	{
		U3CCurrentEffectLabelTweenEffectCRU3Ed__38_t35025879B5382AE5E6D1D27E9F51C6920712C86D * L_0 = (U3CCurrentEffectLabelTweenEffectCRU3Ed__38_t35025879B5382AE5E6D1D27E9F51C6920712C86D *)il2cpp_codegen_object_new(U3CCurrentEffectLabelTweenEffectCRU3Ed__38_t35025879B5382AE5E6D1D27E9F51C6920712C86D_il2cpp_TypeInfo_var);
		U3CCurrentEffectLabelTweenEffectCRU3Ed__38__ctor_m1B9000091C421AFD651FC198D57793EB6F85CF1B(L_0, 0, /*hidden argument*/NULL);
		U3CCurrentEffectLabelTweenEffectCRU3Ed__38_t35025879B5382AE5E6D1D27E9F51C6920712C86D * L_1 = L_0;
		NullCheck(L_1);
		L_1->set_U3CU3E4__this_2(__this);
		return L_1;
	}
}
// System.Void AllIn1VfxToolkit.Demo.Scripts.AllIn1VfxDemoController::DestroyAllChildren()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void AllIn1VfxDemoController_DestroyAllChildren_mAD6FDC80DDC9B8DA3E39DC364065D4C06DD9373D (AllIn1VfxDemoController_tDBA0E647E412D7CE6715A6976DB1E1A5722F6892 * __this, const RuntimeMethod* method)
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&IDisposable_t099785737FC6A1E3699919A94109383715A8D807_il2cpp_TypeInfo_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&IEnumerator_t5956F3AFB7ECF1117E3BC5890E7FC7B7F7A04105_il2cpp_TypeInfo_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Object_tF2F3778131EFF286AF62B7B013A170F95A91571A_il2cpp_TypeInfo_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Transform_tA8193BB29D4D2C7EC04918F3ED1816345186C3F1_il2cpp_TypeInfo_var);
		s_Il2CppMethodInitialized = true;
	}
	RuntimeObject* V_0 = NULL;
	RuntimeObject* V_1 = NULL;
	Exception_t * __last_unhandled_exception = 0;
	il2cpp::utils::ExceptionSupportStack<int32_t, 1> __leave_targets;
	{
		// foreach(Transform child in transform) Destroy(child.gameObject);
		Transform_tA8193BB29D4D2C7EC04918F3ED1816345186C3F1 * L_0;
		L_0 = Component_get_transform_mE8496EBC45BEB1BADB5F314960F1DF1C952FA11F(__this, /*hidden argument*/NULL);
		NullCheck(L_0);
		RuntimeObject* L_1;
		L_1 = Transform_GetEnumerator_mBA0E884A69F0AA05FCB69F4EE5F700177F75DD7E(L_0, /*hidden argument*/NULL);
		V_0 = L_1;
	}

IL_000c:
	try
	{ // begin try (depth: 1)
		{
			goto IL_0023;
		}

IL_000e:
		{
			// foreach(Transform child in transform) Destroy(child.gameObject);
			RuntimeObject* L_2 = V_0;
			NullCheck(L_2);
			RuntimeObject * L_3;
			L_3 = InterfaceFuncInvoker0< RuntimeObject * >::Invoke(1 /* System.Object System.Collections.IEnumerator::get_Current() */, IEnumerator_t5956F3AFB7ECF1117E3BC5890E7FC7B7F7A04105_il2cpp_TypeInfo_var, L_2);
			// foreach(Transform child in transform) Destroy(child.gameObject);
			NullCheck(((Transform_tA8193BB29D4D2C7EC04918F3ED1816345186C3F1 *)CastclassClass((RuntimeObject*)L_3, Transform_tA8193BB29D4D2C7EC04918F3ED1816345186C3F1_il2cpp_TypeInfo_var)));
			GameObject_tC000A2E1A7CF1E10FD7BA08863287C072207C319 * L_4;
			L_4 = Component_get_gameObject_m55DC35B149AFB9157582755383BA954655FE0C5B(((Transform_tA8193BB29D4D2C7EC04918F3ED1816345186C3F1 *)CastclassClass((RuntimeObject*)L_3, Transform_tA8193BB29D4D2C7EC04918F3ED1816345186C3F1_il2cpp_TypeInfo_var)), /*hidden argument*/NULL);
			IL2CPP_RUNTIME_CLASS_INIT(Object_tF2F3778131EFF286AF62B7B013A170F95A91571A_il2cpp_TypeInfo_var);
			Object_Destroy_m3EEDB6ECD49A541EC826EA8E1C8B599F7AF67D30(L_4, /*hidden argument*/NULL);
		}

IL_0023:
		{
			// foreach(Transform child in transform) Destroy(child.gameObject);
			RuntimeObject* L_5 = V_0;
			NullCheck(L_5);
			bool L_6;
			L_6 = InterfaceFuncInvoker0< bool >::Invoke(0 /* System.Boolean System.Collections.IEnumerator::MoveNext() */, IEnumerator_t5956F3AFB7ECF1117E3BC5890E7FC7B7F7A04105_il2cpp_TypeInfo_var, L_5);
			if (L_6)
			{
				goto IL_000e;
			}
		}

IL_002b:
		{
			IL2CPP_LEAVE(0x3E, FINALLY_002d);
		}
	} // end try (depth: 1)
	catch(Il2CppExceptionWrapper& e)
	{
		__last_unhandled_exception = (Exception_t *)e.ex;
		goto FINALLY_002d;
	}

FINALLY_002d:
	{ // begin finally (depth: 1)
		{
			RuntimeObject* L_7 = V_0;
			V_1 = ((RuntimeObject*)IsInst((RuntimeObject*)L_7, IDisposable_t099785737FC6A1E3699919A94109383715A8D807_il2cpp_TypeInfo_var));
			RuntimeObject* L_8 = V_1;
			if (!L_8)
			{
				goto IL_003d;
			}
		}

IL_0037:
		{
			RuntimeObject* L_9 = V_1;
			NullCheck(L_9);
			InterfaceActionInvoker0::Invoke(0 /* System.Void System.IDisposable::Dispose() */, IDisposable_t099785737FC6A1E3699919A94109383715A8D807_il2cpp_TypeInfo_var, L_9);
		}

IL_003d:
		{
			IL2CPP_END_FINALLY(45)
		}
	} // end finally (depth: 1)
	IL2CPP_CLEANUP(45)
	{
		IL2CPP_RETHROW_IF_UNHANDLED(Exception_t *)
		IL2CPP_JUMP_TBL(0x3E, IL_003e)
	}

IL_003e:
	{
		// }
		return;
	}
}
// System.Void AllIn1VfxToolkit.Demo.Scripts.AllIn1VfxDemoController::.ctor()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void AllIn1VfxDemoController__ctor_m314F96DED82777C8FBDDC4E4AA43FD3DA6AD82DF (AllIn1VfxDemoController_tDBA0E647E412D7CE6715A6976DB1E1A5722F6892 * __this, const RuntimeMethod* method)
{
	{
		// [SerializeField] private KeyCode playEffectKey = KeyCode.Q;
		__this->set_playEffectKey_10(((int32_t)113));
		// [SerializeField] private KeyCode nextEffectKey = KeyCode.RightArrow;
		__this->set_nextEffectKey_11(((int32_t)275));
		// [SerializeField] private KeyCode nextEffectKeyAlt = KeyCode.D;
		__this->set_nextEffectKeyAlt_12(((int32_t)100));
		// [SerializeField] private KeyCode previousEffectKey = KeyCode.LeftArrow;
		__this->set_previousEffectKey_13(((int32_t)276));
		// [SerializeField] private KeyCode previousEffectKeyAlt = KeyCode.A;
		__this->set_previousEffectKeyAlt_14(((int32_t)97));
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
// System.Void AllIn1VfxToolkit.Demo.Scripts.AllIn1VfxFadeLight::Start()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void AllIn1VfxFadeLight_Start_mDAB706F123CE5E1C8367A1DB9842ADFC8E05D1FF (AllIn1VfxFadeLight_t063DC487D234F37F3E1D51B46CE77FE9983E238C * __this, const RuntimeMethod* method)
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Component_GetComponent_TisLight_tA2F349FE839781469A0344CF6039B51512394275_m78431E28004B9C0FF3A712F157BFEDF8D42E36EA_RuntimeMethod_var);
		s_Il2CppMethodInitialized = true;
	}
	{
		// targetLight = GetComponent<Light>();
		Light_tA2F349FE839781469A0344CF6039B51512394275 * L_0;
		L_0 = Component_GetComponent_TisLight_tA2F349FE839781469A0344CF6039B51512394275_m78431E28004B9C0FF3A712F157BFEDF8D42E36EA(__this, /*hidden argument*/Component_GetComponent_TisLight_tA2F349FE839781469A0344CF6039B51512394275_m78431E28004B9C0FF3A712F157BFEDF8D42E36EA_RuntimeMethod_var);
		__this->set_targetLight_6(L_0);
		// iniLightIntensity = targetLight.intensity;
		Light_tA2F349FE839781469A0344CF6039B51512394275 * L_1 = __this->get_targetLight_6();
		NullCheck(L_1);
		float L_2;
		L_2 = Light_get_intensity_mFABC9E1EA23E954E1072233C33C2211D64262326(L_1, /*hidden argument*/NULL);
		__this->set_iniLightIntensity_8(L_2);
		// }
		return;
	}
}
// System.Void AllIn1VfxToolkit.Demo.Scripts.AllIn1VfxFadeLight::Update()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void AllIn1VfxFadeLight_Update_m90D0853FBF01CCFD71BBB9EA076394697271030F (AllIn1VfxFadeLight_t063DC487D234F37F3E1D51B46CE77FE9983E238C * __this, const RuntimeMethod* method)
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Object_tF2F3778131EFF286AF62B7B013A170F95A91571A_il2cpp_TypeInfo_var);
		s_Il2CppMethodInitialized = true;
	}
	{
		// targetLight.intensity = Mathf.Lerp(0f, iniLightIntensity, animationRatioRemaining);
		Light_tA2F349FE839781469A0344CF6039B51512394275 * L_0 = __this->get_targetLight_6();
		float L_1 = __this->get_iniLightIntensity_8();
		float L_2 = __this->get_animationRatioRemaining_7();
		float L_3;
		L_3 = Mathf_Lerp_m8A2A50B945F42D579EDF44D5EE79E85A4DA59616((0.0f), L_1, L_2, /*hidden argument*/NULL);
		NullCheck(L_0);
		Light_set_intensity_m372D5B9494809AFAD717B2707957DD1478C52DFC(L_0, L_3, /*hidden argument*/NULL);
		// animationRatioRemaining -= Time.deltaTime / fadeDuration;
		float L_4 = __this->get_animationRatioRemaining_7();
		float L_5;
		L_5 = Time_get_deltaTime_mCC15F147DA67F38C74CE408FB5D7FF4A87DA2290(/*hidden argument*/NULL);
		float L_6 = __this->get_fadeDuration_4();
		__this->set_animationRatioRemaining_7(((float)il2cpp_codegen_subtract((float)L_4, (float)((float)((float)L_5/(float)L_6)))));
		// if(destroyWhenFaded && animationRatioRemaining <= 0f) Destroy(gameObject);
		bool L_7 = __this->get_destroyWhenFaded_5();
		if (!L_7)
		{
			goto IL_005a;
		}
	}
	{
		float L_8 = __this->get_animationRatioRemaining_7();
		if ((!(((float)L_8) <= ((float)(0.0f)))))
		{
			goto IL_005a;
		}
	}
	{
		// if(destroyWhenFaded && animationRatioRemaining <= 0f) Destroy(gameObject);
		GameObject_tC000A2E1A7CF1E10FD7BA08863287C072207C319 * L_9;
		L_9 = Component_get_gameObject_m55DC35B149AFB9157582755383BA954655FE0C5B(__this, /*hidden argument*/NULL);
		IL2CPP_RUNTIME_CLASS_INIT(Object_tF2F3778131EFF286AF62B7B013A170F95A91571A_il2cpp_TypeInfo_var);
		Object_Destroy_m3EEDB6ECD49A541EC826EA8E1C8B599F7AF67D30(L_9, /*hidden argument*/NULL);
	}

IL_005a:
	{
		// }
		return;
	}
}
// System.Void AllIn1VfxToolkit.Demo.Scripts.AllIn1VfxFadeLight::.ctor()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void AllIn1VfxFadeLight__ctor_m240DA28F8151F6B5B3D52A6BC4E5CD628FCB37C2 (AllIn1VfxFadeLight_t063DC487D234F37F3E1D51B46CE77FE9983E238C * __this, const RuntimeMethod* method)
{
	{
		// [SerializeField] private float fadeDuration = 0.1f;
		__this->set_fadeDuration_4((0.100000001f));
		// [SerializeField] private bool destroyWhenFaded = true;
		__this->set_destroyWhenFaded_5((bool)1);
		// private float animationRatioRemaining = 1f;
		__this->set_animationRatioRemaining_7((1.0f));
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
// System.Void AllIn1VfxToolkit.Demo.Scripts.AllIn1VfxParticleSystemTime::Start()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void AllIn1VfxParticleSystemTime_Start_m029DF9262FAD5F94BA4DABA6D3AEF00FA49808E6 (AllIn1VfxParticleSystemTime_t1EE72855BC01A8A9547DB7A4C30287E1CDF7E9EF * __this, const RuntimeMethod* method)
{
	{
		// SetSimulationTime();
		AllIn1VfxParticleSystemTime_SetSimulationTime_mD07C485CA96C3C04CAB8389FFCBDE81E2B522268(__this, /*hidden argument*/NULL);
		// }
		return;
	}
}
// System.Void AllIn1VfxToolkit.Demo.Scripts.AllIn1VfxParticleSystemTime::Update()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void AllIn1VfxParticleSystemTime_Update_mBA4FAF17AAD26E848A4F97750B1C7B14A497E2A8 (AllIn1VfxParticleSystemTime_t1EE72855BC01A8A9547DB7A4C30287E1CDF7E9EF * __this, const RuntimeMethod* method)
{
	{
		// if(updateEveryFrame) SetSimulationTime();
		bool L_0 = __this->get_updateEveryFrame_4();
		if (!L_0)
		{
			goto IL_000e;
		}
	}
	{
		// if(updateEveryFrame) SetSimulationTime();
		AllIn1VfxParticleSystemTime_SetSimulationTime_mD07C485CA96C3C04CAB8389FFCBDE81E2B522268(__this, /*hidden argument*/NULL);
	}

IL_000e:
	{
		// }
		return;
	}
}
// System.Void AllIn1VfxToolkit.Demo.Scripts.AllIn1VfxParticleSystemTime::OnValidate()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void AllIn1VfxParticleSystemTime_OnValidate_m97DE678CE07E8D07D934013FB191EE05A4B4DE34 (AllIn1VfxParticleSystemTime_t1EE72855BC01A8A9547DB7A4C30287E1CDF7E9EF * __this, const RuntimeMethod* method)
{
	{
		// SetSimulationTime();
		AllIn1VfxParticleSystemTime_SetSimulationTime_mD07C485CA96C3C04CAB8389FFCBDE81E2B522268(__this, /*hidden argument*/NULL);
		// }
		return;
	}
}
// System.Void AllIn1VfxToolkit.Demo.Scripts.AllIn1VfxParticleSystemTime::SetSimulationTime()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void AllIn1VfxParticleSystemTime_SetSimulationTime_mD07C485CA96C3C04CAB8389FFCBDE81E2B522268 (AllIn1VfxParticleSystemTime_t1EE72855BC01A8A9547DB7A4C30287E1CDF7E9EF * __this, const RuntimeMethod* method)
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Component_GetComponent_TisParticleSystem_t2F526CCDBD3512879B3FCBE04BCAB20D7B4F391E_m91CE0171326B90198E69EAFA60F45473CAC6E0C3_RuntimeMethod_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Debug_tEB68BCBEB8EFD60F8043C67146DC05E7F50F374B_il2cpp_TypeInfo_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Object_tF2F3778131EFF286AF62B7B013A170F95A91571A_il2cpp_TypeInfo_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&_stringLiteral5FD7ACA76D20D20DB889E633C51EEB14ED85007F);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&_stringLiteralF5D8EF422ABD0284BA3EEB3BF58FBA9313575F4E);
		s_Il2CppMethodInitialized = true;
	}
	{
		// if(targetPs == null)
		ParticleSystem_t2F526CCDBD3512879B3FCBE04BCAB20D7B4F391E * L_0 = __this->get_targetPs_6();
		IL2CPP_RUNTIME_CLASS_INIT(Object_tF2F3778131EFF286AF62B7B013A170F95A91571A_il2cpp_TypeInfo_var);
		bool L_1;
		L_1 = Object_op_Equality_mEE9EC7EB5C7DC3E95B94AB904E1986FC4D566D54(L_0, (Object_tF2F3778131EFF286AF62B7B013A170F95A91571A *)NULL, /*hidden argument*/NULL);
		if (!L_1)
		{
			goto IL_0056;
		}
	}
	{
		// targetPs = GetComponent<ParticleSystem>();
		ParticleSystem_t2F526CCDBD3512879B3FCBE04BCAB20D7B4F391E * L_2;
		L_2 = Component_GetComponent_TisParticleSystem_t2F526CCDBD3512879B3FCBE04BCAB20D7B4F391E_m91CE0171326B90198E69EAFA60F45473CAC6E0C3(__this, /*hidden argument*/Component_GetComponent_TisParticleSystem_t2F526CCDBD3512879B3FCBE04BCAB20D7B4F391E_m91CE0171326B90198E69EAFA60F45473CAC6E0C3_RuntimeMethod_var);
		__this->set_targetPs_6(L_2);
		// if(targetPs == null && isValid)
		ParticleSystem_t2F526CCDBD3512879B3FCBE04BCAB20D7B4F391E * L_3 = __this->get_targetPs_6();
		IL2CPP_RUNTIME_CLASS_INIT(Object_tF2F3778131EFF286AF62B7B013A170F95A91571A_il2cpp_TypeInfo_var);
		bool L_4;
		L_4 = Object_op_Equality_mEE9EC7EB5C7DC3E95B94AB904E1986FC4D566D54(L_3, (Object_tF2F3778131EFF286AF62B7B013A170F95A91571A *)NULL, /*hidden argument*/NULL);
		if (!L_4)
		{
			goto IL_0056;
		}
	}
	{
		bool L_5 = __this->get_isValid_7();
		if (!L_5)
		{
			goto IL_0056;
		}
	}
	{
		// Debug.LogError("The object " + gameObject.name + " has no Particle System and you are trying to access it. Please take a look");
		GameObject_tC000A2E1A7CF1E10FD7BA08863287C072207C319 * L_6;
		L_6 = Component_get_gameObject_m55DC35B149AFB9157582755383BA954655FE0C5B(__this, /*hidden argument*/NULL);
		NullCheck(L_6);
		String_t* L_7;
		L_7 = Object_get_name_m0C7BC870ED2F0DC5A2FB09628136CD7D1CB82CFB(L_6, /*hidden argument*/NULL);
		String_t* L_8;
		L_8 = String_Concat_m89EAB4C6A96B0E5C3F87300D6BE78D386B9EFC44(_stringLiteralF5D8EF422ABD0284BA3EEB3BF58FBA9313575F4E, L_7, _stringLiteral5FD7ACA76D20D20DB889E633C51EEB14ED85007F, /*hidden argument*/NULL);
		IL2CPP_RUNTIME_CLASS_INIT(Debug_tEB68BCBEB8EFD60F8043C67146DC05E7F50F374B_il2cpp_TypeInfo_var);
		Debug_LogError_m8850D65592770A364D494025FF3A73E8D4D70485(L_8, /*hidden argument*/NULL);
		// isValid = false;
		__this->set_isValid_7((bool)0);
	}

IL_0056:
	{
		// if(!isValid) return;
		bool L_9 = __this->get_isValid_7();
		if (L_9)
		{
			goto IL_005f;
		}
	}
	{
		// if(!isValid) return;
		return;
	}

IL_005f:
	{
		// if(simulationTimeRange.y > 0f) targetPs.Simulate(Random.Range(simulationTimeRange.x, simulationTimeRange.y), true, true);
		Vector2_tBB32F2736AEC229A7BFBCE18197EC0F6AC7EC2D9 * L_10 = __this->get_address_of_simulationTimeRange_5();
		float L_11 = L_10->get_y_1();
		if ((!(((float)L_11) > ((float)(0.0f)))))
		{
			goto IL_009a;
		}
	}
	{
		// if(simulationTimeRange.y > 0f) targetPs.Simulate(Random.Range(simulationTimeRange.x, simulationTimeRange.y), true, true);
		ParticleSystem_t2F526CCDBD3512879B3FCBE04BCAB20D7B4F391E * L_12 = __this->get_targetPs_6();
		Vector2_tBB32F2736AEC229A7BFBCE18197EC0F6AC7EC2D9 * L_13 = __this->get_address_of_simulationTimeRange_5();
		float L_14 = L_13->get_x_0();
		Vector2_tBB32F2736AEC229A7BFBCE18197EC0F6AC7EC2D9 * L_15 = __this->get_address_of_simulationTimeRange_5();
		float L_16 = L_15->get_y_1();
		float L_17;
		L_17 = Random_Range_mC15372D42A9ABDCAC3DE82E114D60A40C9C311D2(L_14, L_16, /*hidden argument*/NULL);
		NullCheck(L_12);
		ParticleSystem_Simulate_mC2F2E060D7CE94D4936BA995C49827231DF5F1F8(L_12, L_17, (bool)1, (bool)1, /*hidden argument*/NULL);
		return;
	}

IL_009a:
	{
		// else targetPs.Simulate(simulationTimeRange.x, true, true);
		ParticleSystem_t2F526CCDBD3512879B3FCBE04BCAB20D7B4F391E * L_18 = __this->get_targetPs_6();
		Vector2_tBB32F2736AEC229A7BFBCE18197EC0F6AC7EC2D9 * L_19 = __this->get_address_of_simulationTimeRange_5();
		float L_20 = L_19->get_x_0();
		NullCheck(L_18);
		ParticleSystem_Simulate_mC2F2E060D7CE94D4936BA995C49827231DF5F1F8(L_18, L_20, (bool)1, (bool)1, /*hidden argument*/NULL);
		// }
		return;
	}
}
// System.Void AllIn1VfxToolkit.Demo.Scripts.AllIn1VfxParticleSystemTime::.ctor()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void AllIn1VfxParticleSystemTime__ctor_m1EDAC85519D145FF883B80258D726B926BDE163D (AllIn1VfxParticleSystemTime_t1EE72855BC01A8A9547DB7A4C30287E1CDF7E9EF * __this, const RuntimeMethod* method)
{
	{
		// [SerializeField] private bool updateEveryFrame = true;
		__this->set_updateEveryFrame_4((bool)1);
		// [SerializeField] private Vector2 simulationTimeRange = Vector2.zero;
		Vector2_tBB32F2736AEC229A7BFBCE18197EC0F6AC7EC2D9  L_0;
		L_0 = Vector2_get_zero_m621041B9DF5FAE86C1EF4CB28C224FEA089CB828(/*hidden argument*/NULL);
		__this->set_simulationTimeRange_5(L_0);
		// private bool isValid = true;
		__this->set_isValid_7((bool)1);
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
// System.Void AllIn1VfxToolkit.Demo.Scripts.AllIn1VfxDemoController/<CurrentEffectLabelTweenEffectCR>d__38::.ctor(System.Int32)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void U3CCurrentEffectLabelTweenEffectCRU3Ed__38__ctor_m1B9000091C421AFD651FC198D57793EB6F85CF1B (U3CCurrentEffectLabelTweenEffectCRU3Ed__38_t35025879B5382AE5E6D1D27E9F51C6920712C86D * __this, int32_t ___U3CU3E1__state0, const RuntimeMethod* method)
{
	{
		Object__ctor_m88880E0413421D13FD95325EDCE231707CE1F405(__this, /*hidden argument*/NULL);
		int32_t L_0 = ___U3CU3E1__state0;
		__this->set_U3CU3E1__state_0(L_0);
		return;
	}
}
// System.Void AllIn1VfxToolkit.Demo.Scripts.AllIn1VfxDemoController/<CurrentEffectLabelTweenEffectCR>d__38::System.IDisposable.Dispose()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void U3CCurrentEffectLabelTweenEffectCRU3Ed__38_System_IDisposable_Dispose_mEF6A08284B54F85D4F3C1A10A5423C0CDEB1B060 (U3CCurrentEffectLabelTweenEffectCRU3Ed__38_t35025879B5382AE5E6D1D27E9F51C6920712C86D * __this, const RuntimeMethod* method)
{
	{
		return;
	}
}
// System.Boolean AllIn1VfxToolkit.Demo.Scripts.AllIn1VfxDemoController/<CurrentEffectLabelTweenEffectCR>d__38::MoveNext()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR bool U3CCurrentEffectLabelTweenEffectCRU3Ed__38_MoveNext_m9C29D52E5B8F059BF9AAFD1010EAD6D8725E4454 (U3CCurrentEffectLabelTweenEffectCRU3Ed__38_t35025879B5382AE5E6D1D27E9F51C6920712C86D * __this, const RuntimeMethod* method)
{
	int32_t V_0 = 0;
	AllIn1VfxDemoController_tDBA0E647E412D7CE6715A6976DB1E1A5722F6892 * V_1 = NULL;
	{
		int32_t L_0 = __this->get_U3CU3E1__state_0();
		V_0 = L_0;
		AllIn1VfxDemoController_tDBA0E647E412D7CE6715A6976DB1E1A5722F6892 * L_1 = __this->get_U3CU3E4__this_2();
		V_1 = L_1;
		int32_t L_2 = V_0;
		if (!L_2)
		{
			goto IL_0017;
		}
	}
	{
		int32_t L_3 = V_0;
		if ((((int32_t)L_3) == ((int32_t)1)))
		{
			goto IL_0080;
		}
	}
	{
		return (bool)0;
	}

IL_0017:
	{
		__this->set_U3CU3E1__state_0((-1));
		// Color startColor = currentEffectLabel.color;
		AllIn1VfxDemoController_tDBA0E647E412D7CE6715A6976DB1E1A5722F6892 * L_4 = V_1;
		NullCheck(L_4);
		Text_t6A2339DA6C05AE2646FC1A6C8FCC127391BE7FA1 * L_5 = L_4->get_currentEffectLabel_15();
		NullCheck(L_5);
		Color_tF40DAF76C04FFECF3FE6024F85A294741C9CC659  L_6;
		L_6 = VirtFuncInvoker0< Color_tF40DAF76C04FFECF3FE6024F85A294741C9CC659  >::Invoke(22 /* UnityEngine.Color UnityEngine.UI.Graphic::get_color() */, L_5);
		__this->set_U3CstartColorU3E5__2_3(L_6);
		// currLabelTween.ScaleDownTween();
		AllIn1VfxDemoController_tDBA0E647E412D7CE6715A6976DB1E1A5722F6892 * L_7 = V_1;
		NullCheck(L_7);
		AllIn1DemoScaleTween_t513A5592D7B99AAE00D3C297524793A01504CCD0 * L_8 = L_7->get_currLabelTween_29();
		NullCheck(L_8);
		AllIn1DemoScaleTween_ScaleDownTween_m7D782A48F0D5A8096F6ABED9BE22B118A3DD0B4B(L_8, /*hidden argument*/NULL);
		// currentEffectLabel.color = new Color(startColor.r, startColor.g, startColor.b, 0f);
		AllIn1VfxDemoController_tDBA0E647E412D7CE6715A6976DB1E1A5722F6892 * L_9 = V_1;
		NullCheck(L_9);
		Text_t6A2339DA6C05AE2646FC1A6C8FCC127391BE7FA1 * L_10 = L_9->get_currentEffectLabel_15();
		Color_tF40DAF76C04FFECF3FE6024F85A294741C9CC659 * L_11 = __this->get_address_of_U3CstartColorU3E5__2_3();
		float L_12 = L_11->get_r_0();
		Color_tF40DAF76C04FFECF3FE6024F85A294741C9CC659 * L_13 = __this->get_address_of_U3CstartColorU3E5__2_3();
		float L_14 = L_13->get_g_1();
		Color_tF40DAF76C04FFECF3FE6024F85A294741C9CC659 * L_15 = __this->get_address_of_U3CstartColorU3E5__2_3();
		float L_16 = L_15->get_b_2();
		Color_tF40DAF76C04FFECF3FE6024F85A294741C9CC659  L_17;
		memset((&L_17), 0, sizeof(L_17));
		Color__ctor_m679019E6084BF7A6F82590F66F5F695F6A50ECC5((&L_17), L_12, L_14, L_16, (0.0f), /*hidden argument*/NULL);
		NullCheck(L_10);
		VirtActionInvoker1< Color_tF40DAF76C04FFECF3FE6024F85A294741C9CC659  >::Invoke(23 /* System.Void UnityEngine.UI.Graphic::set_color(UnityEngine.Color) */, L_10, L_17);
		// yield return null;
		__this->set_U3CU3E2__current_1(NULL);
		__this->set_U3CU3E1__state_0(1);
		return (bool)1;
	}

IL_0080:
	{
		__this->set_U3CU3E1__state_0((-1));
		// currentEffectLabel.color = new Color(startColor.r, startColor.g, startColor.b, 1f);
		AllIn1VfxDemoController_tDBA0E647E412D7CE6715A6976DB1E1A5722F6892 * L_18 = V_1;
		NullCheck(L_18);
		Text_t6A2339DA6C05AE2646FC1A6C8FCC127391BE7FA1 * L_19 = L_18->get_currentEffectLabel_15();
		Color_tF40DAF76C04FFECF3FE6024F85A294741C9CC659 * L_20 = __this->get_address_of_U3CstartColorU3E5__2_3();
		float L_21 = L_20->get_r_0();
		Color_tF40DAF76C04FFECF3FE6024F85A294741C9CC659 * L_22 = __this->get_address_of_U3CstartColorU3E5__2_3();
		float L_23 = L_22->get_g_1();
		Color_tF40DAF76C04FFECF3FE6024F85A294741C9CC659 * L_24 = __this->get_address_of_U3CstartColorU3E5__2_3();
		float L_25 = L_24->get_b_2();
		Color_tF40DAF76C04FFECF3FE6024F85A294741C9CC659  L_26;
		memset((&L_26), 0, sizeof(L_26));
		Color__ctor_m679019E6084BF7A6F82590F66F5F695F6A50ECC5((&L_26), L_21, L_23, L_25, (1.0f), /*hidden argument*/NULL);
		NullCheck(L_19);
		VirtActionInvoker1< Color_tF40DAF76C04FFECF3FE6024F85A294741C9CC659  >::Invoke(23 /* System.Void UnityEngine.UI.Graphic::set_color(UnityEngine.Color) */, L_19, L_26);
		// }
		return (bool)0;
	}
}
// System.Object AllIn1VfxToolkit.Demo.Scripts.AllIn1VfxDemoController/<CurrentEffectLabelTweenEffectCR>d__38::System.Collections.Generic.IEnumerator<System.Object>.get_Current()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR RuntimeObject * U3CCurrentEffectLabelTweenEffectCRU3Ed__38_System_Collections_Generic_IEnumeratorU3CSystem_ObjectU3E_get_Current_mA04704E89F3410D24DE48E28970FD1E225850C94 (U3CCurrentEffectLabelTweenEffectCRU3Ed__38_t35025879B5382AE5E6D1D27E9F51C6920712C86D * __this, const RuntimeMethod* method)
{
	{
		RuntimeObject * L_0 = __this->get_U3CU3E2__current_1();
		return L_0;
	}
}
// System.Void AllIn1VfxToolkit.Demo.Scripts.AllIn1VfxDemoController/<CurrentEffectLabelTweenEffectCR>d__38::System.Collections.IEnumerator.Reset()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void U3CCurrentEffectLabelTweenEffectCRU3Ed__38_System_Collections_IEnumerator_Reset_m8D9441A9D2421A712769A540219C18C2C05D7FC4 (U3CCurrentEffectLabelTweenEffectCRU3Ed__38_t35025879B5382AE5E6D1D27E9F51C6920712C86D * __this, const RuntimeMethod* method)
{
	{
		NotSupportedException_tB9D89F0E9470A2C423D239D7C68EE0CFD77F9339 * L_0 = (NotSupportedException_tB9D89F0E9470A2C423D239D7C68EE0CFD77F9339 *)il2cpp_codegen_object_new(((RuntimeClass*)il2cpp_codegen_initialize_runtime_metadata_inline((uintptr_t*)&NotSupportedException_tB9D89F0E9470A2C423D239D7C68EE0CFD77F9339_il2cpp_TypeInfo_var)));
		NotSupportedException__ctor_m3EA81A5B209A87C3ADA47443F2AFFF735E5256EE(L_0, /*hidden argument*/NULL);
		IL2CPP_RAISE_MANAGED_EXCEPTION(L_0, ((RuntimeMethod*)il2cpp_codegen_initialize_runtime_metadata_inline((uintptr_t*)&U3CCurrentEffectLabelTweenEffectCRU3Ed__38_System_Collections_IEnumerator_Reset_m8D9441A9D2421A712769A540219C18C2C05D7FC4_RuntimeMethod_var)));
	}
}
// System.Object AllIn1VfxToolkit.Demo.Scripts.AllIn1VfxDemoController/<CurrentEffectLabelTweenEffectCR>d__38::System.Collections.IEnumerator.get_Current()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR RuntimeObject * U3CCurrentEffectLabelTweenEffectCRU3Ed__38_System_Collections_IEnumerator_get_Current_m9046AB655FF01559591AB8921EC1EC518C4737FB (U3CCurrentEffectLabelTweenEffectCRU3Ed__38_t35025879B5382AE5E6D1D27E9F51C6920712C86D * __this, const RuntimeMethod* method)
{
	{
		RuntimeObject * L_0 = __this->get_U3CU3E2__current_1();
		return L_0;
	}
}
#ifdef __clang__
#pragma clang diagnostic pop
#endif
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR int32_t Dropdown_get_value_mFBF47E0C72050C5CB96B8B6D33F41BA2D1368F26_inline (Dropdown_t099F5232BB75810BC79EED6E27DDCED46C3BCD96 * __this, const RuntimeMethod* method)
{
	{
		// return m_Value;
		int32_t L_0 = __this->get_m_Value_25();
		return L_0;
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
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR void AllIn1Shaker_DoCameraShake_m9B27491C1A4577C33D283B3CDD03BDCFC87E0AA2_inline (AllIn1Shaker_t4540E312EAE72C5A4E5F184AFEC3099E91179295 * __this, float ___shakeAmount0, const RuntimeMethod* method)
{
	{
		// currentShakeAmount = shakeAmount;
		float L_0 = ___shakeAmount0;
		__this->set_currentShakeAmount_10(L_0);
		// }
		return;
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
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR SliderEvent_t312D89AE02E00DD965D68D6F7F813BDF455FD780 * Slider_get_onValueChanged_m7F480C569A6D668952BE1436691850D13825E129_inline (Slider_tBF39A11CC24CBD3F8BD728982ACAEAE43989B51A * __this, const RuntimeMethod* method)
{
	{
		// public SliderEvent onValueChanged { get { return m_OnValueChanged; } set { m_OnValueChanged = value; } }
		SliderEvent_t312D89AE02E00DD965D68D6F7F813BDF455FD780 * L_0 = __this->get_m_OnValueChanged_27();
		return L_0;
	}
}
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR Vector3_t65B972D6A585A0A5B63153CF1177A90D3C90D65E  Vector3_Lerp_m8E095584FFA10CF1D3EABCD04F4C83FB82EC5524_inline (Vector3_t65B972D6A585A0A5B63153CF1177A90D3C90D65E  ___a0, Vector3_t65B972D6A585A0A5B63153CF1177A90D3C90D65E  ___b1, float ___t2, const RuntimeMethod* method)
{
	Vector3_t65B972D6A585A0A5B63153CF1177A90D3C90D65E  V_0;
	memset((&V_0), 0, sizeof(V_0));
	{
		float L_0 = ___t2;
		float L_1;
		L_1 = Mathf_Clamp01_m2296D75F0F1292D5C8181C57007A1CA45F440C4C(L_0, /*hidden argument*/NULL);
		___t2 = L_1;
		Vector3_t65B972D6A585A0A5B63153CF1177A90D3C90D65E  L_2 = ___a0;
		float L_3 = L_2.get_x_2();
		Vector3_t65B972D6A585A0A5B63153CF1177A90D3C90D65E  L_4 = ___b1;
		float L_5 = L_4.get_x_2();
		Vector3_t65B972D6A585A0A5B63153CF1177A90D3C90D65E  L_6 = ___a0;
		float L_7 = L_6.get_x_2();
		float L_8 = ___t2;
		Vector3_t65B972D6A585A0A5B63153CF1177A90D3C90D65E  L_9 = ___a0;
		float L_10 = L_9.get_y_3();
		Vector3_t65B972D6A585A0A5B63153CF1177A90D3C90D65E  L_11 = ___b1;
		float L_12 = L_11.get_y_3();
		Vector3_t65B972D6A585A0A5B63153CF1177A90D3C90D65E  L_13 = ___a0;
		float L_14 = L_13.get_y_3();
		float L_15 = ___t2;
		Vector3_t65B972D6A585A0A5B63153CF1177A90D3C90D65E  L_16 = ___a0;
		float L_17 = L_16.get_z_4();
		Vector3_t65B972D6A585A0A5B63153CF1177A90D3C90D65E  L_18 = ___b1;
		float L_19 = L_18.get_z_4();
		Vector3_t65B972D6A585A0A5B63153CF1177A90D3C90D65E  L_20 = ___a0;
		float L_21 = L_20.get_z_4();
		float L_22 = ___t2;
		Vector3_t65B972D6A585A0A5B63153CF1177A90D3C90D65E  L_23;
		memset((&L_23), 0, sizeof(L_23));
		Vector3__ctor_m57495F692C6CE1CEF278CAD9A98221165D37E636_inline((&L_23), ((float)il2cpp_codegen_add((float)L_3, (float)((float)il2cpp_codegen_multiply((float)((float)il2cpp_codegen_subtract((float)L_5, (float)L_7)), (float)L_8)))), ((float)il2cpp_codegen_add((float)L_10, (float)((float)il2cpp_codegen_multiply((float)((float)il2cpp_codegen_subtract((float)L_12, (float)L_14)), (float)L_15)))), ((float)il2cpp_codegen_add((float)L_17, (float)((float)il2cpp_codegen_multiply((float)((float)il2cpp_codegen_subtract((float)L_19, (float)L_21)), (float)L_22)))), /*hidden argument*/NULL);
		V_0 = L_23;
		goto IL_0053;
	}

IL_0053:
	{
		Vector3_t65B972D6A585A0A5B63153CF1177A90D3C90D65E  L_24 = V_0;
		return L_24;
	}
}
