#include "pch-cpp.hpp"

#ifndef _MSC_VER
# include <alloca.h>
#else
# include <malloc.h>
#endif


#include <stdint.h>
#include <limits>


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
struct InterfaceActionInvoker0
{
	typedef void (*Action)(void*, const RuntimeMethod*);

	static inline void Invoke (Il2CppMethodSlot slot, RuntimeClass* declaringInterface, RuntimeObject* obj)
	{
		const VirtualInvokeData& invokeData = il2cpp_codegen_get_interface_invoke_data(slot, obj, declaringInterface);
		((Action)invokeData.methodPtr)(obj, invokeData.method);
	}
};

// System.Action`1<System.Runtime.InteropServices.WindowsRuntime.EventRegistrationToken>
struct Action_1_t91FC536003CAB9AB56B84E901AE08156372856E3;
// System.Dynamic.Utils.CacheDict`2<System.Type,System.Func`5<System.Linq.Expressions.Expression,System.String,System.Boolean,System.Collections.ObjectModel.ReadOnlyCollection`1<System.Linq.Expressions.ParameterExpression>,System.Linq.Expressions.LambdaExpression>>
struct CacheDict_2_t9FD97836EA998D29FFE492313652BD241E48F2C6;
// System.Dynamic.Utils.CacheDict`2<System.Type,System.Reflection.MethodInfo>
struct CacheDict_2_t23833FEB97C42D87EBF4B5FE3B56AA1336D7B3CE;
// System.Runtime.CompilerServices.ConditionalWeakTable`2<System.Linq.Expressions.Expression,System.Linq.Expressions.Expression/ExtensionInfo>
struct ConditionalWeakTable_2_t53315BD762B310982B9C8EEAA1BEB06E4E8D0815;
// System.Runtime.CompilerServices.ConditionalWeakTable`2<System.Object,System.Collections.Generic.Dictionary`2<System.Reflection.MethodInfo,System.Collections.Generic.Dictionary`2<System.Object,System.Runtime.InteropServices.WindowsRuntime.WindowsRuntimeMarshal/EventRegistrationTokenList>>>
struct ConditionalWeakTable_2_t15FB672E1FCD9A86D386950CA4AB07A87DFC64DC;
// System.Runtime.CompilerServices.ConditionalWeakTable`2<System.Object,System.Object>
struct ConditionalWeakTable_2_tCF100268EF76D0BC19F774221E488BBB4CD4B365;
// System.Runtime.CompilerServices.ConditionalWeakTable`2<System.Object,System.Runtime.InteropServices.WindowsRuntime.WindowsRuntimeMarshal/NativeOrStaticEventRegistrationImpl/EventRegistrationTokenListWithCount>
struct ConditionalWeakTable_2_tDE9E02FF583A5D6707A2CCEF9E15BD2791EA4229;
// System.Collections.Generic.Dictionary`2<System.Object,System.Object>
struct Dictionary_2_tBD1E3221EBD04CEBDA49B84779912E91F56B958D;
// System.Collections.Generic.Dictionary`2<System.Object,System.Runtime.InteropServices.WindowsRuntime.WindowsRuntimeMarshal/EventRegistrationTokenList>
struct Dictionary_2_t5BB631D653FC099355128DBC14DC44E27AD30739;
// System.Collections.Generic.Dictionary`2<System.Linq.Expressions.ParameterExpression,System.Int32>
struct Dictionary_2_t557635FBDBCB4F09E0827F01D69D76FF503D03A7;
// System.Collections.Generic.Dictionary`2<System.Linq.Expressions.ParameterExpression,System.Linq.Expressions.Interpreter.LocalVariable>
struct Dictionary_2_tAE9216CE6245A2FBEA94860E5D55598909B27352;
// System.Collections.Generic.Dictionary`2<System.Type,System.Object>
struct Dictionary_2_t1BCBBB8B077DB2EE009E3E0992AEAA34875A70FE;
// System.Collections.Generic.Dictionary`2<System.Xml.XmlQualifiedName,System.Runtime.Serialization.DataContract>
struct Dictionary_2_t4718820257735C3DF2901A055292922ED97E4759;
// System.Collections.Generic.Dictionary`2<System.Runtime.InteropServices.WindowsRuntime.WindowsRuntimeMarshal/NativeOrStaticEventRegistrationImpl/EventCacheKey,System.Runtime.InteropServices.WindowsRuntime.WindowsRuntimeMarshal/NativeOrStaticEventRegistrationImpl/EventCacheEntry>
struct Dictionary_2_t0986F9D82B8D09D448B013D5071D700FA1CF22C8;
// System.Linq.Expressions.Expression`1<System.Object>
struct Expression_1_t01B093F396848A065BE827B0C58E6F20E760FB6F;
// System.Dynamic.DynamicObject/MetaDynamic/Fallback`1<System.Object>
struct Fallback_1_t80F90982EFE3FFA9073E13C782ABA43FD48B7A9A;
// System.Func`2<System.Object,System.Runtime.InteropServices.WindowsRuntime.EventRegistrationToken>
struct Func_2_t5650431F2BFFD75382D3BA01D19E366CD1DA1813;
// System.Collections.Generic.HashSet`1<System.Object>
struct HashSet_1_t680119C7ED8D82AED56CDB83DF6F0E9149852A9B;
// System.Collections.Generic.HashSet`1<System.Linq.Expressions.ParameterExpression>
struct HashSet_1_t42A3AC337CA15FAC250AA5DA438F909806C72CB0;
// System.Collections.Generic.ICollection`1<System.Object>
struct ICollection_1_t35488BE070734B4C5D136DC1A68CBC9CE507D488;
// System.Collections.Generic.IEnumerable`1<System.Linq.Expressions.Expression>
struct IEnumerable_1_t947D2FEEDF3348F6F77C55E8712AD442E6A65F83;
// System.Collections.Generic.IEnumerable`1<System.Linq.Expressions.ParameterExpression>
struct IEnumerable_1_tF5978845C2912DCA5471ADD9480357E32BB03D1E;
// System.Collections.Generic.IEqualityComparer`1<System.Object>
struct IEqualityComparer_1_t1A386BEF1855064FD5CC71F340A68881A52B4932;
// System.Collections.Generic.IEqualityComparer`1<System.Linq.Expressions.ParameterExpression>
struct IEqualityComparer_1_t25F6568124205E1DCEEEFEF9FFD485B340114892;
// System.Collections.Generic.IList`1<System.Linq.Expressions.Expression>
struct IList_1_tBA929C89BC35AAE67764DAA82D62E01A200D3C7D;
// System.Collections.Generic.IList`1<System.Linq.Expressions.ParameterExpression>
struct IList_1_t577FCBB6A17E4D24559E5AD6C70155CFF0DFACAC;
// System.Collections.Generic.IList`1<System.Type>
struct IList_1_tDA1FACADA2EBD1F518087EF8A99C23BD8BE068DD;
// System.Collections.Generic.IReadOnlyList`1<System.Linq.Expressions.Expression>
struct IReadOnlyList_1_t3970E0723A7C2FEA094E64207358CF587FA8010F;
// System.Collections.Generic.Dictionary`2/KeyCollection<System.Object,System.Runtime.InteropServices.WindowsRuntime.WindowsRuntimeMarshal/EventRegistrationTokenList>
struct KeyCollection_t6F870BF5CEDDFEB13959730E1D35AF53F95D1153;
// System.Collections.Generic.List`1<System.Runtime.InteropServices.WindowsRuntime.EventRegistrationToken>
struct List_1_t01F23063BEF9E4FDEA5BD7414739DB35870B9ED9;
// System.Collections.Generic.List`1<System.Object>
struct List_1_t3F94120C77410A62EAE48421CF166B83AB95A2F5;
// System.Collections.Generic.List`1<System.Linq.Expressions.ParameterExpression>
struct List_1_tCDDF33E8793E2DD752E38CC326B13F8F35B1493B;
// System.Collections.ObjectModel.ReadOnlyCollection`1<System.Linq.Expressions.Expression>
struct ReadOnlyCollection_1_t7976DDE3F2FC7BAAF4F920193FF1B5BA33CCC2B5;
// System.Collections.ObjectModel.ReadOnlyCollection`1<System.Reflection.MemberInfo>
struct ReadOnlyCollection_1_t1BDA19F8C4CB4BE530A2234A21A1B2C9FB3B7991;
// System.Collections.ObjectModel.ReadOnlyCollection`1<System.Object>
struct ReadOnlyCollection_1_t921D1901AD35062BE31FAEB0798A4B814F33A3C3;
// System.Collections.Generic.Stack`1<System.Collections.Generic.HashSet`1<System.Linq.Expressions.ParameterExpression>>
struct Stack_1_t438C22E9DF33740A9BDB48CF9504B6E044484958;
// System.Collections.Generic.Stack`1<System.Object>
struct Stack_1_t92AC5F573A3C00899B24B775A71B4327D588E981;
// System.Runtime.CompilerServices.TrueReadOnlyCollection`1<System.Linq.Expressions.Expression>
struct TrueReadOnlyCollection_1_t06D7E0A73C830464D87F10A513072796E7172082;
// System.Runtime.CompilerServices.TrueReadOnlyCollection`1<System.Object>
struct TrueReadOnlyCollection_1_t7B0C79057B5BCC33C785557CBB2BEC37F5C2207A;
// System.Runtime.CompilerServices.TrueReadOnlyCollection`1<System.Linq.Expressions.ParameterExpression>
struct TrueReadOnlyCollection_1_tFACBB37A6A09F5303FA9A457A34FAFE7002020A3;
// System.Collections.Generic.Dictionary`2/ValueCollection<System.Object,System.Runtime.InteropServices.WindowsRuntime.WindowsRuntimeMarshal/EventRegistrationTokenList>
struct ValueCollection_tEA48E4B6DFB033F98ED189470457D6134F7C7AA9;
// System.Collections.Generic.Dictionary`2<System.Xml.XmlQualifiedName,System.Runtime.Serialization.DataContract>[]
struct Dictionary_2U5BU5D_t59E2DE680C0FE29F30EB1C2272A8899E85BD097E;
// System.Collections.Generic.Dictionary`2/Entry<System.Object,System.Runtime.InteropServices.WindowsRuntime.WindowsRuntimeMarshal/EventRegistrationTokenList>[]
struct EntryU5BU5D_t8D607320BF96B9AF7102AD17E8A0C7173DB1AF85;
// System.Collections.Generic.HashSet`1<System.Linq.Expressions.ParameterExpression>[]
struct HashSet_1U5BU5D_tE80AA7A58195958A441A5F7F80D36F0F00AD9275;
// System.Collections.Generic.HashSet`1/Slot<System.Linq.Expressions.ParameterExpression>[]
struct SlotU5BU5D_tAF315AD110D3AD4FBD91B25289AFC6FB963DC31E;
// System.Boolean[]
struct BooleanU5BU5D_tEC7BAF93C44F875016DAADC8696EE3A465644D3C;
// System.Byte[]
struct ByteU5BU5D_tDBBEB0E8362242FA7223000D978B0DD19D4B0726;
// System.Char[]
struct CharU5BU5D_t7B7FC5BC8091AA3B9CB0B29CDD80B5EE9254AA34;
// System.Delegate[]
struct DelegateU5BU5D_t677D8FE08A5F99E8EE49150B73966CD6E9BF7DB8;
// System.Double[]
struct DoubleU5BU5D_t8E1B42EB2ABB79FBD193A6B8C8D97A7CDE44A4FB;
// System.Dynamic.DynamicMetaObject[]
struct DynamicMetaObjectU5BU5D_t42D6D3818EB1DC2B3EAC2434CA3E7489874E0421;
// System.Runtime.CompilerServices.Ephemeron[]
struct EphemeronU5BU5D_tA2F880A59471B7642CA02323CD56295126FC28A8;
// System.Linq.Expressions.Expression[]
struct ExpressionU5BU5D_t4F1F138488EBD58837D142B40E0E4EEFC607EA63;
// System.Int16[]
struct Int16U5BU5D_tD134F1E6F746D4C09C987436805256C210C2FFCD;
// System.Int32[]
struct Int32U5BU5D_t70F1BDC14B1786481B176D6139A5E3B87DC54C32;
// System.Int64[]
struct Int64U5BU5D_tCA61E42872C63A4286B24EEE6E0650143B43DCE6;
// System.IntPtr[]
struct IntPtrU5BU5D_t27FC72B0409D75AAF33EC42498E8094E95FEE9A6;
// System.Object[]
struct ObjectU5BU5D_tC1F4EE0DB0B7300255F5FD4AF64FE4C585CF5ADE;
// System.Linq.Expressions.ParameterExpression[]
struct ParameterExpressionU5BU5D_tCF3EAA6D8556513C4937E1126F65AA08DF4DB147;
// System.SByte[]
struct SByteU5BU5D_t7D94C53295E6116625EA7CC7DEA21FEDC39869E7;
// System.Single[]
struct SingleU5BU5D_t47E8DBF5B597C122478D1FFBD9DD57399A0650FA;
// System.Diagnostics.StackTrace[]
struct StackTraceU5BU5D_t4AD999C288CB6D1F38A299D12B1598D606588971;
// System.TimeSpan[]
struct TimeSpanU5BU5D_t93A1470C8423F710E4D26493EE109A5A5920D545;
// System.Type[]
struct TypeU5BU5D_t85B10489E46F06CEC7C4B1CCBD0E01FAB6649755;
// System.UInt16[]
struct UInt16U5BU5D_t42D35C587B07DCDBCFDADF572C6D733AE85B2A67;
// System.UInt32[]
struct UInt32U5BU5D_tCF06F1E9E72E0302C762578FF5358CC523F2A2CF;
// System.UInt64[]
struct UInt64U5BU5D_t7C6E32D10F47677C1CEF3C30F4E4CE95B3A633E2;
// UnityEngine.AndroidJavaObject
struct AndroidJavaObject_t10188D5695DCD09C9F621B44B0A8C93A2281236E;
// System.AsyncCallback
struct AsyncCallback_tA7921BEF974919C46FF8F9D9867C567B200BB0EA;
// System.Runtime.Serialization.Attributes
struct Attributes_tD6437F2E6AA7A54A2FFBEC096DFF3139A3B294A7;
// System.Linq.Expressions.BinaryExpression
struct BinaryExpression_tCD79755962D104E6603B50D89E7F0E41D1D9CA79;
// System.Reflection.Binder
struct Binder_t2BEE27FD84737D1E79BC47FD67F6D3DD2F2DDA30;
// System.Dynamic.BindingRestrictions
struct BindingRestrictions_t03E14FA0517A70DEDA502032CE956595EF6E0DFC;
// System.Linq.Expressions.BlockExpression
struct BlockExpression_t429D310E740322594C18397DEAE7E17DCFE0E0BB;
// System.Linq.Expressions.ConditionalExpression
struct ConditionalExpression_t74C60793A382D6FC191C590A353984ED63ED3D4A;
// System.Linq.Expressions.ConstantExpression
struct ConstantExpression_tE22239C4AE815AF9B4647E026E802623F433F0FB;
// System.Reflection.ConstructorInfo
struct ConstructorInfo_t449AEC508DCA508EE46784C4F2716545488ACD5B;
// System.Runtime.Serialization.DataContract
struct DataContract_t2532937602A7512698085FE1EB691B9AEF058B15;
// System.Runtime.Serialization.DataContractResolver
struct DataContractResolver_t9AD484A6045B8B4A915E3790073DBA483ED529D4;
// System.Linq.Expressions.DefaultExpression
struct DefaultExpression_t3FC1DD4F4C518F7FDF62C04BB3BF78B10D654D46;
// System.Delegate
struct Delegate_t;
// System.DelegateData
struct DelegateData_t17DD30660E330C49381DAA99F934BE75CB11F288;
// System.Dynamic.DynamicMetaObject
struct DynamicMetaObject_t5279001ADBFAB6EF015CAC54937F4E9F003881C3;
// System.Dynamic.DynamicObject
struct DynamicObject_t97AD66D9AA9182AA4635DB778C9CE337E5E429D6;
// System.Threading.EventWaitHandle
struct EventWaitHandle_t80CDEB33529EF7549E7D3E3B689D8272B9F37F3C;
// System.Exception
struct Exception_t;
// System.Linq.Expressions.Expression
struct Expression_t30A004209C10C2D9A9785B2F74EEED431A4D4660;
// UnityEngine.GlobalJavaObjectRef
struct GlobalJavaObjectRef_t04A7D04EB0317C286F089E4DB4444EC4F2D78289;
// System.Runtime.Serialization.HybridObjectCache
struct HybridObjectCache_tB50855B7F76244247922DC330B5F4CC3527B40EE;
// System.IAsyncResult
struct IAsyncResult_tC9F97BF36FCF122D29D3101D80642278297BF370;
// System.Collections.IDictionary
struct IDictionary_t99871C56B8EC2452AC5C4CF3831695E617B89D3A;
// System.Xml.IXmlNamespaceResolver
struct IXmlNamespaceResolver_tE715F6572D858174C1BDCF0076B3C6415B226CD0;
// System.Linq.Expressions.Interpreter.InterpretedFrame
struct InterpretedFrame_tC7B57503A639148EB56B34F5464120D4B42627E2;
// System.Runtime.Serialization.KnownTypeDataContractResolver
struct KnownTypeDataContractResolver_t80FA21062F8A80958C85D372384F43DADB6EB0CC;
// System.Linq.Expressions.LabelTarget
struct LabelTarget_t4E0B75FE6DAD05FC6651E53032D2C5F19D8E81D1;
// System.Linq.Expressions.LambdaExpression
struct LambdaExpression_t26BF905E97E6D94F81F17D60F4F4F47F8E93B474;
// System.Reflection.MemberFilter
struct MemberFilter_t48D0AA10105D186AF42428FA532D4B4332CF8B81;
// System.Linq.Expressions.MethodCallExpression
struct MethodCallExpression_tF8E07995EEDB83A97C356206D651D5EEC72EFFA4;
// System.Reflection.MethodInfo
struct MethodInfo_t;
// System.Linq.Expressions.NewArrayExpression
struct NewArrayExpression_tE4702BA06AA0479BA675A5087BB6E2342F921F0A;
// System.Linq.Expressions.NewExpression
struct NewExpression_tCC2B6EAD4868381D56BB8B1AA4C5267F8A620987;
// System.Runtime.Serialization.ObjectToIdCache
struct ObjectToIdCache_t1968B045F0ECA41760C38CEE1F8B5B0BD8C78875;
// System.Linq.Expressions.ParameterExpression
struct ParameterExpression_tA7B24F1DE0F013DA4BD55F76DB43B06DB33D8BEE;
// System.Runtime.Serialization.SafeSerializationManager
struct SafeSerializationManager_tDE44F029589A028F8A3053C5C06153FAB4AAE29F;
// System.Runtime.Serialization.SerializationException
struct SerializationException_tDB38C13A2ABF407C381E3F332D197AC1AD097A92;
// System.Runtime.Serialization.SerializationInfo
struct SerializationInfo_t097DA64D9DB49ED7F2458E964BE8CCCF63FC67C1;
// System.String
struct String_t;
// System.Text.StringBuilder
struct StringBuilder_t;
// System.Type
struct Type_t;
// System.Linq.Expressions.TypeBinaryExpression
struct TypeBinaryExpression_t802702BB83CA4CE99BAE599EAD7D58FDF8C32185;
// System.Linq.Expressions.UnaryExpression
struct UnaryExpression_t5DE6F6FA2216CDD34DFCFADEB0080CB29326DD62;
// System.Void
struct Void_t700C6383A2A510C2CF4DD86DABD5CA9FF70ADAC5;
// System.Xml.XmlDictionaryWriter
struct XmlDictionaryWriter_t7DBB53A3CB2D175E2753690C4032D28AD7B23B83;
// System.Xml.XmlDocument
struct XmlDocument_t513899C58F800C43E8D78C0B72BD18C2C036233F;
// System.Xml.Schema.XmlListConverter
struct XmlListConverter_t58F692567B1B34BF5171B647F1BE66EC017D4F4D;
// System.Runtime.Serialization.XmlObjectSerializer
struct XmlObjectSerializer_t079CA08E29281806E298EA39F279546B75A0011E;
// System.Runtime.Serialization.XmlObjectSerializerWriteContext
struct XmlObjectSerializerWriteContext_t0DDF2A2D70F1E6DDBC86B5E9E3DBA5D577889AE9;
// System.Runtime.Serialization.XmlReaderDelegator
struct XmlReaderDelegator_t5BFA29001B28A7C4E173E867DDB27CE3CC875C17;
// System.Xml.Schema.XmlSchemaType
struct XmlSchemaType_t390DB79F0EB746B12C400BD1897CDB9F3557FCBA;
// System.Runtime.Serialization.XmlSerializableReader
struct XmlSerializableReader_t4E181C3106AB58D899A19A210CEAB97005666D95;
// System.Runtime.Serialization.XmlSerializableWriter
struct XmlSerializableWriter_t53FF8DF35B374ECA932A56FCAE3E4D87781B4C54;
// System.Xml.Schema.XmlValueConverter
struct XmlValueConverter_t18B2DCDB3B3F7609F3E43D5C46D2095BD09E6763;
// System.Xml.XmlWriter
struct XmlWriter_t676293C138D2D0DAB9C1BC16A7BEE618391C5B2D;
// System.Runtime.Serialization.XmlWriterDelegator
struct XmlWriterDelegator_t14F933DC94CDCA5AA29C259565A8C4C0E41613BC;
// System.Dynamic.DynamicObject/MetaDynamic
struct MetaDynamic_t774AF4A12F33149209C1FA08022AB0EE951BFB7C;
// System.Linq.Expressions.Interpreter.LightCompiler/QuoteVisitor
struct QuoteVisitor_tFE404B4C826642C3FC245A108AEC9E94D691E627;
// System.Linq.Expressions.Interpreter.QuoteInstruction/ExpressionQuoter
struct ExpressionQuoter_t174D328A07E522775BA6B19ADF09DBEAF13098FE;
// System.Runtime.InteropServices.WindowsRuntime.WindowsRuntimeMarshal/NativeOrStaticEventRegistrationImpl/EventRegistrationTokenListWithCount
struct EventRegistrationTokenListWithCount_t8BA708F75B90C86A7CA1F3FD1DFCBD742D458FC6;
// System.Runtime.InteropServices.WindowsRuntime.WindowsRuntimeMarshal/NativeOrStaticEventRegistrationImpl/MyReaderWriterLock
struct MyReaderWriterLock_t0EAF7040A5BCE7C816030732D088A8DB81FB97AD;
// System.Runtime.InteropServices.WindowsRuntime.WindowsRuntimeMarshal/NativeOrStaticEventRegistrationImpl/TokenListCount
struct TokenListCount_t769EA62356D8C37857DCC81DB79A76FA75E319AC;

IL2CPP_EXTERN_C RuntimeClass* AndroidJavaObjectU5BU5D_tEE28563C9013906CEB39794019A55F4BA5B06120_il2cpp_TypeInfo_var;
IL2CPP_EXTERN_C RuntimeClass* AndroidJavaObject_t10188D5695DCD09C9F621B44B0A8C93A2281236E_il2cpp_TypeInfo_var;
IL2CPP_EXTERN_C RuntimeClass* AndroidReflection_tEB6633FD5B7D2816E1AC6C711E11B2DD33822F16_il2cpp_TypeInfo_var;
IL2CPP_EXTERN_C RuntimeClass* BindingRestrictions_t03E14FA0517A70DEDA502032CE956595EF6E0DFC_il2cpp_TypeInfo_var;
IL2CPP_EXTERN_C RuntimeClass* Debug_tEB68BCBEB8EFD60F8043C67146DC05E7F50F374B_il2cpp_TypeInfo_var;
IL2CPP_EXTERN_C RuntimeClass* DynamicMetaObject_t5279001ADBFAB6EF015CAC54937F4E9F003881C3_il2cpp_TypeInfo_var;
IL2CPP_EXTERN_C RuntimeClass* EventRegistrationTokenListWithCount_t8BA708F75B90C86A7CA1F3FD1DFCBD742D458FC6_il2cpp_TypeInfo_var;
IL2CPP_EXTERN_C RuntimeClass* Exception_t_il2cpp_TypeInfo_var;
IL2CPP_EXTERN_C RuntimeClass* ExpressionU5BU5D_t4F1F138488EBD58837D142B40E0E4EEFC607EA63_il2cpp_TypeInfo_var;
IL2CPP_EXTERN_C RuntimeClass* Expression_t30A004209C10C2D9A9785B2F74EEED431A4D4660_il2cpp_TypeInfo_var;
IL2CPP_EXTERN_C RuntimeClass* HashSet_1_t42A3AC337CA15FAC250AA5DA438F909806C72CB0_il2cpp_TypeInfo_var;
IL2CPP_EXTERN_C RuntimeClass* ICollection_tC1E1DED86C0A66845675392606B302452210D5DA_il2cpp_TypeInfo_var;
IL2CPP_EXTERN_C RuntimeClass* IDisposable_t099785737FC6A1E3699919A94109383715A8D807_il2cpp_TypeInfo_var;
IL2CPP_EXTERN_C RuntimeClass* IEnumerable_t47A618747A1BB2A868710316F7372094849163A2_il2cpp_TypeInfo_var;
IL2CPP_EXTERN_C RuntimeClass* IEnumerator_t5956F3AFB7ECF1117E3BC5890E7FC7B7F7A04105_il2cpp_TypeInfo_var;
IL2CPP_EXTERN_C RuntimeClass* IList_tB15A9D6625D09661D6E47976BB626C703EC81910_il2cpp_TypeInfo_var;
IL2CPP_EXTERN_C RuntimeClass* Int32_tFDE5F8CD43D10453F6A2E0C77FE48C6CC7009046_il2cpp_TypeInfo_var;
IL2CPP_EXTERN_C RuntimeClass* List_1_tCDDF33E8793E2DD752E38CC326B13F8F35B1493B_il2cpp_TypeInfo_var;
IL2CPP_EXTERN_C RuntimeClass* ManagedEventRegistrationImpl_t68BCFDC6DFC89A0F8CF53836672DD1F41C47CEEB_il2cpp_TypeInfo_var;
IL2CPP_EXTERN_C RuntimeClass* MetaDynamic_t774AF4A12F33149209C1FA08022AB0EE951BFB7C_il2cpp_TypeInfo_var;
IL2CPP_EXTERN_C RuntimeClass* NativeOrStaticEventRegistrationImpl_tCA81B1033AD6FCE9E03C1E043758D4A1815B90E4_il2cpp_TypeInfo_var;
IL2CPP_EXTERN_C RuntimeClass* ObjectU5BU5D_tC1F4EE0DB0B7300255F5FD4AF64FE4C585CF5ADE_il2cpp_TypeInfo_var;
IL2CPP_EXTERN_C RuntimeClass* ParameterExpressionU5BU5D_tCF3EAA6D8556513C4937E1126F65AA08DF4DB147_il2cpp_TypeInfo_var;
IL2CPP_EXTERN_C RuntimeClass* StringBuilder_t_il2cpp_TypeInfo_var;
IL2CPP_EXTERN_C RuntimeClass* StringU5BU5D_tACEBFEDE350025B554CD507C9AE8FFE49359549A_il2cpp_TypeInfo_var;
IL2CPP_EXTERN_C RuntimeClass* TrueReadOnlyCollection_1_t06D7E0A73C830464D87F10A513072796E7172082_il2cpp_TypeInfo_var;
IL2CPP_EXTERN_C RuntimeClass* TrueReadOnlyCollection_1_tFACBB37A6A09F5303FA9A457A34FAFE7002020A3_il2cpp_TypeInfo_var;
IL2CPP_EXTERN_C RuntimeClass* Type_t_il2cpp_TypeInfo_var;
IL2CPP_EXTERN_C RuntimeClass* Utils_t98C8733198C84566DF6847E887A57D45326CE485_il2cpp_TypeInfo_var;
IL2CPP_EXTERN_C String_t* _stringLiteral23114468D04FA2B7A2DA455B545DB914D0A3ED94;
IL2CPP_EXTERN_C String_t* _stringLiteral24CC8D396132365E532646F936DFC8579E2299B2;
IL2CPP_EXTERN_C String_t* _stringLiteral42646B33B50B6AA15E22733C8900716F0FE19E1D;
IL2CPP_EXTERN_C String_t* _stringLiteral51253131B895C2F8066BCC47E62D44F18F43446C;
IL2CPP_EXTERN_C String_t* _stringLiteral5BEFD8CC60A79699B5BB00E37BAC5B62D371E174;
IL2CPP_EXTERN_C String_t* _stringLiteral94ADECE30C954CD6685EE98984452C698987E415;
IL2CPP_EXTERN_C const RuntimeMethod* Action_1_Invoke_m0670A1DF770A18B2D457A2B700EEF92B463652DA_RuntimeMethod_var;
IL2CPP_EXTERN_C const RuntimeMethod* Array_Empty_TisParameterExpression_tA7B24F1DE0F013DA4BD55F76DB43B06DB33D8BEE_m8FAF2226E6288860C1D3C92AB793820D17F32D71_RuntimeMethod_var;
IL2CPP_EXTERN_C const RuntimeMethod* ConditionalWeakTable_2_Add_mF73DB702E1356B2CC2F9C09D3443987A75954088_RuntimeMethod_var;
IL2CPP_EXTERN_C const RuntimeMethod* ConditionalWeakTable_2_FindEquivalentKeyUnsafe_mC28129CC24B2F2D4CACEEC954DB5F99E4EEE0713_RuntimeMethod_var;
IL2CPP_EXTERN_C const RuntimeMethod* ConditionalWeakTable_2_Remove_mF1535859D88E215E79053D8935FCE7DF3F2D7124_RuntimeMethod_var;
IL2CPP_EXTERN_C const RuntimeMethod* Dictionary_2_Remove_mF26A9D605B336E64E00D3E9B1A2B24D23F440D1C_RuntimeMethod_var;
IL2CPP_EXTERN_C const RuntimeMethod* Dictionary_2_TryGetValue_mF842EC8D110A281144B0082DE75F29AE5261F24F_RuntimeMethod_var;
IL2CPP_EXTERN_C const RuntimeMethod* Dictionary_2_set_Item_mC31C547D1D8807C284FEE2E67821F99533C54EB7_RuntimeMethod_var;
IL2CPP_EXTERN_C const RuntimeMethod* HashSet_1_Add_m97A1CDFD6C8F09EC6D4C676F183FBAF06EC20CDE_RuntimeMethod_var;
IL2CPP_EXTERN_C const RuntimeMethod* HashSet_1__ctor_m7E015D0E7832B3967403CAEE703C819D77AE741B_RuntimeMethod_var;
IL2CPP_EXTERN_C const RuntimeMethod* List_1_Add_mC5D74D70A6B9B4BC082AEB0EC771879B842C7708_RuntimeMethod_var;
IL2CPP_EXTERN_C const RuntimeMethod* List_1__ctor_mE4C9B3F15E5D5168479F4E7227A000B97C871A30_RuntimeMethod_var;
IL2CPP_EXTERN_C const RuntimeMethod* NativeOrStaticEventRegistrationImpl_AddEventHandler_TisRuntimeObject_m8E5074116B1AE98ECF1E3CF6F7FF8040E6221BE2_RuntimeMethod_var;
IL2CPP_EXTERN_C const RuntimeMethod* ReadOnlyCollection_1_get_Item_m61B304E87F7A24CB20EA9565FBC66CB9118FE6D1_RuntimeMethod_var;
IL2CPP_EXTERN_C const RuntimeMethod* Stack_1_Pop_mE1B2B7343AEB424CD56DCD92DE34D64249A26769_RuntimeMethod_var;
IL2CPP_EXTERN_C const RuntimeMethod* Stack_1_Push_m97F7795161150F81DB993EFB230CD48A2B2A369C_RuntimeMethod_var;
IL2CPP_EXTERN_C const RuntimeMethod* TrueReadOnlyCollection_1__ctor_m69554AD79082CEEEE9808387797E4A9C052A1820_RuntimeMethod_var;
IL2CPP_EXTERN_C const RuntimeMethod* TrueReadOnlyCollection_1__ctor_mF8FDD857140C35B895099B7D89BFFE4153D771B5_RuntimeMethod_var;
IL2CPP_EXTERN_C const RuntimeMethod* XmlObjectSerializerReadContext_EnsureArraySize_TisRuntimeObject_mD59ABE364D023B96A4D85AB81673B9F2C62C8C30_RuntimeMethod_var;
IL2CPP_EXTERN_C const RuntimeMethod* _AndroidJNIHelper_ConvertFromJNIArray_TisBoolean_t07D1E3F34E4813023D64F584DFF7B34C9D922F37_m20E7EDFF477647AD2AAEA5C01F2F96F086673299_RuntimeMethod_var;
IL2CPP_EXTERN_C const RuntimeMethod* _AndroidJNIHelper_ConvertFromJNIArray_TisChar_tFF60D8E7E89A20BE2294A003734341BD1DF43E14_mF3A18A8F874B12CB2B14263BF4574ABB14FBCF1E_RuntimeMethod_var;
IL2CPP_EXTERN_C const RuntimeMethod* _AndroidJNIHelper_ConvertFromJNIArray_TisDouble_t42821932CB52DE2057E685D0E1AF3DE5033D2181_m5DFA0BED6B580096B2E3ADB1394F918653E21D07_RuntimeMethod_var;
IL2CPP_EXTERN_C const RuntimeMethod* _AndroidJNIHelper_ConvertFromJNIArray_TisInt16_tD0F031114106263BB459DA1F099FF9F42691295A_m8139D52A1384EE34677345013798688D522DFF37_RuntimeMethod_var;
IL2CPP_EXTERN_C const RuntimeMethod* _AndroidJNIHelper_ConvertFromJNIArray_TisInt32_tFDE5F8CD43D10453F6A2E0C77FE48C6CC7009046_m46E475527292788C29DD62A991E948CE3D9189A3_RuntimeMethod_var;
IL2CPP_EXTERN_C const RuntimeMethod* _AndroidJNIHelper_ConvertFromJNIArray_TisInt64_t378EE0D608BD3107E77238E85F30D2BBD46981F3_m67885FB92D65381C9570857BCD66D9A5377C9FC2_RuntimeMethod_var;
IL2CPP_EXTERN_C const RuntimeMethod* _AndroidJNIHelper_ConvertFromJNIArray_TisRuntimeObject_m353E485413995A0C209B6FAA96D368CF72FB4592_RuntimeMethod_var;
IL2CPP_EXTERN_C const RuntimeMethod* _AndroidJNIHelper_ConvertFromJNIArray_TisSByte_t928712DD662DC29BA4FAAE8CE2230AFB23447F0B_m2F4CBB579C50AAAF7EF6FBC73C5FC304A87A60EE_RuntimeMethod_var;
IL2CPP_EXTERN_C const RuntimeMethod* _AndroidJNIHelper_ConvertFromJNIArray_TisSingle_tE07797BA3C98D4CA9B5A19413C19A76688AB899E_mD3EDB3217478F469F150970E33043F80EF1BA3CB_RuntimeMethod_var;
IL2CPP_EXTERN_C const RuntimeType* AndroidJavaObject_t10188D5695DCD09C9F621B44B0A8C93A2281236E_0_0_0_var;
IL2CPP_EXTERN_C const RuntimeType* Boolean_t07D1E3F34E4813023D64F584DFF7B34C9D922F37_0_0_0_var;
IL2CPP_EXTERN_C const RuntimeType* Byte_t0111FAB8B8685667EDDAF77683F0D8F86B659056_0_0_0_var;
IL2CPP_EXTERN_C const RuntimeType* Char_tFF60D8E7E89A20BE2294A003734341BD1DF43E14_0_0_0_var;
IL2CPP_EXTERN_C const RuntimeType* Double_t42821932CB52DE2057E685D0E1AF3DE5033D2181_0_0_0_var;
IL2CPP_EXTERN_C const RuntimeType* Int16_tD0F031114106263BB459DA1F099FF9F42691295A_0_0_0_var;
IL2CPP_EXTERN_C const RuntimeType* Int32_tFDE5F8CD43D10453F6A2E0C77FE48C6CC7009046_0_0_0_var;
IL2CPP_EXTERN_C const RuntimeType* Int64_t378EE0D608BD3107E77238E85F30D2BBD46981F3_0_0_0_var;
IL2CPP_EXTERN_C const RuntimeType* ObjectU5BU5D_tC1F4EE0DB0B7300255F5FD4AF64FE4C585CF5ADE_0_0_0_var;
IL2CPP_EXTERN_C const RuntimeType* RuntimeObject_0_0_0_var;
IL2CPP_EXTERN_C const RuntimeType* SByte_t928712DD662DC29BA4FAAE8CE2230AFB23447F0B_0_0_0_var;
IL2CPP_EXTERN_C const RuntimeType* Single_tE07797BA3C98D4CA9B5A19413C19A76688AB899E_0_0_0_var;
IL2CPP_EXTERN_C const RuntimeType* String_t_0_0_0_var;
IL2CPP_EXTERN_C const RuntimeType* Void_t700C6383A2A510C2CF4DD86DABD5CA9FF70ADAC5_0_0_0_var;
struct Delegate_t_marshaled_com;
struct Delegate_t_marshaled_pinvoke;
struct Exception_t_marshaled_com;
struct Exception_t_marshaled_pinvoke;

struct AndroidJavaObjectU5BU5D_tEE28563C9013906CEB39794019A55F4BA5B06120;
struct BooleanU5BU5D_tEC7BAF93C44F875016DAADC8696EE3A465644D3C;
struct ByteU5BU5D_tDBBEB0E8362242FA7223000D978B0DD19D4B0726;
struct CharU5BU5D_t7B7FC5BC8091AA3B9CB0B29CDD80B5EE9254AA34;
struct DoubleU5BU5D_t8E1B42EB2ABB79FBD193A6B8C8D97A7CDE44A4FB;
struct ExpressionU5BU5D_t4F1F138488EBD58837D142B40E0E4EEFC607EA63;
struct Int16U5BU5D_tD134F1E6F746D4C09C987436805256C210C2FFCD;
struct Int32U5BU5D_t70F1BDC14B1786481B176D6139A5E3B87DC54C32;
struct Int64U5BU5D_tCA61E42872C63A4286B24EEE6E0650143B43DCE6;
struct ObjectU5BU5D_tC1F4EE0DB0B7300255F5FD4AF64FE4C585CF5ADE;
struct ParameterExpressionU5BU5D_tCF3EAA6D8556513C4937E1126F65AA08DF4DB147;
struct SByteU5BU5D_t7D94C53295E6116625EA7CC7DEA21FEDC39869E7;
struct SingleU5BU5D_t47E8DBF5B597C122478D1FFBD9DD57399A0650FA;
struct StringU5BU5D_tACEBFEDE350025B554CD507C9AE8FFE49359549A;
struct TimeSpanU5BU5D_t93A1470C8423F710E4D26493EE109A5A5920D545;
struct UInt16U5BU5D_t42D35C587B07DCDBCFDADF572C6D733AE85B2A67;
struct UInt32U5BU5D_tCF06F1E9E72E0302C762578FF5358CC523F2A2CF;
struct UInt64U5BU5D_t7C6E32D10F47677C1CEF3C30F4E4CE95B3A633E2;

IL2CPP_EXTERN_C_BEGIN
IL2CPP_EXTERN_C_END

#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

// System.Object


// System.Runtime.CompilerServices.ConditionalWeakTable`2<System.Object,System.Runtime.InteropServices.WindowsRuntime.WindowsRuntimeMarshal/NativeOrStaticEventRegistrationImpl/EventRegistrationTokenListWithCount>
struct ConditionalWeakTable_2_tDE9E02FF583A5D6707A2CCEF9E15BD2791EA4229  : public RuntimeObject
{
public:
	// System.Runtime.CompilerServices.Ephemeron[] System.Runtime.CompilerServices.ConditionalWeakTable`2::data
	EphemeronU5BU5D_tA2F880A59471B7642CA02323CD56295126FC28A8* ___data_4;
	// System.Object System.Runtime.CompilerServices.ConditionalWeakTable`2::_lock
	RuntimeObject * ____lock_5;
	// System.Int32 System.Runtime.CompilerServices.ConditionalWeakTable`2::size
	int32_t ___size_6;

public:
	inline static int32_t get_offset_of_data_4() { return static_cast<int32_t>(offsetof(ConditionalWeakTable_2_tDE9E02FF583A5D6707A2CCEF9E15BD2791EA4229, ___data_4)); }
	inline EphemeronU5BU5D_tA2F880A59471B7642CA02323CD56295126FC28A8* get_data_4() const { return ___data_4; }
	inline EphemeronU5BU5D_tA2F880A59471B7642CA02323CD56295126FC28A8** get_address_of_data_4() { return &___data_4; }
	inline void set_data_4(EphemeronU5BU5D_tA2F880A59471B7642CA02323CD56295126FC28A8* value)
	{
		___data_4 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___data_4), (void*)value);
	}

	inline static int32_t get_offset_of__lock_5() { return static_cast<int32_t>(offsetof(ConditionalWeakTable_2_tDE9E02FF583A5D6707A2CCEF9E15BD2791EA4229, ____lock_5)); }
	inline RuntimeObject * get__lock_5() const { return ____lock_5; }
	inline RuntimeObject ** get_address_of__lock_5() { return &____lock_5; }
	inline void set__lock_5(RuntimeObject * value)
	{
		____lock_5 = value;
		Il2CppCodeGenWriteBarrier((void**)(&____lock_5), (void*)value);
	}

	inline static int32_t get_offset_of_size_6() { return static_cast<int32_t>(offsetof(ConditionalWeakTable_2_tDE9E02FF583A5D6707A2CCEF9E15BD2791EA4229, ___size_6)); }
	inline int32_t get_size_6() const { return ___size_6; }
	inline int32_t* get_address_of_size_6() { return &___size_6; }
	inline void set_size_6(int32_t value)
	{
		___size_6 = value;
	}
};


// System.Collections.Generic.Dictionary`2<System.Object,System.Runtime.InteropServices.WindowsRuntime.WindowsRuntimeMarshal/EventRegistrationTokenList>
struct Dictionary_2_t5BB631D653FC099355128DBC14DC44E27AD30739  : public RuntimeObject
{
public:
	// System.Int32[] System.Collections.Generic.Dictionary`2::buckets
	Int32U5BU5D_t70F1BDC14B1786481B176D6139A5E3B87DC54C32* ___buckets_0;
	// System.Collections.Generic.Dictionary`2/Entry<TKey,TValue>[] System.Collections.Generic.Dictionary`2::entries
	EntryU5BU5D_t8D607320BF96B9AF7102AD17E8A0C7173DB1AF85* ___entries_1;
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
	KeyCollection_t6F870BF5CEDDFEB13959730E1D35AF53F95D1153 * ___keys_7;
	// System.Collections.Generic.Dictionary`2/ValueCollection<TKey,TValue> System.Collections.Generic.Dictionary`2::values
	ValueCollection_tEA48E4B6DFB033F98ED189470457D6134F7C7AA9 * ___values_8;
	// System.Object System.Collections.Generic.Dictionary`2::_syncRoot
	RuntimeObject * ____syncRoot_9;

public:
	inline static int32_t get_offset_of_buckets_0() { return static_cast<int32_t>(offsetof(Dictionary_2_t5BB631D653FC099355128DBC14DC44E27AD30739, ___buckets_0)); }
	inline Int32U5BU5D_t70F1BDC14B1786481B176D6139A5E3B87DC54C32* get_buckets_0() const { return ___buckets_0; }
	inline Int32U5BU5D_t70F1BDC14B1786481B176D6139A5E3B87DC54C32** get_address_of_buckets_0() { return &___buckets_0; }
	inline void set_buckets_0(Int32U5BU5D_t70F1BDC14B1786481B176D6139A5E3B87DC54C32* value)
	{
		___buckets_0 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___buckets_0), (void*)value);
	}

	inline static int32_t get_offset_of_entries_1() { return static_cast<int32_t>(offsetof(Dictionary_2_t5BB631D653FC099355128DBC14DC44E27AD30739, ___entries_1)); }
	inline EntryU5BU5D_t8D607320BF96B9AF7102AD17E8A0C7173DB1AF85* get_entries_1() const { return ___entries_1; }
	inline EntryU5BU5D_t8D607320BF96B9AF7102AD17E8A0C7173DB1AF85** get_address_of_entries_1() { return &___entries_1; }
	inline void set_entries_1(EntryU5BU5D_t8D607320BF96B9AF7102AD17E8A0C7173DB1AF85* value)
	{
		___entries_1 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___entries_1), (void*)value);
	}

	inline static int32_t get_offset_of_count_2() { return static_cast<int32_t>(offsetof(Dictionary_2_t5BB631D653FC099355128DBC14DC44E27AD30739, ___count_2)); }
	inline int32_t get_count_2() const { return ___count_2; }
	inline int32_t* get_address_of_count_2() { return &___count_2; }
	inline void set_count_2(int32_t value)
	{
		___count_2 = value;
	}

	inline static int32_t get_offset_of_version_3() { return static_cast<int32_t>(offsetof(Dictionary_2_t5BB631D653FC099355128DBC14DC44E27AD30739, ___version_3)); }
	inline int32_t get_version_3() const { return ___version_3; }
	inline int32_t* get_address_of_version_3() { return &___version_3; }
	inline void set_version_3(int32_t value)
	{
		___version_3 = value;
	}

	inline static int32_t get_offset_of_freeList_4() { return static_cast<int32_t>(offsetof(Dictionary_2_t5BB631D653FC099355128DBC14DC44E27AD30739, ___freeList_4)); }
	inline int32_t get_freeList_4() const { return ___freeList_4; }
	inline int32_t* get_address_of_freeList_4() { return &___freeList_4; }
	inline void set_freeList_4(int32_t value)
	{
		___freeList_4 = value;
	}

	inline static int32_t get_offset_of_freeCount_5() { return static_cast<int32_t>(offsetof(Dictionary_2_t5BB631D653FC099355128DBC14DC44E27AD30739, ___freeCount_5)); }
	inline int32_t get_freeCount_5() const { return ___freeCount_5; }
	inline int32_t* get_address_of_freeCount_5() { return &___freeCount_5; }
	inline void set_freeCount_5(int32_t value)
	{
		___freeCount_5 = value;
	}

	inline static int32_t get_offset_of_comparer_6() { return static_cast<int32_t>(offsetof(Dictionary_2_t5BB631D653FC099355128DBC14DC44E27AD30739, ___comparer_6)); }
	inline RuntimeObject* get_comparer_6() const { return ___comparer_6; }
	inline RuntimeObject** get_address_of_comparer_6() { return &___comparer_6; }
	inline void set_comparer_6(RuntimeObject* value)
	{
		___comparer_6 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___comparer_6), (void*)value);
	}

	inline static int32_t get_offset_of_keys_7() { return static_cast<int32_t>(offsetof(Dictionary_2_t5BB631D653FC099355128DBC14DC44E27AD30739, ___keys_7)); }
	inline KeyCollection_t6F870BF5CEDDFEB13959730E1D35AF53F95D1153 * get_keys_7() const { return ___keys_7; }
	inline KeyCollection_t6F870BF5CEDDFEB13959730E1D35AF53F95D1153 ** get_address_of_keys_7() { return &___keys_7; }
	inline void set_keys_7(KeyCollection_t6F870BF5CEDDFEB13959730E1D35AF53F95D1153 * value)
	{
		___keys_7 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___keys_7), (void*)value);
	}

	inline static int32_t get_offset_of_values_8() { return static_cast<int32_t>(offsetof(Dictionary_2_t5BB631D653FC099355128DBC14DC44E27AD30739, ___values_8)); }
	inline ValueCollection_tEA48E4B6DFB033F98ED189470457D6134F7C7AA9 * get_values_8() const { return ___values_8; }
	inline ValueCollection_tEA48E4B6DFB033F98ED189470457D6134F7C7AA9 ** get_address_of_values_8() { return &___values_8; }
	inline void set_values_8(ValueCollection_tEA48E4B6DFB033F98ED189470457D6134F7C7AA9 * value)
	{
		___values_8 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___values_8), (void*)value);
	}

	inline static int32_t get_offset_of__syncRoot_9() { return static_cast<int32_t>(offsetof(Dictionary_2_t5BB631D653FC099355128DBC14DC44E27AD30739, ____syncRoot_9)); }
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


// System.Collections.Generic.HashSet`1<System.Linq.Expressions.ParameterExpression>
struct HashSet_1_t42A3AC337CA15FAC250AA5DA438F909806C72CB0  : public RuntimeObject
{
public:
	// System.Int32[] System.Collections.Generic.HashSet`1::_buckets
	Int32U5BU5D_t70F1BDC14B1786481B176D6139A5E3B87DC54C32* ____buckets_7;
	// System.Collections.Generic.HashSet`1/Slot<T>[] System.Collections.Generic.HashSet`1::_slots
	SlotU5BU5D_tAF315AD110D3AD4FBD91B25289AFC6FB963DC31E* ____slots_8;
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
	inline static int32_t get_offset_of__buckets_7() { return static_cast<int32_t>(offsetof(HashSet_1_t42A3AC337CA15FAC250AA5DA438F909806C72CB0, ____buckets_7)); }
	inline Int32U5BU5D_t70F1BDC14B1786481B176D6139A5E3B87DC54C32* get__buckets_7() const { return ____buckets_7; }
	inline Int32U5BU5D_t70F1BDC14B1786481B176D6139A5E3B87DC54C32** get_address_of__buckets_7() { return &____buckets_7; }
	inline void set__buckets_7(Int32U5BU5D_t70F1BDC14B1786481B176D6139A5E3B87DC54C32* value)
	{
		____buckets_7 = value;
		Il2CppCodeGenWriteBarrier((void**)(&____buckets_7), (void*)value);
	}

	inline static int32_t get_offset_of__slots_8() { return static_cast<int32_t>(offsetof(HashSet_1_t42A3AC337CA15FAC250AA5DA438F909806C72CB0, ____slots_8)); }
	inline SlotU5BU5D_tAF315AD110D3AD4FBD91B25289AFC6FB963DC31E* get__slots_8() const { return ____slots_8; }
	inline SlotU5BU5D_tAF315AD110D3AD4FBD91B25289AFC6FB963DC31E** get_address_of__slots_8() { return &____slots_8; }
	inline void set__slots_8(SlotU5BU5D_tAF315AD110D3AD4FBD91B25289AFC6FB963DC31E* value)
	{
		____slots_8 = value;
		Il2CppCodeGenWriteBarrier((void**)(&____slots_8), (void*)value);
	}

	inline static int32_t get_offset_of__count_9() { return static_cast<int32_t>(offsetof(HashSet_1_t42A3AC337CA15FAC250AA5DA438F909806C72CB0, ____count_9)); }
	inline int32_t get__count_9() const { return ____count_9; }
	inline int32_t* get_address_of__count_9() { return &____count_9; }
	inline void set__count_9(int32_t value)
	{
		____count_9 = value;
	}

	inline static int32_t get_offset_of__lastIndex_10() { return static_cast<int32_t>(offsetof(HashSet_1_t42A3AC337CA15FAC250AA5DA438F909806C72CB0, ____lastIndex_10)); }
	inline int32_t get__lastIndex_10() const { return ____lastIndex_10; }
	inline int32_t* get_address_of__lastIndex_10() { return &____lastIndex_10; }
	inline void set__lastIndex_10(int32_t value)
	{
		____lastIndex_10 = value;
	}

	inline static int32_t get_offset_of__freeList_11() { return static_cast<int32_t>(offsetof(HashSet_1_t42A3AC337CA15FAC250AA5DA438F909806C72CB0, ____freeList_11)); }
	inline int32_t get__freeList_11() const { return ____freeList_11; }
	inline int32_t* get_address_of__freeList_11() { return &____freeList_11; }
	inline void set__freeList_11(int32_t value)
	{
		____freeList_11 = value;
	}

	inline static int32_t get_offset_of__comparer_12() { return static_cast<int32_t>(offsetof(HashSet_1_t42A3AC337CA15FAC250AA5DA438F909806C72CB0, ____comparer_12)); }
	inline RuntimeObject* get__comparer_12() const { return ____comparer_12; }
	inline RuntimeObject** get_address_of__comparer_12() { return &____comparer_12; }
	inline void set__comparer_12(RuntimeObject* value)
	{
		____comparer_12 = value;
		Il2CppCodeGenWriteBarrier((void**)(&____comparer_12), (void*)value);
	}

	inline static int32_t get_offset_of__version_13() { return static_cast<int32_t>(offsetof(HashSet_1_t42A3AC337CA15FAC250AA5DA438F909806C72CB0, ____version_13)); }
	inline int32_t get__version_13() const { return ____version_13; }
	inline int32_t* get_address_of__version_13() { return &____version_13; }
	inline void set__version_13(int32_t value)
	{
		____version_13 = value;
	}

	inline static int32_t get_offset_of__siInfo_14() { return static_cast<int32_t>(offsetof(HashSet_1_t42A3AC337CA15FAC250AA5DA438F909806C72CB0, ____siInfo_14)); }
	inline SerializationInfo_t097DA64D9DB49ED7F2458E964BE8CCCF63FC67C1 * get__siInfo_14() const { return ____siInfo_14; }
	inline SerializationInfo_t097DA64D9DB49ED7F2458E964BE8CCCF63FC67C1 ** get_address_of__siInfo_14() { return &____siInfo_14; }
	inline void set__siInfo_14(SerializationInfo_t097DA64D9DB49ED7F2458E964BE8CCCF63FC67C1 * value)
	{
		____siInfo_14 = value;
		Il2CppCodeGenWriteBarrier((void**)(&____siInfo_14), (void*)value);
	}
};


// System.Collections.Generic.List`1<System.Linq.Expressions.ParameterExpression>
struct List_1_tCDDF33E8793E2DD752E38CC326B13F8F35B1493B  : public RuntimeObject
{
public:
	// T[] System.Collections.Generic.List`1::_items
	ParameterExpressionU5BU5D_tCF3EAA6D8556513C4937E1126F65AA08DF4DB147* ____items_1;
	// System.Int32 System.Collections.Generic.List`1::_size
	int32_t ____size_2;
	// System.Int32 System.Collections.Generic.List`1::_version
	int32_t ____version_3;
	// System.Object System.Collections.Generic.List`1::_syncRoot
	RuntimeObject * ____syncRoot_4;

public:
	inline static int32_t get_offset_of__items_1() { return static_cast<int32_t>(offsetof(List_1_tCDDF33E8793E2DD752E38CC326B13F8F35B1493B, ____items_1)); }
	inline ParameterExpressionU5BU5D_tCF3EAA6D8556513C4937E1126F65AA08DF4DB147* get__items_1() const { return ____items_1; }
	inline ParameterExpressionU5BU5D_tCF3EAA6D8556513C4937E1126F65AA08DF4DB147** get_address_of__items_1() { return &____items_1; }
	inline void set__items_1(ParameterExpressionU5BU5D_tCF3EAA6D8556513C4937E1126F65AA08DF4DB147* value)
	{
		____items_1 = value;
		Il2CppCodeGenWriteBarrier((void**)(&____items_1), (void*)value);
	}

	inline static int32_t get_offset_of__size_2() { return static_cast<int32_t>(offsetof(List_1_tCDDF33E8793E2DD752E38CC326B13F8F35B1493B, ____size_2)); }
	inline int32_t get__size_2() const { return ____size_2; }
	inline int32_t* get_address_of__size_2() { return &____size_2; }
	inline void set__size_2(int32_t value)
	{
		____size_2 = value;
	}

	inline static int32_t get_offset_of__version_3() { return static_cast<int32_t>(offsetof(List_1_tCDDF33E8793E2DD752E38CC326B13F8F35B1493B, ____version_3)); }
	inline int32_t get__version_3() const { return ____version_3; }
	inline int32_t* get_address_of__version_3() { return &____version_3; }
	inline void set__version_3(int32_t value)
	{
		____version_3 = value;
	}

	inline static int32_t get_offset_of__syncRoot_4() { return static_cast<int32_t>(offsetof(List_1_tCDDF33E8793E2DD752E38CC326B13F8F35B1493B, ____syncRoot_4)); }
	inline RuntimeObject * get__syncRoot_4() const { return ____syncRoot_4; }
	inline RuntimeObject ** get_address_of__syncRoot_4() { return &____syncRoot_4; }
	inline void set__syncRoot_4(RuntimeObject * value)
	{
		____syncRoot_4 = value;
		Il2CppCodeGenWriteBarrier((void**)(&____syncRoot_4), (void*)value);
	}
};

struct List_1_tCDDF33E8793E2DD752E38CC326B13F8F35B1493B_StaticFields
{
public:
	// T[] System.Collections.Generic.List`1::_emptyArray
	ParameterExpressionU5BU5D_tCF3EAA6D8556513C4937E1126F65AA08DF4DB147* ____emptyArray_5;

public:
	inline static int32_t get_offset_of__emptyArray_5() { return static_cast<int32_t>(offsetof(List_1_tCDDF33E8793E2DD752E38CC326B13F8F35B1493B_StaticFields, ____emptyArray_5)); }
	inline ParameterExpressionU5BU5D_tCF3EAA6D8556513C4937E1126F65AA08DF4DB147* get__emptyArray_5() const { return ____emptyArray_5; }
	inline ParameterExpressionU5BU5D_tCF3EAA6D8556513C4937E1126F65AA08DF4DB147** get_address_of__emptyArray_5() { return &____emptyArray_5; }
	inline void set__emptyArray_5(ParameterExpressionU5BU5D_tCF3EAA6D8556513C4937E1126F65AA08DF4DB147* value)
	{
		____emptyArray_5 = value;
		Il2CppCodeGenWriteBarrier((void**)(&____emptyArray_5), (void*)value);
	}
};


// System.Collections.Generic.List`1<System.SByte>
struct List_1_t7F0E10DCBF1EBD7FBCA81F990C2A8D07D7A611F7  : public RuntimeObject
{
public:
	// T[] System.Collections.Generic.List`1::_items
	SByteU5BU5D_t7D94C53295E6116625EA7CC7DEA21FEDC39869E7* ____items_1;
	// System.Int32 System.Collections.Generic.List`1::_size
	int32_t ____size_2;
	// System.Int32 System.Collections.Generic.List`1::_version
	int32_t ____version_3;
	// System.Object System.Collections.Generic.List`1::_syncRoot
	RuntimeObject * ____syncRoot_4;

public:
	inline static int32_t get_offset_of__items_1() { return static_cast<int32_t>(offsetof(List_1_t7F0E10DCBF1EBD7FBCA81F990C2A8D07D7A611F7, ____items_1)); }
	inline SByteU5BU5D_t7D94C53295E6116625EA7CC7DEA21FEDC39869E7* get__items_1() const { return ____items_1; }
	inline SByteU5BU5D_t7D94C53295E6116625EA7CC7DEA21FEDC39869E7** get_address_of__items_1() { return &____items_1; }
	inline void set__items_1(SByteU5BU5D_t7D94C53295E6116625EA7CC7DEA21FEDC39869E7* value)
	{
		____items_1 = value;
		Il2CppCodeGenWriteBarrier((void**)(&____items_1), (void*)value);
	}

	inline static int32_t get_offset_of__size_2() { return static_cast<int32_t>(offsetof(List_1_t7F0E10DCBF1EBD7FBCA81F990C2A8D07D7A611F7, ____size_2)); }
	inline int32_t get__size_2() const { return ____size_2; }
	inline int32_t* get_address_of__size_2() { return &____size_2; }
	inline void set__size_2(int32_t value)
	{
		____size_2 = value;
	}

	inline static int32_t get_offset_of__version_3() { return static_cast<int32_t>(offsetof(List_1_t7F0E10DCBF1EBD7FBCA81F990C2A8D07D7A611F7, ____version_3)); }
	inline int32_t get__version_3() const { return ____version_3; }
	inline int32_t* get_address_of__version_3() { return &____version_3; }
	inline void set__version_3(int32_t value)
	{
		____version_3 = value;
	}

	inline static int32_t get_offset_of__syncRoot_4() { return static_cast<int32_t>(offsetof(List_1_t7F0E10DCBF1EBD7FBCA81F990C2A8D07D7A611F7, ____syncRoot_4)); }
	inline RuntimeObject * get__syncRoot_4() const { return ____syncRoot_4; }
	inline RuntimeObject ** get_address_of__syncRoot_4() { return &____syncRoot_4; }
	inline void set__syncRoot_4(RuntimeObject * value)
	{
		____syncRoot_4 = value;
		Il2CppCodeGenWriteBarrier((void**)(&____syncRoot_4), (void*)value);
	}
};

struct List_1_t7F0E10DCBF1EBD7FBCA81F990C2A8D07D7A611F7_StaticFields
{
public:
	// T[] System.Collections.Generic.List`1::_emptyArray
	SByteU5BU5D_t7D94C53295E6116625EA7CC7DEA21FEDC39869E7* ____emptyArray_5;

public:
	inline static int32_t get_offset_of__emptyArray_5() { return static_cast<int32_t>(offsetof(List_1_t7F0E10DCBF1EBD7FBCA81F990C2A8D07D7A611F7_StaticFields, ____emptyArray_5)); }
	inline SByteU5BU5D_t7D94C53295E6116625EA7CC7DEA21FEDC39869E7* get__emptyArray_5() const { return ____emptyArray_5; }
	inline SByteU5BU5D_t7D94C53295E6116625EA7CC7DEA21FEDC39869E7** get_address_of__emptyArray_5() { return &____emptyArray_5; }
	inline void set__emptyArray_5(SByteU5BU5D_t7D94C53295E6116625EA7CC7DEA21FEDC39869E7* value)
	{
		____emptyArray_5 = value;
		Il2CppCodeGenWriteBarrier((void**)(&____emptyArray_5), (void*)value);
	}
};


// System.Collections.Generic.List`1<System.Single>
struct List_1_t6726F9309570A0BDC5D42E10777F3E2931C487AA  : public RuntimeObject
{
public:
	// T[] System.Collections.Generic.List`1::_items
	SingleU5BU5D_t47E8DBF5B597C122478D1FFBD9DD57399A0650FA* ____items_1;
	// System.Int32 System.Collections.Generic.List`1::_size
	int32_t ____size_2;
	// System.Int32 System.Collections.Generic.List`1::_version
	int32_t ____version_3;
	// System.Object System.Collections.Generic.List`1::_syncRoot
	RuntimeObject * ____syncRoot_4;

public:
	inline static int32_t get_offset_of__items_1() { return static_cast<int32_t>(offsetof(List_1_t6726F9309570A0BDC5D42E10777F3E2931C487AA, ____items_1)); }
	inline SingleU5BU5D_t47E8DBF5B597C122478D1FFBD9DD57399A0650FA* get__items_1() const { return ____items_1; }
	inline SingleU5BU5D_t47E8DBF5B597C122478D1FFBD9DD57399A0650FA** get_address_of__items_1() { return &____items_1; }
	inline void set__items_1(SingleU5BU5D_t47E8DBF5B597C122478D1FFBD9DD57399A0650FA* value)
	{
		____items_1 = value;
		Il2CppCodeGenWriteBarrier((void**)(&____items_1), (void*)value);
	}

	inline static int32_t get_offset_of__size_2() { return static_cast<int32_t>(offsetof(List_1_t6726F9309570A0BDC5D42E10777F3E2931C487AA, ____size_2)); }
	inline int32_t get__size_2() const { return ____size_2; }
	inline int32_t* get_address_of__size_2() { return &____size_2; }
	inline void set__size_2(int32_t value)
	{
		____size_2 = value;
	}

	inline static int32_t get_offset_of__version_3() { return static_cast<int32_t>(offsetof(List_1_t6726F9309570A0BDC5D42E10777F3E2931C487AA, ____version_3)); }
	inline int32_t get__version_3() const { return ____version_3; }
	inline int32_t* get_address_of__version_3() { return &____version_3; }
	inline void set__version_3(int32_t value)
	{
		____version_3 = value;
	}

	inline static int32_t get_offset_of__syncRoot_4() { return static_cast<int32_t>(offsetof(List_1_t6726F9309570A0BDC5D42E10777F3E2931C487AA, ____syncRoot_4)); }
	inline RuntimeObject * get__syncRoot_4() const { return ____syncRoot_4; }
	inline RuntimeObject ** get_address_of__syncRoot_4() { return &____syncRoot_4; }
	inline void set__syncRoot_4(RuntimeObject * value)
	{
		____syncRoot_4 = value;
		Il2CppCodeGenWriteBarrier((void**)(&____syncRoot_4), (void*)value);
	}
};

struct List_1_t6726F9309570A0BDC5D42E10777F3E2931C487AA_StaticFields
{
public:
	// T[] System.Collections.Generic.List`1::_emptyArray
	SingleU5BU5D_t47E8DBF5B597C122478D1FFBD9DD57399A0650FA* ____emptyArray_5;

public:
	inline static int32_t get_offset_of__emptyArray_5() { return static_cast<int32_t>(offsetof(List_1_t6726F9309570A0BDC5D42E10777F3E2931C487AA_StaticFields, ____emptyArray_5)); }
	inline SingleU5BU5D_t47E8DBF5B597C122478D1FFBD9DD57399A0650FA* get__emptyArray_5() const { return ____emptyArray_5; }
	inline SingleU5BU5D_t47E8DBF5B597C122478D1FFBD9DD57399A0650FA** get_address_of__emptyArray_5() { return &____emptyArray_5; }
	inline void set__emptyArray_5(SingleU5BU5D_t47E8DBF5B597C122478D1FFBD9DD57399A0650FA* value)
	{
		____emptyArray_5 = value;
		Il2CppCodeGenWriteBarrier((void**)(&____emptyArray_5), (void*)value);
	}
};


// System.Collections.Generic.List`1<System.TimeSpan>
struct List_1_t6CC60BBD48A742FE583491EABD97557A9B169FC3  : public RuntimeObject
{
public:
	// T[] System.Collections.Generic.List`1::_items
	TimeSpanU5BU5D_t93A1470C8423F710E4D26493EE109A5A5920D545* ____items_1;
	// System.Int32 System.Collections.Generic.List`1::_size
	int32_t ____size_2;
	// System.Int32 System.Collections.Generic.List`1::_version
	int32_t ____version_3;
	// System.Object System.Collections.Generic.List`1::_syncRoot
	RuntimeObject * ____syncRoot_4;

public:
	inline static int32_t get_offset_of__items_1() { return static_cast<int32_t>(offsetof(List_1_t6CC60BBD48A742FE583491EABD97557A9B169FC3, ____items_1)); }
	inline TimeSpanU5BU5D_t93A1470C8423F710E4D26493EE109A5A5920D545* get__items_1() const { return ____items_1; }
	inline TimeSpanU5BU5D_t93A1470C8423F710E4D26493EE109A5A5920D545** get_address_of__items_1() { return &____items_1; }
	inline void set__items_1(TimeSpanU5BU5D_t93A1470C8423F710E4D26493EE109A5A5920D545* value)
	{
		____items_1 = value;
		Il2CppCodeGenWriteBarrier((void**)(&____items_1), (void*)value);
	}

	inline static int32_t get_offset_of__size_2() { return static_cast<int32_t>(offsetof(List_1_t6CC60BBD48A742FE583491EABD97557A9B169FC3, ____size_2)); }
	inline int32_t get__size_2() const { return ____size_2; }
	inline int32_t* get_address_of__size_2() { return &____size_2; }
	inline void set__size_2(int32_t value)
	{
		____size_2 = value;
	}

	inline static int32_t get_offset_of__version_3() { return static_cast<int32_t>(offsetof(List_1_t6CC60BBD48A742FE583491EABD97557A9B169FC3, ____version_3)); }
	inline int32_t get__version_3() const { return ____version_3; }
	inline int32_t* get_address_of__version_3() { return &____version_3; }
	inline void set__version_3(int32_t value)
	{
		____version_3 = value;
	}

	inline static int32_t get_offset_of__syncRoot_4() { return static_cast<int32_t>(offsetof(List_1_t6CC60BBD48A742FE583491EABD97557A9B169FC3, ____syncRoot_4)); }
	inline RuntimeObject * get__syncRoot_4() const { return ____syncRoot_4; }
	inline RuntimeObject ** get_address_of__syncRoot_4() { return &____syncRoot_4; }
	inline void set__syncRoot_4(RuntimeObject * value)
	{
		____syncRoot_4 = value;
		Il2CppCodeGenWriteBarrier((void**)(&____syncRoot_4), (void*)value);
	}
};

struct List_1_t6CC60BBD48A742FE583491EABD97557A9B169FC3_StaticFields
{
public:
	// T[] System.Collections.Generic.List`1::_emptyArray
	TimeSpanU5BU5D_t93A1470C8423F710E4D26493EE109A5A5920D545* ____emptyArray_5;

public:
	inline static int32_t get_offset_of__emptyArray_5() { return static_cast<int32_t>(offsetof(List_1_t6CC60BBD48A742FE583491EABD97557A9B169FC3_StaticFields, ____emptyArray_5)); }
	inline TimeSpanU5BU5D_t93A1470C8423F710E4D26493EE109A5A5920D545* get__emptyArray_5() const { return ____emptyArray_5; }
	inline TimeSpanU5BU5D_t93A1470C8423F710E4D26493EE109A5A5920D545** get_address_of__emptyArray_5() { return &____emptyArray_5; }
	inline void set__emptyArray_5(TimeSpanU5BU5D_t93A1470C8423F710E4D26493EE109A5A5920D545* value)
	{
		____emptyArray_5 = value;
		Il2CppCodeGenWriteBarrier((void**)(&____emptyArray_5), (void*)value);
	}
};


// System.Collections.Generic.List`1<System.UInt16>
struct List_1_tBBC4E953860E582A3E060CC10B1387AFC5A36FC5  : public RuntimeObject
{
public:
	// T[] System.Collections.Generic.List`1::_items
	UInt16U5BU5D_t42D35C587B07DCDBCFDADF572C6D733AE85B2A67* ____items_1;
	// System.Int32 System.Collections.Generic.List`1::_size
	int32_t ____size_2;
	// System.Int32 System.Collections.Generic.List`1::_version
	int32_t ____version_3;
	// System.Object System.Collections.Generic.List`1::_syncRoot
	RuntimeObject * ____syncRoot_4;

public:
	inline static int32_t get_offset_of__items_1() { return static_cast<int32_t>(offsetof(List_1_tBBC4E953860E582A3E060CC10B1387AFC5A36FC5, ____items_1)); }
	inline UInt16U5BU5D_t42D35C587B07DCDBCFDADF572C6D733AE85B2A67* get__items_1() const { return ____items_1; }
	inline UInt16U5BU5D_t42D35C587B07DCDBCFDADF572C6D733AE85B2A67** get_address_of__items_1() { return &____items_1; }
	inline void set__items_1(UInt16U5BU5D_t42D35C587B07DCDBCFDADF572C6D733AE85B2A67* value)
	{
		____items_1 = value;
		Il2CppCodeGenWriteBarrier((void**)(&____items_1), (void*)value);
	}

	inline static int32_t get_offset_of__size_2() { return static_cast<int32_t>(offsetof(List_1_tBBC4E953860E582A3E060CC10B1387AFC5A36FC5, ____size_2)); }
	inline int32_t get__size_2() const { return ____size_2; }
	inline int32_t* get_address_of__size_2() { return &____size_2; }
	inline void set__size_2(int32_t value)
	{
		____size_2 = value;
	}

	inline static int32_t get_offset_of__version_3() { return static_cast<int32_t>(offsetof(List_1_tBBC4E953860E582A3E060CC10B1387AFC5A36FC5, ____version_3)); }
	inline int32_t get__version_3() const { return ____version_3; }
	inline int32_t* get_address_of__version_3() { return &____version_3; }
	inline void set__version_3(int32_t value)
	{
		____version_3 = value;
	}

	inline static int32_t get_offset_of__syncRoot_4() { return static_cast<int32_t>(offsetof(List_1_tBBC4E953860E582A3E060CC10B1387AFC5A36FC5, ____syncRoot_4)); }
	inline RuntimeObject * get__syncRoot_4() const { return ____syncRoot_4; }
	inline RuntimeObject ** get_address_of__syncRoot_4() { return &____syncRoot_4; }
	inline void set__syncRoot_4(RuntimeObject * value)
	{
		____syncRoot_4 = value;
		Il2CppCodeGenWriteBarrier((void**)(&____syncRoot_4), (void*)value);
	}
};

struct List_1_tBBC4E953860E582A3E060CC10B1387AFC5A36FC5_StaticFields
{
public:
	// T[] System.Collections.Generic.List`1::_emptyArray
	UInt16U5BU5D_t42D35C587B07DCDBCFDADF572C6D733AE85B2A67* ____emptyArray_5;

public:
	inline static int32_t get_offset_of__emptyArray_5() { return static_cast<int32_t>(offsetof(List_1_tBBC4E953860E582A3E060CC10B1387AFC5A36FC5_StaticFields, ____emptyArray_5)); }
	inline UInt16U5BU5D_t42D35C587B07DCDBCFDADF572C6D733AE85B2A67* get__emptyArray_5() const { return ____emptyArray_5; }
	inline UInt16U5BU5D_t42D35C587B07DCDBCFDADF572C6D733AE85B2A67** get_address_of__emptyArray_5() { return &____emptyArray_5; }
	inline void set__emptyArray_5(UInt16U5BU5D_t42D35C587B07DCDBCFDADF572C6D733AE85B2A67* value)
	{
		____emptyArray_5 = value;
		Il2CppCodeGenWriteBarrier((void**)(&____emptyArray_5), (void*)value);
	}
};


// System.Collections.Generic.List`1<System.UInt32>
struct List_1_t023026A8F0D0D113E2B62213C8C74717BF7F4731  : public RuntimeObject
{
public:
	// T[] System.Collections.Generic.List`1::_items
	UInt32U5BU5D_tCF06F1E9E72E0302C762578FF5358CC523F2A2CF* ____items_1;
	// System.Int32 System.Collections.Generic.List`1::_size
	int32_t ____size_2;
	// System.Int32 System.Collections.Generic.List`1::_version
	int32_t ____version_3;
	// System.Object System.Collections.Generic.List`1::_syncRoot
	RuntimeObject * ____syncRoot_4;

public:
	inline static int32_t get_offset_of__items_1() { return static_cast<int32_t>(offsetof(List_1_t023026A8F0D0D113E2B62213C8C74717BF7F4731, ____items_1)); }
	inline UInt32U5BU5D_tCF06F1E9E72E0302C762578FF5358CC523F2A2CF* get__items_1() const { return ____items_1; }
	inline UInt32U5BU5D_tCF06F1E9E72E0302C762578FF5358CC523F2A2CF** get_address_of__items_1() { return &____items_1; }
	inline void set__items_1(UInt32U5BU5D_tCF06F1E9E72E0302C762578FF5358CC523F2A2CF* value)
	{
		____items_1 = value;
		Il2CppCodeGenWriteBarrier((void**)(&____items_1), (void*)value);
	}

	inline static int32_t get_offset_of__size_2() { return static_cast<int32_t>(offsetof(List_1_t023026A8F0D0D113E2B62213C8C74717BF7F4731, ____size_2)); }
	inline int32_t get__size_2() const { return ____size_2; }
	inline int32_t* get_address_of__size_2() { return &____size_2; }
	inline void set__size_2(int32_t value)
	{
		____size_2 = value;
	}

	inline static int32_t get_offset_of__version_3() { return static_cast<int32_t>(offsetof(List_1_t023026A8F0D0D113E2B62213C8C74717BF7F4731, ____version_3)); }
	inline int32_t get__version_3() const { return ____version_3; }
	inline int32_t* get_address_of__version_3() { return &____version_3; }
	inline void set__version_3(int32_t value)
	{
		____version_3 = value;
	}

	inline static int32_t get_offset_of__syncRoot_4() { return static_cast<int32_t>(offsetof(List_1_t023026A8F0D0D113E2B62213C8C74717BF7F4731, ____syncRoot_4)); }
	inline RuntimeObject * get__syncRoot_4() const { return ____syncRoot_4; }
	inline RuntimeObject ** get_address_of__syncRoot_4() { return &____syncRoot_4; }
	inline void set__syncRoot_4(RuntimeObject * value)
	{
		____syncRoot_4 = value;
		Il2CppCodeGenWriteBarrier((void**)(&____syncRoot_4), (void*)value);
	}
};

struct List_1_t023026A8F0D0D113E2B62213C8C74717BF7F4731_StaticFields
{
public:
	// T[] System.Collections.Generic.List`1::_emptyArray
	UInt32U5BU5D_tCF06F1E9E72E0302C762578FF5358CC523F2A2CF* ____emptyArray_5;

public:
	inline static int32_t get_offset_of__emptyArray_5() { return static_cast<int32_t>(offsetof(List_1_t023026A8F0D0D113E2B62213C8C74717BF7F4731_StaticFields, ____emptyArray_5)); }
	inline UInt32U5BU5D_tCF06F1E9E72E0302C762578FF5358CC523F2A2CF* get__emptyArray_5() const { return ____emptyArray_5; }
	inline UInt32U5BU5D_tCF06F1E9E72E0302C762578FF5358CC523F2A2CF** get_address_of__emptyArray_5() { return &____emptyArray_5; }
	inline void set__emptyArray_5(UInt32U5BU5D_tCF06F1E9E72E0302C762578FF5358CC523F2A2CF* value)
	{
		____emptyArray_5 = value;
		Il2CppCodeGenWriteBarrier((void**)(&____emptyArray_5), (void*)value);
	}
};


// System.Collections.Generic.List`1<System.UInt64>
struct List_1_t1F1C2C7D92FB6DF4FCD88B0AB0919AEAB3B45F6B  : public RuntimeObject
{
public:
	// T[] System.Collections.Generic.List`1::_items
	UInt64U5BU5D_t7C6E32D10F47677C1CEF3C30F4E4CE95B3A633E2* ____items_1;
	// System.Int32 System.Collections.Generic.List`1::_size
	int32_t ____size_2;
	// System.Int32 System.Collections.Generic.List`1::_version
	int32_t ____version_3;
	// System.Object System.Collections.Generic.List`1::_syncRoot
	RuntimeObject * ____syncRoot_4;

public:
	inline static int32_t get_offset_of__items_1() { return static_cast<int32_t>(offsetof(List_1_t1F1C2C7D92FB6DF4FCD88B0AB0919AEAB3B45F6B, ____items_1)); }
	inline UInt64U5BU5D_t7C6E32D10F47677C1CEF3C30F4E4CE95B3A633E2* get__items_1() const { return ____items_1; }
	inline UInt64U5BU5D_t7C6E32D10F47677C1CEF3C30F4E4CE95B3A633E2** get_address_of__items_1() { return &____items_1; }
	inline void set__items_1(UInt64U5BU5D_t7C6E32D10F47677C1CEF3C30F4E4CE95B3A633E2* value)
	{
		____items_1 = value;
		Il2CppCodeGenWriteBarrier((void**)(&____items_1), (void*)value);
	}

	inline static int32_t get_offset_of__size_2() { return static_cast<int32_t>(offsetof(List_1_t1F1C2C7D92FB6DF4FCD88B0AB0919AEAB3B45F6B, ____size_2)); }
	inline int32_t get__size_2() const { return ____size_2; }
	inline int32_t* get_address_of__size_2() { return &____size_2; }
	inline void set__size_2(int32_t value)
	{
		____size_2 = value;
	}

	inline static int32_t get_offset_of__version_3() { return static_cast<int32_t>(offsetof(List_1_t1F1C2C7D92FB6DF4FCD88B0AB0919AEAB3B45F6B, ____version_3)); }
	inline int32_t get__version_3() const { return ____version_3; }
	inline int32_t* get_address_of__version_3() { return &____version_3; }
	inline void set__version_3(int32_t value)
	{
		____version_3 = value;
	}

	inline static int32_t get_offset_of__syncRoot_4() { return static_cast<int32_t>(offsetof(List_1_t1F1C2C7D92FB6DF4FCD88B0AB0919AEAB3B45F6B, ____syncRoot_4)); }
	inline RuntimeObject * get__syncRoot_4() const { return ____syncRoot_4; }
	inline RuntimeObject ** get_address_of__syncRoot_4() { return &____syncRoot_4; }
	inline void set__syncRoot_4(RuntimeObject * value)
	{
		____syncRoot_4 = value;
		Il2CppCodeGenWriteBarrier((void**)(&____syncRoot_4), (void*)value);
	}
};

struct List_1_t1F1C2C7D92FB6DF4FCD88B0AB0919AEAB3B45F6B_StaticFields
{
public:
	// T[] System.Collections.Generic.List`1::_emptyArray
	UInt64U5BU5D_t7C6E32D10F47677C1CEF3C30F4E4CE95B3A633E2* ____emptyArray_5;

public:
	inline static int32_t get_offset_of__emptyArray_5() { return static_cast<int32_t>(offsetof(List_1_t1F1C2C7D92FB6DF4FCD88B0AB0919AEAB3B45F6B_StaticFields, ____emptyArray_5)); }
	inline UInt64U5BU5D_t7C6E32D10F47677C1CEF3C30F4E4CE95B3A633E2* get__emptyArray_5() const { return ____emptyArray_5; }
	inline UInt64U5BU5D_t7C6E32D10F47677C1CEF3C30F4E4CE95B3A633E2** get_address_of__emptyArray_5() { return &____emptyArray_5; }
	inline void set__emptyArray_5(UInt64U5BU5D_t7C6E32D10F47677C1CEF3C30F4E4CE95B3A633E2* value)
	{
		____emptyArray_5 = value;
		Il2CppCodeGenWriteBarrier((void**)(&____emptyArray_5), (void*)value);
	}
};


// System.Collections.ObjectModel.ReadOnlyCollection`1<System.Linq.Expressions.Expression>
struct ReadOnlyCollection_1_t7976DDE3F2FC7BAAF4F920193FF1B5BA33CCC2B5  : public RuntimeObject
{
public:
	// System.Collections.Generic.IList`1<T> System.Collections.ObjectModel.ReadOnlyCollection`1::list
	RuntimeObject* ___list_0;
	// System.Object System.Collections.ObjectModel.ReadOnlyCollection`1::_syncRoot
	RuntimeObject * ____syncRoot_1;

public:
	inline static int32_t get_offset_of_list_0() { return static_cast<int32_t>(offsetof(ReadOnlyCollection_1_t7976DDE3F2FC7BAAF4F920193FF1B5BA33CCC2B5, ___list_0)); }
	inline RuntimeObject* get_list_0() const { return ___list_0; }
	inline RuntimeObject** get_address_of_list_0() { return &___list_0; }
	inline void set_list_0(RuntimeObject* value)
	{
		___list_0 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___list_0), (void*)value);
	}

	inline static int32_t get_offset_of__syncRoot_1() { return static_cast<int32_t>(offsetof(ReadOnlyCollection_1_t7976DDE3F2FC7BAAF4F920193FF1B5BA33CCC2B5, ____syncRoot_1)); }
	inline RuntimeObject * get__syncRoot_1() const { return ____syncRoot_1; }
	inline RuntimeObject ** get_address_of__syncRoot_1() { return &____syncRoot_1; }
	inline void set__syncRoot_1(RuntimeObject * value)
	{
		____syncRoot_1 = value;
		Il2CppCodeGenWriteBarrier((void**)(&____syncRoot_1), (void*)value);
	}
};


// System.Collections.ObjectModel.ReadOnlyCollection`1<System.Linq.Expressions.ParameterExpression>
struct ReadOnlyCollection_1_t27106E268B51074ED9E2D5BB56A9C107EA4E8472  : public RuntimeObject
{
public:
	// System.Collections.Generic.IList`1<T> System.Collections.ObjectModel.ReadOnlyCollection`1::list
	RuntimeObject* ___list_0;
	// System.Object System.Collections.ObjectModel.ReadOnlyCollection`1::_syncRoot
	RuntimeObject * ____syncRoot_1;

public:
	inline static int32_t get_offset_of_list_0() { return static_cast<int32_t>(offsetof(ReadOnlyCollection_1_t27106E268B51074ED9E2D5BB56A9C107EA4E8472, ___list_0)); }
	inline RuntimeObject* get_list_0() const { return ___list_0; }
	inline RuntimeObject** get_address_of_list_0() { return &___list_0; }
	inline void set_list_0(RuntimeObject* value)
	{
		___list_0 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___list_0), (void*)value);
	}

	inline static int32_t get_offset_of__syncRoot_1() { return static_cast<int32_t>(offsetof(ReadOnlyCollection_1_t27106E268B51074ED9E2D5BB56A9C107EA4E8472, ____syncRoot_1)); }
	inline RuntimeObject * get__syncRoot_1() const { return ____syncRoot_1; }
	inline RuntimeObject ** get_address_of__syncRoot_1() { return &____syncRoot_1; }
	inline void set__syncRoot_1(RuntimeObject * value)
	{
		____syncRoot_1 = value;
		Il2CppCodeGenWriteBarrier((void**)(&____syncRoot_1), (void*)value);
	}
};


// System.Collections.Generic.Stack`1<System.Collections.Generic.HashSet`1<System.Linq.Expressions.ParameterExpression>>
struct Stack_1_t438C22E9DF33740A9BDB48CF9504B6E044484958  : public RuntimeObject
{
public:
	// T[] System.Collections.Generic.Stack`1::_array
	HashSet_1U5BU5D_tE80AA7A58195958A441A5F7F80D36F0F00AD9275* ____array_0;
	// System.Int32 System.Collections.Generic.Stack`1::_size
	int32_t ____size_1;
	// System.Int32 System.Collections.Generic.Stack`1::_version
	int32_t ____version_2;
	// System.Object System.Collections.Generic.Stack`1::_syncRoot
	RuntimeObject * ____syncRoot_3;

public:
	inline static int32_t get_offset_of__array_0() { return static_cast<int32_t>(offsetof(Stack_1_t438C22E9DF33740A9BDB48CF9504B6E044484958, ____array_0)); }
	inline HashSet_1U5BU5D_tE80AA7A58195958A441A5F7F80D36F0F00AD9275* get__array_0() const { return ____array_0; }
	inline HashSet_1U5BU5D_tE80AA7A58195958A441A5F7F80D36F0F00AD9275** get_address_of__array_0() { return &____array_0; }
	inline void set__array_0(HashSet_1U5BU5D_tE80AA7A58195958A441A5F7F80D36F0F00AD9275* value)
	{
		____array_0 = value;
		Il2CppCodeGenWriteBarrier((void**)(&____array_0), (void*)value);
	}

	inline static int32_t get_offset_of__size_1() { return static_cast<int32_t>(offsetof(Stack_1_t438C22E9DF33740A9BDB48CF9504B6E044484958, ____size_1)); }
	inline int32_t get__size_1() const { return ____size_1; }
	inline int32_t* get_address_of__size_1() { return &____size_1; }
	inline void set__size_1(int32_t value)
	{
		____size_1 = value;
	}

	inline static int32_t get_offset_of__version_2() { return static_cast<int32_t>(offsetof(Stack_1_t438C22E9DF33740A9BDB48CF9504B6E044484958, ____version_2)); }
	inline int32_t get__version_2() const { return ____version_2; }
	inline int32_t* get_address_of__version_2() { return &____version_2; }
	inline void set__version_2(int32_t value)
	{
		____version_2 = value;
	}

	inline static int32_t get_offset_of__syncRoot_3() { return static_cast<int32_t>(offsetof(Stack_1_t438C22E9DF33740A9BDB48CF9504B6E044484958, ____syncRoot_3)); }
	inline RuntimeObject * get__syncRoot_3() const { return ____syncRoot_3; }
	inline RuntimeObject ** get_address_of__syncRoot_3() { return &____syncRoot_3; }
	inline void set__syncRoot_3(RuntimeObject * value)
	{
		____syncRoot_3 = value;
		Il2CppCodeGenWriteBarrier((void**)(&____syncRoot_3), (void*)value);
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


// System.Dynamic.BindingRestrictions
struct BindingRestrictions_t03E14FA0517A70DEDA502032CE956595EF6E0DFC  : public RuntimeObject
{
public:

public:
};

struct BindingRestrictions_t03E14FA0517A70DEDA502032CE956595EF6E0DFC_StaticFields
{
public:
	// System.Dynamic.BindingRestrictions System.Dynamic.BindingRestrictions::Empty
	BindingRestrictions_t03E14FA0517A70DEDA502032CE956595EF6E0DFC * ___Empty_0;

public:
	inline static int32_t get_offset_of_Empty_0() { return static_cast<int32_t>(offsetof(BindingRestrictions_t03E14FA0517A70DEDA502032CE956595EF6E0DFC_StaticFields, ___Empty_0)); }
	inline BindingRestrictions_t03E14FA0517A70DEDA502032CE956595EF6E0DFC * get_Empty_0() const { return ___Empty_0; }
	inline BindingRestrictions_t03E14FA0517A70DEDA502032CE956595EF6E0DFC ** get_address_of_Empty_0() { return &___Empty_0; }
	inline void set_Empty_0(BindingRestrictions_t03E14FA0517A70DEDA502032CE956595EF6E0DFC * value)
	{
		___Empty_0 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___Empty_0), (void*)value);
	}
};


// System.Runtime.CompilerServices.CallSiteBinder
struct CallSiteBinder_tB923BEDF63B135302EB848D5BF2F18DD183ABD6C  : public RuntimeObject
{
public:
	// System.Collections.Generic.Dictionary`2<System.Type,System.Object> System.Runtime.CompilerServices.CallSiteBinder::Cache
	Dictionary_2_t1BCBBB8B077DB2EE009E3E0992AEAA34875A70FE * ___Cache_0;

public:
	inline static int32_t get_offset_of_Cache_0() { return static_cast<int32_t>(offsetof(CallSiteBinder_tB923BEDF63B135302EB848D5BF2F18DD183ABD6C, ___Cache_0)); }
	inline Dictionary_2_t1BCBBB8B077DB2EE009E3E0992AEAA34875A70FE * get_Cache_0() const { return ___Cache_0; }
	inline Dictionary_2_t1BCBBB8B077DB2EE009E3E0992AEAA34875A70FE ** get_address_of_Cache_0() { return &___Cache_0; }
	inline void set_Cache_0(Dictionary_2_t1BCBBB8B077DB2EE009E3E0992AEAA34875A70FE * value)
	{
		___Cache_0 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___Cache_0), (void*)value);
	}
};

struct CallSiteBinder_tB923BEDF63B135302EB848D5BF2F18DD183ABD6C_StaticFields
{
public:
	// System.Linq.Expressions.LabelTarget System.Runtime.CompilerServices.CallSiteBinder::<UpdateLabel>k__BackingField
	LabelTarget_t4E0B75FE6DAD05FC6651E53032D2C5F19D8E81D1 * ___U3CUpdateLabelU3Ek__BackingField_1;

public:
	inline static int32_t get_offset_of_U3CUpdateLabelU3Ek__BackingField_1() { return static_cast<int32_t>(offsetof(CallSiteBinder_tB923BEDF63B135302EB848D5BF2F18DD183ABD6C_StaticFields, ___U3CUpdateLabelU3Ek__BackingField_1)); }
	inline LabelTarget_t4E0B75FE6DAD05FC6651E53032D2C5F19D8E81D1 * get_U3CUpdateLabelU3Ek__BackingField_1() const { return ___U3CUpdateLabelU3Ek__BackingField_1; }
	inline LabelTarget_t4E0B75FE6DAD05FC6651E53032D2C5F19D8E81D1 ** get_address_of_U3CUpdateLabelU3Ek__BackingField_1() { return &___U3CUpdateLabelU3Ek__BackingField_1; }
	inline void set_U3CUpdateLabelU3Ek__BackingField_1(LabelTarget_t4E0B75FE6DAD05FC6651E53032D2C5F19D8E81D1 * value)
	{
		___U3CUpdateLabelU3Ek__BackingField_1 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___U3CUpdateLabelU3Ek__BackingField_1), (void*)value);
	}
};


// System.Dynamic.DynamicMetaObject
struct DynamicMetaObject_t5279001ADBFAB6EF015CAC54937F4E9F003881C3  : public RuntimeObject
{
public:
	// System.Linq.Expressions.Expression System.Dynamic.DynamicMetaObject::<Expression>k__BackingField
	Expression_t30A004209C10C2D9A9785B2F74EEED431A4D4660 * ___U3CExpressionU3Ek__BackingField_1;
	// System.Dynamic.BindingRestrictions System.Dynamic.DynamicMetaObject::<Restrictions>k__BackingField
	BindingRestrictions_t03E14FA0517A70DEDA502032CE956595EF6E0DFC * ___U3CRestrictionsU3Ek__BackingField_2;
	// System.Object System.Dynamic.DynamicMetaObject::<Value>k__BackingField
	RuntimeObject * ___U3CValueU3Ek__BackingField_3;
	// System.Boolean System.Dynamic.DynamicMetaObject::<HasValue>k__BackingField
	bool ___U3CHasValueU3Ek__BackingField_4;

public:
	inline static int32_t get_offset_of_U3CExpressionU3Ek__BackingField_1() { return static_cast<int32_t>(offsetof(DynamicMetaObject_t5279001ADBFAB6EF015CAC54937F4E9F003881C3, ___U3CExpressionU3Ek__BackingField_1)); }
	inline Expression_t30A004209C10C2D9A9785B2F74EEED431A4D4660 * get_U3CExpressionU3Ek__BackingField_1() const { return ___U3CExpressionU3Ek__BackingField_1; }
	inline Expression_t30A004209C10C2D9A9785B2F74EEED431A4D4660 ** get_address_of_U3CExpressionU3Ek__BackingField_1() { return &___U3CExpressionU3Ek__BackingField_1; }
	inline void set_U3CExpressionU3Ek__BackingField_1(Expression_t30A004209C10C2D9A9785B2F74EEED431A4D4660 * value)
	{
		___U3CExpressionU3Ek__BackingField_1 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___U3CExpressionU3Ek__BackingField_1), (void*)value);
	}

	inline static int32_t get_offset_of_U3CRestrictionsU3Ek__BackingField_2() { return static_cast<int32_t>(offsetof(DynamicMetaObject_t5279001ADBFAB6EF015CAC54937F4E9F003881C3, ___U3CRestrictionsU3Ek__BackingField_2)); }
	inline BindingRestrictions_t03E14FA0517A70DEDA502032CE956595EF6E0DFC * get_U3CRestrictionsU3Ek__BackingField_2() const { return ___U3CRestrictionsU3Ek__BackingField_2; }
	inline BindingRestrictions_t03E14FA0517A70DEDA502032CE956595EF6E0DFC ** get_address_of_U3CRestrictionsU3Ek__BackingField_2() { return &___U3CRestrictionsU3Ek__BackingField_2; }
	inline void set_U3CRestrictionsU3Ek__BackingField_2(BindingRestrictions_t03E14FA0517A70DEDA502032CE956595EF6E0DFC * value)
	{
		___U3CRestrictionsU3Ek__BackingField_2 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___U3CRestrictionsU3Ek__BackingField_2), (void*)value);
	}

	inline static int32_t get_offset_of_U3CValueU3Ek__BackingField_3() { return static_cast<int32_t>(offsetof(DynamicMetaObject_t5279001ADBFAB6EF015CAC54937F4E9F003881C3, ___U3CValueU3Ek__BackingField_3)); }
	inline RuntimeObject * get_U3CValueU3Ek__BackingField_3() const { return ___U3CValueU3Ek__BackingField_3; }
	inline RuntimeObject ** get_address_of_U3CValueU3Ek__BackingField_3() { return &___U3CValueU3Ek__BackingField_3; }
	inline void set_U3CValueU3Ek__BackingField_3(RuntimeObject * value)
	{
		___U3CValueU3Ek__BackingField_3 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___U3CValueU3Ek__BackingField_3), (void*)value);
	}

	inline static int32_t get_offset_of_U3CHasValueU3Ek__BackingField_4() { return static_cast<int32_t>(offsetof(DynamicMetaObject_t5279001ADBFAB6EF015CAC54937F4E9F003881C3, ___U3CHasValueU3Ek__BackingField_4)); }
	inline bool get_U3CHasValueU3Ek__BackingField_4() const { return ___U3CHasValueU3Ek__BackingField_4; }
	inline bool* get_address_of_U3CHasValueU3Ek__BackingField_4() { return &___U3CHasValueU3Ek__BackingField_4; }
	inline void set_U3CHasValueU3Ek__BackingField_4(bool value)
	{
		___U3CHasValueU3Ek__BackingField_4 = value;
	}
};

struct DynamicMetaObject_t5279001ADBFAB6EF015CAC54937F4E9F003881C3_StaticFields
{
public:
	// System.Dynamic.DynamicMetaObject[] System.Dynamic.DynamicMetaObject::EmptyMetaObjects
	DynamicMetaObjectU5BU5D_t42D6D3818EB1DC2B3EAC2434CA3E7489874E0421* ___EmptyMetaObjects_0;

public:
	inline static int32_t get_offset_of_EmptyMetaObjects_0() { return static_cast<int32_t>(offsetof(DynamicMetaObject_t5279001ADBFAB6EF015CAC54937F4E9F003881C3_StaticFields, ___EmptyMetaObjects_0)); }
	inline DynamicMetaObjectU5BU5D_t42D6D3818EB1DC2B3EAC2434CA3E7489874E0421* get_EmptyMetaObjects_0() const { return ___EmptyMetaObjects_0; }
	inline DynamicMetaObjectU5BU5D_t42D6D3818EB1DC2B3EAC2434CA3E7489874E0421** get_address_of_EmptyMetaObjects_0() { return &___EmptyMetaObjects_0; }
	inline void set_EmptyMetaObjects_0(DynamicMetaObjectU5BU5D_t42D6D3818EB1DC2B3EAC2434CA3E7489874E0421* value)
	{
		___EmptyMetaObjects_0 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___EmptyMetaObjects_0), (void*)value);
	}
};


// System.Dynamic.DynamicObject
struct DynamicObject_t97AD66D9AA9182AA4635DB778C9CE337E5E429D6  : public RuntimeObject
{
public:

public:
};


// System.Linq.Expressions.Expression
struct Expression_t30A004209C10C2D9A9785B2F74EEED431A4D4660  : public RuntimeObject
{
public:

public:
};

struct Expression_t30A004209C10C2D9A9785B2F74EEED431A4D4660_StaticFields
{
public:
	// System.Dynamic.Utils.CacheDict`2<System.Type,System.Reflection.MethodInfo> System.Linq.Expressions.Expression::s_lambdaDelegateCache
	CacheDict_2_t23833FEB97C42D87EBF4B5FE3B56AA1336D7B3CE * ___s_lambdaDelegateCache_0;
	// System.Dynamic.Utils.CacheDict`2<System.Type,System.Func`5<System.Linq.Expressions.Expression,System.String,System.Boolean,System.Collections.ObjectModel.ReadOnlyCollection`1<System.Linq.Expressions.ParameterExpression>,System.Linq.Expressions.LambdaExpression>> modreq(System.Runtime.CompilerServices.IsVolatile) System.Linq.Expressions.Expression::s_lambdaFactories
	CacheDict_2_t9FD97836EA998D29FFE492313652BD241E48F2C6 * ___s_lambdaFactories_1;
	// System.Runtime.CompilerServices.ConditionalWeakTable`2<System.Linq.Expressions.Expression,System.Linq.Expressions.Expression/ExtensionInfo> System.Linq.Expressions.Expression::s_legacyCtorSupportTable
	ConditionalWeakTable_2_t53315BD762B310982B9C8EEAA1BEB06E4E8D0815 * ___s_legacyCtorSupportTable_2;

public:
	inline static int32_t get_offset_of_s_lambdaDelegateCache_0() { return static_cast<int32_t>(offsetof(Expression_t30A004209C10C2D9A9785B2F74EEED431A4D4660_StaticFields, ___s_lambdaDelegateCache_0)); }
	inline CacheDict_2_t23833FEB97C42D87EBF4B5FE3B56AA1336D7B3CE * get_s_lambdaDelegateCache_0() const { return ___s_lambdaDelegateCache_0; }
	inline CacheDict_2_t23833FEB97C42D87EBF4B5FE3B56AA1336D7B3CE ** get_address_of_s_lambdaDelegateCache_0() { return &___s_lambdaDelegateCache_0; }
	inline void set_s_lambdaDelegateCache_0(CacheDict_2_t23833FEB97C42D87EBF4B5FE3B56AA1336D7B3CE * value)
	{
		___s_lambdaDelegateCache_0 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___s_lambdaDelegateCache_0), (void*)value);
	}

	inline static int32_t get_offset_of_s_lambdaFactories_1() { return static_cast<int32_t>(offsetof(Expression_t30A004209C10C2D9A9785B2F74EEED431A4D4660_StaticFields, ___s_lambdaFactories_1)); }
	inline CacheDict_2_t9FD97836EA998D29FFE492313652BD241E48F2C6 * get_s_lambdaFactories_1() const { return ___s_lambdaFactories_1; }
	inline CacheDict_2_t9FD97836EA998D29FFE492313652BD241E48F2C6 ** get_address_of_s_lambdaFactories_1() { return &___s_lambdaFactories_1; }
	inline void set_s_lambdaFactories_1(CacheDict_2_t9FD97836EA998D29FFE492313652BD241E48F2C6 * value)
	{
		___s_lambdaFactories_1 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___s_lambdaFactories_1), (void*)value);
	}

	inline static int32_t get_offset_of_s_legacyCtorSupportTable_2() { return static_cast<int32_t>(offsetof(Expression_t30A004209C10C2D9A9785B2F74EEED431A4D4660_StaticFields, ___s_legacyCtorSupportTable_2)); }
	inline ConditionalWeakTable_2_t53315BD762B310982B9C8EEAA1BEB06E4E8D0815 * get_s_legacyCtorSupportTable_2() const { return ___s_legacyCtorSupportTable_2; }
	inline ConditionalWeakTable_2_t53315BD762B310982B9C8EEAA1BEB06E4E8D0815 ** get_address_of_s_legacyCtorSupportTable_2() { return &___s_legacyCtorSupportTable_2; }
	inline void set_s_legacyCtorSupportTable_2(ConditionalWeakTable_2_t53315BD762B310982B9C8EEAA1BEB06E4E8D0815 * value)
	{
		___s_legacyCtorSupportTable_2 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___s_legacyCtorSupportTable_2), (void*)value);
	}
};


// System.Linq.Expressions.ExpressionVisitor
struct ExpressionVisitor_tD098DE8A366FBBB58C498C4EFF8B003FCA726DF4  : public RuntimeObject
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


// System.Linq.Expressions.Utils
struct Utils_t98C8733198C84566DF6847E887A57D45326CE485  : public RuntimeObject
{
public:

public:
};

struct Utils_t98C8733198C84566DF6847E887A57D45326CE485_StaticFields
{
public:
	// System.Object System.Linq.Expressions.Utils::BoxedFalse
	RuntimeObject * ___BoxedFalse_0;
	// System.Object System.Linq.Expressions.Utils::BoxedTrue
	RuntimeObject * ___BoxedTrue_1;
	// System.Object System.Linq.Expressions.Utils::BoxedIntM1
	RuntimeObject * ___BoxedIntM1_2;
	// System.Object System.Linq.Expressions.Utils::BoxedInt0
	RuntimeObject * ___BoxedInt0_3;
	// System.Object System.Linq.Expressions.Utils::BoxedInt1
	RuntimeObject * ___BoxedInt1_4;
	// System.Object System.Linq.Expressions.Utils::BoxedInt2
	RuntimeObject * ___BoxedInt2_5;
	// System.Object System.Linq.Expressions.Utils::BoxedInt3
	RuntimeObject * ___BoxedInt3_6;
	// System.Object System.Linq.Expressions.Utils::BoxedDefaultSByte
	RuntimeObject * ___BoxedDefaultSByte_7;
	// System.Object System.Linq.Expressions.Utils::BoxedDefaultChar
	RuntimeObject * ___BoxedDefaultChar_8;
	// System.Object System.Linq.Expressions.Utils::BoxedDefaultInt16
	RuntimeObject * ___BoxedDefaultInt16_9;
	// System.Object System.Linq.Expressions.Utils::BoxedDefaultInt64
	RuntimeObject * ___BoxedDefaultInt64_10;
	// System.Object System.Linq.Expressions.Utils::BoxedDefaultByte
	RuntimeObject * ___BoxedDefaultByte_11;
	// System.Object System.Linq.Expressions.Utils::BoxedDefaultUInt16
	RuntimeObject * ___BoxedDefaultUInt16_12;
	// System.Object System.Linq.Expressions.Utils::BoxedDefaultUInt32
	RuntimeObject * ___BoxedDefaultUInt32_13;
	// System.Object System.Linq.Expressions.Utils::BoxedDefaultUInt64
	RuntimeObject * ___BoxedDefaultUInt64_14;
	// System.Object System.Linq.Expressions.Utils::BoxedDefaultSingle
	RuntimeObject * ___BoxedDefaultSingle_15;
	// System.Object System.Linq.Expressions.Utils::BoxedDefaultDouble
	RuntimeObject * ___BoxedDefaultDouble_16;
	// System.Object System.Linq.Expressions.Utils::BoxedDefaultDecimal
	RuntimeObject * ___BoxedDefaultDecimal_17;
	// System.Object System.Linq.Expressions.Utils::BoxedDefaultDateTime
	RuntimeObject * ___BoxedDefaultDateTime_18;
	// System.Linq.Expressions.ConstantExpression System.Linq.Expressions.Utils::s_true
	ConstantExpression_tE22239C4AE815AF9B4647E026E802623F433F0FB * ___s_true_19;
	// System.Linq.Expressions.ConstantExpression System.Linq.Expressions.Utils::s_false
	ConstantExpression_tE22239C4AE815AF9B4647E026E802623F433F0FB * ___s_false_20;
	// System.Linq.Expressions.ConstantExpression System.Linq.Expressions.Utils::s_m1
	ConstantExpression_tE22239C4AE815AF9B4647E026E802623F433F0FB * ___s_m1_21;
	// System.Linq.Expressions.ConstantExpression System.Linq.Expressions.Utils::s_0
	ConstantExpression_tE22239C4AE815AF9B4647E026E802623F433F0FB * ___s_0_22;
	// System.Linq.Expressions.ConstantExpression System.Linq.Expressions.Utils::s_1
	ConstantExpression_tE22239C4AE815AF9B4647E026E802623F433F0FB * ___s_1_23;
	// System.Linq.Expressions.ConstantExpression System.Linq.Expressions.Utils::s_2
	ConstantExpression_tE22239C4AE815AF9B4647E026E802623F433F0FB * ___s_2_24;
	// System.Linq.Expressions.ConstantExpression System.Linq.Expressions.Utils::s_3
	ConstantExpression_tE22239C4AE815AF9B4647E026E802623F433F0FB * ___s_3_25;
	// System.Linq.Expressions.DefaultExpression System.Linq.Expressions.Utils::Empty
	DefaultExpression_t3FC1DD4F4C518F7FDF62C04BB3BF78B10D654D46 * ___Empty_26;
	// System.Linq.Expressions.ConstantExpression System.Linq.Expressions.Utils::Null
	ConstantExpression_tE22239C4AE815AF9B4647E026E802623F433F0FB * ___Null_27;

public:
	inline static int32_t get_offset_of_BoxedFalse_0() { return static_cast<int32_t>(offsetof(Utils_t98C8733198C84566DF6847E887A57D45326CE485_StaticFields, ___BoxedFalse_0)); }
	inline RuntimeObject * get_BoxedFalse_0() const { return ___BoxedFalse_0; }
	inline RuntimeObject ** get_address_of_BoxedFalse_0() { return &___BoxedFalse_0; }
	inline void set_BoxedFalse_0(RuntimeObject * value)
	{
		___BoxedFalse_0 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___BoxedFalse_0), (void*)value);
	}

	inline static int32_t get_offset_of_BoxedTrue_1() { return static_cast<int32_t>(offsetof(Utils_t98C8733198C84566DF6847E887A57D45326CE485_StaticFields, ___BoxedTrue_1)); }
	inline RuntimeObject * get_BoxedTrue_1() const { return ___BoxedTrue_1; }
	inline RuntimeObject ** get_address_of_BoxedTrue_1() { return &___BoxedTrue_1; }
	inline void set_BoxedTrue_1(RuntimeObject * value)
	{
		___BoxedTrue_1 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___BoxedTrue_1), (void*)value);
	}

	inline static int32_t get_offset_of_BoxedIntM1_2() { return static_cast<int32_t>(offsetof(Utils_t98C8733198C84566DF6847E887A57D45326CE485_StaticFields, ___BoxedIntM1_2)); }
	inline RuntimeObject * get_BoxedIntM1_2() const { return ___BoxedIntM1_2; }
	inline RuntimeObject ** get_address_of_BoxedIntM1_2() { return &___BoxedIntM1_2; }
	inline void set_BoxedIntM1_2(RuntimeObject * value)
	{
		___BoxedIntM1_2 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___BoxedIntM1_2), (void*)value);
	}

	inline static int32_t get_offset_of_BoxedInt0_3() { return static_cast<int32_t>(offsetof(Utils_t98C8733198C84566DF6847E887A57D45326CE485_StaticFields, ___BoxedInt0_3)); }
	inline RuntimeObject * get_BoxedInt0_3() const { return ___BoxedInt0_3; }
	inline RuntimeObject ** get_address_of_BoxedInt0_3() { return &___BoxedInt0_3; }
	inline void set_BoxedInt0_3(RuntimeObject * value)
	{
		___BoxedInt0_3 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___BoxedInt0_3), (void*)value);
	}

	inline static int32_t get_offset_of_BoxedInt1_4() { return static_cast<int32_t>(offsetof(Utils_t98C8733198C84566DF6847E887A57D45326CE485_StaticFields, ___BoxedInt1_4)); }
	inline RuntimeObject * get_BoxedInt1_4() const { return ___BoxedInt1_4; }
	inline RuntimeObject ** get_address_of_BoxedInt1_4() { return &___BoxedInt1_4; }
	inline void set_BoxedInt1_4(RuntimeObject * value)
	{
		___BoxedInt1_4 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___BoxedInt1_4), (void*)value);
	}

	inline static int32_t get_offset_of_BoxedInt2_5() { return static_cast<int32_t>(offsetof(Utils_t98C8733198C84566DF6847E887A57D45326CE485_StaticFields, ___BoxedInt2_5)); }
	inline RuntimeObject * get_BoxedInt2_5() const { return ___BoxedInt2_5; }
	inline RuntimeObject ** get_address_of_BoxedInt2_5() { return &___BoxedInt2_5; }
	inline void set_BoxedInt2_5(RuntimeObject * value)
	{
		___BoxedInt2_5 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___BoxedInt2_5), (void*)value);
	}

	inline static int32_t get_offset_of_BoxedInt3_6() { return static_cast<int32_t>(offsetof(Utils_t98C8733198C84566DF6847E887A57D45326CE485_StaticFields, ___BoxedInt3_6)); }
	inline RuntimeObject * get_BoxedInt3_6() const { return ___BoxedInt3_6; }
	inline RuntimeObject ** get_address_of_BoxedInt3_6() { return &___BoxedInt3_6; }
	inline void set_BoxedInt3_6(RuntimeObject * value)
	{
		___BoxedInt3_6 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___BoxedInt3_6), (void*)value);
	}

	inline static int32_t get_offset_of_BoxedDefaultSByte_7() { return static_cast<int32_t>(offsetof(Utils_t98C8733198C84566DF6847E887A57D45326CE485_StaticFields, ___BoxedDefaultSByte_7)); }
	inline RuntimeObject * get_BoxedDefaultSByte_7() const { return ___BoxedDefaultSByte_7; }
	inline RuntimeObject ** get_address_of_BoxedDefaultSByte_7() { return &___BoxedDefaultSByte_7; }
	inline void set_BoxedDefaultSByte_7(RuntimeObject * value)
	{
		___BoxedDefaultSByte_7 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___BoxedDefaultSByte_7), (void*)value);
	}

	inline static int32_t get_offset_of_BoxedDefaultChar_8() { return static_cast<int32_t>(offsetof(Utils_t98C8733198C84566DF6847E887A57D45326CE485_StaticFields, ___BoxedDefaultChar_8)); }
	inline RuntimeObject * get_BoxedDefaultChar_8() const { return ___BoxedDefaultChar_8; }
	inline RuntimeObject ** get_address_of_BoxedDefaultChar_8() { return &___BoxedDefaultChar_8; }
	inline void set_BoxedDefaultChar_8(RuntimeObject * value)
	{
		___BoxedDefaultChar_8 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___BoxedDefaultChar_8), (void*)value);
	}

	inline static int32_t get_offset_of_BoxedDefaultInt16_9() { return static_cast<int32_t>(offsetof(Utils_t98C8733198C84566DF6847E887A57D45326CE485_StaticFields, ___BoxedDefaultInt16_9)); }
	inline RuntimeObject * get_BoxedDefaultInt16_9() const { return ___BoxedDefaultInt16_9; }
	inline RuntimeObject ** get_address_of_BoxedDefaultInt16_9() { return &___BoxedDefaultInt16_9; }
	inline void set_BoxedDefaultInt16_9(RuntimeObject * value)
	{
		___BoxedDefaultInt16_9 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___BoxedDefaultInt16_9), (void*)value);
	}

	inline static int32_t get_offset_of_BoxedDefaultInt64_10() { return static_cast<int32_t>(offsetof(Utils_t98C8733198C84566DF6847E887A57D45326CE485_StaticFields, ___BoxedDefaultInt64_10)); }
	inline RuntimeObject * get_BoxedDefaultInt64_10() const { return ___BoxedDefaultInt64_10; }
	inline RuntimeObject ** get_address_of_BoxedDefaultInt64_10() { return &___BoxedDefaultInt64_10; }
	inline void set_BoxedDefaultInt64_10(RuntimeObject * value)
	{
		___BoxedDefaultInt64_10 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___BoxedDefaultInt64_10), (void*)value);
	}

	inline static int32_t get_offset_of_BoxedDefaultByte_11() { return static_cast<int32_t>(offsetof(Utils_t98C8733198C84566DF6847E887A57D45326CE485_StaticFields, ___BoxedDefaultByte_11)); }
	inline RuntimeObject * get_BoxedDefaultByte_11() const { return ___BoxedDefaultByte_11; }
	inline RuntimeObject ** get_address_of_BoxedDefaultByte_11() { return &___BoxedDefaultByte_11; }
	inline void set_BoxedDefaultByte_11(RuntimeObject * value)
	{
		___BoxedDefaultByte_11 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___BoxedDefaultByte_11), (void*)value);
	}

	inline static int32_t get_offset_of_BoxedDefaultUInt16_12() { return static_cast<int32_t>(offsetof(Utils_t98C8733198C84566DF6847E887A57D45326CE485_StaticFields, ___BoxedDefaultUInt16_12)); }
	inline RuntimeObject * get_BoxedDefaultUInt16_12() const { return ___BoxedDefaultUInt16_12; }
	inline RuntimeObject ** get_address_of_BoxedDefaultUInt16_12() { return &___BoxedDefaultUInt16_12; }
	inline void set_BoxedDefaultUInt16_12(RuntimeObject * value)
	{
		___BoxedDefaultUInt16_12 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___BoxedDefaultUInt16_12), (void*)value);
	}

	inline static int32_t get_offset_of_BoxedDefaultUInt32_13() { return static_cast<int32_t>(offsetof(Utils_t98C8733198C84566DF6847E887A57D45326CE485_StaticFields, ___BoxedDefaultUInt32_13)); }
	inline RuntimeObject * get_BoxedDefaultUInt32_13() const { return ___BoxedDefaultUInt32_13; }
	inline RuntimeObject ** get_address_of_BoxedDefaultUInt32_13() { return &___BoxedDefaultUInt32_13; }
	inline void set_BoxedDefaultUInt32_13(RuntimeObject * value)
	{
		___BoxedDefaultUInt32_13 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___BoxedDefaultUInt32_13), (void*)value);
	}

	inline static int32_t get_offset_of_BoxedDefaultUInt64_14() { return static_cast<int32_t>(offsetof(Utils_t98C8733198C84566DF6847E887A57D45326CE485_StaticFields, ___BoxedDefaultUInt64_14)); }
	inline RuntimeObject * get_BoxedDefaultUInt64_14() const { return ___BoxedDefaultUInt64_14; }
	inline RuntimeObject ** get_address_of_BoxedDefaultUInt64_14() { return &___BoxedDefaultUInt64_14; }
	inline void set_BoxedDefaultUInt64_14(RuntimeObject * value)
	{
		___BoxedDefaultUInt64_14 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___BoxedDefaultUInt64_14), (void*)value);
	}

	inline static int32_t get_offset_of_BoxedDefaultSingle_15() { return static_cast<int32_t>(offsetof(Utils_t98C8733198C84566DF6847E887A57D45326CE485_StaticFields, ___BoxedDefaultSingle_15)); }
	inline RuntimeObject * get_BoxedDefaultSingle_15() const { return ___BoxedDefaultSingle_15; }
	inline RuntimeObject ** get_address_of_BoxedDefaultSingle_15() { return &___BoxedDefaultSingle_15; }
	inline void set_BoxedDefaultSingle_15(RuntimeObject * value)
	{
		___BoxedDefaultSingle_15 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___BoxedDefaultSingle_15), (void*)value);
	}

	inline static int32_t get_offset_of_BoxedDefaultDouble_16() { return static_cast<int32_t>(offsetof(Utils_t98C8733198C84566DF6847E887A57D45326CE485_StaticFields, ___BoxedDefaultDouble_16)); }
	inline RuntimeObject * get_BoxedDefaultDouble_16() const { return ___BoxedDefaultDouble_16; }
	inline RuntimeObject ** get_address_of_BoxedDefaultDouble_16() { return &___BoxedDefaultDouble_16; }
	inline void set_BoxedDefaultDouble_16(RuntimeObject * value)
	{
		___BoxedDefaultDouble_16 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___BoxedDefaultDouble_16), (void*)value);
	}

	inline static int32_t get_offset_of_BoxedDefaultDecimal_17() { return static_cast<int32_t>(offsetof(Utils_t98C8733198C84566DF6847E887A57D45326CE485_StaticFields, ___BoxedDefaultDecimal_17)); }
	inline RuntimeObject * get_BoxedDefaultDecimal_17() const { return ___BoxedDefaultDecimal_17; }
	inline RuntimeObject ** get_address_of_BoxedDefaultDecimal_17() { return &___BoxedDefaultDecimal_17; }
	inline void set_BoxedDefaultDecimal_17(RuntimeObject * value)
	{
		___BoxedDefaultDecimal_17 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___BoxedDefaultDecimal_17), (void*)value);
	}

	inline static int32_t get_offset_of_BoxedDefaultDateTime_18() { return static_cast<int32_t>(offsetof(Utils_t98C8733198C84566DF6847E887A57D45326CE485_StaticFields, ___BoxedDefaultDateTime_18)); }
	inline RuntimeObject * get_BoxedDefaultDateTime_18() const { return ___BoxedDefaultDateTime_18; }
	inline RuntimeObject ** get_address_of_BoxedDefaultDateTime_18() { return &___BoxedDefaultDateTime_18; }
	inline void set_BoxedDefaultDateTime_18(RuntimeObject * value)
	{
		___BoxedDefaultDateTime_18 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___BoxedDefaultDateTime_18), (void*)value);
	}

	inline static int32_t get_offset_of_s_true_19() { return static_cast<int32_t>(offsetof(Utils_t98C8733198C84566DF6847E887A57D45326CE485_StaticFields, ___s_true_19)); }
	inline ConstantExpression_tE22239C4AE815AF9B4647E026E802623F433F0FB * get_s_true_19() const { return ___s_true_19; }
	inline ConstantExpression_tE22239C4AE815AF9B4647E026E802623F433F0FB ** get_address_of_s_true_19() { return &___s_true_19; }
	inline void set_s_true_19(ConstantExpression_tE22239C4AE815AF9B4647E026E802623F433F0FB * value)
	{
		___s_true_19 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___s_true_19), (void*)value);
	}

	inline static int32_t get_offset_of_s_false_20() { return static_cast<int32_t>(offsetof(Utils_t98C8733198C84566DF6847E887A57D45326CE485_StaticFields, ___s_false_20)); }
	inline ConstantExpression_tE22239C4AE815AF9B4647E026E802623F433F0FB * get_s_false_20() const { return ___s_false_20; }
	inline ConstantExpression_tE22239C4AE815AF9B4647E026E802623F433F0FB ** get_address_of_s_false_20() { return &___s_false_20; }
	inline void set_s_false_20(ConstantExpression_tE22239C4AE815AF9B4647E026E802623F433F0FB * value)
	{
		___s_false_20 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___s_false_20), (void*)value);
	}

	inline static int32_t get_offset_of_s_m1_21() { return static_cast<int32_t>(offsetof(Utils_t98C8733198C84566DF6847E887A57D45326CE485_StaticFields, ___s_m1_21)); }
	inline ConstantExpression_tE22239C4AE815AF9B4647E026E802623F433F0FB * get_s_m1_21() const { return ___s_m1_21; }
	inline ConstantExpression_tE22239C4AE815AF9B4647E026E802623F433F0FB ** get_address_of_s_m1_21() { return &___s_m1_21; }
	inline void set_s_m1_21(ConstantExpression_tE22239C4AE815AF9B4647E026E802623F433F0FB * value)
	{
		___s_m1_21 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___s_m1_21), (void*)value);
	}

	inline static int32_t get_offset_of_s_0_22() { return static_cast<int32_t>(offsetof(Utils_t98C8733198C84566DF6847E887A57D45326CE485_StaticFields, ___s_0_22)); }
	inline ConstantExpression_tE22239C4AE815AF9B4647E026E802623F433F0FB * get_s_0_22() const { return ___s_0_22; }
	inline ConstantExpression_tE22239C4AE815AF9B4647E026E802623F433F0FB ** get_address_of_s_0_22() { return &___s_0_22; }
	inline void set_s_0_22(ConstantExpression_tE22239C4AE815AF9B4647E026E802623F433F0FB * value)
	{
		___s_0_22 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___s_0_22), (void*)value);
	}

	inline static int32_t get_offset_of_s_1_23() { return static_cast<int32_t>(offsetof(Utils_t98C8733198C84566DF6847E887A57D45326CE485_StaticFields, ___s_1_23)); }
	inline ConstantExpression_tE22239C4AE815AF9B4647E026E802623F433F0FB * get_s_1_23() const { return ___s_1_23; }
	inline ConstantExpression_tE22239C4AE815AF9B4647E026E802623F433F0FB ** get_address_of_s_1_23() { return &___s_1_23; }
	inline void set_s_1_23(ConstantExpression_tE22239C4AE815AF9B4647E026E802623F433F0FB * value)
	{
		___s_1_23 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___s_1_23), (void*)value);
	}

	inline static int32_t get_offset_of_s_2_24() { return static_cast<int32_t>(offsetof(Utils_t98C8733198C84566DF6847E887A57D45326CE485_StaticFields, ___s_2_24)); }
	inline ConstantExpression_tE22239C4AE815AF9B4647E026E802623F433F0FB * get_s_2_24() const { return ___s_2_24; }
	inline ConstantExpression_tE22239C4AE815AF9B4647E026E802623F433F0FB ** get_address_of_s_2_24() { return &___s_2_24; }
	inline void set_s_2_24(ConstantExpression_tE22239C4AE815AF9B4647E026E802623F433F0FB * value)
	{
		___s_2_24 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___s_2_24), (void*)value);
	}

	inline static int32_t get_offset_of_s_3_25() { return static_cast<int32_t>(offsetof(Utils_t98C8733198C84566DF6847E887A57D45326CE485_StaticFields, ___s_3_25)); }
	inline ConstantExpression_tE22239C4AE815AF9B4647E026E802623F433F0FB * get_s_3_25() const { return ___s_3_25; }
	inline ConstantExpression_tE22239C4AE815AF9B4647E026E802623F433F0FB ** get_address_of_s_3_25() { return &___s_3_25; }
	inline void set_s_3_25(ConstantExpression_tE22239C4AE815AF9B4647E026E802623F433F0FB * value)
	{
		___s_3_25 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___s_3_25), (void*)value);
	}

	inline static int32_t get_offset_of_Empty_26() { return static_cast<int32_t>(offsetof(Utils_t98C8733198C84566DF6847E887A57D45326CE485_StaticFields, ___Empty_26)); }
	inline DefaultExpression_t3FC1DD4F4C518F7FDF62C04BB3BF78B10D654D46 * get_Empty_26() const { return ___Empty_26; }
	inline DefaultExpression_t3FC1DD4F4C518F7FDF62C04BB3BF78B10D654D46 ** get_address_of_Empty_26() { return &___Empty_26; }
	inline void set_Empty_26(DefaultExpression_t3FC1DD4F4C518F7FDF62C04BB3BF78B10D654D46 * value)
	{
		___Empty_26 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___Empty_26), (void*)value);
	}

	inline static int32_t get_offset_of_Null_27() { return static_cast<int32_t>(offsetof(Utils_t98C8733198C84566DF6847E887A57D45326CE485_StaticFields, ___Null_27)); }
	inline ConstantExpression_tE22239C4AE815AF9B4647E026E802623F433F0FB * get_Null_27() const { return ___Null_27; }
	inline ConstantExpression_tE22239C4AE815AF9B4647E026E802623F433F0FB ** get_address_of_Null_27() { return &___Null_27; }
	inline void set_Null_27(ConstantExpression_tE22239C4AE815AF9B4647E026E802623F433F0FB * value)
	{
		___Null_27 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___Null_27), (void*)value);
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

// System.Xml.Schema.XmlValueConverter
struct XmlValueConverter_t18B2DCDB3B3F7609F3E43D5C46D2095BD09E6763  : public RuntimeObject
{
public:

public:
};


// System.Runtime.Serialization.XmlWriterDelegator
struct XmlWriterDelegator_t14F933DC94CDCA5AA29C259565A8C4C0E41613BC  : public RuntimeObject
{
public:
	// System.Xml.XmlWriter System.Runtime.Serialization.XmlWriterDelegator::writer
	XmlWriter_t676293C138D2D0DAB9C1BC16A7BEE618391C5B2D * ___writer_0;
	// System.Xml.XmlDictionaryWriter System.Runtime.Serialization.XmlWriterDelegator::dictionaryWriter
	XmlDictionaryWriter_t7DBB53A3CB2D175E2753690C4032D28AD7B23B83 * ___dictionaryWriter_1;
	// System.Int32 System.Runtime.Serialization.XmlWriterDelegator::depth
	int32_t ___depth_2;
	// System.Int32 System.Runtime.Serialization.XmlWriterDelegator::prefixes
	int32_t ___prefixes_3;

public:
	inline static int32_t get_offset_of_writer_0() { return static_cast<int32_t>(offsetof(XmlWriterDelegator_t14F933DC94CDCA5AA29C259565A8C4C0E41613BC, ___writer_0)); }
	inline XmlWriter_t676293C138D2D0DAB9C1BC16A7BEE618391C5B2D * get_writer_0() const { return ___writer_0; }
	inline XmlWriter_t676293C138D2D0DAB9C1BC16A7BEE618391C5B2D ** get_address_of_writer_0() { return &___writer_0; }
	inline void set_writer_0(XmlWriter_t676293C138D2D0DAB9C1BC16A7BEE618391C5B2D * value)
	{
		___writer_0 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___writer_0), (void*)value);
	}

	inline static int32_t get_offset_of_dictionaryWriter_1() { return static_cast<int32_t>(offsetof(XmlWriterDelegator_t14F933DC94CDCA5AA29C259565A8C4C0E41613BC, ___dictionaryWriter_1)); }
	inline XmlDictionaryWriter_t7DBB53A3CB2D175E2753690C4032D28AD7B23B83 * get_dictionaryWriter_1() const { return ___dictionaryWriter_1; }
	inline XmlDictionaryWriter_t7DBB53A3CB2D175E2753690C4032D28AD7B23B83 ** get_address_of_dictionaryWriter_1() { return &___dictionaryWriter_1; }
	inline void set_dictionaryWriter_1(XmlDictionaryWriter_t7DBB53A3CB2D175E2753690C4032D28AD7B23B83 * value)
	{
		___dictionaryWriter_1 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___dictionaryWriter_1), (void*)value);
	}

	inline static int32_t get_offset_of_depth_2() { return static_cast<int32_t>(offsetof(XmlWriterDelegator_t14F933DC94CDCA5AA29C259565A8C4C0E41613BC, ___depth_2)); }
	inline int32_t get_depth_2() const { return ___depth_2; }
	inline int32_t* get_address_of_depth_2() { return &___depth_2; }
	inline void set_depth_2(int32_t value)
	{
		___depth_2 = value;
	}

	inline static int32_t get_offset_of_prefixes_3() { return static_cast<int32_t>(offsetof(XmlWriterDelegator_t14F933DC94CDCA5AA29C259565A8C4C0E41613BC, ___prefixes_3)); }
	inline int32_t get_prefixes_3() const { return ___prefixes_3; }
	inline int32_t* get_address_of_prefixes_3() { return &___prefixes_3; }
	inline void set_prefixes_3(int32_t value)
	{
		___prefixes_3 = value;
	}
};


// UnityEngine._AndroidJNIHelper
struct _AndroidJNIHelper_t664F535B46589884A627F66F98A451D1CD48F76B  : public RuntimeObject
{
public:

public:
};


// System.Runtime.InteropServices.WindowsRuntime.WindowsRuntimeMarshal/ManagedEventRegistrationImpl
struct ManagedEventRegistrationImpl_t68BCFDC6DFC89A0F8CF53836672DD1F41C47CEEB  : public RuntimeObject
{
public:

public:
};

struct ManagedEventRegistrationImpl_t68BCFDC6DFC89A0F8CF53836672DD1F41C47CEEB_StaticFields
{
public:
	// System.Runtime.CompilerServices.ConditionalWeakTable`2<System.Object,System.Collections.Generic.Dictionary`2<System.Reflection.MethodInfo,System.Collections.Generic.Dictionary`2<System.Object,System.Runtime.InteropServices.WindowsRuntime.WindowsRuntimeMarshal/EventRegistrationTokenList>>> modreq(System.Runtime.CompilerServices.IsVolatile) System.Runtime.InteropServices.WindowsRuntime.WindowsRuntimeMarshal/ManagedEventRegistrationImpl::s_eventRegistrations
	ConditionalWeakTable_2_t15FB672E1FCD9A86D386950CA4AB07A87DFC64DC * ___s_eventRegistrations_0;

public:
	inline static int32_t get_offset_of_s_eventRegistrations_0() { return static_cast<int32_t>(offsetof(ManagedEventRegistrationImpl_t68BCFDC6DFC89A0F8CF53836672DD1F41C47CEEB_StaticFields, ___s_eventRegistrations_0)); }
	inline ConditionalWeakTable_2_t15FB672E1FCD9A86D386950CA4AB07A87DFC64DC * get_s_eventRegistrations_0() const { return ___s_eventRegistrations_0; }
	inline ConditionalWeakTable_2_t15FB672E1FCD9A86D386950CA4AB07A87DFC64DC ** get_address_of_s_eventRegistrations_0() { return &___s_eventRegistrations_0; }
	inline void set_s_eventRegistrations_0(ConditionalWeakTable_2_t15FB672E1FCD9A86D386950CA4AB07A87DFC64DC * value)
	{
		___s_eventRegistrations_0 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___s_eventRegistrations_0), (void*)value);
	}
};


// System.Runtime.InteropServices.WindowsRuntime.WindowsRuntimeMarshal/NativeOrStaticEventRegistrationImpl
struct NativeOrStaticEventRegistrationImpl_tCA81B1033AD6FCE9E03C1E043758D4A1815B90E4  : public RuntimeObject
{
public:

public:
};

struct NativeOrStaticEventRegistrationImpl_tCA81B1033AD6FCE9E03C1E043758D4A1815B90E4_StaticFields
{
public:
	// System.Collections.Generic.Dictionary`2<System.Runtime.InteropServices.WindowsRuntime.WindowsRuntimeMarshal/NativeOrStaticEventRegistrationImpl/EventCacheKey,System.Runtime.InteropServices.WindowsRuntime.WindowsRuntimeMarshal/NativeOrStaticEventRegistrationImpl/EventCacheEntry> modreq(System.Runtime.CompilerServices.IsVolatile) System.Runtime.InteropServices.WindowsRuntime.WindowsRuntimeMarshal/NativeOrStaticEventRegistrationImpl::s_eventRegistrations
	Dictionary_2_t0986F9D82B8D09D448B013D5071D700FA1CF22C8 * ___s_eventRegistrations_0;
	// System.Runtime.InteropServices.WindowsRuntime.WindowsRuntimeMarshal/NativeOrStaticEventRegistrationImpl/MyReaderWriterLock modreq(System.Runtime.CompilerServices.IsVolatile) System.Runtime.InteropServices.WindowsRuntime.WindowsRuntimeMarshal/NativeOrStaticEventRegistrationImpl::s_eventCacheRWLock
	MyReaderWriterLock_t0EAF7040A5BCE7C816030732D088A8DB81FB97AD * ___s_eventCacheRWLock_1;

public:
	inline static int32_t get_offset_of_s_eventRegistrations_0() { return static_cast<int32_t>(offsetof(NativeOrStaticEventRegistrationImpl_tCA81B1033AD6FCE9E03C1E043758D4A1815B90E4_StaticFields, ___s_eventRegistrations_0)); }
	inline Dictionary_2_t0986F9D82B8D09D448B013D5071D700FA1CF22C8 * get_s_eventRegistrations_0() const { return ___s_eventRegistrations_0; }
	inline Dictionary_2_t0986F9D82B8D09D448B013D5071D700FA1CF22C8 ** get_address_of_s_eventRegistrations_0() { return &___s_eventRegistrations_0; }
	inline void set_s_eventRegistrations_0(Dictionary_2_t0986F9D82B8D09D448B013D5071D700FA1CF22C8 * value)
	{
		___s_eventRegistrations_0 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___s_eventRegistrations_0), (void*)value);
	}

	inline static int32_t get_offset_of_s_eventCacheRWLock_1() { return static_cast<int32_t>(offsetof(NativeOrStaticEventRegistrationImpl_tCA81B1033AD6FCE9E03C1E043758D4A1815B90E4_StaticFields, ___s_eventCacheRWLock_1)); }
	inline MyReaderWriterLock_t0EAF7040A5BCE7C816030732D088A8DB81FB97AD * get_s_eventCacheRWLock_1() const { return ___s_eventCacheRWLock_1; }
	inline MyReaderWriterLock_t0EAF7040A5BCE7C816030732D088A8DB81FB97AD ** get_address_of_s_eventCacheRWLock_1() { return &___s_eventCacheRWLock_1; }
	inline void set_s_eventCacheRWLock_1(MyReaderWriterLock_t0EAF7040A5BCE7C816030732D088A8DB81FB97AD * value)
	{
		___s_eventCacheRWLock_1 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___s_eventCacheRWLock_1), (void*)value);
	}
};


// System.Runtime.InteropServices.WindowsRuntime.WindowsRuntimeMarshal/NativeOrStaticEventRegistrationImpl/MyReaderWriterLock
struct MyReaderWriterLock_t0EAF7040A5BCE7C816030732D088A8DB81FB97AD  : public RuntimeObject
{
public:
	// System.Int32 System.Runtime.InteropServices.WindowsRuntime.WindowsRuntimeMarshal/NativeOrStaticEventRegistrationImpl/MyReaderWriterLock::myLock
	int32_t ___myLock_0;
	// System.Int32 System.Runtime.InteropServices.WindowsRuntime.WindowsRuntimeMarshal/NativeOrStaticEventRegistrationImpl/MyReaderWriterLock::owners
	int32_t ___owners_1;
	// System.UInt32 System.Runtime.InteropServices.WindowsRuntime.WindowsRuntimeMarshal/NativeOrStaticEventRegistrationImpl/MyReaderWriterLock::numWriteWaiters
	uint32_t ___numWriteWaiters_2;
	// System.UInt32 System.Runtime.InteropServices.WindowsRuntime.WindowsRuntimeMarshal/NativeOrStaticEventRegistrationImpl/MyReaderWriterLock::numReadWaiters
	uint32_t ___numReadWaiters_3;
	// System.Threading.EventWaitHandle System.Runtime.InteropServices.WindowsRuntime.WindowsRuntimeMarshal/NativeOrStaticEventRegistrationImpl/MyReaderWriterLock::writeEvent
	EventWaitHandle_t80CDEB33529EF7549E7D3E3B689D8272B9F37F3C * ___writeEvent_4;
	// System.Threading.EventWaitHandle System.Runtime.InteropServices.WindowsRuntime.WindowsRuntimeMarshal/NativeOrStaticEventRegistrationImpl/MyReaderWriterLock::readEvent
	EventWaitHandle_t80CDEB33529EF7549E7D3E3B689D8272B9F37F3C * ___readEvent_5;

public:
	inline static int32_t get_offset_of_myLock_0() { return static_cast<int32_t>(offsetof(MyReaderWriterLock_t0EAF7040A5BCE7C816030732D088A8DB81FB97AD, ___myLock_0)); }
	inline int32_t get_myLock_0() const { return ___myLock_0; }
	inline int32_t* get_address_of_myLock_0() { return &___myLock_0; }
	inline void set_myLock_0(int32_t value)
	{
		___myLock_0 = value;
	}

	inline static int32_t get_offset_of_owners_1() { return static_cast<int32_t>(offsetof(MyReaderWriterLock_t0EAF7040A5BCE7C816030732D088A8DB81FB97AD, ___owners_1)); }
	inline int32_t get_owners_1() const { return ___owners_1; }
	inline int32_t* get_address_of_owners_1() { return &___owners_1; }
	inline void set_owners_1(int32_t value)
	{
		___owners_1 = value;
	}

	inline static int32_t get_offset_of_numWriteWaiters_2() { return static_cast<int32_t>(offsetof(MyReaderWriterLock_t0EAF7040A5BCE7C816030732D088A8DB81FB97AD, ___numWriteWaiters_2)); }
	inline uint32_t get_numWriteWaiters_2() const { return ___numWriteWaiters_2; }
	inline uint32_t* get_address_of_numWriteWaiters_2() { return &___numWriteWaiters_2; }
	inline void set_numWriteWaiters_2(uint32_t value)
	{
		___numWriteWaiters_2 = value;
	}

	inline static int32_t get_offset_of_numReadWaiters_3() { return static_cast<int32_t>(offsetof(MyReaderWriterLock_t0EAF7040A5BCE7C816030732D088A8DB81FB97AD, ___numReadWaiters_3)); }
	inline uint32_t get_numReadWaiters_3() const { return ___numReadWaiters_3; }
	inline uint32_t* get_address_of_numReadWaiters_3() { return &___numReadWaiters_3; }
	inline void set_numReadWaiters_3(uint32_t value)
	{
		___numReadWaiters_3 = value;
	}

	inline static int32_t get_offset_of_writeEvent_4() { return static_cast<int32_t>(offsetof(MyReaderWriterLock_t0EAF7040A5BCE7C816030732D088A8DB81FB97AD, ___writeEvent_4)); }
	inline EventWaitHandle_t80CDEB33529EF7549E7D3E3B689D8272B9F37F3C * get_writeEvent_4() const { return ___writeEvent_4; }
	inline EventWaitHandle_t80CDEB33529EF7549E7D3E3B689D8272B9F37F3C ** get_address_of_writeEvent_4() { return &___writeEvent_4; }
	inline void set_writeEvent_4(EventWaitHandle_t80CDEB33529EF7549E7D3E3B689D8272B9F37F3C * value)
	{
		___writeEvent_4 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___writeEvent_4), (void*)value);
	}

	inline static int32_t get_offset_of_readEvent_5() { return static_cast<int32_t>(offsetof(MyReaderWriterLock_t0EAF7040A5BCE7C816030732D088A8DB81FB97AD, ___readEvent_5)); }
	inline EventWaitHandle_t80CDEB33529EF7549E7D3E3B689D8272B9F37F3C * get_readEvent_5() const { return ___readEvent_5; }
	inline EventWaitHandle_t80CDEB33529EF7549E7D3E3B689D8272B9F37F3C ** get_address_of_readEvent_5() { return &___readEvent_5; }
	inline void set_readEvent_5(EventWaitHandle_t80CDEB33529EF7549E7D3E3B689D8272B9F37F3C * value)
	{
		___readEvent_5 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___readEvent_5), (void*)value);
	}
};


// System.Runtime.CompilerServices.TrueReadOnlyCollection`1<System.Linq.Expressions.Expression>
struct TrueReadOnlyCollection_1_t06D7E0A73C830464D87F10A513072796E7172082  : public ReadOnlyCollection_1_t7976DDE3F2FC7BAAF4F920193FF1B5BA33CCC2B5
{
public:

public:
};


// System.Runtime.CompilerServices.TrueReadOnlyCollection`1<System.Linq.Expressions.ParameterExpression>
struct TrueReadOnlyCollection_1_tFACBB37A6A09F5303FA9A457A34FAFE7002020A3  : public ReadOnlyCollection_1_t27106E268B51074ED9E2D5BB56A9C107EA4E8472
{
public:

public:
};


// System.Linq.Expressions.BinaryExpression
struct BinaryExpression_tCD79755962D104E6603B50D89E7F0E41D1D9CA79  : public Expression_t30A004209C10C2D9A9785B2F74EEED431A4D4660
{
public:
	// System.Linq.Expressions.Expression System.Linq.Expressions.BinaryExpression::<Right>k__BackingField
	Expression_t30A004209C10C2D9A9785B2F74EEED431A4D4660 * ___U3CRightU3Ek__BackingField_3;
	// System.Linq.Expressions.Expression System.Linq.Expressions.BinaryExpression::<Left>k__BackingField
	Expression_t30A004209C10C2D9A9785B2F74EEED431A4D4660 * ___U3CLeftU3Ek__BackingField_4;

public:
	inline static int32_t get_offset_of_U3CRightU3Ek__BackingField_3() { return static_cast<int32_t>(offsetof(BinaryExpression_tCD79755962D104E6603B50D89E7F0E41D1D9CA79, ___U3CRightU3Ek__BackingField_3)); }
	inline Expression_t30A004209C10C2D9A9785B2F74EEED431A4D4660 * get_U3CRightU3Ek__BackingField_3() const { return ___U3CRightU3Ek__BackingField_3; }
	inline Expression_t30A004209C10C2D9A9785B2F74EEED431A4D4660 ** get_address_of_U3CRightU3Ek__BackingField_3() { return &___U3CRightU3Ek__BackingField_3; }
	inline void set_U3CRightU3Ek__BackingField_3(Expression_t30A004209C10C2D9A9785B2F74EEED431A4D4660 * value)
	{
		___U3CRightU3Ek__BackingField_3 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___U3CRightU3Ek__BackingField_3), (void*)value);
	}

	inline static int32_t get_offset_of_U3CLeftU3Ek__BackingField_4() { return static_cast<int32_t>(offsetof(BinaryExpression_tCD79755962D104E6603B50D89E7F0E41D1D9CA79, ___U3CLeftU3Ek__BackingField_4)); }
	inline Expression_t30A004209C10C2D9A9785B2F74EEED431A4D4660 * get_U3CLeftU3Ek__BackingField_4() const { return ___U3CLeftU3Ek__BackingField_4; }
	inline Expression_t30A004209C10C2D9A9785B2F74EEED431A4D4660 ** get_address_of_U3CLeftU3Ek__BackingField_4() { return &___U3CLeftU3Ek__BackingField_4; }
	inline void set_U3CLeftU3Ek__BackingField_4(Expression_t30A004209C10C2D9A9785B2F74EEED431A4D4660 * value)
	{
		___U3CLeftU3Ek__BackingField_4 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___U3CLeftU3Ek__BackingField_4), (void*)value);
	}
};


// System.Linq.Expressions.BlockExpression
struct BlockExpression_t429D310E740322594C18397DEAE7E17DCFE0E0BB  : public Expression_t30A004209C10C2D9A9785B2F74EEED431A4D4660
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


// System.Linq.Expressions.ConditionalExpression
struct ConditionalExpression_t74C60793A382D6FC191C590A353984ED63ED3D4A  : public Expression_t30A004209C10C2D9A9785B2F74EEED431A4D4660
{
public:
	// System.Linq.Expressions.Expression System.Linq.Expressions.ConditionalExpression::<Test>k__BackingField
	Expression_t30A004209C10C2D9A9785B2F74EEED431A4D4660 * ___U3CTestU3Ek__BackingField_3;
	// System.Linq.Expressions.Expression System.Linq.Expressions.ConditionalExpression::<IfTrue>k__BackingField
	Expression_t30A004209C10C2D9A9785B2F74EEED431A4D4660 * ___U3CIfTrueU3Ek__BackingField_4;

public:
	inline static int32_t get_offset_of_U3CTestU3Ek__BackingField_3() { return static_cast<int32_t>(offsetof(ConditionalExpression_t74C60793A382D6FC191C590A353984ED63ED3D4A, ___U3CTestU3Ek__BackingField_3)); }
	inline Expression_t30A004209C10C2D9A9785B2F74EEED431A4D4660 * get_U3CTestU3Ek__BackingField_3() const { return ___U3CTestU3Ek__BackingField_3; }
	inline Expression_t30A004209C10C2D9A9785B2F74EEED431A4D4660 ** get_address_of_U3CTestU3Ek__BackingField_3() { return &___U3CTestU3Ek__BackingField_3; }
	inline void set_U3CTestU3Ek__BackingField_3(Expression_t30A004209C10C2D9A9785B2F74EEED431A4D4660 * value)
	{
		___U3CTestU3Ek__BackingField_3 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___U3CTestU3Ek__BackingField_3), (void*)value);
	}

	inline static int32_t get_offset_of_U3CIfTrueU3Ek__BackingField_4() { return static_cast<int32_t>(offsetof(ConditionalExpression_t74C60793A382D6FC191C590A353984ED63ED3D4A, ___U3CIfTrueU3Ek__BackingField_4)); }
	inline Expression_t30A004209C10C2D9A9785B2F74EEED431A4D4660 * get_U3CIfTrueU3Ek__BackingField_4() const { return ___U3CIfTrueU3Ek__BackingField_4; }
	inline Expression_t30A004209C10C2D9A9785B2F74EEED431A4D4660 ** get_address_of_U3CIfTrueU3Ek__BackingField_4() { return &___U3CIfTrueU3Ek__BackingField_4; }
	inline void set_U3CIfTrueU3Ek__BackingField_4(Expression_t30A004209C10C2D9A9785B2F74EEED431A4D4660 * value)
	{
		___U3CIfTrueU3Ek__BackingField_4 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___U3CIfTrueU3Ek__BackingField_4), (void*)value);
	}
};


// System.Linq.Expressions.ConstantExpression
struct ConstantExpression_tE22239C4AE815AF9B4647E026E802623F433F0FB  : public Expression_t30A004209C10C2D9A9785B2F74EEED431A4D4660
{
public:
	// System.Object System.Linq.Expressions.ConstantExpression::<Value>k__BackingField
	RuntimeObject * ___U3CValueU3Ek__BackingField_3;

public:
	inline static int32_t get_offset_of_U3CValueU3Ek__BackingField_3() { return static_cast<int32_t>(offsetof(ConstantExpression_tE22239C4AE815AF9B4647E026E802623F433F0FB, ___U3CValueU3Ek__BackingField_3)); }
	inline RuntimeObject * get_U3CValueU3Ek__BackingField_3() const { return ___U3CValueU3Ek__BackingField_3; }
	inline RuntimeObject ** get_address_of_U3CValueU3Ek__BackingField_3() { return &___U3CValueU3Ek__BackingField_3; }
	inline void set_U3CValueU3Ek__BackingField_3(RuntimeObject * value)
	{
		___U3CValueU3Ek__BackingField_3 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___U3CValueU3Ek__BackingField_3), (void*)value);
	}
};


// System.Linq.Expressions.DefaultExpression
struct DefaultExpression_t3FC1DD4F4C518F7FDF62C04BB3BF78B10D654D46  : public Expression_t30A004209C10C2D9A9785B2F74EEED431A4D4660
{
public:
	// System.Type System.Linq.Expressions.DefaultExpression::<Type>k__BackingField
	Type_t * ___U3CTypeU3Ek__BackingField_3;

public:
	inline static int32_t get_offset_of_U3CTypeU3Ek__BackingField_3() { return static_cast<int32_t>(offsetof(DefaultExpression_t3FC1DD4F4C518F7FDF62C04BB3BF78B10D654D46, ___U3CTypeU3Ek__BackingField_3)); }
	inline Type_t * get_U3CTypeU3Ek__BackingField_3() const { return ___U3CTypeU3Ek__BackingField_3; }
	inline Type_t ** get_address_of_U3CTypeU3Ek__BackingField_3() { return &___U3CTypeU3Ek__BackingField_3; }
	inline void set_U3CTypeU3Ek__BackingField_3(Type_t * value)
	{
		___U3CTypeU3Ek__BackingField_3 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___U3CTypeU3Ek__BackingField_3), (void*)value);
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


// System.Dynamic.DynamicMetaObjectBinder
struct DynamicMetaObjectBinder_t7B24B7AF08AEA7004A4855C632E18CA2E400CA8D  : public CallSiteBinder_tB923BEDF63B135302EB848D5BF2F18DD183ABD6C
{
public:

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

// System.Runtime.InteropServices.WindowsRuntime.EventRegistrationToken
struct EventRegistrationToken_t5460ED02F1A6B74B604DFD634E8D5429857E9830 
{
public:
	// System.UInt64 System.Runtime.InteropServices.WindowsRuntime.EventRegistrationToken::m_value
	uint64_t ___m_value_0;

public:
	inline static int32_t get_offset_of_m_value_0() { return static_cast<int32_t>(offsetof(EventRegistrationToken_t5460ED02F1A6B74B604DFD634E8D5429857E9830, ___m_value_0)); }
	inline uint64_t get_m_value_0() const { return ___m_value_0; }
	inline uint64_t* get_address_of_m_value_0() { return &___m_value_0; }
	inline void set_m_value_0(uint64_t value)
	{
		___m_value_0 = value;
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


// System.Linq.Expressions.LambdaExpression
struct LambdaExpression_t26BF905E97E6D94F81F17D60F4F4F47F8E93B474  : public Expression_t30A004209C10C2D9A9785B2F74EEED431A4D4660
{
public:
	// System.Linq.Expressions.Expression System.Linq.Expressions.LambdaExpression::_body
	Expression_t30A004209C10C2D9A9785B2F74EEED431A4D4660 * ____body_3;

public:
	inline static int32_t get_offset_of__body_3() { return static_cast<int32_t>(offsetof(LambdaExpression_t26BF905E97E6D94F81F17D60F4F4F47F8E93B474, ____body_3)); }
	inline Expression_t30A004209C10C2D9A9785B2F74EEED431A4D4660 * get__body_3() const { return ____body_3; }
	inline Expression_t30A004209C10C2D9A9785B2F74EEED431A4D4660 ** get_address_of__body_3() { return &____body_3; }
	inline void set__body_3(Expression_t30A004209C10C2D9A9785B2F74EEED431A4D4660 * value)
	{
		____body_3 = value;
		Il2CppCodeGenWriteBarrier((void**)(&____body_3), (void*)value);
	}
};


// System.Reflection.MethodBase
struct MethodBase_t  : public MemberInfo_t
{
public:

public:
};


// System.Linq.Expressions.MethodCallExpression
struct MethodCallExpression_tF8E07995EEDB83A97C356206D651D5EEC72EFFA4  : public Expression_t30A004209C10C2D9A9785B2F74EEED431A4D4660
{
public:
	// System.Reflection.MethodInfo System.Linq.Expressions.MethodCallExpression::<Method>k__BackingField
	MethodInfo_t * ___U3CMethodU3Ek__BackingField_3;

public:
	inline static int32_t get_offset_of_U3CMethodU3Ek__BackingField_3() { return static_cast<int32_t>(offsetof(MethodCallExpression_tF8E07995EEDB83A97C356206D651D5EEC72EFFA4, ___U3CMethodU3Ek__BackingField_3)); }
	inline MethodInfo_t * get_U3CMethodU3Ek__BackingField_3() const { return ___U3CMethodU3Ek__BackingField_3; }
	inline MethodInfo_t ** get_address_of_U3CMethodU3Ek__BackingField_3() { return &___U3CMethodU3Ek__BackingField_3; }
	inline void set_U3CMethodU3Ek__BackingField_3(MethodInfo_t * value)
	{
		___U3CMethodU3Ek__BackingField_3 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___U3CMethodU3Ek__BackingField_3), (void*)value);
	}
};


// System.Linq.Expressions.NewArrayExpression
struct NewArrayExpression_tE4702BA06AA0479BA675A5087BB6E2342F921F0A  : public Expression_t30A004209C10C2D9A9785B2F74EEED431A4D4660
{
public:
	// System.Type System.Linq.Expressions.NewArrayExpression::<Type>k__BackingField
	Type_t * ___U3CTypeU3Ek__BackingField_3;
	// System.Collections.ObjectModel.ReadOnlyCollection`1<System.Linq.Expressions.Expression> System.Linq.Expressions.NewArrayExpression::<Expressions>k__BackingField
	ReadOnlyCollection_1_t7976DDE3F2FC7BAAF4F920193FF1B5BA33CCC2B5 * ___U3CExpressionsU3Ek__BackingField_4;

public:
	inline static int32_t get_offset_of_U3CTypeU3Ek__BackingField_3() { return static_cast<int32_t>(offsetof(NewArrayExpression_tE4702BA06AA0479BA675A5087BB6E2342F921F0A, ___U3CTypeU3Ek__BackingField_3)); }
	inline Type_t * get_U3CTypeU3Ek__BackingField_3() const { return ___U3CTypeU3Ek__BackingField_3; }
	inline Type_t ** get_address_of_U3CTypeU3Ek__BackingField_3() { return &___U3CTypeU3Ek__BackingField_3; }
	inline void set_U3CTypeU3Ek__BackingField_3(Type_t * value)
	{
		___U3CTypeU3Ek__BackingField_3 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___U3CTypeU3Ek__BackingField_3), (void*)value);
	}

	inline static int32_t get_offset_of_U3CExpressionsU3Ek__BackingField_4() { return static_cast<int32_t>(offsetof(NewArrayExpression_tE4702BA06AA0479BA675A5087BB6E2342F921F0A, ___U3CExpressionsU3Ek__BackingField_4)); }
	inline ReadOnlyCollection_1_t7976DDE3F2FC7BAAF4F920193FF1B5BA33CCC2B5 * get_U3CExpressionsU3Ek__BackingField_4() const { return ___U3CExpressionsU3Ek__BackingField_4; }
	inline ReadOnlyCollection_1_t7976DDE3F2FC7BAAF4F920193FF1B5BA33CCC2B5 ** get_address_of_U3CExpressionsU3Ek__BackingField_4() { return &___U3CExpressionsU3Ek__BackingField_4; }
	inline void set_U3CExpressionsU3Ek__BackingField_4(ReadOnlyCollection_1_t7976DDE3F2FC7BAAF4F920193FF1B5BA33CCC2B5 * value)
	{
		___U3CExpressionsU3Ek__BackingField_4 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___U3CExpressionsU3Ek__BackingField_4), (void*)value);
	}
};


// System.Linq.Expressions.NewExpression
struct NewExpression_tCC2B6EAD4868381D56BB8B1AA4C5267F8A620987  : public Expression_t30A004209C10C2D9A9785B2F74EEED431A4D4660
{
public:
	// System.Collections.Generic.IReadOnlyList`1<System.Linq.Expressions.Expression> System.Linq.Expressions.NewExpression::_arguments
	RuntimeObject* ____arguments_3;
	// System.Reflection.ConstructorInfo System.Linq.Expressions.NewExpression::<Constructor>k__BackingField
	ConstructorInfo_t449AEC508DCA508EE46784C4F2716545488ACD5B * ___U3CConstructorU3Ek__BackingField_4;
	// System.Collections.ObjectModel.ReadOnlyCollection`1<System.Reflection.MemberInfo> System.Linq.Expressions.NewExpression::<Members>k__BackingField
	ReadOnlyCollection_1_t1BDA19F8C4CB4BE530A2234A21A1B2C9FB3B7991 * ___U3CMembersU3Ek__BackingField_5;

public:
	inline static int32_t get_offset_of__arguments_3() { return static_cast<int32_t>(offsetof(NewExpression_tCC2B6EAD4868381D56BB8B1AA4C5267F8A620987, ____arguments_3)); }
	inline RuntimeObject* get__arguments_3() const { return ____arguments_3; }
	inline RuntimeObject** get_address_of__arguments_3() { return &____arguments_3; }
	inline void set__arguments_3(RuntimeObject* value)
	{
		____arguments_3 = value;
		Il2CppCodeGenWriteBarrier((void**)(&____arguments_3), (void*)value);
	}

	inline static int32_t get_offset_of_U3CConstructorU3Ek__BackingField_4() { return static_cast<int32_t>(offsetof(NewExpression_tCC2B6EAD4868381D56BB8B1AA4C5267F8A620987, ___U3CConstructorU3Ek__BackingField_4)); }
	inline ConstructorInfo_t449AEC508DCA508EE46784C4F2716545488ACD5B * get_U3CConstructorU3Ek__BackingField_4() const { return ___U3CConstructorU3Ek__BackingField_4; }
	inline ConstructorInfo_t449AEC508DCA508EE46784C4F2716545488ACD5B ** get_address_of_U3CConstructorU3Ek__BackingField_4() { return &___U3CConstructorU3Ek__BackingField_4; }
	inline void set_U3CConstructorU3Ek__BackingField_4(ConstructorInfo_t449AEC508DCA508EE46784C4F2716545488ACD5B * value)
	{
		___U3CConstructorU3Ek__BackingField_4 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___U3CConstructorU3Ek__BackingField_4), (void*)value);
	}

	inline static int32_t get_offset_of_U3CMembersU3Ek__BackingField_5() { return static_cast<int32_t>(offsetof(NewExpression_tCC2B6EAD4868381D56BB8B1AA4C5267F8A620987, ___U3CMembersU3Ek__BackingField_5)); }
	inline ReadOnlyCollection_1_t1BDA19F8C4CB4BE530A2234A21A1B2C9FB3B7991 * get_U3CMembersU3Ek__BackingField_5() const { return ___U3CMembersU3Ek__BackingField_5; }
	inline ReadOnlyCollection_1_t1BDA19F8C4CB4BE530A2234A21A1B2C9FB3B7991 ** get_address_of_U3CMembersU3Ek__BackingField_5() { return &___U3CMembersU3Ek__BackingField_5; }
	inline void set_U3CMembersU3Ek__BackingField_5(ReadOnlyCollection_1_t1BDA19F8C4CB4BE530A2234A21A1B2C9FB3B7991 * value)
	{
		___U3CMembersU3Ek__BackingField_5 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___U3CMembersU3Ek__BackingField_5), (void*)value);
	}
};


// System.Runtime.Serialization.ObjectReferenceStack
struct ObjectReferenceStack_t2B8E7AC251005213F977D4D8545D127AA29FD221 
{
public:
	// System.Int32 System.Runtime.Serialization.ObjectReferenceStack::count
	int32_t ___count_2;
	// System.Object[] System.Runtime.Serialization.ObjectReferenceStack::objectArray
	ObjectU5BU5D_tC1F4EE0DB0B7300255F5FD4AF64FE4C585CF5ADE* ___objectArray_3;
	// System.Boolean[] System.Runtime.Serialization.ObjectReferenceStack::isReferenceArray
	BooleanU5BU5D_tEC7BAF93C44F875016DAADC8696EE3A465644D3C* ___isReferenceArray_4;
	// System.Collections.Generic.Dictionary`2<System.Object,System.Object> System.Runtime.Serialization.ObjectReferenceStack::objectDictionary
	Dictionary_2_tBD1E3221EBD04CEBDA49B84779912E91F56B958D * ___objectDictionary_5;

public:
	inline static int32_t get_offset_of_count_2() { return static_cast<int32_t>(offsetof(ObjectReferenceStack_t2B8E7AC251005213F977D4D8545D127AA29FD221, ___count_2)); }
	inline int32_t get_count_2() const { return ___count_2; }
	inline int32_t* get_address_of_count_2() { return &___count_2; }
	inline void set_count_2(int32_t value)
	{
		___count_2 = value;
	}

	inline static int32_t get_offset_of_objectArray_3() { return static_cast<int32_t>(offsetof(ObjectReferenceStack_t2B8E7AC251005213F977D4D8545D127AA29FD221, ___objectArray_3)); }
	inline ObjectU5BU5D_tC1F4EE0DB0B7300255F5FD4AF64FE4C585CF5ADE* get_objectArray_3() const { return ___objectArray_3; }
	inline ObjectU5BU5D_tC1F4EE0DB0B7300255F5FD4AF64FE4C585CF5ADE** get_address_of_objectArray_3() { return &___objectArray_3; }
	inline void set_objectArray_3(ObjectU5BU5D_tC1F4EE0DB0B7300255F5FD4AF64FE4C585CF5ADE* value)
	{
		___objectArray_3 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___objectArray_3), (void*)value);
	}

	inline static int32_t get_offset_of_isReferenceArray_4() { return static_cast<int32_t>(offsetof(ObjectReferenceStack_t2B8E7AC251005213F977D4D8545D127AA29FD221, ___isReferenceArray_4)); }
	inline BooleanU5BU5D_tEC7BAF93C44F875016DAADC8696EE3A465644D3C* get_isReferenceArray_4() const { return ___isReferenceArray_4; }
	inline BooleanU5BU5D_tEC7BAF93C44F875016DAADC8696EE3A465644D3C** get_address_of_isReferenceArray_4() { return &___isReferenceArray_4; }
	inline void set_isReferenceArray_4(BooleanU5BU5D_tEC7BAF93C44F875016DAADC8696EE3A465644D3C* value)
	{
		___isReferenceArray_4 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___isReferenceArray_4), (void*)value);
	}

	inline static int32_t get_offset_of_objectDictionary_5() { return static_cast<int32_t>(offsetof(ObjectReferenceStack_t2B8E7AC251005213F977D4D8545D127AA29FD221, ___objectDictionary_5)); }
	inline Dictionary_2_tBD1E3221EBD04CEBDA49B84779912E91F56B958D * get_objectDictionary_5() const { return ___objectDictionary_5; }
	inline Dictionary_2_tBD1E3221EBD04CEBDA49B84779912E91F56B958D ** get_address_of_objectDictionary_5() { return &___objectDictionary_5; }
	inline void set_objectDictionary_5(Dictionary_2_tBD1E3221EBD04CEBDA49B84779912E91F56B958D * value)
	{
		___objectDictionary_5 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___objectDictionary_5), (void*)value);
	}
};

// Native definition for P/Invoke marshalling of System.Runtime.Serialization.ObjectReferenceStack
struct ObjectReferenceStack_t2B8E7AC251005213F977D4D8545D127AA29FD221_marshaled_pinvoke
{
	int32_t ___count_2;
	ObjectU5BU5D_tC1F4EE0DB0B7300255F5FD4AF64FE4C585CF5ADE* ___objectArray_3;
	int32_t* ___isReferenceArray_4;
	Dictionary_2_tBD1E3221EBD04CEBDA49B84779912E91F56B958D * ___objectDictionary_5;
};
// Native definition for COM marshalling of System.Runtime.Serialization.ObjectReferenceStack
struct ObjectReferenceStack_t2B8E7AC251005213F977D4D8545D127AA29FD221_marshaled_com
{
	int32_t ___count_2;
	ObjectU5BU5D_tC1F4EE0DB0B7300255F5FD4AF64FE4C585CF5ADE* ___objectArray_3;
	int32_t* ___isReferenceArray_4;
	Dictionary_2_tBD1E3221EBD04CEBDA49B84779912E91F56B958D * ___objectDictionary_5;
};

// System.Linq.Expressions.ParameterExpression
struct ParameterExpression_tA7B24F1DE0F013DA4BD55F76DB43B06DB33D8BEE  : public Expression_t30A004209C10C2D9A9785B2F74EEED431A4D4660
{
public:
	// System.String System.Linq.Expressions.ParameterExpression::<Name>k__BackingField
	String_t* ___U3CNameU3Ek__BackingField_3;

public:
	inline static int32_t get_offset_of_U3CNameU3Ek__BackingField_3() { return static_cast<int32_t>(offsetof(ParameterExpression_tA7B24F1DE0F013DA4BD55F76DB43B06DB33D8BEE, ___U3CNameU3Ek__BackingField_3)); }
	inline String_t* get_U3CNameU3Ek__BackingField_3() const { return ___U3CNameU3Ek__BackingField_3; }
	inline String_t** get_address_of_U3CNameU3Ek__BackingField_3() { return &___U3CNameU3Ek__BackingField_3; }
	inline void set_U3CNameU3Ek__BackingField_3(String_t* value)
	{
		___U3CNameU3Ek__BackingField_3 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___U3CNameU3Ek__BackingField_3), (void*)value);
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


// System.Runtime.Serialization.ScopedKnownTypes
struct ScopedKnownTypes_t55B523F7067D7B5A1EA1CF17C20354731924CCA7 
{
public:
	// System.Collections.Generic.Dictionary`2<System.Xml.XmlQualifiedName,System.Runtime.Serialization.DataContract>[] System.Runtime.Serialization.ScopedKnownTypes::dataContractDictionaries
	Dictionary_2U5BU5D_t59E2DE680C0FE29F30EB1C2272A8899E85BD097E* ___dataContractDictionaries_0;
	// System.Int32 System.Runtime.Serialization.ScopedKnownTypes::count
	int32_t ___count_1;

public:
	inline static int32_t get_offset_of_dataContractDictionaries_0() { return static_cast<int32_t>(offsetof(ScopedKnownTypes_t55B523F7067D7B5A1EA1CF17C20354731924CCA7, ___dataContractDictionaries_0)); }
	inline Dictionary_2U5BU5D_t59E2DE680C0FE29F30EB1C2272A8899E85BD097E* get_dataContractDictionaries_0() const { return ___dataContractDictionaries_0; }
	inline Dictionary_2U5BU5D_t59E2DE680C0FE29F30EB1C2272A8899E85BD097E** get_address_of_dataContractDictionaries_0() { return &___dataContractDictionaries_0; }
	inline void set_dataContractDictionaries_0(Dictionary_2U5BU5D_t59E2DE680C0FE29F30EB1C2272A8899E85BD097E* value)
	{
		___dataContractDictionaries_0 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___dataContractDictionaries_0), (void*)value);
	}

	inline static int32_t get_offset_of_count_1() { return static_cast<int32_t>(offsetof(ScopedKnownTypes_t55B523F7067D7B5A1EA1CF17C20354731924CCA7, ___count_1)); }
	inline int32_t get_count_1() const { return ___count_1; }
	inline int32_t* get_address_of_count_1() { return &___count_1; }
	inline void set_count_1(int32_t value)
	{
		___count_1 = value;
	}
};

// Native definition for P/Invoke marshalling of System.Runtime.Serialization.ScopedKnownTypes
struct ScopedKnownTypes_t55B523F7067D7B5A1EA1CF17C20354731924CCA7_marshaled_pinvoke
{
	Dictionary_2_t4718820257735C3DF2901A055292922ED97E4759 ** ___dataContractDictionaries_0;
	int32_t ___count_1;
};
// Native definition for COM marshalling of System.Runtime.Serialization.ScopedKnownTypes
struct ScopedKnownTypes_t55B523F7067D7B5A1EA1CF17C20354731924CCA7_marshaled_com
{
	Dictionary_2_t4718820257735C3DF2901A055292922ED97E4759 ** ___dataContractDictionaries_0;
	int32_t ___count_1;
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


// System.Dynamic.DynamicObject/MetaDynamic
struct MetaDynamic_t774AF4A12F33149209C1FA08022AB0EE951BFB7C  : public DynamicMetaObject_t5279001ADBFAB6EF015CAC54937F4E9F003881C3
{
public:

public:
};

struct MetaDynamic_t774AF4A12F33149209C1FA08022AB0EE951BFB7C_StaticFields
{
public:
	// System.Linq.Expressions.Expression[] System.Dynamic.DynamicObject/MetaDynamic::s_noArgs
	ExpressionU5BU5D_t4F1F138488EBD58837D142B40E0E4EEFC607EA63* ___s_noArgs_5;

public:
	inline static int32_t get_offset_of_s_noArgs_5() { return static_cast<int32_t>(offsetof(MetaDynamic_t774AF4A12F33149209C1FA08022AB0EE951BFB7C_StaticFields, ___s_noArgs_5)); }
	inline ExpressionU5BU5D_t4F1F138488EBD58837D142B40E0E4EEFC607EA63* get_s_noArgs_5() const { return ___s_noArgs_5; }
	inline ExpressionU5BU5D_t4F1F138488EBD58837D142B40E0E4EEFC607EA63** get_address_of_s_noArgs_5() { return &___s_noArgs_5; }
	inline void set_s_noArgs_5(ExpressionU5BU5D_t4F1F138488EBD58837D142B40E0E4EEFC607EA63* value)
	{
		___s_noArgs_5 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___s_noArgs_5), (void*)value);
	}
};


// System.Linq.Expressions.Interpreter.LightCompiler/QuoteVisitor
struct QuoteVisitor_tFE404B4C826642C3FC245A108AEC9E94D691E627  : public ExpressionVisitor_tD098DE8A366FBBB58C498C4EFF8B003FCA726DF4
{
public:
	// System.Collections.Generic.Dictionary`2<System.Linq.Expressions.ParameterExpression,System.Int32> System.Linq.Expressions.Interpreter.LightCompiler/QuoteVisitor::_definedParameters
	Dictionary_2_t557635FBDBCB4F09E0827F01D69D76FF503D03A7 * ____definedParameters_0;
	// System.Collections.Generic.HashSet`1<System.Linq.Expressions.ParameterExpression> System.Linq.Expressions.Interpreter.LightCompiler/QuoteVisitor::_hoistedParameters
	HashSet_1_t42A3AC337CA15FAC250AA5DA438F909806C72CB0 * ____hoistedParameters_1;

public:
	inline static int32_t get_offset_of__definedParameters_0() { return static_cast<int32_t>(offsetof(QuoteVisitor_tFE404B4C826642C3FC245A108AEC9E94D691E627, ____definedParameters_0)); }
	inline Dictionary_2_t557635FBDBCB4F09E0827F01D69D76FF503D03A7 * get__definedParameters_0() const { return ____definedParameters_0; }
	inline Dictionary_2_t557635FBDBCB4F09E0827F01D69D76FF503D03A7 ** get_address_of__definedParameters_0() { return &____definedParameters_0; }
	inline void set__definedParameters_0(Dictionary_2_t557635FBDBCB4F09E0827F01D69D76FF503D03A7 * value)
	{
		____definedParameters_0 = value;
		Il2CppCodeGenWriteBarrier((void**)(&____definedParameters_0), (void*)value);
	}

	inline static int32_t get_offset_of__hoistedParameters_1() { return static_cast<int32_t>(offsetof(QuoteVisitor_tFE404B4C826642C3FC245A108AEC9E94D691E627, ____hoistedParameters_1)); }
	inline HashSet_1_t42A3AC337CA15FAC250AA5DA438F909806C72CB0 * get__hoistedParameters_1() const { return ____hoistedParameters_1; }
	inline HashSet_1_t42A3AC337CA15FAC250AA5DA438F909806C72CB0 ** get_address_of__hoistedParameters_1() { return &____hoistedParameters_1; }
	inline void set__hoistedParameters_1(HashSet_1_t42A3AC337CA15FAC250AA5DA438F909806C72CB0 * value)
	{
		____hoistedParameters_1 = value;
		Il2CppCodeGenWriteBarrier((void**)(&____hoistedParameters_1), (void*)value);
	}
};


// System.Linq.Expressions.Interpreter.QuoteInstruction/ExpressionQuoter
struct ExpressionQuoter_t174D328A07E522775BA6B19ADF09DBEAF13098FE  : public ExpressionVisitor_tD098DE8A366FBBB58C498C4EFF8B003FCA726DF4
{
public:
	// System.Collections.Generic.Dictionary`2<System.Linq.Expressions.ParameterExpression,System.Linq.Expressions.Interpreter.LocalVariable> System.Linq.Expressions.Interpreter.QuoteInstruction/ExpressionQuoter::_variables
	Dictionary_2_tAE9216CE6245A2FBEA94860E5D55598909B27352 * ____variables_0;
	// System.Linq.Expressions.Interpreter.InterpretedFrame System.Linq.Expressions.Interpreter.QuoteInstruction/ExpressionQuoter::_frame
	InterpretedFrame_tC7B57503A639148EB56B34F5464120D4B42627E2 * ____frame_1;
	// System.Collections.Generic.Stack`1<System.Collections.Generic.HashSet`1<System.Linq.Expressions.ParameterExpression>> System.Linq.Expressions.Interpreter.QuoteInstruction/ExpressionQuoter::_shadowedVars
	Stack_1_t438C22E9DF33740A9BDB48CF9504B6E044484958 * ____shadowedVars_2;

public:
	inline static int32_t get_offset_of__variables_0() { return static_cast<int32_t>(offsetof(ExpressionQuoter_t174D328A07E522775BA6B19ADF09DBEAF13098FE, ____variables_0)); }
	inline Dictionary_2_tAE9216CE6245A2FBEA94860E5D55598909B27352 * get__variables_0() const { return ____variables_0; }
	inline Dictionary_2_tAE9216CE6245A2FBEA94860E5D55598909B27352 ** get_address_of__variables_0() { return &____variables_0; }
	inline void set__variables_0(Dictionary_2_tAE9216CE6245A2FBEA94860E5D55598909B27352 * value)
	{
		____variables_0 = value;
		Il2CppCodeGenWriteBarrier((void**)(&____variables_0), (void*)value);
	}

	inline static int32_t get_offset_of__frame_1() { return static_cast<int32_t>(offsetof(ExpressionQuoter_t174D328A07E522775BA6B19ADF09DBEAF13098FE, ____frame_1)); }
	inline InterpretedFrame_tC7B57503A639148EB56B34F5464120D4B42627E2 * get__frame_1() const { return ____frame_1; }
	inline InterpretedFrame_tC7B57503A639148EB56B34F5464120D4B42627E2 ** get_address_of__frame_1() { return &____frame_1; }
	inline void set__frame_1(InterpretedFrame_tC7B57503A639148EB56B34F5464120D4B42627E2 * value)
	{
		____frame_1 = value;
		Il2CppCodeGenWriteBarrier((void**)(&____frame_1), (void*)value);
	}

	inline static int32_t get_offset_of__shadowedVars_2() { return static_cast<int32_t>(offsetof(ExpressionQuoter_t174D328A07E522775BA6B19ADF09DBEAF13098FE, ____shadowedVars_2)); }
	inline Stack_1_t438C22E9DF33740A9BDB48CF9504B6E044484958 * get__shadowedVars_2() const { return ____shadowedVars_2; }
	inline Stack_1_t438C22E9DF33740A9BDB48CF9504B6E044484958 ** get_address_of__shadowedVars_2() { return &____shadowedVars_2; }
	inline void set__shadowedVars_2(Stack_1_t438C22E9DF33740A9BDB48CF9504B6E044484958 * value)
	{
		____shadowedVars_2 = value;
		Il2CppCodeGenWriteBarrier((void**)(&____shadowedVars_2), (void*)value);
	}
};


// System.Runtime.InteropServices.WindowsRuntime.WindowsRuntimeMarshal/NativeOrStaticEventRegistrationImpl/EventCacheKey
struct EventCacheKey_t12702AEDF54C3DF6DAFF437A04ACE47ACEF1D639 
{
public:
	// System.Object System.Runtime.InteropServices.WindowsRuntime.WindowsRuntimeMarshal/NativeOrStaticEventRegistrationImpl/EventCacheKey::target
	RuntimeObject * ___target_0;
	// System.Reflection.MethodInfo System.Runtime.InteropServices.WindowsRuntime.WindowsRuntimeMarshal/NativeOrStaticEventRegistrationImpl/EventCacheKey::method
	MethodInfo_t * ___method_1;

public:
	inline static int32_t get_offset_of_target_0() { return static_cast<int32_t>(offsetof(EventCacheKey_t12702AEDF54C3DF6DAFF437A04ACE47ACEF1D639, ___target_0)); }
	inline RuntimeObject * get_target_0() const { return ___target_0; }
	inline RuntimeObject ** get_address_of_target_0() { return &___target_0; }
	inline void set_target_0(RuntimeObject * value)
	{
		___target_0 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___target_0), (void*)value);
	}

	inline static int32_t get_offset_of_method_1() { return static_cast<int32_t>(offsetof(EventCacheKey_t12702AEDF54C3DF6DAFF437A04ACE47ACEF1D639, ___method_1)); }
	inline MethodInfo_t * get_method_1() const { return ___method_1; }
	inline MethodInfo_t ** get_address_of_method_1() { return &___method_1; }
	inline void set_method_1(MethodInfo_t * value)
	{
		___method_1 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___method_1), (void*)value);
	}
};

// Native definition for P/Invoke marshalling of System.Runtime.InteropServices.WindowsRuntime.WindowsRuntimeMarshal/NativeOrStaticEventRegistrationImpl/EventCacheKey
struct EventCacheKey_t12702AEDF54C3DF6DAFF437A04ACE47ACEF1D639_marshaled_pinvoke
{
	RuntimeObject * ___target_0;
	MethodInfo_t * ___method_1;
};
// Native definition for COM marshalling of System.Runtime.InteropServices.WindowsRuntime.WindowsRuntimeMarshal/NativeOrStaticEventRegistrationImpl/EventCacheKey
struct EventCacheKey_t12702AEDF54C3DF6DAFF437A04ACE47ACEF1D639_marshaled_com
{
	RuntimeObject * ___target_0;
	MethodInfo_t * ___method_1;
};

// System.Linq.Expressions.Expression`1<System.Object>
struct Expression_1_t01B093F396848A065BE827B0C58E6F20E760FB6F  : public LambdaExpression_t26BF905E97E6D94F81F17D60F4F4F47F8E93B474
{
public:

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


// System.Reflection.ConstructorInfo
struct ConstructorInfo_t449AEC508DCA508EE46784C4F2716545488ACD5B  : public MethodBase_t
{
public:

public:
};

struct ConstructorInfo_t449AEC508DCA508EE46784C4F2716545488ACD5B_StaticFields
{
public:
	// System.String System.Reflection.ConstructorInfo::ConstructorName
	String_t* ___ConstructorName_0;
	// System.String System.Reflection.ConstructorInfo::TypeConstructorName
	String_t* ___TypeConstructorName_1;

public:
	inline static int32_t get_offset_of_ConstructorName_0() { return static_cast<int32_t>(offsetof(ConstructorInfo_t449AEC508DCA508EE46784C4F2716545488ACD5B_StaticFields, ___ConstructorName_0)); }
	inline String_t* get_ConstructorName_0() const { return ___ConstructorName_0; }
	inline String_t** get_address_of_ConstructorName_0() { return &___ConstructorName_0; }
	inline void set_ConstructorName_0(String_t* value)
	{
		___ConstructorName_0 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___ConstructorName_0), (void*)value);
	}

	inline static int32_t get_offset_of_TypeConstructorName_1() { return static_cast<int32_t>(offsetof(ConstructorInfo_t449AEC508DCA508EE46784C4F2716545488ACD5B_StaticFields, ___TypeConstructorName_1)); }
	inline String_t* get_TypeConstructorName_1() const { return ___TypeConstructorName_1; }
	inline String_t** get_address_of_TypeConstructorName_1() { return &___TypeConstructorName_1; }
	inline void set_TypeConstructorName_1(String_t* value)
	{
		___TypeConstructorName_1 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___TypeConstructorName_1), (void*)value);
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

// System.Linq.Expressions.ExpressionType
struct ExpressionType_t5DFF595F84E155FA27FA8929A81459546074CE51 
{
public:
	// System.Int32 System.Linq.Expressions.ExpressionType::value__
	int32_t ___value___2;

public:
	inline static int32_t get_offset_of_value___2() { return static_cast<int32_t>(offsetof(ExpressionType_t5DFF595F84E155FA27FA8929A81459546074CE51, ___value___2)); }
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


// System.Xml.Schema.XmlTypeCode
struct XmlTypeCode_t8BCC3C3572E95AA39A6F53864E90CE04AB3290E1 
{
public:
	// System.Int32 System.Xml.Schema.XmlTypeCode::value__
	int32_t ___value___2;

public:
	inline static int32_t get_offset_of_value___2() { return static_cast<int32_t>(offsetof(XmlTypeCode_t8BCC3C3572E95AA39A6F53864E90CE04AB3290E1, ___value___2)); }
	inline int32_t get_value___2() const { return ___value___2; }
	inline int32_t* get_address_of_value___2() { return &___value___2; }
	inline void set_value___2(int32_t value)
	{
		___value___2 = value;
	}
};


// System.Runtime.InteropServices.WindowsRuntime.WindowsRuntimeMarshal/EventRegistrationTokenList
struct EventRegistrationTokenList_t0B8EB3E0DA8A305BFCD313936266A15F50B4B128 
{
public:
	// System.Runtime.InteropServices.WindowsRuntime.EventRegistrationToken System.Runtime.InteropServices.WindowsRuntime.WindowsRuntimeMarshal/EventRegistrationTokenList::firstToken
	EventRegistrationToken_t5460ED02F1A6B74B604DFD634E8D5429857E9830  ___firstToken_0;
	// System.Collections.Generic.List`1<System.Runtime.InteropServices.WindowsRuntime.EventRegistrationToken> System.Runtime.InteropServices.WindowsRuntime.WindowsRuntimeMarshal/EventRegistrationTokenList::restTokens
	List_1_t01F23063BEF9E4FDEA5BD7414739DB35870B9ED9 * ___restTokens_1;

public:
	inline static int32_t get_offset_of_firstToken_0() { return static_cast<int32_t>(offsetof(EventRegistrationTokenList_t0B8EB3E0DA8A305BFCD313936266A15F50B4B128, ___firstToken_0)); }
	inline EventRegistrationToken_t5460ED02F1A6B74B604DFD634E8D5429857E9830  get_firstToken_0() const { return ___firstToken_0; }
	inline EventRegistrationToken_t5460ED02F1A6B74B604DFD634E8D5429857E9830 * get_address_of_firstToken_0() { return &___firstToken_0; }
	inline void set_firstToken_0(EventRegistrationToken_t5460ED02F1A6B74B604DFD634E8D5429857E9830  value)
	{
		___firstToken_0 = value;
	}

	inline static int32_t get_offset_of_restTokens_1() { return static_cast<int32_t>(offsetof(EventRegistrationTokenList_t0B8EB3E0DA8A305BFCD313936266A15F50B4B128, ___restTokens_1)); }
	inline List_1_t01F23063BEF9E4FDEA5BD7414739DB35870B9ED9 * get_restTokens_1() const { return ___restTokens_1; }
	inline List_1_t01F23063BEF9E4FDEA5BD7414739DB35870B9ED9 ** get_address_of_restTokens_1() { return &___restTokens_1; }
	inline void set_restTokens_1(List_1_t01F23063BEF9E4FDEA5BD7414739DB35870B9ED9 * value)
	{
		___restTokens_1 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___restTokens_1), (void*)value);
	}
};

// Native definition for P/Invoke marshalling of System.Runtime.InteropServices.WindowsRuntime.WindowsRuntimeMarshal/EventRegistrationTokenList
struct EventRegistrationTokenList_t0B8EB3E0DA8A305BFCD313936266A15F50B4B128_marshaled_pinvoke
{
	EventRegistrationToken_t5460ED02F1A6B74B604DFD634E8D5429857E9830  ___firstToken_0;
	List_1_t01F23063BEF9E4FDEA5BD7414739DB35870B9ED9 * ___restTokens_1;
};
// Native definition for COM marshalling of System.Runtime.InteropServices.WindowsRuntime.WindowsRuntimeMarshal/EventRegistrationTokenList
struct EventRegistrationTokenList_t0B8EB3E0DA8A305BFCD313936266A15F50B4B128_marshaled_com
{
	EventRegistrationToken_t5460ED02F1A6B74B604DFD634E8D5429857E9830  ___firstToken_0;
	List_1_t01F23063BEF9E4FDEA5BD7414739DB35870B9ED9 * ___restTokens_1;
};

// System.Runtime.InteropServices.WindowsRuntime.WindowsRuntimeMarshal/NativeOrStaticEventRegistrationImpl/TokenListCount
struct TokenListCount_t769EA62356D8C37857DCC81DB79A76FA75E319AC  : public RuntimeObject
{
public:
	// System.Int32 System.Runtime.InteropServices.WindowsRuntime.WindowsRuntimeMarshal/NativeOrStaticEventRegistrationImpl/TokenListCount::_count
	int32_t ____count_0;
	// System.Runtime.InteropServices.WindowsRuntime.WindowsRuntimeMarshal/NativeOrStaticEventRegistrationImpl/EventCacheKey System.Runtime.InteropServices.WindowsRuntime.WindowsRuntimeMarshal/NativeOrStaticEventRegistrationImpl/TokenListCount::_key
	EventCacheKey_t12702AEDF54C3DF6DAFF437A04ACE47ACEF1D639  ____key_1;

public:
	inline static int32_t get_offset_of__count_0() { return static_cast<int32_t>(offsetof(TokenListCount_t769EA62356D8C37857DCC81DB79A76FA75E319AC, ____count_0)); }
	inline int32_t get__count_0() const { return ____count_0; }
	inline int32_t* get_address_of__count_0() { return &____count_0; }
	inline void set__count_0(int32_t value)
	{
		____count_0 = value;
	}

	inline static int32_t get_offset_of__key_1() { return static_cast<int32_t>(offsetof(TokenListCount_t769EA62356D8C37857DCC81DB79A76FA75E319AC, ____key_1)); }
	inline EventCacheKey_t12702AEDF54C3DF6DAFF437A04ACE47ACEF1D639  get__key_1() const { return ____key_1; }
	inline EventCacheKey_t12702AEDF54C3DF6DAFF437A04ACE47ACEF1D639 * get_address_of__key_1() { return &____key_1; }
	inline void set__key_1(EventCacheKey_t12702AEDF54C3DF6DAFF437A04ACE47ACEF1D639  value)
	{
		____key_1 = value;
		Il2CppCodeGenWriteBarrier((void**)&(((&____key_1))->___target_0), (void*)NULL);
		#if IL2CPP_ENABLE_STRICT_WRITE_BARRIERS
		Il2CppCodeGenWriteBarrier((void**)&(((&____key_1))->___method_1), (void*)NULL);
		#endif
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


// System.Linq.Expressions.TypeBinaryExpression
struct TypeBinaryExpression_t802702BB83CA4CE99BAE599EAD7D58FDF8C32185  : public Expression_t30A004209C10C2D9A9785B2F74EEED431A4D4660
{
public:
	// System.Linq.Expressions.ExpressionType System.Linq.Expressions.TypeBinaryExpression::<NodeType>k__BackingField
	int32_t ___U3CNodeTypeU3Ek__BackingField_3;
	// System.Linq.Expressions.Expression System.Linq.Expressions.TypeBinaryExpression::<Expression>k__BackingField
	Expression_t30A004209C10C2D9A9785B2F74EEED431A4D4660 * ___U3CExpressionU3Ek__BackingField_4;
	// System.Type System.Linq.Expressions.TypeBinaryExpression::<TypeOperand>k__BackingField
	Type_t * ___U3CTypeOperandU3Ek__BackingField_5;

public:
	inline static int32_t get_offset_of_U3CNodeTypeU3Ek__BackingField_3() { return static_cast<int32_t>(offsetof(TypeBinaryExpression_t802702BB83CA4CE99BAE599EAD7D58FDF8C32185, ___U3CNodeTypeU3Ek__BackingField_3)); }
	inline int32_t get_U3CNodeTypeU3Ek__BackingField_3() const { return ___U3CNodeTypeU3Ek__BackingField_3; }
	inline int32_t* get_address_of_U3CNodeTypeU3Ek__BackingField_3() { return &___U3CNodeTypeU3Ek__BackingField_3; }
	inline void set_U3CNodeTypeU3Ek__BackingField_3(int32_t value)
	{
		___U3CNodeTypeU3Ek__BackingField_3 = value;
	}

	inline static int32_t get_offset_of_U3CExpressionU3Ek__BackingField_4() { return static_cast<int32_t>(offsetof(TypeBinaryExpression_t802702BB83CA4CE99BAE599EAD7D58FDF8C32185, ___U3CExpressionU3Ek__BackingField_4)); }
	inline Expression_t30A004209C10C2D9A9785B2F74EEED431A4D4660 * get_U3CExpressionU3Ek__BackingField_4() const { return ___U3CExpressionU3Ek__BackingField_4; }
	inline Expression_t30A004209C10C2D9A9785B2F74EEED431A4D4660 ** get_address_of_U3CExpressionU3Ek__BackingField_4() { return &___U3CExpressionU3Ek__BackingField_4; }
	inline void set_U3CExpressionU3Ek__BackingField_4(Expression_t30A004209C10C2D9A9785B2F74EEED431A4D4660 * value)
	{
		___U3CExpressionU3Ek__BackingField_4 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___U3CExpressionU3Ek__BackingField_4), (void*)value);
	}

	inline static int32_t get_offset_of_U3CTypeOperandU3Ek__BackingField_5() { return static_cast<int32_t>(offsetof(TypeBinaryExpression_t802702BB83CA4CE99BAE599EAD7D58FDF8C32185, ___U3CTypeOperandU3Ek__BackingField_5)); }
	inline Type_t * get_U3CTypeOperandU3Ek__BackingField_5() const { return ___U3CTypeOperandU3Ek__BackingField_5; }
	inline Type_t ** get_address_of_U3CTypeOperandU3Ek__BackingField_5() { return &___U3CTypeOperandU3Ek__BackingField_5; }
	inline void set_U3CTypeOperandU3Ek__BackingField_5(Type_t * value)
	{
		___U3CTypeOperandU3Ek__BackingField_5 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___U3CTypeOperandU3Ek__BackingField_5), (void*)value);
	}
};


// System.Linq.Expressions.UnaryExpression
struct UnaryExpression_t5DE6F6FA2216CDD34DFCFADEB0080CB29326DD62  : public Expression_t30A004209C10C2D9A9785B2F74EEED431A4D4660
{
public:
	// System.Type System.Linq.Expressions.UnaryExpression::<Type>k__BackingField
	Type_t * ___U3CTypeU3Ek__BackingField_3;
	// System.Linq.Expressions.ExpressionType System.Linq.Expressions.UnaryExpression::<NodeType>k__BackingField
	int32_t ___U3CNodeTypeU3Ek__BackingField_4;
	// System.Linq.Expressions.Expression System.Linq.Expressions.UnaryExpression::<Operand>k__BackingField
	Expression_t30A004209C10C2D9A9785B2F74EEED431A4D4660 * ___U3COperandU3Ek__BackingField_5;
	// System.Reflection.MethodInfo System.Linq.Expressions.UnaryExpression::<Method>k__BackingField
	MethodInfo_t * ___U3CMethodU3Ek__BackingField_6;

public:
	inline static int32_t get_offset_of_U3CTypeU3Ek__BackingField_3() { return static_cast<int32_t>(offsetof(UnaryExpression_t5DE6F6FA2216CDD34DFCFADEB0080CB29326DD62, ___U3CTypeU3Ek__BackingField_3)); }
	inline Type_t * get_U3CTypeU3Ek__BackingField_3() const { return ___U3CTypeU3Ek__BackingField_3; }
	inline Type_t ** get_address_of_U3CTypeU3Ek__BackingField_3() { return &___U3CTypeU3Ek__BackingField_3; }
	inline void set_U3CTypeU3Ek__BackingField_3(Type_t * value)
	{
		___U3CTypeU3Ek__BackingField_3 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___U3CTypeU3Ek__BackingField_3), (void*)value);
	}

	inline static int32_t get_offset_of_U3CNodeTypeU3Ek__BackingField_4() { return static_cast<int32_t>(offsetof(UnaryExpression_t5DE6F6FA2216CDD34DFCFADEB0080CB29326DD62, ___U3CNodeTypeU3Ek__BackingField_4)); }
	inline int32_t get_U3CNodeTypeU3Ek__BackingField_4() const { return ___U3CNodeTypeU3Ek__BackingField_4; }
	inline int32_t* get_address_of_U3CNodeTypeU3Ek__BackingField_4() { return &___U3CNodeTypeU3Ek__BackingField_4; }
	inline void set_U3CNodeTypeU3Ek__BackingField_4(int32_t value)
	{
		___U3CNodeTypeU3Ek__BackingField_4 = value;
	}

	inline static int32_t get_offset_of_U3COperandU3Ek__BackingField_5() { return static_cast<int32_t>(offsetof(UnaryExpression_t5DE6F6FA2216CDD34DFCFADEB0080CB29326DD62, ___U3COperandU3Ek__BackingField_5)); }
	inline Expression_t30A004209C10C2D9A9785B2F74EEED431A4D4660 * get_U3COperandU3Ek__BackingField_5() const { return ___U3COperandU3Ek__BackingField_5; }
	inline Expression_t30A004209C10C2D9A9785B2F74EEED431A4D4660 ** get_address_of_U3COperandU3Ek__BackingField_5() { return &___U3COperandU3Ek__BackingField_5; }
	inline void set_U3COperandU3Ek__BackingField_5(Expression_t30A004209C10C2D9A9785B2F74EEED431A4D4660 * value)
	{
		___U3COperandU3Ek__BackingField_5 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___U3COperandU3Ek__BackingField_5), (void*)value);
	}

	inline static int32_t get_offset_of_U3CMethodU3Ek__BackingField_6() { return static_cast<int32_t>(offsetof(UnaryExpression_t5DE6F6FA2216CDD34DFCFADEB0080CB29326DD62, ___U3CMethodU3Ek__BackingField_6)); }
	inline MethodInfo_t * get_U3CMethodU3Ek__BackingField_6() const { return ___U3CMethodU3Ek__BackingField_6; }
	inline MethodInfo_t ** get_address_of_U3CMethodU3Ek__BackingField_6() { return &___U3CMethodU3Ek__BackingField_6; }
	inline void set_U3CMethodU3Ek__BackingField_6(MethodInfo_t * value)
	{
		___U3CMethodU3Ek__BackingField_6 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___U3CMethodU3Ek__BackingField_6), (void*)value);
	}
};


// System.Xml.Schema.XmlBaseConverter
struct XmlBaseConverter_t4F695A2F48A15F26227A564201074D2EBF094C55  : public XmlValueConverter_t18B2DCDB3B3F7609F3E43D5C46D2095BD09E6763
{
public:
	// System.Xml.Schema.XmlSchemaType System.Xml.Schema.XmlBaseConverter::schemaType
	XmlSchemaType_t390DB79F0EB746B12C400BD1897CDB9F3557FCBA * ___schemaType_0;
	// System.Xml.Schema.XmlTypeCode System.Xml.Schema.XmlBaseConverter::typeCode
	int32_t ___typeCode_1;
	// System.Type System.Xml.Schema.XmlBaseConverter::clrTypeDefault
	Type_t * ___clrTypeDefault_2;

public:
	inline static int32_t get_offset_of_schemaType_0() { return static_cast<int32_t>(offsetof(XmlBaseConverter_t4F695A2F48A15F26227A564201074D2EBF094C55, ___schemaType_0)); }
	inline XmlSchemaType_t390DB79F0EB746B12C400BD1897CDB9F3557FCBA * get_schemaType_0() const { return ___schemaType_0; }
	inline XmlSchemaType_t390DB79F0EB746B12C400BD1897CDB9F3557FCBA ** get_address_of_schemaType_0() { return &___schemaType_0; }
	inline void set_schemaType_0(XmlSchemaType_t390DB79F0EB746B12C400BD1897CDB9F3557FCBA * value)
	{
		___schemaType_0 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___schemaType_0), (void*)value);
	}

	inline static int32_t get_offset_of_typeCode_1() { return static_cast<int32_t>(offsetof(XmlBaseConverter_t4F695A2F48A15F26227A564201074D2EBF094C55, ___typeCode_1)); }
	inline int32_t get_typeCode_1() const { return ___typeCode_1; }
	inline int32_t* get_address_of_typeCode_1() { return &___typeCode_1; }
	inline void set_typeCode_1(int32_t value)
	{
		___typeCode_1 = value;
	}

	inline static int32_t get_offset_of_clrTypeDefault_2() { return static_cast<int32_t>(offsetof(XmlBaseConverter_t4F695A2F48A15F26227A564201074D2EBF094C55, ___clrTypeDefault_2)); }
	inline Type_t * get_clrTypeDefault_2() const { return ___clrTypeDefault_2; }
	inline Type_t ** get_address_of_clrTypeDefault_2() { return &___clrTypeDefault_2; }
	inline void set_clrTypeDefault_2(Type_t * value)
	{
		___clrTypeDefault_2 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___clrTypeDefault_2), (void*)value);
	}
};

struct XmlBaseConverter_t4F695A2F48A15F26227A564201074D2EBF094C55_StaticFields
{
public:
	// System.Type System.Xml.Schema.XmlBaseConverter::ICollectionType
	Type_t * ___ICollectionType_3;
	// System.Type System.Xml.Schema.XmlBaseConverter::IEnumerableType
	Type_t * ___IEnumerableType_4;
	// System.Type System.Xml.Schema.XmlBaseConverter::IListType
	Type_t * ___IListType_5;
	// System.Type System.Xml.Schema.XmlBaseConverter::ObjectArrayType
	Type_t * ___ObjectArrayType_6;
	// System.Type System.Xml.Schema.XmlBaseConverter::StringArrayType
	Type_t * ___StringArrayType_7;
	// System.Type System.Xml.Schema.XmlBaseConverter::XmlAtomicValueArrayType
	Type_t * ___XmlAtomicValueArrayType_8;
	// System.Type System.Xml.Schema.XmlBaseConverter::DecimalType
	Type_t * ___DecimalType_9;
	// System.Type System.Xml.Schema.XmlBaseConverter::Int32Type
	Type_t * ___Int32Type_10;
	// System.Type System.Xml.Schema.XmlBaseConverter::Int64Type
	Type_t * ___Int64Type_11;
	// System.Type System.Xml.Schema.XmlBaseConverter::StringType
	Type_t * ___StringType_12;
	// System.Type System.Xml.Schema.XmlBaseConverter::XmlAtomicValueType
	Type_t * ___XmlAtomicValueType_13;
	// System.Type System.Xml.Schema.XmlBaseConverter::ObjectType
	Type_t * ___ObjectType_14;
	// System.Type System.Xml.Schema.XmlBaseConverter::ByteType
	Type_t * ___ByteType_15;
	// System.Type System.Xml.Schema.XmlBaseConverter::Int16Type
	Type_t * ___Int16Type_16;
	// System.Type System.Xml.Schema.XmlBaseConverter::SByteType
	Type_t * ___SByteType_17;
	// System.Type System.Xml.Schema.XmlBaseConverter::UInt16Type
	Type_t * ___UInt16Type_18;
	// System.Type System.Xml.Schema.XmlBaseConverter::UInt32Type
	Type_t * ___UInt32Type_19;
	// System.Type System.Xml.Schema.XmlBaseConverter::UInt64Type
	Type_t * ___UInt64Type_20;
	// System.Type System.Xml.Schema.XmlBaseConverter::XPathItemType
	Type_t * ___XPathItemType_21;
	// System.Type System.Xml.Schema.XmlBaseConverter::DoubleType
	Type_t * ___DoubleType_22;
	// System.Type System.Xml.Schema.XmlBaseConverter::SingleType
	Type_t * ___SingleType_23;
	// System.Type System.Xml.Schema.XmlBaseConverter::DateTimeType
	Type_t * ___DateTimeType_24;
	// System.Type System.Xml.Schema.XmlBaseConverter::DateTimeOffsetType
	Type_t * ___DateTimeOffsetType_25;
	// System.Type System.Xml.Schema.XmlBaseConverter::BooleanType
	Type_t * ___BooleanType_26;
	// System.Type System.Xml.Schema.XmlBaseConverter::ByteArrayType
	Type_t * ___ByteArrayType_27;
	// System.Type System.Xml.Schema.XmlBaseConverter::XmlQualifiedNameType
	Type_t * ___XmlQualifiedNameType_28;
	// System.Type System.Xml.Schema.XmlBaseConverter::UriType
	Type_t * ___UriType_29;
	// System.Type System.Xml.Schema.XmlBaseConverter::TimeSpanType
	Type_t * ___TimeSpanType_30;
	// System.Type System.Xml.Schema.XmlBaseConverter::XPathNavigatorType
	Type_t * ___XPathNavigatorType_31;

public:
	inline static int32_t get_offset_of_ICollectionType_3() { return static_cast<int32_t>(offsetof(XmlBaseConverter_t4F695A2F48A15F26227A564201074D2EBF094C55_StaticFields, ___ICollectionType_3)); }
	inline Type_t * get_ICollectionType_3() const { return ___ICollectionType_3; }
	inline Type_t ** get_address_of_ICollectionType_3() { return &___ICollectionType_3; }
	inline void set_ICollectionType_3(Type_t * value)
	{
		___ICollectionType_3 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___ICollectionType_3), (void*)value);
	}

	inline static int32_t get_offset_of_IEnumerableType_4() { return static_cast<int32_t>(offsetof(XmlBaseConverter_t4F695A2F48A15F26227A564201074D2EBF094C55_StaticFields, ___IEnumerableType_4)); }
	inline Type_t * get_IEnumerableType_4() const { return ___IEnumerableType_4; }
	inline Type_t ** get_address_of_IEnumerableType_4() { return &___IEnumerableType_4; }
	inline void set_IEnumerableType_4(Type_t * value)
	{
		___IEnumerableType_4 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___IEnumerableType_4), (void*)value);
	}

	inline static int32_t get_offset_of_IListType_5() { return static_cast<int32_t>(offsetof(XmlBaseConverter_t4F695A2F48A15F26227A564201074D2EBF094C55_StaticFields, ___IListType_5)); }
	inline Type_t * get_IListType_5() const { return ___IListType_5; }
	inline Type_t ** get_address_of_IListType_5() { return &___IListType_5; }
	inline void set_IListType_5(Type_t * value)
	{
		___IListType_5 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___IListType_5), (void*)value);
	}

	inline static int32_t get_offset_of_ObjectArrayType_6() { return static_cast<int32_t>(offsetof(XmlBaseConverter_t4F695A2F48A15F26227A564201074D2EBF094C55_StaticFields, ___ObjectArrayType_6)); }
	inline Type_t * get_ObjectArrayType_6() const { return ___ObjectArrayType_6; }
	inline Type_t ** get_address_of_ObjectArrayType_6() { return &___ObjectArrayType_6; }
	inline void set_ObjectArrayType_6(Type_t * value)
	{
		___ObjectArrayType_6 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___ObjectArrayType_6), (void*)value);
	}

	inline static int32_t get_offset_of_StringArrayType_7() { return static_cast<int32_t>(offsetof(XmlBaseConverter_t4F695A2F48A15F26227A564201074D2EBF094C55_StaticFields, ___StringArrayType_7)); }
	inline Type_t * get_StringArrayType_7() const { return ___StringArrayType_7; }
	inline Type_t ** get_address_of_StringArrayType_7() { return &___StringArrayType_7; }
	inline void set_StringArrayType_7(Type_t * value)
	{
		___StringArrayType_7 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___StringArrayType_7), (void*)value);
	}

	inline static int32_t get_offset_of_XmlAtomicValueArrayType_8() { return static_cast<int32_t>(offsetof(XmlBaseConverter_t4F695A2F48A15F26227A564201074D2EBF094C55_StaticFields, ___XmlAtomicValueArrayType_8)); }
	inline Type_t * get_XmlAtomicValueArrayType_8() const { return ___XmlAtomicValueArrayType_8; }
	inline Type_t ** get_address_of_XmlAtomicValueArrayType_8() { return &___XmlAtomicValueArrayType_8; }
	inline void set_XmlAtomicValueArrayType_8(Type_t * value)
	{
		___XmlAtomicValueArrayType_8 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___XmlAtomicValueArrayType_8), (void*)value);
	}

	inline static int32_t get_offset_of_DecimalType_9() { return static_cast<int32_t>(offsetof(XmlBaseConverter_t4F695A2F48A15F26227A564201074D2EBF094C55_StaticFields, ___DecimalType_9)); }
	inline Type_t * get_DecimalType_9() const { return ___DecimalType_9; }
	inline Type_t ** get_address_of_DecimalType_9() { return &___DecimalType_9; }
	inline void set_DecimalType_9(Type_t * value)
	{
		___DecimalType_9 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___DecimalType_9), (void*)value);
	}

	inline static int32_t get_offset_of_Int32Type_10() { return static_cast<int32_t>(offsetof(XmlBaseConverter_t4F695A2F48A15F26227A564201074D2EBF094C55_StaticFields, ___Int32Type_10)); }
	inline Type_t * get_Int32Type_10() const { return ___Int32Type_10; }
	inline Type_t ** get_address_of_Int32Type_10() { return &___Int32Type_10; }
	inline void set_Int32Type_10(Type_t * value)
	{
		___Int32Type_10 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___Int32Type_10), (void*)value);
	}

	inline static int32_t get_offset_of_Int64Type_11() { return static_cast<int32_t>(offsetof(XmlBaseConverter_t4F695A2F48A15F26227A564201074D2EBF094C55_StaticFields, ___Int64Type_11)); }
	inline Type_t * get_Int64Type_11() const { return ___Int64Type_11; }
	inline Type_t ** get_address_of_Int64Type_11() { return &___Int64Type_11; }
	inline void set_Int64Type_11(Type_t * value)
	{
		___Int64Type_11 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___Int64Type_11), (void*)value);
	}

	inline static int32_t get_offset_of_StringType_12() { return static_cast<int32_t>(offsetof(XmlBaseConverter_t4F695A2F48A15F26227A564201074D2EBF094C55_StaticFields, ___StringType_12)); }
	inline Type_t * get_StringType_12() const { return ___StringType_12; }
	inline Type_t ** get_address_of_StringType_12() { return &___StringType_12; }
	inline void set_StringType_12(Type_t * value)
	{
		___StringType_12 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___StringType_12), (void*)value);
	}

	inline static int32_t get_offset_of_XmlAtomicValueType_13() { return static_cast<int32_t>(offsetof(XmlBaseConverter_t4F695A2F48A15F26227A564201074D2EBF094C55_StaticFields, ___XmlAtomicValueType_13)); }
	inline Type_t * get_XmlAtomicValueType_13() const { return ___XmlAtomicValueType_13; }
	inline Type_t ** get_address_of_XmlAtomicValueType_13() { return &___XmlAtomicValueType_13; }
	inline void set_XmlAtomicValueType_13(Type_t * value)
	{
		___XmlAtomicValueType_13 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___XmlAtomicValueType_13), (void*)value);
	}

	inline static int32_t get_offset_of_ObjectType_14() { return static_cast<int32_t>(offsetof(XmlBaseConverter_t4F695A2F48A15F26227A564201074D2EBF094C55_StaticFields, ___ObjectType_14)); }
	inline Type_t * get_ObjectType_14() const { return ___ObjectType_14; }
	inline Type_t ** get_address_of_ObjectType_14() { return &___ObjectType_14; }
	inline void set_ObjectType_14(Type_t * value)
	{
		___ObjectType_14 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___ObjectType_14), (void*)value);
	}

	inline static int32_t get_offset_of_ByteType_15() { return static_cast<int32_t>(offsetof(XmlBaseConverter_t4F695A2F48A15F26227A564201074D2EBF094C55_StaticFields, ___ByteType_15)); }
	inline Type_t * get_ByteType_15() const { return ___ByteType_15; }
	inline Type_t ** get_address_of_ByteType_15() { return &___ByteType_15; }
	inline void set_ByteType_15(Type_t * value)
	{
		___ByteType_15 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___ByteType_15), (void*)value);
	}

	inline static int32_t get_offset_of_Int16Type_16() { return static_cast<int32_t>(offsetof(XmlBaseConverter_t4F695A2F48A15F26227A564201074D2EBF094C55_StaticFields, ___Int16Type_16)); }
	inline Type_t * get_Int16Type_16() const { return ___Int16Type_16; }
	inline Type_t ** get_address_of_Int16Type_16() { return &___Int16Type_16; }
	inline void set_Int16Type_16(Type_t * value)
	{
		___Int16Type_16 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___Int16Type_16), (void*)value);
	}

	inline static int32_t get_offset_of_SByteType_17() { return static_cast<int32_t>(offsetof(XmlBaseConverter_t4F695A2F48A15F26227A564201074D2EBF094C55_StaticFields, ___SByteType_17)); }
	inline Type_t * get_SByteType_17() const { return ___SByteType_17; }
	inline Type_t ** get_address_of_SByteType_17() { return &___SByteType_17; }
	inline void set_SByteType_17(Type_t * value)
	{
		___SByteType_17 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___SByteType_17), (void*)value);
	}

	inline static int32_t get_offset_of_UInt16Type_18() { return static_cast<int32_t>(offsetof(XmlBaseConverter_t4F695A2F48A15F26227A564201074D2EBF094C55_StaticFields, ___UInt16Type_18)); }
	inline Type_t * get_UInt16Type_18() const { return ___UInt16Type_18; }
	inline Type_t ** get_address_of_UInt16Type_18() { return &___UInt16Type_18; }
	inline void set_UInt16Type_18(Type_t * value)
	{
		___UInt16Type_18 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___UInt16Type_18), (void*)value);
	}

	inline static int32_t get_offset_of_UInt32Type_19() { return static_cast<int32_t>(offsetof(XmlBaseConverter_t4F695A2F48A15F26227A564201074D2EBF094C55_StaticFields, ___UInt32Type_19)); }
	inline Type_t * get_UInt32Type_19() const { return ___UInt32Type_19; }
	inline Type_t ** get_address_of_UInt32Type_19() { return &___UInt32Type_19; }
	inline void set_UInt32Type_19(Type_t * value)
	{
		___UInt32Type_19 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___UInt32Type_19), (void*)value);
	}

	inline static int32_t get_offset_of_UInt64Type_20() { return static_cast<int32_t>(offsetof(XmlBaseConverter_t4F695A2F48A15F26227A564201074D2EBF094C55_StaticFields, ___UInt64Type_20)); }
	inline Type_t * get_UInt64Type_20() const { return ___UInt64Type_20; }
	inline Type_t ** get_address_of_UInt64Type_20() { return &___UInt64Type_20; }
	inline void set_UInt64Type_20(Type_t * value)
	{
		___UInt64Type_20 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___UInt64Type_20), (void*)value);
	}

	inline static int32_t get_offset_of_XPathItemType_21() { return static_cast<int32_t>(offsetof(XmlBaseConverter_t4F695A2F48A15F26227A564201074D2EBF094C55_StaticFields, ___XPathItemType_21)); }
	inline Type_t * get_XPathItemType_21() const { return ___XPathItemType_21; }
	inline Type_t ** get_address_of_XPathItemType_21() { return &___XPathItemType_21; }
	inline void set_XPathItemType_21(Type_t * value)
	{
		___XPathItemType_21 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___XPathItemType_21), (void*)value);
	}

	inline static int32_t get_offset_of_DoubleType_22() { return static_cast<int32_t>(offsetof(XmlBaseConverter_t4F695A2F48A15F26227A564201074D2EBF094C55_StaticFields, ___DoubleType_22)); }
	inline Type_t * get_DoubleType_22() const { return ___DoubleType_22; }
	inline Type_t ** get_address_of_DoubleType_22() { return &___DoubleType_22; }
	inline void set_DoubleType_22(Type_t * value)
	{
		___DoubleType_22 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___DoubleType_22), (void*)value);
	}

	inline static int32_t get_offset_of_SingleType_23() { return static_cast<int32_t>(offsetof(XmlBaseConverter_t4F695A2F48A15F26227A564201074D2EBF094C55_StaticFields, ___SingleType_23)); }
	inline Type_t * get_SingleType_23() const { return ___SingleType_23; }
	inline Type_t ** get_address_of_SingleType_23() { return &___SingleType_23; }
	inline void set_SingleType_23(Type_t * value)
	{
		___SingleType_23 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___SingleType_23), (void*)value);
	}

	inline static int32_t get_offset_of_DateTimeType_24() { return static_cast<int32_t>(offsetof(XmlBaseConverter_t4F695A2F48A15F26227A564201074D2EBF094C55_StaticFields, ___DateTimeType_24)); }
	inline Type_t * get_DateTimeType_24() const { return ___DateTimeType_24; }
	inline Type_t ** get_address_of_DateTimeType_24() { return &___DateTimeType_24; }
	inline void set_DateTimeType_24(Type_t * value)
	{
		___DateTimeType_24 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___DateTimeType_24), (void*)value);
	}

	inline static int32_t get_offset_of_DateTimeOffsetType_25() { return static_cast<int32_t>(offsetof(XmlBaseConverter_t4F695A2F48A15F26227A564201074D2EBF094C55_StaticFields, ___DateTimeOffsetType_25)); }
	inline Type_t * get_DateTimeOffsetType_25() const { return ___DateTimeOffsetType_25; }
	inline Type_t ** get_address_of_DateTimeOffsetType_25() { return &___DateTimeOffsetType_25; }
	inline void set_DateTimeOffsetType_25(Type_t * value)
	{
		___DateTimeOffsetType_25 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___DateTimeOffsetType_25), (void*)value);
	}

	inline static int32_t get_offset_of_BooleanType_26() { return static_cast<int32_t>(offsetof(XmlBaseConverter_t4F695A2F48A15F26227A564201074D2EBF094C55_StaticFields, ___BooleanType_26)); }
	inline Type_t * get_BooleanType_26() const { return ___BooleanType_26; }
	inline Type_t ** get_address_of_BooleanType_26() { return &___BooleanType_26; }
	inline void set_BooleanType_26(Type_t * value)
	{
		___BooleanType_26 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___BooleanType_26), (void*)value);
	}

	inline static int32_t get_offset_of_ByteArrayType_27() { return static_cast<int32_t>(offsetof(XmlBaseConverter_t4F695A2F48A15F26227A564201074D2EBF094C55_StaticFields, ___ByteArrayType_27)); }
	inline Type_t * get_ByteArrayType_27() const { return ___ByteArrayType_27; }
	inline Type_t ** get_address_of_ByteArrayType_27() { return &___ByteArrayType_27; }
	inline void set_ByteArrayType_27(Type_t * value)
	{
		___ByteArrayType_27 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___ByteArrayType_27), (void*)value);
	}

	inline static int32_t get_offset_of_XmlQualifiedNameType_28() { return static_cast<int32_t>(offsetof(XmlBaseConverter_t4F695A2F48A15F26227A564201074D2EBF094C55_StaticFields, ___XmlQualifiedNameType_28)); }
	inline Type_t * get_XmlQualifiedNameType_28() const { return ___XmlQualifiedNameType_28; }
	inline Type_t ** get_address_of_XmlQualifiedNameType_28() { return &___XmlQualifiedNameType_28; }
	inline void set_XmlQualifiedNameType_28(Type_t * value)
	{
		___XmlQualifiedNameType_28 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___XmlQualifiedNameType_28), (void*)value);
	}

	inline static int32_t get_offset_of_UriType_29() { return static_cast<int32_t>(offsetof(XmlBaseConverter_t4F695A2F48A15F26227A564201074D2EBF094C55_StaticFields, ___UriType_29)); }
	inline Type_t * get_UriType_29() const { return ___UriType_29; }
	inline Type_t ** get_address_of_UriType_29() { return &___UriType_29; }
	inline void set_UriType_29(Type_t * value)
	{
		___UriType_29 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___UriType_29), (void*)value);
	}

	inline static int32_t get_offset_of_TimeSpanType_30() { return static_cast<int32_t>(offsetof(XmlBaseConverter_t4F695A2F48A15F26227A564201074D2EBF094C55_StaticFields, ___TimeSpanType_30)); }
	inline Type_t * get_TimeSpanType_30() const { return ___TimeSpanType_30; }
	inline Type_t ** get_address_of_TimeSpanType_30() { return &___TimeSpanType_30; }
	inline void set_TimeSpanType_30(Type_t * value)
	{
		___TimeSpanType_30 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___TimeSpanType_30), (void*)value);
	}

	inline static int32_t get_offset_of_XPathNavigatorType_31() { return static_cast<int32_t>(offsetof(XmlBaseConverter_t4F695A2F48A15F26227A564201074D2EBF094C55_StaticFields, ___XPathNavigatorType_31)); }
	inline Type_t * get_XPathNavigatorType_31() const { return ___XPathNavigatorType_31; }
	inline Type_t ** get_address_of_XPathNavigatorType_31() { return &___XPathNavigatorType_31; }
	inline void set_XPathNavigatorType_31(Type_t * value)
	{
		___XPathNavigatorType_31 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___XPathNavigatorType_31), (void*)value);
	}
};


// System.Runtime.InteropServices.WindowsRuntime.WindowsRuntimeMarshal/NativeOrStaticEventRegistrationImpl/EventRegistrationTokenListWithCount
struct EventRegistrationTokenListWithCount_t8BA708F75B90C86A7CA1F3FD1DFCBD742D458FC6  : public RuntimeObject
{
public:
	// System.Runtime.InteropServices.WindowsRuntime.WindowsRuntimeMarshal/NativeOrStaticEventRegistrationImpl/TokenListCount System.Runtime.InteropServices.WindowsRuntime.WindowsRuntimeMarshal/NativeOrStaticEventRegistrationImpl/EventRegistrationTokenListWithCount::_tokenListCount
	TokenListCount_t769EA62356D8C37857DCC81DB79A76FA75E319AC * ____tokenListCount_0;
	// System.Runtime.InteropServices.WindowsRuntime.WindowsRuntimeMarshal/EventRegistrationTokenList System.Runtime.InteropServices.WindowsRuntime.WindowsRuntimeMarshal/NativeOrStaticEventRegistrationImpl/EventRegistrationTokenListWithCount::_tokenList
	EventRegistrationTokenList_t0B8EB3E0DA8A305BFCD313936266A15F50B4B128  ____tokenList_1;

public:
	inline static int32_t get_offset_of__tokenListCount_0() { return static_cast<int32_t>(offsetof(EventRegistrationTokenListWithCount_t8BA708F75B90C86A7CA1F3FD1DFCBD742D458FC6, ____tokenListCount_0)); }
	inline TokenListCount_t769EA62356D8C37857DCC81DB79A76FA75E319AC * get__tokenListCount_0() const { return ____tokenListCount_0; }
	inline TokenListCount_t769EA62356D8C37857DCC81DB79A76FA75E319AC ** get_address_of__tokenListCount_0() { return &____tokenListCount_0; }
	inline void set__tokenListCount_0(TokenListCount_t769EA62356D8C37857DCC81DB79A76FA75E319AC * value)
	{
		____tokenListCount_0 = value;
		Il2CppCodeGenWriteBarrier((void**)(&____tokenListCount_0), (void*)value);
	}

	inline static int32_t get_offset_of__tokenList_1() { return static_cast<int32_t>(offsetof(EventRegistrationTokenListWithCount_t8BA708F75B90C86A7CA1F3FD1DFCBD742D458FC6, ____tokenList_1)); }
	inline EventRegistrationTokenList_t0B8EB3E0DA8A305BFCD313936266A15F50B4B128  get__tokenList_1() const { return ____tokenList_1; }
	inline EventRegistrationTokenList_t0B8EB3E0DA8A305BFCD313936266A15F50B4B128 * get_address_of__tokenList_1() { return &____tokenList_1; }
	inline void set__tokenList_1(EventRegistrationTokenList_t0B8EB3E0DA8A305BFCD313936266A15F50B4B128  value)
	{
		____tokenList_1 = value;
		Il2CppCodeGenWriteBarrier((void**)&(((&____tokenList_1))->___restTokens_1), (void*)NULL);
	}
};


// System.Action`1<System.Runtime.InteropServices.WindowsRuntime.EventRegistrationToken>
struct Action_1_t91FC536003CAB9AB56B84E901AE08156372856E3  : public MulticastDelegate_t
{
public:

public:
};


// System.Dynamic.DynamicObject/MetaDynamic/Fallback`1<System.Object>
struct Fallback_1_t80F90982EFE3FFA9073E13C782ABA43FD48B7A9A  : public MulticastDelegate_t
{
public:

public:
};


// System.Func`2<System.Object,System.Runtime.InteropServices.WindowsRuntime.EventRegistrationToken>
struct Func_2_t5650431F2BFFD75382D3BA01D19E366CD1DA1813  : public MulticastDelegate_t
{
public:

public:
};


// System.Runtime.Serialization.SerializationException
struct SerializationException_tDB38C13A2ABF407C381E3F332D197AC1AD097A92  : public SystemException_tC551B4D6EE3772B5F32C71EE8C719F4B43ECCC62
{
public:

public:
};

struct SerializationException_tDB38C13A2ABF407C381E3F332D197AC1AD097A92_StaticFields
{
public:
	// System.String System.Runtime.Serialization.SerializationException::_nullMessage
	String_t* ____nullMessage_17;

public:
	inline static int32_t get_offset_of__nullMessage_17() { return static_cast<int32_t>(offsetof(SerializationException_tDB38C13A2ABF407C381E3F332D197AC1AD097A92_StaticFields, ____nullMessage_17)); }
	inline String_t* get__nullMessage_17() const { return ____nullMessage_17; }
	inline String_t** get_address_of__nullMessage_17() { return &____nullMessage_17; }
	inline void set__nullMessage_17(String_t* value)
	{
		____nullMessage_17 = value;
		Il2CppCodeGenWriteBarrier((void**)(&____nullMessage_17), (void*)value);
	}
};


// System.Xml.Schema.XmlListConverter
struct XmlListConverter_t58F692567B1B34BF5171B647F1BE66EC017D4F4D  : public XmlBaseConverter_t4F695A2F48A15F26227A564201074D2EBF094C55
{
public:
	// System.Xml.Schema.XmlValueConverter System.Xml.Schema.XmlListConverter::atomicConverter
	XmlValueConverter_t18B2DCDB3B3F7609F3E43D5C46D2095BD09E6763 * ___atomicConverter_32;

public:
	inline static int32_t get_offset_of_atomicConverter_32() { return static_cast<int32_t>(offsetof(XmlListConverter_t58F692567B1B34BF5171B647F1BE66EC017D4F4D, ___atomicConverter_32)); }
	inline XmlValueConverter_t18B2DCDB3B3F7609F3E43D5C46D2095BD09E6763 * get_atomicConverter_32() const { return ___atomicConverter_32; }
	inline XmlValueConverter_t18B2DCDB3B3F7609F3E43D5C46D2095BD09E6763 ** get_address_of_atomicConverter_32() { return &___atomicConverter_32; }
	inline void set_atomicConverter_32(XmlValueConverter_t18B2DCDB3B3F7609F3E43D5C46D2095BD09E6763 * value)
	{
		___atomicConverter_32 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___atomicConverter_32), (void*)value);
	}
};


// System.Runtime.Serialization.XmlObjectSerializerContext
struct XmlObjectSerializerContext_t9057A798705D63BEE0929C1630965F6D388C2623  : public RuntimeObject
{
public:
	// System.Runtime.Serialization.XmlObjectSerializer System.Runtime.Serialization.XmlObjectSerializerContext::serializer
	XmlObjectSerializer_t079CA08E29281806E298EA39F279546B75A0011E * ___serializer_0;
	// System.Runtime.Serialization.DataContract System.Runtime.Serialization.XmlObjectSerializerContext::rootTypeDataContract
	DataContract_t2532937602A7512698085FE1EB691B9AEF058B15 * ___rootTypeDataContract_1;
	// System.Runtime.Serialization.ScopedKnownTypes System.Runtime.Serialization.XmlObjectSerializerContext::scopedKnownTypes
	ScopedKnownTypes_t55B523F7067D7B5A1EA1CF17C20354731924CCA7  ___scopedKnownTypes_2;
	// System.Collections.Generic.Dictionary`2<System.Xml.XmlQualifiedName,System.Runtime.Serialization.DataContract> System.Runtime.Serialization.XmlObjectSerializerContext::serializerKnownDataContracts
	Dictionary_2_t4718820257735C3DF2901A055292922ED97E4759 * ___serializerKnownDataContracts_3;
	// System.Boolean System.Runtime.Serialization.XmlObjectSerializerContext::isSerializerKnownDataContractsSetExplicit
	bool ___isSerializerKnownDataContractsSetExplicit_4;
	// System.Collections.Generic.IList`1<System.Type> System.Runtime.Serialization.XmlObjectSerializerContext::serializerKnownTypeList
	RuntimeObject* ___serializerKnownTypeList_5;
	// System.Boolean System.Runtime.Serialization.XmlObjectSerializerContext::demandedSerializationFormatterPermission
	bool ___demandedSerializationFormatterPermission_6;
	// System.Boolean System.Runtime.Serialization.XmlObjectSerializerContext::demandedMemberAccessPermission
	bool ___demandedMemberAccessPermission_7;
	// System.Int32 System.Runtime.Serialization.XmlObjectSerializerContext::itemCount
	int32_t ___itemCount_8;
	// System.Int32 System.Runtime.Serialization.XmlObjectSerializerContext::maxItemsInObjectGraph
	int32_t ___maxItemsInObjectGraph_9;
	// System.Runtime.Serialization.StreamingContext System.Runtime.Serialization.XmlObjectSerializerContext::streamingContext
	StreamingContext_t5888E7E8C81AB6EF3B14FDDA6674F458076A8505  ___streamingContext_10;
	// System.Boolean System.Runtime.Serialization.XmlObjectSerializerContext::ignoreExtensionDataObject
	bool ___ignoreExtensionDataObject_11;
	// System.Runtime.Serialization.DataContractResolver System.Runtime.Serialization.XmlObjectSerializerContext::dataContractResolver
	DataContractResolver_t9AD484A6045B8B4A915E3790073DBA483ED529D4 * ___dataContractResolver_12;
	// System.Runtime.Serialization.KnownTypeDataContractResolver System.Runtime.Serialization.XmlObjectSerializerContext::knownTypeResolver
	KnownTypeDataContractResolver_t80FA21062F8A80958C85D372384F43DADB6EB0CC * ___knownTypeResolver_13;

public:
	inline static int32_t get_offset_of_serializer_0() { return static_cast<int32_t>(offsetof(XmlObjectSerializerContext_t9057A798705D63BEE0929C1630965F6D388C2623, ___serializer_0)); }
	inline XmlObjectSerializer_t079CA08E29281806E298EA39F279546B75A0011E * get_serializer_0() const { return ___serializer_0; }
	inline XmlObjectSerializer_t079CA08E29281806E298EA39F279546B75A0011E ** get_address_of_serializer_0() { return &___serializer_0; }
	inline void set_serializer_0(XmlObjectSerializer_t079CA08E29281806E298EA39F279546B75A0011E * value)
	{
		___serializer_0 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___serializer_0), (void*)value);
	}

	inline static int32_t get_offset_of_rootTypeDataContract_1() { return static_cast<int32_t>(offsetof(XmlObjectSerializerContext_t9057A798705D63BEE0929C1630965F6D388C2623, ___rootTypeDataContract_1)); }
	inline DataContract_t2532937602A7512698085FE1EB691B9AEF058B15 * get_rootTypeDataContract_1() const { return ___rootTypeDataContract_1; }
	inline DataContract_t2532937602A7512698085FE1EB691B9AEF058B15 ** get_address_of_rootTypeDataContract_1() { return &___rootTypeDataContract_1; }
	inline void set_rootTypeDataContract_1(DataContract_t2532937602A7512698085FE1EB691B9AEF058B15 * value)
	{
		___rootTypeDataContract_1 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___rootTypeDataContract_1), (void*)value);
	}

	inline static int32_t get_offset_of_scopedKnownTypes_2() { return static_cast<int32_t>(offsetof(XmlObjectSerializerContext_t9057A798705D63BEE0929C1630965F6D388C2623, ___scopedKnownTypes_2)); }
	inline ScopedKnownTypes_t55B523F7067D7B5A1EA1CF17C20354731924CCA7  get_scopedKnownTypes_2() const { return ___scopedKnownTypes_2; }
	inline ScopedKnownTypes_t55B523F7067D7B5A1EA1CF17C20354731924CCA7 * get_address_of_scopedKnownTypes_2() { return &___scopedKnownTypes_2; }
	inline void set_scopedKnownTypes_2(ScopedKnownTypes_t55B523F7067D7B5A1EA1CF17C20354731924CCA7  value)
	{
		___scopedKnownTypes_2 = value;
		Il2CppCodeGenWriteBarrier((void**)&(((&___scopedKnownTypes_2))->___dataContractDictionaries_0), (void*)NULL);
	}

	inline static int32_t get_offset_of_serializerKnownDataContracts_3() { return static_cast<int32_t>(offsetof(XmlObjectSerializerContext_t9057A798705D63BEE0929C1630965F6D388C2623, ___serializerKnownDataContracts_3)); }
	inline Dictionary_2_t4718820257735C3DF2901A055292922ED97E4759 * get_serializerKnownDataContracts_3() const { return ___serializerKnownDataContracts_3; }
	inline Dictionary_2_t4718820257735C3DF2901A055292922ED97E4759 ** get_address_of_serializerKnownDataContracts_3() { return &___serializerKnownDataContracts_3; }
	inline void set_serializerKnownDataContracts_3(Dictionary_2_t4718820257735C3DF2901A055292922ED97E4759 * value)
	{
		___serializerKnownDataContracts_3 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___serializerKnownDataContracts_3), (void*)value);
	}

	inline static int32_t get_offset_of_isSerializerKnownDataContractsSetExplicit_4() { return static_cast<int32_t>(offsetof(XmlObjectSerializerContext_t9057A798705D63BEE0929C1630965F6D388C2623, ___isSerializerKnownDataContractsSetExplicit_4)); }
	inline bool get_isSerializerKnownDataContractsSetExplicit_4() const { return ___isSerializerKnownDataContractsSetExplicit_4; }
	inline bool* get_address_of_isSerializerKnownDataContractsSetExplicit_4() { return &___isSerializerKnownDataContractsSetExplicit_4; }
	inline void set_isSerializerKnownDataContractsSetExplicit_4(bool value)
	{
		___isSerializerKnownDataContractsSetExplicit_4 = value;
	}

	inline static int32_t get_offset_of_serializerKnownTypeList_5() { return static_cast<int32_t>(offsetof(XmlObjectSerializerContext_t9057A798705D63BEE0929C1630965F6D388C2623, ___serializerKnownTypeList_5)); }
	inline RuntimeObject* get_serializerKnownTypeList_5() const { return ___serializerKnownTypeList_5; }
	inline RuntimeObject** get_address_of_serializerKnownTypeList_5() { return &___serializerKnownTypeList_5; }
	inline void set_serializerKnownTypeList_5(RuntimeObject* value)
	{
		___serializerKnownTypeList_5 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___serializerKnownTypeList_5), (void*)value);
	}

	inline static int32_t get_offset_of_demandedSerializationFormatterPermission_6() { return static_cast<int32_t>(offsetof(XmlObjectSerializerContext_t9057A798705D63BEE0929C1630965F6D388C2623, ___demandedSerializationFormatterPermission_6)); }
	inline bool get_demandedSerializationFormatterPermission_6() const { return ___demandedSerializationFormatterPermission_6; }
	inline bool* get_address_of_demandedSerializationFormatterPermission_6() { return &___demandedSerializationFormatterPermission_6; }
	inline void set_demandedSerializationFormatterPermission_6(bool value)
	{
		___demandedSerializationFormatterPermission_6 = value;
	}

	inline static int32_t get_offset_of_demandedMemberAccessPermission_7() { return static_cast<int32_t>(offsetof(XmlObjectSerializerContext_t9057A798705D63BEE0929C1630965F6D388C2623, ___demandedMemberAccessPermission_7)); }
	inline bool get_demandedMemberAccessPermission_7() const { return ___demandedMemberAccessPermission_7; }
	inline bool* get_address_of_demandedMemberAccessPermission_7() { return &___demandedMemberAccessPermission_7; }
	inline void set_demandedMemberAccessPermission_7(bool value)
	{
		___demandedMemberAccessPermission_7 = value;
	}

	inline static int32_t get_offset_of_itemCount_8() { return static_cast<int32_t>(offsetof(XmlObjectSerializerContext_t9057A798705D63BEE0929C1630965F6D388C2623, ___itemCount_8)); }
	inline int32_t get_itemCount_8() const { return ___itemCount_8; }
	inline int32_t* get_address_of_itemCount_8() { return &___itemCount_8; }
	inline void set_itemCount_8(int32_t value)
	{
		___itemCount_8 = value;
	}

	inline static int32_t get_offset_of_maxItemsInObjectGraph_9() { return static_cast<int32_t>(offsetof(XmlObjectSerializerContext_t9057A798705D63BEE0929C1630965F6D388C2623, ___maxItemsInObjectGraph_9)); }
	inline int32_t get_maxItemsInObjectGraph_9() const { return ___maxItemsInObjectGraph_9; }
	inline int32_t* get_address_of_maxItemsInObjectGraph_9() { return &___maxItemsInObjectGraph_9; }
	inline void set_maxItemsInObjectGraph_9(int32_t value)
	{
		___maxItemsInObjectGraph_9 = value;
	}

	inline static int32_t get_offset_of_streamingContext_10() { return static_cast<int32_t>(offsetof(XmlObjectSerializerContext_t9057A798705D63BEE0929C1630965F6D388C2623, ___streamingContext_10)); }
	inline StreamingContext_t5888E7E8C81AB6EF3B14FDDA6674F458076A8505  get_streamingContext_10() const { return ___streamingContext_10; }
	inline StreamingContext_t5888E7E8C81AB6EF3B14FDDA6674F458076A8505 * get_address_of_streamingContext_10() { return &___streamingContext_10; }
	inline void set_streamingContext_10(StreamingContext_t5888E7E8C81AB6EF3B14FDDA6674F458076A8505  value)
	{
		___streamingContext_10 = value;
		Il2CppCodeGenWriteBarrier((void**)&(((&___streamingContext_10))->___m_additionalContext_0), (void*)NULL);
	}

	inline static int32_t get_offset_of_ignoreExtensionDataObject_11() { return static_cast<int32_t>(offsetof(XmlObjectSerializerContext_t9057A798705D63BEE0929C1630965F6D388C2623, ___ignoreExtensionDataObject_11)); }
	inline bool get_ignoreExtensionDataObject_11() const { return ___ignoreExtensionDataObject_11; }
	inline bool* get_address_of_ignoreExtensionDataObject_11() { return &___ignoreExtensionDataObject_11; }
	inline void set_ignoreExtensionDataObject_11(bool value)
	{
		___ignoreExtensionDataObject_11 = value;
	}

	inline static int32_t get_offset_of_dataContractResolver_12() { return static_cast<int32_t>(offsetof(XmlObjectSerializerContext_t9057A798705D63BEE0929C1630965F6D388C2623, ___dataContractResolver_12)); }
	inline DataContractResolver_t9AD484A6045B8B4A915E3790073DBA483ED529D4 * get_dataContractResolver_12() const { return ___dataContractResolver_12; }
	inline DataContractResolver_t9AD484A6045B8B4A915E3790073DBA483ED529D4 ** get_address_of_dataContractResolver_12() { return &___dataContractResolver_12; }
	inline void set_dataContractResolver_12(DataContractResolver_t9AD484A6045B8B4A915E3790073DBA483ED529D4 * value)
	{
		___dataContractResolver_12 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___dataContractResolver_12), (void*)value);
	}

	inline static int32_t get_offset_of_knownTypeResolver_13() { return static_cast<int32_t>(offsetof(XmlObjectSerializerContext_t9057A798705D63BEE0929C1630965F6D388C2623, ___knownTypeResolver_13)); }
	inline KnownTypeDataContractResolver_t80FA21062F8A80958C85D372384F43DADB6EB0CC * get_knownTypeResolver_13() const { return ___knownTypeResolver_13; }
	inline KnownTypeDataContractResolver_t80FA21062F8A80958C85D372384F43DADB6EB0CC ** get_address_of_knownTypeResolver_13() { return &___knownTypeResolver_13; }
	inline void set_knownTypeResolver_13(KnownTypeDataContractResolver_t80FA21062F8A80958C85D372384F43DADB6EB0CC * value)
	{
		___knownTypeResolver_13 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___knownTypeResolver_13), (void*)value);
	}
};

struct XmlObjectSerializerContext_t9057A798705D63BEE0929C1630965F6D388C2623_StaticFields
{
public:
	// System.Reflection.MethodInfo System.Runtime.Serialization.XmlObjectSerializerContext::incrementItemCountMethod
	MethodInfo_t * ___incrementItemCountMethod_14;

public:
	inline static int32_t get_offset_of_incrementItemCountMethod_14() { return static_cast<int32_t>(offsetof(XmlObjectSerializerContext_t9057A798705D63BEE0929C1630965F6D388C2623_StaticFields, ___incrementItemCountMethod_14)); }
	inline MethodInfo_t * get_incrementItemCountMethod_14() const { return ___incrementItemCountMethod_14; }
	inline MethodInfo_t ** get_address_of_incrementItemCountMethod_14() { return &___incrementItemCountMethod_14; }
	inline void set_incrementItemCountMethod_14(MethodInfo_t * value)
	{
		___incrementItemCountMethod_14 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___incrementItemCountMethod_14), (void*)value);
	}
};


// System.Runtime.Serialization.XmlObjectSerializerReadContext
struct XmlObjectSerializerReadContext_t3EF773F2A519B2BD15F925F5C44AA251B2036921  : public XmlObjectSerializerContext_t9057A798705D63BEE0929C1630965F6D388C2623
{
public:
	// System.Runtime.Serialization.Attributes System.Runtime.Serialization.XmlObjectSerializerReadContext::attributes
	Attributes_tD6437F2E6AA7A54A2FFBEC096DFF3139A3B294A7 * ___attributes_15;
	// System.Runtime.Serialization.HybridObjectCache System.Runtime.Serialization.XmlObjectSerializerReadContext::deserializedObjects
	HybridObjectCache_tB50855B7F76244247922DC330B5F4CC3527B40EE * ___deserializedObjects_16;
	// System.Runtime.Serialization.XmlSerializableReader System.Runtime.Serialization.XmlObjectSerializerReadContext::xmlSerializableReader
	XmlSerializableReader_t4E181C3106AB58D899A19A210CEAB97005666D95 * ___xmlSerializableReader_17;
	// System.Xml.XmlDocument System.Runtime.Serialization.XmlObjectSerializerReadContext::xmlDocument
	XmlDocument_t513899C58F800C43E8D78C0B72BD18C2C036233F * ___xmlDocument_18;
	// System.Runtime.Serialization.Attributes System.Runtime.Serialization.XmlObjectSerializerReadContext::attributesInXmlData
	Attributes_tD6437F2E6AA7A54A2FFBEC096DFF3139A3B294A7 * ___attributesInXmlData_19;
	// System.Runtime.Serialization.XmlReaderDelegator System.Runtime.Serialization.XmlObjectSerializerReadContext::extensionDataReader
	XmlReaderDelegator_t5BFA29001B28A7C4E173E867DDB27CE3CC875C17 * ___extensionDataReader_20;
	// System.Object System.Runtime.Serialization.XmlObjectSerializerReadContext::getOnlyCollectionValue
	RuntimeObject * ___getOnlyCollectionValue_21;
	// System.Boolean System.Runtime.Serialization.XmlObjectSerializerReadContext::isGetOnlyCollection
	bool ___isGetOnlyCollection_22;

public:
	inline static int32_t get_offset_of_attributes_15() { return static_cast<int32_t>(offsetof(XmlObjectSerializerReadContext_t3EF773F2A519B2BD15F925F5C44AA251B2036921, ___attributes_15)); }
	inline Attributes_tD6437F2E6AA7A54A2FFBEC096DFF3139A3B294A7 * get_attributes_15() const { return ___attributes_15; }
	inline Attributes_tD6437F2E6AA7A54A2FFBEC096DFF3139A3B294A7 ** get_address_of_attributes_15() { return &___attributes_15; }
	inline void set_attributes_15(Attributes_tD6437F2E6AA7A54A2FFBEC096DFF3139A3B294A7 * value)
	{
		___attributes_15 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___attributes_15), (void*)value);
	}

	inline static int32_t get_offset_of_deserializedObjects_16() { return static_cast<int32_t>(offsetof(XmlObjectSerializerReadContext_t3EF773F2A519B2BD15F925F5C44AA251B2036921, ___deserializedObjects_16)); }
	inline HybridObjectCache_tB50855B7F76244247922DC330B5F4CC3527B40EE * get_deserializedObjects_16() const { return ___deserializedObjects_16; }
	inline HybridObjectCache_tB50855B7F76244247922DC330B5F4CC3527B40EE ** get_address_of_deserializedObjects_16() { return &___deserializedObjects_16; }
	inline void set_deserializedObjects_16(HybridObjectCache_tB50855B7F76244247922DC330B5F4CC3527B40EE * value)
	{
		___deserializedObjects_16 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___deserializedObjects_16), (void*)value);
	}

	inline static int32_t get_offset_of_xmlSerializableReader_17() { return static_cast<int32_t>(offsetof(XmlObjectSerializerReadContext_t3EF773F2A519B2BD15F925F5C44AA251B2036921, ___xmlSerializableReader_17)); }
	inline XmlSerializableReader_t4E181C3106AB58D899A19A210CEAB97005666D95 * get_xmlSerializableReader_17() const { return ___xmlSerializableReader_17; }
	inline XmlSerializableReader_t4E181C3106AB58D899A19A210CEAB97005666D95 ** get_address_of_xmlSerializableReader_17() { return &___xmlSerializableReader_17; }
	inline void set_xmlSerializableReader_17(XmlSerializableReader_t4E181C3106AB58D899A19A210CEAB97005666D95 * value)
	{
		___xmlSerializableReader_17 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___xmlSerializableReader_17), (void*)value);
	}

	inline static int32_t get_offset_of_xmlDocument_18() { return static_cast<int32_t>(offsetof(XmlObjectSerializerReadContext_t3EF773F2A519B2BD15F925F5C44AA251B2036921, ___xmlDocument_18)); }
	inline XmlDocument_t513899C58F800C43E8D78C0B72BD18C2C036233F * get_xmlDocument_18() const { return ___xmlDocument_18; }
	inline XmlDocument_t513899C58F800C43E8D78C0B72BD18C2C036233F ** get_address_of_xmlDocument_18() { return &___xmlDocument_18; }
	inline void set_xmlDocument_18(XmlDocument_t513899C58F800C43E8D78C0B72BD18C2C036233F * value)
	{
		___xmlDocument_18 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___xmlDocument_18), (void*)value);
	}

	inline static int32_t get_offset_of_attributesInXmlData_19() { return static_cast<int32_t>(offsetof(XmlObjectSerializerReadContext_t3EF773F2A519B2BD15F925F5C44AA251B2036921, ___attributesInXmlData_19)); }
	inline Attributes_tD6437F2E6AA7A54A2FFBEC096DFF3139A3B294A7 * get_attributesInXmlData_19() const { return ___attributesInXmlData_19; }
	inline Attributes_tD6437F2E6AA7A54A2FFBEC096DFF3139A3B294A7 ** get_address_of_attributesInXmlData_19() { return &___attributesInXmlData_19; }
	inline void set_attributesInXmlData_19(Attributes_tD6437F2E6AA7A54A2FFBEC096DFF3139A3B294A7 * value)
	{
		___attributesInXmlData_19 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___attributesInXmlData_19), (void*)value);
	}

	inline static int32_t get_offset_of_extensionDataReader_20() { return static_cast<int32_t>(offsetof(XmlObjectSerializerReadContext_t3EF773F2A519B2BD15F925F5C44AA251B2036921, ___extensionDataReader_20)); }
	inline XmlReaderDelegator_t5BFA29001B28A7C4E173E867DDB27CE3CC875C17 * get_extensionDataReader_20() const { return ___extensionDataReader_20; }
	inline XmlReaderDelegator_t5BFA29001B28A7C4E173E867DDB27CE3CC875C17 ** get_address_of_extensionDataReader_20() { return &___extensionDataReader_20; }
	inline void set_extensionDataReader_20(XmlReaderDelegator_t5BFA29001B28A7C4E173E867DDB27CE3CC875C17 * value)
	{
		___extensionDataReader_20 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___extensionDataReader_20), (void*)value);
	}

	inline static int32_t get_offset_of_getOnlyCollectionValue_21() { return static_cast<int32_t>(offsetof(XmlObjectSerializerReadContext_t3EF773F2A519B2BD15F925F5C44AA251B2036921, ___getOnlyCollectionValue_21)); }
	inline RuntimeObject * get_getOnlyCollectionValue_21() const { return ___getOnlyCollectionValue_21; }
	inline RuntimeObject ** get_address_of_getOnlyCollectionValue_21() { return &___getOnlyCollectionValue_21; }
	inline void set_getOnlyCollectionValue_21(RuntimeObject * value)
	{
		___getOnlyCollectionValue_21 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___getOnlyCollectionValue_21), (void*)value);
	}

	inline static int32_t get_offset_of_isGetOnlyCollection_22() { return static_cast<int32_t>(offsetof(XmlObjectSerializerReadContext_t3EF773F2A519B2BD15F925F5C44AA251B2036921, ___isGetOnlyCollection_22)); }
	inline bool get_isGetOnlyCollection_22() const { return ___isGetOnlyCollection_22; }
	inline bool* get_address_of_isGetOnlyCollection_22() { return &___isGetOnlyCollection_22; }
	inline void set_isGetOnlyCollection_22(bool value)
	{
		___isGetOnlyCollection_22 = value;
	}
};


// System.Runtime.Serialization.XmlObjectSerializerWriteContext
struct XmlObjectSerializerWriteContext_t0DDF2A2D70F1E6DDBC86B5E9E3DBA5D577889AE9  : public XmlObjectSerializerContext_t9057A798705D63BEE0929C1630965F6D388C2623
{
public:
	// System.Runtime.Serialization.ObjectReferenceStack System.Runtime.Serialization.XmlObjectSerializerWriteContext::byValObjectsInScope
	ObjectReferenceStack_t2B8E7AC251005213F977D4D8545D127AA29FD221  ___byValObjectsInScope_15;
	// System.Runtime.Serialization.XmlSerializableWriter System.Runtime.Serialization.XmlObjectSerializerWriteContext::xmlSerializableWriter
	XmlSerializableWriter_t53FF8DF35B374ECA932A56FCAE3E4D87781B4C54 * ___xmlSerializableWriter_16;
	// System.Boolean System.Runtime.Serialization.XmlObjectSerializerWriteContext::preserveObjectReferences
	bool ___preserveObjectReferences_18;
	// System.Runtime.Serialization.ObjectToIdCache System.Runtime.Serialization.XmlObjectSerializerWriteContext::serializedObjects
	ObjectToIdCache_t1968B045F0ECA41760C38CEE1F8B5B0BD8C78875 * ___serializedObjects_19;
	// System.Boolean System.Runtime.Serialization.XmlObjectSerializerWriteContext::isGetOnlyCollection
	bool ___isGetOnlyCollection_20;
	// System.Boolean System.Runtime.Serialization.XmlObjectSerializerWriteContext::unsafeTypeForwardingEnabled
	bool ___unsafeTypeForwardingEnabled_21;
	// System.Boolean System.Runtime.Serialization.XmlObjectSerializerWriteContext::serializeReadOnlyTypes
	bool ___serializeReadOnlyTypes_22;

public:
	inline static int32_t get_offset_of_byValObjectsInScope_15() { return static_cast<int32_t>(offsetof(XmlObjectSerializerWriteContext_t0DDF2A2D70F1E6DDBC86B5E9E3DBA5D577889AE9, ___byValObjectsInScope_15)); }
	inline ObjectReferenceStack_t2B8E7AC251005213F977D4D8545D127AA29FD221  get_byValObjectsInScope_15() const { return ___byValObjectsInScope_15; }
	inline ObjectReferenceStack_t2B8E7AC251005213F977D4D8545D127AA29FD221 * get_address_of_byValObjectsInScope_15() { return &___byValObjectsInScope_15; }
	inline void set_byValObjectsInScope_15(ObjectReferenceStack_t2B8E7AC251005213F977D4D8545D127AA29FD221  value)
	{
		___byValObjectsInScope_15 = value;
		Il2CppCodeGenWriteBarrier((void**)&(((&___byValObjectsInScope_15))->___objectArray_3), (void*)NULL);
		#if IL2CPP_ENABLE_STRICT_WRITE_BARRIERS
		Il2CppCodeGenWriteBarrier((void**)&(((&___byValObjectsInScope_15))->___isReferenceArray_4), (void*)NULL);
		#endif
		#if IL2CPP_ENABLE_STRICT_WRITE_BARRIERS
		Il2CppCodeGenWriteBarrier((void**)&(((&___byValObjectsInScope_15))->___objectDictionary_5), (void*)NULL);
		#endif
	}

	inline static int32_t get_offset_of_xmlSerializableWriter_16() { return static_cast<int32_t>(offsetof(XmlObjectSerializerWriteContext_t0DDF2A2D70F1E6DDBC86B5E9E3DBA5D577889AE9, ___xmlSerializableWriter_16)); }
	inline XmlSerializableWriter_t53FF8DF35B374ECA932A56FCAE3E4D87781B4C54 * get_xmlSerializableWriter_16() const { return ___xmlSerializableWriter_16; }
	inline XmlSerializableWriter_t53FF8DF35B374ECA932A56FCAE3E4D87781B4C54 ** get_address_of_xmlSerializableWriter_16() { return &___xmlSerializableWriter_16; }
	inline void set_xmlSerializableWriter_16(XmlSerializableWriter_t53FF8DF35B374ECA932A56FCAE3E4D87781B4C54 * value)
	{
		___xmlSerializableWriter_16 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___xmlSerializableWriter_16), (void*)value);
	}

	inline static int32_t get_offset_of_preserveObjectReferences_18() { return static_cast<int32_t>(offsetof(XmlObjectSerializerWriteContext_t0DDF2A2D70F1E6DDBC86B5E9E3DBA5D577889AE9, ___preserveObjectReferences_18)); }
	inline bool get_preserveObjectReferences_18() const { return ___preserveObjectReferences_18; }
	inline bool* get_address_of_preserveObjectReferences_18() { return &___preserveObjectReferences_18; }
	inline void set_preserveObjectReferences_18(bool value)
	{
		___preserveObjectReferences_18 = value;
	}

	inline static int32_t get_offset_of_serializedObjects_19() { return static_cast<int32_t>(offsetof(XmlObjectSerializerWriteContext_t0DDF2A2D70F1E6DDBC86B5E9E3DBA5D577889AE9, ___serializedObjects_19)); }
	inline ObjectToIdCache_t1968B045F0ECA41760C38CEE1F8B5B0BD8C78875 * get_serializedObjects_19() const { return ___serializedObjects_19; }
	inline ObjectToIdCache_t1968B045F0ECA41760C38CEE1F8B5B0BD8C78875 ** get_address_of_serializedObjects_19() { return &___serializedObjects_19; }
	inline void set_serializedObjects_19(ObjectToIdCache_t1968B045F0ECA41760C38CEE1F8B5B0BD8C78875 * value)
	{
		___serializedObjects_19 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___serializedObjects_19), (void*)value);
	}

	inline static int32_t get_offset_of_isGetOnlyCollection_20() { return static_cast<int32_t>(offsetof(XmlObjectSerializerWriteContext_t0DDF2A2D70F1E6DDBC86B5E9E3DBA5D577889AE9, ___isGetOnlyCollection_20)); }
	inline bool get_isGetOnlyCollection_20() const { return ___isGetOnlyCollection_20; }
	inline bool* get_address_of_isGetOnlyCollection_20() { return &___isGetOnlyCollection_20; }
	inline void set_isGetOnlyCollection_20(bool value)
	{
		___isGetOnlyCollection_20 = value;
	}

	inline static int32_t get_offset_of_unsafeTypeForwardingEnabled_21() { return static_cast<int32_t>(offsetof(XmlObjectSerializerWriteContext_t0DDF2A2D70F1E6DDBC86B5E9E3DBA5D577889AE9, ___unsafeTypeForwardingEnabled_21)); }
	inline bool get_unsafeTypeForwardingEnabled_21() const { return ___unsafeTypeForwardingEnabled_21; }
	inline bool* get_address_of_unsafeTypeForwardingEnabled_21() { return &___unsafeTypeForwardingEnabled_21; }
	inline void set_unsafeTypeForwardingEnabled_21(bool value)
	{
		___unsafeTypeForwardingEnabled_21 = value;
	}

	inline static int32_t get_offset_of_serializeReadOnlyTypes_22() { return static_cast<int32_t>(offsetof(XmlObjectSerializerWriteContext_t0DDF2A2D70F1E6DDBC86B5E9E3DBA5D577889AE9, ___serializeReadOnlyTypes_22)); }
	inline bool get_serializeReadOnlyTypes_22() const { return ___serializeReadOnlyTypes_22; }
	inline bool* get_address_of_serializeReadOnlyTypes_22() { return &___serializeReadOnlyTypes_22; }
	inline void set_serializeReadOnlyTypes_22(bool value)
	{
		___serializeReadOnlyTypes_22 = value;
	}
};

#ifdef __clang__
#pragma clang diagnostic pop
#endif
// System.SByte[]
struct SByteU5BU5D_t7D94C53295E6116625EA7CC7DEA21FEDC39869E7  : public RuntimeArray
{
public:
	ALIGN_FIELD (8) int8_t m_Items[1];

public:
	inline int8_t GetAt(il2cpp_array_size_t index) const
	{
		IL2CPP_ARRAY_BOUNDS_CHECK(index, (uint32_t)(this)->max_length);
		return m_Items[index];
	}
	inline int8_t* GetAddressAt(il2cpp_array_size_t index)
	{
		IL2CPP_ARRAY_BOUNDS_CHECK(index, (uint32_t)(this)->max_length);
		return m_Items + index;
	}
	inline void SetAt(il2cpp_array_size_t index, int8_t value)
	{
		IL2CPP_ARRAY_BOUNDS_CHECK(index, (uint32_t)(this)->max_length);
		m_Items[index] = value;
	}
	inline int8_t GetAtUnchecked(il2cpp_array_size_t index) const
	{
		return m_Items[index];
	}
	inline int8_t* GetAddressAtUnchecked(il2cpp_array_size_t index)
	{
		return m_Items + index;
	}
	inline void SetAtUnchecked(il2cpp_array_size_t index, int8_t value)
	{
		m_Items[index] = value;
	}
};
// System.Single[]
struct SingleU5BU5D_t47E8DBF5B597C122478D1FFBD9DD57399A0650FA  : public RuntimeArray
{
public:
	ALIGN_FIELD (8) float m_Items[1];

public:
	inline float GetAt(il2cpp_array_size_t index) const
	{
		IL2CPP_ARRAY_BOUNDS_CHECK(index, (uint32_t)(this)->max_length);
		return m_Items[index];
	}
	inline float* GetAddressAt(il2cpp_array_size_t index)
	{
		IL2CPP_ARRAY_BOUNDS_CHECK(index, (uint32_t)(this)->max_length);
		return m_Items + index;
	}
	inline void SetAt(il2cpp_array_size_t index, float value)
	{
		IL2CPP_ARRAY_BOUNDS_CHECK(index, (uint32_t)(this)->max_length);
		m_Items[index] = value;
	}
	inline float GetAtUnchecked(il2cpp_array_size_t index) const
	{
		return m_Items[index];
	}
	inline float* GetAddressAtUnchecked(il2cpp_array_size_t index)
	{
		return m_Items + index;
	}
	inline void SetAtUnchecked(il2cpp_array_size_t index, float value)
	{
		m_Items[index] = value;
	}
};
// System.TimeSpan[]
struct TimeSpanU5BU5D_t93A1470C8423F710E4D26493EE109A5A5920D545  : public RuntimeArray
{
public:
	ALIGN_FIELD (8) TimeSpan_t4F6A0E13E703B65365CFCAB58E05EE0AF3EE6203  m_Items[1];

public:
	inline TimeSpan_t4F6A0E13E703B65365CFCAB58E05EE0AF3EE6203  GetAt(il2cpp_array_size_t index) const
	{
		IL2CPP_ARRAY_BOUNDS_CHECK(index, (uint32_t)(this)->max_length);
		return m_Items[index];
	}
	inline TimeSpan_t4F6A0E13E703B65365CFCAB58E05EE0AF3EE6203 * GetAddressAt(il2cpp_array_size_t index)
	{
		IL2CPP_ARRAY_BOUNDS_CHECK(index, (uint32_t)(this)->max_length);
		return m_Items + index;
	}
	inline void SetAt(il2cpp_array_size_t index, TimeSpan_t4F6A0E13E703B65365CFCAB58E05EE0AF3EE6203  value)
	{
		IL2CPP_ARRAY_BOUNDS_CHECK(index, (uint32_t)(this)->max_length);
		m_Items[index] = value;
	}
	inline TimeSpan_t4F6A0E13E703B65365CFCAB58E05EE0AF3EE6203  GetAtUnchecked(il2cpp_array_size_t index) const
	{
		return m_Items[index];
	}
	inline TimeSpan_t4F6A0E13E703B65365CFCAB58E05EE0AF3EE6203 * GetAddressAtUnchecked(il2cpp_array_size_t index)
	{
		return m_Items + index;
	}
	inline void SetAtUnchecked(il2cpp_array_size_t index, TimeSpan_t4F6A0E13E703B65365CFCAB58E05EE0AF3EE6203  value)
	{
		m_Items[index] = value;
	}
};
// System.UInt16[]
struct UInt16U5BU5D_t42D35C587B07DCDBCFDADF572C6D733AE85B2A67  : public RuntimeArray
{
public:
	ALIGN_FIELD (8) uint16_t m_Items[1];

public:
	inline uint16_t GetAt(il2cpp_array_size_t index) const
	{
		IL2CPP_ARRAY_BOUNDS_CHECK(index, (uint32_t)(this)->max_length);
		return m_Items[index];
	}
	inline uint16_t* GetAddressAt(il2cpp_array_size_t index)
	{
		IL2CPP_ARRAY_BOUNDS_CHECK(index, (uint32_t)(this)->max_length);
		return m_Items + index;
	}
	inline void SetAt(il2cpp_array_size_t index, uint16_t value)
	{
		IL2CPP_ARRAY_BOUNDS_CHECK(index, (uint32_t)(this)->max_length);
		m_Items[index] = value;
	}
	inline uint16_t GetAtUnchecked(il2cpp_array_size_t index) const
	{
		return m_Items[index];
	}
	inline uint16_t* GetAddressAtUnchecked(il2cpp_array_size_t index)
	{
		return m_Items + index;
	}
	inline void SetAtUnchecked(il2cpp_array_size_t index, uint16_t value)
	{
		m_Items[index] = value;
	}
};
// System.UInt32[]
struct UInt32U5BU5D_tCF06F1E9E72E0302C762578FF5358CC523F2A2CF  : public RuntimeArray
{
public:
	ALIGN_FIELD (8) uint32_t m_Items[1];

public:
	inline uint32_t GetAt(il2cpp_array_size_t index) const
	{
		IL2CPP_ARRAY_BOUNDS_CHECK(index, (uint32_t)(this)->max_length);
		return m_Items[index];
	}
	inline uint32_t* GetAddressAt(il2cpp_array_size_t index)
	{
		IL2CPP_ARRAY_BOUNDS_CHECK(index, (uint32_t)(this)->max_length);
		return m_Items + index;
	}
	inline void SetAt(il2cpp_array_size_t index, uint32_t value)
	{
		IL2CPP_ARRAY_BOUNDS_CHECK(index, (uint32_t)(this)->max_length);
		m_Items[index] = value;
	}
	inline uint32_t GetAtUnchecked(il2cpp_array_size_t index) const
	{
		return m_Items[index];
	}
	inline uint32_t* GetAddressAtUnchecked(il2cpp_array_size_t index)
	{
		return m_Items + index;
	}
	inline void SetAtUnchecked(il2cpp_array_size_t index, uint32_t value)
	{
		m_Items[index] = value;
	}
};
// System.UInt64[]
struct UInt64U5BU5D_t7C6E32D10F47677C1CEF3C30F4E4CE95B3A633E2  : public RuntimeArray
{
public:
	ALIGN_FIELD (8) uint64_t m_Items[1];

public:
	inline uint64_t GetAt(il2cpp_array_size_t index) const
	{
		IL2CPP_ARRAY_BOUNDS_CHECK(index, (uint32_t)(this)->max_length);
		return m_Items[index];
	}
	inline uint64_t* GetAddressAt(il2cpp_array_size_t index)
	{
		IL2CPP_ARRAY_BOUNDS_CHECK(index, (uint32_t)(this)->max_length);
		return m_Items + index;
	}
	inline void SetAt(il2cpp_array_size_t index, uint64_t value)
	{
		IL2CPP_ARRAY_BOUNDS_CHECK(index, (uint32_t)(this)->max_length);
		m_Items[index] = value;
	}
	inline uint64_t GetAtUnchecked(il2cpp_array_size_t index) const
	{
		return m_Items[index];
	}
	inline uint64_t* GetAddressAtUnchecked(il2cpp_array_size_t index)
	{
		return m_Items + index;
	}
	inline void SetAtUnchecked(il2cpp_array_size_t index, uint64_t value)
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
// UnityEngine.AndroidJavaObject[]
struct AndroidJavaObjectU5BU5D_tEE28563C9013906CEB39794019A55F4BA5B06120  : public RuntimeArray
{
public:
	ALIGN_FIELD (8) AndroidJavaObject_t10188D5695DCD09C9F621B44B0A8C93A2281236E * m_Items[1];

public:
	inline AndroidJavaObject_t10188D5695DCD09C9F621B44B0A8C93A2281236E * GetAt(il2cpp_array_size_t index) const
	{
		IL2CPP_ARRAY_BOUNDS_CHECK(index, (uint32_t)(this)->max_length);
		return m_Items[index];
	}
	inline AndroidJavaObject_t10188D5695DCD09C9F621B44B0A8C93A2281236E ** GetAddressAt(il2cpp_array_size_t index)
	{
		IL2CPP_ARRAY_BOUNDS_CHECK(index, (uint32_t)(this)->max_length);
		return m_Items + index;
	}
	inline void SetAt(il2cpp_array_size_t index, AndroidJavaObject_t10188D5695DCD09C9F621B44B0A8C93A2281236E * value)
	{
		IL2CPP_ARRAY_BOUNDS_CHECK(index, (uint32_t)(this)->max_length);
		m_Items[index] = value;
		Il2CppCodeGenWriteBarrier((void**)m_Items + index, (void*)value);
	}
	inline AndroidJavaObject_t10188D5695DCD09C9F621B44B0A8C93A2281236E * GetAtUnchecked(il2cpp_array_size_t index) const
	{
		return m_Items[index];
	}
	inline AndroidJavaObject_t10188D5695DCD09C9F621B44B0A8C93A2281236E ** GetAddressAtUnchecked(il2cpp_array_size_t index)
	{
		return m_Items + index;
	}
	inline void SetAtUnchecked(il2cpp_array_size_t index, AndroidJavaObject_t10188D5695DCD09C9F621B44B0A8C93A2281236E * value)
	{
		m_Items[index] = value;
		Il2CppCodeGenWriteBarrier((void**)m_Items + index, (void*)value);
	}
};
// System.Int32[]
struct Int32U5BU5D_t70F1BDC14B1786481B176D6139A5E3B87DC54C32  : public RuntimeArray
{
public:
	ALIGN_FIELD (8) int32_t m_Items[1];

public:
	inline int32_t GetAt(il2cpp_array_size_t index) const
	{
		IL2CPP_ARRAY_BOUNDS_CHECK(index, (uint32_t)(this)->max_length);
		return m_Items[index];
	}
	inline int32_t* GetAddressAt(il2cpp_array_size_t index)
	{
		IL2CPP_ARRAY_BOUNDS_CHECK(index, (uint32_t)(this)->max_length);
		return m_Items + index;
	}
	inline void SetAt(il2cpp_array_size_t index, int32_t value)
	{
		IL2CPP_ARRAY_BOUNDS_CHECK(index, (uint32_t)(this)->max_length);
		m_Items[index] = value;
	}
	inline int32_t GetAtUnchecked(il2cpp_array_size_t index) const
	{
		return m_Items[index];
	}
	inline int32_t* GetAddressAtUnchecked(il2cpp_array_size_t index)
	{
		return m_Items + index;
	}
	inline void SetAtUnchecked(il2cpp_array_size_t index, int32_t value)
	{
		m_Items[index] = value;
	}
};
// System.Boolean[]
struct BooleanU5BU5D_tEC7BAF93C44F875016DAADC8696EE3A465644D3C  : public RuntimeArray
{
public:
	ALIGN_FIELD (8) bool m_Items[1];

public:
	inline bool GetAt(il2cpp_array_size_t index) const
	{
		IL2CPP_ARRAY_BOUNDS_CHECK(index, (uint32_t)(this)->max_length);
		return m_Items[index];
	}
	inline bool* GetAddressAt(il2cpp_array_size_t index)
	{
		IL2CPP_ARRAY_BOUNDS_CHECK(index, (uint32_t)(this)->max_length);
		return m_Items + index;
	}
	inline void SetAt(il2cpp_array_size_t index, bool value)
	{
		IL2CPP_ARRAY_BOUNDS_CHECK(index, (uint32_t)(this)->max_length);
		m_Items[index] = value;
	}
	inline bool GetAtUnchecked(il2cpp_array_size_t index) const
	{
		return m_Items[index];
	}
	inline bool* GetAddressAtUnchecked(il2cpp_array_size_t index)
	{
		return m_Items + index;
	}
	inline void SetAtUnchecked(il2cpp_array_size_t index, bool value)
	{
		m_Items[index] = value;
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
// System.Int16[]
struct Int16U5BU5D_tD134F1E6F746D4C09C987436805256C210C2FFCD  : public RuntimeArray
{
public:
	ALIGN_FIELD (8) int16_t m_Items[1];

public:
	inline int16_t GetAt(il2cpp_array_size_t index) const
	{
		IL2CPP_ARRAY_BOUNDS_CHECK(index, (uint32_t)(this)->max_length);
		return m_Items[index];
	}
	inline int16_t* GetAddressAt(il2cpp_array_size_t index)
	{
		IL2CPP_ARRAY_BOUNDS_CHECK(index, (uint32_t)(this)->max_length);
		return m_Items + index;
	}
	inline void SetAt(il2cpp_array_size_t index, int16_t value)
	{
		IL2CPP_ARRAY_BOUNDS_CHECK(index, (uint32_t)(this)->max_length);
		m_Items[index] = value;
	}
	inline int16_t GetAtUnchecked(il2cpp_array_size_t index) const
	{
		return m_Items[index];
	}
	inline int16_t* GetAddressAtUnchecked(il2cpp_array_size_t index)
	{
		return m_Items + index;
	}
	inline void SetAtUnchecked(il2cpp_array_size_t index, int16_t value)
	{
		m_Items[index] = value;
	}
};
// System.Int64[]
struct Int64U5BU5D_tCA61E42872C63A4286B24EEE6E0650143B43DCE6  : public RuntimeArray
{
public:
	ALIGN_FIELD (8) int64_t m_Items[1];

public:
	inline int64_t GetAt(il2cpp_array_size_t index) const
	{
		IL2CPP_ARRAY_BOUNDS_CHECK(index, (uint32_t)(this)->max_length);
		return m_Items[index];
	}
	inline int64_t* GetAddressAt(il2cpp_array_size_t index)
	{
		IL2CPP_ARRAY_BOUNDS_CHECK(index, (uint32_t)(this)->max_length);
		return m_Items + index;
	}
	inline void SetAt(il2cpp_array_size_t index, int64_t value)
	{
		IL2CPP_ARRAY_BOUNDS_CHECK(index, (uint32_t)(this)->max_length);
		m_Items[index] = value;
	}
	inline int64_t GetAtUnchecked(il2cpp_array_size_t index) const
	{
		return m_Items[index];
	}
	inline int64_t* GetAddressAtUnchecked(il2cpp_array_size_t index)
	{
		return m_Items + index;
	}
	inline void SetAtUnchecked(il2cpp_array_size_t index, int64_t value)
	{
		m_Items[index] = value;
	}
};
// System.Double[]
struct DoubleU5BU5D_t8E1B42EB2ABB79FBD193A6B8C8D97A7CDE44A4FB  : public RuntimeArray
{
public:
	ALIGN_FIELD (8) double m_Items[1];

public:
	inline double GetAt(il2cpp_array_size_t index) const
	{
		IL2CPP_ARRAY_BOUNDS_CHECK(index, (uint32_t)(this)->max_length);
		return m_Items[index];
	}
	inline double* GetAddressAt(il2cpp_array_size_t index)
	{
		IL2CPP_ARRAY_BOUNDS_CHECK(index, (uint32_t)(this)->max_length);
		return m_Items + index;
	}
	inline void SetAt(il2cpp_array_size_t index, double value)
	{
		IL2CPP_ARRAY_BOUNDS_CHECK(index, (uint32_t)(this)->max_length);
		m_Items[index] = value;
	}
	inline double GetAtUnchecked(il2cpp_array_size_t index) const
	{
		return m_Items[index];
	}
	inline double* GetAddressAtUnchecked(il2cpp_array_size_t index)
	{
		return m_Items + index;
	}
	inline void SetAtUnchecked(il2cpp_array_size_t index, double value)
	{
		m_Items[index] = value;
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
// System.Linq.Expressions.Expression[]
struct ExpressionU5BU5D_t4F1F138488EBD58837D142B40E0E4EEFC607EA63  : public RuntimeArray
{
public:
	ALIGN_FIELD (8) Expression_t30A004209C10C2D9A9785B2F74EEED431A4D4660 * m_Items[1];

public:
	inline Expression_t30A004209C10C2D9A9785B2F74EEED431A4D4660 * GetAt(il2cpp_array_size_t index) const
	{
		IL2CPP_ARRAY_BOUNDS_CHECK(index, (uint32_t)(this)->max_length);
		return m_Items[index];
	}
	inline Expression_t30A004209C10C2D9A9785B2F74EEED431A4D4660 ** GetAddressAt(il2cpp_array_size_t index)
	{
		IL2CPP_ARRAY_BOUNDS_CHECK(index, (uint32_t)(this)->max_length);
		return m_Items + index;
	}
	inline void SetAt(il2cpp_array_size_t index, Expression_t30A004209C10C2D9A9785B2F74EEED431A4D4660 * value)
	{
		IL2CPP_ARRAY_BOUNDS_CHECK(index, (uint32_t)(this)->max_length);
		m_Items[index] = value;
		Il2CppCodeGenWriteBarrier((void**)m_Items + index, (void*)value);
	}
	inline Expression_t30A004209C10C2D9A9785B2F74EEED431A4D4660 * GetAtUnchecked(il2cpp_array_size_t index) const
	{
		return m_Items[index];
	}
	inline Expression_t30A004209C10C2D9A9785B2F74EEED431A4D4660 ** GetAddressAtUnchecked(il2cpp_array_size_t index)
	{
		return m_Items + index;
	}
	inline void SetAtUnchecked(il2cpp_array_size_t index, Expression_t30A004209C10C2D9A9785B2F74EEED431A4D4660 * value)
	{
		m_Items[index] = value;
		Il2CppCodeGenWriteBarrier((void**)m_Items + index, (void*)value);
	}
};
// System.Linq.Expressions.ParameterExpression[]
struct ParameterExpressionU5BU5D_tCF3EAA6D8556513C4937E1126F65AA08DF4DB147  : public RuntimeArray
{
public:
	ALIGN_FIELD (8) ParameterExpression_tA7B24F1DE0F013DA4BD55F76DB43B06DB33D8BEE * m_Items[1];

public:
	inline ParameterExpression_tA7B24F1DE0F013DA4BD55F76DB43B06DB33D8BEE * GetAt(il2cpp_array_size_t index) const
	{
		IL2CPP_ARRAY_BOUNDS_CHECK(index, (uint32_t)(this)->max_length);
		return m_Items[index];
	}
	inline ParameterExpression_tA7B24F1DE0F013DA4BD55F76DB43B06DB33D8BEE ** GetAddressAt(il2cpp_array_size_t index)
	{
		IL2CPP_ARRAY_BOUNDS_CHECK(index, (uint32_t)(this)->max_length);
		return m_Items + index;
	}
	inline void SetAt(il2cpp_array_size_t index, ParameterExpression_tA7B24F1DE0F013DA4BD55F76DB43B06DB33D8BEE * value)
	{
		IL2CPP_ARRAY_BOUNDS_CHECK(index, (uint32_t)(this)->max_length);
		m_Items[index] = value;
		Il2CppCodeGenWriteBarrier((void**)m_Items + index, (void*)value);
	}
	inline ParameterExpression_tA7B24F1DE0F013DA4BD55F76DB43B06DB33D8BEE * GetAtUnchecked(il2cpp_array_size_t index) const
	{
		return m_Items[index];
	}
	inline ParameterExpression_tA7B24F1DE0F013DA4BD55F76DB43B06DB33D8BEE ** GetAddressAtUnchecked(il2cpp_array_size_t index)
	{
		return m_Items + index;
	}
	inline void SetAtUnchecked(il2cpp_array_size_t index, ParameterExpression_tA7B24F1DE0F013DA4BD55F76DB43B06DB33D8BEE * value)
	{
		m_Items[index] = value;
		Il2CppCodeGenWriteBarrier((void**)m_Items + index, (void*)value);
	}
};


// System.Void System.Runtime.CompilerServices.TrueReadOnlyCollection`1<System.Object>::.ctor(T[])
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void TrueReadOnlyCollection_1__ctor_mDF3EF583478D490FB15F7AB3FF61E2E73191FFA2_gshared (TrueReadOnlyCollection_1_t7B0C79057B5BCC33C785557CBB2BEC37F5C2207A * __this, ObjectU5BU5D_tC1F4EE0DB0B7300255F5FD4AF64FE4C585CF5ADE* ___list0, const RuntimeMethod* method);
// !0 System.Collections.ObjectModel.ReadOnlyCollection`1<System.Object>::get_Item(System.Int32)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR RuntimeObject * ReadOnlyCollection_1_get_Item_m92C5369651F9216CBCAD03983F2F34C5C3BF0744_gshared (ReadOnlyCollection_1_t921D1901AD35062BE31FAEB0798A4B814F33A3C3 * __this, int32_t ___index0, const RuntimeMethod* method);
// !!0[] System.Array::Empty<System.Object>()
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR ObjectU5BU5D_tC1F4EE0DB0B7300255F5FD4AF64FE4C585CF5ADE* Array_Empty_TisRuntimeObject_m1FBC21243DF3542384C523801E8CA8A97606C747_gshared_inline (const RuntimeMethod* method);
// System.Void System.Collections.Generic.List`1<System.Object>::.ctor(System.Int32)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void List_1__ctor_mFEB2301A6F28290A828A979BA9CC847B16B3D538_gshared (List_1_t3F94120C77410A62EAE48421CF166B83AB95A2F5 * __this, int32_t ___capacity0, const RuntimeMethod* method);
// System.Void System.Collections.Generic.List`1<System.Object>::Add(!0)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void List_1_Add_mE5B3CBB3A625606D9BC4337FEAAF1D66BCB6F96E_gshared (List_1_t3F94120C77410A62EAE48421CF166B83AB95A2F5 * __this, RuntimeObject * ___item0, const RuntimeMethod* method);
// System.Void System.Collections.Generic.HashSet`1<System.Object>::.ctor()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void HashSet_1__ctor_m2CDA40DEC2900A9CB00F8348FF386DF44ABD0EC7_gshared (HashSet_1_t680119C7ED8D82AED56CDB83DF6F0E9149852A9B * __this, const RuntimeMethod* method);
// System.Boolean System.Collections.Generic.HashSet`1<System.Object>::Add(T)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR bool HashSet_1_Add_mF670AD4C3F2685F0797E05C5491BC1841CEA9DBA_gshared (HashSet_1_t680119C7ED8D82AED56CDB83DF6F0E9149852A9B * __this, RuntimeObject * ___item0, const RuntimeMethod* method);
// System.Void System.Collections.Generic.Stack`1<System.Object>::Push(!0)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Stack_1_Push_m37749C6ED558EC2D89F38CF78C833D4EE8A2DF04_gshared (Stack_1_t92AC5F573A3C00899B24B775A71B4327D588E981 * __this, RuntimeObject * ___item0, const RuntimeMethod* method);
// !0 System.Collections.Generic.Stack`1<System.Object>::Pop()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR RuntimeObject * Stack_1_Pop_m9503124BACE0FDA402D22BC901708C5D99063C12_gshared (Stack_1_t92AC5F573A3C00899B24B775A71B4327D588E981 * __this, const RuntimeMethod* method);
// System.Boolean System.Collections.Generic.Dictionary`2<System.Object,System.Runtime.InteropServices.WindowsRuntime.WindowsRuntimeMarshal/EventRegistrationTokenList>::TryGetValue(TKey,TValue&)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR bool Dictionary_2_TryGetValue_mF842EC8D110A281144B0082DE75F29AE5261F24F_gshared (Dictionary_2_t5BB631D653FC099355128DBC14DC44E27AD30739 * __this, RuntimeObject * ___key0, EventRegistrationTokenList_t0B8EB3E0DA8A305BFCD313936266A15F50B4B128 * ___value1, const RuntimeMethod* method);
// System.Void System.Collections.Generic.Dictionary`2<System.Object,System.Runtime.InteropServices.WindowsRuntime.WindowsRuntimeMarshal/EventRegistrationTokenList>::set_Item(TKey,TValue)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Dictionary_2_set_Item_mC31C547D1D8807C284FEE2E67821F99533C54EB7_gshared (Dictionary_2_t5BB631D653FC099355128DBC14DC44E27AD30739 * __this, RuntimeObject * ___key0, EventRegistrationTokenList_t0B8EB3E0DA8A305BFCD313936266A15F50B4B128  ___value1, const RuntimeMethod* method);
// System.Boolean System.Collections.Generic.Dictionary`2<System.Object,System.Runtime.InteropServices.WindowsRuntime.WindowsRuntimeMarshal/EventRegistrationTokenList>::Remove(TKey)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR bool Dictionary_2_Remove_mF26A9D605B336E64E00D3E9B1A2B24D23F440D1C_gshared (Dictionary_2_t5BB631D653FC099355128DBC14DC44E27AD30739 * __this, RuntimeObject * ___key0, const RuntimeMethod* method);
// System.Void System.Action`1<System.Runtime.InteropServices.WindowsRuntime.EventRegistrationToken>::Invoke(T)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Action_1_Invoke_m0670A1DF770A18B2D457A2B700EEF92B463652DA_gshared (Action_1_t91FC536003CAB9AB56B84E901AE08156372856E3 * __this, EventRegistrationToken_t5460ED02F1A6B74B604DFD634E8D5429857E9830  ___obj0, const RuntimeMethod* method);
// TKey System.Runtime.CompilerServices.ConditionalWeakTable`2<System.Object,System.Object>::FindEquivalentKeyUnsafe(TKey,TValue&)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR RuntimeObject * ConditionalWeakTable_2_FindEquivalentKeyUnsafe_mE374DB04CE4CDA882F4AA25E26375C46728BA8AA_gshared (ConditionalWeakTable_2_tCF100268EF76D0BC19F774221E488BBB4CD4B365 * __this, RuntimeObject * ___key0, RuntimeObject ** ___value1, const RuntimeMethod* method);
// System.Void System.Runtime.CompilerServices.ConditionalWeakTable`2<System.Object,System.Object>::Add(TKey,TValue)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void ConditionalWeakTable_2_Add_m92A993D020EA2EE92A0C05D9AA35E65E043E7805_gshared (ConditionalWeakTable_2_tCF100268EF76D0BC19F774221E488BBB4CD4B365 * __this, RuntimeObject * ___key0, RuntimeObject * ___value1, const RuntimeMethod* method);
// System.Boolean System.Runtime.CompilerServices.ConditionalWeakTable`2<System.Object,System.Object>::Remove(TKey)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR bool ConditionalWeakTable_2_Remove_m0B765A2BAD7A3874D8B33A87AC105A25764895FB_gshared (ConditionalWeakTable_2_tCF100268EF76D0BC19F774221E488BBB4CD4B365 * __this, RuntimeObject * ___key0, const RuntimeMethod* method);

// System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR Type_t * Type_GetTypeFromHandle_m8BB57524FF7F9DB1803BC561D2B3A4DBACEB385E (RuntimeTypeHandle_tC33965ADA3E041E0C94AF05E5CB527B56482CEF9  ___handle0, const RuntimeMethod* method);
// System.String System.Runtime.Serialization.DataContract::GetClrTypeFullName(System.Type)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR String_t* DataContract_GetClrTypeFullName_m2780B0E4C129B4655489C1E02D8F96ADDACA4711 (Type_t * ___type0, const RuntimeMethod* method);
// System.String System.Runtime.Serialization.SR::GetString(System.String,System.Object[])
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR String_t* SR_GetString_m9362D6A80ADB0E2770FB53AD9ACDF8A99FA4E7F6 (String_t* ___name0, ObjectU5BU5D_tC1F4EE0DB0B7300255F5FD4AF64FE4C585CF5ADE* ___args1, const RuntimeMethod* method);
// System.Runtime.Serialization.SerializationException System.Runtime.Serialization.XmlObjectSerializer::CreateSerializationException(System.String)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR SerializationException_tDB38C13A2ABF407C381E3F332D197AC1AD097A92 * XmlObjectSerializer_CreateSerializationException_mA433DFF9CCCB3DBF82DC4C09F362F1F0C2CCF160 (String_t* ___errorMessage0, const RuntimeMethod* method);
// System.Exception System.Runtime.Serialization.DiagnosticUtility/ExceptionUtility::ThrowHelperError(System.Exception)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR Exception_t * ExceptionUtility_ThrowHelperError_m23931D3B92251FB3E39C0A3CCDBAA006397B2E99 (Exception_t * ___e0, const RuntimeMethod* method);
// System.Void System.Array::Copy(System.Array,System.Int32,System.Array,System.Int32,System.Int32)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Array_Copy_m3F127FFB5149532135043FFE285F9177C80CB877 (RuntimeArray * ___sourceArray0, int32_t ___sourceIndex1, RuntimeArray * ___destinationArray2, int32_t ___destinationIndex3, int32_t ___length4, const RuntimeMethod* method);
// System.Void System.Runtime.Serialization.XmlObjectSerializerWriteContext::IncrementCollectionCount(System.Runtime.Serialization.XmlWriterDelegator,System.Int32)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void XmlObjectSerializerWriteContext_IncrementCollectionCount_mE4F8ED23C2425966E40F6A27851CE31CD6269C3C (XmlObjectSerializerWriteContext_t0DDF2A2D70F1E6DDBC86B5E9E3DBA5D577889AE9 * __this, XmlWriterDelegator_t14F933DC94CDCA5AA29C259565A8C4C0E41613BC * ___xmlWriter0, int32_t ___size1, const RuntimeMethod* method);
// System.Boolean UnityEngine.AndroidReflection::IsPrimitive(System.Type)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR bool AndroidReflection_IsPrimitive_mDD6A4050793DF2FA1EDF58010982C64A3F17376D (Type_t * ___t0, const RuntimeMethod* method);
// System.Int32[] UnityEngine.AndroidJNISafe::FromIntArray(System.IntPtr)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR Int32U5BU5D_t70F1BDC14B1786481B176D6139A5E3B87DC54C32* AndroidJNISafe_FromIntArray_mBF0C0B4309BA525BBA12D7FD3C2790C8FA7C4703 (intptr_t ___array0, const RuntimeMethod* method);
// System.Boolean[] UnityEngine.AndroidJNISafe::FromBooleanArray(System.IntPtr)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR BooleanU5BU5D_tEC7BAF93C44F875016DAADC8696EE3A465644D3C* AndroidJNISafe_FromBooleanArray_m77A66C34FCB94ADB1AD5E1D88262500C930A5DBF (intptr_t ___array0, const RuntimeMethod* method);
// System.Void UnityEngine.Debug::LogWarning(System.Object)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Debug_LogWarning_m24085D883C9E74D7AB423F0625E13259923960E7 (RuntimeObject * ___message0, const RuntimeMethod* method);
// System.Byte[] UnityEngine.AndroidJNISafe::FromByteArray(System.IntPtr)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR ByteU5BU5D_tDBBEB0E8362242FA7223000D978B0DD19D4B0726* AndroidJNISafe_FromByteArray_m81760A688AECE368E1CFF7DAAC8E141F1B8FA8A8 (intptr_t ___array0, const RuntimeMethod* method);
// System.SByte[] UnityEngine.AndroidJNISafe::FromSByteArray(System.IntPtr)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR SByteU5BU5D_t7D94C53295E6116625EA7CC7DEA21FEDC39869E7* AndroidJNISafe_FromSByteArray_m01F6539AF10F86B3927436955B57CC809C52416D (intptr_t ___array0, const RuntimeMethod* method);
// System.Int16[] UnityEngine.AndroidJNISafe::FromShortArray(System.IntPtr)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR Int16U5BU5D_tD134F1E6F746D4C09C987436805256C210C2FFCD* AndroidJNISafe_FromShortArray_mCDF5B796D950D31035BD35A2E463D41509E4A5CD (intptr_t ___array0, const RuntimeMethod* method);
// System.Int64[] UnityEngine.AndroidJNISafe::FromLongArray(System.IntPtr)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR Int64U5BU5D_tCA61E42872C63A4286B24EEE6E0650143B43DCE6* AndroidJNISafe_FromLongArray_m0E7C56CB8CFD0EC240F0D86ECBBFD635FFE55CDA (intptr_t ___array0, const RuntimeMethod* method);
// System.Single[] UnityEngine.AndroidJNISafe::FromFloatArray(System.IntPtr)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR SingleU5BU5D_t47E8DBF5B597C122478D1FFBD9DD57399A0650FA* AndroidJNISafe_FromFloatArray_mF6A63CA1B7C10BC27EEC033F0E390772DFDD652D (intptr_t ___array0, const RuntimeMethod* method);
// System.Double[] UnityEngine.AndroidJNISafe::FromDoubleArray(System.IntPtr)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR DoubleU5BU5D_t8E1B42EB2ABB79FBD193A6B8C8D97A7CDE44A4FB* AndroidJNISafe_FromDoubleArray_m9438B5668E8B2DB3B18CACFF0CC9CAEAB5EC73C8 (intptr_t ___array0, const RuntimeMethod* method);
// System.Char[] UnityEngine.AndroidJNISafe::FromCharArray(System.IntPtr)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR CharU5BU5D_t7B7FC5BC8091AA3B9CB0B29CDD80B5EE9254AA34* AndroidJNISafe_FromCharArray_mA49DB27755EF3B2AE81487E0FCFE06E23F617305 (intptr_t ___array0, const RuntimeMethod* method);
// System.Int32 UnityEngine.AndroidJNISafe::GetArrayLength(System.IntPtr)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR int32_t AndroidJNISafe_GetArrayLength_m3015C191DBFC246946A88592731441A934507B56 (intptr_t ___array0, const RuntimeMethod* method);
// System.IntPtr UnityEngine.AndroidJNI::GetObjectArrayElement(System.IntPtr,System.Int32)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR intptr_t AndroidJNI_GetObjectArrayElement_m502026BF77232EE45D03661E4923C2E5E99FDE18 (intptr_t ___array0, int32_t ___index1, const RuntimeMethod* method);
// System.String UnityEngine.AndroidJNISafe::GetStringChars(System.IntPtr)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR String_t* AndroidJNISafe_GetStringChars_mD59FFDE4192F837E1380B51569B5803E09BE58C8 (intptr_t ___str0, const RuntimeMethod* method);
// System.Void UnityEngine.AndroidJNISafe::DeleteLocalRef(System.IntPtr)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void AndroidJNISafe_DeleteLocalRef_m7AB242A76D13A3BF4C04831D77960C020D6ADA39 (intptr_t ___localref0, const RuntimeMethod* method);
// System.Void UnityEngine.AndroidJavaObject::.ctor(System.IntPtr)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void AndroidJavaObject__ctor_m880F6533139DF0BD36C6EF428E45E9F44B6534A3 (AndroidJavaObject_t10188D5695DCD09C9F621B44B0A8C93A2281236E * __this, intptr_t ___jobject0, const RuntimeMethod* method);
// System.String System.String::Concat(System.String,System.String,System.String)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR String_t* String_Concat_m89EAB4C6A96B0E5C3F87300D6BE78D386B9EFC44 (String_t* ___str00, String_t* ___str11, String_t* ___str22, const RuntimeMethod* method);
// System.Void System.Exception::.ctor(System.String)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Exception__ctor_m8ECDE8ACA7F2E0EF1144BD1200FB5DB2870B5F11 (Exception_t * __this, String_t* ___message0, const RuntimeMethod* method);
// System.String UnityEngine._AndroidJNIHelper::GetSignature(System.Object)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR String_t* _AndroidJNIHelper_GetSignature_m4A272D66518BF9A4C746B02B91AAB1361293232C (RuntimeObject * ___obj0, const RuntimeMethod* method);
// System.IntPtr UnityEngine.AndroidJNIHelper::GetFieldID(System.IntPtr,System.String,System.String,System.Boolean)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR intptr_t AndroidJNIHelper_GetFieldID_mCDDF095C790C66CB19342E3A143A104020F5E170 (intptr_t ___javaClass0, String_t* ___fieldName1, String_t* ___signature2, bool ___isStatic3, const RuntimeMethod* method);
// System.IntPtr UnityEngine.AndroidJNIHelper::GetMethodID(System.IntPtr,System.String,System.String,System.Boolean)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR intptr_t AndroidJNIHelper_GetMethodID_m2B5E7C9B05905F6C6B60A735B8A6E97BBA468535 (intptr_t ___javaClass0, String_t* ___methodName1, String_t* ___signature2, bool ___isStatic3, const RuntimeMethod* method);
// System.Void System.Text.StringBuilder::.ctor()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void StringBuilder__ctor_m5A81DE19E748F748E19FF13FB6FFD2547F9212D9 (StringBuilder_t * __this, const RuntimeMethod* method);
// System.Text.StringBuilder System.Text.StringBuilder::Append(System.Char)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR StringBuilder_t * StringBuilder_Append_m1ADA3C16E40BF253BCDB5F9579B4DBA9C3E5B22E (StringBuilder_t * __this, Il2CppChar ___value0, const RuntimeMethod* method);
// System.Text.StringBuilder System.Text.StringBuilder::Append(System.String)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR StringBuilder_t * StringBuilder_Append_mD02AB0C74C6F55E3E330818C77EC147E22096FB1 (StringBuilder_t * __this, String_t* ___value0, const RuntimeMethod* method);
// System.Boolean System.Dynamic.DynamicObject/MetaDynamic::IsOverridden(System.Reflection.MethodInfo)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR bool MetaDynamic_IsOverridden_m23850D35DA8C827538AF468CAE3C139D18A06626 (MetaDynamic_t774AF4A12F33149209C1FA08022AB0EE951BFB7C * __this, MethodInfo_t * ___method0, const RuntimeMethod* method);
// System.Linq.Expressions.ParameterExpression System.Linq.Expressions.Expression::Parameter(System.Type,System.String)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR ParameterExpression_tA7B24F1DE0F013DA4BD55F76DB43B06DB33D8BEE * Expression_Parameter_m1613C069AFED7D393811F36BC7F91188D668A333 (Type_t * ___type0, String_t* ___name1, const RuntimeMethod* method);
// System.Reflection.MethodInfo System.Linq.Expressions.CachedReflectionInfo::get_DynamicObject_TryBinaryOperation()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR MethodInfo_t * CachedReflectionInfo_get_DynamicObject_TryBinaryOperation_mD0D3151684B0FA6C655BC84F441D7FDFC498AD00 (const RuntimeMethod* method);
// System.Boolean System.Reflection.MethodInfo::op_Inequality(System.Reflection.MethodInfo,System.Reflection.MethodInfo)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR bool MethodInfo_op_Inequality_mDE1DAA5D330E9C975AC6423FC2D06862637BE68D (MethodInfo_t * ___left0, MethodInfo_t * ___right1, const RuntimeMethod* method);
// System.Collections.ObjectModel.ReadOnlyCollection`1<System.Linq.Expressions.Expression> System.Dynamic.DynamicObject/MetaDynamic::GetConvertedArgs(System.Linq.Expressions.Expression[])
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR ReadOnlyCollection_1_t7976DDE3F2FC7BAAF4F920193FF1B5BA33CCC2B5 * MetaDynamic_GetConvertedArgs_m1C2C9220C741DBE95A2DFC7767F1DD02AB432AC9 (ExpressionU5BU5D_t4F1F138488EBD58837D142B40E0E4EEFC607EA63* ___args0, const RuntimeMethod* method);
// System.Void System.Dynamic.DynamicMetaObject::.ctor(System.Linq.Expressions.Expression,System.Dynamic.BindingRestrictions)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void DynamicMetaObject__ctor_m2851C1E47FD59D49C80E454597607C1F4A8458AA (DynamicMetaObject_t5279001ADBFAB6EF015CAC54937F4E9F003881C3 * __this, Expression_t30A004209C10C2D9A9785B2F74EEED431A4D4660 * ___expression0, BindingRestrictions_t03E14FA0517A70DEDA502032CE956595EF6E0DFC * ___restrictions1, const RuntimeMethod* method);
// System.Boolean System.Type::op_Inequality(System.Type,System.Type)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR bool Type_op_Inequality_m6DDC5E923203A79BF505F9275B694AD3FAA36DB0 (Type_t * ___left0, Type_t * ___right1, const RuntimeMethod* method);
// System.Linq.Expressions.Expression System.Dynamic.DynamicMetaObject::get_Expression()
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR Expression_t30A004209C10C2D9A9785B2F74EEED431A4D4660 * DynamicMetaObject_get_Expression_m56AEEE5B82DB27F8490D27758D6ECAEC19BE64C2_inline (DynamicMetaObject_t5279001ADBFAB6EF015CAC54937F4E9F003881C3 * __this, const RuntimeMethod* method);
// System.Linq.Expressions.UnaryExpression System.Linq.Expressions.Expression::Convert(System.Linq.Expressions.Expression,System.Type)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR UnaryExpression_t5DE6F6FA2216CDD34DFCFADEB0080CB29326DD62 * Expression_Convert_m494826A3729B238263D95E7D7B0E236DE3B1CDA7 (Expression_t30A004209C10C2D9A9785B2F74EEED431A4D4660 * ___expression0, Type_t * ___type1, const RuntimeMethod* method);
// System.Dynamic.DynamicObject System.Dynamic.DynamicObject/MetaDynamic::get_Value()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR DynamicObject_t97AD66D9AA9182AA4635DB778C9CE337E5E429D6 * MetaDynamic_get_Value_mF3A50AC306B2161D40834CA9313F46A8669DE561 (MetaDynamic_t774AF4A12F33149209C1FA08022AB0EE951BFB7C * __this, const RuntimeMethod* method);
// System.Type System.Object::GetType()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR Type_t * Object_GetType_m571FE8360C10B98C23AAF1F066D92C08CC94F45B (RuntimeObject * __this, const RuntimeMethod* method);
// System.String System.Linq.Expressions.Strings::DynamicObjectResultNotAssignable(System.Object,System.Object,System.Object,System.Object)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR String_t* Strings_DynamicObjectResultNotAssignable_m3F88B63C924BC2152059FCB50C54C72D73AF6D62 (RuntimeObject * ___p00, RuntimeObject * ___p11, RuntimeObject * ___p22, RuntimeObject * ___p33, const RuntimeMethod* method);
// System.Boolean System.Type::get_IsValueType()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR bool Type_get_IsValueType_m9CCCB4759C2D5A890096F8DBA66DAAEFE9D913FB (Type_t * __this, const RuntimeMethod* method);
// System.Type System.Nullable::GetUnderlyingType(System.Type)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR Type_t * Nullable_GetUnderlyingType_mC5699E7E11E1AFE25365CAB564A48F0193318629 (Type_t * ___nullableType0, const RuntimeMethod* method);
// System.Boolean System.Type::op_Equality(System.Type,System.Type)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR bool Type_op_Equality_mA438719A1FDF103C7BBBB08AEF564E7FAEEA0046 (Type_t * ___left0, Type_t * ___right1, const RuntimeMethod* method);
// System.Linq.Expressions.TypeBinaryExpression System.Linq.Expressions.Expression::TypeIs(System.Linq.Expressions.Expression,System.Type)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR TypeBinaryExpression_t802702BB83CA4CE99BAE599EAD7D58FDF8C32185 * Expression_TypeIs_m963DA9C402453E3373C87492847B02551E2305F3 (Expression_t30A004209C10C2D9A9785B2F74EEED431A4D4660 * ___expression0, Type_t * ___type1, const RuntimeMethod* method);
// System.Linq.Expressions.BinaryExpression System.Linq.Expressions.Expression::Equal(System.Linq.Expressions.Expression,System.Linq.Expressions.Expression)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR BinaryExpression_tCD79755962D104E6603B50D89E7F0E41D1D9CA79 * Expression_Equal_m587E6FD4AF53E3A711A242A985E9F8D73F9BDC61 (Expression_t30A004209C10C2D9A9785B2F74EEED431A4D4660 * ___left0, Expression_t30A004209C10C2D9A9785B2F74EEED431A4D4660 * ___right1, const RuntimeMethod* method);
// System.Linq.Expressions.BinaryExpression System.Linq.Expressions.Expression::OrElse(System.Linq.Expressions.Expression,System.Linq.Expressions.Expression)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR BinaryExpression_tCD79755962D104E6603B50D89E7F0E41D1D9CA79 * Expression_OrElse_m47274255A9C9A23CF1218A24E13CF598D1E17AB4 (Expression_t30A004209C10C2D9A9785B2F74EEED431A4D4660 * ___left0, Expression_t30A004209C10C2D9A9785B2F74EEED431A4D4660 * ___right1, const RuntimeMethod* method);
// System.Reflection.ConstructorInfo System.Linq.Expressions.CachedReflectionInfo::get_InvalidCastException_Ctor_String()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR ConstructorInfo_t449AEC508DCA508EE46784C4F2716545488ACD5B * CachedReflectionInfo_get_InvalidCastException_Ctor_String_m51EF84D08DFE096EAD86BF57E76444963BBA2965 (const RuntimeMethod* method);
// System.Reflection.MethodInfo System.Linq.Expressions.CachedReflectionInfo::get_String_Format_String_ObjectArray()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR MethodInfo_t * CachedReflectionInfo_get_String_Format_String_ObjectArray_mC9ACA19786E7FBA880BD7943B6A8388E11970581 (const RuntimeMethod* method);
// System.Linq.Expressions.ConstantExpression System.Linq.Expressions.Expression::Constant(System.Object)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR ConstantExpression_tE22239C4AE815AF9B4647E026E802623F433F0FB * Expression_Constant_mEEA1BB10F0EE0D668C36114629468DA1D840601C (RuntimeObject * ___value0, const RuntimeMethod* method);
// System.Reflection.MethodInfo System.Linq.Expressions.CachedReflectionInfo::get_Object_GetType()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR MethodInfo_t * CachedReflectionInfo_get_Object_GetType_m9FC2ACE7ABCFEC3CA351CEF7F054C2CEFB7614F7 (const RuntimeMethod* method);
// System.Linq.Expressions.MethodCallExpression System.Linq.Expressions.Expression::Call(System.Linq.Expressions.Expression,System.Reflection.MethodInfo)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR MethodCallExpression_tF8E07995EEDB83A97C356206D651D5EEC72EFFA4 * Expression_Call_m5E98322EFB58C6947149191AFC7B609BF220AC4B (Expression_t30A004209C10C2D9A9785B2F74EEED431A4D4660 * ___instance0, MethodInfo_t * ___method1, const RuntimeMethod* method);
// System.Linq.Expressions.ConditionalExpression System.Linq.Expressions.Expression::Condition(System.Linq.Expressions.Expression,System.Linq.Expressions.Expression,System.Linq.Expressions.Expression,System.Type)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR ConditionalExpression_t74C60793A382D6FC191C590A353984ED63ED3D4A * Expression_Condition_mDAAB02AA8FE6525ECAE36CAF26695ADBFA738260 (Expression_t30A004209C10C2D9A9785B2F74EEED431A4D4660 * ___test0, Expression_t30A004209C10C2D9A9785B2F74EEED431A4D4660 * ___ifTrue1, Expression_t30A004209C10C2D9A9785B2F74EEED431A4D4660 * ___ifFalse2, Type_t * ___type3, const RuntimeMethod* method);
// System.Void System.Runtime.CompilerServices.TrueReadOnlyCollection`1<System.Linq.Expressions.Expression>::.ctor(T[])
inline void TrueReadOnlyCollection_1__ctor_m69554AD79082CEEEE9808387797E4A9C052A1820 (TrueReadOnlyCollection_1_t06D7E0A73C830464D87F10A513072796E7172082 * __this, ExpressionU5BU5D_t4F1F138488EBD58837D142B40E0E4EEFC607EA63* ___list0, const RuntimeMethod* method)
{
	((  void (*) (TrueReadOnlyCollection_1_t06D7E0A73C830464D87F10A513072796E7172082 *, ExpressionU5BU5D_t4F1F138488EBD58837D142B40E0E4EEFC607EA63*, const RuntimeMethod*))TrueReadOnlyCollection_1__ctor_mDF3EF583478D490FB15F7AB3FF61E2E73191FFA2_gshared)(__this, ___list0, method);
}
// System.Linq.Expressions.NewArrayExpression System.Linq.Expressions.Expression::NewArrayInit(System.Type,System.Collections.Generic.IEnumerable`1<System.Linq.Expressions.Expression>)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR NewArrayExpression_tE4702BA06AA0479BA675A5087BB6E2342F921F0A * Expression_NewArrayInit_m4E25520959297D32D03E19147E1812530858109E (Type_t * ___type0, RuntimeObject* ___initializers1, const RuntimeMethod* method);
// System.Linq.Expressions.MethodCallExpression System.Linq.Expressions.Expression::Call(System.Reflection.MethodInfo,System.Linq.Expressions.Expression,System.Linq.Expressions.Expression)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR MethodCallExpression_tF8E07995EEDB83A97C356206D651D5EEC72EFFA4 * Expression_Call_m7F8784CDCEA8B62A5019ED5FA8990E932D869E24 (MethodInfo_t * ___method0, Expression_t30A004209C10C2D9A9785B2F74EEED431A4D4660 * ___arg01, Expression_t30A004209C10C2D9A9785B2F74EEED431A4D4660 * ___arg12, const RuntimeMethod* method);
// System.Linq.Expressions.NewExpression System.Linq.Expressions.Expression::New(System.Reflection.ConstructorInfo,System.Collections.Generic.IEnumerable`1<System.Linq.Expressions.Expression>)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR NewExpression_tCC2B6EAD4868381D56BB8B1AA4C5267F8A620987 * Expression_New_mE2FB5DD0768AAF8AAC45C32C8430C01F079A46C4 (ConstructorInfo_t449AEC508DCA508EE46784C4F2716545488ACD5B * ___constructor0, RuntimeObject* ___arguments1, const RuntimeMethod* method);
// System.Linq.Expressions.UnaryExpression System.Linq.Expressions.Expression::Throw(System.Linq.Expressions.Expression,System.Type)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR UnaryExpression_t5DE6F6FA2216CDD34DFCFADEB0080CB29326DD62 * Expression_Throw_mEDE9895093C52A20A1A895C44CE7F73D7F0C7A01 (Expression_t30A004209C10C2D9A9785B2F74EEED431A4D4660 * ___value0, Type_t * ___type1, const RuntimeMethod* method);
// System.Dynamic.BindingRestrictions System.Dynamic.DynamicMetaObject::get_Restrictions()
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR BindingRestrictions_t03E14FA0517A70DEDA502032CE956595EF6E0DFC * DynamicMetaObject_get_Restrictions_mE04FE62E32906462628D87A3341521ABFADC63C5_inline (DynamicMetaObject_t5279001ADBFAB6EF015CAC54937F4E9F003881C3 * __this, const RuntimeMethod* method);
// System.Void System.Runtime.CompilerServices.TrueReadOnlyCollection`1<System.Linq.Expressions.ParameterExpression>::.ctor(T[])
inline void TrueReadOnlyCollection_1__ctor_mF8FDD857140C35B895099B7D89BFFE4153D771B5 (TrueReadOnlyCollection_1_tFACBB37A6A09F5303FA9A457A34FAFE7002020A3 * __this, ParameterExpressionU5BU5D_tCF3EAA6D8556513C4937E1126F65AA08DF4DB147* ___list0, const RuntimeMethod* method)
{
	((  void (*) (TrueReadOnlyCollection_1_tFACBB37A6A09F5303FA9A457A34FAFE7002020A3 *, ParameterExpressionU5BU5D_tCF3EAA6D8556513C4937E1126F65AA08DF4DB147*, const RuntimeMethod*))TrueReadOnlyCollection_1__ctor_mDF3EF583478D490FB15F7AB3FF61E2E73191FFA2_gshared)(__this, ___list0, method);
}
// !0 System.Collections.ObjectModel.ReadOnlyCollection`1<System.Linq.Expressions.Expression>::get_Item(System.Int32)
inline Expression_t30A004209C10C2D9A9785B2F74EEED431A4D4660 * ReadOnlyCollection_1_get_Item_m61B304E87F7A24CB20EA9565FBC66CB9118FE6D1 (ReadOnlyCollection_1_t7976DDE3F2FC7BAAF4F920193FF1B5BA33CCC2B5 * __this, int32_t ___index0, const RuntimeMethod* method)
{
	return ((  Expression_t30A004209C10C2D9A9785B2F74EEED431A4D4660 * (*) (ReadOnlyCollection_1_t7976DDE3F2FC7BAAF4F920193FF1B5BA33CCC2B5 *, int32_t, const RuntimeMethod*))ReadOnlyCollection_1_get_Item_m92C5369651F9216CBCAD03983F2F34C5C3BF0744_gshared)(__this, ___index0, method);
}
// System.Linq.Expressions.BinaryExpression System.Linq.Expressions.Expression::Assign(System.Linq.Expressions.Expression,System.Linq.Expressions.Expression)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR BinaryExpression_tCD79755962D104E6603B50D89E7F0E41D1D9CA79 * Expression_Assign_m32AEF41186AAC28E7AB3E83502C64A93CA69562C (Expression_t30A004209C10C2D9A9785B2F74EEED431A4D4660 * ___left0, Expression_t30A004209C10C2D9A9785B2F74EEED431A4D4660 * ___right1, const RuntimeMethod* method);
// System.Linq.Expressions.Expression System.Dynamic.DynamicObject/MetaDynamic::GetLimitedSelf()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR Expression_t30A004209C10C2D9A9785B2F74EEED431A4D4660 * MetaDynamic_GetLimitedSelf_mBECEBC402098F5A006F3554E50694B4FB5C526C9 (MetaDynamic_t774AF4A12F33149209C1FA08022AB0EE951BFB7C * __this, const RuntimeMethod* method);
// System.Linq.Expressions.MethodCallExpression System.Linq.Expressions.Expression::Call(System.Linq.Expressions.Expression,System.Reflection.MethodInfo,System.Linq.Expressions.Expression[])
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR MethodCallExpression_tF8E07995EEDB83A97C356206D651D5EEC72EFFA4 * Expression_Call_mC590C169ED2A0064A3B956FE928BE8E53F1F85F7 (Expression_t30A004209C10C2D9A9785B2F74EEED431A4D4660 * ___instance0, MethodInfo_t * ___method1, ExpressionU5BU5D_t4F1F138488EBD58837D142B40E0E4EEFC607EA63* ___arguments2, const RuntimeMethod* method);
// System.Linq.Expressions.Expression System.Dynamic.DynamicObject/MetaDynamic::ReferenceArgAssign(System.Linq.Expressions.Expression,System.Linq.Expressions.Expression[])
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR Expression_t30A004209C10C2D9A9785B2F74EEED431A4D4660 * MetaDynamic_ReferenceArgAssign_mBB711F0B8A80C937B3ED02BC585F9B2BCA60EFA1 (Expression_t30A004209C10C2D9A9785B2F74EEED431A4D4660 * ___callArgs0, ExpressionU5BU5D_t4F1F138488EBD58837D142B40E0E4EEFC607EA63* ___args1, const RuntimeMethod* method);
// System.Linq.Expressions.BlockExpression System.Linq.Expressions.Expression::Block(System.Linq.Expressions.Expression,System.Linq.Expressions.Expression)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR BlockExpression_t429D310E740322594C18397DEAE7E17DCFE0E0BB * Expression_Block_m7103824690B02B43C2A397B52AF560EC9A044810 (Expression_t30A004209C10C2D9A9785B2F74EEED431A4D4660 * ___arg00, Expression_t30A004209C10C2D9A9785B2F74EEED431A4D4660 * ___arg11, const RuntimeMethod* method);
// System.Linq.Expressions.BlockExpression System.Linq.Expressions.Expression::Block(System.Collections.Generic.IEnumerable`1<System.Linq.Expressions.ParameterExpression>,System.Collections.Generic.IEnumerable`1<System.Linq.Expressions.Expression>)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR BlockExpression_t429D310E740322594C18397DEAE7E17DCFE0E0BB * Expression_Block_mA6CB052758601202DB19D5181835168D9CE6F908 (RuntimeObject* ___variables0, RuntimeObject* ___expressions1, const RuntimeMethod* method);
// System.Dynamic.BindingRestrictions System.Dynamic.DynamicObject/MetaDynamic::GetRestrictions()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR BindingRestrictions_t03E14FA0517A70DEDA502032CE956595EF6E0DFC * MetaDynamic_GetRestrictions_mFD3843F7B4CCBFC34A3C66170CA03B3E19504F38 (MetaDynamic_t774AF4A12F33149209C1FA08022AB0EE951BFB7C * __this, const RuntimeMethod* method);
// System.Dynamic.BindingRestrictions System.Dynamic.BindingRestrictions::Merge(System.Dynamic.BindingRestrictions)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR BindingRestrictions_t03E14FA0517A70DEDA502032CE956595EF6E0DFC * BindingRestrictions_Merge_mA5D48059166AC655BF2CDF39CC199F4CE3400D19 (BindingRestrictions_t03E14FA0517A70DEDA502032CE956595EF6E0DFC * __this, BindingRestrictions_t03E14FA0517A70DEDA502032CE956595EF6E0DFC * ___restrictions0, const RuntimeMethod* method);
// System.Linq.Expressions.ConstantExpression System.Linq.Expressions.Expression::Constant(System.Object,System.Type)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR ConstantExpression_tE22239C4AE815AF9B4647E026E802623F433F0FB * Expression_Constant_m014E12A7CCA8E2705E27CA97B85616EBE181F3FF (RuntimeObject * ___value0, Type_t * ___type1, const RuntimeMethod* method);
// !!0[] System.Array::Empty<System.Linq.Expressions.ParameterExpression>()
inline ParameterExpressionU5BU5D_tCF3EAA6D8556513C4937E1126F65AA08DF4DB147* Array_Empty_TisParameterExpression_tA7B24F1DE0F013DA4BD55F76DB43B06DB33D8BEE_m8FAF2226E6288860C1D3C92AB793820D17F32D71_inline (const RuntimeMethod* method)
{
	return ((  ParameterExpressionU5BU5D_tCF3EAA6D8556513C4937E1126F65AA08DF4DB147* (*) (const RuntimeMethod*))Array_Empty_TisRuntimeObject_m1FBC21243DF3542384C523801E8CA8A97606C747_gshared_inline)(method);
}
// System.Void System.Collections.Generic.List`1<System.Linq.Expressions.ParameterExpression>::.ctor(System.Int32)
inline void List_1__ctor_mE4C9B3F15E5D5168479F4E7227A000B97C871A30 (List_1_tCDDF33E8793E2DD752E38CC326B13F8F35B1493B * __this, int32_t ___capacity0, const RuntimeMethod* method)
{
	((  void (*) (List_1_tCDDF33E8793E2DD752E38CC326B13F8F35B1493B *, int32_t, const RuntimeMethod*))List_1__ctor_mFEB2301A6F28290A828A979BA9CC847B16B3D538_gshared)(__this, ___capacity0, method);
}
// System.Void System.Collections.Generic.List`1<System.Linq.Expressions.ParameterExpression>::Add(!0)
inline void List_1_Add_mC5D74D70A6B9B4BC082AEB0EC771879B842C7708 (List_1_tCDDF33E8793E2DD752E38CC326B13F8F35B1493B * __this, ParameterExpression_tA7B24F1DE0F013DA4BD55F76DB43B06DB33D8BEE * ___item0, const RuntimeMethod* method)
{
	((  void (*) (List_1_tCDDF33E8793E2DD752E38CC326B13F8F35B1493B *, ParameterExpression_tA7B24F1DE0F013DA4BD55F76DB43B06DB33D8BEE *, const RuntimeMethod*))List_1_Add_mE5B3CBB3A625606D9BC4337FEAAF1D66BCB6F96E_gshared)(__this, ___item0, method);
}
// System.Void System.Linq.Expressions.Interpreter.LightCompiler/QuoteVisitor::PushParameters(System.Collections.Generic.IEnumerable`1<System.Linq.Expressions.ParameterExpression>)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void QuoteVisitor_PushParameters_m7AAC447E0627A0AD1A5EBAB7A7AFFD5F239CC0ED (QuoteVisitor_tFE404B4C826642C3FC245A108AEC9E94D691E627 * __this, RuntimeObject* ___parameters0, const RuntimeMethod* method);
// System.Void System.Linq.Expressions.Interpreter.LightCompiler/QuoteVisitor::PopParameters(System.Collections.Generic.IEnumerable`1<System.Linq.Expressions.ParameterExpression>)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void QuoteVisitor_PopParameters_m88C9C499B152E0333072D63BFD2908F2D710495A (QuoteVisitor_tFE404B4C826642C3FC245A108AEC9E94D691E627 * __this, RuntimeObject* ___parameters0, const RuntimeMethod* method);
// System.Void System.Collections.Generic.HashSet`1<System.Linq.Expressions.ParameterExpression>::.ctor()
inline void HashSet_1__ctor_m7E015D0E7832B3967403CAEE703C819D77AE741B (HashSet_1_t42A3AC337CA15FAC250AA5DA438F909806C72CB0 * __this, const RuntimeMethod* method)
{
	((  void (*) (HashSet_1_t42A3AC337CA15FAC250AA5DA438F909806C72CB0 *, const RuntimeMethod*))HashSet_1__ctor_m2CDA40DEC2900A9CB00F8348FF386DF44ABD0EC7_gshared)(__this, method);
}
// System.Boolean System.Collections.Generic.HashSet`1<System.Linq.Expressions.ParameterExpression>::Add(T)
inline bool HashSet_1_Add_m97A1CDFD6C8F09EC6D4C676F183FBAF06EC20CDE (HashSet_1_t42A3AC337CA15FAC250AA5DA438F909806C72CB0 * __this, ParameterExpression_tA7B24F1DE0F013DA4BD55F76DB43B06DB33D8BEE * ___item0, const RuntimeMethod* method)
{
	return ((  bool (*) (HashSet_1_t42A3AC337CA15FAC250AA5DA438F909806C72CB0 *, ParameterExpression_tA7B24F1DE0F013DA4BD55F76DB43B06DB33D8BEE *, const RuntimeMethod*))HashSet_1_Add_mF670AD4C3F2685F0797E05C5491BC1841CEA9DBA_gshared)(__this, ___item0, method);
}
// System.Void System.Collections.Generic.Stack`1<System.Collections.Generic.HashSet`1<System.Linq.Expressions.ParameterExpression>>::Push(!0)
inline void Stack_1_Push_m97F7795161150F81DB993EFB230CD48A2B2A369C (Stack_1_t438C22E9DF33740A9BDB48CF9504B6E044484958 * __this, HashSet_1_t42A3AC337CA15FAC250AA5DA438F909806C72CB0 * ___item0, const RuntimeMethod* method)
{
	((  void (*) (Stack_1_t438C22E9DF33740A9BDB48CF9504B6E044484958 *, HashSet_1_t42A3AC337CA15FAC250AA5DA438F909806C72CB0 *, const RuntimeMethod*))Stack_1_Push_m37749C6ED558EC2D89F38CF78C833D4EE8A2DF04_gshared)(__this, ___item0, method);
}
// System.Linq.Expressions.Expression System.Linq.Expressions.LambdaExpression::get_Body()
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR Expression_t30A004209C10C2D9A9785B2F74EEED431A4D4660 * LambdaExpression_get_Body_m595A485419E2F0AA13FC2695DEBD99ED9712D042_inline (LambdaExpression_t26BF905E97E6D94F81F17D60F4F4F47F8E93B474 * __this, const RuntimeMethod* method);
// !0 System.Collections.Generic.Stack`1<System.Collections.Generic.HashSet`1<System.Linq.Expressions.ParameterExpression>>::Pop()
inline HashSet_1_t42A3AC337CA15FAC250AA5DA438F909806C72CB0 * Stack_1_Pop_mE1B2B7343AEB424CD56DCD92DE34D64249A26769 (Stack_1_t438C22E9DF33740A9BDB48CF9504B6E044484958 * __this, const RuntimeMethod* method)
{
	return ((  HashSet_1_t42A3AC337CA15FAC250AA5DA438F909806C72CB0 * (*) (Stack_1_t438C22E9DF33740A9BDB48CF9504B6E044484958 *, const RuntimeMethod*))Stack_1_Pop_m9503124BACE0FDA402D22BC901708C5D99063C12_gshared)(__this, method);
}
// System.Object System.Delegate::get_Target()
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR RuntimeObject * Delegate_get_Target_mA4C35D598EE379F0F1D49EA8670620792D25EAB1_inline (Delegate_t * __this, const RuntimeMethod* method);
// System.Collections.Generic.Dictionary`2<System.Object,System.Runtime.InteropServices.WindowsRuntime.WindowsRuntimeMarshal/EventRegistrationTokenList> System.Runtime.InteropServices.WindowsRuntime.WindowsRuntimeMarshal/ManagedEventRegistrationImpl::GetEventRegistrationTokenTable(System.Object,System.Action`1<System.Runtime.InteropServices.WindowsRuntime.EventRegistrationToken>)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR Dictionary_2_t5BB631D653FC099355128DBC14DC44E27AD30739 * ManagedEventRegistrationImpl_GetEventRegistrationTokenTable_m8BBB3CF664BBC6EA31B8469EADEFD8EC1D82B8D3 (RuntimeObject * ___instance0, Action_1_t91FC536003CAB9AB56B84E901AE08156372856E3 * ___removeMethod1, const RuntimeMethod* method);
// System.Void System.Threading.Monitor::Enter(System.Object,System.Boolean&)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Monitor_Enter_mBEB6CC84184B46F26375EC3FC8921D16E48EA4C4 (RuntimeObject * ___obj0, bool* ___lockTaken1, const RuntimeMethod* method);
// System.Boolean System.Collections.Generic.Dictionary`2<System.Object,System.Runtime.InteropServices.WindowsRuntime.WindowsRuntimeMarshal/EventRegistrationTokenList>::TryGetValue(TKey,TValue&)
inline bool Dictionary_2_TryGetValue_mF842EC8D110A281144B0082DE75F29AE5261F24F (Dictionary_2_t5BB631D653FC099355128DBC14DC44E27AD30739 * __this, RuntimeObject * ___key0, EventRegistrationTokenList_t0B8EB3E0DA8A305BFCD313936266A15F50B4B128 * ___value1, const RuntimeMethod* method)
{
	return ((  bool (*) (Dictionary_2_t5BB631D653FC099355128DBC14DC44E27AD30739 *, RuntimeObject *, EventRegistrationTokenList_t0B8EB3E0DA8A305BFCD313936266A15F50B4B128 *, const RuntimeMethod*))Dictionary_2_TryGetValue_mF842EC8D110A281144B0082DE75F29AE5261F24F_gshared)(__this, ___key0, ___value1, method);
}
// System.Void System.Runtime.InteropServices.WindowsRuntime.WindowsRuntimeMarshal/EventRegistrationTokenList::.ctor(System.Runtime.InteropServices.WindowsRuntime.EventRegistrationToken)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void EventRegistrationTokenList__ctor_m06470FB422418EBC781CFC09992EE7D2F4EF9772 (EventRegistrationTokenList_t0B8EB3E0DA8A305BFCD313936266A15F50B4B128 * __this, EventRegistrationToken_t5460ED02F1A6B74B604DFD634E8D5429857E9830  ___token0, const RuntimeMethod* method);
// System.Void System.Collections.Generic.Dictionary`2<System.Object,System.Runtime.InteropServices.WindowsRuntime.WindowsRuntimeMarshal/EventRegistrationTokenList>::set_Item(TKey,TValue)
inline void Dictionary_2_set_Item_mC31C547D1D8807C284FEE2E67821F99533C54EB7 (Dictionary_2_t5BB631D653FC099355128DBC14DC44E27AD30739 * __this, RuntimeObject * ___key0, EventRegistrationTokenList_t0B8EB3E0DA8A305BFCD313936266A15F50B4B128  ___value1, const RuntimeMethod* method)
{
	((  void (*) (Dictionary_2_t5BB631D653FC099355128DBC14DC44E27AD30739 *, RuntimeObject *, EventRegistrationTokenList_t0B8EB3E0DA8A305BFCD313936266A15F50B4B128 , const RuntimeMethod*))Dictionary_2_set_Item_mC31C547D1D8807C284FEE2E67821F99533C54EB7_gshared)(__this, ___key0, ___value1, method);
}
// System.Boolean System.Runtime.InteropServices.WindowsRuntime.WindowsRuntimeMarshal/EventRegistrationTokenList::Push(System.Runtime.InteropServices.WindowsRuntime.EventRegistrationToken)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR bool EventRegistrationTokenList_Push_mA05262483205E888368D766263A039078C98D8E8 (EventRegistrationTokenList_t0B8EB3E0DA8A305BFCD313936266A15F50B4B128 * __this, EventRegistrationToken_t5460ED02F1A6B74B604DFD634E8D5429857E9830  ___token0, const RuntimeMethod* method);
// System.Void System.Threading.Monitor::Exit(System.Object)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Monitor_Exit_mA776B403DA88AC77CDEEF67AB9F0D0E77ABD254A (RuntimeObject * ___obj0, const RuntimeMethod* method);
// System.Boolean System.Runtime.InteropServices.WindowsRuntime.WindowsRuntimeMarshal/EventRegistrationTokenList::Pop(System.Runtime.InteropServices.WindowsRuntime.EventRegistrationToken&)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR bool EventRegistrationTokenList_Pop_mEDB55C6642FBEE0B03BDC2C06E84FBEFAE96FCDB (EventRegistrationTokenList_t0B8EB3E0DA8A305BFCD313936266A15F50B4B128 * __this, EventRegistrationToken_t5460ED02F1A6B74B604DFD634E8D5429857E9830 * ___token0, const RuntimeMethod* method);
// System.Boolean System.Collections.Generic.Dictionary`2<System.Object,System.Runtime.InteropServices.WindowsRuntime.WindowsRuntimeMarshal/EventRegistrationTokenList>::Remove(TKey)
inline bool Dictionary_2_Remove_mF26A9D605B336E64E00D3E9B1A2B24D23F440D1C (Dictionary_2_t5BB631D653FC099355128DBC14DC44E27AD30739 * __this, RuntimeObject * ___key0, const RuntimeMethod* method)
{
	return ((  bool (*) (Dictionary_2_t5BB631D653FC099355128DBC14DC44E27AD30739 *, RuntimeObject *, const RuntimeMethod*))Dictionary_2_Remove_mF26A9D605B336E64E00D3E9B1A2B24D23F440D1C_gshared)(__this, ___key0, method);
}
// System.Void System.Action`1<System.Runtime.InteropServices.WindowsRuntime.EventRegistrationToken>::Invoke(T)
inline void Action_1_Invoke_m0670A1DF770A18B2D457A2B700EEF92B463652DA (Action_1_t91FC536003CAB9AB56B84E901AE08156372856E3 * __this, EventRegistrationToken_t5460ED02F1A6B74B604DFD634E8D5429857E9830  ___obj0, const RuntimeMethod* method)
{
	((  void (*) (Action_1_t91FC536003CAB9AB56B84E901AE08156372856E3 *, EventRegistrationToken_t5460ED02F1A6B74B604DFD634E8D5429857E9830 , const RuntimeMethod*))Action_1_Invoke_m0670A1DF770A18B2D457A2B700EEF92B463652DA_gshared)(__this, ___obj0, method);
}
// System.Object System.Runtime.InteropServices.WindowsRuntime.WindowsRuntimeMarshal/NativeOrStaticEventRegistrationImpl::GetInstanceKey(System.Action`1<System.Runtime.InteropServices.WindowsRuntime.EventRegistrationToken>)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR RuntimeObject * NativeOrStaticEventRegistrationImpl_GetInstanceKey_m609103D809620576492B03F7BFB8FC959231E174 (Action_1_t91FC536003CAB9AB56B84E901AE08156372856E3 * ___removeMethod0, const RuntimeMethod* method);
// System.Void System.Runtime.InteropServices.WindowsRuntime.WindowsRuntimeMarshal/NativeOrStaticEventRegistrationImpl/MyReaderWriterLock::AcquireReaderLock(System.Int32)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void MyReaderWriterLock_AcquireReaderLock_m4C64A27901CB970D8F6FA8A4AE98B8980C8138AD (MyReaderWriterLock_t0EAF7040A5BCE7C816030732D088A8DB81FB97AD * __this, int32_t ___millisecondsTimeout0, const RuntimeMethod* method);
// System.Runtime.CompilerServices.ConditionalWeakTable`2<System.Object,System.Runtime.InteropServices.WindowsRuntime.WindowsRuntimeMarshal/NativeOrStaticEventRegistrationImpl/EventRegistrationTokenListWithCount> System.Runtime.InteropServices.WindowsRuntime.WindowsRuntimeMarshal/NativeOrStaticEventRegistrationImpl::GetOrCreateEventRegistrationTokenTable(System.Object,System.Action`1<System.Runtime.InteropServices.WindowsRuntime.EventRegistrationToken>,System.Runtime.InteropServices.WindowsRuntime.WindowsRuntimeMarshal/NativeOrStaticEventRegistrationImpl/TokenListCount&)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR ConditionalWeakTable_2_tDE9E02FF583A5D6707A2CCEF9E15BD2791EA4229 * NativeOrStaticEventRegistrationImpl_GetOrCreateEventRegistrationTokenTable_mE0D26BCAD8501EEF779A9CB54A47E7621638426F (RuntimeObject * ___instance0, Action_1_t91FC536003CAB9AB56B84E901AE08156372856E3 * ___removeMethod1, TokenListCount_t769EA62356D8C37857DCC81DB79A76FA75E319AC ** ___tokenListCount2, const RuntimeMethod* method);
// TKey System.Runtime.CompilerServices.ConditionalWeakTable`2<System.Object,System.Runtime.InteropServices.WindowsRuntime.WindowsRuntimeMarshal/NativeOrStaticEventRegistrationImpl/EventRegistrationTokenListWithCount>::FindEquivalentKeyUnsafe(TKey,TValue&)
inline RuntimeObject * ConditionalWeakTable_2_FindEquivalentKeyUnsafe_mC28129CC24B2F2D4CACEEC954DB5F99E4EEE0713 (ConditionalWeakTable_2_tDE9E02FF583A5D6707A2CCEF9E15BD2791EA4229 * __this, RuntimeObject * ___key0, EventRegistrationTokenListWithCount_t8BA708F75B90C86A7CA1F3FD1DFCBD742D458FC6 ** ___value1, const RuntimeMethod* method)
{
	return ((  RuntimeObject * (*) (ConditionalWeakTable_2_tDE9E02FF583A5D6707A2CCEF9E15BD2791EA4229 *, RuntimeObject *, EventRegistrationTokenListWithCount_t8BA708F75B90C86A7CA1F3FD1DFCBD742D458FC6 **, const RuntimeMethod*))ConditionalWeakTable_2_FindEquivalentKeyUnsafe_mE374DB04CE4CDA882F4AA25E26375C46728BA8AA_gshared)(__this, ___key0, ___value1, method);
}
// System.Void System.Runtime.InteropServices.WindowsRuntime.WindowsRuntimeMarshal/NativeOrStaticEventRegistrationImpl/EventRegistrationTokenListWithCount::.ctor(System.Runtime.InteropServices.WindowsRuntime.WindowsRuntimeMarshal/NativeOrStaticEventRegistrationImpl/TokenListCount,System.Runtime.InteropServices.WindowsRuntime.EventRegistrationToken)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void EventRegistrationTokenListWithCount__ctor_m09819A938F29C2DD7D8E2ACCC5249E6B7275E748 (EventRegistrationTokenListWithCount_t8BA708F75B90C86A7CA1F3FD1DFCBD742D458FC6 * __this, TokenListCount_t769EA62356D8C37857DCC81DB79A76FA75E319AC * ___tokenListCount0, EventRegistrationToken_t5460ED02F1A6B74B604DFD634E8D5429857E9830  ___token1, const RuntimeMethod* method);
// System.Void System.Runtime.CompilerServices.ConditionalWeakTable`2<System.Object,System.Runtime.InteropServices.WindowsRuntime.WindowsRuntimeMarshal/NativeOrStaticEventRegistrationImpl/EventRegistrationTokenListWithCount>::Add(TKey,TValue)
inline void ConditionalWeakTable_2_Add_mF73DB702E1356B2CC2F9C09D3443987A75954088 (ConditionalWeakTable_2_tDE9E02FF583A5D6707A2CCEF9E15BD2791EA4229 * __this, RuntimeObject * ___key0, EventRegistrationTokenListWithCount_t8BA708F75B90C86A7CA1F3FD1DFCBD742D458FC6 * ___value1, const RuntimeMethod* method)
{
	((  void (*) (ConditionalWeakTable_2_tDE9E02FF583A5D6707A2CCEF9E15BD2791EA4229 *, RuntimeObject *, EventRegistrationTokenListWithCount_t8BA708F75B90C86A7CA1F3FD1DFCBD742D458FC6 *, const RuntimeMethod*))ConditionalWeakTable_2_Add_m92A993D020EA2EE92A0C05D9AA35E65E043E7805_gshared)(__this, ___key0, ___value1, method);
}
// System.Void System.Runtime.InteropServices.WindowsRuntime.WindowsRuntimeMarshal/NativeOrStaticEventRegistrationImpl/EventRegistrationTokenListWithCount::Push(System.Runtime.InteropServices.WindowsRuntime.EventRegistrationToken)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void EventRegistrationTokenListWithCount_Push_m966CF9B4B55E54DADA94B9B325053F115B9421F5 (EventRegistrationTokenListWithCount_t8BA708F75B90C86A7CA1F3FD1DFCBD742D458FC6 * __this, EventRegistrationToken_t5460ED02F1A6B74B604DFD634E8D5429857E9830  ___token0, const RuntimeMethod* method);
// System.Void System.Runtime.InteropServices.WindowsRuntime.WindowsRuntimeMarshal/NativeOrStaticEventRegistrationImpl/MyReaderWriterLock::ReleaseReaderLock()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void MyReaderWriterLock_ReleaseReaderLock_m9957FB580A0C803C269D10DB3C7B9482FF46A94D (MyReaderWriterLock_t0EAF7040A5BCE7C816030732D088A8DB81FB97AD * __this, const RuntimeMethod* method);
// System.Runtime.CompilerServices.ConditionalWeakTable`2<System.Object,System.Runtime.InteropServices.WindowsRuntime.WindowsRuntimeMarshal/NativeOrStaticEventRegistrationImpl/EventRegistrationTokenListWithCount> System.Runtime.InteropServices.WindowsRuntime.WindowsRuntimeMarshal/NativeOrStaticEventRegistrationImpl::GetEventRegistrationTokenTableNoCreate(System.Object,System.Action`1<System.Runtime.InteropServices.WindowsRuntime.EventRegistrationToken>,System.Runtime.InteropServices.WindowsRuntime.WindowsRuntimeMarshal/NativeOrStaticEventRegistrationImpl/TokenListCount&)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR ConditionalWeakTable_2_tDE9E02FF583A5D6707A2CCEF9E15BD2791EA4229 * NativeOrStaticEventRegistrationImpl_GetEventRegistrationTokenTableNoCreate_m2FDC87A2509BEB899C090FC0D2C3A5D0888B3250 (RuntimeObject * ___instance0, Action_1_t91FC536003CAB9AB56B84E901AE08156372856E3 * ___removeMethod1, TokenListCount_t769EA62356D8C37857DCC81DB79A76FA75E319AC ** ___tokenListCount2, const RuntimeMethod* method);
// System.Boolean System.Runtime.InteropServices.WindowsRuntime.WindowsRuntimeMarshal/NativeOrStaticEventRegistrationImpl/EventRegistrationTokenListWithCount::Pop(System.Runtime.InteropServices.WindowsRuntime.EventRegistrationToken&)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR bool EventRegistrationTokenListWithCount_Pop_mB0D869EA5FC0BB430DB9BCF253396C6B5F7D20FB (EventRegistrationTokenListWithCount_t8BA708F75B90C86A7CA1F3FD1DFCBD742D458FC6 * __this, EventRegistrationToken_t5460ED02F1A6B74B604DFD634E8D5429857E9830 * ___token0, const RuntimeMethod* method);
// System.Boolean System.Runtime.CompilerServices.ConditionalWeakTable`2<System.Object,System.Runtime.InteropServices.WindowsRuntime.WindowsRuntimeMarshal/NativeOrStaticEventRegistrationImpl/EventRegistrationTokenListWithCount>::Remove(TKey)
inline bool ConditionalWeakTable_2_Remove_mF1535859D88E215E79053D8935FCE7DF3F2D7124 (ConditionalWeakTable_2_tDE9E02FF583A5D6707A2CCEF9E15BD2791EA4229 * __this, RuntimeObject * ___key0, const RuntimeMethod* method)
{
	return ((  bool (*) (ConditionalWeakTable_2_tDE9E02FF583A5D6707A2CCEF9E15BD2791EA4229 *, RuntimeObject *, const RuntimeMethod*))ConditionalWeakTable_2_Remove_m0B765A2BAD7A3874D8B33A87AC105A25764895FB_gshared)(__this, ___key0, method);
}
// T[] System.Xml.Schema.XmlListConverter::ToArray<System.SByte>(System.Object,System.Xml.IXmlNamespaceResolver)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR SByteU5BU5D_t7D94C53295E6116625EA7CC7DEA21FEDC39869E7* XmlListConverter_ToArray_TisSByte_t928712DD662DC29BA4FAAE8CE2230AFB23447F0B_m4BE75BE01AD0B9442E284F30311EFE22BE4853F6_gshared (XmlListConverter_t58F692567B1B34BF5171B647F1BE66EC017D4F4D * __this, RuntimeObject * ___list0, RuntimeObject* ___nsResolver1, const RuntimeMethod* method)
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&ICollection_tC1E1DED86C0A66845675392606B302452210D5DA_il2cpp_TypeInfo_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&IDisposable_t099785737FC6A1E3699919A94109383715A8D807_il2cpp_TypeInfo_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&IEnumerable_t47A618747A1BB2A868710316F7372094849163A2_il2cpp_TypeInfo_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&IEnumerator_t5956F3AFB7ECF1117E3BC5890E7FC7B7F7A04105_il2cpp_TypeInfo_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&IList_tB15A9D6625D09661D6E47976BB626C703EC81910_il2cpp_TypeInfo_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Type_t_il2cpp_TypeInfo_var);
		s_Il2CppMethodInitialized = true;
	}
	RuntimeObject* V_0 = NULL;
	List_1_t7F0E10DCBF1EBD7FBCA81F990C2A8D07D7A611F7 * V_1 = NULL;
	SByteU5BU5D_t7D94C53295E6116625EA7CC7DEA21FEDC39869E7* V_2 = NULL;
	int32_t V_3 = 0;
	RuntimeObject* V_4 = NULL;
	RuntimeObject * V_5 = NULL;
	RuntimeObject* V_6 = NULL;
	Exception_t * __last_unhandled_exception = 0;
	il2cpp::utils::ExceptionSupportStack<int32_t, 1> __leave_targets;
	{
		RuntimeObject * L_0 = ___list0;
		V_0 = (RuntimeObject*)((RuntimeObject*)IsInst((RuntimeObject*)L_0, IList_tB15A9D6625D09661D6E47976BB626C703EC81910_il2cpp_TypeInfo_var));
		RuntimeObject* L_1 = V_0;
		if (!L_1)
		{
			goto IL_0052;
		}
	}
	{
		RuntimeObject* L_2 = V_0;
		NullCheck((RuntimeObject*)L_2);
		int32_t L_3;
		L_3 = InterfaceFuncInvoker0< int32_t >::Invoke(1 /* System.Int32 System.Collections.ICollection::get_Count() */, ICollection_tC1E1DED86C0A66845675392606B302452210D5DA_il2cpp_TypeInfo_var, (RuntimeObject*)L_2);
		SByteU5BU5D_t7D94C53295E6116625EA7CC7DEA21FEDC39869E7* L_4 = (SByteU5BU5D_t7D94C53295E6116625EA7CC7DEA21FEDC39869E7*)(SByteU5BU5D_t7D94C53295E6116625EA7CC7DEA21FEDC39869E7*)SZArrayNew(IL2CPP_RGCTX_DATA(method->rgctx_data, 0), (uint32_t)L_3);
		V_2 = (SByteU5BU5D_t7D94C53295E6116625EA7CC7DEA21FEDC39869E7*)L_4;
		V_3 = (int32_t)0;
		goto IL_0047;
	}

IL_001a:
	{
		SByteU5BU5D_t7D94C53295E6116625EA7CC7DEA21FEDC39869E7* L_5 = V_2;
		int32_t L_6 = V_3;
		XmlValueConverter_t18B2DCDB3B3F7609F3E43D5C46D2095BD09E6763 * L_7 = (XmlValueConverter_t18B2DCDB3B3F7609F3E43D5C46D2095BD09E6763 *)__this->get_atomicConverter_32();
		RuntimeObject* L_8 = V_0;
		int32_t L_9 = V_3;
		NullCheck((RuntimeObject*)L_8);
		RuntimeObject * L_10;
		L_10 = InterfaceFuncInvoker1< RuntimeObject *, int32_t >::Invoke(0 /* System.Object System.Collections.IList::get_Item(System.Int32) */, IList_tB15A9D6625D09661D6E47976BB626C703EC81910_il2cpp_TypeInfo_var, (RuntimeObject*)L_8, (int32_t)L_9);
		RuntimeTypeHandle_tC33965ADA3E041E0C94AF05E5CB527B56482CEF9  L_11 = { reinterpret_cast<intptr_t> (IL2CPP_RGCTX_TYPE(method->rgctx_data, 1)) };
		IL2CPP_RUNTIME_CLASS_INIT(Type_t_il2cpp_TypeInfo_var);
		Type_t * L_12;
		L_12 = Type_GetTypeFromHandle_m8BB57524FF7F9DB1803BC561D2B3A4DBACEB385E((RuntimeTypeHandle_tC33965ADA3E041E0C94AF05E5CB527B56482CEF9 )L_11, /*hidden argument*/NULL);
		RuntimeObject* L_13 = ___nsResolver1;
		NullCheck((XmlValueConverter_t18B2DCDB3B3F7609F3E43D5C46D2095BD09E6763 *)L_7);
		RuntimeObject * L_14;
		L_14 = VirtFuncInvoker3< RuntimeObject *, RuntimeObject *, Type_t *, RuntimeObject* >::Invoke(61 /* System.Object System.Xml.Schema.XmlValueConverter::ChangeType(System.Object,System.Type,System.Xml.IXmlNamespaceResolver) */, (XmlValueConverter_t18B2DCDB3B3F7609F3E43D5C46D2095BD09E6763 *)L_7, (RuntimeObject *)L_10, (Type_t *)L_12, (RuntimeObject*)L_13);
		NullCheck(L_5);
		(L_5)->SetAt(static_cast<il2cpp_array_size_t>(L_6), (int8_t)((*(int8_t*)((int8_t*)UnBox(L_14, IL2CPP_RGCTX_DATA(method->rgctx_data, 2))))));
		int32_t L_15 = V_3;
		V_3 = (int32_t)((int32_t)il2cpp_codegen_add((int32_t)L_15, (int32_t)1));
	}

IL_0047:
	{
		int32_t L_16 = V_3;
		RuntimeObject* L_17 = V_0;
		NullCheck((RuntimeObject*)L_17);
		int32_t L_18;
		L_18 = InterfaceFuncInvoker0< int32_t >::Invoke(1 /* System.Int32 System.Collections.ICollection::get_Count() */, ICollection_tC1E1DED86C0A66845675392606B302452210D5DA_il2cpp_TypeInfo_var, (RuntimeObject*)L_17);
		if ((((int32_t)L_16) < ((int32_t)L_18)))
		{
			goto IL_001a;
		}
	}
	{
		SByteU5BU5D_t7D94C53295E6116625EA7CC7DEA21FEDC39869E7* L_19 = V_2;
		return (SByteU5BU5D_t7D94C53295E6116625EA7CC7DEA21FEDC39869E7*)L_19;
	}

IL_0052:
	{
		RuntimeObject * L_20 = ___list0;
		List_1_t7F0E10DCBF1EBD7FBCA81F990C2A8D07D7A611F7 * L_21 = (List_1_t7F0E10DCBF1EBD7FBCA81F990C2A8D07D7A611F7 *)il2cpp_codegen_object_new(IL2CPP_RGCTX_DATA(method->rgctx_data, 3));
		((  void (*) (List_1_t7F0E10DCBF1EBD7FBCA81F990C2A8D07D7A611F7 *, const RuntimeMethod*))IL2CPP_RGCTX_METHOD_INFO(method->rgctx_data, 4)->methodPointer)(L_21, /*hidden argument*/IL2CPP_RGCTX_METHOD_INFO(method->rgctx_data, 4));
		V_1 = (List_1_t7F0E10DCBF1EBD7FBCA81F990C2A8D07D7A611F7 *)L_21;
		NullCheck((RuntimeObject*)((RuntimeObject*)IsInst((RuntimeObject*)L_20, IEnumerable_t47A618747A1BB2A868710316F7372094849163A2_il2cpp_TypeInfo_var)));
		RuntimeObject* L_22;
		L_22 = InterfaceFuncInvoker0< RuntimeObject* >::Invoke(0 /* System.Collections.IEnumerator System.Collections.IEnumerable::GetEnumerator() */, IEnumerable_t47A618747A1BB2A868710316F7372094849163A2_il2cpp_TypeInfo_var, (RuntimeObject*)((RuntimeObject*)IsInst((RuntimeObject*)L_20, IEnumerable_t47A618747A1BB2A868710316F7372094849163A2_il2cpp_TypeInfo_var)));
		V_4 = (RuntimeObject*)L_22;
	}

IL_0065:
	try
	{ // begin try (depth: 1)
		{
			goto IL_0093;
		}

IL_0067:
		{
			RuntimeObject* L_23 = V_4;
			NullCheck((RuntimeObject*)L_23);
			RuntimeObject * L_24;
			L_24 = InterfaceFuncInvoker0< RuntimeObject * >::Invoke(1 /* System.Object System.Collections.IEnumerator::get_Current() */, IEnumerator_t5956F3AFB7ECF1117E3BC5890E7FC7B7F7A04105_il2cpp_TypeInfo_var, (RuntimeObject*)L_23);
			V_5 = (RuntimeObject *)L_24;
			List_1_t7F0E10DCBF1EBD7FBCA81F990C2A8D07D7A611F7 * L_25 = V_1;
			XmlValueConverter_t18B2DCDB3B3F7609F3E43D5C46D2095BD09E6763 * L_26 = (XmlValueConverter_t18B2DCDB3B3F7609F3E43D5C46D2095BD09E6763 *)__this->get_atomicConverter_32();
			RuntimeObject * L_27 = V_5;
			RuntimeTypeHandle_tC33965ADA3E041E0C94AF05E5CB527B56482CEF9  L_28 = { reinterpret_cast<intptr_t> (IL2CPP_RGCTX_TYPE(method->rgctx_data, 1)) };
			IL2CPP_RUNTIME_CLASS_INIT(Type_t_il2cpp_TypeInfo_var);
			Type_t * L_29;
			L_29 = Type_GetTypeFromHandle_m8BB57524FF7F9DB1803BC561D2B3A4DBACEB385E((RuntimeTypeHandle_tC33965ADA3E041E0C94AF05E5CB527B56482CEF9 )L_28, /*hidden argument*/NULL);
			RuntimeObject* L_30 = ___nsResolver1;
			NullCheck((XmlValueConverter_t18B2DCDB3B3F7609F3E43D5C46D2095BD09E6763 *)L_26);
			RuntimeObject * L_31;
			L_31 = VirtFuncInvoker3< RuntimeObject *, RuntimeObject *, Type_t *, RuntimeObject* >::Invoke(61 /* System.Object System.Xml.Schema.XmlValueConverter::ChangeType(System.Object,System.Type,System.Xml.IXmlNamespaceResolver) */, (XmlValueConverter_t18B2DCDB3B3F7609F3E43D5C46D2095BD09E6763 *)L_26, (RuntimeObject *)L_27, (Type_t *)L_29, (RuntimeObject*)L_30);
			NullCheck((List_1_t7F0E10DCBF1EBD7FBCA81F990C2A8D07D7A611F7 *)L_25);
			((  void (*) (List_1_t7F0E10DCBF1EBD7FBCA81F990C2A8D07D7A611F7 *, int8_t, const RuntimeMethod*))IL2CPP_RGCTX_METHOD_INFO(method->rgctx_data, 5)->methodPointer)((List_1_t7F0E10DCBF1EBD7FBCA81F990C2A8D07D7A611F7 *)L_25, (int8_t)((*(int8_t*)((int8_t*)UnBox(L_31, IL2CPP_RGCTX_DATA(method->rgctx_data, 2))))), /*hidden argument*/IL2CPP_RGCTX_METHOD_INFO(method->rgctx_data, 5));
		}

IL_0093:
		{
			RuntimeObject* L_32 = V_4;
			NullCheck((RuntimeObject*)L_32);
			bool L_33;
			L_33 = InterfaceFuncInvoker0< bool >::Invoke(0 /* System.Boolean System.Collections.IEnumerator::MoveNext() */, IEnumerator_t5956F3AFB7ECF1117E3BC5890E7FC7B7F7A04105_il2cpp_TypeInfo_var, (RuntimeObject*)L_32);
			if (L_33)
			{
				goto IL_0067;
			}
		}

IL_009c:
		{
			IL2CPP_LEAVE(0xB3, FINALLY_009e);
		}
	} // end try (depth: 1)
	catch(Il2CppExceptionWrapper& e)
	{
		__last_unhandled_exception = (Exception_t *)e.ex;
		goto FINALLY_009e;
	}

FINALLY_009e:
	{ // begin finally (depth: 1)
		{
			RuntimeObject* L_34 = V_4;
			V_6 = (RuntimeObject*)((RuntimeObject*)IsInst((RuntimeObject*)L_34, IDisposable_t099785737FC6A1E3699919A94109383715A8D807_il2cpp_TypeInfo_var));
			RuntimeObject* L_35 = V_6;
			if (!L_35)
			{
				goto IL_00b2;
			}
		}

IL_00ab:
		{
			RuntimeObject* L_36 = V_6;
			NullCheck((RuntimeObject*)L_36);
			InterfaceActionInvoker0::Invoke(0 /* System.Void System.IDisposable::Dispose() */, IDisposable_t099785737FC6A1E3699919A94109383715A8D807_il2cpp_TypeInfo_var, (RuntimeObject*)L_36);
		}

IL_00b2:
		{
			IL2CPP_END_FINALLY(158)
		}
	} // end finally (depth: 1)
	IL2CPP_CLEANUP(158)
	{
		IL2CPP_RETHROW_IF_UNHANDLED(Exception_t *)
		IL2CPP_JUMP_TBL(0xB3, IL_00b3)
	}

IL_00b3:
	{
		List_1_t7F0E10DCBF1EBD7FBCA81F990C2A8D07D7A611F7 * L_37 = V_1;
		NullCheck((List_1_t7F0E10DCBF1EBD7FBCA81F990C2A8D07D7A611F7 *)L_37);
		SByteU5BU5D_t7D94C53295E6116625EA7CC7DEA21FEDC39869E7* L_38;
		L_38 = ((  SByteU5BU5D_t7D94C53295E6116625EA7CC7DEA21FEDC39869E7* (*) (List_1_t7F0E10DCBF1EBD7FBCA81F990C2A8D07D7A611F7 *, const RuntimeMethod*))IL2CPP_RGCTX_METHOD_INFO(method->rgctx_data, 6)->methodPointer)((List_1_t7F0E10DCBF1EBD7FBCA81F990C2A8D07D7A611F7 *)L_37, /*hidden argument*/IL2CPP_RGCTX_METHOD_INFO(method->rgctx_data, 6));
		return (SByteU5BU5D_t7D94C53295E6116625EA7CC7DEA21FEDC39869E7*)L_38;
	}
}
// T[] System.Xml.Schema.XmlListConverter::ToArray<System.Single>(System.Object,System.Xml.IXmlNamespaceResolver)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR SingleU5BU5D_t47E8DBF5B597C122478D1FFBD9DD57399A0650FA* XmlListConverter_ToArray_TisSingle_tE07797BA3C98D4CA9B5A19413C19A76688AB899E_m732749002501767553BB0EC8E96EAB7E85628666_gshared (XmlListConverter_t58F692567B1B34BF5171B647F1BE66EC017D4F4D * __this, RuntimeObject * ___list0, RuntimeObject* ___nsResolver1, const RuntimeMethod* method)
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&ICollection_tC1E1DED86C0A66845675392606B302452210D5DA_il2cpp_TypeInfo_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&IDisposable_t099785737FC6A1E3699919A94109383715A8D807_il2cpp_TypeInfo_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&IEnumerable_t47A618747A1BB2A868710316F7372094849163A2_il2cpp_TypeInfo_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&IEnumerator_t5956F3AFB7ECF1117E3BC5890E7FC7B7F7A04105_il2cpp_TypeInfo_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&IList_tB15A9D6625D09661D6E47976BB626C703EC81910_il2cpp_TypeInfo_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Type_t_il2cpp_TypeInfo_var);
		s_Il2CppMethodInitialized = true;
	}
	RuntimeObject* V_0 = NULL;
	List_1_t6726F9309570A0BDC5D42E10777F3E2931C487AA * V_1 = NULL;
	SingleU5BU5D_t47E8DBF5B597C122478D1FFBD9DD57399A0650FA* V_2 = NULL;
	int32_t V_3 = 0;
	RuntimeObject* V_4 = NULL;
	RuntimeObject * V_5 = NULL;
	RuntimeObject* V_6 = NULL;
	Exception_t * __last_unhandled_exception = 0;
	il2cpp::utils::ExceptionSupportStack<int32_t, 1> __leave_targets;
	{
		RuntimeObject * L_0 = ___list0;
		V_0 = (RuntimeObject*)((RuntimeObject*)IsInst((RuntimeObject*)L_0, IList_tB15A9D6625D09661D6E47976BB626C703EC81910_il2cpp_TypeInfo_var));
		RuntimeObject* L_1 = V_0;
		if (!L_1)
		{
			goto IL_0052;
		}
	}
	{
		RuntimeObject* L_2 = V_0;
		NullCheck((RuntimeObject*)L_2);
		int32_t L_3;
		L_3 = InterfaceFuncInvoker0< int32_t >::Invoke(1 /* System.Int32 System.Collections.ICollection::get_Count() */, ICollection_tC1E1DED86C0A66845675392606B302452210D5DA_il2cpp_TypeInfo_var, (RuntimeObject*)L_2);
		SingleU5BU5D_t47E8DBF5B597C122478D1FFBD9DD57399A0650FA* L_4 = (SingleU5BU5D_t47E8DBF5B597C122478D1FFBD9DD57399A0650FA*)(SingleU5BU5D_t47E8DBF5B597C122478D1FFBD9DD57399A0650FA*)SZArrayNew(IL2CPP_RGCTX_DATA(method->rgctx_data, 0), (uint32_t)L_3);
		V_2 = (SingleU5BU5D_t47E8DBF5B597C122478D1FFBD9DD57399A0650FA*)L_4;
		V_3 = (int32_t)0;
		goto IL_0047;
	}

IL_001a:
	{
		SingleU5BU5D_t47E8DBF5B597C122478D1FFBD9DD57399A0650FA* L_5 = V_2;
		int32_t L_6 = V_3;
		XmlValueConverter_t18B2DCDB3B3F7609F3E43D5C46D2095BD09E6763 * L_7 = (XmlValueConverter_t18B2DCDB3B3F7609F3E43D5C46D2095BD09E6763 *)__this->get_atomicConverter_32();
		RuntimeObject* L_8 = V_0;
		int32_t L_9 = V_3;
		NullCheck((RuntimeObject*)L_8);
		RuntimeObject * L_10;
		L_10 = InterfaceFuncInvoker1< RuntimeObject *, int32_t >::Invoke(0 /* System.Object System.Collections.IList::get_Item(System.Int32) */, IList_tB15A9D6625D09661D6E47976BB626C703EC81910_il2cpp_TypeInfo_var, (RuntimeObject*)L_8, (int32_t)L_9);
		RuntimeTypeHandle_tC33965ADA3E041E0C94AF05E5CB527B56482CEF9  L_11 = { reinterpret_cast<intptr_t> (IL2CPP_RGCTX_TYPE(method->rgctx_data, 1)) };
		IL2CPP_RUNTIME_CLASS_INIT(Type_t_il2cpp_TypeInfo_var);
		Type_t * L_12;
		L_12 = Type_GetTypeFromHandle_m8BB57524FF7F9DB1803BC561D2B3A4DBACEB385E((RuntimeTypeHandle_tC33965ADA3E041E0C94AF05E5CB527B56482CEF9 )L_11, /*hidden argument*/NULL);
		RuntimeObject* L_13 = ___nsResolver1;
		NullCheck((XmlValueConverter_t18B2DCDB3B3F7609F3E43D5C46D2095BD09E6763 *)L_7);
		RuntimeObject * L_14;
		L_14 = VirtFuncInvoker3< RuntimeObject *, RuntimeObject *, Type_t *, RuntimeObject* >::Invoke(61 /* System.Object System.Xml.Schema.XmlValueConverter::ChangeType(System.Object,System.Type,System.Xml.IXmlNamespaceResolver) */, (XmlValueConverter_t18B2DCDB3B3F7609F3E43D5C46D2095BD09E6763 *)L_7, (RuntimeObject *)L_10, (Type_t *)L_12, (RuntimeObject*)L_13);
		NullCheck(L_5);
		(L_5)->SetAt(static_cast<il2cpp_array_size_t>(L_6), (float)((*(float*)((float*)UnBox(L_14, IL2CPP_RGCTX_DATA(method->rgctx_data, 2))))));
		int32_t L_15 = V_3;
		V_3 = (int32_t)((int32_t)il2cpp_codegen_add((int32_t)L_15, (int32_t)1));
	}

IL_0047:
	{
		int32_t L_16 = V_3;
		RuntimeObject* L_17 = V_0;
		NullCheck((RuntimeObject*)L_17);
		int32_t L_18;
		L_18 = InterfaceFuncInvoker0< int32_t >::Invoke(1 /* System.Int32 System.Collections.ICollection::get_Count() */, ICollection_tC1E1DED86C0A66845675392606B302452210D5DA_il2cpp_TypeInfo_var, (RuntimeObject*)L_17);
		if ((((int32_t)L_16) < ((int32_t)L_18)))
		{
			goto IL_001a;
		}
	}
	{
		SingleU5BU5D_t47E8DBF5B597C122478D1FFBD9DD57399A0650FA* L_19 = V_2;
		return (SingleU5BU5D_t47E8DBF5B597C122478D1FFBD9DD57399A0650FA*)L_19;
	}

IL_0052:
	{
		RuntimeObject * L_20 = ___list0;
		List_1_t6726F9309570A0BDC5D42E10777F3E2931C487AA * L_21 = (List_1_t6726F9309570A0BDC5D42E10777F3E2931C487AA *)il2cpp_codegen_object_new(IL2CPP_RGCTX_DATA(method->rgctx_data, 3));
		((  void (*) (List_1_t6726F9309570A0BDC5D42E10777F3E2931C487AA *, const RuntimeMethod*))IL2CPP_RGCTX_METHOD_INFO(method->rgctx_data, 4)->methodPointer)(L_21, /*hidden argument*/IL2CPP_RGCTX_METHOD_INFO(method->rgctx_data, 4));
		V_1 = (List_1_t6726F9309570A0BDC5D42E10777F3E2931C487AA *)L_21;
		NullCheck((RuntimeObject*)((RuntimeObject*)IsInst((RuntimeObject*)L_20, IEnumerable_t47A618747A1BB2A868710316F7372094849163A2_il2cpp_TypeInfo_var)));
		RuntimeObject* L_22;
		L_22 = InterfaceFuncInvoker0< RuntimeObject* >::Invoke(0 /* System.Collections.IEnumerator System.Collections.IEnumerable::GetEnumerator() */, IEnumerable_t47A618747A1BB2A868710316F7372094849163A2_il2cpp_TypeInfo_var, (RuntimeObject*)((RuntimeObject*)IsInst((RuntimeObject*)L_20, IEnumerable_t47A618747A1BB2A868710316F7372094849163A2_il2cpp_TypeInfo_var)));
		V_4 = (RuntimeObject*)L_22;
	}

IL_0065:
	try
	{ // begin try (depth: 1)
		{
			goto IL_0093;
		}

IL_0067:
		{
			RuntimeObject* L_23 = V_4;
			NullCheck((RuntimeObject*)L_23);
			RuntimeObject * L_24;
			L_24 = InterfaceFuncInvoker0< RuntimeObject * >::Invoke(1 /* System.Object System.Collections.IEnumerator::get_Current() */, IEnumerator_t5956F3AFB7ECF1117E3BC5890E7FC7B7F7A04105_il2cpp_TypeInfo_var, (RuntimeObject*)L_23);
			V_5 = (RuntimeObject *)L_24;
			List_1_t6726F9309570A0BDC5D42E10777F3E2931C487AA * L_25 = V_1;
			XmlValueConverter_t18B2DCDB3B3F7609F3E43D5C46D2095BD09E6763 * L_26 = (XmlValueConverter_t18B2DCDB3B3F7609F3E43D5C46D2095BD09E6763 *)__this->get_atomicConverter_32();
			RuntimeObject * L_27 = V_5;
			RuntimeTypeHandle_tC33965ADA3E041E0C94AF05E5CB527B56482CEF9  L_28 = { reinterpret_cast<intptr_t> (IL2CPP_RGCTX_TYPE(method->rgctx_data, 1)) };
			IL2CPP_RUNTIME_CLASS_INIT(Type_t_il2cpp_TypeInfo_var);
			Type_t * L_29;
			L_29 = Type_GetTypeFromHandle_m8BB57524FF7F9DB1803BC561D2B3A4DBACEB385E((RuntimeTypeHandle_tC33965ADA3E041E0C94AF05E5CB527B56482CEF9 )L_28, /*hidden argument*/NULL);
			RuntimeObject* L_30 = ___nsResolver1;
			NullCheck((XmlValueConverter_t18B2DCDB3B3F7609F3E43D5C46D2095BD09E6763 *)L_26);
			RuntimeObject * L_31;
			L_31 = VirtFuncInvoker3< RuntimeObject *, RuntimeObject *, Type_t *, RuntimeObject* >::Invoke(61 /* System.Object System.Xml.Schema.XmlValueConverter::ChangeType(System.Object,System.Type,System.Xml.IXmlNamespaceResolver) */, (XmlValueConverter_t18B2DCDB3B3F7609F3E43D5C46D2095BD09E6763 *)L_26, (RuntimeObject *)L_27, (Type_t *)L_29, (RuntimeObject*)L_30);
			NullCheck((List_1_t6726F9309570A0BDC5D42E10777F3E2931C487AA *)L_25);
			((  void (*) (List_1_t6726F9309570A0BDC5D42E10777F3E2931C487AA *, float, const RuntimeMethod*))IL2CPP_RGCTX_METHOD_INFO(method->rgctx_data, 5)->methodPointer)((List_1_t6726F9309570A0BDC5D42E10777F3E2931C487AA *)L_25, (float)((*(float*)((float*)UnBox(L_31, IL2CPP_RGCTX_DATA(method->rgctx_data, 2))))), /*hidden argument*/IL2CPP_RGCTX_METHOD_INFO(method->rgctx_data, 5));
		}

IL_0093:
		{
			RuntimeObject* L_32 = V_4;
			NullCheck((RuntimeObject*)L_32);
			bool L_33;
			L_33 = InterfaceFuncInvoker0< bool >::Invoke(0 /* System.Boolean System.Collections.IEnumerator::MoveNext() */, IEnumerator_t5956F3AFB7ECF1117E3BC5890E7FC7B7F7A04105_il2cpp_TypeInfo_var, (RuntimeObject*)L_32);
			if (L_33)
			{
				goto IL_0067;
			}
		}

IL_009c:
		{
			IL2CPP_LEAVE(0xB3, FINALLY_009e);
		}
	} // end try (depth: 1)
	catch(Il2CppExceptionWrapper& e)
	{
		__last_unhandled_exception = (Exception_t *)e.ex;
		goto FINALLY_009e;
	}

FINALLY_009e:
	{ // begin finally (depth: 1)
		{
			RuntimeObject* L_34 = V_4;
			V_6 = (RuntimeObject*)((RuntimeObject*)IsInst((RuntimeObject*)L_34, IDisposable_t099785737FC6A1E3699919A94109383715A8D807_il2cpp_TypeInfo_var));
			RuntimeObject* L_35 = V_6;
			if (!L_35)
			{
				goto IL_00b2;
			}
		}

IL_00ab:
		{
			RuntimeObject* L_36 = V_6;
			NullCheck((RuntimeObject*)L_36);
			InterfaceActionInvoker0::Invoke(0 /* System.Void System.IDisposable::Dispose() */, IDisposable_t099785737FC6A1E3699919A94109383715A8D807_il2cpp_TypeInfo_var, (RuntimeObject*)L_36);
		}

IL_00b2:
		{
			IL2CPP_END_FINALLY(158)
		}
	} // end finally (depth: 1)
	IL2CPP_CLEANUP(158)
	{
		IL2CPP_RETHROW_IF_UNHANDLED(Exception_t *)
		IL2CPP_JUMP_TBL(0xB3, IL_00b3)
	}

IL_00b3:
	{
		List_1_t6726F9309570A0BDC5D42E10777F3E2931C487AA * L_37 = V_1;
		NullCheck((List_1_t6726F9309570A0BDC5D42E10777F3E2931C487AA *)L_37);
		SingleU5BU5D_t47E8DBF5B597C122478D1FFBD9DD57399A0650FA* L_38;
		L_38 = ((  SingleU5BU5D_t47E8DBF5B597C122478D1FFBD9DD57399A0650FA* (*) (List_1_t6726F9309570A0BDC5D42E10777F3E2931C487AA *, const RuntimeMethod*))IL2CPP_RGCTX_METHOD_INFO(method->rgctx_data, 6)->methodPointer)((List_1_t6726F9309570A0BDC5D42E10777F3E2931C487AA *)L_37, /*hidden argument*/IL2CPP_RGCTX_METHOD_INFO(method->rgctx_data, 6));
		return (SingleU5BU5D_t47E8DBF5B597C122478D1FFBD9DD57399A0650FA*)L_38;
	}
}
// T[] System.Xml.Schema.XmlListConverter::ToArray<System.TimeSpan>(System.Object,System.Xml.IXmlNamespaceResolver)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR TimeSpanU5BU5D_t93A1470C8423F710E4D26493EE109A5A5920D545* XmlListConverter_ToArray_TisTimeSpan_t4F6A0E13E703B65365CFCAB58E05EE0AF3EE6203_mC083BFA043EC296F49553CC3771F3FE741CE8A15_gshared (XmlListConverter_t58F692567B1B34BF5171B647F1BE66EC017D4F4D * __this, RuntimeObject * ___list0, RuntimeObject* ___nsResolver1, const RuntimeMethod* method)
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&ICollection_tC1E1DED86C0A66845675392606B302452210D5DA_il2cpp_TypeInfo_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&IDisposable_t099785737FC6A1E3699919A94109383715A8D807_il2cpp_TypeInfo_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&IEnumerable_t47A618747A1BB2A868710316F7372094849163A2_il2cpp_TypeInfo_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&IEnumerator_t5956F3AFB7ECF1117E3BC5890E7FC7B7F7A04105_il2cpp_TypeInfo_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&IList_tB15A9D6625D09661D6E47976BB626C703EC81910_il2cpp_TypeInfo_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Type_t_il2cpp_TypeInfo_var);
		s_Il2CppMethodInitialized = true;
	}
	RuntimeObject* V_0 = NULL;
	List_1_t6CC60BBD48A742FE583491EABD97557A9B169FC3 * V_1 = NULL;
	TimeSpanU5BU5D_t93A1470C8423F710E4D26493EE109A5A5920D545* V_2 = NULL;
	int32_t V_3 = 0;
	RuntimeObject* V_4 = NULL;
	RuntimeObject * V_5 = NULL;
	RuntimeObject* V_6 = NULL;
	Exception_t * __last_unhandled_exception = 0;
	il2cpp::utils::ExceptionSupportStack<int32_t, 1> __leave_targets;
	{
		RuntimeObject * L_0 = ___list0;
		V_0 = (RuntimeObject*)((RuntimeObject*)IsInst((RuntimeObject*)L_0, IList_tB15A9D6625D09661D6E47976BB626C703EC81910_il2cpp_TypeInfo_var));
		RuntimeObject* L_1 = V_0;
		if (!L_1)
		{
			goto IL_0052;
		}
	}
	{
		RuntimeObject* L_2 = V_0;
		NullCheck((RuntimeObject*)L_2);
		int32_t L_3;
		L_3 = InterfaceFuncInvoker0< int32_t >::Invoke(1 /* System.Int32 System.Collections.ICollection::get_Count() */, ICollection_tC1E1DED86C0A66845675392606B302452210D5DA_il2cpp_TypeInfo_var, (RuntimeObject*)L_2);
		TimeSpanU5BU5D_t93A1470C8423F710E4D26493EE109A5A5920D545* L_4 = (TimeSpanU5BU5D_t93A1470C8423F710E4D26493EE109A5A5920D545*)(TimeSpanU5BU5D_t93A1470C8423F710E4D26493EE109A5A5920D545*)SZArrayNew(IL2CPP_RGCTX_DATA(method->rgctx_data, 0), (uint32_t)L_3);
		V_2 = (TimeSpanU5BU5D_t93A1470C8423F710E4D26493EE109A5A5920D545*)L_4;
		V_3 = (int32_t)0;
		goto IL_0047;
	}

IL_001a:
	{
		TimeSpanU5BU5D_t93A1470C8423F710E4D26493EE109A5A5920D545* L_5 = V_2;
		int32_t L_6 = V_3;
		XmlValueConverter_t18B2DCDB3B3F7609F3E43D5C46D2095BD09E6763 * L_7 = (XmlValueConverter_t18B2DCDB3B3F7609F3E43D5C46D2095BD09E6763 *)__this->get_atomicConverter_32();
		RuntimeObject* L_8 = V_0;
		int32_t L_9 = V_3;
		NullCheck((RuntimeObject*)L_8);
		RuntimeObject * L_10;
		L_10 = InterfaceFuncInvoker1< RuntimeObject *, int32_t >::Invoke(0 /* System.Object System.Collections.IList::get_Item(System.Int32) */, IList_tB15A9D6625D09661D6E47976BB626C703EC81910_il2cpp_TypeInfo_var, (RuntimeObject*)L_8, (int32_t)L_9);
		RuntimeTypeHandle_tC33965ADA3E041E0C94AF05E5CB527B56482CEF9  L_11 = { reinterpret_cast<intptr_t> (IL2CPP_RGCTX_TYPE(method->rgctx_data, 1)) };
		IL2CPP_RUNTIME_CLASS_INIT(Type_t_il2cpp_TypeInfo_var);
		Type_t * L_12;
		L_12 = Type_GetTypeFromHandle_m8BB57524FF7F9DB1803BC561D2B3A4DBACEB385E((RuntimeTypeHandle_tC33965ADA3E041E0C94AF05E5CB527B56482CEF9 )L_11, /*hidden argument*/NULL);
		RuntimeObject* L_13 = ___nsResolver1;
		NullCheck((XmlValueConverter_t18B2DCDB3B3F7609F3E43D5C46D2095BD09E6763 *)L_7);
		RuntimeObject * L_14;
		L_14 = VirtFuncInvoker3< RuntimeObject *, RuntimeObject *, Type_t *, RuntimeObject* >::Invoke(61 /* System.Object System.Xml.Schema.XmlValueConverter::ChangeType(System.Object,System.Type,System.Xml.IXmlNamespaceResolver) */, (XmlValueConverter_t18B2DCDB3B3F7609F3E43D5C46D2095BD09E6763 *)L_7, (RuntimeObject *)L_10, (Type_t *)L_12, (RuntimeObject*)L_13);
		NullCheck(L_5);
		(L_5)->SetAt(static_cast<il2cpp_array_size_t>(L_6), (TimeSpan_t4F6A0E13E703B65365CFCAB58E05EE0AF3EE6203 )((*(TimeSpan_t4F6A0E13E703B65365CFCAB58E05EE0AF3EE6203 *)((TimeSpan_t4F6A0E13E703B65365CFCAB58E05EE0AF3EE6203 *)UnBox(L_14, IL2CPP_RGCTX_DATA(method->rgctx_data, 2))))));
		int32_t L_15 = V_3;
		V_3 = (int32_t)((int32_t)il2cpp_codegen_add((int32_t)L_15, (int32_t)1));
	}

IL_0047:
	{
		int32_t L_16 = V_3;
		RuntimeObject* L_17 = V_0;
		NullCheck((RuntimeObject*)L_17);
		int32_t L_18;
		L_18 = InterfaceFuncInvoker0< int32_t >::Invoke(1 /* System.Int32 System.Collections.ICollection::get_Count() */, ICollection_tC1E1DED86C0A66845675392606B302452210D5DA_il2cpp_TypeInfo_var, (RuntimeObject*)L_17);
		if ((((int32_t)L_16) < ((int32_t)L_18)))
		{
			goto IL_001a;
		}
	}
	{
		TimeSpanU5BU5D_t93A1470C8423F710E4D26493EE109A5A5920D545* L_19 = V_2;
		return (TimeSpanU5BU5D_t93A1470C8423F710E4D26493EE109A5A5920D545*)L_19;
	}

IL_0052:
	{
		RuntimeObject * L_20 = ___list0;
		List_1_t6CC60BBD48A742FE583491EABD97557A9B169FC3 * L_21 = (List_1_t6CC60BBD48A742FE583491EABD97557A9B169FC3 *)il2cpp_codegen_object_new(IL2CPP_RGCTX_DATA(method->rgctx_data, 3));
		((  void (*) (List_1_t6CC60BBD48A742FE583491EABD97557A9B169FC3 *, const RuntimeMethod*))IL2CPP_RGCTX_METHOD_INFO(method->rgctx_data, 4)->methodPointer)(L_21, /*hidden argument*/IL2CPP_RGCTX_METHOD_INFO(method->rgctx_data, 4));
		V_1 = (List_1_t6CC60BBD48A742FE583491EABD97557A9B169FC3 *)L_21;
		NullCheck((RuntimeObject*)((RuntimeObject*)IsInst((RuntimeObject*)L_20, IEnumerable_t47A618747A1BB2A868710316F7372094849163A2_il2cpp_TypeInfo_var)));
		RuntimeObject* L_22;
		L_22 = InterfaceFuncInvoker0< RuntimeObject* >::Invoke(0 /* System.Collections.IEnumerator System.Collections.IEnumerable::GetEnumerator() */, IEnumerable_t47A618747A1BB2A868710316F7372094849163A2_il2cpp_TypeInfo_var, (RuntimeObject*)((RuntimeObject*)IsInst((RuntimeObject*)L_20, IEnumerable_t47A618747A1BB2A868710316F7372094849163A2_il2cpp_TypeInfo_var)));
		V_4 = (RuntimeObject*)L_22;
	}

IL_0065:
	try
	{ // begin try (depth: 1)
		{
			goto IL_0093;
		}

IL_0067:
		{
			RuntimeObject* L_23 = V_4;
			NullCheck((RuntimeObject*)L_23);
			RuntimeObject * L_24;
			L_24 = InterfaceFuncInvoker0< RuntimeObject * >::Invoke(1 /* System.Object System.Collections.IEnumerator::get_Current() */, IEnumerator_t5956F3AFB7ECF1117E3BC5890E7FC7B7F7A04105_il2cpp_TypeInfo_var, (RuntimeObject*)L_23);
			V_5 = (RuntimeObject *)L_24;
			List_1_t6CC60BBD48A742FE583491EABD97557A9B169FC3 * L_25 = V_1;
			XmlValueConverter_t18B2DCDB3B3F7609F3E43D5C46D2095BD09E6763 * L_26 = (XmlValueConverter_t18B2DCDB3B3F7609F3E43D5C46D2095BD09E6763 *)__this->get_atomicConverter_32();
			RuntimeObject * L_27 = V_5;
			RuntimeTypeHandle_tC33965ADA3E041E0C94AF05E5CB527B56482CEF9  L_28 = { reinterpret_cast<intptr_t> (IL2CPP_RGCTX_TYPE(method->rgctx_data, 1)) };
			IL2CPP_RUNTIME_CLASS_INIT(Type_t_il2cpp_TypeInfo_var);
			Type_t * L_29;
			L_29 = Type_GetTypeFromHandle_m8BB57524FF7F9DB1803BC561D2B3A4DBACEB385E((RuntimeTypeHandle_tC33965ADA3E041E0C94AF05E5CB527B56482CEF9 )L_28, /*hidden argument*/NULL);
			RuntimeObject* L_30 = ___nsResolver1;
			NullCheck((XmlValueConverter_t18B2DCDB3B3F7609F3E43D5C46D2095BD09E6763 *)L_26);
			RuntimeObject * L_31;
			L_31 = VirtFuncInvoker3< RuntimeObject *, RuntimeObject *, Type_t *, RuntimeObject* >::Invoke(61 /* System.Object System.Xml.Schema.XmlValueConverter::ChangeType(System.Object,System.Type,System.Xml.IXmlNamespaceResolver) */, (XmlValueConverter_t18B2DCDB3B3F7609F3E43D5C46D2095BD09E6763 *)L_26, (RuntimeObject *)L_27, (Type_t *)L_29, (RuntimeObject*)L_30);
			NullCheck((List_1_t6CC60BBD48A742FE583491EABD97557A9B169FC3 *)L_25);
			((  void (*) (List_1_t6CC60BBD48A742FE583491EABD97557A9B169FC3 *, TimeSpan_t4F6A0E13E703B65365CFCAB58E05EE0AF3EE6203 , const RuntimeMethod*))IL2CPP_RGCTX_METHOD_INFO(method->rgctx_data, 5)->methodPointer)((List_1_t6CC60BBD48A742FE583491EABD97557A9B169FC3 *)L_25, (TimeSpan_t4F6A0E13E703B65365CFCAB58E05EE0AF3EE6203 )((*(TimeSpan_t4F6A0E13E703B65365CFCAB58E05EE0AF3EE6203 *)((TimeSpan_t4F6A0E13E703B65365CFCAB58E05EE0AF3EE6203 *)UnBox(L_31, IL2CPP_RGCTX_DATA(method->rgctx_data, 2))))), /*hidden argument*/IL2CPP_RGCTX_METHOD_INFO(method->rgctx_data, 5));
		}

IL_0093:
		{
			RuntimeObject* L_32 = V_4;
			NullCheck((RuntimeObject*)L_32);
			bool L_33;
			L_33 = InterfaceFuncInvoker0< bool >::Invoke(0 /* System.Boolean System.Collections.IEnumerator::MoveNext() */, IEnumerator_t5956F3AFB7ECF1117E3BC5890E7FC7B7F7A04105_il2cpp_TypeInfo_var, (RuntimeObject*)L_32);
			if (L_33)
			{
				goto IL_0067;
			}
		}

IL_009c:
		{
			IL2CPP_LEAVE(0xB3, FINALLY_009e);
		}
	} // end try (depth: 1)
	catch(Il2CppExceptionWrapper& e)
	{
		__last_unhandled_exception = (Exception_t *)e.ex;
		goto FINALLY_009e;
	}

FINALLY_009e:
	{ // begin finally (depth: 1)
		{
			RuntimeObject* L_34 = V_4;
			V_6 = (RuntimeObject*)((RuntimeObject*)IsInst((RuntimeObject*)L_34, IDisposable_t099785737FC6A1E3699919A94109383715A8D807_il2cpp_TypeInfo_var));
			RuntimeObject* L_35 = V_6;
			if (!L_35)
			{
				goto IL_00b2;
			}
		}

IL_00ab:
		{
			RuntimeObject* L_36 = V_6;
			NullCheck((RuntimeObject*)L_36);
			InterfaceActionInvoker0::Invoke(0 /* System.Void System.IDisposable::Dispose() */, IDisposable_t099785737FC6A1E3699919A94109383715A8D807_il2cpp_TypeInfo_var, (RuntimeObject*)L_36);
		}

IL_00b2:
		{
			IL2CPP_END_FINALLY(158)
		}
	} // end finally (depth: 1)
	IL2CPP_CLEANUP(158)
	{
		IL2CPP_RETHROW_IF_UNHANDLED(Exception_t *)
		IL2CPP_JUMP_TBL(0xB3, IL_00b3)
	}

IL_00b3:
	{
		List_1_t6CC60BBD48A742FE583491EABD97557A9B169FC3 * L_37 = V_1;
		NullCheck((List_1_t6CC60BBD48A742FE583491EABD97557A9B169FC3 *)L_37);
		TimeSpanU5BU5D_t93A1470C8423F710E4D26493EE109A5A5920D545* L_38;
		L_38 = ((  TimeSpanU5BU5D_t93A1470C8423F710E4D26493EE109A5A5920D545* (*) (List_1_t6CC60BBD48A742FE583491EABD97557A9B169FC3 *, const RuntimeMethod*))IL2CPP_RGCTX_METHOD_INFO(method->rgctx_data, 6)->methodPointer)((List_1_t6CC60BBD48A742FE583491EABD97557A9B169FC3 *)L_37, /*hidden argument*/IL2CPP_RGCTX_METHOD_INFO(method->rgctx_data, 6));
		return (TimeSpanU5BU5D_t93A1470C8423F710E4D26493EE109A5A5920D545*)L_38;
	}
}
// T[] System.Xml.Schema.XmlListConverter::ToArray<System.UInt16>(System.Object,System.Xml.IXmlNamespaceResolver)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR UInt16U5BU5D_t42D35C587B07DCDBCFDADF572C6D733AE85B2A67* XmlListConverter_ToArray_TisUInt16_t894EA9D4FB7C799B244E7BBF2DF0EEEDBC77A8BD_m586B58E3697C0A2474F4154812CF23D753E69482_gshared (XmlListConverter_t58F692567B1B34BF5171B647F1BE66EC017D4F4D * __this, RuntimeObject * ___list0, RuntimeObject* ___nsResolver1, const RuntimeMethod* method)
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&ICollection_tC1E1DED86C0A66845675392606B302452210D5DA_il2cpp_TypeInfo_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&IDisposable_t099785737FC6A1E3699919A94109383715A8D807_il2cpp_TypeInfo_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&IEnumerable_t47A618747A1BB2A868710316F7372094849163A2_il2cpp_TypeInfo_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&IEnumerator_t5956F3AFB7ECF1117E3BC5890E7FC7B7F7A04105_il2cpp_TypeInfo_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&IList_tB15A9D6625D09661D6E47976BB626C703EC81910_il2cpp_TypeInfo_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Type_t_il2cpp_TypeInfo_var);
		s_Il2CppMethodInitialized = true;
	}
	RuntimeObject* V_0 = NULL;
	List_1_tBBC4E953860E582A3E060CC10B1387AFC5A36FC5 * V_1 = NULL;
	UInt16U5BU5D_t42D35C587B07DCDBCFDADF572C6D733AE85B2A67* V_2 = NULL;
	int32_t V_3 = 0;
	RuntimeObject* V_4 = NULL;
	RuntimeObject * V_5 = NULL;
	RuntimeObject* V_6 = NULL;
	Exception_t * __last_unhandled_exception = 0;
	il2cpp::utils::ExceptionSupportStack<int32_t, 1> __leave_targets;
	{
		RuntimeObject * L_0 = ___list0;
		V_0 = (RuntimeObject*)((RuntimeObject*)IsInst((RuntimeObject*)L_0, IList_tB15A9D6625D09661D6E47976BB626C703EC81910_il2cpp_TypeInfo_var));
		RuntimeObject* L_1 = V_0;
		if (!L_1)
		{
			goto IL_0052;
		}
	}
	{
		RuntimeObject* L_2 = V_0;
		NullCheck((RuntimeObject*)L_2);
		int32_t L_3;
		L_3 = InterfaceFuncInvoker0< int32_t >::Invoke(1 /* System.Int32 System.Collections.ICollection::get_Count() */, ICollection_tC1E1DED86C0A66845675392606B302452210D5DA_il2cpp_TypeInfo_var, (RuntimeObject*)L_2);
		UInt16U5BU5D_t42D35C587B07DCDBCFDADF572C6D733AE85B2A67* L_4 = (UInt16U5BU5D_t42D35C587B07DCDBCFDADF572C6D733AE85B2A67*)(UInt16U5BU5D_t42D35C587B07DCDBCFDADF572C6D733AE85B2A67*)SZArrayNew(IL2CPP_RGCTX_DATA(method->rgctx_data, 0), (uint32_t)L_3);
		V_2 = (UInt16U5BU5D_t42D35C587B07DCDBCFDADF572C6D733AE85B2A67*)L_4;
		V_3 = (int32_t)0;
		goto IL_0047;
	}

IL_001a:
	{
		UInt16U5BU5D_t42D35C587B07DCDBCFDADF572C6D733AE85B2A67* L_5 = V_2;
		int32_t L_6 = V_3;
		XmlValueConverter_t18B2DCDB3B3F7609F3E43D5C46D2095BD09E6763 * L_7 = (XmlValueConverter_t18B2DCDB3B3F7609F3E43D5C46D2095BD09E6763 *)__this->get_atomicConverter_32();
		RuntimeObject* L_8 = V_0;
		int32_t L_9 = V_3;
		NullCheck((RuntimeObject*)L_8);
		RuntimeObject * L_10;
		L_10 = InterfaceFuncInvoker1< RuntimeObject *, int32_t >::Invoke(0 /* System.Object System.Collections.IList::get_Item(System.Int32) */, IList_tB15A9D6625D09661D6E47976BB626C703EC81910_il2cpp_TypeInfo_var, (RuntimeObject*)L_8, (int32_t)L_9);
		RuntimeTypeHandle_tC33965ADA3E041E0C94AF05E5CB527B56482CEF9  L_11 = { reinterpret_cast<intptr_t> (IL2CPP_RGCTX_TYPE(method->rgctx_data, 1)) };
		IL2CPP_RUNTIME_CLASS_INIT(Type_t_il2cpp_TypeInfo_var);
		Type_t * L_12;
		L_12 = Type_GetTypeFromHandle_m8BB57524FF7F9DB1803BC561D2B3A4DBACEB385E((RuntimeTypeHandle_tC33965ADA3E041E0C94AF05E5CB527B56482CEF9 )L_11, /*hidden argument*/NULL);
		RuntimeObject* L_13 = ___nsResolver1;
		NullCheck((XmlValueConverter_t18B2DCDB3B3F7609F3E43D5C46D2095BD09E6763 *)L_7);
		RuntimeObject * L_14;
		L_14 = VirtFuncInvoker3< RuntimeObject *, RuntimeObject *, Type_t *, RuntimeObject* >::Invoke(61 /* System.Object System.Xml.Schema.XmlValueConverter::ChangeType(System.Object,System.Type,System.Xml.IXmlNamespaceResolver) */, (XmlValueConverter_t18B2DCDB3B3F7609F3E43D5C46D2095BD09E6763 *)L_7, (RuntimeObject *)L_10, (Type_t *)L_12, (RuntimeObject*)L_13);
		NullCheck(L_5);
		(L_5)->SetAt(static_cast<il2cpp_array_size_t>(L_6), (uint16_t)((*(uint16_t*)((uint16_t*)UnBox(L_14, IL2CPP_RGCTX_DATA(method->rgctx_data, 2))))));
		int32_t L_15 = V_3;
		V_3 = (int32_t)((int32_t)il2cpp_codegen_add((int32_t)L_15, (int32_t)1));
	}

IL_0047:
	{
		int32_t L_16 = V_3;
		RuntimeObject* L_17 = V_0;
		NullCheck((RuntimeObject*)L_17);
		int32_t L_18;
		L_18 = InterfaceFuncInvoker0< int32_t >::Invoke(1 /* System.Int32 System.Collections.ICollection::get_Count() */, ICollection_tC1E1DED86C0A66845675392606B302452210D5DA_il2cpp_TypeInfo_var, (RuntimeObject*)L_17);
		if ((((int32_t)L_16) < ((int32_t)L_18)))
		{
			goto IL_001a;
		}
	}
	{
		UInt16U5BU5D_t42D35C587B07DCDBCFDADF572C6D733AE85B2A67* L_19 = V_2;
		return (UInt16U5BU5D_t42D35C587B07DCDBCFDADF572C6D733AE85B2A67*)L_19;
	}

IL_0052:
	{
		RuntimeObject * L_20 = ___list0;
		List_1_tBBC4E953860E582A3E060CC10B1387AFC5A36FC5 * L_21 = (List_1_tBBC4E953860E582A3E060CC10B1387AFC5A36FC5 *)il2cpp_codegen_object_new(IL2CPP_RGCTX_DATA(method->rgctx_data, 3));
		((  void (*) (List_1_tBBC4E953860E582A3E060CC10B1387AFC5A36FC5 *, const RuntimeMethod*))IL2CPP_RGCTX_METHOD_INFO(method->rgctx_data, 4)->methodPointer)(L_21, /*hidden argument*/IL2CPP_RGCTX_METHOD_INFO(method->rgctx_data, 4));
		V_1 = (List_1_tBBC4E953860E582A3E060CC10B1387AFC5A36FC5 *)L_21;
		NullCheck((RuntimeObject*)((RuntimeObject*)IsInst((RuntimeObject*)L_20, IEnumerable_t47A618747A1BB2A868710316F7372094849163A2_il2cpp_TypeInfo_var)));
		RuntimeObject* L_22;
		L_22 = InterfaceFuncInvoker0< RuntimeObject* >::Invoke(0 /* System.Collections.IEnumerator System.Collections.IEnumerable::GetEnumerator() */, IEnumerable_t47A618747A1BB2A868710316F7372094849163A2_il2cpp_TypeInfo_var, (RuntimeObject*)((RuntimeObject*)IsInst((RuntimeObject*)L_20, IEnumerable_t47A618747A1BB2A868710316F7372094849163A2_il2cpp_TypeInfo_var)));
		V_4 = (RuntimeObject*)L_22;
	}

IL_0065:
	try
	{ // begin try (depth: 1)
		{
			goto IL_0093;
		}

IL_0067:
		{
			RuntimeObject* L_23 = V_4;
			NullCheck((RuntimeObject*)L_23);
			RuntimeObject * L_24;
			L_24 = InterfaceFuncInvoker0< RuntimeObject * >::Invoke(1 /* System.Object System.Collections.IEnumerator::get_Current() */, IEnumerator_t5956F3AFB7ECF1117E3BC5890E7FC7B7F7A04105_il2cpp_TypeInfo_var, (RuntimeObject*)L_23);
			V_5 = (RuntimeObject *)L_24;
			List_1_tBBC4E953860E582A3E060CC10B1387AFC5A36FC5 * L_25 = V_1;
			XmlValueConverter_t18B2DCDB3B3F7609F3E43D5C46D2095BD09E6763 * L_26 = (XmlValueConverter_t18B2DCDB3B3F7609F3E43D5C46D2095BD09E6763 *)__this->get_atomicConverter_32();
			RuntimeObject * L_27 = V_5;
			RuntimeTypeHandle_tC33965ADA3E041E0C94AF05E5CB527B56482CEF9  L_28 = { reinterpret_cast<intptr_t> (IL2CPP_RGCTX_TYPE(method->rgctx_data, 1)) };
			IL2CPP_RUNTIME_CLASS_INIT(Type_t_il2cpp_TypeInfo_var);
			Type_t * L_29;
			L_29 = Type_GetTypeFromHandle_m8BB57524FF7F9DB1803BC561D2B3A4DBACEB385E((RuntimeTypeHandle_tC33965ADA3E041E0C94AF05E5CB527B56482CEF9 )L_28, /*hidden argument*/NULL);
			RuntimeObject* L_30 = ___nsResolver1;
			NullCheck((XmlValueConverter_t18B2DCDB3B3F7609F3E43D5C46D2095BD09E6763 *)L_26);
			RuntimeObject * L_31;
			L_31 = VirtFuncInvoker3< RuntimeObject *, RuntimeObject *, Type_t *, RuntimeObject* >::Invoke(61 /* System.Object System.Xml.Schema.XmlValueConverter::ChangeType(System.Object,System.Type,System.Xml.IXmlNamespaceResolver) */, (XmlValueConverter_t18B2DCDB3B3F7609F3E43D5C46D2095BD09E6763 *)L_26, (RuntimeObject *)L_27, (Type_t *)L_29, (RuntimeObject*)L_30);
			NullCheck((List_1_tBBC4E953860E582A3E060CC10B1387AFC5A36FC5 *)L_25);
			((  void (*) (List_1_tBBC4E953860E582A3E060CC10B1387AFC5A36FC5 *, uint16_t, const RuntimeMethod*))IL2CPP_RGCTX_METHOD_INFO(method->rgctx_data, 5)->methodPointer)((List_1_tBBC4E953860E582A3E060CC10B1387AFC5A36FC5 *)L_25, (uint16_t)((*(uint16_t*)((uint16_t*)UnBox(L_31, IL2CPP_RGCTX_DATA(method->rgctx_data, 2))))), /*hidden argument*/IL2CPP_RGCTX_METHOD_INFO(method->rgctx_data, 5));
		}

IL_0093:
		{
			RuntimeObject* L_32 = V_4;
			NullCheck((RuntimeObject*)L_32);
			bool L_33;
			L_33 = InterfaceFuncInvoker0< bool >::Invoke(0 /* System.Boolean System.Collections.IEnumerator::MoveNext() */, IEnumerator_t5956F3AFB7ECF1117E3BC5890E7FC7B7F7A04105_il2cpp_TypeInfo_var, (RuntimeObject*)L_32);
			if (L_33)
			{
				goto IL_0067;
			}
		}

IL_009c:
		{
			IL2CPP_LEAVE(0xB3, FINALLY_009e);
		}
	} // end try (depth: 1)
	catch(Il2CppExceptionWrapper& e)
	{
		__last_unhandled_exception = (Exception_t *)e.ex;
		goto FINALLY_009e;
	}

FINALLY_009e:
	{ // begin finally (depth: 1)
		{
			RuntimeObject* L_34 = V_4;
			V_6 = (RuntimeObject*)((RuntimeObject*)IsInst((RuntimeObject*)L_34, IDisposable_t099785737FC6A1E3699919A94109383715A8D807_il2cpp_TypeInfo_var));
			RuntimeObject* L_35 = V_6;
			if (!L_35)
			{
				goto IL_00b2;
			}
		}

IL_00ab:
		{
			RuntimeObject* L_36 = V_6;
			NullCheck((RuntimeObject*)L_36);
			InterfaceActionInvoker0::Invoke(0 /* System.Void System.IDisposable::Dispose() */, IDisposable_t099785737FC6A1E3699919A94109383715A8D807_il2cpp_TypeInfo_var, (RuntimeObject*)L_36);
		}

IL_00b2:
		{
			IL2CPP_END_FINALLY(158)
		}
	} // end finally (depth: 1)
	IL2CPP_CLEANUP(158)
	{
		IL2CPP_RETHROW_IF_UNHANDLED(Exception_t *)
		IL2CPP_JUMP_TBL(0xB3, IL_00b3)
	}

IL_00b3:
	{
		List_1_tBBC4E953860E582A3E060CC10B1387AFC5A36FC5 * L_37 = V_1;
		NullCheck((List_1_tBBC4E953860E582A3E060CC10B1387AFC5A36FC5 *)L_37);
		UInt16U5BU5D_t42D35C587B07DCDBCFDADF572C6D733AE85B2A67* L_38;
		L_38 = ((  UInt16U5BU5D_t42D35C587B07DCDBCFDADF572C6D733AE85B2A67* (*) (List_1_tBBC4E953860E582A3E060CC10B1387AFC5A36FC5 *, const RuntimeMethod*))IL2CPP_RGCTX_METHOD_INFO(method->rgctx_data, 6)->methodPointer)((List_1_tBBC4E953860E582A3E060CC10B1387AFC5A36FC5 *)L_37, /*hidden argument*/IL2CPP_RGCTX_METHOD_INFO(method->rgctx_data, 6));
		return (UInt16U5BU5D_t42D35C587B07DCDBCFDADF572C6D733AE85B2A67*)L_38;
	}
}
// T[] System.Xml.Schema.XmlListConverter::ToArray<System.UInt32>(System.Object,System.Xml.IXmlNamespaceResolver)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR UInt32U5BU5D_tCF06F1E9E72E0302C762578FF5358CC523F2A2CF* XmlListConverter_ToArray_TisUInt32_tE60352A06233E4E69DD198BCC67142159F686B15_m5307DF081EBEE484E60F40EB50C8D20BDB43AE96_gshared (XmlListConverter_t58F692567B1B34BF5171B647F1BE66EC017D4F4D * __this, RuntimeObject * ___list0, RuntimeObject* ___nsResolver1, const RuntimeMethod* method)
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&ICollection_tC1E1DED86C0A66845675392606B302452210D5DA_il2cpp_TypeInfo_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&IDisposable_t099785737FC6A1E3699919A94109383715A8D807_il2cpp_TypeInfo_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&IEnumerable_t47A618747A1BB2A868710316F7372094849163A2_il2cpp_TypeInfo_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&IEnumerator_t5956F3AFB7ECF1117E3BC5890E7FC7B7F7A04105_il2cpp_TypeInfo_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&IList_tB15A9D6625D09661D6E47976BB626C703EC81910_il2cpp_TypeInfo_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Type_t_il2cpp_TypeInfo_var);
		s_Il2CppMethodInitialized = true;
	}
	RuntimeObject* V_0 = NULL;
	List_1_t023026A8F0D0D113E2B62213C8C74717BF7F4731 * V_1 = NULL;
	UInt32U5BU5D_tCF06F1E9E72E0302C762578FF5358CC523F2A2CF* V_2 = NULL;
	int32_t V_3 = 0;
	RuntimeObject* V_4 = NULL;
	RuntimeObject * V_5 = NULL;
	RuntimeObject* V_6 = NULL;
	Exception_t * __last_unhandled_exception = 0;
	il2cpp::utils::ExceptionSupportStack<int32_t, 1> __leave_targets;
	{
		RuntimeObject * L_0 = ___list0;
		V_0 = (RuntimeObject*)((RuntimeObject*)IsInst((RuntimeObject*)L_0, IList_tB15A9D6625D09661D6E47976BB626C703EC81910_il2cpp_TypeInfo_var));
		RuntimeObject* L_1 = V_0;
		if (!L_1)
		{
			goto IL_0052;
		}
	}
	{
		RuntimeObject* L_2 = V_0;
		NullCheck((RuntimeObject*)L_2);
		int32_t L_3;
		L_3 = InterfaceFuncInvoker0< int32_t >::Invoke(1 /* System.Int32 System.Collections.ICollection::get_Count() */, ICollection_tC1E1DED86C0A66845675392606B302452210D5DA_il2cpp_TypeInfo_var, (RuntimeObject*)L_2);
		UInt32U5BU5D_tCF06F1E9E72E0302C762578FF5358CC523F2A2CF* L_4 = (UInt32U5BU5D_tCF06F1E9E72E0302C762578FF5358CC523F2A2CF*)(UInt32U5BU5D_tCF06F1E9E72E0302C762578FF5358CC523F2A2CF*)SZArrayNew(IL2CPP_RGCTX_DATA(method->rgctx_data, 0), (uint32_t)L_3);
		V_2 = (UInt32U5BU5D_tCF06F1E9E72E0302C762578FF5358CC523F2A2CF*)L_4;
		V_3 = (int32_t)0;
		goto IL_0047;
	}

IL_001a:
	{
		UInt32U5BU5D_tCF06F1E9E72E0302C762578FF5358CC523F2A2CF* L_5 = V_2;
		int32_t L_6 = V_3;
		XmlValueConverter_t18B2DCDB3B3F7609F3E43D5C46D2095BD09E6763 * L_7 = (XmlValueConverter_t18B2DCDB3B3F7609F3E43D5C46D2095BD09E6763 *)__this->get_atomicConverter_32();
		RuntimeObject* L_8 = V_0;
		int32_t L_9 = V_3;
		NullCheck((RuntimeObject*)L_8);
		RuntimeObject * L_10;
		L_10 = InterfaceFuncInvoker1< RuntimeObject *, int32_t >::Invoke(0 /* System.Object System.Collections.IList::get_Item(System.Int32) */, IList_tB15A9D6625D09661D6E47976BB626C703EC81910_il2cpp_TypeInfo_var, (RuntimeObject*)L_8, (int32_t)L_9);
		RuntimeTypeHandle_tC33965ADA3E041E0C94AF05E5CB527B56482CEF9  L_11 = { reinterpret_cast<intptr_t> (IL2CPP_RGCTX_TYPE(method->rgctx_data, 1)) };
		IL2CPP_RUNTIME_CLASS_INIT(Type_t_il2cpp_TypeInfo_var);
		Type_t * L_12;
		L_12 = Type_GetTypeFromHandle_m8BB57524FF7F9DB1803BC561D2B3A4DBACEB385E((RuntimeTypeHandle_tC33965ADA3E041E0C94AF05E5CB527B56482CEF9 )L_11, /*hidden argument*/NULL);
		RuntimeObject* L_13 = ___nsResolver1;
		NullCheck((XmlValueConverter_t18B2DCDB3B3F7609F3E43D5C46D2095BD09E6763 *)L_7);
		RuntimeObject * L_14;
		L_14 = VirtFuncInvoker3< RuntimeObject *, RuntimeObject *, Type_t *, RuntimeObject* >::Invoke(61 /* System.Object System.Xml.Schema.XmlValueConverter::ChangeType(System.Object,System.Type,System.Xml.IXmlNamespaceResolver) */, (XmlValueConverter_t18B2DCDB3B3F7609F3E43D5C46D2095BD09E6763 *)L_7, (RuntimeObject *)L_10, (Type_t *)L_12, (RuntimeObject*)L_13);
		NullCheck(L_5);
		(L_5)->SetAt(static_cast<il2cpp_array_size_t>(L_6), (uint32_t)((*(uint32_t*)((uint32_t*)UnBox(L_14, IL2CPP_RGCTX_DATA(method->rgctx_data, 2))))));
		int32_t L_15 = V_3;
		V_3 = (int32_t)((int32_t)il2cpp_codegen_add((int32_t)L_15, (int32_t)1));
	}

IL_0047:
	{
		int32_t L_16 = V_3;
		RuntimeObject* L_17 = V_0;
		NullCheck((RuntimeObject*)L_17);
		int32_t L_18;
		L_18 = InterfaceFuncInvoker0< int32_t >::Invoke(1 /* System.Int32 System.Collections.ICollection::get_Count() */, ICollection_tC1E1DED86C0A66845675392606B302452210D5DA_il2cpp_TypeInfo_var, (RuntimeObject*)L_17);
		if ((((int32_t)L_16) < ((int32_t)L_18)))
		{
			goto IL_001a;
		}
	}
	{
		UInt32U5BU5D_tCF06F1E9E72E0302C762578FF5358CC523F2A2CF* L_19 = V_2;
		return (UInt32U5BU5D_tCF06F1E9E72E0302C762578FF5358CC523F2A2CF*)L_19;
	}

IL_0052:
	{
		RuntimeObject * L_20 = ___list0;
		List_1_t023026A8F0D0D113E2B62213C8C74717BF7F4731 * L_21 = (List_1_t023026A8F0D0D113E2B62213C8C74717BF7F4731 *)il2cpp_codegen_object_new(IL2CPP_RGCTX_DATA(method->rgctx_data, 3));
		((  void (*) (List_1_t023026A8F0D0D113E2B62213C8C74717BF7F4731 *, const RuntimeMethod*))IL2CPP_RGCTX_METHOD_INFO(method->rgctx_data, 4)->methodPointer)(L_21, /*hidden argument*/IL2CPP_RGCTX_METHOD_INFO(method->rgctx_data, 4));
		V_1 = (List_1_t023026A8F0D0D113E2B62213C8C74717BF7F4731 *)L_21;
		NullCheck((RuntimeObject*)((RuntimeObject*)IsInst((RuntimeObject*)L_20, IEnumerable_t47A618747A1BB2A868710316F7372094849163A2_il2cpp_TypeInfo_var)));
		RuntimeObject* L_22;
		L_22 = InterfaceFuncInvoker0< RuntimeObject* >::Invoke(0 /* System.Collections.IEnumerator System.Collections.IEnumerable::GetEnumerator() */, IEnumerable_t47A618747A1BB2A868710316F7372094849163A2_il2cpp_TypeInfo_var, (RuntimeObject*)((RuntimeObject*)IsInst((RuntimeObject*)L_20, IEnumerable_t47A618747A1BB2A868710316F7372094849163A2_il2cpp_TypeInfo_var)));
		V_4 = (RuntimeObject*)L_22;
	}

IL_0065:
	try
	{ // begin try (depth: 1)
		{
			goto IL_0093;
		}

IL_0067:
		{
			RuntimeObject* L_23 = V_4;
			NullCheck((RuntimeObject*)L_23);
			RuntimeObject * L_24;
			L_24 = InterfaceFuncInvoker0< RuntimeObject * >::Invoke(1 /* System.Object System.Collections.IEnumerator::get_Current() */, IEnumerator_t5956F3AFB7ECF1117E3BC5890E7FC7B7F7A04105_il2cpp_TypeInfo_var, (RuntimeObject*)L_23);
			V_5 = (RuntimeObject *)L_24;
			List_1_t023026A8F0D0D113E2B62213C8C74717BF7F4731 * L_25 = V_1;
			XmlValueConverter_t18B2DCDB3B3F7609F3E43D5C46D2095BD09E6763 * L_26 = (XmlValueConverter_t18B2DCDB3B3F7609F3E43D5C46D2095BD09E6763 *)__this->get_atomicConverter_32();
			RuntimeObject * L_27 = V_5;
			RuntimeTypeHandle_tC33965ADA3E041E0C94AF05E5CB527B56482CEF9  L_28 = { reinterpret_cast<intptr_t> (IL2CPP_RGCTX_TYPE(method->rgctx_data, 1)) };
			IL2CPP_RUNTIME_CLASS_INIT(Type_t_il2cpp_TypeInfo_var);
			Type_t * L_29;
			L_29 = Type_GetTypeFromHandle_m8BB57524FF7F9DB1803BC561D2B3A4DBACEB385E((RuntimeTypeHandle_tC33965ADA3E041E0C94AF05E5CB527B56482CEF9 )L_28, /*hidden argument*/NULL);
			RuntimeObject* L_30 = ___nsResolver1;
			NullCheck((XmlValueConverter_t18B2DCDB3B3F7609F3E43D5C46D2095BD09E6763 *)L_26);
			RuntimeObject * L_31;
			L_31 = VirtFuncInvoker3< RuntimeObject *, RuntimeObject *, Type_t *, RuntimeObject* >::Invoke(61 /* System.Object System.Xml.Schema.XmlValueConverter::ChangeType(System.Object,System.Type,System.Xml.IXmlNamespaceResolver) */, (XmlValueConverter_t18B2DCDB3B3F7609F3E43D5C46D2095BD09E6763 *)L_26, (RuntimeObject *)L_27, (Type_t *)L_29, (RuntimeObject*)L_30);
			NullCheck((List_1_t023026A8F0D0D113E2B62213C8C74717BF7F4731 *)L_25);
			((  void (*) (List_1_t023026A8F0D0D113E2B62213C8C74717BF7F4731 *, uint32_t, const RuntimeMethod*))IL2CPP_RGCTX_METHOD_INFO(method->rgctx_data, 5)->methodPointer)((List_1_t023026A8F0D0D113E2B62213C8C74717BF7F4731 *)L_25, (uint32_t)((*(uint32_t*)((uint32_t*)UnBox(L_31, IL2CPP_RGCTX_DATA(method->rgctx_data, 2))))), /*hidden argument*/IL2CPP_RGCTX_METHOD_INFO(method->rgctx_data, 5));
		}

IL_0093:
		{
			RuntimeObject* L_32 = V_4;
			NullCheck((RuntimeObject*)L_32);
			bool L_33;
			L_33 = InterfaceFuncInvoker0< bool >::Invoke(0 /* System.Boolean System.Collections.IEnumerator::MoveNext() */, IEnumerator_t5956F3AFB7ECF1117E3BC5890E7FC7B7F7A04105_il2cpp_TypeInfo_var, (RuntimeObject*)L_32);
			if (L_33)
			{
				goto IL_0067;
			}
		}

IL_009c:
		{
			IL2CPP_LEAVE(0xB3, FINALLY_009e);
		}
	} // end try (depth: 1)
	catch(Il2CppExceptionWrapper& e)
	{
		__last_unhandled_exception = (Exception_t *)e.ex;
		goto FINALLY_009e;
	}

FINALLY_009e:
	{ // begin finally (depth: 1)
		{
			RuntimeObject* L_34 = V_4;
			V_6 = (RuntimeObject*)((RuntimeObject*)IsInst((RuntimeObject*)L_34, IDisposable_t099785737FC6A1E3699919A94109383715A8D807_il2cpp_TypeInfo_var));
			RuntimeObject* L_35 = V_6;
			if (!L_35)
			{
				goto IL_00b2;
			}
		}

IL_00ab:
		{
			RuntimeObject* L_36 = V_6;
			NullCheck((RuntimeObject*)L_36);
			InterfaceActionInvoker0::Invoke(0 /* System.Void System.IDisposable::Dispose() */, IDisposable_t099785737FC6A1E3699919A94109383715A8D807_il2cpp_TypeInfo_var, (RuntimeObject*)L_36);
		}

IL_00b2:
		{
			IL2CPP_END_FINALLY(158)
		}
	} // end finally (depth: 1)
	IL2CPP_CLEANUP(158)
	{
		IL2CPP_RETHROW_IF_UNHANDLED(Exception_t *)
		IL2CPP_JUMP_TBL(0xB3, IL_00b3)
	}

IL_00b3:
	{
		List_1_t023026A8F0D0D113E2B62213C8C74717BF7F4731 * L_37 = V_1;
		NullCheck((List_1_t023026A8F0D0D113E2B62213C8C74717BF7F4731 *)L_37);
		UInt32U5BU5D_tCF06F1E9E72E0302C762578FF5358CC523F2A2CF* L_38;
		L_38 = ((  UInt32U5BU5D_tCF06F1E9E72E0302C762578FF5358CC523F2A2CF* (*) (List_1_t023026A8F0D0D113E2B62213C8C74717BF7F4731 *, const RuntimeMethod*))IL2CPP_RGCTX_METHOD_INFO(method->rgctx_data, 6)->methodPointer)((List_1_t023026A8F0D0D113E2B62213C8C74717BF7F4731 *)L_37, /*hidden argument*/IL2CPP_RGCTX_METHOD_INFO(method->rgctx_data, 6));
		return (UInt32U5BU5D_tCF06F1E9E72E0302C762578FF5358CC523F2A2CF*)L_38;
	}
}
// T[] System.Xml.Schema.XmlListConverter::ToArray<System.UInt64>(System.Object,System.Xml.IXmlNamespaceResolver)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR UInt64U5BU5D_t7C6E32D10F47677C1CEF3C30F4E4CE95B3A633E2* XmlListConverter_ToArray_TisUInt64_tEC57511B3E3CA2DBA1BEBD434C6983E31C943281_mB1B5B6225DD0325B4EFED267FCF77EAAE38B4B1C_gshared (XmlListConverter_t58F692567B1B34BF5171B647F1BE66EC017D4F4D * __this, RuntimeObject * ___list0, RuntimeObject* ___nsResolver1, const RuntimeMethod* method)
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&ICollection_tC1E1DED86C0A66845675392606B302452210D5DA_il2cpp_TypeInfo_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&IDisposable_t099785737FC6A1E3699919A94109383715A8D807_il2cpp_TypeInfo_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&IEnumerable_t47A618747A1BB2A868710316F7372094849163A2_il2cpp_TypeInfo_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&IEnumerator_t5956F3AFB7ECF1117E3BC5890E7FC7B7F7A04105_il2cpp_TypeInfo_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&IList_tB15A9D6625D09661D6E47976BB626C703EC81910_il2cpp_TypeInfo_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Type_t_il2cpp_TypeInfo_var);
		s_Il2CppMethodInitialized = true;
	}
	RuntimeObject* V_0 = NULL;
	List_1_t1F1C2C7D92FB6DF4FCD88B0AB0919AEAB3B45F6B * V_1 = NULL;
	UInt64U5BU5D_t7C6E32D10F47677C1CEF3C30F4E4CE95B3A633E2* V_2 = NULL;
	int32_t V_3 = 0;
	RuntimeObject* V_4 = NULL;
	RuntimeObject * V_5 = NULL;
	RuntimeObject* V_6 = NULL;
	Exception_t * __last_unhandled_exception = 0;
	il2cpp::utils::ExceptionSupportStack<int32_t, 1> __leave_targets;
	{
		RuntimeObject * L_0 = ___list0;
		V_0 = (RuntimeObject*)((RuntimeObject*)IsInst((RuntimeObject*)L_0, IList_tB15A9D6625D09661D6E47976BB626C703EC81910_il2cpp_TypeInfo_var));
		RuntimeObject* L_1 = V_0;
		if (!L_1)
		{
			goto IL_0052;
		}
	}
	{
		RuntimeObject* L_2 = V_0;
		NullCheck((RuntimeObject*)L_2);
		int32_t L_3;
		L_3 = InterfaceFuncInvoker0< int32_t >::Invoke(1 /* System.Int32 System.Collections.ICollection::get_Count() */, ICollection_tC1E1DED86C0A66845675392606B302452210D5DA_il2cpp_TypeInfo_var, (RuntimeObject*)L_2);
		UInt64U5BU5D_t7C6E32D10F47677C1CEF3C30F4E4CE95B3A633E2* L_4 = (UInt64U5BU5D_t7C6E32D10F47677C1CEF3C30F4E4CE95B3A633E2*)(UInt64U5BU5D_t7C6E32D10F47677C1CEF3C30F4E4CE95B3A633E2*)SZArrayNew(IL2CPP_RGCTX_DATA(method->rgctx_data, 0), (uint32_t)L_3);
		V_2 = (UInt64U5BU5D_t7C6E32D10F47677C1CEF3C30F4E4CE95B3A633E2*)L_4;
		V_3 = (int32_t)0;
		goto IL_0047;
	}

IL_001a:
	{
		UInt64U5BU5D_t7C6E32D10F47677C1CEF3C30F4E4CE95B3A633E2* L_5 = V_2;
		int32_t L_6 = V_3;
		XmlValueConverter_t18B2DCDB3B3F7609F3E43D5C46D2095BD09E6763 * L_7 = (XmlValueConverter_t18B2DCDB3B3F7609F3E43D5C46D2095BD09E6763 *)__this->get_atomicConverter_32();
		RuntimeObject* L_8 = V_0;
		int32_t L_9 = V_3;
		NullCheck((RuntimeObject*)L_8);
		RuntimeObject * L_10;
		L_10 = InterfaceFuncInvoker1< RuntimeObject *, int32_t >::Invoke(0 /* System.Object System.Collections.IList::get_Item(System.Int32) */, IList_tB15A9D6625D09661D6E47976BB626C703EC81910_il2cpp_TypeInfo_var, (RuntimeObject*)L_8, (int32_t)L_9);
		RuntimeTypeHandle_tC33965ADA3E041E0C94AF05E5CB527B56482CEF9  L_11 = { reinterpret_cast<intptr_t> (IL2CPP_RGCTX_TYPE(method->rgctx_data, 1)) };
		IL2CPP_RUNTIME_CLASS_INIT(Type_t_il2cpp_TypeInfo_var);
		Type_t * L_12;
		L_12 = Type_GetTypeFromHandle_m8BB57524FF7F9DB1803BC561D2B3A4DBACEB385E((RuntimeTypeHandle_tC33965ADA3E041E0C94AF05E5CB527B56482CEF9 )L_11, /*hidden argument*/NULL);
		RuntimeObject* L_13 = ___nsResolver1;
		NullCheck((XmlValueConverter_t18B2DCDB3B3F7609F3E43D5C46D2095BD09E6763 *)L_7);
		RuntimeObject * L_14;
		L_14 = VirtFuncInvoker3< RuntimeObject *, RuntimeObject *, Type_t *, RuntimeObject* >::Invoke(61 /* System.Object System.Xml.Schema.XmlValueConverter::ChangeType(System.Object,System.Type,System.Xml.IXmlNamespaceResolver) */, (XmlValueConverter_t18B2DCDB3B3F7609F3E43D5C46D2095BD09E6763 *)L_7, (RuntimeObject *)L_10, (Type_t *)L_12, (RuntimeObject*)L_13);
		NullCheck(L_5);
		(L_5)->SetAt(static_cast<il2cpp_array_size_t>(L_6), (uint64_t)((*(uint64_t*)((uint64_t*)UnBox(L_14, IL2CPP_RGCTX_DATA(method->rgctx_data, 2))))));
		int32_t L_15 = V_3;
		V_3 = (int32_t)((int32_t)il2cpp_codegen_add((int32_t)L_15, (int32_t)1));
	}

IL_0047:
	{
		int32_t L_16 = V_3;
		RuntimeObject* L_17 = V_0;
		NullCheck((RuntimeObject*)L_17);
		int32_t L_18;
		L_18 = InterfaceFuncInvoker0< int32_t >::Invoke(1 /* System.Int32 System.Collections.ICollection::get_Count() */, ICollection_tC1E1DED86C0A66845675392606B302452210D5DA_il2cpp_TypeInfo_var, (RuntimeObject*)L_17);
		if ((((int32_t)L_16) < ((int32_t)L_18)))
		{
			goto IL_001a;
		}
	}
	{
		UInt64U5BU5D_t7C6E32D10F47677C1CEF3C30F4E4CE95B3A633E2* L_19 = V_2;
		return (UInt64U5BU5D_t7C6E32D10F47677C1CEF3C30F4E4CE95B3A633E2*)L_19;
	}

IL_0052:
	{
		RuntimeObject * L_20 = ___list0;
		List_1_t1F1C2C7D92FB6DF4FCD88B0AB0919AEAB3B45F6B * L_21 = (List_1_t1F1C2C7D92FB6DF4FCD88B0AB0919AEAB3B45F6B *)il2cpp_codegen_object_new(IL2CPP_RGCTX_DATA(method->rgctx_data, 3));
		((  void (*) (List_1_t1F1C2C7D92FB6DF4FCD88B0AB0919AEAB3B45F6B *, const RuntimeMethod*))IL2CPP_RGCTX_METHOD_INFO(method->rgctx_data, 4)->methodPointer)(L_21, /*hidden argument*/IL2CPP_RGCTX_METHOD_INFO(method->rgctx_data, 4));
		V_1 = (List_1_t1F1C2C7D92FB6DF4FCD88B0AB0919AEAB3B45F6B *)L_21;
		NullCheck((RuntimeObject*)((RuntimeObject*)IsInst((RuntimeObject*)L_20, IEnumerable_t47A618747A1BB2A868710316F7372094849163A2_il2cpp_TypeInfo_var)));
		RuntimeObject* L_22;
		L_22 = InterfaceFuncInvoker0< RuntimeObject* >::Invoke(0 /* System.Collections.IEnumerator System.Collections.IEnumerable::GetEnumerator() */, IEnumerable_t47A618747A1BB2A868710316F7372094849163A2_il2cpp_TypeInfo_var, (RuntimeObject*)((RuntimeObject*)IsInst((RuntimeObject*)L_20, IEnumerable_t47A618747A1BB2A868710316F7372094849163A2_il2cpp_TypeInfo_var)));
		V_4 = (RuntimeObject*)L_22;
	}

IL_0065:
	try
	{ // begin try (depth: 1)
		{
			goto IL_0093;
		}

IL_0067:
		{
			RuntimeObject* L_23 = V_4;
			NullCheck((RuntimeObject*)L_23);
			RuntimeObject * L_24;
			L_24 = InterfaceFuncInvoker0< RuntimeObject * >::Invoke(1 /* System.Object System.Collections.IEnumerator::get_Current() */, IEnumerator_t5956F3AFB7ECF1117E3BC5890E7FC7B7F7A04105_il2cpp_TypeInfo_var, (RuntimeObject*)L_23);
			V_5 = (RuntimeObject *)L_24;
			List_1_t1F1C2C7D92FB6DF4FCD88B0AB0919AEAB3B45F6B * L_25 = V_1;
			XmlValueConverter_t18B2DCDB3B3F7609F3E43D5C46D2095BD09E6763 * L_26 = (XmlValueConverter_t18B2DCDB3B3F7609F3E43D5C46D2095BD09E6763 *)__this->get_atomicConverter_32();
			RuntimeObject * L_27 = V_5;
			RuntimeTypeHandle_tC33965ADA3E041E0C94AF05E5CB527B56482CEF9  L_28 = { reinterpret_cast<intptr_t> (IL2CPP_RGCTX_TYPE(method->rgctx_data, 1)) };
			IL2CPP_RUNTIME_CLASS_INIT(Type_t_il2cpp_TypeInfo_var);
			Type_t * L_29;
			L_29 = Type_GetTypeFromHandle_m8BB57524FF7F9DB1803BC561D2B3A4DBACEB385E((RuntimeTypeHandle_tC33965ADA3E041E0C94AF05E5CB527B56482CEF9 )L_28, /*hidden argument*/NULL);
			RuntimeObject* L_30 = ___nsResolver1;
			NullCheck((XmlValueConverter_t18B2DCDB3B3F7609F3E43D5C46D2095BD09E6763 *)L_26);
			RuntimeObject * L_31;
			L_31 = VirtFuncInvoker3< RuntimeObject *, RuntimeObject *, Type_t *, RuntimeObject* >::Invoke(61 /* System.Object System.Xml.Schema.XmlValueConverter::ChangeType(System.Object,System.Type,System.Xml.IXmlNamespaceResolver) */, (XmlValueConverter_t18B2DCDB3B3F7609F3E43D5C46D2095BD09E6763 *)L_26, (RuntimeObject *)L_27, (Type_t *)L_29, (RuntimeObject*)L_30);
			NullCheck((List_1_t1F1C2C7D92FB6DF4FCD88B0AB0919AEAB3B45F6B *)L_25);
			((  void (*) (List_1_t1F1C2C7D92FB6DF4FCD88B0AB0919AEAB3B45F6B *, uint64_t, const RuntimeMethod*))IL2CPP_RGCTX_METHOD_INFO(method->rgctx_data, 5)->methodPointer)((List_1_t1F1C2C7D92FB6DF4FCD88B0AB0919AEAB3B45F6B *)L_25, (uint64_t)((*(uint64_t*)((uint64_t*)UnBox(L_31, IL2CPP_RGCTX_DATA(method->rgctx_data, 2))))), /*hidden argument*/IL2CPP_RGCTX_METHOD_INFO(method->rgctx_data, 5));
		}

IL_0093:
		{
			RuntimeObject* L_32 = V_4;
			NullCheck((RuntimeObject*)L_32);
			bool L_33;
			L_33 = InterfaceFuncInvoker0< bool >::Invoke(0 /* System.Boolean System.Collections.IEnumerator::MoveNext() */, IEnumerator_t5956F3AFB7ECF1117E3BC5890E7FC7B7F7A04105_il2cpp_TypeInfo_var, (RuntimeObject*)L_32);
			if (L_33)
			{
				goto IL_0067;
			}
		}

IL_009c:
		{
			IL2CPP_LEAVE(0xB3, FINALLY_009e);
		}
	} // end try (depth: 1)
	catch(Il2CppExceptionWrapper& e)
	{
		__last_unhandled_exception = (Exception_t *)e.ex;
		goto FINALLY_009e;
	}

FINALLY_009e:
	{ // begin finally (depth: 1)
		{
			RuntimeObject* L_34 = V_4;
			V_6 = (RuntimeObject*)((RuntimeObject*)IsInst((RuntimeObject*)L_34, IDisposable_t099785737FC6A1E3699919A94109383715A8D807_il2cpp_TypeInfo_var));
			RuntimeObject* L_35 = V_6;
			if (!L_35)
			{
				goto IL_00b2;
			}
		}

IL_00ab:
		{
			RuntimeObject* L_36 = V_6;
			NullCheck((RuntimeObject*)L_36);
			InterfaceActionInvoker0::Invoke(0 /* System.Void System.IDisposable::Dispose() */, IDisposable_t099785737FC6A1E3699919A94109383715A8D807_il2cpp_TypeInfo_var, (RuntimeObject*)L_36);
		}

IL_00b2:
		{
			IL2CPP_END_FINALLY(158)
		}
	} // end finally (depth: 1)
	IL2CPP_CLEANUP(158)
	{
		IL2CPP_RETHROW_IF_UNHANDLED(Exception_t *)
		IL2CPP_JUMP_TBL(0xB3, IL_00b3)
	}

IL_00b3:
	{
		List_1_t1F1C2C7D92FB6DF4FCD88B0AB0919AEAB3B45F6B * L_37 = V_1;
		NullCheck((List_1_t1F1C2C7D92FB6DF4FCD88B0AB0919AEAB3B45F6B *)L_37);
		UInt64U5BU5D_t7C6E32D10F47677C1CEF3C30F4E4CE95B3A633E2* L_38;
		L_38 = ((  UInt64U5BU5D_t7C6E32D10F47677C1CEF3C30F4E4CE95B3A633E2* (*) (List_1_t1F1C2C7D92FB6DF4FCD88B0AB0919AEAB3B45F6B *, const RuntimeMethod*))IL2CPP_RGCTX_METHOD_INFO(method->rgctx_data, 6)->methodPointer)((List_1_t1F1C2C7D92FB6DF4FCD88B0AB0919AEAB3B45F6B *)L_37, /*hidden argument*/IL2CPP_RGCTX_METHOD_INFO(method->rgctx_data, 6));
		return (UInt64U5BU5D_t7C6E32D10F47677C1CEF3C30F4E4CE95B3A633E2*)L_38;
	}
}
// T[] System.Runtime.Serialization.XmlObjectSerializerReadContext::EnsureArraySize<System.Object>(T[],System.Int32)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR ObjectU5BU5D_tC1F4EE0DB0B7300255F5FD4AF64FE4C585CF5ADE* XmlObjectSerializerReadContext_EnsureArraySize_TisRuntimeObject_mD59ABE364D023B96A4D85AB81673B9F2C62C8C30_gshared (ObjectU5BU5D_tC1F4EE0DB0B7300255F5FD4AF64FE4C585CF5ADE* ___array0, int32_t ___index1, const RuntimeMethod* method)
{
	ObjectU5BU5D_tC1F4EE0DB0B7300255F5FD4AF64FE4C585CF5ADE* V_0 = NULL;
	int32_t G_B6_0 = 0;
	{
		ObjectU5BU5D_tC1F4EE0DB0B7300255F5FD4AF64FE4C585CF5ADE* L_0 = ___array0;
		NullCheck(L_0);
		int32_t L_1 = ___index1;
		if ((((int32_t)((int32_t)((int32_t)(((RuntimeArray*)L_0)->max_length)))) > ((int32_t)L_1)))
		{
			goto IL_006f;
		}
	}
	{
		int32_t L_2 = ___index1;
		if ((!(((uint32_t)L_2) == ((uint32_t)((int32_t)2147483647LL)))))
		{
			goto IL_0048;
		}
	}
	{
		ObjectU5BU5D_tC1F4EE0DB0B7300255F5FD4AF64FE4C585CF5ADE* L_3 = (ObjectU5BU5D_tC1F4EE0DB0B7300255F5FD4AF64FE4C585CF5ADE*)(ObjectU5BU5D_tC1F4EE0DB0B7300255F5FD4AF64FE4C585CF5ADE*)SZArrayNew(((RuntimeClass*)il2cpp_codegen_initialize_runtime_metadata_inline((uintptr_t*)&ObjectU5BU5D_tC1F4EE0DB0B7300255F5FD4AF64FE4C585CF5ADE_il2cpp_TypeInfo_var)), (uint32_t)2);
		ObjectU5BU5D_tC1F4EE0DB0B7300255F5FD4AF64FE4C585CF5ADE* L_4 = (ObjectU5BU5D_tC1F4EE0DB0B7300255F5FD4AF64FE4C585CF5ADE*)L_3;
		int32_t L_5 = ((int32_t)2147483647LL);
		RuntimeObject * L_6 = Box(((RuntimeClass*)il2cpp_codegen_initialize_runtime_metadata_inline((uintptr_t*)&Int32_tFDE5F8CD43D10453F6A2E0C77FE48C6CC7009046_il2cpp_TypeInfo_var)), &L_5);
		NullCheck(L_4);
		ArrayElementTypeCheck (L_4, L_6);
		(L_4)->SetAt(static_cast<il2cpp_array_size_t>(0), (RuntimeObject *)L_6);
		ObjectU5BU5D_tC1F4EE0DB0B7300255F5FD4AF64FE4C585CF5ADE* L_7 = (ObjectU5BU5D_tC1F4EE0DB0B7300255F5FD4AF64FE4C585CF5ADE*)L_4;
		RuntimeTypeHandle_tC33965ADA3E041E0C94AF05E5CB527B56482CEF9  L_8 = { reinterpret_cast<intptr_t> (IL2CPP_RGCTX_TYPE(method->rgctx_data, 0)) };
		IL2CPP_RUNTIME_CLASS_INIT(((RuntimeClass*)il2cpp_codegen_initialize_runtime_metadata_inline((uintptr_t*)&Type_t_il2cpp_TypeInfo_var)));
		Type_t * L_9;
		L_9 = Type_GetTypeFromHandle_m8BB57524FF7F9DB1803BC561D2B3A4DBACEB385E((RuntimeTypeHandle_tC33965ADA3E041E0C94AF05E5CB527B56482CEF9 )L_8, /*hidden argument*/NULL);
		String_t* L_10;
		L_10 = DataContract_GetClrTypeFullName_m2780B0E4C129B4655489C1E02D8F96ADDACA4711((Type_t *)L_9, /*hidden argument*/NULL);
		NullCheck(L_7);
		ArrayElementTypeCheck (L_7, L_10);
		(L_7)->SetAt(static_cast<il2cpp_array_size_t>(1), (RuntimeObject *)L_10);
		String_t* L_11;
		L_11 = SR_GetString_m9362D6A80ADB0E2770FB53AD9ACDF8A99FA4E7F6((String_t*)((String_t*)il2cpp_codegen_initialize_runtime_metadata_inline((uintptr_t*)&_stringLiteral94ADECE30C954CD6685EE98984452C698987E415)), (ObjectU5BU5D_tC1F4EE0DB0B7300255F5FD4AF64FE4C585CF5ADE*)L_7, /*hidden argument*/NULL);
		SerializationException_tDB38C13A2ABF407C381E3F332D197AC1AD097A92 * L_12;
		L_12 = XmlObjectSerializer_CreateSerializationException_mA433DFF9CCCB3DBF82DC4C09F362F1F0C2CCF160((String_t*)L_11, /*hidden argument*/NULL);
		Exception_t * L_13;
		L_13 = ExceptionUtility_ThrowHelperError_m23931D3B92251FB3E39C0A3CCDBAA006397B2E99((Exception_t *)L_12, /*hidden argument*/NULL);
		IL2CPP_RAISE_MANAGED_EXCEPTION(L_13, ((RuntimeMethod*)il2cpp_codegen_initialize_runtime_metadata_inline((uintptr_t*)&XmlObjectSerializerReadContext_EnsureArraySize_TisRuntimeObject_mD59ABE364D023B96A4D85AB81673B9F2C62C8C30_RuntimeMethod_var)));
	}

IL_0048:
	{
		int32_t L_14 = ___index1;
		if ((((int32_t)L_14) < ((int32_t)((int32_t)1073741823))))
		{
			goto IL_0057;
		}
	}
	{
		G_B6_0 = ((int32_t)2147483647LL);
		goto IL_005a;
	}

IL_0057:
	{
		int32_t L_15 = ___index1;
		G_B6_0 = ((int32_t)il2cpp_codegen_multiply((int32_t)L_15, (int32_t)2));
	}

IL_005a:
	{
		ObjectU5BU5D_tC1F4EE0DB0B7300255F5FD4AF64FE4C585CF5ADE* L_16 = (ObjectU5BU5D_tC1F4EE0DB0B7300255F5FD4AF64FE4C585CF5ADE*)(ObjectU5BU5D_tC1F4EE0DB0B7300255F5FD4AF64FE4C585CF5ADE*)SZArrayNew(IL2CPP_RGCTX_DATA(method->rgctx_data, 1), (uint32_t)G_B6_0);
		V_0 = (ObjectU5BU5D_tC1F4EE0DB0B7300255F5FD4AF64FE4C585CF5ADE*)L_16;
		ObjectU5BU5D_tC1F4EE0DB0B7300255F5FD4AF64FE4C585CF5ADE* L_17 = ___array0;
		ObjectU5BU5D_tC1F4EE0DB0B7300255F5FD4AF64FE4C585CF5ADE* L_18 = V_0;
		ObjectU5BU5D_tC1F4EE0DB0B7300255F5FD4AF64FE4C585CF5ADE* L_19 = ___array0;
		NullCheck(L_19);
		Array_Copy_m3F127FFB5149532135043FFE285F9177C80CB877((RuntimeArray *)(RuntimeArray *)L_17, (int32_t)0, (RuntimeArray *)(RuntimeArray *)L_18, (int32_t)0, (int32_t)((int32_t)((int32_t)(((RuntimeArray*)L_19)->max_length))), /*hidden argument*/NULL);
		ObjectU5BU5D_tC1F4EE0DB0B7300255F5FD4AF64FE4C585CF5ADE* L_20 = V_0;
		___array0 = (ObjectU5BU5D_tC1F4EE0DB0B7300255F5FD4AF64FE4C585CF5ADE*)L_20;
	}

IL_006f:
	{
		ObjectU5BU5D_tC1F4EE0DB0B7300255F5FD4AF64FE4C585CF5ADE* L_21 = ___array0;
		return (ObjectU5BU5D_tC1F4EE0DB0B7300255F5FD4AF64FE4C585CF5ADE*)L_21;
	}
}
// T[] System.Runtime.Serialization.XmlObjectSerializerReadContext::TrimArraySize<System.Object>(T[],System.Int32)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR ObjectU5BU5D_tC1F4EE0DB0B7300255F5FD4AF64FE4C585CF5ADE* XmlObjectSerializerReadContext_TrimArraySize_TisRuntimeObject_mF82A54637118617509385A067E8A677AC3877326_gshared (ObjectU5BU5D_tC1F4EE0DB0B7300255F5FD4AF64FE4C585CF5ADE* ___array0, int32_t ___size1, const RuntimeMethod* method)
{
	ObjectU5BU5D_tC1F4EE0DB0B7300255F5FD4AF64FE4C585CF5ADE* V_0 = NULL;
	{
		int32_t L_0 = ___size1;
		ObjectU5BU5D_tC1F4EE0DB0B7300255F5FD4AF64FE4C585CF5ADE* L_1 = ___array0;
		NullCheck(L_1);
		if ((((int32_t)L_0) == ((int32_t)((int32_t)((int32_t)(((RuntimeArray*)L_1)->max_length))))))
		{
			goto IL_001a;
		}
	}
	{
		int32_t L_2 = ___size1;
		ObjectU5BU5D_tC1F4EE0DB0B7300255F5FD4AF64FE4C585CF5ADE* L_3 = (ObjectU5BU5D_tC1F4EE0DB0B7300255F5FD4AF64FE4C585CF5ADE*)(ObjectU5BU5D_tC1F4EE0DB0B7300255F5FD4AF64FE4C585CF5ADE*)SZArrayNew(IL2CPP_RGCTX_DATA(method->rgctx_data, 0), (uint32_t)L_2);
		V_0 = (ObjectU5BU5D_tC1F4EE0DB0B7300255F5FD4AF64FE4C585CF5ADE*)L_3;
		ObjectU5BU5D_tC1F4EE0DB0B7300255F5FD4AF64FE4C585CF5ADE* L_4 = ___array0;
		ObjectU5BU5D_tC1F4EE0DB0B7300255F5FD4AF64FE4C585CF5ADE* L_5 = V_0;
		int32_t L_6 = ___size1;
		Array_Copy_m3F127FFB5149532135043FFE285F9177C80CB877((RuntimeArray *)(RuntimeArray *)L_4, (int32_t)0, (RuntimeArray *)(RuntimeArray *)L_5, (int32_t)0, (int32_t)L_6, /*hidden argument*/NULL);
		ObjectU5BU5D_tC1F4EE0DB0B7300255F5FD4AF64FE4C585CF5ADE* L_7 = V_0;
		___array0 = (ObjectU5BU5D_tC1F4EE0DB0B7300255F5FD4AF64FE4C585CF5ADE*)L_7;
	}

IL_001a:
	{
		ObjectU5BU5D_tC1F4EE0DB0B7300255F5FD4AF64FE4C585CF5ADE* L_8 = ___array0;
		return (ObjectU5BU5D_tC1F4EE0DB0B7300255F5FD4AF64FE4C585CF5ADE*)L_8;
	}
}
// T System.Runtime.Serialization.XmlObjectSerializerWriteContext::GetDefaultValue<System.Object>()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR RuntimeObject * XmlObjectSerializerWriteContext_GetDefaultValue_TisRuntimeObject_m9B96AA450D859BA0262ECAB70279B45E99495521_gshared (const RuntimeMethod* method)
{
	RuntimeObject * V_0 = NULL;
	{
		il2cpp_codegen_initobj((&V_0), sizeof(RuntimeObject *));
		RuntimeObject * L_0 = V_0;
		return (RuntimeObject *)L_0;
	}
}
// System.Void System.Runtime.Serialization.XmlObjectSerializerWriteContext::IncrementCollectionCountGeneric<System.Object>(System.Runtime.Serialization.XmlWriterDelegator,System.Collections.Generic.ICollection`1<T>)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void XmlObjectSerializerWriteContext_IncrementCollectionCountGeneric_TisRuntimeObject_m1445D1A9F3B76DD749AC728F1C4BAC4C1EABDAF9_gshared (XmlObjectSerializerWriteContext_t0DDF2A2D70F1E6DDBC86B5E9E3DBA5D577889AE9 * __this, XmlWriterDelegator_t14F933DC94CDCA5AA29C259565A8C4C0E41613BC * ___xmlWriter0, RuntimeObject* ___collection1, const RuntimeMethod* method)
{
	{
		XmlWriterDelegator_t14F933DC94CDCA5AA29C259565A8C4C0E41613BC * L_0 = ___xmlWriter0;
		RuntimeObject* L_1 = ___collection1;
		NullCheck((RuntimeObject*)L_1);
		int32_t L_2;
		L_2 = InterfaceFuncInvoker0< int32_t >::Invoke(0 /* System.Int32 System.Collections.Generic.ICollection`1<System.Object>::get_Count() */, IL2CPP_RGCTX_DATA(method->rgctx_data, 0), (RuntimeObject*)L_1);
		NullCheck((XmlObjectSerializerWriteContext_t0DDF2A2D70F1E6DDBC86B5E9E3DBA5D577889AE9 *)__this);
		XmlObjectSerializerWriteContext_IncrementCollectionCount_mE4F8ED23C2425966E40F6A27851CE31CD6269C3C((XmlObjectSerializerWriteContext_t0DDF2A2D70F1E6DDBC86B5E9E3DBA5D577889AE9 *)__this, (XmlWriterDelegator_t14F933DC94CDCA5AA29C259565A8C4C0E41613BC *)L_0, (int32_t)L_2, /*hidden argument*/NULL);
		return;
	}
}
// ArrayType UnityEngine._AndroidJNIHelper::ConvertFromJNIArray<System.Boolean>(System.IntPtr)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR bool _AndroidJNIHelper_ConvertFromJNIArray_TisBoolean_t07D1E3F34E4813023D64F584DFF7B34C9D922F37_m20E7EDFF477647AD2AAEA5C01F2F96F086673299_gshared (intptr_t ___array0, const RuntimeMethod* method)
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&AndroidJavaObjectU5BU5D_tEE28563C9013906CEB39794019A55F4BA5B06120_il2cpp_TypeInfo_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&AndroidJavaObject_t10188D5695DCD09C9F621B44B0A8C93A2281236E_0_0_0_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&AndroidJavaObject_t10188D5695DCD09C9F621B44B0A8C93A2281236E_il2cpp_TypeInfo_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&AndroidReflection_tEB6633FD5B7D2816E1AC6C711E11B2DD33822F16_il2cpp_TypeInfo_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Boolean_t07D1E3F34E4813023D64F584DFF7B34C9D922F37_0_0_0_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Byte_t0111FAB8B8685667EDDAF77683F0D8F86B659056_0_0_0_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Char_tFF60D8E7E89A20BE2294A003734341BD1DF43E14_0_0_0_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Debug_tEB68BCBEB8EFD60F8043C67146DC05E7F50F374B_il2cpp_TypeInfo_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Double_t42821932CB52DE2057E685D0E1AF3DE5033D2181_0_0_0_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Int16_tD0F031114106263BB459DA1F099FF9F42691295A_0_0_0_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Int32_tFDE5F8CD43D10453F6A2E0C77FE48C6CC7009046_0_0_0_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Int64_t378EE0D608BD3107E77238E85F30D2BBD46981F3_0_0_0_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&SByte_t928712DD662DC29BA4FAAE8CE2230AFB23447F0B_0_0_0_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Single_tE07797BA3C98D4CA9B5A19413C19A76688AB899E_0_0_0_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&StringU5BU5D_tACEBFEDE350025B554CD507C9AE8FFE49359549A_il2cpp_TypeInfo_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&String_t_0_0_0_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Type_t_il2cpp_TypeInfo_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&_stringLiteral24CC8D396132365E532646F936DFC8579E2299B2);
		s_Il2CppMethodInitialized = true;
	}
	Type_t * V_0 = NULL;
	bool V_1 = false;
	bool V_2 = false;
	bool V_3 = false;
	bool V_4 = false;
	bool V_5 = false;
	bool V_6 = false;
	bool V_7 = false;
	bool V_8 = false;
	bool V_9 = false;
	bool V_10 = false;
	bool V_11 = false;
	bool V_12 = false;
	int32_t V_13 = 0;
	StringU5BU5D_tACEBFEDE350025B554CD507C9AE8FFE49359549A* V_14 = NULL;
	int32_t V_15 = 0;
	intptr_t V_16;
	memset((&V_16), 0, sizeof(V_16));
	bool V_17 = false;
	bool V_18 = false;
	int32_t V_19 = 0;
	AndroidJavaObjectU5BU5D_tEE28563C9013906CEB39794019A55F4BA5B06120* V_20 = NULL;
	int32_t V_21 = 0;
	intptr_t V_22;
	memset((&V_22), 0, sizeof(V_22));
	bool V_23 = false;
	bool V_24 = false;
	Type_t * G_B32_0 = NULL;
	String_t* G_B32_1 = NULL;
	Type_t * G_B31_0 = NULL;
	String_t* G_B31_1 = NULL;
	String_t* G_B33_0 = NULL;
	String_t* G_B33_1 = NULL;
	{
		RuntimeTypeHandle_tC33965ADA3E041E0C94AF05E5CB527B56482CEF9  L_0 = { reinterpret_cast<intptr_t> (IL2CPP_RGCTX_TYPE(method->rgctx_data, 0)) };
		IL2CPP_RUNTIME_CLASS_INIT(Type_t_il2cpp_TypeInfo_var);
		Type_t * L_1;
		L_1 = Type_GetTypeFromHandle_m8BB57524FF7F9DB1803BC561D2B3A4DBACEB385E((RuntimeTypeHandle_tC33965ADA3E041E0C94AF05E5CB527B56482CEF9 )L_0, /*hidden argument*/NULL);
		NullCheck((Type_t *)L_1);
		Type_t * L_2;
		L_2 = VirtFuncInvoker0< Type_t * >::Invoke(220 /* System.Type System.Type::GetElementType() */, (Type_t *)L_1);
		V_0 = (Type_t *)L_2;
		Type_t * L_3 = V_0;
		IL2CPP_RUNTIME_CLASS_INIT(AndroidReflection_tEB6633FD5B7D2816E1AC6C711E11B2DD33822F16_il2cpp_TypeInfo_var);
		bool L_4;
		L_4 = AndroidReflection_IsPrimitive_mDD6A4050793DF2FA1EDF58010982C64A3F17376D((Type_t *)L_3, /*hidden argument*/NULL);
		V_1 = (bool)L_4;
		bool L_5 = V_1;
		if (!L_5)
		{
			goto IL_0173;
		}
	}
	{
		Type_t * L_6 = V_0;
		RuntimeTypeHandle_tC33965ADA3E041E0C94AF05E5CB527B56482CEF9  L_7 = { reinterpret_cast<intptr_t> (Int32_tFDE5F8CD43D10453F6A2E0C77FE48C6CC7009046_0_0_0_var) };
		IL2CPP_RUNTIME_CLASS_INIT(Type_t_il2cpp_TypeInfo_var);
		Type_t * L_8;
		L_8 = Type_GetTypeFromHandle_m8BB57524FF7F9DB1803BC561D2B3A4DBACEB385E((RuntimeTypeHandle_tC33965ADA3E041E0C94AF05E5CB527B56482CEF9 )L_7, /*hidden argument*/NULL);
		V_2 = (bool)((((RuntimeObject*)(Type_t *)L_6) == ((RuntimeObject*)(Type_t *)L_8))? 1 : 0);
		bool L_9 = V_2;
		if (!L_9)
		{
			goto IL_0041;
		}
	}
	{
		intptr_t L_10 = ___array0;
		Int32U5BU5D_t70F1BDC14B1786481B176D6139A5E3B87DC54C32* L_11;
		L_11 = AndroidJNISafe_FromIntArray_mBF0C0B4309BA525BBA12D7FD3C2790C8FA7C4703((intptr_t)L_10, /*hidden argument*/NULL);
		V_3 = (bool)((*(bool*)((bool*)UnBox((RuntimeObject *)L_11, IL2CPP_RGCTX_DATA(method->rgctx_data, 1)))));
		goto IL_0272;
	}

IL_0041:
	{
		Type_t * L_12 = V_0;
		RuntimeTypeHandle_tC33965ADA3E041E0C94AF05E5CB527B56482CEF9  L_13 = { reinterpret_cast<intptr_t> (Boolean_t07D1E3F34E4813023D64F584DFF7B34C9D922F37_0_0_0_var) };
		IL2CPP_RUNTIME_CLASS_INIT(Type_t_il2cpp_TypeInfo_var);
		Type_t * L_14;
		L_14 = Type_GetTypeFromHandle_m8BB57524FF7F9DB1803BC561D2B3A4DBACEB385E((RuntimeTypeHandle_tC33965ADA3E041E0C94AF05E5CB527B56482CEF9 )L_13, /*hidden argument*/NULL);
		V_4 = (bool)((((RuntimeObject*)(Type_t *)L_12) == ((RuntimeObject*)(Type_t *)L_14))? 1 : 0);
		bool L_15 = V_4;
		if (!L_15)
		{
			goto IL_0065;
		}
	}
	{
		intptr_t L_16 = ___array0;
		BooleanU5BU5D_tEC7BAF93C44F875016DAADC8696EE3A465644D3C* L_17;
		L_17 = AndroidJNISafe_FromBooleanArray_m77A66C34FCB94ADB1AD5E1D88262500C930A5DBF((intptr_t)L_16, /*hidden argument*/NULL);
		V_3 = (bool)((*(bool*)((bool*)UnBox((RuntimeObject *)L_17, IL2CPP_RGCTX_DATA(method->rgctx_data, 1)))));
		goto IL_0272;
	}

IL_0065:
	{
		Type_t * L_18 = V_0;
		RuntimeTypeHandle_tC33965ADA3E041E0C94AF05E5CB527B56482CEF9  L_19 = { reinterpret_cast<intptr_t> (Byte_t0111FAB8B8685667EDDAF77683F0D8F86B659056_0_0_0_var) };
		IL2CPP_RUNTIME_CLASS_INIT(Type_t_il2cpp_TypeInfo_var);
		Type_t * L_20;
		L_20 = Type_GetTypeFromHandle_m8BB57524FF7F9DB1803BC561D2B3A4DBACEB385E((RuntimeTypeHandle_tC33965ADA3E041E0C94AF05E5CB527B56482CEF9 )L_19, /*hidden argument*/NULL);
		V_5 = (bool)((((RuntimeObject*)(Type_t *)L_18) == ((RuntimeObject*)(Type_t *)L_20))? 1 : 0);
		bool L_21 = V_5;
		if (!L_21)
		{
			goto IL_0095;
		}
	}
	{
		IL2CPP_RUNTIME_CLASS_INIT(Debug_tEB68BCBEB8EFD60F8043C67146DC05E7F50F374B_il2cpp_TypeInfo_var);
		Debug_LogWarning_m24085D883C9E74D7AB423F0625E13259923960E7((RuntimeObject *)_stringLiteral24CC8D396132365E532646F936DFC8579E2299B2, /*hidden argument*/NULL);
		intptr_t L_22 = ___array0;
		ByteU5BU5D_tDBBEB0E8362242FA7223000D978B0DD19D4B0726* L_23;
		L_23 = AndroidJNISafe_FromByteArray_m81760A688AECE368E1CFF7DAAC8E141F1B8FA8A8((intptr_t)L_22, /*hidden argument*/NULL);
		V_3 = (bool)((*(bool*)((bool*)UnBox((RuntimeObject *)L_23, IL2CPP_RGCTX_DATA(method->rgctx_data, 1)))));
		goto IL_0272;
	}

IL_0095:
	{
		Type_t * L_24 = V_0;
		RuntimeTypeHandle_tC33965ADA3E041E0C94AF05E5CB527B56482CEF9  L_25 = { reinterpret_cast<intptr_t> (SByte_t928712DD662DC29BA4FAAE8CE2230AFB23447F0B_0_0_0_var) };
		IL2CPP_RUNTIME_CLASS_INIT(Type_t_il2cpp_TypeInfo_var);
		Type_t * L_26;
		L_26 = Type_GetTypeFromHandle_m8BB57524FF7F9DB1803BC561D2B3A4DBACEB385E((RuntimeTypeHandle_tC33965ADA3E041E0C94AF05E5CB527B56482CEF9 )L_25, /*hidden argument*/NULL);
		V_6 = (bool)((((RuntimeObject*)(Type_t *)L_24) == ((RuntimeObject*)(Type_t *)L_26))? 1 : 0);
		bool L_27 = V_6;
		if (!L_27)
		{
			goto IL_00b9;
		}
	}
	{
		intptr_t L_28 = ___array0;
		SByteU5BU5D_t7D94C53295E6116625EA7CC7DEA21FEDC39869E7* L_29;
		L_29 = AndroidJNISafe_FromSByteArray_m01F6539AF10F86B3927436955B57CC809C52416D((intptr_t)L_28, /*hidden argument*/NULL);
		V_3 = (bool)((*(bool*)((bool*)UnBox((RuntimeObject *)L_29, IL2CPP_RGCTX_DATA(method->rgctx_data, 1)))));
		goto IL_0272;
	}

IL_00b9:
	{
		Type_t * L_30 = V_0;
		RuntimeTypeHandle_tC33965ADA3E041E0C94AF05E5CB527B56482CEF9  L_31 = { reinterpret_cast<intptr_t> (Int16_tD0F031114106263BB459DA1F099FF9F42691295A_0_0_0_var) };
		IL2CPP_RUNTIME_CLASS_INIT(Type_t_il2cpp_TypeInfo_var);
		Type_t * L_32;
		L_32 = Type_GetTypeFromHandle_m8BB57524FF7F9DB1803BC561D2B3A4DBACEB385E((RuntimeTypeHandle_tC33965ADA3E041E0C94AF05E5CB527B56482CEF9 )L_31, /*hidden argument*/NULL);
		V_7 = (bool)((((RuntimeObject*)(Type_t *)L_30) == ((RuntimeObject*)(Type_t *)L_32))? 1 : 0);
		bool L_33 = V_7;
		if (!L_33)
		{
			goto IL_00dd;
		}
	}
	{
		intptr_t L_34 = ___array0;
		Int16U5BU5D_tD134F1E6F746D4C09C987436805256C210C2FFCD* L_35;
		L_35 = AndroidJNISafe_FromShortArray_mCDF5B796D950D31035BD35A2E463D41509E4A5CD((intptr_t)L_34, /*hidden argument*/NULL);
		V_3 = (bool)((*(bool*)((bool*)UnBox((RuntimeObject *)L_35, IL2CPP_RGCTX_DATA(method->rgctx_data, 1)))));
		goto IL_0272;
	}

IL_00dd:
	{
		Type_t * L_36 = V_0;
		RuntimeTypeHandle_tC33965ADA3E041E0C94AF05E5CB527B56482CEF9  L_37 = { reinterpret_cast<intptr_t> (Int64_t378EE0D608BD3107E77238E85F30D2BBD46981F3_0_0_0_var) };
		IL2CPP_RUNTIME_CLASS_INIT(Type_t_il2cpp_TypeInfo_var);
		Type_t * L_38;
		L_38 = Type_GetTypeFromHandle_m8BB57524FF7F9DB1803BC561D2B3A4DBACEB385E((RuntimeTypeHandle_tC33965ADA3E041E0C94AF05E5CB527B56482CEF9 )L_37, /*hidden argument*/NULL);
		V_8 = (bool)((((RuntimeObject*)(Type_t *)L_36) == ((RuntimeObject*)(Type_t *)L_38))? 1 : 0);
		bool L_39 = V_8;
		if (!L_39)
		{
			goto IL_0101;
		}
	}
	{
		intptr_t L_40 = ___array0;
		Int64U5BU5D_tCA61E42872C63A4286B24EEE6E0650143B43DCE6* L_41;
		L_41 = AndroidJNISafe_FromLongArray_m0E7C56CB8CFD0EC240F0D86ECBBFD635FFE55CDA((intptr_t)L_40, /*hidden argument*/NULL);
		V_3 = (bool)((*(bool*)((bool*)UnBox((RuntimeObject *)L_41, IL2CPP_RGCTX_DATA(method->rgctx_data, 1)))));
		goto IL_0272;
	}

IL_0101:
	{
		Type_t * L_42 = V_0;
		RuntimeTypeHandle_tC33965ADA3E041E0C94AF05E5CB527B56482CEF9  L_43 = { reinterpret_cast<intptr_t> (Single_tE07797BA3C98D4CA9B5A19413C19A76688AB899E_0_0_0_var) };
		IL2CPP_RUNTIME_CLASS_INIT(Type_t_il2cpp_TypeInfo_var);
		Type_t * L_44;
		L_44 = Type_GetTypeFromHandle_m8BB57524FF7F9DB1803BC561D2B3A4DBACEB385E((RuntimeTypeHandle_tC33965ADA3E041E0C94AF05E5CB527B56482CEF9 )L_43, /*hidden argument*/NULL);
		V_9 = (bool)((((RuntimeObject*)(Type_t *)L_42) == ((RuntimeObject*)(Type_t *)L_44))? 1 : 0);
		bool L_45 = V_9;
		if (!L_45)
		{
			goto IL_0125;
		}
	}
	{
		intptr_t L_46 = ___array0;
		SingleU5BU5D_t47E8DBF5B597C122478D1FFBD9DD57399A0650FA* L_47;
		L_47 = AndroidJNISafe_FromFloatArray_mF6A63CA1B7C10BC27EEC033F0E390772DFDD652D((intptr_t)L_46, /*hidden argument*/NULL);
		V_3 = (bool)((*(bool*)((bool*)UnBox((RuntimeObject *)L_47, IL2CPP_RGCTX_DATA(method->rgctx_data, 1)))));
		goto IL_0272;
	}

IL_0125:
	{
		Type_t * L_48 = V_0;
		RuntimeTypeHandle_tC33965ADA3E041E0C94AF05E5CB527B56482CEF9  L_49 = { reinterpret_cast<intptr_t> (Double_t42821932CB52DE2057E685D0E1AF3DE5033D2181_0_0_0_var) };
		IL2CPP_RUNTIME_CLASS_INIT(Type_t_il2cpp_TypeInfo_var);
		Type_t * L_50;
		L_50 = Type_GetTypeFromHandle_m8BB57524FF7F9DB1803BC561D2B3A4DBACEB385E((RuntimeTypeHandle_tC33965ADA3E041E0C94AF05E5CB527B56482CEF9 )L_49, /*hidden argument*/NULL);
		V_10 = (bool)((((RuntimeObject*)(Type_t *)L_48) == ((RuntimeObject*)(Type_t *)L_50))? 1 : 0);
		bool L_51 = V_10;
		if (!L_51)
		{
			goto IL_0149;
		}
	}
	{
		intptr_t L_52 = ___array0;
		DoubleU5BU5D_t8E1B42EB2ABB79FBD193A6B8C8D97A7CDE44A4FB* L_53;
		L_53 = AndroidJNISafe_FromDoubleArray_m9438B5668E8B2DB3B18CACFF0CC9CAEAB5EC73C8((intptr_t)L_52, /*hidden argument*/NULL);
		V_3 = (bool)((*(bool*)((bool*)UnBox((RuntimeObject *)L_53, IL2CPP_RGCTX_DATA(method->rgctx_data, 1)))));
		goto IL_0272;
	}

IL_0149:
	{
		Type_t * L_54 = V_0;
		RuntimeTypeHandle_tC33965ADA3E041E0C94AF05E5CB527B56482CEF9  L_55 = { reinterpret_cast<intptr_t> (Char_tFF60D8E7E89A20BE2294A003734341BD1DF43E14_0_0_0_var) };
		IL2CPP_RUNTIME_CLASS_INIT(Type_t_il2cpp_TypeInfo_var);
		Type_t * L_56;
		L_56 = Type_GetTypeFromHandle_m8BB57524FF7F9DB1803BC561D2B3A4DBACEB385E((RuntimeTypeHandle_tC33965ADA3E041E0C94AF05E5CB527B56482CEF9 )L_55, /*hidden argument*/NULL);
		V_11 = (bool)((((RuntimeObject*)(Type_t *)L_54) == ((RuntimeObject*)(Type_t *)L_56))? 1 : 0);
		bool L_57 = V_11;
		if (!L_57)
		{
			goto IL_016d;
		}
	}
	{
		intptr_t L_58 = ___array0;
		CharU5BU5D_t7B7FC5BC8091AA3B9CB0B29CDD80B5EE9254AA34* L_59;
		L_59 = AndroidJNISafe_FromCharArray_mA49DB27755EF3B2AE81487E0FCFE06E23F617305((intptr_t)L_58, /*hidden argument*/NULL);
		V_3 = (bool)((*(bool*)((bool*)UnBox((RuntimeObject *)L_59, IL2CPP_RGCTX_DATA(method->rgctx_data, 1)))));
		goto IL_0272;
	}

IL_016d:
	{
		goto IL_0265;
	}

IL_0173:
	{
		Type_t * L_60 = V_0;
		RuntimeTypeHandle_tC33965ADA3E041E0C94AF05E5CB527B56482CEF9  L_61 = { reinterpret_cast<intptr_t> (String_t_0_0_0_var) };
		IL2CPP_RUNTIME_CLASS_INIT(Type_t_il2cpp_TypeInfo_var);
		Type_t * L_62;
		L_62 = Type_GetTypeFromHandle_m8BB57524FF7F9DB1803BC561D2B3A4DBACEB385E((RuntimeTypeHandle_tC33965ADA3E041E0C94AF05E5CB527B56482CEF9 )L_61, /*hidden argument*/NULL);
		V_12 = (bool)((((RuntimeObject*)(Type_t *)L_60) == ((RuntimeObject*)(Type_t *)L_62))? 1 : 0);
		bool L_63 = V_12;
		if (!L_63)
		{
			goto IL_01dc;
		}
	}
	{
		intptr_t L_64 = ___array0;
		int32_t L_65;
		L_65 = AndroidJNISafe_GetArrayLength_m3015C191DBFC246946A88592731441A934507B56((intptr_t)L_64, /*hidden argument*/NULL);
		V_13 = (int32_t)L_65;
		int32_t L_66 = V_13;
		StringU5BU5D_tACEBFEDE350025B554CD507C9AE8FFE49359549A* L_67 = (StringU5BU5D_tACEBFEDE350025B554CD507C9AE8FFE49359549A*)(StringU5BU5D_tACEBFEDE350025B554CD507C9AE8FFE49359549A*)SZArrayNew(StringU5BU5D_tACEBFEDE350025B554CD507C9AE8FFE49359549A_il2cpp_TypeInfo_var, (uint32_t)L_66);
		V_14 = (StringU5BU5D_tACEBFEDE350025B554CD507C9AE8FFE49359549A*)L_67;
		V_15 = (int32_t)0;
		goto IL_01c3;
	}

IL_019d:
	{
		intptr_t L_68 = ___array0;
		int32_t L_69 = V_15;
		intptr_t L_70;
		L_70 = AndroidJNI_GetObjectArrayElement_m502026BF77232EE45D03661E4923C2E5E99FDE18((intptr_t)L_68, (int32_t)L_69, /*hidden argument*/NULL);
		V_16 = (intptr_t)L_70;
		StringU5BU5D_tACEBFEDE350025B554CD507C9AE8FFE49359549A* L_71 = V_14;
		int32_t L_72 = V_15;
		intptr_t L_73 = V_16;
		String_t* L_74;
		L_74 = AndroidJNISafe_GetStringChars_mD59FFDE4192F837E1380B51569B5803E09BE58C8((intptr_t)L_73, /*hidden argument*/NULL);
		NullCheck(L_71);
		ArrayElementTypeCheck (L_71, L_74);
		(L_71)->SetAt(static_cast<il2cpp_array_size_t>(L_72), (String_t*)L_74);
		intptr_t L_75 = V_16;
		AndroidJNISafe_DeleteLocalRef_m7AB242A76D13A3BF4C04831D77960C020D6ADA39((intptr_t)L_75, /*hidden argument*/NULL);
		int32_t L_76 = V_15;
		V_15 = (int32_t)((int32_t)il2cpp_codegen_add((int32_t)L_76, (int32_t)1));
	}

IL_01c3:
	{
		int32_t L_77 = V_15;
		int32_t L_78 = V_13;
		V_17 = (bool)((((int32_t)L_77) < ((int32_t)L_78))? 1 : 0);
		bool L_79 = V_17;
		if (L_79)
		{
			goto IL_019d;
		}
	}
	{
		StringU5BU5D_tACEBFEDE350025B554CD507C9AE8FFE49359549A* L_80 = V_14;
		V_3 = (bool)((*(bool*)((bool*)UnBox((RuntimeObject *)L_80, IL2CPP_RGCTX_DATA(method->rgctx_data, 1)))));
		goto IL_0272;
	}

IL_01dc:
	{
		Type_t * L_81 = V_0;
		RuntimeTypeHandle_tC33965ADA3E041E0C94AF05E5CB527B56482CEF9  L_82 = { reinterpret_cast<intptr_t> (AndroidJavaObject_t10188D5695DCD09C9F621B44B0A8C93A2281236E_0_0_0_var) };
		IL2CPP_RUNTIME_CLASS_INIT(Type_t_il2cpp_TypeInfo_var);
		Type_t * L_83;
		L_83 = Type_GetTypeFromHandle_m8BB57524FF7F9DB1803BC561D2B3A4DBACEB385E((RuntimeTypeHandle_tC33965ADA3E041E0C94AF05E5CB527B56482CEF9 )L_82, /*hidden argument*/NULL);
		V_18 = (bool)((((RuntimeObject*)(Type_t *)L_81) == ((RuntimeObject*)(Type_t *)L_83))? 1 : 0);
		bool L_84 = V_18;
		if (!L_84)
		{
			goto IL_0242;
		}
	}
	{
		intptr_t L_85 = ___array0;
		int32_t L_86;
		L_86 = AndroidJNISafe_GetArrayLength_m3015C191DBFC246946A88592731441A934507B56((intptr_t)L_85, /*hidden argument*/NULL);
		V_19 = (int32_t)L_86;
		int32_t L_87 = V_19;
		AndroidJavaObjectU5BU5D_tEE28563C9013906CEB39794019A55F4BA5B06120* L_88 = (AndroidJavaObjectU5BU5D_tEE28563C9013906CEB39794019A55F4BA5B06120*)(AndroidJavaObjectU5BU5D_tEE28563C9013906CEB39794019A55F4BA5B06120*)SZArrayNew(AndroidJavaObjectU5BU5D_tEE28563C9013906CEB39794019A55F4BA5B06120_il2cpp_TypeInfo_var, (uint32_t)L_87);
		V_20 = (AndroidJavaObjectU5BU5D_tEE28563C9013906CEB39794019A55F4BA5B06120*)L_88;
		V_21 = (int32_t)0;
		goto IL_022c;
	}

IL_0206:
	{
		intptr_t L_89 = ___array0;
		int32_t L_90 = V_21;
		intptr_t L_91;
		L_91 = AndroidJNI_GetObjectArrayElement_m502026BF77232EE45D03661E4923C2E5E99FDE18((intptr_t)L_89, (int32_t)L_90, /*hidden argument*/NULL);
		V_22 = (intptr_t)L_91;
		AndroidJavaObjectU5BU5D_tEE28563C9013906CEB39794019A55F4BA5B06120* L_92 = V_20;
		int32_t L_93 = V_21;
		intptr_t L_94 = V_22;
		AndroidJavaObject_t10188D5695DCD09C9F621B44B0A8C93A2281236E * L_95 = (AndroidJavaObject_t10188D5695DCD09C9F621B44B0A8C93A2281236E *)il2cpp_codegen_object_new(AndroidJavaObject_t10188D5695DCD09C9F621B44B0A8C93A2281236E_il2cpp_TypeInfo_var);
		AndroidJavaObject__ctor_m880F6533139DF0BD36C6EF428E45E9F44B6534A3(L_95, (intptr_t)L_94, /*hidden argument*/NULL);
		NullCheck(L_92);
		ArrayElementTypeCheck (L_92, L_95);
		(L_92)->SetAt(static_cast<il2cpp_array_size_t>(L_93), (AndroidJavaObject_t10188D5695DCD09C9F621B44B0A8C93A2281236E *)L_95);
		intptr_t L_96 = V_22;
		AndroidJNISafe_DeleteLocalRef_m7AB242A76D13A3BF4C04831D77960C020D6ADA39((intptr_t)L_96, /*hidden argument*/NULL);
		int32_t L_97 = V_21;
		V_21 = (int32_t)((int32_t)il2cpp_codegen_add((int32_t)L_97, (int32_t)1));
	}

IL_022c:
	{
		int32_t L_98 = V_21;
		int32_t L_99 = V_19;
		V_23 = (bool)((((int32_t)L_98) < ((int32_t)L_99))? 1 : 0);
		bool L_100 = V_23;
		if (L_100)
		{
			goto IL_0206;
		}
	}
	{
		AndroidJavaObjectU5BU5D_tEE28563C9013906CEB39794019A55F4BA5B06120* L_101 = V_20;
		V_3 = (bool)((*(bool*)((bool*)UnBox((RuntimeObject *)L_101, IL2CPP_RGCTX_DATA(method->rgctx_data, 1)))));
		goto IL_0272;
	}

IL_0242:
	{
		Type_t * L_102 = V_0;
		Type_t * L_103 = (Type_t *)L_102;
		G_B31_0 = L_103;
		G_B31_1 = ((String_t*)il2cpp_codegen_initialize_runtime_metadata_inline((uintptr_t*)&_stringLiteral51253131B895C2F8066BCC47E62D44F18F43446C));
		if (L_103)
		{
			G_B32_0 = L_103;
			G_B32_1 = ((String_t*)il2cpp_codegen_initialize_runtime_metadata_inline((uintptr_t*)&_stringLiteral51253131B895C2F8066BCC47E62D44F18F43446C));
			goto IL_0250;
		}
	}
	{
		G_B33_0 = ((String_t*)(NULL));
		G_B33_1 = G_B31_1;
		goto IL_0255;
	}

IL_0250:
	{
		NullCheck((RuntimeObject *)G_B32_0);
		String_t* L_104;
		L_104 = VirtFuncInvoker0< String_t* >::Invoke(3 /* System.String System.Object::ToString() */, (RuntimeObject *)G_B32_0);
		G_B33_0 = L_104;
		G_B33_1 = G_B32_1;
	}

IL_0255:
	{
		String_t* L_105;
		L_105 = String_Concat_m89EAB4C6A96B0E5C3F87300D6BE78D386B9EFC44((String_t*)G_B33_1, (String_t*)G_B33_0, (String_t*)((String_t*)il2cpp_codegen_initialize_runtime_metadata_inline((uintptr_t*)&_stringLiteral42646B33B50B6AA15E22733C8900716F0FE19E1D)), /*hidden argument*/NULL);
		Exception_t * L_106 = (Exception_t *)il2cpp_codegen_object_new(((RuntimeClass*)il2cpp_codegen_initialize_runtime_metadata_inline((uintptr_t*)&Exception_t_il2cpp_TypeInfo_var)));
		Exception__ctor_m8ECDE8ACA7F2E0EF1144BD1200FB5DB2870B5F11(L_106, (String_t*)L_105, /*hidden argument*/NULL);
		IL2CPP_RAISE_MANAGED_EXCEPTION(L_106, ((RuntimeMethod*)il2cpp_codegen_initialize_runtime_metadata_inline((uintptr_t*)&_AndroidJNIHelper_ConvertFromJNIArray_TisBoolean_t07D1E3F34E4813023D64F584DFF7B34C9D922F37_m20E7EDFF477647AD2AAEA5C01F2F96F086673299_RuntimeMethod_var)));
	}

IL_0265:
	{
		il2cpp_codegen_initobj((&V_24), sizeof(bool));
		bool L_107 = V_24;
		V_3 = (bool)L_107;
		goto IL_0272;
	}

IL_0272:
	{
		bool L_108 = V_3;
		return (bool)L_108;
	}
}
// ArrayType UnityEngine._AndroidJNIHelper::ConvertFromJNIArray<System.Char>(System.IntPtr)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR Il2CppChar _AndroidJNIHelper_ConvertFromJNIArray_TisChar_tFF60D8E7E89A20BE2294A003734341BD1DF43E14_mF3A18A8F874B12CB2B14263BF4574ABB14FBCF1E_gshared (intptr_t ___array0, const RuntimeMethod* method)
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&AndroidJavaObjectU5BU5D_tEE28563C9013906CEB39794019A55F4BA5B06120_il2cpp_TypeInfo_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&AndroidJavaObject_t10188D5695DCD09C9F621B44B0A8C93A2281236E_0_0_0_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&AndroidJavaObject_t10188D5695DCD09C9F621B44B0A8C93A2281236E_il2cpp_TypeInfo_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&AndroidReflection_tEB6633FD5B7D2816E1AC6C711E11B2DD33822F16_il2cpp_TypeInfo_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Boolean_t07D1E3F34E4813023D64F584DFF7B34C9D922F37_0_0_0_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Byte_t0111FAB8B8685667EDDAF77683F0D8F86B659056_0_0_0_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Char_tFF60D8E7E89A20BE2294A003734341BD1DF43E14_0_0_0_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Debug_tEB68BCBEB8EFD60F8043C67146DC05E7F50F374B_il2cpp_TypeInfo_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Double_t42821932CB52DE2057E685D0E1AF3DE5033D2181_0_0_0_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Int16_tD0F031114106263BB459DA1F099FF9F42691295A_0_0_0_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Int32_tFDE5F8CD43D10453F6A2E0C77FE48C6CC7009046_0_0_0_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Int64_t378EE0D608BD3107E77238E85F30D2BBD46981F3_0_0_0_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&SByte_t928712DD662DC29BA4FAAE8CE2230AFB23447F0B_0_0_0_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Single_tE07797BA3C98D4CA9B5A19413C19A76688AB899E_0_0_0_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&StringU5BU5D_tACEBFEDE350025B554CD507C9AE8FFE49359549A_il2cpp_TypeInfo_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&String_t_0_0_0_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Type_t_il2cpp_TypeInfo_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&_stringLiteral24CC8D396132365E532646F936DFC8579E2299B2);
		s_Il2CppMethodInitialized = true;
	}
	Type_t * V_0 = NULL;
	bool V_1 = false;
	bool V_2 = false;
	Il2CppChar V_3 = 0x0;
	bool V_4 = false;
	bool V_5 = false;
	bool V_6 = false;
	bool V_7 = false;
	bool V_8 = false;
	bool V_9 = false;
	bool V_10 = false;
	bool V_11 = false;
	bool V_12 = false;
	int32_t V_13 = 0;
	StringU5BU5D_tACEBFEDE350025B554CD507C9AE8FFE49359549A* V_14 = NULL;
	int32_t V_15 = 0;
	intptr_t V_16;
	memset((&V_16), 0, sizeof(V_16));
	bool V_17 = false;
	bool V_18 = false;
	int32_t V_19 = 0;
	AndroidJavaObjectU5BU5D_tEE28563C9013906CEB39794019A55F4BA5B06120* V_20 = NULL;
	int32_t V_21 = 0;
	intptr_t V_22;
	memset((&V_22), 0, sizeof(V_22));
	bool V_23 = false;
	Il2CppChar V_24 = 0x0;
	Type_t * G_B32_0 = NULL;
	String_t* G_B32_1 = NULL;
	Type_t * G_B31_0 = NULL;
	String_t* G_B31_1 = NULL;
	String_t* G_B33_0 = NULL;
	String_t* G_B33_1 = NULL;
	{
		RuntimeTypeHandle_tC33965ADA3E041E0C94AF05E5CB527B56482CEF9  L_0 = { reinterpret_cast<intptr_t> (IL2CPP_RGCTX_TYPE(method->rgctx_data, 0)) };
		IL2CPP_RUNTIME_CLASS_INIT(Type_t_il2cpp_TypeInfo_var);
		Type_t * L_1;
		L_1 = Type_GetTypeFromHandle_m8BB57524FF7F9DB1803BC561D2B3A4DBACEB385E((RuntimeTypeHandle_tC33965ADA3E041E0C94AF05E5CB527B56482CEF9 )L_0, /*hidden argument*/NULL);
		NullCheck((Type_t *)L_1);
		Type_t * L_2;
		L_2 = VirtFuncInvoker0< Type_t * >::Invoke(220 /* System.Type System.Type::GetElementType() */, (Type_t *)L_1);
		V_0 = (Type_t *)L_2;
		Type_t * L_3 = V_0;
		IL2CPP_RUNTIME_CLASS_INIT(AndroidReflection_tEB6633FD5B7D2816E1AC6C711E11B2DD33822F16_il2cpp_TypeInfo_var);
		bool L_4;
		L_4 = AndroidReflection_IsPrimitive_mDD6A4050793DF2FA1EDF58010982C64A3F17376D((Type_t *)L_3, /*hidden argument*/NULL);
		V_1 = (bool)L_4;
		bool L_5 = V_1;
		if (!L_5)
		{
			goto IL_0173;
		}
	}
	{
		Type_t * L_6 = V_0;
		RuntimeTypeHandle_tC33965ADA3E041E0C94AF05E5CB527B56482CEF9  L_7 = { reinterpret_cast<intptr_t> (Int32_tFDE5F8CD43D10453F6A2E0C77FE48C6CC7009046_0_0_0_var) };
		IL2CPP_RUNTIME_CLASS_INIT(Type_t_il2cpp_TypeInfo_var);
		Type_t * L_8;
		L_8 = Type_GetTypeFromHandle_m8BB57524FF7F9DB1803BC561D2B3A4DBACEB385E((RuntimeTypeHandle_tC33965ADA3E041E0C94AF05E5CB527B56482CEF9 )L_7, /*hidden argument*/NULL);
		V_2 = (bool)((((RuntimeObject*)(Type_t *)L_6) == ((RuntimeObject*)(Type_t *)L_8))? 1 : 0);
		bool L_9 = V_2;
		if (!L_9)
		{
			goto IL_0041;
		}
	}
	{
		intptr_t L_10 = ___array0;
		Int32U5BU5D_t70F1BDC14B1786481B176D6139A5E3B87DC54C32* L_11;
		L_11 = AndroidJNISafe_FromIntArray_mBF0C0B4309BA525BBA12D7FD3C2790C8FA7C4703((intptr_t)L_10, /*hidden argument*/NULL);
		V_3 = (Il2CppChar)((*(Il2CppChar*)((Il2CppChar*)UnBox((RuntimeObject *)L_11, IL2CPP_RGCTX_DATA(method->rgctx_data, 1)))));
		goto IL_0272;
	}

IL_0041:
	{
		Type_t * L_12 = V_0;
		RuntimeTypeHandle_tC33965ADA3E041E0C94AF05E5CB527B56482CEF9  L_13 = { reinterpret_cast<intptr_t> (Boolean_t07D1E3F34E4813023D64F584DFF7B34C9D922F37_0_0_0_var) };
		IL2CPP_RUNTIME_CLASS_INIT(Type_t_il2cpp_TypeInfo_var);
		Type_t * L_14;
		L_14 = Type_GetTypeFromHandle_m8BB57524FF7F9DB1803BC561D2B3A4DBACEB385E((RuntimeTypeHandle_tC33965ADA3E041E0C94AF05E5CB527B56482CEF9 )L_13, /*hidden argument*/NULL);
		V_4 = (bool)((((RuntimeObject*)(Type_t *)L_12) == ((RuntimeObject*)(Type_t *)L_14))? 1 : 0);
		bool L_15 = V_4;
		if (!L_15)
		{
			goto IL_0065;
		}
	}
	{
		intptr_t L_16 = ___array0;
		BooleanU5BU5D_tEC7BAF93C44F875016DAADC8696EE3A465644D3C* L_17;
		L_17 = AndroidJNISafe_FromBooleanArray_m77A66C34FCB94ADB1AD5E1D88262500C930A5DBF((intptr_t)L_16, /*hidden argument*/NULL);
		V_3 = (Il2CppChar)((*(Il2CppChar*)((Il2CppChar*)UnBox((RuntimeObject *)L_17, IL2CPP_RGCTX_DATA(method->rgctx_data, 1)))));
		goto IL_0272;
	}

IL_0065:
	{
		Type_t * L_18 = V_0;
		RuntimeTypeHandle_tC33965ADA3E041E0C94AF05E5CB527B56482CEF9  L_19 = { reinterpret_cast<intptr_t> (Byte_t0111FAB8B8685667EDDAF77683F0D8F86B659056_0_0_0_var) };
		IL2CPP_RUNTIME_CLASS_INIT(Type_t_il2cpp_TypeInfo_var);
		Type_t * L_20;
		L_20 = Type_GetTypeFromHandle_m8BB57524FF7F9DB1803BC561D2B3A4DBACEB385E((RuntimeTypeHandle_tC33965ADA3E041E0C94AF05E5CB527B56482CEF9 )L_19, /*hidden argument*/NULL);
		V_5 = (bool)((((RuntimeObject*)(Type_t *)L_18) == ((RuntimeObject*)(Type_t *)L_20))? 1 : 0);
		bool L_21 = V_5;
		if (!L_21)
		{
			goto IL_0095;
		}
	}
	{
		IL2CPP_RUNTIME_CLASS_INIT(Debug_tEB68BCBEB8EFD60F8043C67146DC05E7F50F374B_il2cpp_TypeInfo_var);
		Debug_LogWarning_m24085D883C9E74D7AB423F0625E13259923960E7((RuntimeObject *)_stringLiteral24CC8D396132365E532646F936DFC8579E2299B2, /*hidden argument*/NULL);
		intptr_t L_22 = ___array0;
		ByteU5BU5D_tDBBEB0E8362242FA7223000D978B0DD19D4B0726* L_23;
		L_23 = AndroidJNISafe_FromByteArray_m81760A688AECE368E1CFF7DAAC8E141F1B8FA8A8((intptr_t)L_22, /*hidden argument*/NULL);
		V_3 = (Il2CppChar)((*(Il2CppChar*)((Il2CppChar*)UnBox((RuntimeObject *)L_23, IL2CPP_RGCTX_DATA(method->rgctx_data, 1)))));
		goto IL_0272;
	}

IL_0095:
	{
		Type_t * L_24 = V_0;
		RuntimeTypeHandle_tC33965ADA3E041E0C94AF05E5CB527B56482CEF9  L_25 = { reinterpret_cast<intptr_t> (SByte_t928712DD662DC29BA4FAAE8CE2230AFB23447F0B_0_0_0_var) };
		IL2CPP_RUNTIME_CLASS_INIT(Type_t_il2cpp_TypeInfo_var);
		Type_t * L_26;
		L_26 = Type_GetTypeFromHandle_m8BB57524FF7F9DB1803BC561D2B3A4DBACEB385E((RuntimeTypeHandle_tC33965ADA3E041E0C94AF05E5CB527B56482CEF9 )L_25, /*hidden argument*/NULL);
		V_6 = (bool)((((RuntimeObject*)(Type_t *)L_24) == ((RuntimeObject*)(Type_t *)L_26))? 1 : 0);
		bool L_27 = V_6;
		if (!L_27)
		{
			goto IL_00b9;
		}
	}
	{
		intptr_t L_28 = ___array0;
		SByteU5BU5D_t7D94C53295E6116625EA7CC7DEA21FEDC39869E7* L_29;
		L_29 = AndroidJNISafe_FromSByteArray_m01F6539AF10F86B3927436955B57CC809C52416D((intptr_t)L_28, /*hidden argument*/NULL);
		V_3 = (Il2CppChar)((*(Il2CppChar*)((Il2CppChar*)UnBox((RuntimeObject *)L_29, IL2CPP_RGCTX_DATA(method->rgctx_data, 1)))));
		goto IL_0272;
	}

IL_00b9:
	{
		Type_t * L_30 = V_0;
		RuntimeTypeHandle_tC33965ADA3E041E0C94AF05E5CB527B56482CEF9  L_31 = { reinterpret_cast<intptr_t> (Int16_tD0F031114106263BB459DA1F099FF9F42691295A_0_0_0_var) };
		IL2CPP_RUNTIME_CLASS_INIT(Type_t_il2cpp_TypeInfo_var);
		Type_t * L_32;
		L_32 = Type_GetTypeFromHandle_m8BB57524FF7F9DB1803BC561D2B3A4DBACEB385E((RuntimeTypeHandle_tC33965ADA3E041E0C94AF05E5CB527B56482CEF9 )L_31, /*hidden argument*/NULL);
		V_7 = (bool)((((RuntimeObject*)(Type_t *)L_30) == ((RuntimeObject*)(Type_t *)L_32))? 1 : 0);
		bool L_33 = V_7;
		if (!L_33)
		{
			goto IL_00dd;
		}
	}
	{
		intptr_t L_34 = ___array0;
		Int16U5BU5D_tD134F1E6F746D4C09C987436805256C210C2FFCD* L_35;
		L_35 = AndroidJNISafe_FromShortArray_mCDF5B796D950D31035BD35A2E463D41509E4A5CD((intptr_t)L_34, /*hidden argument*/NULL);
		V_3 = (Il2CppChar)((*(Il2CppChar*)((Il2CppChar*)UnBox((RuntimeObject *)L_35, IL2CPP_RGCTX_DATA(method->rgctx_data, 1)))));
		goto IL_0272;
	}

IL_00dd:
	{
		Type_t * L_36 = V_0;
		RuntimeTypeHandle_tC33965ADA3E041E0C94AF05E5CB527B56482CEF9  L_37 = { reinterpret_cast<intptr_t> (Int64_t378EE0D608BD3107E77238E85F30D2BBD46981F3_0_0_0_var) };
		IL2CPP_RUNTIME_CLASS_INIT(Type_t_il2cpp_TypeInfo_var);
		Type_t * L_38;
		L_38 = Type_GetTypeFromHandle_m8BB57524FF7F9DB1803BC561D2B3A4DBACEB385E((RuntimeTypeHandle_tC33965ADA3E041E0C94AF05E5CB527B56482CEF9 )L_37, /*hidden argument*/NULL);
		V_8 = (bool)((((RuntimeObject*)(Type_t *)L_36) == ((RuntimeObject*)(Type_t *)L_38))? 1 : 0);
		bool L_39 = V_8;
		if (!L_39)
		{
			goto IL_0101;
		}
	}
	{
		intptr_t L_40 = ___array0;
		Int64U5BU5D_tCA61E42872C63A4286B24EEE6E0650143B43DCE6* L_41;
		L_41 = AndroidJNISafe_FromLongArray_m0E7C56CB8CFD0EC240F0D86ECBBFD635FFE55CDA((intptr_t)L_40, /*hidden argument*/NULL);
		V_3 = (Il2CppChar)((*(Il2CppChar*)((Il2CppChar*)UnBox((RuntimeObject *)L_41, IL2CPP_RGCTX_DATA(method->rgctx_data, 1)))));
		goto IL_0272;
	}

IL_0101:
	{
		Type_t * L_42 = V_0;
		RuntimeTypeHandle_tC33965ADA3E041E0C94AF05E5CB527B56482CEF9  L_43 = { reinterpret_cast<intptr_t> (Single_tE07797BA3C98D4CA9B5A19413C19A76688AB899E_0_0_0_var) };
		IL2CPP_RUNTIME_CLASS_INIT(Type_t_il2cpp_TypeInfo_var);
		Type_t * L_44;
		L_44 = Type_GetTypeFromHandle_m8BB57524FF7F9DB1803BC561D2B3A4DBACEB385E((RuntimeTypeHandle_tC33965ADA3E041E0C94AF05E5CB527B56482CEF9 )L_43, /*hidden argument*/NULL);
		V_9 = (bool)((((RuntimeObject*)(Type_t *)L_42) == ((RuntimeObject*)(Type_t *)L_44))? 1 : 0);
		bool L_45 = V_9;
		if (!L_45)
		{
			goto IL_0125;
		}
	}
	{
		intptr_t L_46 = ___array0;
		SingleU5BU5D_t47E8DBF5B597C122478D1FFBD9DD57399A0650FA* L_47;
		L_47 = AndroidJNISafe_FromFloatArray_mF6A63CA1B7C10BC27EEC033F0E390772DFDD652D((intptr_t)L_46, /*hidden argument*/NULL);
		V_3 = (Il2CppChar)((*(Il2CppChar*)((Il2CppChar*)UnBox((RuntimeObject *)L_47, IL2CPP_RGCTX_DATA(method->rgctx_data, 1)))));
		goto IL_0272;
	}

IL_0125:
	{
		Type_t * L_48 = V_0;
		RuntimeTypeHandle_tC33965ADA3E041E0C94AF05E5CB527B56482CEF9  L_49 = { reinterpret_cast<intptr_t> (Double_t42821932CB52DE2057E685D0E1AF3DE5033D2181_0_0_0_var) };
		IL2CPP_RUNTIME_CLASS_INIT(Type_t_il2cpp_TypeInfo_var);
		Type_t * L_50;
		L_50 = Type_GetTypeFromHandle_m8BB57524FF7F9DB1803BC561D2B3A4DBACEB385E((RuntimeTypeHandle_tC33965ADA3E041E0C94AF05E5CB527B56482CEF9 )L_49, /*hidden argument*/NULL);
		V_10 = (bool)((((RuntimeObject*)(Type_t *)L_48) == ((RuntimeObject*)(Type_t *)L_50))? 1 : 0);
		bool L_51 = V_10;
		if (!L_51)
		{
			goto IL_0149;
		}
	}
	{
		intptr_t L_52 = ___array0;
		DoubleU5BU5D_t8E1B42EB2ABB79FBD193A6B8C8D97A7CDE44A4FB* L_53;
		L_53 = AndroidJNISafe_FromDoubleArray_m9438B5668E8B2DB3B18CACFF0CC9CAEAB5EC73C8((intptr_t)L_52, /*hidden argument*/NULL);
		V_3 = (Il2CppChar)((*(Il2CppChar*)((Il2CppChar*)UnBox((RuntimeObject *)L_53, IL2CPP_RGCTX_DATA(method->rgctx_data, 1)))));
		goto IL_0272;
	}

IL_0149:
	{
		Type_t * L_54 = V_0;
		RuntimeTypeHandle_tC33965ADA3E041E0C94AF05E5CB527B56482CEF9  L_55 = { reinterpret_cast<intptr_t> (Char_tFF60D8E7E89A20BE2294A003734341BD1DF43E14_0_0_0_var) };
		IL2CPP_RUNTIME_CLASS_INIT(Type_t_il2cpp_TypeInfo_var);
		Type_t * L_56;
		L_56 = Type_GetTypeFromHandle_m8BB57524FF7F9DB1803BC561D2B3A4DBACEB385E((RuntimeTypeHandle_tC33965ADA3E041E0C94AF05E5CB527B56482CEF9 )L_55, /*hidden argument*/NULL);
		V_11 = (bool)((((RuntimeObject*)(Type_t *)L_54) == ((RuntimeObject*)(Type_t *)L_56))? 1 : 0);
		bool L_57 = V_11;
		if (!L_57)
		{
			goto IL_016d;
		}
	}
	{
		intptr_t L_58 = ___array0;
		CharU5BU5D_t7B7FC5BC8091AA3B9CB0B29CDD80B5EE9254AA34* L_59;
		L_59 = AndroidJNISafe_FromCharArray_mA49DB27755EF3B2AE81487E0FCFE06E23F617305((intptr_t)L_58, /*hidden argument*/NULL);
		V_3 = (Il2CppChar)((*(Il2CppChar*)((Il2CppChar*)UnBox((RuntimeObject *)L_59, IL2CPP_RGCTX_DATA(method->rgctx_data, 1)))));
		goto IL_0272;
	}

IL_016d:
	{
		goto IL_0265;
	}

IL_0173:
	{
		Type_t * L_60 = V_0;
		RuntimeTypeHandle_tC33965ADA3E041E0C94AF05E5CB527B56482CEF9  L_61 = { reinterpret_cast<intptr_t> (String_t_0_0_0_var) };
		IL2CPP_RUNTIME_CLASS_INIT(Type_t_il2cpp_TypeInfo_var);
		Type_t * L_62;
		L_62 = Type_GetTypeFromHandle_m8BB57524FF7F9DB1803BC561D2B3A4DBACEB385E((RuntimeTypeHandle_tC33965ADA3E041E0C94AF05E5CB527B56482CEF9 )L_61, /*hidden argument*/NULL);
		V_12 = (bool)((((RuntimeObject*)(Type_t *)L_60) == ((RuntimeObject*)(Type_t *)L_62))? 1 : 0);
		bool L_63 = V_12;
		if (!L_63)
		{
			goto IL_01dc;
		}
	}
	{
		intptr_t L_64 = ___array0;
		int32_t L_65;
		L_65 = AndroidJNISafe_GetArrayLength_m3015C191DBFC246946A88592731441A934507B56((intptr_t)L_64, /*hidden argument*/NULL);
		V_13 = (int32_t)L_65;
		int32_t L_66 = V_13;
		StringU5BU5D_tACEBFEDE350025B554CD507C9AE8FFE49359549A* L_67 = (StringU5BU5D_tACEBFEDE350025B554CD507C9AE8FFE49359549A*)(StringU5BU5D_tACEBFEDE350025B554CD507C9AE8FFE49359549A*)SZArrayNew(StringU5BU5D_tACEBFEDE350025B554CD507C9AE8FFE49359549A_il2cpp_TypeInfo_var, (uint32_t)L_66);
		V_14 = (StringU5BU5D_tACEBFEDE350025B554CD507C9AE8FFE49359549A*)L_67;
		V_15 = (int32_t)0;
		goto IL_01c3;
	}

IL_019d:
	{
		intptr_t L_68 = ___array0;
		int32_t L_69 = V_15;
		intptr_t L_70;
		L_70 = AndroidJNI_GetObjectArrayElement_m502026BF77232EE45D03661E4923C2E5E99FDE18((intptr_t)L_68, (int32_t)L_69, /*hidden argument*/NULL);
		V_16 = (intptr_t)L_70;
		StringU5BU5D_tACEBFEDE350025B554CD507C9AE8FFE49359549A* L_71 = V_14;
		int32_t L_72 = V_15;
		intptr_t L_73 = V_16;
		String_t* L_74;
		L_74 = AndroidJNISafe_GetStringChars_mD59FFDE4192F837E1380B51569B5803E09BE58C8((intptr_t)L_73, /*hidden argument*/NULL);
		NullCheck(L_71);
		ArrayElementTypeCheck (L_71, L_74);
		(L_71)->SetAt(static_cast<il2cpp_array_size_t>(L_72), (String_t*)L_74);
		intptr_t L_75 = V_16;
		AndroidJNISafe_DeleteLocalRef_m7AB242A76D13A3BF4C04831D77960C020D6ADA39((intptr_t)L_75, /*hidden argument*/NULL);
		int32_t L_76 = V_15;
		V_15 = (int32_t)((int32_t)il2cpp_codegen_add((int32_t)L_76, (int32_t)1));
	}

IL_01c3:
	{
		int32_t L_77 = V_15;
		int32_t L_78 = V_13;
		V_17 = (bool)((((int32_t)L_77) < ((int32_t)L_78))? 1 : 0);
		bool L_79 = V_17;
		if (L_79)
		{
			goto IL_019d;
		}
	}
	{
		StringU5BU5D_tACEBFEDE350025B554CD507C9AE8FFE49359549A* L_80 = V_14;
		V_3 = (Il2CppChar)((*(Il2CppChar*)((Il2CppChar*)UnBox((RuntimeObject *)L_80, IL2CPP_RGCTX_DATA(method->rgctx_data, 1)))));
		goto IL_0272;
	}

IL_01dc:
	{
		Type_t * L_81 = V_0;
		RuntimeTypeHandle_tC33965ADA3E041E0C94AF05E5CB527B56482CEF9  L_82 = { reinterpret_cast<intptr_t> (AndroidJavaObject_t10188D5695DCD09C9F621B44B0A8C93A2281236E_0_0_0_var) };
		IL2CPP_RUNTIME_CLASS_INIT(Type_t_il2cpp_TypeInfo_var);
		Type_t * L_83;
		L_83 = Type_GetTypeFromHandle_m8BB57524FF7F9DB1803BC561D2B3A4DBACEB385E((RuntimeTypeHandle_tC33965ADA3E041E0C94AF05E5CB527B56482CEF9 )L_82, /*hidden argument*/NULL);
		V_18 = (bool)((((RuntimeObject*)(Type_t *)L_81) == ((RuntimeObject*)(Type_t *)L_83))? 1 : 0);
		bool L_84 = V_18;
		if (!L_84)
		{
			goto IL_0242;
		}
	}
	{
		intptr_t L_85 = ___array0;
		int32_t L_86;
		L_86 = AndroidJNISafe_GetArrayLength_m3015C191DBFC246946A88592731441A934507B56((intptr_t)L_85, /*hidden argument*/NULL);
		V_19 = (int32_t)L_86;
		int32_t L_87 = V_19;
		AndroidJavaObjectU5BU5D_tEE28563C9013906CEB39794019A55F4BA5B06120* L_88 = (AndroidJavaObjectU5BU5D_tEE28563C9013906CEB39794019A55F4BA5B06120*)(AndroidJavaObjectU5BU5D_tEE28563C9013906CEB39794019A55F4BA5B06120*)SZArrayNew(AndroidJavaObjectU5BU5D_tEE28563C9013906CEB39794019A55F4BA5B06120_il2cpp_TypeInfo_var, (uint32_t)L_87);
		V_20 = (AndroidJavaObjectU5BU5D_tEE28563C9013906CEB39794019A55F4BA5B06120*)L_88;
		V_21 = (int32_t)0;
		goto IL_022c;
	}

IL_0206:
	{
		intptr_t L_89 = ___array0;
		int32_t L_90 = V_21;
		intptr_t L_91;
		L_91 = AndroidJNI_GetObjectArrayElement_m502026BF77232EE45D03661E4923C2E5E99FDE18((intptr_t)L_89, (int32_t)L_90, /*hidden argument*/NULL);
		V_22 = (intptr_t)L_91;
		AndroidJavaObjectU5BU5D_tEE28563C9013906CEB39794019A55F4BA5B06120* L_92 = V_20;
		int32_t L_93 = V_21;
		intptr_t L_94 = V_22;
		AndroidJavaObject_t10188D5695DCD09C9F621B44B0A8C93A2281236E * L_95 = (AndroidJavaObject_t10188D5695DCD09C9F621B44B0A8C93A2281236E *)il2cpp_codegen_object_new(AndroidJavaObject_t10188D5695DCD09C9F621B44B0A8C93A2281236E_il2cpp_TypeInfo_var);
		AndroidJavaObject__ctor_m880F6533139DF0BD36C6EF428E45E9F44B6534A3(L_95, (intptr_t)L_94, /*hidden argument*/NULL);
		NullCheck(L_92);
		ArrayElementTypeCheck (L_92, L_95);
		(L_92)->SetAt(static_cast<il2cpp_array_size_t>(L_93), (AndroidJavaObject_t10188D5695DCD09C9F621B44B0A8C93A2281236E *)L_95);
		intptr_t L_96 = V_22;
		AndroidJNISafe_DeleteLocalRef_m7AB242A76D13A3BF4C04831D77960C020D6ADA39((intptr_t)L_96, /*hidden argument*/NULL);
		int32_t L_97 = V_21;
		V_21 = (int32_t)((int32_t)il2cpp_codegen_add((int32_t)L_97, (int32_t)1));
	}

IL_022c:
	{
		int32_t L_98 = V_21;
		int32_t L_99 = V_19;
		V_23 = (bool)((((int32_t)L_98) < ((int32_t)L_99))? 1 : 0);
		bool L_100 = V_23;
		if (L_100)
		{
			goto IL_0206;
		}
	}
	{
		AndroidJavaObjectU5BU5D_tEE28563C9013906CEB39794019A55F4BA5B06120* L_101 = V_20;
		V_3 = (Il2CppChar)((*(Il2CppChar*)((Il2CppChar*)UnBox((RuntimeObject *)L_101, IL2CPP_RGCTX_DATA(method->rgctx_data, 1)))));
		goto IL_0272;
	}

IL_0242:
	{
		Type_t * L_102 = V_0;
		Type_t * L_103 = (Type_t *)L_102;
		G_B31_0 = L_103;
		G_B31_1 = ((String_t*)il2cpp_codegen_initialize_runtime_metadata_inline((uintptr_t*)&_stringLiteral51253131B895C2F8066BCC47E62D44F18F43446C));
		if (L_103)
		{
			G_B32_0 = L_103;
			G_B32_1 = ((String_t*)il2cpp_codegen_initialize_runtime_metadata_inline((uintptr_t*)&_stringLiteral51253131B895C2F8066BCC47E62D44F18F43446C));
			goto IL_0250;
		}
	}
	{
		G_B33_0 = ((String_t*)(NULL));
		G_B33_1 = G_B31_1;
		goto IL_0255;
	}

IL_0250:
	{
		NullCheck((RuntimeObject *)G_B32_0);
		String_t* L_104;
		L_104 = VirtFuncInvoker0< String_t* >::Invoke(3 /* System.String System.Object::ToString() */, (RuntimeObject *)G_B32_0);
		G_B33_0 = L_104;
		G_B33_1 = G_B32_1;
	}

IL_0255:
	{
		String_t* L_105;
		L_105 = String_Concat_m89EAB4C6A96B0E5C3F87300D6BE78D386B9EFC44((String_t*)G_B33_1, (String_t*)G_B33_0, (String_t*)((String_t*)il2cpp_codegen_initialize_runtime_metadata_inline((uintptr_t*)&_stringLiteral42646B33B50B6AA15E22733C8900716F0FE19E1D)), /*hidden argument*/NULL);
		Exception_t * L_106 = (Exception_t *)il2cpp_codegen_object_new(((RuntimeClass*)il2cpp_codegen_initialize_runtime_metadata_inline((uintptr_t*)&Exception_t_il2cpp_TypeInfo_var)));
		Exception__ctor_m8ECDE8ACA7F2E0EF1144BD1200FB5DB2870B5F11(L_106, (String_t*)L_105, /*hidden argument*/NULL);
		IL2CPP_RAISE_MANAGED_EXCEPTION(L_106, ((RuntimeMethod*)il2cpp_codegen_initialize_runtime_metadata_inline((uintptr_t*)&_AndroidJNIHelper_ConvertFromJNIArray_TisChar_tFF60D8E7E89A20BE2294A003734341BD1DF43E14_mF3A18A8F874B12CB2B14263BF4574ABB14FBCF1E_RuntimeMethod_var)));
	}

IL_0265:
	{
		il2cpp_codegen_initobj((&V_24), sizeof(Il2CppChar));
		Il2CppChar L_107 = V_24;
		V_3 = (Il2CppChar)L_107;
		goto IL_0272;
	}

IL_0272:
	{
		Il2CppChar L_108 = V_3;
		return (Il2CppChar)L_108;
	}
}
// ArrayType UnityEngine._AndroidJNIHelper::ConvertFromJNIArray<System.Double>(System.IntPtr)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR double _AndroidJNIHelper_ConvertFromJNIArray_TisDouble_t42821932CB52DE2057E685D0E1AF3DE5033D2181_m5DFA0BED6B580096B2E3ADB1394F918653E21D07_gshared (intptr_t ___array0, const RuntimeMethod* method)
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&AndroidJavaObjectU5BU5D_tEE28563C9013906CEB39794019A55F4BA5B06120_il2cpp_TypeInfo_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&AndroidJavaObject_t10188D5695DCD09C9F621B44B0A8C93A2281236E_0_0_0_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&AndroidJavaObject_t10188D5695DCD09C9F621B44B0A8C93A2281236E_il2cpp_TypeInfo_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&AndroidReflection_tEB6633FD5B7D2816E1AC6C711E11B2DD33822F16_il2cpp_TypeInfo_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Boolean_t07D1E3F34E4813023D64F584DFF7B34C9D922F37_0_0_0_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Byte_t0111FAB8B8685667EDDAF77683F0D8F86B659056_0_0_0_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Char_tFF60D8E7E89A20BE2294A003734341BD1DF43E14_0_0_0_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Debug_tEB68BCBEB8EFD60F8043C67146DC05E7F50F374B_il2cpp_TypeInfo_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Double_t42821932CB52DE2057E685D0E1AF3DE5033D2181_0_0_0_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Int16_tD0F031114106263BB459DA1F099FF9F42691295A_0_0_0_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Int32_tFDE5F8CD43D10453F6A2E0C77FE48C6CC7009046_0_0_0_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Int64_t378EE0D608BD3107E77238E85F30D2BBD46981F3_0_0_0_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&SByte_t928712DD662DC29BA4FAAE8CE2230AFB23447F0B_0_0_0_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Single_tE07797BA3C98D4CA9B5A19413C19A76688AB899E_0_0_0_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&StringU5BU5D_tACEBFEDE350025B554CD507C9AE8FFE49359549A_il2cpp_TypeInfo_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&String_t_0_0_0_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Type_t_il2cpp_TypeInfo_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&_stringLiteral24CC8D396132365E532646F936DFC8579E2299B2);
		s_Il2CppMethodInitialized = true;
	}
	Type_t * V_0 = NULL;
	bool V_1 = false;
	bool V_2 = false;
	double V_3 = 0.0;
	bool V_4 = false;
	bool V_5 = false;
	bool V_6 = false;
	bool V_7 = false;
	bool V_8 = false;
	bool V_9 = false;
	bool V_10 = false;
	bool V_11 = false;
	bool V_12 = false;
	int32_t V_13 = 0;
	StringU5BU5D_tACEBFEDE350025B554CD507C9AE8FFE49359549A* V_14 = NULL;
	int32_t V_15 = 0;
	intptr_t V_16;
	memset((&V_16), 0, sizeof(V_16));
	bool V_17 = false;
	bool V_18 = false;
	int32_t V_19 = 0;
	AndroidJavaObjectU5BU5D_tEE28563C9013906CEB39794019A55F4BA5B06120* V_20 = NULL;
	int32_t V_21 = 0;
	intptr_t V_22;
	memset((&V_22), 0, sizeof(V_22));
	bool V_23 = false;
	double V_24 = 0.0;
	Type_t * G_B32_0 = NULL;
	String_t* G_B32_1 = NULL;
	Type_t * G_B31_0 = NULL;
	String_t* G_B31_1 = NULL;
	String_t* G_B33_0 = NULL;
	String_t* G_B33_1 = NULL;
	{
		RuntimeTypeHandle_tC33965ADA3E041E0C94AF05E5CB527B56482CEF9  L_0 = { reinterpret_cast<intptr_t> (IL2CPP_RGCTX_TYPE(method->rgctx_data, 0)) };
		IL2CPP_RUNTIME_CLASS_INIT(Type_t_il2cpp_TypeInfo_var);
		Type_t * L_1;
		L_1 = Type_GetTypeFromHandle_m8BB57524FF7F9DB1803BC561D2B3A4DBACEB385E((RuntimeTypeHandle_tC33965ADA3E041E0C94AF05E5CB527B56482CEF9 )L_0, /*hidden argument*/NULL);
		NullCheck((Type_t *)L_1);
		Type_t * L_2;
		L_2 = VirtFuncInvoker0< Type_t * >::Invoke(220 /* System.Type System.Type::GetElementType() */, (Type_t *)L_1);
		V_0 = (Type_t *)L_2;
		Type_t * L_3 = V_0;
		IL2CPP_RUNTIME_CLASS_INIT(AndroidReflection_tEB6633FD5B7D2816E1AC6C711E11B2DD33822F16_il2cpp_TypeInfo_var);
		bool L_4;
		L_4 = AndroidReflection_IsPrimitive_mDD6A4050793DF2FA1EDF58010982C64A3F17376D((Type_t *)L_3, /*hidden argument*/NULL);
		V_1 = (bool)L_4;
		bool L_5 = V_1;
		if (!L_5)
		{
			goto IL_0173;
		}
	}
	{
		Type_t * L_6 = V_0;
		RuntimeTypeHandle_tC33965ADA3E041E0C94AF05E5CB527B56482CEF9  L_7 = { reinterpret_cast<intptr_t> (Int32_tFDE5F8CD43D10453F6A2E0C77FE48C6CC7009046_0_0_0_var) };
		IL2CPP_RUNTIME_CLASS_INIT(Type_t_il2cpp_TypeInfo_var);
		Type_t * L_8;
		L_8 = Type_GetTypeFromHandle_m8BB57524FF7F9DB1803BC561D2B3A4DBACEB385E((RuntimeTypeHandle_tC33965ADA3E041E0C94AF05E5CB527B56482CEF9 )L_7, /*hidden argument*/NULL);
		V_2 = (bool)((((RuntimeObject*)(Type_t *)L_6) == ((RuntimeObject*)(Type_t *)L_8))? 1 : 0);
		bool L_9 = V_2;
		if (!L_9)
		{
			goto IL_0041;
		}
	}
	{
		intptr_t L_10 = ___array0;
		Int32U5BU5D_t70F1BDC14B1786481B176D6139A5E3B87DC54C32* L_11;
		L_11 = AndroidJNISafe_FromIntArray_mBF0C0B4309BA525BBA12D7FD3C2790C8FA7C4703((intptr_t)L_10, /*hidden argument*/NULL);
		V_3 = (double)((*(double*)((double*)UnBox((RuntimeObject *)L_11, IL2CPP_RGCTX_DATA(method->rgctx_data, 1)))));
		goto IL_0272;
	}

IL_0041:
	{
		Type_t * L_12 = V_0;
		RuntimeTypeHandle_tC33965ADA3E041E0C94AF05E5CB527B56482CEF9  L_13 = { reinterpret_cast<intptr_t> (Boolean_t07D1E3F34E4813023D64F584DFF7B34C9D922F37_0_0_0_var) };
		IL2CPP_RUNTIME_CLASS_INIT(Type_t_il2cpp_TypeInfo_var);
		Type_t * L_14;
		L_14 = Type_GetTypeFromHandle_m8BB57524FF7F9DB1803BC561D2B3A4DBACEB385E((RuntimeTypeHandle_tC33965ADA3E041E0C94AF05E5CB527B56482CEF9 )L_13, /*hidden argument*/NULL);
		V_4 = (bool)((((RuntimeObject*)(Type_t *)L_12) == ((RuntimeObject*)(Type_t *)L_14))? 1 : 0);
		bool L_15 = V_4;
		if (!L_15)
		{
			goto IL_0065;
		}
	}
	{
		intptr_t L_16 = ___array0;
		BooleanU5BU5D_tEC7BAF93C44F875016DAADC8696EE3A465644D3C* L_17;
		L_17 = AndroidJNISafe_FromBooleanArray_m77A66C34FCB94ADB1AD5E1D88262500C930A5DBF((intptr_t)L_16, /*hidden argument*/NULL);
		V_3 = (double)((*(double*)((double*)UnBox((RuntimeObject *)L_17, IL2CPP_RGCTX_DATA(method->rgctx_data, 1)))));
		goto IL_0272;
	}

IL_0065:
	{
		Type_t * L_18 = V_0;
		RuntimeTypeHandle_tC33965ADA3E041E0C94AF05E5CB527B56482CEF9  L_19 = { reinterpret_cast<intptr_t> (Byte_t0111FAB8B8685667EDDAF77683F0D8F86B659056_0_0_0_var) };
		IL2CPP_RUNTIME_CLASS_INIT(Type_t_il2cpp_TypeInfo_var);
		Type_t * L_20;
		L_20 = Type_GetTypeFromHandle_m8BB57524FF7F9DB1803BC561D2B3A4DBACEB385E((RuntimeTypeHandle_tC33965ADA3E041E0C94AF05E5CB527B56482CEF9 )L_19, /*hidden argument*/NULL);
		V_5 = (bool)((((RuntimeObject*)(Type_t *)L_18) == ((RuntimeObject*)(Type_t *)L_20))? 1 : 0);
		bool L_21 = V_5;
		if (!L_21)
		{
			goto IL_0095;
		}
	}
	{
		IL2CPP_RUNTIME_CLASS_INIT(Debug_tEB68BCBEB8EFD60F8043C67146DC05E7F50F374B_il2cpp_TypeInfo_var);
		Debug_LogWarning_m24085D883C9E74D7AB423F0625E13259923960E7((RuntimeObject *)_stringLiteral24CC8D396132365E532646F936DFC8579E2299B2, /*hidden argument*/NULL);
		intptr_t L_22 = ___array0;
		ByteU5BU5D_tDBBEB0E8362242FA7223000D978B0DD19D4B0726* L_23;
		L_23 = AndroidJNISafe_FromByteArray_m81760A688AECE368E1CFF7DAAC8E141F1B8FA8A8((intptr_t)L_22, /*hidden argument*/NULL);
		V_3 = (double)((*(double*)((double*)UnBox((RuntimeObject *)L_23, IL2CPP_RGCTX_DATA(method->rgctx_data, 1)))));
		goto IL_0272;
	}

IL_0095:
	{
		Type_t * L_24 = V_0;
		RuntimeTypeHandle_tC33965ADA3E041E0C94AF05E5CB527B56482CEF9  L_25 = { reinterpret_cast<intptr_t> (SByte_t928712DD662DC29BA4FAAE8CE2230AFB23447F0B_0_0_0_var) };
		IL2CPP_RUNTIME_CLASS_INIT(Type_t_il2cpp_TypeInfo_var);
		Type_t * L_26;
		L_26 = Type_GetTypeFromHandle_m8BB57524FF7F9DB1803BC561D2B3A4DBACEB385E((RuntimeTypeHandle_tC33965ADA3E041E0C94AF05E5CB527B56482CEF9 )L_25, /*hidden argument*/NULL);
		V_6 = (bool)((((RuntimeObject*)(Type_t *)L_24) == ((RuntimeObject*)(Type_t *)L_26))? 1 : 0);
		bool L_27 = V_6;
		if (!L_27)
		{
			goto IL_00b9;
		}
	}
	{
		intptr_t L_28 = ___array0;
		SByteU5BU5D_t7D94C53295E6116625EA7CC7DEA21FEDC39869E7* L_29;
		L_29 = AndroidJNISafe_FromSByteArray_m01F6539AF10F86B3927436955B57CC809C52416D((intptr_t)L_28, /*hidden argument*/NULL);
		V_3 = (double)((*(double*)((double*)UnBox((RuntimeObject *)L_29, IL2CPP_RGCTX_DATA(method->rgctx_data, 1)))));
		goto IL_0272;
	}

IL_00b9:
	{
		Type_t * L_30 = V_0;
		RuntimeTypeHandle_tC33965ADA3E041E0C94AF05E5CB527B56482CEF9  L_31 = { reinterpret_cast<intptr_t> (Int16_tD0F031114106263BB459DA1F099FF9F42691295A_0_0_0_var) };
		IL2CPP_RUNTIME_CLASS_INIT(Type_t_il2cpp_TypeInfo_var);
		Type_t * L_32;
		L_32 = Type_GetTypeFromHandle_m8BB57524FF7F9DB1803BC561D2B3A4DBACEB385E((RuntimeTypeHandle_tC33965ADA3E041E0C94AF05E5CB527B56482CEF9 )L_31, /*hidden argument*/NULL);
		V_7 = (bool)((((RuntimeObject*)(Type_t *)L_30) == ((RuntimeObject*)(Type_t *)L_32))? 1 : 0);
		bool L_33 = V_7;
		if (!L_33)
		{
			goto IL_00dd;
		}
	}
	{
		intptr_t L_34 = ___array0;
		Int16U5BU5D_tD134F1E6F746D4C09C987436805256C210C2FFCD* L_35;
		L_35 = AndroidJNISafe_FromShortArray_mCDF5B796D950D31035BD35A2E463D41509E4A5CD((intptr_t)L_34, /*hidden argument*/NULL);
		V_3 = (double)((*(double*)((double*)UnBox((RuntimeObject *)L_35, IL2CPP_RGCTX_DATA(method->rgctx_data, 1)))));
		goto IL_0272;
	}

IL_00dd:
	{
		Type_t * L_36 = V_0;
		RuntimeTypeHandle_tC33965ADA3E041E0C94AF05E5CB527B56482CEF9  L_37 = { reinterpret_cast<intptr_t> (Int64_t378EE0D608BD3107E77238E85F30D2BBD46981F3_0_0_0_var) };
		IL2CPP_RUNTIME_CLASS_INIT(Type_t_il2cpp_TypeInfo_var);
		Type_t * L_38;
		L_38 = Type_GetTypeFromHandle_m8BB57524FF7F9DB1803BC561D2B3A4DBACEB385E((RuntimeTypeHandle_tC33965ADA3E041E0C94AF05E5CB527B56482CEF9 )L_37, /*hidden argument*/NULL);
		V_8 = (bool)((((RuntimeObject*)(Type_t *)L_36) == ((RuntimeObject*)(Type_t *)L_38))? 1 : 0);
		bool L_39 = V_8;
		if (!L_39)
		{
			goto IL_0101;
		}
	}
	{
		intptr_t L_40 = ___array0;
		Int64U5BU5D_tCA61E42872C63A4286B24EEE6E0650143B43DCE6* L_41;
		L_41 = AndroidJNISafe_FromLongArray_m0E7C56CB8CFD0EC240F0D86ECBBFD635FFE55CDA((intptr_t)L_40, /*hidden argument*/NULL);
		V_3 = (double)((*(double*)((double*)UnBox((RuntimeObject *)L_41, IL2CPP_RGCTX_DATA(method->rgctx_data, 1)))));
		goto IL_0272;
	}

IL_0101:
	{
		Type_t * L_42 = V_0;
		RuntimeTypeHandle_tC33965ADA3E041E0C94AF05E5CB527B56482CEF9  L_43 = { reinterpret_cast<intptr_t> (Single_tE07797BA3C98D4CA9B5A19413C19A76688AB899E_0_0_0_var) };
		IL2CPP_RUNTIME_CLASS_INIT(Type_t_il2cpp_TypeInfo_var);
		Type_t * L_44;
		L_44 = Type_GetTypeFromHandle_m8BB57524FF7F9DB1803BC561D2B3A4DBACEB385E((RuntimeTypeHandle_tC33965ADA3E041E0C94AF05E5CB527B56482CEF9 )L_43, /*hidden argument*/NULL);
		V_9 = (bool)((((RuntimeObject*)(Type_t *)L_42) == ((RuntimeObject*)(Type_t *)L_44))? 1 : 0);
		bool L_45 = V_9;
		if (!L_45)
		{
			goto IL_0125;
		}
	}
	{
		intptr_t L_46 = ___array0;
		SingleU5BU5D_t47E8DBF5B597C122478D1FFBD9DD57399A0650FA* L_47;
		L_47 = AndroidJNISafe_FromFloatArray_mF6A63CA1B7C10BC27EEC033F0E390772DFDD652D((intptr_t)L_46, /*hidden argument*/NULL);
		V_3 = (double)((*(double*)((double*)UnBox((RuntimeObject *)L_47, IL2CPP_RGCTX_DATA(method->rgctx_data, 1)))));
		goto IL_0272;
	}

IL_0125:
	{
		Type_t * L_48 = V_0;
		RuntimeTypeHandle_tC33965ADA3E041E0C94AF05E5CB527B56482CEF9  L_49 = { reinterpret_cast<intptr_t> (Double_t42821932CB52DE2057E685D0E1AF3DE5033D2181_0_0_0_var) };
		IL2CPP_RUNTIME_CLASS_INIT(Type_t_il2cpp_TypeInfo_var);
		Type_t * L_50;
		L_50 = Type_GetTypeFromHandle_m8BB57524FF7F9DB1803BC561D2B3A4DBACEB385E((RuntimeTypeHandle_tC33965ADA3E041E0C94AF05E5CB527B56482CEF9 )L_49, /*hidden argument*/NULL);
		V_10 = (bool)((((RuntimeObject*)(Type_t *)L_48) == ((RuntimeObject*)(Type_t *)L_50))? 1 : 0);
		bool L_51 = V_10;
		if (!L_51)
		{
			goto IL_0149;
		}
	}
	{
		intptr_t L_52 = ___array0;
		DoubleU5BU5D_t8E1B42EB2ABB79FBD193A6B8C8D97A7CDE44A4FB* L_53;
		L_53 = AndroidJNISafe_FromDoubleArray_m9438B5668E8B2DB3B18CACFF0CC9CAEAB5EC73C8((intptr_t)L_52, /*hidden argument*/NULL);
		V_3 = (double)((*(double*)((double*)UnBox((RuntimeObject *)L_53, IL2CPP_RGCTX_DATA(method->rgctx_data, 1)))));
		goto IL_0272;
	}

IL_0149:
	{
		Type_t * L_54 = V_0;
		RuntimeTypeHandle_tC33965ADA3E041E0C94AF05E5CB527B56482CEF9  L_55 = { reinterpret_cast<intptr_t> (Char_tFF60D8E7E89A20BE2294A003734341BD1DF43E14_0_0_0_var) };
		IL2CPP_RUNTIME_CLASS_INIT(Type_t_il2cpp_TypeInfo_var);
		Type_t * L_56;
		L_56 = Type_GetTypeFromHandle_m8BB57524FF7F9DB1803BC561D2B3A4DBACEB385E((RuntimeTypeHandle_tC33965ADA3E041E0C94AF05E5CB527B56482CEF9 )L_55, /*hidden argument*/NULL);
		V_11 = (bool)((((RuntimeObject*)(Type_t *)L_54) == ((RuntimeObject*)(Type_t *)L_56))? 1 : 0);
		bool L_57 = V_11;
		if (!L_57)
		{
			goto IL_016d;
		}
	}
	{
		intptr_t L_58 = ___array0;
		CharU5BU5D_t7B7FC5BC8091AA3B9CB0B29CDD80B5EE9254AA34* L_59;
		L_59 = AndroidJNISafe_FromCharArray_mA49DB27755EF3B2AE81487E0FCFE06E23F617305((intptr_t)L_58, /*hidden argument*/NULL);
		V_3 = (double)((*(double*)((double*)UnBox((RuntimeObject *)L_59, IL2CPP_RGCTX_DATA(method->rgctx_data, 1)))));
		goto IL_0272;
	}

IL_016d:
	{
		goto IL_0265;
	}

IL_0173:
	{
		Type_t * L_60 = V_0;
		RuntimeTypeHandle_tC33965ADA3E041E0C94AF05E5CB527B56482CEF9  L_61 = { reinterpret_cast<intptr_t> (String_t_0_0_0_var) };
		IL2CPP_RUNTIME_CLASS_INIT(Type_t_il2cpp_TypeInfo_var);
		Type_t * L_62;
		L_62 = Type_GetTypeFromHandle_m8BB57524FF7F9DB1803BC561D2B3A4DBACEB385E((RuntimeTypeHandle_tC33965ADA3E041E0C94AF05E5CB527B56482CEF9 )L_61, /*hidden argument*/NULL);
		V_12 = (bool)((((RuntimeObject*)(Type_t *)L_60) == ((RuntimeObject*)(Type_t *)L_62))? 1 : 0);
		bool L_63 = V_12;
		if (!L_63)
		{
			goto IL_01dc;
		}
	}
	{
		intptr_t L_64 = ___array0;
		int32_t L_65;
		L_65 = AndroidJNISafe_GetArrayLength_m3015C191DBFC246946A88592731441A934507B56((intptr_t)L_64, /*hidden argument*/NULL);
		V_13 = (int32_t)L_65;
		int32_t L_66 = V_13;
		StringU5BU5D_tACEBFEDE350025B554CD507C9AE8FFE49359549A* L_67 = (StringU5BU5D_tACEBFEDE350025B554CD507C9AE8FFE49359549A*)(StringU5BU5D_tACEBFEDE350025B554CD507C9AE8FFE49359549A*)SZArrayNew(StringU5BU5D_tACEBFEDE350025B554CD507C9AE8FFE49359549A_il2cpp_TypeInfo_var, (uint32_t)L_66);
		V_14 = (StringU5BU5D_tACEBFEDE350025B554CD507C9AE8FFE49359549A*)L_67;
		V_15 = (int32_t)0;
		goto IL_01c3;
	}

IL_019d:
	{
		intptr_t L_68 = ___array0;
		int32_t L_69 = V_15;
		intptr_t L_70;
		L_70 = AndroidJNI_GetObjectArrayElement_m502026BF77232EE45D03661E4923C2E5E99FDE18((intptr_t)L_68, (int32_t)L_69, /*hidden argument*/NULL);
		V_16 = (intptr_t)L_70;
		StringU5BU5D_tACEBFEDE350025B554CD507C9AE8FFE49359549A* L_71 = V_14;
		int32_t L_72 = V_15;
		intptr_t L_73 = V_16;
		String_t* L_74;
		L_74 = AndroidJNISafe_GetStringChars_mD59FFDE4192F837E1380B51569B5803E09BE58C8((intptr_t)L_73, /*hidden argument*/NULL);
		NullCheck(L_71);
		ArrayElementTypeCheck (L_71, L_74);
		(L_71)->SetAt(static_cast<il2cpp_array_size_t>(L_72), (String_t*)L_74);
		intptr_t L_75 = V_16;
		AndroidJNISafe_DeleteLocalRef_m7AB242A76D13A3BF4C04831D77960C020D6ADA39((intptr_t)L_75, /*hidden argument*/NULL);
		int32_t L_76 = V_15;
		V_15 = (int32_t)((int32_t)il2cpp_codegen_add((int32_t)L_76, (int32_t)1));
	}

IL_01c3:
	{
		int32_t L_77 = V_15;
		int32_t L_78 = V_13;
		V_17 = (bool)((((int32_t)L_77) < ((int32_t)L_78))? 1 : 0);
		bool L_79 = V_17;
		if (L_79)
		{
			goto IL_019d;
		}
	}
	{
		StringU5BU5D_tACEBFEDE350025B554CD507C9AE8FFE49359549A* L_80 = V_14;
		V_3 = (double)((*(double*)((double*)UnBox((RuntimeObject *)L_80, IL2CPP_RGCTX_DATA(method->rgctx_data, 1)))));
		goto IL_0272;
	}

IL_01dc:
	{
		Type_t * L_81 = V_0;
		RuntimeTypeHandle_tC33965ADA3E041E0C94AF05E5CB527B56482CEF9  L_82 = { reinterpret_cast<intptr_t> (AndroidJavaObject_t10188D5695DCD09C9F621B44B0A8C93A2281236E_0_0_0_var) };
		IL2CPP_RUNTIME_CLASS_INIT(Type_t_il2cpp_TypeInfo_var);
		Type_t * L_83;
		L_83 = Type_GetTypeFromHandle_m8BB57524FF7F9DB1803BC561D2B3A4DBACEB385E((RuntimeTypeHandle_tC33965ADA3E041E0C94AF05E5CB527B56482CEF9 )L_82, /*hidden argument*/NULL);
		V_18 = (bool)((((RuntimeObject*)(Type_t *)L_81) == ((RuntimeObject*)(Type_t *)L_83))? 1 : 0);
		bool L_84 = V_18;
		if (!L_84)
		{
			goto IL_0242;
		}
	}
	{
		intptr_t L_85 = ___array0;
		int32_t L_86;
		L_86 = AndroidJNISafe_GetArrayLength_m3015C191DBFC246946A88592731441A934507B56((intptr_t)L_85, /*hidden argument*/NULL);
		V_19 = (int32_t)L_86;
		int32_t L_87 = V_19;
		AndroidJavaObjectU5BU5D_tEE28563C9013906CEB39794019A55F4BA5B06120* L_88 = (AndroidJavaObjectU5BU5D_tEE28563C9013906CEB39794019A55F4BA5B06120*)(AndroidJavaObjectU5BU5D_tEE28563C9013906CEB39794019A55F4BA5B06120*)SZArrayNew(AndroidJavaObjectU5BU5D_tEE28563C9013906CEB39794019A55F4BA5B06120_il2cpp_TypeInfo_var, (uint32_t)L_87);
		V_20 = (AndroidJavaObjectU5BU5D_tEE28563C9013906CEB39794019A55F4BA5B06120*)L_88;
		V_21 = (int32_t)0;
		goto IL_022c;
	}

IL_0206:
	{
		intptr_t L_89 = ___array0;
		int32_t L_90 = V_21;
		intptr_t L_91;
		L_91 = AndroidJNI_GetObjectArrayElement_m502026BF77232EE45D03661E4923C2E5E99FDE18((intptr_t)L_89, (int32_t)L_90, /*hidden argument*/NULL);
		V_22 = (intptr_t)L_91;
		AndroidJavaObjectU5BU5D_tEE28563C9013906CEB39794019A55F4BA5B06120* L_92 = V_20;
		int32_t L_93 = V_21;
		intptr_t L_94 = V_22;
		AndroidJavaObject_t10188D5695DCD09C9F621B44B0A8C93A2281236E * L_95 = (AndroidJavaObject_t10188D5695DCD09C9F621B44B0A8C93A2281236E *)il2cpp_codegen_object_new(AndroidJavaObject_t10188D5695DCD09C9F621B44B0A8C93A2281236E_il2cpp_TypeInfo_var);
		AndroidJavaObject__ctor_m880F6533139DF0BD36C6EF428E45E9F44B6534A3(L_95, (intptr_t)L_94, /*hidden argument*/NULL);
		NullCheck(L_92);
		ArrayElementTypeCheck (L_92, L_95);
		(L_92)->SetAt(static_cast<il2cpp_array_size_t>(L_93), (AndroidJavaObject_t10188D5695DCD09C9F621B44B0A8C93A2281236E *)L_95);
		intptr_t L_96 = V_22;
		AndroidJNISafe_DeleteLocalRef_m7AB242A76D13A3BF4C04831D77960C020D6ADA39((intptr_t)L_96, /*hidden argument*/NULL);
		int32_t L_97 = V_21;
		V_21 = (int32_t)((int32_t)il2cpp_codegen_add((int32_t)L_97, (int32_t)1));
	}

IL_022c:
	{
		int32_t L_98 = V_21;
		int32_t L_99 = V_19;
		V_23 = (bool)((((int32_t)L_98) < ((int32_t)L_99))? 1 : 0);
		bool L_100 = V_23;
		if (L_100)
		{
			goto IL_0206;
		}
	}
	{
		AndroidJavaObjectU5BU5D_tEE28563C9013906CEB39794019A55F4BA5B06120* L_101 = V_20;
		V_3 = (double)((*(double*)((double*)UnBox((RuntimeObject *)L_101, IL2CPP_RGCTX_DATA(method->rgctx_data, 1)))));
		goto IL_0272;
	}

IL_0242:
	{
		Type_t * L_102 = V_0;
		Type_t * L_103 = (Type_t *)L_102;
		G_B31_0 = L_103;
		G_B31_1 = ((String_t*)il2cpp_codegen_initialize_runtime_metadata_inline((uintptr_t*)&_stringLiteral51253131B895C2F8066BCC47E62D44F18F43446C));
		if (L_103)
		{
			G_B32_0 = L_103;
			G_B32_1 = ((String_t*)il2cpp_codegen_initialize_runtime_metadata_inline((uintptr_t*)&_stringLiteral51253131B895C2F8066BCC47E62D44F18F43446C));
			goto IL_0250;
		}
	}
	{
		G_B33_0 = ((String_t*)(NULL));
		G_B33_1 = G_B31_1;
		goto IL_0255;
	}

IL_0250:
	{
		NullCheck((RuntimeObject *)G_B32_0);
		String_t* L_104;
		L_104 = VirtFuncInvoker0< String_t* >::Invoke(3 /* System.String System.Object::ToString() */, (RuntimeObject *)G_B32_0);
		G_B33_0 = L_104;
		G_B33_1 = G_B32_1;
	}

IL_0255:
	{
		String_t* L_105;
		L_105 = String_Concat_m89EAB4C6A96B0E5C3F87300D6BE78D386B9EFC44((String_t*)G_B33_1, (String_t*)G_B33_0, (String_t*)((String_t*)il2cpp_codegen_initialize_runtime_metadata_inline((uintptr_t*)&_stringLiteral42646B33B50B6AA15E22733C8900716F0FE19E1D)), /*hidden argument*/NULL);
		Exception_t * L_106 = (Exception_t *)il2cpp_codegen_object_new(((RuntimeClass*)il2cpp_codegen_initialize_runtime_metadata_inline((uintptr_t*)&Exception_t_il2cpp_TypeInfo_var)));
		Exception__ctor_m8ECDE8ACA7F2E0EF1144BD1200FB5DB2870B5F11(L_106, (String_t*)L_105, /*hidden argument*/NULL);
		IL2CPP_RAISE_MANAGED_EXCEPTION(L_106, ((RuntimeMethod*)il2cpp_codegen_initialize_runtime_metadata_inline((uintptr_t*)&_AndroidJNIHelper_ConvertFromJNIArray_TisDouble_t42821932CB52DE2057E685D0E1AF3DE5033D2181_m5DFA0BED6B580096B2E3ADB1394F918653E21D07_RuntimeMethod_var)));
	}

IL_0265:
	{
		il2cpp_codegen_initobj((&V_24), sizeof(double));
		double L_107 = V_24;
		V_3 = (double)L_107;
		goto IL_0272;
	}

IL_0272:
	{
		double L_108 = V_3;
		return (double)L_108;
	}
}
// ArrayType UnityEngine._AndroidJNIHelper::ConvertFromJNIArray<System.Int16>(System.IntPtr)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR int16_t _AndroidJNIHelper_ConvertFromJNIArray_TisInt16_tD0F031114106263BB459DA1F099FF9F42691295A_m8139D52A1384EE34677345013798688D522DFF37_gshared (intptr_t ___array0, const RuntimeMethod* method)
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&AndroidJavaObjectU5BU5D_tEE28563C9013906CEB39794019A55F4BA5B06120_il2cpp_TypeInfo_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&AndroidJavaObject_t10188D5695DCD09C9F621B44B0A8C93A2281236E_0_0_0_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&AndroidJavaObject_t10188D5695DCD09C9F621B44B0A8C93A2281236E_il2cpp_TypeInfo_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&AndroidReflection_tEB6633FD5B7D2816E1AC6C711E11B2DD33822F16_il2cpp_TypeInfo_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Boolean_t07D1E3F34E4813023D64F584DFF7B34C9D922F37_0_0_0_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Byte_t0111FAB8B8685667EDDAF77683F0D8F86B659056_0_0_0_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Char_tFF60D8E7E89A20BE2294A003734341BD1DF43E14_0_0_0_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Debug_tEB68BCBEB8EFD60F8043C67146DC05E7F50F374B_il2cpp_TypeInfo_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Double_t42821932CB52DE2057E685D0E1AF3DE5033D2181_0_0_0_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Int16_tD0F031114106263BB459DA1F099FF9F42691295A_0_0_0_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Int32_tFDE5F8CD43D10453F6A2E0C77FE48C6CC7009046_0_0_0_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Int64_t378EE0D608BD3107E77238E85F30D2BBD46981F3_0_0_0_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&SByte_t928712DD662DC29BA4FAAE8CE2230AFB23447F0B_0_0_0_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Single_tE07797BA3C98D4CA9B5A19413C19A76688AB899E_0_0_0_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&StringU5BU5D_tACEBFEDE350025B554CD507C9AE8FFE49359549A_il2cpp_TypeInfo_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&String_t_0_0_0_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Type_t_il2cpp_TypeInfo_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&_stringLiteral24CC8D396132365E532646F936DFC8579E2299B2);
		s_Il2CppMethodInitialized = true;
	}
	Type_t * V_0 = NULL;
	bool V_1 = false;
	bool V_2 = false;
	int16_t V_3 = 0;
	bool V_4 = false;
	bool V_5 = false;
	bool V_6 = false;
	bool V_7 = false;
	bool V_8 = false;
	bool V_9 = false;
	bool V_10 = false;
	bool V_11 = false;
	bool V_12 = false;
	int32_t V_13 = 0;
	StringU5BU5D_tACEBFEDE350025B554CD507C9AE8FFE49359549A* V_14 = NULL;
	int32_t V_15 = 0;
	intptr_t V_16;
	memset((&V_16), 0, sizeof(V_16));
	bool V_17 = false;
	bool V_18 = false;
	int32_t V_19 = 0;
	AndroidJavaObjectU5BU5D_tEE28563C9013906CEB39794019A55F4BA5B06120* V_20 = NULL;
	int32_t V_21 = 0;
	intptr_t V_22;
	memset((&V_22), 0, sizeof(V_22));
	bool V_23 = false;
	int16_t V_24 = 0;
	Type_t * G_B32_0 = NULL;
	String_t* G_B32_1 = NULL;
	Type_t * G_B31_0 = NULL;
	String_t* G_B31_1 = NULL;
	String_t* G_B33_0 = NULL;
	String_t* G_B33_1 = NULL;
	{
		RuntimeTypeHandle_tC33965ADA3E041E0C94AF05E5CB527B56482CEF9  L_0 = { reinterpret_cast<intptr_t> (IL2CPP_RGCTX_TYPE(method->rgctx_data, 0)) };
		IL2CPP_RUNTIME_CLASS_INIT(Type_t_il2cpp_TypeInfo_var);
		Type_t * L_1;
		L_1 = Type_GetTypeFromHandle_m8BB57524FF7F9DB1803BC561D2B3A4DBACEB385E((RuntimeTypeHandle_tC33965ADA3E041E0C94AF05E5CB527B56482CEF9 )L_0, /*hidden argument*/NULL);
		NullCheck((Type_t *)L_1);
		Type_t * L_2;
		L_2 = VirtFuncInvoker0< Type_t * >::Invoke(220 /* System.Type System.Type::GetElementType() */, (Type_t *)L_1);
		V_0 = (Type_t *)L_2;
		Type_t * L_3 = V_0;
		IL2CPP_RUNTIME_CLASS_INIT(AndroidReflection_tEB6633FD5B7D2816E1AC6C711E11B2DD33822F16_il2cpp_TypeInfo_var);
		bool L_4;
		L_4 = AndroidReflection_IsPrimitive_mDD6A4050793DF2FA1EDF58010982C64A3F17376D((Type_t *)L_3, /*hidden argument*/NULL);
		V_1 = (bool)L_4;
		bool L_5 = V_1;
		if (!L_5)
		{
			goto IL_0173;
		}
	}
	{
		Type_t * L_6 = V_0;
		RuntimeTypeHandle_tC33965ADA3E041E0C94AF05E5CB527B56482CEF9  L_7 = { reinterpret_cast<intptr_t> (Int32_tFDE5F8CD43D10453F6A2E0C77FE48C6CC7009046_0_0_0_var) };
		IL2CPP_RUNTIME_CLASS_INIT(Type_t_il2cpp_TypeInfo_var);
		Type_t * L_8;
		L_8 = Type_GetTypeFromHandle_m8BB57524FF7F9DB1803BC561D2B3A4DBACEB385E((RuntimeTypeHandle_tC33965ADA3E041E0C94AF05E5CB527B56482CEF9 )L_7, /*hidden argument*/NULL);
		V_2 = (bool)((((RuntimeObject*)(Type_t *)L_6) == ((RuntimeObject*)(Type_t *)L_8))? 1 : 0);
		bool L_9 = V_2;
		if (!L_9)
		{
			goto IL_0041;
		}
	}
	{
		intptr_t L_10 = ___array0;
		Int32U5BU5D_t70F1BDC14B1786481B176D6139A5E3B87DC54C32* L_11;
		L_11 = AndroidJNISafe_FromIntArray_mBF0C0B4309BA525BBA12D7FD3C2790C8FA7C4703((intptr_t)L_10, /*hidden argument*/NULL);
		V_3 = (int16_t)((*(int16_t*)((int16_t*)UnBox((RuntimeObject *)L_11, IL2CPP_RGCTX_DATA(method->rgctx_data, 1)))));
		goto IL_0272;
	}

IL_0041:
	{
		Type_t * L_12 = V_0;
		RuntimeTypeHandle_tC33965ADA3E041E0C94AF05E5CB527B56482CEF9  L_13 = { reinterpret_cast<intptr_t> (Boolean_t07D1E3F34E4813023D64F584DFF7B34C9D922F37_0_0_0_var) };
		IL2CPP_RUNTIME_CLASS_INIT(Type_t_il2cpp_TypeInfo_var);
		Type_t * L_14;
		L_14 = Type_GetTypeFromHandle_m8BB57524FF7F9DB1803BC561D2B3A4DBACEB385E((RuntimeTypeHandle_tC33965ADA3E041E0C94AF05E5CB527B56482CEF9 )L_13, /*hidden argument*/NULL);
		V_4 = (bool)((((RuntimeObject*)(Type_t *)L_12) == ((RuntimeObject*)(Type_t *)L_14))? 1 : 0);
		bool L_15 = V_4;
		if (!L_15)
		{
			goto IL_0065;
		}
	}
	{
		intptr_t L_16 = ___array0;
		BooleanU5BU5D_tEC7BAF93C44F875016DAADC8696EE3A465644D3C* L_17;
		L_17 = AndroidJNISafe_FromBooleanArray_m77A66C34FCB94ADB1AD5E1D88262500C930A5DBF((intptr_t)L_16, /*hidden argument*/NULL);
		V_3 = (int16_t)((*(int16_t*)((int16_t*)UnBox((RuntimeObject *)L_17, IL2CPP_RGCTX_DATA(method->rgctx_data, 1)))));
		goto IL_0272;
	}

IL_0065:
	{
		Type_t * L_18 = V_0;
		RuntimeTypeHandle_tC33965ADA3E041E0C94AF05E5CB527B56482CEF9  L_19 = { reinterpret_cast<intptr_t> (Byte_t0111FAB8B8685667EDDAF77683F0D8F86B659056_0_0_0_var) };
		IL2CPP_RUNTIME_CLASS_INIT(Type_t_il2cpp_TypeInfo_var);
		Type_t * L_20;
		L_20 = Type_GetTypeFromHandle_m8BB57524FF7F9DB1803BC561D2B3A4DBACEB385E((RuntimeTypeHandle_tC33965ADA3E041E0C94AF05E5CB527B56482CEF9 )L_19, /*hidden argument*/NULL);
		V_5 = (bool)((((RuntimeObject*)(Type_t *)L_18) == ((RuntimeObject*)(Type_t *)L_20))? 1 : 0);
		bool L_21 = V_5;
		if (!L_21)
		{
			goto IL_0095;
		}
	}
	{
		IL2CPP_RUNTIME_CLASS_INIT(Debug_tEB68BCBEB8EFD60F8043C67146DC05E7F50F374B_il2cpp_TypeInfo_var);
		Debug_LogWarning_m24085D883C9E74D7AB423F0625E13259923960E7((RuntimeObject *)_stringLiteral24CC8D396132365E532646F936DFC8579E2299B2, /*hidden argument*/NULL);
		intptr_t L_22 = ___array0;
		ByteU5BU5D_tDBBEB0E8362242FA7223000D978B0DD19D4B0726* L_23;
		L_23 = AndroidJNISafe_FromByteArray_m81760A688AECE368E1CFF7DAAC8E141F1B8FA8A8((intptr_t)L_22, /*hidden argument*/NULL);
		V_3 = (int16_t)((*(int16_t*)((int16_t*)UnBox((RuntimeObject *)L_23, IL2CPP_RGCTX_DATA(method->rgctx_data, 1)))));
		goto IL_0272;
	}

IL_0095:
	{
		Type_t * L_24 = V_0;
		RuntimeTypeHandle_tC33965ADA3E041E0C94AF05E5CB527B56482CEF9  L_25 = { reinterpret_cast<intptr_t> (SByte_t928712DD662DC29BA4FAAE8CE2230AFB23447F0B_0_0_0_var) };
		IL2CPP_RUNTIME_CLASS_INIT(Type_t_il2cpp_TypeInfo_var);
		Type_t * L_26;
		L_26 = Type_GetTypeFromHandle_m8BB57524FF7F9DB1803BC561D2B3A4DBACEB385E((RuntimeTypeHandle_tC33965ADA3E041E0C94AF05E5CB527B56482CEF9 )L_25, /*hidden argument*/NULL);
		V_6 = (bool)((((RuntimeObject*)(Type_t *)L_24) == ((RuntimeObject*)(Type_t *)L_26))? 1 : 0);
		bool L_27 = V_6;
		if (!L_27)
		{
			goto IL_00b9;
		}
	}
	{
		intptr_t L_28 = ___array0;
		SByteU5BU5D_t7D94C53295E6116625EA7CC7DEA21FEDC39869E7* L_29;
		L_29 = AndroidJNISafe_FromSByteArray_m01F6539AF10F86B3927436955B57CC809C52416D((intptr_t)L_28, /*hidden argument*/NULL);
		V_3 = (int16_t)((*(int16_t*)((int16_t*)UnBox((RuntimeObject *)L_29, IL2CPP_RGCTX_DATA(method->rgctx_data, 1)))));
		goto IL_0272;
	}

IL_00b9:
	{
		Type_t * L_30 = V_0;
		RuntimeTypeHandle_tC33965ADA3E041E0C94AF05E5CB527B56482CEF9  L_31 = { reinterpret_cast<intptr_t> (Int16_tD0F031114106263BB459DA1F099FF9F42691295A_0_0_0_var) };
		IL2CPP_RUNTIME_CLASS_INIT(Type_t_il2cpp_TypeInfo_var);
		Type_t * L_32;
		L_32 = Type_GetTypeFromHandle_m8BB57524FF7F9DB1803BC561D2B3A4DBACEB385E((RuntimeTypeHandle_tC33965ADA3E041E0C94AF05E5CB527B56482CEF9 )L_31, /*hidden argument*/NULL);
		V_7 = (bool)((((RuntimeObject*)(Type_t *)L_30) == ((RuntimeObject*)(Type_t *)L_32))? 1 : 0);
		bool L_33 = V_7;
		if (!L_33)
		{
			goto IL_00dd;
		}
	}
	{
		intptr_t L_34 = ___array0;
		Int16U5BU5D_tD134F1E6F746D4C09C987436805256C210C2FFCD* L_35;
		L_35 = AndroidJNISafe_FromShortArray_mCDF5B796D950D31035BD35A2E463D41509E4A5CD((intptr_t)L_34, /*hidden argument*/NULL);
		V_3 = (int16_t)((*(int16_t*)((int16_t*)UnBox((RuntimeObject *)L_35, IL2CPP_RGCTX_DATA(method->rgctx_data, 1)))));
		goto IL_0272;
	}

IL_00dd:
	{
		Type_t * L_36 = V_0;
		RuntimeTypeHandle_tC33965ADA3E041E0C94AF05E5CB527B56482CEF9  L_37 = { reinterpret_cast<intptr_t> (Int64_t378EE0D608BD3107E77238E85F30D2BBD46981F3_0_0_0_var) };
		IL2CPP_RUNTIME_CLASS_INIT(Type_t_il2cpp_TypeInfo_var);
		Type_t * L_38;
		L_38 = Type_GetTypeFromHandle_m8BB57524FF7F9DB1803BC561D2B3A4DBACEB385E((RuntimeTypeHandle_tC33965ADA3E041E0C94AF05E5CB527B56482CEF9 )L_37, /*hidden argument*/NULL);
		V_8 = (bool)((((RuntimeObject*)(Type_t *)L_36) == ((RuntimeObject*)(Type_t *)L_38))? 1 : 0);
		bool L_39 = V_8;
		if (!L_39)
		{
			goto IL_0101;
		}
	}
	{
		intptr_t L_40 = ___array0;
		Int64U5BU5D_tCA61E42872C63A4286B24EEE6E0650143B43DCE6* L_41;
		L_41 = AndroidJNISafe_FromLongArray_m0E7C56CB8CFD0EC240F0D86ECBBFD635FFE55CDA((intptr_t)L_40, /*hidden argument*/NULL);
		V_3 = (int16_t)((*(int16_t*)((int16_t*)UnBox((RuntimeObject *)L_41, IL2CPP_RGCTX_DATA(method->rgctx_data, 1)))));
		goto IL_0272;
	}

IL_0101:
	{
		Type_t * L_42 = V_0;
		RuntimeTypeHandle_tC33965ADA3E041E0C94AF05E5CB527B56482CEF9  L_43 = { reinterpret_cast<intptr_t> (Single_tE07797BA3C98D4CA9B5A19413C19A76688AB899E_0_0_0_var) };
		IL2CPP_RUNTIME_CLASS_INIT(Type_t_il2cpp_TypeInfo_var);
		Type_t * L_44;
		L_44 = Type_GetTypeFromHandle_m8BB57524FF7F9DB1803BC561D2B3A4DBACEB385E((RuntimeTypeHandle_tC33965ADA3E041E0C94AF05E5CB527B56482CEF9 )L_43, /*hidden argument*/NULL);
		V_9 = (bool)((((RuntimeObject*)(Type_t *)L_42) == ((RuntimeObject*)(Type_t *)L_44))? 1 : 0);
		bool L_45 = V_9;
		if (!L_45)
		{
			goto IL_0125;
		}
	}
	{
		intptr_t L_46 = ___array0;
		SingleU5BU5D_t47E8DBF5B597C122478D1FFBD9DD57399A0650FA* L_47;
		L_47 = AndroidJNISafe_FromFloatArray_mF6A63CA1B7C10BC27EEC033F0E390772DFDD652D((intptr_t)L_46, /*hidden argument*/NULL);
		V_3 = (int16_t)((*(int16_t*)((int16_t*)UnBox((RuntimeObject *)L_47, IL2CPP_RGCTX_DATA(method->rgctx_data, 1)))));
		goto IL_0272;
	}

IL_0125:
	{
		Type_t * L_48 = V_0;
		RuntimeTypeHandle_tC33965ADA3E041E0C94AF05E5CB527B56482CEF9  L_49 = { reinterpret_cast<intptr_t> (Double_t42821932CB52DE2057E685D0E1AF3DE5033D2181_0_0_0_var) };
		IL2CPP_RUNTIME_CLASS_INIT(Type_t_il2cpp_TypeInfo_var);
		Type_t * L_50;
		L_50 = Type_GetTypeFromHandle_m8BB57524FF7F9DB1803BC561D2B3A4DBACEB385E((RuntimeTypeHandle_tC33965ADA3E041E0C94AF05E5CB527B56482CEF9 )L_49, /*hidden argument*/NULL);
		V_10 = (bool)((((RuntimeObject*)(Type_t *)L_48) == ((RuntimeObject*)(Type_t *)L_50))? 1 : 0);
		bool L_51 = V_10;
		if (!L_51)
		{
			goto IL_0149;
		}
	}
	{
		intptr_t L_52 = ___array0;
		DoubleU5BU5D_t8E1B42EB2ABB79FBD193A6B8C8D97A7CDE44A4FB* L_53;
		L_53 = AndroidJNISafe_FromDoubleArray_m9438B5668E8B2DB3B18CACFF0CC9CAEAB5EC73C8((intptr_t)L_52, /*hidden argument*/NULL);
		V_3 = (int16_t)((*(int16_t*)((int16_t*)UnBox((RuntimeObject *)L_53, IL2CPP_RGCTX_DATA(method->rgctx_data, 1)))));
		goto IL_0272;
	}

IL_0149:
	{
		Type_t * L_54 = V_0;
		RuntimeTypeHandle_tC33965ADA3E041E0C94AF05E5CB527B56482CEF9  L_55 = { reinterpret_cast<intptr_t> (Char_tFF60D8E7E89A20BE2294A003734341BD1DF43E14_0_0_0_var) };
		IL2CPP_RUNTIME_CLASS_INIT(Type_t_il2cpp_TypeInfo_var);
		Type_t * L_56;
		L_56 = Type_GetTypeFromHandle_m8BB57524FF7F9DB1803BC561D2B3A4DBACEB385E((RuntimeTypeHandle_tC33965ADA3E041E0C94AF05E5CB527B56482CEF9 )L_55, /*hidden argument*/NULL);
		V_11 = (bool)((((RuntimeObject*)(Type_t *)L_54) == ((RuntimeObject*)(Type_t *)L_56))? 1 : 0);
		bool L_57 = V_11;
		if (!L_57)
		{
			goto IL_016d;
		}
	}
	{
		intptr_t L_58 = ___array0;
		CharU5BU5D_t7B7FC5BC8091AA3B9CB0B29CDD80B5EE9254AA34* L_59;
		L_59 = AndroidJNISafe_FromCharArray_mA49DB27755EF3B2AE81487E0FCFE06E23F617305((intptr_t)L_58, /*hidden argument*/NULL);
		V_3 = (int16_t)((*(int16_t*)((int16_t*)UnBox((RuntimeObject *)L_59, IL2CPP_RGCTX_DATA(method->rgctx_data, 1)))));
		goto IL_0272;
	}

IL_016d:
	{
		goto IL_0265;
	}

IL_0173:
	{
		Type_t * L_60 = V_0;
		RuntimeTypeHandle_tC33965ADA3E041E0C94AF05E5CB527B56482CEF9  L_61 = { reinterpret_cast<intptr_t> (String_t_0_0_0_var) };
		IL2CPP_RUNTIME_CLASS_INIT(Type_t_il2cpp_TypeInfo_var);
		Type_t * L_62;
		L_62 = Type_GetTypeFromHandle_m8BB57524FF7F9DB1803BC561D2B3A4DBACEB385E((RuntimeTypeHandle_tC33965ADA3E041E0C94AF05E5CB527B56482CEF9 )L_61, /*hidden argument*/NULL);
		V_12 = (bool)((((RuntimeObject*)(Type_t *)L_60) == ((RuntimeObject*)(Type_t *)L_62))? 1 : 0);
		bool L_63 = V_12;
		if (!L_63)
		{
			goto IL_01dc;
		}
	}
	{
		intptr_t L_64 = ___array0;
		int32_t L_65;
		L_65 = AndroidJNISafe_GetArrayLength_m3015C191DBFC246946A88592731441A934507B56((intptr_t)L_64, /*hidden argument*/NULL);
		V_13 = (int32_t)L_65;
		int32_t L_66 = V_13;
		StringU5BU5D_tACEBFEDE350025B554CD507C9AE8FFE49359549A* L_67 = (StringU5BU5D_tACEBFEDE350025B554CD507C9AE8FFE49359549A*)(StringU5BU5D_tACEBFEDE350025B554CD507C9AE8FFE49359549A*)SZArrayNew(StringU5BU5D_tACEBFEDE350025B554CD507C9AE8FFE49359549A_il2cpp_TypeInfo_var, (uint32_t)L_66);
		V_14 = (StringU5BU5D_tACEBFEDE350025B554CD507C9AE8FFE49359549A*)L_67;
		V_15 = (int32_t)0;
		goto IL_01c3;
	}

IL_019d:
	{
		intptr_t L_68 = ___array0;
		int32_t L_69 = V_15;
		intptr_t L_70;
		L_70 = AndroidJNI_GetObjectArrayElement_m502026BF77232EE45D03661E4923C2E5E99FDE18((intptr_t)L_68, (int32_t)L_69, /*hidden argument*/NULL);
		V_16 = (intptr_t)L_70;
		StringU5BU5D_tACEBFEDE350025B554CD507C9AE8FFE49359549A* L_71 = V_14;
		int32_t L_72 = V_15;
		intptr_t L_73 = V_16;
		String_t* L_74;
		L_74 = AndroidJNISafe_GetStringChars_mD59FFDE4192F837E1380B51569B5803E09BE58C8((intptr_t)L_73, /*hidden argument*/NULL);
		NullCheck(L_71);
		ArrayElementTypeCheck (L_71, L_74);
		(L_71)->SetAt(static_cast<il2cpp_array_size_t>(L_72), (String_t*)L_74);
		intptr_t L_75 = V_16;
		AndroidJNISafe_DeleteLocalRef_m7AB242A76D13A3BF4C04831D77960C020D6ADA39((intptr_t)L_75, /*hidden argument*/NULL);
		int32_t L_76 = V_15;
		V_15 = (int32_t)((int32_t)il2cpp_codegen_add((int32_t)L_76, (int32_t)1));
	}

IL_01c3:
	{
		int32_t L_77 = V_15;
		int32_t L_78 = V_13;
		V_17 = (bool)((((int32_t)L_77) < ((int32_t)L_78))? 1 : 0);
		bool L_79 = V_17;
		if (L_79)
		{
			goto IL_019d;
		}
	}
	{
		StringU5BU5D_tACEBFEDE350025B554CD507C9AE8FFE49359549A* L_80 = V_14;
		V_3 = (int16_t)((*(int16_t*)((int16_t*)UnBox((RuntimeObject *)L_80, IL2CPP_RGCTX_DATA(method->rgctx_data, 1)))));
		goto IL_0272;
	}

IL_01dc:
	{
		Type_t * L_81 = V_0;
		RuntimeTypeHandle_tC33965ADA3E041E0C94AF05E5CB527B56482CEF9  L_82 = { reinterpret_cast<intptr_t> (AndroidJavaObject_t10188D5695DCD09C9F621B44B0A8C93A2281236E_0_0_0_var) };
		IL2CPP_RUNTIME_CLASS_INIT(Type_t_il2cpp_TypeInfo_var);
		Type_t * L_83;
		L_83 = Type_GetTypeFromHandle_m8BB57524FF7F9DB1803BC561D2B3A4DBACEB385E((RuntimeTypeHandle_tC33965ADA3E041E0C94AF05E5CB527B56482CEF9 )L_82, /*hidden argument*/NULL);
		V_18 = (bool)((((RuntimeObject*)(Type_t *)L_81) == ((RuntimeObject*)(Type_t *)L_83))? 1 : 0);
		bool L_84 = V_18;
		if (!L_84)
		{
			goto IL_0242;
		}
	}
	{
		intptr_t L_85 = ___array0;
		int32_t L_86;
		L_86 = AndroidJNISafe_GetArrayLength_m3015C191DBFC246946A88592731441A934507B56((intptr_t)L_85, /*hidden argument*/NULL);
		V_19 = (int32_t)L_86;
		int32_t L_87 = V_19;
		AndroidJavaObjectU5BU5D_tEE28563C9013906CEB39794019A55F4BA5B06120* L_88 = (AndroidJavaObjectU5BU5D_tEE28563C9013906CEB39794019A55F4BA5B06120*)(AndroidJavaObjectU5BU5D_tEE28563C9013906CEB39794019A55F4BA5B06120*)SZArrayNew(AndroidJavaObjectU5BU5D_tEE28563C9013906CEB39794019A55F4BA5B06120_il2cpp_TypeInfo_var, (uint32_t)L_87);
		V_20 = (AndroidJavaObjectU5BU5D_tEE28563C9013906CEB39794019A55F4BA5B06120*)L_88;
		V_21 = (int32_t)0;
		goto IL_022c;
	}

IL_0206:
	{
		intptr_t L_89 = ___array0;
		int32_t L_90 = V_21;
		intptr_t L_91;
		L_91 = AndroidJNI_GetObjectArrayElement_m502026BF77232EE45D03661E4923C2E5E99FDE18((intptr_t)L_89, (int32_t)L_90, /*hidden argument*/NULL);
		V_22 = (intptr_t)L_91;
		AndroidJavaObjectU5BU5D_tEE28563C9013906CEB39794019A55F4BA5B06120* L_92 = V_20;
		int32_t L_93 = V_21;
		intptr_t L_94 = V_22;
		AndroidJavaObject_t10188D5695DCD09C9F621B44B0A8C93A2281236E * L_95 = (AndroidJavaObject_t10188D5695DCD09C9F621B44B0A8C93A2281236E *)il2cpp_codegen_object_new(AndroidJavaObject_t10188D5695DCD09C9F621B44B0A8C93A2281236E_il2cpp_TypeInfo_var);
		AndroidJavaObject__ctor_m880F6533139DF0BD36C6EF428E45E9F44B6534A3(L_95, (intptr_t)L_94, /*hidden argument*/NULL);
		NullCheck(L_92);
		ArrayElementTypeCheck (L_92, L_95);
		(L_92)->SetAt(static_cast<il2cpp_array_size_t>(L_93), (AndroidJavaObject_t10188D5695DCD09C9F621B44B0A8C93A2281236E *)L_95);
		intptr_t L_96 = V_22;
		AndroidJNISafe_DeleteLocalRef_m7AB242A76D13A3BF4C04831D77960C020D6ADA39((intptr_t)L_96, /*hidden argument*/NULL);
		int32_t L_97 = V_21;
		V_21 = (int32_t)((int32_t)il2cpp_codegen_add((int32_t)L_97, (int32_t)1));
	}

IL_022c:
	{
		int32_t L_98 = V_21;
		int32_t L_99 = V_19;
		V_23 = (bool)((((int32_t)L_98) < ((int32_t)L_99))? 1 : 0);
		bool L_100 = V_23;
		if (L_100)
		{
			goto IL_0206;
		}
	}
	{
		AndroidJavaObjectU5BU5D_tEE28563C9013906CEB39794019A55F4BA5B06120* L_101 = V_20;
		V_3 = (int16_t)((*(int16_t*)((int16_t*)UnBox((RuntimeObject *)L_101, IL2CPP_RGCTX_DATA(method->rgctx_data, 1)))));
		goto IL_0272;
	}

IL_0242:
	{
		Type_t * L_102 = V_0;
		Type_t * L_103 = (Type_t *)L_102;
		G_B31_0 = L_103;
		G_B31_1 = ((String_t*)il2cpp_codegen_initialize_runtime_metadata_inline((uintptr_t*)&_stringLiteral51253131B895C2F8066BCC47E62D44F18F43446C));
		if (L_103)
		{
			G_B32_0 = L_103;
			G_B32_1 = ((String_t*)il2cpp_codegen_initialize_runtime_metadata_inline((uintptr_t*)&_stringLiteral51253131B895C2F8066BCC47E62D44F18F43446C));
			goto IL_0250;
		}
	}
	{
		G_B33_0 = ((String_t*)(NULL));
		G_B33_1 = G_B31_1;
		goto IL_0255;
	}

IL_0250:
	{
		NullCheck((RuntimeObject *)G_B32_0);
		String_t* L_104;
		L_104 = VirtFuncInvoker0< String_t* >::Invoke(3 /* System.String System.Object::ToString() */, (RuntimeObject *)G_B32_0);
		G_B33_0 = L_104;
		G_B33_1 = G_B32_1;
	}

IL_0255:
	{
		String_t* L_105;
		L_105 = String_Concat_m89EAB4C6A96B0E5C3F87300D6BE78D386B9EFC44((String_t*)G_B33_1, (String_t*)G_B33_0, (String_t*)((String_t*)il2cpp_codegen_initialize_runtime_metadata_inline((uintptr_t*)&_stringLiteral42646B33B50B6AA15E22733C8900716F0FE19E1D)), /*hidden argument*/NULL);
		Exception_t * L_106 = (Exception_t *)il2cpp_codegen_object_new(((RuntimeClass*)il2cpp_codegen_initialize_runtime_metadata_inline((uintptr_t*)&Exception_t_il2cpp_TypeInfo_var)));
		Exception__ctor_m8ECDE8ACA7F2E0EF1144BD1200FB5DB2870B5F11(L_106, (String_t*)L_105, /*hidden argument*/NULL);
		IL2CPP_RAISE_MANAGED_EXCEPTION(L_106, ((RuntimeMethod*)il2cpp_codegen_initialize_runtime_metadata_inline((uintptr_t*)&_AndroidJNIHelper_ConvertFromJNIArray_TisInt16_tD0F031114106263BB459DA1F099FF9F42691295A_m8139D52A1384EE34677345013798688D522DFF37_RuntimeMethod_var)));
	}

IL_0265:
	{
		il2cpp_codegen_initobj((&V_24), sizeof(int16_t));
		int16_t L_107 = V_24;
		V_3 = (int16_t)L_107;
		goto IL_0272;
	}

IL_0272:
	{
		int16_t L_108 = V_3;
		return (int16_t)L_108;
	}
}
// ArrayType UnityEngine._AndroidJNIHelper::ConvertFromJNIArray<System.Int32>(System.IntPtr)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR int32_t _AndroidJNIHelper_ConvertFromJNIArray_TisInt32_tFDE5F8CD43D10453F6A2E0C77FE48C6CC7009046_m46E475527292788C29DD62A991E948CE3D9189A3_gshared (intptr_t ___array0, const RuntimeMethod* method)
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&AndroidJavaObjectU5BU5D_tEE28563C9013906CEB39794019A55F4BA5B06120_il2cpp_TypeInfo_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&AndroidJavaObject_t10188D5695DCD09C9F621B44B0A8C93A2281236E_0_0_0_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&AndroidJavaObject_t10188D5695DCD09C9F621B44B0A8C93A2281236E_il2cpp_TypeInfo_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&AndroidReflection_tEB6633FD5B7D2816E1AC6C711E11B2DD33822F16_il2cpp_TypeInfo_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Boolean_t07D1E3F34E4813023D64F584DFF7B34C9D922F37_0_0_0_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Byte_t0111FAB8B8685667EDDAF77683F0D8F86B659056_0_0_0_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Char_tFF60D8E7E89A20BE2294A003734341BD1DF43E14_0_0_0_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Debug_tEB68BCBEB8EFD60F8043C67146DC05E7F50F374B_il2cpp_TypeInfo_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Double_t42821932CB52DE2057E685D0E1AF3DE5033D2181_0_0_0_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Int16_tD0F031114106263BB459DA1F099FF9F42691295A_0_0_0_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Int32_tFDE5F8CD43D10453F6A2E0C77FE48C6CC7009046_0_0_0_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Int64_t378EE0D608BD3107E77238E85F30D2BBD46981F3_0_0_0_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&SByte_t928712DD662DC29BA4FAAE8CE2230AFB23447F0B_0_0_0_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Single_tE07797BA3C98D4CA9B5A19413C19A76688AB899E_0_0_0_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&StringU5BU5D_tACEBFEDE350025B554CD507C9AE8FFE49359549A_il2cpp_TypeInfo_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&String_t_0_0_0_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Type_t_il2cpp_TypeInfo_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&_stringLiteral24CC8D396132365E532646F936DFC8579E2299B2);
		s_Il2CppMethodInitialized = true;
	}
	Type_t * V_0 = NULL;
	bool V_1 = false;
	bool V_2 = false;
	int32_t V_3 = 0;
	bool V_4 = false;
	bool V_5 = false;
	bool V_6 = false;
	bool V_7 = false;
	bool V_8 = false;
	bool V_9 = false;
	bool V_10 = false;
	bool V_11 = false;
	bool V_12 = false;
	int32_t V_13 = 0;
	StringU5BU5D_tACEBFEDE350025B554CD507C9AE8FFE49359549A* V_14 = NULL;
	int32_t V_15 = 0;
	intptr_t V_16;
	memset((&V_16), 0, sizeof(V_16));
	bool V_17 = false;
	bool V_18 = false;
	int32_t V_19 = 0;
	AndroidJavaObjectU5BU5D_tEE28563C9013906CEB39794019A55F4BA5B06120* V_20 = NULL;
	int32_t V_21 = 0;
	intptr_t V_22;
	memset((&V_22), 0, sizeof(V_22));
	bool V_23 = false;
	int32_t V_24 = 0;
	Type_t * G_B32_0 = NULL;
	String_t* G_B32_1 = NULL;
	Type_t * G_B31_0 = NULL;
	String_t* G_B31_1 = NULL;
	String_t* G_B33_0 = NULL;
	String_t* G_B33_1 = NULL;
	{
		RuntimeTypeHandle_tC33965ADA3E041E0C94AF05E5CB527B56482CEF9  L_0 = { reinterpret_cast<intptr_t> (IL2CPP_RGCTX_TYPE(method->rgctx_data, 0)) };
		IL2CPP_RUNTIME_CLASS_INIT(Type_t_il2cpp_TypeInfo_var);
		Type_t * L_1;
		L_1 = Type_GetTypeFromHandle_m8BB57524FF7F9DB1803BC561D2B3A4DBACEB385E((RuntimeTypeHandle_tC33965ADA3E041E0C94AF05E5CB527B56482CEF9 )L_0, /*hidden argument*/NULL);
		NullCheck((Type_t *)L_1);
		Type_t * L_2;
		L_2 = VirtFuncInvoker0< Type_t * >::Invoke(220 /* System.Type System.Type::GetElementType() */, (Type_t *)L_1);
		V_0 = (Type_t *)L_2;
		Type_t * L_3 = V_0;
		IL2CPP_RUNTIME_CLASS_INIT(AndroidReflection_tEB6633FD5B7D2816E1AC6C711E11B2DD33822F16_il2cpp_TypeInfo_var);
		bool L_4;
		L_4 = AndroidReflection_IsPrimitive_mDD6A4050793DF2FA1EDF58010982C64A3F17376D((Type_t *)L_3, /*hidden argument*/NULL);
		V_1 = (bool)L_4;
		bool L_5 = V_1;
		if (!L_5)
		{
			goto IL_0173;
		}
	}
	{
		Type_t * L_6 = V_0;
		RuntimeTypeHandle_tC33965ADA3E041E0C94AF05E5CB527B56482CEF9  L_7 = { reinterpret_cast<intptr_t> (Int32_tFDE5F8CD43D10453F6A2E0C77FE48C6CC7009046_0_0_0_var) };
		IL2CPP_RUNTIME_CLASS_INIT(Type_t_il2cpp_TypeInfo_var);
		Type_t * L_8;
		L_8 = Type_GetTypeFromHandle_m8BB57524FF7F9DB1803BC561D2B3A4DBACEB385E((RuntimeTypeHandle_tC33965ADA3E041E0C94AF05E5CB527B56482CEF9 )L_7, /*hidden argument*/NULL);
		V_2 = (bool)((((RuntimeObject*)(Type_t *)L_6) == ((RuntimeObject*)(Type_t *)L_8))? 1 : 0);
		bool L_9 = V_2;
		if (!L_9)
		{
			goto IL_0041;
		}
	}
	{
		intptr_t L_10 = ___array0;
		Int32U5BU5D_t70F1BDC14B1786481B176D6139A5E3B87DC54C32* L_11;
		L_11 = AndroidJNISafe_FromIntArray_mBF0C0B4309BA525BBA12D7FD3C2790C8FA7C4703((intptr_t)L_10, /*hidden argument*/NULL);
		V_3 = (int32_t)((*(int32_t*)((int32_t*)UnBox((RuntimeObject *)L_11, IL2CPP_RGCTX_DATA(method->rgctx_data, 1)))));
		goto IL_0272;
	}

IL_0041:
	{
		Type_t * L_12 = V_0;
		RuntimeTypeHandle_tC33965ADA3E041E0C94AF05E5CB527B56482CEF9  L_13 = { reinterpret_cast<intptr_t> (Boolean_t07D1E3F34E4813023D64F584DFF7B34C9D922F37_0_0_0_var) };
		IL2CPP_RUNTIME_CLASS_INIT(Type_t_il2cpp_TypeInfo_var);
		Type_t * L_14;
		L_14 = Type_GetTypeFromHandle_m8BB57524FF7F9DB1803BC561D2B3A4DBACEB385E((RuntimeTypeHandle_tC33965ADA3E041E0C94AF05E5CB527B56482CEF9 )L_13, /*hidden argument*/NULL);
		V_4 = (bool)((((RuntimeObject*)(Type_t *)L_12) == ((RuntimeObject*)(Type_t *)L_14))? 1 : 0);
		bool L_15 = V_4;
		if (!L_15)
		{
			goto IL_0065;
		}
	}
	{
		intptr_t L_16 = ___array0;
		BooleanU5BU5D_tEC7BAF93C44F875016DAADC8696EE3A465644D3C* L_17;
		L_17 = AndroidJNISafe_FromBooleanArray_m77A66C34FCB94ADB1AD5E1D88262500C930A5DBF((intptr_t)L_16, /*hidden argument*/NULL);
		V_3 = (int32_t)((*(int32_t*)((int32_t*)UnBox((RuntimeObject *)L_17, IL2CPP_RGCTX_DATA(method->rgctx_data, 1)))));
		goto IL_0272;
	}

IL_0065:
	{
		Type_t * L_18 = V_0;
		RuntimeTypeHandle_tC33965ADA3E041E0C94AF05E5CB527B56482CEF9  L_19 = { reinterpret_cast<intptr_t> (Byte_t0111FAB8B8685667EDDAF77683F0D8F86B659056_0_0_0_var) };
		IL2CPP_RUNTIME_CLASS_INIT(Type_t_il2cpp_TypeInfo_var);
		Type_t * L_20;
		L_20 = Type_GetTypeFromHandle_m8BB57524FF7F9DB1803BC561D2B3A4DBACEB385E((RuntimeTypeHandle_tC33965ADA3E041E0C94AF05E5CB527B56482CEF9 )L_19, /*hidden argument*/NULL);
		V_5 = (bool)((((RuntimeObject*)(Type_t *)L_18) == ((RuntimeObject*)(Type_t *)L_20))? 1 : 0);
		bool L_21 = V_5;
		if (!L_21)
		{
			goto IL_0095;
		}
	}
	{
		IL2CPP_RUNTIME_CLASS_INIT(Debug_tEB68BCBEB8EFD60F8043C67146DC05E7F50F374B_il2cpp_TypeInfo_var);
		Debug_LogWarning_m24085D883C9E74D7AB423F0625E13259923960E7((RuntimeObject *)_stringLiteral24CC8D396132365E532646F936DFC8579E2299B2, /*hidden argument*/NULL);
		intptr_t L_22 = ___array0;
		ByteU5BU5D_tDBBEB0E8362242FA7223000D978B0DD19D4B0726* L_23;
		L_23 = AndroidJNISafe_FromByteArray_m81760A688AECE368E1CFF7DAAC8E141F1B8FA8A8((intptr_t)L_22, /*hidden argument*/NULL);
		V_3 = (int32_t)((*(int32_t*)((int32_t*)UnBox((RuntimeObject *)L_23, IL2CPP_RGCTX_DATA(method->rgctx_data, 1)))));
		goto IL_0272;
	}

IL_0095:
	{
		Type_t * L_24 = V_0;
		RuntimeTypeHandle_tC33965ADA3E041E0C94AF05E5CB527B56482CEF9  L_25 = { reinterpret_cast<intptr_t> (SByte_t928712DD662DC29BA4FAAE8CE2230AFB23447F0B_0_0_0_var) };
		IL2CPP_RUNTIME_CLASS_INIT(Type_t_il2cpp_TypeInfo_var);
		Type_t * L_26;
		L_26 = Type_GetTypeFromHandle_m8BB57524FF7F9DB1803BC561D2B3A4DBACEB385E((RuntimeTypeHandle_tC33965ADA3E041E0C94AF05E5CB527B56482CEF9 )L_25, /*hidden argument*/NULL);
		V_6 = (bool)((((RuntimeObject*)(Type_t *)L_24) == ((RuntimeObject*)(Type_t *)L_26))? 1 : 0);
		bool L_27 = V_6;
		if (!L_27)
		{
			goto IL_00b9;
		}
	}
	{
		intptr_t L_28 = ___array0;
		SByteU5BU5D_t7D94C53295E6116625EA7CC7DEA21FEDC39869E7* L_29;
		L_29 = AndroidJNISafe_FromSByteArray_m01F6539AF10F86B3927436955B57CC809C52416D((intptr_t)L_28, /*hidden argument*/NULL);
		V_3 = (int32_t)((*(int32_t*)((int32_t*)UnBox((RuntimeObject *)L_29, IL2CPP_RGCTX_DATA(method->rgctx_data, 1)))));
		goto IL_0272;
	}

IL_00b9:
	{
		Type_t * L_30 = V_0;
		RuntimeTypeHandle_tC33965ADA3E041E0C94AF05E5CB527B56482CEF9  L_31 = { reinterpret_cast<intptr_t> (Int16_tD0F031114106263BB459DA1F099FF9F42691295A_0_0_0_var) };
		IL2CPP_RUNTIME_CLASS_INIT(Type_t_il2cpp_TypeInfo_var);
		Type_t * L_32;
		L_32 = Type_GetTypeFromHandle_m8BB57524FF7F9DB1803BC561D2B3A4DBACEB385E((RuntimeTypeHandle_tC33965ADA3E041E0C94AF05E5CB527B56482CEF9 )L_31, /*hidden argument*/NULL);
		V_7 = (bool)((((RuntimeObject*)(Type_t *)L_30) == ((RuntimeObject*)(Type_t *)L_32))? 1 : 0);
		bool L_33 = V_7;
		if (!L_33)
		{
			goto IL_00dd;
		}
	}
	{
		intptr_t L_34 = ___array0;
		Int16U5BU5D_tD134F1E6F746D4C09C987436805256C210C2FFCD* L_35;
		L_35 = AndroidJNISafe_FromShortArray_mCDF5B796D950D31035BD35A2E463D41509E4A5CD((intptr_t)L_34, /*hidden argument*/NULL);
		V_3 = (int32_t)((*(int32_t*)((int32_t*)UnBox((RuntimeObject *)L_35, IL2CPP_RGCTX_DATA(method->rgctx_data, 1)))));
		goto IL_0272;
	}

IL_00dd:
	{
		Type_t * L_36 = V_0;
		RuntimeTypeHandle_tC33965ADA3E041E0C94AF05E5CB527B56482CEF9  L_37 = { reinterpret_cast<intptr_t> (Int64_t378EE0D608BD3107E77238E85F30D2BBD46981F3_0_0_0_var) };
		IL2CPP_RUNTIME_CLASS_INIT(Type_t_il2cpp_TypeInfo_var);
		Type_t * L_38;
		L_38 = Type_GetTypeFromHandle_m8BB57524FF7F9DB1803BC561D2B3A4DBACEB385E((RuntimeTypeHandle_tC33965ADA3E041E0C94AF05E5CB527B56482CEF9 )L_37, /*hidden argument*/NULL);
		V_8 = (bool)((((RuntimeObject*)(Type_t *)L_36) == ((RuntimeObject*)(Type_t *)L_38))? 1 : 0);
		bool L_39 = V_8;
		if (!L_39)
		{
			goto IL_0101;
		}
	}
	{
		intptr_t L_40 = ___array0;
		Int64U5BU5D_tCA61E42872C63A4286B24EEE6E0650143B43DCE6* L_41;
		L_41 = AndroidJNISafe_FromLongArray_m0E7C56CB8CFD0EC240F0D86ECBBFD635FFE55CDA((intptr_t)L_40, /*hidden argument*/NULL);
		V_3 = (int32_t)((*(int32_t*)((int32_t*)UnBox((RuntimeObject *)L_41, IL2CPP_RGCTX_DATA(method->rgctx_data, 1)))));
		goto IL_0272;
	}

IL_0101:
	{
		Type_t * L_42 = V_0;
		RuntimeTypeHandle_tC33965ADA3E041E0C94AF05E5CB527B56482CEF9  L_43 = { reinterpret_cast<intptr_t> (Single_tE07797BA3C98D4CA9B5A19413C19A76688AB899E_0_0_0_var) };
		IL2CPP_RUNTIME_CLASS_INIT(Type_t_il2cpp_TypeInfo_var);
		Type_t * L_44;
		L_44 = Type_GetTypeFromHandle_m8BB57524FF7F9DB1803BC561D2B3A4DBACEB385E((RuntimeTypeHandle_tC33965ADA3E041E0C94AF05E5CB527B56482CEF9 )L_43, /*hidden argument*/NULL);
		V_9 = (bool)((((RuntimeObject*)(Type_t *)L_42) == ((RuntimeObject*)(Type_t *)L_44))? 1 : 0);
		bool L_45 = V_9;
		if (!L_45)
		{
			goto IL_0125;
		}
	}
	{
		intptr_t L_46 = ___array0;
		SingleU5BU5D_t47E8DBF5B597C122478D1FFBD9DD57399A0650FA* L_47;
		L_47 = AndroidJNISafe_FromFloatArray_mF6A63CA1B7C10BC27EEC033F0E390772DFDD652D((intptr_t)L_46, /*hidden argument*/NULL);
		V_3 = (int32_t)((*(int32_t*)((int32_t*)UnBox((RuntimeObject *)L_47, IL2CPP_RGCTX_DATA(method->rgctx_data, 1)))));
		goto IL_0272;
	}

IL_0125:
	{
		Type_t * L_48 = V_0;
		RuntimeTypeHandle_tC33965ADA3E041E0C94AF05E5CB527B56482CEF9  L_49 = { reinterpret_cast<intptr_t> (Double_t42821932CB52DE2057E685D0E1AF3DE5033D2181_0_0_0_var) };
		IL2CPP_RUNTIME_CLASS_INIT(Type_t_il2cpp_TypeInfo_var);
		Type_t * L_50;
		L_50 = Type_GetTypeFromHandle_m8BB57524FF7F9DB1803BC561D2B3A4DBACEB385E((RuntimeTypeHandle_tC33965ADA3E041E0C94AF05E5CB527B56482CEF9 )L_49, /*hidden argument*/NULL);
		V_10 = (bool)((((RuntimeObject*)(Type_t *)L_48) == ((RuntimeObject*)(Type_t *)L_50))? 1 : 0);
		bool L_51 = V_10;
		if (!L_51)
		{
			goto IL_0149;
		}
	}
	{
		intptr_t L_52 = ___array0;
		DoubleU5BU5D_t8E1B42EB2ABB79FBD193A6B8C8D97A7CDE44A4FB* L_53;
		L_53 = AndroidJNISafe_FromDoubleArray_m9438B5668E8B2DB3B18CACFF0CC9CAEAB5EC73C8((intptr_t)L_52, /*hidden argument*/NULL);
		V_3 = (int32_t)((*(int32_t*)((int32_t*)UnBox((RuntimeObject *)L_53, IL2CPP_RGCTX_DATA(method->rgctx_data, 1)))));
		goto IL_0272;
	}

IL_0149:
	{
		Type_t * L_54 = V_0;
		RuntimeTypeHandle_tC33965ADA3E041E0C94AF05E5CB527B56482CEF9  L_55 = { reinterpret_cast<intptr_t> (Char_tFF60D8E7E89A20BE2294A003734341BD1DF43E14_0_0_0_var) };
		IL2CPP_RUNTIME_CLASS_INIT(Type_t_il2cpp_TypeInfo_var);
		Type_t * L_56;
		L_56 = Type_GetTypeFromHandle_m8BB57524FF7F9DB1803BC561D2B3A4DBACEB385E((RuntimeTypeHandle_tC33965ADA3E041E0C94AF05E5CB527B56482CEF9 )L_55, /*hidden argument*/NULL);
		V_11 = (bool)((((RuntimeObject*)(Type_t *)L_54) == ((RuntimeObject*)(Type_t *)L_56))? 1 : 0);
		bool L_57 = V_11;
		if (!L_57)
		{
			goto IL_016d;
		}
	}
	{
		intptr_t L_58 = ___array0;
		CharU5BU5D_t7B7FC5BC8091AA3B9CB0B29CDD80B5EE9254AA34* L_59;
		L_59 = AndroidJNISafe_FromCharArray_mA49DB27755EF3B2AE81487E0FCFE06E23F617305((intptr_t)L_58, /*hidden argument*/NULL);
		V_3 = (int32_t)((*(int32_t*)((int32_t*)UnBox((RuntimeObject *)L_59, IL2CPP_RGCTX_DATA(method->rgctx_data, 1)))));
		goto IL_0272;
	}

IL_016d:
	{
		goto IL_0265;
	}

IL_0173:
	{
		Type_t * L_60 = V_0;
		RuntimeTypeHandle_tC33965ADA3E041E0C94AF05E5CB527B56482CEF9  L_61 = { reinterpret_cast<intptr_t> (String_t_0_0_0_var) };
		IL2CPP_RUNTIME_CLASS_INIT(Type_t_il2cpp_TypeInfo_var);
		Type_t * L_62;
		L_62 = Type_GetTypeFromHandle_m8BB57524FF7F9DB1803BC561D2B3A4DBACEB385E((RuntimeTypeHandle_tC33965ADA3E041E0C94AF05E5CB527B56482CEF9 )L_61, /*hidden argument*/NULL);
		V_12 = (bool)((((RuntimeObject*)(Type_t *)L_60) == ((RuntimeObject*)(Type_t *)L_62))? 1 : 0);
		bool L_63 = V_12;
		if (!L_63)
		{
			goto IL_01dc;
		}
	}
	{
		intptr_t L_64 = ___array0;
		int32_t L_65;
		L_65 = AndroidJNISafe_GetArrayLength_m3015C191DBFC246946A88592731441A934507B56((intptr_t)L_64, /*hidden argument*/NULL);
		V_13 = (int32_t)L_65;
		int32_t L_66 = V_13;
		StringU5BU5D_tACEBFEDE350025B554CD507C9AE8FFE49359549A* L_67 = (StringU5BU5D_tACEBFEDE350025B554CD507C9AE8FFE49359549A*)(StringU5BU5D_tACEBFEDE350025B554CD507C9AE8FFE49359549A*)SZArrayNew(StringU5BU5D_tACEBFEDE350025B554CD507C9AE8FFE49359549A_il2cpp_TypeInfo_var, (uint32_t)L_66);
		V_14 = (StringU5BU5D_tACEBFEDE350025B554CD507C9AE8FFE49359549A*)L_67;
		V_15 = (int32_t)0;
		goto IL_01c3;
	}

IL_019d:
	{
		intptr_t L_68 = ___array0;
		int32_t L_69 = V_15;
		intptr_t L_70;
		L_70 = AndroidJNI_GetObjectArrayElement_m502026BF77232EE45D03661E4923C2E5E99FDE18((intptr_t)L_68, (int32_t)L_69, /*hidden argument*/NULL);
		V_16 = (intptr_t)L_70;
		StringU5BU5D_tACEBFEDE350025B554CD507C9AE8FFE49359549A* L_71 = V_14;
		int32_t L_72 = V_15;
		intptr_t L_73 = V_16;
		String_t* L_74;
		L_74 = AndroidJNISafe_GetStringChars_mD59FFDE4192F837E1380B51569B5803E09BE58C8((intptr_t)L_73, /*hidden argument*/NULL);
		NullCheck(L_71);
		ArrayElementTypeCheck (L_71, L_74);
		(L_71)->SetAt(static_cast<il2cpp_array_size_t>(L_72), (String_t*)L_74);
		intptr_t L_75 = V_16;
		AndroidJNISafe_DeleteLocalRef_m7AB242A76D13A3BF4C04831D77960C020D6ADA39((intptr_t)L_75, /*hidden argument*/NULL);
		int32_t L_76 = V_15;
		V_15 = (int32_t)((int32_t)il2cpp_codegen_add((int32_t)L_76, (int32_t)1));
	}

IL_01c3:
	{
		int32_t L_77 = V_15;
		int32_t L_78 = V_13;
		V_17 = (bool)((((int32_t)L_77) < ((int32_t)L_78))? 1 : 0);
		bool L_79 = V_17;
		if (L_79)
		{
			goto IL_019d;
		}
	}
	{
		StringU5BU5D_tACEBFEDE350025B554CD507C9AE8FFE49359549A* L_80 = V_14;
		V_3 = (int32_t)((*(int32_t*)((int32_t*)UnBox((RuntimeObject *)L_80, IL2CPP_RGCTX_DATA(method->rgctx_data, 1)))));
		goto IL_0272;
	}

IL_01dc:
	{
		Type_t * L_81 = V_0;
		RuntimeTypeHandle_tC33965ADA3E041E0C94AF05E5CB527B56482CEF9  L_82 = { reinterpret_cast<intptr_t> (AndroidJavaObject_t10188D5695DCD09C9F621B44B0A8C93A2281236E_0_0_0_var) };
		IL2CPP_RUNTIME_CLASS_INIT(Type_t_il2cpp_TypeInfo_var);
		Type_t * L_83;
		L_83 = Type_GetTypeFromHandle_m8BB57524FF7F9DB1803BC561D2B3A4DBACEB385E((RuntimeTypeHandle_tC33965ADA3E041E0C94AF05E5CB527B56482CEF9 )L_82, /*hidden argument*/NULL);
		V_18 = (bool)((((RuntimeObject*)(Type_t *)L_81) == ((RuntimeObject*)(Type_t *)L_83))? 1 : 0);
		bool L_84 = V_18;
		if (!L_84)
		{
			goto IL_0242;
		}
	}
	{
		intptr_t L_85 = ___array0;
		int32_t L_86;
		L_86 = AndroidJNISafe_GetArrayLength_m3015C191DBFC246946A88592731441A934507B56((intptr_t)L_85, /*hidden argument*/NULL);
		V_19 = (int32_t)L_86;
		int32_t L_87 = V_19;
		AndroidJavaObjectU5BU5D_tEE28563C9013906CEB39794019A55F4BA5B06120* L_88 = (AndroidJavaObjectU5BU5D_tEE28563C9013906CEB39794019A55F4BA5B06120*)(AndroidJavaObjectU5BU5D_tEE28563C9013906CEB39794019A55F4BA5B06120*)SZArrayNew(AndroidJavaObjectU5BU5D_tEE28563C9013906CEB39794019A55F4BA5B06120_il2cpp_TypeInfo_var, (uint32_t)L_87);
		V_20 = (AndroidJavaObjectU5BU5D_tEE28563C9013906CEB39794019A55F4BA5B06120*)L_88;
		V_21 = (int32_t)0;
		goto IL_022c;
	}

IL_0206:
	{
		intptr_t L_89 = ___array0;
		int32_t L_90 = V_21;
		intptr_t L_91;
		L_91 = AndroidJNI_GetObjectArrayElement_m502026BF77232EE45D03661E4923C2E5E99FDE18((intptr_t)L_89, (int32_t)L_90, /*hidden argument*/NULL);
		V_22 = (intptr_t)L_91;
		AndroidJavaObjectU5BU5D_tEE28563C9013906CEB39794019A55F4BA5B06120* L_92 = V_20;
		int32_t L_93 = V_21;
		intptr_t L_94 = V_22;
		AndroidJavaObject_t10188D5695DCD09C9F621B44B0A8C93A2281236E * L_95 = (AndroidJavaObject_t10188D5695DCD09C9F621B44B0A8C93A2281236E *)il2cpp_codegen_object_new(AndroidJavaObject_t10188D5695DCD09C9F621B44B0A8C93A2281236E_il2cpp_TypeInfo_var);
		AndroidJavaObject__ctor_m880F6533139DF0BD36C6EF428E45E9F44B6534A3(L_95, (intptr_t)L_94, /*hidden argument*/NULL);
		NullCheck(L_92);
		ArrayElementTypeCheck (L_92, L_95);
		(L_92)->SetAt(static_cast<il2cpp_array_size_t>(L_93), (AndroidJavaObject_t10188D5695DCD09C9F621B44B0A8C93A2281236E *)L_95);
		intptr_t L_96 = V_22;
		AndroidJNISafe_DeleteLocalRef_m7AB242A76D13A3BF4C04831D77960C020D6ADA39((intptr_t)L_96, /*hidden argument*/NULL);
		int32_t L_97 = V_21;
		V_21 = (int32_t)((int32_t)il2cpp_codegen_add((int32_t)L_97, (int32_t)1));
	}

IL_022c:
	{
		int32_t L_98 = V_21;
		int32_t L_99 = V_19;
		V_23 = (bool)((((int32_t)L_98) < ((int32_t)L_99))? 1 : 0);
		bool L_100 = V_23;
		if (L_100)
		{
			goto IL_0206;
		}
	}
	{
		AndroidJavaObjectU5BU5D_tEE28563C9013906CEB39794019A55F4BA5B06120* L_101 = V_20;
		V_3 = (int32_t)((*(int32_t*)((int32_t*)UnBox((RuntimeObject *)L_101, IL2CPP_RGCTX_DATA(method->rgctx_data, 1)))));
		goto IL_0272;
	}

IL_0242:
	{
		Type_t * L_102 = V_0;
		Type_t * L_103 = (Type_t *)L_102;
		G_B31_0 = L_103;
		G_B31_1 = ((String_t*)il2cpp_codegen_initialize_runtime_metadata_inline((uintptr_t*)&_stringLiteral51253131B895C2F8066BCC47E62D44F18F43446C));
		if (L_103)
		{
			G_B32_0 = L_103;
			G_B32_1 = ((String_t*)il2cpp_codegen_initialize_runtime_metadata_inline((uintptr_t*)&_stringLiteral51253131B895C2F8066BCC47E62D44F18F43446C));
			goto IL_0250;
		}
	}
	{
		G_B33_0 = ((String_t*)(NULL));
		G_B33_1 = G_B31_1;
		goto IL_0255;
	}

IL_0250:
	{
		NullCheck((RuntimeObject *)G_B32_0);
		String_t* L_104;
		L_104 = VirtFuncInvoker0< String_t* >::Invoke(3 /* System.String System.Object::ToString() */, (RuntimeObject *)G_B32_0);
		G_B33_0 = L_104;
		G_B33_1 = G_B32_1;
	}

IL_0255:
	{
		String_t* L_105;
		L_105 = String_Concat_m89EAB4C6A96B0E5C3F87300D6BE78D386B9EFC44((String_t*)G_B33_1, (String_t*)G_B33_0, (String_t*)((String_t*)il2cpp_codegen_initialize_runtime_metadata_inline((uintptr_t*)&_stringLiteral42646B33B50B6AA15E22733C8900716F0FE19E1D)), /*hidden argument*/NULL);
		Exception_t * L_106 = (Exception_t *)il2cpp_codegen_object_new(((RuntimeClass*)il2cpp_codegen_initialize_runtime_metadata_inline((uintptr_t*)&Exception_t_il2cpp_TypeInfo_var)));
		Exception__ctor_m8ECDE8ACA7F2E0EF1144BD1200FB5DB2870B5F11(L_106, (String_t*)L_105, /*hidden argument*/NULL);
		IL2CPP_RAISE_MANAGED_EXCEPTION(L_106, ((RuntimeMethod*)il2cpp_codegen_initialize_runtime_metadata_inline((uintptr_t*)&_AndroidJNIHelper_ConvertFromJNIArray_TisInt32_tFDE5F8CD43D10453F6A2E0C77FE48C6CC7009046_m46E475527292788C29DD62A991E948CE3D9189A3_RuntimeMethod_var)));
	}

IL_0265:
	{
		il2cpp_codegen_initobj((&V_24), sizeof(int32_t));
		int32_t L_107 = V_24;
		V_3 = (int32_t)L_107;
		goto IL_0272;
	}

IL_0272:
	{
		int32_t L_108 = V_3;
		return (int32_t)L_108;
	}
}
// ArrayType UnityEngine._AndroidJNIHelper::ConvertFromJNIArray<System.Int64>(System.IntPtr)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR int64_t _AndroidJNIHelper_ConvertFromJNIArray_TisInt64_t378EE0D608BD3107E77238E85F30D2BBD46981F3_m67885FB92D65381C9570857BCD66D9A5377C9FC2_gshared (intptr_t ___array0, const RuntimeMethod* method)
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&AndroidJavaObjectU5BU5D_tEE28563C9013906CEB39794019A55F4BA5B06120_il2cpp_TypeInfo_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&AndroidJavaObject_t10188D5695DCD09C9F621B44B0A8C93A2281236E_0_0_0_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&AndroidJavaObject_t10188D5695DCD09C9F621B44B0A8C93A2281236E_il2cpp_TypeInfo_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&AndroidReflection_tEB6633FD5B7D2816E1AC6C711E11B2DD33822F16_il2cpp_TypeInfo_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Boolean_t07D1E3F34E4813023D64F584DFF7B34C9D922F37_0_0_0_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Byte_t0111FAB8B8685667EDDAF77683F0D8F86B659056_0_0_0_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Char_tFF60D8E7E89A20BE2294A003734341BD1DF43E14_0_0_0_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Debug_tEB68BCBEB8EFD60F8043C67146DC05E7F50F374B_il2cpp_TypeInfo_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Double_t42821932CB52DE2057E685D0E1AF3DE5033D2181_0_0_0_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Int16_tD0F031114106263BB459DA1F099FF9F42691295A_0_0_0_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Int32_tFDE5F8CD43D10453F6A2E0C77FE48C6CC7009046_0_0_0_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Int64_t378EE0D608BD3107E77238E85F30D2BBD46981F3_0_0_0_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&SByte_t928712DD662DC29BA4FAAE8CE2230AFB23447F0B_0_0_0_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Single_tE07797BA3C98D4CA9B5A19413C19A76688AB899E_0_0_0_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&StringU5BU5D_tACEBFEDE350025B554CD507C9AE8FFE49359549A_il2cpp_TypeInfo_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&String_t_0_0_0_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Type_t_il2cpp_TypeInfo_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&_stringLiteral24CC8D396132365E532646F936DFC8579E2299B2);
		s_Il2CppMethodInitialized = true;
	}
	Type_t * V_0 = NULL;
	bool V_1 = false;
	bool V_2 = false;
	int64_t V_3 = 0;
	bool V_4 = false;
	bool V_5 = false;
	bool V_6 = false;
	bool V_7 = false;
	bool V_8 = false;
	bool V_9 = false;
	bool V_10 = false;
	bool V_11 = false;
	bool V_12 = false;
	int32_t V_13 = 0;
	StringU5BU5D_tACEBFEDE350025B554CD507C9AE8FFE49359549A* V_14 = NULL;
	int32_t V_15 = 0;
	intptr_t V_16;
	memset((&V_16), 0, sizeof(V_16));
	bool V_17 = false;
	bool V_18 = false;
	int32_t V_19 = 0;
	AndroidJavaObjectU5BU5D_tEE28563C9013906CEB39794019A55F4BA5B06120* V_20 = NULL;
	int32_t V_21 = 0;
	intptr_t V_22;
	memset((&V_22), 0, sizeof(V_22));
	bool V_23 = false;
	int64_t V_24 = 0;
	Type_t * G_B32_0 = NULL;
	String_t* G_B32_1 = NULL;
	Type_t * G_B31_0 = NULL;
	String_t* G_B31_1 = NULL;
	String_t* G_B33_0 = NULL;
	String_t* G_B33_1 = NULL;
	{
		RuntimeTypeHandle_tC33965ADA3E041E0C94AF05E5CB527B56482CEF9  L_0 = { reinterpret_cast<intptr_t> (IL2CPP_RGCTX_TYPE(method->rgctx_data, 0)) };
		IL2CPP_RUNTIME_CLASS_INIT(Type_t_il2cpp_TypeInfo_var);
		Type_t * L_1;
		L_1 = Type_GetTypeFromHandle_m8BB57524FF7F9DB1803BC561D2B3A4DBACEB385E((RuntimeTypeHandle_tC33965ADA3E041E0C94AF05E5CB527B56482CEF9 )L_0, /*hidden argument*/NULL);
		NullCheck((Type_t *)L_1);
		Type_t * L_2;
		L_2 = VirtFuncInvoker0< Type_t * >::Invoke(220 /* System.Type System.Type::GetElementType() */, (Type_t *)L_1);
		V_0 = (Type_t *)L_2;
		Type_t * L_3 = V_0;
		IL2CPP_RUNTIME_CLASS_INIT(AndroidReflection_tEB6633FD5B7D2816E1AC6C711E11B2DD33822F16_il2cpp_TypeInfo_var);
		bool L_4;
		L_4 = AndroidReflection_IsPrimitive_mDD6A4050793DF2FA1EDF58010982C64A3F17376D((Type_t *)L_3, /*hidden argument*/NULL);
		V_1 = (bool)L_4;
		bool L_5 = V_1;
		if (!L_5)
		{
			goto IL_0173;
		}
	}
	{
		Type_t * L_6 = V_0;
		RuntimeTypeHandle_tC33965ADA3E041E0C94AF05E5CB527B56482CEF9  L_7 = { reinterpret_cast<intptr_t> (Int32_tFDE5F8CD43D10453F6A2E0C77FE48C6CC7009046_0_0_0_var) };
		IL2CPP_RUNTIME_CLASS_INIT(Type_t_il2cpp_TypeInfo_var);
		Type_t * L_8;
		L_8 = Type_GetTypeFromHandle_m8BB57524FF7F9DB1803BC561D2B3A4DBACEB385E((RuntimeTypeHandle_tC33965ADA3E041E0C94AF05E5CB527B56482CEF9 )L_7, /*hidden argument*/NULL);
		V_2 = (bool)((((RuntimeObject*)(Type_t *)L_6) == ((RuntimeObject*)(Type_t *)L_8))? 1 : 0);
		bool L_9 = V_2;
		if (!L_9)
		{
			goto IL_0041;
		}
	}
	{
		intptr_t L_10 = ___array0;
		Int32U5BU5D_t70F1BDC14B1786481B176D6139A5E3B87DC54C32* L_11;
		L_11 = AndroidJNISafe_FromIntArray_mBF0C0B4309BA525BBA12D7FD3C2790C8FA7C4703((intptr_t)L_10, /*hidden argument*/NULL);
		V_3 = (int64_t)((*(int64_t*)((int64_t*)UnBox((RuntimeObject *)L_11, IL2CPP_RGCTX_DATA(method->rgctx_data, 1)))));
		goto IL_0272;
	}

IL_0041:
	{
		Type_t * L_12 = V_0;
		RuntimeTypeHandle_tC33965ADA3E041E0C94AF05E5CB527B56482CEF9  L_13 = { reinterpret_cast<intptr_t> (Boolean_t07D1E3F34E4813023D64F584DFF7B34C9D922F37_0_0_0_var) };
		IL2CPP_RUNTIME_CLASS_INIT(Type_t_il2cpp_TypeInfo_var);
		Type_t * L_14;
		L_14 = Type_GetTypeFromHandle_m8BB57524FF7F9DB1803BC561D2B3A4DBACEB385E((RuntimeTypeHandle_tC33965ADA3E041E0C94AF05E5CB527B56482CEF9 )L_13, /*hidden argument*/NULL);
		V_4 = (bool)((((RuntimeObject*)(Type_t *)L_12) == ((RuntimeObject*)(Type_t *)L_14))? 1 : 0);
		bool L_15 = V_4;
		if (!L_15)
		{
			goto IL_0065;
		}
	}
	{
		intptr_t L_16 = ___array0;
		BooleanU5BU5D_tEC7BAF93C44F875016DAADC8696EE3A465644D3C* L_17;
		L_17 = AndroidJNISafe_FromBooleanArray_m77A66C34FCB94ADB1AD5E1D88262500C930A5DBF((intptr_t)L_16, /*hidden argument*/NULL);
		V_3 = (int64_t)((*(int64_t*)((int64_t*)UnBox((RuntimeObject *)L_17, IL2CPP_RGCTX_DATA(method->rgctx_data, 1)))));
		goto IL_0272;
	}

IL_0065:
	{
		Type_t * L_18 = V_0;
		RuntimeTypeHandle_tC33965ADA3E041E0C94AF05E5CB527B56482CEF9  L_19 = { reinterpret_cast<intptr_t> (Byte_t0111FAB8B8685667EDDAF77683F0D8F86B659056_0_0_0_var) };
		IL2CPP_RUNTIME_CLASS_INIT(Type_t_il2cpp_TypeInfo_var);
		Type_t * L_20;
		L_20 = Type_GetTypeFromHandle_m8BB57524FF7F9DB1803BC561D2B3A4DBACEB385E((RuntimeTypeHandle_tC33965ADA3E041E0C94AF05E5CB527B56482CEF9 )L_19, /*hidden argument*/NULL);
		V_5 = (bool)((((RuntimeObject*)(Type_t *)L_18) == ((RuntimeObject*)(Type_t *)L_20))? 1 : 0);
		bool L_21 = V_5;
		if (!L_21)
		{
			goto IL_0095;
		}
	}
	{
		IL2CPP_RUNTIME_CLASS_INIT(Debug_tEB68BCBEB8EFD60F8043C67146DC05E7F50F374B_il2cpp_TypeInfo_var);
		Debug_LogWarning_m24085D883C9E74D7AB423F0625E13259923960E7((RuntimeObject *)_stringLiteral24CC8D396132365E532646F936DFC8579E2299B2, /*hidden argument*/NULL);
		intptr_t L_22 = ___array0;
		ByteU5BU5D_tDBBEB0E8362242FA7223000D978B0DD19D4B0726* L_23;
		L_23 = AndroidJNISafe_FromByteArray_m81760A688AECE368E1CFF7DAAC8E141F1B8FA8A8((intptr_t)L_22, /*hidden argument*/NULL);
		V_3 = (int64_t)((*(int64_t*)((int64_t*)UnBox((RuntimeObject *)L_23, IL2CPP_RGCTX_DATA(method->rgctx_data, 1)))));
		goto IL_0272;
	}

IL_0095:
	{
		Type_t * L_24 = V_0;
		RuntimeTypeHandle_tC33965ADA3E041E0C94AF05E5CB527B56482CEF9  L_25 = { reinterpret_cast<intptr_t> (SByte_t928712DD662DC29BA4FAAE8CE2230AFB23447F0B_0_0_0_var) };
		IL2CPP_RUNTIME_CLASS_INIT(Type_t_il2cpp_TypeInfo_var);
		Type_t * L_26;
		L_26 = Type_GetTypeFromHandle_m8BB57524FF7F9DB1803BC561D2B3A4DBACEB385E((RuntimeTypeHandle_tC33965ADA3E041E0C94AF05E5CB527B56482CEF9 )L_25, /*hidden argument*/NULL);
		V_6 = (bool)((((RuntimeObject*)(Type_t *)L_24) == ((RuntimeObject*)(Type_t *)L_26))? 1 : 0);
		bool L_27 = V_6;
		if (!L_27)
		{
			goto IL_00b9;
		}
	}
	{
		intptr_t L_28 = ___array0;
		SByteU5BU5D_t7D94C53295E6116625EA7CC7DEA21FEDC39869E7* L_29;
		L_29 = AndroidJNISafe_FromSByteArray_m01F6539AF10F86B3927436955B57CC809C52416D((intptr_t)L_28, /*hidden argument*/NULL);
		V_3 = (int64_t)((*(int64_t*)((int64_t*)UnBox((RuntimeObject *)L_29, IL2CPP_RGCTX_DATA(method->rgctx_data, 1)))));
		goto IL_0272;
	}

IL_00b9:
	{
		Type_t * L_30 = V_0;
		RuntimeTypeHandle_tC33965ADA3E041E0C94AF05E5CB527B56482CEF9  L_31 = { reinterpret_cast<intptr_t> (Int16_tD0F031114106263BB459DA1F099FF9F42691295A_0_0_0_var) };
		IL2CPP_RUNTIME_CLASS_INIT(Type_t_il2cpp_TypeInfo_var);
		Type_t * L_32;
		L_32 = Type_GetTypeFromHandle_m8BB57524FF7F9DB1803BC561D2B3A4DBACEB385E((RuntimeTypeHandle_tC33965ADA3E041E0C94AF05E5CB527B56482CEF9 )L_31, /*hidden argument*/NULL);
		V_7 = (bool)((((RuntimeObject*)(Type_t *)L_30) == ((RuntimeObject*)(Type_t *)L_32))? 1 : 0);
		bool L_33 = V_7;
		if (!L_33)
		{
			goto IL_00dd;
		}
	}
	{
		intptr_t L_34 = ___array0;
		Int16U5BU5D_tD134F1E6F746D4C09C987436805256C210C2FFCD* L_35;
		L_35 = AndroidJNISafe_FromShortArray_mCDF5B796D950D31035BD35A2E463D41509E4A5CD((intptr_t)L_34, /*hidden argument*/NULL);
		V_3 = (int64_t)((*(int64_t*)((int64_t*)UnBox((RuntimeObject *)L_35, IL2CPP_RGCTX_DATA(method->rgctx_data, 1)))));
		goto IL_0272;
	}

IL_00dd:
	{
		Type_t * L_36 = V_0;
		RuntimeTypeHandle_tC33965ADA3E041E0C94AF05E5CB527B56482CEF9  L_37 = { reinterpret_cast<intptr_t> (Int64_t378EE0D608BD3107E77238E85F30D2BBD46981F3_0_0_0_var) };
		IL2CPP_RUNTIME_CLASS_INIT(Type_t_il2cpp_TypeInfo_var);
		Type_t * L_38;
		L_38 = Type_GetTypeFromHandle_m8BB57524FF7F9DB1803BC561D2B3A4DBACEB385E((RuntimeTypeHandle_tC33965ADA3E041E0C94AF05E5CB527B56482CEF9 )L_37, /*hidden argument*/NULL);
		V_8 = (bool)((((RuntimeObject*)(Type_t *)L_36) == ((RuntimeObject*)(Type_t *)L_38))? 1 : 0);
		bool L_39 = V_8;
		if (!L_39)
		{
			goto IL_0101;
		}
	}
	{
		intptr_t L_40 = ___array0;
		Int64U5BU5D_tCA61E42872C63A4286B24EEE6E0650143B43DCE6* L_41;
		L_41 = AndroidJNISafe_FromLongArray_m0E7C56CB8CFD0EC240F0D86ECBBFD635FFE55CDA((intptr_t)L_40, /*hidden argument*/NULL);
		V_3 = (int64_t)((*(int64_t*)((int64_t*)UnBox((RuntimeObject *)L_41, IL2CPP_RGCTX_DATA(method->rgctx_data, 1)))));
		goto IL_0272;
	}

IL_0101:
	{
		Type_t * L_42 = V_0;
		RuntimeTypeHandle_tC33965ADA3E041E0C94AF05E5CB527B56482CEF9  L_43 = { reinterpret_cast<intptr_t> (Single_tE07797BA3C98D4CA9B5A19413C19A76688AB899E_0_0_0_var) };
		IL2CPP_RUNTIME_CLASS_INIT(Type_t_il2cpp_TypeInfo_var);
		Type_t * L_44;
		L_44 = Type_GetTypeFromHandle_m8BB57524FF7F9DB1803BC561D2B3A4DBACEB385E((RuntimeTypeHandle_tC33965ADA3E041E0C94AF05E5CB527B56482CEF9 )L_43, /*hidden argument*/NULL);
		V_9 = (bool)((((RuntimeObject*)(Type_t *)L_42) == ((RuntimeObject*)(Type_t *)L_44))? 1 : 0);
		bool L_45 = V_9;
		if (!L_45)
		{
			goto IL_0125;
		}
	}
	{
		intptr_t L_46 = ___array0;
		SingleU5BU5D_t47E8DBF5B597C122478D1FFBD9DD57399A0650FA* L_47;
		L_47 = AndroidJNISafe_FromFloatArray_mF6A63CA1B7C10BC27EEC033F0E390772DFDD652D((intptr_t)L_46, /*hidden argument*/NULL);
		V_3 = (int64_t)((*(int64_t*)((int64_t*)UnBox((RuntimeObject *)L_47, IL2CPP_RGCTX_DATA(method->rgctx_data, 1)))));
		goto IL_0272;
	}

IL_0125:
	{
		Type_t * L_48 = V_0;
		RuntimeTypeHandle_tC33965ADA3E041E0C94AF05E5CB527B56482CEF9  L_49 = { reinterpret_cast<intptr_t> (Double_t42821932CB52DE2057E685D0E1AF3DE5033D2181_0_0_0_var) };
		IL2CPP_RUNTIME_CLASS_INIT(Type_t_il2cpp_TypeInfo_var);
		Type_t * L_50;
		L_50 = Type_GetTypeFromHandle_m8BB57524FF7F9DB1803BC561D2B3A4DBACEB385E((RuntimeTypeHandle_tC33965ADA3E041E0C94AF05E5CB527B56482CEF9 )L_49, /*hidden argument*/NULL);
		V_10 = (bool)((((RuntimeObject*)(Type_t *)L_48) == ((RuntimeObject*)(Type_t *)L_50))? 1 : 0);
		bool L_51 = V_10;
		if (!L_51)
		{
			goto IL_0149;
		}
	}
	{
		intptr_t L_52 = ___array0;
		DoubleU5BU5D_t8E1B42EB2ABB79FBD193A6B8C8D97A7CDE44A4FB* L_53;
		L_53 = AndroidJNISafe_FromDoubleArray_m9438B5668E8B2DB3B18CACFF0CC9CAEAB5EC73C8((intptr_t)L_52, /*hidden argument*/NULL);
		V_3 = (int64_t)((*(int64_t*)((int64_t*)UnBox((RuntimeObject *)L_53, IL2CPP_RGCTX_DATA(method->rgctx_data, 1)))));
		goto IL_0272;
	}

IL_0149:
	{
		Type_t * L_54 = V_0;
		RuntimeTypeHandle_tC33965ADA3E041E0C94AF05E5CB527B56482CEF9  L_55 = { reinterpret_cast<intptr_t> (Char_tFF60D8E7E89A20BE2294A003734341BD1DF43E14_0_0_0_var) };
		IL2CPP_RUNTIME_CLASS_INIT(Type_t_il2cpp_TypeInfo_var);
		Type_t * L_56;
		L_56 = Type_GetTypeFromHandle_m8BB57524FF7F9DB1803BC561D2B3A4DBACEB385E((RuntimeTypeHandle_tC33965ADA3E041E0C94AF05E5CB527B56482CEF9 )L_55, /*hidden argument*/NULL);
		V_11 = (bool)((((RuntimeObject*)(Type_t *)L_54) == ((RuntimeObject*)(Type_t *)L_56))? 1 : 0);
		bool L_57 = V_11;
		if (!L_57)
		{
			goto IL_016d;
		}
	}
	{
		intptr_t L_58 = ___array0;
		CharU5BU5D_t7B7FC5BC8091AA3B9CB0B29CDD80B5EE9254AA34* L_59;
		L_59 = AndroidJNISafe_FromCharArray_mA49DB27755EF3B2AE81487E0FCFE06E23F617305((intptr_t)L_58, /*hidden argument*/NULL);
		V_3 = (int64_t)((*(int64_t*)((int64_t*)UnBox((RuntimeObject *)L_59, IL2CPP_RGCTX_DATA(method->rgctx_data, 1)))));
		goto IL_0272;
	}

IL_016d:
	{
		goto IL_0265;
	}

IL_0173:
	{
		Type_t * L_60 = V_0;
		RuntimeTypeHandle_tC33965ADA3E041E0C94AF05E5CB527B56482CEF9  L_61 = { reinterpret_cast<intptr_t> (String_t_0_0_0_var) };
		IL2CPP_RUNTIME_CLASS_INIT(Type_t_il2cpp_TypeInfo_var);
		Type_t * L_62;
		L_62 = Type_GetTypeFromHandle_m8BB57524FF7F9DB1803BC561D2B3A4DBACEB385E((RuntimeTypeHandle_tC33965ADA3E041E0C94AF05E5CB527B56482CEF9 )L_61, /*hidden argument*/NULL);
		V_12 = (bool)((((RuntimeObject*)(Type_t *)L_60) == ((RuntimeObject*)(Type_t *)L_62))? 1 : 0);
		bool L_63 = V_12;
		if (!L_63)
		{
			goto IL_01dc;
		}
	}
	{
		intptr_t L_64 = ___array0;
		int32_t L_65;
		L_65 = AndroidJNISafe_GetArrayLength_m3015C191DBFC246946A88592731441A934507B56((intptr_t)L_64, /*hidden argument*/NULL);
		V_13 = (int32_t)L_65;
		int32_t L_66 = V_13;
		StringU5BU5D_tACEBFEDE350025B554CD507C9AE8FFE49359549A* L_67 = (StringU5BU5D_tACEBFEDE350025B554CD507C9AE8FFE49359549A*)(StringU5BU5D_tACEBFEDE350025B554CD507C9AE8FFE49359549A*)SZArrayNew(StringU5BU5D_tACEBFEDE350025B554CD507C9AE8FFE49359549A_il2cpp_TypeInfo_var, (uint32_t)L_66);
		V_14 = (StringU5BU5D_tACEBFEDE350025B554CD507C9AE8FFE49359549A*)L_67;
		V_15 = (int32_t)0;
		goto IL_01c3;
	}

IL_019d:
	{
		intptr_t L_68 = ___array0;
		int32_t L_69 = V_15;
		intptr_t L_70;
		L_70 = AndroidJNI_GetObjectArrayElement_m502026BF77232EE45D03661E4923C2E5E99FDE18((intptr_t)L_68, (int32_t)L_69, /*hidden argument*/NULL);
		V_16 = (intptr_t)L_70;
		StringU5BU5D_tACEBFEDE350025B554CD507C9AE8FFE49359549A* L_71 = V_14;
		int32_t L_72 = V_15;
		intptr_t L_73 = V_16;
		String_t* L_74;
		L_74 = AndroidJNISafe_GetStringChars_mD59FFDE4192F837E1380B51569B5803E09BE58C8((intptr_t)L_73, /*hidden argument*/NULL);
		NullCheck(L_71);
		ArrayElementTypeCheck (L_71, L_74);
		(L_71)->SetAt(static_cast<il2cpp_array_size_t>(L_72), (String_t*)L_74);
		intptr_t L_75 = V_16;
		AndroidJNISafe_DeleteLocalRef_m7AB242A76D13A3BF4C04831D77960C020D6ADA39((intptr_t)L_75, /*hidden argument*/NULL);
		int32_t L_76 = V_15;
		V_15 = (int32_t)((int32_t)il2cpp_codegen_add((int32_t)L_76, (int32_t)1));
	}

IL_01c3:
	{
		int32_t L_77 = V_15;
		int32_t L_78 = V_13;
		V_17 = (bool)((((int32_t)L_77) < ((int32_t)L_78))? 1 : 0);
		bool L_79 = V_17;
		if (L_79)
		{
			goto IL_019d;
		}
	}
	{
		StringU5BU5D_tACEBFEDE350025B554CD507C9AE8FFE49359549A* L_80 = V_14;
		V_3 = (int64_t)((*(int64_t*)((int64_t*)UnBox((RuntimeObject *)L_80, IL2CPP_RGCTX_DATA(method->rgctx_data, 1)))));
		goto IL_0272;
	}

IL_01dc:
	{
		Type_t * L_81 = V_0;
		RuntimeTypeHandle_tC33965ADA3E041E0C94AF05E5CB527B56482CEF9  L_82 = { reinterpret_cast<intptr_t> (AndroidJavaObject_t10188D5695DCD09C9F621B44B0A8C93A2281236E_0_0_0_var) };
		IL2CPP_RUNTIME_CLASS_INIT(Type_t_il2cpp_TypeInfo_var);
		Type_t * L_83;
		L_83 = Type_GetTypeFromHandle_m8BB57524FF7F9DB1803BC561D2B3A4DBACEB385E((RuntimeTypeHandle_tC33965ADA3E041E0C94AF05E5CB527B56482CEF9 )L_82, /*hidden argument*/NULL);
		V_18 = (bool)((((RuntimeObject*)(Type_t *)L_81) == ((RuntimeObject*)(Type_t *)L_83))? 1 : 0);
		bool L_84 = V_18;
		if (!L_84)
		{
			goto IL_0242;
		}
	}
	{
		intptr_t L_85 = ___array0;
		int32_t L_86;
		L_86 = AndroidJNISafe_GetArrayLength_m3015C191DBFC246946A88592731441A934507B56((intptr_t)L_85, /*hidden argument*/NULL);
		V_19 = (int32_t)L_86;
		int32_t L_87 = V_19;
		AndroidJavaObjectU5BU5D_tEE28563C9013906CEB39794019A55F4BA5B06120* L_88 = (AndroidJavaObjectU5BU5D_tEE28563C9013906CEB39794019A55F4BA5B06120*)(AndroidJavaObjectU5BU5D_tEE28563C9013906CEB39794019A55F4BA5B06120*)SZArrayNew(AndroidJavaObjectU5BU5D_tEE28563C9013906CEB39794019A55F4BA5B06120_il2cpp_TypeInfo_var, (uint32_t)L_87);
		V_20 = (AndroidJavaObjectU5BU5D_tEE28563C9013906CEB39794019A55F4BA5B06120*)L_88;
		V_21 = (int32_t)0;
		goto IL_022c;
	}

IL_0206:
	{
		intptr_t L_89 = ___array0;
		int32_t L_90 = V_21;
		intptr_t L_91;
		L_91 = AndroidJNI_GetObjectArrayElement_m502026BF77232EE45D03661E4923C2E5E99FDE18((intptr_t)L_89, (int32_t)L_90, /*hidden argument*/NULL);
		V_22 = (intptr_t)L_91;
		AndroidJavaObjectU5BU5D_tEE28563C9013906CEB39794019A55F4BA5B06120* L_92 = V_20;
		int32_t L_93 = V_21;
		intptr_t L_94 = V_22;
		AndroidJavaObject_t10188D5695DCD09C9F621B44B0A8C93A2281236E * L_95 = (AndroidJavaObject_t10188D5695DCD09C9F621B44B0A8C93A2281236E *)il2cpp_codegen_object_new(AndroidJavaObject_t10188D5695DCD09C9F621B44B0A8C93A2281236E_il2cpp_TypeInfo_var);
		AndroidJavaObject__ctor_m880F6533139DF0BD36C6EF428E45E9F44B6534A3(L_95, (intptr_t)L_94, /*hidden argument*/NULL);
		NullCheck(L_92);
		ArrayElementTypeCheck (L_92, L_95);
		(L_92)->SetAt(static_cast<il2cpp_array_size_t>(L_93), (AndroidJavaObject_t10188D5695DCD09C9F621B44B0A8C93A2281236E *)L_95);
		intptr_t L_96 = V_22;
		AndroidJNISafe_DeleteLocalRef_m7AB242A76D13A3BF4C04831D77960C020D6ADA39((intptr_t)L_96, /*hidden argument*/NULL);
		int32_t L_97 = V_21;
		V_21 = (int32_t)((int32_t)il2cpp_codegen_add((int32_t)L_97, (int32_t)1));
	}

IL_022c:
	{
		int32_t L_98 = V_21;
		int32_t L_99 = V_19;
		V_23 = (bool)((((int32_t)L_98) < ((int32_t)L_99))? 1 : 0);
		bool L_100 = V_23;
		if (L_100)
		{
			goto IL_0206;
		}
	}
	{
		AndroidJavaObjectU5BU5D_tEE28563C9013906CEB39794019A55F4BA5B06120* L_101 = V_20;
		V_3 = (int64_t)((*(int64_t*)((int64_t*)UnBox((RuntimeObject *)L_101, IL2CPP_RGCTX_DATA(method->rgctx_data, 1)))));
		goto IL_0272;
	}

IL_0242:
	{
		Type_t * L_102 = V_0;
		Type_t * L_103 = (Type_t *)L_102;
		G_B31_0 = L_103;
		G_B31_1 = ((String_t*)il2cpp_codegen_initialize_runtime_metadata_inline((uintptr_t*)&_stringLiteral51253131B895C2F8066BCC47E62D44F18F43446C));
		if (L_103)
		{
			G_B32_0 = L_103;
			G_B32_1 = ((String_t*)il2cpp_codegen_initialize_runtime_metadata_inline((uintptr_t*)&_stringLiteral51253131B895C2F8066BCC47E62D44F18F43446C));
			goto IL_0250;
		}
	}
	{
		G_B33_0 = ((String_t*)(NULL));
		G_B33_1 = G_B31_1;
		goto IL_0255;
	}

IL_0250:
	{
		NullCheck((RuntimeObject *)G_B32_0);
		String_t* L_104;
		L_104 = VirtFuncInvoker0< String_t* >::Invoke(3 /* System.String System.Object::ToString() */, (RuntimeObject *)G_B32_0);
		G_B33_0 = L_104;
		G_B33_1 = G_B32_1;
	}

IL_0255:
	{
		String_t* L_105;
		L_105 = String_Concat_m89EAB4C6A96B0E5C3F87300D6BE78D386B9EFC44((String_t*)G_B33_1, (String_t*)G_B33_0, (String_t*)((String_t*)il2cpp_codegen_initialize_runtime_metadata_inline((uintptr_t*)&_stringLiteral42646B33B50B6AA15E22733C8900716F0FE19E1D)), /*hidden argument*/NULL);
		Exception_t * L_106 = (Exception_t *)il2cpp_codegen_object_new(((RuntimeClass*)il2cpp_codegen_initialize_runtime_metadata_inline((uintptr_t*)&Exception_t_il2cpp_TypeInfo_var)));
		Exception__ctor_m8ECDE8ACA7F2E0EF1144BD1200FB5DB2870B5F11(L_106, (String_t*)L_105, /*hidden argument*/NULL);
		IL2CPP_RAISE_MANAGED_EXCEPTION(L_106, ((RuntimeMethod*)il2cpp_codegen_initialize_runtime_metadata_inline((uintptr_t*)&_AndroidJNIHelper_ConvertFromJNIArray_TisInt64_t378EE0D608BD3107E77238E85F30D2BBD46981F3_m67885FB92D65381C9570857BCD66D9A5377C9FC2_RuntimeMethod_var)));
	}

IL_0265:
	{
		il2cpp_codegen_initobj((&V_24), sizeof(int64_t));
		int64_t L_107 = V_24;
		V_3 = (int64_t)L_107;
		goto IL_0272;
	}

IL_0272:
	{
		int64_t L_108 = V_3;
		return (int64_t)L_108;
	}
}
// ArrayType UnityEngine._AndroidJNIHelper::ConvertFromJNIArray<System.Object>(System.IntPtr)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR RuntimeObject * _AndroidJNIHelper_ConvertFromJNIArray_TisRuntimeObject_m353E485413995A0C209B6FAA96D368CF72FB4592_gshared (intptr_t ___array0, const RuntimeMethod* method)
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&AndroidJavaObjectU5BU5D_tEE28563C9013906CEB39794019A55F4BA5B06120_il2cpp_TypeInfo_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&AndroidJavaObject_t10188D5695DCD09C9F621B44B0A8C93A2281236E_0_0_0_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&AndroidJavaObject_t10188D5695DCD09C9F621B44B0A8C93A2281236E_il2cpp_TypeInfo_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&AndroidReflection_tEB6633FD5B7D2816E1AC6C711E11B2DD33822F16_il2cpp_TypeInfo_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Boolean_t07D1E3F34E4813023D64F584DFF7B34C9D922F37_0_0_0_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Byte_t0111FAB8B8685667EDDAF77683F0D8F86B659056_0_0_0_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Char_tFF60D8E7E89A20BE2294A003734341BD1DF43E14_0_0_0_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Debug_tEB68BCBEB8EFD60F8043C67146DC05E7F50F374B_il2cpp_TypeInfo_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Double_t42821932CB52DE2057E685D0E1AF3DE5033D2181_0_0_0_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Int16_tD0F031114106263BB459DA1F099FF9F42691295A_0_0_0_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Int32_tFDE5F8CD43D10453F6A2E0C77FE48C6CC7009046_0_0_0_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Int64_t378EE0D608BD3107E77238E85F30D2BBD46981F3_0_0_0_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&SByte_t928712DD662DC29BA4FAAE8CE2230AFB23447F0B_0_0_0_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Single_tE07797BA3C98D4CA9B5A19413C19A76688AB899E_0_0_0_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&StringU5BU5D_tACEBFEDE350025B554CD507C9AE8FFE49359549A_il2cpp_TypeInfo_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&String_t_0_0_0_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Type_t_il2cpp_TypeInfo_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&_stringLiteral24CC8D396132365E532646F936DFC8579E2299B2);
		s_Il2CppMethodInitialized = true;
	}
	Type_t * V_0 = NULL;
	bool V_1 = false;
	bool V_2 = false;
	RuntimeObject * V_3 = NULL;
	bool V_4 = false;
	bool V_5 = false;
	bool V_6 = false;
	bool V_7 = false;
	bool V_8 = false;
	bool V_9 = false;
	bool V_10 = false;
	bool V_11 = false;
	bool V_12 = false;
	int32_t V_13 = 0;
	StringU5BU5D_tACEBFEDE350025B554CD507C9AE8FFE49359549A* V_14 = NULL;
	int32_t V_15 = 0;
	intptr_t V_16;
	memset((&V_16), 0, sizeof(V_16));
	bool V_17 = false;
	bool V_18 = false;
	int32_t V_19 = 0;
	AndroidJavaObjectU5BU5D_tEE28563C9013906CEB39794019A55F4BA5B06120* V_20 = NULL;
	int32_t V_21 = 0;
	intptr_t V_22;
	memset((&V_22), 0, sizeof(V_22));
	bool V_23 = false;
	RuntimeObject * V_24 = NULL;
	Type_t * G_B32_0 = NULL;
	String_t* G_B32_1 = NULL;
	Type_t * G_B31_0 = NULL;
	String_t* G_B31_1 = NULL;
	String_t* G_B33_0 = NULL;
	String_t* G_B33_1 = NULL;
	{
		RuntimeTypeHandle_tC33965ADA3E041E0C94AF05E5CB527B56482CEF9  L_0 = { reinterpret_cast<intptr_t> (IL2CPP_RGCTX_TYPE(method->rgctx_data, 0)) };
		IL2CPP_RUNTIME_CLASS_INIT(Type_t_il2cpp_TypeInfo_var);
		Type_t * L_1;
		L_1 = Type_GetTypeFromHandle_m8BB57524FF7F9DB1803BC561D2B3A4DBACEB385E((RuntimeTypeHandle_tC33965ADA3E041E0C94AF05E5CB527B56482CEF9 )L_0, /*hidden argument*/NULL);
		NullCheck((Type_t *)L_1);
		Type_t * L_2;
		L_2 = VirtFuncInvoker0< Type_t * >::Invoke(220 /* System.Type System.Type::GetElementType() */, (Type_t *)L_1);
		V_0 = (Type_t *)L_2;
		Type_t * L_3 = V_0;
		IL2CPP_RUNTIME_CLASS_INIT(AndroidReflection_tEB6633FD5B7D2816E1AC6C711E11B2DD33822F16_il2cpp_TypeInfo_var);
		bool L_4;
		L_4 = AndroidReflection_IsPrimitive_mDD6A4050793DF2FA1EDF58010982C64A3F17376D((Type_t *)L_3, /*hidden argument*/NULL);
		V_1 = (bool)L_4;
		bool L_5 = V_1;
		if (!L_5)
		{
			goto IL_0173;
		}
	}
	{
		Type_t * L_6 = V_0;
		RuntimeTypeHandle_tC33965ADA3E041E0C94AF05E5CB527B56482CEF9  L_7 = { reinterpret_cast<intptr_t> (Int32_tFDE5F8CD43D10453F6A2E0C77FE48C6CC7009046_0_0_0_var) };
		IL2CPP_RUNTIME_CLASS_INIT(Type_t_il2cpp_TypeInfo_var);
		Type_t * L_8;
		L_8 = Type_GetTypeFromHandle_m8BB57524FF7F9DB1803BC561D2B3A4DBACEB385E((RuntimeTypeHandle_tC33965ADA3E041E0C94AF05E5CB527B56482CEF9 )L_7, /*hidden argument*/NULL);
		V_2 = (bool)((((RuntimeObject*)(Type_t *)L_6) == ((RuntimeObject*)(Type_t *)L_8))? 1 : 0);
		bool L_9 = V_2;
		if (!L_9)
		{
			goto IL_0041;
		}
	}
	{
		intptr_t L_10 = ___array0;
		Int32U5BU5D_t70F1BDC14B1786481B176D6139A5E3B87DC54C32* L_11;
		L_11 = AndroidJNISafe_FromIntArray_mBF0C0B4309BA525BBA12D7FD3C2790C8FA7C4703((intptr_t)L_10, /*hidden argument*/NULL);
		V_3 = (RuntimeObject *)((RuntimeObject *)Castclass((RuntimeObject*)L_11, IL2CPP_RGCTX_DATA(method->rgctx_data, 1)));
		goto IL_0272;
	}

IL_0041:
	{
		Type_t * L_12 = V_0;
		RuntimeTypeHandle_tC33965ADA3E041E0C94AF05E5CB527B56482CEF9  L_13 = { reinterpret_cast<intptr_t> (Boolean_t07D1E3F34E4813023D64F584DFF7B34C9D922F37_0_0_0_var) };
		IL2CPP_RUNTIME_CLASS_INIT(Type_t_il2cpp_TypeInfo_var);
		Type_t * L_14;
		L_14 = Type_GetTypeFromHandle_m8BB57524FF7F9DB1803BC561D2B3A4DBACEB385E((RuntimeTypeHandle_tC33965ADA3E041E0C94AF05E5CB527B56482CEF9 )L_13, /*hidden argument*/NULL);
		V_4 = (bool)((((RuntimeObject*)(Type_t *)L_12) == ((RuntimeObject*)(Type_t *)L_14))? 1 : 0);
		bool L_15 = V_4;
		if (!L_15)
		{
			goto IL_0065;
		}
	}
	{
		intptr_t L_16 = ___array0;
		BooleanU5BU5D_tEC7BAF93C44F875016DAADC8696EE3A465644D3C* L_17;
		L_17 = AndroidJNISafe_FromBooleanArray_m77A66C34FCB94ADB1AD5E1D88262500C930A5DBF((intptr_t)L_16, /*hidden argument*/NULL);
		V_3 = (RuntimeObject *)((RuntimeObject *)Castclass((RuntimeObject*)L_17, IL2CPP_RGCTX_DATA(method->rgctx_data, 1)));
		goto IL_0272;
	}

IL_0065:
	{
		Type_t * L_18 = V_0;
		RuntimeTypeHandle_tC33965ADA3E041E0C94AF05E5CB527B56482CEF9  L_19 = { reinterpret_cast<intptr_t> (Byte_t0111FAB8B8685667EDDAF77683F0D8F86B659056_0_0_0_var) };
		IL2CPP_RUNTIME_CLASS_INIT(Type_t_il2cpp_TypeInfo_var);
		Type_t * L_20;
		L_20 = Type_GetTypeFromHandle_m8BB57524FF7F9DB1803BC561D2B3A4DBACEB385E((RuntimeTypeHandle_tC33965ADA3E041E0C94AF05E5CB527B56482CEF9 )L_19, /*hidden argument*/NULL);
		V_5 = (bool)((((RuntimeObject*)(Type_t *)L_18) == ((RuntimeObject*)(Type_t *)L_20))? 1 : 0);
		bool L_21 = V_5;
		if (!L_21)
		{
			goto IL_0095;
		}
	}
	{
		IL2CPP_RUNTIME_CLASS_INIT(Debug_tEB68BCBEB8EFD60F8043C67146DC05E7F50F374B_il2cpp_TypeInfo_var);
		Debug_LogWarning_m24085D883C9E74D7AB423F0625E13259923960E7((RuntimeObject *)_stringLiteral24CC8D396132365E532646F936DFC8579E2299B2, /*hidden argument*/NULL);
		intptr_t L_22 = ___array0;
		ByteU5BU5D_tDBBEB0E8362242FA7223000D978B0DD19D4B0726* L_23;
		L_23 = AndroidJNISafe_FromByteArray_m81760A688AECE368E1CFF7DAAC8E141F1B8FA8A8((intptr_t)L_22, /*hidden argument*/NULL);
		V_3 = (RuntimeObject *)((RuntimeObject *)Castclass((RuntimeObject*)L_23, IL2CPP_RGCTX_DATA(method->rgctx_data, 1)));
		goto IL_0272;
	}

IL_0095:
	{
		Type_t * L_24 = V_0;
		RuntimeTypeHandle_tC33965ADA3E041E0C94AF05E5CB527B56482CEF9  L_25 = { reinterpret_cast<intptr_t> (SByte_t928712DD662DC29BA4FAAE8CE2230AFB23447F0B_0_0_0_var) };
		IL2CPP_RUNTIME_CLASS_INIT(Type_t_il2cpp_TypeInfo_var);
		Type_t * L_26;
		L_26 = Type_GetTypeFromHandle_m8BB57524FF7F9DB1803BC561D2B3A4DBACEB385E((RuntimeTypeHandle_tC33965ADA3E041E0C94AF05E5CB527B56482CEF9 )L_25, /*hidden argument*/NULL);
		V_6 = (bool)((((RuntimeObject*)(Type_t *)L_24) == ((RuntimeObject*)(Type_t *)L_26))? 1 : 0);
		bool L_27 = V_6;
		if (!L_27)
		{
			goto IL_00b9;
		}
	}
	{
		intptr_t L_28 = ___array0;
		SByteU5BU5D_t7D94C53295E6116625EA7CC7DEA21FEDC39869E7* L_29;
		L_29 = AndroidJNISafe_FromSByteArray_m01F6539AF10F86B3927436955B57CC809C52416D((intptr_t)L_28, /*hidden argument*/NULL);
		V_3 = (RuntimeObject *)((RuntimeObject *)Castclass((RuntimeObject*)L_29, IL2CPP_RGCTX_DATA(method->rgctx_data, 1)));
		goto IL_0272;
	}

IL_00b9:
	{
		Type_t * L_30 = V_0;
		RuntimeTypeHandle_tC33965ADA3E041E0C94AF05E5CB527B56482CEF9  L_31 = { reinterpret_cast<intptr_t> (Int16_tD0F031114106263BB459DA1F099FF9F42691295A_0_0_0_var) };
		IL2CPP_RUNTIME_CLASS_INIT(Type_t_il2cpp_TypeInfo_var);
		Type_t * L_32;
		L_32 = Type_GetTypeFromHandle_m8BB57524FF7F9DB1803BC561D2B3A4DBACEB385E((RuntimeTypeHandle_tC33965ADA3E041E0C94AF05E5CB527B56482CEF9 )L_31, /*hidden argument*/NULL);
		V_7 = (bool)((((RuntimeObject*)(Type_t *)L_30) == ((RuntimeObject*)(Type_t *)L_32))? 1 : 0);
		bool L_33 = V_7;
		if (!L_33)
		{
			goto IL_00dd;
		}
	}
	{
		intptr_t L_34 = ___array0;
		Int16U5BU5D_tD134F1E6F746D4C09C987436805256C210C2FFCD* L_35;
		L_35 = AndroidJNISafe_FromShortArray_mCDF5B796D950D31035BD35A2E463D41509E4A5CD((intptr_t)L_34, /*hidden argument*/NULL);
		V_3 = (RuntimeObject *)((RuntimeObject *)Castclass((RuntimeObject*)L_35, IL2CPP_RGCTX_DATA(method->rgctx_data, 1)));
		goto IL_0272;
	}

IL_00dd:
	{
		Type_t * L_36 = V_0;
		RuntimeTypeHandle_tC33965ADA3E041E0C94AF05E5CB527B56482CEF9  L_37 = { reinterpret_cast<intptr_t> (Int64_t378EE0D608BD3107E77238E85F30D2BBD46981F3_0_0_0_var) };
		IL2CPP_RUNTIME_CLASS_INIT(Type_t_il2cpp_TypeInfo_var);
		Type_t * L_38;
		L_38 = Type_GetTypeFromHandle_m8BB57524FF7F9DB1803BC561D2B3A4DBACEB385E((RuntimeTypeHandle_tC33965ADA3E041E0C94AF05E5CB527B56482CEF9 )L_37, /*hidden argument*/NULL);
		V_8 = (bool)((((RuntimeObject*)(Type_t *)L_36) == ((RuntimeObject*)(Type_t *)L_38))? 1 : 0);
		bool L_39 = V_8;
		if (!L_39)
		{
			goto IL_0101;
		}
	}
	{
		intptr_t L_40 = ___array0;
		Int64U5BU5D_tCA61E42872C63A4286B24EEE6E0650143B43DCE6* L_41;
		L_41 = AndroidJNISafe_FromLongArray_m0E7C56CB8CFD0EC240F0D86ECBBFD635FFE55CDA((intptr_t)L_40, /*hidden argument*/NULL);
		V_3 = (RuntimeObject *)((RuntimeObject *)Castclass((RuntimeObject*)L_41, IL2CPP_RGCTX_DATA(method->rgctx_data, 1)));
		goto IL_0272;
	}

IL_0101:
	{
		Type_t * L_42 = V_0;
		RuntimeTypeHandle_tC33965ADA3E041E0C94AF05E5CB527B56482CEF9  L_43 = { reinterpret_cast<intptr_t> (Single_tE07797BA3C98D4CA9B5A19413C19A76688AB899E_0_0_0_var) };
		IL2CPP_RUNTIME_CLASS_INIT(Type_t_il2cpp_TypeInfo_var);
		Type_t * L_44;
		L_44 = Type_GetTypeFromHandle_m8BB57524FF7F9DB1803BC561D2B3A4DBACEB385E((RuntimeTypeHandle_tC33965ADA3E041E0C94AF05E5CB527B56482CEF9 )L_43, /*hidden argument*/NULL);
		V_9 = (bool)((((RuntimeObject*)(Type_t *)L_42) == ((RuntimeObject*)(Type_t *)L_44))? 1 : 0);
		bool L_45 = V_9;
		if (!L_45)
		{
			goto IL_0125;
		}
	}
	{
		intptr_t L_46 = ___array0;
		SingleU5BU5D_t47E8DBF5B597C122478D1FFBD9DD57399A0650FA* L_47;
		L_47 = AndroidJNISafe_FromFloatArray_mF6A63CA1B7C10BC27EEC033F0E390772DFDD652D((intptr_t)L_46, /*hidden argument*/NULL);
		V_3 = (RuntimeObject *)((RuntimeObject *)Castclass((RuntimeObject*)L_47, IL2CPP_RGCTX_DATA(method->rgctx_data, 1)));
		goto IL_0272;
	}

IL_0125:
	{
		Type_t * L_48 = V_0;
		RuntimeTypeHandle_tC33965ADA3E041E0C94AF05E5CB527B56482CEF9  L_49 = { reinterpret_cast<intptr_t> (Double_t42821932CB52DE2057E685D0E1AF3DE5033D2181_0_0_0_var) };
		IL2CPP_RUNTIME_CLASS_INIT(Type_t_il2cpp_TypeInfo_var);
		Type_t * L_50;
		L_50 = Type_GetTypeFromHandle_m8BB57524FF7F9DB1803BC561D2B3A4DBACEB385E((RuntimeTypeHandle_tC33965ADA3E041E0C94AF05E5CB527B56482CEF9 )L_49, /*hidden argument*/NULL);
		V_10 = (bool)((((RuntimeObject*)(Type_t *)L_48) == ((RuntimeObject*)(Type_t *)L_50))? 1 : 0);
		bool L_51 = V_10;
		if (!L_51)
		{
			goto IL_0149;
		}
	}
	{
		intptr_t L_52 = ___array0;
		DoubleU5BU5D_t8E1B42EB2ABB79FBD193A6B8C8D97A7CDE44A4FB* L_53;
		L_53 = AndroidJNISafe_FromDoubleArray_m9438B5668E8B2DB3B18CACFF0CC9CAEAB5EC73C8((intptr_t)L_52, /*hidden argument*/NULL);
		V_3 = (RuntimeObject *)((RuntimeObject *)Castclass((RuntimeObject*)L_53, IL2CPP_RGCTX_DATA(method->rgctx_data, 1)));
		goto IL_0272;
	}

IL_0149:
	{
		Type_t * L_54 = V_0;
		RuntimeTypeHandle_tC33965ADA3E041E0C94AF05E5CB527B56482CEF9  L_55 = { reinterpret_cast<intptr_t> (Char_tFF60D8E7E89A20BE2294A003734341BD1DF43E14_0_0_0_var) };
		IL2CPP_RUNTIME_CLASS_INIT(Type_t_il2cpp_TypeInfo_var);
		Type_t * L_56;
		L_56 = Type_GetTypeFromHandle_m8BB57524FF7F9DB1803BC561D2B3A4DBACEB385E((RuntimeTypeHandle_tC33965ADA3E041E0C94AF05E5CB527B56482CEF9 )L_55, /*hidden argument*/NULL);
		V_11 = (bool)((((RuntimeObject*)(Type_t *)L_54) == ((RuntimeObject*)(Type_t *)L_56))? 1 : 0);
		bool L_57 = V_11;
		if (!L_57)
		{
			goto IL_016d;
		}
	}
	{
		intptr_t L_58 = ___array0;
		CharU5BU5D_t7B7FC5BC8091AA3B9CB0B29CDD80B5EE9254AA34* L_59;
		L_59 = AndroidJNISafe_FromCharArray_mA49DB27755EF3B2AE81487E0FCFE06E23F617305((intptr_t)L_58, /*hidden argument*/NULL);
		V_3 = (RuntimeObject *)((RuntimeObject *)Castclass((RuntimeObject*)L_59, IL2CPP_RGCTX_DATA(method->rgctx_data, 1)));
		goto IL_0272;
	}

IL_016d:
	{
		goto IL_0265;
	}

IL_0173:
	{
		Type_t * L_60 = V_0;
		RuntimeTypeHandle_tC33965ADA3E041E0C94AF05E5CB527B56482CEF9  L_61 = { reinterpret_cast<intptr_t> (String_t_0_0_0_var) };
		IL2CPP_RUNTIME_CLASS_INIT(Type_t_il2cpp_TypeInfo_var);
		Type_t * L_62;
		L_62 = Type_GetTypeFromHandle_m8BB57524FF7F9DB1803BC561D2B3A4DBACEB385E((RuntimeTypeHandle_tC33965ADA3E041E0C94AF05E5CB527B56482CEF9 )L_61, /*hidden argument*/NULL);
		V_12 = (bool)((((RuntimeObject*)(Type_t *)L_60) == ((RuntimeObject*)(Type_t *)L_62))? 1 : 0);
		bool L_63 = V_12;
		if (!L_63)
		{
			goto IL_01dc;
		}
	}
	{
		intptr_t L_64 = ___array0;
		int32_t L_65;
		L_65 = AndroidJNISafe_GetArrayLength_m3015C191DBFC246946A88592731441A934507B56((intptr_t)L_64, /*hidden argument*/NULL);
		V_13 = (int32_t)L_65;
		int32_t L_66 = V_13;
		StringU5BU5D_tACEBFEDE350025B554CD507C9AE8FFE49359549A* L_67 = (StringU5BU5D_tACEBFEDE350025B554CD507C9AE8FFE49359549A*)(StringU5BU5D_tACEBFEDE350025B554CD507C9AE8FFE49359549A*)SZArrayNew(StringU5BU5D_tACEBFEDE350025B554CD507C9AE8FFE49359549A_il2cpp_TypeInfo_var, (uint32_t)L_66);
		V_14 = (StringU5BU5D_tACEBFEDE350025B554CD507C9AE8FFE49359549A*)L_67;
		V_15 = (int32_t)0;
		goto IL_01c3;
	}

IL_019d:
	{
		intptr_t L_68 = ___array0;
		int32_t L_69 = V_15;
		intptr_t L_70;
		L_70 = AndroidJNI_GetObjectArrayElement_m502026BF77232EE45D03661E4923C2E5E99FDE18((intptr_t)L_68, (int32_t)L_69, /*hidden argument*/NULL);
		V_16 = (intptr_t)L_70;
		StringU5BU5D_tACEBFEDE350025B554CD507C9AE8FFE49359549A* L_71 = V_14;
		int32_t L_72 = V_15;
		intptr_t L_73 = V_16;
		String_t* L_74;
		L_74 = AndroidJNISafe_GetStringChars_mD59FFDE4192F837E1380B51569B5803E09BE58C8((intptr_t)L_73, /*hidden argument*/NULL);
		NullCheck(L_71);
		ArrayElementTypeCheck (L_71, L_74);
		(L_71)->SetAt(static_cast<il2cpp_array_size_t>(L_72), (String_t*)L_74);
		intptr_t L_75 = V_16;
		AndroidJNISafe_DeleteLocalRef_m7AB242A76D13A3BF4C04831D77960C020D6ADA39((intptr_t)L_75, /*hidden argument*/NULL);
		int32_t L_76 = V_15;
		V_15 = (int32_t)((int32_t)il2cpp_codegen_add((int32_t)L_76, (int32_t)1));
	}

IL_01c3:
	{
		int32_t L_77 = V_15;
		int32_t L_78 = V_13;
		V_17 = (bool)((((int32_t)L_77) < ((int32_t)L_78))? 1 : 0);
		bool L_79 = V_17;
		if (L_79)
		{
			goto IL_019d;
		}
	}
	{
		StringU5BU5D_tACEBFEDE350025B554CD507C9AE8FFE49359549A* L_80 = V_14;
		V_3 = (RuntimeObject *)((RuntimeObject *)Castclass((RuntimeObject*)L_80, IL2CPP_RGCTX_DATA(method->rgctx_data, 1)));
		goto IL_0272;
	}

IL_01dc:
	{
		Type_t * L_81 = V_0;
		RuntimeTypeHandle_tC33965ADA3E041E0C94AF05E5CB527B56482CEF9  L_82 = { reinterpret_cast<intptr_t> (AndroidJavaObject_t10188D5695DCD09C9F621B44B0A8C93A2281236E_0_0_0_var) };
		IL2CPP_RUNTIME_CLASS_INIT(Type_t_il2cpp_TypeInfo_var);
		Type_t * L_83;
		L_83 = Type_GetTypeFromHandle_m8BB57524FF7F9DB1803BC561D2B3A4DBACEB385E((RuntimeTypeHandle_tC33965ADA3E041E0C94AF05E5CB527B56482CEF9 )L_82, /*hidden argument*/NULL);
		V_18 = (bool)((((RuntimeObject*)(Type_t *)L_81) == ((RuntimeObject*)(Type_t *)L_83))? 1 : 0);
		bool L_84 = V_18;
		if (!L_84)
		{
			goto IL_0242;
		}
	}
	{
		intptr_t L_85 = ___array0;
		int32_t L_86;
		L_86 = AndroidJNISafe_GetArrayLength_m3015C191DBFC246946A88592731441A934507B56((intptr_t)L_85, /*hidden argument*/NULL);
		V_19 = (int32_t)L_86;
		int32_t L_87 = V_19;
		AndroidJavaObjectU5BU5D_tEE28563C9013906CEB39794019A55F4BA5B06120* L_88 = (AndroidJavaObjectU5BU5D_tEE28563C9013906CEB39794019A55F4BA5B06120*)(AndroidJavaObjectU5BU5D_tEE28563C9013906CEB39794019A55F4BA5B06120*)SZArrayNew(AndroidJavaObjectU5BU5D_tEE28563C9013906CEB39794019A55F4BA5B06120_il2cpp_TypeInfo_var, (uint32_t)L_87);
		V_20 = (AndroidJavaObjectU5BU5D_tEE28563C9013906CEB39794019A55F4BA5B06120*)L_88;
		V_21 = (int32_t)0;
		goto IL_022c;
	}

IL_0206:
	{
		intptr_t L_89 = ___array0;
		int32_t L_90 = V_21;
		intptr_t L_91;
		L_91 = AndroidJNI_GetObjectArrayElement_m502026BF77232EE45D03661E4923C2E5E99FDE18((intptr_t)L_89, (int32_t)L_90, /*hidden argument*/NULL);
		V_22 = (intptr_t)L_91;
		AndroidJavaObjectU5BU5D_tEE28563C9013906CEB39794019A55F4BA5B06120* L_92 = V_20;
		int32_t L_93 = V_21;
		intptr_t L_94 = V_22;
		AndroidJavaObject_t10188D5695DCD09C9F621B44B0A8C93A2281236E * L_95 = (AndroidJavaObject_t10188D5695DCD09C9F621B44B0A8C93A2281236E *)il2cpp_codegen_object_new(AndroidJavaObject_t10188D5695DCD09C9F621B44B0A8C93A2281236E_il2cpp_TypeInfo_var);
		AndroidJavaObject__ctor_m880F6533139DF0BD36C6EF428E45E9F44B6534A3(L_95, (intptr_t)L_94, /*hidden argument*/NULL);
		NullCheck(L_92);
		ArrayElementTypeCheck (L_92, L_95);
		(L_92)->SetAt(static_cast<il2cpp_array_size_t>(L_93), (AndroidJavaObject_t10188D5695DCD09C9F621B44B0A8C93A2281236E *)L_95);
		intptr_t L_96 = V_22;
		AndroidJNISafe_DeleteLocalRef_m7AB242A76D13A3BF4C04831D77960C020D6ADA39((intptr_t)L_96, /*hidden argument*/NULL);
		int32_t L_97 = V_21;
		V_21 = (int32_t)((int32_t)il2cpp_codegen_add((int32_t)L_97, (int32_t)1));
	}

IL_022c:
	{
		int32_t L_98 = V_21;
		int32_t L_99 = V_19;
		V_23 = (bool)((((int32_t)L_98) < ((int32_t)L_99))? 1 : 0);
		bool L_100 = V_23;
		if (L_100)
		{
			goto IL_0206;
		}
	}
	{
		AndroidJavaObjectU5BU5D_tEE28563C9013906CEB39794019A55F4BA5B06120* L_101 = V_20;
		V_3 = (RuntimeObject *)((RuntimeObject *)Castclass((RuntimeObject*)L_101, IL2CPP_RGCTX_DATA(method->rgctx_data, 1)));
		goto IL_0272;
	}

IL_0242:
	{
		Type_t * L_102 = V_0;
		Type_t * L_103 = (Type_t *)L_102;
		G_B31_0 = L_103;
		G_B31_1 = ((String_t*)il2cpp_codegen_initialize_runtime_metadata_inline((uintptr_t*)&_stringLiteral51253131B895C2F8066BCC47E62D44F18F43446C));
		if (L_103)
		{
			G_B32_0 = L_103;
			G_B32_1 = ((String_t*)il2cpp_codegen_initialize_runtime_metadata_inline((uintptr_t*)&_stringLiteral51253131B895C2F8066BCC47E62D44F18F43446C));
			goto IL_0250;
		}
	}
	{
		G_B33_0 = ((String_t*)(NULL));
		G_B33_1 = G_B31_1;
		goto IL_0255;
	}

IL_0250:
	{
		NullCheck((RuntimeObject *)G_B32_0);
		String_t* L_104;
		L_104 = VirtFuncInvoker0< String_t* >::Invoke(3 /* System.String System.Object::ToString() */, (RuntimeObject *)G_B32_0);
		G_B33_0 = L_104;
		G_B33_1 = G_B32_1;
	}

IL_0255:
	{
		String_t* L_105;
		L_105 = String_Concat_m89EAB4C6A96B0E5C3F87300D6BE78D386B9EFC44((String_t*)G_B33_1, (String_t*)G_B33_0, (String_t*)((String_t*)il2cpp_codegen_initialize_runtime_metadata_inline((uintptr_t*)&_stringLiteral42646B33B50B6AA15E22733C8900716F0FE19E1D)), /*hidden argument*/NULL);
		Exception_t * L_106 = (Exception_t *)il2cpp_codegen_object_new(((RuntimeClass*)il2cpp_codegen_initialize_runtime_metadata_inline((uintptr_t*)&Exception_t_il2cpp_TypeInfo_var)));
		Exception__ctor_m8ECDE8ACA7F2E0EF1144BD1200FB5DB2870B5F11(L_106, (String_t*)L_105, /*hidden argument*/NULL);
		IL2CPP_RAISE_MANAGED_EXCEPTION(L_106, ((RuntimeMethod*)il2cpp_codegen_initialize_runtime_metadata_inline((uintptr_t*)&_AndroidJNIHelper_ConvertFromJNIArray_TisRuntimeObject_m353E485413995A0C209B6FAA96D368CF72FB4592_RuntimeMethod_var)));
	}

IL_0265:
	{
		il2cpp_codegen_initobj((&V_24), sizeof(RuntimeObject *));
		RuntimeObject * L_107 = V_24;
		V_3 = (RuntimeObject *)L_107;
		goto IL_0272;
	}

IL_0272:
	{
		RuntimeObject * L_108 = V_3;
		return (RuntimeObject *)L_108;
	}
}
// ArrayType UnityEngine._AndroidJNIHelper::ConvertFromJNIArray<System.SByte>(System.IntPtr)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR int8_t _AndroidJNIHelper_ConvertFromJNIArray_TisSByte_t928712DD662DC29BA4FAAE8CE2230AFB23447F0B_m2F4CBB579C50AAAF7EF6FBC73C5FC304A87A60EE_gshared (intptr_t ___array0, const RuntimeMethod* method)
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&AndroidJavaObjectU5BU5D_tEE28563C9013906CEB39794019A55F4BA5B06120_il2cpp_TypeInfo_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&AndroidJavaObject_t10188D5695DCD09C9F621B44B0A8C93A2281236E_0_0_0_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&AndroidJavaObject_t10188D5695DCD09C9F621B44B0A8C93A2281236E_il2cpp_TypeInfo_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&AndroidReflection_tEB6633FD5B7D2816E1AC6C711E11B2DD33822F16_il2cpp_TypeInfo_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Boolean_t07D1E3F34E4813023D64F584DFF7B34C9D922F37_0_0_0_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Byte_t0111FAB8B8685667EDDAF77683F0D8F86B659056_0_0_0_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Char_tFF60D8E7E89A20BE2294A003734341BD1DF43E14_0_0_0_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Debug_tEB68BCBEB8EFD60F8043C67146DC05E7F50F374B_il2cpp_TypeInfo_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Double_t42821932CB52DE2057E685D0E1AF3DE5033D2181_0_0_0_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Int16_tD0F031114106263BB459DA1F099FF9F42691295A_0_0_0_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Int32_tFDE5F8CD43D10453F6A2E0C77FE48C6CC7009046_0_0_0_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Int64_t378EE0D608BD3107E77238E85F30D2BBD46981F3_0_0_0_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&SByte_t928712DD662DC29BA4FAAE8CE2230AFB23447F0B_0_0_0_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Single_tE07797BA3C98D4CA9B5A19413C19A76688AB899E_0_0_0_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&StringU5BU5D_tACEBFEDE350025B554CD507C9AE8FFE49359549A_il2cpp_TypeInfo_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&String_t_0_0_0_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Type_t_il2cpp_TypeInfo_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&_stringLiteral24CC8D396132365E532646F936DFC8579E2299B2);
		s_Il2CppMethodInitialized = true;
	}
	Type_t * V_0 = NULL;
	bool V_1 = false;
	bool V_2 = false;
	int8_t V_3 = 0x0;
	bool V_4 = false;
	bool V_5 = false;
	bool V_6 = false;
	bool V_7 = false;
	bool V_8 = false;
	bool V_9 = false;
	bool V_10 = false;
	bool V_11 = false;
	bool V_12 = false;
	int32_t V_13 = 0;
	StringU5BU5D_tACEBFEDE350025B554CD507C9AE8FFE49359549A* V_14 = NULL;
	int32_t V_15 = 0;
	intptr_t V_16;
	memset((&V_16), 0, sizeof(V_16));
	bool V_17 = false;
	bool V_18 = false;
	int32_t V_19 = 0;
	AndroidJavaObjectU5BU5D_tEE28563C9013906CEB39794019A55F4BA5B06120* V_20 = NULL;
	int32_t V_21 = 0;
	intptr_t V_22;
	memset((&V_22), 0, sizeof(V_22));
	bool V_23 = false;
	int8_t V_24 = 0x0;
	Type_t * G_B32_0 = NULL;
	String_t* G_B32_1 = NULL;
	Type_t * G_B31_0 = NULL;
	String_t* G_B31_1 = NULL;
	String_t* G_B33_0 = NULL;
	String_t* G_B33_1 = NULL;
	{
		RuntimeTypeHandle_tC33965ADA3E041E0C94AF05E5CB527B56482CEF9  L_0 = { reinterpret_cast<intptr_t> (IL2CPP_RGCTX_TYPE(method->rgctx_data, 0)) };
		IL2CPP_RUNTIME_CLASS_INIT(Type_t_il2cpp_TypeInfo_var);
		Type_t * L_1;
		L_1 = Type_GetTypeFromHandle_m8BB57524FF7F9DB1803BC561D2B3A4DBACEB385E((RuntimeTypeHandle_tC33965ADA3E041E0C94AF05E5CB527B56482CEF9 )L_0, /*hidden argument*/NULL);
		NullCheck((Type_t *)L_1);
		Type_t * L_2;
		L_2 = VirtFuncInvoker0< Type_t * >::Invoke(220 /* System.Type System.Type::GetElementType() */, (Type_t *)L_1);
		V_0 = (Type_t *)L_2;
		Type_t * L_3 = V_0;
		IL2CPP_RUNTIME_CLASS_INIT(AndroidReflection_tEB6633FD5B7D2816E1AC6C711E11B2DD33822F16_il2cpp_TypeInfo_var);
		bool L_4;
		L_4 = AndroidReflection_IsPrimitive_mDD6A4050793DF2FA1EDF58010982C64A3F17376D((Type_t *)L_3, /*hidden argument*/NULL);
		V_1 = (bool)L_4;
		bool L_5 = V_1;
		if (!L_5)
		{
			goto IL_0173;
		}
	}
	{
		Type_t * L_6 = V_0;
		RuntimeTypeHandle_tC33965ADA3E041E0C94AF05E5CB527B56482CEF9  L_7 = { reinterpret_cast<intptr_t> (Int32_tFDE5F8CD43D10453F6A2E0C77FE48C6CC7009046_0_0_0_var) };
		IL2CPP_RUNTIME_CLASS_INIT(Type_t_il2cpp_TypeInfo_var);
		Type_t * L_8;
		L_8 = Type_GetTypeFromHandle_m8BB57524FF7F9DB1803BC561D2B3A4DBACEB385E((RuntimeTypeHandle_tC33965ADA3E041E0C94AF05E5CB527B56482CEF9 )L_7, /*hidden argument*/NULL);
		V_2 = (bool)((((RuntimeObject*)(Type_t *)L_6) == ((RuntimeObject*)(Type_t *)L_8))? 1 : 0);
		bool L_9 = V_2;
		if (!L_9)
		{
			goto IL_0041;
		}
	}
	{
		intptr_t L_10 = ___array0;
		Int32U5BU5D_t70F1BDC14B1786481B176D6139A5E3B87DC54C32* L_11;
		L_11 = AndroidJNISafe_FromIntArray_mBF0C0B4309BA525BBA12D7FD3C2790C8FA7C4703((intptr_t)L_10, /*hidden argument*/NULL);
		V_3 = (int8_t)((*(int8_t*)((int8_t*)UnBox((RuntimeObject *)L_11, IL2CPP_RGCTX_DATA(method->rgctx_data, 1)))));
		goto IL_0272;
	}

IL_0041:
	{
		Type_t * L_12 = V_0;
		RuntimeTypeHandle_tC33965ADA3E041E0C94AF05E5CB527B56482CEF9  L_13 = { reinterpret_cast<intptr_t> (Boolean_t07D1E3F34E4813023D64F584DFF7B34C9D922F37_0_0_0_var) };
		IL2CPP_RUNTIME_CLASS_INIT(Type_t_il2cpp_TypeInfo_var);
		Type_t * L_14;
		L_14 = Type_GetTypeFromHandle_m8BB57524FF7F9DB1803BC561D2B3A4DBACEB385E((RuntimeTypeHandle_tC33965ADA3E041E0C94AF05E5CB527B56482CEF9 )L_13, /*hidden argument*/NULL);
		V_4 = (bool)((((RuntimeObject*)(Type_t *)L_12) == ((RuntimeObject*)(Type_t *)L_14))? 1 : 0);
		bool L_15 = V_4;
		if (!L_15)
		{
			goto IL_0065;
		}
	}
	{
		intptr_t L_16 = ___array0;
		BooleanU5BU5D_tEC7BAF93C44F875016DAADC8696EE3A465644D3C* L_17;
		L_17 = AndroidJNISafe_FromBooleanArray_m77A66C34FCB94ADB1AD5E1D88262500C930A5DBF((intptr_t)L_16, /*hidden argument*/NULL);
		V_3 = (int8_t)((*(int8_t*)((int8_t*)UnBox((RuntimeObject *)L_17, IL2CPP_RGCTX_DATA(method->rgctx_data, 1)))));
		goto IL_0272;
	}

IL_0065:
	{
		Type_t * L_18 = V_0;
		RuntimeTypeHandle_tC33965ADA3E041E0C94AF05E5CB527B56482CEF9  L_19 = { reinterpret_cast<intptr_t> (Byte_t0111FAB8B8685667EDDAF77683F0D8F86B659056_0_0_0_var) };
		IL2CPP_RUNTIME_CLASS_INIT(Type_t_il2cpp_TypeInfo_var);
		Type_t * L_20;
		L_20 = Type_GetTypeFromHandle_m8BB57524FF7F9DB1803BC561D2B3A4DBACEB385E((RuntimeTypeHandle_tC33965ADA3E041E0C94AF05E5CB527B56482CEF9 )L_19, /*hidden argument*/NULL);
		V_5 = (bool)((((RuntimeObject*)(Type_t *)L_18) == ((RuntimeObject*)(Type_t *)L_20))? 1 : 0);
		bool L_21 = V_5;
		if (!L_21)
		{
			goto IL_0095;
		}
	}
	{
		IL2CPP_RUNTIME_CLASS_INIT(Debug_tEB68BCBEB8EFD60F8043C67146DC05E7F50F374B_il2cpp_TypeInfo_var);
		Debug_LogWarning_m24085D883C9E74D7AB423F0625E13259923960E7((RuntimeObject *)_stringLiteral24CC8D396132365E532646F936DFC8579E2299B2, /*hidden argument*/NULL);
		intptr_t L_22 = ___array0;
		ByteU5BU5D_tDBBEB0E8362242FA7223000D978B0DD19D4B0726* L_23;
		L_23 = AndroidJNISafe_FromByteArray_m81760A688AECE368E1CFF7DAAC8E141F1B8FA8A8((intptr_t)L_22, /*hidden argument*/NULL);
		V_3 = (int8_t)((*(int8_t*)((int8_t*)UnBox((RuntimeObject *)L_23, IL2CPP_RGCTX_DATA(method->rgctx_data, 1)))));
		goto IL_0272;
	}

IL_0095:
	{
		Type_t * L_24 = V_0;
		RuntimeTypeHandle_tC33965ADA3E041E0C94AF05E5CB527B56482CEF9  L_25 = { reinterpret_cast<intptr_t> (SByte_t928712DD662DC29BA4FAAE8CE2230AFB23447F0B_0_0_0_var) };
		IL2CPP_RUNTIME_CLASS_INIT(Type_t_il2cpp_TypeInfo_var);
		Type_t * L_26;
		L_26 = Type_GetTypeFromHandle_m8BB57524FF7F9DB1803BC561D2B3A4DBACEB385E((RuntimeTypeHandle_tC33965ADA3E041E0C94AF05E5CB527B56482CEF9 )L_25, /*hidden argument*/NULL);
		V_6 = (bool)((((RuntimeObject*)(Type_t *)L_24) == ((RuntimeObject*)(Type_t *)L_26))? 1 : 0);
		bool L_27 = V_6;
		if (!L_27)
		{
			goto IL_00b9;
		}
	}
	{
		intptr_t L_28 = ___array0;
		SByteU5BU5D_t7D94C53295E6116625EA7CC7DEA21FEDC39869E7* L_29;
		L_29 = AndroidJNISafe_FromSByteArray_m01F6539AF10F86B3927436955B57CC809C52416D((intptr_t)L_28, /*hidden argument*/NULL);
		V_3 = (int8_t)((*(int8_t*)((int8_t*)UnBox((RuntimeObject *)L_29, IL2CPP_RGCTX_DATA(method->rgctx_data, 1)))));
		goto IL_0272;
	}

IL_00b9:
	{
		Type_t * L_30 = V_0;
		RuntimeTypeHandle_tC33965ADA3E041E0C94AF05E5CB527B56482CEF9  L_31 = { reinterpret_cast<intptr_t> (Int16_tD0F031114106263BB459DA1F099FF9F42691295A_0_0_0_var) };
		IL2CPP_RUNTIME_CLASS_INIT(Type_t_il2cpp_TypeInfo_var);
		Type_t * L_32;
		L_32 = Type_GetTypeFromHandle_m8BB57524FF7F9DB1803BC561D2B3A4DBACEB385E((RuntimeTypeHandle_tC33965ADA3E041E0C94AF05E5CB527B56482CEF9 )L_31, /*hidden argument*/NULL);
		V_7 = (bool)((((RuntimeObject*)(Type_t *)L_30) == ((RuntimeObject*)(Type_t *)L_32))? 1 : 0);
		bool L_33 = V_7;
		if (!L_33)
		{
			goto IL_00dd;
		}
	}
	{
		intptr_t L_34 = ___array0;
		Int16U5BU5D_tD134F1E6F746D4C09C987436805256C210C2FFCD* L_35;
		L_35 = AndroidJNISafe_FromShortArray_mCDF5B796D950D31035BD35A2E463D41509E4A5CD((intptr_t)L_34, /*hidden argument*/NULL);
		V_3 = (int8_t)((*(int8_t*)((int8_t*)UnBox((RuntimeObject *)L_35, IL2CPP_RGCTX_DATA(method->rgctx_data, 1)))));
		goto IL_0272;
	}

IL_00dd:
	{
		Type_t * L_36 = V_0;
		RuntimeTypeHandle_tC33965ADA3E041E0C94AF05E5CB527B56482CEF9  L_37 = { reinterpret_cast<intptr_t> (Int64_t378EE0D608BD3107E77238E85F30D2BBD46981F3_0_0_0_var) };
		IL2CPP_RUNTIME_CLASS_INIT(Type_t_il2cpp_TypeInfo_var);
		Type_t * L_38;
		L_38 = Type_GetTypeFromHandle_m8BB57524FF7F9DB1803BC561D2B3A4DBACEB385E((RuntimeTypeHandle_tC33965ADA3E041E0C94AF05E5CB527B56482CEF9 )L_37, /*hidden argument*/NULL);
		V_8 = (bool)((((RuntimeObject*)(Type_t *)L_36) == ((RuntimeObject*)(Type_t *)L_38))? 1 : 0);
		bool L_39 = V_8;
		if (!L_39)
		{
			goto IL_0101;
		}
	}
	{
		intptr_t L_40 = ___array0;
		Int64U5BU5D_tCA61E42872C63A4286B24EEE6E0650143B43DCE6* L_41;
		L_41 = AndroidJNISafe_FromLongArray_m0E7C56CB8CFD0EC240F0D86ECBBFD635FFE55CDA((intptr_t)L_40, /*hidden argument*/NULL);
		V_3 = (int8_t)((*(int8_t*)((int8_t*)UnBox((RuntimeObject *)L_41, IL2CPP_RGCTX_DATA(method->rgctx_data, 1)))));
		goto IL_0272;
	}

IL_0101:
	{
		Type_t * L_42 = V_0;
		RuntimeTypeHandle_tC33965ADA3E041E0C94AF05E5CB527B56482CEF9  L_43 = { reinterpret_cast<intptr_t> (Single_tE07797BA3C98D4CA9B5A19413C19A76688AB899E_0_0_0_var) };
		IL2CPP_RUNTIME_CLASS_INIT(Type_t_il2cpp_TypeInfo_var);
		Type_t * L_44;
		L_44 = Type_GetTypeFromHandle_m8BB57524FF7F9DB1803BC561D2B3A4DBACEB385E((RuntimeTypeHandle_tC33965ADA3E041E0C94AF05E5CB527B56482CEF9 )L_43, /*hidden argument*/NULL);
		V_9 = (bool)((((RuntimeObject*)(Type_t *)L_42) == ((RuntimeObject*)(Type_t *)L_44))? 1 : 0);
		bool L_45 = V_9;
		if (!L_45)
		{
			goto IL_0125;
		}
	}
	{
		intptr_t L_46 = ___array0;
		SingleU5BU5D_t47E8DBF5B597C122478D1FFBD9DD57399A0650FA* L_47;
		L_47 = AndroidJNISafe_FromFloatArray_mF6A63CA1B7C10BC27EEC033F0E390772DFDD652D((intptr_t)L_46, /*hidden argument*/NULL);
		V_3 = (int8_t)((*(int8_t*)((int8_t*)UnBox((RuntimeObject *)L_47, IL2CPP_RGCTX_DATA(method->rgctx_data, 1)))));
		goto IL_0272;
	}

IL_0125:
	{
		Type_t * L_48 = V_0;
		RuntimeTypeHandle_tC33965ADA3E041E0C94AF05E5CB527B56482CEF9  L_49 = { reinterpret_cast<intptr_t> (Double_t42821932CB52DE2057E685D0E1AF3DE5033D2181_0_0_0_var) };
		IL2CPP_RUNTIME_CLASS_INIT(Type_t_il2cpp_TypeInfo_var);
		Type_t * L_50;
		L_50 = Type_GetTypeFromHandle_m8BB57524FF7F9DB1803BC561D2B3A4DBACEB385E((RuntimeTypeHandle_tC33965ADA3E041E0C94AF05E5CB527B56482CEF9 )L_49, /*hidden argument*/NULL);
		V_10 = (bool)((((RuntimeObject*)(Type_t *)L_48) == ((RuntimeObject*)(Type_t *)L_50))? 1 : 0);
		bool L_51 = V_10;
		if (!L_51)
		{
			goto IL_0149;
		}
	}
	{
		intptr_t L_52 = ___array0;
		DoubleU5BU5D_t8E1B42EB2ABB79FBD193A6B8C8D97A7CDE44A4FB* L_53;
		L_53 = AndroidJNISafe_FromDoubleArray_m9438B5668E8B2DB3B18CACFF0CC9CAEAB5EC73C8((intptr_t)L_52, /*hidden argument*/NULL);
		V_3 = (int8_t)((*(int8_t*)((int8_t*)UnBox((RuntimeObject *)L_53, IL2CPP_RGCTX_DATA(method->rgctx_data, 1)))));
		goto IL_0272;
	}

IL_0149:
	{
		Type_t * L_54 = V_0;
		RuntimeTypeHandle_tC33965ADA3E041E0C94AF05E5CB527B56482CEF9  L_55 = { reinterpret_cast<intptr_t> (Char_tFF60D8E7E89A20BE2294A003734341BD1DF43E14_0_0_0_var) };
		IL2CPP_RUNTIME_CLASS_INIT(Type_t_il2cpp_TypeInfo_var);
		Type_t * L_56;
		L_56 = Type_GetTypeFromHandle_m8BB57524FF7F9DB1803BC561D2B3A4DBACEB385E((RuntimeTypeHandle_tC33965ADA3E041E0C94AF05E5CB527B56482CEF9 )L_55, /*hidden argument*/NULL);
		V_11 = (bool)((((RuntimeObject*)(Type_t *)L_54) == ((RuntimeObject*)(Type_t *)L_56))? 1 : 0);
		bool L_57 = V_11;
		if (!L_57)
		{
			goto IL_016d;
		}
	}
	{
		intptr_t L_58 = ___array0;
		CharU5BU5D_t7B7FC5BC8091AA3B9CB0B29CDD80B5EE9254AA34* L_59;
		L_59 = AndroidJNISafe_FromCharArray_mA49DB27755EF3B2AE81487E0FCFE06E23F617305((intptr_t)L_58, /*hidden argument*/NULL);
		V_3 = (int8_t)((*(int8_t*)((int8_t*)UnBox((RuntimeObject *)L_59, IL2CPP_RGCTX_DATA(method->rgctx_data, 1)))));
		goto IL_0272;
	}

IL_016d:
	{
		goto IL_0265;
	}

IL_0173:
	{
		Type_t * L_60 = V_0;
		RuntimeTypeHandle_tC33965ADA3E041E0C94AF05E5CB527B56482CEF9  L_61 = { reinterpret_cast<intptr_t> (String_t_0_0_0_var) };
		IL2CPP_RUNTIME_CLASS_INIT(Type_t_il2cpp_TypeInfo_var);
		Type_t * L_62;
		L_62 = Type_GetTypeFromHandle_m8BB57524FF7F9DB1803BC561D2B3A4DBACEB385E((RuntimeTypeHandle_tC33965ADA3E041E0C94AF05E5CB527B56482CEF9 )L_61, /*hidden argument*/NULL);
		V_12 = (bool)((((RuntimeObject*)(Type_t *)L_60) == ((RuntimeObject*)(Type_t *)L_62))? 1 : 0);
		bool L_63 = V_12;
		if (!L_63)
		{
			goto IL_01dc;
		}
	}
	{
		intptr_t L_64 = ___array0;
		int32_t L_65;
		L_65 = AndroidJNISafe_GetArrayLength_m3015C191DBFC246946A88592731441A934507B56((intptr_t)L_64, /*hidden argument*/NULL);
		V_13 = (int32_t)L_65;
		int32_t L_66 = V_13;
		StringU5BU5D_tACEBFEDE350025B554CD507C9AE8FFE49359549A* L_67 = (StringU5BU5D_tACEBFEDE350025B554CD507C9AE8FFE49359549A*)(StringU5BU5D_tACEBFEDE350025B554CD507C9AE8FFE49359549A*)SZArrayNew(StringU5BU5D_tACEBFEDE350025B554CD507C9AE8FFE49359549A_il2cpp_TypeInfo_var, (uint32_t)L_66);
		V_14 = (StringU5BU5D_tACEBFEDE350025B554CD507C9AE8FFE49359549A*)L_67;
		V_15 = (int32_t)0;
		goto IL_01c3;
	}

IL_019d:
	{
		intptr_t L_68 = ___array0;
		int32_t L_69 = V_15;
		intptr_t L_70;
		L_70 = AndroidJNI_GetObjectArrayElement_m502026BF77232EE45D03661E4923C2E5E99FDE18((intptr_t)L_68, (int32_t)L_69, /*hidden argument*/NULL);
		V_16 = (intptr_t)L_70;
		StringU5BU5D_tACEBFEDE350025B554CD507C9AE8FFE49359549A* L_71 = V_14;
		int32_t L_72 = V_15;
		intptr_t L_73 = V_16;
		String_t* L_74;
		L_74 = AndroidJNISafe_GetStringChars_mD59FFDE4192F837E1380B51569B5803E09BE58C8((intptr_t)L_73, /*hidden argument*/NULL);
		NullCheck(L_71);
		ArrayElementTypeCheck (L_71, L_74);
		(L_71)->SetAt(static_cast<il2cpp_array_size_t>(L_72), (String_t*)L_74);
		intptr_t L_75 = V_16;
		AndroidJNISafe_DeleteLocalRef_m7AB242A76D13A3BF4C04831D77960C020D6ADA39((intptr_t)L_75, /*hidden argument*/NULL);
		int32_t L_76 = V_15;
		V_15 = (int32_t)((int32_t)il2cpp_codegen_add((int32_t)L_76, (int32_t)1));
	}

IL_01c3:
	{
		int32_t L_77 = V_15;
		int32_t L_78 = V_13;
		V_17 = (bool)((((int32_t)L_77) < ((int32_t)L_78))? 1 : 0);
		bool L_79 = V_17;
		if (L_79)
		{
			goto IL_019d;
		}
	}
	{
		StringU5BU5D_tACEBFEDE350025B554CD507C9AE8FFE49359549A* L_80 = V_14;
		V_3 = (int8_t)((*(int8_t*)((int8_t*)UnBox((RuntimeObject *)L_80, IL2CPP_RGCTX_DATA(method->rgctx_data, 1)))));
		goto IL_0272;
	}

IL_01dc:
	{
		Type_t * L_81 = V_0;
		RuntimeTypeHandle_tC33965ADA3E041E0C94AF05E5CB527B56482CEF9  L_82 = { reinterpret_cast<intptr_t> (AndroidJavaObject_t10188D5695DCD09C9F621B44B0A8C93A2281236E_0_0_0_var) };
		IL2CPP_RUNTIME_CLASS_INIT(Type_t_il2cpp_TypeInfo_var);
		Type_t * L_83;
		L_83 = Type_GetTypeFromHandle_m8BB57524FF7F9DB1803BC561D2B3A4DBACEB385E((RuntimeTypeHandle_tC33965ADA3E041E0C94AF05E5CB527B56482CEF9 )L_82, /*hidden argument*/NULL);
		V_18 = (bool)((((RuntimeObject*)(Type_t *)L_81) == ((RuntimeObject*)(Type_t *)L_83))? 1 : 0);
		bool L_84 = V_18;
		if (!L_84)
		{
			goto IL_0242;
		}
	}
	{
		intptr_t L_85 = ___array0;
		int32_t L_86;
		L_86 = AndroidJNISafe_GetArrayLength_m3015C191DBFC246946A88592731441A934507B56((intptr_t)L_85, /*hidden argument*/NULL);
		V_19 = (int32_t)L_86;
		int32_t L_87 = V_19;
		AndroidJavaObjectU5BU5D_tEE28563C9013906CEB39794019A55F4BA5B06120* L_88 = (AndroidJavaObjectU5BU5D_tEE28563C9013906CEB39794019A55F4BA5B06120*)(AndroidJavaObjectU5BU5D_tEE28563C9013906CEB39794019A55F4BA5B06120*)SZArrayNew(AndroidJavaObjectU5BU5D_tEE28563C9013906CEB39794019A55F4BA5B06120_il2cpp_TypeInfo_var, (uint32_t)L_87);
		V_20 = (AndroidJavaObjectU5BU5D_tEE28563C9013906CEB39794019A55F4BA5B06120*)L_88;
		V_21 = (int32_t)0;
		goto IL_022c;
	}

IL_0206:
	{
		intptr_t L_89 = ___array0;
		int32_t L_90 = V_21;
		intptr_t L_91;
		L_91 = AndroidJNI_GetObjectArrayElement_m502026BF77232EE45D03661E4923C2E5E99FDE18((intptr_t)L_89, (int32_t)L_90, /*hidden argument*/NULL);
		V_22 = (intptr_t)L_91;
		AndroidJavaObjectU5BU5D_tEE28563C9013906CEB39794019A55F4BA5B06120* L_92 = V_20;
		int32_t L_93 = V_21;
		intptr_t L_94 = V_22;
		AndroidJavaObject_t10188D5695DCD09C9F621B44B0A8C93A2281236E * L_95 = (AndroidJavaObject_t10188D5695DCD09C9F621B44B0A8C93A2281236E *)il2cpp_codegen_object_new(AndroidJavaObject_t10188D5695DCD09C9F621B44B0A8C93A2281236E_il2cpp_TypeInfo_var);
		AndroidJavaObject__ctor_m880F6533139DF0BD36C6EF428E45E9F44B6534A3(L_95, (intptr_t)L_94, /*hidden argument*/NULL);
		NullCheck(L_92);
		ArrayElementTypeCheck (L_92, L_95);
		(L_92)->SetAt(static_cast<il2cpp_array_size_t>(L_93), (AndroidJavaObject_t10188D5695DCD09C9F621B44B0A8C93A2281236E *)L_95);
		intptr_t L_96 = V_22;
		AndroidJNISafe_DeleteLocalRef_m7AB242A76D13A3BF4C04831D77960C020D6ADA39((intptr_t)L_96, /*hidden argument*/NULL);
		int32_t L_97 = V_21;
		V_21 = (int32_t)((int32_t)il2cpp_codegen_add((int32_t)L_97, (int32_t)1));
	}

IL_022c:
	{
		int32_t L_98 = V_21;
		int32_t L_99 = V_19;
		V_23 = (bool)((((int32_t)L_98) < ((int32_t)L_99))? 1 : 0);
		bool L_100 = V_23;
		if (L_100)
		{
			goto IL_0206;
		}
	}
	{
		AndroidJavaObjectU5BU5D_tEE28563C9013906CEB39794019A55F4BA5B06120* L_101 = V_20;
		V_3 = (int8_t)((*(int8_t*)((int8_t*)UnBox((RuntimeObject *)L_101, IL2CPP_RGCTX_DATA(method->rgctx_data, 1)))));
		goto IL_0272;
	}

IL_0242:
	{
		Type_t * L_102 = V_0;
		Type_t * L_103 = (Type_t *)L_102;
		G_B31_0 = L_103;
		G_B31_1 = ((String_t*)il2cpp_codegen_initialize_runtime_metadata_inline((uintptr_t*)&_stringLiteral51253131B895C2F8066BCC47E62D44F18F43446C));
		if (L_103)
		{
			G_B32_0 = L_103;
			G_B32_1 = ((String_t*)il2cpp_codegen_initialize_runtime_metadata_inline((uintptr_t*)&_stringLiteral51253131B895C2F8066BCC47E62D44F18F43446C));
			goto IL_0250;
		}
	}
	{
		G_B33_0 = ((String_t*)(NULL));
		G_B33_1 = G_B31_1;
		goto IL_0255;
	}

IL_0250:
	{
		NullCheck((RuntimeObject *)G_B32_0);
		String_t* L_104;
		L_104 = VirtFuncInvoker0< String_t* >::Invoke(3 /* System.String System.Object::ToString() */, (RuntimeObject *)G_B32_0);
		G_B33_0 = L_104;
		G_B33_1 = G_B32_1;
	}

IL_0255:
	{
		String_t* L_105;
		L_105 = String_Concat_m89EAB4C6A96B0E5C3F87300D6BE78D386B9EFC44((String_t*)G_B33_1, (String_t*)G_B33_0, (String_t*)((String_t*)il2cpp_codegen_initialize_runtime_metadata_inline((uintptr_t*)&_stringLiteral42646B33B50B6AA15E22733C8900716F0FE19E1D)), /*hidden argument*/NULL);
		Exception_t * L_106 = (Exception_t *)il2cpp_codegen_object_new(((RuntimeClass*)il2cpp_codegen_initialize_runtime_metadata_inline((uintptr_t*)&Exception_t_il2cpp_TypeInfo_var)));
		Exception__ctor_m8ECDE8ACA7F2E0EF1144BD1200FB5DB2870B5F11(L_106, (String_t*)L_105, /*hidden argument*/NULL);
		IL2CPP_RAISE_MANAGED_EXCEPTION(L_106, ((RuntimeMethod*)il2cpp_codegen_initialize_runtime_metadata_inline((uintptr_t*)&_AndroidJNIHelper_ConvertFromJNIArray_TisSByte_t928712DD662DC29BA4FAAE8CE2230AFB23447F0B_m2F4CBB579C50AAAF7EF6FBC73C5FC304A87A60EE_RuntimeMethod_var)));
	}

IL_0265:
	{
		il2cpp_codegen_initobj((&V_24), sizeof(int8_t));
		int8_t L_107 = V_24;
		V_3 = (int8_t)L_107;
		goto IL_0272;
	}

IL_0272:
	{
		int8_t L_108 = V_3;
		return (int8_t)L_108;
	}
}
// ArrayType UnityEngine._AndroidJNIHelper::ConvertFromJNIArray<System.Single>(System.IntPtr)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR float _AndroidJNIHelper_ConvertFromJNIArray_TisSingle_tE07797BA3C98D4CA9B5A19413C19A76688AB899E_mD3EDB3217478F469F150970E33043F80EF1BA3CB_gshared (intptr_t ___array0, const RuntimeMethod* method)
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&AndroidJavaObjectU5BU5D_tEE28563C9013906CEB39794019A55F4BA5B06120_il2cpp_TypeInfo_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&AndroidJavaObject_t10188D5695DCD09C9F621B44B0A8C93A2281236E_0_0_0_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&AndroidJavaObject_t10188D5695DCD09C9F621B44B0A8C93A2281236E_il2cpp_TypeInfo_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&AndroidReflection_tEB6633FD5B7D2816E1AC6C711E11B2DD33822F16_il2cpp_TypeInfo_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Boolean_t07D1E3F34E4813023D64F584DFF7B34C9D922F37_0_0_0_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Byte_t0111FAB8B8685667EDDAF77683F0D8F86B659056_0_0_0_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Char_tFF60D8E7E89A20BE2294A003734341BD1DF43E14_0_0_0_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Debug_tEB68BCBEB8EFD60F8043C67146DC05E7F50F374B_il2cpp_TypeInfo_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Double_t42821932CB52DE2057E685D0E1AF3DE5033D2181_0_0_0_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Int16_tD0F031114106263BB459DA1F099FF9F42691295A_0_0_0_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Int32_tFDE5F8CD43D10453F6A2E0C77FE48C6CC7009046_0_0_0_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Int64_t378EE0D608BD3107E77238E85F30D2BBD46981F3_0_0_0_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&SByte_t928712DD662DC29BA4FAAE8CE2230AFB23447F0B_0_0_0_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Single_tE07797BA3C98D4CA9B5A19413C19A76688AB899E_0_0_0_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&StringU5BU5D_tACEBFEDE350025B554CD507C9AE8FFE49359549A_il2cpp_TypeInfo_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&String_t_0_0_0_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Type_t_il2cpp_TypeInfo_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&_stringLiteral24CC8D396132365E532646F936DFC8579E2299B2);
		s_Il2CppMethodInitialized = true;
	}
	Type_t * V_0 = NULL;
	bool V_1 = false;
	bool V_2 = false;
	float V_3 = 0.0f;
	bool V_4 = false;
	bool V_5 = false;
	bool V_6 = false;
	bool V_7 = false;
	bool V_8 = false;
	bool V_9 = false;
	bool V_10 = false;
	bool V_11 = false;
	bool V_12 = false;
	int32_t V_13 = 0;
	StringU5BU5D_tACEBFEDE350025B554CD507C9AE8FFE49359549A* V_14 = NULL;
	int32_t V_15 = 0;
	intptr_t V_16;
	memset((&V_16), 0, sizeof(V_16));
	bool V_17 = false;
	bool V_18 = false;
	int32_t V_19 = 0;
	AndroidJavaObjectU5BU5D_tEE28563C9013906CEB39794019A55F4BA5B06120* V_20 = NULL;
	int32_t V_21 = 0;
	intptr_t V_22;
	memset((&V_22), 0, sizeof(V_22));
	bool V_23 = false;
	float V_24 = 0.0f;
	Type_t * G_B32_0 = NULL;
	String_t* G_B32_1 = NULL;
	Type_t * G_B31_0 = NULL;
	String_t* G_B31_1 = NULL;
	String_t* G_B33_0 = NULL;
	String_t* G_B33_1 = NULL;
	{
		RuntimeTypeHandle_tC33965ADA3E041E0C94AF05E5CB527B56482CEF9  L_0 = { reinterpret_cast<intptr_t> (IL2CPP_RGCTX_TYPE(method->rgctx_data, 0)) };
		IL2CPP_RUNTIME_CLASS_INIT(Type_t_il2cpp_TypeInfo_var);
		Type_t * L_1;
		L_1 = Type_GetTypeFromHandle_m8BB57524FF7F9DB1803BC561D2B3A4DBACEB385E((RuntimeTypeHandle_tC33965ADA3E041E0C94AF05E5CB527B56482CEF9 )L_0, /*hidden argument*/NULL);
		NullCheck((Type_t *)L_1);
		Type_t * L_2;
		L_2 = VirtFuncInvoker0< Type_t * >::Invoke(220 /* System.Type System.Type::GetElementType() */, (Type_t *)L_1);
		V_0 = (Type_t *)L_2;
		Type_t * L_3 = V_0;
		IL2CPP_RUNTIME_CLASS_INIT(AndroidReflection_tEB6633FD5B7D2816E1AC6C711E11B2DD33822F16_il2cpp_TypeInfo_var);
		bool L_4;
		L_4 = AndroidReflection_IsPrimitive_mDD6A4050793DF2FA1EDF58010982C64A3F17376D((Type_t *)L_3, /*hidden argument*/NULL);
		V_1 = (bool)L_4;
		bool L_5 = V_1;
		if (!L_5)
		{
			goto IL_0173;
		}
	}
	{
		Type_t * L_6 = V_0;
		RuntimeTypeHandle_tC33965ADA3E041E0C94AF05E5CB527B56482CEF9  L_7 = { reinterpret_cast<intptr_t> (Int32_tFDE5F8CD43D10453F6A2E0C77FE48C6CC7009046_0_0_0_var) };
		IL2CPP_RUNTIME_CLASS_INIT(Type_t_il2cpp_TypeInfo_var);
		Type_t * L_8;
		L_8 = Type_GetTypeFromHandle_m8BB57524FF7F9DB1803BC561D2B3A4DBACEB385E((RuntimeTypeHandle_tC33965ADA3E041E0C94AF05E5CB527B56482CEF9 )L_7, /*hidden argument*/NULL);
		V_2 = (bool)((((RuntimeObject*)(Type_t *)L_6) == ((RuntimeObject*)(Type_t *)L_8))? 1 : 0);
		bool L_9 = V_2;
		if (!L_9)
		{
			goto IL_0041;
		}
	}
	{
		intptr_t L_10 = ___array0;
		Int32U5BU5D_t70F1BDC14B1786481B176D6139A5E3B87DC54C32* L_11;
		L_11 = AndroidJNISafe_FromIntArray_mBF0C0B4309BA525BBA12D7FD3C2790C8FA7C4703((intptr_t)L_10, /*hidden argument*/NULL);
		V_3 = (float)((*(float*)((float*)UnBox((RuntimeObject *)L_11, IL2CPP_RGCTX_DATA(method->rgctx_data, 1)))));
		goto IL_0272;
	}

IL_0041:
	{
		Type_t * L_12 = V_0;
		RuntimeTypeHandle_tC33965ADA3E041E0C94AF05E5CB527B56482CEF9  L_13 = { reinterpret_cast<intptr_t> (Boolean_t07D1E3F34E4813023D64F584DFF7B34C9D922F37_0_0_0_var) };
		IL2CPP_RUNTIME_CLASS_INIT(Type_t_il2cpp_TypeInfo_var);
		Type_t * L_14;
		L_14 = Type_GetTypeFromHandle_m8BB57524FF7F9DB1803BC561D2B3A4DBACEB385E((RuntimeTypeHandle_tC33965ADA3E041E0C94AF05E5CB527B56482CEF9 )L_13, /*hidden argument*/NULL);
		V_4 = (bool)((((RuntimeObject*)(Type_t *)L_12) == ((RuntimeObject*)(Type_t *)L_14))? 1 : 0);
		bool L_15 = V_4;
		if (!L_15)
		{
			goto IL_0065;
		}
	}
	{
		intptr_t L_16 = ___array0;
		BooleanU5BU5D_tEC7BAF93C44F875016DAADC8696EE3A465644D3C* L_17;
		L_17 = AndroidJNISafe_FromBooleanArray_m77A66C34FCB94ADB1AD5E1D88262500C930A5DBF((intptr_t)L_16, /*hidden argument*/NULL);
		V_3 = (float)((*(float*)((float*)UnBox((RuntimeObject *)L_17, IL2CPP_RGCTX_DATA(method->rgctx_data, 1)))));
		goto IL_0272;
	}

IL_0065:
	{
		Type_t * L_18 = V_0;
		RuntimeTypeHandle_tC33965ADA3E041E0C94AF05E5CB527B56482CEF9  L_19 = { reinterpret_cast<intptr_t> (Byte_t0111FAB8B8685667EDDAF77683F0D8F86B659056_0_0_0_var) };
		IL2CPP_RUNTIME_CLASS_INIT(Type_t_il2cpp_TypeInfo_var);
		Type_t * L_20;
		L_20 = Type_GetTypeFromHandle_m8BB57524FF7F9DB1803BC561D2B3A4DBACEB385E((RuntimeTypeHandle_tC33965ADA3E041E0C94AF05E5CB527B56482CEF9 )L_19, /*hidden argument*/NULL);
		V_5 = (bool)((((RuntimeObject*)(Type_t *)L_18) == ((RuntimeObject*)(Type_t *)L_20))? 1 : 0);
		bool L_21 = V_5;
		if (!L_21)
		{
			goto IL_0095;
		}
	}
	{
		IL2CPP_RUNTIME_CLASS_INIT(Debug_tEB68BCBEB8EFD60F8043C67146DC05E7F50F374B_il2cpp_TypeInfo_var);
		Debug_LogWarning_m24085D883C9E74D7AB423F0625E13259923960E7((RuntimeObject *)_stringLiteral24CC8D396132365E532646F936DFC8579E2299B2, /*hidden argument*/NULL);
		intptr_t L_22 = ___array0;
		ByteU5BU5D_tDBBEB0E8362242FA7223000D978B0DD19D4B0726* L_23;
		L_23 = AndroidJNISafe_FromByteArray_m81760A688AECE368E1CFF7DAAC8E141F1B8FA8A8((intptr_t)L_22, /*hidden argument*/NULL);
		V_3 = (float)((*(float*)((float*)UnBox((RuntimeObject *)L_23, IL2CPP_RGCTX_DATA(method->rgctx_data, 1)))));
		goto IL_0272;
	}

IL_0095:
	{
		Type_t * L_24 = V_0;
		RuntimeTypeHandle_tC33965ADA3E041E0C94AF05E5CB527B56482CEF9  L_25 = { reinterpret_cast<intptr_t> (SByte_t928712DD662DC29BA4FAAE8CE2230AFB23447F0B_0_0_0_var) };
		IL2CPP_RUNTIME_CLASS_INIT(Type_t_il2cpp_TypeInfo_var);
		Type_t * L_26;
		L_26 = Type_GetTypeFromHandle_m8BB57524FF7F9DB1803BC561D2B3A4DBACEB385E((RuntimeTypeHandle_tC33965ADA3E041E0C94AF05E5CB527B56482CEF9 )L_25, /*hidden argument*/NULL);
		V_6 = (bool)((((RuntimeObject*)(Type_t *)L_24) == ((RuntimeObject*)(Type_t *)L_26))? 1 : 0);
		bool L_27 = V_6;
		if (!L_27)
		{
			goto IL_00b9;
		}
	}
	{
		intptr_t L_28 = ___array0;
		SByteU5BU5D_t7D94C53295E6116625EA7CC7DEA21FEDC39869E7* L_29;
		L_29 = AndroidJNISafe_FromSByteArray_m01F6539AF10F86B3927436955B57CC809C52416D((intptr_t)L_28, /*hidden argument*/NULL);
		V_3 = (float)((*(float*)((float*)UnBox((RuntimeObject *)L_29, IL2CPP_RGCTX_DATA(method->rgctx_data, 1)))));
		goto IL_0272;
	}

IL_00b9:
	{
		Type_t * L_30 = V_0;
		RuntimeTypeHandle_tC33965ADA3E041E0C94AF05E5CB527B56482CEF9  L_31 = { reinterpret_cast<intptr_t> (Int16_tD0F031114106263BB459DA1F099FF9F42691295A_0_0_0_var) };
		IL2CPP_RUNTIME_CLASS_INIT(Type_t_il2cpp_TypeInfo_var);
		Type_t * L_32;
		L_32 = Type_GetTypeFromHandle_m8BB57524FF7F9DB1803BC561D2B3A4DBACEB385E((RuntimeTypeHandle_tC33965ADA3E041E0C94AF05E5CB527B56482CEF9 )L_31, /*hidden argument*/NULL);
		V_7 = (bool)((((RuntimeObject*)(Type_t *)L_30) == ((RuntimeObject*)(Type_t *)L_32))? 1 : 0);
		bool L_33 = V_7;
		if (!L_33)
		{
			goto IL_00dd;
		}
	}
	{
		intptr_t L_34 = ___array0;
		Int16U5BU5D_tD134F1E6F746D4C09C987436805256C210C2FFCD* L_35;
		L_35 = AndroidJNISafe_FromShortArray_mCDF5B796D950D31035BD35A2E463D41509E4A5CD((intptr_t)L_34, /*hidden argument*/NULL);
		V_3 = (float)((*(float*)((float*)UnBox((RuntimeObject *)L_35, IL2CPP_RGCTX_DATA(method->rgctx_data, 1)))));
		goto IL_0272;
	}

IL_00dd:
	{
		Type_t * L_36 = V_0;
		RuntimeTypeHandle_tC33965ADA3E041E0C94AF05E5CB527B56482CEF9  L_37 = { reinterpret_cast<intptr_t> (Int64_t378EE0D608BD3107E77238E85F30D2BBD46981F3_0_0_0_var) };
		IL2CPP_RUNTIME_CLASS_INIT(Type_t_il2cpp_TypeInfo_var);
		Type_t * L_38;
		L_38 = Type_GetTypeFromHandle_m8BB57524FF7F9DB1803BC561D2B3A4DBACEB385E((RuntimeTypeHandle_tC33965ADA3E041E0C94AF05E5CB527B56482CEF9 )L_37, /*hidden argument*/NULL);
		V_8 = (bool)((((RuntimeObject*)(Type_t *)L_36) == ((RuntimeObject*)(Type_t *)L_38))? 1 : 0);
		bool L_39 = V_8;
		if (!L_39)
		{
			goto IL_0101;
		}
	}
	{
		intptr_t L_40 = ___array0;
		Int64U5BU5D_tCA61E42872C63A4286B24EEE6E0650143B43DCE6* L_41;
		L_41 = AndroidJNISafe_FromLongArray_m0E7C56CB8CFD0EC240F0D86ECBBFD635FFE55CDA((intptr_t)L_40, /*hidden argument*/NULL);
		V_3 = (float)((*(float*)((float*)UnBox((RuntimeObject *)L_41, IL2CPP_RGCTX_DATA(method->rgctx_data, 1)))));
		goto IL_0272;
	}

IL_0101:
	{
		Type_t * L_42 = V_0;
		RuntimeTypeHandle_tC33965ADA3E041E0C94AF05E5CB527B56482CEF9  L_43 = { reinterpret_cast<intptr_t> (Single_tE07797BA3C98D4CA9B5A19413C19A76688AB899E_0_0_0_var) };
		IL2CPP_RUNTIME_CLASS_INIT(Type_t_il2cpp_TypeInfo_var);
		Type_t * L_44;
		L_44 = Type_GetTypeFromHandle_m8BB57524FF7F9DB1803BC561D2B3A4DBACEB385E((RuntimeTypeHandle_tC33965ADA3E041E0C94AF05E5CB527B56482CEF9 )L_43, /*hidden argument*/NULL);
		V_9 = (bool)((((RuntimeObject*)(Type_t *)L_42) == ((RuntimeObject*)(Type_t *)L_44))? 1 : 0);
		bool L_45 = V_9;
		if (!L_45)
		{
			goto IL_0125;
		}
	}
	{
		intptr_t L_46 = ___array0;
		SingleU5BU5D_t47E8DBF5B597C122478D1FFBD9DD57399A0650FA* L_47;
		L_47 = AndroidJNISafe_FromFloatArray_mF6A63CA1B7C10BC27EEC033F0E390772DFDD652D((intptr_t)L_46, /*hidden argument*/NULL);
		V_3 = (float)((*(float*)((float*)UnBox((RuntimeObject *)L_47, IL2CPP_RGCTX_DATA(method->rgctx_data, 1)))));
		goto IL_0272;
	}

IL_0125:
	{
		Type_t * L_48 = V_0;
		RuntimeTypeHandle_tC33965ADA3E041E0C94AF05E5CB527B56482CEF9  L_49 = { reinterpret_cast<intptr_t> (Double_t42821932CB52DE2057E685D0E1AF3DE5033D2181_0_0_0_var) };
		IL2CPP_RUNTIME_CLASS_INIT(Type_t_il2cpp_TypeInfo_var);
		Type_t * L_50;
		L_50 = Type_GetTypeFromHandle_m8BB57524FF7F9DB1803BC561D2B3A4DBACEB385E((RuntimeTypeHandle_tC33965ADA3E041E0C94AF05E5CB527B56482CEF9 )L_49, /*hidden argument*/NULL);
		V_10 = (bool)((((RuntimeObject*)(Type_t *)L_48) == ((RuntimeObject*)(Type_t *)L_50))? 1 : 0);
		bool L_51 = V_10;
		if (!L_51)
		{
			goto IL_0149;
		}
	}
	{
		intptr_t L_52 = ___array0;
		DoubleU5BU5D_t8E1B42EB2ABB79FBD193A6B8C8D97A7CDE44A4FB* L_53;
		L_53 = AndroidJNISafe_FromDoubleArray_m9438B5668E8B2DB3B18CACFF0CC9CAEAB5EC73C8((intptr_t)L_52, /*hidden argument*/NULL);
		V_3 = (float)((*(float*)((float*)UnBox((RuntimeObject *)L_53, IL2CPP_RGCTX_DATA(method->rgctx_data, 1)))));
		goto IL_0272;
	}

IL_0149:
	{
		Type_t * L_54 = V_0;
		RuntimeTypeHandle_tC33965ADA3E041E0C94AF05E5CB527B56482CEF9  L_55 = { reinterpret_cast<intptr_t> (Char_tFF60D8E7E89A20BE2294A003734341BD1DF43E14_0_0_0_var) };
		IL2CPP_RUNTIME_CLASS_INIT(Type_t_il2cpp_TypeInfo_var);
		Type_t * L_56;
		L_56 = Type_GetTypeFromHandle_m8BB57524FF7F9DB1803BC561D2B3A4DBACEB385E((RuntimeTypeHandle_tC33965ADA3E041E0C94AF05E5CB527B56482CEF9 )L_55, /*hidden argument*/NULL);
		V_11 = (bool)((((RuntimeObject*)(Type_t *)L_54) == ((RuntimeObject*)(Type_t *)L_56))? 1 : 0);
		bool L_57 = V_11;
		if (!L_57)
		{
			goto IL_016d;
		}
	}
	{
		intptr_t L_58 = ___array0;
		CharU5BU5D_t7B7FC5BC8091AA3B9CB0B29CDD80B5EE9254AA34* L_59;
		L_59 = AndroidJNISafe_FromCharArray_mA49DB27755EF3B2AE81487E0FCFE06E23F617305((intptr_t)L_58, /*hidden argument*/NULL);
		V_3 = (float)((*(float*)((float*)UnBox((RuntimeObject *)L_59, IL2CPP_RGCTX_DATA(method->rgctx_data, 1)))));
		goto IL_0272;
	}

IL_016d:
	{
		goto IL_0265;
	}

IL_0173:
	{
		Type_t * L_60 = V_0;
		RuntimeTypeHandle_tC33965ADA3E041E0C94AF05E5CB527B56482CEF9  L_61 = { reinterpret_cast<intptr_t> (String_t_0_0_0_var) };
		IL2CPP_RUNTIME_CLASS_INIT(Type_t_il2cpp_TypeInfo_var);
		Type_t * L_62;
		L_62 = Type_GetTypeFromHandle_m8BB57524FF7F9DB1803BC561D2B3A4DBACEB385E((RuntimeTypeHandle_tC33965ADA3E041E0C94AF05E5CB527B56482CEF9 )L_61, /*hidden argument*/NULL);
		V_12 = (bool)((((RuntimeObject*)(Type_t *)L_60) == ((RuntimeObject*)(Type_t *)L_62))? 1 : 0);
		bool L_63 = V_12;
		if (!L_63)
		{
			goto IL_01dc;
		}
	}
	{
		intptr_t L_64 = ___array0;
		int32_t L_65;
		L_65 = AndroidJNISafe_GetArrayLength_m3015C191DBFC246946A88592731441A934507B56((intptr_t)L_64, /*hidden argument*/NULL);
		V_13 = (int32_t)L_65;
		int32_t L_66 = V_13;
		StringU5BU5D_tACEBFEDE350025B554CD507C9AE8FFE49359549A* L_67 = (StringU5BU5D_tACEBFEDE350025B554CD507C9AE8FFE49359549A*)(StringU5BU5D_tACEBFEDE350025B554CD507C9AE8FFE49359549A*)SZArrayNew(StringU5BU5D_tACEBFEDE350025B554CD507C9AE8FFE49359549A_il2cpp_TypeInfo_var, (uint32_t)L_66);
		V_14 = (StringU5BU5D_tACEBFEDE350025B554CD507C9AE8FFE49359549A*)L_67;
		V_15 = (int32_t)0;
		goto IL_01c3;
	}

IL_019d:
	{
		intptr_t L_68 = ___array0;
		int32_t L_69 = V_15;
		intptr_t L_70;
		L_70 = AndroidJNI_GetObjectArrayElement_m502026BF77232EE45D03661E4923C2E5E99FDE18((intptr_t)L_68, (int32_t)L_69, /*hidden argument*/NULL);
		V_16 = (intptr_t)L_70;
		StringU5BU5D_tACEBFEDE350025B554CD507C9AE8FFE49359549A* L_71 = V_14;
		int32_t L_72 = V_15;
		intptr_t L_73 = V_16;
		String_t* L_74;
		L_74 = AndroidJNISafe_GetStringChars_mD59FFDE4192F837E1380B51569B5803E09BE58C8((intptr_t)L_73, /*hidden argument*/NULL);
		NullCheck(L_71);
		ArrayElementTypeCheck (L_71, L_74);
		(L_71)->SetAt(static_cast<il2cpp_array_size_t>(L_72), (String_t*)L_74);
		intptr_t L_75 = V_16;
		AndroidJNISafe_DeleteLocalRef_m7AB242A76D13A3BF4C04831D77960C020D6ADA39((intptr_t)L_75, /*hidden argument*/NULL);
		int32_t L_76 = V_15;
		V_15 = (int32_t)((int32_t)il2cpp_codegen_add((int32_t)L_76, (int32_t)1));
	}

IL_01c3:
	{
		int32_t L_77 = V_15;
		int32_t L_78 = V_13;
		V_17 = (bool)((((int32_t)L_77) < ((int32_t)L_78))? 1 : 0);
		bool L_79 = V_17;
		if (L_79)
		{
			goto IL_019d;
		}
	}
	{
		StringU5BU5D_tACEBFEDE350025B554CD507C9AE8FFE49359549A* L_80 = V_14;
		V_3 = (float)((*(float*)((float*)UnBox((RuntimeObject *)L_80, IL2CPP_RGCTX_DATA(method->rgctx_data, 1)))));
		goto IL_0272;
	}

IL_01dc:
	{
		Type_t * L_81 = V_0;
		RuntimeTypeHandle_tC33965ADA3E041E0C94AF05E5CB527B56482CEF9  L_82 = { reinterpret_cast<intptr_t> (AndroidJavaObject_t10188D5695DCD09C9F621B44B0A8C93A2281236E_0_0_0_var) };
		IL2CPP_RUNTIME_CLASS_INIT(Type_t_il2cpp_TypeInfo_var);
		Type_t * L_83;
		L_83 = Type_GetTypeFromHandle_m8BB57524FF7F9DB1803BC561D2B3A4DBACEB385E((RuntimeTypeHandle_tC33965ADA3E041E0C94AF05E5CB527B56482CEF9 )L_82, /*hidden argument*/NULL);
		V_18 = (bool)((((RuntimeObject*)(Type_t *)L_81) == ((RuntimeObject*)(Type_t *)L_83))? 1 : 0);
		bool L_84 = V_18;
		if (!L_84)
		{
			goto IL_0242;
		}
	}
	{
		intptr_t L_85 = ___array0;
		int32_t L_86;
		L_86 = AndroidJNISafe_GetArrayLength_m3015C191DBFC246946A88592731441A934507B56((intptr_t)L_85, /*hidden argument*/NULL);
		V_19 = (int32_t)L_86;
		int32_t L_87 = V_19;
		AndroidJavaObjectU5BU5D_tEE28563C9013906CEB39794019A55F4BA5B06120* L_88 = (AndroidJavaObjectU5BU5D_tEE28563C9013906CEB39794019A55F4BA5B06120*)(AndroidJavaObjectU5BU5D_tEE28563C9013906CEB39794019A55F4BA5B06120*)SZArrayNew(AndroidJavaObjectU5BU5D_tEE28563C9013906CEB39794019A55F4BA5B06120_il2cpp_TypeInfo_var, (uint32_t)L_87);
		V_20 = (AndroidJavaObjectU5BU5D_tEE28563C9013906CEB39794019A55F4BA5B06120*)L_88;
		V_21 = (int32_t)0;
		goto IL_022c;
	}

IL_0206:
	{
		intptr_t L_89 = ___array0;
		int32_t L_90 = V_21;
		intptr_t L_91;
		L_91 = AndroidJNI_GetObjectArrayElement_m502026BF77232EE45D03661E4923C2E5E99FDE18((intptr_t)L_89, (int32_t)L_90, /*hidden argument*/NULL);
		V_22 = (intptr_t)L_91;
		AndroidJavaObjectU5BU5D_tEE28563C9013906CEB39794019A55F4BA5B06120* L_92 = V_20;
		int32_t L_93 = V_21;
		intptr_t L_94 = V_22;
		AndroidJavaObject_t10188D5695DCD09C9F621B44B0A8C93A2281236E * L_95 = (AndroidJavaObject_t10188D5695DCD09C9F621B44B0A8C93A2281236E *)il2cpp_codegen_object_new(AndroidJavaObject_t10188D5695DCD09C9F621B44B0A8C93A2281236E_il2cpp_TypeInfo_var);
		AndroidJavaObject__ctor_m880F6533139DF0BD36C6EF428E45E9F44B6534A3(L_95, (intptr_t)L_94, /*hidden argument*/NULL);
		NullCheck(L_92);
		ArrayElementTypeCheck (L_92, L_95);
		(L_92)->SetAt(static_cast<il2cpp_array_size_t>(L_93), (AndroidJavaObject_t10188D5695DCD09C9F621B44B0A8C93A2281236E *)L_95);
		intptr_t L_96 = V_22;
		AndroidJNISafe_DeleteLocalRef_m7AB242A76D13A3BF4C04831D77960C020D6ADA39((intptr_t)L_96, /*hidden argument*/NULL);
		int32_t L_97 = V_21;
		V_21 = (int32_t)((int32_t)il2cpp_codegen_add((int32_t)L_97, (int32_t)1));
	}

IL_022c:
	{
		int32_t L_98 = V_21;
		int32_t L_99 = V_19;
		V_23 = (bool)((((int32_t)L_98) < ((int32_t)L_99))? 1 : 0);
		bool L_100 = V_23;
		if (L_100)
		{
			goto IL_0206;
		}
	}
	{
		AndroidJavaObjectU5BU5D_tEE28563C9013906CEB39794019A55F4BA5B06120* L_101 = V_20;
		V_3 = (float)((*(float*)((float*)UnBox((RuntimeObject *)L_101, IL2CPP_RGCTX_DATA(method->rgctx_data, 1)))));
		goto IL_0272;
	}

IL_0242:
	{
		Type_t * L_102 = V_0;
		Type_t * L_103 = (Type_t *)L_102;
		G_B31_0 = L_103;
		G_B31_1 = ((String_t*)il2cpp_codegen_initialize_runtime_metadata_inline((uintptr_t*)&_stringLiteral51253131B895C2F8066BCC47E62D44F18F43446C));
		if (L_103)
		{
			G_B32_0 = L_103;
			G_B32_1 = ((String_t*)il2cpp_codegen_initialize_runtime_metadata_inline((uintptr_t*)&_stringLiteral51253131B895C2F8066BCC47E62D44F18F43446C));
			goto IL_0250;
		}
	}
	{
		G_B33_0 = ((String_t*)(NULL));
		G_B33_1 = G_B31_1;
		goto IL_0255;
	}

IL_0250:
	{
		NullCheck((RuntimeObject *)G_B32_0);
		String_t* L_104;
		L_104 = VirtFuncInvoker0< String_t* >::Invoke(3 /* System.String System.Object::ToString() */, (RuntimeObject *)G_B32_0);
		G_B33_0 = L_104;
		G_B33_1 = G_B32_1;
	}

IL_0255:
	{
		String_t* L_105;
		L_105 = String_Concat_m89EAB4C6A96B0E5C3F87300D6BE78D386B9EFC44((String_t*)G_B33_1, (String_t*)G_B33_0, (String_t*)((String_t*)il2cpp_codegen_initialize_runtime_metadata_inline((uintptr_t*)&_stringLiteral42646B33B50B6AA15E22733C8900716F0FE19E1D)), /*hidden argument*/NULL);
		Exception_t * L_106 = (Exception_t *)il2cpp_codegen_object_new(((RuntimeClass*)il2cpp_codegen_initialize_runtime_metadata_inline((uintptr_t*)&Exception_t_il2cpp_TypeInfo_var)));
		Exception__ctor_m8ECDE8ACA7F2E0EF1144BD1200FB5DB2870B5F11(L_106, (String_t*)L_105, /*hidden argument*/NULL);
		IL2CPP_RAISE_MANAGED_EXCEPTION(L_106, ((RuntimeMethod*)il2cpp_codegen_initialize_runtime_metadata_inline((uintptr_t*)&_AndroidJNIHelper_ConvertFromJNIArray_TisSingle_tE07797BA3C98D4CA9B5A19413C19A76688AB899E_mD3EDB3217478F469F150970E33043F80EF1BA3CB_RuntimeMethod_var)));
	}

IL_0265:
	{
		il2cpp_codegen_initobj((&V_24), sizeof(float));
		float L_107 = V_24;
		V_3 = (float)L_107;
		goto IL_0272;
	}

IL_0272:
	{
		float L_108 = V_3;
		return (float)L_108;
	}
}
// System.IntPtr UnityEngine._AndroidJNIHelper::GetFieldID<System.Int32>(System.IntPtr,System.String,System.Boolean)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR intptr_t _AndroidJNIHelper_GetFieldID_TisInt32_tFDE5F8CD43D10453F6A2E0C77FE48C6CC7009046_m32A6CFE9E2DB2590A7E7622E12BE5A86B33D5AD0_gshared (intptr_t ___jclass0, String_t* ___fieldName1, bool ___isStatic2, const RuntimeMethod* method)
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Type_t_il2cpp_TypeInfo_var);
		s_Il2CppMethodInitialized = true;
	}
	intptr_t V_0;
	memset((&V_0), 0, sizeof(V_0));
	{
		intptr_t L_0 = ___jclass0;
		String_t* L_1 = ___fieldName1;
		RuntimeTypeHandle_tC33965ADA3E041E0C94AF05E5CB527B56482CEF9  L_2 = { reinterpret_cast<intptr_t> (IL2CPP_RGCTX_TYPE(method->rgctx_data, 0)) };
		IL2CPP_RUNTIME_CLASS_INIT(Type_t_il2cpp_TypeInfo_var);
		Type_t * L_3;
		L_3 = Type_GetTypeFromHandle_m8BB57524FF7F9DB1803BC561D2B3A4DBACEB385E((RuntimeTypeHandle_tC33965ADA3E041E0C94AF05E5CB527B56482CEF9 )L_2, /*hidden argument*/NULL);
		String_t* L_4;
		L_4 = _AndroidJNIHelper_GetSignature_m4A272D66518BF9A4C746B02B91AAB1361293232C((RuntimeObject *)L_3, /*hidden argument*/NULL);
		bool L_5 = ___isStatic2;
		intptr_t L_6;
		L_6 = AndroidJNIHelper_GetFieldID_mCDDF095C790C66CB19342E3A143A104020F5E170((intptr_t)L_0, (String_t*)L_1, (String_t*)L_4, (bool)L_5, /*hidden argument*/NULL);
		V_0 = (intptr_t)L_6;
		goto IL_001b;
	}

IL_001b:
	{
		intptr_t L_7 = V_0;
		return (intptr_t)L_7;
	}
}
// System.IntPtr UnityEngine._AndroidJNIHelper::GetFieldID<System.Object>(System.IntPtr,System.String,System.Boolean)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR intptr_t _AndroidJNIHelper_GetFieldID_TisRuntimeObject_m197B83058968EF834FD281FFA228ECD28C55F871_gshared (intptr_t ___jclass0, String_t* ___fieldName1, bool ___isStatic2, const RuntimeMethod* method)
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Type_t_il2cpp_TypeInfo_var);
		s_Il2CppMethodInitialized = true;
	}
	intptr_t V_0;
	memset((&V_0), 0, sizeof(V_0));
	{
		intptr_t L_0 = ___jclass0;
		String_t* L_1 = ___fieldName1;
		RuntimeTypeHandle_tC33965ADA3E041E0C94AF05E5CB527B56482CEF9  L_2 = { reinterpret_cast<intptr_t> (IL2CPP_RGCTX_TYPE(method->rgctx_data, 0)) };
		IL2CPP_RUNTIME_CLASS_INIT(Type_t_il2cpp_TypeInfo_var);
		Type_t * L_3;
		L_3 = Type_GetTypeFromHandle_m8BB57524FF7F9DB1803BC561D2B3A4DBACEB385E((RuntimeTypeHandle_tC33965ADA3E041E0C94AF05E5CB527B56482CEF9 )L_2, /*hidden argument*/NULL);
		String_t* L_4;
		L_4 = _AndroidJNIHelper_GetSignature_m4A272D66518BF9A4C746B02B91AAB1361293232C((RuntimeObject *)L_3, /*hidden argument*/NULL);
		bool L_5 = ___isStatic2;
		intptr_t L_6;
		L_6 = AndroidJNIHelper_GetFieldID_mCDDF095C790C66CB19342E3A143A104020F5E170((intptr_t)L_0, (String_t*)L_1, (String_t*)L_4, (bool)L_5, /*hidden argument*/NULL);
		V_0 = (intptr_t)L_6;
		goto IL_001b;
	}

IL_001b:
	{
		intptr_t L_7 = V_0;
		return (intptr_t)L_7;
	}
}
// System.IntPtr UnityEngine._AndroidJNIHelper::GetMethodID<System.Boolean>(System.IntPtr,System.String,System.Object[],System.Boolean)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR intptr_t _AndroidJNIHelper_GetMethodID_TisBoolean_t07D1E3F34E4813023D64F584DFF7B34C9D922F37_mA6A3AB087792C0011A244BF219EB013D009592B2_gshared (intptr_t ___jclass0, String_t* ___methodName1, ObjectU5BU5D_tC1F4EE0DB0B7300255F5FD4AF64FE4C585CF5ADE* ___args2, bool ___isStatic3, const RuntimeMethod* method)
{
	intptr_t V_0;
	memset((&V_0), 0, sizeof(V_0));
	{
		intptr_t L_0 = ___jclass0;
		String_t* L_1 = ___methodName1;
		ObjectU5BU5D_tC1F4EE0DB0B7300255F5FD4AF64FE4C585CF5ADE* L_2 = ___args2;
		String_t* L_3;
		L_3 = ((  String_t* (*) (ObjectU5BU5D_tC1F4EE0DB0B7300255F5FD4AF64FE4C585CF5ADE*, const RuntimeMethod*))IL2CPP_RGCTX_METHOD_INFO(method->rgctx_data, 0)->methodPointer)((ObjectU5BU5D_tC1F4EE0DB0B7300255F5FD4AF64FE4C585CF5ADE*)L_2, /*hidden argument*/IL2CPP_RGCTX_METHOD_INFO(method->rgctx_data, 0));
		bool L_4 = ___isStatic3;
		intptr_t L_5;
		L_5 = AndroidJNIHelper_GetMethodID_m2B5E7C9B05905F6C6B60A735B8A6E97BBA468535((intptr_t)L_0, (String_t*)L_1, (String_t*)L_3, (bool)L_4, /*hidden argument*/NULL);
		V_0 = (intptr_t)L_5;
		goto IL_0012;
	}

IL_0012:
	{
		intptr_t L_6 = V_0;
		return (intptr_t)L_6;
	}
}
// System.IntPtr UnityEngine._AndroidJNIHelper::GetMethodID<System.Char>(System.IntPtr,System.String,System.Object[],System.Boolean)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR intptr_t _AndroidJNIHelper_GetMethodID_TisChar_tFF60D8E7E89A20BE2294A003734341BD1DF43E14_mF091800677E029891EFE21CF853FAF7A59EAA5EB_gshared (intptr_t ___jclass0, String_t* ___methodName1, ObjectU5BU5D_tC1F4EE0DB0B7300255F5FD4AF64FE4C585CF5ADE* ___args2, bool ___isStatic3, const RuntimeMethod* method)
{
	intptr_t V_0;
	memset((&V_0), 0, sizeof(V_0));
	{
		intptr_t L_0 = ___jclass0;
		String_t* L_1 = ___methodName1;
		ObjectU5BU5D_tC1F4EE0DB0B7300255F5FD4AF64FE4C585CF5ADE* L_2 = ___args2;
		String_t* L_3;
		L_3 = ((  String_t* (*) (ObjectU5BU5D_tC1F4EE0DB0B7300255F5FD4AF64FE4C585CF5ADE*, const RuntimeMethod*))IL2CPP_RGCTX_METHOD_INFO(method->rgctx_data, 0)->methodPointer)((ObjectU5BU5D_tC1F4EE0DB0B7300255F5FD4AF64FE4C585CF5ADE*)L_2, /*hidden argument*/IL2CPP_RGCTX_METHOD_INFO(method->rgctx_data, 0));
		bool L_4 = ___isStatic3;
		intptr_t L_5;
		L_5 = AndroidJNIHelper_GetMethodID_m2B5E7C9B05905F6C6B60A735B8A6E97BBA468535((intptr_t)L_0, (String_t*)L_1, (String_t*)L_3, (bool)L_4, /*hidden argument*/NULL);
		V_0 = (intptr_t)L_5;
		goto IL_0012;
	}

IL_0012:
	{
		intptr_t L_6 = V_0;
		return (intptr_t)L_6;
	}
}
// System.IntPtr UnityEngine._AndroidJNIHelper::GetMethodID<System.Double>(System.IntPtr,System.String,System.Object[],System.Boolean)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR intptr_t _AndroidJNIHelper_GetMethodID_TisDouble_t42821932CB52DE2057E685D0E1AF3DE5033D2181_m2AC2F0071B32B0242BD624B60ED4DF0989C8FA51_gshared (intptr_t ___jclass0, String_t* ___methodName1, ObjectU5BU5D_tC1F4EE0DB0B7300255F5FD4AF64FE4C585CF5ADE* ___args2, bool ___isStatic3, const RuntimeMethod* method)
{
	intptr_t V_0;
	memset((&V_0), 0, sizeof(V_0));
	{
		intptr_t L_0 = ___jclass0;
		String_t* L_1 = ___methodName1;
		ObjectU5BU5D_tC1F4EE0DB0B7300255F5FD4AF64FE4C585CF5ADE* L_2 = ___args2;
		String_t* L_3;
		L_3 = ((  String_t* (*) (ObjectU5BU5D_tC1F4EE0DB0B7300255F5FD4AF64FE4C585CF5ADE*, const RuntimeMethod*))IL2CPP_RGCTX_METHOD_INFO(method->rgctx_data, 0)->methodPointer)((ObjectU5BU5D_tC1F4EE0DB0B7300255F5FD4AF64FE4C585CF5ADE*)L_2, /*hidden argument*/IL2CPP_RGCTX_METHOD_INFO(method->rgctx_data, 0));
		bool L_4 = ___isStatic3;
		intptr_t L_5;
		L_5 = AndroidJNIHelper_GetMethodID_m2B5E7C9B05905F6C6B60A735B8A6E97BBA468535((intptr_t)L_0, (String_t*)L_1, (String_t*)L_3, (bool)L_4, /*hidden argument*/NULL);
		V_0 = (intptr_t)L_5;
		goto IL_0012;
	}

IL_0012:
	{
		intptr_t L_6 = V_0;
		return (intptr_t)L_6;
	}
}
// System.IntPtr UnityEngine._AndroidJNIHelper::GetMethodID<System.Int16>(System.IntPtr,System.String,System.Object[],System.Boolean)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR intptr_t _AndroidJNIHelper_GetMethodID_TisInt16_tD0F031114106263BB459DA1F099FF9F42691295A_m75B0CDC857E28490BBB6B93E24923ECA7D896754_gshared (intptr_t ___jclass0, String_t* ___methodName1, ObjectU5BU5D_tC1F4EE0DB0B7300255F5FD4AF64FE4C585CF5ADE* ___args2, bool ___isStatic3, const RuntimeMethod* method)
{
	intptr_t V_0;
	memset((&V_0), 0, sizeof(V_0));
	{
		intptr_t L_0 = ___jclass0;
		String_t* L_1 = ___methodName1;
		ObjectU5BU5D_tC1F4EE0DB0B7300255F5FD4AF64FE4C585CF5ADE* L_2 = ___args2;
		String_t* L_3;
		L_3 = ((  String_t* (*) (ObjectU5BU5D_tC1F4EE0DB0B7300255F5FD4AF64FE4C585CF5ADE*, const RuntimeMethod*))IL2CPP_RGCTX_METHOD_INFO(method->rgctx_data, 0)->methodPointer)((ObjectU5BU5D_tC1F4EE0DB0B7300255F5FD4AF64FE4C585CF5ADE*)L_2, /*hidden argument*/IL2CPP_RGCTX_METHOD_INFO(method->rgctx_data, 0));
		bool L_4 = ___isStatic3;
		intptr_t L_5;
		L_5 = AndroidJNIHelper_GetMethodID_m2B5E7C9B05905F6C6B60A735B8A6E97BBA468535((intptr_t)L_0, (String_t*)L_1, (String_t*)L_3, (bool)L_4, /*hidden argument*/NULL);
		V_0 = (intptr_t)L_5;
		goto IL_0012;
	}

IL_0012:
	{
		intptr_t L_6 = V_0;
		return (intptr_t)L_6;
	}
}
// System.IntPtr UnityEngine._AndroidJNIHelper::GetMethodID<System.Int32>(System.IntPtr,System.String,System.Object[],System.Boolean)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR intptr_t _AndroidJNIHelper_GetMethodID_TisInt32_tFDE5F8CD43D10453F6A2E0C77FE48C6CC7009046_m74985872D44523341B02768E3167C022A0BB74C0_gshared (intptr_t ___jclass0, String_t* ___methodName1, ObjectU5BU5D_tC1F4EE0DB0B7300255F5FD4AF64FE4C585CF5ADE* ___args2, bool ___isStatic3, const RuntimeMethod* method)
{
	intptr_t V_0;
	memset((&V_0), 0, sizeof(V_0));
	{
		intptr_t L_0 = ___jclass0;
		String_t* L_1 = ___methodName1;
		ObjectU5BU5D_tC1F4EE0DB0B7300255F5FD4AF64FE4C585CF5ADE* L_2 = ___args2;
		String_t* L_3;
		L_3 = ((  String_t* (*) (ObjectU5BU5D_tC1F4EE0DB0B7300255F5FD4AF64FE4C585CF5ADE*, const RuntimeMethod*))IL2CPP_RGCTX_METHOD_INFO(method->rgctx_data, 0)->methodPointer)((ObjectU5BU5D_tC1F4EE0DB0B7300255F5FD4AF64FE4C585CF5ADE*)L_2, /*hidden argument*/IL2CPP_RGCTX_METHOD_INFO(method->rgctx_data, 0));
		bool L_4 = ___isStatic3;
		intptr_t L_5;
		L_5 = AndroidJNIHelper_GetMethodID_m2B5E7C9B05905F6C6B60A735B8A6E97BBA468535((intptr_t)L_0, (String_t*)L_1, (String_t*)L_3, (bool)L_4, /*hidden argument*/NULL);
		V_0 = (intptr_t)L_5;
		goto IL_0012;
	}

IL_0012:
	{
		intptr_t L_6 = V_0;
		return (intptr_t)L_6;
	}
}
// System.IntPtr UnityEngine._AndroidJNIHelper::GetMethodID<System.Int64>(System.IntPtr,System.String,System.Object[],System.Boolean)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR intptr_t _AndroidJNIHelper_GetMethodID_TisInt64_t378EE0D608BD3107E77238E85F30D2BBD46981F3_m94135D9C37BCAFBC5C814AB2EB52A4A2B46A92A4_gshared (intptr_t ___jclass0, String_t* ___methodName1, ObjectU5BU5D_tC1F4EE0DB0B7300255F5FD4AF64FE4C585CF5ADE* ___args2, bool ___isStatic3, const RuntimeMethod* method)
{
	intptr_t V_0;
	memset((&V_0), 0, sizeof(V_0));
	{
		intptr_t L_0 = ___jclass0;
		String_t* L_1 = ___methodName1;
		ObjectU5BU5D_tC1F4EE0DB0B7300255F5FD4AF64FE4C585CF5ADE* L_2 = ___args2;
		String_t* L_3;
		L_3 = ((  String_t* (*) (ObjectU5BU5D_tC1F4EE0DB0B7300255F5FD4AF64FE4C585CF5ADE*, const RuntimeMethod*))IL2CPP_RGCTX_METHOD_INFO(method->rgctx_data, 0)->methodPointer)((ObjectU5BU5D_tC1F4EE0DB0B7300255F5FD4AF64FE4C585CF5ADE*)L_2, /*hidden argument*/IL2CPP_RGCTX_METHOD_INFO(method->rgctx_data, 0));
		bool L_4 = ___isStatic3;
		intptr_t L_5;
		L_5 = AndroidJNIHelper_GetMethodID_m2B5E7C9B05905F6C6B60A735B8A6E97BBA468535((intptr_t)L_0, (String_t*)L_1, (String_t*)L_3, (bool)L_4, /*hidden argument*/NULL);
		V_0 = (intptr_t)L_5;
		goto IL_0012;
	}

IL_0012:
	{
		intptr_t L_6 = V_0;
		return (intptr_t)L_6;
	}
}
// System.IntPtr UnityEngine._AndroidJNIHelper::GetMethodID<System.Object>(System.IntPtr,System.String,System.Object[],System.Boolean)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR intptr_t _AndroidJNIHelper_GetMethodID_TisRuntimeObject_mE923D006BD57E879AAE0EF692E8D0045CF7E0748_gshared (intptr_t ___jclass0, String_t* ___methodName1, ObjectU5BU5D_tC1F4EE0DB0B7300255F5FD4AF64FE4C585CF5ADE* ___args2, bool ___isStatic3, const RuntimeMethod* method)
{
	intptr_t V_0;
	memset((&V_0), 0, sizeof(V_0));
	{
		intptr_t L_0 = ___jclass0;
		String_t* L_1 = ___methodName1;
		ObjectU5BU5D_tC1F4EE0DB0B7300255F5FD4AF64FE4C585CF5ADE* L_2 = ___args2;
		String_t* L_3;
		L_3 = ((  String_t* (*) (ObjectU5BU5D_tC1F4EE0DB0B7300255F5FD4AF64FE4C585CF5ADE*, const RuntimeMethod*))IL2CPP_RGCTX_METHOD_INFO(method->rgctx_data, 0)->methodPointer)((ObjectU5BU5D_tC1F4EE0DB0B7300255F5FD4AF64FE4C585CF5ADE*)L_2, /*hidden argument*/IL2CPP_RGCTX_METHOD_INFO(method->rgctx_data, 0));
		bool L_4 = ___isStatic3;
		intptr_t L_5;
		L_5 = AndroidJNIHelper_GetMethodID_m2B5E7C9B05905F6C6B60A735B8A6E97BBA468535((intptr_t)L_0, (String_t*)L_1, (String_t*)L_3, (bool)L_4, /*hidden argument*/NULL);
		V_0 = (intptr_t)L_5;
		goto IL_0012;
	}

IL_0012:
	{
		intptr_t L_6 = V_0;
		return (intptr_t)L_6;
	}
}
// System.IntPtr UnityEngine._AndroidJNIHelper::GetMethodID<System.SByte>(System.IntPtr,System.String,System.Object[],System.Boolean)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR intptr_t _AndroidJNIHelper_GetMethodID_TisSByte_t928712DD662DC29BA4FAAE8CE2230AFB23447F0B_m33DBC436D5D48BD8B087CC4D6BDC0FF2B658D402_gshared (intptr_t ___jclass0, String_t* ___methodName1, ObjectU5BU5D_tC1F4EE0DB0B7300255F5FD4AF64FE4C585CF5ADE* ___args2, bool ___isStatic3, const RuntimeMethod* method)
{
	intptr_t V_0;
	memset((&V_0), 0, sizeof(V_0));
	{
		intptr_t L_0 = ___jclass0;
		String_t* L_1 = ___methodName1;
		ObjectU5BU5D_tC1F4EE0DB0B7300255F5FD4AF64FE4C585CF5ADE* L_2 = ___args2;
		String_t* L_3;
		L_3 = ((  String_t* (*) (ObjectU5BU5D_tC1F4EE0DB0B7300255F5FD4AF64FE4C585CF5ADE*, const RuntimeMethod*))IL2CPP_RGCTX_METHOD_INFO(method->rgctx_data, 0)->methodPointer)((ObjectU5BU5D_tC1F4EE0DB0B7300255F5FD4AF64FE4C585CF5ADE*)L_2, /*hidden argument*/IL2CPP_RGCTX_METHOD_INFO(method->rgctx_data, 0));
		bool L_4 = ___isStatic3;
		intptr_t L_5;
		L_5 = AndroidJNIHelper_GetMethodID_m2B5E7C9B05905F6C6B60A735B8A6E97BBA468535((intptr_t)L_0, (String_t*)L_1, (String_t*)L_3, (bool)L_4, /*hidden argument*/NULL);
		V_0 = (intptr_t)L_5;
		goto IL_0012;
	}

IL_0012:
	{
		intptr_t L_6 = V_0;
		return (intptr_t)L_6;
	}
}
// System.IntPtr UnityEngine._AndroidJNIHelper::GetMethodID<System.Single>(System.IntPtr,System.String,System.Object[],System.Boolean)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR intptr_t _AndroidJNIHelper_GetMethodID_TisSingle_tE07797BA3C98D4CA9B5A19413C19A76688AB899E_m056304D259B1FDB717A6CEE1A2262C45CE33DEBC_gshared (intptr_t ___jclass0, String_t* ___methodName1, ObjectU5BU5D_tC1F4EE0DB0B7300255F5FD4AF64FE4C585CF5ADE* ___args2, bool ___isStatic3, const RuntimeMethod* method)
{
	intptr_t V_0;
	memset((&V_0), 0, sizeof(V_0));
	{
		intptr_t L_0 = ___jclass0;
		String_t* L_1 = ___methodName1;
		ObjectU5BU5D_tC1F4EE0DB0B7300255F5FD4AF64FE4C585CF5ADE* L_2 = ___args2;
		String_t* L_3;
		L_3 = ((  String_t* (*) (ObjectU5BU5D_tC1F4EE0DB0B7300255F5FD4AF64FE4C585CF5ADE*, const RuntimeMethod*))IL2CPP_RGCTX_METHOD_INFO(method->rgctx_data, 0)->methodPointer)((ObjectU5BU5D_tC1F4EE0DB0B7300255F5FD4AF64FE4C585CF5ADE*)L_2, /*hidden argument*/IL2CPP_RGCTX_METHOD_INFO(method->rgctx_data, 0));
		bool L_4 = ___isStatic3;
		intptr_t L_5;
		L_5 = AndroidJNIHelper_GetMethodID_m2B5E7C9B05905F6C6B60A735B8A6E97BBA468535((intptr_t)L_0, (String_t*)L_1, (String_t*)L_3, (bool)L_4, /*hidden argument*/NULL);
		V_0 = (intptr_t)L_5;
		goto IL_0012;
	}

IL_0012:
	{
		intptr_t L_6 = V_0;
		return (intptr_t)L_6;
	}
}
// System.String UnityEngine._AndroidJNIHelper::GetSignature<System.Boolean>(System.Object[])
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR String_t* _AndroidJNIHelper_GetSignature_TisBoolean_t07D1E3F34E4813023D64F584DFF7B34C9D922F37_mBD54DD62EF90673A4806A2CEFA031CFE3C998274_gshared (ObjectU5BU5D_tC1F4EE0DB0B7300255F5FD4AF64FE4C585CF5ADE* ___args0, const RuntimeMethod* method)
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&StringBuilder_t_il2cpp_TypeInfo_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Type_t_il2cpp_TypeInfo_var);
		s_Il2CppMethodInitialized = true;
	}
	StringBuilder_t * V_0 = NULL;
	ObjectU5BU5D_tC1F4EE0DB0B7300255F5FD4AF64FE4C585CF5ADE* V_1 = NULL;
	int32_t V_2 = 0;
	RuntimeObject * V_3 = NULL;
	String_t* V_4 = NULL;
	{
		StringBuilder_t * L_0 = (StringBuilder_t *)il2cpp_codegen_object_new(StringBuilder_t_il2cpp_TypeInfo_var);
		StringBuilder__ctor_m5A81DE19E748F748E19FF13FB6FFD2547F9212D9(L_0, /*hidden argument*/NULL);
		V_0 = (StringBuilder_t *)L_0;
		StringBuilder_t * L_1 = V_0;
		NullCheck((StringBuilder_t *)L_1);
		StringBuilder_t * L_2;
		L_2 = StringBuilder_Append_m1ADA3C16E40BF253BCDB5F9579B4DBA9C3E5B22E((StringBuilder_t *)L_1, (Il2CppChar)((int32_t)40), /*hidden argument*/NULL);
		ObjectU5BU5D_tC1F4EE0DB0B7300255F5FD4AF64FE4C585CF5ADE* L_3 = ___args0;
		V_1 = (ObjectU5BU5D_tC1F4EE0DB0B7300255F5FD4AF64FE4C585CF5ADE*)L_3;
		V_2 = (int32_t)0;
		goto IL_002e;
	}

IL_0017:
	{
		ObjectU5BU5D_tC1F4EE0DB0B7300255F5FD4AF64FE4C585CF5ADE* L_4 = V_1;
		int32_t L_5 = V_2;
		NullCheck(L_4);
		int32_t L_6 = L_5;
		RuntimeObject * L_7 = (L_4)->GetAt(static_cast<il2cpp_array_size_t>(L_6));
		V_3 = (RuntimeObject *)L_7;
		StringBuilder_t * L_8 = V_0;
		RuntimeObject * L_9 = V_3;
		String_t* L_10;
		L_10 = _AndroidJNIHelper_GetSignature_m4A272D66518BF9A4C746B02B91AAB1361293232C((RuntimeObject *)L_9, /*hidden argument*/NULL);
		NullCheck((StringBuilder_t *)L_8);
		StringBuilder_t * L_11;
		L_11 = StringBuilder_Append_mD02AB0C74C6F55E3E330818C77EC147E22096FB1((StringBuilder_t *)L_8, (String_t*)L_10, /*hidden argument*/NULL);
		int32_t L_12 = V_2;
		V_2 = (int32_t)((int32_t)il2cpp_codegen_add((int32_t)L_12, (int32_t)1));
	}

IL_002e:
	{
		int32_t L_13 = V_2;
		ObjectU5BU5D_tC1F4EE0DB0B7300255F5FD4AF64FE4C585CF5ADE* L_14 = V_1;
		NullCheck(L_14);
		if ((((int32_t)L_13) < ((int32_t)((int32_t)((int32_t)(((RuntimeArray*)L_14)->max_length))))))
		{
			goto IL_0017;
		}
	}
	{
		StringBuilder_t * L_15 = V_0;
		NullCheck((StringBuilder_t *)L_15);
		StringBuilder_t * L_16;
		L_16 = StringBuilder_Append_m1ADA3C16E40BF253BCDB5F9579B4DBA9C3E5B22E((StringBuilder_t *)L_15, (Il2CppChar)((int32_t)41), /*hidden argument*/NULL);
		StringBuilder_t * L_17 = V_0;
		RuntimeTypeHandle_tC33965ADA3E041E0C94AF05E5CB527B56482CEF9  L_18 = { reinterpret_cast<intptr_t> (IL2CPP_RGCTX_TYPE(method->rgctx_data, 0)) };
		IL2CPP_RUNTIME_CLASS_INIT(Type_t_il2cpp_TypeInfo_var);
		Type_t * L_19;
		L_19 = Type_GetTypeFromHandle_m8BB57524FF7F9DB1803BC561D2B3A4DBACEB385E((RuntimeTypeHandle_tC33965ADA3E041E0C94AF05E5CB527B56482CEF9 )L_18, /*hidden argument*/NULL);
		String_t* L_20;
		L_20 = _AndroidJNIHelper_GetSignature_m4A272D66518BF9A4C746B02B91AAB1361293232C((RuntimeObject *)L_19, /*hidden argument*/NULL);
		NullCheck((StringBuilder_t *)L_17);
		StringBuilder_t * L_21;
		L_21 = StringBuilder_Append_mD02AB0C74C6F55E3E330818C77EC147E22096FB1((StringBuilder_t *)L_17, (String_t*)L_20, /*hidden argument*/NULL);
		StringBuilder_t * L_22 = V_0;
		NullCheck((RuntimeObject *)L_22);
		String_t* L_23;
		L_23 = VirtFuncInvoker0< String_t* >::Invoke(3 /* System.String System.Object::ToString() */, (RuntimeObject *)L_22);
		V_4 = (String_t*)L_23;
		goto IL_005d;
	}

IL_005d:
	{
		String_t* L_24 = V_4;
		return (String_t*)L_24;
	}
}
// System.String UnityEngine._AndroidJNIHelper::GetSignature<System.Char>(System.Object[])
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR String_t* _AndroidJNIHelper_GetSignature_TisChar_tFF60D8E7E89A20BE2294A003734341BD1DF43E14_mB636DED19D226BEDFC17AE941CAD220377CA0584_gshared (ObjectU5BU5D_tC1F4EE0DB0B7300255F5FD4AF64FE4C585CF5ADE* ___args0, const RuntimeMethod* method)
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&StringBuilder_t_il2cpp_TypeInfo_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Type_t_il2cpp_TypeInfo_var);
		s_Il2CppMethodInitialized = true;
	}
	StringBuilder_t * V_0 = NULL;
	ObjectU5BU5D_tC1F4EE0DB0B7300255F5FD4AF64FE4C585CF5ADE* V_1 = NULL;
	int32_t V_2 = 0;
	RuntimeObject * V_3 = NULL;
	String_t* V_4 = NULL;
	{
		StringBuilder_t * L_0 = (StringBuilder_t *)il2cpp_codegen_object_new(StringBuilder_t_il2cpp_TypeInfo_var);
		StringBuilder__ctor_m5A81DE19E748F748E19FF13FB6FFD2547F9212D9(L_0, /*hidden argument*/NULL);
		V_0 = (StringBuilder_t *)L_0;
		StringBuilder_t * L_1 = V_0;
		NullCheck((StringBuilder_t *)L_1);
		StringBuilder_t * L_2;
		L_2 = StringBuilder_Append_m1ADA3C16E40BF253BCDB5F9579B4DBA9C3E5B22E((StringBuilder_t *)L_1, (Il2CppChar)((int32_t)40), /*hidden argument*/NULL);
		ObjectU5BU5D_tC1F4EE0DB0B7300255F5FD4AF64FE4C585CF5ADE* L_3 = ___args0;
		V_1 = (ObjectU5BU5D_tC1F4EE0DB0B7300255F5FD4AF64FE4C585CF5ADE*)L_3;
		V_2 = (int32_t)0;
		goto IL_002e;
	}

IL_0017:
	{
		ObjectU5BU5D_tC1F4EE0DB0B7300255F5FD4AF64FE4C585CF5ADE* L_4 = V_1;
		int32_t L_5 = V_2;
		NullCheck(L_4);
		int32_t L_6 = L_5;
		RuntimeObject * L_7 = (L_4)->GetAt(static_cast<il2cpp_array_size_t>(L_6));
		V_3 = (RuntimeObject *)L_7;
		StringBuilder_t * L_8 = V_0;
		RuntimeObject * L_9 = V_3;
		String_t* L_10;
		L_10 = _AndroidJNIHelper_GetSignature_m4A272D66518BF9A4C746B02B91AAB1361293232C((RuntimeObject *)L_9, /*hidden argument*/NULL);
		NullCheck((StringBuilder_t *)L_8);
		StringBuilder_t * L_11;
		L_11 = StringBuilder_Append_mD02AB0C74C6F55E3E330818C77EC147E22096FB1((StringBuilder_t *)L_8, (String_t*)L_10, /*hidden argument*/NULL);
		int32_t L_12 = V_2;
		V_2 = (int32_t)((int32_t)il2cpp_codegen_add((int32_t)L_12, (int32_t)1));
	}

IL_002e:
	{
		int32_t L_13 = V_2;
		ObjectU5BU5D_tC1F4EE0DB0B7300255F5FD4AF64FE4C585CF5ADE* L_14 = V_1;
		NullCheck(L_14);
		if ((((int32_t)L_13) < ((int32_t)((int32_t)((int32_t)(((RuntimeArray*)L_14)->max_length))))))
		{
			goto IL_0017;
		}
	}
	{
		StringBuilder_t * L_15 = V_0;
		NullCheck((StringBuilder_t *)L_15);
		StringBuilder_t * L_16;
		L_16 = StringBuilder_Append_m1ADA3C16E40BF253BCDB5F9579B4DBA9C3E5B22E((StringBuilder_t *)L_15, (Il2CppChar)((int32_t)41), /*hidden argument*/NULL);
		StringBuilder_t * L_17 = V_0;
		RuntimeTypeHandle_tC33965ADA3E041E0C94AF05E5CB527B56482CEF9  L_18 = { reinterpret_cast<intptr_t> (IL2CPP_RGCTX_TYPE(method->rgctx_data, 0)) };
		IL2CPP_RUNTIME_CLASS_INIT(Type_t_il2cpp_TypeInfo_var);
		Type_t * L_19;
		L_19 = Type_GetTypeFromHandle_m8BB57524FF7F9DB1803BC561D2B3A4DBACEB385E((RuntimeTypeHandle_tC33965ADA3E041E0C94AF05E5CB527B56482CEF9 )L_18, /*hidden argument*/NULL);
		String_t* L_20;
		L_20 = _AndroidJNIHelper_GetSignature_m4A272D66518BF9A4C746B02B91AAB1361293232C((RuntimeObject *)L_19, /*hidden argument*/NULL);
		NullCheck((StringBuilder_t *)L_17);
		StringBuilder_t * L_21;
		L_21 = StringBuilder_Append_mD02AB0C74C6F55E3E330818C77EC147E22096FB1((StringBuilder_t *)L_17, (String_t*)L_20, /*hidden argument*/NULL);
		StringBuilder_t * L_22 = V_0;
		NullCheck((RuntimeObject *)L_22);
		String_t* L_23;
		L_23 = VirtFuncInvoker0< String_t* >::Invoke(3 /* System.String System.Object::ToString() */, (RuntimeObject *)L_22);
		V_4 = (String_t*)L_23;
		goto IL_005d;
	}

IL_005d:
	{
		String_t* L_24 = V_4;
		return (String_t*)L_24;
	}
}
// System.String UnityEngine._AndroidJNIHelper::GetSignature<System.Double>(System.Object[])
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR String_t* _AndroidJNIHelper_GetSignature_TisDouble_t42821932CB52DE2057E685D0E1AF3DE5033D2181_mD09A1E6993B600273E5DA6DD5A610B0A45E10035_gshared (ObjectU5BU5D_tC1F4EE0DB0B7300255F5FD4AF64FE4C585CF5ADE* ___args0, const RuntimeMethod* method)
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&StringBuilder_t_il2cpp_TypeInfo_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Type_t_il2cpp_TypeInfo_var);
		s_Il2CppMethodInitialized = true;
	}
	StringBuilder_t * V_0 = NULL;
	ObjectU5BU5D_tC1F4EE0DB0B7300255F5FD4AF64FE4C585CF5ADE* V_1 = NULL;
	int32_t V_2 = 0;
	RuntimeObject * V_3 = NULL;
	String_t* V_4 = NULL;
	{
		StringBuilder_t * L_0 = (StringBuilder_t *)il2cpp_codegen_object_new(StringBuilder_t_il2cpp_TypeInfo_var);
		StringBuilder__ctor_m5A81DE19E748F748E19FF13FB6FFD2547F9212D9(L_0, /*hidden argument*/NULL);
		V_0 = (StringBuilder_t *)L_0;
		StringBuilder_t * L_1 = V_0;
		NullCheck((StringBuilder_t *)L_1);
		StringBuilder_t * L_2;
		L_2 = StringBuilder_Append_m1ADA3C16E40BF253BCDB5F9579B4DBA9C3E5B22E((StringBuilder_t *)L_1, (Il2CppChar)((int32_t)40), /*hidden argument*/NULL);
		ObjectU5BU5D_tC1F4EE0DB0B7300255F5FD4AF64FE4C585CF5ADE* L_3 = ___args0;
		V_1 = (ObjectU5BU5D_tC1F4EE0DB0B7300255F5FD4AF64FE4C585CF5ADE*)L_3;
		V_2 = (int32_t)0;
		goto IL_002e;
	}

IL_0017:
	{
		ObjectU5BU5D_tC1F4EE0DB0B7300255F5FD4AF64FE4C585CF5ADE* L_4 = V_1;
		int32_t L_5 = V_2;
		NullCheck(L_4);
		int32_t L_6 = L_5;
		RuntimeObject * L_7 = (L_4)->GetAt(static_cast<il2cpp_array_size_t>(L_6));
		V_3 = (RuntimeObject *)L_7;
		StringBuilder_t * L_8 = V_0;
		RuntimeObject * L_9 = V_3;
		String_t* L_10;
		L_10 = _AndroidJNIHelper_GetSignature_m4A272D66518BF9A4C746B02B91AAB1361293232C((RuntimeObject *)L_9, /*hidden argument*/NULL);
		NullCheck((StringBuilder_t *)L_8);
		StringBuilder_t * L_11;
		L_11 = StringBuilder_Append_mD02AB0C74C6F55E3E330818C77EC147E22096FB1((StringBuilder_t *)L_8, (String_t*)L_10, /*hidden argument*/NULL);
		int32_t L_12 = V_2;
		V_2 = (int32_t)((int32_t)il2cpp_codegen_add((int32_t)L_12, (int32_t)1));
	}

IL_002e:
	{
		int32_t L_13 = V_2;
		ObjectU5BU5D_tC1F4EE0DB0B7300255F5FD4AF64FE4C585CF5ADE* L_14 = V_1;
		NullCheck(L_14);
		if ((((int32_t)L_13) < ((int32_t)((int32_t)((int32_t)(((RuntimeArray*)L_14)->max_length))))))
		{
			goto IL_0017;
		}
	}
	{
		StringBuilder_t * L_15 = V_0;
		NullCheck((StringBuilder_t *)L_15);
		StringBuilder_t * L_16;
		L_16 = StringBuilder_Append_m1ADA3C16E40BF253BCDB5F9579B4DBA9C3E5B22E((StringBuilder_t *)L_15, (Il2CppChar)((int32_t)41), /*hidden argument*/NULL);
		StringBuilder_t * L_17 = V_0;
		RuntimeTypeHandle_tC33965ADA3E041E0C94AF05E5CB527B56482CEF9  L_18 = { reinterpret_cast<intptr_t> (IL2CPP_RGCTX_TYPE(method->rgctx_data, 0)) };
		IL2CPP_RUNTIME_CLASS_INIT(Type_t_il2cpp_TypeInfo_var);
		Type_t * L_19;
		L_19 = Type_GetTypeFromHandle_m8BB57524FF7F9DB1803BC561D2B3A4DBACEB385E((RuntimeTypeHandle_tC33965ADA3E041E0C94AF05E5CB527B56482CEF9 )L_18, /*hidden argument*/NULL);
		String_t* L_20;
		L_20 = _AndroidJNIHelper_GetSignature_m4A272D66518BF9A4C746B02B91AAB1361293232C((RuntimeObject *)L_19, /*hidden argument*/NULL);
		NullCheck((StringBuilder_t *)L_17);
		StringBuilder_t * L_21;
		L_21 = StringBuilder_Append_mD02AB0C74C6F55E3E330818C77EC147E22096FB1((StringBuilder_t *)L_17, (String_t*)L_20, /*hidden argument*/NULL);
		StringBuilder_t * L_22 = V_0;
		NullCheck((RuntimeObject *)L_22);
		String_t* L_23;
		L_23 = VirtFuncInvoker0< String_t* >::Invoke(3 /* System.String System.Object::ToString() */, (RuntimeObject *)L_22);
		V_4 = (String_t*)L_23;
		goto IL_005d;
	}

IL_005d:
	{
		String_t* L_24 = V_4;
		return (String_t*)L_24;
	}
}
// System.String UnityEngine._AndroidJNIHelper::GetSignature<System.Int16>(System.Object[])
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR String_t* _AndroidJNIHelper_GetSignature_TisInt16_tD0F031114106263BB459DA1F099FF9F42691295A_m53EA03473D7F4C2525577E0D9E0999F78F5E7F7B_gshared (ObjectU5BU5D_tC1F4EE0DB0B7300255F5FD4AF64FE4C585CF5ADE* ___args0, const RuntimeMethod* method)
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&StringBuilder_t_il2cpp_TypeInfo_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Type_t_il2cpp_TypeInfo_var);
		s_Il2CppMethodInitialized = true;
	}
	StringBuilder_t * V_0 = NULL;
	ObjectU5BU5D_tC1F4EE0DB0B7300255F5FD4AF64FE4C585CF5ADE* V_1 = NULL;
	int32_t V_2 = 0;
	RuntimeObject * V_3 = NULL;
	String_t* V_4 = NULL;
	{
		StringBuilder_t * L_0 = (StringBuilder_t *)il2cpp_codegen_object_new(StringBuilder_t_il2cpp_TypeInfo_var);
		StringBuilder__ctor_m5A81DE19E748F748E19FF13FB6FFD2547F9212D9(L_0, /*hidden argument*/NULL);
		V_0 = (StringBuilder_t *)L_0;
		StringBuilder_t * L_1 = V_0;
		NullCheck((StringBuilder_t *)L_1);
		StringBuilder_t * L_2;
		L_2 = StringBuilder_Append_m1ADA3C16E40BF253BCDB5F9579B4DBA9C3E5B22E((StringBuilder_t *)L_1, (Il2CppChar)((int32_t)40), /*hidden argument*/NULL);
		ObjectU5BU5D_tC1F4EE0DB0B7300255F5FD4AF64FE4C585CF5ADE* L_3 = ___args0;
		V_1 = (ObjectU5BU5D_tC1F4EE0DB0B7300255F5FD4AF64FE4C585CF5ADE*)L_3;
		V_2 = (int32_t)0;
		goto IL_002e;
	}

IL_0017:
	{
		ObjectU5BU5D_tC1F4EE0DB0B7300255F5FD4AF64FE4C585CF5ADE* L_4 = V_1;
		int32_t L_5 = V_2;
		NullCheck(L_4);
		int32_t L_6 = L_5;
		RuntimeObject * L_7 = (L_4)->GetAt(static_cast<il2cpp_array_size_t>(L_6));
		V_3 = (RuntimeObject *)L_7;
		StringBuilder_t * L_8 = V_0;
		RuntimeObject * L_9 = V_3;
		String_t* L_10;
		L_10 = _AndroidJNIHelper_GetSignature_m4A272D66518BF9A4C746B02B91AAB1361293232C((RuntimeObject *)L_9, /*hidden argument*/NULL);
		NullCheck((StringBuilder_t *)L_8);
		StringBuilder_t * L_11;
		L_11 = StringBuilder_Append_mD02AB0C74C6F55E3E330818C77EC147E22096FB1((StringBuilder_t *)L_8, (String_t*)L_10, /*hidden argument*/NULL);
		int32_t L_12 = V_2;
		V_2 = (int32_t)((int32_t)il2cpp_codegen_add((int32_t)L_12, (int32_t)1));
	}

IL_002e:
	{
		int32_t L_13 = V_2;
		ObjectU5BU5D_tC1F4EE0DB0B7300255F5FD4AF64FE4C585CF5ADE* L_14 = V_1;
		NullCheck(L_14);
		if ((((int32_t)L_13) < ((int32_t)((int32_t)((int32_t)(((RuntimeArray*)L_14)->max_length))))))
		{
			goto IL_0017;
		}
	}
	{
		StringBuilder_t * L_15 = V_0;
		NullCheck((StringBuilder_t *)L_15);
		StringBuilder_t * L_16;
		L_16 = StringBuilder_Append_m1ADA3C16E40BF253BCDB5F9579B4DBA9C3E5B22E((StringBuilder_t *)L_15, (Il2CppChar)((int32_t)41), /*hidden argument*/NULL);
		StringBuilder_t * L_17 = V_0;
		RuntimeTypeHandle_tC33965ADA3E041E0C94AF05E5CB527B56482CEF9  L_18 = { reinterpret_cast<intptr_t> (IL2CPP_RGCTX_TYPE(method->rgctx_data, 0)) };
		IL2CPP_RUNTIME_CLASS_INIT(Type_t_il2cpp_TypeInfo_var);
		Type_t * L_19;
		L_19 = Type_GetTypeFromHandle_m8BB57524FF7F9DB1803BC561D2B3A4DBACEB385E((RuntimeTypeHandle_tC33965ADA3E041E0C94AF05E5CB527B56482CEF9 )L_18, /*hidden argument*/NULL);
		String_t* L_20;
		L_20 = _AndroidJNIHelper_GetSignature_m4A272D66518BF9A4C746B02B91AAB1361293232C((RuntimeObject *)L_19, /*hidden argument*/NULL);
		NullCheck((StringBuilder_t *)L_17);
		StringBuilder_t * L_21;
		L_21 = StringBuilder_Append_mD02AB0C74C6F55E3E330818C77EC147E22096FB1((StringBuilder_t *)L_17, (String_t*)L_20, /*hidden argument*/NULL);
		StringBuilder_t * L_22 = V_0;
		NullCheck((RuntimeObject *)L_22);
		String_t* L_23;
		L_23 = VirtFuncInvoker0< String_t* >::Invoke(3 /* System.String System.Object::ToString() */, (RuntimeObject *)L_22);
		V_4 = (String_t*)L_23;
		goto IL_005d;
	}

IL_005d:
	{
		String_t* L_24 = V_4;
		return (String_t*)L_24;
	}
}
// System.String UnityEngine._AndroidJNIHelper::GetSignature<System.Int32>(System.Object[])
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR String_t* _AndroidJNIHelper_GetSignature_TisInt32_tFDE5F8CD43D10453F6A2E0C77FE48C6CC7009046_m83D9133FDC0884534CE97F82ED983AC5AE9465CA_gshared (ObjectU5BU5D_tC1F4EE0DB0B7300255F5FD4AF64FE4C585CF5ADE* ___args0, const RuntimeMethod* method)
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&StringBuilder_t_il2cpp_TypeInfo_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Type_t_il2cpp_TypeInfo_var);
		s_Il2CppMethodInitialized = true;
	}
	StringBuilder_t * V_0 = NULL;
	ObjectU5BU5D_tC1F4EE0DB0B7300255F5FD4AF64FE4C585CF5ADE* V_1 = NULL;
	int32_t V_2 = 0;
	RuntimeObject * V_3 = NULL;
	String_t* V_4 = NULL;
	{
		StringBuilder_t * L_0 = (StringBuilder_t *)il2cpp_codegen_object_new(StringBuilder_t_il2cpp_TypeInfo_var);
		StringBuilder__ctor_m5A81DE19E748F748E19FF13FB6FFD2547F9212D9(L_0, /*hidden argument*/NULL);
		V_0 = (StringBuilder_t *)L_0;
		StringBuilder_t * L_1 = V_0;
		NullCheck((StringBuilder_t *)L_1);
		StringBuilder_t * L_2;
		L_2 = StringBuilder_Append_m1ADA3C16E40BF253BCDB5F9579B4DBA9C3E5B22E((StringBuilder_t *)L_1, (Il2CppChar)((int32_t)40), /*hidden argument*/NULL);
		ObjectU5BU5D_tC1F4EE0DB0B7300255F5FD4AF64FE4C585CF5ADE* L_3 = ___args0;
		V_1 = (ObjectU5BU5D_tC1F4EE0DB0B7300255F5FD4AF64FE4C585CF5ADE*)L_3;
		V_2 = (int32_t)0;
		goto IL_002e;
	}

IL_0017:
	{
		ObjectU5BU5D_tC1F4EE0DB0B7300255F5FD4AF64FE4C585CF5ADE* L_4 = V_1;
		int32_t L_5 = V_2;
		NullCheck(L_4);
		int32_t L_6 = L_5;
		RuntimeObject * L_7 = (L_4)->GetAt(static_cast<il2cpp_array_size_t>(L_6));
		V_3 = (RuntimeObject *)L_7;
		StringBuilder_t * L_8 = V_0;
		RuntimeObject * L_9 = V_3;
		String_t* L_10;
		L_10 = _AndroidJNIHelper_GetSignature_m4A272D66518BF9A4C746B02B91AAB1361293232C((RuntimeObject *)L_9, /*hidden argument*/NULL);
		NullCheck((StringBuilder_t *)L_8);
		StringBuilder_t * L_11;
		L_11 = StringBuilder_Append_mD02AB0C74C6F55E3E330818C77EC147E22096FB1((StringBuilder_t *)L_8, (String_t*)L_10, /*hidden argument*/NULL);
		int32_t L_12 = V_2;
		V_2 = (int32_t)((int32_t)il2cpp_codegen_add((int32_t)L_12, (int32_t)1));
	}

IL_002e:
	{
		int32_t L_13 = V_2;
		ObjectU5BU5D_tC1F4EE0DB0B7300255F5FD4AF64FE4C585CF5ADE* L_14 = V_1;
		NullCheck(L_14);
		if ((((int32_t)L_13) < ((int32_t)((int32_t)((int32_t)(((RuntimeArray*)L_14)->max_length))))))
		{
			goto IL_0017;
		}
	}
	{
		StringBuilder_t * L_15 = V_0;
		NullCheck((StringBuilder_t *)L_15);
		StringBuilder_t * L_16;
		L_16 = StringBuilder_Append_m1ADA3C16E40BF253BCDB5F9579B4DBA9C3E5B22E((StringBuilder_t *)L_15, (Il2CppChar)((int32_t)41), /*hidden argument*/NULL);
		StringBuilder_t * L_17 = V_0;
		RuntimeTypeHandle_tC33965ADA3E041E0C94AF05E5CB527B56482CEF9  L_18 = { reinterpret_cast<intptr_t> (IL2CPP_RGCTX_TYPE(method->rgctx_data, 0)) };
		IL2CPP_RUNTIME_CLASS_INIT(Type_t_il2cpp_TypeInfo_var);
		Type_t * L_19;
		L_19 = Type_GetTypeFromHandle_m8BB57524FF7F9DB1803BC561D2B3A4DBACEB385E((RuntimeTypeHandle_tC33965ADA3E041E0C94AF05E5CB527B56482CEF9 )L_18, /*hidden argument*/NULL);
		String_t* L_20;
		L_20 = _AndroidJNIHelper_GetSignature_m4A272D66518BF9A4C746B02B91AAB1361293232C((RuntimeObject *)L_19, /*hidden argument*/NULL);
		NullCheck((StringBuilder_t *)L_17);
		StringBuilder_t * L_21;
		L_21 = StringBuilder_Append_mD02AB0C74C6F55E3E330818C77EC147E22096FB1((StringBuilder_t *)L_17, (String_t*)L_20, /*hidden argument*/NULL);
		StringBuilder_t * L_22 = V_0;
		NullCheck((RuntimeObject *)L_22);
		String_t* L_23;
		L_23 = VirtFuncInvoker0< String_t* >::Invoke(3 /* System.String System.Object::ToString() */, (RuntimeObject *)L_22);
		V_4 = (String_t*)L_23;
		goto IL_005d;
	}

IL_005d:
	{
		String_t* L_24 = V_4;
		return (String_t*)L_24;
	}
}
// System.String UnityEngine._AndroidJNIHelper::GetSignature<System.Int64>(System.Object[])
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR String_t* _AndroidJNIHelper_GetSignature_TisInt64_t378EE0D608BD3107E77238E85F30D2BBD46981F3_m413740B31E01EB314EE0D3A2B1CF91DAD24A9659_gshared (ObjectU5BU5D_tC1F4EE0DB0B7300255F5FD4AF64FE4C585CF5ADE* ___args0, const RuntimeMethod* method)
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&StringBuilder_t_il2cpp_TypeInfo_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Type_t_il2cpp_TypeInfo_var);
		s_Il2CppMethodInitialized = true;
	}
	StringBuilder_t * V_0 = NULL;
	ObjectU5BU5D_tC1F4EE0DB0B7300255F5FD4AF64FE4C585CF5ADE* V_1 = NULL;
	int32_t V_2 = 0;
	RuntimeObject * V_3 = NULL;
	String_t* V_4 = NULL;
	{
		StringBuilder_t * L_0 = (StringBuilder_t *)il2cpp_codegen_object_new(StringBuilder_t_il2cpp_TypeInfo_var);
		StringBuilder__ctor_m5A81DE19E748F748E19FF13FB6FFD2547F9212D9(L_0, /*hidden argument*/NULL);
		V_0 = (StringBuilder_t *)L_0;
		StringBuilder_t * L_1 = V_0;
		NullCheck((StringBuilder_t *)L_1);
		StringBuilder_t * L_2;
		L_2 = StringBuilder_Append_m1ADA3C16E40BF253BCDB5F9579B4DBA9C3E5B22E((StringBuilder_t *)L_1, (Il2CppChar)((int32_t)40), /*hidden argument*/NULL);
		ObjectU5BU5D_tC1F4EE0DB0B7300255F5FD4AF64FE4C585CF5ADE* L_3 = ___args0;
		V_1 = (ObjectU5BU5D_tC1F4EE0DB0B7300255F5FD4AF64FE4C585CF5ADE*)L_3;
		V_2 = (int32_t)0;
		goto IL_002e;
	}

IL_0017:
	{
		ObjectU5BU5D_tC1F4EE0DB0B7300255F5FD4AF64FE4C585CF5ADE* L_4 = V_1;
		int32_t L_5 = V_2;
		NullCheck(L_4);
		int32_t L_6 = L_5;
		RuntimeObject * L_7 = (L_4)->GetAt(static_cast<il2cpp_array_size_t>(L_6));
		V_3 = (RuntimeObject *)L_7;
		StringBuilder_t * L_8 = V_0;
		RuntimeObject * L_9 = V_3;
		String_t* L_10;
		L_10 = _AndroidJNIHelper_GetSignature_m4A272D66518BF9A4C746B02B91AAB1361293232C((RuntimeObject *)L_9, /*hidden argument*/NULL);
		NullCheck((StringBuilder_t *)L_8);
		StringBuilder_t * L_11;
		L_11 = StringBuilder_Append_mD02AB0C74C6F55E3E330818C77EC147E22096FB1((StringBuilder_t *)L_8, (String_t*)L_10, /*hidden argument*/NULL);
		int32_t L_12 = V_2;
		V_2 = (int32_t)((int32_t)il2cpp_codegen_add((int32_t)L_12, (int32_t)1));
	}

IL_002e:
	{
		int32_t L_13 = V_2;
		ObjectU5BU5D_tC1F4EE0DB0B7300255F5FD4AF64FE4C585CF5ADE* L_14 = V_1;
		NullCheck(L_14);
		if ((((int32_t)L_13) < ((int32_t)((int32_t)((int32_t)(((RuntimeArray*)L_14)->max_length))))))
		{
			goto IL_0017;
		}
	}
	{
		StringBuilder_t * L_15 = V_0;
		NullCheck((StringBuilder_t *)L_15);
		StringBuilder_t * L_16;
		L_16 = StringBuilder_Append_m1ADA3C16E40BF253BCDB5F9579B4DBA9C3E5B22E((StringBuilder_t *)L_15, (Il2CppChar)((int32_t)41), /*hidden argument*/NULL);
		StringBuilder_t * L_17 = V_0;
		RuntimeTypeHandle_tC33965ADA3E041E0C94AF05E5CB527B56482CEF9  L_18 = { reinterpret_cast<intptr_t> (IL2CPP_RGCTX_TYPE(method->rgctx_data, 0)) };
		IL2CPP_RUNTIME_CLASS_INIT(Type_t_il2cpp_TypeInfo_var);
		Type_t * L_19;
		L_19 = Type_GetTypeFromHandle_m8BB57524FF7F9DB1803BC561D2B3A4DBACEB385E((RuntimeTypeHandle_tC33965ADA3E041E0C94AF05E5CB527B56482CEF9 )L_18, /*hidden argument*/NULL);
		String_t* L_20;
		L_20 = _AndroidJNIHelper_GetSignature_m4A272D66518BF9A4C746B02B91AAB1361293232C((RuntimeObject *)L_19, /*hidden argument*/NULL);
		NullCheck((StringBuilder_t *)L_17);
		StringBuilder_t * L_21;
		L_21 = StringBuilder_Append_mD02AB0C74C6F55E3E330818C77EC147E22096FB1((StringBuilder_t *)L_17, (String_t*)L_20, /*hidden argument*/NULL);
		StringBuilder_t * L_22 = V_0;
		NullCheck((RuntimeObject *)L_22);
		String_t* L_23;
		L_23 = VirtFuncInvoker0< String_t* >::Invoke(3 /* System.String System.Object::ToString() */, (RuntimeObject *)L_22);
		V_4 = (String_t*)L_23;
		goto IL_005d;
	}

IL_005d:
	{
		String_t* L_24 = V_4;
		return (String_t*)L_24;
	}
}
// System.String UnityEngine._AndroidJNIHelper::GetSignature<System.Object>(System.Object[])
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR String_t* _AndroidJNIHelper_GetSignature_TisRuntimeObject_mC6BEA8EDE34CA523E26ACA072A4E246C7FF6DB25_gshared (ObjectU5BU5D_tC1F4EE0DB0B7300255F5FD4AF64FE4C585CF5ADE* ___args0, const RuntimeMethod* method)
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&StringBuilder_t_il2cpp_TypeInfo_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Type_t_il2cpp_TypeInfo_var);
		s_Il2CppMethodInitialized = true;
	}
	StringBuilder_t * V_0 = NULL;
	ObjectU5BU5D_tC1F4EE0DB0B7300255F5FD4AF64FE4C585CF5ADE* V_1 = NULL;
	int32_t V_2 = 0;
	RuntimeObject * V_3 = NULL;
	String_t* V_4 = NULL;
	{
		StringBuilder_t * L_0 = (StringBuilder_t *)il2cpp_codegen_object_new(StringBuilder_t_il2cpp_TypeInfo_var);
		StringBuilder__ctor_m5A81DE19E748F748E19FF13FB6FFD2547F9212D9(L_0, /*hidden argument*/NULL);
		V_0 = (StringBuilder_t *)L_0;
		StringBuilder_t * L_1 = V_0;
		NullCheck((StringBuilder_t *)L_1);
		StringBuilder_t * L_2;
		L_2 = StringBuilder_Append_m1ADA3C16E40BF253BCDB5F9579B4DBA9C3E5B22E((StringBuilder_t *)L_1, (Il2CppChar)((int32_t)40), /*hidden argument*/NULL);
		ObjectU5BU5D_tC1F4EE0DB0B7300255F5FD4AF64FE4C585CF5ADE* L_3 = ___args0;
		V_1 = (ObjectU5BU5D_tC1F4EE0DB0B7300255F5FD4AF64FE4C585CF5ADE*)L_3;
		V_2 = (int32_t)0;
		goto IL_002e;
	}

IL_0017:
	{
		ObjectU5BU5D_tC1F4EE0DB0B7300255F5FD4AF64FE4C585CF5ADE* L_4 = V_1;
		int32_t L_5 = V_2;
		NullCheck(L_4);
		int32_t L_6 = L_5;
		RuntimeObject * L_7 = (L_4)->GetAt(static_cast<il2cpp_array_size_t>(L_6));
		V_3 = (RuntimeObject *)L_7;
		StringBuilder_t * L_8 = V_0;
		RuntimeObject * L_9 = V_3;
		String_t* L_10;
		L_10 = _AndroidJNIHelper_GetSignature_m4A272D66518BF9A4C746B02B91AAB1361293232C((RuntimeObject *)L_9, /*hidden argument*/NULL);
		NullCheck((StringBuilder_t *)L_8);
		StringBuilder_t * L_11;
		L_11 = StringBuilder_Append_mD02AB0C74C6F55E3E330818C77EC147E22096FB1((StringBuilder_t *)L_8, (String_t*)L_10, /*hidden argument*/NULL);
		int32_t L_12 = V_2;
		V_2 = (int32_t)((int32_t)il2cpp_codegen_add((int32_t)L_12, (int32_t)1));
	}

IL_002e:
	{
		int32_t L_13 = V_2;
		ObjectU5BU5D_tC1F4EE0DB0B7300255F5FD4AF64FE4C585CF5ADE* L_14 = V_1;
		NullCheck(L_14);
		if ((((int32_t)L_13) < ((int32_t)((int32_t)((int32_t)(((RuntimeArray*)L_14)->max_length))))))
		{
			goto IL_0017;
		}
	}
	{
		StringBuilder_t * L_15 = V_0;
		NullCheck((StringBuilder_t *)L_15);
		StringBuilder_t * L_16;
		L_16 = StringBuilder_Append_m1ADA3C16E40BF253BCDB5F9579B4DBA9C3E5B22E((StringBuilder_t *)L_15, (Il2CppChar)((int32_t)41), /*hidden argument*/NULL);
		StringBuilder_t * L_17 = V_0;
		RuntimeTypeHandle_tC33965ADA3E041E0C94AF05E5CB527B56482CEF9  L_18 = { reinterpret_cast<intptr_t> (IL2CPP_RGCTX_TYPE(method->rgctx_data, 0)) };
		IL2CPP_RUNTIME_CLASS_INIT(Type_t_il2cpp_TypeInfo_var);
		Type_t * L_19;
		L_19 = Type_GetTypeFromHandle_m8BB57524FF7F9DB1803BC561D2B3A4DBACEB385E((RuntimeTypeHandle_tC33965ADA3E041E0C94AF05E5CB527B56482CEF9 )L_18, /*hidden argument*/NULL);
		String_t* L_20;
		L_20 = _AndroidJNIHelper_GetSignature_m4A272D66518BF9A4C746B02B91AAB1361293232C((RuntimeObject *)L_19, /*hidden argument*/NULL);
		NullCheck((StringBuilder_t *)L_17);
		StringBuilder_t * L_21;
		L_21 = StringBuilder_Append_mD02AB0C74C6F55E3E330818C77EC147E22096FB1((StringBuilder_t *)L_17, (String_t*)L_20, /*hidden argument*/NULL);
		StringBuilder_t * L_22 = V_0;
		NullCheck((RuntimeObject *)L_22);
		String_t* L_23;
		L_23 = VirtFuncInvoker0< String_t* >::Invoke(3 /* System.String System.Object::ToString() */, (RuntimeObject *)L_22);
		V_4 = (String_t*)L_23;
		goto IL_005d;
	}

IL_005d:
	{
		String_t* L_24 = V_4;
		return (String_t*)L_24;
	}
}
// System.String UnityEngine._AndroidJNIHelper::GetSignature<System.SByte>(System.Object[])
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR String_t* _AndroidJNIHelper_GetSignature_TisSByte_t928712DD662DC29BA4FAAE8CE2230AFB23447F0B_mA275B45366DA25AFB161A011BC8F1888F54B0BF2_gshared (ObjectU5BU5D_tC1F4EE0DB0B7300255F5FD4AF64FE4C585CF5ADE* ___args0, const RuntimeMethod* method)
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&StringBuilder_t_il2cpp_TypeInfo_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Type_t_il2cpp_TypeInfo_var);
		s_Il2CppMethodInitialized = true;
	}
	StringBuilder_t * V_0 = NULL;
	ObjectU5BU5D_tC1F4EE0DB0B7300255F5FD4AF64FE4C585CF5ADE* V_1 = NULL;
	int32_t V_2 = 0;
	RuntimeObject * V_3 = NULL;
	String_t* V_4 = NULL;
	{
		StringBuilder_t * L_0 = (StringBuilder_t *)il2cpp_codegen_object_new(StringBuilder_t_il2cpp_TypeInfo_var);
		StringBuilder__ctor_m5A81DE19E748F748E19FF13FB6FFD2547F9212D9(L_0, /*hidden argument*/NULL);
		V_0 = (StringBuilder_t *)L_0;
		StringBuilder_t * L_1 = V_0;
		NullCheck((StringBuilder_t *)L_1);
		StringBuilder_t * L_2;
		L_2 = StringBuilder_Append_m1ADA3C16E40BF253BCDB5F9579B4DBA9C3E5B22E((StringBuilder_t *)L_1, (Il2CppChar)((int32_t)40), /*hidden argument*/NULL);
		ObjectU5BU5D_tC1F4EE0DB0B7300255F5FD4AF64FE4C585CF5ADE* L_3 = ___args0;
		V_1 = (ObjectU5BU5D_tC1F4EE0DB0B7300255F5FD4AF64FE4C585CF5ADE*)L_3;
		V_2 = (int32_t)0;
		goto IL_002e;
	}

IL_0017:
	{
		ObjectU5BU5D_tC1F4EE0DB0B7300255F5FD4AF64FE4C585CF5ADE* L_4 = V_1;
		int32_t L_5 = V_2;
		NullCheck(L_4);
		int32_t L_6 = L_5;
		RuntimeObject * L_7 = (L_4)->GetAt(static_cast<il2cpp_array_size_t>(L_6));
		V_3 = (RuntimeObject *)L_7;
		StringBuilder_t * L_8 = V_0;
		RuntimeObject * L_9 = V_3;
		String_t* L_10;
		L_10 = _AndroidJNIHelper_GetSignature_m4A272D66518BF9A4C746B02B91AAB1361293232C((RuntimeObject *)L_9, /*hidden argument*/NULL);
		NullCheck((StringBuilder_t *)L_8);
		StringBuilder_t * L_11;
		L_11 = StringBuilder_Append_mD02AB0C74C6F55E3E330818C77EC147E22096FB1((StringBuilder_t *)L_8, (String_t*)L_10, /*hidden argument*/NULL);
		int32_t L_12 = V_2;
		V_2 = (int32_t)((int32_t)il2cpp_codegen_add((int32_t)L_12, (int32_t)1));
	}

IL_002e:
	{
		int32_t L_13 = V_2;
		ObjectU5BU5D_tC1F4EE0DB0B7300255F5FD4AF64FE4C585CF5ADE* L_14 = V_1;
		NullCheck(L_14);
		if ((((int32_t)L_13) < ((int32_t)((int32_t)((int32_t)(((RuntimeArray*)L_14)->max_length))))))
		{
			goto IL_0017;
		}
	}
	{
		StringBuilder_t * L_15 = V_0;
		NullCheck((StringBuilder_t *)L_15);
		StringBuilder_t * L_16;
		L_16 = StringBuilder_Append_m1ADA3C16E40BF253BCDB5F9579B4DBA9C3E5B22E((StringBuilder_t *)L_15, (Il2CppChar)((int32_t)41), /*hidden argument*/NULL);
		StringBuilder_t * L_17 = V_0;
		RuntimeTypeHandle_tC33965ADA3E041E0C94AF05E5CB527B56482CEF9  L_18 = { reinterpret_cast<intptr_t> (IL2CPP_RGCTX_TYPE(method->rgctx_data, 0)) };
		IL2CPP_RUNTIME_CLASS_INIT(Type_t_il2cpp_TypeInfo_var);
		Type_t * L_19;
		L_19 = Type_GetTypeFromHandle_m8BB57524FF7F9DB1803BC561D2B3A4DBACEB385E((RuntimeTypeHandle_tC33965ADA3E041E0C94AF05E5CB527B56482CEF9 )L_18, /*hidden argument*/NULL);
		String_t* L_20;
		L_20 = _AndroidJNIHelper_GetSignature_m4A272D66518BF9A4C746B02B91AAB1361293232C((RuntimeObject *)L_19, /*hidden argument*/NULL);
		NullCheck((StringBuilder_t *)L_17);
		StringBuilder_t * L_21;
		L_21 = StringBuilder_Append_mD02AB0C74C6F55E3E330818C77EC147E22096FB1((StringBuilder_t *)L_17, (String_t*)L_20, /*hidden argument*/NULL);
		StringBuilder_t * L_22 = V_0;
		NullCheck((RuntimeObject *)L_22);
		String_t* L_23;
		L_23 = VirtFuncInvoker0< String_t* >::Invoke(3 /* System.String System.Object::ToString() */, (RuntimeObject *)L_22);
		V_4 = (String_t*)L_23;
		goto IL_005d;
	}

IL_005d:
	{
		String_t* L_24 = V_4;
		return (String_t*)L_24;
	}
}
// System.String UnityEngine._AndroidJNIHelper::GetSignature<System.Single>(System.Object[])
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR String_t* _AndroidJNIHelper_GetSignature_TisSingle_tE07797BA3C98D4CA9B5A19413C19A76688AB899E_m82A85440F4B906A83640CA6939D1BC0D1BDEB2C3_gshared (ObjectU5BU5D_tC1F4EE0DB0B7300255F5FD4AF64FE4C585CF5ADE* ___args0, const RuntimeMethod* method)
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&StringBuilder_t_il2cpp_TypeInfo_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Type_t_il2cpp_TypeInfo_var);
		s_Il2CppMethodInitialized = true;
	}
	StringBuilder_t * V_0 = NULL;
	ObjectU5BU5D_tC1F4EE0DB0B7300255F5FD4AF64FE4C585CF5ADE* V_1 = NULL;
	int32_t V_2 = 0;
	RuntimeObject * V_3 = NULL;
	String_t* V_4 = NULL;
	{
		StringBuilder_t * L_0 = (StringBuilder_t *)il2cpp_codegen_object_new(StringBuilder_t_il2cpp_TypeInfo_var);
		StringBuilder__ctor_m5A81DE19E748F748E19FF13FB6FFD2547F9212D9(L_0, /*hidden argument*/NULL);
		V_0 = (StringBuilder_t *)L_0;
		StringBuilder_t * L_1 = V_0;
		NullCheck((StringBuilder_t *)L_1);
		StringBuilder_t * L_2;
		L_2 = StringBuilder_Append_m1ADA3C16E40BF253BCDB5F9579B4DBA9C3E5B22E((StringBuilder_t *)L_1, (Il2CppChar)((int32_t)40), /*hidden argument*/NULL);
		ObjectU5BU5D_tC1F4EE0DB0B7300255F5FD4AF64FE4C585CF5ADE* L_3 = ___args0;
		V_1 = (ObjectU5BU5D_tC1F4EE0DB0B7300255F5FD4AF64FE4C585CF5ADE*)L_3;
		V_2 = (int32_t)0;
		goto IL_002e;
	}

IL_0017:
	{
		ObjectU5BU5D_tC1F4EE0DB0B7300255F5FD4AF64FE4C585CF5ADE* L_4 = V_1;
		int32_t L_5 = V_2;
		NullCheck(L_4);
		int32_t L_6 = L_5;
		RuntimeObject * L_7 = (L_4)->GetAt(static_cast<il2cpp_array_size_t>(L_6));
		V_3 = (RuntimeObject *)L_7;
		StringBuilder_t * L_8 = V_0;
		RuntimeObject * L_9 = V_3;
		String_t* L_10;
		L_10 = _AndroidJNIHelper_GetSignature_m4A272D66518BF9A4C746B02B91AAB1361293232C((RuntimeObject *)L_9, /*hidden argument*/NULL);
		NullCheck((StringBuilder_t *)L_8);
		StringBuilder_t * L_11;
		L_11 = StringBuilder_Append_mD02AB0C74C6F55E3E330818C77EC147E22096FB1((StringBuilder_t *)L_8, (String_t*)L_10, /*hidden argument*/NULL);
		int32_t L_12 = V_2;
		V_2 = (int32_t)((int32_t)il2cpp_codegen_add((int32_t)L_12, (int32_t)1));
	}

IL_002e:
	{
		int32_t L_13 = V_2;
		ObjectU5BU5D_tC1F4EE0DB0B7300255F5FD4AF64FE4C585CF5ADE* L_14 = V_1;
		NullCheck(L_14);
		if ((((int32_t)L_13) < ((int32_t)((int32_t)((int32_t)(((RuntimeArray*)L_14)->max_length))))))
		{
			goto IL_0017;
		}
	}
	{
		StringBuilder_t * L_15 = V_0;
		NullCheck((StringBuilder_t *)L_15);
		StringBuilder_t * L_16;
		L_16 = StringBuilder_Append_m1ADA3C16E40BF253BCDB5F9579B4DBA9C3E5B22E((StringBuilder_t *)L_15, (Il2CppChar)((int32_t)41), /*hidden argument*/NULL);
		StringBuilder_t * L_17 = V_0;
		RuntimeTypeHandle_tC33965ADA3E041E0C94AF05E5CB527B56482CEF9  L_18 = { reinterpret_cast<intptr_t> (IL2CPP_RGCTX_TYPE(method->rgctx_data, 0)) };
		IL2CPP_RUNTIME_CLASS_INIT(Type_t_il2cpp_TypeInfo_var);
		Type_t * L_19;
		L_19 = Type_GetTypeFromHandle_m8BB57524FF7F9DB1803BC561D2B3A4DBACEB385E((RuntimeTypeHandle_tC33965ADA3E041E0C94AF05E5CB527B56482CEF9 )L_18, /*hidden argument*/NULL);
		String_t* L_20;
		L_20 = _AndroidJNIHelper_GetSignature_m4A272D66518BF9A4C746B02B91AAB1361293232C((RuntimeObject *)L_19, /*hidden argument*/NULL);
		NullCheck((StringBuilder_t *)L_17);
		StringBuilder_t * L_21;
		L_21 = StringBuilder_Append_mD02AB0C74C6F55E3E330818C77EC147E22096FB1((StringBuilder_t *)L_17, (String_t*)L_20, /*hidden argument*/NULL);
		StringBuilder_t * L_22 = V_0;
		NullCheck((RuntimeObject *)L_22);
		String_t* L_23;
		L_23 = VirtFuncInvoker0< String_t* >::Invoke(3 /* System.String System.Object::ToString() */, (RuntimeObject *)L_22);
		V_4 = (String_t*)L_23;
		goto IL_005d;
	}

IL_005d:
	{
		String_t* L_24 = V_4;
		return (String_t*)L_24;
	}
}
// System.Linq.Expressions.Expression[] System.Dynamic.DynamicObject/MetaDynamic::BuildCallArgs<System.Object>(TBinder,System.Linq.Expressions.Expression[],System.Linq.Expressions.Expression,System.Linq.Expressions.Expression)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR ExpressionU5BU5D_t4F1F138488EBD58837D142B40E0E4EEFC607EA63* MetaDynamic_BuildCallArgs_TisRuntimeObject_m725C3D9ACE1141A1A87582DB48E02B04DB35FD1C_gshared (RuntimeObject * ___binder0, ExpressionU5BU5D_t4F1F138488EBD58837D142B40E0E4EEFC607EA63* ___parameters1, Expression_t30A004209C10C2D9A9785B2F74EEED431A4D4660 * ___arg02, Expression_t30A004209C10C2D9A9785B2F74EEED431A4D4660 * ___arg13, const RuntimeMethod* method)
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&ExpressionU5BU5D_t4F1F138488EBD58837D142B40E0E4EEFC607EA63_il2cpp_TypeInfo_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&MetaDynamic_t774AF4A12F33149209C1FA08022AB0EE951BFB7C_il2cpp_TypeInfo_var);
		s_Il2CppMethodInitialized = true;
	}
	{
		ExpressionU5BU5D_t4F1F138488EBD58837D142B40E0E4EEFC607EA63* L_0 = ___parameters1;
		IL2CPP_RUNTIME_CLASS_INIT(MetaDynamic_t774AF4A12F33149209C1FA08022AB0EE951BFB7C_il2cpp_TypeInfo_var);
		ExpressionU5BU5D_t4F1F138488EBD58837D142B40E0E4EEFC607EA63* L_1 = ((MetaDynamic_t774AF4A12F33149209C1FA08022AB0EE951BFB7C_StaticFields*)il2cpp_codegen_static_fields_for(MetaDynamic_t774AF4A12F33149209C1FA08022AB0EE951BFB7C_il2cpp_TypeInfo_var))->get_s_noArgs_5();
		if ((((RuntimeObject*)(ExpressionU5BU5D_t4F1F138488EBD58837D142B40E0E4EEFC607EA63*)L_0) == ((RuntimeObject*)(ExpressionU5BU5D_t4F1F138488EBD58837D142B40E0E4EEFC607EA63*)L_1)))
		{
			goto IL_0037;
		}
	}
	{
		Expression_t30A004209C10C2D9A9785B2F74EEED431A4D4660 * L_2 = ___arg13;
		if (L_2)
		{
			goto IL_001f;
		}
	}
	{
		ExpressionU5BU5D_t4F1F138488EBD58837D142B40E0E4EEFC607EA63* L_3 = (ExpressionU5BU5D_t4F1F138488EBD58837D142B40E0E4EEFC607EA63*)(ExpressionU5BU5D_t4F1F138488EBD58837D142B40E0E4EEFC607EA63*)SZArrayNew(ExpressionU5BU5D_t4F1F138488EBD58837D142B40E0E4EEFC607EA63_il2cpp_TypeInfo_var, (uint32_t)2);
		ExpressionU5BU5D_t4F1F138488EBD58837D142B40E0E4EEFC607EA63* L_4 = (ExpressionU5BU5D_t4F1F138488EBD58837D142B40E0E4EEFC607EA63*)L_3;
		RuntimeObject * L_5 = ___binder0;
		IL2CPP_RUNTIME_CLASS_INIT(MetaDynamic_t774AF4A12F33149209C1FA08022AB0EE951BFB7C_il2cpp_TypeInfo_var);
		ConstantExpression_tE22239C4AE815AF9B4647E026E802623F433F0FB * L_6;
		L_6 = ((  ConstantExpression_tE22239C4AE815AF9B4647E026E802623F433F0FB * (*) (RuntimeObject *, const RuntimeMethod*))IL2CPP_RGCTX_METHOD_INFO(method->rgctx_data, 0)->methodPointer)((RuntimeObject *)L_5, /*hidden argument*/IL2CPP_RGCTX_METHOD_INFO(method->rgctx_data, 0));
		NullCheck(L_4);
		ArrayElementTypeCheck (L_4, L_6);
		(L_4)->SetAt(static_cast<il2cpp_array_size_t>(0), (Expression_t30A004209C10C2D9A9785B2F74EEED431A4D4660 *)L_6);
		ExpressionU5BU5D_t4F1F138488EBD58837D142B40E0E4EEFC607EA63* L_7 = (ExpressionU5BU5D_t4F1F138488EBD58837D142B40E0E4EEFC607EA63*)L_4;
		Expression_t30A004209C10C2D9A9785B2F74EEED431A4D4660 * L_8 = ___arg02;
		NullCheck(L_7);
		ArrayElementTypeCheck (L_7, L_8);
		(L_7)->SetAt(static_cast<il2cpp_array_size_t>(1), (Expression_t30A004209C10C2D9A9785B2F74EEED431A4D4660 *)L_8);
		return (ExpressionU5BU5D_t4F1F138488EBD58837D142B40E0E4EEFC607EA63*)L_7;
	}

IL_001f:
	{
		ExpressionU5BU5D_t4F1F138488EBD58837D142B40E0E4EEFC607EA63* L_9 = (ExpressionU5BU5D_t4F1F138488EBD58837D142B40E0E4EEFC607EA63*)(ExpressionU5BU5D_t4F1F138488EBD58837D142B40E0E4EEFC607EA63*)SZArrayNew(ExpressionU5BU5D_t4F1F138488EBD58837D142B40E0E4EEFC607EA63_il2cpp_TypeInfo_var, (uint32_t)3);
		ExpressionU5BU5D_t4F1F138488EBD58837D142B40E0E4EEFC607EA63* L_10 = (ExpressionU5BU5D_t4F1F138488EBD58837D142B40E0E4EEFC607EA63*)L_9;
		RuntimeObject * L_11 = ___binder0;
		IL2CPP_RUNTIME_CLASS_INIT(MetaDynamic_t774AF4A12F33149209C1FA08022AB0EE951BFB7C_il2cpp_TypeInfo_var);
		ConstantExpression_tE22239C4AE815AF9B4647E026E802623F433F0FB * L_12;
		L_12 = ((  ConstantExpression_tE22239C4AE815AF9B4647E026E802623F433F0FB * (*) (RuntimeObject *, const RuntimeMethod*))IL2CPP_RGCTX_METHOD_INFO(method->rgctx_data, 0)->methodPointer)((RuntimeObject *)L_11, /*hidden argument*/IL2CPP_RGCTX_METHOD_INFO(method->rgctx_data, 0));
		NullCheck(L_10);
		ArrayElementTypeCheck (L_10, L_12);
		(L_10)->SetAt(static_cast<il2cpp_array_size_t>(0), (Expression_t30A004209C10C2D9A9785B2F74EEED431A4D4660 *)L_12);
		ExpressionU5BU5D_t4F1F138488EBD58837D142B40E0E4EEFC607EA63* L_13 = (ExpressionU5BU5D_t4F1F138488EBD58837D142B40E0E4EEFC607EA63*)L_10;
		Expression_t30A004209C10C2D9A9785B2F74EEED431A4D4660 * L_14 = ___arg02;
		NullCheck(L_13);
		ArrayElementTypeCheck (L_13, L_14);
		(L_13)->SetAt(static_cast<il2cpp_array_size_t>(1), (Expression_t30A004209C10C2D9A9785B2F74EEED431A4D4660 *)L_14);
		ExpressionU5BU5D_t4F1F138488EBD58837D142B40E0E4EEFC607EA63* L_15 = (ExpressionU5BU5D_t4F1F138488EBD58837D142B40E0E4EEFC607EA63*)L_13;
		Expression_t30A004209C10C2D9A9785B2F74EEED431A4D4660 * L_16 = ___arg13;
		NullCheck(L_15);
		ArrayElementTypeCheck (L_15, L_16);
		(L_15)->SetAt(static_cast<il2cpp_array_size_t>(2), (Expression_t30A004209C10C2D9A9785B2F74EEED431A4D4660 *)L_16);
		return (ExpressionU5BU5D_t4F1F138488EBD58837D142B40E0E4EEFC607EA63*)L_15;
	}

IL_0037:
	{
		Expression_t30A004209C10C2D9A9785B2F74EEED431A4D4660 * L_17 = ___arg13;
		if (L_17)
		{
			goto IL_004a;
		}
	}
	{
		ExpressionU5BU5D_t4F1F138488EBD58837D142B40E0E4EEFC607EA63* L_18 = (ExpressionU5BU5D_t4F1F138488EBD58837D142B40E0E4EEFC607EA63*)(ExpressionU5BU5D_t4F1F138488EBD58837D142B40E0E4EEFC607EA63*)SZArrayNew(ExpressionU5BU5D_t4F1F138488EBD58837D142B40E0E4EEFC607EA63_il2cpp_TypeInfo_var, (uint32_t)1);
		ExpressionU5BU5D_t4F1F138488EBD58837D142B40E0E4EEFC607EA63* L_19 = (ExpressionU5BU5D_t4F1F138488EBD58837D142B40E0E4EEFC607EA63*)L_18;
		RuntimeObject * L_20 = ___binder0;
		IL2CPP_RUNTIME_CLASS_INIT(MetaDynamic_t774AF4A12F33149209C1FA08022AB0EE951BFB7C_il2cpp_TypeInfo_var);
		ConstantExpression_tE22239C4AE815AF9B4647E026E802623F433F0FB * L_21;
		L_21 = ((  ConstantExpression_tE22239C4AE815AF9B4647E026E802623F433F0FB * (*) (RuntimeObject *, const RuntimeMethod*))IL2CPP_RGCTX_METHOD_INFO(method->rgctx_data, 0)->methodPointer)((RuntimeObject *)L_20, /*hidden argument*/IL2CPP_RGCTX_METHOD_INFO(method->rgctx_data, 0));
		NullCheck(L_19);
		ArrayElementTypeCheck (L_19, L_21);
		(L_19)->SetAt(static_cast<il2cpp_array_size_t>(0), (Expression_t30A004209C10C2D9A9785B2F74EEED431A4D4660 *)L_21);
		return (ExpressionU5BU5D_t4F1F138488EBD58837D142B40E0E4EEFC607EA63*)L_19;
	}

IL_004a:
	{
		ExpressionU5BU5D_t4F1F138488EBD58837D142B40E0E4EEFC607EA63* L_22 = (ExpressionU5BU5D_t4F1F138488EBD58837D142B40E0E4EEFC607EA63*)(ExpressionU5BU5D_t4F1F138488EBD58837D142B40E0E4EEFC607EA63*)SZArrayNew(ExpressionU5BU5D_t4F1F138488EBD58837D142B40E0E4EEFC607EA63_il2cpp_TypeInfo_var, (uint32_t)2);
		ExpressionU5BU5D_t4F1F138488EBD58837D142B40E0E4EEFC607EA63* L_23 = (ExpressionU5BU5D_t4F1F138488EBD58837D142B40E0E4EEFC607EA63*)L_22;
		RuntimeObject * L_24 = ___binder0;
		IL2CPP_RUNTIME_CLASS_INIT(MetaDynamic_t774AF4A12F33149209C1FA08022AB0EE951BFB7C_il2cpp_TypeInfo_var);
		ConstantExpression_tE22239C4AE815AF9B4647E026E802623F433F0FB * L_25;
		L_25 = ((  ConstantExpression_tE22239C4AE815AF9B4647E026E802623F433F0FB * (*) (RuntimeObject *, const RuntimeMethod*))IL2CPP_RGCTX_METHOD_INFO(method->rgctx_data, 0)->methodPointer)((RuntimeObject *)L_24, /*hidden argument*/IL2CPP_RGCTX_METHOD_INFO(method->rgctx_data, 0));
		NullCheck(L_23);
		ArrayElementTypeCheck (L_23, L_25);
		(L_23)->SetAt(static_cast<il2cpp_array_size_t>(0), (Expression_t30A004209C10C2D9A9785B2F74EEED431A4D4660 *)L_25);
		ExpressionU5BU5D_t4F1F138488EBD58837D142B40E0E4EEFC607EA63* L_26 = (ExpressionU5BU5D_t4F1F138488EBD58837D142B40E0E4EEFC607EA63*)L_23;
		Expression_t30A004209C10C2D9A9785B2F74EEED431A4D4660 * L_27 = ___arg13;
		NullCheck(L_26);
		ArrayElementTypeCheck (L_26, L_27);
		(L_26)->SetAt(static_cast<il2cpp_array_size_t>(1), (Expression_t30A004209C10C2D9A9785B2F74EEED431A4D4660 *)L_27);
		return (ExpressionU5BU5D_t4F1F138488EBD58837D142B40E0E4EEFC607EA63*)L_26;
	}
}
// System.Dynamic.DynamicMetaObject System.Dynamic.DynamicObject/MetaDynamic::BuildCallMethodWithResult<System.Object>(System.Reflection.MethodInfo,TBinder,System.Linq.Expressions.Expression[],System.Dynamic.DynamicMetaObject,System.Dynamic.DynamicObject/MetaDynamic/Fallback`1<TBinder>)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR DynamicMetaObject_t5279001ADBFAB6EF015CAC54937F4E9F003881C3 * MetaDynamic_BuildCallMethodWithResult_TisRuntimeObject_mF5AF3558271ADF129708AB5FFD1BBB3054DC9E09_gshared (MetaDynamic_t774AF4A12F33149209C1FA08022AB0EE951BFB7C * __this, MethodInfo_t * ___method0, RuntimeObject * ___binder1, ExpressionU5BU5D_t4F1F138488EBD58837D142B40E0E4EEFC607EA63* ___args2, DynamicMetaObject_t5279001ADBFAB6EF015CAC54937F4E9F003881C3 * ___fallbackResult3, Fallback_1_t80F90982EFE3FFA9073E13C782ABA43FD48B7A9A * ___fallbackInvoke4, const RuntimeMethod* method)
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&BindingRestrictions_t03E14FA0517A70DEDA502032CE956595EF6E0DFC_il2cpp_TypeInfo_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&DynamicMetaObject_t5279001ADBFAB6EF015CAC54937F4E9F003881C3_il2cpp_TypeInfo_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&ExpressionU5BU5D_t4F1F138488EBD58837D142B40E0E4EEFC607EA63_il2cpp_TypeInfo_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Expression_t30A004209C10C2D9A9785B2F74EEED431A4D4660_il2cpp_TypeInfo_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&MetaDynamic_t774AF4A12F33149209C1FA08022AB0EE951BFB7C_il2cpp_TypeInfo_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&ObjectU5BU5D_tC1F4EE0DB0B7300255F5FD4AF64FE4C585CF5ADE_0_0_0_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&ParameterExpressionU5BU5D_tCF3EAA6D8556513C4937E1126F65AA08DF4DB147_il2cpp_TypeInfo_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&ReadOnlyCollection_1_get_Item_m61B304E87F7A24CB20EA9565FBC66CB9118FE6D1_RuntimeMethod_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&RuntimeObject_0_0_0_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&TrueReadOnlyCollection_1__ctor_m69554AD79082CEEEE9808387797E4A9C052A1820_RuntimeMethod_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&TrueReadOnlyCollection_1__ctor_mF8FDD857140C35B895099B7D89BFFE4153D771B5_RuntimeMethod_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&TrueReadOnlyCollection_1_t06D7E0A73C830464D87F10A513072796E7172082_il2cpp_TypeInfo_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&TrueReadOnlyCollection_1_tFACBB37A6A09F5303FA9A457A34FAFE7002020A3_il2cpp_TypeInfo_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Type_t_il2cpp_TypeInfo_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Utils_t98C8733198C84566DF6847E887A57D45326CE485_il2cpp_TypeInfo_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&_stringLiteral23114468D04FA2B7A2DA455B545DB914D0A3ED94);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&_stringLiteral5BEFD8CC60A79699B5BB00E37BAC5B62D371E174);
		s_Il2CppMethodInitialized = true;
	}
	ParameterExpression_tA7B24F1DE0F013DA4BD55F76DB43B06DB33D8BEE * V_0 = NULL;
	ParameterExpression_tA7B24F1DE0F013DA4BD55F76DB43B06DB33D8BEE * V_1 = NULL;
	ReadOnlyCollection_1_t7976DDE3F2FC7BAAF4F920193FF1B5BA33CCC2B5 * V_2 = NULL;
	DynamicMetaObject_t5279001ADBFAB6EF015CAC54937F4E9F003881C3 * V_3 = NULL;
	UnaryExpression_t5DE6F6FA2216CDD34DFCFADEB0080CB29326DD62 * V_4 = NULL;
	String_t* V_5 = NULL;
	Expression_t30A004209C10C2D9A9785B2F74EEED431A4D4660 * V_6 = NULL;
	ParameterExpression_tA7B24F1DE0F013DA4BD55F76DB43B06DB33D8BEE * G_B5_0 = NULL;
	int32_t G_B15_0 = 0;
	ExpressionU5BU5D_t4F1F138488EBD58837D142B40E0E4EEFC607EA63* G_B15_1 = NULL;
	ExpressionU5BU5D_t4F1F138488EBD58837D142B40E0E4EEFC607EA63* G_B15_2 = NULL;
	TrueReadOnlyCollection_1_tFACBB37A6A09F5303FA9A457A34FAFE7002020A3 * G_B15_3 = NULL;
	int32_t G_B14_0 = 0;
	ExpressionU5BU5D_t4F1F138488EBD58837D142B40E0E4EEFC607EA63* G_B14_1 = NULL;
	ExpressionU5BU5D_t4F1F138488EBD58837D142B40E0E4EEFC607EA63* G_B14_2 = NULL;
	TrueReadOnlyCollection_1_tFACBB37A6A09F5303FA9A457A34FAFE7002020A3 * G_B14_3 = NULL;
	BinaryExpression_tCD79755962D104E6603B50D89E7F0E41D1D9CA79 * G_B16_0 = NULL;
	int32_t G_B16_1 = 0;
	ExpressionU5BU5D_t4F1F138488EBD58837D142B40E0E4EEFC607EA63* G_B16_2 = NULL;
	ExpressionU5BU5D_t4F1F138488EBD58837D142B40E0E4EEFC607EA63* G_B16_3 = NULL;
	TrueReadOnlyCollection_1_tFACBB37A6A09F5303FA9A457A34FAFE7002020A3 * G_B16_4 = NULL;
	MethodCallExpression_tF8E07995EEDB83A97C356206D651D5EEC72EFFA4 * G_B18_0 = NULL;
	int32_t G_B18_1 = 0;
	ExpressionU5BU5D_t4F1F138488EBD58837D142B40E0E4EEFC607EA63* G_B18_2 = NULL;
	ExpressionU5BU5D_t4F1F138488EBD58837D142B40E0E4EEFC607EA63* G_B18_3 = NULL;
	TrueReadOnlyCollection_1_tFACBB37A6A09F5303FA9A457A34FAFE7002020A3 * G_B18_4 = NULL;
	MethodCallExpression_tF8E07995EEDB83A97C356206D651D5EEC72EFFA4 * G_B17_0 = NULL;
	int32_t G_B17_1 = 0;
	ExpressionU5BU5D_t4F1F138488EBD58837D142B40E0E4EEFC607EA63* G_B17_2 = NULL;
	ExpressionU5BU5D_t4F1F138488EBD58837D142B40E0E4EEFC607EA63* G_B17_3 = NULL;
	TrueReadOnlyCollection_1_tFACBB37A6A09F5303FA9A457A34FAFE7002020A3 * G_B17_4 = NULL;
	DefaultExpression_t3FC1DD4F4C518F7FDF62C04BB3BF78B10D654D46 * G_B19_0 = NULL;
	MethodCallExpression_tF8E07995EEDB83A97C356206D651D5EEC72EFFA4 * G_B19_1 = NULL;
	int32_t G_B19_2 = 0;
	ExpressionU5BU5D_t4F1F138488EBD58837D142B40E0E4EEFC607EA63* G_B19_3 = NULL;
	ExpressionU5BU5D_t4F1F138488EBD58837D142B40E0E4EEFC607EA63* G_B19_4 = NULL;
	TrueReadOnlyCollection_1_tFACBB37A6A09F5303FA9A457A34FAFE7002020A3 * G_B19_5 = NULL;
	{
		MethodInfo_t * L_0 = ___method0;
		NullCheck((MetaDynamic_t774AF4A12F33149209C1FA08022AB0EE951BFB7C *)__this);
		bool L_1;
		L_1 = MetaDynamic_IsOverridden_m23850D35DA8C827538AF468CAE3C139D18A06626((MetaDynamic_t774AF4A12F33149209C1FA08022AB0EE951BFB7C *)__this, (MethodInfo_t *)L_0, /*hidden argument*/NULL);
		if (L_1)
		{
			goto IL_000c;
		}
	}
	{
		DynamicMetaObject_t5279001ADBFAB6EF015CAC54937F4E9F003881C3 * L_2 = ___fallbackResult3;
		return (DynamicMetaObject_t5279001ADBFAB6EF015CAC54937F4E9F003881C3 *)L_2;
	}

IL_000c:
	{
		RuntimeTypeHandle_tC33965ADA3E041E0C94AF05E5CB527B56482CEF9  L_3 = { reinterpret_cast<intptr_t> (RuntimeObject_0_0_0_var) };
		IL2CPP_RUNTIME_CLASS_INIT(Type_t_il2cpp_TypeInfo_var);
		Type_t * L_4;
		L_4 = Type_GetTypeFromHandle_m8BB57524FF7F9DB1803BC561D2B3A4DBACEB385E((RuntimeTypeHandle_tC33965ADA3E041E0C94AF05E5CB527B56482CEF9 )L_3, /*hidden argument*/NULL);
		IL2CPP_RUNTIME_CLASS_INIT(Expression_t30A004209C10C2D9A9785B2F74EEED431A4D4660_il2cpp_TypeInfo_var);
		ParameterExpression_tA7B24F1DE0F013DA4BD55F76DB43B06DB33D8BEE * L_5;
		L_5 = Expression_Parameter_m1613C069AFED7D393811F36BC7F91188D668A333((Type_t *)L_4, (String_t*)NULL, /*hidden argument*/NULL);
		V_0 = (ParameterExpression_tA7B24F1DE0F013DA4BD55F76DB43B06DB33D8BEE *)L_5;
		MethodInfo_t * L_6 = ___method0;
		MethodInfo_t * L_7;
		L_7 = CachedReflectionInfo_get_DynamicObject_TryBinaryOperation_mD0D3151684B0FA6C655BC84F441D7FDFC498AD00(/*hidden argument*/NULL);
		bool L_8;
		L_8 = MethodInfo_op_Inequality_mDE1DAA5D330E9C975AC6423FC2D06862637BE68D((MethodInfo_t *)L_6, (MethodInfo_t *)L_7, /*hidden argument*/NULL);
		if (L_8)
		{
			goto IL_003c;
		}
	}
	{
		RuntimeTypeHandle_tC33965ADA3E041E0C94AF05E5CB527B56482CEF9  L_9 = { reinterpret_cast<intptr_t> (RuntimeObject_0_0_0_var) };
		IL2CPP_RUNTIME_CLASS_INIT(Type_t_il2cpp_TypeInfo_var);
		Type_t * L_10;
		L_10 = Type_GetTypeFromHandle_m8BB57524FF7F9DB1803BC561D2B3A4DBACEB385E((RuntimeTypeHandle_tC33965ADA3E041E0C94AF05E5CB527B56482CEF9 )L_9, /*hidden argument*/NULL);
		IL2CPP_RUNTIME_CLASS_INIT(Expression_t30A004209C10C2D9A9785B2F74EEED431A4D4660_il2cpp_TypeInfo_var);
		ParameterExpression_tA7B24F1DE0F013DA4BD55F76DB43B06DB33D8BEE * L_11;
		L_11 = Expression_Parameter_m1613C069AFED7D393811F36BC7F91188D668A333((Type_t *)L_10, (String_t*)NULL, /*hidden argument*/NULL);
		G_B5_0 = L_11;
		goto IL_004c;
	}

IL_003c:
	{
		RuntimeTypeHandle_tC33965ADA3E041E0C94AF05E5CB527B56482CEF9  L_12 = { reinterpret_cast<intptr_t> (ObjectU5BU5D_tC1F4EE0DB0B7300255F5FD4AF64FE4C585CF5ADE_0_0_0_var) };
		IL2CPP_RUNTIME_CLASS_INIT(Type_t_il2cpp_TypeInfo_var);
		Type_t * L_13;
		L_13 = Type_GetTypeFromHandle_m8BB57524FF7F9DB1803BC561D2B3A4DBACEB385E((RuntimeTypeHandle_tC33965ADA3E041E0C94AF05E5CB527B56482CEF9 )L_12, /*hidden argument*/NULL);
		IL2CPP_RUNTIME_CLASS_INIT(Expression_t30A004209C10C2D9A9785B2F74EEED431A4D4660_il2cpp_TypeInfo_var);
		ParameterExpression_tA7B24F1DE0F013DA4BD55F76DB43B06DB33D8BEE * L_14;
		L_14 = Expression_Parameter_m1613C069AFED7D393811F36BC7F91188D668A333((Type_t *)L_13, (String_t*)NULL, /*hidden argument*/NULL);
		G_B5_0 = L_14;
	}

IL_004c:
	{
		V_1 = (ParameterExpression_tA7B24F1DE0F013DA4BD55F76DB43B06DB33D8BEE *)G_B5_0;
		ExpressionU5BU5D_t4F1F138488EBD58837D142B40E0E4EEFC607EA63* L_15 = ___args2;
		IL2CPP_RUNTIME_CLASS_INIT(MetaDynamic_t774AF4A12F33149209C1FA08022AB0EE951BFB7C_il2cpp_TypeInfo_var);
		ReadOnlyCollection_1_t7976DDE3F2FC7BAAF4F920193FF1B5BA33CCC2B5 * L_16;
		L_16 = MetaDynamic_GetConvertedArgs_m1C2C9220C741DBE95A2DFC7767F1DD02AB432AC9((ExpressionU5BU5D_t4F1F138488EBD58837D142B40E0E4EEFC607EA63*)L_15, /*hidden argument*/NULL);
		V_2 = (ReadOnlyCollection_1_t7976DDE3F2FC7BAAF4F920193FF1B5BA33CCC2B5 *)L_16;
		ParameterExpression_tA7B24F1DE0F013DA4BD55F76DB43B06DB33D8BEE * L_17 = V_0;
		IL2CPP_RUNTIME_CLASS_INIT(BindingRestrictions_t03E14FA0517A70DEDA502032CE956595EF6E0DFC_il2cpp_TypeInfo_var);
		BindingRestrictions_t03E14FA0517A70DEDA502032CE956595EF6E0DFC * L_18 = ((BindingRestrictions_t03E14FA0517A70DEDA502032CE956595EF6E0DFC_StaticFields*)il2cpp_codegen_static_fields_for(BindingRestrictions_t03E14FA0517A70DEDA502032CE956595EF6E0DFC_il2cpp_TypeInfo_var))->get_Empty_0();
		DynamicMetaObject_t5279001ADBFAB6EF015CAC54937F4E9F003881C3 * L_19 = (DynamicMetaObject_t5279001ADBFAB6EF015CAC54937F4E9F003881C3 *)il2cpp_codegen_object_new(DynamicMetaObject_t5279001ADBFAB6EF015CAC54937F4E9F003881C3_il2cpp_TypeInfo_var);
		DynamicMetaObject__ctor_m2851C1E47FD59D49C80E454597607C1F4A8458AA(L_19, (Expression_t30A004209C10C2D9A9785B2F74EEED431A4D4660 *)L_17, (BindingRestrictions_t03E14FA0517A70DEDA502032CE956595EF6E0DFC *)L_18, /*hidden argument*/NULL);
		V_3 = (DynamicMetaObject_t5279001ADBFAB6EF015CAC54937F4E9F003881C3 *)L_19;
		RuntimeObject * L_20 = ___binder1;
		NullCheck((DynamicMetaObjectBinder_t7B24B7AF08AEA7004A4855C632E18CA2E400CA8D *)L_20);
		Type_t * L_21;
		L_21 = VirtFuncInvoker0< Type_t * >::Invoke(6 /* System.Type System.Dynamic.DynamicMetaObjectBinder::get_ReturnType() */, (DynamicMetaObjectBinder_t7B24B7AF08AEA7004A4855C632E18CA2E400CA8D *)L_20);
		RuntimeTypeHandle_tC33965ADA3E041E0C94AF05E5CB527B56482CEF9  L_22 = { reinterpret_cast<intptr_t> (RuntimeObject_0_0_0_var) };
		IL2CPP_RUNTIME_CLASS_INIT(Type_t_il2cpp_TypeInfo_var);
		Type_t * L_23;
		L_23 = Type_GetTypeFromHandle_m8BB57524FF7F9DB1803BC561D2B3A4DBACEB385E((RuntimeTypeHandle_tC33965ADA3E041E0C94AF05E5CB527B56482CEF9 )L_22, /*hidden argument*/NULL);
		bool L_24;
		L_24 = Type_op_Inequality_m6DDC5E923203A79BF505F9275B694AD3FAA36DB0((Type_t *)L_21, (Type_t *)L_23, /*hidden argument*/NULL);
		if (!L_24)
		{
			goto IL_01e4;
		}
	}
	{
		DynamicMetaObject_t5279001ADBFAB6EF015CAC54937F4E9F003881C3 * L_25 = V_3;
		NullCheck((DynamicMetaObject_t5279001ADBFAB6EF015CAC54937F4E9F003881C3 *)L_25);
		Expression_t30A004209C10C2D9A9785B2F74EEED431A4D4660 * L_26;
		L_26 = DynamicMetaObject_get_Expression_m56AEEE5B82DB27F8490D27758D6ECAEC19BE64C2_inline((DynamicMetaObject_t5279001ADBFAB6EF015CAC54937F4E9F003881C3 *)L_25, /*hidden argument*/NULL);
		RuntimeObject * L_27 = ___binder1;
		NullCheck((DynamicMetaObjectBinder_t7B24B7AF08AEA7004A4855C632E18CA2E400CA8D *)L_27);
		Type_t * L_28;
		L_28 = VirtFuncInvoker0< Type_t * >::Invoke(6 /* System.Type System.Dynamic.DynamicMetaObjectBinder::get_ReturnType() */, (DynamicMetaObjectBinder_t7B24B7AF08AEA7004A4855C632E18CA2E400CA8D *)L_27);
		IL2CPP_RUNTIME_CLASS_INIT(Expression_t30A004209C10C2D9A9785B2F74EEED431A4D4660_il2cpp_TypeInfo_var);
		UnaryExpression_t5DE6F6FA2216CDD34DFCFADEB0080CB29326DD62 * L_29;
		L_29 = Expression_Convert_m494826A3729B238263D95E7D7B0E236DE3B1CDA7((Expression_t30A004209C10C2D9A9785B2F74EEED431A4D4660 *)L_26, (Type_t *)L_28, /*hidden argument*/NULL);
		V_4 = (UnaryExpression_t5DE6F6FA2216CDD34DFCFADEB0080CB29326DD62 *)L_29;
		NullCheck((MetaDynamic_t774AF4A12F33149209C1FA08022AB0EE951BFB7C *)__this);
		DynamicObject_t97AD66D9AA9182AA4635DB778C9CE337E5E429D6 * L_30;
		L_30 = MetaDynamic_get_Value_mF3A50AC306B2161D40834CA9313F46A8669DE561((MetaDynamic_t774AF4A12F33149209C1FA08022AB0EE951BFB7C *)__this, /*hidden argument*/NULL);
		NullCheck((RuntimeObject *)L_30);
		Type_t * L_31;
		L_31 = Object_GetType_m571FE8360C10B98C23AAF1F066D92C08CC94F45B((RuntimeObject *)L_30, /*hidden argument*/NULL);
		RuntimeObject * L_32 = ___binder1;
		NullCheck((RuntimeObject *)L_32);
		Type_t * L_33;
		L_33 = Object_GetType_m571FE8360C10B98C23AAF1F066D92C08CC94F45B((RuntimeObject *)L_32, /*hidden argument*/NULL);
		RuntimeObject * L_34 = ___binder1;
		NullCheck((DynamicMetaObjectBinder_t7B24B7AF08AEA7004A4855C632E18CA2E400CA8D *)L_34);
		Type_t * L_35;
		L_35 = VirtFuncInvoker0< Type_t * >::Invoke(6 /* System.Type System.Dynamic.DynamicMetaObjectBinder::get_ReturnType() */, (DynamicMetaObjectBinder_t7B24B7AF08AEA7004A4855C632E18CA2E400CA8D *)L_34);
		String_t* L_36;
		L_36 = Strings_DynamicObjectResultNotAssignable_m3F88B63C924BC2152059FCB50C54C72D73AF6D62((RuntimeObject *)_stringLiteral23114468D04FA2B7A2DA455B545DB914D0A3ED94, (RuntimeObject *)L_31, (RuntimeObject *)L_33, (RuntimeObject *)L_35, /*hidden argument*/NULL);
		V_5 = (String_t*)L_36;
		RuntimeObject * L_37 = ___binder1;
		NullCheck((DynamicMetaObjectBinder_t7B24B7AF08AEA7004A4855C632E18CA2E400CA8D *)L_37);
		Type_t * L_38;
		L_38 = VirtFuncInvoker0< Type_t * >::Invoke(6 /* System.Type System.Dynamic.DynamicMetaObjectBinder::get_ReturnType() */, (DynamicMetaObjectBinder_t7B24B7AF08AEA7004A4855C632E18CA2E400CA8D *)L_37);
		NullCheck((Type_t *)L_38);
		bool L_39;
		L_39 = Type_get_IsValueType_m9CCCB4759C2D5A890096F8DBA66DAAEFE9D913FB((Type_t *)L_38, /*hidden argument*/NULL);
		if (!L_39)
		{
			goto IL_0108;
		}
	}
	{
		RuntimeObject * L_40 = ___binder1;
		NullCheck((DynamicMetaObjectBinder_t7B24B7AF08AEA7004A4855C632E18CA2E400CA8D *)L_40);
		Type_t * L_41;
		L_41 = VirtFuncInvoker0< Type_t * >::Invoke(6 /* System.Type System.Dynamic.DynamicMetaObjectBinder::get_ReturnType() */, (DynamicMetaObjectBinder_t7B24B7AF08AEA7004A4855C632E18CA2E400CA8D *)L_40);
		Type_t * L_42;
		L_42 = Nullable_GetUnderlyingType_mC5699E7E11E1AFE25365CAB564A48F0193318629((Type_t *)L_41, /*hidden argument*/NULL);
		IL2CPP_RUNTIME_CLASS_INIT(Type_t_il2cpp_TypeInfo_var);
		bool L_43;
		L_43 = Type_op_Equality_mA438719A1FDF103C7BBBB08AEF564E7FAEEA0046((Type_t *)L_42, (Type_t *)NULL, /*hidden argument*/NULL);
		if (!L_43)
		{
			goto IL_0108;
		}
	}
	{
		DynamicMetaObject_t5279001ADBFAB6EF015CAC54937F4E9F003881C3 * L_44 = V_3;
		NullCheck((DynamicMetaObject_t5279001ADBFAB6EF015CAC54937F4E9F003881C3 *)L_44);
		Expression_t30A004209C10C2D9A9785B2F74EEED431A4D4660 * L_45;
		L_45 = DynamicMetaObject_get_Expression_m56AEEE5B82DB27F8490D27758D6ECAEC19BE64C2_inline((DynamicMetaObject_t5279001ADBFAB6EF015CAC54937F4E9F003881C3 *)L_44, /*hidden argument*/NULL);
		RuntimeObject * L_46 = ___binder1;
		NullCheck((DynamicMetaObjectBinder_t7B24B7AF08AEA7004A4855C632E18CA2E400CA8D *)L_46);
		Type_t * L_47;
		L_47 = VirtFuncInvoker0< Type_t * >::Invoke(6 /* System.Type System.Dynamic.DynamicMetaObjectBinder::get_ReturnType() */, (DynamicMetaObjectBinder_t7B24B7AF08AEA7004A4855C632E18CA2E400CA8D *)L_46);
		IL2CPP_RUNTIME_CLASS_INIT(Expression_t30A004209C10C2D9A9785B2F74EEED431A4D4660_il2cpp_TypeInfo_var);
		TypeBinaryExpression_t802702BB83CA4CE99BAE599EAD7D58FDF8C32185 * L_48;
		L_48 = Expression_TypeIs_m963DA9C402453E3373C87492847B02551E2305F3((Expression_t30A004209C10C2D9A9785B2F74EEED431A4D4660 *)L_45, (Type_t *)L_47, /*hidden argument*/NULL);
		V_6 = (Expression_t30A004209C10C2D9A9785B2F74EEED431A4D4660 *)L_48;
		goto IL_0135;
	}

IL_0108:
	{
		DynamicMetaObject_t5279001ADBFAB6EF015CAC54937F4E9F003881C3 * L_49 = V_3;
		NullCheck((DynamicMetaObject_t5279001ADBFAB6EF015CAC54937F4E9F003881C3 *)L_49);
		Expression_t30A004209C10C2D9A9785B2F74EEED431A4D4660 * L_50;
		L_50 = DynamicMetaObject_get_Expression_m56AEEE5B82DB27F8490D27758D6ECAEC19BE64C2_inline((DynamicMetaObject_t5279001ADBFAB6EF015CAC54937F4E9F003881C3 *)L_49, /*hidden argument*/NULL);
		IL2CPP_RUNTIME_CLASS_INIT(Utils_t98C8733198C84566DF6847E887A57D45326CE485_il2cpp_TypeInfo_var);
		ConstantExpression_tE22239C4AE815AF9B4647E026E802623F433F0FB * L_51 = ((Utils_t98C8733198C84566DF6847E887A57D45326CE485_StaticFields*)il2cpp_codegen_static_fields_for(Utils_t98C8733198C84566DF6847E887A57D45326CE485_il2cpp_TypeInfo_var))->get_Null_27();
		IL2CPP_RUNTIME_CLASS_INIT(Expression_t30A004209C10C2D9A9785B2F74EEED431A4D4660_il2cpp_TypeInfo_var);
		BinaryExpression_tCD79755962D104E6603B50D89E7F0E41D1D9CA79 * L_52;
		L_52 = Expression_Equal_m587E6FD4AF53E3A711A242A985E9F8D73F9BDC61((Expression_t30A004209C10C2D9A9785B2F74EEED431A4D4660 *)L_50, (Expression_t30A004209C10C2D9A9785B2F74EEED431A4D4660 *)L_51, /*hidden argument*/NULL);
		DynamicMetaObject_t5279001ADBFAB6EF015CAC54937F4E9F003881C3 * L_53 = V_3;
		NullCheck((DynamicMetaObject_t5279001ADBFAB6EF015CAC54937F4E9F003881C3 *)L_53);
		Expression_t30A004209C10C2D9A9785B2F74EEED431A4D4660 * L_54;
		L_54 = DynamicMetaObject_get_Expression_m56AEEE5B82DB27F8490D27758D6ECAEC19BE64C2_inline((DynamicMetaObject_t5279001ADBFAB6EF015CAC54937F4E9F003881C3 *)L_53, /*hidden argument*/NULL);
		RuntimeObject * L_55 = ___binder1;
		NullCheck((DynamicMetaObjectBinder_t7B24B7AF08AEA7004A4855C632E18CA2E400CA8D *)L_55);
		Type_t * L_56;
		L_56 = VirtFuncInvoker0< Type_t * >::Invoke(6 /* System.Type System.Dynamic.DynamicMetaObjectBinder::get_ReturnType() */, (DynamicMetaObjectBinder_t7B24B7AF08AEA7004A4855C632E18CA2E400CA8D *)L_55);
		TypeBinaryExpression_t802702BB83CA4CE99BAE599EAD7D58FDF8C32185 * L_57;
		L_57 = Expression_TypeIs_m963DA9C402453E3373C87492847B02551E2305F3((Expression_t30A004209C10C2D9A9785B2F74EEED431A4D4660 *)L_54, (Type_t *)L_56, /*hidden argument*/NULL);
		BinaryExpression_tCD79755962D104E6603B50D89E7F0E41D1D9CA79 * L_58;
		L_58 = Expression_OrElse_m47274255A9C9A23CF1218A24E13CF598D1E17AB4((Expression_t30A004209C10C2D9A9785B2F74EEED431A4D4660 *)L_52, (Expression_t30A004209C10C2D9A9785B2F74EEED431A4D4660 *)L_57, /*hidden argument*/NULL);
		V_6 = (Expression_t30A004209C10C2D9A9785B2F74EEED431A4D4660 *)L_58;
	}

IL_0135:
	{
		Expression_t30A004209C10C2D9A9785B2F74EEED431A4D4660 * L_59 = V_6;
		UnaryExpression_t5DE6F6FA2216CDD34DFCFADEB0080CB29326DD62 * L_60 = V_4;
		ConstructorInfo_t449AEC508DCA508EE46784C4F2716545488ACD5B * L_61;
		L_61 = CachedReflectionInfo_get_InvalidCastException_Ctor_String_m51EF84D08DFE096EAD86BF57E76444963BBA2965(/*hidden argument*/NULL);
		ExpressionU5BU5D_t4F1F138488EBD58837D142B40E0E4EEFC607EA63* L_62 = (ExpressionU5BU5D_t4F1F138488EBD58837D142B40E0E4EEFC607EA63*)(ExpressionU5BU5D_t4F1F138488EBD58837D142B40E0E4EEFC607EA63*)SZArrayNew(ExpressionU5BU5D_t4F1F138488EBD58837D142B40E0E4EEFC607EA63_il2cpp_TypeInfo_var, (uint32_t)1);
		ExpressionU5BU5D_t4F1F138488EBD58837D142B40E0E4EEFC607EA63* L_63 = (ExpressionU5BU5D_t4F1F138488EBD58837D142B40E0E4EEFC607EA63*)L_62;
		MethodInfo_t * L_64;
		L_64 = CachedReflectionInfo_get_String_Format_String_ObjectArray_mC9ACA19786E7FBA880BD7943B6A8388E11970581(/*hidden argument*/NULL);
		String_t* L_65 = V_5;
		IL2CPP_RUNTIME_CLASS_INIT(Expression_t30A004209C10C2D9A9785B2F74EEED431A4D4660_il2cpp_TypeInfo_var);
		ConstantExpression_tE22239C4AE815AF9B4647E026E802623F433F0FB * L_66;
		L_66 = Expression_Constant_mEEA1BB10F0EE0D668C36114629468DA1D840601C((RuntimeObject *)L_65, /*hidden argument*/NULL);
		RuntimeTypeHandle_tC33965ADA3E041E0C94AF05E5CB527B56482CEF9  L_67 = { reinterpret_cast<intptr_t> (RuntimeObject_0_0_0_var) };
		IL2CPP_RUNTIME_CLASS_INIT(Type_t_il2cpp_TypeInfo_var);
		Type_t * L_68;
		L_68 = Type_GetTypeFromHandle_m8BB57524FF7F9DB1803BC561D2B3A4DBACEB385E((RuntimeTypeHandle_tC33965ADA3E041E0C94AF05E5CB527B56482CEF9 )L_67, /*hidden argument*/NULL);
		ExpressionU5BU5D_t4F1F138488EBD58837D142B40E0E4EEFC607EA63* L_69 = (ExpressionU5BU5D_t4F1F138488EBD58837D142B40E0E4EEFC607EA63*)(ExpressionU5BU5D_t4F1F138488EBD58837D142B40E0E4EEFC607EA63*)SZArrayNew(ExpressionU5BU5D_t4F1F138488EBD58837D142B40E0E4EEFC607EA63_il2cpp_TypeInfo_var, (uint32_t)1);
		ExpressionU5BU5D_t4F1F138488EBD58837D142B40E0E4EEFC607EA63* L_70 = (ExpressionU5BU5D_t4F1F138488EBD58837D142B40E0E4EEFC607EA63*)L_69;
		DynamicMetaObject_t5279001ADBFAB6EF015CAC54937F4E9F003881C3 * L_71 = V_3;
		NullCheck((DynamicMetaObject_t5279001ADBFAB6EF015CAC54937F4E9F003881C3 *)L_71);
		Expression_t30A004209C10C2D9A9785B2F74EEED431A4D4660 * L_72;
		L_72 = DynamicMetaObject_get_Expression_m56AEEE5B82DB27F8490D27758D6ECAEC19BE64C2_inline((DynamicMetaObject_t5279001ADBFAB6EF015CAC54937F4E9F003881C3 *)L_71, /*hidden argument*/NULL);
		IL2CPP_RUNTIME_CLASS_INIT(Utils_t98C8733198C84566DF6847E887A57D45326CE485_il2cpp_TypeInfo_var);
		ConstantExpression_tE22239C4AE815AF9B4647E026E802623F433F0FB * L_73 = ((Utils_t98C8733198C84566DF6847E887A57D45326CE485_StaticFields*)il2cpp_codegen_static_fields_for(Utils_t98C8733198C84566DF6847E887A57D45326CE485_il2cpp_TypeInfo_var))->get_Null_27();
		BinaryExpression_tCD79755962D104E6603B50D89E7F0E41D1D9CA79 * L_74;
		L_74 = Expression_Equal_m587E6FD4AF53E3A711A242A985E9F8D73F9BDC61((Expression_t30A004209C10C2D9A9785B2F74EEED431A4D4660 *)L_72, (Expression_t30A004209C10C2D9A9785B2F74EEED431A4D4660 *)L_73, /*hidden argument*/NULL);
		ConstantExpression_tE22239C4AE815AF9B4647E026E802623F433F0FB * L_75;
		L_75 = Expression_Constant_mEEA1BB10F0EE0D668C36114629468DA1D840601C((RuntimeObject *)_stringLiteral5BEFD8CC60A79699B5BB00E37BAC5B62D371E174, /*hidden argument*/NULL);
		DynamicMetaObject_t5279001ADBFAB6EF015CAC54937F4E9F003881C3 * L_76 = V_3;
		NullCheck((DynamicMetaObject_t5279001ADBFAB6EF015CAC54937F4E9F003881C3 *)L_76);
		Expression_t30A004209C10C2D9A9785B2F74EEED431A4D4660 * L_77;
		L_77 = DynamicMetaObject_get_Expression_m56AEEE5B82DB27F8490D27758D6ECAEC19BE64C2_inline((DynamicMetaObject_t5279001ADBFAB6EF015CAC54937F4E9F003881C3 *)L_76, /*hidden argument*/NULL);
		MethodInfo_t * L_78;
		L_78 = CachedReflectionInfo_get_Object_GetType_m9FC2ACE7ABCFEC3CA351CEF7F054C2CEFB7614F7(/*hidden argument*/NULL);
		MethodCallExpression_tF8E07995EEDB83A97C356206D651D5EEC72EFFA4 * L_79;
		L_79 = Expression_Call_m5E98322EFB58C6947149191AFC7B609BF220AC4B((Expression_t30A004209C10C2D9A9785B2F74EEED431A4D4660 *)L_77, (MethodInfo_t *)L_78, /*hidden argument*/NULL);
		RuntimeTypeHandle_tC33965ADA3E041E0C94AF05E5CB527B56482CEF9  L_80 = { reinterpret_cast<intptr_t> (RuntimeObject_0_0_0_var) };
		Type_t * L_81;
		L_81 = Type_GetTypeFromHandle_m8BB57524FF7F9DB1803BC561D2B3A4DBACEB385E((RuntimeTypeHandle_tC33965ADA3E041E0C94AF05E5CB527B56482CEF9 )L_80, /*hidden argument*/NULL);
		ConditionalExpression_t74C60793A382D6FC191C590A353984ED63ED3D4A * L_82;
		L_82 = Expression_Condition_mDAAB02AA8FE6525ECAE36CAF26695ADBFA738260((Expression_t30A004209C10C2D9A9785B2F74EEED431A4D4660 *)L_74, (Expression_t30A004209C10C2D9A9785B2F74EEED431A4D4660 *)L_75, (Expression_t30A004209C10C2D9A9785B2F74EEED431A4D4660 *)L_79, (Type_t *)L_81, /*hidden argument*/NULL);
		NullCheck(L_70);
		ArrayElementTypeCheck (L_70, L_82);
		(L_70)->SetAt(static_cast<il2cpp_array_size_t>(0), (Expression_t30A004209C10C2D9A9785B2F74EEED431A4D4660 *)L_82);
		TrueReadOnlyCollection_1_t06D7E0A73C830464D87F10A513072796E7172082 * L_83 = (TrueReadOnlyCollection_1_t06D7E0A73C830464D87F10A513072796E7172082 *)il2cpp_codegen_object_new(TrueReadOnlyCollection_1_t06D7E0A73C830464D87F10A513072796E7172082_il2cpp_TypeInfo_var);
		TrueReadOnlyCollection_1__ctor_m69554AD79082CEEEE9808387797E4A9C052A1820(L_83, (ExpressionU5BU5D_t4F1F138488EBD58837D142B40E0E4EEFC607EA63*)L_70, /*hidden argument*/TrueReadOnlyCollection_1__ctor_m69554AD79082CEEEE9808387797E4A9C052A1820_RuntimeMethod_var);
		NewArrayExpression_tE4702BA06AA0479BA675A5087BB6E2342F921F0A * L_84;
		L_84 = Expression_NewArrayInit_m4E25520959297D32D03E19147E1812530858109E((Type_t *)L_68, (RuntimeObject*)L_83, /*hidden argument*/NULL);
		MethodCallExpression_tF8E07995EEDB83A97C356206D651D5EEC72EFFA4 * L_85;
		L_85 = Expression_Call_m7F8784CDCEA8B62A5019ED5FA8990E932D869E24((MethodInfo_t *)L_64, (Expression_t30A004209C10C2D9A9785B2F74EEED431A4D4660 *)L_66, (Expression_t30A004209C10C2D9A9785B2F74EEED431A4D4660 *)L_84, /*hidden argument*/NULL);
		NullCheck(L_63);
		ArrayElementTypeCheck (L_63, L_85);
		(L_63)->SetAt(static_cast<il2cpp_array_size_t>(0), (Expression_t30A004209C10C2D9A9785B2F74EEED431A4D4660 *)L_85);
		TrueReadOnlyCollection_1_t06D7E0A73C830464D87F10A513072796E7172082 * L_86 = (TrueReadOnlyCollection_1_t06D7E0A73C830464D87F10A513072796E7172082 *)il2cpp_codegen_object_new(TrueReadOnlyCollection_1_t06D7E0A73C830464D87F10A513072796E7172082_il2cpp_TypeInfo_var);
		TrueReadOnlyCollection_1__ctor_m69554AD79082CEEEE9808387797E4A9C052A1820(L_86, (ExpressionU5BU5D_t4F1F138488EBD58837D142B40E0E4EEFC607EA63*)L_63, /*hidden argument*/TrueReadOnlyCollection_1__ctor_m69554AD79082CEEEE9808387797E4A9C052A1820_RuntimeMethod_var);
		NewExpression_tCC2B6EAD4868381D56BB8B1AA4C5267F8A620987 * L_87;
		L_87 = Expression_New_mE2FB5DD0768AAF8AAC45C32C8430C01F079A46C4((ConstructorInfo_t449AEC508DCA508EE46784C4F2716545488ACD5B *)L_61, (RuntimeObject*)L_86, /*hidden argument*/NULL);
		RuntimeObject * L_88 = ___binder1;
		NullCheck((DynamicMetaObjectBinder_t7B24B7AF08AEA7004A4855C632E18CA2E400CA8D *)L_88);
		Type_t * L_89;
		L_89 = VirtFuncInvoker0< Type_t * >::Invoke(6 /* System.Type System.Dynamic.DynamicMetaObjectBinder::get_ReturnType() */, (DynamicMetaObjectBinder_t7B24B7AF08AEA7004A4855C632E18CA2E400CA8D *)L_88);
		UnaryExpression_t5DE6F6FA2216CDD34DFCFADEB0080CB29326DD62 * L_90;
		L_90 = Expression_Throw_mEDE9895093C52A20A1A895C44CE7F73D7F0C7A01((Expression_t30A004209C10C2D9A9785B2F74EEED431A4D4660 *)L_87, (Type_t *)L_89, /*hidden argument*/NULL);
		RuntimeObject * L_91 = ___binder1;
		NullCheck((DynamicMetaObjectBinder_t7B24B7AF08AEA7004A4855C632E18CA2E400CA8D *)L_91);
		Type_t * L_92;
		L_92 = VirtFuncInvoker0< Type_t * >::Invoke(6 /* System.Type System.Dynamic.DynamicMetaObjectBinder::get_ReturnType() */, (DynamicMetaObjectBinder_t7B24B7AF08AEA7004A4855C632E18CA2E400CA8D *)L_91);
		ConditionalExpression_t74C60793A382D6FC191C590A353984ED63ED3D4A * L_93;
		L_93 = Expression_Condition_mDAAB02AA8FE6525ECAE36CAF26695ADBFA738260((Expression_t30A004209C10C2D9A9785B2F74EEED431A4D4660 *)L_59, (Expression_t30A004209C10C2D9A9785B2F74EEED431A4D4660 *)L_60, (Expression_t30A004209C10C2D9A9785B2F74EEED431A4D4660 *)L_90, (Type_t *)L_92, /*hidden argument*/NULL);
		DynamicMetaObject_t5279001ADBFAB6EF015CAC54937F4E9F003881C3 * L_94 = V_3;
		NullCheck((DynamicMetaObject_t5279001ADBFAB6EF015CAC54937F4E9F003881C3 *)L_94);
		BindingRestrictions_t03E14FA0517A70DEDA502032CE956595EF6E0DFC * L_95;
		L_95 = DynamicMetaObject_get_Restrictions_mE04FE62E32906462628D87A3341521ABFADC63C5_inline((DynamicMetaObject_t5279001ADBFAB6EF015CAC54937F4E9F003881C3 *)L_94, /*hidden argument*/NULL);
		DynamicMetaObject_t5279001ADBFAB6EF015CAC54937F4E9F003881C3 * L_96 = (DynamicMetaObject_t5279001ADBFAB6EF015CAC54937F4E9F003881C3 *)il2cpp_codegen_object_new(DynamicMetaObject_t5279001ADBFAB6EF015CAC54937F4E9F003881C3_il2cpp_TypeInfo_var);
		DynamicMetaObject__ctor_m2851C1E47FD59D49C80E454597607C1F4A8458AA(L_96, (Expression_t30A004209C10C2D9A9785B2F74EEED431A4D4660 *)L_93, (BindingRestrictions_t03E14FA0517A70DEDA502032CE956595EF6E0DFC *)L_95, /*hidden argument*/NULL);
		V_3 = (DynamicMetaObject_t5279001ADBFAB6EF015CAC54937F4E9F003881C3 *)L_96;
	}

IL_01e4:
	{
		Fallback_1_t80F90982EFE3FFA9073E13C782ABA43FD48B7A9A * L_97 = ___fallbackInvoke4;
		if (!L_97)
		{
			goto IL_01f3;
		}
	}
	{
		Fallback_1_t80F90982EFE3FFA9073E13C782ABA43FD48B7A9A * L_98 = ___fallbackInvoke4;
		RuntimeObject * L_99 = ___binder1;
		DynamicMetaObject_t5279001ADBFAB6EF015CAC54937F4E9F003881C3 * L_100 = V_3;
		NullCheck((Fallback_1_t80F90982EFE3FFA9073E13C782ABA43FD48B7A9A *)L_98);
		DynamicMetaObject_t5279001ADBFAB6EF015CAC54937F4E9F003881C3 * L_101;
		L_101 = ((  DynamicMetaObject_t5279001ADBFAB6EF015CAC54937F4E9F003881C3 * (*) (Fallback_1_t80F90982EFE3FFA9073E13C782ABA43FD48B7A9A *, MetaDynamic_t774AF4A12F33149209C1FA08022AB0EE951BFB7C *, RuntimeObject *, DynamicMetaObject_t5279001ADBFAB6EF015CAC54937F4E9F003881C3 *, const RuntimeMethod*))IL2CPP_RGCTX_METHOD_INFO(method->rgctx_data, 1)->methodPointer)((Fallback_1_t80F90982EFE3FFA9073E13C782ABA43FD48B7A9A *)L_98, (MetaDynamic_t774AF4A12F33149209C1FA08022AB0EE951BFB7C *)__this, (RuntimeObject *)L_99, (DynamicMetaObject_t5279001ADBFAB6EF015CAC54937F4E9F003881C3 *)L_100, /*hidden argument*/IL2CPP_RGCTX_METHOD_INFO(method->rgctx_data, 1));
		V_3 = (DynamicMetaObject_t5279001ADBFAB6EF015CAC54937F4E9F003881C3 *)L_101;
	}

IL_01f3:
	{
		ParameterExpressionU5BU5D_tCF3EAA6D8556513C4937E1126F65AA08DF4DB147* L_102 = (ParameterExpressionU5BU5D_tCF3EAA6D8556513C4937E1126F65AA08DF4DB147*)(ParameterExpressionU5BU5D_tCF3EAA6D8556513C4937E1126F65AA08DF4DB147*)SZArrayNew(ParameterExpressionU5BU5D_tCF3EAA6D8556513C4937E1126F65AA08DF4DB147_il2cpp_TypeInfo_var, (uint32_t)2);
		ParameterExpressionU5BU5D_tCF3EAA6D8556513C4937E1126F65AA08DF4DB147* L_103 = (ParameterExpressionU5BU5D_tCF3EAA6D8556513C4937E1126F65AA08DF4DB147*)L_102;
		ParameterExpression_tA7B24F1DE0F013DA4BD55F76DB43B06DB33D8BEE * L_104 = V_0;
		NullCheck(L_103);
		ArrayElementTypeCheck (L_103, L_104);
		(L_103)->SetAt(static_cast<il2cpp_array_size_t>(0), (ParameterExpression_tA7B24F1DE0F013DA4BD55F76DB43B06DB33D8BEE *)L_104);
		ParameterExpressionU5BU5D_tCF3EAA6D8556513C4937E1126F65AA08DF4DB147* L_105 = (ParameterExpressionU5BU5D_tCF3EAA6D8556513C4937E1126F65AA08DF4DB147*)L_103;
		ParameterExpression_tA7B24F1DE0F013DA4BD55F76DB43B06DB33D8BEE * L_106 = V_1;
		NullCheck(L_105);
		ArrayElementTypeCheck (L_105, L_106);
		(L_105)->SetAt(static_cast<il2cpp_array_size_t>(1), (ParameterExpression_tA7B24F1DE0F013DA4BD55F76DB43B06DB33D8BEE *)L_106);
		TrueReadOnlyCollection_1_tFACBB37A6A09F5303FA9A457A34FAFE7002020A3 * L_107 = (TrueReadOnlyCollection_1_tFACBB37A6A09F5303FA9A457A34FAFE7002020A3 *)il2cpp_codegen_object_new(TrueReadOnlyCollection_1_tFACBB37A6A09F5303FA9A457A34FAFE7002020A3_il2cpp_TypeInfo_var);
		TrueReadOnlyCollection_1__ctor_mF8FDD857140C35B895099B7D89BFFE4153D771B5(L_107, (ParameterExpressionU5BU5D_tCF3EAA6D8556513C4937E1126F65AA08DF4DB147*)L_105, /*hidden argument*/TrueReadOnlyCollection_1__ctor_mF8FDD857140C35B895099B7D89BFFE4153D771B5_RuntimeMethod_var);
		ExpressionU5BU5D_t4F1F138488EBD58837D142B40E0E4EEFC607EA63* L_108 = (ExpressionU5BU5D_t4F1F138488EBD58837D142B40E0E4EEFC607EA63*)(ExpressionU5BU5D_t4F1F138488EBD58837D142B40E0E4EEFC607EA63*)SZArrayNew(ExpressionU5BU5D_t4F1F138488EBD58837D142B40E0E4EEFC607EA63_il2cpp_TypeInfo_var, (uint32_t)2);
		ExpressionU5BU5D_t4F1F138488EBD58837D142B40E0E4EEFC607EA63* L_109 = (ExpressionU5BU5D_t4F1F138488EBD58837D142B40E0E4EEFC607EA63*)L_108;
		MethodInfo_t * L_110 = ___method0;
		MethodInfo_t * L_111;
		L_111 = CachedReflectionInfo_get_DynamicObject_TryBinaryOperation_mD0D3151684B0FA6C655BC84F441D7FDFC498AD00(/*hidden argument*/NULL);
		bool L_112;
		L_112 = MethodInfo_op_Inequality_mDE1DAA5D330E9C975AC6423FC2D06862637BE68D((MethodInfo_t *)L_110, (MethodInfo_t *)L_111, /*hidden argument*/NULL);
		G_B14_0 = 0;
		G_B14_1 = L_109;
		G_B14_2 = L_109;
		G_B14_3 = L_107;
		if (L_112)
		{
			G_B15_0 = 0;
			G_B15_1 = L_109;
			G_B15_2 = L_109;
			G_B15_3 = L_107;
			goto IL_022a;
		}
	}
	{
		ParameterExpression_tA7B24F1DE0F013DA4BD55F76DB43B06DB33D8BEE * L_113 = V_1;
		ReadOnlyCollection_1_t7976DDE3F2FC7BAAF4F920193FF1B5BA33CCC2B5 * L_114 = V_2;
		NullCheck((ReadOnlyCollection_1_t7976DDE3F2FC7BAAF4F920193FF1B5BA33CCC2B5 *)L_114);
		Expression_t30A004209C10C2D9A9785B2F74EEED431A4D4660 * L_115;
		L_115 = ReadOnlyCollection_1_get_Item_m61B304E87F7A24CB20EA9565FBC66CB9118FE6D1((ReadOnlyCollection_1_t7976DDE3F2FC7BAAF4F920193FF1B5BA33CCC2B5 *)L_114, (int32_t)0, /*hidden argument*/ReadOnlyCollection_1_get_Item_m61B304E87F7A24CB20EA9565FBC66CB9118FE6D1_RuntimeMethod_var);
		IL2CPP_RUNTIME_CLASS_INIT(Expression_t30A004209C10C2D9A9785B2F74EEED431A4D4660_il2cpp_TypeInfo_var);
		BinaryExpression_tCD79755962D104E6603B50D89E7F0E41D1D9CA79 * L_116;
		L_116 = Expression_Assign_m32AEF41186AAC28E7AB3E83502C64A93CA69562C((Expression_t30A004209C10C2D9A9785B2F74EEED431A4D4660 *)L_113, (Expression_t30A004209C10C2D9A9785B2F74EEED431A4D4660 *)L_115, /*hidden argument*/NULL);
		G_B16_0 = L_116;
		G_B16_1 = G_B14_0;
		G_B16_2 = G_B14_1;
		G_B16_3 = G_B14_2;
		G_B16_4 = G_B14_3;
		goto IL_0240;
	}

IL_022a:
	{
		ParameterExpression_tA7B24F1DE0F013DA4BD55F76DB43B06DB33D8BEE * L_117 = V_1;
		RuntimeTypeHandle_tC33965ADA3E041E0C94AF05E5CB527B56482CEF9  L_118 = { reinterpret_cast<intptr_t> (RuntimeObject_0_0_0_var) };
		IL2CPP_RUNTIME_CLASS_INIT(Type_t_il2cpp_TypeInfo_var);
		Type_t * L_119;
		L_119 = Type_GetTypeFromHandle_m8BB57524FF7F9DB1803BC561D2B3A4DBACEB385E((RuntimeTypeHandle_tC33965ADA3E041E0C94AF05E5CB527B56482CEF9 )L_118, /*hidden argument*/NULL);
		ReadOnlyCollection_1_t7976DDE3F2FC7BAAF4F920193FF1B5BA33CCC2B5 * L_120 = V_2;
		IL2CPP_RUNTIME_CLASS_INIT(Expression_t30A004209C10C2D9A9785B2F74EEED431A4D4660_il2cpp_TypeInfo_var);
		NewArrayExpression_tE4702BA06AA0479BA675A5087BB6E2342F921F0A * L_121;
		L_121 = Expression_NewArrayInit_m4E25520959297D32D03E19147E1812530858109E((Type_t *)L_119, (RuntimeObject*)L_120, /*hidden argument*/NULL);
		BinaryExpression_tCD79755962D104E6603B50D89E7F0E41D1D9CA79 * L_122;
		L_122 = Expression_Assign_m32AEF41186AAC28E7AB3E83502C64A93CA69562C((Expression_t30A004209C10C2D9A9785B2F74EEED431A4D4660 *)L_117, (Expression_t30A004209C10C2D9A9785B2F74EEED431A4D4660 *)L_121, /*hidden argument*/NULL);
		G_B16_0 = L_122;
		G_B16_1 = G_B15_0;
		G_B16_2 = G_B15_1;
		G_B16_3 = G_B15_2;
		G_B16_4 = G_B15_3;
	}

IL_0240:
	{
		NullCheck(G_B16_2);
		ArrayElementTypeCheck (G_B16_2, G_B16_0);
		(G_B16_2)->SetAt(static_cast<il2cpp_array_size_t>(G_B16_1), (Expression_t30A004209C10C2D9A9785B2F74EEED431A4D4660 *)G_B16_0);
		ExpressionU5BU5D_t4F1F138488EBD58837D142B40E0E4EEFC607EA63* L_123 = (ExpressionU5BU5D_t4F1F138488EBD58837D142B40E0E4EEFC607EA63*)G_B16_3;
		NullCheck((MetaDynamic_t774AF4A12F33149209C1FA08022AB0EE951BFB7C *)__this);
		Expression_t30A004209C10C2D9A9785B2F74EEED431A4D4660 * L_124;
		L_124 = MetaDynamic_GetLimitedSelf_mBECEBC402098F5A006F3554E50694B4FB5C526C9((MetaDynamic_t774AF4A12F33149209C1FA08022AB0EE951BFB7C *)__this, /*hidden argument*/NULL);
		MethodInfo_t * L_125 = ___method0;
		RuntimeObject * L_126 = ___binder1;
		ExpressionU5BU5D_t4F1F138488EBD58837D142B40E0E4EEFC607EA63* L_127 = ___args2;
		ParameterExpression_tA7B24F1DE0F013DA4BD55F76DB43B06DB33D8BEE * L_128 = V_1;
		ParameterExpression_tA7B24F1DE0F013DA4BD55F76DB43B06DB33D8BEE * L_129 = V_0;
		IL2CPP_RUNTIME_CLASS_INIT(MetaDynamic_t774AF4A12F33149209C1FA08022AB0EE951BFB7C_il2cpp_TypeInfo_var);
		ExpressionU5BU5D_t4F1F138488EBD58837D142B40E0E4EEFC607EA63* L_130;
		L_130 = ((  ExpressionU5BU5D_t4F1F138488EBD58837D142B40E0E4EEFC607EA63* (*) (RuntimeObject *, ExpressionU5BU5D_t4F1F138488EBD58837D142B40E0E4EEFC607EA63*, Expression_t30A004209C10C2D9A9785B2F74EEED431A4D4660 *, Expression_t30A004209C10C2D9A9785B2F74EEED431A4D4660 *, const RuntimeMethod*))IL2CPP_RGCTX_METHOD_INFO(method->rgctx_data, 2)->methodPointer)((RuntimeObject *)L_126, (ExpressionU5BU5D_t4F1F138488EBD58837D142B40E0E4EEFC607EA63*)L_127, (Expression_t30A004209C10C2D9A9785B2F74EEED431A4D4660 *)L_128, (Expression_t30A004209C10C2D9A9785B2F74EEED431A4D4660 *)L_129, /*hidden argument*/IL2CPP_RGCTX_METHOD_INFO(method->rgctx_data, 2));
		IL2CPP_RUNTIME_CLASS_INIT(Expression_t30A004209C10C2D9A9785B2F74EEED431A4D4660_il2cpp_TypeInfo_var);
		MethodCallExpression_tF8E07995EEDB83A97C356206D651D5EEC72EFFA4 * L_131;
		L_131 = Expression_Call_mC590C169ED2A0064A3B956FE928BE8E53F1F85F7((Expression_t30A004209C10C2D9A9785B2F74EEED431A4D4660 *)L_124, (MethodInfo_t *)L_125, (ExpressionU5BU5D_t4F1F138488EBD58837D142B40E0E4EEFC607EA63*)L_130, /*hidden argument*/NULL);
		MethodInfo_t * L_132 = ___method0;
		MethodInfo_t * L_133;
		L_133 = CachedReflectionInfo_get_DynamicObject_TryBinaryOperation_mD0D3151684B0FA6C655BC84F441D7FDFC498AD00(/*hidden argument*/NULL);
		bool L_134;
		L_134 = MethodInfo_op_Inequality_mDE1DAA5D330E9C975AC6423FC2D06862637BE68D((MethodInfo_t *)L_132, (MethodInfo_t *)L_133, /*hidden argument*/NULL);
		G_B17_0 = L_131;
		G_B17_1 = 1;
		G_B17_2 = L_123;
		G_B17_3 = L_123;
		G_B17_4 = G_B16_4;
		if (L_134)
		{
			G_B18_0 = L_131;
			G_B18_1 = 1;
			G_B18_2 = L_123;
			G_B18_3 = L_123;
			G_B18_4 = G_B16_4;
			goto IL_026c;
		}
	}
	{
		IL2CPP_RUNTIME_CLASS_INIT(Utils_t98C8733198C84566DF6847E887A57D45326CE485_il2cpp_TypeInfo_var);
		DefaultExpression_t3FC1DD4F4C518F7FDF62C04BB3BF78B10D654D46 * L_135 = ((Utils_t98C8733198C84566DF6847E887A57D45326CE485_StaticFields*)il2cpp_codegen_static_fields_for(Utils_t98C8733198C84566DF6847E887A57D45326CE485_il2cpp_TypeInfo_var))->get_Empty_26();
		G_B19_0 = L_135;
		G_B19_1 = G_B17_0;
		G_B19_2 = G_B17_1;
		G_B19_3 = G_B17_2;
		G_B19_4 = G_B17_3;
		G_B19_5 = G_B17_4;
		goto IL_0273;
	}

IL_026c:
	{
		ParameterExpression_tA7B24F1DE0F013DA4BD55F76DB43B06DB33D8BEE * L_136 = V_1;
		ExpressionU5BU5D_t4F1F138488EBD58837D142B40E0E4EEFC607EA63* L_137 = ___args2;
		IL2CPP_RUNTIME_CLASS_INIT(MetaDynamic_t774AF4A12F33149209C1FA08022AB0EE951BFB7C_il2cpp_TypeInfo_var);
		Expression_t30A004209C10C2D9A9785B2F74EEED431A4D4660 * L_138;
		L_138 = MetaDynamic_ReferenceArgAssign_mBB711F0B8A80C937B3ED02BC585F9B2BCA60EFA1((Expression_t30A004209C10C2D9A9785B2F74EEED431A4D4660 *)L_136, (ExpressionU5BU5D_t4F1F138488EBD58837D142B40E0E4EEFC607EA63*)L_137, /*hidden argument*/NULL);
		G_B19_0 = ((DefaultExpression_t3FC1DD4F4C518F7FDF62C04BB3BF78B10D654D46 *)(L_138));
		G_B19_1 = G_B18_0;
		G_B19_2 = G_B18_1;
		G_B19_3 = G_B18_2;
		G_B19_4 = G_B18_3;
		G_B19_5 = G_B18_4;
	}

IL_0273:
	{
		DynamicMetaObject_t5279001ADBFAB6EF015CAC54937F4E9F003881C3 * L_139 = V_3;
		NullCheck((DynamicMetaObject_t5279001ADBFAB6EF015CAC54937F4E9F003881C3 *)L_139);
		Expression_t30A004209C10C2D9A9785B2F74EEED431A4D4660 * L_140;
		L_140 = DynamicMetaObject_get_Expression_m56AEEE5B82DB27F8490D27758D6ECAEC19BE64C2_inline((DynamicMetaObject_t5279001ADBFAB6EF015CAC54937F4E9F003881C3 *)L_139, /*hidden argument*/NULL);
		IL2CPP_RUNTIME_CLASS_INIT(Expression_t30A004209C10C2D9A9785B2F74EEED431A4D4660_il2cpp_TypeInfo_var);
		BlockExpression_t429D310E740322594C18397DEAE7E17DCFE0E0BB * L_141;
		L_141 = Expression_Block_m7103824690B02B43C2A397B52AF560EC9A044810((Expression_t30A004209C10C2D9A9785B2F74EEED431A4D4660 *)G_B19_0, (Expression_t30A004209C10C2D9A9785B2F74EEED431A4D4660 *)L_140, /*hidden argument*/NULL);
		DynamicMetaObject_t5279001ADBFAB6EF015CAC54937F4E9F003881C3 * L_142 = ___fallbackResult3;
		NullCheck((DynamicMetaObject_t5279001ADBFAB6EF015CAC54937F4E9F003881C3 *)L_142);
		Expression_t30A004209C10C2D9A9785B2F74EEED431A4D4660 * L_143;
		L_143 = DynamicMetaObject_get_Expression_m56AEEE5B82DB27F8490D27758D6ECAEC19BE64C2_inline((DynamicMetaObject_t5279001ADBFAB6EF015CAC54937F4E9F003881C3 *)L_142, /*hidden argument*/NULL);
		RuntimeObject * L_144 = ___binder1;
		NullCheck((DynamicMetaObjectBinder_t7B24B7AF08AEA7004A4855C632E18CA2E400CA8D *)L_144);
		Type_t * L_145;
		L_145 = VirtFuncInvoker0< Type_t * >::Invoke(6 /* System.Type System.Dynamic.DynamicMetaObjectBinder::get_ReturnType() */, (DynamicMetaObjectBinder_t7B24B7AF08AEA7004A4855C632E18CA2E400CA8D *)L_144);
		ConditionalExpression_t74C60793A382D6FC191C590A353984ED63ED3D4A * L_146;
		L_146 = Expression_Condition_mDAAB02AA8FE6525ECAE36CAF26695ADBFA738260((Expression_t30A004209C10C2D9A9785B2F74EEED431A4D4660 *)G_B19_1, (Expression_t30A004209C10C2D9A9785B2F74EEED431A4D4660 *)L_141, (Expression_t30A004209C10C2D9A9785B2F74EEED431A4D4660 *)L_143, (Type_t *)L_145, /*hidden argument*/NULL);
		NullCheck(G_B19_3);
		ArrayElementTypeCheck (G_B19_3, L_146);
		(G_B19_3)->SetAt(static_cast<il2cpp_array_size_t>(G_B19_2), (Expression_t30A004209C10C2D9A9785B2F74EEED431A4D4660 *)L_146);
		TrueReadOnlyCollection_1_t06D7E0A73C830464D87F10A513072796E7172082 * L_147 = (TrueReadOnlyCollection_1_t06D7E0A73C830464D87F10A513072796E7172082 *)il2cpp_codegen_object_new(TrueReadOnlyCollection_1_t06D7E0A73C830464D87F10A513072796E7172082_il2cpp_TypeInfo_var);
		TrueReadOnlyCollection_1__ctor_m69554AD79082CEEEE9808387797E4A9C052A1820(L_147, (ExpressionU5BU5D_t4F1F138488EBD58837D142B40E0E4EEFC607EA63*)G_B19_4, /*hidden argument*/TrueReadOnlyCollection_1__ctor_m69554AD79082CEEEE9808387797E4A9C052A1820_RuntimeMethod_var);
		BlockExpression_t429D310E740322594C18397DEAE7E17DCFE0E0BB * L_148;
		L_148 = Expression_Block_mA6CB052758601202DB19D5181835168D9CE6F908((RuntimeObject*)G_B19_5, (RuntimeObject*)L_147, /*hidden argument*/NULL);
		NullCheck((MetaDynamic_t774AF4A12F33149209C1FA08022AB0EE951BFB7C *)__this);
		BindingRestrictions_t03E14FA0517A70DEDA502032CE956595EF6E0DFC * L_149;
		L_149 = MetaDynamic_GetRestrictions_mFD3843F7B4CCBFC34A3C66170CA03B3E19504F38((MetaDynamic_t774AF4A12F33149209C1FA08022AB0EE951BFB7C *)__this, /*hidden argument*/NULL);
		DynamicMetaObject_t5279001ADBFAB6EF015CAC54937F4E9F003881C3 * L_150 = V_3;
		NullCheck((DynamicMetaObject_t5279001ADBFAB6EF015CAC54937F4E9F003881C3 *)L_150);
		BindingRestrictions_t03E14FA0517A70DEDA502032CE956595EF6E0DFC * L_151;
		L_151 = DynamicMetaObject_get_Restrictions_mE04FE62E32906462628D87A3341521ABFADC63C5_inline((DynamicMetaObject_t5279001ADBFAB6EF015CAC54937F4E9F003881C3 *)L_150, /*hidden argument*/NULL);
		NullCheck((BindingRestrictions_t03E14FA0517A70DEDA502032CE956595EF6E0DFC *)L_149);
		BindingRestrictions_t03E14FA0517A70DEDA502032CE956595EF6E0DFC * L_152;
		L_152 = BindingRestrictions_Merge_mA5D48059166AC655BF2CDF39CC199F4CE3400D19((BindingRestrictions_t03E14FA0517A70DEDA502032CE956595EF6E0DFC *)L_149, (BindingRestrictions_t03E14FA0517A70DEDA502032CE956595EF6E0DFC *)L_151, /*hidden argument*/NULL);
		DynamicMetaObject_t5279001ADBFAB6EF015CAC54937F4E9F003881C3 * L_153 = ___fallbackResult3;
		NullCheck((DynamicMetaObject_t5279001ADBFAB6EF015CAC54937F4E9F003881C3 *)L_153);
		BindingRestrictions_t03E14FA0517A70DEDA502032CE956595EF6E0DFC * L_154;
		L_154 = DynamicMetaObject_get_Restrictions_mE04FE62E32906462628D87A3341521ABFADC63C5_inline((DynamicMetaObject_t5279001ADBFAB6EF015CAC54937F4E9F003881C3 *)L_153, /*hidden argument*/NULL);
		NullCheck((BindingRestrictions_t03E14FA0517A70DEDA502032CE956595EF6E0DFC *)L_152);
		BindingRestrictions_t03E14FA0517A70DEDA502032CE956595EF6E0DFC * L_155;
		L_155 = BindingRestrictions_Merge_mA5D48059166AC655BF2CDF39CC199F4CE3400D19((BindingRestrictions_t03E14FA0517A70DEDA502032CE956595EF6E0DFC *)L_152, (BindingRestrictions_t03E14FA0517A70DEDA502032CE956595EF6E0DFC *)L_154, /*hidden argument*/NULL);
		DynamicMetaObject_t5279001ADBFAB6EF015CAC54937F4E9F003881C3 * L_156 = (DynamicMetaObject_t5279001ADBFAB6EF015CAC54937F4E9F003881C3 *)il2cpp_codegen_object_new(DynamicMetaObject_t5279001ADBFAB6EF015CAC54937F4E9F003881C3_il2cpp_TypeInfo_var);
		DynamicMetaObject__ctor_m2851C1E47FD59D49C80E454597607C1F4A8458AA(L_156, (Expression_t30A004209C10C2D9A9785B2F74EEED431A4D4660 *)L_148, (BindingRestrictions_t03E14FA0517A70DEDA502032CE956595EF6E0DFC *)L_155, /*hidden argument*/NULL);
		return (DynamicMetaObject_t5279001ADBFAB6EF015CAC54937F4E9F003881C3 *)L_156;
	}
}
// System.Dynamic.DynamicMetaObject System.Dynamic.DynamicObject/MetaDynamic::CallMethodNoResult<System.Object>(System.Reflection.MethodInfo,TBinder,System.Linq.Expressions.Expression[],System.Dynamic.DynamicObject/MetaDynamic/Fallback`1<TBinder>)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR DynamicMetaObject_t5279001ADBFAB6EF015CAC54937F4E9F003881C3 * MetaDynamic_CallMethodNoResult_TisRuntimeObject_mB6DB480A7E00A3CF5B3D4B2787E9464869124E19_gshared (MetaDynamic_t774AF4A12F33149209C1FA08022AB0EE951BFB7C * __this, MethodInfo_t * ___method0, RuntimeObject * ___binder1, ExpressionU5BU5D_t4F1F138488EBD58837D142B40E0E4EEFC607EA63* ___args2, Fallback_1_t80F90982EFE3FFA9073E13C782ABA43FD48B7A9A * ___fallback3, const RuntimeMethod* method)
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&DynamicMetaObject_t5279001ADBFAB6EF015CAC54937F4E9F003881C3_il2cpp_TypeInfo_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&ExpressionU5BU5D_t4F1F138488EBD58837D142B40E0E4EEFC607EA63_il2cpp_TypeInfo_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Expression_t30A004209C10C2D9A9785B2F74EEED431A4D4660_il2cpp_TypeInfo_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&MetaDynamic_t774AF4A12F33149209C1FA08022AB0EE951BFB7C_il2cpp_TypeInfo_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&ObjectU5BU5D_tC1F4EE0DB0B7300255F5FD4AF64FE4C585CF5ADE_0_0_0_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&ParameterExpressionU5BU5D_tCF3EAA6D8556513C4937E1126F65AA08DF4DB147_il2cpp_TypeInfo_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&RuntimeObject_0_0_0_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&TrueReadOnlyCollection_1__ctor_m69554AD79082CEEEE9808387797E4A9C052A1820_RuntimeMethod_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&TrueReadOnlyCollection_1__ctor_mF8FDD857140C35B895099B7D89BFFE4153D771B5_RuntimeMethod_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&TrueReadOnlyCollection_1_t06D7E0A73C830464D87F10A513072796E7172082_il2cpp_TypeInfo_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&TrueReadOnlyCollection_1_tFACBB37A6A09F5303FA9A457A34FAFE7002020A3_il2cpp_TypeInfo_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Type_t_il2cpp_TypeInfo_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Utils_t98C8733198C84566DF6847E887A57D45326CE485_il2cpp_TypeInfo_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Void_t700C6383A2A510C2CF4DD86DABD5CA9FF70ADAC5_0_0_0_var);
		s_Il2CppMethodInitialized = true;
	}
	DynamicMetaObject_t5279001ADBFAB6EF015CAC54937F4E9F003881C3 * V_0 = NULL;
	ParameterExpression_tA7B24F1DE0F013DA4BD55F76DB43B06DB33D8BEE * V_1 = NULL;
	ReadOnlyCollection_1_t7976DDE3F2FC7BAAF4F920193FF1B5BA33CCC2B5 * V_2 = NULL;
	DynamicMetaObject_t5279001ADBFAB6EF015CAC54937F4E9F003881C3 * V_3 = NULL;
	{
		Fallback_1_t80F90982EFE3FFA9073E13C782ABA43FD48B7A9A * L_0 = ___fallback3;
		RuntimeObject * L_1 = ___binder1;
		NullCheck((Fallback_1_t80F90982EFE3FFA9073E13C782ABA43FD48B7A9A *)L_0);
		DynamicMetaObject_t5279001ADBFAB6EF015CAC54937F4E9F003881C3 * L_2;
		L_2 = ((  DynamicMetaObject_t5279001ADBFAB6EF015CAC54937F4E9F003881C3 * (*) (Fallback_1_t80F90982EFE3FFA9073E13C782ABA43FD48B7A9A *, MetaDynamic_t774AF4A12F33149209C1FA08022AB0EE951BFB7C *, RuntimeObject *, DynamicMetaObject_t5279001ADBFAB6EF015CAC54937F4E9F003881C3 *, const RuntimeMethod*))IL2CPP_RGCTX_METHOD_INFO(method->rgctx_data, 0)->methodPointer)((Fallback_1_t80F90982EFE3FFA9073E13C782ABA43FD48B7A9A *)L_0, (MetaDynamic_t774AF4A12F33149209C1FA08022AB0EE951BFB7C *)__this, (RuntimeObject *)L_1, (DynamicMetaObject_t5279001ADBFAB6EF015CAC54937F4E9F003881C3 *)NULL, /*hidden argument*/IL2CPP_RGCTX_METHOD_INFO(method->rgctx_data, 0));
		V_0 = (DynamicMetaObject_t5279001ADBFAB6EF015CAC54937F4E9F003881C3 *)L_2;
		RuntimeTypeHandle_tC33965ADA3E041E0C94AF05E5CB527B56482CEF9  L_3 = { reinterpret_cast<intptr_t> (ObjectU5BU5D_tC1F4EE0DB0B7300255F5FD4AF64FE4C585CF5ADE_0_0_0_var) };
		IL2CPP_RUNTIME_CLASS_INIT(Type_t_il2cpp_TypeInfo_var);
		Type_t * L_4;
		L_4 = Type_GetTypeFromHandle_m8BB57524FF7F9DB1803BC561D2B3A4DBACEB385E((RuntimeTypeHandle_tC33965ADA3E041E0C94AF05E5CB527B56482CEF9 )L_3, /*hidden argument*/NULL);
		IL2CPP_RUNTIME_CLASS_INIT(Expression_t30A004209C10C2D9A9785B2F74EEED431A4D4660_il2cpp_TypeInfo_var);
		ParameterExpression_tA7B24F1DE0F013DA4BD55F76DB43B06DB33D8BEE * L_5;
		L_5 = Expression_Parameter_m1613C069AFED7D393811F36BC7F91188D668A333((Type_t *)L_4, (String_t*)NULL, /*hidden argument*/NULL);
		V_1 = (ParameterExpression_tA7B24F1DE0F013DA4BD55F76DB43B06DB33D8BEE *)L_5;
		ExpressionU5BU5D_t4F1F138488EBD58837D142B40E0E4EEFC607EA63* L_6 = ___args2;
		IL2CPP_RUNTIME_CLASS_INIT(MetaDynamic_t774AF4A12F33149209C1FA08022AB0EE951BFB7C_il2cpp_TypeInfo_var);
		ReadOnlyCollection_1_t7976DDE3F2FC7BAAF4F920193FF1B5BA33CCC2B5 * L_7;
		L_7 = MetaDynamic_GetConvertedArgs_m1C2C9220C741DBE95A2DFC7767F1DD02AB432AC9((ExpressionU5BU5D_t4F1F138488EBD58837D142B40E0E4EEFC607EA63*)L_6, /*hidden argument*/NULL);
		V_2 = (ReadOnlyCollection_1_t7976DDE3F2FC7BAAF4F920193FF1B5BA33CCC2B5 *)L_7;
		ParameterExpressionU5BU5D_tCF3EAA6D8556513C4937E1126F65AA08DF4DB147* L_8 = (ParameterExpressionU5BU5D_tCF3EAA6D8556513C4937E1126F65AA08DF4DB147*)(ParameterExpressionU5BU5D_tCF3EAA6D8556513C4937E1126F65AA08DF4DB147*)SZArrayNew(ParameterExpressionU5BU5D_tCF3EAA6D8556513C4937E1126F65AA08DF4DB147_il2cpp_TypeInfo_var, (uint32_t)1);
		ParameterExpressionU5BU5D_tCF3EAA6D8556513C4937E1126F65AA08DF4DB147* L_9 = (ParameterExpressionU5BU5D_tCF3EAA6D8556513C4937E1126F65AA08DF4DB147*)L_8;
		ParameterExpression_tA7B24F1DE0F013DA4BD55F76DB43B06DB33D8BEE * L_10 = V_1;
		NullCheck(L_9);
		ArrayElementTypeCheck (L_9, L_10);
		(L_9)->SetAt(static_cast<il2cpp_array_size_t>(0), (ParameterExpression_tA7B24F1DE0F013DA4BD55F76DB43B06DB33D8BEE *)L_10);
		TrueReadOnlyCollection_1_tFACBB37A6A09F5303FA9A457A34FAFE7002020A3 * L_11 = (TrueReadOnlyCollection_1_tFACBB37A6A09F5303FA9A457A34FAFE7002020A3 *)il2cpp_codegen_object_new(TrueReadOnlyCollection_1_tFACBB37A6A09F5303FA9A457A34FAFE7002020A3_il2cpp_TypeInfo_var);
		TrueReadOnlyCollection_1__ctor_mF8FDD857140C35B895099B7D89BFFE4153D771B5(L_11, (ParameterExpressionU5BU5D_tCF3EAA6D8556513C4937E1126F65AA08DF4DB147*)L_9, /*hidden argument*/TrueReadOnlyCollection_1__ctor_mF8FDD857140C35B895099B7D89BFFE4153D771B5_RuntimeMethod_var);
		ExpressionU5BU5D_t4F1F138488EBD58837D142B40E0E4EEFC607EA63* L_12 = (ExpressionU5BU5D_t4F1F138488EBD58837D142B40E0E4EEFC607EA63*)(ExpressionU5BU5D_t4F1F138488EBD58837D142B40E0E4EEFC607EA63*)SZArrayNew(ExpressionU5BU5D_t4F1F138488EBD58837D142B40E0E4EEFC607EA63_il2cpp_TypeInfo_var, (uint32_t)2);
		ExpressionU5BU5D_t4F1F138488EBD58837D142B40E0E4EEFC607EA63* L_13 = (ExpressionU5BU5D_t4F1F138488EBD58837D142B40E0E4EEFC607EA63*)L_12;
		ParameterExpression_tA7B24F1DE0F013DA4BD55F76DB43B06DB33D8BEE * L_14 = V_1;
		RuntimeTypeHandle_tC33965ADA3E041E0C94AF05E5CB527B56482CEF9  L_15 = { reinterpret_cast<intptr_t> (RuntimeObject_0_0_0_var) };
		Type_t * L_16;
		L_16 = Type_GetTypeFromHandle_m8BB57524FF7F9DB1803BC561D2B3A4DBACEB385E((RuntimeTypeHandle_tC33965ADA3E041E0C94AF05E5CB527B56482CEF9 )L_15, /*hidden argument*/NULL);
		ReadOnlyCollection_1_t7976DDE3F2FC7BAAF4F920193FF1B5BA33CCC2B5 * L_17 = V_2;
		NewArrayExpression_tE4702BA06AA0479BA675A5087BB6E2342F921F0A * L_18;
		L_18 = Expression_NewArrayInit_m4E25520959297D32D03E19147E1812530858109E((Type_t *)L_16, (RuntimeObject*)L_17, /*hidden argument*/NULL);
		BinaryExpression_tCD79755962D104E6603B50D89E7F0E41D1D9CA79 * L_19;
		L_19 = Expression_Assign_m32AEF41186AAC28E7AB3E83502C64A93CA69562C((Expression_t30A004209C10C2D9A9785B2F74EEED431A4D4660 *)L_14, (Expression_t30A004209C10C2D9A9785B2F74EEED431A4D4660 *)L_18, /*hidden argument*/NULL);
		NullCheck(L_13);
		ArrayElementTypeCheck (L_13, L_19);
		(L_13)->SetAt(static_cast<il2cpp_array_size_t>(0), (Expression_t30A004209C10C2D9A9785B2F74EEED431A4D4660 *)L_19);
		ExpressionU5BU5D_t4F1F138488EBD58837D142B40E0E4EEFC607EA63* L_20 = (ExpressionU5BU5D_t4F1F138488EBD58837D142B40E0E4EEFC607EA63*)L_13;
		NullCheck((MetaDynamic_t774AF4A12F33149209C1FA08022AB0EE951BFB7C *)__this);
		Expression_t30A004209C10C2D9A9785B2F74EEED431A4D4660 * L_21;
		L_21 = MetaDynamic_GetLimitedSelf_mBECEBC402098F5A006F3554E50694B4FB5C526C9((MetaDynamic_t774AF4A12F33149209C1FA08022AB0EE951BFB7C *)__this, /*hidden argument*/NULL);
		MethodInfo_t * L_22 = ___method0;
		RuntimeObject * L_23 = ___binder1;
		ExpressionU5BU5D_t4F1F138488EBD58837D142B40E0E4EEFC607EA63* L_24 = ___args2;
		ParameterExpression_tA7B24F1DE0F013DA4BD55F76DB43B06DB33D8BEE * L_25 = V_1;
		ExpressionU5BU5D_t4F1F138488EBD58837D142B40E0E4EEFC607EA63* L_26;
		L_26 = ((  ExpressionU5BU5D_t4F1F138488EBD58837D142B40E0E4EEFC607EA63* (*) (RuntimeObject *, ExpressionU5BU5D_t4F1F138488EBD58837D142B40E0E4EEFC607EA63*, Expression_t30A004209C10C2D9A9785B2F74EEED431A4D4660 *, Expression_t30A004209C10C2D9A9785B2F74EEED431A4D4660 *, const RuntimeMethod*))IL2CPP_RGCTX_METHOD_INFO(method->rgctx_data, 1)->methodPointer)((RuntimeObject *)L_23, (ExpressionU5BU5D_t4F1F138488EBD58837D142B40E0E4EEFC607EA63*)L_24, (Expression_t30A004209C10C2D9A9785B2F74EEED431A4D4660 *)L_25, (Expression_t30A004209C10C2D9A9785B2F74EEED431A4D4660 *)NULL, /*hidden argument*/IL2CPP_RGCTX_METHOD_INFO(method->rgctx_data, 1));
		MethodCallExpression_tF8E07995EEDB83A97C356206D651D5EEC72EFFA4 * L_27;
		L_27 = Expression_Call_mC590C169ED2A0064A3B956FE928BE8E53F1F85F7((Expression_t30A004209C10C2D9A9785B2F74EEED431A4D4660 *)L_21, (MethodInfo_t *)L_22, (ExpressionU5BU5D_t4F1F138488EBD58837D142B40E0E4EEFC607EA63*)L_26, /*hidden argument*/NULL);
		ParameterExpression_tA7B24F1DE0F013DA4BD55F76DB43B06DB33D8BEE * L_28 = V_1;
		ExpressionU5BU5D_t4F1F138488EBD58837D142B40E0E4EEFC607EA63* L_29 = ___args2;
		Expression_t30A004209C10C2D9A9785B2F74EEED431A4D4660 * L_30;
		L_30 = MetaDynamic_ReferenceArgAssign_mBB711F0B8A80C937B3ED02BC585F9B2BCA60EFA1((Expression_t30A004209C10C2D9A9785B2F74EEED431A4D4660 *)L_28, (ExpressionU5BU5D_t4F1F138488EBD58837D142B40E0E4EEFC607EA63*)L_29, /*hidden argument*/NULL);
		IL2CPP_RUNTIME_CLASS_INIT(Utils_t98C8733198C84566DF6847E887A57D45326CE485_il2cpp_TypeInfo_var);
		DefaultExpression_t3FC1DD4F4C518F7FDF62C04BB3BF78B10D654D46 * L_31 = ((Utils_t98C8733198C84566DF6847E887A57D45326CE485_StaticFields*)il2cpp_codegen_static_fields_for(Utils_t98C8733198C84566DF6847E887A57D45326CE485_il2cpp_TypeInfo_var))->get_Empty_26();
		BlockExpression_t429D310E740322594C18397DEAE7E17DCFE0E0BB * L_32;
		L_32 = Expression_Block_m7103824690B02B43C2A397B52AF560EC9A044810((Expression_t30A004209C10C2D9A9785B2F74EEED431A4D4660 *)L_30, (Expression_t30A004209C10C2D9A9785B2F74EEED431A4D4660 *)L_31, /*hidden argument*/NULL);
		DynamicMetaObject_t5279001ADBFAB6EF015CAC54937F4E9F003881C3 * L_33 = V_0;
		NullCheck((DynamicMetaObject_t5279001ADBFAB6EF015CAC54937F4E9F003881C3 *)L_33);
		Expression_t30A004209C10C2D9A9785B2F74EEED431A4D4660 * L_34;
		L_34 = DynamicMetaObject_get_Expression_m56AEEE5B82DB27F8490D27758D6ECAEC19BE64C2_inline((DynamicMetaObject_t5279001ADBFAB6EF015CAC54937F4E9F003881C3 *)L_33, /*hidden argument*/NULL);
		RuntimeTypeHandle_tC33965ADA3E041E0C94AF05E5CB527B56482CEF9  L_35 = { reinterpret_cast<intptr_t> (Void_t700C6383A2A510C2CF4DD86DABD5CA9FF70ADAC5_0_0_0_var) };
		Type_t * L_36;
		L_36 = Type_GetTypeFromHandle_m8BB57524FF7F9DB1803BC561D2B3A4DBACEB385E((RuntimeTypeHandle_tC33965ADA3E041E0C94AF05E5CB527B56482CEF9 )L_35, /*hidden argument*/NULL);
		ConditionalExpression_t74C60793A382D6FC191C590A353984ED63ED3D4A * L_37;
		L_37 = Expression_Condition_mDAAB02AA8FE6525ECAE36CAF26695ADBFA738260((Expression_t30A004209C10C2D9A9785B2F74EEED431A4D4660 *)L_27, (Expression_t30A004209C10C2D9A9785B2F74EEED431A4D4660 *)L_32, (Expression_t30A004209C10C2D9A9785B2F74EEED431A4D4660 *)L_34, (Type_t *)L_36, /*hidden argument*/NULL);
		NullCheck(L_20);
		ArrayElementTypeCheck (L_20, L_37);
		(L_20)->SetAt(static_cast<il2cpp_array_size_t>(1), (Expression_t30A004209C10C2D9A9785B2F74EEED431A4D4660 *)L_37);
		TrueReadOnlyCollection_1_t06D7E0A73C830464D87F10A513072796E7172082 * L_38 = (TrueReadOnlyCollection_1_t06D7E0A73C830464D87F10A513072796E7172082 *)il2cpp_codegen_object_new(TrueReadOnlyCollection_1_t06D7E0A73C830464D87F10A513072796E7172082_il2cpp_TypeInfo_var);
		TrueReadOnlyCollection_1__ctor_m69554AD79082CEEEE9808387797E4A9C052A1820(L_38, (ExpressionU5BU5D_t4F1F138488EBD58837D142B40E0E4EEFC607EA63*)L_20, /*hidden argument*/TrueReadOnlyCollection_1__ctor_m69554AD79082CEEEE9808387797E4A9C052A1820_RuntimeMethod_var);
		BlockExpression_t429D310E740322594C18397DEAE7E17DCFE0E0BB * L_39;
		L_39 = Expression_Block_mA6CB052758601202DB19D5181835168D9CE6F908((RuntimeObject*)L_11, (RuntimeObject*)L_38, /*hidden argument*/NULL);
		NullCheck((MetaDynamic_t774AF4A12F33149209C1FA08022AB0EE951BFB7C *)__this);
		BindingRestrictions_t03E14FA0517A70DEDA502032CE956595EF6E0DFC * L_40;
		L_40 = MetaDynamic_GetRestrictions_mFD3843F7B4CCBFC34A3C66170CA03B3E19504F38((MetaDynamic_t774AF4A12F33149209C1FA08022AB0EE951BFB7C *)__this, /*hidden argument*/NULL);
		DynamicMetaObject_t5279001ADBFAB6EF015CAC54937F4E9F003881C3 * L_41 = V_0;
		NullCheck((DynamicMetaObject_t5279001ADBFAB6EF015CAC54937F4E9F003881C3 *)L_41);
		BindingRestrictions_t03E14FA0517A70DEDA502032CE956595EF6E0DFC * L_42;
		L_42 = DynamicMetaObject_get_Restrictions_mE04FE62E32906462628D87A3341521ABFADC63C5_inline((DynamicMetaObject_t5279001ADBFAB6EF015CAC54937F4E9F003881C3 *)L_41, /*hidden argument*/NULL);
		NullCheck((BindingRestrictions_t03E14FA0517A70DEDA502032CE956595EF6E0DFC *)L_40);
		BindingRestrictions_t03E14FA0517A70DEDA502032CE956595EF6E0DFC * L_43;
		L_43 = BindingRestrictions_Merge_mA5D48059166AC655BF2CDF39CC199F4CE3400D19((BindingRestrictions_t03E14FA0517A70DEDA502032CE956595EF6E0DFC *)L_40, (BindingRestrictions_t03E14FA0517A70DEDA502032CE956595EF6E0DFC *)L_42, /*hidden argument*/NULL);
		DynamicMetaObject_t5279001ADBFAB6EF015CAC54937F4E9F003881C3 * L_44 = (DynamicMetaObject_t5279001ADBFAB6EF015CAC54937F4E9F003881C3 *)il2cpp_codegen_object_new(DynamicMetaObject_t5279001ADBFAB6EF015CAC54937F4E9F003881C3_il2cpp_TypeInfo_var);
		DynamicMetaObject__ctor_m2851C1E47FD59D49C80E454597607C1F4A8458AA(L_44, (Expression_t30A004209C10C2D9A9785B2F74EEED431A4D4660 *)L_39, (BindingRestrictions_t03E14FA0517A70DEDA502032CE956595EF6E0DFC *)L_43, /*hidden argument*/NULL);
		V_3 = (DynamicMetaObject_t5279001ADBFAB6EF015CAC54937F4E9F003881C3 *)L_44;
		Fallback_1_t80F90982EFE3FFA9073E13C782ABA43FD48B7A9A * L_45 = ___fallback3;
		RuntimeObject * L_46 = ___binder1;
		DynamicMetaObject_t5279001ADBFAB6EF015CAC54937F4E9F003881C3 * L_47 = V_3;
		NullCheck((Fallback_1_t80F90982EFE3FFA9073E13C782ABA43FD48B7A9A *)L_45);
		DynamicMetaObject_t5279001ADBFAB6EF015CAC54937F4E9F003881C3 * L_48;
		L_48 = ((  DynamicMetaObject_t5279001ADBFAB6EF015CAC54937F4E9F003881C3 * (*) (Fallback_1_t80F90982EFE3FFA9073E13C782ABA43FD48B7A9A *, MetaDynamic_t774AF4A12F33149209C1FA08022AB0EE951BFB7C *, RuntimeObject *, DynamicMetaObject_t5279001ADBFAB6EF015CAC54937F4E9F003881C3 *, const RuntimeMethod*))IL2CPP_RGCTX_METHOD_INFO(method->rgctx_data, 0)->methodPointer)((Fallback_1_t80F90982EFE3FFA9073E13C782ABA43FD48B7A9A *)L_45, (MetaDynamic_t774AF4A12F33149209C1FA08022AB0EE951BFB7C *)__this, (RuntimeObject *)L_46, (DynamicMetaObject_t5279001ADBFAB6EF015CAC54937F4E9F003881C3 *)L_47, /*hidden argument*/IL2CPP_RGCTX_METHOD_INFO(method->rgctx_data, 0));
		return (DynamicMetaObject_t5279001ADBFAB6EF015CAC54937F4E9F003881C3 *)L_48;
	}
}
// System.Dynamic.DynamicMetaObject System.Dynamic.DynamicObject/MetaDynamic::CallMethodReturnLast<System.Object>(System.Reflection.MethodInfo,TBinder,System.Linq.Expressions.Expression[],System.Linq.Expressions.Expression,System.Dynamic.DynamicObject/MetaDynamic/Fallback`1<TBinder>)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR DynamicMetaObject_t5279001ADBFAB6EF015CAC54937F4E9F003881C3 * MetaDynamic_CallMethodReturnLast_TisRuntimeObject_mCA5F98C3D2BEF5DF4700EFF217CA2B6249CF5960_gshared (MetaDynamic_t774AF4A12F33149209C1FA08022AB0EE951BFB7C * __this, MethodInfo_t * ___method0, RuntimeObject * ___binder1, ExpressionU5BU5D_t4F1F138488EBD58837D142B40E0E4EEFC607EA63* ___args2, Expression_t30A004209C10C2D9A9785B2F74EEED431A4D4660 * ___value3, Fallback_1_t80F90982EFE3FFA9073E13C782ABA43FD48B7A9A * ___fallback4, const RuntimeMethod* method)
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&DynamicMetaObject_t5279001ADBFAB6EF015CAC54937F4E9F003881C3_il2cpp_TypeInfo_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&ExpressionU5BU5D_t4F1F138488EBD58837D142B40E0E4EEFC607EA63_il2cpp_TypeInfo_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Expression_t30A004209C10C2D9A9785B2F74EEED431A4D4660_il2cpp_TypeInfo_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&MetaDynamic_t774AF4A12F33149209C1FA08022AB0EE951BFB7C_il2cpp_TypeInfo_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&ObjectU5BU5D_tC1F4EE0DB0B7300255F5FD4AF64FE4C585CF5ADE_0_0_0_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&ParameterExpressionU5BU5D_tCF3EAA6D8556513C4937E1126F65AA08DF4DB147_il2cpp_TypeInfo_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&RuntimeObject_0_0_0_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&TrueReadOnlyCollection_1__ctor_m69554AD79082CEEEE9808387797E4A9C052A1820_RuntimeMethod_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&TrueReadOnlyCollection_1__ctor_mF8FDD857140C35B895099B7D89BFFE4153D771B5_RuntimeMethod_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&TrueReadOnlyCollection_1_t06D7E0A73C830464D87F10A513072796E7172082_il2cpp_TypeInfo_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&TrueReadOnlyCollection_1_tFACBB37A6A09F5303FA9A457A34FAFE7002020A3_il2cpp_TypeInfo_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Type_t_il2cpp_TypeInfo_var);
		s_Il2CppMethodInitialized = true;
	}
	DynamicMetaObject_t5279001ADBFAB6EF015CAC54937F4E9F003881C3 * V_0 = NULL;
	ParameterExpression_tA7B24F1DE0F013DA4BD55F76DB43B06DB33D8BEE * V_1 = NULL;
	ParameterExpression_tA7B24F1DE0F013DA4BD55F76DB43B06DB33D8BEE * V_2 = NULL;
	ReadOnlyCollection_1_t7976DDE3F2FC7BAAF4F920193FF1B5BA33CCC2B5 * V_3 = NULL;
	DynamicMetaObject_t5279001ADBFAB6EF015CAC54937F4E9F003881C3 * V_4 = NULL;
	{
		Fallback_1_t80F90982EFE3FFA9073E13C782ABA43FD48B7A9A * L_0 = ___fallback4;
		RuntimeObject * L_1 = ___binder1;
		NullCheck((Fallback_1_t80F90982EFE3FFA9073E13C782ABA43FD48B7A9A *)L_0);
		DynamicMetaObject_t5279001ADBFAB6EF015CAC54937F4E9F003881C3 * L_2;
		L_2 = ((  DynamicMetaObject_t5279001ADBFAB6EF015CAC54937F4E9F003881C3 * (*) (Fallback_1_t80F90982EFE3FFA9073E13C782ABA43FD48B7A9A *, MetaDynamic_t774AF4A12F33149209C1FA08022AB0EE951BFB7C *, RuntimeObject *, DynamicMetaObject_t5279001ADBFAB6EF015CAC54937F4E9F003881C3 *, const RuntimeMethod*))IL2CPP_RGCTX_METHOD_INFO(method->rgctx_data, 0)->methodPointer)((Fallback_1_t80F90982EFE3FFA9073E13C782ABA43FD48B7A9A *)L_0, (MetaDynamic_t774AF4A12F33149209C1FA08022AB0EE951BFB7C *)__this, (RuntimeObject *)L_1, (DynamicMetaObject_t5279001ADBFAB6EF015CAC54937F4E9F003881C3 *)NULL, /*hidden argument*/IL2CPP_RGCTX_METHOD_INFO(method->rgctx_data, 0));
		V_0 = (DynamicMetaObject_t5279001ADBFAB6EF015CAC54937F4E9F003881C3 *)L_2;
		RuntimeTypeHandle_tC33965ADA3E041E0C94AF05E5CB527B56482CEF9  L_3 = { reinterpret_cast<intptr_t> (RuntimeObject_0_0_0_var) };
		IL2CPP_RUNTIME_CLASS_INIT(Type_t_il2cpp_TypeInfo_var);
		Type_t * L_4;
		L_4 = Type_GetTypeFromHandle_m8BB57524FF7F9DB1803BC561D2B3A4DBACEB385E((RuntimeTypeHandle_tC33965ADA3E041E0C94AF05E5CB527B56482CEF9 )L_3, /*hidden argument*/NULL);
		IL2CPP_RUNTIME_CLASS_INIT(Expression_t30A004209C10C2D9A9785B2F74EEED431A4D4660_il2cpp_TypeInfo_var);
		ParameterExpression_tA7B24F1DE0F013DA4BD55F76DB43B06DB33D8BEE * L_5;
		L_5 = Expression_Parameter_m1613C069AFED7D393811F36BC7F91188D668A333((Type_t *)L_4, (String_t*)NULL, /*hidden argument*/NULL);
		V_1 = (ParameterExpression_tA7B24F1DE0F013DA4BD55F76DB43B06DB33D8BEE *)L_5;
		RuntimeTypeHandle_tC33965ADA3E041E0C94AF05E5CB527B56482CEF9  L_6 = { reinterpret_cast<intptr_t> (ObjectU5BU5D_tC1F4EE0DB0B7300255F5FD4AF64FE4C585CF5ADE_0_0_0_var) };
		Type_t * L_7;
		L_7 = Type_GetTypeFromHandle_m8BB57524FF7F9DB1803BC561D2B3A4DBACEB385E((RuntimeTypeHandle_tC33965ADA3E041E0C94AF05E5CB527B56482CEF9 )L_6, /*hidden argument*/NULL);
		ParameterExpression_tA7B24F1DE0F013DA4BD55F76DB43B06DB33D8BEE * L_8;
		L_8 = Expression_Parameter_m1613C069AFED7D393811F36BC7F91188D668A333((Type_t *)L_7, (String_t*)NULL, /*hidden argument*/NULL);
		V_2 = (ParameterExpression_tA7B24F1DE0F013DA4BD55F76DB43B06DB33D8BEE *)L_8;
		ExpressionU5BU5D_t4F1F138488EBD58837D142B40E0E4EEFC607EA63* L_9 = ___args2;
		IL2CPP_RUNTIME_CLASS_INIT(MetaDynamic_t774AF4A12F33149209C1FA08022AB0EE951BFB7C_il2cpp_TypeInfo_var);
		ReadOnlyCollection_1_t7976DDE3F2FC7BAAF4F920193FF1B5BA33CCC2B5 * L_10;
		L_10 = MetaDynamic_GetConvertedArgs_m1C2C9220C741DBE95A2DFC7767F1DD02AB432AC9((ExpressionU5BU5D_t4F1F138488EBD58837D142B40E0E4EEFC607EA63*)L_9, /*hidden argument*/NULL);
		V_3 = (ReadOnlyCollection_1_t7976DDE3F2FC7BAAF4F920193FF1B5BA33CCC2B5 *)L_10;
		ParameterExpressionU5BU5D_tCF3EAA6D8556513C4937E1126F65AA08DF4DB147* L_11 = (ParameterExpressionU5BU5D_tCF3EAA6D8556513C4937E1126F65AA08DF4DB147*)(ParameterExpressionU5BU5D_tCF3EAA6D8556513C4937E1126F65AA08DF4DB147*)SZArrayNew(ParameterExpressionU5BU5D_tCF3EAA6D8556513C4937E1126F65AA08DF4DB147_il2cpp_TypeInfo_var, (uint32_t)2);
		ParameterExpressionU5BU5D_tCF3EAA6D8556513C4937E1126F65AA08DF4DB147* L_12 = (ParameterExpressionU5BU5D_tCF3EAA6D8556513C4937E1126F65AA08DF4DB147*)L_11;
		ParameterExpression_tA7B24F1DE0F013DA4BD55F76DB43B06DB33D8BEE * L_13 = V_1;
		NullCheck(L_12);
		ArrayElementTypeCheck (L_12, L_13);
		(L_12)->SetAt(static_cast<il2cpp_array_size_t>(0), (ParameterExpression_tA7B24F1DE0F013DA4BD55F76DB43B06DB33D8BEE *)L_13);
		ParameterExpressionU5BU5D_tCF3EAA6D8556513C4937E1126F65AA08DF4DB147* L_14 = (ParameterExpressionU5BU5D_tCF3EAA6D8556513C4937E1126F65AA08DF4DB147*)L_12;
		ParameterExpression_tA7B24F1DE0F013DA4BD55F76DB43B06DB33D8BEE * L_15 = V_2;
		NullCheck(L_14);
		ArrayElementTypeCheck (L_14, L_15);
		(L_14)->SetAt(static_cast<il2cpp_array_size_t>(1), (ParameterExpression_tA7B24F1DE0F013DA4BD55F76DB43B06DB33D8BEE *)L_15);
		TrueReadOnlyCollection_1_tFACBB37A6A09F5303FA9A457A34FAFE7002020A3 * L_16 = (TrueReadOnlyCollection_1_tFACBB37A6A09F5303FA9A457A34FAFE7002020A3 *)il2cpp_codegen_object_new(TrueReadOnlyCollection_1_tFACBB37A6A09F5303FA9A457A34FAFE7002020A3_il2cpp_TypeInfo_var);
		TrueReadOnlyCollection_1__ctor_mF8FDD857140C35B895099B7D89BFFE4153D771B5(L_16, (ParameterExpressionU5BU5D_tCF3EAA6D8556513C4937E1126F65AA08DF4DB147*)L_14, /*hidden argument*/TrueReadOnlyCollection_1__ctor_mF8FDD857140C35B895099B7D89BFFE4153D771B5_RuntimeMethod_var);
		ExpressionU5BU5D_t4F1F138488EBD58837D142B40E0E4EEFC607EA63* L_17 = (ExpressionU5BU5D_t4F1F138488EBD58837D142B40E0E4EEFC607EA63*)(ExpressionU5BU5D_t4F1F138488EBD58837D142B40E0E4EEFC607EA63*)SZArrayNew(ExpressionU5BU5D_t4F1F138488EBD58837D142B40E0E4EEFC607EA63_il2cpp_TypeInfo_var, (uint32_t)2);
		ExpressionU5BU5D_t4F1F138488EBD58837D142B40E0E4EEFC607EA63* L_18 = (ExpressionU5BU5D_t4F1F138488EBD58837D142B40E0E4EEFC607EA63*)L_17;
		ParameterExpression_tA7B24F1DE0F013DA4BD55F76DB43B06DB33D8BEE * L_19 = V_2;
		RuntimeTypeHandle_tC33965ADA3E041E0C94AF05E5CB527B56482CEF9  L_20 = { reinterpret_cast<intptr_t> (RuntimeObject_0_0_0_var) };
		Type_t * L_21;
		L_21 = Type_GetTypeFromHandle_m8BB57524FF7F9DB1803BC561D2B3A4DBACEB385E((RuntimeTypeHandle_tC33965ADA3E041E0C94AF05E5CB527B56482CEF9 )L_20, /*hidden argument*/NULL);
		ReadOnlyCollection_1_t7976DDE3F2FC7BAAF4F920193FF1B5BA33CCC2B5 * L_22 = V_3;
		NewArrayExpression_tE4702BA06AA0479BA675A5087BB6E2342F921F0A * L_23;
		L_23 = Expression_NewArrayInit_m4E25520959297D32D03E19147E1812530858109E((Type_t *)L_21, (RuntimeObject*)L_22, /*hidden argument*/NULL);
		BinaryExpression_tCD79755962D104E6603B50D89E7F0E41D1D9CA79 * L_24;
		L_24 = Expression_Assign_m32AEF41186AAC28E7AB3E83502C64A93CA69562C((Expression_t30A004209C10C2D9A9785B2F74EEED431A4D4660 *)L_19, (Expression_t30A004209C10C2D9A9785B2F74EEED431A4D4660 *)L_23, /*hidden argument*/NULL);
		NullCheck(L_18);
		ArrayElementTypeCheck (L_18, L_24);
		(L_18)->SetAt(static_cast<il2cpp_array_size_t>(0), (Expression_t30A004209C10C2D9A9785B2F74EEED431A4D4660 *)L_24);
		ExpressionU5BU5D_t4F1F138488EBD58837D142B40E0E4EEFC607EA63* L_25 = (ExpressionU5BU5D_t4F1F138488EBD58837D142B40E0E4EEFC607EA63*)L_18;
		NullCheck((MetaDynamic_t774AF4A12F33149209C1FA08022AB0EE951BFB7C *)__this);
		Expression_t30A004209C10C2D9A9785B2F74EEED431A4D4660 * L_26;
		L_26 = MetaDynamic_GetLimitedSelf_mBECEBC402098F5A006F3554E50694B4FB5C526C9((MetaDynamic_t774AF4A12F33149209C1FA08022AB0EE951BFB7C *)__this, /*hidden argument*/NULL);
		MethodInfo_t * L_27 = ___method0;
		RuntimeObject * L_28 = ___binder1;
		ExpressionU5BU5D_t4F1F138488EBD58837D142B40E0E4EEFC607EA63* L_29 = ___args2;
		ParameterExpression_tA7B24F1DE0F013DA4BD55F76DB43B06DB33D8BEE * L_30 = V_2;
		ParameterExpression_tA7B24F1DE0F013DA4BD55F76DB43B06DB33D8BEE * L_31 = V_1;
		Expression_t30A004209C10C2D9A9785B2F74EEED431A4D4660 * L_32 = ___value3;
		RuntimeTypeHandle_tC33965ADA3E041E0C94AF05E5CB527B56482CEF9  L_33 = { reinterpret_cast<intptr_t> (RuntimeObject_0_0_0_var) };
		Type_t * L_34;
		L_34 = Type_GetTypeFromHandle_m8BB57524FF7F9DB1803BC561D2B3A4DBACEB385E((RuntimeTypeHandle_tC33965ADA3E041E0C94AF05E5CB527B56482CEF9 )L_33, /*hidden argument*/NULL);
		UnaryExpression_t5DE6F6FA2216CDD34DFCFADEB0080CB29326DD62 * L_35;
		L_35 = Expression_Convert_m494826A3729B238263D95E7D7B0E236DE3B1CDA7((Expression_t30A004209C10C2D9A9785B2F74EEED431A4D4660 *)L_32, (Type_t *)L_34, /*hidden argument*/NULL);
		BinaryExpression_tCD79755962D104E6603B50D89E7F0E41D1D9CA79 * L_36;
		L_36 = Expression_Assign_m32AEF41186AAC28E7AB3E83502C64A93CA69562C((Expression_t30A004209C10C2D9A9785B2F74EEED431A4D4660 *)L_31, (Expression_t30A004209C10C2D9A9785B2F74EEED431A4D4660 *)L_35, /*hidden argument*/NULL);
		ExpressionU5BU5D_t4F1F138488EBD58837D142B40E0E4EEFC607EA63* L_37;
		L_37 = ((  ExpressionU5BU5D_t4F1F138488EBD58837D142B40E0E4EEFC607EA63* (*) (RuntimeObject *, ExpressionU5BU5D_t4F1F138488EBD58837D142B40E0E4EEFC607EA63*, Expression_t30A004209C10C2D9A9785B2F74EEED431A4D4660 *, Expression_t30A004209C10C2D9A9785B2F74EEED431A4D4660 *, const RuntimeMethod*))IL2CPP_RGCTX_METHOD_INFO(method->rgctx_data, 1)->methodPointer)((RuntimeObject *)L_28, (ExpressionU5BU5D_t4F1F138488EBD58837D142B40E0E4EEFC607EA63*)L_29, (Expression_t30A004209C10C2D9A9785B2F74EEED431A4D4660 *)L_30, (Expression_t30A004209C10C2D9A9785B2F74EEED431A4D4660 *)L_36, /*hidden argument*/IL2CPP_RGCTX_METHOD_INFO(method->rgctx_data, 1));
		MethodCallExpression_tF8E07995EEDB83A97C356206D651D5EEC72EFFA4 * L_38;
		L_38 = Expression_Call_mC590C169ED2A0064A3B956FE928BE8E53F1F85F7((Expression_t30A004209C10C2D9A9785B2F74EEED431A4D4660 *)L_26, (MethodInfo_t *)L_27, (ExpressionU5BU5D_t4F1F138488EBD58837D142B40E0E4EEFC607EA63*)L_37, /*hidden argument*/NULL);
		ParameterExpression_tA7B24F1DE0F013DA4BD55F76DB43B06DB33D8BEE * L_39 = V_2;
		ExpressionU5BU5D_t4F1F138488EBD58837D142B40E0E4EEFC607EA63* L_40 = ___args2;
		Expression_t30A004209C10C2D9A9785B2F74EEED431A4D4660 * L_41;
		L_41 = MetaDynamic_ReferenceArgAssign_mBB711F0B8A80C937B3ED02BC585F9B2BCA60EFA1((Expression_t30A004209C10C2D9A9785B2F74EEED431A4D4660 *)L_39, (ExpressionU5BU5D_t4F1F138488EBD58837D142B40E0E4EEFC607EA63*)L_40, /*hidden argument*/NULL);
		ParameterExpression_tA7B24F1DE0F013DA4BD55F76DB43B06DB33D8BEE * L_42 = V_1;
		BlockExpression_t429D310E740322594C18397DEAE7E17DCFE0E0BB * L_43;
		L_43 = Expression_Block_m7103824690B02B43C2A397B52AF560EC9A044810((Expression_t30A004209C10C2D9A9785B2F74EEED431A4D4660 *)L_41, (Expression_t30A004209C10C2D9A9785B2F74EEED431A4D4660 *)L_42, /*hidden argument*/NULL);
		DynamicMetaObject_t5279001ADBFAB6EF015CAC54937F4E9F003881C3 * L_44 = V_0;
		NullCheck((DynamicMetaObject_t5279001ADBFAB6EF015CAC54937F4E9F003881C3 *)L_44);
		Expression_t30A004209C10C2D9A9785B2F74EEED431A4D4660 * L_45;
		L_45 = DynamicMetaObject_get_Expression_m56AEEE5B82DB27F8490D27758D6ECAEC19BE64C2_inline((DynamicMetaObject_t5279001ADBFAB6EF015CAC54937F4E9F003881C3 *)L_44, /*hidden argument*/NULL);
		RuntimeTypeHandle_tC33965ADA3E041E0C94AF05E5CB527B56482CEF9  L_46 = { reinterpret_cast<intptr_t> (RuntimeObject_0_0_0_var) };
		Type_t * L_47;
		L_47 = Type_GetTypeFromHandle_m8BB57524FF7F9DB1803BC561D2B3A4DBACEB385E((RuntimeTypeHandle_tC33965ADA3E041E0C94AF05E5CB527B56482CEF9 )L_46, /*hidden argument*/NULL);
		ConditionalExpression_t74C60793A382D6FC191C590A353984ED63ED3D4A * L_48;
		L_48 = Expression_Condition_mDAAB02AA8FE6525ECAE36CAF26695ADBFA738260((Expression_t30A004209C10C2D9A9785B2F74EEED431A4D4660 *)L_38, (Expression_t30A004209C10C2D9A9785B2F74EEED431A4D4660 *)L_43, (Expression_t30A004209C10C2D9A9785B2F74EEED431A4D4660 *)L_45, (Type_t *)L_47, /*hidden argument*/NULL);
		NullCheck(L_25);
		ArrayElementTypeCheck (L_25, L_48);
		(L_25)->SetAt(static_cast<il2cpp_array_size_t>(1), (Expression_t30A004209C10C2D9A9785B2F74EEED431A4D4660 *)L_48);
		TrueReadOnlyCollection_1_t06D7E0A73C830464D87F10A513072796E7172082 * L_49 = (TrueReadOnlyCollection_1_t06D7E0A73C830464D87F10A513072796E7172082 *)il2cpp_codegen_object_new(TrueReadOnlyCollection_1_t06D7E0A73C830464D87F10A513072796E7172082_il2cpp_TypeInfo_var);
		TrueReadOnlyCollection_1__ctor_m69554AD79082CEEEE9808387797E4A9C052A1820(L_49, (ExpressionU5BU5D_t4F1F138488EBD58837D142B40E0E4EEFC607EA63*)L_25, /*hidden argument*/TrueReadOnlyCollection_1__ctor_m69554AD79082CEEEE9808387797E4A9C052A1820_RuntimeMethod_var);
		BlockExpression_t429D310E740322594C18397DEAE7E17DCFE0E0BB * L_50;
		L_50 = Expression_Block_mA6CB052758601202DB19D5181835168D9CE6F908((RuntimeObject*)L_16, (RuntimeObject*)L_49, /*hidden argument*/NULL);
		NullCheck((MetaDynamic_t774AF4A12F33149209C1FA08022AB0EE951BFB7C *)__this);
		BindingRestrictions_t03E14FA0517A70DEDA502032CE956595EF6E0DFC * L_51;
		L_51 = MetaDynamic_GetRestrictions_mFD3843F7B4CCBFC34A3C66170CA03B3E19504F38((MetaDynamic_t774AF4A12F33149209C1FA08022AB0EE951BFB7C *)__this, /*hidden argument*/NULL);
		DynamicMetaObject_t5279001ADBFAB6EF015CAC54937F4E9F003881C3 * L_52 = V_0;
		NullCheck((DynamicMetaObject_t5279001ADBFAB6EF015CAC54937F4E9F003881C3 *)L_52);
		BindingRestrictions_t03E14FA0517A70DEDA502032CE956595EF6E0DFC * L_53;
		L_53 = DynamicMetaObject_get_Restrictions_mE04FE62E32906462628D87A3341521ABFADC63C5_inline((DynamicMetaObject_t5279001ADBFAB6EF015CAC54937F4E9F003881C3 *)L_52, /*hidden argument*/NULL);
		NullCheck((BindingRestrictions_t03E14FA0517A70DEDA502032CE956595EF6E0DFC *)L_51);
		BindingRestrictions_t03E14FA0517A70DEDA502032CE956595EF6E0DFC * L_54;
		L_54 = BindingRestrictions_Merge_mA5D48059166AC655BF2CDF39CC199F4CE3400D19((BindingRestrictions_t03E14FA0517A70DEDA502032CE956595EF6E0DFC *)L_51, (BindingRestrictions_t03E14FA0517A70DEDA502032CE956595EF6E0DFC *)L_53, /*hidden argument*/NULL);
		DynamicMetaObject_t5279001ADBFAB6EF015CAC54937F4E9F003881C3 * L_55 = (DynamicMetaObject_t5279001ADBFAB6EF015CAC54937F4E9F003881C3 *)il2cpp_codegen_object_new(DynamicMetaObject_t5279001ADBFAB6EF015CAC54937F4E9F003881C3_il2cpp_TypeInfo_var);
		DynamicMetaObject__ctor_m2851C1E47FD59D49C80E454597607C1F4A8458AA(L_55, (Expression_t30A004209C10C2D9A9785B2F74EEED431A4D4660 *)L_50, (BindingRestrictions_t03E14FA0517A70DEDA502032CE956595EF6E0DFC *)L_54, /*hidden argument*/NULL);
		V_4 = (DynamicMetaObject_t5279001ADBFAB6EF015CAC54937F4E9F003881C3 *)L_55;
		Fallback_1_t80F90982EFE3FFA9073E13C782ABA43FD48B7A9A * L_56 = ___fallback4;
		RuntimeObject * L_57 = ___binder1;
		DynamicMetaObject_t5279001ADBFAB6EF015CAC54937F4E9F003881C3 * L_58 = V_4;
		NullCheck((Fallback_1_t80F90982EFE3FFA9073E13C782ABA43FD48B7A9A *)L_56);
		DynamicMetaObject_t5279001ADBFAB6EF015CAC54937F4E9F003881C3 * L_59;
		L_59 = ((  DynamicMetaObject_t5279001ADBFAB6EF015CAC54937F4E9F003881C3 * (*) (Fallback_1_t80F90982EFE3FFA9073E13C782ABA43FD48B7A9A *, MetaDynamic_t774AF4A12F33149209C1FA08022AB0EE951BFB7C *, RuntimeObject *, DynamicMetaObject_t5279001ADBFAB6EF015CAC54937F4E9F003881C3 *, const RuntimeMethod*))IL2CPP_RGCTX_METHOD_INFO(method->rgctx_data, 0)->methodPointer)((Fallback_1_t80F90982EFE3FFA9073E13C782ABA43FD48B7A9A *)L_56, (MetaDynamic_t774AF4A12F33149209C1FA08022AB0EE951BFB7C *)__this, (RuntimeObject *)L_57, (DynamicMetaObject_t5279001ADBFAB6EF015CAC54937F4E9F003881C3 *)L_58, /*hidden argument*/IL2CPP_RGCTX_METHOD_INFO(method->rgctx_data, 0));
		return (DynamicMetaObject_t5279001ADBFAB6EF015CAC54937F4E9F003881C3 *)L_59;
	}
}
// System.Dynamic.DynamicMetaObject System.Dynamic.DynamicObject/MetaDynamic::CallMethodWithResult<System.Object>(System.Reflection.MethodInfo,TBinder,System.Linq.Expressions.Expression[],System.Dynamic.DynamicObject/MetaDynamic/Fallback`1<TBinder>)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR DynamicMetaObject_t5279001ADBFAB6EF015CAC54937F4E9F003881C3 * MetaDynamic_CallMethodWithResult_TisRuntimeObject_m15341E06D1A05B748FE6777F1E2B2766F3D591CB_gshared (MetaDynamic_t774AF4A12F33149209C1FA08022AB0EE951BFB7C * __this, MethodInfo_t * ___method0, RuntimeObject * ___binder1, ExpressionU5BU5D_t4F1F138488EBD58837D142B40E0E4EEFC607EA63* ___args2, Fallback_1_t80F90982EFE3FFA9073E13C782ABA43FD48B7A9A * ___fallback3, const RuntimeMethod* method)
{
	{
		MethodInfo_t * L_0 = ___method0;
		RuntimeObject * L_1 = ___binder1;
		ExpressionU5BU5D_t4F1F138488EBD58837D142B40E0E4EEFC607EA63* L_2 = ___args2;
		Fallback_1_t80F90982EFE3FFA9073E13C782ABA43FD48B7A9A * L_3 = ___fallback3;
		NullCheck((MetaDynamic_t774AF4A12F33149209C1FA08022AB0EE951BFB7C *)__this);
		DynamicMetaObject_t5279001ADBFAB6EF015CAC54937F4E9F003881C3 * L_4;
		L_4 = ((  DynamicMetaObject_t5279001ADBFAB6EF015CAC54937F4E9F003881C3 * (*) (MetaDynamic_t774AF4A12F33149209C1FA08022AB0EE951BFB7C *, MethodInfo_t *, RuntimeObject *, ExpressionU5BU5D_t4F1F138488EBD58837D142B40E0E4EEFC607EA63*, Fallback_1_t80F90982EFE3FFA9073E13C782ABA43FD48B7A9A *, Fallback_1_t80F90982EFE3FFA9073E13C782ABA43FD48B7A9A *, const RuntimeMethod*))IL2CPP_RGCTX_METHOD_INFO(method->rgctx_data, 0)->methodPointer)((MetaDynamic_t774AF4A12F33149209C1FA08022AB0EE951BFB7C *)__this, (MethodInfo_t *)L_0, (RuntimeObject *)L_1, (ExpressionU5BU5D_t4F1F138488EBD58837D142B40E0E4EEFC607EA63*)L_2, (Fallback_1_t80F90982EFE3FFA9073E13C782ABA43FD48B7A9A *)L_3, (Fallback_1_t80F90982EFE3FFA9073E13C782ABA43FD48B7A9A *)NULL, /*hidden argument*/IL2CPP_RGCTX_METHOD_INFO(method->rgctx_data, 0));
		return (DynamicMetaObject_t5279001ADBFAB6EF015CAC54937F4E9F003881C3 *)L_4;
	}
}
// System.Dynamic.DynamicMetaObject System.Dynamic.DynamicObject/MetaDynamic::CallMethodWithResult<System.Object>(System.Reflection.MethodInfo,TBinder,System.Linq.Expressions.Expression[],System.Dynamic.DynamicObject/MetaDynamic/Fallback`1<TBinder>,System.Dynamic.DynamicObject/MetaDynamic/Fallback`1<TBinder>)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR DynamicMetaObject_t5279001ADBFAB6EF015CAC54937F4E9F003881C3 * MetaDynamic_CallMethodWithResult_TisRuntimeObject_m00A8676D77692765FEE71BC5002E7C688158653E_gshared (MetaDynamic_t774AF4A12F33149209C1FA08022AB0EE951BFB7C * __this, MethodInfo_t * ___method0, RuntimeObject * ___binder1, ExpressionU5BU5D_t4F1F138488EBD58837D142B40E0E4EEFC607EA63* ___args2, Fallback_1_t80F90982EFE3FFA9073E13C782ABA43FD48B7A9A * ___fallback3, Fallback_1_t80F90982EFE3FFA9073E13C782ABA43FD48B7A9A * ___fallbackInvoke4, const RuntimeMethod* method)
{
	DynamicMetaObject_t5279001ADBFAB6EF015CAC54937F4E9F003881C3 * V_0 = NULL;
	DynamicMetaObject_t5279001ADBFAB6EF015CAC54937F4E9F003881C3 * V_1 = NULL;
	{
		Fallback_1_t80F90982EFE3FFA9073E13C782ABA43FD48B7A9A * L_0 = ___fallback3;
		RuntimeObject * L_1 = ___binder1;
		NullCheck((Fallback_1_t80F90982EFE3FFA9073E13C782ABA43FD48B7A9A *)L_0);
		DynamicMetaObject_t5279001ADBFAB6EF015CAC54937F4E9F003881C3 * L_2;
		L_2 = ((  DynamicMetaObject_t5279001ADBFAB6EF015CAC54937F4E9F003881C3 * (*) (Fallback_1_t80F90982EFE3FFA9073E13C782ABA43FD48B7A9A *, MetaDynamic_t774AF4A12F33149209C1FA08022AB0EE951BFB7C *, RuntimeObject *, DynamicMetaObject_t5279001ADBFAB6EF015CAC54937F4E9F003881C3 *, const RuntimeMethod*))IL2CPP_RGCTX_METHOD_INFO(method->rgctx_data, 0)->methodPointer)((Fallback_1_t80F90982EFE3FFA9073E13C782ABA43FD48B7A9A *)L_0, (MetaDynamic_t774AF4A12F33149209C1FA08022AB0EE951BFB7C *)__this, (RuntimeObject *)L_1, (DynamicMetaObject_t5279001ADBFAB6EF015CAC54937F4E9F003881C3 *)NULL, /*hidden argument*/IL2CPP_RGCTX_METHOD_INFO(method->rgctx_data, 0));
		V_0 = (DynamicMetaObject_t5279001ADBFAB6EF015CAC54937F4E9F003881C3 *)L_2;
		MethodInfo_t * L_3 = ___method0;
		RuntimeObject * L_4 = ___binder1;
		ExpressionU5BU5D_t4F1F138488EBD58837D142B40E0E4EEFC607EA63* L_5 = ___args2;
		DynamicMetaObject_t5279001ADBFAB6EF015CAC54937F4E9F003881C3 * L_6 = V_0;
		Fallback_1_t80F90982EFE3FFA9073E13C782ABA43FD48B7A9A * L_7 = ___fallbackInvoke4;
		NullCheck((MetaDynamic_t774AF4A12F33149209C1FA08022AB0EE951BFB7C *)__this);
		DynamicMetaObject_t5279001ADBFAB6EF015CAC54937F4E9F003881C3 * L_8;
		L_8 = ((  DynamicMetaObject_t5279001ADBFAB6EF015CAC54937F4E9F003881C3 * (*) (MetaDynamic_t774AF4A12F33149209C1FA08022AB0EE951BFB7C *, MethodInfo_t *, RuntimeObject *, ExpressionU5BU5D_t4F1F138488EBD58837D142B40E0E4EEFC607EA63*, DynamicMetaObject_t5279001ADBFAB6EF015CAC54937F4E9F003881C3 *, Fallback_1_t80F90982EFE3FFA9073E13C782ABA43FD48B7A9A *, const RuntimeMethod*))IL2CPP_RGCTX_METHOD_INFO(method->rgctx_data, 1)->methodPointer)((MetaDynamic_t774AF4A12F33149209C1FA08022AB0EE951BFB7C *)__this, (MethodInfo_t *)L_3, (RuntimeObject *)L_4, (ExpressionU5BU5D_t4F1F138488EBD58837D142B40E0E4EEFC607EA63*)L_5, (DynamicMetaObject_t5279001ADBFAB6EF015CAC54937F4E9F003881C3 *)L_6, (Fallback_1_t80F90982EFE3FFA9073E13C782ABA43FD48B7A9A *)L_7, /*hidden argument*/IL2CPP_RGCTX_METHOD_INFO(method->rgctx_data, 1));
		V_1 = (DynamicMetaObject_t5279001ADBFAB6EF015CAC54937F4E9F003881C3 *)L_8;
		Fallback_1_t80F90982EFE3FFA9073E13C782ABA43FD48B7A9A * L_9 = ___fallback3;
		RuntimeObject * L_10 = ___binder1;
		DynamicMetaObject_t5279001ADBFAB6EF015CAC54937F4E9F003881C3 * L_11 = V_1;
		NullCheck((Fallback_1_t80F90982EFE3FFA9073E13C782ABA43FD48B7A9A *)L_9);
		DynamicMetaObject_t5279001ADBFAB6EF015CAC54937F4E9F003881C3 * L_12;
		L_12 = ((  DynamicMetaObject_t5279001ADBFAB6EF015CAC54937F4E9F003881C3 * (*) (Fallback_1_t80F90982EFE3FFA9073E13C782ABA43FD48B7A9A *, MetaDynamic_t774AF4A12F33149209C1FA08022AB0EE951BFB7C *, RuntimeObject *, DynamicMetaObject_t5279001ADBFAB6EF015CAC54937F4E9F003881C3 *, const RuntimeMethod*))IL2CPP_RGCTX_METHOD_INFO(method->rgctx_data, 0)->methodPointer)((Fallback_1_t80F90982EFE3FFA9073E13C782ABA43FD48B7A9A *)L_9, (MetaDynamic_t774AF4A12F33149209C1FA08022AB0EE951BFB7C *)__this, (RuntimeObject *)L_10, (DynamicMetaObject_t5279001ADBFAB6EF015CAC54937F4E9F003881C3 *)L_11, /*hidden argument*/IL2CPP_RGCTX_METHOD_INFO(method->rgctx_data, 0));
		return (DynamicMetaObject_t5279001ADBFAB6EF015CAC54937F4E9F003881C3 *)L_12;
	}
}
// System.Linq.Expressions.ConstantExpression System.Dynamic.DynamicObject/MetaDynamic::Constant<System.Object>(TBinder)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR ConstantExpression_tE22239C4AE815AF9B4647E026E802623F433F0FB * MetaDynamic_Constant_TisRuntimeObject_m80122CDEB9137B2C40827F6D07E655AABD063608_gshared (RuntimeObject * ___binder0, const RuntimeMethod* method)
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Expression_t30A004209C10C2D9A9785B2F74EEED431A4D4660_il2cpp_TypeInfo_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Type_t_il2cpp_TypeInfo_var);
		s_Il2CppMethodInitialized = true;
	}
	{
		RuntimeObject * L_0 = ___binder0;
		RuntimeTypeHandle_tC33965ADA3E041E0C94AF05E5CB527B56482CEF9  L_1 = { reinterpret_cast<intptr_t> (IL2CPP_RGCTX_TYPE(method->rgctx_data, 1)) };
		IL2CPP_RUNTIME_CLASS_INIT(Type_t_il2cpp_TypeInfo_var);
		Type_t * L_2;
		L_2 = Type_GetTypeFromHandle_m8BB57524FF7F9DB1803BC561D2B3A4DBACEB385E((RuntimeTypeHandle_tC33965ADA3E041E0C94AF05E5CB527B56482CEF9 )L_1, /*hidden argument*/NULL);
		IL2CPP_RUNTIME_CLASS_INIT(Expression_t30A004209C10C2D9A9785B2F74EEED431A4D4660_il2cpp_TypeInfo_var);
		ConstantExpression_tE22239C4AE815AF9B4647E026E802623F433F0FB * L_3;
		L_3 = Expression_Constant_m014E12A7CCA8E2705E27CA97B85616EBE181F3FF((RuntimeObject *)L_0, (Type_t *)L_2, /*hidden argument*/NULL);
		return (ConstantExpression_tE22239C4AE815AF9B4647E026E802623F433F0FB *)L_3;
	}
}
// System.Linq.Expressions.Expression System.Linq.Expressions.Interpreter.LightCompiler/QuoteVisitor::VisitLambda<System.Object>(System.Linq.Expressions.Expression`1<T>)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR Expression_t30A004209C10C2D9A9785B2F74EEED431A4D4660 * QuoteVisitor_VisitLambda_TisRuntimeObject_mF0A4AC2198AACA7CB1D4527BC7E79D3D9DAF8F72_gshared (QuoteVisitor_tFE404B4C826642C3FC245A108AEC9E94D691E627 * __this, Expression_1_t01B093F396848A065BE827B0C58E6F20E760FB6F * ___node0, const RuntimeMethod* method)
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Array_Empty_TisParameterExpression_tA7B24F1DE0F013DA4BD55F76DB43B06DB33D8BEE_m8FAF2226E6288860C1D3C92AB793820D17F32D71_RuntimeMethod_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&List_1_Add_mC5D74D70A6B9B4BC082AEB0EC771879B842C7708_RuntimeMethod_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&List_1__ctor_mE4C9B3F15E5D5168479F4E7227A000B97C871A30_RuntimeMethod_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&List_1_tCDDF33E8793E2DD752E38CC326B13F8F35B1493B_il2cpp_TypeInfo_var);
		s_Il2CppMethodInitialized = true;
	}
	RuntimeObject* V_0 = NULL;
	int32_t V_1 = 0;
	List_1_tCDDF33E8793E2DD752E38CC326B13F8F35B1493B * V_2 = NULL;
	int32_t V_3 = 0;
	{
		ParameterExpressionU5BU5D_tCF3EAA6D8556513C4937E1126F65AA08DF4DB147* L_0;
		L_0 = Array_Empty_TisParameterExpression_tA7B24F1DE0F013DA4BD55F76DB43B06DB33D8BEE_m8FAF2226E6288860C1D3C92AB793820D17F32D71_inline(/*hidden argument*/Array_Empty_TisParameterExpression_tA7B24F1DE0F013DA4BD55F76DB43B06DB33D8BEE_m8FAF2226E6288860C1D3C92AB793820D17F32D71_RuntimeMethod_var);
		V_0 = (RuntimeObject*)L_0;
		Expression_1_t01B093F396848A065BE827B0C58E6F20E760FB6F * L_1 = ___node0;
		NullCheck((LambdaExpression_t26BF905E97E6D94F81F17D60F4F4F47F8E93B474 *)L_1);
		int32_t L_2;
		L_2 = VirtFuncInvoker0< int32_t >::Invoke(18 /* System.Int32 System.Linq.Expressions.LambdaExpression::get_ParameterCount() */, (LambdaExpression_t26BF905E97E6D94F81F17D60F4F4F47F8E93B474 *)L_1);
		V_1 = (int32_t)L_2;
		int32_t L_3 = V_1;
		if ((((int32_t)L_3) <= ((int32_t)0)))
		{
			goto IL_0033;
		}
	}
	{
		int32_t L_4 = V_1;
		List_1_tCDDF33E8793E2DD752E38CC326B13F8F35B1493B * L_5 = (List_1_tCDDF33E8793E2DD752E38CC326B13F8F35B1493B *)il2cpp_codegen_object_new(List_1_tCDDF33E8793E2DD752E38CC326B13F8F35B1493B_il2cpp_TypeInfo_var);
		List_1__ctor_mE4C9B3F15E5D5168479F4E7227A000B97C871A30(L_5, (int32_t)L_4, /*hidden argument*/List_1__ctor_mE4C9B3F15E5D5168479F4E7227A000B97C871A30_RuntimeMethod_var);
		V_2 = (List_1_tCDDF33E8793E2DD752E38CC326B13F8F35B1493B *)L_5;
		V_3 = (int32_t)0;
		goto IL_002d;
	}

IL_001c:
	{
		List_1_tCDDF33E8793E2DD752E38CC326B13F8F35B1493B * L_6 = V_2;
		Expression_1_t01B093F396848A065BE827B0C58E6F20E760FB6F * L_7 = ___node0;
		int32_t L_8 = V_3;
		NullCheck((LambdaExpression_t26BF905E97E6D94F81F17D60F4F4F47F8E93B474 *)L_7);
		ParameterExpression_tA7B24F1DE0F013DA4BD55F76DB43B06DB33D8BEE * L_9;
		L_9 = VirtFuncInvoker1< ParameterExpression_tA7B24F1DE0F013DA4BD55F76DB43B06DB33D8BEE *, int32_t >::Invoke(17 /* System.Linq.Expressions.ParameterExpression System.Linq.Expressions.LambdaExpression::GetParameter(System.Int32) */, (LambdaExpression_t26BF905E97E6D94F81F17D60F4F4F47F8E93B474 *)L_7, (int32_t)L_8);
		NullCheck((List_1_tCDDF33E8793E2DD752E38CC326B13F8F35B1493B *)L_6);
		List_1_Add_mC5D74D70A6B9B4BC082AEB0EC771879B842C7708((List_1_tCDDF33E8793E2DD752E38CC326B13F8F35B1493B *)L_6, (ParameterExpression_tA7B24F1DE0F013DA4BD55F76DB43B06DB33D8BEE *)L_9, /*hidden argument*/List_1_Add_mC5D74D70A6B9B4BC082AEB0EC771879B842C7708_RuntimeMethod_var);
		int32_t L_10 = V_3;
		V_3 = (int32_t)((int32_t)il2cpp_codegen_add((int32_t)L_10, (int32_t)1));
	}

IL_002d:
	{
		int32_t L_11 = V_3;
		int32_t L_12 = V_1;
		if ((((int32_t)L_11) < ((int32_t)L_12)))
		{
			goto IL_001c;
		}
	}
	{
		List_1_tCDDF33E8793E2DD752E38CC326B13F8F35B1493B * L_13 = V_2;
		V_0 = (RuntimeObject*)L_13;
	}

IL_0033:
	{
		RuntimeObject* L_14 = V_0;
		NullCheck((QuoteVisitor_tFE404B4C826642C3FC245A108AEC9E94D691E627 *)__this);
		QuoteVisitor_PushParameters_m7AAC447E0627A0AD1A5EBAB7A7AFFD5F239CC0ED((QuoteVisitor_tFE404B4C826642C3FC245A108AEC9E94D691E627 *)__this, (RuntimeObject*)L_14, /*hidden argument*/NULL);
		Expression_1_t01B093F396848A065BE827B0C58E6F20E760FB6F * L_15 = ___node0;
		NullCheck((ExpressionVisitor_tD098DE8A366FBBB58C498C4EFF8B003FCA726DF4 *)__this);
		Expression_t30A004209C10C2D9A9785B2F74EEED431A4D4660 * L_16;
		L_16 = ((  Expression_t30A004209C10C2D9A9785B2F74EEED431A4D4660 * (*) (ExpressionVisitor_tD098DE8A366FBBB58C498C4EFF8B003FCA726DF4 *, Expression_1_t01B093F396848A065BE827B0C58E6F20E760FB6F *, const RuntimeMethod*))IL2CPP_RGCTX_METHOD_INFO(method->rgctx_data, 0)->methodPointer)((ExpressionVisitor_tD098DE8A366FBBB58C498C4EFF8B003FCA726DF4 *)__this, (Expression_1_t01B093F396848A065BE827B0C58E6F20E760FB6F *)L_15, /*hidden argument*/IL2CPP_RGCTX_METHOD_INFO(method->rgctx_data, 0));
		RuntimeObject* L_17 = V_0;
		NullCheck((QuoteVisitor_tFE404B4C826642C3FC245A108AEC9E94D691E627 *)__this);
		QuoteVisitor_PopParameters_m88C9C499B152E0333072D63BFD2908F2D710495A((QuoteVisitor_tFE404B4C826642C3FC245A108AEC9E94D691E627 *)__this, (RuntimeObject*)L_17, /*hidden argument*/NULL);
		Expression_1_t01B093F396848A065BE827B0C58E6F20E760FB6F * L_18 = ___node0;
		return (Expression_t30A004209C10C2D9A9785B2F74EEED431A4D4660 *)L_18;
	}
}
// System.Linq.Expressions.Expression System.Linq.Expressions.Interpreter.QuoteInstruction/ExpressionQuoter::VisitLambda<System.Object>(System.Linq.Expressions.Expression`1<T>)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR Expression_t30A004209C10C2D9A9785B2F74EEED431A4D4660 * ExpressionQuoter_VisitLambda_TisRuntimeObject_m35F891348C1626D5AB57E495CE369CC7865BF436_gshared (ExpressionQuoter_t174D328A07E522775BA6B19ADF09DBEAF13098FE * __this, Expression_1_t01B093F396848A065BE827B0C58E6F20E760FB6F * ___node0, const RuntimeMethod* method)
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&HashSet_1_Add_m97A1CDFD6C8F09EC6D4C676F183FBAF06EC20CDE_RuntimeMethod_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&HashSet_1__ctor_m7E015D0E7832B3967403CAEE703C819D77AE741B_RuntimeMethod_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&HashSet_1_t42A3AC337CA15FAC250AA5DA438F909806C72CB0_il2cpp_TypeInfo_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Stack_1_Pop_mE1B2B7343AEB424CD56DCD92DE34D64249A26769_RuntimeMethod_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Stack_1_Push_m97F7795161150F81DB993EFB230CD48A2B2A369C_RuntimeMethod_var);
		s_Il2CppMethodInitialized = true;
	}
	Expression_t30A004209C10C2D9A9785B2F74EEED431A4D4660 * V_0 = NULL;
	HashSet_1_t42A3AC337CA15FAC250AA5DA438F909806C72CB0 * V_1 = NULL;
	int32_t V_2 = 0;
	int32_t V_3 = 0;
	{
		Expression_1_t01B093F396848A065BE827B0C58E6F20E760FB6F * L_0 = ___node0;
		NullCheck((LambdaExpression_t26BF905E97E6D94F81F17D60F4F4F47F8E93B474 *)L_0);
		int32_t L_1;
		L_1 = VirtFuncInvoker0< int32_t >::Invoke(18 /* System.Int32 System.Linq.Expressions.LambdaExpression::get_ParameterCount() */, (LambdaExpression_t26BF905E97E6D94F81F17D60F4F4F47F8E93B474 *)L_0);
		if ((((int32_t)L_1) <= ((int32_t)0)))
		{
			goto IL_003c;
		}
	}
	{
		HashSet_1_t42A3AC337CA15FAC250AA5DA438F909806C72CB0 * L_2 = (HashSet_1_t42A3AC337CA15FAC250AA5DA438F909806C72CB0 *)il2cpp_codegen_object_new(HashSet_1_t42A3AC337CA15FAC250AA5DA438F909806C72CB0_il2cpp_TypeInfo_var);
		HashSet_1__ctor_m7E015D0E7832B3967403CAEE703C819D77AE741B(L_2, /*hidden argument*/HashSet_1__ctor_m7E015D0E7832B3967403CAEE703C819D77AE741B_RuntimeMethod_var);
		V_1 = (HashSet_1_t42A3AC337CA15FAC250AA5DA438F909806C72CB0 *)L_2;
		V_2 = (int32_t)0;
		Expression_1_t01B093F396848A065BE827B0C58E6F20E760FB6F * L_3 = ___node0;
		NullCheck((LambdaExpression_t26BF905E97E6D94F81F17D60F4F4F47F8E93B474 *)L_3);
		int32_t L_4;
		L_4 = VirtFuncInvoker0< int32_t >::Invoke(18 /* System.Int32 System.Linq.Expressions.LambdaExpression::get_ParameterCount() */, (LambdaExpression_t26BF905E97E6D94F81F17D60F4F4F47F8E93B474 *)L_3);
		V_3 = (int32_t)L_4;
		goto IL_002c;
	}

IL_001a:
	{
		HashSet_1_t42A3AC337CA15FAC250AA5DA438F909806C72CB0 * L_5 = V_1;
		Expression_1_t01B093F396848A065BE827B0C58E6F20E760FB6F * L_6 = ___node0;
		int32_t L_7 = V_2;
		NullCheck((LambdaExpression_t26BF905E97E6D94F81F17D60F4F4F47F8E93B474 *)L_6);
		ParameterExpression_tA7B24F1DE0F013DA4BD55F76DB43B06DB33D8BEE * L_8;
		L_8 = VirtFuncInvoker1< ParameterExpression_tA7B24F1DE0F013DA4BD55F76DB43B06DB33D8BEE *, int32_t >::Invoke(17 /* System.Linq.Expressions.ParameterExpression System.Linq.Expressions.LambdaExpression::GetParameter(System.Int32) */, (LambdaExpression_t26BF905E97E6D94F81F17D60F4F4F47F8E93B474 *)L_6, (int32_t)L_7);
		NullCheck((HashSet_1_t42A3AC337CA15FAC250AA5DA438F909806C72CB0 *)L_5);
		bool L_9;
		L_9 = HashSet_1_Add_m97A1CDFD6C8F09EC6D4C676F183FBAF06EC20CDE((HashSet_1_t42A3AC337CA15FAC250AA5DA438F909806C72CB0 *)L_5, (ParameterExpression_tA7B24F1DE0F013DA4BD55F76DB43B06DB33D8BEE *)L_8, /*hidden argument*/HashSet_1_Add_m97A1CDFD6C8F09EC6D4C676F183FBAF06EC20CDE_RuntimeMethod_var);
		int32_t L_10 = V_2;
		V_2 = (int32_t)((int32_t)il2cpp_codegen_add((int32_t)L_10, (int32_t)1));
	}

IL_002c:
	{
		int32_t L_11 = V_2;
		int32_t L_12 = V_3;
		if ((((int32_t)L_11) < ((int32_t)L_12)))
		{
			goto IL_001a;
		}
	}
	{
		Stack_1_t438C22E9DF33740A9BDB48CF9504B6E044484958 * L_13 = (Stack_1_t438C22E9DF33740A9BDB48CF9504B6E044484958 *)__this->get__shadowedVars_2();
		HashSet_1_t42A3AC337CA15FAC250AA5DA438F909806C72CB0 * L_14 = V_1;
		NullCheck((Stack_1_t438C22E9DF33740A9BDB48CF9504B6E044484958 *)L_13);
		Stack_1_Push_m97F7795161150F81DB993EFB230CD48A2B2A369C((Stack_1_t438C22E9DF33740A9BDB48CF9504B6E044484958 *)L_13, (HashSet_1_t42A3AC337CA15FAC250AA5DA438F909806C72CB0 *)L_14, /*hidden argument*/Stack_1_Push_m97F7795161150F81DB993EFB230CD48A2B2A369C_RuntimeMethod_var);
	}

IL_003c:
	{
		Expression_1_t01B093F396848A065BE827B0C58E6F20E760FB6F * L_15 = ___node0;
		NullCheck((LambdaExpression_t26BF905E97E6D94F81F17D60F4F4F47F8E93B474 *)L_15);
		Expression_t30A004209C10C2D9A9785B2F74EEED431A4D4660 * L_16;
		L_16 = LambdaExpression_get_Body_m595A485419E2F0AA13FC2695DEBD99ED9712D042_inline((LambdaExpression_t26BF905E97E6D94F81F17D60F4F4F47F8E93B474 *)L_15, /*hidden argument*/NULL);
		NullCheck((ExpressionVisitor_tD098DE8A366FBBB58C498C4EFF8B003FCA726DF4 *)__this);
		Expression_t30A004209C10C2D9A9785B2F74EEED431A4D4660 * L_17;
		L_17 = VirtFuncInvoker1< Expression_t30A004209C10C2D9A9785B2F74EEED431A4D4660 *, Expression_t30A004209C10C2D9A9785B2F74EEED431A4D4660 * >::Invoke(4 /* System.Linq.Expressions.Expression System.Linq.Expressions.ExpressionVisitor::Visit(System.Linq.Expressions.Expression) */, (ExpressionVisitor_tD098DE8A366FBBB58C498C4EFF8B003FCA726DF4 *)__this, (Expression_t30A004209C10C2D9A9785B2F74EEED431A4D4660 *)L_16);
		V_0 = (Expression_t30A004209C10C2D9A9785B2F74EEED431A4D4660 *)L_17;
		Expression_1_t01B093F396848A065BE827B0C58E6F20E760FB6F * L_18 = ___node0;
		NullCheck((LambdaExpression_t26BF905E97E6D94F81F17D60F4F4F47F8E93B474 *)L_18);
		int32_t L_19;
		L_19 = VirtFuncInvoker0< int32_t >::Invoke(18 /* System.Int32 System.Linq.Expressions.LambdaExpression::get_ParameterCount() */, (LambdaExpression_t26BF905E97E6D94F81F17D60F4F4F47F8E93B474 *)L_18);
		if ((((int32_t)L_19) <= ((int32_t)0)))
		{
			goto IL_005e;
		}
	}
	{
		Stack_1_t438C22E9DF33740A9BDB48CF9504B6E044484958 * L_20 = (Stack_1_t438C22E9DF33740A9BDB48CF9504B6E044484958 *)__this->get__shadowedVars_2();
		NullCheck((Stack_1_t438C22E9DF33740A9BDB48CF9504B6E044484958 *)L_20);
		HashSet_1_t42A3AC337CA15FAC250AA5DA438F909806C72CB0 * L_21;
		L_21 = Stack_1_Pop_mE1B2B7343AEB424CD56DCD92DE34D64249A26769((Stack_1_t438C22E9DF33740A9BDB48CF9504B6E044484958 *)L_20, /*hidden argument*/Stack_1_Pop_mE1B2B7343AEB424CD56DCD92DE34D64249A26769_RuntimeMethod_var);
	}

IL_005e:
	{
		Expression_t30A004209C10C2D9A9785B2F74EEED431A4D4660 * L_22 = V_0;
		Expression_1_t01B093F396848A065BE827B0C58E6F20E760FB6F * L_23 = ___node0;
		NullCheck((LambdaExpression_t26BF905E97E6D94F81F17D60F4F4F47F8E93B474 *)L_23);
		Expression_t30A004209C10C2D9A9785B2F74EEED431A4D4660 * L_24;
		L_24 = LambdaExpression_get_Body_m595A485419E2F0AA13FC2695DEBD99ED9712D042_inline((LambdaExpression_t26BF905E97E6D94F81F17D60F4F4F47F8E93B474 *)L_23, /*hidden argument*/NULL);
		if ((!(((RuntimeObject*)(Expression_t30A004209C10C2D9A9785B2F74EEED431A4D4660 *)L_22) == ((RuntimeObject*)(Expression_t30A004209C10C2D9A9785B2F74EEED431A4D4660 *)L_24))))
		{
			goto IL_0069;
		}
	}
	{
		Expression_1_t01B093F396848A065BE827B0C58E6F20E760FB6F * L_25 = ___node0;
		return (Expression_t30A004209C10C2D9A9785B2F74EEED431A4D4660 *)L_25;
	}

IL_0069:
	{
		Expression_1_t01B093F396848A065BE827B0C58E6F20E760FB6F * L_26 = ___node0;
		Expression_t30A004209C10C2D9A9785B2F74EEED431A4D4660 * L_27 = V_0;
		NullCheck((Expression_1_t01B093F396848A065BE827B0C58E6F20E760FB6F *)L_26);
		Expression_1_t01B093F396848A065BE827B0C58E6F20E760FB6F * L_28;
		L_28 = VirtFuncInvoker2< Expression_1_t01B093F396848A065BE827B0C58E6F20E760FB6F *, Expression_t30A004209C10C2D9A9785B2F74EEED431A4D4660 *, ParameterExpressionU5BU5D_tCF3EAA6D8556513C4937E1126F65AA08DF4DB147* >::Invoke(20 /* System.Linq.Expressions.Expression`1<TDelegate> System.Linq.Expressions.Expression`1<System.Object>::Rewrite(System.Linq.Expressions.Expression,System.Linq.Expressions.ParameterExpression[]) */, (Expression_1_t01B093F396848A065BE827B0C58E6F20E760FB6F *)L_26, (Expression_t30A004209C10C2D9A9785B2F74EEED431A4D4660 *)L_27, (ParameterExpressionU5BU5D_tCF3EAA6D8556513C4937E1126F65AA08DF4DB147*)(ParameterExpressionU5BU5D_tCF3EAA6D8556513C4937E1126F65AA08DF4DB147*)NULL);
		return (Expression_t30A004209C10C2D9A9785B2F74EEED431A4D4660 *)L_28;
	}
}
// System.Void System.Runtime.InteropServices.WindowsRuntime.WindowsRuntimeMarshal/ManagedEventRegistrationImpl::AddEventHandler<System.Object>(System.Func`2<T,System.Runtime.InteropServices.WindowsRuntime.EventRegistrationToken>,System.Action`1<System.Runtime.InteropServices.WindowsRuntime.EventRegistrationToken>,T)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void ManagedEventRegistrationImpl_AddEventHandler_TisRuntimeObject_m22C549D6251D785B853C0F4CC2CC687EEAFDDAF1_gshared (Func_2_t5650431F2BFFD75382D3BA01D19E366CD1DA1813 * ___addMethod0, Action_1_t91FC536003CAB9AB56B84E901AE08156372856E3 * ___removeMethod1, RuntimeObject * ___handler2, const RuntimeMethod* method)
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Dictionary_2_TryGetValue_mF842EC8D110A281144B0082DE75F29AE5261F24F_RuntimeMethod_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Dictionary_2_set_Item_mC31C547D1D8807C284FEE2E67821F99533C54EB7_RuntimeMethod_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&ManagedEventRegistrationImpl_t68BCFDC6DFC89A0F8CF53836672DD1F41C47CEEB_il2cpp_TypeInfo_var);
		s_Il2CppMethodInitialized = true;
	}
	Dictionary_2_t5BB631D653FC099355128DBC14DC44E27AD30739 * V_0 = NULL;
	EventRegistrationToken_t5460ED02F1A6B74B604DFD634E8D5429857E9830  V_1;
	memset((&V_1), 0, sizeof(V_1));
	Dictionary_2_t5BB631D653FC099355128DBC14DC44E27AD30739 * V_2 = NULL;
	bool V_3 = false;
	EventRegistrationTokenList_t0B8EB3E0DA8A305BFCD313936266A15F50B4B128  V_4;
	memset((&V_4), 0, sizeof(V_4));
	Exception_t * __last_unhandled_exception = 0;
	il2cpp::utils::ExceptionSupportStack<int32_t, 2> __leave_targets;
	{
		Action_1_t91FC536003CAB9AB56B84E901AE08156372856E3 * L_0 = ___removeMethod1;
		NullCheck((Delegate_t *)L_0);
		RuntimeObject * L_1;
		L_1 = Delegate_get_Target_mA4C35D598EE379F0F1D49EA8670620792D25EAB1_inline((Delegate_t *)L_0, /*hidden argument*/NULL);
		Action_1_t91FC536003CAB9AB56B84E901AE08156372856E3 * L_2 = ___removeMethod1;
		IL2CPP_RUNTIME_CLASS_INIT(ManagedEventRegistrationImpl_t68BCFDC6DFC89A0F8CF53836672DD1F41C47CEEB_il2cpp_TypeInfo_var);
		Dictionary_2_t5BB631D653FC099355128DBC14DC44E27AD30739 * L_3;
		L_3 = ManagedEventRegistrationImpl_GetEventRegistrationTokenTable_m8BBB3CF664BBC6EA31B8469EADEFD8EC1D82B8D3((RuntimeObject *)L_1, (Action_1_t91FC536003CAB9AB56B84E901AE08156372856E3 *)L_2, /*hidden argument*/NULL);
		V_0 = (Dictionary_2_t5BB631D653FC099355128DBC14DC44E27AD30739 *)L_3;
		Func_2_t5650431F2BFFD75382D3BA01D19E366CD1DA1813 * L_4 = ___addMethod0;
		RuntimeObject * L_5 = ___handler2;
		NullCheck((Func_2_t5650431F2BFFD75382D3BA01D19E366CD1DA1813 *)L_4);
		EventRegistrationToken_t5460ED02F1A6B74B604DFD634E8D5429857E9830  L_6;
		L_6 = ((  EventRegistrationToken_t5460ED02F1A6B74B604DFD634E8D5429857E9830  (*) (Func_2_t5650431F2BFFD75382D3BA01D19E366CD1DA1813 *, RuntimeObject *, const RuntimeMethod*))IL2CPP_RGCTX_METHOD_INFO(method->rgctx_data, 0)->methodPointer)((Func_2_t5650431F2BFFD75382D3BA01D19E366CD1DA1813 *)L_4, (RuntimeObject *)L_5, /*hidden argument*/IL2CPP_RGCTX_METHOD_INFO(method->rgctx_data, 0));
		V_1 = (EventRegistrationToken_t5460ED02F1A6B74B604DFD634E8D5429857E9830 )L_6;
		Dictionary_2_t5BB631D653FC099355128DBC14DC44E27AD30739 * L_7 = V_0;
		V_2 = (Dictionary_2_t5BB631D653FC099355128DBC14DC44E27AD30739 *)L_7;
		V_3 = (bool)0;
	}

IL_0019:
	try
	{ // begin try (depth: 1)
		{
			Dictionary_2_t5BB631D653FC099355128DBC14DC44E27AD30739 * L_8 = V_2;
			Monitor_Enter_mBEB6CC84184B46F26375EC3FC8921D16E48EA4C4((RuntimeObject *)L_8, (bool*)(bool*)(&V_3), /*hidden argument*/NULL);
			Dictionary_2_t5BB631D653FC099355128DBC14DC44E27AD30739 * L_9 = V_0;
			RuntimeObject * L_10 = ___handler2;
			NullCheck((Dictionary_2_t5BB631D653FC099355128DBC14DC44E27AD30739 *)L_9);
			bool L_11;
			L_11 = Dictionary_2_TryGetValue_mF842EC8D110A281144B0082DE75F29AE5261F24F((Dictionary_2_t5BB631D653FC099355128DBC14DC44E27AD30739 *)L_9, (RuntimeObject *)L_10, (EventRegistrationTokenList_t0B8EB3E0DA8A305BFCD313936266A15F50B4B128 *)(EventRegistrationTokenList_t0B8EB3E0DA8A305BFCD313936266A15F50B4B128 *)(&V_4), /*hidden argument*/Dictionary_2_TryGetValue_mF842EC8D110A281144B0082DE75F29AE5261F24F_RuntimeMethod_var);
			if (L_11)
			{
				goto IL_0049;
			}
		}

IL_0031:
		{
			EventRegistrationToken_t5460ED02F1A6B74B604DFD634E8D5429857E9830  L_12 = V_1;
			EventRegistrationTokenList__ctor_m06470FB422418EBC781CFC09992EE7D2F4EF9772((EventRegistrationTokenList_t0B8EB3E0DA8A305BFCD313936266A15F50B4B128 *)(EventRegistrationTokenList_t0B8EB3E0DA8A305BFCD313936266A15F50B4B128 *)(&V_4), (EventRegistrationToken_t5460ED02F1A6B74B604DFD634E8D5429857E9830 )L_12, /*hidden argument*/NULL);
			Dictionary_2_t5BB631D653FC099355128DBC14DC44E27AD30739 * L_13 = V_0;
			RuntimeObject * L_14 = ___handler2;
			EventRegistrationTokenList_t0B8EB3E0DA8A305BFCD313936266A15F50B4B128  L_15 = V_4;
			NullCheck((Dictionary_2_t5BB631D653FC099355128DBC14DC44E27AD30739 *)L_13);
			Dictionary_2_set_Item_mC31C547D1D8807C284FEE2E67821F99533C54EB7((Dictionary_2_t5BB631D653FC099355128DBC14DC44E27AD30739 *)L_13, (RuntimeObject *)L_14, (EventRegistrationTokenList_t0B8EB3E0DA8A305BFCD313936266A15F50B4B128 )L_15, /*hidden argument*/Dictionary_2_set_Item_mC31C547D1D8807C284FEE2E67821F99533C54EB7_RuntimeMethod_var);
			IL2CPP_LEAVE(0x6D, FINALLY_0063);
		}

IL_0049:
		{
			EventRegistrationToken_t5460ED02F1A6B74B604DFD634E8D5429857E9830  L_16 = V_1;
			bool L_17;
			L_17 = EventRegistrationTokenList_Push_mA05262483205E888368D766263A039078C98D8E8((EventRegistrationTokenList_t0B8EB3E0DA8A305BFCD313936266A15F50B4B128 *)(EventRegistrationTokenList_t0B8EB3E0DA8A305BFCD313936266A15F50B4B128 *)(&V_4), (EventRegistrationToken_t5460ED02F1A6B74B604DFD634E8D5429857E9830 )L_16, /*hidden argument*/NULL);
			if (!L_17)
			{
				goto IL_0061;
			}
		}

IL_0053:
		{
			Dictionary_2_t5BB631D653FC099355128DBC14DC44E27AD30739 * L_18 = V_0;
			RuntimeObject * L_19 = ___handler2;
			EventRegistrationTokenList_t0B8EB3E0DA8A305BFCD313936266A15F50B4B128  L_20 = V_4;
			NullCheck((Dictionary_2_t5BB631D653FC099355128DBC14DC44E27AD30739 *)L_18);
			Dictionary_2_set_Item_mC31C547D1D8807C284FEE2E67821F99533C54EB7((Dictionary_2_t5BB631D653FC099355128DBC14DC44E27AD30739 *)L_18, (RuntimeObject *)L_19, (EventRegistrationTokenList_t0B8EB3E0DA8A305BFCD313936266A15F50B4B128 )L_20, /*hidden argument*/Dictionary_2_set_Item_mC31C547D1D8807C284FEE2E67821F99533C54EB7_RuntimeMethod_var);
		}

IL_0061:
		{
			IL2CPP_LEAVE(0x6D, FINALLY_0063);
		}
	} // end try (depth: 1)
	catch(Il2CppExceptionWrapper& e)
	{
		__last_unhandled_exception = (Exception_t *)e.ex;
		goto FINALLY_0063;
	}

FINALLY_0063:
	{ // begin finally (depth: 1)
		{
			bool L_21 = V_3;
			if (!L_21)
			{
				goto IL_006c;
			}
		}

IL_0066:
		{
			Dictionary_2_t5BB631D653FC099355128DBC14DC44E27AD30739 * L_22 = V_2;
			Monitor_Exit_mA776B403DA88AC77CDEEF67AB9F0D0E77ABD254A((RuntimeObject *)L_22, /*hidden argument*/NULL);
		}

IL_006c:
		{
			IL2CPP_END_FINALLY(99)
		}
	} // end finally (depth: 1)
	IL2CPP_CLEANUP(99)
	{
		IL2CPP_RETHROW_IF_UNHANDLED(Exception_t *)
		IL2CPP_JUMP_TBL(0x6D, IL_006d)
	}

IL_006d:
	{
		return;
	}
}
// System.Void System.Runtime.InteropServices.WindowsRuntime.WindowsRuntimeMarshal/ManagedEventRegistrationImpl::RemoveEventHandler<System.Object>(System.Action`1<System.Runtime.InteropServices.WindowsRuntime.EventRegistrationToken>,T)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void ManagedEventRegistrationImpl_RemoveEventHandler_TisRuntimeObject_mD97F895A37C0E52B1E901B4E0E072FFE0CCF363F_gshared (Action_1_t91FC536003CAB9AB56B84E901AE08156372856E3 * ___removeMethod0, RuntimeObject * ___handler1, const RuntimeMethod* method)
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Action_1_Invoke_m0670A1DF770A18B2D457A2B700EEF92B463652DA_RuntimeMethod_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Dictionary_2_Remove_mF26A9D605B336E64E00D3E9B1A2B24D23F440D1C_RuntimeMethod_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Dictionary_2_TryGetValue_mF842EC8D110A281144B0082DE75F29AE5261F24F_RuntimeMethod_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&ManagedEventRegistrationImpl_t68BCFDC6DFC89A0F8CF53836672DD1F41C47CEEB_il2cpp_TypeInfo_var);
		s_Il2CppMethodInitialized = true;
	}
	Dictionary_2_t5BB631D653FC099355128DBC14DC44E27AD30739 * V_0 = NULL;
	EventRegistrationToken_t5460ED02F1A6B74B604DFD634E8D5429857E9830  V_1;
	memset((&V_1), 0, sizeof(V_1));
	Dictionary_2_t5BB631D653FC099355128DBC14DC44E27AD30739 * V_2 = NULL;
	bool V_3 = false;
	EventRegistrationTokenList_t0B8EB3E0DA8A305BFCD313936266A15F50B4B128  V_4;
	memset((&V_4), 0, sizeof(V_4));
	Exception_t * __last_unhandled_exception = 0;
	il2cpp::utils::ExceptionSupportStack<int32_t, 2> __leave_targets;
	{
		Action_1_t91FC536003CAB9AB56B84E901AE08156372856E3 * L_0 = ___removeMethod0;
		NullCheck((Delegate_t *)L_0);
		RuntimeObject * L_1;
		L_1 = Delegate_get_Target_mA4C35D598EE379F0F1D49EA8670620792D25EAB1_inline((Delegate_t *)L_0, /*hidden argument*/NULL);
		Action_1_t91FC536003CAB9AB56B84E901AE08156372856E3 * L_2 = ___removeMethod0;
		IL2CPP_RUNTIME_CLASS_INIT(ManagedEventRegistrationImpl_t68BCFDC6DFC89A0F8CF53836672DD1F41C47CEEB_il2cpp_TypeInfo_var);
		Dictionary_2_t5BB631D653FC099355128DBC14DC44E27AD30739 * L_3;
		L_3 = ManagedEventRegistrationImpl_GetEventRegistrationTokenTable_m8BBB3CF664BBC6EA31B8469EADEFD8EC1D82B8D3((RuntimeObject *)L_1, (Action_1_t91FC536003CAB9AB56B84E901AE08156372856E3 *)L_2, /*hidden argument*/NULL);
		V_0 = (Dictionary_2_t5BB631D653FC099355128DBC14DC44E27AD30739 *)L_3;
		Dictionary_2_t5BB631D653FC099355128DBC14DC44E27AD30739 * L_4 = V_0;
		V_2 = (Dictionary_2_t5BB631D653FC099355128DBC14DC44E27AD30739 *)L_4;
		V_3 = (bool)0;
	}

IL_0011:
	try
	{ // begin try (depth: 1)
		{
			Dictionary_2_t5BB631D653FC099355128DBC14DC44E27AD30739 * L_5 = V_2;
			Monitor_Enter_mBEB6CC84184B46F26375EC3FC8921D16E48EA4C4((RuntimeObject *)L_5, (bool*)(bool*)(&V_3), /*hidden argument*/NULL);
			Dictionary_2_t5BB631D653FC099355128DBC14DC44E27AD30739 * L_6 = V_0;
			RuntimeObject * L_7 = ___handler1;
			NullCheck((Dictionary_2_t5BB631D653FC099355128DBC14DC44E27AD30739 *)L_6);
			bool L_8;
			L_8 = Dictionary_2_TryGetValue_mF842EC8D110A281144B0082DE75F29AE5261F24F((Dictionary_2_t5BB631D653FC099355128DBC14DC44E27AD30739 *)L_6, (RuntimeObject *)L_7, (EventRegistrationTokenList_t0B8EB3E0DA8A305BFCD313936266A15F50B4B128 *)(EventRegistrationTokenList_t0B8EB3E0DA8A305BFCD313936266A15F50B4B128 *)(&V_4), /*hidden argument*/Dictionary_2_TryGetValue_mF842EC8D110A281144B0082DE75F29AE5261F24F_RuntimeMethod_var);
			if (L_8)
			{
				goto IL_002b;
			}
		}

IL_0029:
		{
			IL2CPP_LEAVE(0x56, FINALLY_0045);
		}

IL_002b:
		{
			bool L_9;
			L_9 = EventRegistrationTokenList_Pop_mEDB55C6642FBEE0B03BDC2C06E84FBEFAE96FCDB((EventRegistrationTokenList_t0B8EB3E0DA8A305BFCD313936266A15F50B4B128 *)(EventRegistrationTokenList_t0B8EB3E0DA8A305BFCD313936266A15F50B4B128 *)(&V_4), (EventRegistrationToken_t5460ED02F1A6B74B604DFD634E8D5429857E9830 *)(EventRegistrationToken_t5460ED02F1A6B74B604DFD634E8D5429857E9830 *)(&V_1), /*hidden argument*/NULL);
			if (L_9)
			{
				goto IL_0043;
			}
		}

IL_0036:
		{
			Dictionary_2_t5BB631D653FC099355128DBC14DC44E27AD30739 * L_10 = V_0;
			RuntimeObject * L_11 = ___handler1;
			NullCheck((Dictionary_2_t5BB631D653FC099355128DBC14DC44E27AD30739 *)L_10);
			bool L_12;
			L_12 = Dictionary_2_Remove_mF26A9D605B336E64E00D3E9B1A2B24D23F440D1C((Dictionary_2_t5BB631D653FC099355128DBC14DC44E27AD30739 *)L_10, (RuntimeObject *)L_11, /*hidden argument*/Dictionary_2_Remove_mF26A9D605B336E64E00D3E9B1A2B24D23F440D1C_RuntimeMethod_var);
		}

IL_0043:
		{
			IL2CPP_LEAVE(0x4F, FINALLY_0045);
		}
	} // end try (depth: 1)
	catch(Il2CppExceptionWrapper& e)
	{
		__last_unhandled_exception = (Exception_t *)e.ex;
		goto FINALLY_0045;
	}

FINALLY_0045:
	{ // begin finally (depth: 1)
		{
			bool L_13 = V_3;
			if (!L_13)
			{
				goto IL_004e;
			}
		}

IL_0048:
		{
			Dictionary_2_t5BB631D653FC099355128DBC14DC44E27AD30739 * L_14 = V_2;
			Monitor_Exit_mA776B403DA88AC77CDEEF67AB9F0D0E77ABD254A((RuntimeObject *)L_14, /*hidden argument*/NULL);
		}

IL_004e:
		{
			IL2CPP_END_FINALLY(69)
		}
	} // end finally (depth: 1)
	IL2CPP_CLEANUP(69)
	{
		IL2CPP_RETHROW_IF_UNHANDLED(Exception_t *)
		IL2CPP_JUMP_TBL(0x56, IL_0056)
		IL2CPP_JUMP_TBL(0x4F, IL_004f)
	}

IL_004f:
	{
		Action_1_t91FC536003CAB9AB56B84E901AE08156372856E3 * L_15 = ___removeMethod0;
		EventRegistrationToken_t5460ED02F1A6B74B604DFD634E8D5429857E9830  L_16 = V_1;
		NullCheck((Action_1_t91FC536003CAB9AB56B84E901AE08156372856E3 *)L_15);
		Action_1_Invoke_m0670A1DF770A18B2D457A2B700EEF92B463652DA((Action_1_t91FC536003CAB9AB56B84E901AE08156372856E3 *)L_15, (EventRegistrationToken_t5460ED02F1A6B74B604DFD634E8D5429857E9830 )L_16, /*hidden argument*/Action_1_Invoke_m0670A1DF770A18B2D457A2B700EEF92B463652DA_RuntimeMethod_var);
	}

IL_0056:
	{
		return;
	}
}
// System.Void System.Runtime.InteropServices.WindowsRuntime.WindowsRuntimeMarshal/NativeOrStaticEventRegistrationImpl::AddEventHandler<System.Object>(System.Func`2<T,System.Runtime.InteropServices.WindowsRuntime.EventRegistrationToken>,System.Action`1<System.Runtime.InteropServices.WindowsRuntime.EventRegistrationToken>,T)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void NativeOrStaticEventRegistrationImpl_AddEventHandler_TisRuntimeObject_m8E5074116B1AE98ECF1E3CF6F7FF8040E6221BE2_gshared (Func_2_t5650431F2BFFD75382D3BA01D19E366CD1DA1813 * ___addMethod0, Action_1_t91FC536003CAB9AB56B84E901AE08156372856E3 * ___removeMethod1, RuntimeObject * ___handler2, const RuntimeMethod* method)
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&ConditionalWeakTable_2_Add_mF73DB702E1356B2CC2F9C09D3443987A75954088_RuntimeMethod_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&ConditionalWeakTable_2_FindEquivalentKeyUnsafe_mC28129CC24B2F2D4CACEEC954DB5F99E4EEE0713_RuntimeMethod_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&EventRegistrationTokenListWithCount_t8BA708F75B90C86A7CA1F3FD1DFCBD742D458FC6_il2cpp_TypeInfo_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&NativeOrStaticEventRegistrationImpl_tCA81B1033AD6FCE9E03C1E043758D4A1815B90E4_il2cpp_TypeInfo_var);
		s_Il2CppMethodInitialized = true;
	}
	RuntimeObject * V_0 = NULL;
	EventRegistrationToken_t5460ED02F1A6B74B604DFD634E8D5429857E9830  V_1;
	memset((&V_1), 0, sizeof(V_1));
	bool V_2 = false;
	EventRegistrationTokenListWithCount_t8BA708F75B90C86A7CA1F3FD1DFCBD742D458FC6 * V_3 = NULL;
	TokenListCount_t769EA62356D8C37857DCC81DB79A76FA75E319AC * V_4 = NULL;
	ConditionalWeakTable_2_tDE9E02FF583A5D6707A2CCEF9E15BD2791EA4229 * V_5 = NULL;
	ConditionalWeakTable_2_tDE9E02FF583A5D6707A2CCEF9E15BD2791EA4229 * V_6 = NULL;
	bool V_7 = false;
	Exception_t * __last_unhandled_exception = 0;
	il2cpp::utils::ExceptionSupportStack<RuntimeObject*, 1> __active_exceptions;
	il2cpp::utils::ExceptionSupportStack<int32_t, 3> __leave_targets;
	{
		Action_1_t91FC536003CAB9AB56B84E901AE08156372856E3 * L_0 = ___removeMethod1;
		IL2CPP_RUNTIME_CLASS_INIT(NativeOrStaticEventRegistrationImpl_tCA81B1033AD6FCE9E03C1E043758D4A1815B90E4_il2cpp_TypeInfo_var);
		RuntimeObject * L_1;
		L_1 = NativeOrStaticEventRegistrationImpl_GetInstanceKey_m609103D809620576492B03F7BFB8FC959231E174((Action_1_t91FC536003CAB9AB56B84E901AE08156372856E3 *)L_0, /*hidden argument*/NULL);
		V_0 = (RuntimeObject *)L_1;
		Func_2_t5650431F2BFFD75382D3BA01D19E366CD1DA1813 * L_2 = ___addMethod0;
		RuntimeObject * L_3 = ___handler2;
		NullCheck((Func_2_t5650431F2BFFD75382D3BA01D19E366CD1DA1813 *)L_2);
		EventRegistrationToken_t5460ED02F1A6B74B604DFD634E8D5429857E9830  L_4;
		L_4 = ((  EventRegistrationToken_t5460ED02F1A6B74B604DFD634E8D5429857E9830  (*) (Func_2_t5650431F2BFFD75382D3BA01D19E366CD1DA1813 *, RuntimeObject *, const RuntimeMethod*))IL2CPP_RGCTX_METHOD_INFO(method->rgctx_data, 0)->methodPointer)((Func_2_t5650431F2BFFD75382D3BA01D19E366CD1DA1813 *)L_2, (RuntimeObject *)L_3, /*hidden argument*/IL2CPP_RGCTX_METHOD_INFO(method->rgctx_data, 0));
		V_1 = (EventRegistrationToken_t5460ED02F1A6B74B604DFD634E8D5429857E9830 )L_4;
		V_2 = (bool)0;
	}

IL_0011:
	try
	{ // begin try (depth: 1)
		{
			IL2CPP_RUNTIME_CLASS_INIT(NativeOrStaticEventRegistrationImpl_tCA81B1033AD6FCE9E03C1E043758D4A1815B90E4_il2cpp_TypeInfo_var);
			MyReaderWriterLock_t0EAF7040A5BCE7C816030732D088A8DB81FB97AD * L_5 = ((NativeOrStaticEventRegistrationImpl_tCA81B1033AD6FCE9E03C1E043758D4A1815B90E4_StaticFields*)il2cpp_codegen_static_fields_for(NativeOrStaticEventRegistrationImpl_tCA81B1033AD6FCE9E03C1E043758D4A1815B90E4_il2cpp_TypeInfo_var))->get_s_eventCacheRWLock_1();
			il2cpp_codegen_memory_barrier();
			NullCheck((MyReaderWriterLock_t0EAF7040A5BCE7C816030732D088A8DB81FB97AD *)L_5);
			MyReaderWriterLock_AcquireReaderLock_m4C64A27901CB970D8F6FA8A4AE98B8980C8138AD((MyReaderWriterLock_t0EAF7040A5BCE7C816030732D088A8DB81FB97AD *)L_5, (int32_t)(-1), /*hidden argument*/NULL);
		}

IL_001e:
		try
		{ // begin try (depth: 2)
			{
				RuntimeObject * L_6 = V_0;
				Action_1_t91FC536003CAB9AB56B84E901AE08156372856E3 * L_7 = ___removeMethod1;
				IL2CPP_RUNTIME_CLASS_INIT(NativeOrStaticEventRegistrationImpl_tCA81B1033AD6FCE9E03C1E043758D4A1815B90E4_il2cpp_TypeInfo_var);
				ConditionalWeakTable_2_tDE9E02FF583A5D6707A2CCEF9E15BD2791EA4229 * L_8;
				L_8 = NativeOrStaticEventRegistrationImpl_GetOrCreateEventRegistrationTokenTable_mE0D26BCAD8501EEF779A9CB54A47E7621638426F((RuntimeObject *)L_6, (Action_1_t91FC536003CAB9AB56B84E901AE08156372856E3 *)L_7, (TokenListCount_t769EA62356D8C37857DCC81DB79A76FA75E319AC **)(TokenListCount_t769EA62356D8C37857DCC81DB79A76FA75E319AC **)(&V_4), /*hidden argument*/NULL);
				V_5 = (ConditionalWeakTable_2_tDE9E02FF583A5D6707A2CCEF9E15BD2791EA4229 *)L_8;
				ConditionalWeakTable_2_tDE9E02FF583A5D6707A2CCEF9E15BD2791EA4229 * L_9 = V_5;
				V_6 = (ConditionalWeakTable_2_tDE9E02FF583A5D6707A2CCEF9E15BD2791EA4229 *)L_9;
				V_7 = (bool)0;
			}

IL_0030:
			try
			{ // begin try (depth: 3)
				{
					ConditionalWeakTable_2_tDE9E02FF583A5D6707A2CCEF9E15BD2791EA4229 * L_10 = V_6;
					Monitor_Enter_mBEB6CC84184B46F26375EC3FC8921D16E48EA4C4((RuntimeObject *)L_10, (bool*)(bool*)(&V_7), /*hidden argument*/NULL);
					ConditionalWeakTable_2_tDE9E02FF583A5D6707A2CCEF9E15BD2791EA4229 * L_11 = V_5;
					RuntimeObject * L_12 = ___handler2;
					NullCheck((ConditionalWeakTable_2_tDE9E02FF583A5D6707A2CCEF9E15BD2791EA4229 *)L_11);
					RuntimeObject * L_13;
					L_13 = ConditionalWeakTable_2_FindEquivalentKeyUnsafe_mC28129CC24B2F2D4CACEEC954DB5F99E4EEE0713((ConditionalWeakTable_2_tDE9E02FF583A5D6707A2CCEF9E15BD2791EA4229 *)L_11, (RuntimeObject *)L_12, (EventRegistrationTokenListWithCount_t8BA708F75B90C86A7CA1F3FD1DFCBD742D458FC6 **)(EventRegistrationTokenListWithCount_t8BA708F75B90C86A7CA1F3FD1DFCBD742D458FC6 **)(&V_3), /*hidden argument*/ConditionalWeakTable_2_FindEquivalentKeyUnsafe_mC28129CC24B2F2D4CACEEC954DB5F99E4EEE0713_RuntimeMethod_var);
					if (L_13)
					{
						goto IL_0063;
					}
				}

IL_004a:
				{
					TokenListCount_t769EA62356D8C37857DCC81DB79A76FA75E319AC * L_14 = V_4;
					EventRegistrationToken_t5460ED02F1A6B74B604DFD634E8D5429857E9830  L_15 = V_1;
					EventRegistrationTokenListWithCount_t8BA708F75B90C86A7CA1F3FD1DFCBD742D458FC6 * L_16 = (EventRegistrationTokenListWithCount_t8BA708F75B90C86A7CA1F3FD1DFCBD742D458FC6 *)il2cpp_codegen_object_new(EventRegistrationTokenListWithCount_t8BA708F75B90C86A7CA1F3FD1DFCBD742D458FC6_il2cpp_TypeInfo_var);
					EventRegistrationTokenListWithCount__ctor_m09819A938F29C2DD7D8E2ACCC5249E6B7275E748(L_16, (TokenListCount_t769EA62356D8C37857DCC81DB79A76FA75E319AC *)L_14, (EventRegistrationToken_t5460ED02F1A6B74B604DFD634E8D5429857E9830 )L_15, /*hidden argument*/NULL);
					V_3 = (EventRegistrationTokenListWithCount_t8BA708F75B90C86A7CA1F3FD1DFCBD742D458FC6 *)L_16;
					ConditionalWeakTable_2_tDE9E02FF583A5D6707A2CCEF9E15BD2791EA4229 * L_17 = V_5;
					RuntimeObject * L_18 = ___handler2;
					EventRegistrationTokenListWithCount_t8BA708F75B90C86A7CA1F3FD1DFCBD742D458FC6 * L_19 = V_3;
					NullCheck((ConditionalWeakTable_2_tDE9E02FF583A5D6707A2CCEF9E15BD2791EA4229 *)L_17);
					ConditionalWeakTable_2_Add_mF73DB702E1356B2CC2F9C09D3443987A75954088((ConditionalWeakTable_2_tDE9E02FF583A5D6707A2CCEF9E15BD2791EA4229 *)L_17, (RuntimeObject *)L_18, (EventRegistrationTokenListWithCount_t8BA708F75B90C86A7CA1F3FD1DFCBD742D458FC6 *)L_19, /*hidden argument*/ConditionalWeakTable_2_Add_mF73DB702E1356B2CC2F9C09D3443987A75954088_RuntimeMethod_var);
					goto IL_006a;
				}

IL_0063:
				{
					EventRegistrationTokenListWithCount_t8BA708F75B90C86A7CA1F3FD1DFCBD742D458FC6 * L_20 = V_3;
					EventRegistrationToken_t5460ED02F1A6B74B604DFD634E8D5429857E9830  L_21 = V_1;
					NullCheck((EventRegistrationTokenListWithCount_t8BA708F75B90C86A7CA1F3FD1DFCBD742D458FC6 *)L_20);
					EventRegistrationTokenListWithCount_Push_m966CF9B4B55E54DADA94B9B325053F115B9421F5((EventRegistrationTokenListWithCount_t8BA708F75B90C86A7CA1F3FD1DFCBD742D458FC6 *)L_20, (EventRegistrationToken_t5460ED02F1A6B74B604DFD634E8D5429857E9830 )L_21, /*hidden argument*/NULL);
				}

IL_006a:
				{
					V_2 = (bool)1;
					IL2CPP_LEAVE(0x7A, FINALLY_006e);
				}
			} // end try (depth: 3)
			catch(Il2CppExceptionWrapper& e)
			{
				__last_unhandled_exception = (Exception_t *)e.ex;
				goto FINALLY_006e;
			}

FINALLY_006e:
			{ // begin finally (depth: 3)
				{
					bool L_22 = V_7;
					if (!L_22)
					{
						goto IL_0079;
					}
				}

IL_0072:
				{
					ConditionalWeakTable_2_tDE9E02FF583A5D6707A2CCEF9E15BD2791EA4229 * L_23 = V_6;
					Monitor_Exit_mA776B403DA88AC77CDEEF67AB9F0D0E77ABD254A((RuntimeObject *)L_23, /*hidden argument*/NULL);
				}

IL_0079:
				{
					IL2CPP_END_FINALLY(110)
				}
			} // end finally (depth: 3)
			IL2CPP_CLEANUP(110)
			{
				IL2CPP_RETHROW_IF_UNHANDLED(Exception_t *)
				IL2CPP_JUMP_TBL(0x7A, IL_007a)
			}

IL_007a:
			{
				IL2CPP_LEAVE(0x89, FINALLY_007c);
			}
		} // end try (depth: 2)
		catch(Il2CppExceptionWrapper& e)
		{
			__last_unhandled_exception = (Exception_t *)e.ex;
			goto FINALLY_007c;
		}

FINALLY_007c:
		{ // begin finally (depth: 2)
			IL2CPP_RUNTIME_CLASS_INIT(NativeOrStaticEventRegistrationImpl_tCA81B1033AD6FCE9E03C1E043758D4A1815B90E4_il2cpp_TypeInfo_var);
			MyReaderWriterLock_t0EAF7040A5BCE7C816030732D088A8DB81FB97AD * L_24 = ((NativeOrStaticEventRegistrationImpl_tCA81B1033AD6FCE9E03C1E043758D4A1815B90E4_StaticFields*)il2cpp_codegen_static_fields_for(NativeOrStaticEventRegistrationImpl_tCA81B1033AD6FCE9E03C1E043758D4A1815B90E4_il2cpp_TypeInfo_var))->get_s_eventCacheRWLock_1();
			il2cpp_codegen_memory_barrier();
			NullCheck((MyReaderWriterLock_t0EAF7040A5BCE7C816030732D088A8DB81FB97AD *)L_24);
			MyReaderWriterLock_ReleaseReaderLock_m9957FB580A0C803C269D10DB3C7B9482FF46A94D((MyReaderWriterLock_t0EAF7040A5BCE7C816030732D088A8DB81FB97AD *)L_24, /*hidden argument*/NULL);
			IL2CPP_END_FINALLY(124)
		} // end finally (depth: 2)
		IL2CPP_CLEANUP(124)
		{
			IL2CPP_RETHROW_IF_UNHANDLED(Exception_t *)
			IL2CPP_JUMP_TBL(0x89, IL_0089)
		}

IL_0089:
		{
			goto IL_0098;
		}
	} // end try (depth: 1)
	catch(Il2CppExceptionWrapper& e)
	{
		if(il2cpp_codegen_class_is_assignable_from (((RuntimeClass*)il2cpp_codegen_initialize_runtime_metadata_inline((uintptr_t*)&Exception_t_il2cpp_TypeInfo_var)), il2cpp_codegen_object_class(e.ex)))
		{
			IL2CPP_PUSH_ACTIVE_EXCEPTION(e.ex);
			goto CATCH_008b;
		}
		throw e;
	}

CATCH_008b:
	{ // begin catch(System.Exception)
		{
			bool L_25 = V_2;
			if (L_25)
			{
				goto IL_0096;
			}
		}

IL_008f:
		{
			Action_1_t91FC536003CAB9AB56B84E901AE08156372856E3 * L_26 = ___removeMethod1;
			EventRegistrationToken_t5460ED02F1A6B74B604DFD634E8D5429857E9830  L_27 = V_1;
			NullCheck((Action_1_t91FC536003CAB9AB56B84E901AE08156372856E3 *)L_26);
			Action_1_Invoke_m0670A1DF770A18B2D457A2B700EEF92B463652DA((Action_1_t91FC536003CAB9AB56B84E901AE08156372856E3 *)L_26, (EventRegistrationToken_t5460ED02F1A6B74B604DFD634E8D5429857E9830 )L_27, /*hidden argument*/((RuntimeMethod*)il2cpp_codegen_initialize_runtime_metadata_inline((uintptr_t*)&Action_1_Invoke_m0670A1DF770A18B2D457A2B700EEF92B463652DA_RuntimeMethod_var)));
		}

IL_0096:
		{
			IL2CPP_RAISE_MANAGED_EXCEPTION(IL2CPP_GET_ACTIVE_EXCEPTION(Exception_t *), ((RuntimeMethod*)il2cpp_codegen_initialize_runtime_metadata_inline((uintptr_t*)&NativeOrStaticEventRegistrationImpl_AddEventHandler_TisRuntimeObject_m8E5074116B1AE98ECF1E3CF6F7FF8040E6221BE2_RuntimeMethod_var)));
		}
	} // end catch (depth: 1)

IL_0098:
	{
		return;
	}
}
// System.Void System.Runtime.InteropServices.WindowsRuntime.WindowsRuntimeMarshal/NativeOrStaticEventRegistrationImpl::RemoveEventHandler<System.Object>(System.Action`1<System.Runtime.InteropServices.WindowsRuntime.EventRegistrationToken>,T)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void NativeOrStaticEventRegistrationImpl_RemoveEventHandler_TisRuntimeObject_mD2BD38B2B3F52E3A92A6C2A48E74B8396671E01B_gshared (Action_1_t91FC536003CAB9AB56B84E901AE08156372856E3 * ___removeMethod0, RuntimeObject * ___handler1, const RuntimeMethod* method)
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Action_1_Invoke_m0670A1DF770A18B2D457A2B700EEF92B463652DA_RuntimeMethod_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&ConditionalWeakTable_2_FindEquivalentKeyUnsafe_mC28129CC24B2F2D4CACEEC954DB5F99E4EEE0713_RuntimeMethod_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&ConditionalWeakTable_2_Remove_mF1535859D88E215E79053D8935FCE7DF3F2D7124_RuntimeMethod_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&NativeOrStaticEventRegistrationImpl_tCA81B1033AD6FCE9E03C1E043758D4A1815B90E4_il2cpp_TypeInfo_var);
		s_Il2CppMethodInitialized = true;
	}
	RuntimeObject * V_0 = NULL;
	EventRegistrationToken_t5460ED02F1A6B74B604DFD634E8D5429857E9830  V_1;
	memset((&V_1), 0, sizeof(V_1));
	TokenListCount_t769EA62356D8C37857DCC81DB79A76FA75E319AC * V_2 = NULL;
	ConditionalWeakTable_2_tDE9E02FF583A5D6707A2CCEF9E15BD2791EA4229 * V_3 = NULL;
	ConditionalWeakTable_2_tDE9E02FF583A5D6707A2CCEF9E15BD2791EA4229 * V_4 = NULL;
	bool V_5 = false;
	EventRegistrationTokenListWithCount_t8BA708F75B90C86A7CA1F3FD1DFCBD742D458FC6 * V_6 = NULL;
	RuntimeObject * V_7 = NULL;
	Exception_t * __last_unhandled_exception = 0;
	il2cpp::utils::ExceptionSupportStack<int32_t, 3> __leave_targets;
	{
		Action_1_t91FC536003CAB9AB56B84E901AE08156372856E3 * L_0 = ___removeMethod0;
		IL2CPP_RUNTIME_CLASS_INIT(NativeOrStaticEventRegistrationImpl_tCA81B1033AD6FCE9E03C1E043758D4A1815B90E4_il2cpp_TypeInfo_var);
		RuntimeObject * L_1;
		L_1 = NativeOrStaticEventRegistrationImpl_GetInstanceKey_m609103D809620576492B03F7BFB8FC959231E174((Action_1_t91FC536003CAB9AB56B84E901AE08156372856E3 *)L_0, /*hidden argument*/NULL);
		V_0 = (RuntimeObject *)L_1;
		MyReaderWriterLock_t0EAF7040A5BCE7C816030732D088A8DB81FB97AD * L_2 = ((NativeOrStaticEventRegistrationImpl_tCA81B1033AD6FCE9E03C1E043758D4A1815B90E4_StaticFields*)il2cpp_codegen_static_fields_for(NativeOrStaticEventRegistrationImpl_tCA81B1033AD6FCE9E03C1E043758D4A1815B90E4_il2cpp_TypeInfo_var))->get_s_eventCacheRWLock_1();
		il2cpp_codegen_memory_barrier();
		NullCheck((MyReaderWriterLock_t0EAF7040A5BCE7C816030732D088A8DB81FB97AD *)L_2);
		MyReaderWriterLock_AcquireReaderLock_m4C64A27901CB970D8F6FA8A4AE98B8980C8138AD((MyReaderWriterLock_t0EAF7040A5BCE7C816030732D088A8DB81FB97AD *)L_2, (int32_t)(-1), /*hidden argument*/NULL);
	}

IL_0014:
	try
	{ // begin try (depth: 1)
		{
			RuntimeObject * L_3 = V_0;
			Action_1_t91FC536003CAB9AB56B84E901AE08156372856E3 * L_4 = ___removeMethod0;
			IL2CPP_RUNTIME_CLASS_INIT(NativeOrStaticEventRegistrationImpl_tCA81B1033AD6FCE9E03C1E043758D4A1815B90E4_il2cpp_TypeInfo_var);
			ConditionalWeakTable_2_tDE9E02FF583A5D6707A2CCEF9E15BD2791EA4229 * L_5;
			L_5 = NativeOrStaticEventRegistrationImpl_GetEventRegistrationTokenTableNoCreate_m2FDC87A2509BEB899C090FC0D2C3A5D0888B3250((RuntimeObject *)L_3, (Action_1_t91FC536003CAB9AB56B84E901AE08156372856E3 *)L_4, (TokenListCount_t769EA62356D8C37857DCC81DB79A76FA75E319AC **)(TokenListCount_t769EA62356D8C37857DCC81DB79A76FA75E319AC **)(&V_2), /*hidden argument*/NULL);
			V_3 = (ConditionalWeakTable_2_tDE9E02FF583A5D6707A2CCEF9E15BD2791EA4229 *)L_5;
			ConditionalWeakTable_2_tDE9E02FF583A5D6707A2CCEF9E15BD2791EA4229 * L_6 = V_3;
			if (L_6)
			{
				goto IL_0023;
			}
		}

IL_0021:
		{
			IL2CPP_LEAVE(0x7E, FINALLY_006a);
		}

IL_0023:
		{
			ConditionalWeakTable_2_tDE9E02FF583A5D6707A2CCEF9E15BD2791EA4229 * L_7 = V_3;
			V_4 = (ConditionalWeakTable_2_tDE9E02FF583A5D6707A2CCEF9E15BD2791EA4229 *)L_7;
			V_5 = (bool)0;
		}

IL_0029:
		try
		{ // begin try (depth: 2)
			{
				ConditionalWeakTable_2_tDE9E02FF583A5D6707A2CCEF9E15BD2791EA4229 * L_8 = V_4;
				Monitor_Enter_mBEB6CC84184B46F26375EC3FC8921D16E48EA4C4((RuntimeObject *)L_8, (bool*)(bool*)(&V_5), /*hidden argument*/NULL);
				ConditionalWeakTable_2_tDE9E02FF583A5D6707A2CCEF9E15BD2791EA4229 * L_9 = V_3;
				RuntimeObject * L_10 = ___handler1;
				NullCheck((ConditionalWeakTable_2_tDE9E02FF583A5D6707A2CCEF9E15BD2791EA4229 *)L_9);
				RuntimeObject * L_11;
				L_11 = ConditionalWeakTable_2_FindEquivalentKeyUnsafe_mC28129CC24B2F2D4CACEEC954DB5F99E4EEE0713((ConditionalWeakTable_2_tDE9E02FF583A5D6707A2CCEF9E15BD2791EA4229 *)L_9, (RuntimeObject *)L_10, (EventRegistrationTokenListWithCount_t8BA708F75B90C86A7CA1F3FD1DFCBD742D458FC6 **)(EventRegistrationTokenListWithCount_t8BA708F75B90C86A7CA1F3FD1DFCBD742D458FC6 **)(&V_6), /*hidden argument*/ConditionalWeakTable_2_FindEquivalentKeyUnsafe_mC28129CC24B2F2D4CACEEC954DB5F99E4EEE0713_RuntimeMethod_var);
				V_7 = (RuntimeObject *)L_11;
				EventRegistrationTokenListWithCount_t8BA708F75B90C86A7CA1F3FD1DFCBD742D458FC6 * L_12 = V_6;
				if (L_12)
				{
					goto IL_0048;
				}
			}

IL_0046:
			{
				IL2CPP_LEAVE(0x7E, FINALLY_005e);
			}

IL_0048:
			{
				EventRegistrationTokenListWithCount_t8BA708F75B90C86A7CA1F3FD1DFCBD742D458FC6 * L_13 = V_6;
				NullCheck((EventRegistrationTokenListWithCount_t8BA708F75B90C86A7CA1F3FD1DFCBD742D458FC6 *)L_13);
				bool L_14;
				L_14 = EventRegistrationTokenListWithCount_Pop_mB0D869EA5FC0BB430DB9BCF253396C6B5F7D20FB((EventRegistrationTokenListWithCount_t8BA708F75B90C86A7CA1F3FD1DFCBD742D458FC6 *)L_13, (EventRegistrationToken_t5460ED02F1A6B74B604DFD634E8D5429857E9830 *)(EventRegistrationToken_t5460ED02F1A6B74B604DFD634E8D5429857E9830 *)(&V_1), /*hidden argument*/NULL);
				if (L_14)
				{
					goto IL_005c;
				}
			}

IL_0053:
			{
				ConditionalWeakTable_2_tDE9E02FF583A5D6707A2CCEF9E15BD2791EA4229 * L_15 = V_3;
				RuntimeObject * L_16 = V_7;
				NullCheck((ConditionalWeakTable_2_tDE9E02FF583A5D6707A2CCEF9E15BD2791EA4229 *)L_15);
				bool L_17;
				L_17 = ConditionalWeakTable_2_Remove_mF1535859D88E215E79053D8935FCE7DF3F2D7124((ConditionalWeakTable_2_tDE9E02FF583A5D6707A2CCEF9E15BD2791EA4229 *)L_15, (RuntimeObject *)L_16, /*hidden argument*/ConditionalWeakTable_2_Remove_mF1535859D88E215E79053D8935FCE7DF3F2D7124_RuntimeMethod_var);
			}

IL_005c:
			{
				IL2CPP_LEAVE(0x77, FINALLY_005e);
			}
		} // end try (depth: 2)
		catch(Il2CppExceptionWrapper& e)
		{
			__last_unhandled_exception = (Exception_t *)e.ex;
			goto FINALLY_005e;
		}

FINALLY_005e:
		{ // begin finally (depth: 2)
			{
				bool L_18 = V_5;
				if (!L_18)
				{
					goto IL_0069;
				}
			}

IL_0062:
			{
				ConditionalWeakTable_2_tDE9E02FF583A5D6707A2CCEF9E15BD2791EA4229 * L_19 = V_4;
				Monitor_Exit_mA776B403DA88AC77CDEEF67AB9F0D0E77ABD254A((RuntimeObject *)L_19, /*hidden argument*/NULL);
			}

IL_0069:
			{
				IL2CPP_END_FINALLY(94)
			}
		} // end finally (depth: 2)
		IL2CPP_CLEANUP(94)
		{
			IL2CPP_RETHROW_IF_UNHANDLED(Exception_t *)
			IL2CPP_END_CLEANUP(0x7E, FINALLY_006a);
			IL2CPP_END_CLEANUP(0x77, FINALLY_006a);
		}
	} // end try (depth: 1)
	catch(Il2CppExceptionWrapper& e)
	{
		__last_unhandled_exception = (Exception_t *)e.ex;
		goto FINALLY_006a;
	}

FINALLY_006a:
	{ // begin finally (depth: 1)
		IL2CPP_RUNTIME_CLASS_INIT(NativeOrStaticEventRegistrationImpl_tCA81B1033AD6FCE9E03C1E043758D4A1815B90E4_il2cpp_TypeInfo_var);
		MyReaderWriterLock_t0EAF7040A5BCE7C816030732D088A8DB81FB97AD * L_20 = ((NativeOrStaticEventRegistrationImpl_tCA81B1033AD6FCE9E03C1E043758D4A1815B90E4_StaticFields*)il2cpp_codegen_static_fields_for(NativeOrStaticEventRegistrationImpl_tCA81B1033AD6FCE9E03C1E043758D4A1815B90E4_il2cpp_TypeInfo_var))->get_s_eventCacheRWLock_1();
		il2cpp_codegen_memory_barrier();
		NullCheck((MyReaderWriterLock_t0EAF7040A5BCE7C816030732D088A8DB81FB97AD *)L_20);
		MyReaderWriterLock_ReleaseReaderLock_m9957FB580A0C803C269D10DB3C7B9482FF46A94D((MyReaderWriterLock_t0EAF7040A5BCE7C816030732D088A8DB81FB97AD *)L_20, /*hidden argument*/NULL);
		IL2CPP_END_FINALLY(106)
	} // end finally (depth: 1)
	IL2CPP_CLEANUP(106)
	{
		IL2CPP_RETHROW_IF_UNHANDLED(Exception_t *)
		IL2CPP_JUMP_TBL(0x7E, IL_007e)
		IL2CPP_JUMP_TBL(0x77, IL_0077)
	}

IL_0077:
	{
		Action_1_t91FC536003CAB9AB56B84E901AE08156372856E3 * L_21 = ___removeMethod0;
		EventRegistrationToken_t5460ED02F1A6B74B604DFD634E8D5429857E9830  L_22 = V_1;
		NullCheck((Action_1_t91FC536003CAB9AB56B84E901AE08156372856E3 *)L_21);
		Action_1_Invoke_m0670A1DF770A18B2D457A2B700EEF92B463652DA((Action_1_t91FC536003CAB9AB56B84E901AE08156372856E3 *)L_21, (EventRegistrationToken_t5460ED02F1A6B74B604DFD634E8D5429857E9830 )L_22, /*hidden argument*/Action_1_Invoke_m0670A1DF770A18B2D457A2B700EEF92B463652DA_RuntimeMethod_var);
	}

IL_007e:
	{
		return;
	}
}
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR Expression_t30A004209C10C2D9A9785B2F74EEED431A4D4660 * DynamicMetaObject_get_Expression_m56AEEE5B82DB27F8490D27758D6ECAEC19BE64C2_inline (DynamicMetaObject_t5279001ADBFAB6EF015CAC54937F4E9F003881C3 * __this, const RuntimeMethod* method)
{
	{
		Expression_t30A004209C10C2D9A9785B2F74EEED431A4D4660 * L_0 = __this->get_U3CExpressionU3Ek__BackingField_1();
		return L_0;
	}
}
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR BindingRestrictions_t03E14FA0517A70DEDA502032CE956595EF6E0DFC * DynamicMetaObject_get_Restrictions_mE04FE62E32906462628D87A3341521ABFADC63C5_inline (DynamicMetaObject_t5279001ADBFAB6EF015CAC54937F4E9F003881C3 * __this, const RuntimeMethod* method)
{
	{
		BindingRestrictions_t03E14FA0517A70DEDA502032CE956595EF6E0DFC * L_0 = __this->get_U3CRestrictionsU3Ek__BackingField_2();
		return L_0;
	}
}
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR Expression_t30A004209C10C2D9A9785B2F74EEED431A4D4660 * LambdaExpression_get_Body_m595A485419E2F0AA13FC2695DEBD99ED9712D042_inline (LambdaExpression_t26BF905E97E6D94F81F17D60F4F4F47F8E93B474 * __this, const RuntimeMethod* method)
{
	{
		Expression_t30A004209C10C2D9A9785B2F74EEED431A4D4660 * L_0 = __this->get__body_3();
		return L_0;
	}
}
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR RuntimeObject * Delegate_get_Target_mA4C35D598EE379F0F1D49EA8670620792D25EAB1_inline (Delegate_t * __this, const RuntimeMethod* method)
{
	{
		RuntimeObject * L_0 = __this->get_m_target_2();
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
