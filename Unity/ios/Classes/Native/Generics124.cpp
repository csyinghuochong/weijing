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
template <typename R, typename T1, typename T2>
struct InterfaceFuncInvoker2
{
	typedef R (*Func)(void*, T1, T2, const RuntimeMethod*);

	static inline R Invoke (Il2CppMethodSlot slot, RuntimeClass* declaringInterface, RuntimeObject* obj, T1 p1, T2 p2)
	{
		const VirtualInvokeData& invokeData = il2cpp_codegen_get_interface_invoke_data(slot, obj, declaringInterface);
		return ((Func)invokeData.methodPtr)(obj, p1, p2, invokeData.method);
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
// System.Runtime.CompilerServices.ConditionalWeakTable`2<System.Threading.Tasks.TaskScheduler,System.Object>
struct ConditionalWeakTable_2_t93AD246458B1FCACF9EE33160B2DB2E06AB42CD8;
// System.Collections.Generic.EqualityComparer`1<System.Object>
struct EqualityComparer_1_t469B0BBE7B6765C576211BEF8F2803A5AD411A20;
// System.EventHandler`1<System.Threading.Tasks.UnobservedTaskExceptionEventArgs>
struct EventHandler_1_t7DFDECE3AD515844324382F8BBCAC2975ABEE63A;
// System.Func`2<System.Nullable`1<System.Decimal>,System.Boolean>
struct Func_2_t04450D4888681586D3F4812C491231E855EF5DE7;
// System.Func`2<System.Nullable`1<System.Double>,System.Boolean>
struct Func_2_t4B7DAD120FE072A61F61F9158CB1013D6F95E130;
// System.Func`2<System.Nullable`1<System.Int32>,System.Boolean>
struct Func_2_t42993C24F11175D8FA98C3DB6E40DC467687C57D;
// System.Func`2<System.Nullable`1<System.Int64>,System.Boolean>
struct Func_2_t1637E276420B054B58108E2AD51B1537DEC785D9;
// System.Func`2<System.Nullable`1<System.Single>,System.Boolean>
struct Func_2_t9B3CA7186DE9A33B978124F5B7131DD16456B41A;
// System.Func`2<System.ValueTuple`2<System.Object,System.Object>,System.Boolean>
struct Func_2_t139EF32B1D20FBA53B5FC13859124C746B2D3C04;
// System.Func`2<System.ValueTuple`2<System.Object,System.Object>,System.Int32>
struct Func_2_tEB5259FF5AA54436077282823F2EEBED7C80AECF;
// System.Func`2<System.ValueTuple`2<System.Object,System.Object>,System.Int64>
struct Func_2_tCCE8B772536DC33F644E3A0108AA7059ABA2EDB3;
// System.Func`2<System.ValueTuple`2<System.Object,System.Object>,System.Object>
struct Func_2_tD5B31A0553FE51700369DE1E4E6F33189C45045A;
// System.Func`2<System.ValueTuple`2<System.Object,System.Object>,System.Single>
struct Func_2_tCFA319B29B51C5B4FA9EE912CCB3BB9525555F72;
// System.Func`2<System.Boolean,System.Boolean>
struct Func_2_t50F598941CFDF02619DC5D52FFDBC329473C5F7B;
// System.Func`2<System.Boolean,System.Object>
struct Func_2_t51AFCB712DCD56A45EE1645FC1762C549DA040FB;
// System.Func`2<UnityEngine.Color,System.Boolean>
struct Func_2_t3985FFDAB0D05F8E97E8EA849D5A24F16EFFC4FD;
// System.Func`2<UnityEngine.Experimental.Rendering.Universal.LibTessDotNet.ContourVertex,System.Boolean>
struct Func_2_tD4EF074F88731E713305C48E156AB9F6F0F9324A;
// System.Func`2<UnityEngine.Experimental.Rendering.Universal.LibTessDotNet.ContourVertex,UnityEngine.Color>
struct Func_2_t07574F1E7EF84CF543A9B2FF0E62BB6B96696C64;
// System.Func`2<UnityEngine.Experimental.Rendering.Universal.LibTessDotNet.ContourVertex,UnityEngine.Vector3>
struct Func_2_tA55660D7B36BC919063457215A12594F309CFDF1;
// System.Func`2<UnityEngine.Experimental.Rendering.Universal.LibTessDotNet.ContourVertex,Unity.Mathematics.float3>
struct Func_2_t4ADAECFAD3DFE1FE3B6834A49502FA772B85CB3C;
// System.Func`2<System.Decimal,System.Boolean>
struct Func_2_t85912C5553CB5462E74F14A32388FC1004CC7C2E;
// System.Func`2<System.Decimal,System.Object>
struct Func_2_t19AF92FE90E4D29194E67E9C39AA7BDBF405CD01;
// System.Func`2<System.Double,System.Boolean>
struct Func_2_t4E607BF9FA9E115F43BD77F92F4285E3B8C7FB0D;
// System.Func`2<System.Double,System.Object>
struct Func_2_t9250D6A3AAE1BC9DC97036CF116D97FC17C08719;
// System.Func`2<System.Int32,System.Nullable`1<System.Decimal>>
struct Func_2_t2CF7067ECC6F2E1B8FC552857749A03DC1E5AE1E;
// System.Func`2<System.Int32,System.Nullable`1<System.Double>>
struct Func_2_t6C7618E0D575852E15D00A9E3CA463CE2CF5D159;
// System.Func`2<System.Int32,System.Nullable`1<System.Int32>>
struct Func_2_t212214032B3E2E671F2871ED55DFBC92A4EBD9C3;
// System.Func`2<System.Int32,System.Nullable`1<System.Int64>>
struct Func_2_tC286DBD1D3140BC4FC4D1DCF2D41DE03E72D8CAF;
// System.Func`2<System.Int32,System.Nullable`1<System.Single>>
struct Func_2_t6663A9FD2A53E3B599DF99EC970BF2320E8D9D40;
// System.Func`2<System.Int32,System.Boolean>
struct Func_2_t2EBF98B0BA555D9F0633C9BCCBE3DF332B9C1274;
// System.Func`2<System.Int32,System.Decimal>
struct Func_2_tBF5E42259B30DEB08B8F01DEAD14034173D7F115;
// System.Func`2<System.Int32,System.Double>
struct Func_2_t23C797B165C3B4B97ADF0BE92281F030E672AD4B;
// System.Func`2<System.Int32,System.Int32>
struct Func_2_tFF6AE79EFD0857556AD37A1A1594C43F76012FEA;
// System.Func`2<System.Int32,System.Int64>
struct Func_2_tAB99B2018719C6ADFD37FB04A207F07169AE46E0;
// System.Func`2<System.Int32,System.Object>
struct Func_2_t401E8A228CE43E56CCE9280AD9C6D87CC73A0123;
// System.Func`2<System.Int32,System.Single>
struct Func_2_t1452DFFA61F60F54CF3A78C987C4F98906EFD2B6;
// System.Func`2<System.Int64,System.Boolean>
struct Func_2_t03B9AF86FB7E93B62590F1CBD16276EF7AA1B215;
// System.Func`2<System.Int64,System.Object>
struct Func_2_tB6B8AC34A03E8EEE1C7FF71178B07B46BC827B7B;
// System.Func`2<System.Object,System.Nullable`1<System.Decimal>>
struct Func_2_t3818905EA774DF4C16A3B852ECBDEAA1B10478B4;
// System.Func`2<System.Object,System.Nullable`1<System.Double>>
struct Func_2_t969BC5FC9B68C7023AE4F7C254A78F446A7609F8;
// System.Func`2<System.Object,System.Nullable`1<System.Int32>>
struct Func_2_tF690BAA548D29EADC5635B1C8E7A7C6C9E4F7CFE;
// System.Func`2<System.Object,System.Nullable`1<System.Int64>>
struct Func_2_tF1DB5D7EFA801A89D60CE3A973ABC6EC71457FD5;
// System.Func`2<System.Object,System.Nullable`1<System.Single>>
struct Func_2_t936E494B9795BDACAC731255502447EA0D04753F;
// System.Func`2<System.Object,System.Boolean>
struct Func_2_t99409DECFF50F0FA9B427C863AC6C99C66E6F9F8;
// System.Func`2<System.Object,System.Decimal>
struct Func_2_t849BC6BC29946D6D8A1A3EB4E4406C8ADBD11CAA;
// System.Func`2<System.Object,System.Double>
struct Func_2_t32F4E81162C0EB5B67EF4324ABCC54A453AB7B22;
// System.Func`2<System.Object,System.Int32>
struct Func_2_t0CEE9D1C856153BA9C23BB9D7E929D577AF37A2C;
// System.Func`2<System.Object,System.Int64>
struct Func_2_tCA3E9A68051723CDABE44FC0BAE52FE7599059D6;
// System.Func`2<System.Object,System.Object>
struct Func_2_tFF5BB8F40A35B1BEA00D4EBBC6CBE7184A584436;
// System.Func`2<System.Object,System.Single>
struct Func_2_t78F21BB7B6C7D754A8C4D71ACB39668A8F967BA1;
// System.Func`2<System.Single,System.Boolean>
struct Func_2_t7214BC9C9A47482C751067B9A197D164F4041A3A;
// System.Func`2<System.Single,System.Object>
struct Func_2_tE11BDF71BCB314E58F1A9CFC9DAE08A5F717E2A0;
// System.Func`2<UnityEngine.Vector3,System.Boolean>
struct Func_2_t3041FD3183D19FE8416AE2E43A6398B2C06B7269;
// System.Func`2<Unity.Mathematics.float3,System.Boolean>
struct Func_2_t43355C55B1BBA93635101F6AF90867509812D7E5;
// System.Func`3<System.Object,System.Object,System.Object>
struct Func_3_tBBBFF266D23D5A9A7940D16DA73BCD5DE0753A27;
// System.Collections.Generic.IComparer`1<System.Int32>
struct IComparer_1_t150A86695C404E117B1B644BEAD79BA2344FB009;
// System.Collections.Generic.IEnumerable`1<System.Nullable`1<System.Decimal>>
struct IEnumerable_1_t064F7F73438EF566F6312C95B3E54C9799FF0FA7;
// System.Collections.Generic.IEnumerable`1<System.Nullable`1<System.Double>>
struct IEnumerable_1_tED7D298F70DE0BAB25320900E41E8EF6B348C5A4;
// System.Collections.Generic.IEnumerable`1<System.Nullable`1<System.Int32>>
struct IEnumerable_1_tADB400B43A76DA43063F5ED3C3BD11A7E9E10443;
// System.Collections.Generic.IEnumerable`1<System.Nullable`1<System.Int64>>
struct IEnumerable_1_t208ED0976D86C2A2C30818772373555237DB49B4;
// System.Collections.Generic.IEnumerable`1<System.Nullable`1<System.Single>>
struct IEnumerable_1_t8748D435947252D4C5978256F042AE257902FBAC;
// System.Collections.Generic.IEnumerable`1<System.Boolean>
struct IEnumerable_1_t90AD96F2C518D6F04343C83B67B02220C715C642;
// System.Collections.Generic.IEnumerable`1<UnityEngine.Color>
struct IEnumerable_1_tABC441119E42D460CA5B9DED9C1D1A2BD8C836DD;
// System.Collections.Generic.IEnumerable`1<System.Decimal>
struct IEnumerable_1_t4395DCD695AF41BD1BA767D249964AA4911362A4;
// System.Collections.Generic.IEnumerable`1<System.Double>
struct IEnumerable_1_t4DFA5CB8F95829BAC3B2C5251EA018F27F9EFCB2;
// System.Collections.Generic.IEnumerable`1<System.Int32>
struct IEnumerable_1_t60929E1AA80B46746F987B99A4EBD004FD72D370;
// System.Collections.Generic.IEnumerable`1<System.Int64>
struct IEnumerable_1_tBA0E6E878DA8F8DD29D887670962BCC85E2FCB3E;
// System.Collections.Generic.IEnumerable`1<System.Object>
struct IEnumerable_1_t52B1AC8D9E5E1ED28DF6C46A37C9A1B00B394F9D;
// System.Collections.Generic.IEnumerable`1<System.Single>
struct IEnumerable_1_t673DFF64E51C18A8B1287F4BD988966CE3B15A45;
// System.Collections.Generic.IEnumerable`1<UnityEngine.Vector3>
struct IEnumerable_1_tDBC849B8248C833C53F1762E771EFC477EB8AF18;
// System.Collections.Generic.IEnumerable`1<Unity.Mathematics.float3>
struct IEnumerable_1_tE6FE2A92BEFC9DD4F45302076646BA0D6F4807D9;
// System.Collections.Generic.IEnumerator`1<System.Nullable`1<System.Decimal>>
struct IEnumerator_1_t9B4F84C3FCE40E22A119C3FC876C4C34C9F9E571;
// System.Collections.Generic.IEnumerator`1<System.Nullable`1<System.Double>>
struct IEnumerator_1_tA81BA90EBFB8D2FDE82A9B0184355BF76542946B;
// System.Collections.Generic.IEnumerator`1<System.Nullable`1<System.Int32>>
struct IEnumerator_1_t63B92F0305D20A3DE4E1AB84D31F9ADF4C4CECE7;
// System.Collections.Generic.IEnumerator`1<System.Nullable`1<System.Int64>>
struct IEnumerator_1_tA0D18E8AC50EF2EDBD71960180ABA10DECC2A986;
// System.Collections.Generic.IEnumerator`1<System.Nullable`1<System.Single>>
struct IEnumerator_1_t1D180B9CD3019B7BA8EBC9C545F8A801CB443B5B;
// System.Collections.Generic.IEnumerator`1<System.Boolean>
struct IEnumerator_1_tD64DA1873BBF65E545905171348E0241A3B706C0;
// System.Collections.Generic.IEnumerator`1<UnityEngine.Color>
struct IEnumerator_1_t02C24C8A9AB2516412261243B17D8239575F3E86;
// System.Collections.Generic.IEnumerator`1<System.Decimal>
struct IEnumerator_1_t2A12E0F591DC9275837A4F2F46DD625C67D76F2B;
// System.Collections.Generic.IEnumerator`1<System.Double>
struct IEnumerator_1_t6BFD84269A7022891577378974C44D0A01467A63;
// System.Collections.Generic.IEnumerator`1<System.Int32>
struct IEnumerator_1_t72AB4B40AF5290B386215B0BFADC8919D394DCAB;
// System.Collections.Generic.IEnumerator`1<System.Int64>
struct IEnumerator_1_tAA2BE9F7B57F3BA20E480FBFDAC12A6CFDB0D296;
// System.Collections.Generic.IEnumerator`1<System.Object>
struct IEnumerator_1_t2DC97C7D486BF9E077C2BC2E517E434F393AA76E;
// System.Collections.Generic.IEnumerator`1<System.Single>
struct IEnumerator_1_t5918C99D6FA69C530D0287467B91ADE56FA3D7AF;
// System.Collections.Generic.IEnumerator`1<UnityEngine.Vector3>
struct IEnumerator_1_t9C426231952B863270D78D88F9DB5B4E9A16CC6A;
// System.Collections.Generic.IEnumerator`1<Unity.Mathematics.float3>
struct IEnumerator_1_tB485EF79267D439DD3A02E073C24196FEC5EDD52;
// System.Collections.Generic.IEqualityComparer`1<System.Object>
struct IEqualityComparer_1_t1A386BEF1855064FD5CC71F340A68881A52B4932;
// System.Collections.Generic.IList`1<System.Object>
struct IList_1_t707982BD768B18C51D263C759F33BCDBDFA44901;
// System.Linq.Parallel.IMergeHelper`1<System.Object>
struct IMergeHelper_1_t51F0AA1FA425EAF49B44631DCB5CD94D782AB417;
// System.Linq.Parallel.IPartitionedStreamRecipient`1<System.Object>
struct IPartitionedStreamRecipient_1_t80775437C53CCD3496D6C9B841684CA14ED1403C;
// System.Linq.Enumerable/Iterator`1<System.Nullable`1<System.Decimal>>
struct Iterator_1_tC3AC38DE0A9857A77F64882DC49BB78318A5EF00;
// System.Linq.Enumerable/Iterator`1<System.Nullable`1<System.Double>>
struct Iterator_1_t75B26B5E87871854D759A25738CFE42AF131D6A8;
// System.Linq.Enumerable/Iterator`1<System.Nullable`1<System.Int32>>
struct Iterator_1_t88E927D3E5FC45C833C1A5146A04FBA17D02CA43;
// System.Linq.Enumerable/Iterator`1<System.Nullable`1<System.Int64>>
struct Iterator_1_t7714579EDED47F91E8FBA7AF6D3F0674241FDF6C;
// System.Linq.Enumerable/Iterator`1<System.Nullable`1<System.Single>>
struct Iterator_1_t5F8CC81E7DD3167D5EC5BFC0984EBCEE64F5B45E;
// System.Linq.Enumerable/Iterator`1<System.Boolean>
struct Iterator_1_tF558BC64630CA9038F999F5A16CC3DD5A0DB6933;
// System.Linq.Enumerable/Iterator`1<UnityEngine.Color>
struct Iterator_1_tDEF6AC46E52D8687C27A6E60B6E0200D50011D76;
// System.Linq.Enumerable/Iterator`1<System.Decimal>
struct Iterator_1_t4861EDEAC91472CDE6F71F17BA6EF43B5D56F78E;
// System.Linq.Enumerable/Iterator`1<System.Double>
struct Iterator_1_t167C775670D48A9186D95126BDB6A078470CAE8D;
// System.Linq.Enumerable/Iterator`1<System.Int32>
struct Iterator_1_tCFFC952B03DBE4E956DE317DB9704D936AEA2379;
// System.Linq.Enumerable/Iterator`1<System.Int64>
struct Iterator_1_tF88FA02D56A55D26D525180DE0108FA4F019BECE;
// System.Linq.Enumerable/Iterator`1<System.Object>
struct Iterator_1_t674ABE41CF4096D4BE4D51E21FEBDADBF74CC279;
// System.Linq.Enumerable/Iterator`1<System.Single>
struct Iterator_1_t859CAAB8DD3B63D3758E13D2802ED7523B331199;
// System.Linq.Enumerable/Iterator`1<UnityEngine.Vector3>
struct Iterator_1_t04F5D870FD247BBBEE27254587FA10F440D4EEFF;
// System.Linq.Enumerable/Iterator`1<Unity.Mathematics.float3>
struct Iterator_1_tCEC2E244A64F110B247B6A3DF34DE60D4456BA1A;
// System.Collections.Generic.List`1<System.ValueTuple`2<System.Object,System.Object>>
struct List_1_tF837281ACA0AE5696644C85291C841E8820C7AAC;
// System.Collections.Generic.List`1<System.Boolean>
struct List_1_tD4D2BACE5281B6C85799892C1F12F5F2F81A2DF3;
// System.Collections.Generic.List`1<UnityEngine.Experimental.Rendering.Universal.LibTessDotNet.ContourVertex>
struct List_1_t793A994CE01AE29FEE85500B7E3540653BFE5A0C;
// System.Collections.Generic.List`1<System.Decimal>
struct List_1_t137B540BF717527106254AA05BE36A51A068C8F5;
// System.Collections.Generic.List`1<System.Double>
struct List_1_t760D7EED86247E3493CD5F22F0E822BF6AE1C2BC;
// System.Collections.Generic.List`1<System.Int32>
struct List_1_t260B41F956D673396C33A4CF94E8D6C4389EACB7;
// System.Collections.Generic.List`1<System.Int64>
struct List_1_tC465E4AAC82F54C0A79B2CE3B797531B10B9ACE4;
// System.Collections.Generic.List`1<System.Object>
struct List_1_t3F94120C77410A62EAE48421CF166B83AB95A2F5;
// System.Collections.Generic.List`1<System.Single>
struct List_1_t6726F9309570A0BDC5D42E10777F3E2931C487AA;
// System.Linq.Parallel.MergeExecutor`1<System.Object>
struct MergeExecutor_1_t53031849DE058B85127E8DDEEB6483EA88655E2D;
// System.Linq.ParallelQuery`1<System.Object>
struct ParallelQuery_1_t27EE69EA11DD2EF16DC5DCA17156F1CC9C5D3638;
// System.Linq.Parallel.QueryOperator`1<System.Object>
struct QueryOperator_1_t2F4038BA1C7627FB9361A0BC79E4F2A421AEF668;
// System.Linq.Parallel.QueryResults`1<System.Object>
struct QueryResults_1_t1956EED88B24434B080C8523FEDCF6843748F3D2;
// System.Linq.Parallel.Shared`1<System.Boolean>
struct Shared_1_t74E18ADA97BB3E28B39731FCA4223461A55BD971;
// System.Linq.Enumerable/WhereSelectListIterator`2<System.ValueTuple`2<System.Object,System.Object>,System.Int32>
struct WhereSelectListIterator_2_t6DF338AD50F89D3140CE0D070D507B13786150AC;
// System.Linq.Enumerable/WhereSelectListIterator`2<System.ValueTuple`2<System.Object,System.Object>,System.Int64>
struct WhereSelectListIterator_2_t74BEECDFAC30D3415AFB22B70C33682938B5343B;
// System.Linq.Enumerable/WhereSelectListIterator`2<System.ValueTuple`2<System.Object,System.Object>,System.Object>
struct WhereSelectListIterator_2_tF4580FBFA67D084FC48A2A4D3CCD114BE92FAD20;
// System.Linq.Enumerable/WhereSelectListIterator`2<System.ValueTuple`2<System.Object,System.Object>,System.Single>
struct WhereSelectListIterator_2_tBC8201B4C00B3004BB33AA252E6112F87595F077;
// System.Linq.Enumerable/WhereSelectListIterator`2<System.Boolean,System.Object>
struct WhereSelectListIterator_2_t7686D2FCD0C149BEF2A7DDFD0203E102E436E876;
// System.Linq.Enumerable/WhereSelectListIterator`2<UnityEngine.Experimental.Rendering.Universal.LibTessDotNet.ContourVertex,UnityEngine.Color>
struct WhereSelectListIterator_2_t08B768B4AD54F201B800C51471E1C1C5FD1A8E8C;
// System.Linq.Enumerable/WhereSelectListIterator`2<UnityEngine.Experimental.Rendering.Universal.LibTessDotNet.ContourVertex,UnityEngine.Vector3>
struct WhereSelectListIterator_2_t94F415FEA624816E42FAE1274A4EC29F5D5C1625;
// System.Linq.Enumerable/WhereSelectListIterator`2<UnityEngine.Experimental.Rendering.Universal.LibTessDotNet.ContourVertex,Unity.Mathematics.float3>
struct WhereSelectListIterator_2_t8005F348CC0B870A84DE3E85429A840305201D6E;
// System.Linq.Enumerable/WhereSelectListIterator`2<System.Decimal,System.Object>
struct WhereSelectListIterator_2_tAACFFE54E7C18BF4B0567FEF884C49B920B0FA6F;
// System.Linq.Enumerable/WhereSelectListIterator`2<System.Double,System.Object>
struct WhereSelectListIterator_2_tEAC6442837D35900886655E6EBECD17A00D72FF1;
// System.Linq.Enumerable/WhereSelectListIterator`2<System.Int32,System.Nullable`1<System.Decimal>>
struct WhereSelectListIterator_2_tE0E6511BEA6332534ECB4BFFD7FF61385E8B4D37;
// System.Linq.Enumerable/WhereSelectListIterator`2<System.Int32,System.Nullable`1<System.Double>>
struct WhereSelectListIterator_2_t1490C52A3F0E91B34D300F481F9E37F5F0FECEA4;
// System.Linq.Enumerable/WhereSelectListIterator`2<System.Int32,System.Nullable`1<System.Int32>>
struct WhereSelectListIterator_2_tDFB4A007D3032729411EC82D94FF3BD767D46B20;
// System.Linq.Enumerable/WhereSelectListIterator`2<System.Int32,System.Nullable`1<System.Int64>>
struct WhereSelectListIterator_2_t976CDD198DB8AC61A9A22BA501F3C314F00E2C78;
// System.Linq.Enumerable/WhereSelectListIterator`2<System.Int32,System.Nullable`1<System.Single>>
struct WhereSelectListIterator_2_tACE6C37EC1B04DF78ECD3C22632AB334307C46DB;
// System.Linq.Enumerable/WhereSelectListIterator`2<System.Int32,System.Boolean>
struct WhereSelectListIterator_2_t2989AC7E9CA6D1FB0231FD52E44E7AFC843ACA21;
// System.Linq.Enumerable/WhereSelectListIterator`2<System.Int32,System.Decimal>
struct WhereSelectListIterator_2_t2EBF84FB2CE39E9E5B9DD3AC4C33E4F0D6142BBC;
// System.Linq.Enumerable/WhereSelectListIterator`2<System.Int32,System.Double>
struct WhereSelectListIterator_2_tF60E714CAFC3118F16C82A15D86A38A42EFEDFA7;
// System.Linq.Enumerable/WhereSelectListIterator`2<System.Int32,System.Int32>
struct WhereSelectListIterator_2_t4CC3FE3A35610DC6F761EE7DB863B845957AD325;
// System.Linq.Enumerable/WhereSelectListIterator`2<System.Int32,System.Int64>
struct WhereSelectListIterator_2_t029DF87EF6C1A59C1658F051FF560E0216888A24;
// System.Linq.Enumerable/WhereSelectListIterator`2<System.Int32,System.Object>
struct WhereSelectListIterator_2_tA41D93FF12E41BB5A5BEA27AEED367695ADACEA4;
// System.Linq.Enumerable/WhereSelectListIterator`2<System.Int32,System.Single>
struct WhereSelectListIterator_2_tBCA9468991E9C8B9F4178D0FA0C99545886B7F06;
// System.Linq.Enumerable/WhereSelectListIterator`2<System.Int64,System.Object>
struct WhereSelectListIterator_2_t87107416F9D6AA1D41ED2E04567ABE36603547C9;
// System.Linq.Enumerable/WhereSelectListIterator`2<System.Object,System.Nullable`1<System.Decimal>>
struct WhereSelectListIterator_2_t49F3CEC3F8DE6BE9B2E0E65A36314CEEED603DE7;
// System.Linq.Enumerable/WhereSelectListIterator`2<System.Object,System.Nullable`1<System.Double>>
struct WhereSelectListIterator_2_tEE6392F7E2CDC15C2F3490EE288AB2275DEF7D9A;
// System.Linq.Enumerable/WhereSelectListIterator`2<System.Object,System.Nullable`1<System.Int32>>
struct WhereSelectListIterator_2_tAA7EB4891E566E311D0CC2850A8453EC4A1F2F1C;
// System.Linq.Enumerable/WhereSelectListIterator`2<System.Object,System.Nullable`1<System.Int64>>
struct WhereSelectListIterator_2_tDE07EDB851C318005CF3E85AFC71DB625406AACB;
// System.Linq.Enumerable/WhereSelectListIterator`2<System.Object,System.Nullable`1<System.Single>>
struct WhereSelectListIterator_2_tA3FAD38D0543C622EB734E603C9C973343DA791B;
// System.Linq.Enumerable/WhereSelectListIterator`2<System.Object,System.Boolean>
struct WhereSelectListIterator_2_t1135F63EC4A3B58BB9EDE8324AD11A2B64F209E2;
// System.Linq.Enumerable/WhereSelectListIterator`2<System.Object,System.Decimal>
struct WhereSelectListIterator_2_t613751E34DF4E5DB1F8E3A1B3B14696B0408ED62;
// System.Linq.Enumerable/WhereSelectListIterator`2<System.Object,System.Double>
struct WhereSelectListIterator_2_tFD5E5F4E072C47EE9200C7D42018559EEAA4E0CD;
// System.Linq.Enumerable/WhereSelectListIterator`2<System.Object,System.Int32>
struct WhereSelectListIterator_2_tA7C52B3E46CAC7800298BB868DD54565FDCB75B6;
// System.Linq.Enumerable/WhereSelectListIterator`2<System.Object,System.Int64>
struct WhereSelectListIterator_2_tB72C4254D904FF99DDF6A7B544158C7E96DF5323;
// System.Linq.Enumerable/WhereSelectListIterator`2<System.Object,System.Object>
struct WhereSelectListIterator_2_t85B78DFF0573BC95A62C79D6088FA39DFEBE1AF2;
// System.Linq.Enumerable/WhereSelectListIterator`2<System.Object,System.Single>
struct WhereSelectListIterator_2_t20DB17268C20F9E95977E2485885C2547B573A2F;
// System.Linq.Enumerable/WhereSelectListIterator`2<System.Single,System.Object>
struct WhereSelectListIterator_2_t77C04C3B7AD0F11B52AC864B3B1635FBFC5D2259;
// System.Collections.Concurrent.ConcurrentBag`1/WorkStealingQueue<System.Object>
struct WorkStealingQueue_t46BF20180E5A47304513625C3E005065BA4B93D7;
// System.Linq.Parallel.ZipQueryOperator`3/ZipQueryOperatorResults<System.Object,System.Object,System.Object>
struct ZipQueryOperatorResults_tB9DD58D5EFCC60A84DADC3938A2FFA8BAA7A6367;
// System.Linq.Parallel.ZipQueryOperator`3<System.Object,System.Object,System.Object>
struct ZipQueryOperator_3_t2D0121637CE51185E2CBB640EEAF8876A893637E;
// System.Linq.Parallel.QueryOperatorEnumerator`2<System.Object,System.Int32>[]
struct QueryOperatorEnumerator_2U5BU5D_t1B4A9F3A22210CE839D9CAE3FEAD3B53DABDC078;
// System.ValueTuple`2<System.Object,System.Object>[]
struct ValueTuple_2U5BU5D_tD132CAFC435A6E98F4DC6821CC5508CF6CED384A;
// System.Boolean[]
struct BooleanU5BU5D_tEC7BAF93C44F875016DAADC8696EE3A465644D3C;
// System.Char[]
struct CharU5BU5D_t7B7FC5BC8091AA3B9CB0B29CDD80B5EE9254AA34;
// UnityEngine.Experimental.Rendering.Universal.LibTessDotNet.ContourVertex[]
struct ContourVertexU5BU5D_tD78F2EA3E732B8F5B5201FA2D894087C252E6F36;
// System.Decimal[]
struct DecimalU5BU5D_tAA3302A4A6ACCE77638A2346993A0FAAE2F9FDBA;
// System.Delegate[]
struct DelegateU5BU5D_t677D8FE08A5F99E8EE49150B73966CD6E9BF7DB8;
// System.Double[]
struct DoubleU5BU5D_t8E1B42EB2ABB79FBD193A6B8C8D97A7CDE44A4FB;
// System.Int32[]
struct Int32U5BU5D_t70F1BDC14B1786481B176D6139A5E3B87DC54C32;
// System.Int64[]
struct Int64U5BU5D_tCA61E42872C63A4286B24EEE6E0650143B43DCE6;
// System.Object[]
struct ObjectU5BU5D_tC1F4EE0DB0B7300255F5FD4AF64FE4C585CF5ADE;
// System.Single[]
struct SingleU5BU5D_t47E8DBF5B597C122478D1FFBD9DD57399A0650FA;
// System.UInt32[]
struct UInt32U5BU5D_tCF06F1E9E72E0302C762578FF5358CC523F2A2CF;
// System.AsyncCallback
struct AsyncCallback_tA7921BEF974919C46FF8F9D9867C567B200BB0EA;
// System.Linq.Parallel.CancellationState
struct CancellationState_t302EEDE088D5E82EBE9A74EE31029F9CB981E9CC;
// System.Threading.CancellationTokenSource
struct CancellationTokenSource_t78B989179DE23EDD36F870FFEE20A15D6D3C65B3;
// System.DelegateData
struct DelegateData_t17DD30660E330C49381DAA99F934BE75CB11F288;
// System.IAsyncResult
struct IAsyncResult_tC9F97BF36FCF122D29D3101D80642278297BF370;
// System.Reflection.MethodInfo
struct MethodInfo_t;
// System.Linq.ParallelQuery
struct ParallelQuery_tA2D9886CB464C3FA8EB1BB56036F35E3AB55DEF4;
// System.String
struct String_t;
// System.Threading.Tasks.TaskScheduler
struct TaskScheduler_t74FBEEEDBDD5E0088FF0EEC18F45CD866B098D5D;
// System.Void
struct Void_t700C6383A2A510C2CF4DD86DABD5CA9FF70ADAC5;

IL2CPP_EXTERN_C RuntimeClass* Math_tA269614262430118C9FC5C4D9EF4F61C812568F0_il2cpp_TypeInfo_var;
IL2CPP_EXTERN_C const RuntimeMethod* Nullable_1_get_Value_mA0CB54A62D31AFC51F165263F2DB953605F2458D_RuntimeMethod_var;
IL2CPP_EXTERN_C const RuntimeMethod* WorkStealingQueue_LocalPush_m21A75830BF02EE497FA709E0A39B7EE096F7EEED_RuntimeMethod_var;
struct Delegate_t_marshaled_com;
struct Delegate_t_marshaled_pinvoke;

struct ObjectU5BU5D_tC1F4EE0DB0B7300255F5FD4AF64FE4C585CF5ADE;

IL2CPP_EXTERN_C_BEGIN
IL2CPP_EXTERN_C_END

#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

// System.Object


// System.Collections.Generic.EqualityComparer`1<System.Object>
struct EqualityComparer_1_t469B0BBE7B6765C576211BEF8F2803A5AD411A20  : public RuntimeObject
{
public:

public:
};

struct EqualityComparer_1_t469B0BBE7B6765C576211BEF8F2803A5AD411A20_StaticFields
{
public:
	// System.Collections.Generic.EqualityComparer`1<T> modreq(System.Runtime.CompilerServices.IsVolatile) System.Collections.Generic.EqualityComparer`1::defaultComparer
	EqualityComparer_1_t469B0BBE7B6765C576211BEF8F2803A5AD411A20 * ___defaultComparer_0;

public:
	inline static int32_t get_offset_of_defaultComparer_0() { return static_cast<int32_t>(offsetof(EqualityComparer_1_t469B0BBE7B6765C576211BEF8F2803A5AD411A20_StaticFields, ___defaultComparer_0)); }
	inline EqualityComparer_1_t469B0BBE7B6765C576211BEF8F2803A5AD411A20 * get_defaultComparer_0() const { return ___defaultComparer_0; }
	inline EqualityComparer_1_t469B0BBE7B6765C576211BEF8F2803A5AD411A20 ** get_address_of_defaultComparer_0() { return &___defaultComparer_0; }
	inline void set_defaultComparer_0(EqualityComparer_1_t469B0BBE7B6765C576211BEF8F2803A5AD411A20 * value)
	{
		___defaultComparer_0 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___defaultComparer_0), (void*)value);
	}
};


// System.Linq.Enumerable/Iterator`1<System.Boolean>
struct Iterator_1_tF558BC64630CA9038F999F5A16CC3DD5A0DB6933  : public RuntimeObject
{
public:
	// System.Int32 System.Linq.Enumerable/Iterator`1::threadId
	int32_t ___threadId_0;
	// System.Int32 System.Linq.Enumerable/Iterator`1::state
	int32_t ___state_1;
	// TSource System.Linq.Enumerable/Iterator`1::current
	bool ___current_2;

public:
	inline static int32_t get_offset_of_threadId_0() { return static_cast<int32_t>(offsetof(Iterator_1_tF558BC64630CA9038F999F5A16CC3DD5A0DB6933, ___threadId_0)); }
	inline int32_t get_threadId_0() const { return ___threadId_0; }
	inline int32_t* get_address_of_threadId_0() { return &___threadId_0; }
	inline void set_threadId_0(int32_t value)
	{
		___threadId_0 = value;
	}

	inline static int32_t get_offset_of_state_1() { return static_cast<int32_t>(offsetof(Iterator_1_tF558BC64630CA9038F999F5A16CC3DD5A0DB6933, ___state_1)); }
	inline int32_t get_state_1() const { return ___state_1; }
	inline int32_t* get_address_of_state_1() { return &___state_1; }
	inline void set_state_1(int32_t value)
	{
		___state_1 = value;
	}

	inline static int32_t get_offset_of_current_2() { return static_cast<int32_t>(offsetof(Iterator_1_tF558BC64630CA9038F999F5A16CC3DD5A0DB6933, ___current_2)); }
	inline bool get_current_2() const { return ___current_2; }
	inline bool* get_address_of_current_2() { return &___current_2; }
	inline void set_current_2(bool value)
	{
		___current_2 = value;
	}
};


// System.Linq.Enumerable/Iterator`1<System.Double>
struct Iterator_1_t167C775670D48A9186D95126BDB6A078470CAE8D  : public RuntimeObject
{
public:
	// System.Int32 System.Linq.Enumerable/Iterator`1::threadId
	int32_t ___threadId_0;
	// System.Int32 System.Linq.Enumerable/Iterator`1::state
	int32_t ___state_1;
	// TSource System.Linq.Enumerable/Iterator`1::current
	double ___current_2;

public:
	inline static int32_t get_offset_of_threadId_0() { return static_cast<int32_t>(offsetof(Iterator_1_t167C775670D48A9186D95126BDB6A078470CAE8D, ___threadId_0)); }
	inline int32_t get_threadId_0() const { return ___threadId_0; }
	inline int32_t* get_address_of_threadId_0() { return &___threadId_0; }
	inline void set_threadId_0(int32_t value)
	{
		___threadId_0 = value;
	}

	inline static int32_t get_offset_of_state_1() { return static_cast<int32_t>(offsetof(Iterator_1_t167C775670D48A9186D95126BDB6A078470CAE8D, ___state_1)); }
	inline int32_t get_state_1() const { return ___state_1; }
	inline int32_t* get_address_of_state_1() { return &___state_1; }
	inline void set_state_1(int32_t value)
	{
		___state_1 = value;
	}

	inline static int32_t get_offset_of_current_2() { return static_cast<int32_t>(offsetof(Iterator_1_t167C775670D48A9186D95126BDB6A078470CAE8D, ___current_2)); }
	inline double get_current_2() const { return ___current_2; }
	inline double* get_address_of_current_2() { return &___current_2; }
	inline void set_current_2(double value)
	{
		___current_2 = value;
	}
};


// System.Linq.Enumerable/Iterator`1<System.Int32>
struct Iterator_1_tCFFC952B03DBE4E956DE317DB9704D936AEA2379  : public RuntimeObject
{
public:
	// System.Int32 System.Linq.Enumerable/Iterator`1::threadId
	int32_t ___threadId_0;
	// System.Int32 System.Linq.Enumerable/Iterator`1::state
	int32_t ___state_1;
	// TSource System.Linq.Enumerable/Iterator`1::current
	int32_t ___current_2;

public:
	inline static int32_t get_offset_of_threadId_0() { return static_cast<int32_t>(offsetof(Iterator_1_tCFFC952B03DBE4E956DE317DB9704D936AEA2379, ___threadId_0)); }
	inline int32_t get_threadId_0() const { return ___threadId_0; }
	inline int32_t* get_address_of_threadId_0() { return &___threadId_0; }
	inline void set_threadId_0(int32_t value)
	{
		___threadId_0 = value;
	}

	inline static int32_t get_offset_of_state_1() { return static_cast<int32_t>(offsetof(Iterator_1_tCFFC952B03DBE4E956DE317DB9704D936AEA2379, ___state_1)); }
	inline int32_t get_state_1() const { return ___state_1; }
	inline int32_t* get_address_of_state_1() { return &___state_1; }
	inline void set_state_1(int32_t value)
	{
		___state_1 = value;
	}

	inline static int32_t get_offset_of_current_2() { return static_cast<int32_t>(offsetof(Iterator_1_tCFFC952B03DBE4E956DE317DB9704D936AEA2379, ___current_2)); }
	inline int32_t get_current_2() const { return ___current_2; }
	inline int32_t* get_address_of_current_2() { return &___current_2; }
	inline void set_current_2(int32_t value)
	{
		___current_2 = value;
	}
};


// System.Linq.Enumerable/Iterator`1<System.Int64>
struct Iterator_1_tF88FA02D56A55D26D525180DE0108FA4F019BECE  : public RuntimeObject
{
public:
	// System.Int32 System.Linq.Enumerable/Iterator`1::threadId
	int32_t ___threadId_0;
	// System.Int32 System.Linq.Enumerable/Iterator`1::state
	int32_t ___state_1;
	// TSource System.Linq.Enumerable/Iterator`1::current
	int64_t ___current_2;

public:
	inline static int32_t get_offset_of_threadId_0() { return static_cast<int32_t>(offsetof(Iterator_1_tF88FA02D56A55D26D525180DE0108FA4F019BECE, ___threadId_0)); }
	inline int32_t get_threadId_0() const { return ___threadId_0; }
	inline int32_t* get_address_of_threadId_0() { return &___threadId_0; }
	inline void set_threadId_0(int32_t value)
	{
		___threadId_0 = value;
	}

	inline static int32_t get_offset_of_state_1() { return static_cast<int32_t>(offsetof(Iterator_1_tF88FA02D56A55D26D525180DE0108FA4F019BECE, ___state_1)); }
	inline int32_t get_state_1() const { return ___state_1; }
	inline int32_t* get_address_of_state_1() { return &___state_1; }
	inline void set_state_1(int32_t value)
	{
		___state_1 = value;
	}

	inline static int32_t get_offset_of_current_2() { return static_cast<int32_t>(offsetof(Iterator_1_tF88FA02D56A55D26D525180DE0108FA4F019BECE, ___current_2)); }
	inline int64_t get_current_2() const { return ___current_2; }
	inline int64_t* get_address_of_current_2() { return &___current_2; }
	inline void set_current_2(int64_t value)
	{
		___current_2 = value;
	}
};


// System.Linq.Enumerable/Iterator`1<System.Object>
struct Iterator_1_t674ABE41CF4096D4BE4D51E21FEBDADBF74CC279  : public RuntimeObject
{
public:
	// System.Int32 System.Linq.Enumerable/Iterator`1::threadId
	int32_t ___threadId_0;
	// System.Int32 System.Linq.Enumerable/Iterator`1::state
	int32_t ___state_1;
	// TSource System.Linq.Enumerable/Iterator`1::current
	RuntimeObject * ___current_2;

public:
	inline static int32_t get_offset_of_threadId_0() { return static_cast<int32_t>(offsetof(Iterator_1_t674ABE41CF4096D4BE4D51E21FEBDADBF74CC279, ___threadId_0)); }
	inline int32_t get_threadId_0() const { return ___threadId_0; }
	inline int32_t* get_address_of_threadId_0() { return &___threadId_0; }
	inline void set_threadId_0(int32_t value)
	{
		___threadId_0 = value;
	}

	inline static int32_t get_offset_of_state_1() { return static_cast<int32_t>(offsetof(Iterator_1_t674ABE41CF4096D4BE4D51E21FEBDADBF74CC279, ___state_1)); }
	inline int32_t get_state_1() const { return ___state_1; }
	inline int32_t* get_address_of_state_1() { return &___state_1; }
	inline void set_state_1(int32_t value)
	{
		___state_1 = value;
	}

	inline static int32_t get_offset_of_current_2() { return static_cast<int32_t>(offsetof(Iterator_1_t674ABE41CF4096D4BE4D51E21FEBDADBF74CC279, ___current_2)); }
	inline RuntimeObject * get_current_2() const { return ___current_2; }
	inline RuntimeObject ** get_address_of_current_2() { return &___current_2; }
	inline void set_current_2(RuntimeObject * value)
	{
		___current_2 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___current_2), (void*)value);
	}
};


// System.Linq.Enumerable/Iterator`1<System.Single>
struct Iterator_1_t859CAAB8DD3B63D3758E13D2802ED7523B331199  : public RuntimeObject
{
public:
	// System.Int32 System.Linq.Enumerable/Iterator`1::threadId
	int32_t ___threadId_0;
	// System.Int32 System.Linq.Enumerable/Iterator`1::state
	int32_t ___state_1;
	// TSource System.Linq.Enumerable/Iterator`1::current
	float ___current_2;

public:
	inline static int32_t get_offset_of_threadId_0() { return static_cast<int32_t>(offsetof(Iterator_1_t859CAAB8DD3B63D3758E13D2802ED7523B331199, ___threadId_0)); }
	inline int32_t get_threadId_0() const { return ___threadId_0; }
	inline int32_t* get_address_of_threadId_0() { return &___threadId_0; }
	inline void set_threadId_0(int32_t value)
	{
		___threadId_0 = value;
	}

	inline static int32_t get_offset_of_state_1() { return static_cast<int32_t>(offsetof(Iterator_1_t859CAAB8DD3B63D3758E13D2802ED7523B331199, ___state_1)); }
	inline int32_t get_state_1() const { return ___state_1; }
	inline int32_t* get_address_of_state_1() { return &___state_1; }
	inline void set_state_1(int32_t value)
	{
		___state_1 = value;
	}

	inline static int32_t get_offset_of_current_2() { return static_cast<int32_t>(offsetof(Iterator_1_t859CAAB8DD3B63D3758E13D2802ED7523B331199, ___current_2)); }
	inline float get_current_2() const { return ___current_2; }
	inline float* get_address_of_current_2() { return &___current_2; }
	inline void set_current_2(float value)
	{
		___current_2 = value;
	}
};


// System.Collections.Generic.List`1<System.ValueTuple`2<System.Object,System.Object>>
struct List_1_tF837281ACA0AE5696644C85291C841E8820C7AAC  : public RuntimeObject
{
public:
	// T[] System.Collections.Generic.List`1::_items
	ValueTuple_2U5BU5D_tD132CAFC435A6E98F4DC6821CC5508CF6CED384A* ____items_1;
	// System.Int32 System.Collections.Generic.List`1::_size
	int32_t ____size_2;
	// System.Int32 System.Collections.Generic.List`1::_version
	int32_t ____version_3;
	// System.Object System.Collections.Generic.List`1::_syncRoot
	RuntimeObject * ____syncRoot_4;

public:
	inline static int32_t get_offset_of__items_1() { return static_cast<int32_t>(offsetof(List_1_tF837281ACA0AE5696644C85291C841E8820C7AAC, ____items_1)); }
	inline ValueTuple_2U5BU5D_tD132CAFC435A6E98F4DC6821CC5508CF6CED384A* get__items_1() const { return ____items_1; }
	inline ValueTuple_2U5BU5D_tD132CAFC435A6E98F4DC6821CC5508CF6CED384A** get_address_of__items_1() { return &____items_1; }
	inline void set__items_1(ValueTuple_2U5BU5D_tD132CAFC435A6E98F4DC6821CC5508CF6CED384A* value)
	{
		____items_1 = value;
		Il2CppCodeGenWriteBarrier((void**)(&____items_1), (void*)value);
	}

	inline static int32_t get_offset_of__size_2() { return static_cast<int32_t>(offsetof(List_1_tF837281ACA0AE5696644C85291C841E8820C7AAC, ____size_2)); }
	inline int32_t get__size_2() const { return ____size_2; }
	inline int32_t* get_address_of__size_2() { return &____size_2; }
	inline void set__size_2(int32_t value)
	{
		____size_2 = value;
	}

	inline static int32_t get_offset_of__version_3() { return static_cast<int32_t>(offsetof(List_1_tF837281ACA0AE5696644C85291C841E8820C7AAC, ____version_3)); }
	inline int32_t get__version_3() const { return ____version_3; }
	inline int32_t* get_address_of__version_3() { return &____version_3; }
	inline void set__version_3(int32_t value)
	{
		____version_3 = value;
	}

	inline static int32_t get_offset_of__syncRoot_4() { return static_cast<int32_t>(offsetof(List_1_tF837281ACA0AE5696644C85291C841E8820C7AAC, ____syncRoot_4)); }
	inline RuntimeObject * get__syncRoot_4() const { return ____syncRoot_4; }
	inline RuntimeObject ** get_address_of__syncRoot_4() { return &____syncRoot_4; }
	inline void set__syncRoot_4(RuntimeObject * value)
	{
		____syncRoot_4 = value;
		Il2CppCodeGenWriteBarrier((void**)(&____syncRoot_4), (void*)value);
	}
};

struct List_1_tF837281ACA0AE5696644C85291C841E8820C7AAC_StaticFields
{
public:
	// T[] System.Collections.Generic.List`1::_emptyArray
	ValueTuple_2U5BU5D_tD132CAFC435A6E98F4DC6821CC5508CF6CED384A* ____emptyArray_5;

public:
	inline static int32_t get_offset_of__emptyArray_5() { return static_cast<int32_t>(offsetof(List_1_tF837281ACA0AE5696644C85291C841E8820C7AAC_StaticFields, ____emptyArray_5)); }
	inline ValueTuple_2U5BU5D_tD132CAFC435A6E98F4DC6821CC5508CF6CED384A* get__emptyArray_5() const { return ____emptyArray_5; }
	inline ValueTuple_2U5BU5D_tD132CAFC435A6E98F4DC6821CC5508CF6CED384A** get_address_of__emptyArray_5() { return &____emptyArray_5; }
	inline void set__emptyArray_5(ValueTuple_2U5BU5D_tD132CAFC435A6E98F4DC6821CC5508CF6CED384A* value)
	{
		____emptyArray_5 = value;
		Il2CppCodeGenWriteBarrier((void**)(&____emptyArray_5), (void*)value);
	}
};


// System.Collections.Generic.List`1<System.Boolean>
struct List_1_tD4D2BACE5281B6C85799892C1F12F5F2F81A2DF3  : public RuntimeObject
{
public:
	// T[] System.Collections.Generic.List`1::_items
	BooleanU5BU5D_tEC7BAF93C44F875016DAADC8696EE3A465644D3C* ____items_1;
	// System.Int32 System.Collections.Generic.List`1::_size
	int32_t ____size_2;
	// System.Int32 System.Collections.Generic.List`1::_version
	int32_t ____version_3;
	// System.Object System.Collections.Generic.List`1::_syncRoot
	RuntimeObject * ____syncRoot_4;

public:
	inline static int32_t get_offset_of__items_1() { return static_cast<int32_t>(offsetof(List_1_tD4D2BACE5281B6C85799892C1F12F5F2F81A2DF3, ____items_1)); }
	inline BooleanU5BU5D_tEC7BAF93C44F875016DAADC8696EE3A465644D3C* get__items_1() const { return ____items_1; }
	inline BooleanU5BU5D_tEC7BAF93C44F875016DAADC8696EE3A465644D3C** get_address_of__items_1() { return &____items_1; }
	inline void set__items_1(BooleanU5BU5D_tEC7BAF93C44F875016DAADC8696EE3A465644D3C* value)
	{
		____items_1 = value;
		Il2CppCodeGenWriteBarrier((void**)(&____items_1), (void*)value);
	}

	inline static int32_t get_offset_of__size_2() { return static_cast<int32_t>(offsetof(List_1_tD4D2BACE5281B6C85799892C1F12F5F2F81A2DF3, ____size_2)); }
	inline int32_t get__size_2() const { return ____size_2; }
	inline int32_t* get_address_of__size_2() { return &____size_2; }
	inline void set__size_2(int32_t value)
	{
		____size_2 = value;
	}

	inline static int32_t get_offset_of__version_3() { return static_cast<int32_t>(offsetof(List_1_tD4D2BACE5281B6C85799892C1F12F5F2F81A2DF3, ____version_3)); }
	inline int32_t get__version_3() const { return ____version_3; }
	inline int32_t* get_address_of__version_3() { return &____version_3; }
	inline void set__version_3(int32_t value)
	{
		____version_3 = value;
	}

	inline static int32_t get_offset_of__syncRoot_4() { return static_cast<int32_t>(offsetof(List_1_tD4D2BACE5281B6C85799892C1F12F5F2F81A2DF3, ____syncRoot_4)); }
	inline RuntimeObject * get__syncRoot_4() const { return ____syncRoot_4; }
	inline RuntimeObject ** get_address_of__syncRoot_4() { return &____syncRoot_4; }
	inline void set__syncRoot_4(RuntimeObject * value)
	{
		____syncRoot_4 = value;
		Il2CppCodeGenWriteBarrier((void**)(&____syncRoot_4), (void*)value);
	}
};

struct List_1_tD4D2BACE5281B6C85799892C1F12F5F2F81A2DF3_StaticFields
{
public:
	// T[] System.Collections.Generic.List`1::_emptyArray
	BooleanU5BU5D_tEC7BAF93C44F875016DAADC8696EE3A465644D3C* ____emptyArray_5;

public:
	inline static int32_t get_offset_of__emptyArray_5() { return static_cast<int32_t>(offsetof(List_1_tD4D2BACE5281B6C85799892C1F12F5F2F81A2DF3_StaticFields, ____emptyArray_5)); }
	inline BooleanU5BU5D_tEC7BAF93C44F875016DAADC8696EE3A465644D3C* get__emptyArray_5() const { return ____emptyArray_5; }
	inline BooleanU5BU5D_tEC7BAF93C44F875016DAADC8696EE3A465644D3C** get_address_of__emptyArray_5() { return &____emptyArray_5; }
	inline void set__emptyArray_5(BooleanU5BU5D_tEC7BAF93C44F875016DAADC8696EE3A465644D3C* value)
	{
		____emptyArray_5 = value;
		Il2CppCodeGenWriteBarrier((void**)(&____emptyArray_5), (void*)value);
	}
};


// System.Collections.Generic.List`1<UnityEngine.Experimental.Rendering.Universal.LibTessDotNet.ContourVertex>
struct List_1_t793A994CE01AE29FEE85500B7E3540653BFE5A0C  : public RuntimeObject
{
public:
	// T[] System.Collections.Generic.List`1::_items
	ContourVertexU5BU5D_tD78F2EA3E732B8F5B5201FA2D894087C252E6F36* ____items_1;
	// System.Int32 System.Collections.Generic.List`1::_size
	int32_t ____size_2;
	// System.Int32 System.Collections.Generic.List`1::_version
	int32_t ____version_3;
	// System.Object System.Collections.Generic.List`1::_syncRoot
	RuntimeObject * ____syncRoot_4;

public:
	inline static int32_t get_offset_of__items_1() { return static_cast<int32_t>(offsetof(List_1_t793A994CE01AE29FEE85500B7E3540653BFE5A0C, ____items_1)); }
	inline ContourVertexU5BU5D_tD78F2EA3E732B8F5B5201FA2D894087C252E6F36* get__items_1() const { return ____items_1; }
	inline ContourVertexU5BU5D_tD78F2EA3E732B8F5B5201FA2D894087C252E6F36** get_address_of__items_1() { return &____items_1; }
	inline void set__items_1(ContourVertexU5BU5D_tD78F2EA3E732B8F5B5201FA2D894087C252E6F36* value)
	{
		____items_1 = value;
		Il2CppCodeGenWriteBarrier((void**)(&____items_1), (void*)value);
	}

	inline static int32_t get_offset_of__size_2() { return static_cast<int32_t>(offsetof(List_1_t793A994CE01AE29FEE85500B7E3540653BFE5A0C, ____size_2)); }
	inline int32_t get__size_2() const { return ____size_2; }
	inline int32_t* get_address_of__size_2() { return &____size_2; }
	inline void set__size_2(int32_t value)
	{
		____size_2 = value;
	}

	inline static int32_t get_offset_of__version_3() { return static_cast<int32_t>(offsetof(List_1_t793A994CE01AE29FEE85500B7E3540653BFE5A0C, ____version_3)); }
	inline int32_t get__version_3() const { return ____version_3; }
	inline int32_t* get_address_of__version_3() { return &____version_3; }
	inline void set__version_3(int32_t value)
	{
		____version_3 = value;
	}

	inline static int32_t get_offset_of__syncRoot_4() { return static_cast<int32_t>(offsetof(List_1_t793A994CE01AE29FEE85500B7E3540653BFE5A0C, ____syncRoot_4)); }
	inline RuntimeObject * get__syncRoot_4() const { return ____syncRoot_4; }
	inline RuntimeObject ** get_address_of__syncRoot_4() { return &____syncRoot_4; }
	inline void set__syncRoot_4(RuntimeObject * value)
	{
		____syncRoot_4 = value;
		Il2CppCodeGenWriteBarrier((void**)(&____syncRoot_4), (void*)value);
	}
};

struct List_1_t793A994CE01AE29FEE85500B7E3540653BFE5A0C_StaticFields
{
public:
	// T[] System.Collections.Generic.List`1::_emptyArray
	ContourVertexU5BU5D_tD78F2EA3E732B8F5B5201FA2D894087C252E6F36* ____emptyArray_5;

public:
	inline static int32_t get_offset_of__emptyArray_5() { return static_cast<int32_t>(offsetof(List_1_t793A994CE01AE29FEE85500B7E3540653BFE5A0C_StaticFields, ____emptyArray_5)); }
	inline ContourVertexU5BU5D_tD78F2EA3E732B8F5B5201FA2D894087C252E6F36* get__emptyArray_5() const { return ____emptyArray_5; }
	inline ContourVertexU5BU5D_tD78F2EA3E732B8F5B5201FA2D894087C252E6F36** get_address_of__emptyArray_5() { return &____emptyArray_5; }
	inline void set__emptyArray_5(ContourVertexU5BU5D_tD78F2EA3E732B8F5B5201FA2D894087C252E6F36* value)
	{
		____emptyArray_5 = value;
		Il2CppCodeGenWriteBarrier((void**)(&____emptyArray_5), (void*)value);
	}
};


// System.Collections.Generic.List`1<System.Decimal>
struct List_1_t137B540BF717527106254AA05BE36A51A068C8F5  : public RuntimeObject
{
public:
	// T[] System.Collections.Generic.List`1::_items
	DecimalU5BU5D_tAA3302A4A6ACCE77638A2346993A0FAAE2F9FDBA* ____items_1;
	// System.Int32 System.Collections.Generic.List`1::_size
	int32_t ____size_2;
	// System.Int32 System.Collections.Generic.List`1::_version
	int32_t ____version_3;
	// System.Object System.Collections.Generic.List`1::_syncRoot
	RuntimeObject * ____syncRoot_4;

public:
	inline static int32_t get_offset_of__items_1() { return static_cast<int32_t>(offsetof(List_1_t137B540BF717527106254AA05BE36A51A068C8F5, ____items_1)); }
	inline DecimalU5BU5D_tAA3302A4A6ACCE77638A2346993A0FAAE2F9FDBA* get__items_1() const { return ____items_1; }
	inline DecimalU5BU5D_tAA3302A4A6ACCE77638A2346993A0FAAE2F9FDBA** get_address_of__items_1() { return &____items_1; }
	inline void set__items_1(DecimalU5BU5D_tAA3302A4A6ACCE77638A2346993A0FAAE2F9FDBA* value)
	{
		____items_1 = value;
		Il2CppCodeGenWriteBarrier((void**)(&____items_1), (void*)value);
	}

	inline static int32_t get_offset_of__size_2() { return static_cast<int32_t>(offsetof(List_1_t137B540BF717527106254AA05BE36A51A068C8F5, ____size_2)); }
	inline int32_t get__size_2() const { return ____size_2; }
	inline int32_t* get_address_of__size_2() { return &____size_2; }
	inline void set__size_2(int32_t value)
	{
		____size_2 = value;
	}

	inline static int32_t get_offset_of__version_3() { return static_cast<int32_t>(offsetof(List_1_t137B540BF717527106254AA05BE36A51A068C8F5, ____version_3)); }
	inline int32_t get__version_3() const { return ____version_3; }
	inline int32_t* get_address_of__version_3() { return &____version_3; }
	inline void set__version_3(int32_t value)
	{
		____version_3 = value;
	}

	inline static int32_t get_offset_of__syncRoot_4() { return static_cast<int32_t>(offsetof(List_1_t137B540BF717527106254AA05BE36A51A068C8F5, ____syncRoot_4)); }
	inline RuntimeObject * get__syncRoot_4() const { return ____syncRoot_4; }
	inline RuntimeObject ** get_address_of__syncRoot_4() { return &____syncRoot_4; }
	inline void set__syncRoot_4(RuntimeObject * value)
	{
		____syncRoot_4 = value;
		Il2CppCodeGenWriteBarrier((void**)(&____syncRoot_4), (void*)value);
	}
};

struct List_1_t137B540BF717527106254AA05BE36A51A068C8F5_StaticFields
{
public:
	// T[] System.Collections.Generic.List`1::_emptyArray
	DecimalU5BU5D_tAA3302A4A6ACCE77638A2346993A0FAAE2F9FDBA* ____emptyArray_5;

public:
	inline static int32_t get_offset_of__emptyArray_5() { return static_cast<int32_t>(offsetof(List_1_t137B540BF717527106254AA05BE36A51A068C8F5_StaticFields, ____emptyArray_5)); }
	inline DecimalU5BU5D_tAA3302A4A6ACCE77638A2346993A0FAAE2F9FDBA* get__emptyArray_5() const { return ____emptyArray_5; }
	inline DecimalU5BU5D_tAA3302A4A6ACCE77638A2346993A0FAAE2F9FDBA** get_address_of__emptyArray_5() { return &____emptyArray_5; }
	inline void set__emptyArray_5(DecimalU5BU5D_tAA3302A4A6ACCE77638A2346993A0FAAE2F9FDBA* value)
	{
		____emptyArray_5 = value;
		Il2CppCodeGenWriteBarrier((void**)(&____emptyArray_5), (void*)value);
	}
};


// System.Collections.Generic.List`1<System.Double>
struct List_1_t760D7EED86247E3493CD5F22F0E822BF6AE1C2BC  : public RuntimeObject
{
public:
	// T[] System.Collections.Generic.List`1::_items
	DoubleU5BU5D_t8E1B42EB2ABB79FBD193A6B8C8D97A7CDE44A4FB* ____items_1;
	// System.Int32 System.Collections.Generic.List`1::_size
	int32_t ____size_2;
	// System.Int32 System.Collections.Generic.List`1::_version
	int32_t ____version_3;
	// System.Object System.Collections.Generic.List`1::_syncRoot
	RuntimeObject * ____syncRoot_4;

public:
	inline static int32_t get_offset_of__items_1() { return static_cast<int32_t>(offsetof(List_1_t760D7EED86247E3493CD5F22F0E822BF6AE1C2BC, ____items_1)); }
	inline DoubleU5BU5D_t8E1B42EB2ABB79FBD193A6B8C8D97A7CDE44A4FB* get__items_1() const { return ____items_1; }
	inline DoubleU5BU5D_t8E1B42EB2ABB79FBD193A6B8C8D97A7CDE44A4FB** get_address_of__items_1() { return &____items_1; }
	inline void set__items_1(DoubleU5BU5D_t8E1B42EB2ABB79FBD193A6B8C8D97A7CDE44A4FB* value)
	{
		____items_1 = value;
		Il2CppCodeGenWriteBarrier((void**)(&____items_1), (void*)value);
	}

	inline static int32_t get_offset_of__size_2() { return static_cast<int32_t>(offsetof(List_1_t760D7EED86247E3493CD5F22F0E822BF6AE1C2BC, ____size_2)); }
	inline int32_t get__size_2() const { return ____size_2; }
	inline int32_t* get_address_of__size_2() { return &____size_2; }
	inline void set__size_2(int32_t value)
	{
		____size_2 = value;
	}

	inline static int32_t get_offset_of__version_3() { return static_cast<int32_t>(offsetof(List_1_t760D7EED86247E3493CD5F22F0E822BF6AE1C2BC, ____version_3)); }
	inline int32_t get__version_3() const { return ____version_3; }
	inline int32_t* get_address_of__version_3() { return &____version_3; }
	inline void set__version_3(int32_t value)
	{
		____version_3 = value;
	}

	inline static int32_t get_offset_of__syncRoot_4() { return static_cast<int32_t>(offsetof(List_1_t760D7EED86247E3493CD5F22F0E822BF6AE1C2BC, ____syncRoot_4)); }
	inline RuntimeObject * get__syncRoot_4() const { return ____syncRoot_4; }
	inline RuntimeObject ** get_address_of__syncRoot_4() { return &____syncRoot_4; }
	inline void set__syncRoot_4(RuntimeObject * value)
	{
		____syncRoot_4 = value;
		Il2CppCodeGenWriteBarrier((void**)(&____syncRoot_4), (void*)value);
	}
};

struct List_1_t760D7EED86247E3493CD5F22F0E822BF6AE1C2BC_StaticFields
{
public:
	// T[] System.Collections.Generic.List`1::_emptyArray
	DoubleU5BU5D_t8E1B42EB2ABB79FBD193A6B8C8D97A7CDE44A4FB* ____emptyArray_5;

public:
	inline static int32_t get_offset_of__emptyArray_5() { return static_cast<int32_t>(offsetof(List_1_t760D7EED86247E3493CD5F22F0E822BF6AE1C2BC_StaticFields, ____emptyArray_5)); }
	inline DoubleU5BU5D_t8E1B42EB2ABB79FBD193A6B8C8D97A7CDE44A4FB* get__emptyArray_5() const { return ____emptyArray_5; }
	inline DoubleU5BU5D_t8E1B42EB2ABB79FBD193A6B8C8D97A7CDE44A4FB** get_address_of__emptyArray_5() { return &____emptyArray_5; }
	inline void set__emptyArray_5(DoubleU5BU5D_t8E1B42EB2ABB79FBD193A6B8C8D97A7CDE44A4FB* value)
	{
		____emptyArray_5 = value;
		Il2CppCodeGenWriteBarrier((void**)(&____emptyArray_5), (void*)value);
	}
};


// System.Collections.Generic.List`1<System.Int32>
struct List_1_t260B41F956D673396C33A4CF94E8D6C4389EACB7  : public RuntimeObject
{
public:
	// T[] System.Collections.Generic.List`1::_items
	Int32U5BU5D_t70F1BDC14B1786481B176D6139A5E3B87DC54C32* ____items_1;
	// System.Int32 System.Collections.Generic.List`1::_size
	int32_t ____size_2;
	// System.Int32 System.Collections.Generic.List`1::_version
	int32_t ____version_3;
	// System.Object System.Collections.Generic.List`1::_syncRoot
	RuntimeObject * ____syncRoot_4;

public:
	inline static int32_t get_offset_of__items_1() { return static_cast<int32_t>(offsetof(List_1_t260B41F956D673396C33A4CF94E8D6C4389EACB7, ____items_1)); }
	inline Int32U5BU5D_t70F1BDC14B1786481B176D6139A5E3B87DC54C32* get__items_1() const { return ____items_1; }
	inline Int32U5BU5D_t70F1BDC14B1786481B176D6139A5E3B87DC54C32** get_address_of__items_1() { return &____items_1; }
	inline void set__items_1(Int32U5BU5D_t70F1BDC14B1786481B176D6139A5E3B87DC54C32* value)
	{
		____items_1 = value;
		Il2CppCodeGenWriteBarrier((void**)(&____items_1), (void*)value);
	}

	inline static int32_t get_offset_of__size_2() { return static_cast<int32_t>(offsetof(List_1_t260B41F956D673396C33A4CF94E8D6C4389EACB7, ____size_2)); }
	inline int32_t get__size_2() const { return ____size_2; }
	inline int32_t* get_address_of__size_2() { return &____size_2; }
	inline void set__size_2(int32_t value)
	{
		____size_2 = value;
	}

	inline static int32_t get_offset_of__version_3() { return static_cast<int32_t>(offsetof(List_1_t260B41F956D673396C33A4CF94E8D6C4389EACB7, ____version_3)); }
	inline int32_t get__version_3() const { return ____version_3; }
	inline int32_t* get_address_of__version_3() { return &____version_3; }
	inline void set__version_3(int32_t value)
	{
		____version_3 = value;
	}

	inline static int32_t get_offset_of__syncRoot_4() { return static_cast<int32_t>(offsetof(List_1_t260B41F956D673396C33A4CF94E8D6C4389EACB7, ____syncRoot_4)); }
	inline RuntimeObject * get__syncRoot_4() const { return ____syncRoot_4; }
	inline RuntimeObject ** get_address_of__syncRoot_4() { return &____syncRoot_4; }
	inline void set__syncRoot_4(RuntimeObject * value)
	{
		____syncRoot_4 = value;
		Il2CppCodeGenWriteBarrier((void**)(&____syncRoot_4), (void*)value);
	}
};

struct List_1_t260B41F956D673396C33A4CF94E8D6C4389EACB7_StaticFields
{
public:
	// T[] System.Collections.Generic.List`1::_emptyArray
	Int32U5BU5D_t70F1BDC14B1786481B176D6139A5E3B87DC54C32* ____emptyArray_5;

public:
	inline static int32_t get_offset_of__emptyArray_5() { return static_cast<int32_t>(offsetof(List_1_t260B41F956D673396C33A4CF94E8D6C4389EACB7_StaticFields, ____emptyArray_5)); }
	inline Int32U5BU5D_t70F1BDC14B1786481B176D6139A5E3B87DC54C32* get__emptyArray_5() const { return ____emptyArray_5; }
	inline Int32U5BU5D_t70F1BDC14B1786481B176D6139A5E3B87DC54C32** get_address_of__emptyArray_5() { return &____emptyArray_5; }
	inline void set__emptyArray_5(Int32U5BU5D_t70F1BDC14B1786481B176D6139A5E3B87DC54C32* value)
	{
		____emptyArray_5 = value;
		Il2CppCodeGenWriteBarrier((void**)(&____emptyArray_5), (void*)value);
	}
};


// System.Collections.Generic.List`1<System.Int64>
struct List_1_tC465E4AAC82F54C0A79B2CE3B797531B10B9ACE4  : public RuntimeObject
{
public:
	// T[] System.Collections.Generic.List`1::_items
	Int64U5BU5D_tCA61E42872C63A4286B24EEE6E0650143B43DCE6* ____items_1;
	// System.Int32 System.Collections.Generic.List`1::_size
	int32_t ____size_2;
	// System.Int32 System.Collections.Generic.List`1::_version
	int32_t ____version_3;
	// System.Object System.Collections.Generic.List`1::_syncRoot
	RuntimeObject * ____syncRoot_4;

public:
	inline static int32_t get_offset_of__items_1() { return static_cast<int32_t>(offsetof(List_1_tC465E4AAC82F54C0A79B2CE3B797531B10B9ACE4, ____items_1)); }
	inline Int64U5BU5D_tCA61E42872C63A4286B24EEE6E0650143B43DCE6* get__items_1() const { return ____items_1; }
	inline Int64U5BU5D_tCA61E42872C63A4286B24EEE6E0650143B43DCE6** get_address_of__items_1() { return &____items_1; }
	inline void set__items_1(Int64U5BU5D_tCA61E42872C63A4286B24EEE6E0650143B43DCE6* value)
	{
		____items_1 = value;
		Il2CppCodeGenWriteBarrier((void**)(&____items_1), (void*)value);
	}

	inline static int32_t get_offset_of__size_2() { return static_cast<int32_t>(offsetof(List_1_tC465E4AAC82F54C0A79B2CE3B797531B10B9ACE4, ____size_2)); }
	inline int32_t get__size_2() const { return ____size_2; }
	inline int32_t* get_address_of__size_2() { return &____size_2; }
	inline void set__size_2(int32_t value)
	{
		____size_2 = value;
	}

	inline static int32_t get_offset_of__version_3() { return static_cast<int32_t>(offsetof(List_1_tC465E4AAC82F54C0A79B2CE3B797531B10B9ACE4, ____version_3)); }
	inline int32_t get__version_3() const { return ____version_3; }
	inline int32_t* get_address_of__version_3() { return &____version_3; }
	inline void set__version_3(int32_t value)
	{
		____version_3 = value;
	}

	inline static int32_t get_offset_of__syncRoot_4() { return static_cast<int32_t>(offsetof(List_1_tC465E4AAC82F54C0A79B2CE3B797531B10B9ACE4, ____syncRoot_4)); }
	inline RuntimeObject * get__syncRoot_4() const { return ____syncRoot_4; }
	inline RuntimeObject ** get_address_of__syncRoot_4() { return &____syncRoot_4; }
	inline void set__syncRoot_4(RuntimeObject * value)
	{
		____syncRoot_4 = value;
		Il2CppCodeGenWriteBarrier((void**)(&____syncRoot_4), (void*)value);
	}
};

struct List_1_tC465E4AAC82F54C0A79B2CE3B797531B10B9ACE4_StaticFields
{
public:
	// T[] System.Collections.Generic.List`1::_emptyArray
	Int64U5BU5D_tCA61E42872C63A4286B24EEE6E0650143B43DCE6* ____emptyArray_5;

public:
	inline static int32_t get_offset_of__emptyArray_5() { return static_cast<int32_t>(offsetof(List_1_tC465E4AAC82F54C0A79B2CE3B797531B10B9ACE4_StaticFields, ____emptyArray_5)); }
	inline Int64U5BU5D_tCA61E42872C63A4286B24EEE6E0650143B43DCE6* get__emptyArray_5() const { return ____emptyArray_5; }
	inline Int64U5BU5D_tCA61E42872C63A4286B24EEE6E0650143B43DCE6** get_address_of__emptyArray_5() { return &____emptyArray_5; }
	inline void set__emptyArray_5(Int64U5BU5D_tCA61E42872C63A4286B24EEE6E0650143B43DCE6* value)
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


// System.Linq.Parallel.MergeExecutor`1<System.Object>
struct MergeExecutor_1_t53031849DE058B85127E8DDEEB6483EA88655E2D  : public RuntimeObject
{
public:
	// System.Linq.Parallel.IMergeHelper`1<TInputOutput> System.Linq.Parallel.MergeExecutor`1::_mergeHelper
	RuntimeObject* ____mergeHelper_0;

public:
	inline static int32_t get_offset_of__mergeHelper_0() { return static_cast<int32_t>(offsetof(MergeExecutor_1_t53031849DE058B85127E8DDEEB6483EA88655E2D, ____mergeHelper_0)); }
	inline RuntimeObject* get__mergeHelper_0() const { return ____mergeHelper_0; }
	inline RuntimeObject** get_address_of__mergeHelper_0() { return &____mergeHelper_0; }
	inline void set__mergeHelper_0(RuntimeObject* value)
	{
		____mergeHelper_0 = value;
		Il2CppCodeGenWriteBarrier((void**)(&____mergeHelper_0), (void*)value);
	}
};


// System.Linq.Parallel.QueryResults`1<System.Object>
struct QueryResults_1_t1956EED88B24434B080C8523FEDCF6843748F3D2  : public RuntimeObject
{
public:

public:
};

struct Il2CppArrayBounds;

// System.Array


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

// System.Collections.Generic.List`1/Enumerator<System.Boolean>
struct Enumerator_t3F9663F5F32B0D733380A76CCEAA3ADFA3AE34A9 
{
public:
	// System.Collections.Generic.List`1<T> System.Collections.Generic.List`1/Enumerator::list
	List_1_tD4D2BACE5281B6C85799892C1F12F5F2F81A2DF3 * ___list_0;
	// System.Int32 System.Collections.Generic.List`1/Enumerator::index
	int32_t ___index_1;
	// System.Int32 System.Collections.Generic.List`1/Enumerator::version
	int32_t ___version_2;
	// T System.Collections.Generic.List`1/Enumerator::current
	bool ___current_3;

public:
	inline static int32_t get_offset_of_list_0() { return static_cast<int32_t>(offsetof(Enumerator_t3F9663F5F32B0D733380A76CCEAA3ADFA3AE34A9, ___list_0)); }
	inline List_1_tD4D2BACE5281B6C85799892C1F12F5F2F81A2DF3 * get_list_0() const { return ___list_0; }
	inline List_1_tD4D2BACE5281B6C85799892C1F12F5F2F81A2DF3 ** get_address_of_list_0() { return &___list_0; }
	inline void set_list_0(List_1_tD4D2BACE5281B6C85799892C1F12F5F2F81A2DF3 * value)
	{
		___list_0 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___list_0), (void*)value);
	}

	inline static int32_t get_offset_of_index_1() { return static_cast<int32_t>(offsetof(Enumerator_t3F9663F5F32B0D733380A76CCEAA3ADFA3AE34A9, ___index_1)); }
	inline int32_t get_index_1() const { return ___index_1; }
	inline int32_t* get_address_of_index_1() { return &___index_1; }
	inline void set_index_1(int32_t value)
	{
		___index_1 = value;
	}

	inline static int32_t get_offset_of_version_2() { return static_cast<int32_t>(offsetof(Enumerator_t3F9663F5F32B0D733380A76CCEAA3ADFA3AE34A9, ___version_2)); }
	inline int32_t get_version_2() const { return ___version_2; }
	inline int32_t* get_address_of_version_2() { return &___version_2; }
	inline void set_version_2(int32_t value)
	{
		___version_2 = value;
	}

	inline static int32_t get_offset_of_current_3() { return static_cast<int32_t>(offsetof(Enumerator_t3F9663F5F32B0D733380A76CCEAA3ADFA3AE34A9, ___current_3)); }
	inline bool get_current_3() const { return ___current_3; }
	inline bool* get_address_of_current_3() { return &___current_3; }
	inline void set_current_3(bool value)
	{
		___current_3 = value;
	}
};


// System.Collections.Generic.List`1/Enumerator<System.Double>
struct Enumerator_tDB7E887EC564EBF2D244915021ED0896BFD7A8A2 
{
public:
	// System.Collections.Generic.List`1<T> System.Collections.Generic.List`1/Enumerator::list
	List_1_t760D7EED86247E3493CD5F22F0E822BF6AE1C2BC * ___list_0;
	// System.Int32 System.Collections.Generic.List`1/Enumerator::index
	int32_t ___index_1;
	// System.Int32 System.Collections.Generic.List`1/Enumerator::version
	int32_t ___version_2;
	// T System.Collections.Generic.List`1/Enumerator::current
	double ___current_3;

public:
	inline static int32_t get_offset_of_list_0() { return static_cast<int32_t>(offsetof(Enumerator_tDB7E887EC564EBF2D244915021ED0896BFD7A8A2, ___list_0)); }
	inline List_1_t760D7EED86247E3493CD5F22F0E822BF6AE1C2BC * get_list_0() const { return ___list_0; }
	inline List_1_t760D7EED86247E3493CD5F22F0E822BF6AE1C2BC ** get_address_of_list_0() { return &___list_0; }
	inline void set_list_0(List_1_t760D7EED86247E3493CD5F22F0E822BF6AE1C2BC * value)
	{
		___list_0 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___list_0), (void*)value);
	}

	inline static int32_t get_offset_of_index_1() { return static_cast<int32_t>(offsetof(Enumerator_tDB7E887EC564EBF2D244915021ED0896BFD7A8A2, ___index_1)); }
	inline int32_t get_index_1() const { return ___index_1; }
	inline int32_t* get_address_of_index_1() { return &___index_1; }
	inline void set_index_1(int32_t value)
	{
		___index_1 = value;
	}

	inline static int32_t get_offset_of_version_2() { return static_cast<int32_t>(offsetof(Enumerator_tDB7E887EC564EBF2D244915021ED0896BFD7A8A2, ___version_2)); }
	inline int32_t get_version_2() const { return ___version_2; }
	inline int32_t* get_address_of_version_2() { return &___version_2; }
	inline void set_version_2(int32_t value)
	{
		___version_2 = value;
	}

	inline static int32_t get_offset_of_current_3() { return static_cast<int32_t>(offsetof(Enumerator_tDB7E887EC564EBF2D244915021ED0896BFD7A8A2, ___current_3)); }
	inline double get_current_3() const { return ___current_3; }
	inline double* get_address_of_current_3() { return &___current_3; }
	inline void set_current_3(double value)
	{
		___current_3 = value;
	}
};


// System.Collections.Generic.List`1/Enumerator<System.Int32>
struct Enumerator_t7BA00929E14A2F2A62CE085585044A3FEB2C5F3C 
{
public:
	// System.Collections.Generic.List`1<T> System.Collections.Generic.List`1/Enumerator::list
	List_1_t260B41F956D673396C33A4CF94E8D6C4389EACB7 * ___list_0;
	// System.Int32 System.Collections.Generic.List`1/Enumerator::index
	int32_t ___index_1;
	// System.Int32 System.Collections.Generic.List`1/Enumerator::version
	int32_t ___version_2;
	// T System.Collections.Generic.List`1/Enumerator::current
	int32_t ___current_3;

public:
	inline static int32_t get_offset_of_list_0() { return static_cast<int32_t>(offsetof(Enumerator_t7BA00929E14A2F2A62CE085585044A3FEB2C5F3C, ___list_0)); }
	inline List_1_t260B41F956D673396C33A4CF94E8D6C4389EACB7 * get_list_0() const { return ___list_0; }
	inline List_1_t260B41F956D673396C33A4CF94E8D6C4389EACB7 ** get_address_of_list_0() { return &___list_0; }
	inline void set_list_0(List_1_t260B41F956D673396C33A4CF94E8D6C4389EACB7 * value)
	{
		___list_0 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___list_0), (void*)value);
	}

	inline static int32_t get_offset_of_index_1() { return static_cast<int32_t>(offsetof(Enumerator_t7BA00929E14A2F2A62CE085585044A3FEB2C5F3C, ___index_1)); }
	inline int32_t get_index_1() const { return ___index_1; }
	inline int32_t* get_address_of_index_1() { return &___index_1; }
	inline void set_index_1(int32_t value)
	{
		___index_1 = value;
	}

	inline static int32_t get_offset_of_version_2() { return static_cast<int32_t>(offsetof(Enumerator_t7BA00929E14A2F2A62CE085585044A3FEB2C5F3C, ___version_2)); }
	inline int32_t get_version_2() const { return ___version_2; }
	inline int32_t* get_address_of_version_2() { return &___version_2; }
	inline void set_version_2(int32_t value)
	{
		___version_2 = value;
	}

	inline static int32_t get_offset_of_current_3() { return static_cast<int32_t>(offsetof(Enumerator_t7BA00929E14A2F2A62CE085585044A3FEB2C5F3C, ___current_3)); }
	inline int32_t get_current_3() const { return ___current_3; }
	inline int32_t* get_address_of_current_3() { return &___current_3; }
	inline void set_current_3(int32_t value)
	{
		___current_3 = value;
	}
};


// System.Collections.Generic.List`1/Enumerator<System.Int64>
struct Enumerator_t1C02C38119DFDA075166A979AE2B70CCA911ED37 
{
public:
	// System.Collections.Generic.List`1<T> System.Collections.Generic.List`1/Enumerator::list
	List_1_tC465E4AAC82F54C0A79B2CE3B797531B10B9ACE4 * ___list_0;
	// System.Int32 System.Collections.Generic.List`1/Enumerator::index
	int32_t ___index_1;
	// System.Int32 System.Collections.Generic.List`1/Enumerator::version
	int32_t ___version_2;
	// T System.Collections.Generic.List`1/Enumerator::current
	int64_t ___current_3;

public:
	inline static int32_t get_offset_of_list_0() { return static_cast<int32_t>(offsetof(Enumerator_t1C02C38119DFDA075166A979AE2B70CCA911ED37, ___list_0)); }
	inline List_1_tC465E4AAC82F54C0A79B2CE3B797531B10B9ACE4 * get_list_0() const { return ___list_0; }
	inline List_1_tC465E4AAC82F54C0A79B2CE3B797531B10B9ACE4 ** get_address_of_list_0() { return &___list_0; }
	inline void set_list_0(List_1_tC465E4AAC82F54C0A79B2CE3B797531B10B9ACE4 * value)
	{
		___list_0 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___list_0), (void*)value);
	}

	inline static int32_t get_offset_of_index_1() { return static_cast<int32_t>(offsetof(Enumerator_t1C02C38119DFDA075166A979AE2B70CCA911ED37, ___index_1)); }
	inline int32_t get_index_1() const { return ___index_1; }
	inline int32_t* get_address_of_index_1() { return &___index_1; }
	inline void set_index_1(int32_t value)
	{
		___index_1 = value;
	}

	inline static int32_t get_offset_of_version_2() { return static_cast<int32_t>(offsetof(Enumerator_t1C02C38119DFDA075166A979AE2B70CCA911ED37, ___version_2)); }
	inline int32_t get_version_2() const { return ___version_2; }
	inline int32_t* get_address_of_version_2() { return &___version_2; }
	inline void set_version_2(int32_t value)
	{
		___version_2 = value;
	}

	inline static int32_t get_offset_of_current_3() { return static_cast<int32_t>(offsetof(Enumerator_t1C02C38119DFDA075166A979AE2B70CCA911ED37, ___current_3)); }
	inline int64_t get_current_3() const { return ___current_3; }
	inline int64_t* get_address_of_current_3() { return &___current_3; }
	inline void set_current_3(int64_t value)
	{
		___current_3 = value;
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


// System.Collections.Generic.List`1/Enumerator<System.Single>
struct Enumerator_tC1FD01C8BB5327D442D71FD022B4338ACD701783 
{
public:
	// System.Collections.Generic.List`1<T> System.Collections.Generic.List`1/Enumerator::list
	List_1_t6726F9309570A0BDC5D42E10777F3E2931C487AA * ___list_0;
	// System.Int32 System.Collections.Generic.List`1/Enumerator::index
	int32_t ___index_1;
	// System.Int32 System.Collections.Generic.List`1/Enumerator::version
	int32_t ___version_2;
	// T System.Collections.Generic.List`1/Enumerator::current
	float ___current_3;

public:
	inline static int32_t get_offset_of_list_0() { return static_cast<int32_t>(offsetof(Enumerator_tC1FD01C8BB5327D442D71FD022B4338ACD701783, ___list_0)); }
	inline List_1_t6726F9309570A0BDC5D42E10777F3E2931C487AA * get_list_0() const { return ___list_0; }
	inline List_1_t6726F9309570A0BDC5D42E10777F3E2931C487AA ** get_address_of_list_0() { return &___list_0; }
	inline void set_list_0(List_1_t6726F9309570A0BDC5D42E10777F3E2931C487AA * value)
	{
		___list_0 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___list_0), (void*)value);
	}

	inline static int32_t get_offset_of_index_1() { return static_cast<int32_t>(offsetof(Enumerator_tC1FD01C8BB5327D442D71FD022B4338ACD701783, ___index_1)); }
	inline int32_t get_index_1() const { return ___index_1; }
	inline int32_t* get_address_of_index_1() { return &___index_1; }
	inline void set_index_1(int32_t value)
	{
		___index_1 = value;
	}

	inline static int32_t get_offset_of_version_2() { return static_cast<int32_t>(offsetof(Enumerator_tC1FD01C8BB5327D442D71FD022B4338ACD701783, ___version_2)); }
	inline int32_t get_version_2() const { return ___version_2; }
	inline int32_t* get_address_of_version_2() { return &___version_2; }
	inline void set_version_2(int32_t value)
	{
		___version_2 = value;
	}

	inline static int32_t get_offset_of_current_3() { return static_cast<int32_t>(offsetof(Enumerator_tC1FD01C8BB5327D442D71FD022B4338ACD701783, ___current_3)); }
	inline float get_current_3() const { return ___current_3; }
	inline float* get_address_of_current_3() { return &___current_3; }
	inline void set_current_3(float value)
	{
		___current_3 = value;
	}
};


// System.Linq.Parallel.ListQueryResults`1<System.Object>
struct ListQueryResults_1_t00D93FF58E931DC3CEE0650FBA675E7A368BE065  : public QueryResults_1_t1956EED88B24434B080C8523FEDCF6843748F3D2
{
public:
	// System.Collections.Generic.IList`1<T> System.Linq.Parallel.ListQueryResults`1::_source
	RuntimeObject* ____source_0;
	// System.Int32 System.Linq.Parallel.ListQueryResults`1::_partitionCount
	int32_t ____partitionCount_1;
	// System.Boolean System.Linq.Parallel.ListQueryResults`1::_useStriping
	bool ____useStriping_2;

public:
	inline static int32_t get_offset_of__source_0() { return static_cast<int32_t>(offsetof(ListQueryResults_1_t00D93FF58E931DC3CEE0650FBA675E7A368BE065, ____source_0)); }
	inline RuntimeObject* get__source_0() const { return ____source_0; }
	inline RuntimeObject** get_address_of__source_0() { return &____source_0; }
	inline void set__source_0(RuntimeObject* value)
	{
		____source_0 = value;
		Il2CppCodeGenWriteBarrier((void**)(&____source_0), (void*)value);
	}

	inline static int32_t get_offset_of__partitionCount_1() { return static_cast<int32_t>(offsetof(ListQueryResults_1_t00D93FF58E931DC3CEE0650FBA675E7A368BE065, ____partitionCount_1)); }
	inline int32_t get__partitionCount_1() const { return ____partitionCount_1; }
	inline int32_t* get_address_of__partitionCount_1() { return &____partitionCount_1; }
	inline void set__partitionCount_1(int32_t value)
	{
		____partitionCount_1 = value;
	}

	inline static int32_t get_offset_of__useStriping_2() { return static_cast<int32_t>(offsetof(ListQueryResults_1_t00D93FF58E931DC3CEE0650FBA675E7A368BE065, ____useStriping_2)); }
	inline bool get__useStriping_2() const { return ____useStriping_2; }
	inline bool* get_address_of__useStriping_2() { return &____useStriping_2; }
	inline void set__useStriping_2(bool value)
	{
		____useStriping_2 = value;
	}
};


// System.Nullable`1<System.Double>
struct Nullable_1_t75730434CAD4E48A4EE117588CFD586FFBCAC209 
{
public:
	// T System.Nullable`1::value
	double ___value_0;
	// System.Boolean System.Nullable`1::has_value
	bool ___has_value_1;

public:
	inline static int32_t get_offset_of_value_0() { return static_cast<int32_t>(offsetof(Nullable_1_t75730434CAD4E48A4EE117588CFD586FFBCAC209, ___value_0)); }
	inline double get_value_0() const { return ___value_0; }
	inline double* get_address_of_value_0() { return &___value_0; }
	inline void set_value_0(double value)
	{
		___value_0 = value;
	}

	inline static int32_t get_offset_of_has_value_1() { return static_cast<int32_t>(offsetof(Nullable_1_t75730434CAD4E48A4EE117588CFD586FFBCAC209, ___has_value_1)); }
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


// System.Nullable`1<System.Int64>
struct Nullable_1_t340361C8134256120F5769AC5A3F743DB6C11D1F 
{
public:
	// T System.Nullable`1::value
	int64_t ___value_0;
	// System.Boolean System.Nullable`1::has_value
	bool ___has_value_1;

public:
	inline static int32_t get_offset_of_value_0() { return static_cast<int32_t>(offsetof(Nullable_1_t340361C8134256120F5769AC5A3F743DB6C11D1F, ___value_0)); }
	inline int64_t get_value_0() const { return ___value_0; }
	inline int64_t* get_address_of_value_0() { return &___value_0; }
	inline void set_value_0(int64_t value)
	{
		___value_0 = value;
	}

	inline static int32_t get_offset_of_has_value_1() { return static_cast<int32_t>(offsetof(Nullable_1_t340361C8134256120F5769AC5A3F743DB6C11D1F, ___has_value_1)); }
	inline bool get_has_value_1() const { return ___has_value_1; }
	inline bool* get_address_of_has_value_1() { return &___has_value_1; }
	inline void set_has_value_1(bool value)
	{
		___has_value_1 = value;
	}
};


// System.Nullable`1<System.Single>
struct Nullable_1_t0C4AC2E457C437FA106160547FD9BA5B50B1888A 
{
public:
	// T System.Nullable`1::value
	float ___value_0;
	// System.Boolean System.Nullable`1::has_value
	bool ___has_value_1;

public:
	inline static int32_t get_offset_of_value_0() { return static_cast<int32_t>(offsetof(Nullable_1_t0C4AC2E457C437FA106160547FD9BA5B50B1888A, ___value_0)); }
	inline float get_value_0() const { return ___value_0; }
	inline float* get_address_of_value_0() { return &___value_0; }
	inline void set_value_0(float value)
	{
		___value_0 = value;
	}

	inline static int32_t get_offset_of_has_value_1() { return static_cast<int32_t>(offsetof(Nullable_1_t0C4AC2E457C437FA106160547FD9BA5B50B1888A, ___has_value_1)); }
	inline bool get_has_value_1() const { return ___has_value_1; }
	inline bool* get_address_of_has_value_1() { return &___has_value_1; }
	inline void set_has_value_1(bool value)
	{
		___has_value_1 = value;
	}
};


// System.ValueTuple`2<System.Object,System.Object>
struct ValueTuple_2_t69671C4973C1A3829B2193E4C598B1AE7162E403 
{
public:
	// T1 System.ValueTuple`2::Item1
	RuntimeObject * ___Item1_0;
	// T2 System.ValueTuple`2::Item2
	RuntimeObject * ___Item2_1;

public:
	inline static int32_t get_offset_of_Item1_0() { return static_cast<int32_t>(offsetof(ValueTuple_2_t69671C4973C1A3829B2193E4C598B1AE7162E403, ___Item1_0)); }
	inline RuntimeObject * get_Item1_0() const { return ___Item1_0; }
	inline RuntimeObject ** get_address_of_Item1_0() { return &___Item1_0; }
	inline void set_Item1_0(RuntimeObject * value)
	{
		___Item1_0 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___Item1_0), (void*)value);
	}

	inline static int32_t get_offset_of_Item2_1() { return static_cast<int32_t>(offsetof(ValueTuple_2_t69671C4973C1A3829B2193E4C598B1AE7162E403, ___Item2_1)); }
	inline RuntimeObject * get_Item2_1() const { return ___Item2_1; }
	inline RuntimeObject ** get_address_of_Item2_1() { return &___Item2_1; }
	inline void set_Item2_1(RuntimeObject * value)
	{
		___Item2_1 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___Item2_1), (void*)value);
	}
};


// System.Linq.Enumerable/WhereEnumerableIterator`1<System.Boolean>
struct WhereEnumerableIterator_1_t3A84EA4A91D206312F2931E2BC9124FFF81BFE22  : public Iterator_1_tF558BC64630CA9038F999F5A16CC3DD5A0DB6933
{
public:
	// System.Collections.Generic.IEnumerable`1<TSource> System.Linq.Enumerable/WhereEnumerableIterator`1::source
	RuntimeObject* ___source_3;
	// System.Func`2<TSource,System.Boolean> System.Linq.Enumerable/WhereEnumerableIterator`1::predicate
	Func_2_t50F598941CFDF02619DC5D52FFDBC329473C5F7B * ___predicate_4;
	// System.Collections.Generic.IEnumerator`1<TSource> System.Linq.Enumerable/WhereEnumerableIterator`1::enumerator
	RuntimeObject* ___enumerator_5;

public:
	inline static int32_t get_offset_of_source_3() { return static_cast<int32_t>(offsetof(WhereEnumerableIterator_1_t3A84EA4A91D206312F2931E2BC9124FFF81BFE22, ___source_3)); }
	inline RuntimeObject* get_source_3() const { return ___source_3; }
	inline RuntimeObject** get_address_of_source_3() { return &___source_3; }
	inline void set_source_3(RuntimeObject* value)
	{
		___source_3 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___source_3), (void*)value);
	}

	inline static int32_t get_offset_of_predicate_4() { return static_cast<int32_t>(offsetof(WhereEnumerableIterator_1_t3A84EA4A91D206312F2931E2BC9124FFF81BFE22, ___predicate_4)); }
	inline Func_2_t50F598941CFDF02619DC5D52FFDBC329473C5F7B * get_predicate_4() const { return ___predicate_4; }
	inline Func_2_t50F598941CFDF02619DC5D52FFDBC329473C5F7B ** get_address_of_predicate_4() { return &___predicate_4; }
	inline void set_predicate_4(Func_2_t50F598941CFDF02619DC5D52FFDBC329473C5F7B * value)
	{
		___predicate_4 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___predicate_4), (void*)value);
	}

	inline static int32_t get_offset_of_enumerator_5() { return static_cast<int32_t>(offsetof(WhereEnumerableIterator_1_t3A84EA4A91D206312F2931E2BC9124FFF81BFE22, ___enumerator_5)); }
	inline RuntimeObject* get_enumerator_5() const { return ___enumerator_5; }
	inline RuntimeObject** get_address_of_enumerator_5() { return &___enumerator_5; }
	inline void set_enumerator_5(RuntimeObject* value)
	{
		___enumerator_5 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___enumerator_5), (void*)value);
	}
};


// System.Linq.Enumerable/WhereEnumerableIterator`1<System.Double>
struct WhereEnumerableIterator_1_tB738E509FB63FFBEF5774573271E95894BA5679F  : public Iterator_1_t167C775670D48A9186D95126BDB6A078470CAE8D
{
public:
	// System.Collections.Generic.IEnumerable`1<TSource> System.Linq.Enumerable/WhereEnumerableIterator`1::source
	RuntimeObject* ___source_3;
	// System.Func`2<TSource,System.Boolean> System.Linq.Enumerable/WhereEnumerableIterator`1::predicate
	Func_2_t4E607BF9FA9E115F43BD77F92F4285E3B8C7FB0D * ___predicate_4;
	// System.Collections.Generic.IEnumerator`1<TSource> System.Linq.Enumerable/WhereEnumerableIterator`1::enumerator
	RuntimeObject* ___enumerator_5;

public:
	inline static int32_t get_offset_of_source_3() { return static_cast<int32_t>(offsetof(WhereEnumerableIterator_1_tB738E509FB63FFBEF5774573271E95894BA5679F, ___source_3)); }
	inline RuntimeObject* get_source_3() const { return ___source_3; }
	inline RuntimeObject** get_address_of_source_3() { return &___source_3; }
	inline void set_source_3(RuntimeObject* value)
	{
		___source_3 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___source_3), (void*)value);
	}

	inline static int32_t get_offset_of_predicate_4() { return static_cast<int32_t>(offsetof(WhereEnumerableIterator_1_tB738E509FB63FFBEF5774573271E95894BA5679F, ___predicate_4)); }
	inline Func_2_t4E607BF9FA9E115F43BD77F92F4285E3B8C7FB0D * get_predicate_4() const { return ___predicate_4; }
	inline Func_2_t4E607BF9FA9E115F43BD77F92F4285E3B8C7FB0D ** get_address_of_predicate_4() { return &___predicate_4; }
	inline void set_predicate_4(Func_2_t4E607BF9FA9E115F43BD77F92F4285E3B8C7FB0D * value)
	{
		___predicate_4 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___predicate_4), (void*)value);
	}

	inline static int32_t get_offset_of_enumerator_5() { return static_cast<int32_t>(offsetof(WhereEnumerableIterator_1_tB738E509FB63FFBEF5774573271E95894BA5679F, ___enumerator_5)); }
	inline RuntimeObject* get_enumerator_5() const { return ___enumerator_5; }
	inline RuntimeObject** get_address_of_enumerator_5() { return &___enumerator_5; }
	inline void set_enumerator_5(RuntimeObject* value)
	{
		___enumerator_5 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___enumerator_5), (void*)value);
	}
};


// System.Linq.Enumerable/WhereEnumerableIterator`1<System.Int32>
struct WhereEnumerableIterator_1_t9F4DDC70173BABD72AEC7AA00D62F4FAE2613CEA  : public Iterator_1_tCFFC952B03DBE4E956DE317DB9704D936AEA2379
{
public:
	// System.Collections.Generic.IEnumerable`1<TSource> System.Linq.Enumerable/WhereEnumerableIterator`1::source
	RuntimeObject* ___source_3;
	// System.Func`2<TSource,System.Boolean> System.Linq.Enumerable/WhereEnumerableIterator`1::predicate
	Func_2_t2EBF98B0BA555D9F0633C9BCCBE3DF332B9C1274 * ___predicate_4;
	// System.Collections.Generic.IEnumerator`1<TSource> System.Linq.Enumerable/WhereEnumerableIterator`1::enumerator
	RuntimeObject* ___enumerator_5;

public:
	inline static int32_t get_offset_of_source_3() { return static_cast<int32_t>(offsetof(WhereEnumerableIterator_1_t9F4DDC70173BABD72AEC7AA00D62F4FAE2613CEA, ___source_3)); }
	inline RuntimeObject* get_source_3() const { return ___source_3; }
	inline RuntimeObject** get_address_of_source_3() { return &___source_3; }
	inline void set_source_3(RuntimeObject* value)
	{
		___source_3 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___source_3), (void*)value);
	}

	inline static int32_t get_offset_of_predicate_4() { return static_cast<int32_t>(offsetof(WhereEnumerableIterator_1_t9F4DDC70173BABD72AEC7AA00D62F4FAE2613CEA, ___predicate_4)); }
	inline Func_2_t2EBF98B0BA555D9F0633C9BCCBE3DF332B9C1274 * get_predicate_4() const { return ___predicate_4; }
	inline Func_2_t2EBF98B0BA555D9F0633C9BCCBE3DF332B9C1274 ** get_address_of_predicate_4() { return &___predicate_4; }
	inline void set_predicate_4(Func_2_t2EBF98B0BA555D9F0633C9BCCBE3DF332B9C1274 * value)
	{
		___predicate_4 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___predicate_4), (void*)value);
	}

	inline static int32_t get_offset_of_enumerator_5() { return static_cast<int32_t>(offsetof(WhereEnumerableIterator_1_t9F4DDC70173BABD72AEC7AA00D62F4FAE2613CEA, ___enumerator_5)); }
	inline RuntimeObject* get_enumerator_5() const { return ___enumerator_5; }
	inline RuntimeObject** get_address_of_enumerator_5() { return &___enumerator_5; }
	inline void set_enumerator_5(RuntimeObject* value)
	{
		___enumerator_5 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___enumerator_5), (void*)value);
	}
};


// System.Linq.Enumerable/WhereEnumerableIterator`1<System.Int64>
struct WhereEnumerableIterator_1_tBAC8281C998E41429788C96260CB05A7E0471BC1  : public Iterator_1_tF88FA02D56A55D26D525180DE0108FA4F019BECE
{
public:
	// System.Collections.Generic.IEnumerable`1<TSource> System.Linq.Enumerable/WhereEnumerableIterator`1::source
	RuntimeObject* ___source_3;
	// System.Func`2<TSource,System.Boolean> System.Linq.Enumerable/WhereEnumerableIterator`1::predicate
	Func_2_t03B9AF86FB7E93B62590F1CBD16276EF7AA1B215 * ___predicate_4;
	// System.Collections.Generic.IEnumerator`1<TSource> System.Linq.Enumerable/WhereEnumerableIterator`1::enumerator
	RuntimeObject* ___enumerator_5;

public:
	inline static int32_t get_offset_of_source_3() { return static_cast<int32_t>(offsetof(WhereEnumerableIterator_1_tBAC8281C998E41429788C96260CB05A7E0471BC1, ___source_3)); }
	inline RuntimeObject* get_source_3() const { return ___source_3; }
	inline RuntimeObject** get_address_of_source_3() { return &___source_3; }
	inline void set_source_3(RuntimeObject* value)
	{
		___source_3 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___source_3), (void*)value);
	}

	inline static int32_t get_offset_of_predicate_4() { return static_cast<int32_t>(offsetof(WhereEnumerableIterator_1_tBAC8281C998E41429788C96260CB05A7E0471BC1, ___predicate_4)); }
	inline Func_2_t03B9AF86FB7E93B62590F1CBD16276EF7AA1B215 * get_predicate_4() const { return ___predicate_4; }
	inline Func_2_t03B9AF86FB7E93B62590F1CBD16276EF7AA1B215 ** get_address_of_predicate_4() { return &___predicate_4; }
	inline void set_predicate_4(Func_2_t03B9AF86FB7E93B62590F1CBD16276EF7AA1B215 * value)
	{
		___predicate_4 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___predicate_4), (void*)value);
	}

	inline static int32_t get_offset_of_enumerator_5() { return static_cast<int32_t>(offsetof(WhereEnumerableIterator_1_tBAC8281C998E41429788C96260CB05A7E0471BC1, ___enumerator_5)); }
	inline RuntimeObject* get_enumerator_5() const { return ___enumerator_5; }
	inline RuntimeObject** get_address_of_enumerator_5() { return &___enumerator_5; }
	inline void set_enumerator_5(RuntimeObject* value)
	{
		___enumerator_5 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___enumerator_5), (void*)value);
	}
};


// System.Linq.Enumerable/WhereEnumerableIterator`1<System.Object>
struct WhereEnumerableIterator_1_t1E9FDCFD8F8136C6A5A5740C1E093EF03F0B5CE0  : public Iterator_1_t674ABE41CF4096D4BE4D51E21FEBDADBF74CC279
{
public:
	// System.Collections.Generic.IEnumerable`1<TSource> System.Linq.Enumerable/WhereEnumerableIterator`1::source
	RuntimeObject* ___source_3;
	// System.Func`2<TSource,System.Boolean> System.Linq.Enumerable/WhereEnumerableIterator`1::predicate
	Func_2_t99409DECFF50F0FA9B427C863AC6C99C66E6F9F8 * ___predicate_4;
	// System.Collections.Generic.IEnumerator`1<TSource> System.Linq.Enumerable/WhereEnumerableIterator`1::enumerator
	RuntimeObject* ___enumerator_5;

public:
	inline static int32_t get_offset_of_source_3() { return static_cast<int32_t>(offsetof(WhereEnumerableIterator_1_t1E9FDCFD8F8136C6A5A5740C1E093EF03F0B5CE0, ___source_3)); }
	inline RuntimeObject* get_source_3() const { return ___source_3; }
	inline RuntimeObject** get_address_of_source_3() { return &___source_3; }
	inline void set_source_3(RuntimeObject* value)
	{
		___source_3 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___source_3), (void*)value);
	}

	inline static int32_t get_offset_of_predicate_4() { return static_cast<int32_t>(offsetof(WhereEnumerableIterator_1_t1E9FDCFD8F8136C6A5A5740C1E093EF03F0B5CE0, ___predicate_4)); }
	inline Func_2_t99409DECFF50F0FA9B427C863AC6C99C66E6F9F8 * get_predicate_4() const { return ___predicate_4; }
	inline Func_2_t99409DECFF50F0FA9B427C863AC6C99C66E6F9F8 ** get_address_of_predicate_4() { return &___predicate_4; }
	inline void set_predicate_4(Func_2_t99409DECFF50F0FA9B427C863AC6C99C66E6F9F8 * value)
	{
		___predicate_4 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___predicate_4), (void*)value);
	}

	inline static int32_t get_offset_of_enumerator_5() { return static_cast<int32_t>(offsetof(WhereEnumerableIterator_1_t1E9FDCFD8F8136C6A5A5740C1E093EF03F0B5CE0, ___enumerator_5)); }
	inline RuntimeObject* get_enumerator_5() const { return ___enumerator_5; }
	inline RuntimeObject** get_address_of_enumerator_5() { return &___enumerator_5; }
	inline void set_enumerator_5(RuntimeObject* value)
	{
		___enumerator_5 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___enumerator_5), (void*)value);
	}
};


// System.Linq.Enumerable/WhereEnumerableIterator`1<System.Single>
struct WhereEnumerableIterator_1_tC5339F8E75587CBA511FF3EDFBA6D5A81E54057F  : public Iterator_1_t859CAAB8DD3B63D3758E13D2802ED7523B331199
{
public:
	// System.Collections.Generic.IEnumerable`1<TSource> System.Linq.Enumerable/WhereEnumerableIterator`1::source
	RuntimeObject* ___source_3;
	// System.Func`2<TSource,System.Boolean> System.Linq.Enumerable/WhereEnumerableIterator`1::predicate
	Func_2_t7214BC9C9A47482C751067B9A197D164F4041A3A * ___predicate_4;
	// System.Collections.Generic.IEnumerator`1<TSource> System.Linq.Enumerable/WhereEnumerableIterator`1::enumerator
	RuntimeObject* ___enumerator_5;

public:
	inline static int32_t get_offset_of_source_3() { return static_cast<int32_t>(offsetof(WhereEnumerableIterator_1_tC5339F8E75587CBA511FF3EDFBA6D5A81E54057F, ___source_3)); }
	inline RuntimeObject* get_source_3() const { return ___source_3; }
	inline RuntimeObject** get_address_of_source_3() { return &___source_3; }
	inline void set_source_3(RuntimeObject* value)
	{
		___source_3 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___source_3), (void*)value);
	}

	inline static int32_t get_offset_of_predicate_4() { return static_cast<int32_t>(offsetof(WhereEnumerableIterator_1_tC5339F8E75587CBA511FF3EDFBA6D5A81E54057F, ___predicate_4)); }
	inline Func_2_t7214BC9C9A47482C751067B9A197D164F4041A3A * get_predicate_4() const { return ___predicate_4; }
	inline Func_2_t7214BC9C9A47482C751067B9A197D164F4041A3A ** get_address_of_predicate_4() { return &___predicate_4; }
	inline void set_predicate_4(Func_2_t7214BC9C9A47482C751067B9A197D164F4041A3A * value)
	{
		___predicate_4 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___predicate_4), (void*)value);
	}

	inline static int32_t get_offset_of_enumerator_5() { return static_cast<int32_t>(offsetof(WhereEnumerableIterator_1_tC5339F8E75587CBA511FF3EDFBA6D5A81E54057F, ___enumerator_5)); }
	inline RuntimeObject* get_enumerator_5() const { return ___enumerator_5; }
	inline RuntimeObject** get_address_of_enumerator_5() { return &___enumerator_5; }
	inline void set_enumerator_5(RuntimeObject* value)
	{
		___enumerator_5 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___enumerator_5), (void*)value);
	}
};


// System.Linq.Parallel.WrapperEqualityComparer`1<System.Object>
struct WrapperEqualityComparer_1_t4AD211C5560CD8CDAD6255CC8B0CCCC3E20A3D42 
{
public:
	// System.Collections.Generic.IEqualityComparer`1<T> System.Linq.Parallel.WrapperEqualityComparer`1::_comparer
	RuntimeObject* ____comparer_0;

public:
	inline static int32_t get_offset_of__comparer_0() { return static_cast<int32_t>(offsetof(WrapperEqualityComparer_1_t4AD211C5560CD8CDAD6255CC8B0CCCC3E20A3D42, ____comparer_0)); }
	inline RuntimeObject* get__comparer_0() const { return ____comparer_0; }
	inline RuntimeObject** get_address_of__comparer_0() { return &____comparer_0; }
	inline void set__comparer_0(RuntimeObject* value)
	{
		____comparer_0 = value;
		Il2CppCodeGenWriteBarrier((void**)(&____comparer_0), (void*)value);
	}
};


// System.Linq.Parallel.Wrapper`1<System.Object>
struct Wrapper_1_tDDD2ABAF8D432140BA7A444ED61075E20B73095F 
{
public:
	// T System.Linq.Parallel.Wrapper`1::Value
	RuntimeObject * ___Value_0;

public:
	inline static int32_t get_offset_of_Value_0() { return static_cast<int32_t>(offsetof(Wrapper_1_tDDD2ABAF8D432140BA7A444ED61075E20B73095F, ___Value_0)); }
	inline RuntimeObject * get_Value_0() const { return ___Value_0; }
	inline RuntimeObject ** get_address_of_Value_0() { return &___Value_0; }
	inline void set_Value_0(RuntimeObject * value)
	{
		___Value_0 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___Value_0), (void*)value);
	}
};


// System.Linq.Parallel.ZipQueryOperator`3/ZipQueryOperatorResults<System.Object,System.Object,System.Object>
struct ZipQueryOperatorResults_tB9DD58D5EFCC60A84DADC3938A2FFA8BAA7A6367  : public QueryResults_1_t1956EED88B24434B080C8523FEDCF6843748F3D2
{
public:
	// System.Linq.Parallel.QueryResults`1<TLeftInput> System.Linq.Parallel.ZipQueryOperator`3/ZipQueryOperatorResults::_leftChildResults
	QueryResults_1_t1956EED88B24434B080C8523FEDCF6843748F3D2 * ____leftChildResults_0;
	// System.Linq.Parallel.QueryResults`1<TRightInput> System.Linq.Parallel.ZipQueryOperator`3/ZipQueryOperatorResults::_rightChildResults
	QueryResults_1_t1956EED88B24434B080C8523FEDCF6843748F3D2 * ____rightChildResults_1;
	// System.Func`3<TLeftInput,TRightInput,TOutput> System.Linq.Parallel.ZipQueryOperator`3/ZipQueryOperatorResults::_resultSelector
	Func_3_tBBBFF266D23D5A9A7940D16DA73BCD5DE0753A27 * ____resultSelector_2;
	// System.Int32 System.Linq.Parallel.ZipQueryOperator`3/ZipQueryOperatorResults::_count
	int32_t ____count_3;
	// System.Int32 System.Linq.Parallel.ZipQueryOperator`3/ZipQueryOperatorResults::_partitionCount
	int32_t ____partitionCount_4;
	// System.Boolean System.Linq.Parallel.ZipQueryOperator`3/ZipQueryOperatorResults::_preferStriping
	bool ____preferStriping_5;

public:
	inline static int32_t get_offset_of__leftChildResults_0() { return static_cast<int32_t>(offsetof(ZipQueryOperatorResults_tB9DD58D5EFCC60A84DADC3938A2FFA8BAA7A6367, ____leftChildResults_0)); }
	inline QueryResults_1_t1956EED88B24434B080C8523FEDCF6843748F3D2 * get__leftChildResults_0() const { return ____leftChildResults_0; }
	inline QueryResults_1_t1956EED88B24434B080C8523FEDCF6843748F3D2 ** get_address_of__leftChildResults_0() { return &____leftChildResults_0; }
	inline void set__leftChildResults_0(QueryResults_1_t1956EED88B24434B080C8523FEDCF6843748F3D2 * value)
	{
		____leftChildResults_0 = value;
		Il2CppCodeGenWriteBarrier((void**)(&____leftChildResults_0), (void*)value);
	}

	inline static int32_t get_offset_of__rightChildResults_1() { return static_cast<int32_t>(offsetof(ZipQueryOperatorResults_tB9DD58D5EFCC60A84DADC3938A2FFA8BAA7A6367, ____rightChildResults_1)); }
	inline QueryResults_1_t1956EED88B24434B080C8523FEDCF6843748F3D2 * get__rightChildResults_1() const { return ____rightChildResults_1; }
	inline QueryResults_1_t1956EED88B24434B080C8523FEDCF6843748F3D2 ** get_address_of__rightChildResults_1() { return &____rightChildResults_1; }
	inline void set__rightChildResults_1(QueryResults_1_t1956EED88B24434B080C8523FEDCF6843748F3D2 * value)
	{
		____rightChildResults_1 = value;
		Il2CppCodeGenWriteBarrier((void**)(&____rightChildResults_1), (void*)value);
	}

	inline static int32_t get_offset_of__resultSelector_2() { return static_cast<int32_t>(offsetof(ZipQueryOperatorResults_tB9DD58D5EFCC60A84DADC3938A2FFA8BAA7A6367, ____resultSelector_2)); }
	inline Func_3_tBBBFF266D23D5A9A7940D16DA73BCD5DE0753A27 * get__resultSelector_2() const { return ____resultSelector_2; }
	inline Func_3_tBBBFF266D23D5A9A7940D16DA73BCD5DE0753A27 ** get_address_of__resultSelector_2() { return &____resultSelector_2; }
	inline void set__resultSelector_2(Func_3_tBBBFF266D23D5A9A7940D16DA73BCD5DE0753A27 * value)
	{
		____resultSelector_2 = value;
		Il2CppCodeGenWriteBarrier((void**)(&____resultSelector_2), (void*)value);
	}

	inline static int32_t get_offset_of__count_3() { return static_cast<int32_t>(offsetof(ZipQueryOperatorResults_tB9DD58D5EFCC60A84DADC3938A2FFA8BAA7A6367, ____count_3)); }
	inline int32_t get__count_3() const { return ____count_3; }
	inline int32_t* get_address_of__count_3() { return &____count_3; }
	inline void set__count_3(int32_t value)
	{
		____count_3 = value;
	}

	inline static int32_t get_offset_of__partitionCount_4() { return static_cast<int32_t>(offsetof(ZipQueryOperatorResults_tB9DD58D5EFCC60A84DADC3938A2FFA8BAA7A6367, ____partitionCount_4)); }
	inline int32_t get__partitionCount_4() const { return ____partitionCount_4; }
	inline int32_t* get_address_of__partitionCount_4() { return &____partitionCount_4; }
	inline void set__partitionCount_4(int32_t value)
	{
		____partitionCount_4 = value;
	}

	inline static int32_t get_offset_of__preferStriping_5() { return static_cast<int32_t>(offsetof(ZipQueryOperatorResults_tB9DD58D5EFCC60A84DADC3938A2FFA8BAA7A6367, ____preferStriping_5)); }
	inline bool get__preferStriping_5() const { return ____preferStriping_5; }
	inline bool* get_address_of__preferStriping_5() { return &____preferStriping_5; }
	inline void set__preferStriping_5(bool value)
	{
		____preferStriping_5 = value;
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


// UnityEngine.Experimental.Rendering.Universal.LibTessDotNet.Vec3
struct Vec3_tDD913B31171F6A37E61E4625FEA6C7901A6B1BC1 
{
public:
	// System.Single UnityEngine.Experimental.Rendering.Universal.LibTessDotNet.Vec3::X
	float ___X_1;
	// System.Single UnityEngine.Experimental.Rendering.Universal.LibTessDotNet.Vec3::Y
	float ___Y_2;
	// System.Single UnityEngine.Experimental.Rendering.Universal.LibTessDotNet.Vec3::Z
	float ___Z_3;

public:
	inline static int32_t get_offset_of_X_1() { return static_cast<int32_t>(offsetof(Vec3_tDD913B31171F6A37E61E4625FEA6C7901A6B1BC1, ___X_1)); }
	inline float get_X_1() const { return ___X_1; }
	inline float* get_address_of_X_1() { return &___X_1; }
	inline void set_X_1(float value)
	{
		___X_1 = value;
	}

	inline static int32_t get_offset_of_Y_2() { return static_cast<int32_t>(offsetof(Vec3_tDD913B31171F6A37E61E4625FEA6C7901A6B1BC1, ___Y_2)); }
	inline float get_Y_2() const { return ___Y_2; }
	inline float* get_address_of_Y_2() { return &___Y_2; }
	inline void set_Y_2(float value)
	{
		___Y_2 = value;
	}

	inline static int32_t get_offset_of_Z_3() { return static_cast<int32_t>(offsetof(Vec3_tDD913B31171F6A37E61E4625FEA6C7901A6B1BC1, ___Z_3)); }
	inline float get_Z_3() const { return ___Z_3; }
	inline float* get_address_of_Z_3() { return &___Z_3; }
	inline void set_Z_3(float value)
	{
		___Z_3 = value;
	}
};

struct Vec3_tDD913B31171F6A37E61E4625FEA6C7901A6B1BC1_StaticFields
{
public:
	// UnityEngine.Experimental.Rendering.Universal.LibTessDotNet.Vec3 UnityEngine.Experimental.Rendering.Universal.LibTessDotNet.Vec3::Zero
	Vec3_tDD913B31171F6A37E61E4625FEA6C7901A6B1BC1  ___Zero_0;

public:
	inline static int32_t get_offset_of_Zero_0() { return static_cast<int32_t>(offsetof(Vec3_tDD913B31171F6A37E61E4625FEA6C7901A6B1BC1_StaticFields, ___Zero_0)); }
	inline Vec3_tDD913B31171F6A37E61E4625FEA6C7901A6B1BC1  get_Zero_0() const { return ___Zero_0; }
	inline Vec3_tDD913B31171F6A37E61E4625FEA6C7901A6B1BC1 * get_address_of_Zero_0() { return &___Zero_0; }
	inline void set_Zero_0(Vec3_tDD913B31171F6A37E61E4625FEA6C7901A6B1BC1  value)
	{
		___Zero_0 = value;
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


// Unity.Mathematics.float3
struct float3_tE0DD2FF13F818025945C9AC314390D2A1F55E37D 
{
public:
	// System.Single Unity.Mathematics.float3::x
	float ___x_0;
	// System.Single Unity.Mathematics.float3::y
	float ___y_1;
	// System.Single Unity.Mathematics.float3::z
	float ___z_2;

public:
	inline static int32_t get_offset_of_x_0() { return static_cast<int32_t>(offsetof(float3_tE0DD2FF13F818025945C9AC314390D2A1F55E37D, ___x_0)); }
	inline float get_x_0() const { return ___x_0; }
	inline float* get_address_of_x_0() { return &___x_0; }
	inline void set_x_0(float value)
	{
		___x_0 = value;
	}

	inline static int32_t get_offset_of_y_1() { return static_cast<int32_t>(offsetof(float3_tE0DD2FF13F818025945C9AC314390D2A1F55E37D, ___y_1)); }
	inline float get_y_1() const { return ___y_1; }
	inline float* get_address_of_y_1() { return &___y_1; }
	inline void set_y_1(float value)
	{
		___y_1 = value;
	}

	inline static int32_t get_offset_of_z_2() { return static_cast<int32_t>(offsetof(float3_tE0DD2FF13F818025945C9AC314390D2A1F55E37D, ___z_2)); }
	inline float get_z_2() const { return ___z_2; }
	inline float* get_address_of_z_2() { return &___z_2; }
	inline void set_z_2(float value)
	{
		___z_2 = value;
	}
};

struct float3_tE0DD2FF13F818025945C9AC314390D2A1F55E37D_StaticFields
{
public:
	// Unity.Mathematics.float3 Unity.Mathematics.float3::zero
	float3_tE0DD2FF13F818025945C9AC314390D2A1F55E37D  ___zero_3;

public:
	inline static int32_t get_offset_of_zero_3() { return static_cast<int32_t>(offsetof(float3_tE0DD2FF13F818025945C9AC314390D2A1F55E37D_StaticFields, ___zero_3)); }
	inline float3_tE0DD2FF13F818025945C9AC314390D2A1F55E37D  get_zero_3() const { return ___zero_3; }
	inline float3_tE0DD2FF13F818025945C9AC314390D2A1F55E37D * get_address_of_zero_3() { return &___zero_3; }
	inline void set_zero_3(float3_tE0DD2FF13F818025945C9AC314390D2A1F55E37D  value)
	{
		___zero_3 = value;
	}
};


// System.Linq.Parallel.ZipQueryOperator`3/<AsSequentialQuery>d__9<System.Object,System.Object,System.Object>
struct U3CAsSequentialQueryU3Ed__9_t72DBDAADFC463654715CB97A6C9639B8BE40A398  : public RuntimeObject
{
public:
	// System.Int32 System.Linq.Parallel.ZipQueryOperator`3/<AsSequentialQuery>d__9::<>1__state
	int32_t ___U3CU3E1__state_0;
	// TOutput System.Linq.Parallel.ZipQueryOperator`3/<AsSequentialQuery>d__9::<>2__current
	RuntimeObject * ___U3CU3E2__current_1;
	// System.Int32 System.Linq.Parallel.ZipQueryOperator`3/<AsSequentialQuery>d__9::<>l__initialThreadId
	int32_t ___U3CU3El__initialThreadId_2;
	// System.Linq.Parallel.ZipQueryOperator`3<TLeftInput,TRightInput,TOutput> System.Linq.Parallel.ZipQueryOperator`3/<AsSequentialQuery>d__9::<>4__this
	ZipQueryOperator_3_t2D0121637CE51185E2CBB640EEAF8876A893637E * ___U3CU3E4__this_3;
	// System.Threading.CancellationToken System.Linq.Parallel.ZipQueryOperator`3/<AsSequentialQuery>d__9::token
	CancellationToken_tC9D68381C9164A4BA10397257E87ADC832AF5FFD  ___token_4;
	// System.Threading.CancellationToken System.Linq.Parallel.ZipQueryOperator`3/<AsSequentialQuery>d__9::<>3__token
	CancellationToken_tC9D68381C9164A4BA10397257E87ADC832AF5FFD  ___U3CU3E3__token_5;
	// System.Collections.Generic.IEnumerator`1<TLeftInput> System.Linq.Parallel.ZipQueryOperator`3/<AsSequentialQuery>d__9::<leftEnumerator>5__1
	RuntimeObject* ___U3CleftEnumeratorU3E5__1_6;
	// System.Collections.Generic.IEnumerator`1<TRightInput> System.Linq.Parallel.ZipQueryOperator`3/<AsSequentialQuery>d__9::<rightEnumerator>5__2
	RuntimeObject* ___U3CrightEnumeratorU3E5__2_7;

public:
	inline static int32_t get_offset_of_U3CU3E1__state_0() { return static_cast<int32_t>(offsetof(U3CAsSequentialQueryU3Ed__9_t72DBDAADFC463654715CB97A6C9639B8BE40A398, ___U3CU3E1__state_0)); }
	inline int32_t get_U3CU3E1__state_0() const { return ___U3CU3E1__state_0; }
	inline int32_t* get_address_of_U3CU3E1__state_0() { return &___U3CU3E1__state_0; }
	inline void set_U3CU3E1__state_0(int32_t value)
	{
		___U3CU3E1__state_0 = value;
	}

	inline static int32_t get_offset_of_U3CU3E2__current_1() { return static_cast<int32_t>(offsetof(U3CAsSequentialQueryU3Ed__9_t72DBDAADFC463654715CB97A6C9639B8BE40A398, ___U3CU3E2__current_1)); }
	inline RuntimeObject * get_U3CU3E2__current_1() const { return ___U3CU3E2__current_1; }
	inline RuntimeObject ** get_address_of_U3CU3E2__current_1() { return &___U3CU3E2__current_1; }
	inline void set_U3CU3E2__current_1(RuntimeObject * value)
	{
		___U3CU3E2__current_1 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___U3CU3E2__current_1), (void*)value);
	}

	inline static int32_t get_offset_of_U3CU3El__initialThreadId_2() { return static_cast<int32_t>(offsetof(U3CAsSequentialQueryU3Ed__9_t72DBDAADFC463654715CB97A6C9639B8BE40A398, ___U3CU3El__initialThreadId_2)); }
	inline int32_t get_U3CU3El__initialThreadId_2() const { return ___U3CU3El__initialThreadId_2; }
	inline int32_t* get_address_of_U3CU3El__initialThreadId_2() { return &___U3CU3El__initialThreadId_2; }
	inline void set_U3CU3El__initialThreadId_2(int32_t value)
	{
		___U3CU3El__initialThreadId_2 = value;
	}

	inline static int32_t get_offset_of_U3CU3E4__this_3() { return static_cast<int32_t>(offsetof(U3CAsSequentialQueryU3Ed__9_t72DBDAADFC463654715CB97A6C9639B8BE40A398, ___U3CU3E4__this_3)); }
	inline ZipQueryOperator_3_t2D0121637CE51185E2CBB640EEAF8876A893637E * get_U3CU3E4__this_3() const { return ___U3CU3E4__this_3; }
	inline ZipQueryOperator_3_t2D0121637CE51185E2CBB640EEAF8876A893637E ** get_address_of_U3CU3E4__this_3() { return &___U3CU3E4__this_3; }
	inline void set_U3CU3E4__this_3(ZipQueryOperator_3_t2D0121637CE51185E2CBB640EEAF8876A893637E * value)
	{
		___U3CU3E4__this_3 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___U3CU3E4__this_3), (void*)value);
	}

	inline static int32_t get_offset_of_token_4() { return static_cast<int32_t>(offsetof(U3CAsSequentialQueryU3Ed__9_t72DBDAADFC463654715CB97A6C9639B8BE40A398, ___token_4)); }
	inline CancellationToken_tC9D68381C9164A4BA10397257E87ADC832AF5FFD  get_token_4() const { return ___token_4; }
	inline CancellationToken_tC9D68381C9164A4BA10397257E87ADC832AF5FFD * get_address_of_token_4() { return &___token_4; }
	inline void set_token_4(CancellationToken_tC9D68381C9164A4BA10397257E87ADC832AF5FFD  value)
	{
		___token_4 = value;
		Il2CppCodeGenWriteBarrier((void**)&(((&___token_4))->___m_source_0), (void*)NULL);
	}

	inline static int32_t get_offset_of_U3CU3E3__token_5() { return static_cast<int32_t>(offsetof(U3CAsSequentialQueryU3Ed__9_t72DBDAADFC463654715CB97A6C9639B8BE40A398, ___U3CU3E3__token_5)); }
	inline CancellationToken_tC9D68381C9164A4BA10397257E87ADC832AF5FFD  get_U3CU3E3__token_5() const { return ___U3CU3E3__token_5; }
	inline CancellationToken_tC9D68381C9164A4BA10397257E87ADC832AF5FFD * get_address_of_U3CU3E3__token_5() { return &___U3CU3E3__token_5; }
	inline void set_U3CU3E3__token_5(CancellationToken_tC9D68381C9164A4BA10397257E87ADC832AF5FFD  value)
	{
		___U3CU3E3__token_5 = value;
		Il2CppCodeGenWriteBarrier((void**)&(((&___U3CU3E3__token_5))->___m_source_0), (void*)NULL);
	}

	inline static int32_t get_offset_of_U3CleftEnumeratorU3E5__1_6() { return static_cast<int32_t>(offsetof(U3CAsSequentialQueryU3Ed__9_t72DBDAADFC463654715CB97A6C9639B8BE40A398, ___U3CleftEnumeratorU3E5__1_6)); }
	inline RuntimeObject* get_U3CleftEnumeratorU3E5__1_6() const { return ___U3CleftEnumeratorU3E5__1_6; }
	inline RuntimeObject** get_address_of_U3CleftEnumeratorU3E5__1_6() { return &___U3CleftEnumeratorU3E5__1_6; }
	inline void set_U3CleftEnumeratorU3E5__1_6(RuntimeObject* value)
	{
		___U3CleftEnumeratorU3E5__1_6 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___U3CleftEnumeratorU3E5__1_6), (void*)value);
	}

	inline static int32_t get_offset_of_U3CrightEnumeratorU3E5__2_7() { return static_cast<int32_t>(offsetof(U3CAsSequentialQueryU3Ed__9_t72DBDAADFC463654715CB97A6C9639B8BE40A398, ___U3CrightEnumeratorU3E5__2_7)); }
	inline RuntimeObject* get_U3CrightEnumeratorU3E5__2_7() const { return ___U3CrightEnumeratorU3E5__2_7; }
	inline RuntimeObject** get_address_of_U3CrightEnumeratorU3E5__2_7() { return &___U3CrightEnumeratorU3E5__2_7; }
	inline void set_U3CrightEnumeratorU3E5__2_7(RuntimeObject* value)
	{
		___U3CrightEnumeratorU3E5__2_7 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___U3CrightEnumeratorU3E5__2_7), (void*)value);
	}
};


// System.Collections.Generic.List`1/Enumerator<System.ValueTuple`2<System.Object,System.Object>>
struct Enumerator_tCF455A92CC670AF169DFC7D0E19B47CAB2BD1DA0 
{
public:
	// System.Collections.Generic.List`1<T> System.Collections.Generic.List`1/Enumerator::list
	List_1_tF837281ACA0AE5696644C85291C841E8820C7AAC * ___list_0;
	// System.Int32 System.Collections.Generic.List`1/Enumerator::index
	int32_t ___index_1;
	// System.Int32 System.Collections.Generic.List`1/Enumerator::version
	int32_t ___version_2;
	// T System.Collections.Generic.List`1/Enumerator::current
	ValueTuple_2_t69671C4973C1A3829B2193E4C598B1AE7162E403  ___current_3;

public:
	inline static int32_t get_offset_of_list_0() { return static_cast<int32_t>(offsetof(Enumerator_tCF455A92CC670AF169DFC7D0E19B47CAB2BD1DA0, ___list_0)); }
	inline List_1_tF837281ACA0AE5696644C85291C841E8820C7AAC * get_list_0() const { return ___list_0; }
	inline List_1_tF837281ACA0AE5696644C85291C841E8820C7AAC ** get_address_of_list_0() { return &___list_0; }
	inline void set_list_0(List_1_tF837281ACA0AE5696644C85291C841E8820C7AAC * value)
	{
		___list_0 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___list_0), (void*)value);
	}

	inline static int32_t get_offset_of_index_1() { return static_cast<int32_t>(offsetof(Enumerator_tCF455A92CC670AF169DFC7D0E19B47CAB2BD1DA0, ___index_1)); }
	inline int32_t get_index_1() const { return ___index_1; }
	inline int32_t* get_address_of_index_1() { return &___index_1; }
	inline void set_index_1(int32_t value)
	{
		___index_1 = value;
	}

	inline static int32_t get_offset_of_version_2() { return static_cast<int32_t>(offsetof(Enumerator_tCF455A92CC670AF169DFC7D0E19B47CAB2BD1DA0, ___version_2)); }
	inline int32_t get_version_2() const { return ___version_2; }
	inline int32_t* get_address_of_version_2() { return &___version_2; }
	inline void set_version_2(int32_t value)
	{
		___version_2 = value;
	}

	inline static int32_t get_offset_of_current_3() { return static_cast<int32_t>(offsetof(Enumerator_tCF455A92CC670AF169DFC7D0E19B47CAB2BD1DA0, ___current_3)); }
	inline ValueTuple_2_t69671C4973C1A3829B2193E4C598B1AE7162E403  get_current_3() const { return ___current_3; }
	inline ValueTuple_2_t69671C4973C1A3829B2193E4C598B1AE7162E403 * get_address_of_current_3() { return &___current_3; }
	inline void set_current_3(ValueTuple_2_t69671C4973C1A3829B2193E4C598B1AE7162E403  value)
	{
		___current_3 = value;
		Il2CppCodeGenWriteBarrier((void**)&(((&___current_3))->___Item1_0), (void*)NULL);
		#if IL2CPP_ENABLE_STRICT_WRITE_BARRIERS
		Il2CppCodeGenWriteBarrier((void**)&(((&___current_3))->___Item2_1), (void*)NULL);
		#endif
	}
};


// System.Collections.Generic.List`1/Enumerator<System.Decimal>
struct Enumerator_t97AF9DDC8F349478939A4899D22F6CC1A2FA7021 
{
public:
	// System.Collections.Generic.List`1<T> System.Collections.Generic.List`1/Enumerator::list
	List_1_t137B540BF717527106254AA05BE36A51A068C8F5 * ___list_0;
	// System.Int32 System.Collections.Generic.List`1/Enumerator::index
	int32_t ___index_1;
	// System.Int32 System.Collections.Generic.List`1/Enumerator::version
	int32_t ___version_2;
	// T System.Collections.Generic.List`1/Enumerator::current
	Decimal_t2978B229CA86D3B7BA66A0AEEE014E0DE4F940D7  ___current_3;

public:
	inline static int32_t get_offset_of_list_0() { return static_cast<int32_t>(offsetof(Enumerator_t97AF9DDC8F349478939A4899D22F6CC1A2FA7021, ___list_0)); }
	inline List_1_t137B540BF717527106254AA05BE36A51A068C8F5 * get_list_0() const { return ___list_0; }
	inline List_1_t137B540BF717527106254AA05BE36A51A068C8F5 ** get_address_of_list_0() { return &___list_0; }
	inline void set_list_0(List_1_t137B540BF717527106254AA05BE36A51A068C8F5 * value)
	{
		___list_0 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___list_0), (void*)value);
	}

	inline static int32_t get_offset_of_index_1() { return static_cast<int32_t>(offsetof(Enumerator_t97AF9DDC8F349478939A4899D22F6CC1A2FA7021, ___index_1)); }
	inline int32_t get_index_1() const { return ___index_1; }
	inline int32_t* get_address_of_index_1() { return &___index_1; }
	inline void set_index_1(int32_t value)
	{
		___index_1 = value;
	}

	inline static int32_t get_offset_of_version_2() { return static_cast<int32_t>(offsetof(Enumerator_t97AF9DDC8F349478939A4899D22F6CC1A2FA7021, ___version_2)); }
	inline int32_t get_version_2() const { return ___version_2; }
	inline int32_t* get_address_of_version_2() { return &___version_2; }
	inline void set_version_2(int32_t value)
	{
		___version_2 = value;
	}

	inline static int32_t get_offset_of_current_3() { return static_cast<int32_t>(offsetof(Enumerator_t97AF9DDC8F349478939A4899D22F6CC1A2FA7021, ___current_3)); }
	inline Decimal_t2978B229CA86D3B7BA66A0AEEE014E0DE4F940D7  get_current_3() const { return ___current_3; }
	inline Decimal_t2978B229CA86D3B7BA66A0AEEE014E0DE4F940D7 * get_address_of_current_3() { return &___current_3; }
	inline void set_current_3(Decimal_t2978B229CA86D3B7BA66A0AEEE014E0DE4F940D7  value)
	{
		___current_3 = value;
	}
};


// System.Linq.Enumerable/Iterator`1<System.Nullable`1<System.Double>>
struct Iterator_1_t75B26B5E87871854D759A25738CFE42AF131D6A8  : public RuntimeObject
{
public:
	// System.Int32 System.Linq.Enumerable/Iterator`1::threadId
	int32_t ___threadId_0;
	// System.Int32 System.Linq.Enumerable/Iterator`1::state
	int32_t ___state_1;
	// TSource System.Linq.Enumerable/Iterator`1::current
	Nullable_1_t75730434CAD4E48A4EE117588CFD586FFBCAC209  ___current_2;

public:
	inline static int32_t get_offset_of_threadId_0() { return static_cast<int32_t>(offsetof(Iterator_1_t75B26B5E87871854D759A25738CFE42AF131D6A8, ___threadId_0)); }
	inline int32_t get_threadId_0() const { return ___threadId_0; }
	inline int32_t* get_address_of_threadId_0() { return &___threadId_0; }
	inline void set_threadId_0(int32_t value)
	{
		___threadId_0 = value;
	}

	inline static int32_t get_offset_of_state_1() { return static_cast<int32_t>(offsetof(Iterator_1_t75B26B5E87871854D759A25738CFE42AF131D6A8, ___state_1)); }
	inline int32_t get_state_1() const { return ___state_1; }
	inline int32_t* get_address_of_state_1() { return &___state_1; }
	inline void set_state_1(int32_t value)
	{
		___state_1 = value;
	}

	inline static int32_t get_offset_of_current_2() { return static_cast<int32_t>(offsetof(Iterator_1_t75B26B5E87871854D759A25738CFE42AF131D6A8, ___current_2)); }
	inline Nullable_1_t75730434CAD4E48A4EE117588CFD586FFBCAC209  get_current_2() const { return ___current_2; }
	inline Nullable_1_t75730434CAD4E48A4EE117588CFD586FFBCAC209 * get_address_of_current_2() { return &___current_2; }
	inline void set_current_2(Nullable_1_t75730434CAD4E48A4EE117588CFD586FFBCAC209  value)
	{
		___current_2 = value;
	}
};


// System.Linq.Enumerable/Iterator`1<System.Nullable`1<System.Int32>>
struct Iterator_1_t88E927D3E5FC45C833C1A5146A04FBA17D02CA43  : public RuntimeObject
{
public:
	// System.Int32 System.Linq.Enumerable/Iterator`1::threadId
	int32_t ___threadId_0;
	// System.Int32 System.Linq.Enumerable/Iterator`1::state
	int32_t ___state_1;
	// TSource System.Linq.Enumerable/Iterator`1::current
	Nullable_1_t864FD0051A05D37F91C857AB496BFCB3FE756103  ___current_2;

public:
	inline static int32_t get_offset_of_threadId_0() { return static_cast<int32_t>(offsetof(Iterator_1_t88E927D3E5FC45C833C1A5146A04FBA17D02CA43, ___threadId_0)); }
	inline int32_t get_threadId_0() const { return ___threadId_0; }
	inline int32_t* get_address_of_threadId_0() { return &___threadId_0; }
	inline void set_threadId_0(int32_t value)
	{
		___threadId_0 = value;
	}

	inline static int32_t get_offset_of_state_1() { return static_cast<int32_t>(offsetof(Iterator_1_t88E927D3E5FC45C833C1A5146A04FBA17D02CA43, ___state_1)); }
	inline int32_t get_state_1() const { return ___state_1; }
	inline int32_t* get_address_of_state_1() { return &___state_1; }
	inline void set_state_1(int32_t value)
	{
		___state_1 = value;
	}

	inline static int32_t get_offset_of_current_2() { return static_cast<int32_t>(offsetof(Iterator_1_t88E927D3E5FC45C833C1A5146A04FBA17D02CA43, ___current_2)); }
	inline Nullable_1_t864FD0051A05D37F91C857AB496BFCB3FE756103  get_current_2() const { return ___current_2; }
	inline Nullable_1_t864FD0051A05D37F91C857AB496BFCB3FE756103 * get_address_of_current_2() { return &___current_2; }
	inline void set_current_2(Nullable_1_t864FD0051A05D37F91C857AB496BFCB3FE756103  value)
	{
		___current_2 = value;
	}
};


// System.Linq.Enumerable/Iterator`1<System.Nullable`1<System.Int64>>
struct Iterator_1_t7714579EDED47F91E8FBA7AF6D3F0674241FDF6C  : public RuntimeObject
{
public:
	// System.Int32 System.Linq.Enumerable/Iterator`1::threadId
	int32_t ___threadId_0;
	// System.Int32 System.Linq.Enumerable/Iterator`1::state
	int32_t ___state_1;
	// TSource System.Linq.Enumerable/Iterator`1::current
	Nullable_1_t340361C8134256120F5769AC5A3F743DB6C11D1F  ___current_2;

public:
	inline static int32_t get_offset_of_threadId_0() { return static_cast<int32_t>(offsetof(Iterator_1_t7714579EDED47F91E8FBA7AF6D3F0674241FDF6C, ___threadId_0)); }
	inline int32_t get_threadId_0() const { return ___threadId_0; }
	inline int32_t* get_address_of_threadId_0() { return &___threadId_0; }
	inline void set_threadId_0(int32_t value)
	{
		___threadId_0 = value;
	}

	inline static int32_t get_offset_of_state_1() { return static_cast<int32_t>(offsetof(Iterator_1_t7714579EDED47F91E8FBA7AF6D3F0674241FDF6C, ___state_1)); }
	inline int32_t get_state_1() const { return ___state_1; }
	inline int32_t* get_address_of_state_1() { return &___state_1; }
	inline void set_state_1(int32_t value)
	{
		___state_1 = value;
	}

	inline static int32_t get_offset_of_current_2() { return static_cast<int32_t>(offsetof(Iterator_1_t7714579EDED47F91E8FBA7AF6D3F0674241FDF6C, ___current_2)); }
	inline Nullable_1_t340361C8134256120F5769AC5A3F743DB6C11D1F  get_current_2() const { return ___current_2; }
	inline Nullable_1_t340361C8134256120F5769AC5A3F743DB6C11D1F * get_address_of_current_2() { return &___current_2; }
	inline void set_current_2(Nullable_1_t340361C8134256120F5769AC5A3F743DB6C11D1F  value)
	{
		___current_2 = value;
	}
};


// System.Linq.Enumerable/Iterator`1<System.Nullable`1<System.Single>>
struct Iterator_1_t5F8CC81E7DD3167D5EC5BFC0984EBCEE64F5B45E  : public RuntimeObject
{
public:
	// System.Int32 System.Linq.Enumerable/Iterator`1::threadId
	int32_t ___threadId_0;
	// System.Int32 System.Linq.Enumerable/Iterator`1::state
	int32_t ___state_1;
	// TSource System.Linq.Enumerable/Iterator`1::current
	Nullable_1_t0C4AC2E457C437FA106160547FD9BA5B50B1888A  ___current_2;

public:
	inline static int32_t get_offset_of_threadId_0() { return static_cast<int32_t>(offsetof(Iterator_1_t5F8CC81E7DD3167D5EC5BFC0984EBCEE64F5B45E, ___threadId_0)); }
	inline int32_t get_threadId_0() const { return ___threadId_0; }
	inline int32_t* get_address_of_threadId_0() { return &___threadId_0; }
	inline void set_threadId_0(int32_t value)
	{
		___threadId_0 = value;
	}

	inline static int32_t get_offset_of_state_1() { return static_cast<int32_t>(offsetof(Iterator_1_t5F8CC81E7DD3167D5EC5BFC0984EBCEE64F5B45E, ___state_1)); }
	inline int32_t get_state_1() const { return ___state_1; }
	inline int32_t* get_address_of_state_1() { return &___state_1; }
	inline void set_state_1(int32_t value)
	{
		___state_1 = value;
	}

	inline static int32_t get_offset_of_current_2() { return static_cast<int32_t>(offsetof(Iterator_1_t5F8CC81E7DD3167D5EC5BFC0984EBCEE64F5B45E, ___current_2)); }
	inline Nullable_1_t0C4AC2E457C437FA106160547FD9BA5B50B1888A  get_current_2() const { return ___current_2; }
	inline Nullable_1_t0C4AC2E457C437FA106160547FD9BA5B50B1888A * get_address_of_current_2() { return &___current_2; }
	inline void set_current_2(Nullable_1_t0C4AC2E457C437FA106160547FD9BA5B50B1888A  value)
	{
		___current_2 = value;
	}
};


// System.Linq.Enumerable/Iterator`1<UnityEngine.Color>
struct Iterator_1_tDEF6AC46E52D8687C27A6E60B6E0200D50011D76  : public RuntimeObject
{
public:
	// System.Int32 System.Linq.Enumerable/Iterator`1::threadId
	int32_t ___threadId_0;
	// System.Int32 System.Linq.Enumerable/Iterator`1::state
	int32_t ___state_1;
	// TSource System.Linq.Enumerable/Iterator`1::current
	Color_tF40DAF76C04FFECF3FE6024F85A294741C9CC659  ___current_2;

public:
	inline static int32_t get_offset_of_threadId_0() { return static_cast<int32_t>(offsetof(Iterator_1_tDEF6AC46E52D8687C27A6E60B6E0200D50011D76, ___threadId_0)); }
	inline int32_t get_threadId_0() const { return ___threadId_0; }
	inline int32_t* get_address_of_threadId_0() { return &___threadId_0; }
	inline void set_threadId_0(int32_t value)
	{
		___threadId_0 = value;
	}

	inline static int32_t get_offset_of_state_1() { return static_cast<int32_t>(offsetof(Iterator_1_tDEF6AC46E52D8687C27A6E60B6E0200D50011D76, ___state_1)); }
	inline int32_t get_state_1() const { return ___state_1; }
	inline int32_t* get_address_of_state_1() { return &___state_1; }
	inline void set_state_1(int32_t value)
	{
		___state_1 = value;
	}

	inline static int32_t get_offset_of_current_2() { return static_cast<int32_t>(offsetof(Iterator_1_tDEF6AC46E52D8687C27A6E60B6E0200D50011D76, ___current_2)); }
	inline Color_tF40DAF76C04FFECF3FE6024F85A294741C9CC659  get_current_2() const { return ___current_2; }
	inline Color_tF40DAF76C04FFECF3FE6024F85A294741C9CC659 * get_address_of_current_2() { return &___current_2; }
	inline void set_current_2(Color_tF40DAF76C04FFECF3FE6024F85A294741C9CC659  value)
	{
		___current_2 = value;
	}
};


// System.Linq.Enumerable/Iterator`1<System.Decimal>
struct Iterator_1_t4861EDEAC91472CDE6F71F17BA6EF43B5D56F78E  : public RuntimeObject
{
public:
	// System.Int32 System.Linq.Enumerable/Iterator`1::threadId
	int32_t ___threadId_0;
	// System.Int32 System.Linq.Enumerable/Iterator`1::state
	int32_t ___state_1;
	// TSource System.Linq.Enumerable/Iterator`1::current
	Decimal_t2978B229CA86D3B7BA66A0AEEE014E0DE4F940D7  ___current_2;

public:
	inline static int32_t get_offset_of_threadId_0() { return static_cast<int32_t>(offsetof(Iterator_1_t4861EDEAC91472CDE6F71F17BA6EF43B5D56F78E, ___threadId_0)); }
	inline int32_t get_threadId_0() const { return ___threadId_0; }
	inline int32_t* get_address_of_threadId_0() { return &___threadId_0; }
	inline void set_threadId_0(int32_t value)
	{
		___threadId_0 = value;
	}

	inline static int32_t get_offset_of_state_1() { return static_cast<int32_t>(offsetof(Iterator_1_t4861EDEAC91472CDE6F71F17BA6EF43B5D56F78E, ___state_1)); }
	inline int32_t get_state_1() const { return ___state_1; }
	inline int32_t* get_address_of_state_1() { return &___state_1; }
	inline void set_state_1(int32_t value)
	{
		___state_1 = value;
	}

	inline static int32_t get_offset_of_current_2() { return static_cast<int32_t>(offsetof(Iterator_1_t4861EDEAC91472CDE6F71F17BA6EF43B5D56F78E, ___current_2)); }
	inline Decimal_t2978B229CA86D3B7BA66A0AEEE014E0DE4F940D7  get_current_2() const { return ___current_2; }
	inline Decimal_t2978B229CA86D3B7BA66A0AEEE014E0DE4F940D7 * get_address_of_current_2() { return &___current_2; }
	inline void set_current_2(Decimal_t2978B229CA86D3B7BA66A0AEEE014E0DE4F940D7  value)
	{
		___current_2 = value;
	}
};


// System.Linq.Enumerable/Iterator`1<UnityEngine.Vector3>
struct Iterator_1_t04F5D870FD247BBBEE27254587FA10F440D4EEFF  : public RuntimeObject
{
public:
	// System.Int32 System.Linq.Enumerable/Iterator`1::threadId
	int32_t ___threadId_0;
	// System.Int32 System.Linq.Enumerable/Iterator`1::state
	int32_t ___state_1;
	// TSource System.Linq.Enumerable/Iterator`1::current
	Vector3_t65B972D6A585A0A5B63153CF1177A90D3C90D65E  ___current_2;

public:
	inline static int32_t get_offset_of_threadId_0() { return static_cast<int32_t>(offsetof(Iterator_1_t04F5D870FD247BBBEE27254587FA10F440D4EEFF, ___threadId_0)); }
	inline int32_t get_threadId_0() const { return ___threadId_0; }
	inline int32_t* get_address_of_threadId_0() { return &___threadId_0; }
	inline void set_threadId_0(int32_t value)
	{
		___threadId_0 = value;
	}

	inline static int32_t get_offset_of_state_1() { return static_cast<int32_t>(offsetof(Iterator_1_t04F5D870FD247BBBEE27254587FA10F440D4EEFF, ___state_1)); }
	inline int32_t get_state_1() const { return ___state_1; }
	inline int32_t* get_address_of_state_1() { return &___state_1; }
	inline void set_state_1(int32_t value)
	{
		___state_1 = value;
	}

	inline static int32_t get_offset_of_current_2() { return static_cast<int32_t>(offsetof(Iterator_1_t04F5D870FD247BBBEE27254587FA10F440D4EEFF, ___current_2)); }
	inline Vector3_t65B972D6A585A0A5B63153CF1177A90D3C90D65E  get_current_2() const { return ___current_2; }
	inline Vector3_t65B972D6A585A0A5B63153CF1177A90D3C90D65E * get_address_of_current_2() { return &___current_2; }
	inline void set_current_2(Vector3_t65B972D6A585A0A5B63153CF1177A90D3C90D65E  value)
	{
		___current_2 = value;
	}
};


// System.Linq.Enumerable/Iterator`1<Unity.Mathematics.float3>
struct Iterator_1_tCEC2E244A64F110B247B6A3DF34DE60D4456BA1A  : public RuntimeObject
{
public:
	// System.Int32 System.Linq.Enumerable/Iterator`1::threadId
	int32_t ___threadId_0;
	// System.Int32 System.Linq.Enumerable/Iterator`1::state
	int32_t ___state_1;
	// TSource System.Linq.Enumerable/Iterator`1::current
	float3_tE0DD2FF13F818025945C9AC314390D2A1F55E37D  ___current_2;

public:
	inline static int32_t get_offset_of_threadId_0() { return static_cast<int32_t>(offsetof(Iterator_1_tCEC2E244A64F110B247B6A3DF34DE60D4456BA1A, ___threadId_0)); }
	inline int32_t get_threadId_0() const { return ___threadId_0; }
	inline int32_t* get_address_of_threadId_0() { return &___threadId_0; }
	inline void set_threadId_0(int32_t value)
	{
		___threadId_0 = value;
	}

	inline static int32_t get_offset_of_state_1() { return static_cast<int32_t>(offsetof(Iterator_1_tCEC2E244A64F110B247B6A3DF34DE60D4456BA1A, ___state_1)); }
	inline int32_t get_state_1() const { return ___state_1; }
	inline int32_t* get_address_of_state_1() { return &___state_1; }
	inline void set_state_1(int32_t value)
	{
		___state_1 = value;
	}

	inline static int32_t get_offset_of_current_2() { return static_cast<int32_t>(offsetof(Iterator_1_tCEC2E244A64F110B247B6A3DF34DE60D4456BA1A, ___current_2)); }
	inline float3_tE0DD2FF13F818025945C9AC314390D2A1F55E37D  get_current_2() const { return ___current_2; }
	inline float3_tE0DD2FF13F818025945C9AC314390D2A1F55E37D * get_address_of_current_2() { return &___current_2; }
	inline void set_current_2(float3_tE0DD2FF13F818025945C9AC314390D2A1F55E37D  value)
	{
		___current_2 = value;
	}
};


// System.Nullable`1<System.Decimal>
struct Nullable_1_tD7EB7EB39E548910812AA4DC702F9C7E3E84A84E 
{
public:
	// T System.Nullable`1::value
	Decimal_t2978B229CA86D3B7BA66A0AEEE014E0DE4F940D7  ___value_0;
	// System.Boolean System.Nullable`1::has_value
	bool ___has_value_1;

public:
	inline static int32_t get_offset_of_value_0() { return static_cast<int32_t>(offsetof(Nullable_1_tD7EB7EB39E548910812AA4DC702F9C7E3E84A84E, ___value_0)); }
	inline Decimal_t2978B229CA86D3B7BA66A0AEEE014E0DE4F940D7  get_value_0() const { return ___value_0; }
	inline Decimal_t2978B229CA86D3B7BA66A0AEEE014E0DE4F940D7 * get_address_of_value_0() { return &___value_0; }
	inline void set_value_0(Decimal_t2978B229CA86D3B7BA66A0AEEE014E0DE4F940D7  value)
	{
		___value_0 = value;
	}

	inline static int32_t get_offset_of_has_value_1() { return static_cast<int32_t>(offsetof(Nullable_1_tD7EB7EB39E548910812AA4DC702F9C7E3E84A84E, ___has_value_1)); }
	inline bool get_has_value_1() const { return ___has_value_1; }
	inline bool* get_address_of_has_value_1() { return &___has_value_1; }
	inline void set_has_value_1(bool value)
	{
		___has_value_1 = value;
	}
};


// System.Linq.Enumerable/WhereSelectListIterator`2<System.Boolean,System.Object>
struct WhereSelectListIterator_2_t7686D2FCD0C149BEF2A7DDFD0203E102E436E876  : public Iterator_1_t674ABE41CF4096D4BE4D51E21FEBDADBF74CC279
{
public:
	// System.Collections.Generic.List`1<TSource> System.Linq.Enumerable/WhereSelectListIterator`2::source
	List_1_tD4D2BACE5281B6C85799892C1F12F5F2F81A2DF3 * ___source_3;
	// System.Func`2<TSource,System.Boolean> System.Linq.Enumerable/WhereSelectListIterator`2::predicate
	Func_2_t50F598941CFDF02619DC5D52FFDBC329473C5F7B * ___predicate_4;
	// System.Func`2<TSource,TResult> System.Linq.Enumerable/WhereSelectListIterator`2::selector
	Func_2_t51AFCB712DCD56A45EE1645FC1762C549DA040FB * ___selector_5;
	// System.Collections.Generic.List`1/Enumerator<TSource> System.Linq.Enumerable/WhereSelectListIterator`2::enumerator
	Enumerator_t3F9663F5F32B0D733380A76CCEAA3ADFA3AE34A9  ___enumerator_6;

public:
	inline static int32_t get_offset_of_source_3() { return static_cast<int32_t>(offsetof(WhereSelectListIterator_2_t7686D2FCD0C149BEF2A7DDFD0203E102E436E876, ___source_3)); }
	inline List_1_tD4D2BACE5281B6C85799892C1F12F5F2F81A2DF3 * get_source_3() const { return ___source_3; }
	inline List_1_tD4D2BACE5281B6C85799892C1F12F5F2F81A2DF3 ** get_address_of_source_3() { return &___source_3; }
	inline void set_source_3(List_1_tD4D2BACE5281B6C85799892C1F12F5F2F81A2DF3 * value)
	{
		___source_3 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___source_3), (void*)value);
	}

	inline static int32_t get_offset_of_predicate_4() { return static_cast<int32_t>(offsetof(WhereSelectListIterator_2_t7686D2FCD0C149BEF2A7DDFD0203E102E436E876, ___predicate_4)); }
	inline Func_2_t50F598941CFDF02619DC5D52FFDBC329473C5F7B * get_predicate_4() const { return ___predicate_4; }
	inline Func_2_t50F598941CFDF02619DC5D52FFDBC329473C5F7B ** get_address_of_predicate_4() { return &___predicate_4; }
	inline void set_predicate_4(Func_2_t50F598941CFDF02619DC5D52FFDBC329473C5F7B * value)
	{
		___predicate_4 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___predicate_4), (void*)value);
	}

	inline static int32_t get_offset_of_selector_5() { return static_cast<int32_t>(offsetof(WhereSelectListIterator_2_t7686D2FCD0C149BEF2A7DDFD0203E102E436E876, ___selector_5)); }
	inline Func_2_t51AFCB712DCD56A45EE1645FC1762C549DA040FB * get_selector_5() const { return ___selector_5; }
	inline Func_2_t51AFCB712DCD56A45EE1645FC1762C549DA040FB ** get_address_of_selector_5() { return &___selector_5; }
	inline void set_selector_5(Func_2_t51AFCB712DCD56A45EE1645FC1762C549DA040FB * value)
	{
		___selector_5 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___selector_5), (void*)value);
	}

	inline static int32_t get_offset_of_enumerator_6() { return static_cast<int32_t>(offsetof(WhereSelectListIterator_2_t7686D2FCD0C149BEF2A7DDFD0203E102E436E876, ___enumerator_6)); }
	inline Enumerator_t3F9663F5F32B0D733380A76CCEAA3ADFA3AE34A9  get_enumerator_6() const { return ___enumerator_6; }
	inline Enumerator_t3F9663F5F32B0D733380A76CCEAA3ADFA3AE34A9 * get_address_of_enumerator_6() { return &___enumerator_6; }
	inline void set_enumerator_6(Enumerator_t3F9663F5F32B0D733380A76CCEAA3ADFA3AE34A9  value)
	{
		___enumerator_6 = value;
		Il2CppCodeGenWriteBarrier((void**)&(((&___enumerator_6))->___list_0), (void*)NULL);
	}
};


// System.Linq.Enumerable/WhereSelectListIterator`2<System.Double,System.Object>
struct WhereSelectListIterator_2_tEAC6442837D35900886655E6EBECD17A00D72FF1  : public Iterator_1_t674ABE41CF4096D4BE4D51E21FEBDADBF74CC279
{
public:
	// System.Collections.Generic.List`1<TSource> System.Linq.Enumerable/WhereSelectListIterator`2::source
	List_1_t760D7EED86247E3493CD5F22F0E822BF6AE1C2BC * ___source_3;
	// System.Func`2<TSource,System.Boolean> System.Linq.Enumerable/WhereSelectListIterator`2::predicate
	Func_2_t4E607BF9FA9E115F43BD77F92F4285E3B8C7FB0D * ___predicate_4;
	// System.Func`2<TSource,TResult> System.Linq.Enumerable/WhereSelectListIterator`2::selector
	Func_2_t9250D6A3AAE1BC9DC97036CF116D97FC17C08719 * ___selector_5;
	// System.Collections.Generic.List`1/Enumerator<TSource> System.Linq.Enumerable/WhereSelectListIterator`2::enumerator
	Enumerator_tDB7E887EC564EBF2D244915021ED0896BFD7A8A2  ___enumerator_6;

public:
	inline static int32_t get_offset_of_source_3() { return static_cast<int32_t>(offsetof(WhereSelectListIterator_2_tEAC6442837D35900886655E6EBECD17A00D72FF1, ___source_3)); }
	inline List_1_t760D7EED86247E3493CD5F22F0E822BF6AE1C2BC * get_source_3() const { return ___source_3; }
	inline List_1_t760D7EED86247E3493CD5F22F0E822BF6AE1C2BC ** get_address_of_source_3() { return &___source_3; }
	inline void set_source_3(List_1_t760D7EED86247E3493CD5F22F0E822BF6AE1C2BC * value)
	{
		___source_3 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___source_3), (void*)value);
	}

	inline static int32_t get_offset_of_predicate_4() { return static_cast<int32_t>(offsetof(WhereSelectListIterator_2_tEAC6442837D35900886655E6EBECD17A00D72FF1, ___predicate_4)); }
	inline Func_2_t4E607BF9FA9E115F43BD77F92F4285E3B8C7FB0D * get_predicate_4() const { return ___predicate_4; }
	inline Func_2_t4E607BF9FA9E115F43BD77F92F4285E3B8C7FB0D ** get_address_of_predicate_4() { return &___predicate_4; }
	inline void set_predicate_4(Func_2_t4E607BF9FA9E115F43BD77F92F4285E3B8C7FB0D * value)
	{
		___predicate_4 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___predicate_4), (void*)value);
	}

	inline static int32_t get_offset_of_selector_5() { return static_cast<int32_t>(offsetof(WhereSelectListIterator_2_tEAC6442837D35900886655E6EBECD17A00D72FF1, ___selector_5)); }
	inline Func_2_t9250D6A3AAE1BC9DC97036CF116D97FC17C08719 * get_selector_5() const { return ___selector_5; }
	inline Func_2_t9250D6A3AAE1BC9DC97036CF116D97FC17C08719 ** get_address_of_selector_5() { return &___selector_5; }
	inline void set_selector_5(Func_2_t9250D6A3AAE1BC9DC97036CF116D97FC17C08719 * value)
	{
		___selector_5 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___selector_5), (void*)value);
	}

	inline static int32_t get_offset_of_enumerator_6() { return static_cast<int32_t>(offsetof(WhereSelectListIterator_2_tEAC6442837D35900886655E6EBECD17A00D72FF1, ___enumerator_6)); }
	inline Enumerator_tDB7E887EC564EBF2D244915021ED0896BFD7A8A2  get_enumerator_6() const { return ___enumerator_6; }
	inline Enumerator_tDB7E887EC564EBF2D244915021ED0896BFD7A8A2 * get_address_of_enumerator_6() { return &___enumerator_6; }
	inline void set_enumerator_6(Enumerator_tDB7E887EC564EBF2D244915021ED0896BFD7A8A2  value)
	{
		___enumerator_6 = value;
		Il2CppCodeGenWriteBarrier((void**)&(((&___enumerator_6))->___list_0), (void*)NULL);
	}
};


// System.Linq.Enumerable/WhereSelectListIterator`2<System.Int32,System.Boolean>
struct WhereSelectListIterator_2_t2989AC7E9CA6D1FB0231FD52E44E7AFC843ACA21  : public Iterator_1_tF558BC64630CA9038F999F5A16CC3DD5A0DB6933
{
public:
	// System.Collections.Generic.List`1<TSource> System.Linq.Enumerable/WhereSelectListIterator`2::source
	List_1_t260B41F956D673396C33A4CF94E8D6C4389EACB7 * ___source_3;
	// System.Func`2<TSource,System.Boolean> System.Linq.Enumerable/WhereSelectListIterator`2::predicate
	Func_2_t2EBF98B0BA555D9F0633C9BCCBE3DF332B9C1274 * ___predicate_4;
	// System.Func`2<TSource,TResult> System.Linq.Enumerable/WhereSelectListIterator`2::selector
	Func_2_t2EBF98B0BA555D9F0633C9BCCBE3DF332B9C1274 * ___selector_5;
	// System.Collections.Generic.List`1/Enumerator<TSource> System.Linq.Enumerable/WhereSelectListIterator`2::enumerator
	Enumerator_t7BA00929E14A2F2A62CE085585044A3FEB2C5F3C  ___enumerator_6;

public:
	inline static int32_t get_offset_of_source_3() { return static_cast<int32_t>(offsetof(WhereSelectListIterator_2_t2989AC7E9CA6D1FB0231FD52E44E7AFC843ACA21, ___source_3)); }
	inline List_1_t260B41F956D673396C33A4CF94E8D6C4389EACB7 * get_source_3() const { return ___source_3; }
	inline List_1_t260B41F956D673396C33A4CF94E8D6C4389EACB7 ** get_address_of_source_3() { return &___source_3; }
	inline void set_source_3(List_1_t260B41F956D673396C33A4CF94E8D6C4389EACB7 * value)
	{
		___source_3 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___source_3), (void*)value);
	}

	inline static int32_t get_offset_of_predicate_4() { return static_cast<int32_t>(offsetof(WhereSelectListIterator_2_t2989AC7E9CA6D1FB0231FD52E44E7AFC843ACA21, ___predicate_4)); }
	inline Func_2_t2EBF98B0BA555D9F0633C9BCCBE3DF332B9C1274 * get_predicate_4() const { return ___predicate_4; }
	inline Func_2_t2EBF98B0BA555D9F0633C9BCCBE3DF332B9C1274 ** get_address_of_predicate_4() { return &___predicate_4; }
	inline void set_predicate_4(Func_2_t2EBF98B0BA555D9F0633C9BCCBE3DF332B9C1274 * value)
	{
		___predicate_4 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___predicate_4), (void*)value);
	}

	inline static int32_t get_offset_of_selector_5() { return static_cast<int32_t>(offsetof(WhereSelectListIterator_2_t2989AC7E9CA6D1FB0231FD52E44E7AFC843ACA21, ___selector_5)); }
	inline Func_2_t2EBF98B0BA555D9F0633C9BCCBE3DF332B9C1274 * get_selector_5() const { return ___selector_5; }
	inline Func_2_t2EBF98B0BA555D9F0633C9BCCBE3DF332B9C1274 ** get_address_of_selector_5() { return &___selector_5; }
	inline void set_selector_5(Func_2_t2EBF98B0BA555D9F0633C9BCCBE3DF332B9C1274 * value)
	{
		___selector_5 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___selector_5), (void*)value);
	}

	inline static int32_t get_offset_of_enumerator_6() { return static_cast<int32_t>(offsetof(WhereSelectListIterator_2_t2989AC7E9CA6D1FB0231FD52E44E7AFC843ACA21, ___enumerator_6)); }
	inline Enumerator_t7BA00929E14A2F2A62CE085585044A3FEB2C5F3C  get_enumerator_6() const { return ___enumerator_6; }
	inline Enumerator_t7BA00929E14A2F2A62CE085585044A3FEB2C5F3C * get_address_of_enumerator_6() { return &___enumerator_6; }
	inline void set_enumerator_6(Enumerator_t7BA00929E14A2F2A62CE085585044A3FEB2C5F3C  value)
	{
		___enumerator_6 = value;
		Il2CppCodeGenWriteBarrier((void**)&(((&___enumerator_6))->___list_0), (void*)NULL);
	}
};


// System.Linq.Enumerable/WhereSelectListIterator`2<System.Int32,System.Double>
struct WhereSelectListIterator_2_tF60E714CAFC3118F16C82A15D86A38A42EFEDFA7  : public Iterator_1_t167C775670D48A9186D95126BDB6A078470CAE8D
{
public:
	// System.Collections.Generic.List`1<TSource> System.Linq.Enumerable/WhereSelectListIterator`2::source
	List_1_t260B41F956D673396C33A4CF94E8D6C4389EACB7 * ___source_3;
	// System.Func`2<TSource,System.Boolean> System.Linq.Enumerable/WhereSelectListIterator`2::predicate
	Func_2_t2EBF98B0BA555D9F0633C9BCCBE3DF332B9C1274 * ___predicate_4;
	// System.Func`2<TSource,TResult> System.Linq.Enumerable/WhereSelectListIterator`2::selector
	Func_2_t23C797B165C3B4B97ADF0BE92281F030E672AD4B * ___selector_5;
	// System.Collections.Generic.List`1/Enumerator<TSource> System.Linq.Enumerable/WhereSelectListIterator`2::enumerator
	Enumerator_t7BA00929E14A2F2A62CE085585044A3FEB2C5F3C  ___enumerator_6;

public:
	inline static int32_t get_offset_of_source_3() { return static_cast<int32_t>(offsetof(WhereSelectListIterator_2_tF60E714CAFC3118F16C82A15D86A38A42EFEDFA7, ___source_3)); }
	inline List_1_t260B41F956D673396C33A4CF94E8D6C4389EACB7 * get_source_3() const { return ___source_3; }
	inline List_1_t260B41F956D673396C33A4CF94E8D6C4389EACB7 ** get_address_of_source_3() { return &___source_3; }
	inline void set_source_3(List_1_t260B41F956D673396C33A4CF94E8D6C4389EACB7 * value)
	{
		___source_3 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___source_3), (void*)value);
	}

	inline static int32_t get_offset_of_predicate_4() { return static_cast<int32_t>(offsetof(WhereSelectListIterator_2_tF60E714CAFC3118F16C82A15D86A38A42EFEDFA7, ___predicate_4)); }
	inline Func_2_t2EBF98B0BA555D9F0633C9BCCBE3DF332B9C1274 * get_predicate_4() const { return ___predicate_4; }
	inline Func_2_t2EBF98B0BA555D9F0633C9BCCBE3DF332B9C1274 ** get_address_of_predicate_4() { return &___predicate_4; }
	inline void set_predicate_4(Func_2_t2EBF98B0BA555D9F0633C9BCCBE3DF332B9C1274 * value)
	{
		___predicate_4 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___predicate_4), (void*)value);
	}

	inline static int32_t get_offset_of_selector_5() { return static_cast<int32_t>(offsetof(WhereSelectListIterator_2_tF60E714CAFC3118F16C82A15D86A38A42EFEDFA7, ___selector_5)); }
	inline Func_2_t23C797B165C3B4B97ADF0BE92281F030E672AD4B * get_selector_5() const { return ___selector_5; }
	inline Func_2_t23C797B165C3B4B97ADF0BE92281F030E672AD4B ** get_address_of_selector_5() { return &___selector_5; }
	inline void set_selector_5(Func_2_t23C797B165C3B4B97ADF0BE92281F030E672AD4B * value)
	{
		___selector_5 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___selector_5), (void*)value);
	}

	inline static int32_t get_offset_of_enumerator_6() { return static_cast<int32_t>(offsetof(WhereSelectListIterator_2_tF60E714CAFC3118F16C82A15D86A38A42EFEDFA7, ___enumerator_6)); }
	inline Enumerator_t7BA00929E14A2F2A62CE085585044A3FEB2C5F3C  get_enumerator_6() const { return ___enumerator_6; }
	inline Enumerator_t7BA00929E14A2F2A62CE085585044A3FEB2C5F3C * get_address_of_enumerator_6() { return &___enumerator_6; }
	inline void set_enumerator_6(Enumerator_t7BA00929E14A2F2A62CE085585044A3FEB2C5F3C  value)
	{
		___enumerator_6 = value;
		Il2CppCodeGenWriteBarrier((void**)&(((&___enumerator_6))->___list_0), (void*)NULL);
	}
};


// System.Linq.Enumerable/WhereSelectListIterator`2<System.Int32,System.Int32>
struct WhereSelectListIterator_2_t4CC3FE3A35610DC6F761EE7DB863B845957AD325  : public Iterator_1_tCFFC952B03DBE4E956DE317DB9704D936AEA2379
{
public:
	// System.Collections.Generic.List`1<TSource> System.Linq.Enumerable/WhereSelectListIterator`2::source
	List_1_t260B41F956D673396C33A4CF94E8D6C4389EACB7 * ___source_3;
	// System.Func`2<TSource,System.Boolean> System.Linq.Enumerable/WhereSelectListIterator`2::predicate
	Func_2_t2EBF98B0BA555D9F0633C9BCCBE3DF332B9C1274 * ___predicate_4;
	// System.Func`2<TSource,TResult> System.Linq.Enumerable/WhereSelectListIterator`2::selector
	Func_2_tFF6AE79EFD0857556AD37A1A1594C43F76012FEA * ___selector_5;
	// System.Collections.Generic.List`1/Enumerator<TSource> System.Linq.Enumerable/WhereSelectListIterator`2::enumerator
	Enumerator_t7BA00929E14A2F2A62CE085585044A3FEB2C5F3C  ___enumerator_6;

public:
	inline static int32_t get_offset_of_source_3() { return static_cast<int32_t>(offsetof(WhereSelectListIterator_2_t4CC3FE3A35610DC6F761EE7DB863B845957AD325, ___source_3)); }
	inline List_1_t260B41F956D673396C33A4CF94E8D6C4389EACB7 * get_source_3() const { return ___source_3; }
	inline List_1_t260B41F956D673396C33A4CF94E8D6C4389EACB7 ** get_address_of_source_3() { return &___source_3; }
	inline void set_source_3(List_1_t260B41F956D673396C33A4CF94E8D6C4389EACB7 * value)
	{
		___source_3 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___source_3), (void*)value);
	}

	inline static int32_t get_offset_of_predicate_4() { return static_cast<int32_t>(offsetof(WhereSelectListIterator_2_t4CC3FE3A35610DC6F761EE7DB863B845957AD325, ___predicate_4)); }
	inline Func_2_t2EBF98B0BA555D9F0633C9BCCBE3DF332B9C1274 * get_predicate_4() const { return ___predicate_4; }
	inline Func_2_t2EBF98B0BA555D9F0633C9BCCBE3DF332B9C1274 ** get_address_of_predicate_4() { return &___predicate_4; }
	inline void set_predicate_4(Func_2_t2EBF98B0BA555D9F0633C9BCCBE3DF332B9C1274 * value)
	{
		___predicate_4 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___predicate_4), (void*)value);
	}

	inline static int32_t get_offset_of_selector_5() { return static_cast<int32_t>(offsetof(WhereSelectListIterator_2_t4CC3FE3A35610DC6F761EE7DB863B845957AD325, ___selector_5)); }
	inline Func_2_tFF6AE79EFD0857556AD37A1A1594C43F76012FEA * get_selector_5() const { return ___selector_5; }
	inline Func_2_tFF6AE79EFD0857556AD37A1A1594C43F76012FEA ** get_address_of_selector_5() { return &___selector_5; }
	inline void set_selector_5(Func_2_tFF6AE79EFD0857556AD37A1A1594C43F76012FEA * value)
	{
		___selector_5 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___selector_5), (void*)value);
	}

	inline static int32_t get_offset_of_enumerator_6() { return static_cast<int32_t>(offsetof(WhereSelectListIterator_2_t4CC3FE3A35610DC6F761EE7DB863B845957AD325, ___enumerator_6)); }
	inline Enumerator_t7BA00929E14A2F2A62CE085585044A3FEB2C5F3C  get_enumerator_6() const { return ___enumerator_6; }
	inline Enumerator_t7BA00929E14A2F2A62CE085585044A3FEB2C5F3C * get_address_of_enumerator_6() { return &___enumerator_6; }
	inline void set_enumerator_6(Enumerator_t7BA00929E14A2F2A62CE085585044A3FEB2C5F3C  value)
	{
		___enumerator_6 = value;
		Il2CppCodeGenWriteBarrier((void**)&(((&___enumerator_6))->___list_0), (void*)NULL);
	}
};


// System.Linq.Enumerable/WhereSelectListIterator`2<System.Int32,System.Int64>
struct WhereSelectListIterator_2_t029DF87EF6C1A59C1658F051FF560E0216888A24  : public Iterator_1_tF88FA02D56A55D26D525180DE0108FA4F019BECE
{
public:
	// System.Collections.Generic.List`1<TSource> System.Linq.Enumerable/WhereSelectListIterator`2::source
	List_1_t260B41F956D673396C33A4CF94E8D6C4389EACB7 * ___source_3;
	// System.Func`2<TSource,System.Boolean> System.Linq.Enumerable/WhereSelectListIterator`2::predicate
	Func_2_t2EBF98B0BA555D9F0633C9BCCBE3DF332B9C1274 * ___predicate_4;
	// System.Func`2<TSource,TResult> System.Linq.Enumerable/WhereSelectListIterator`2::selector
	Func_2_tAB99B2018719C6ADFD37FB04A207F07169AE46E0 * ___selector_5;
	// System.Collections.Generic.List`1/Enumerator<TSource> System.Linq.Enumerable/WhereSelectListIterator`2::enumerator
	Enumerator_t7BA00929E14A2F2A62CE085585044A3FEB2C5F3C  ___enumerator_6;

public:
	inline static int32_t get_offset_of_source_3() { return static_cast<int32_t>(offsetof(WhereSelectListIterator_2_t029DF87EF6C1A59C1658F051FF560E0216888A24, ___source_3)); }
	inline List_1_t260B41F956D673396C33A4CF94E8D6C4389EACB7 * get_source_3() const { return ___source_3; }
	inline List_1_t260B41F956D673396C33A4CF94E8D6C4389EACB7 ** get_address_of_source_3() { return &___source_3; }
	inline void set_source_3(List_1_t260B41F956D673396C33A4CF94E8D6C4389EACB7 * value)
	{
		___source_3 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___source_3), (void*)value);
	}

	inline static int32_t get_offset_of_predicate_4() { return static_cast<int32_t>(offsetof(WhereSelectListIterator_2_t029DF87EF6C1A59C1658F051FF560E0216888A24, ___predicate_4)); }
	inline Func_2_t2EBF98B0BA555D9F0633C9BCCBE3DF332B9C1274 * get_predicate_4() const { return ___predicate_4; }
	inline Func_2_t2EBF98B0BA555D9F0633C9BCCBE3DF332B9C1274 ** get_address_of_predicate_4() { return &___predicate_4; }
	inline void set_predicate_4(Func_2_t2EBF98B0BA555D9F0633C9BCCBE3DF332B9C1274 * value)
	{
		___predicate_4 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___predicate_4), (void*)value);
	}

	inline static int32_t get_offset_of_selector_5() { return static_cast<int32_t>(offsetof(WhereSelectListIterator_2_t029DF87EF6C1A59C1658F051FF560E0216888A24, ___selector_5)); }
	inline Func_2_tAB99B2018719C6ADFD37FB04A207F07169AE46E0 * get_selector_5() const { return ___selector_5; }
	inline Func_2_tAB99B2018719C6ADFD37FB04A207F07169AE46E0 ** get_address_of_selector_5() { return &___selector_5; }
	inline void set_selector_5(Func_2_tAB99B2018719C6ADFD37FB04A207F07169AE46E0 * value)
	{
		___selector_5 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___selector_5), (void*)value);
	}

	inline static int32_t get_offset_of_enumerator_6() { return static_cast<int32_t>(offsetof(WhereSelectListIterator_2_t029DF87EF6C1A59C1658F051FF560E0216888A24, ___enumerator_6)); }
	inline Enumerator_t7BA00929E14A2F2A62CE085585044A3FEB2C5F3C  get_enumerator_6() const { return ___enumerator_6; }
	inline Enumerator_t7BA00929E14A2F2A62CE085585044A3FEB2C5F3C * get_address_of_enumerator_6() { return &___enumerator_6; }
	inline void set_enumerator_6(Enumerator_t7BA00929E14A2F2A62CE085585044A3FEB2C5F3C  value)
	{
		___enumerator_6 = value;
		Il2CppCodeGenWriteBarrier((void**)&(((&___enumerator_6))->___list_0), (void*)NULL);
	}
};


// System.Linq.Enumerable/WhereSelectListIterator`2<System.Int32,System.Object>
struct WhereSelectListIterator_2_tA41D93FF12E41BB5A5BEA27AEED367695ADACEA4  : public Iterator_1_t674ABE41CF4096D4BE4D51E21FEBDADBF74CC279
{
public:
	// System.Collections.Generic.List`1<TSource> System.Linq.Enumerable/WhereSelectListIterator`2::source
	List_1_t260B41F956D673396C33A4CF94E8D6C4389EACB7 * ___source_3;
	// System.Func`2<TSource,System.Boolean> System.Linq.Enumerable/WhereSelectListIterator`2::predicate
	Func_2_t2EBF98B0BA555D9F0633C9BCCBE3DF332B9C1274 * ___predicate_4;
	// System.Func`2<TSource,TResult> System.Linq.Enumerable/WhereSelectListIterator`2::selector
	Func_2_t401E8A228CE43E56CCE9280AD9C6D87CC73A0123 * ___selector_5;
	// System.Collections.Generic.List`1/Enumerator<TSource> System.Linq.Enumerable/WhereSelectListIterator`2::enumerator
	Enumerator_t7BA00929E14A2F2A62CE085585044A3FEB2C5F3C  ___enumerator_6;

public:
	inline static int32_t get_offset_of_source_3() { return static_cast<int32_t>(offsetof(WhereSelectListIterator_2_tA41D93FF12E41BB5A5BEA27AEED367695ADACEA4, ___source_3)); }
	inline List_1_t260B41F956D673396C33A4CF94E8D6C4389EACB7 * get_source_3() const { return ___source_3; }
	inline List_1_t260B41F956D673396C33A4CF94E8D6C4389EACB7 ** get_address_of_source_3() { return &___source_3; }
	inline void set_source_3(List_1_t260B41F956D673396C33A4CF94E8D6C4389EACB7 * value)
	{
		___source_3 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___source_3), (void*)value);
	}

	inline static int32_t get_offset_of_predicate_4() { return static_cast<int32_t>(offsetof(WhereSelectListIterator_2_tA41D93FF12E41BB5A5BEA27AEED367695ADACEA4, ___predicate_4)); }
	inline Func_2_t2EBF98B0BA555D9F0633C9BCCBE3DF332B9C1274 * get_predicate_4() const { return ___predicate_4; }
	inline Func_2_t2EBF98B0BA555D9F0633C9BCCBE3DF332B9C1274 ** get_address_of_predicate_4() { return &___predicate_4; }
	inline void set_predicate_4(Func_2_t2EBF98B0BA555D9F0633C9BCCBE3DF332B9C1274 * value)
	{
		___predicate_4 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___predicate_4), (void*)value);
	}

	inline static int32_t get_offset_of_selector_5() { return static_cast<int32_t>(offsetof(WhereSelectListIterator_2_tA41D93FF12E41BB5A5BEA27AEED367695ADACEA4, ___selector_5)); }
	inline Func_2_t401E8A228CE43E56CCE9280AD9C6D87CC73A0123 * get_selector_5() const { return ___selector_5; }
	inline Func_2_t401E8A228CE43E56CCE9280AD9C6D87CC73A0123 ** get_address_of_selector_5() { return &___selector_5; }
	inline void set_selector_5(Func_2_t401E8A228CE43E56CCE9280AD9C6D87CC73A0123 * value)
	{
		___selector_5 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___selector_5), (void*)value);
	}

	inline static int32_t get_offset_of_enumerator_6() { return static_cast<int32_t>(offsetof(WhereSelectListIterator_2_tA41D93FF12E41BB5A5BEA27AEED367695ADACEA4, ___enumerator_6)); }
	inline Enumerator_t7BA00929E14A2F2A62CE085585044A3FEB2C5F3C  get_enumerator_6() const { return ___enumerator_6; }
	inline Enumerator_t7BA00929E14A2F2A62CE085585044A3FEB2C5F3C * get_address_of_enumerator_6() { return &___enumerator_6; }
	inline void set_enumerator_6(Enumerator_t7BA00929E14A2F2A62CE085585044A3FEB2C5F3C  value)
	{
		___enumerator_6 = value;
		Il2CppCodeGenWriteBarrier((void**)&(((&___enumerator_6))->___list_0), (void*)NULL);
	}
};


// System.Linq.Enumerable/WhereSelectListIterator`2<System.Int32,System.Single>
struct WhereSelectListIterator_2_tBCA9468991E9C8B9F4178D0FA0C99545886B7F06  : public Iterator_1_t859CAAB8DD3B63D3758E13D2802ED7523B331199
{
public:
	// System.Collections.Generic.List`1<TSource> System.Linq.Enumerable/WhereSelectListIterator`2::source
	List_1_t260B41F956D673396C33A4CF94E8D6C4389EACB7 * ___source_3;
	// System.Func`2<TSource,System.Boolean> System.Linq.Enumerable/WhereSelectListIterator`2::predicate
	Func_2_t2EBF98B0BA555D9F0633C9BCCBE3DF332B9C1274 * ___predicate_4;
	// System.Func`2<TSource,TResult> System.Linq.Enumerable/WhereSelectListIterator`2::selector
	Func_2_t1452DFFA61F60F54CF3A78C987C4F98906EFD2B6 * ___selector_5;
	// System.Collections.Generic.List`1/Enumerator<TSource> System.Linq.Enumerable/WhereSelectListIterator`2::enumerator
	Enumerator_t7BA00929E14A2F2A62CE085585044A3FEB2C5F3C  ___enumerator_6;

public:
	inline static int32_t get_offset_of_source_3() { return static_cast<int32_t>(offsetof(WhereSelectListIterator_2_tBCA9468991E9C8B9F4178D0FA0C99545886B7F06, ___source_3)); }
	inline List_1_t260B41F956D673396C33A4CF94E8D6C4389EACB7 * get_source_3() const { return ___source_3; }
	inline List_1_t260B41F956D673396C33A4CF94E8D6C4389EACB7 ** get_address_of_source_3() { return &___source_3; }
	inline void set_source_3(List_1_t260B41F956D673396C33A4CF94E8D6C4389EACB7 * value)
	{
		___source_3 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___source_3), (void*)value);
	}

	inline static int32_t get_offset_of_predicate_4() { return static_cast<int32_t>(offsetof(WhereSelectListIterator_2_tBCA9468991E9C8B9F4178D0FA0C99545886B7F06, ___predicate_4)); }
	inline Func_2_t2EBF98B0BA555D9F0633C9BCCBE3DF332B9C1274 * get_predicate_4() const { return ___predicate_4; }
	inline Func_2_t2EBF98B0BA555D9F0633C9BCCBE3DF332B9C1274 ** get_address_of_predicate_4() { return &___predicate_4; }
	inline void set_predicate_4(Func_2_t2EBF98B0BA555D9F0633C9BCCBE3DF332B9C1274 * value)
	{
		___predicate_4 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___predicate_4), (void*)value);
	}

	inline static int32_t get_offset_of_selector_5() { return static_cast<int32_t>(offsetof(WhereSelectListIterator_2_tBCA9468991E9C8B9F4178D0FA0C99545886B7F06, ___selector_5)); }
	inline Func_2_t1452DFFA61F60F54CF3A78C987C4F98906EFD2B6 * get_selector_5() const { return ___selector_5; }
	inline Func_2_t1452DFFA61F60F54CF3A78C987C4F98906EFD2B6 ** get_address_of_selector_5() { return &___selector_5; }
	inline void set_selector_5(Func_2_t1452DFFA61F60F54CF3A78C987C4F98906EFD2B6 * value)
	{
		___selector_5 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___selector_5), (void*)value);
	}

	inline static int32_t get_offset_of_enumerator_6() { return static_cast<int32_t>(offsetof(WhereSelectListIterator_2_tBCA9468991E9C8B9F4178D0FA0C99545886B7F06, ___enumerator_6)); }
	inline Enumerator_t7BA00929E14A2F2A62CE085585044A3FEB2C5F3C  get_enumerator_6() const { return ___enumerator_6; }
	inline Enumerator_t7BA00929E14A2F2A62CE085585044A3FEB2C5F3C * get_address_of_enumerator_6() { return &___enumerator_6; }
	inline void set_enumerator_6(Enumerator_t7BA00929E14A2F2A62CE085585044A3FEB2C5F3C  value)
	{
		___enumerator_6 = value;
		Il2CppCodeGenWriteBarrier((void**)&(((&___enumerator_6))->___list_0), (void*)NULL);
	}
};


// System.Linq.Enumerable/WhereSelectListIterator`2<System.Int64,System.Object>
struct WhereSelectListIterator_2_t87107416F9D6AA1D41ED2E04567ABE36603547C9  : public Iterator_1_t674ABE41CF4096D4BE4D51E21FEBDADBF74CC279
{
public:
	// System.Collections.Generic.List`1<TSource> System.Linq.Enumerable/WhereSelectListIterator`2::source
	List_1_tC465E4AAC82F54C0A79B2CE3B797531B10B9ACE4 * ___source_3;
	// System.Func`2<TSource,System.Boolean> System.Linq.Enumerable/WhereSelectListIterator`2::predicate
	Func_2_t03B9AF86FB7E93B62590F1CBD16276EF7AA1B215 * ___predicate_4;
	// System.Func`2<TSource,TResult> System.Linq.Enumerable/WhereSelectListIterator`2::selector
	Func_2_tB6B8AC34A03E8EEE1C7FF71178B07B46BC827B7B * ___selector_5;
	// System.Collections.Generic.List`1/Enumerator<TSource> System.Linq.Enumerable/WhereSelectListIterator`2::enumerator
	Enumerator_t1C02C38119DFDA075166A979AE2B70CCA911ED37  ___enumerator_6;

public:
	inline static int32_t get_offset_of_source_3() { return static_cast<int32_t>(offsetof(WhereSelectListIterator_2_t87107416F9D6AA1D41ED2E04567ABE36603547C9, ___source_3)); }
	inline List_1_tC465E4AAC82F54C0A79B2CE3B797531B10B9ACE4 * get_source_3() const { return ___source_3; }
	inline List_1_tC465E4AAC82F54C0A79B2CE3B797531B10B9ACE4 ** get_address_of_source_3() { return &___source_3; }
	inline void set_source_3(List_1_tC465E4AAC82F54C0A79B2CE3B797531B10B9ACE4 * value)
	{
		___source_3 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___source_3), (void*)value);
	}

	inline static int32_t get_offset_of_predicate_4() { return static_cast<int32_t>(offsetof(WhereSelectListIterator_2_t87107416F9D6AA1D41ED2E04567ABE36603547C9, ___predicate_4)); }
	inline Func_2_t03B9AF86FB7E93B62590F1CBD16276EF7AA1B215 * get_predicate_4() const { return ___predicate_4; }
	inline Func_2_t03B9AF86FB7E93B62590F1CBD16276EF7AA1B215 ** get_address_of_predicate_4() { return &___predicate_4; }
	inline void set_predicate_4(Func_2_t03B9AF86FB7E93B62590F1CBD16276EF7AA1B215 * value)
	{
		___predicate_4 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___predicate_4), (void*)value);
	}

	inline static int32_t get_offset_of_selector_5() { return static_cast<int32_t>(offsetof(WhereSelectListIterator_2_t87107416F9D6AA1D41ED2E04567ABE36603547C9, ___selector_5)); }
	inline Func_2_tB6B8AC34A03E8EEE1C7FF71178B07B46BC827B7B * get_selector_5() const { return ___selector_5; }
	inline Func_2_tB6B8AC34A03E8EEE1C7FF71178B07B46BC827B7B ** get_address_of_selector_5() { return &___selector_5; }
	inline void set_selector_5(Func_2_tB6B8AC34A03E8EEE1C7FF71178B07B46BC827B7B * value)
	{
		___selector_5 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___selector_5), (void*)value);
	}

	inline static int32_t get_offset_of_enumerator_6() { return static_cast<int32_t>(offsetof(WhereSelectListIterator_2_t87107416F9D6AA1D41ED2E04567ABE36603547C9, ___enumerator_6)); }
	inline Enumerator_t1C02C38119DFDA075166A979AE2B70CCA911ED37  get_enumerator_6() const { return ___enumerator_6; }
	inline Enumerator_t1C02C38119DFDA075166A979AE2B70CCA911ED37 * get_address_of_enumerator_6() { return &___enumerator_6; }
	inline void set_enumerator_6(Enumerator_t1C02C38119DFDA075166A979AE2B70CCA911ED37  value)
	{
		___enumerator_6 = value;
		Il2CppCodeGenWriteBarrier((void**)&(((&___enumerator_6))->___list_0), (void*)NULL);
	}
};


// System.Linq.Enumerable/WhereSelectListIterator`2<System.Object,System.Boolean>
struct WhereSelectListIterator_2_t1135F63EC4A3B58BB9EDE8324AD11A2B64F209E2  : public Iterator_1_tF558BC64630CA9038F999F5A16CC3DD5A0DB6933
{
public:
	// System.Collections.Generic.List`1<TSource> System.Linq.Enumerable/WhereSelectListIterator`2::source
	List_1_t3F94120C77410A62EAE48421CF166B83AB95A2F5 * ___source_3;
	// System.Func`2<TSource,System.Boolean> System.Linq.Enumerable/WhereSelectListIterator`2::predicate
	Func_2_t99409DECFF50F0FA9B427C863AC6C99C66E6F9F8 * ___predicate_4;
	// System.Func`2<TSource,TResult> System.Linq.Enumerable/WhereSelectListIterator`2::selector
	Func_2_t99409DECFF50F0FA9B427C863AC6C99C66E6F9F8 * ___selector_5;
	// System.Collections.Generic.List`1/Enumerator<TSource> System.Linq.Enumerable/WhereSelectListIterator`2::enumerator
	Enumerator_tB6009981BD4E3881E3EC83627255A24198F902D6  ___enumerator_6;

public:
	inline static int32_t get_offset_of_source_3() { return static_cast<int32_t>(offsetof(WhereSelectListIterator_2_t1135F63EC4A3B58BB9EDE8324AD11A2B64F209E2, ___source_3)); }
	inline List_1_t3F94120C77410A62EAE48421CF166B83AB95A2F5 * get_source_3() const { return ___source_3; }
	inline List_1_t3F94120C77410A62EAE48421CF166B83AB95A2F5 ** get_address_of_source_3() { return &___source_3; }
	inline void set_source_3(List_1_t3F94120C77410A62EAE48421CF166B83AB95A2F5 * value)
	{
		___source_3 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___source_3), (void*)value);
	}

	inline static int32_t get_offset_of_predicate_4() { return static_cast<int32_t>(offsetof(WhereSelectListIterator_2_t1135F63EC4A3B58BB9EDE8324AD11A2B64F209E2, ___predicate_4)); }
	inline Func_2_t99409DECFF50F0FA9B427C863AC6C99C66E6F9F8 * get_predicate_4() const { return ___predicate_4; }
	inline Func_2_t99409DECFF50F0FA9B427C863AC6C99C66E6F9F8 ** get_address_of_predicate_4() { return &___predicate_4; }
	inline void set_predicate_4(Func_2_t99409DECFF50F0FA9B427C863AC6C99C66E6F9F8 * value)
	{
		___predicate_4 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___predicate_4), (void*)value);
	}

	inline static int32_t get_offset_of_selector_5() { return static_cast<int32_t>(offsetof(WhereSelectListIterator_2_t1135F63EC4A3B58BB9EDE8324AD11A2B64F209E2, ___selector_5)); }
	inline Func_2_t99409DECFF50F0FA9B427C863AC6C99C66E6F9F8 * get_selector_5() const { return ___selector_5; }
	inline Func_2_t99409DECFF50F0FA9B427C863AC6C99C66E6F9F8 ** get_address_of_selector_5() { return &___selector_5; }
	inline void set_selector_5(Func_2_t99409DECFF50F0FA9B427C863AC6C99C66E6F9F8 * value)
	{
		___selector_5 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___selector_5), (void*)value);
	}

	inline static int32_t get_offset_of_enumerator_6() { return static_cast<int32_t>(offsetof(WhereSelectListIterator_2_t1135F63EC4A3B58BB9EDE8324AD11A2B64F209E2, ___enumerator_6)); }
	inline Enumerator_tB6009981BD4E3881E3EC83627255A24198F902D6  get_enumerator_6() const { return ___enumerator_6; }
	inline Enumerator_tB6009981BD4E3881E3EC83627255A24198F902D6 * get_address_of_enumerator_6() { return &___enumerator_6; }
	inline void set_enumerator_6(Enumerator_tB6009981BD4E3881E3EC83627255A24198F902D6  value)
	{
		___enumerator_6 = value;
		Il2CppCodeGenWriteBarrier((void**)&(((&___enumerator_6))->___list_0), (void*)NULL);
		#if IL2CPP_ENABLE_STRICT_WRITE_BARRIERS
		Il2CppCodeGenWriteBarrier((void**)&(((&___enumerator_6))->___current_3), (void*)NULL);
		#endif
	}
};


// System.Linq.Enumerable/WhereSelectListIterator`2<System.Object,System.Double>
struct WhereSelectListIterator_2_tFD5E5F4E072C47EE9200C7D42018559EEAA4E0CD  : public Iterator_1_t167C775670D48A9186D95126BDB6A078470CAE8D
{
public:
	// System.Collections.Generic.List`1<TSource> System.Linq.Enumerable/WhereSelectListIterator`2::source
	List_1_t3F94120C77410A62EAE48421CF166B83AB95A2F5 * ___source_3;
	// System.Func`2<TSource,System.Boolean> System.Linq.Enumerable/WhereSelectListIterator`2::predicate
	Func_2_t99409DECFF50F0FA9B427C863AC6C99C66E6F9F8 * ___predicate_4;
	// System.Func`2<TSource,TResult> System.Linq.Enumerable/WhereSelectListIterator`2::selector
	Func_2_t32F4E81162C0EB5B67EF4324ABCC54A453AB7B22 * ___selector_5;
	// System.Collections.Generic.List`1/Enumerator<TSource> System.Linq.Enumerable/WhereSelectListIterator`2::enumerator
	Enumerator_tB6009981BD4E3881E3EC83627255A24198F902D6  ___enumerator_6;

public:
	inline static int32_t get_offset_of_source_3() { return static_cast<int32_t>(offsetof(WhereSelectListIterator_2_tFD5E5F4E072C47EE9200C7D42018559EEAA4E0CD, ___source_3)); }
	inline List_1_t3F94120C77410A62EAE48421CF166B83AB95A2F5 * get_source_3() const { return ___source_3; }
	inline List_1_t3F94120C77410A62EAE48421CF166B83AB95A2F5 ** get_address_of_source_3() { return &___source_3; }
	inline void set_source_3(List_1_t3F94120C77410A62EAE48421CF166B83AB95A2F5 * value)
	{
		___source_3 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___source_3), (void*)value);
	}

	inline static int32_t get_offset_of_predicate_4() { return static_cast<int32_t>(offsetof(WhereSelectListIterator_2_tFD5E5F4E072C47EE9200C7D42018559EEAA4E0CD, ___predicate_4)); }
	inline Func_2_t99409DECFF50F0FA9B427C863AC6C99C66E6F9F8 * get_predicate_4() const { return ___predicate_4; }
	inline Func_2_t99409DECFF50F0FA9B427C863AC6C99C66E6F9F8 ** get_address_of_predicate_4() { return &___predicate_4; }
	inline void set_predicate_4(Func_2_t99409DECFF50F0FA9B427C863AC6C99C66E6F9F8 * value)
	{
		___predicate_4 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___predicate_4), (void*)value);
	}

	inline static int32_t get_offset_of_selector_5() { return static_cast<int32_t>(offsetof(WhereSelectListIterator_2_tFD5E5F4E072C47EE9200C7D42018559EEAA4E0CD, ___selector_5)); }
	inline Func_2_t32F4E81162C0EB5B67EF4324ABCC54A453AB7B22 * get_selector_5() const { return ___selector_5; }
	inline Func_2_t32F4E81162C0EB5B67EF4324ABCC54A453AB7B22 ** get_address_of_selector_5() { return &___selector_5; }
	inline void set_selector_5(Func_2_t32F4E81162C0EB5B67EF4324ABCC54A453AB7B22 * value)
	{
		___selector_5 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___selector_5), (void*)value);
	}

	inline static int32_t get_offset_of_enumerator_6() { return static_cast<int32_t>(offsetof(WhereSelectListIterator_2_tFD5E5F4E072C47EE9200C7D42018559EEAA4E0CD, ___enumerator_6)); }
	inline Enumerator_tB6009981BD4E3881E3EC83627255A24198F902D6  get_enumerator_6() const { return ___enumerator_6; }
	inline Enumerator_tB6009981BD4E3881E3EC83627255A24198F902D6 * get_address_of_enumerator_6() { return &___enumerator_6; }
	inline void set_enumerator_6(Enumerator_tB6009981BD4E3881E3EC83627255A24198F902D6  value)
	{
		___enumerator_6 = value;
		Il2CppCodeGenWriteBarrier((void**)&(((&___enumerator_6))->___list_0), (void*)NULL);
		#if IL2CPP_ENABLE_STRICT_WRITE_BARRIERS
		Il2CppCodeGenWriteBarrier((void**)&(((&___enumerator_6))->___current_3), (void*)NULL);
		#endif
	}
};


// System.Linq.Enumerable/WhereSelectListIterator`2<System.Object,System.Int32>
struct WhereSelectListIterator_2_tA7C52B3E46CAC7800298BB868DD54565FDCB75B6  : public Iterator_1_tCFFC952B03DBE4E956DE317DB9704D936AEA2379
{
public:
	// System.Collections.Generic.List`1<TSource> System.Linq.Enumerable/WhereSelectListIterator`2::source
	List_1_t3F94120C77410A62EAE48421CF166B83AB95A2F5 * ___source_3;
	// System.Func`2<TSource,System.Boolean> System.Linq.Enumerable/WhereSelectListIterator`2::predicate
	Func_2_t99409DECFF50F0FA9B427C863AC6C99C66E6F9F8 * ___predicate_4;
	// System.Func`2<TSource,TResult> System.Linq.Enumerable/WhereSelectListIterator`2::selector
	Func_2_t0CEE9D1C856153BA9C23BB9D7E929D577AF37A2C * ___selector_5;
	// System.Collections.Generic.List`1/Enumerator<TSource> System.Linq.Enumerable/WhereSelectListIterator`2::enumerator
	Enumerator_tB6009981BD4E3881E3EC83627255A24198F902D6  ___enumerator_6;

public:
	inline static int32_t get_offset_of_source_3() { return static_cast<int32_t>(offsetof(WhereSelectListIterator_2_tA7C52B3E46CAC7800298BB868DD54565FDCB75B6, ___source_3)); }
	inline List_1_t3F94120C77410A62EAE48421CF166B83AB95A2F5 * get_source_3() const { return ___source_3; }
	inline List_1_t3F94120C77410A62EAE48421CF166B83AB95A2F5 ** get_address_of_source_3() { return &___source_3; }
	inline void set_source_3(List_1_t3F94120C77410A62EAE48421CF166B83AB95A2F5 * value)
	{
		___source_3 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___source_3), (void*)value);
	}

	inline static int32_t get_offset_of_predicate_4() { return static_cast<int32_t>(offsetof(WhereSelectListIterator_2_tA7C52B3E46CAC7800298BB868DD54565FDCB75B6, ___predicate_4)); }
	inline Func_2_t99409DECFF50F0FA9B427C863AC6C99C66E6F9F8 * get_predicate_4() const { return ___predicate_4; }
	inline Func_2_t99409DECFF50F0FA9B427C863AC6C99C66E6F9F8 ** get_address_of_predicate_4() { return &___predicate_4; }
	inline void set_predicate_4(Func_2_t99409DECFF50F0FA9B427C863AC6C99C66E6F9F8 * value)
	{
		___predicate_4 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___predicate_4), (void*)value);
	}

	inline static int32_t get_offset_of_selector_5() { return static_cast<int32_t>(offsetof(WhereSelectListIterator_2_tA7C52B3E46CAC7800298BB868DD54565FDCB75B6, ___selector_5)); }
	inline Func_2_t0CEE9D1C856153BA9C23BB9D7E929D577AF37A2C * get_selector_5() const { return ___selector_5; }
	inline Func_2_t0CEE9D1C856153BA9C23BB9D7E929D577AF37A2C ** get_address_of_selector_5() { return &___selector_5; }
	inline void set_selector_5(Func_2_t0CEE9D1C856153BA9C23BB9D7E929D577AF37A2C * value)
	{
		___selector_5 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___selector_5), (void*)value);
	}

	inline static int32_t get_offset_of_enumerator_6() { return static_cast<int32_t>(offsetof(WhereSelectListIterator_2_tA7C52B3E46CAC7800298BB868DD54565FDCB75B6, ___enumerator_6)); }
	inline Enumerator_tB6009981BD4E3881E3EC83627255A24198F902D6  get_enumerator_6() const { return ___enumerator_6; }
	inline Enumerator_tB6009981BD4E3881E3EC83627255A24198F902D6 * get_address_of_enumerator_6() { return &___enumerator_6; }
	inline void set_enumerator_6(Enumerator_tB6009981BD4E3881E3EC83627255A24198F902D6  value)
	{
		___enumerator_6 = value;
		Il2CppCodeGenWriteBarrier((void**)&(((&___enumerator_6))->___list_0), (void*)NULL);
		#if IL2CPP_ENABLE_STRICT_WRITE_BARRIERS
		Il2CppCodeGenWriteBarrier((void**)&(((&___enumerator_6))->___current_3), (void*)NULL);
		#endif
	}
};


// System.Linq.Enumerable/WhereSelectListIterator`2<System.Object,System.Int64>
struct WhereSelectListIterator_2_tB72C4254D904FF99DDF6A7B544158C7E96DF5323  : public Iterator_1_tF88FA02D56A55D26D525180DE0108FA4F019BECE
{
public:
	// System.Collections.Generic.List`1<TSource> System.Linq.Enumerable/WhereSelectListIterator`2::source
	List_1_t3F94120C77410A62EAE48421CF166B83AB95A2F5 * ___source_3;
	// System.Func`2<TSource,System.Boolean> System.Linq.Enumerable/WhereSelectListIterator`2::predicate
	Func_2_t99409DECFF50F0FA9B427C863AC6C99C66E6F9F8 * ___predicate_4;
	// System.Func`2<TSource,TResult> System.Linq.Enumerable/WhereSelectListIterator`2::selector
	Func_2_tCA3E9A68051723CDABE44FC0BAE52FE7599059D6 * ___selector_5;
	// System.Collections.Generic.List`1/Enumerator<TSource> System.Linq.Enumerable/WhereSelectListIterator`2::enumerator
	Enumerator_tB6009981BD4E3881E3EC83627255A24198F902D6  ___enumerator_6;

public:
	inline static int32_t get_offset_of_source_3() { return static_cast<int32_t>(offsetof(WhereSelectListIterator_2_tB72C4254D904FF99DDF6A7B544158C7E96DF5323, ___source_3)); }
	inline List_1_t3F94120C77410A62EAE48421CF166B83AB95A2F5 * get_source_3() const { return ___source_3; }
	inline List_1_t3F94120C77410A62EAE48421CF166B83AB95A2F5 ** get_address_of_source_3() { return &___source_3; }
	inline void set_source_3(List_1_t3F94120C77410A62EAE48421CF166B83AB95A2F5 * value)
	{
		___source_3 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___source_3), (void*)value);
	}

	inline static int32_t get_offset_of_predicate_4() { return static_cast<int32_t>(offsetof(WhereSelectListIterator_2_tB72C4254D904FF99DDF6A7B544158C7E96DF5323, ___predicate_4)); }
	inline Func_2_t99409DECFF50F0FA9B427C863AC6C99C66E6F9F8 * get_predicate_4() const { return ___predicate_4; }
	inline Func_2_t99409DECFF50F0FA9B427C863AC6C99C66E6F9F8 ** get_address_of_predicate_4() { return &___predicate_4; }
	inline void set_predicate_4(Func_2_t99409DECFF50F0FA9B427C863AC6C99C66E6F9F8 * value)
	{
		___predicate_4 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___predicate_4), (void*)value);
	}

	inline static int32_t get_offset_of_selector_5() { return static_cast<int32_t>(offsetof(WhereSelectListIterator_2_tB72C4254D904FF99DDF6A7B544158C7E96DF5323, ___selector_5)); }
	inline Func_2_tCA3E9A68051723CDABE44FC0BAE52FE7599059D6 * get_selector_5() const { return ___selector_5; }
	inline Func_2_tCA3E9A68051723CDABE44FC0BAE52FE7599059D6 ** get_address_of_selector_5() { return &___selector_5; }
	inline void set_selector_5(Func_2_tCA3E9A68051723CDABE44FC0BAE52FE7599059D6 * value)
	{
		___selector_5 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___selector_5), (void*)value);
	}

	inline static int32_t get_offset_of_enumerator_6() { return static_cast<int32_t>(offsetof(WhereSelectListIterator_2_tB72C4254D904FF99DDF6A7B544158C7E96DF5323, ___enumerator_6)); }
	inline Enumerator_tB6009981BD4E3881E3EC83627255A24198F902D6  get_enumerator_6() const { return ___enumerator_6; }
	inline Enumerator_tB6009981BD4E3881E3EC83627255A24198F902D6 * get_address_of_enumerator_6() { return &___enumerator_6; }
	inline void set_enumerator_6(Enumerator_tB6009981BD4E3881E3EC83627255A24198F902D6  value)
	{
		___enumerator_6 = value;
		Il2CppCodeGenWriteBarrier((void**)&(((&___enumerator_6))->___list_0), (void*)NULL);
		#if IL2CPP_ENABLE_STRICT_WRITE_BARRIERS
		Il2CppCodeGenWriteBarrier((void**)&(((&___enumerator_6))->___current_3), (void*)NULL);
		#endif
	}
};


// System.Linq.Enumerable/WhereSelectListIterator`2<System.Object,System.Object>
struct WhereSelectListIterator_2_t85B78DFF0573BC95A62C79D6088FA39DFEBE1AF2  : public Iterator_1_t674ABE41CF4096D4BE4D51E21FEBDADBF74CC279
{
public:
	// System.Collections.Generic.List`1<TSource> System.Linq.Enumerable/WhereSelectListIterator`2::source
	List_1_t3F94120C77410A62EAE48421CF166B83AB95A2F5 * ___source_3;
	// System.Func`2<TSource,System.Boolean> System.Linq.Enumerable/WhereSelectListIterator`2::predicate
	Func_2_t99409DECFF50F0FA9B427C863AC6C99C66E6F9F8 * ___predicate_4;
	// System.Func`2<TSource,TResult> System.Linq.Enumerable/WhereSelectListIterator`2::selector
	Func_2_tFF5BB8F40A35B1BEA00D4EBBC6CBE7184A584436 * ___selector_5;
	// System.Collections.Generic.List`1/Enumerator<TSource> System.Linq.Enumerable/WhereSelectListIterator`2::enumerator
	Enumerator_tB6009981BD4E3881E3EC83627255A24198F902D6  ___enumerator_6;

public:
	inline static int32_t get_offset_of_source_3() { return static_cast<int32_t>(offsetof(WhereSelectListIterator_2_t85B78DFF0573BC95A62C79D6088FA39DFEBE1AF2, ___source_3)); }
	inline List_1_t3F94120C77410A62EAE48421CF166B83AB95A2F5 * get_source_3() const { return ___source_3; }
	inline List_1_t3F94120C77410A62EAE48421CF166B83AB95A2F5 ** get_address_of_source_3() { return &___source_3; }
	inline void set_source_3(List_1_t3F94120C77410A62EAE48421CF166B83AB95A2F5 * value)
	{
		___source_3 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___source_3), (void*)value);
	}

	inline static int32_t get_offset_of_predicate_4() { return static_cast<int32_t>(offsetof(WhereSelectListIterator_2_t85B78DFF0573BC95A62C79D6088FA39DFEBE1AF2, ___predicate_4)); }
	inline Func_2_t99409DECFF50F0FA9B427C863AC6C99C66E6F9F8 * get_predicate_4() const { return ___predicate_4; }
	inline Func_2_t99409DECFF50F0FA9B427C863AC6C99C66E6F9F8 ** get_address_of_predicate_4() { return &___predicate_4; }
	inline void set_predicate_4(Func_2_t99409DECFF50F0FA9B427C863AC6C99C66E6F9F8 * value)
	{
		___predicate_4 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___predicate_4), (void*)value);
	}

	inline static int32_t get_offset_of_selector_5() { return static_cast<int32_t>(offsetof(WhereSelectListIterator_2_t85B78DFF0573BC95A62C79D6088FA39DFEBE1AF2, ___selector_5)); }
	inline Func_2_tFF5BB8F40A35B1BEA00D4EBBC6CBE7184A584436 * get_selector_5() const { return ___selector_5; }
	inline Func_2_tFF5BB8F40A35B1BEA00D4EBBC6CBE7184A584436 ** get_address_of_selector_5() { return &___selector_5; }
	inline void set_selector_5(Func_2_tFF5BB8F40A35B1BEA00D4EBBC6CBE7184A584436 * value)
	{
		___selector_5 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___selector_5), (void*)value);
	}

	inline static int32_t get_offset_of_enumerator_6() { return static_cast<int32_t>(offsetof(WhereSelectListIterator_2_t85B78DFF0573BC95A62C79D6088FA39DFEBE1AF2, ___enumerator_6)); }
	inline Enumerator_tB6009981BD4E3881E3EC83627255A24198F902D6  get_enumerator_6() const { return ___enumerator_6; }
	inline Enumerator_tB6009981BD4E3881E3EC83627255A24198F902D6 * get_address_of_enumerator_6() { return &___enumerator_6; }
	inline void set_enumerator_6(Enumerator_tB6009981BD4E3881E3EC83627255A24198F902D6  value)
	{
		___enumerator_6 = value;
		Il2CppCodeGenWriteBarrier((void**)&(((&___enumerator_6))->___list_0), (void*)NULL);
		#if IL2CPP_ENABLE_STRICT_WRITE_BARRIERS
		Il2CppCodeGenWriteBarrier((void**)&(((&___enumerator_6))->___current_3), (void*)NULL);
		#endif
	}
};


// System.Linq.Enumerable/WhereSelectListIterator`2<System.Object,System.Single>
struct WhereSelectListIterator_2_t20DB17268C20F9E95977E2485885C2547B573A2F  : public Iterator_1_t859CAAB8DD3B63D3758E13D2802ED7523B331199
{
public:
	// System.Collections.Generic.List`1<TSource> System.Linq.Enumerable/WhereSelectListIterator`2::source
	List_1_t3F94120C77410A62EAE48421CF166B83AB95A2F5 * ___source_3;
	// System.Func`2<TSource,System.Boolean> System.Linq.Enumerable/WhereSelectListIterator`2::predicate
	Func_2_t99409DECFF50F0FA9B427C863AC6C99C66E6F9F8 * ___predicate_4;
	// System.Func`2<TSource,TResult> System.Linq.Enumerable/WhereSelectListIterator`2::selector
	Func_2_t78F21BB7B6C7D754A8C4D71ACB39668A8F967BA1 * ___selector_5;
	// System.Collections.Generic.List`1/Enumerator<TSource> System.Linq.Enumerable/WhereSelectListIterator`2::enumerator
	Enumerator_tB6009981BD4E3881E3EC83627255A24198F902D6  ___enumerator_6;

public:
	inline static int32_t get_offset_of_source_3() { return static_cast<int32_t>(offsetof(WhereSelectListIterator_2_t20DB17268C20F9E95977E2485885C2547B573A2F, ___source_3)); }
	inline List_1_t3F94120C77410A62EAE48421CF166B83AB95A2F5 * get_source_3() const { return ___source_3; }
	inline List_1_t3F94120C77410A62EAE48421CF166B83AB95A2F5 ** get_address_of_source_3() { return &___source_3; }
	inline void set_source_3(List_1_t3F94120C77410A62EAE48421CF166B83AB95A2F5 * value)
	{
		___source_3 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___source_3), (void*)value);
	}

	inline static int32_t get_offset_of_predicate_4() { return static_cast<int32_t>(offsetof(WhereSelectListIterator_2_t20DB17268C20F9E95977E2485885C2547B573A2F, ___predicate_4)); }
	inline Func_2_t99409DECFF50F0FA9B427C863AC6C99C66E6F9F8 * get_predicate_4() const { return ___predicate_4; }
	inline Func_2_t99409DECFF50F0FA9B427C863AC6C99C66E6F9F8 ** get_address_of_predicate_4() { return &___predicate_4; }
	inline void set_predicate_4(Func_2_t99409DECFF50F0FA9B427C863AC6C99C66E6F9F8 * value)
	{
		___predicate_4 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___predicate_4), (void*)value);
	}

	inline static int32_t get_offset_of_selector_5() { return static_cast<int32_t>(offsetof(WhereSelectListIterator_2_t20DB17268C20F9E95977E2485885C2547B573A2F, ___selector_5)); }
	inline Func_2_t78F21BB7B6C7D754A8C4D71ACB39668A8F967BA1 * get_selector_5() const { return ___selector_5; }
	inline Func_2_t78F21BB7B6C7D754A8C4D71ACB39668A8F967BA1 ** get_address_of_selector_5() { return &___selector_5; }
	inline void set_selector_5(Func_2_t78F21BB7B6C7D754A8C4D71ACB39668A8F967BA1 * value)
	{
		___selector_5 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___selector_5), (void*)value);
	}

	inline static int32_t get_offset_of_enumerator_6() { return static_cast<int32_t>(offsetof(WhereSelectListIterator_2_t20DB17268C20F9E95977E2485885C2547B573A2F, ___enumerator_6)); }
	inline Enumerator_tB6009981BD4E3881E3EC83627255A24198F902D6  get_enumerator_6() const { return ___enumerator_6; }
	inline Enumerator_tB6009981BD4E3881E3EC83627255A24198F902D6 * get_address_of_enumerator_6() { return &___enumerator_6; }
	inline void set_enumerator_6(Enumerator_tB6009981BD4E3881E3EC83627255A24198F902D6  value)
	{
		___enumerator_6 = value;
		Il2CppCodeGenWriteBarrier((void**)&(((&___enumerator_6))->___list_0), (void*)NULL);
		#if IL2CPP_ENABLE_STRICT_WRITE_BARRIERS
		Il2CppCodeGenWriteBarrier((void**)&(((&___enumerator_6))->___current_3), (void*)NULL);
		#endif
	}
};


// System.Linq.Enumerable/WhereSelectListIterator`2<System.Single,System.Object>
struct WhereSelectListIterator_2_t77C04C3B7AD0F11B52AC864B3B1635FBFC5D2259  : public Iterator_1_t674ABE41CF4096D4BE4D51E21FEBDADBF74CC279
{
public:
	// System.Collections.Generic.List`1<TSource> System.Linq.Enumerable/WhereSelectListIterator`2::source
	List_1_t6726F9309570A0BDC5D42E10777F3E2931C487AA * ___source_3;
	// System.Func`2<TSource,System.Boolean> System.Linq.Enumerable/WhereSelectListIterator`2::predicate
	Func_2_t7214BC9C9A47482C751067B9A197D164F4041A3A * ___predicate_4;
	// System.Func`2<TSource,TResult> System.Linq.Enumerable/WhereSelectListIterator`2::selector
	Func_2_tE11BDF71BCB314E58F1A9CFC9DAE08A5F717E2A0 * ___selector_5;
	// System.Collections.Generic.List`1/Enumerator<TSource> System.Linq.Enumerable/WhereSelectListIterator`2::enumerator
	Enumerator_tC1FD01C8BB5327D442D71FD022B4338ACD701783  ___enumerator_6;

public:
	inline static int32_t get_offset_of_source_3() { return static_cast<int32_t>(offsetof(WhereSelectListIterator_2_t77C04C3B7AD0F11B52AC864B3B1635FBFC5D2259, ___source_3)); }
	inline List_1_t6726F9309570A0BDC5D42E10777F3E2931C487AA * get_source_3() const { return ___source_3; }
	inline List_1_t6726F9309570A0BDC5D42E10777F3E2931C487AA ** get_address_of_source_3() { return &___source_3; }
	inline void set_source_3(List_1_t6726F9309570A0BDC5D42E10777F3E2931C487AA * value)
	{
		___source_3 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___source_3), (void*)value);
	}

	inline static int32_t get_offset_of_predicate_4() { return static_cast<int32_t>(offsetof(WhereSelectListIterator_2_t77C04C3B7AD0F11B52AC864B3B1635FBFC5D2259, ___predicate_4)); }
	inline Func_2_t7214BC9C9A47482C751067B9A197D164F4041A3A * get_predicate_4() const { return ___predicate_4; }
	inline Func_2_t7214BC9C9A47482C751067B9A197D164F4041A3A ** get_address_of_predicate_4() { return &___predicate_4; }
	inline void set_predicate_4(Func_2_t7214BC9C9A47482C751067B9A197D164F4041A3A * value)
	{
		___predicate_4 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___predicate_4), (void*)value);
	}

	inline static int32_t get_offset_of_selector_5() { return static_cast<int32_t>(offsetof(WhereSelectListIterator_2_t77C04C3B7AD0F11B52AC864B3B1635FBFC5D2259, ___selector_5)); }
	inline Func_2_tE11BDF71BCB314E58F1A9CFC9DAE08A5F717E2A0 * get_selector_5() const { return ___selector_5; }
	inline Func_2_tE11BDF71BCB314E58F1A9CFC9DAE08A5F717E2A0 ** get_address_of_selector_5() { return &___selector_5; }
	inline void set_selector_5(Func_2_tE11BDF71BCB314E58F1A9CFC9DAE08A5F717E2A0 * value)
	{
		___selector_5 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___selector_5), (void*)value);
	}

	inline static int32_t get_offset_of_enumerator_6() { return static_cast<int32_t>(offsetof(WhereSelectListIterator_2_t77C04C3B7AD0F11B52AC864B3B1635FBFC5D2259, ___enumerator_6)); }
	inline Enumerator_tC1FD01C8BB5327D442D71FD022B4338ACD701783  get_enumerator_6() const { return ___enumerator_6; }
	inline Enumerator_tC1FD01C8BB5327D442D71FD022B4338ACD701783 * get_address_of_enumerator_6() { return &___enumerator_6; }
	inline void set_enumerator_6(Enumerator_tC1FD01C8BB5327D442D71FD022B4338ACD701783  value)
	{
		___enumerator_6 = value;
		Il2CppCodeGenWriteBarrier((void**)&(((&___enumerator_6))->___list_0), (void*)NULL);
	}
};


// System.Collections.Concurrent.ConcurrentBag`1/WorkStealingQueue<System.Object>
struct WorkStealingQueue_t46BF20180E5A47304513625C3E005065BA4B93D7  : public RuntimeObject
{
public:
	// System.Int32 modreq(System.Runtime.CompilerServices.IsVolatile) System.Collections.Concurrent.ConcurrentBag`1/WorkStealingQueue::_headIndex
	int32_t ____headIndex_2;
	// System.Int32 modreq(System.Runtime.CompilerServices.IsVolatile) System.Collections.Concurrent.ConcurrentBag`1/WorkStealingQueue::_tailIndex
	int32_t ____tailIndex_3;
	// T[] modreq(System.Runtime.CompilerServices.IsVolatile) System.Collections.Concurrent.ConcurrentBag`1/WorkStealingQueue::_array
	ObjectU5BU5D_tC1F4EE0DB0B7300255F5FD4AF64FE4C585CF5ADE* ____array_4;
	// System.Int32 modreq(System.Runtime.CompilerServices.IsVolatile) System.Collections.Concurrent.ConcurrentBag`1/WorkStealingQueue::_mask
	int32_t ____mask_5;
	// System.Int32 System.Collections.Concurrent.ConcurrentBag`1/WorkStealingQueue::_addTakeCount
	int32_t ____addTakeCount_6;
	// System.Int32 System.Collections.Concurrent.ConcurrentBag`1/WorkStealingQueue::_stealCount
	int32_t ____stealCount_7;
	// System.Int32 modreq(System.Runtime.CompilerServices.IsVolatile) System.Collections.Concurrent.ConcurrentBag`1/WorkStealingQueue::_currentOp
	int32_t ____currentOp_8;
	// System.Boolean System.Collections.Concurrent.ConcurrentBag`1/WorkStealingQueue::_frozen
	bool ____frozen_9;
	// System.Collections.Concurrent.ConcurrentBag`1/WorkStealingQueue<T> System.Collections.Concurrent.ConcurrentBag`1/WorkStealingQueue::_nextQueue
	WorkStealingQueue_t46BF20180E5A47304513625C3E005065BA4B93D7 * ____nextQueue_10;
	// System.Int32 System.Collections.Concurrent.ConcurrentBag`1/WorkStealingQueue::_ownerThreadId
	int32_t ____ownerThreadId_11;

public:
	inline static int32_t get_offset_of__headIndex_2() { return static_cast<int32_t>(offsetof(WorkStealingQueue_t46BF20180E5A47304513625C3E005065BA4B93D7, ____headIndex_2)); }
	inline int32_t get__headIndex_2() const { return ____headIndex_2; }
	inline int32_t* get_address_of__headIndex_2() { return &____headIndex_2; }
	inline void set__headIndex_2(int32_t value)
	{
		____headIndex_2 = value;
	}

	inline static int32_t get_offset_of__tailIndex_3() { return static_cast<int32_t>(offsetof(WorkStealingQueue_t46BF20180E5A47304513625C3E005065BA4B93D7, ____tailIndex_3)); }
	inline int32_t get__tailIndex_3() const { return ____tailIndex_3; }
	inline int32_t* get_address_of__tailIndex_3() { return &____tailIndex_3; }
	inline void set__tailIndex_3(int32_t value)
	{
		____tailIndex_3 = value;
	}

	inline static int32_t get_offset_of__array_4() { return static_cast<int32_t>(offsetof(WorkStealingQueue_t46BF20180E5A47304513625C3E005065BA4B93D7, ____array_4)); }
	inline ObjectU5BU5D_tC1F4EE0DB0B7300255F5FD4AF64FE4C585CF5ADE* get__array_4() const { return ____array_4; }
	inline ObjectU5BU5D_tC1F4EE0DB0B7300255F5FD4AF64FE4C585CF5ADE** get_address_of__array_4() { return &____array_4; }
	inline void set__array_4(ObjectU5BU5D_tC1F4EE0DB0B7300255F5FD4AF64FE4C585CF5ADE* value)
	{
		____array_4 = value;
		Il2CppCodeGenWriteBarrier((void**)(&____array_4), (void*)value);
	}

	inline static int32_t get_offset_of__mask_5() { return static_cast<int32_t>(offsetof(WorkStealingQueue_t46BF20180E5A47304513625C3E005065BA4B93D7, ____mask_5)); }
	inline int32_t get__mask_5() const { return ____mask_5; }
	inline int32_t* get_address_of__mask_5() { return &____mask_5; }
	inline void set__mask_5(int32_t value)
	{
		____mask_5 = value;
	}

	inline static int32_t get_offset_of__addTakeCount_6() { return static_cast<int32_t>(offsetof(WorkStealingQueue_t46BF20180E5A47304513625C3E005065BA4B93D7, ____addTakeCount_6)); }
	inline int32_t get__addTakeCount_6() const { return ____addTakeCount_6; }
	inline int32_t* get_address_of__addTakeCount_6() { return &____addTakeCount_6; }
	inline void set__addTakeCount_6(int32_t value)
	{
		____addTakeCount_6 = value;
	}

	inline static int32_t get_offset_of__stealCount_7() { return static_cast<int32_t>(offsetof(WorkStealingQueue_t46BF20180E5A47304513625C3E005065BA4B93D7, ____stealCount_7)); }
	inline int32_t get__stealCount_7() const { return ____stealCount_7; }
	inline int32_t* get_address_of__stealCount_7() { return &____stealCount_7; }
	inline void set__stealCount_7(int32_t value)
	{
		____stealCount_7 = value;
	}

	inline static int32_t get_offset_of__currentOp_8() { return static_cast<int32_t>(offsetof(WorkStealingQueue_t46BF20180E5A47304513625C3E005065BA4B93D7, ____currentOp_8)); }
	inline int32_t get__currentOp_8() const { return ____currentOp_8; }
	inline int32_t* get_address_of__currentOp_8() { return &____currentOp_8; }
	inline void set__currentOp_8(int32_t value)
	{
		____currentOp_8 = value;
	}

	inline static int32_t get_offset_of__frozen_9() { return static_cast<int32_t>(offsetof(WorkStealingQueue_t46BF20180E5A47304513625C3E005065BA4B93D7, ____frozen_9)); }
	inline bool get__frozen_9() const { return ____frozen_9; }
	inline bool* get_address_of__frozen_9() { return &____frozen_9; }
	inline void set__frozen_9(bool value)
	{
		____frozen_9 = value;
	}

	inline static int32_t get_offset_of__nextQueue_10() { return static_cast<int32_t>(offsetof(WorkStealingQueue_t46BF20180E5A47304513625C3E005065BA4B93D7, ____nextQueue_10)); }
	inline WorkStealingQueue_t46BF20180E5A47304513625C3E005065BA4B93D7 * get__nextQueue_10() const { return ____nextQueue_10; }
	inline WorkStealingQueue_t46BF20180E5A47304513625C3E005065BA4B93D7 ** get_address_of__nextQueue_10() { return &____nextQueue_10; }
	inline void set__nextQueue_10(WorkStealingQueue_t46BF20180E5A47304513625C3E005065BA4B93D7 * value)
	{
		____nextQueue_10 = value;
		Il2CppCodeGenWriteBarrier((void**)(&____nextQueue_10), (void*)value);
	}

	inline static int32_t get_offset_of__ownerThreadId_11() { return static_cast<int32_t>(offsetof(WorkStealingQueue_t46BF20180E5A47304513625C3E005065BA4B93D7, ____ownerThreadId_11)); }
	inline int32_t get__ownerThreadId_11() const { return ____ownerThreadId_11; }
	inline int32_t* get_address_of__ownerThreadId_11() { return &____ownerThreadId_11; }
	inline void set__ownerThreadId_11(int32_t value)
	{
		____ownerThreadId_11 = value;
	}
};


// System.Linq.Parallel.CancellationState
struct CancellationState_t302EEDE088D5E82EBE9A74EE31029F9CB981E9CC  : public RuntimeObject
{
public:
	// System.Threading.CancellationTokenSource System.Linq.Parallel.CancellationState::InternalCancellationTokenSource
	CancellationTokenSource_t78B989179DE23EDD36F870FFEE20A15D6D3C65B3 * ___InternalCancellationTokenSource_0;
	// System.Threading.CancellationToken System.Linq.Parallel.CancellationState::ExternalCancellationToken
	CancellationToken_tC9D68381C9164A4BA10397257E87ADC832AF5FFD  ___ExternalCancellationToken_1;
	// System.Threading.CancellationTokenSource System.Linq.Parallel.CancellationState::MergedCancellationTokenSource
	CancellationTokenSource_t78B989179DE23EDD36F870FFEE20A15D6D3C65B3 * ___MergedCancellationTokenSource_2;
	// System.Linq.Parallel.Shared`1<System.Boolean> System.Linq.Parallel.CancellationState::TopLevelDisposedFlag
	Shared_1_t74E18ADA97BB3E28B39731FCA4223461A55BD971 * ___TopLevelDisposedFlag_3;

public:
	inline static int32_t get_offset_of_InternalCancellationTokenSource_0() { return static_cast<int32_t>(offsetof(CancellationState_t302EEDE088D5E82EBE9A74EE31029F9CB981E9CC, ___InternalCancellationTokenSource_0)); }
	inline CancellationTokenSource_t78B989179DE23EDD36F870FFEE20A15D6D3C65B3 * get_InternalCancellationTokenSource_0() const { return ___InternalCancellationTokenSource_0; }
	inline CancellationTokenSource_t78B989179DE23EDD36F870FFEE20A15D6D3C65B3 ** get_address_of_InternalCancellationTokenSource_0() { return &___InternalCancellationTokenSource_0; }
	inline void set_InternalCancellationTokenSource_0(CancellationTokenSource_t78B989179DE23EDD36F870FFEE20A15D6D3C65B3 * value)
	{
		___InternalCancellationTokenSource_0 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___InternalCancellationTokenSource_0), (void*)value);
	}

	inline static int32_t get_offset_of_ExternalCancellationToken_1() { return static_cast<int32_t>(offsetof(CancellationState_t302EEDE088D5E82EBE9A74EE31029F9CB981E9CC, ___ExternalCancellationToken_1)); }
	inline CancellationToken_tC9D68381C9164A4BA10397257E87ADC832AF5FFD  get_ExternalCancellationToken_1() const { return ___ExternalCancellationToken_1; }
	inline CancellationToken_tC9D68381C9164A4BA10397257E87ADC832AF5FFD * get_address_of_ExternalCancellationToken_1() { return &___ExternalCancellationToken_1; }
	inline void set_ExternalCancellationToken_1(CancellationToken_tC9D68381C9164A4BA10397257E87ADC832AF5FFD  value)
	{
		___ExternalCancellationToken_1 = value;
		Il2CppCodeGenWriteBarrier((void**)&(((&___ExternalCancellationToken_1))->___m_source_0), (void*)NULL);
	}

	inline static int32_t get_offset_of_MergedCancellationTokenSource_2() { return static_cast<int32_t>(offsetof(CancellationState_t302EEDE088D5E82EBE9A74EE31029F9CB981E9CC, ___MergedCancellationTokenSource_2)); }
	inline CancellationTokenSource_t78B989179DE23EDD36F870FFEE20A15D6D3C65B3 * get_MergedCancellationTokenSource_2() const { return ___MergedCancellationTokenSource_2; }
	inline CancellationTokenSource_t78B989179DE23EDD36F870FFEE20A15D6D3C65B3 ** get_address_of_MergedCancellationTokenSource_2() { return &___MergedCancellationTokenSource_2; }
	inline void set_MergedCancellationTokenSource_2(CancellationTokenSource_t78B989179DE23EDD36F870FFEE20A15D6D3C65B3 * value)
	{
		___MergedCancellationTokenSource_2 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___MergedCancellationTokenSource_2), (void*)value);
	}

	inline static int32_t get_offset_of_TopLevelDisposedFlag_3() { return static_cast<int32_t>(offsetof(CancellationState_t302EEDE088D5E82EBE9A74EE31029F9CB981E9CC, ___TopLevelDisposedFlag_3)); }
	inline Shared_1_t74E18ADA97BB3E28B39731FCA4223461A55BD971 * get_TopLevelDisposedFlag_3() const { return ___TopLevelDisposedFlag_3; }
	inline Shared_1_t74E18ADA97BB3E28B39731FCA4223461A55BD971 ** get_address_of_TopLevelDisposedFlag_3() { return &___TopLevelDisposedFlag_3; }
	inline void set_TopLevelDisposedFlag_3(Shared_1_t74E18ADA97BB3E28B39731FCA4223461A55BD971 * value)
	{
		___TopLevelDisposedFlag_3 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___TopLevelDisposedFlag_3), (void*)value);
	}
};


// UnityEngine.Experimental.Rendering.Universal.LibTessDotNet.ContourVertex
struct ContourVertex_tF9E27CB6BCC62DF5F4202153BBBECDE5E3283536 
{
public:
	// UnityEngine.Experimental.Rendering.Universal.LibTessDotNet.Vec3 UnityEngine.Experimental.Rendering.Universal.LibTessDotNet.ContourVertex::Position
	Vec3_tDD913B31171F6A37E61E4625FEA6C7901A6B1BC1  ___Position_0;
	// System.Object UnityEngine.Experimental.Rendering.Universal.LibTessDotNet.ContourVertex::Data
	RuntimeObject * ___Data_1;

public:
	inline static int32_t get_offset_of_Position_0() { return static_cast<int32_t>(offsetof(ContourVertex_tF9E27CB6BCC62DF5F4202153BBBECDE5E3283536, ___Position_0)); }
	inline Vec3_tDD913B31171F6A37E61E4625FEA6C7901A6B1BC1  get_Position_0() const { return ___Position_0; }
	inline Vec3_tDD913B31171F6A37E61E4625FEA6C7901A6B1BC1 * get_address_of_Position_0() { return &___Position_0; }
	inline void set_Position_0(Vec3_tDD913B31171F6A37E61E4625FEA6C7901A6B1BC1  value)
	{
		___Position_0 = value;
	}

	inline static int32_t get_offset_of_Data_1() { return static_cast<int32_t>(offsetof(ContourVertex_tF9E27CB6BCC62DF5F4202153BBBECDE5E3283536, ___Data_1)); }
	inline RuntimeObject * get_Data_1() const { return ___Data_1; }
	inline RuntimeObject ** get_address_of_Data_1() { return &___Data_1; }
	inline void set_Data_1(RuntimeObject * value)
	{
		___Data_1 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___Data_1), (void*)value);
	}
};

// Native definition for P/Invoke marshalling of UnityEngine.Experimental.Rendering.Universal.LibTessDotNet.ContourVertex
struct ContourVertex_tF9E27CB6BCC62DF5F4202153BBBECDE5E3283536_marshaled_pinvoke
{
	Vec3_tDD913B31171F6A37E61E4625FEA6C7901A6B1BC1  ___Position_0;
	Il2CppIUnknown* ___Data_1;
};
// Native definition for COM marshalling of UnityEngine.Experimental.Rendering.Universal.LibTessDotNet.ContourVertex
struct ContourVertex_tF9E27CB6BCC62DF5F4202153BBBECDE5E3283536_marshaled_com
{
	Vec3_tDD913B31171F6A37E61E4625FEA6C7901A6B1BC1  ___Position_0;
	Il2CppIUnknown* ___Data_1;
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

// System.Linq.Parallel.OrdinalIndexState
struct OrdinalIndexState_t2E391DF7D6EC3D221B96F71D4427789B48345801 
{
public:
	// System.Byte System.Linq.Parallel.OrdinalIndexState::value__
	uint8_t ___value___2;

public:
	inline static int32_t get_offset_of_value___2() { return static_cast<int32_t>(offsetof(OrdinalIndexState_t2E391DF7D6EC3D221B96F71D4427789B48345801, ___value___2)); }
	inline uint8_t get_value___2() const { return ___value___2; }
	inline uint8_t* get_address_of_value___2() { return &___value___2; }
	inline void set_value___2(uint8_t value)
	{
		___value___2 = value;
	}
};


// System.Linq.ParallelExecutionMode
struct ParallelExecutionMode_t6C9371655FDC696544292CFCF609DAC56EF9546C 
{
public:
	// System.Int32 System.Linq.ParallelExecutionMode::value__
	int32_t ___value___2;

public:
	inline static int32_t get_offset_of_value___2() { return static_cast<int32_t>(offsetof(ParallelExecutionMode_t6C9371655FDC696544292CFCF609DAC56EF9546C, ___value___2)); }
	inline int32_t get_value___2() const { return ___value___2; }
	inline int32_t* get_address_of_value___2() { return &___value___2; }
	inline void set_value___2(int32_t value)
	{
		___value___2 = value;
	}
};


// System.Linq.ParallelMergeOptions
struct ParallelMergeOptions_t03D0C3747103F7CF6A354607FC3DEAFF8D9AC7B7 
{
public:
	// System.Int32 System.Linq.ParallelMergeOptions::value__
	int32_t ___value___2;

public:
	inline static int32_t get_offset_of_value___2() { return static_cast<int32_t>(offsetof(ParallelMergeOptions_t03D0C3747103F7CF6A354607FC3DEAFF8D9AC7B7, ___value___2)); }
	inline int32_t get_value___2() const { return ___value___2; }
	inline int32_t* get_address_of_value___2() { return &___value___2; }
	inline void set_value___2(int32_t value)
	{
		___value___2 = value;
	}
};


// System.Threading.Tasks.TaskScheduler
struct TaskScheduler_t74FBEEEDBDD5E0088FF0EEC18F45CD866B098D5D  : public RuntimeObject
{
public:
	// System.Int32 modreq(System.Runtime.CompilerServices.IsVolatile) System.Threading.Tasks.TaskScheduler::m_taskSchedulerId
	int32_t ___m_taskSchedulerId_3;

public:
	inline static int32_t get_offset_of_m_taskSchedulerId_3() { return static_cast<int32_t>(offsetof(TaskScheduler_t74FBEEEDBDD5E0088FF0EEC18F45CD866B098D5D, ___m_taskSchedulerId_3)); }
	inline int32_t get_m_taskSchedulerId_3() const { return ___m_taskSchedulerId_3; }
	inline int32_t* get_address_of_m_taskSchedulerId_3() { return &___m_taskSchedulerId_3; }
	inline void set_m_taskSchedulerId_3(int32_t value)
	{
		___m_taskSchedulerId_3 = value;
	}
};

struct TaskScheduler_t74FBEEEDBDD5E0088FF0EEC18F45CD866B098D5D_StaticFields
{
public:
	// System.Runtime.CompilerServices.ConditionalWeakTable`2<System.Threading.Tasks.TaskScheduler,System.Object> System.Threading.Tasks.TaskScheduler::s_activeTaskSchedulers
	ConditionalWeakTable_2_t93AD246458B1FCACF9EE33160B2DB2E06AB42CD8 * ___s_activeTaskSchedulers_0;
	// System.Threading.Tasks.TaskScheduler System.Threading.Tasks.TaskScheduler::s_defaultTaskScheduler
	TaskScheduler_t74FBEEEDBDD5E0088FF0EEC18F45CD866B098D5D * ___s_defaultTaskScheduler_1;
	// System.Int32 System.Threading.Tasks.TaskScheduler::s_taskSchedulerIdCounter
	int32_t ___s_taskSchedulerIdCounter_2;
	// System.EventHandler`1<System.Threading.Tasks.UnobservedTaskExceptionEventArgs> System.Threading.Tasks.TaskScheduler::_unobservedTaskException
	EventHandler_1_t7DFDECE3AD515844324382F8BBCAC2975ABEE63A * ____unobservedTaskException_4;
	// System.Object System.Threading.Tasks.TaskScheduler::_unobservedTaskExceptionLockObject
	RuntimeObject * ____unobservedTaskExceptionLockObject_5;

public:
	inline static int32_t get_offset_of_s_activeTaskSchedulers_0() { return static_cast<int32_t>(offsetof(TaskScheduler_t74FBEEEDBDD5E0088FF0EEC18F45CD866B098D5D_StaticFields, ___s_activeTaskSchedulers_0)); }
	inline ConditionalWeakTable_2_t93AD246458B1FCACF9EE33160B2DB2E06AB42CD8 * get_s_activeTaskSchedulers_0() const { return ___s_activeTaskSchedulers_0; }
	inline ConditionalWeakTable_2_t93AD246458B1FCACF9EE33160B2DB2E06AB42CD8 ** get_address_of_s_activeTaskSchedulers_0() { return &___s_activeTaskSchedulers_0; }
	inline void set_s_activeTaskSchedulers_0(ConditionalWeakTable_2_t93AD246458B1FCACF9EE33160B2DB2E06AB42CD8 * value)
	{
		___s_activeTaskSchedulers_0 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___s_activeTaskSchedulers_0), (void*)value);
	}

	inline static int32_t get_offset_of_s_defaultTaskScheduler_1() { return static_cast<int32_t>(offsetof(TaskScheduler_t74FBEEEDBDD5E0088FF0EEC18F45CD866B098D5D_StaticFields, ___s_defaultTaskScheduler_1)); }
	inline TaskScheduler_t74FBEEEDBDD5E0088FF0EEC18F45CD866B098D5D * get_s_defaultTaskScheduler_1() const { return ___s_defaultTaskScheduler_1; }
	inline TaskScheduler_t74FBEEEDBDD5E0088FF0EEC18F45CD866B098D5D ** get_address_of_s_defaultTaskScheduler_1() { return &___s_defaultTaskScheduler_1; }
	inline void set_s_defaultTaskScheduler_1(TaskScheduler_t74FBEEEDBDD5E0088FF0EEC18F45CD866B098D5D * value)
	{
		___s_defaultTaskScheduler_1 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___s_defaultTaskScheduler_1), (void*)value);
	}

	inline static int32_t get_offset_of_s_taskSchedulerIdCounter_2() { return static_cast<int32_t>(offsetof(TaskScheduler_t74FBEEEDBDD5E0088FF0EEC18F45CD866B098D5D_StaticFields, ___s_taskSchedulerIdCounter_2)); }
	inline int32_t get_s_taskSchedulerIdCounter_2() const { return ___s_taskSchedulerIdCounter_2; }
	inline int32_t* get_address_of_s_taskSchedulerIdCounter_2() { return &___s_taskSchedulerIdCounter_2; }
	inline void set_s_taskSchedulerIdCounter_2(int32_t value)
	{
		___s_taskSchedulerIdCounter_2 = value;
	}

	inline static int32_t get_offset_of__unobservedTaskException_4() { return static_cast<int32_t>(offsetof(TaskScheduler_t74FBEEEDBDD5E0088FF0EEC18F45CD866B098D5D_StaticFields, ____unobservedTaskException_4)); }
	inline EventHandler_1_t7DFDECE3AD515844324382F8BBCAC2975ABEE63A * get__unobservedTaskException_4() const { return ____unobservedTaskException_4; }
	inline EventHandler_1_t7DFDECE3AD515844324382F8BBCAC2975ABEE63A ** get_address_of__unobservedTaskException_4() { return &____unobservedTaskException_4; }
	inline void set__unobservedTaskException_4(EventHandler_1_t7DFDECE3AD515844324382F8BBCAC2975ABEE63A * value)
	{
		____unobservedTaskException_4 = value;
		Il2CppCodeGenWriteBarrier((void**)(&____unobservedTaskException_4), (void*)value);
	}

	inline static int32_t get_offset_of__unobservedTaskExceptionLockObject_5() { return static_cast<int32_t>(offsetof(TaskScheduler_t74FBEEEDBDD5E0088FF0EEC18F45CD866B098D5D_StaticFields, ____unobservedTaskExceptionLockObject_5)); }
	inline RuntimeObject * get__unobservedTaskExceptionLockObject_5() const { return ____unobservedTaskExceptionLockObject_5; }
	inline RuntimeObject ** get_address_of__unobservedTaskExceptionLockObject_5() { return &____unobservedTaskExceptionLockObject_5; }
	inline void set__unobservedTaskExceptionLockObject_5(RuntimeObject * value)
	{
		____unobservedTaskExceptionLockObject_5 = value;
		Il2CppCodeGenWriteBarrier((void**)(&____unobservedTaskExceptionLockObject_5), (void*)value);
	}
};


// System.Collections.Generic.List`1/Enumerator<UnityEngine.Experimental.Rendering.Universal.LibTessDotNet.ContourVertex>
struct Enumerator_t0A364062D6EEDD0B306D570939B5709AEAA88D11 
{
public:
	// System.Collections.Generic.List`1<T> System.Collections.Generic.List`1/Enumerator::list
	List_1_t793A994CE01AE29FEE85500B7E3540653BFE5A0C * ___list_0;
	// System.Int32 System.Collections.Generic.List`1/Enumerator::index
	int32_t ___index_1;
	// System.Int32 System.Collections.Generic.List`1/Enumerator::version
	int32_t ___version_2;
	// T System.Collections.Generic.List`1/Enumerator::current
	ContourVertex_tF9E27CB6BCC62DF5F4202153BBBECDE5E3283536  ___current_3;

public:
	inline static int32_t get_offset_of_list_0() { return static_cast<int32_t>(offsetof(Enumerator_t0A364062D6EEDD0B306D570939B5709AEAA88D11, ___list_0)); }
	inline List_1_t793A994CE01AE29FEE85500B7E3540653BFE5A0C * get_list_0() const { return ___list_0; }
	inline List_1_t793A994CE01AE29FEE85500B7E3540653BFE5A0C ** get_address_of_list_0() { return &___list_0; }
	inline void set_list_0(List_1_t793A994CE01AE29FEE85500B7E3540653BFE5A0C * value)
	{
		___list_0 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___list_0), (void*)value);
	}

	inline static int32_t get_offset_of_index_1() { return static_cast<int32_t>(offsetof(Enumerator_t0A364062D6EEDD0B306D570939B5709AEAA88D11, ___index_1)); }
	inline int32_t get_index_1() const { return ___index_1; }
	inline int32_t* get_address_of_index_1() { return &___index_1; }
	inline void set_index_1(int32_t value)
	{
		___index_1 = value;
	}

	inline static int32_t get_offset_of_version_2() { return static_cast<int32_t>(offsetof(Enumerator_t0A364062D6EEDD0B306D570939B5709AEAA88D11, ___version_2)); }
	inline int32_t get_version_2() const { return ___version_2; }
	inline int32_t* get_address_of_version_2() { return &___version_2; }
	inline void set_version_2(int32_t value)
	{
		___version_2 = value;
	}

	inline static int32_t get_offset_of_current_3() { return static_cast<int32_t>(offsetof(Enumerator_t0A364062D6EEDD0B306D570939B5709AEAA88D11, ___current_3)); }
	inline ContourVertex_tF9E27CB6BCC62DF5F4202153BBBECDE5E3283536  get_current_3() const { return ___current_3; }
	inline ContourVertex_tF9E27CB6BCC62DF5F4202153BBBECDE5E3283536 * get_address_of_current_3() { return &___current_3; }
	inline void set_current_3(ContourVertex_tF9E27CB6BCC62DF5F4202153BBBECDE5E3283536  value)
	{
		___current_3 = value;
		Il2CppCodeGenWriteBarrier((void**)&(((&___current_3))->___Data_1), (void*)NULL);
	}
};


// System.Linq.Enumerable/Iterator`1<System.Nullable`1<System.Decimal>>
struct Iterator_1_tC3AC38DE0A9857A77F64882DC49BB78318A5EF00  : public RuntimeObject
{
public:
	// System.Int32 System.Linq.Enumerable/Iterator`1::threadId
	int32_t ___threadId_0;
	// System.Int32 System.Linq.Enumerable/Iterator`1::state
	int32_t ___state_1;
	// TSource System.Linq.Enumerable/Iterator`1::current
	Nullable_1_tD7EB7EB39E548910812AA4DC702F9C7E3E84A84E  ___current_2;

public:
	inline static int32_t get_offset_of_threadId_0() { return static_cast<int32_t>(offsetof(Iterator_1_tC3AC38DE0A9857A77F64882DC49BB78318A5EF00, ___threadId_0)); }
	inline int32_t get_threadId_0() const { return ___threadId_0; }
	inline int32_t* get_address_of_threadId_0() { return &___threadId_0; }
	inline void set_threadId_0(int32_t value)
	{
		___threadId_0 = value;
	}

	inline static int32_t get_offset_of_state_1() { return static_cast<int32_t>(offsetof(Iterator_1_tC3AC38DE0A9857A77F64882DC49BB78318A5EF00, ___state_1)); }
	inline int32_t get_state_1() const { return ___state_1; }
	inline int32_t* get_address_of_state_1() { return &___state_1; }
	inline void set_state_1(int32_t value)
	{
		___state_1 = value;
	}

	inline static int32_t get_offset_of_current_2() { return static_cast<int32_t>(offsetof(Iterator_1_tC3AC38DE0A9857A77F64882DC49BB78318A5EF00, ___current_2)); }
	inline Nullable_1_tD7EB7EB39E548910812AA4DC702F9C7E3E84A84E  get_current_2() const { return ___current_2; }
	inline Nullable_1_tD7EB7EB39E548910812AA4DC702F9C7E3E84A84E * get_address_of_current_2() { return &___current_2; }
	inline void set_current_2(Nullable_1_tD7EB7EB39E548910812AA4DC702F9C7E3E84A84E  value)
	{
		___current_2 = value;
	}
};


// System.Nullable`1<System.Linq.ParallelExecutionMode>
struct Nullable_1_tD63DBB63DE91B264EBCACCCAE3F99B2F8C1585CF 
{
public:
	// T System.Nullable`1::value
	int32_t ___value_0;
	// System.Boolean System.Nullable`1::has_value
	bool ___has_value_1;

public:
	inline static int32_t get_offset_of_value_0() { return static_cast<int32_t>(offsetof(Nullable_1_tD63DBB63DE91B264EBCACCCAE3F99B2F8C1585CF, ___value_0)); }
	inline int32_t get_value_0() const { return ___value_0; }
	inline int32_t* get_address_of_value_0() { return &___value_0; }
	inline void set_value_0(int32_t value)
	{
		___value_0 = value;
	}

	inline static int32_t get_offset_of_has_value_1() { return static_cast<int32_t>(offsetof(Nullable_1_tD63DBB63DE91B264EBCACCCAE3F99B2F8C1585CF, ___has_value_1)); }
	inline bool get_has_value_1() const { return ___has_value_1; }
	inline bool* get_address_of_has_value_1() { return &___has_value_1; }
	inline void set_has_value_1(bool value)
	{
		___has_value_1 = value;
	}
};


// System.Nullable`1<System.Linq.ParallelMergeOptions>
struct Nullable_1_tC765C1F31F62FF67DE02D2D0A514159758445B48 
{
public:
	// T System.Nullable`1::value
	int32_t ___value_0;
	// System.Boolean System.Nullable`1::has_value
	bool ___has_value_1;

public:
	inline static int32_t get_offset_of_value_0() { return static_cast<int32_t>(offsetof(Nullable_1_tC765C1F31F62FF67DE02D2D0A514159758445B48, ___value_0)); }
	inline int32_t get_value_0() const { return ___value_0; }
	inline int32_t* get_address_of_value_0() { return &___value_0; }
	inline void set_value_0(int32_t value)
	{
		___value_0 = value;
	}

	inline static int32_t get_offset_of_has_value_1() { return static_cast<int32_t>(offsetof(Nullable_1_tC765C1F31F62FF67DE02D2D0A514159758445B48, ___has_value_1)); }
	inline bool get_has_value_1() const { return ___has_value_1; }
	inline bool* get_address_of_has_value_1() { return &___has_value_1; }
	inline void set_has_value_1(bool value)
	{
		___has_value_1 = value;
	}
};


// System.Linq.Parallel.PartitionedStreamMerger`1<System.Object>
struct PartitionedStreamMerger_1_tF29B032A14C6BEEEFD1400E4349350A1F87F5364  : public RuntimeObject
{
public:
	// System.Boolean System.Linq.Parallel.PartitionedStreamMerger`1::_forEffectMerge
	bool ____forEffectMerge_0;
	// System.Linq.ParallelMergeOptions System.Linq.Parallel.PartitionedStreamMerger`1::_mergeOptions
	int32_t ____mergeOptions_1;
	// System.Boolean System.Linq.Parallel.PartitionedStreamMerger`1::_isOrdered
	bool ____isOrdered_2;
	// System.Linq.Parallel.MergeExecutor`1<TOutput> System.Linq.Parallel.PartitionedStreamMerger`1::_mergeExecutor
	MergeExecutor_1_t53031849DE058B85127E8DDEEB6483EA88655E2D * ____mergeExecutor_3;
	// System.Threading.Tasks.TaskScheduler System.Linq.Parallel.PartitionedStreamMerger`1::_taskScheduler
	TaskScheduler_t74FBEEEDBDD5E0088FF0EEC18F45CD866B098D5D * ____taskScheduler_4;
	// System.Int32 System.Linq.Parallel.PartitionedStreamMerger`1::_queryId
	int32_t ____queryId_5;
	// System.Linq.Parallel.CancellationState System.Linq.Parallel.PartitionedStreamMerger`1::_cancellationState
	CancellationState_t302EEDE088D5E82EBE9A74EE31029F9CB981E9CC * ____cancellationState_6;

public:
	inline static int32_t get_offset_of__forEffectMerge_0() { return static_cast<int32_t>(offsetof(PartitionedStreamMerger_1_tF29B032A14C6BEEEFD1400E4349350A1F87F5364, ____forEffectMerge_0)); }
	inline bool get__forEffectMerge_0() const { return ____forEffectMerge_0; }
	inline bool* get_address_of__forEffectMerge_0() { return &____forEffectMerge_0; }
	inline void set__forEffectMerge_0(bool value)
	{
		____forEffectMerge_0 = value;
	}

	inline static int32_t get_offset_of__mergeOptions_1() { return static_cast<int32_t>(offsetof(PartitionedStreamMerger_1_tF29B032A14C6BEEEFD1400E4349350A1F87F5364, ____mergeOptions_1)); }
	inline int32_t get__mergeOptions_1() const { return ____mergeOptions_1; }
	inline int32_t* get_address_of__mergeOptions_1() { return &____mergeOptions_1; }
	inline void set__mergeOptions_1(int32_t value)
	{
		____mergeOptions_1 = value;
	}

	inline static int32_t get_offset_of__isOrdered_2() { return static_cast<int32_t>(offsetof(PartitionedStreamMerger_1_tF29B032A14C6BEEEFD1400E4349350A1F87F5364, ____isOrdered_2)); }
	inline bool get__isOrdered_2() const { return ____isOrdered_2; }
	inline bool* get_address_of__isOrdered_2() { return &____isOrdered_2; }
	inline void set__isOrdered_2(bool value)
	{
		____isOrdered_2 = value;
	}

	inline static int32_t get_offset_of__mergeExecutor_3() { return static_cast<int32_t>(offsetof(PartitionedStreamMerger_1_tF29B032A14C6BEEEFD1400E4349350A1F87F5364, ____mergeExecutor_3)); }
	inline MergeExecutor_1_t53031849DE058B85127E8DDEEB6483EA88655E2D * get__mergeExecutor_3() const { return ____mergeExecutor_3; }
	inline MergeExecutor_1_t53031849DE058B85127E8DDEEB6483EA88655E2D ** get_address_of__mergeExecutor_3() { return &____mergeExecutor_3; }
	inline void set__mergeExecutor_3(MergeExecutor_1_t53031849DE058B85127E8DDEEB6483EA88655E2D * value)
	{
		____mergeExecutor_3 = value;
		Il2CppCodeGenWriteBarrier((void**)(&____mergeExecutor_3), (void*)value);
	}

	inline static int32_t get_offset_of__taskScheduler_4() { return static_cast<int32_t>(offsetof(PartitionedStreamMerger_1_tF29B032A14C6BEEEFD1400E4349350A1F87F5364, ____taskScheduler_4)); }
	inline TaskScheduler_t74FBEEEDBDD5E0088FF0EEC18F45CD866B098D5D * get__taskScheduler_4() const { return ____taskScheduler_4; }
	inline TaskScheduler_t74FBEEEDBDD5E0088FF0EEC18F45CD866B098D5D ** get_address_of__taskScheduler_4() { return &____taskScheduler_4; }
	inline void set__taskScheduler_4(TaskScheduler_t74FBEEEDBDD5E0088FF0EEC18F45CD866B098D5D * value)
	{
		____taskScheduler_4 = value;
		Il2CppCodeGenWriteBarrier((void**)(&____taskScheduler_4), (void*)value);
	}

	inline static int32_t get_offset_of__queryId_5() { return static_cast<int32_t>(offsetof(PartitionedStreamMerger_1_tF29B032A14C6BEEEFD1400E4349350A1F87F5364, ____queryId_5)); }
	inline int32_t get__queryId_5() const { return ____queryId_5; }
	inline int32_t* get_address_of__queryId_5() { return &____queryId_5; }
	inline void set__queryId_5(int32_t value)
	{
		____queryId_5 = value;
	}

	inline static int32_t get_offset_of__cancellationState_6() { return static_cast<int32_t>(offsetof(PartitionedStreamMerger_1_tF29B032A14C6BEEEFD1400E4349350A1F87F5364, ____cancellationState_6)); }
	inline CancellationState_t302EEDE088D5E82EBE9A74EE31029F9CB981E9CC * get__cancellationState_6() const { return ____cancellationState_6; }
	inline CancellationState_t302EEDE088D5E82EBE9A74EE31029F9CB981E9CC ** get_address_of__cancellationState_6() { return &____cancellationState_6; }
	inline void set__cancellationState_6(CancellationState_t302EEDE088D5E82EBE9A74EE31029F9CB981E9CC * value)
	{
		____cancellationState_6 = value;
		Il2CppCodeGenWriteBarrier((void**)(&____cancellationState_6), (void*)value);
	}
};


// System.Linq.Parallel.PartitionedStream`2<System.Object,System.Int32>
struct PartitionedStream_2_tE1B2334EDFC774D178A02ACE8BB3C8CFF40AEB03  : public RuntimeObject
{
public:
	// System.Linq.Parallel.QueryOperatorEnumerator`2<TElement,TKey>[] System.Linq.Parallel.PartitionedStream`2::_partitions
	QueryOperatorEnumerator_2U5BU5D_t1B4A9F3A22210CE839D9CAE3FEAD3B53DABDC078* ____partitions_0;
	// System.Collections.Generic.IComparer`1<TKey> System.Linq.Parallel.PartitionedStream`2::_keyComparer
	RuntimeObject* ____keyComparer_1;
	// System.Linq.Parallel.OrdinalIndexState System.Linq.Parallel.PartitionedStream`2::_indexState
	uint8_t ____indexState_2;

public:
	inline static int32_t get_offset_of__partitions_0() { return static_cast<int32_t>(offsetof(PartitionedStream_2_tE1B2334EDFC774D178A02ACE8BB3C8CFF40AEB03, ____partitions_0)); }
	inline QueryOperatorEnumerator_2U5BU5D_t1B4A9F3A22210CE839D9CAE3FEAD3B53DABDC078* get__partitions_0() const { return ____partitions_0; }
	inline QueryOperatorEnumerator_2U5BU5D_t1B4A9F3A22210CE839D9CAE3FEAD3B53DABDC078** get_address_of__partitions_0() { return &____partitions_0; }
	inline void set__partitions_0(QueryOperatorEnumerator_2U5BU5D_t1B4A9F3A22210CE839D9CAE3FEAD3B53DABDC078* value)
	{
		____partitions_0 = value;
		Il2CppCodeGenWriteBarrier((void**)(&____partitions_0), (void*)value);
	}

	inline static int32_t get_offset_of__keyComparer_1() { return static_cast<int32_t>(offsetof(PartitionedStream_2_tE1B2334EDFC774D178A02ACE8BB3C8CFF40AEB03, ____keyComparer_1)); }
	inline RuntimeObject* get__keyComparer_1() const { return ____keyComparer_1; }
	inline RuntimeObject** get_address_of__keyComparer_1() { return &____keyComparer_1; }
	inline void set__keyComparer_1(RuntimeObject* value)
	{
		____keyComparer_1 = value;
		Il2CppCodeGenWriteBarrier((void**)(&____keyComparer_1), (void*)value);
	}

	inline static int32_t get_offset_of__indexState_2() { return static_cast<int32_t>(offsetof(PartitionedStream_2_tE1B2334EDFC774D178A02ACE8BB3C8CFF40AEB03, ____indexState_2)); }
	inline uint8_t get__indexState_2() const { return ____indexState_2; }
	inline uint8_t* get_address_of__indexState_2() { return &____indexState_2; }
	inline void set__indexState_2(uint8_t value)
	{
		____indexState_2 = value;
	}
};


// System.Linq.Enumerable/WhereEnumerableIterator`1<System.Nullable`1<System.Double>>
struct WhereEnumerableIterator_1_t66C0068FA4DE078BBB4FF7511CF89C013E04A14D  : public Iterator_1_t75B26B5E87871854D759A25738CFE42AF131D6A8
{
public:
	// System.Collections.Generic.IEnumerable`1<TSource> System.Linq.Enumerable/WhereEnumerableIterator`1::source
	RuntimeObject* ___source_3;
	// System.Func`2<TSource,System.Boolean> System.Linq.Enumerable/WhereEnumerableIterator`1::predicate
	Func_2_t4B7DAD120FE072A61F61F9158CB1013D6F95E130 * ___predicate_4;
	// System.Collections.Generic.IEnumerator`1<TSource> System.Linq.Enumerable/WhereEnumerableIterator`1::enumerator
	RuntimeObject* ___enumerator_5;

public:
	inline static int32_t get_offset_of_source_3() { return static_cast<int32_t>(offsetof(WhereEnumerableIterator_1_t66C0068FA4DE078BBB4FF7511CF89C013E04A14D, ___source_3)); }
	inline RuntimeObject* get_source_3() const { return ___source_3; }
	inline RuntimeObject** get_address_of_source_3() { return &___source_3; }
	inline void set_source_3(RuntimeObject* value)
	{
		___source_3 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___source_3), (void*)value);
	}

	inline static int32_t get_offset_of_predicate_4() { return static_cast<int32_t>(offsetof(WhereEnumerableIterator_1_t66C0068FA4DE078BBB4FF7511CF89C013E04A14D, ___predicate_4)); }
	inline Func_2_t4B7DAD120FE072A61F61F9158CB1013D6F95E130 * get_predicate_4() const { return ___predicate_4; }
	inline Func_2_t4B7DAD120FE072A61F61F9158CB1013D6F95E130 ** get_address_of_predicate_4() { return &___predicate_4; }
	inline void set_predicate_4(Func_2_t4B7DAD120FE072A61F61F9158CB1013D6F95E130 * value)
	{
		___predicate_4 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___predicate_4), (void*)value);
	}

	inline static int32_t get_offset_of_enumerator_5() { return static_cast<int32_t>(offsetof(WhereEnumerableIterator_1_t66C0068FA4DE078BBB4FF7511CF89C013E04A14D, ___enumerator_5)); }
	inline RuntimeObject* get_enumerator_5() const { return ___enumerator_5; }
	inline RuntimeObject** get_address_of_enumerator_5() { return &___enumerator_5; }
	inline void set_enumerator_5(RuntimeObject* value)
	{
		___enumerator_5 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___enumerator_5), (void*)value);
	}
};


// System.Linq.Enumerable/WhereEnumerableIterator`1<System.Nullable`1<System.Int32>>
struct WhereEnumerableIterator_1_t1B1B27D3E99C914ABE052FAFE0F219BB76A0E566  : public Iterator_1_t88E927D3E5FC45C833C1A5146A04FBA17D02CA43
{
public:
	// System.Collections.Generic.IEnumerable`1<TSource> System.Linq.Enumerable/WhereEnumerableIterator`1::source
	RuntimeObject* ___source_3;
	// System.Func`2<TSource,System.Boolean> System.Linq.Enumerable/WhereEnumerableIterator`1::predicate
	Func_2_t42993C24F11175D8FA98C3DB6E40DC467687C57D * ___predicate_4;
	// System.Collections.Generic.IEnumerator`1<TSource> System.Linq.Enumerable/WhereEnumerableIterator`1::enumerator
	RuntimeObject* ___enumerator_5;

public:
	inline static int32_t get_offset_of_source_3() { return static_cast<int32_t>(offsetof(WhereEnumerableIterator_1_t1B1B27D3E99C914ABE052FAFE0F219BB76A0E566, ___source_3)); }
	inline RuntimeObject* get_source_3() const { return ___source_3; }
	inline RuntimeObject** get_address_of_source_3() { return &___source_3; }
	inline void set_source_3(RuntimeObject* value)
	{
		___source_3 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___source_3), (void*)value);
	}

	inline static int32_t get_offset_of_predicate_4() { return static_cast<int32_t>(offsetof(WhereEnumerableIterator_1_t1B1B27D3E99C914ABE052FAFE0F219BB76A0E566, ___predicate_4)); }
	inline Func_2_t42993C24F11175D8FA98C3DB6E40DC467687C57D * get_predicate_4() const { return ___predicate_4; }
	inline Func_2_t42993C24F11175D8FA98C3DB6E40DC467687C57D ** get_address_of_predicate_4() { return &___predicate_4; }
	inline void set_predicate_4(Func_2_t42993C24F11175D8FA98C3DB6E40DC467687C57D * value)
	{
		___predicate_4 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___predicate_4), (void*)value);
	}

	inline static int32_t get_offset_of_enumerator_5() { return static_cast<int32_t>(offsetof(WhereEnumerableIterator_1_t1B1B27D3E99C914ABE052FAFE0F219BB76A0E566, ___enumerator_5)); }
	inline RuntimeObject* get_enumerator_5() const { return ___enumerator_5; }
	inline RuntimeObject** get_address_of_enumerator_5() { return &___enumerator_5; }
	inline void set_enumerator_5(RuntimeObject* value)
	{
		___enumerator_5 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___enumerator_5), (void*)value);
	}
};


// System.Linq.Enumerable/WhereEnumerableIterator`1<System.Nullable`1<System.Int64>>
struct WhereEnumerableIterator_1_t0354BCB72E2636F60E4B00786DDDE24A1EA42885  : public Iterator_1_t7714579EDED47F91E8FBA7AF6D3F0674241FDF6C
{
public:
	// System.Collections.Generic.IEnumerable`1<TSource> System.Linq.Enumerable/WhereEnumerableIterator`1::source
	RuntimeObject* ___source_3;
	// System.Func`2<TSource,System.Boolean> System.Linq.Enumerable/WhereEnumerableIterator`1::predicate
	Func_2_t1637E276420B054B58108E2AD51B1537DEC785D9 * ___predicate_4;
	// System.Collections.Generic.IEnumerator`1<TSource> System.Linq.Enumerable/WhereEnumerableIterator`1::enumerator
	RuntimeObject* ___enumerator_5;

public:
	inline static int32_t get_offset_of_source_3() { return static_cast<int32_t>(offsetof(WhereEnumerableIterator_1_t0354BCB72E2636F60E4B00786DDDE24A1EA42885, ___source_3)); }
	inline RuntimeObject* get_source_3() const { return ___source_3; }
	inline RuntimeObject** get_address_of_source_3() { return &___source_3; }
	inline void set_source_3(RuntimeObject* value)
	{
		___source_3 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___source_3), (void*)value);
	}

	inline static int32_t get_offset_of_predicate_4() { return static_cast<int32_t>(offsetof(WhereEnumerableIterator_1_t0354BCB72E2636F60E4B00786DDDE24A1EA42885, ___predicate_4)); }
	inline Func_2_t1637E276420B054B58108E2AD51B1537DEC785D9 * get_predicate_4() const { return ___predicate_4; }
	inline Func_2_t1637E276420B054B58108E2AD51B1537DEC785D9 ** get_address_of_predicate_4() { return &___predicate_4; }
	inline void set_predicate_4(Func_2_t1637E276420B054B58108E2AD51B1537DEC785D9 * value)
	{
		___predicate_4 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___predicate_4), (void*)value);
	}

	inline static int32_t get_offset_of_enumerator_5() { return static_cast<int32_t>(offsetof(WhereEnumerableIterator_1_t0354BCB72E2636F60E4B00786DDDE24A1EA42885, ___enumerator_5)); }
	inline RuntimeObject* get_enumerator_5() const { return ___enumerator_5; }
	inline RuntimeObject** get_address_of_enumerator_5() { return &___enumerator_5; }
	inline void set_enumerator_5(RuntimeObject* value)
	{
		___enumerator_5 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___enumerator_5), (void*)value);
	}
};


// System.Linq.Enumerable/WhereEnumerableIterator`1<System.Nullable`1<System.Single>>
struct WhereEnumerableIterator_1_tEA993B6947A5D38439F1B98DAAA3D3EE22BAF126  : public Iterator_1_t5F8CC81E7DD3167D5EC5BFC0984EBCEE64F5B45E
{
public:
	// System.Collections.Generic.IEnumerable`1<TSource> System.Linq.Enumerable/WhereEnumerableIterator`1::source
	RuntimeObject* ___source_3;
	// System.Func`2<TSource,System.Boolean> System.Linq.Enumerable/WhereEnumerableIterator`1::predicate
	Func_2_t9B3CA7186DE9A33B978124F5B7131DD16456B41A * ___predicate_4;
	// System.Collections.Generic.IEnumerator`1<TSource> System.Linq.Enumerable/WhereEnumerableIterator`1::enumerator
	RuntimeObject* ___enumerator_5;

public:
	inline static int32_t get_offset_of_source_3() { return static_cast<int32_t>(offsetof(WhereEnumerableIterator_1_tEA993B6947A5D38439F1B98DAAA3D3EE22BAF126, ___source_3)); }
	inline RuntimeObject* get_source_3() const { return ___source_3; }
	inline RuntimeObject** get_address_of_source_3() { return &___source_3; }
	inline void set_source_3(RuntimeObject* value)
	{
		___source_3 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___source_3), (void*)value);
	}

	inline static int32_t get_offset_of_predicate_4() { return static_cast<int32_t>(offsetof(WhereEnumerableIterator_1_tEA993B6947A5D38439F1B98DAAA3D3EE22BAF126, ___predicate_4)); }
	inline Func_2_t9B3CA7186DE9A33B978124F5B7131DD16456B41A * get_predicate_4() const { return ___predicate_4; }
	inline Func_2_t9B3CA7186DE9A33B978124F5B7131DD16456B41A ** get_address_of_predicate_4() { return &___predicate_4; }
	inline void set_predicate_4(Func_2_t9B3CA7186DE9A33B978124F5B7131DD16456B41A * value)
	{
		___predicate_4 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___predicate_4), (void*)value);
	}

	inline static int32_t get_offset_of_enumerator_5() { return static_cast<int32_t>(offsetof(WhereEnumerableIterator_1_tEA993B6947A5D38439F1B98DAAA3D3EE22BAF126, ___enumerator_5)); }
	inline RuntimeObject* get_enumerator_5() const { return ___enumerator_5; }
	inline RuntimeObject** get_address_of_enumerator_5() { return &___enumerator_5; }
	inline void set_enumerator_5(RuntimeObject* value)
	{
		___enumerator_5 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___enumerator_5), (void*)value);
	}
};


// System.Linq.Enumerable/WhereEnumerableIterator`1<UnityEngine.Color>
struct WhereEnumerableIterator_1_tEDD9A2C48D1FE8BE0706121F2B6C8A796196FFF2  : public Iterator_1_tDEF6AC46E52D8687C27A6E60B6E0200D50011D76
{
public:
	// System.Collections.Generic.IEnumerable`1<TSource> System.Linq.Enumerable/WhereEnumerableIterator`1::source
	RuntimeObject* ___source_3;
	// System.Func`2<TSource,System.Boolean> System.Linq.Enumerable/WhereEnumerableIterator`1::predicate
	Func_2_t3985FFDAB0D05F8E97E8EA849D5A24F16EFFC4FD * ___predicate_4;
	// System.Collections.Generic.IEnumerator`1<TSource> System.Linq.Enumerable/WhereEnumerableIterator`1::enumerator
	RuntimeObject* ___enumerator_5;

public:
	inline static int32_t get_offset_of_source_3() { return static_cast<int32_t>(offsetof(WhereEnumerableIterator_1_tEDD9A2C48D1FE8BE0706121F2B6C8A796196FFF2, ___source_3)); }
	inline RuntimeObject* get_source_3() const { return ___source_3; }
	inline RuntimeObject** get_address_of_source_3() { return &___source_3; }
	inline void set_source_3(RuntimeObject* value)
	{
		___source_3 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___source_3), (void*)value);
	}

	inline static int32_t get_offset_of_predicate_4() { return static_cast<int32_t>(offsetof(WhereEnumerableIterator_1_tEDD9A2C48D1FE8BE0706121F2B6C8A796196FFF2, ___predicate_4)); }
	inline Func_2_t3985FFDAB0D05F8E97E8EA849D5A24F16EFFC4FD * get_predicate_4() const { return ___predicate_4; }
	inline Func_2_t3985FFDAB0D05F8E97E8EA849D5A24F16EFFC4FD ** get_address_of_predicate_4() { return &___predicate_4; }
	inline void set_predicate_4(Func_2_t3985FFDAB0D05F8E97E8EA849D5A24F16EFFC4FD * value)
	{
		___predicate_4 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___predicate_4), (void*)value);
	}

	inline static int32_t get_offset_of_enumerator_5() { return static_cast<int32_t>(offsetof(WhereEnumerableIterator_1_tEDD9A2C48D1FE8BE0706121F2B6C8A796196FFF2, ___enumerator_5)); }
	inline RuntimeObject* get_enumerator_5() const { return ___enumerator_5; }
	inline RuntimeObject** get_address_of_enumerator_5() { return &___enumerator_5; }
	inline void set_enumerator_5(RuntimeObject* value)
	{
		___enumerator_5 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___enumerator_5), (void*)value);
	}
};


// System.Linq.Enumerable/WhereEnumerableIterator`1<System.Decimal>
struct WhereEnumerableIterator_1_t681EE290755A32EDFF9E6FDD4DF16CD94CA1A371  : public Iterator_1_t4861EDEAC91472CDE6F71F17BA6EF43B5D56F78E
{
public:
	// System.Collections.Generic.IEnumerable`1<TSource> System.Linq.Enumerable/WhereEnumerableIterator`1::source
	RuntimeObject* ___source_3;
	// System.Func`2<TSource,System.Boolean> System.Linq.Enumerable/WhereEnumerableIterator`1::predicate
	Func_2_t85912C5553CB5462E74F14A32388FC1004CC7C2E * ___predicate_4;
	// System.Collections.Generic.IEnumerator`1<TSource> System.Linq.Enumerable/WhereEnumerableIterator`1::enumerator
	RuntimeObject* ___enumerator_5;

public:
	inline static int32_t get_offset_of_source_3() { return static_cast<int32_t>(offsetof(WhereEnumerableIterator_1_t681EE290755A32EDFF9E6FDD4DF16CD94CA1A371, ___source_3)); }
	inline RuntimeObject* get_source_3() const { return ___source_3; }
	inline RuntimeObject** get_address_of_source_3() { return &___source_3; }
	inline void set_source_3(RuntimeObject* value)
	{
		___source_3 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___source_3), (void*)value);
	}

	inline static int32_t get_offset_of_predicate_4() { return static_cast<int32_t>(offsetof(WhereEnumerableIterator_1_t681EE290755A32EDFF9E6FDD4DF16CD94CA1A371, ___predicate_4)); }
	inline Func_2_t85912C5553CB5462E74F14A32388FC1004CC7C2E * get_predicate_4() const { return ___predicate_4; }
	inline Func_2_t85912C5553CB5462E74F14A32388FC1004CC7C2E ** get_address_of_predicate_4() { return &___predicate_4; }
	inline void set_predicate_4(Func_2_t85912C5553CB5462E74F14A32388FC1004CC7C2E * value)
	{
		___predicate_4 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___predicate_4), (void*)value);
	}

	inline static int32_t get_offset_of_enumerator_5() { return static_cast<int32_t>(offsetof(WhereEnumerableIterator_1_t681EE290755A32EDFF9E6FDD4DF16CD94CA1A371, ___enumerator_5)); }
	inline RuntimeObject* get_enumerator_5() const { return ___enumerator_5; }
	inline RuntimeObject** get_address_of_enumerator_5() { return &___enumerator_5; }
	inline void set_enumerator_5(RuntimeObject* value)
	{
		___enumerator_5 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___enumerator_5), (void*)value);
	}
};


// System.Linq.Enumerable/WhereEnumerableIterator`1<UnityEngine.Vector3>
struct WhereEnumerableIterator_1_t0E01F06572EA26BE9E79530811037753CF6B3BF8  : public Iterator_1_t04F5D870FD247BBBEE27254587FA10F440D4EEFF
{
public:
	// System.Collections.Generic.IEnumerable`1<TSource> System.Linq.Enumerable/WhereEnumerableIterator`1::source
	RuntimeObject* ___source_3;
	// System.Func`2<TSource,System.Boolean> System.Linq.Enumerable/WhereEnumerableIterator`1::predicate
	Func_2_t3041FD3183D19FE8416AE2E43A6398B2C06B7269 * ___predicate_4;
	// System.Collections.Generic.IEnumerator`1<TSource> System.Linq.Enumerable/WhereEnumerableIterator`1::enumerator
	RuntimeObject* ___enumerator_5;

public:
	inline static int32_t get_offset_of_source_3() { return static_cast<int32_t>(offsetof(WhereEnumerableIterator_1_t0E01F06572EA26BE9E79530811037753CF6B3BF8, ___source_3)); }
	inline RuntimeObject* get_source_3() const { return ___source_3; }
	inline RuntimeObject** get_address_of_source_3() { return &___source_3; }
	inline void set_source_3(RuntimeObject* value)
	{
		___source_3 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___source_3), (void*)value);
	}

	inline static int32_t get_offset_of_predicate_4() { return static_cast<int32_t>(offsetof(WhereEnumerableIterator_1_t0E01F06572EA26BE9E79530811037753CF6B3BF8, ___predicate_4)); }
	inline Func_2_t3041FD3183D19FE8416AE2E43A6398B2C06B7269 * get_predicate_4() const { return ___predicate_4; }
	inline Func_2_t3041FD3183D19FE8416AE2E43A6398B2C06B7269 ** get_address_of_predicate_4() { return &___predicate_4; }
	inline void set_predicate_4(Func_2_t3041FD3183D19FE8416AE2E43A6398B2C06B7269 * value)
	{
		___predicate_4 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___predicate_4), (void*)value);
	}

	inline static int32_t get_offset_of_enumerator_5() { return static_cast<int32_t>(offsetof(WhereEnumerableIterator_1_t0E01F06572EA26BE9E79530811037753CF6B3BF8, ___enumerator_5)); }
	inline RuntimeObject* get_enumerator_5() const { return ___enumerator_5; }
	inline RuntimeObject** get_address_of_enumerator_5() { return &___enumerator_5; }
	inline void set_enumerator_5(RuntimeObject* value)
	{
		___enumerator_5 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___enumerator_5), (void*)value);
	}
};


// System.Linq.Enumerable/WhereEnumerableIterator`1<Unity.Mathematics.float3>
struct WhereEnumerableIterator_1_t3450D7A9CB5BBEE711BB0ADD51AC530BD969D13F  : public Iterator_1_tCEC2E244A64F110B247B6A3DF34DE60D4456BA1A
{
public:
	// System.Collections.Generic.IEnumerable`1<TSource> System.Linq.Enumerable/WhereEnumerableIterator`1::source
	RuntimeObject* ___source_3;
	// System.Func`2<TSource,System.Boolean> System.Linq.Enumerable/WhereEnumerableIterator`1::predicate
	Func_2_t43355C55B1BBA93635101F6AF90867509812D7E5 * ___predicate_4;
	// System.Collections.Generic.IEnumerator`1<TSource> System.Linq.Enumerable/WhereEnumerableIterator`1::enumerator
	RuntimeObject* ___enumerator_5;

public:
	inline static int32_t get_offset_of_source_3() { return static_cast<int32_t>(offsetof(WhereEnumerableIterator_1_t3450D7A9CB5BBEE711BB0ADD51AC530BD969D13F, ___source_3)); }
	inline RuntimeObject* get_source_3() const { return ___source_3; }
	inline RuntimeObject** get_address_of_source_3() { return &___source_3; }
	inline void set_source_3(RuntimeObject* value)
	{
		___source_3 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___source_3), (void*)value);
	}

	inline static int32_t get_offset_of_predicate_4() { return static_cast<int32_t>(offsetof(WhereEnumerableIterator_1_t3450D7A9CB5BBEE711BB0ADD51AC530BD969D13F, ___predicate_4)); }
	inline Func_2_t43355C55B1BBA93635101F6AF90867509812D7E5 * get_predicate_4() const { return ___predicate_4; }
	inline Func_2_t43355C55B1BBA93635101F6AF90867509812D7E5 ** get_address_of_predicate_4() { return &___predicate_4; }
	inline void set_predicate_4(Func_2_t43355C55B1BBA93635101F6AF90867509812D7E5 * value)
	{
		___predicate_4 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___predicate_4), (void*)value);
	}

	inline static int32_t get_offset_of_enumerator_5() { return static_cast<int32_t>(offsetof(WhereEnumerableIterator_1_t3450D7A9CB5BBEE711BB0ADD51AC530BD969D13F, ___enumerator_5)); }
	inline RuntimeObject* get_enumerator_5() const { return ___enumerator_5; }
	inline RuntimeObject** get_address_of_enumerator_5() { return &___enumerator_5; }
	inline void set_enumerator_5(RuntimeObject* value)
	{
		___enumerator_5 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___enumerator_5), (void*)value);
	}
};


// System.Linq.Enumerable/WhereSelectListIterator`2<System.ValueTuple`2<System.Object,System.Object>,System.Int32>
struct WhereSelectListIterator_2_t6DF338AD50F89D3140CE0D070D507B13786150AC  : public Iterator_1_tCFFC952B03DBE4E956DE317DB9704D936AEA2379
{
public:
	// System.Collections.Generic.List`1<TSource> System.Linq.Enumerable/WhereSelectListIterator`2::source
	List_1_tF837281ACA0AE5696644C85291C841E8820C7AAC * ___source_3;
	// System.Func`2<TSource,System.Boolean> System.Linq.Enumerable/WhereSelectListIterator`2::predicate
	Func_2_t139EF32B1D20FBA53B5FC13859124C746B2D3C04 * ___predicate_4;
	// System.Func`2<TSource,TResult> System.Linq.Enumerable/WhereSelectListIterator`2::selector
	Func_2_tEB5259FF5AA54436077282823F2EEBED7C80AECF * ___selector_5;
	// System.Collections.Generic.List`1/Enumerator<TSource> System.Linq.Enumerable/WhereSelectListIterator`2::enumerator
	Enumerator_tCF455A92CC670AF169DFC7D0E19B47CAB2BD1DA0  ___enumerator_6;

public:
	inline static int32_t get_offset_of_source_3() { return static_cast<int32_t>(offsetof(WhereSelectListIterator_2_t6DF338AD50F89D3140CE0D070D507B13786150AC, ___source_3)); }
	inline List_1_tF837281ACA0AE5696644C85291C841E8820C7AAC * get_source_3() const { return ___source_3; }
	inline List_1_tF837281ACA0AE5696644C85291C841E8820C7AAC ** get_address_of_source_3() { return &___source_3; }
	inline void set_source_3(List_1_tF837281ACA0AE5696644C85291C841E8820C7AAC * value)
	{
		___source_3 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___source_3), (void*)value);
	}

	inline static int32_t get_offset_of_predicate_4() { return static_cast<int32_t>(offsetof(WhereSelectListIterator_2_t6DF338AD50F89D3140CE0D070D507B13786150AC, ___predicate_4)); }
	inline Func_2_t139EF32B1D20FBA53B5FC13859124C746B2D3C04 * get_predicate_4() const { return ___predicate_4; }
	inline Func_2_t139EF32B1D20FBA53B5FC13859124C746B2D3C04 ** get_address_of_predicate_4() { return &___predicate_4; }
	inline void set_predicate_4(Func_2_t139EF32B1D20FBA53B5FC13859124C746B2D3C04 * value)
	{
		___predicate_4 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___predicate_4), (void*)value);
	}

	inline static int32_t get_offset_of_selector_5() { return static_cast<int32_t>(offsetof(WhereSelectListIterator_2_t6DF338AD50F89D3140CE0D070D507B13786150AC, ___selector_5)); }
	inline Func_2_tEB5259FF5AA54436077282823F2EEBED7C80AECF * get_selector_5() const { return ___selector_5; }
	inline Func_2_tEB5259FF5AA54436077282823F2EEBED7C80AECF ** get_address_of_selector_5() { return &___selector_5; }
	inline void set_selector_5(Func_2_tEB5259FF5AA54436077282823F2EEBED7C80AECF * value)
	{
		___selector_5 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___selector_5), (void*)value);
	}

	inline static int32_t get_offset_of_enumerator_6() { return static_cast<int32_t>(offsetof(WhereSelectListIterator_2_t6DF338AD50F89D3140CE0D070D507B13786150AC, ___enumerator_6)); }
	inline Enumerator_tCF455A92CC670AF169DFC7D0E19B47CAB2BD1DA0  get_enumerator_6() const { return ___enumerator_6; }
	inline Enumerator_tCF455A92CC670AF169DFC7D0E19B47CAB2BD1DA0 * get_address_of_enumerator_6() { return &___enumerator_6; }
	inline void set_enumerator_6(Enumerator_tCF455A92CC670AF169DFC7D0E19B47CAB2BD1DA0  value)
	{
		___enumerator_6 = value;
		Il2CppCodeGenWriteBarrier((void**)&(((&___enumerator_6))->___list_0), (void*)NULL);
		#if IL2CPP_ENABLE_STRICT_WRITE_BARRIERS
		Il2CppCodeGenWriteBarrier((void**)&((&(((&___enumerator_6))->___current_3))->___Item1_0), (void*)NULL);
		#endif
		#if IL2CPP_ENABLE_STRICT_WRITE_BARRIERS
		Il2CppCodeGenWriteBarrier((void**)&((&(((&___enumerator_6))->___current_3))->___Item2_1), (void*)NULL);
		#endif
	}
};


// System.Linq.Enumerable/WhereSelectListIterator`2<System.ValueTuple`2<System.Object,System.Object>,System.Int64>
struct WhereSelectListIterator_2_t74BEECDFAC30D3415AFB22B70C33682938B5343B  : public Iterator_1_tF88FA02D56A55D26D525180DE0108FA4F019BECE
{
public:
	// System.Collections.Generic.List`1<TSource> System.Linq.Enumerable/WhereSelectListIterator`2::source
	List_1_tF837281ACA0AE5696644C85291C841E8820C7AAC * ___source_3;
	// System.Func`2<TSource,System.Boolean> System.Linq.Enumerable/WhereSelectListIterator`2::predicate
	Func_2_t139EF32B1D20FBA53B5FC13859124C746B2D3C04 * ___predicate_4;
	// System.Func`2<TSource,TResult> System.Linq.Enumerable/WhereSelectListIterator`2::selector
	Func_2_tCCE8B772536DC33F644E3A0108AA7059ABA2EDB3 * ___selector_5;
	// System.Collections.Generic.List`1/Enumerator<TSource> System.Linq.Enumerable/WhereSelectListIterator`2::enumerator
	Enumerator_tCF455A92CC670AF169DFC7D0E19B47CAB2BD1DA0  ___enumerator_6;

public:
	inline static int32_t get_offset_of_source_3() { return static_cast<int32_t>(offsetof(WhereSelectListIterator_2_t74BEECDFAC30D3415AFB22B70C33682938B5343B, ___source_3)); }
	inline List_1_tF837281ACA0AE5696644C85291C841E8820C7AAC * get_source_3() const { return ___source_3; }
	inline List_1_tF837281ACA0AE5696644C85291C841E8820C7AAC ** get_address_of_source_3() { return &___source_3; }
	inline void set_source_3(List_1_tF837281ACA0AE5696644C85291C841E8820C7AAC * value)
	{
		___source_3 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___source_3), (void*)value);
	}

	inline static int32_t get_offset_of_predicate_4() { return static_cast<int32_t>(offsetof(WhereSelectListIterator_2_t74BEECDFAC30D3415AFB22B70C33682938B5343B, ___predicate_4)); }
	inline Func_2_t139EF32B1D20FBA53B5FC13859124C746B2D3C04 * get_predicate_4() const { return ___predicate_4; }
	inline Func_2_t139EF32B1D20FBA53B5FC13859124C746B2D3C04 ** get_address_of_predicate_4() { return &___predicate_4; }
	inline void set_predicate_4(Func_2_t139EF32B1D20FBA53B5FC13859124C746B2D3C04 * value)
	{
		___predicate_4 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___predicate_4), (void*)value);
	}

	inline static int32_t get_offset_of_selector_5() { return static_cast<int32_t>(offsetof(WhereSelectListIterator_2_t74BEECDFAC30D3415AFB22B70C33682938B5343B, ___selector_5)); }
	inline Func_2_tCCE8B772536DC33F644E3A0108AA7059ABA2EDB3 * get_selector_5() const { return ___selector_5; }
	inline Func_2_tCCE8B772536DC33F644E3A0108AA7059ABA2EDB3 ** get_address_of_selector_5() { return &___selector_5; }
	inline void set_selector_5(Func_2_tCCE8B772536DC33F644E3A0108AA7059ABA2EDB3 * value)
	{
		___selector_5 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___selector_5), (void*)value);
	}

	inline static int32_t get_offset_of_enumerator_6() { return static_cast<int32_t>(offsetof(WhereSelectListIterator_2_t74BEECDFAC30D3415AFB22B70C33682938B5343B, ___enumerator_6)); }
	inline Enumerator_tCF455A92CC670AF169DFC7D0E19B47CAB2BD1DA0  get_enumerator_6() const { return ___enumerator_6; }
	inline Enumerator_tCF455A92CC670AF169DFC7D0E19B47CAB2BD1DA0 * get_address_of_enumerator_6() { return &___enumerator_6; }
	inline void set_enumerator_6(Enumerator_tCF455A92CC670AF169DFC7D0E19B47CAB2BD1DA0  value)
	{
		___enumerator_6 = value;
		Il2CppCodeGenWriteBarrier((void**)&(((&___enumerator_6))->___list_0), (void*)NULL);
		#if IL2CPP_ENABLE_STRICT_WRITE_BARRIERS
		Il2CppCodeGenWriteBarrier((void**)&((&(((&___enumerator_6))->___current_3))->___Item1_0), (void*)NULL);
		#endif
		#if IL2CPP_ENABLE_STRICT_WRITE_BARRIERS
		Il2CppCodeGenWriteBarrier((void**)&((&(((&___enumerator_6))->___current_3))->___Item2_1), (void*)NULL);
		#endif
	}
};


// System.Linq.Enumerable/WhereSelectListIterator`2<System.ValueTuple`2<System.Object,System.Object>,System.Object>
struct WhereSelectListIterator_2_tF4580FBFA67D084FC48A2A4D3CCD114BE92FAD20  : public Iterator_1_t674ABE41CF4096D4BE4D51E21FEBDADBF74CC279
{
public:
	// System.Collections.Generic.List`1<TSource> System.Linq.Enumerable/WhereSelectListIterator`2::source
	List_1_tF837281ACA0AE5696644C85291C841E8820C7AAC * ___source_3;
	// System.Func`2<TSource,System.Boolean> System.Linq.Enumerable/WhereSelectListIterator`2::predicate
	Func_2_t139EF32B1D20FBA53B5FC13859124C746B2D3C04 * ___predicate_4;
	// System.Func`2<TSource,TResult> System.Linq.Enumerable/WhereSelectListIterator`2::selector
	Func_2_tD5B31A0553FE51700369DE1E4E6F33189C45045A * ___selector_5;
	// System.Collections.Generic.List`1/Enumerator<TSource> System.Linq.Enumerable/WhereSelectListIterator`2::enumerator
	Enumerator_tCF455A92CC670AF169DFC7D0E19B47CAB2BD1DA0  ___enumerator_6;

public:
	inline static int32_t get_offset_of_source_3() { return static_cast<int32_t>(offsetof(WhereSelectListIterator_2_tF4580FBFA67D084FC48A2A4D3CCD114BE92FAD20, ___source_3)); }
	inline List_1_tF837281ACA0AE5696644C85291C841E8820C7AAC * get_source_3() const { return ___source_3; }
	inline List_1_tF837281ACA0AE5696644C85291C841E8820C7AAC ** get_address_of_source_3() { return &___source_3; }
	inline void set_source_3(List_1_tF837281ACA0AE5696644C85291C841E8820C7AAC * value)
	{
		___source_3 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___source_3), (void*)value);
	}

	inline static int32_t get_offset_of_predicate_4() { return static_cast<int32_t>(offsetof(WhereSelectListIterator_2_tF4580FBFA67D084FC48A2A4D3CCD114BE92FAD20, ___predicate_4)); }
	inline Func_2_t139EF32B1D20FBA53B5FC13859124C746B2D3C04 * get_predicate_4() const { return ___predicate_4; }
	inline Func_2_t139EF32B1D20FBA53B5FC13859124C746B2D3C04 ** get_address_of_predicate_4() { return &___predicate_4; }
	inline void set_predicate_4(Func_2_t139EF32B1D20FBA53B5FC13859124C746B2D3C04 * value)
	{
		___predicate_4 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___predicate_4), (void*)value);
	}

	inline static int32_t get_offset_of_selector_5() { return static_cast<int32_t>(offsetof(WhereSelectListIterator_2_tF4580FBFA67D084FC48A2A4D3CCD114BE92FAD20, ___selector_5)); }
	inline Func_2_tD5B31A0553FE51700369DE1E4E6F33189C45045A * get_selector_5() const { return ___selector_5; }
	inline Func_2_tD5B31A0553FE51700369DE1E4E6F33189C45045A ** get_address_of_selector_5() { return &___selector_5; }
	inline void set_selector_5(Func_2_tD5B31A0553FE51700369DE1E4E6F33189C45045A * value)
	{
		___selector_5 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___selector_5), (void*)value);
	}

	inline static int32_t get_offset_of_enumerator_6() { return static_cast<int32_t>(offsetof(WhereSelectListIterator_2_tF4580FBFA67D084FC48A2A4D3CCD114BE92FAD20, ___enumerator_6)); }
	inline Enumerator_tCF455A92CC670AF169DFC7D0E19B47CAB2BD1DA0  get_enumerator_6() const { return ___enumerator_6; }
	inline Enumerator_tCF455A92CC670AF169DFC7D0E19B47CAB2BD1DA0 * get_address_of_enumerator_6() { return &___enumerator_6; }
	inline void set_enumerator_6(Enumerator_tCF455A92CC670AF169DFC7D0E19B47CAB2BD1DA0  value)
	{
		___enumerator_6 = value;
		Il2CppCodeGenWriteBarrier((void**)&(((&___enumerator_6))->___list_0), (void*)NULL);
		#if IL2CPP_ENABLE_STRICT_WRITE_BARRIERS
		Il2CppCodeGenWriteBarrier((void**)&((&(((&___enumerator_6))->___current_3))->___Item1_0), (void*)NULL);
		#endif
		#if IL2CPP_ENABLE_STRICT_WRITE_BARRIERS
		Il2CppCodeGenWriteBarrier((void**)&((&(((&___enumerator_6))->___current_3))->___Item2_1), (void*)NULL);
		#endif
	}
};


// System.Linq.Enumerable/WhereSelectListIterator`2<System.ValueTuple`2<System.Object,System.Object>,System.Single>
struct WhereSelectListIterator_2_tBC8201B4C00B3004BB33AA252E6112F87595F077  : public Iterator_1_t859CAAB8DD3B63D3758E13D2802ED7523B331199
{
public:
	// System.Collections.Generic.List`1<TSource> System.Linq.Enumerable/WhereSelectListIterator`2::source
	List_1_tF837281ACA0AE5696644C85291C841E8820C7AAC * ___source_3;
	// System.Func`2<TSource,System.Boolean> System.Linq.Enumerable/WhereSelectListIterator`2::predicate
	Func_2_t139EF32B1D20FBA53B5FC13859124C746B2D3C04 * ___predicate_4;
	// System.Func`2<TSource,TResult> System.Linq.Enumerable/WhereSelectListIterator`2::selector
	Func_2_tCFA319B29B51C5B4FA9EE912CCB3BB9525555F72 * ___selector_5;
	// System.Collections.Generic.List`1/Enumerator<TSource> System.Linq.Enumerable/WhereSelectListIterator`2::enumerator
	Enumerator_tCF455A92CC670AF169DFC7D0E19B47CAB2BD1DA0  ___enumerator_6;

public:
	inline static int32_t get_offset_of_source_3() { return static_cast<int32_t>(offsetof(WhereSelectListIterator_2_tBC8201B4C00B3004BB33AA252E6112F87595F077, ___source_3)); }
	inline List_1_tF837281ACA0AE5696644C85291C841E8820C7AAC * get_source_3() const { return ___source_3; }
	inline List_1_tF837281ACA0AE5696644C85291C841E8820C7AAC ** get_address_of_source_3() { return &___source_3; }
	inline void set_source_3(List_1_tF837281ACA0AE5696644C85291C841E8820C7AAC * value)
	{
		___source_3 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___source_3), (void*)value);
	}

	inline static int32_t get_offset_of_predicate_4() { return static_cast<int32_t>(offsetof(WhereSelectListIterator_2_tBC8201B4C00B3004BB33AA252E6112F87595F077, ___predicate_4)); }
	inline Func_2_t139EF32B1D20FBA53B5FC13859124C746B2D3C04 * get_predicate_4() const { return ___predicate_4; }
	inline Func_2_t139EF32B1D20FBA53B5FC13859124C746B2D3C04 ** get_address_of_predicate_4() { return &___predicate_4; }
	inline void set_predicate_4(Func_2_t139EF32B1D20FBA53B5FC13859124C746B2D3C04 * value)
	{
		___predicate_4 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___predicate_4), (void*)value);
	}

	inline static int32_t get_offset_of_selector_5() { return static_cast<int32_t>(offsetof(WhereSelectListIterator_2_tBC8201B4C00B3004BB33AA252E6112F87595F077, ___selector_5)); }
	inline Func_2_tCFA319B29B51C5B4FA9EE912CCB3BB9525555F72 * get_selector_5() const { return ___selector_5; }
	inline Func_2_tCFA319B29B51C5B4FA9EE912CCB3BB9525555F72 ** get_address_of_selector_5() { return &___selector_5; }
	inline void set_selector_5(Func_2_tCFA319B29B51C5B4FA9EE912CCB3BB9525555F72 * value)
	{
		___selector_5 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___selector_5), (void*)value);
	}

	inline static int32_t get_offset_of_enumerator_6() { return static_cast<int32_t>(offsetof(WhereSelectListIterator_2_tBC8201B4C00B3004BB33AA252E6112F87595F077, ___enumerator_6)); }
	inline Enumerator_tCF455A92CC670AF169DFC7D0E19B47CAB2BD1DA0  get_enumerator_6() const { return ___enumerator_6; }
	inline Enumerator_tCF455A92CC670AF169DFC7D0E19B47CAB2BD1DA0 * get_address_of_enumerator_6() { return &___enumerator_6; }
	inline void set_enumerator_6(Enumerator_tCF455A92CC670AF169DFC7D0E19B47CAB2BD1DA0  value)
	{
		___enumerator_6 = value;
		Il2CppCodeGenWriteBarrier((void**)&(((&___enumerator_6))->___list_0), (void*)NULL);
		#if IL2CPP_ENABLE_STRICT_WRITE_BARRIERS
		Il2CppCodeGenWriteBarrier((void**)&((&(((&___enumerator_6))->___current_3))->___Item1_0), (void*)NULL);
		#endif
		#if IL2CPP_ENABLE_STRICT_WRITE_BARRIERS
		Il2CppCodeGenWriteBarrier((void**)&((&(((&___enumerator_6))->___current_3))->___Item2_1), (void*)NULL);
		#endif
	}
};


// System.Linq.Enumerable/WhereSelectListIterator`2<System.Decimal,System.Object>
struct WhereSelectListIterator_2_tAACFFE54E7C18BF4B0567FEF884C49B920B0FA6F  : public Iterator_1_t674ABE41CF4096D4BE4D51E21FEBDADBF74CC279
{
public:
	// System.Collections.Generic.List`1<TSource> System.Linq.Enumerable/WhereSelectListIterator`2::source
	List_1_t137B540BF717527106254AA05BE36A51A068C8F5 * ___source_3;
	// System.Func`2<TSource,System.Boolean> System.Linq.Enumerable/WhereSelectListIterator`2::predicate
	Func_2_t85912C5553CB5462E74F14A32388FC1004CC7C2E * ___predicate_4;
	// System.Func`2<TSource,TResult> System.Linq.Enumerable/WhereSelectListIterator`2::selector
	Func_2_t19AF92FE90E4D29194E67E9C39AA7BDBF405CD01 * ___selector_5;
	// System.Collections.Generic.List`1/Enumerator<TSource> System.Linq.Enumerable/WhereSelectListIterator`2::enumerator
	Enumerator_t97AF9DDC8F349478939A4899D22F6CC1A2FA7021  ___enumerator_6;

public:
	inline static int32_t get_offset_of_source_3() { return static_cast<int32_t>(offsetof(WhereSelectListIterator_2_tAACFFE54E7C18BF4B0567FEF884C49B920B0FA6F, ___source_3)); }
	inline List_1_t137B540BF717527106254AA05BE36A51A068C8F5 * get_source_3() const { return ___source_3; }
	inline List_1_t137B540BF717527106254AA05BE36A51A068C8F5 ** get_address_of_source_3() { return &___source_3; }
	inline void set_source_3(List_1_t137B540BF717527106254AA05BE36A51A068C8F5 * value)
	{
		___source_3 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___source_3), (void*)value);
	}

	inline static int32_t get_offset_of_predicate_4() { return static_cast<int32_t>(offsetof(WhereSelectListIterator_2_tAACFFE54E7C18BF4B0567FEF884C49B920B0FA6F, ___predicate_4)); }
	inline Func_2_t85912C5553CB5462E74F14A32388FC1004CC7C2E * get_predicate_4() const { return ___predicate_4; }
	inline Func_2_t85912C5553CB5462E74F14A32388FC1004CC7C2E ** get_address_of_predicate_4() { return &___predicate_4; }
	inline void set_predicate_4(Func_2_t85912C5553CB5462E74F14A32388FC1004CC7C2E * value)
	{
		___predicate_4 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___predicate_4), (void*)value);
	}

	inline static int32_t get_offset_of_selector_5() { return static_cast<int32_t>(offsetof(WhereSelectListIterator_2_tAACFFE54E7C18BF4B0567FEF884C49B920B0FA6F, ___selector_5)); }
	inline Func_2_t19AF92FE90E4D29194E67E9C39AA7BDBF405CD01 * get_selector_5() const { return ___selector_5; }
	inline Func_2_t19AF92FE90E4D29194E67E9C39AA7BDBF405CD01 ** get_address_of_selector_5() { return &___selector_5; }
	inline void set_selector_5(Func_2_t19AF92FE90E4D29194E67E9C39AA7BDBF405CD01 * value)
	{
		___selector_5 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___selector_5), (void*)value);
	}

	inline static int32_t get_offset_of_enumerator_6() { return static_cast<int32_t>(offsetof(WhereSelectListIterator_2_tAACFFE54E7C18BF4B0567FEF884C49B920B0FA6F, ___enumerator_6)); }
	inline Enumerator_t97AF9DDC8F349478939A4899D22F6CC1A2FA7021  get_enumerator_6() const { return ___enumerator_6; }
	inline Enumerator_t97AF9DDC8F349478939A4899D22F6CC1A2FA7021 * get_address_of_enumerator_6() { return &___enumerator_6; }
	inline void set_enumerator_6(Enumerator_t97AF9DDC8F349478939A4899D22F6CC1A2FA7021  value)
	{
		___enumerator_6 = value;
		Il2CppCodeGenWriteBarrier((void**)&(((&___enumerator_6))->___list_0), (void*)NULL);
	}
};


// System.Linq.Enumerable/WhereSelectListIterator`2<System.Int32,System.Nullable`1<System.Double>>
struct WhereSelectListIterator_2_t1490C52A3F0E91B34D300F481F9E37F5F0FECEA4  : public Iterator_1_t75B26B5E87871854D759A25738CFE42AF131D6A8
{
public:
	// System.Collections.Generic.List`1<TSource> System.Linq.Enumerable/WhereSelectListIterator`2::source
	List_1_t260B41F956D673396C33A4CF94E8D6C4389EACB7 * ___source_3;
	// System.Func`2<TSource,System.Boolean> System.Linq.Enumerable/WhereSelectListIterator`2::predicate
	Func_2_t2EBF98B0BA555D9F0633C9BCCBE3DF332B9C1274 * ___predicate_4;
	// System.Func`2<TSource,TResult> System.Linq.Enumerable/WhereSelectListIterator`2::selector
	Func_2_t6C7618E0D575852E15D00A9E3CA463CE2CF5D159 * ___selector_5;
	// System.Collections.Generic.List`1/Enumerator<TSource> System.Linq.Enumerable/WhereSelectListIterator`2::enumerator
	Enumerator_t7BA00929E14A2F2A62CE085585044A3FEB2C5F3C  ___enumerator_6;

public:
	inline static int32_t get_offset_of_source_3() { return static_cast<int32_t>(offsetof(WhereSelectListIterator_2_t1490C52A3F0E91B34D300F481F9E37F5F0FECEA4, ___source_3)); }
	inline List_1_t260B41F956D673396C33A4CF94E8D6C4389EACB7 * get_source_3() const { return ___source_3; }
	inline List_1_t260B41F956D673396C33A4CF94E8D6C4389EACB7 ** get_address_of_source_3() { return &___source_3; }
	inline void set_source_3(List_1_t260B41F956D673396C33A4CF94E8D6C4389EACB7 * value)
	{
		___source_3 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___source_3), (void*)value);
	}

	inline static int32_t get_offset_of_predicate_4() { return static_cast<int32_t>(offsetof(WhereSelectListIterator_2_t1490C52A3F0E91B34D300F481F9E37F5F0FECEA4, ___predicate_4)); }
	inline Func_2_t2EBF98B0BA555D9F0633C9BCCBE3DF332B9C1274 * get_predicate_4() const { return ___predicate_4; }
	inline Func_2_t2EBF98B0BA555D9F0633C9BCCBE3DF332B9C1274 ** get_address_of_predicate_4() { return &___predicate_4; }
	inline void set_predicate_4(Func_2_t2EBF98B0BA555D9F0633C9BCCBE3DF332B9C1274 * value)
	{
		___predicate_4 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___predicate_4), (void*)value);
	}

	inline static int32_t get_offset_of_selector_5() { return static_cast<int32_t>(offsetof(WhereSelectListIterator_2_t1490C52A3F0E91B34D300F481F9E37F5F0FECEA4, ___selector_5)); }
	inline Func_2_t6C7618E0D575852E15D00A9E3CA463CE2CF5D159 * get_selector_5() const { return ___selector_5; }
	inline Func_2_t6C7618E0D575852E15D00A9E3CA463CE2CF5D159 ** get_address_of_selector_5() { return &___selector_5; }
	inline void set_selector_5(Func_2_t6C7618E0D575852E15D00A9E3CA463CE2CF5D159 * value)
	{
		___selector_5 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___selector_5), (void*)value);
	}

	inline static int32_t get_offset_of_enumerator_6() { return static_cast<int32_t>(offsetof(WhereSelectListIterator_2_t1490C52A3F0E91B34D300F481F9E37F5F0FECEA4, ___enumerator_6)); }
	inline Enumerator_t7BA00929E14A2F2A62CE085585044A3FEB2C5F3C  get_enumerator_6() const { return ___enumerator_6; }
	inline Enumerator_t7BA00929E14A2F2A62CE085585044A3FEB2C5F3C * get_address_of_enumerator_6() { return &___enumerator_6; }
	inline void set_enumerator_6(Enumerator_t7BA00929E14A2F2A62CE085585044A3FEB2C5F3C  value)
	{
		___enumerator_6 = value;
		Il2CppCodeGenWriteBarrier((void**)&(((&___enumerator_6))->___list_0), (void*)NULL);
	}
};


// System.Linq.Enumerable/WhereSelectListIterator`2<System.Int32,System.Nullable`1<System.Int32>>
struct WhereSelectListIterator_2_tDFB4A007D3032729411EC82D94FF3BD767D46B20  : public Iterator_1_t88E927D3E5FC45C833C1A5146A04FBA17D02CA43
{
public:
	// System.Collections.Generic.List`1<TSource> System.Linq.Enumerable/WhereSelectListIterator`2::source
	List_1_t260B41F956D673396C33A4CF94E8D6C4389EACB7 * ___source_3;
	// System.Func`2<TSource,System.Boolean> System.Linq.Enumerable/WhereSelectListIterator`2::predicate
	Func_2_t2EBF98B0BA555D9F0633C9BCCBE3DF332B9C1274 * ___predicate_4;
	// System.Func`2<TSource,TResult> System.Linq.Enumerable/WhereSelectListIterator`2::selector
	Func_2_t212214032B3E2E671F2871ED55DFBC92A4EBD9C3 * ___selector_5;
	// System.Collections.Generic.List`1/Enumerator<TSource> System.Linq.Enumerable/WhereSelectListIterator`2::enumerator
	Enumerator_t7BA00929E14A2F2A62CE085585044A3FEB2C5F3C  ___enumerator_6;

public:
	inline static int32_t get_offset_of_source_3() { return static_cast<int32_t>(offsetof(WhereSelectListIterator_2_tDFB4A007D3032729411EC82D94FF3BD767D46B20, ___source_3)); }
	inline List_1_t260B41F956D673396C33A4CF94E8D6C4389EACB7 * get_source_3() const { return ___source_3; }
	inline List_1_t260B41F956D673396C33A4CF94E8D6C4389EACB7 ** get_address_of_source_3() { return &___source_3; }
	inline void set_source_3(List_1_t260B41F956D673396C33A4CF94E8D6C4389EACB7 * value)
	{
		___source_3 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___source_3), (void*)value);
	}

	inline static int32_t get_offset_of_predicate_4() { return static_cast<int32_t>(offsetof(WhereSelectListIterator_2_tDFB4A007D3032729411EC82D94FF3BD767D46B20, ___predicate_4)); }
	inline Func_2_t2EBF98B0BA555D9F0633C9BCCBE3DF332B9C1274 * get_predicate_4() const { return ___predicate_4; }
	inline Func_2_t2EBF98B0BA555D9F0633C9BCCBE3DF332B9C1274 ** get_address_of_predicate_4() { return &___predicate_4; }
	inline void set_predicate_4(Func_2_t2EBF98B0BA555D9F0633C9BCCBE3DF332B9C1274 * value)
	{
		___predicate_4 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___predicate_4), (void*)value);
	}

	inline static int32_t get_offset_of_selector_5() { return static_cast<int32_t>(offsetof(WhereSelectListIterator_2_tDFB4A007D3032729411EC82D94FF3BD767D46B20, ___selector_5)); }
	inline Func_2_t212214032B3E2E671F2871ED55DFBC92A4EBD9C3 * get_selector_5() const { return ___selector_5; }
	inline Func_2_t212214032B3E2E671F2871ED55DFBC92A4EBD9C3 ** get_address_of_selector_5() { return &___selector_5; }
	inline void set_selector_5(Func_2_t212214032B3E2E671F2871ED55DFBC92A4EBD9C3 * value)
	{
		___selector_5 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___selector_5), (void*)value);
	}

	inline static int32_t get_offset_of_enumerator_6() { return static_cast<int32_t>(offsetof(WhereSelectListIterator_2_tDFB4A007D3032729411EC82D94FF3BD767D46B20, ___enumerator_6)); }
	inline Enumerator_t7BA00929E14A2F2A62CE085585044A3FEB2C5F3C  get_enumerator_6() const { return ___enumerator_6; }
	inline Enumerator_t7BA00929E14A2F2A62CE085585044A3FEB2C5F3C * get_address_of_enumerator_6() { return &___enumerator_6; }
	inline void set_enumerator_6(Enumerator_t7BA00929E14A2F2A62CE085585044A3FEB2C5F3C  value)
	{
		___enumerator_6 = value;
		Il2CppCodeGenWriteBarrier((void**)&(((&___enumerator_6))->___list_0), (void*)NULL);
	}
};


// System.Linq.Enumerable/WhereSelectListIterator`2<System.Int32,System.Nullable`1<System.Int64>>
struct WhereSelectListIterator_2_t976CDD198DB8AC61A9A22BA501F3C314F00E2C78  : public Iterator_1_t7714579EDED47F91E8FBA7AF6D3F0674241FDF6C
{
public:
	// System.Collections.Generic.List`1<TSource> System.Linq.Enumerable/WhereSelectListIterator`2::source
	List_1_t260B41F956D673396C33A4CF94E8D6C4389EACB7 * ___source_3;
	// System.Func`2<TSource,System.Boolean> System.Linq.Enumerable/WhereSelectListIterator`2::predicate
	Func_2_t2EBF98B0BA555D9F0633C9BCCBE3DF332B9C1274 * ___predicate_4;
	// System.Func`2<TSource,TResult> System.Linq.Enumerable/WhereSelectListIterator`2::selector
	Func_2_tC286DBD1D3140BC4FC4D1DCF2D41DE03E72D8CAF * ___selector_5;
	// System.Collections.Generic.List`1/Enumerator<TSource> System.Linq.Enumerable/WhereSelectListIterator`2::enumerator
	Enumerator_t7BA00929E14A2F2A62CE085585044A3FEB2C5F3C  ___enumerator_6;

public:
	inline static int32_t get_offset_of_source_3() { return static_cast<int32_t>(offsetof(WhereSelectListIterator_2_t976CDD198DB8AC61A9A22BA501F3C314F00E2C78, ___source_3)); }
	inline List_1_t260B41F956D673396C33A4CF94E8D6C4389EACB7 * get_source_3() const { return ___source_3; }
	inline List_1_t260B41F956D673396C33A4CF94E8D6C4389EACB7 ** get_address_of_source_3() { return &___source_3; }
	inline void set_source_3(List_1_t260B41F956D673396C33A4CF94E8D6C4389EACB7 * value)
	{
		___source_3 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___source_3), (void*)value);
	}

	inline static int32_t get_offset_of_predicate_4() { return static_cast<int32_t>(offsetof(WhereSelectListIterator_2_t976CDD198DB8AC61A9A22BA501F3C314F00E2C78, ___predicate_4)); }
	inline Func_2_t2EBF98B0BA555D9F0633C9BCCBE3DF332B9C1274 * get_predicate_4() const { return ___predicate_4; }
	inline Func_2_t2EBF98B0BA555D9F0633C9BCCBE3DF332B9C1274 ** get_address_of_predicate_4() { return &___predicate_4; }
	inline void set_predicate_4(Func_2_t2EBF98B0BA555D9F0633C9BCCBE3DF332B9C1274 * value)
	{
		___predicate_4 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___predicate_4), (void*)value);
	}

	inline static int32_t get_offset_of_selector_5() { return static_cast<int32_t>(offsetof(WhereSelectListIterator_2_t976CDD198DB8AC61A9A22BA501F3C314F00E2C78, ___selector_5)); }
	inline Func_2_tC286DBD1D3140BC4FC4D1DCF2D41DE03E72D8CAF * get_selector_5() const { return ___selector_5; }
	inline Func_2_tC286DBD1D3140BC4FC4D1DCF2D41DE03E72D8CAF ** get_address_of_selector_5() { return &___selector_5; }
	inline void set_selector_5(Func_2_tC286DBD1D3140BC4FC4D1DCF2D41DE03E72D8CAF * value)
	{
		___selector_5 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___selector_5), (void*)value);
	}

	inline static int32_t get_offset_of_enumerator_6() { return static_cast<int32_t>(offsetof(WhereSelectListIterator_2_t976CDD198DB8AC61A9A22BA501F3C314F00E2C78, ___enumerator_6)); }
	inline Enumerator_t7BA00929E14A2F2A62CE085585044A3FEB2C5F3C  get_enumerator_6() const { return ___enumerator_6; }
	inline Enumerator_t7BA00929E14A2F2A62CE085585044A3FEB2C5F3C * get_address_of_enumerator_6() { return &___enumerator_6; }
	inline void set_enumerator_6(Enumerator_t7BA00929E14A2F2A62CE085585044A3FEB2C5F3C  value)
	{
		___enumerator_6 = value;
		Il2CppCodeGenWriteBarrier((void**)&(((&___enumerator_6))->___list_0), (void*)NULL);
	}
};


// System.Linq.Enumerable/WhereSelectListIterator`2<System.Int32,System.Nullable`1<System.Single>>
struct WhereSelectListIterator_2_tACE6C37EC1B04DF78ECD3C22632AB334307C46DB  : public Iterator_1_t5F8CC81E7DD3167D5EC5BFC0984EBCEE64F5B45E
{
public:
	// System.Collections.Generic.List`1<TSource> System.Linq.Enumerable/WhereSelectListIterator`2::source
	List_1_t260B41F956D673396C33A4CF94E8D6C4389EACB7 * ___source_3;
	// System.Func`2<TSource,System.Boolean> System.Linq.Enumerable/WhereSelectListIterator`2::predicate
	Func_2_t2EBF98B0BA555D9F0633C9BCCBE3DF332B9C1274 * ___predicate_4;
	// System.Func`2<TSource,TResult> System.Linq.Enumerable/WhereSelectListIterator`2::selector
	Func_2_t6663A9FD2A53E3B599DF99EC970BF2320E8D9D40 * ___selector_5;
	// System.Collections.Generic.List`1/Enumerator<TSource> System.Linq.Enumerable/WhereSelectListIterator`2::enumerator
	Enumerator_t7BA00929E14A2F2A62CE085585044A3FEB2C5F3C  ___enumerator_6;

public:
	inline static int32_t get_offset_of_source_3() { return static_cast<int32_t>(offsetof(WhereSelectListIterator_2_tACE6C37EC1B04DF78ECD3C22632AB334307C46DB, ___source_3)); }
	inline List_1_t260B41F956D673396C33A4CF94E8D6C4389EACB7 * get_source_3() const { return ___source_3; }
	inline List_1_t260B41F956D673396C33A4CF94E8D6C4389EACB7 ** get_address_of_source_3() { return &___source_3; }
	inline void set_source_3(List_1_t260B41F956D673396C33A4CF94E8D6C4389EACB7 * value)
	{
		___source_3 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___source_3), (void*)value);
	}

	inline static int32_t get_offset_of_predicate_4() { return static_cast<int32_t>(offsetof(WhereSelectListIterator_2_tACE6C37EC1B04DF78ECD3C22632AB334307C46DB, ___predicate_4)); }
	inline Func_2_t2EBF98B0BA555D9F0633C9BCCBE3DF332B9C1274 * get_predicate_4() const { return ___predicate_4; }
	inline Func_2_t2EBF98B0BA555D9F0633C9BCCBE3DF332B9C1274 ** get_address_of_predicate_4() { return &___predicate_4; }
	inline void set_predicate_4(Func_2_t2EBF98B0BA555D9F0633C9BCCBE3DF332B9C1274 * value)
	{
		___predicate_4 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___predicate_4), (void*)value);
	}

	inline static int32_t get_offset_of_selector_5() { return static_cast<int32_t>(offsetof(WhereSelectListIterator_2_tACE6C37EC1B04DF78ECD3C22632AB334307C46DB, ___selector_5)); }
	inline Func_2_t6663A9FD2A53E3B599DF99EC970BF2320E8D9D40 * get_selector_5() const { return ___selector_5; }
	inline Func_2_t6663A9FD2A53E3B599DF99EC970BF2320E8D9D40 ** get_address_of_selector_5() { return &___selector_5; }
	inline void set_selector_5(Func_2_t6663A9FD2A53E3B599DF99EC970BF2320E8D9D40 * value)
	{
		___selector_5 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___selector_5), (void*)value);
	}

	inline static int32_t get_offset_of_enumerator_6() { return static_cast<int32_t>(offsetof(WhereSelectListIterator_2_tACE6C37EC1B04DF78ECD3C22632AB334307C46DB, ___enumerator_6)); }
	inline Enumerator_t7BA00929E14A2F2A62CE085585044A3FEB2C5F3C  get_enumerator_6() const { return ___enumerator_6; }
	inline Enumerator_t7BA00929E14A2F2A62CE085585044A3FEB2C5F3C * get_address_of_enumerator_6() { return &___enumerator_6; }
	inline void set_enumerator_6(Enumerator_t7BA00929E14A2F2A62CE085585044A3FEB2C5F3C  value)
	{
		___enumerator_6 = value;
		Il2CppCodeGenWriteBarrier((void**)&(((&___enumerator_6))->___list_0), (void*)NULL);
	}
};


// System.Linq.Enumerable/WhereSelectListIterator`2<System.Int32,System.Decimal>
struct WhereSelectListIterator_2_t2EBF84FB2CE39E9E5B9DD3AC4C33E4F0D6142BBC  : public Iterator_1_t4861EDEAC91472CDE6F71F17BA6EF43B5D56F78E
{
public:
	// System.Collections.Generic.List`1<TSource> System.Linq.Enumerable/WhereSelectListIterator`2::source
	List_1_t260B41F956D673396C33A4CF94E8D6C4389EACB7 * ___source_3;
	// System.Func`2<TSource,System.Boolean> System.Linq.Enumerable/WhereSelectListIterator`2::predicate
	Func_2_t2EBF98B0BA555D9F0633C9BCCBE3DF332B9C1274 * ___predicate_4;
	// System.Func`2<TSource,TResult> System.Linq.Enumerable/WhereSelectListIterator`2::selector
	Func_2_tBF5E42259B30DEB08B8F01DEAD14034173D7F115 * ___selector_5;
	// System.Collections.Generic.List`1/Enumerator<TSource> System.Linq.Enumerable/WhereSelectListIterator`2::enumerator
	Enumerator_t7BA00929E14A2F2A62CE085585044A3FEB2C5F3C  ___enumerator_6;

public:
	inline static int32_t get_offset_of_source_3() { return static_cast<int32_t>(offsetof(WhereSelectListIterator_2_t2EBF84FB2CE39E9E5B9DD3AC4C33E4F0D6142BBC, ___source_3)); }
	inline List_1_t260B41F956D673396C33A4CF94E8D6C4389EACB7 * get_source_3() const { return ___source_3; }
	inline List_1_t260B41F956D673396C33A4CF94E8D6C4389EACB7 ** get_address_of_source_3() { return &___source_3; }
	inline void set_source_3(List_1_t260B41F956D673396C33A4CF94E8D6C4389EACB7 * value)
	{
		___source_3 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___source_3), (void*)value);
	}

	inline static int32_t get_offset_of_predicate_4() { return static_cast<int32_t>(offsetof(WhereSelectListIterator_2_t2EBF84FB2CE39E9E5B9DD3AC4C33E4F0D6142BBC, ___predicate_4)); }
	inline Func_2_t2EBF98B0BA555D9F0633C9BCCBE3DF332B9C1274 * get_predicate_4() const { return ___predicate_4; }
	inline Func_2_t2EBF98B0BA555D9F0633C9BCCBE3DF332B9C1274 ** get_address_of_predicate_4() { return &___predicate_4; }
	inline void set_predicate_4(Func_2_t2EBF98B0BA555D9F0633C9BCCBE3DF332B9C1274 * value)
	{
		___predicate_4 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___predicate_4), (void*)value);
	}

	inline static int32_t get_offset_of_selector_5() { return static_cast<int32_t>(offsetof(WhereSelectListIterator_2_t2EBF84FB2CE39E9E5B9DD3AC4C33E4F0D6142BBC, ___selector_5)); }
	inline Func_2_tBF5E42259B30DEB08B8F01DEAD14034173D7F115 * get_selector_5() const { return ___selector_5; }
	inline Func_2_tBF5E42259B30DEB08B8F01DEAD14034173D7F115 ** get_address_of_selector_5() { return &___selector_5; }
	inline void set_selector_5(Func_2_tBF5E42259B30DEB08B8F01DEAD14034173D7F115 * value)
	{
		___selector_5 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___selector_5), (void*)value);
	}

	inline static int32_t get_offset_of_enumerator_6() { return static_cast<int32_t>(offsetof(WhereSelectListIterator_2_t2EBF84FB2CE39E9E5B9DD3AC4C33E4F0D6142BBC, ___enumerator_6)); }
	inline Enumerator_t7BA00929E14A2F2A62CE085585044A3FEB2C5F3C  get_enumerator_6() const { return ___enumerator_6; }
	inline Enumerator_t7BA00929E14A2F2A62CE085585044A3FEB2C5F3C * get_address_of_enumerator_6() { return &___enumerator_6; }
	inline void set_enumerator_6(Enumerator_t7BA00929E14A2F2A62CE085585044A3FEB2C5F3C  value)
	{
		___enumerator_6 = value;
		Il2CppCodeGenWriteBarrier((void**)&(((&___enumerator_6))->___list_0), (void*)NULL);
	}
};


// System.Linq.Enumerable/WhereSelectListIterator`2<System.Object,System.Nullable`1<System.Double>>
struct WhereSelectListIterator_2_tEE6392F7E2CDC15C2F3490EE288AB2275DEF7D9A  : public Iterator_1_t75B26B5E87871854D759A25738CFE42AF131D6A8
{
public:
	// System.Collections.Generic.List`1<TSource> System.Linq.Enumerable/WhereSelectListIterator`2::source
	List_1_t3F94120C77410A62EAE48421CF166B83AB95A2F5 * ___source_3;
	// System.Func`2<TSource,System.Boolean> System.Linq.Enumerable/WhereSelectListIterator`2::predicate
	Func_2_t99409DECFF50F0FA9B427C863AC6C99C66E6F9F8 * ___predicate_4;
	// System.Func`2<TSource,TResult> System.Linq.Enumerable/WhereSelectListIterator`2::selector
	Func_2_t969BC5FC9B68C7023AE4F7C254A78F446A7609F8 * ___selector_5;
	// System.Collections.Generic.List`1/Enumerator<TSource> System.Linq.Enumerable/WhereSelectListIterator`2::enumerator
	Enumerator_tB6009981BD4E3881E3EC83627255A24198F902D6  ___enumerator_6;

public:
	inline static int32_t get_offset_of_source_3() { return static_cast<int32_t>(offsetof(WhereSelectListIterator_2_tEE6392F7E2CDC15C2F3490EE288AB2275DEF7D9A, ___source_3)); }
	inline List_1_t3F94120C77410A62EAE48421CF166B83AB95A2F5 * get_source_3() const { return ___source_3; }
	inline List_1_t3F94120C77410A62EAE48421CF166B83AB95A2F5 ** get_address_of_source_3() { return &___source_3; }
	inline void set_source_3(List_1_t3F94120C77410A62EAE48421CF166B83AB95A2F5 * value)
	{
		___source_3 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___source_3), (void*)value);
	}

	inline static int32_t get_offset_of_predicate_4() { return static_cast<int32_t>(offsetof(WhereSelectListIterator_2_tEE6392F7E2CDC15C2F3490EE288AB2275DEF7D9A, ___predicate_4)); }
	inline Func_2_t99409DECFF50F0FA9B427C863AC6C99C66E6F9F8 * get_predicate_4() const { return ___predicate_4; }
	inline Func_2_t99409DECFF50F0FA9B427C863AC6C99C66E6F9F8 ** get_address_of_predicate_4() { return &___predicate_4; }
	inline void set_predicate_4(Func_2_t99409DECFF50F0FA9B427C863AC6C99C66E6F9F8 * value)
	{
		___predicate_4 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___predicate_4), (void*)value);
	}

	inline static int32_t get_offset_of_selector_5() { return static_cast<int32_t>(offsetof(WhereSelectListIterator_2_tEE6392F7E2CDC15C2F3490EE288AB2275DEF7D9A, ___selector_5)); }
	inline Func_2_t969BC5FC9B68C7023AE4F7C254A78F446A7609F8 * get_selector_5() const { return ___selector_5; }
	inline Func_2_t969BC5FC9B68C7023AE4F7C254A78F446A7609F8 ** get_address_of_selector_5() { return &___selector_5; }
	inline void set_selector_5(Func_2_t969BC5FC9B68C7023AE4F7C254A78F446A7609F8 * value)
	{
		___selector_5 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___selector_5), (void*)value);
	}

	inline static int32_t get_offset_of_enumerator_6() { return static_cast<int32_t>(offsetof(WhereSelectListIterator_2_tEE6392F7E2CDC15C2F3490EE288AB2275DEF7D9A, ___enumerator_6)); }
	inline Enumerator_tB6009981BD4E3881E3EC83627255A24198F902D6  get_enumerator_6() const { return ___enumerator_6; }
	inline Enumerator_tB6009981BD4E3881E3EC83627255A24198F902D6 * get_address_of_enumerator_6() { return &___enumerator_6; }
	inline void set_enumerator_6(Enumerator_tB6009981BD4E3881E3EC83627255A24198F902D6  value)
	{
		___enumerator_6 = value;
		Il2CppCodeGenWriteBarrier((void**)&(((&___enumerator_6))->___list_0), (void*)NULL);
		#if IL2CPP_ENABLE_STRICT_WRITE_BARRIERS
		Il2CppCodeGenWriteBarrier((void**)&(((&___enumerator_6))->___current_3), (void*)NULL);
		#endif
	}
};


// System.Linq.Enumerable/WhereSelectListIterator`2<System.Object,System.Nullable`1<System.Int32>>
struct WhereSelectListIterator_2_tAA7EB4891E566E311D0CC2850A8453EC4A1F2F1C  : public Iterator_1_t88E927D3E5FC45C833C1A5146A04FBA17D02CA43
{
public:
	// System.Collections.Generic.List`1<TSource> System.Linq.Enumerable/WhereSelectListIterator`2::source
	List_1_t3F94120C77410A62EAE48421CF166B83AB95A2F5 * ___source_3;
	// System.Func`2<TSource,System.Boolean> System.Linq.Enumerable/WhereSelectListIterator`2::predicate
	Func_2_t99409DECFF50F0FA9B427C863AC6C99C66E6F9F8 * ___predicate_4;
	// System.Func`2<TSource,TResult> System.Linq.Enumerable/WhereSelectListIterator`2::selector
	Func_2_tF690BAA548D29EADC5635B1C8E7A7C6C9E4F7CFE * ___selector_5;
	// System.Collections.Generic.List`1/Enumerator<TSource> System.Linq.Enumerable/WhereSelectListIterator`2::enumerator
	Enumerator_tB6009981BD4E3881E3EC83627255A24198F902D6  ___enumerator_6;

public:
	inline static int32_t get_offset_of_source_3() { return static_cast<int32_t>(offsetof(WhereSelectListIterator_2_tAA7EB4891E566E311D0CC2850A8453EC4A1F2F1C, ___source_3)); }
	inline List_1_t3F94120C77410A62EAE48421CF166B83AB95A2F5 * get_source_3() const { return ___source_3; }
	inline List_1_t3F94120C77410A62EAE48421CF166B83AB95A2F5 ** get_address_of_source_3() { return &___source_3; }
	inline void set_source_3(List_1_t3F94120C77410A62EAE48421CF166B83AB95A2F5 * value)
	{
		___source_3 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___source_3), (void*)value);
	}

	inline static int32_t get_offset_of_predicate_4() { return static_cast<int32_t>(offsetof(WhereSelectListIterator_2_tAA7EB4891E566E311D0CC2850A8453EC4A1F2F1C, ___predicate_4)); }
	inline Func_2_t99409DECFF50F0FA9B427C863AC6C99C66E6F9F8 * get_predicate_4() const { return ___predicate_4; }
	inline Func_2_t99409DECFF50F0FA9B427C863AC6C99C66E6F9F8 ** get_address_of_predicate_4() { return &___predicate_4; }
	inline void set_predicate_4(Func_2_t99409DECFF50F0FA9B427C863AC6C99C66E6F9F8 * value)
	{
		___predicate_4 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___predicate_4), (void*)value);
	}

	inline static int32_t get_offset_of_selector_5() { return static_cast<int32_t>(offsetof(WhereSelectListIterator_2_tAA7EB4891E566E311D0CC2850A8453EC4A1F2F1C, ___selector_5)); }
	inline Func_2_tF690BAA548D29EADC5635B1C8E7A7C6C9E4F7CFE * get_selector_5() const { return ___selector_5; }
	inline Func_2_tF690BAA548D29EADC5635B1C8E7A7C6C9E4F7CFE ** get_address_of_selector_5() { return &___selector_5; }
	inline void set_selector_5(Func_2_tF690BAA548D29EADC5635B1C8E7A7C6C9E4F7CFE * value)
	{
		___selector_5 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___selector_5), (void*)value);
	}

	inline static int32_t get_offset_of_enumerator_6() { return static_cast<int32_t>(offsetof(WhereSelectListIterator_2_tAA7EB4891E566E311D0CC2850A8453EC4A1F2F1C, ___enumerator_6)); }
	inline Enumerator_tB6009981BD4E3881E3EC83627255A24198F902D6  get_enumerator_6() const { return ___enumerator_6; }
	inline Enumerator_tB6009981BD4E3881E3EC83627255A24198F902D6 * get_address_of_enumerator_6() { return &___enumerator_6; }
	inline void set_enumerator_6(Enumerator_tB6009981BD4E3881E3EC83627255A24198F902D6  value)
	{
		___enumerator_6 = value;
		Il2CppCodeGenWriteBarrier((void**)&(((&___enumerator_6))->___list_0), (void*)NULL);
		#if IL2CPP_ENABLE_STRICT_WRITE_BARRIERS
		Il2CppCodeGenWriteBarrier((void**)&(((&___enumerator_6))->___current_3), (void*)NULL);
		#endif
	}
};


// System.Linq.Enumerable/WhereSelectListIterator`2<System.Object,System.Nullable`1<System.Int64>>
struct WhereSelectListIterator_2_tDE07EDB851C318005CF3E85AFC71DB625406AACB  : public Iterator_1_t7714579EDED47F91E8FBA7AF6D3F0674241FDF6C
{
public:
	// System.Collections.Generic.List`1<TSource> System.Linq.Enumerable/WhereSelectListIterator`2::source
	List_1_t3F94120C77410A62EAE48421CF166B83AB95A2F5 * ___source_3;
	// System.Func`2<TSource,System.Boolean> System.Linq.Enumerable/WhereSelectListIterator`2::predicate
	Func_2_t99409DECFF50F0FA9B427C863AC6C99C66E6F9F8 * ___predicate_4;
	// System.Func`2<TSource,TResult> System.Linq.Enumerable/WhereSelectListIterator`2::selector
	Func_2_tF1DB5D7EFA801A89D60CE3A973ABC6EC71457FD5 * ___selector_5;
	// System.Collections.Generic.List`1/Enumerator<TSource> System.Linq.Enumerable/WhereSelectListIterator`2::enumerator
	Enumerator_tB6009981BD4E3881E3EC83627255A24198F902D6  ___enumerator_6;

public:
	inline static int32_t get_offset_of_source_3() { return static_cast<int32_t>(offsetof(WhereSelectListIterator_2_tDE07EDB851C318005CF3E85AFC71DB625406AACB, ___source_3)); }
	inline List_1_t3F94120C77410A62EAE48421CF166B83AB95A2F5 * get_source_3() const { return ___source_3; }
	inline List_1_t3F94120C77410A62EAE48421CF166B83AB95A2F5 ** get_address_of_source_3() { return &___source_3; }
	inline void set_source_3(List_1_t3F94120C77410A62EAE48421CF166B83AB95A2F5 * value)
	{
		___source_3 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___source_3), (void*)value);
	}

	inline static int32_t get_offset_of_predicate_4() { return static_cast<int32_t>(offsetof(WhereSelectListIterator_2_tDE07EDB851C318005CF3E85AFC71DB625406AACB, ___predicate_4)); }
	inline Func_2_t99409DECFF50F0FA9B427C863AC6C99C66E6F9F8 * get_predicate_4() const { return ___predicate_4; }
	inline Func_2_t99409DECFF50F0FA9B427C863AC6C99C66E6F9F8 ** get_address_of_predicate_4() { return &___predicate_4; }
	inline void set_predicate_4(Func_2_t99409DECFF50F0FA9B427C863AC6C99C66E6F9F8 * value)
	{
		___predicate_4 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___predicate_4), (void*)value);
	}

	inline static int32_t get_offset_of_selector_5() { return static_cast<int32_t>(offsetof(WhereSelectListIterator_2_tDE07EDB851C318005CF3E85AFC71DB625406AACB, ___selector_5)); }
	inline Func_2_tF1DB5D7EFA801A89D60CE3A973ABC6EC71457FD5 * get_selector_5() const { return ___selector_5; }
	inline Func_2_tF1DB5D7EFA801A89D60CE3A973ABC6EC71457FD5 ** get_address_of_selector_5() { return &___selector_5; }
	inline void set_selector_5(Func_2_tF1DB5D7EFA801A89D60CE3A973ABC6EC71457FD5 * value)
	{
		___selector_5 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___selector_5), (void*)value);
	}

	inline static int32_t get_offset_of_enumerator_6() { return static_cast<int32_t>(offsetof(WhereSelectListIterator_2_tDE07EDB851C318005CF3E85AFC71DB625406AACB, ___enumerator_6)); }
	inline Enumerator_tB6009981BD4E3881E3EC83627255A24198F902D6  get_enumerator_6() const { return ___enumerator_6; }
	inline Enumerator_tB6009981BD4E3881E3EC83627255A24198F902D6 * get_address_of_enumerator_6() { return &___enumerator_6; }
	inline void set_enumerator_6(Enumerator_tB6009981BD4E3881E3EC83627255A24198F902D6  value)
	{
		___enumerator_6 = value;
		Il2CppCodeGenWriteBarrier((void**)&(((&___enumerator_6))->___list_0), (void*)NULL);
		#if IL2CPP_ENABLE_STRICT_WRITE_BARRIERS
		Il2CppCodeGenWriteBarrier((void**)&(((&___enumerator_6))->___current_3), (void*)NULL);
		#endif
	}
};


// System.Linq.Enumerable/WhereSelectListIterator`2<System.Object,System.Nullable`1<System.Single>>
struct WhereSelectListIterator_2_tA3FAD38D0543C622EB734E603C9C973343DA791B  : public Iterator_1_t5F8CC81E7DD3167D5EC5BFC0984EBCEE64F5B45E
{
public:
	// System.Collections.Generic.List`1<TSource> System.Linq.Enumerable/WhereSelectListIterator`2::source
	List_1_t3F94120C77410A62EAE48421CF166B83AB95A2F5 * ___source_3;
	// System.Func`2<TSource,System.Boolean> System.Linq.Enumerable/WhereSelectListIterator`2::predicate
	Func_2_t99409DECFF50F0FA9B427C863AC6C99C66E6F9F8 * ___predicate_4;
	// System.Func`2<TSource,TResult> System.Linq.Enumerable/WhereSelectListIterator`2::selector
	Func_2_t936E494B9795BDACAC731255502447EA0D04753F * ___selector_5;
	// System.Collections.Generic.List`1/Enumerator<TSource> System.Linq.Enumerable/WhereSelectListIterator`2::enumerator
	Enumerator_tB6009981BD4E3881E3EC83627255A24198F902D6  ___enumerator_6;

public:
	inline static int32_t get_offset_of_source_3() { return static_cast<int32_t>(offsetof(WhereSelectListIterator_2_tA3FAD38D0543C622EB734E603C9C973343DA791B, ___source_3)); }
	inline List_1_t3F94120C77410A62EAE48421CF166B83AB95A2F5 * get_source_3() const { return ___source_3; }
	inline List_1_t3F94120C77410A62EAE48421CF166B83AB95A2F5 ** get_address_of_source_3() { return &___source_3; }
	inline void set_source_3(List_1_t3F94120C77410A62EAE48421CF166B83AB95A2F5 * value)
	{
		___source_3 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___source_3), (void*)value);
	}

	inline static int32_t get_offset_of_predicate_4() { return static_cast<int32_t>(offsetof(WhereSelectListIterator_2_tA3FAD38D0543C622EB734E603C9C973343DA791B, ___predicate_4)); }
	inline Func_2_t99409DECFF50F0FA9B427C863AC6C99C66E6F9F8 * get_predicate_4() const { return ___predicate_4; }
	inline Func_2_t99409DECFF50F0FA9B427C863AC6C99C66E6F9F8 ** get_address_of_predicate_4() { return &___predicate_4; }
	inline void set_predicate_4(Func_2_t99409DECFF50F0FA9B427C863AC6C99C66E6F9F8 * value)
	{
		___predicate_4 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___predicate_4), (void*)value);
	}

	inline static int32_t get_offset_of_selector_5() { return static_cast<int32_t>(offsetof(WhereSelectListIterator_2_tA3FAD38D0543C622EB734E603C9C973343DA791B, ___selector_5)); }
	inline Func_2_t936E494B9795BDACAC731255502447EA0D04753F * get_selector_5() const { return ___selector_5; }
	inline Func_2_t936E494B9795BDACAC731255502447EA0D04753F ** get_address_of_selector_5() { return &___selector_5; }
	inline void set_selector_5(Func_2_t936E494B9795BDACAC731255502447EA0D04753F * value)
	{
		___selector_5 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___selector_5), (void*)value);
	}

	inline static int32_t get_offset_of_enumerator_6() { return static_cast<int32_t>(offsetof(WhereSelectListIterator_2_tA3FAD38D0543C622EB734E603C9C973343DA791B, ___enumerator_6)); }
	inline Enumerator_tB6009981BD4E3881E3EC83627255A24198F902D6  get_enumerator_6() const { return ___enumerator_6; }
	inline Enumerator_tB6009981BD4E3881E3EC83627255A24198F902D6 * get_address_of_enumerator_6() { return &___enumerator_6; }
	inline void set_enumerator_6(Enumerator_tB6009981BD4E3881E3EC83627255A24198F902D6  value)
	{
		___enumerator_6 = value;
		Il2CppCodeGenWriteBarrier((void**)&(((&___enumerator_6))->___list_0), (void*)NULL);
		#if IL2CPP_ENABLE_STRICT_WRITE_BARRIERS
		Il2CppCodeGenWriteBarrier((void**)&(((&___enumerator_6))->___current_3), (void*)NULL);
		#endif
	}
};


// System.Linq.Enumerable/WhereSelectListIterator`2<System.Object,System.Decimal>
struct WhereSelectListIterator_2_t613751E34DF4E5DB1F8E3A1B3B14696B0408ED62  : public Iterator_1_t4861EDEAC91472CDE6F71F17BA6EF43B5D56F78E
{
public:
	// System.Collections.Generic.List`1<TSource> System.Linq.Enumerable/WhereSelectListIterator`2::source
	List_1_t3F94120C77410A62EAE48421CF166B83AB95A2F5 * ___source_3;
	// System.Func`2<TSource,System.Boolean> System.Linq.Enumerable/WhereSelectListIterator`2::predicate
	Func_2_t99409DECFF50F0FA9B427C863AC6C99C66E6F9F8 * ___predicate_4;
	// System.Func`2<TSource,TResult> System.Linq.Enumerable/WhereSelectListIterator`2::selector
	Func_2_t849BC6BC29946D6D8A1A3EB4E4406C8ADBD11CAA * ___selector_5;
	// System.Collections.Generic.List`1/Enumerator<TSource> System.Linq.Enumerable/WhereSelectListIterator`2::enumerator
	Enumerator_tB6009981BD4E3881E3EC83627255A24198F902D6  ___enumerator_6;

public:
	inline static int32_t get_offset_of_source_3() { return static_cast<int32_t>(offsetof(WhereSelectListIterator_2_t613751E34DF4E5DB1F8E3A1B3B14696B0408ED62, ___source_3)); }
	inline List_1_t3F94120C77410A62EAE48421CF166B83AB95A2F5 * get_source_3() const { return ___source_3; }
	inline List_1_t3F94120C77410A62EAE48421CF166B83AB95A2F5 ** get_address_of_source_3() { return &___source_3; }
	inline void set_source_3(List_1_t3F94120C77410A62EAE48421CF166B83AB95A2F5 * value)
	{
		___source_3 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___source_3), (void*)value);
	}

	inline static int32_t get_offset_of_predicate_4() { return static_cast<int32_t>(offsetof(WhereSelectListIterator_2_t613751E34DF4E5DB1F8E3A1B3B14696B0408ED62, ___predicate_4)); }
	inline Func_2_t99409DECFF50F0FA9B427C863AC6C99C66E6F9F8 * get_predicate_4() const { return ___predicate_4; }
	inline Func_2_t99409DECFF50F0FA9B427C863AC6C99C66E6F9F8 ** get_address_of_predicate_4() { return &___predicate_4; }
	inline void set_predicate_4(Func_2_t99409DECFF50F0FA9B427C863AC6C99C66E6F9F8 * value)
	{
		___predicate_4 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___predicate_4), (void*)value);
	}

	inline static int32_t get_offset_of_selector_5() { return static_cast<int32_t>(offsetof(WhereSelectListIterator_2_t613751E34DF4E5DB1F8E3A1B3B14696B0408ED62, ___selector_5)); }
	inline Func_2_t849BC6BC29946D6D8A1A3EB4E4406C8ADBD11CAA * get_selector_5() const { return ___selector_5; }
	inline Func_2_t849BC6BC29946D6D8A1A3EB4E4406C8ADBD11CAA ** get_address_of_selector_5() { return &___selector_5; }
	inline void set_selector_5(Func_2_t849BC6BC29946D6D8A1A3EB4E4406C8ADBD11CAA * value)
	{
		___selector_5 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___selector_5), (void*)value);
	}

	inline static int32_t get_offset_of_enumerator_6() { return static_cast<int32_t>(offsetof(WhereSelectListIterator_2_t613751E34DF4E5DB1F8E3A1B3B14696B0408ED62, ___enumerator_6)); }
	inline Enumerator_tB6009981BD4E3881E3EC83627255A24198F902D6  get_enumerator_6() const { return ___enumerator_6; }
	inline Enumerator_tB6009981BD4E3881E3EC83627255A24198F902D6 * get_address_of_enumerator_6() { return &___enumerator_6; }
	inline void set_enumerator_6(Enumerator_tB6009981BD4E3881E3EC83627255A24198F902D6  value)
	{
		___enumerator_6 = value;
		Il2CppCodeGenWriteBarrier((void**)&(((&___enumerator_6))->___list_0), (void*)NULL);
		#if IL2CPP_ENABLE_STRICT_WRITE_BARRIERS
		Il2CppCodeGenWriteBarrier((void**)&(((&___enumerator_6))->___current_3), (void*)NULL);
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

// System.Func`2<System.Nullable`1<System.Decimal>,System.Boolean>
struct Func_2_t04450D4888681586D3F4812C491231E855EF5DE7  : public MulticastDelegate_t
{
public:

public:
};


// System.Func`2<System.Nullable`1<System.Double>,System.Boolean>
struct Func_2_t4B7DAD120FE072A61F61F9158CB1013D6F95E130  : public MulticastDelegate_t
{
public:

public:
};


// System.Func`2<System.Nullable`1<System.Int32>,System.Boolean>
struct Func_2_t42993C24F11175D8FA98C3DB6E40DC467687C57D  : public MulticastDelegate_t
{
public:

public:
};


// System.Func`2<System.Nullable`1<System.Int64>,System.Boolean>
struct Func_2_t1637E276420B054B58108E2AD51B1537DEC785D9  : public MulticastDelegate_t
{
public:

public:
};


// System.Func`2<System.Nullable`1<System.Single>,System.Boolean>
struct Func_2_t9B3CA7186DE9A33B978124F5B7131DD16456B41A  : public MulticastDelegate_t
{
public:

public:
};


// System.Func`2<System.ValueTuple`2<System.Object,System.Object>,System.Boolean>
struct Func_2_t139EF32B1D20FBA53B5FC13859124C746B2D3C04  : public MulticastDelegate_t
{
public:

public:
};


// System.Func`2<System.ValueTuple`2<System.Object,System.Object>,System.Int32>
struct Func_2_tEB5259FF5AA54436077282823F2EEBED7C80AECF  : public MulticastDelegate_t
{
public:

public:
};


// System.Func`2<System.ValueTuple`2<System.Object,System.Object>,System.Int64>
struct Func_2_tCCE8B772536DC33F644E3A0108AA7059ABA2EDB3  : public MulticastDelegate_t
{
public:

public:
};


// System.Func`2<System.ValueTuple`2<System.Object,System.Object>,System.Object>
struct Func_2_tD5B31A0553FE51700369DE1E4E6F33189C45045A  : public MulticastDelegate_t
{
public:

public:
};


// System.Func`2<System.ValueTuple`2<System.Object,System.Object>,System.Single>
struct Func_2_tCFA319B29B51C5B4FA9EE912CCB3BB9525555F72  : public MulticastDelegate_t
{
public:

public:
};


// System.Func`2<System.Boolean,System.Boolean>
struct Func_2_t50F598941CFDF02619DC5D52FFDBC329473C5F7B  : public MulticastDelegate_t
{
public:

public:
};


// System.Func`2<System.Boolean,System.Object>
struct Func_2_t51AFCB712DCD56A45EE1645FC1762C549DA040FB  : public MulticastDelegate_t
{
public:

public:
};


// System.Func`2<UnityEngine.Color,System.Boolean>
struct Func_2_t3985FFDAB0D05F8E97E8EA849D5A24F16EFFC4FD  : public MulticastDelegate_t
{
public:

public:
};


// System.Func`2<UnityEngine.Experimental.Rendering.Universal.LibTessDotNet.ContourVertex,System.Boolean>
struct Func_2_tD4EF074F88731E713305C48E156AB9F6F0F9324A  : public MulticastDelegate_t
{
public:

public:
};


// System.Func`2<UnityEngine.Experimental.Rendering.Universal.LibTessDotNet.ContourVertex,UnityEngine.Color>
struct Func_2_t07574F1E7EF84CF543A9B2FF0E62BB6B96696C64  : public MulticastDelegate_t
{
public:

public:
};


// System.Func`2<UnityEngine.Experimental.Rendering.Universal.LibTessDotNet.ContourVertex,UnityEngine.Vector3>
struct Func_2_tA55660D7B36BC919063457215A12594F309CFDF1  : public MulticastDelegate_t
{
public:

public:
};


// System.Func`2<UnityEngine.Experimental.Rendering.Universal.LibTessDotNet.ContourVertex,Unity.Mathematics.float3>
struct Func_2_t4ADAECFAD3DFE1FE3B6834A49502FA772B85CB3C  : public MulticastDelegate_t
{
public:

public:
};


// System.Func`2<System.Decimal,System.Boolean>
struct Func_2_t85912C5553CB5462E74F14A32388FC1004CC7C2E  : public MulticastDelegate_t
{
public:

public:
};


// System.Func`2<System.Decimal,System.Object>
struct Func_2_t19AF92FE90E4D29194E67E9C39AA7BDBF405CD01  : public MulticastDelegate_t
{
public:

public:
};


// System.Func`2<System.Double,System.Boolean>
struct Func_2_t4E607BF9FA9E115F43BD77F92F4285E3B8C7FB0D  : public MulticastDelegate_t
{
public:

public:
};


// System.Func`2<System.Double,System.Object>
struct Func_2_t9250D6A3AAE1BC9DC97036CF116D97FC17C08719  : public MulticastDelegate_t
{
public:

public:
};


// System.Func`2<System.Int32,System.Nullable`1<System.Decimal>>
struct Func_2_t2CF7067ECC6F2E1B8FC552857749A03DC1E5AE1E  : public MulticastDelegate_t
{
public:

public:
};


// System.Func`2<System.Int32,System.Nullable`1<System.Double>>
struct Func_2_t6C7618E0D575852E15D00A9E3CA463CE2CF5D159  : public MulticastDelegate_t
{
public:

public:
};


// System.Func`2<System.Int32,System.Nullable`1<System.Int32>>
struct Func_2_t212214032B3E2E671F2871ED55DFBC92A4EBD9C3  : public MulticastDelegate_t
{
public:

public:
};


// System.Func`2<System.Int32,System.Nullable`1<System.Int64>>
struct Func_2_tC286DBD1D3140BC4FC4D1DCF2D41DE03E72D8CAF  : public MulticastDelegate_t
{
public:

public:
};


// System.Func`2<System.Int32,System.Nullable`1<System.Single>>
struct Func_2_t6663A9FD2A53E3B599DF99EC970BF2320E8D9D40  : public MulticastDelegate_t
{
public:

public:
};


// System.Func`2<System.Int32,System.Boolean>
struct Func_2_t2EBF98B0BA555D9F0633C9BCCBE3DF332B9C1274  : public MulticastDelegate_t
{
public:

public:
};


// System.Func`2<System.Int32,System.Decimal>
struct Func_2_tBF5E42259B30DEB08B8F01DEAD14034173D7F115  : public MulticastDelegate_t
{
public:

public:
};


// System.Func`2<System.Int32,System.Double>
struct Func_2_t23C797B165C3B4B97ADF0BE92281F030E672AD4B  : public MulticastDelegate_t
{
public:

public:
};


// System.Func`2<System.Int32,System.Int32>
struct Func_2_tFF6AE79EFD0857556AD37A1A1594C43F76012FEA  : public MulticastDelegate_t
{
public:

public:
};


// System.Func`2<System.Int32,System.Int64>
struct Func_2_tAB99B2018719C6ADFD37FB04A207F07169AE46E0  : public MulticastDelegate_t
{
public:

public:
};


// System.Func`2<System.Int32,System.Object>
struct Func_2_t401E8A228CE43E56CCE9280AD9C6D87CC73A0123  : public MulticastDelegate_t
{
public:

public:
};


// System.Func`2<System.Int32,System.Single>
struct Func_2_t1452DFFA61F60F54CF3A78C987C4F98906EFD2B6  : public MulticastDelegate_t
{
public:

public:
};


// System.Func`2<System.Int64,System.Boolean>
struct Func_2_t03B9AF86FB7E93B62590F1CBD16276EF7AA1B215  : public MulticastDelegate_t
{
public:

public:
};


// System.Func`2<System.Int64,System.Object>
struct Func_2_tB6B8AC34A03E8EEE1C7FF71178B07B46BC827B7B  : public MulticastDelegate_t
{
public:

public:
};


// System.Func`2<System.Object,System.Nullable`1<System.Decimal>>
struct Func_2_t3818905EA774DF4C16A3B852ECBDEAA1B10478B4  : public MulticastDelegate_t
{
public:

public:
};


// System.Func`2<System.Object,System.Nullable`1<System.Double>>
struct Func_2_t969BC5FC9B68C7023AE4F7C254A78F446A7609F8  : public MulticastDelegate_t
{
public:

public:
};


// System.Func`2<System.Object,System.Nullable`1<System.Int32>>
struct Func_2_tF690BAA548D29EADC5635B1C8E7A7C6C9E4F7CFE  : public MulticastDelegate_t
{
public:

public:
};


// System.Func`2<System.Object,System.Nullable`1<System.Int64>>
struct Func_2_tF1DB5D7EFA801A89D60CE3A973ABC6EC71457FD5  : public MulticastDelegate_t
{
public:

public:
};


// System.Func`2<System.Object,System.Nullable`1<System.Single>>
struct Func_2_t936E494B9795BDACAC731255502447EA0D04753F  : public MulticastDelegate_t
{
public:

public:
};


// System.Func`2<System.Object,System.Boolean>
struct Func_2_t99409DECFF50F0FA9B427C863AC6C99C66E6F9F8  : public MulticastDelegate_t
{
public:

public:
};


// System.Func`2<System.Object,System.Decimal>
struct Func_2_t849BC6BC29946D6D8A1A3EB4E4406C8ADBD11CAA  : public MulticastDelegate_t
{
public:

public:
};


// System.Func`2<System.Object,System.Double>
struct Func_2_t32F4E81162C0EB5B67EF4324ABCC54A453AB7B22  : public MulticastDelegate_t
{
public:

public:
};


// System.Func`2<System.Object,System.Int32>
struct Func_2_t0CEE9D1C856153BA9C23BB9D7E929D577AF37A2C  : public MulticastDelegate_t
{
public:

public:
};


// System.Func`2<System.Object,System.Int64>
struct Func_2_tCA3E9A68051723CDABE44FC0BAE52FE7599059D6  : public MulticastDelegate_t
{
public:

public:
};


// System.Func`2<System.Object,System.Object>
struct Func_2_tFF5BB8F40A35B1BEA00D4EBBC6CBE7184A584436  : public MulticastDelegate_t
{
public:

public:
};


// System.Func`2<System.Object,System.Single>
struct Func_2_t78F21BB7B6C7D754A8C4D71ACB39668A8F967BA1  : public MulticastDelegate_t
{
public:

public:
};


// System.Func`2<System.Single,System.Boolean>
struct Func_2_t7214BC9C9A47482C751067B9A197D164F4041A3A  : public MulticastDelegate_t
{
public:

public:
};


// System.Func`2<System.Single,System.Object>
struct Func_2_tE11BDF71BCB314E58F1A9CFC9DAE08A5F717E2A0  : public MulticastDelegate_t
{
public:

public:
};


// System.Func`2<UnityEngine.Vector3,System.Boolean>
struct Func_2_t3041FD3183D19FE8416AE2E43A6398B2C06B7269  : public MulticastDelegate_t
{
public:

public:
};


// System.Func`2<Unity.Mathematics.float3,System.Boolean>
struct Func_2_t43355C55B1BBA93635101F6AF90867509812D7E5  : public MulticastDelegate_t
{
public:

public:
};


// System.Func`3<System.Object,System.Object,System.Object>
struct Func_3_tBBBFF266D23D5A9A7940D16DA73BCD5DE0753A27  : public MulticastDelegate_t
{
public:

public:
};


// System.Linq.Enumerable/WhereEnumerableIterator`1<System.Nullable`1<System.Decimal>>
struct WhereEnumerableIterator_1_tC23C2A31FF955909EB9C6795D474D218DB84F0F5  : public Iterator_1_tC3AC38DE0A9857A77F64882DC49BB78318A5EF00
{
public:
	// System.Collections.Generic.IEnumerable`1<TSource> System.Linq.Enumerable/WhereEnumerableIterator`1::source
	RuntimeObject* ___source_3;
	// System.Func`2<TSource,System.Boolean> System.Linq.Enumerable/WhereEnumerableIterator`1::predicate
	Func_2_t04450D4888681586D3F4812C491231E855EF5DE7 * ___predicate_4;
	// System.Collections.Generic.IEnumerator`1<TSource> System.Linq.Enumerable/WhereEnumerableIterator`1::enumerator
	RuntimeObject* ___enumerator_5;

public:
	inline static int32_t get_offset_of_source_3() { return static_cast<int32_t>(offsetof(WhereEnumerableIterator_1_tC23C2A31FF955909EB9C6795D474D218DB84F0F5, ___source_3)); }
	inline RuntimeObject* get_source_3() const { return ___source_3; }
	inline RuntimeObject** get_address_of_source_3() { return &___source_3; }
	inline void set_source_3(RuntimeObject* value)
	{
		___source_3 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___source_3), (void*)value);
	}

	inline static int32_t get_offset_of_predicate_4() { return static_cast<int32_t>(offsetof(WhereEnumerableIterator_1_tC23C2A31FF955909EB9C6795D474D218DB84F0F5, ___predicate_4)); }
	inline Func_2_t04450D4888681586D3F4812C491231E855EF5DE7 * get_predicate_4() const { return ___predicate_4; }
	inline Func_2_t04450D4888681586D3F4812C491231E855EF5DE7 ** get_address_of_predicate_4() { return &___predicate_4; }
	inline void set_predicate_4(Func_2_t04450D4888681586D3F4812C491231E855EF5DE7 * value)
	{
		___predicate_4 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___predicate_4), (void*)value);
	}

	inline static int32_t get_offset_of_enumerator_5() { return static_cast<int32_t>(offsetof(WhereEnumerableIterator_1_tC23C2A31FF955909EB9C6795D474D218DB84F0F5, ___enumerator_5)); }
	inline RuntimeObject* get_enumerator_5() const { return ___enumerator_5; }
	inline RuntimeObject** get_address_of_enumerator_5() { return &___enumerator_5; }
	inline void set_enumerator_5(RuntimeObject* value)
	{
		___enumerator_5 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___enumerator_5), (void*)value);
	}
};


// System.Linq.Enumerable/WhereSelectListIterator`2<UnityEngine.Experimental.Rendering.Universal.LibTessDotNet.ContourVertex,UnityEngine.Color>
struct WhereSelectListIterator_2_t08B768B4AD54F201B800C51471E1C1C5FD1A8E8C  : public Iterator_1_tDEF6AC46E52D8687C27A6E60B6E0200D50011D76
{
public:
	// System.Collections.Generic.List`1<TSource> System.Linq.Enumerable/WhereSelectListIterator`2::source
	List_1_t793A994CE01AE29FEE85500B7E3540653BFE5A0C * ___source_3;
	// System.Func`2<TSource,System.Boolean> System.Linq.Enumerable/WhereSelectListIterator`2::predicate
	Func_2_tD4EF074F88731E713305C48E156AB9F6F0F9324A * ___predicate_4;
	// System.Func`2<TSource,TResult> System.Linq.Enumerable/WhereSelectListIterator`2::selector
	Func_2_t07574F1E7EF84CF543A9B2FF0E62BB6B96696C64 * ___selector_5;
	// System.Collections.Generic.List`1/Enumerator<TSource> System.Linq.Enumerable/WhereSelectListIterator`2::enumerator
	Enumerator_t0A364062D6EEDD0B306D570939B5709AEAA88D11  ___enumerator_6;

public:
	inline static int32_t get_offset_of_source_3() { return static_cast<int32_t>(offsetof(WhereSelectListIterator_2_t08B768B4AD54F201B800C51471E1C1C5FD1A8E8C, ___source_3)); }
	inline List_1_t793A994CE01AE29FEE85500B7E3540653BFE5A0C * get_source_3() const { return ___source_3; }
	inline List_1_t793A994CE01AE29FEE85500B7E3540653BFE5A0C ** get_address_of_source_3() { return &___source_3; }
	inline void set_source_3(List_1_t793A994CE01AE29FEE85500B7E3540653BFE5A0C * value)
	{
		___source_3 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___source_3), (void*)value);
	}

	inline static int32_t get_offset_of_predicate_4() { return static_cast<int32_t>(offsetof(WhereSelectListIterator_2_t08B768B4AD54F201B800C51471E1C1C5FD1A8E8C, ___predicate_4)); }
	inline Func_2_tD4EF074F88731E713305C48E156AB9F6F0F9324A * get_predicate_4() const { return ___predicate_4; }
	inline Func_2_tD4EF074F88731E713305C48E156AB9F6F0F9324A ** get_address_of_predicate_4() { return &___predicate_4; }
	inline void set_predicate_4(Func_2_tD4EF074F88731E713305C48E156AB9F6F0F9324A * value)
	{
		___predicate_4 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___predicate_4), (void*)value);
	}

	inline static int32_t get_offset_of_selector_5() { return static_cast<int32_t>(offsetof(WhereSelectListIterator_2_t08B768B4AD54F201B800C51471E1C1C5FD1A8E8C, ___selector_5)); }
	inline Func_2_t07574F1E7EF84CF543A9B2FF0E62BB6B96696C64 * get_selector_5() const { return ___selector_5; }
	inline Func_2_t07574F1E7EF84CF543A9B2FF0E62BB6B96696C64 ** get_address_of_selector_5() { return &___selector_5; }
	inline void set_selector_5(Func_2_t07574F1E7EF84CF543A9B2FF0E62BB6B96696C64 * value)
	{
		___selector_5 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___selector_5), (void*)value);
	}

	inline static int32_t get_offset_of_enumerator_6() { return static_cast<int32_t>(offsetof(WhereSelectListIterator_2_t08B768B4AD54F201B800C51471E1C1C5FD1A8E8C, ___enumerator_6)); }
	inline Enumerator_t0A364062D6EEDD0B306D570939B5709AEAA88D11  get_enumerator_6() const { return ___enumerator_6; }
	inline Enumerator_t0A364062D6EEDD0B306D570939B5709AEAA88D11 * get_address_of_enumerator_6() { return &___enumerator_6; }
	inline void set_enumerator_6(Enumerator_t0A364062D6EEDD0B306D570939B5709AEAA88D11  value)
	{
		___enumerator_6 = value;
		Il2CppCodeGenWriteBarrier((void**)&(((&___enumerator_6))->___list_0), (void*)NULL);
		#if IL2CPP_ENABLE_STRICT_WRITE_BARRIERS
		Il2CppCodeGenWriteBarrier((void**)&((&(((&___enumerator_6))->___current_3))->___Data_1), (void*)NULL);
		#endif
	}
};


// System.Linq.Enumerable/WhereSelectListIterator`2<UnityEngine.Experimental.Rendering.Universal.LibTessDotNet.ContourVertex,UnityEngine.Vector3>
struct WhereSelectListIterator_2_t94F415FEA624816E42FAE1274A4EC29F5D5C1625  : public Iterator_1_t04F5D870FD247BBBEE27254587FA10F440D4EEFF
{
public:
	// System.Collections.Generic.List`1<TSource> System.Linq.Enumerable/WhereSelectListIterator`2::source
	List_1_t793A994CE01AE29FEE85500B7E3540653BFE5A0C * ___source_3;
	// System.Func`2<TSource,System.Boolean> System.Linq.Enumerable/WhereSelectListIterator`2::predicate
	Func_2_tD4EF074F88731E713305C48E156AB9F6F0F9324A * ___predicate_4;
	// System.Func`2<TSource,TResult> System.Linq.Enumerable/WhereSelectListIterator`2::selector
	Func_2_tA55660D7B36BC919063457215A12594F309CFDF1 * ___selector_5;
	// System.Collections.Generic.List`1/Enumerator<TSource> System.Linq.Enumerable/WhereSelectListIterator`2::enumerator
	Enumerator_t0A364062D6EEDD0B306D570939B5709AEAA88D11  ___enumerator_6;

public:
	inline static int32_t get_offset_of_source_3() { return static_cast<int32_t>(offsetof(WhereSelectListIterator_2_t94F415FEA624816E42FAE1274A4EC29F5D5C1625, ___source_3)); }
	inline List_1_t793A994CE01AE29FEE85500B7E3540653BFE5A0C * get_source_3() const { return ___source_3; }
	inline List_1_t793A994CE01AE29FEE85500B7E3540653BFE5A0C ** get_address_of_source_3() { return &___source_3; }
	inline void set_source_3(List_1_t793A994CE01AE29FEE85500B7E3540653BFE5A0C * value)
	{
		___source_3 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___source_3), (void*)value);
	}

	inline static int32_t get_offset_of_predicate_4() { return static_cast<int32_t>(offsetof(WhereSelectListIterator_2_t94F415FEA624816E42FAE1274A4EC29F5D5C1625, ___predicate_4)); }
	inline Func_2_tD4EF074F88731E713305C48E156AB9F6F0F9324A * get_predicate_4() const { return ___predicate_4; }
	inline Func_2_tD4EF074F88731E713305C48E156AB9F6F0F9324A ** get_address_of_predicate_4() { return &___predicate_4; }
	inline void set_predicate_4(Func_2_tD4EF074F88731E713305C48E156AB9F6F0F9324A * value)
	{
		___predicate_4 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___predicate_4), (void*)value);
	}

	inline static int32_t get_offset_of_selector_5() { return static_cast<int32_t>(offsetof(WhereSelectListIterator_2_t94F415FEA624816E42FAE1274A4EC29F5D5C1625, ___selector_5)); }
	inline Func_2_tA55660D7B36BC919063457215A12594F309CFDF1 * get_selector_5() const { return ___selector_5; }
	inline Func_2_tA55660D7B36BC919063457215A12594F309CFDF1 ** get_address_of_selector_5() { return &___selector_5; }
	inline void set_selector_5(Func_2_tA55660D7B36BC919063457215A12594F309CFDF1 * value)
	{
		___selector_5 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___selector_5), (void*)value);
	}

	inline static int32_t get_offset_of_enumerator_6() { return static_cast<int32_t>(offsetof(WhereSelectListIterator_2_t94F415FEA624816E42FAE1274A4EC29F5D5C1625, ___enumerator_6)); }
	inline Enumerator_t0A364062D6EEDD0B306D570939B5709AEAA88D11  get_enumerator_6() const { return ___enumerator_6; }
	inline Enumerator_t0A364062D6EEDD0B306D570939B5709AEAA88D11 * get_address_of_enumerator_6() { return &___enumerator_6; }
	inline void set_enumerator_6(Enumerator_t0A364062D6EEDD0B306D570939B5709AEAA88D11  value)
	{
		___enumerator_6 = value;
		Il2CppCodeGenWriteBarrier((void**)&(((&___enumerator_6))->___list_0), (void*)NULL);
		#if IL2CPP_ENABLE_STRICT_WRITE_BARRIERS
		Il2CppCodeGenWriteBarrier((void**)&((&(((&___enumerator_6))->___current_3))->___Data_1), (void*)NULL);
		#endif
	}
};


// System.Linq.Enumerable/WhereSelectListIterator`2<UnityEngine.Experimental.Rendering.Universal.LibTessDotNet.ContourVertex,Unity.Mathematics.float3>
struct WhereSelectListIterator_2_t8005F348CC0B870A84DE3E85429A840305201D6E  : public Iterator_1_tCEC2E244A64F110B247B6A3DF34DE60D4456BA1A
{
public:
	// System.Collections.Generic.List`1<TSource> System.Linq.Enumerable/WhereSelectListIterator`2::source
	List_1_t793A994CE01AE29FEE85500B7E3540653BFE5A0C * ___source_3;
	// System.Func`2<TSource,System.Boolean> System.Linq.Enumerable/WhereSelectListIterator`2::predicate
	Func_2_tD4EF074F88731E713305C48E156AB9F6F0F9324A * ___predicate_4;
	// System.Func`2<TSource,TResult> System.Linq.Enumerable/WhereSelectListIterator`2::selector
	Func_2_t4ADAECFAD3DFE1FE3B6834A49502FA772B85CB3C * ___selector_5;
	// System.Collections.Generic.List`1/Enumerator<TSource> System.Linq.Enumerable/WhereSelectListIterator`2::enumerator
	Enumerator_t0A364062D6EEDD0B306D570939B5709AEAA88D11  ___enumerator_6;

public:
	inline static int32_t get_offset_of_source_3() { return static_cast<int32_t>(offsetof(WhereSelectListIterator_2_t8005F348CC0B870A84DE3E85429A840305201D6E, ___source_3)); }
	inline List_1_t793A994CE01AE29FEE85500B7E3540653BFE5A0C * get_source_3() const { return ___source_3; }
	inline List_1_t793A994CE01AE29FEE85500B7E3540653BFE5A0C ** get_address_of_source_3() { return &___source_3; }
	inline void set_source_3(List_1_t793A994CE01AE29FEE85500B7E3540653BFE5A0C * value)
	{
		___source_3 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___source_3), (void*)value);
	}

	inline static int32_t get_offset_of_predicate_4() { return static_cast<int32_t>(offsetof(WhereSelectListIterator_2_t8005F348CC0B870A84DE3E85429A840305201D6E, ___predicate_4)); }
	inline Func_2_tD4EF074F88731E713305C48E156AB9F6F0F9324A * get_predicate_4() const { return ___predicate_4; }
	inline Func_2_tD4EF074F88731E713305C48E156AB9F6F0F9324A ** get_address_of_predicate_4() { return &___predicate_4; }
	inline void set_predicate_4(Func_2_tD4EF074F88731E713305C48E156AB9F6F0F9324A * value)
	{
		___predicate_4 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___predicate_4), (void*)value);
	}

	inline static int32_t get_offset_of_selector_5() { return static_cast<int32_t>(offsetof(WhereSelectListIterator_2_t8005F348CC0B870A84DE3E85429A840305201D6E, ___selector_5)); }
	inline Func_2_t4ADAECFAD3DFE1FE3B6834A49502FA772B85CB3C * get_selector_5() const { return ___selector_5; }
	inline Func_2_t4ADAECFAD3DFE1FE3B6834A49502FA772B85CB3C ** get_address_of_selector_5() { return &___selector_5; }
	inline void set_selector_5(Func_2_t4ADAECFAD3DFE1FE3B6834A49502FA772B85CB3C * value)
	{
		___selector_5 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___selector_5), (void*)value);
	}

	inline static int32_t get_offset_of_enumerator_6() { return static_cast<int32_t>(offsetof(WhereSelectListIterator_2_t8005F348CC0B870A84DE3E85429A840305201D6E, ___enumerator_6)); }
	inline Enumerator_t0A364062D6EEDD0B306D570939B5709AEAA88D11  get_enumerator_6() const { return ___enumerator_6; }
	inline Enumerator_t0A364062D6EEDD0B306D570939B5709AEAA88D11 * get_address_of_enumerator_6() { return &___enumerator_6; }
	inline void set_enumerator_6(Enumerator_t0A364062D6EEDD0B306D570939B5709AEAA88D11  value)
	{
		___enumerator_6 = value;
		Il2CppCodeGenWriteBarrier((void**)&(((&___enumerator_6))->___list_0), (void*)NULL);
		#if IL2CPP_ENABLE_STRICT_WRITE_BARRIERS
		Il2CppCodeGenWriteBarrier((void**)&((&(((&___enumerator_6))->___current_3))->___Data_1), (void*)NULL);
		#endif
	}
};


// System.Linq.Enumerable/WhereSelectListIterator`2<System.Int32,System.Nullable`1<System.Decimal>>
struct WhereSelectListIterator_2_tE0E6511BEA6332534ECB4BFFD7FF61385E8B4D37  : public Iterator_1_tC3AC38DE0A9857A77F64882DC49BB78318A5EF00
{
public:
	// System.Collections.Generic.List`1<TSource> System.Linq.Enumerable/WhereSelectListIterator`2::source
	List_1_t260B41F956D673396C33A4CF94E8D6C4389EACB7 * ___source_3;
	// System.Func`2<TSource,System.Boolean> System.Linq.Enumerable/WhereSelectListIterator`2::predicate
	Func_2_t2EBF98B0BA555D9F0633C9BCCBE3DF332B9C1274 * ___predicate_4;
	// System.Func`2<TSource,TResult> System.Linq.Enumerable/WhereSelectListIterator`2::selector
	Func_2_t2CF7067ECC6F2E1B8FC552857749A03DC1E5AE1E * ___selector_5;
	// System.Collections.Generic.List`1/Enumerator<TSource> System.Linq.Enumerable/WhereSelectListIterator`2::enumerator
	Enumerator_t7BA00929E14A2F2A62CE085585044A3FEB2C5F3C  ___enumerator_6;

public:
	inline static int32_t get_offset_of_source_3() { return static_cast<int32_t>(offsetof(WhereSelectListIterator_2_tE0E6511BEA6332534ECB4BFFD7FF61385E8B4D37, ___source_3)); }
	inline List_1_t260B41F956D673396C33A4CF94E8D6C4389EACB7 * get_source_3() const { return ___source_3; }
	inline List_1_t260B41F956D673396C33A4CF94E8D6C4389EACB7 ** get_address_of_source_3() { return &___source_3; }
	inline void set_source_3(List_1_t260B41F956D673396C33A4CF94E8D6C4389EACB7 * value)
	{
		___source_3 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___source_3), (void*)value);
	}

	inline static int32_t get_offset_of_predicate_4() { return static_cast<int32_t>(offsetof(WhereSelectListIterator_2_tE0E6511BEA6332534ECB4BFFD7FF61385E8B4D37, ___predicate_4)); }
	inline Func_2_t2EBF98B0BA555D9F0633C9BCCBE3DF332B9C1274 * get_predicate_4() const { return ___predicate_4; }
	inline Func_2_t2EBF98B0BA555D9F0633C9BCCBE3DF332B9C1274 ** get_address_of_predicate_4() { return &___predicate_4; }
	inline void set_predicate_4(Func_2_t2EBF98B0BA555D9F0633C9BCCBE3DF332B9C1274 * value)
	{
		___predicate_4 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___predicate_4), (void*)value);
	}

	inline static int32_t get_offset_of_selector_5() { return static_cast<int32_t>(offsetof(WhereSelectListIterator_2_tE0E6511BEA6332534ECB4BFFD7FF61385E8B4D37, ___selector_5)); }
	inline Func_2_t2CF7067ECC6F2E1B8FC552857749A03DC1E5AE1E * get_selector_5() const { return ___selector_5; }
	inline Func_2_t2CF7067ECC6F2E1B8FC552857749A03DC1E5AE1E ** get_address_of_selector_5() { return &___selector_5; }
	inline void set_selector_5(Func_2_t2CF7067ECC6F2E1B8FC552857749A03DC1E5AE1E * value)
	{
		___selector_5 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___selector_5), (void*)value);
	}

	inline static int32_t get_offset_of_enumerator_6() { return static_cast<int32_t>(offsetof(WhereSelectListIterator_2_tE0E6511BEA6332534ECB4BFFD7FF61385E8B4D37, ___enumerator_6)); }
	inline Enumerator_t7BA00929E14A2F2A62CE085585044A3FEB2C5F3C  get_enumerator_6() const { return ___enumerator_6; }
	inline Enumerator_t7BA00929E14A2F2A62CE085585044A3FEB2C5F3C * get_address_of_enumerator_6() { return &___enumerator_6; }
	inline void set_enumerator_6(Enumerator_t7BA00929E14A2F2A62CE085585044A3FEB2C5F3C  value)
	{
		___enumerator_6 = value;
		Il2CppCodeGenWriteBarrier((void**)&(((&___enumerator_6))->___list_0), (void*)NULL);
	}
};


// System.Linq.Enumerable/WhereSelectListIterator`2<System.Object,System.Nullable`1<System.Decimal>>
struct WhereSelectListIterator_2_t49F3CEC3F8DE6BE9B2E0E65A36314CEEED603DE7  : public Iterator_1_tC3AC38DE0A9857A77F64882DC49BB78318A5EF00
{
public:
	// System.Collections.Generic.List`1<TSource> System.Linq.Enumerable/WhereSelectListIterator`2::source
	List_1_t3F94120C77410A62EAE48421CF166B83AB95A2F5 * ___source_3;
	// System.Func`2<TSource,System.Boolean> System.Linq.Enumerable/WhereSelectListIterator`2::predicate
	Func_2_t99409DECFF50F0FA9B427C863AC6C99C66E6F9F8 * ___predicate_4;
	// System.Func`2<TSource,TResult> System.Linq.Enumerable/WhereSelectListIterator`2::selector
	Func_2_t3818905EA774DF4C16A3B852ECBDEAA1B10478B4 * ___selector_5;
	// System.Collections.Generic.List`1/Enumerator<TSource> System.Linq.Enumerable/WhereSelectListIterator`2::enumerator
	Enumerator_tB6009981BD4E3881E3EC83627255A24198F902D6  ___enumerator_6;

public:
	inline static int32_t get_offset_of_source_3() { return static_cast<int32_t>(offsetof(WhereSelectListIterator_2_t49F3CEC3F8DE6BE9B2E0E65A36314CEEED603DE7, ___source_3)); }
	inline List_1_t3F94120C77410A62EAE48421CF166B83AB95A2F5 * get_source_3() const { return ___source_3; }
	inline List_1_t3F94120C77410A62EAE48421CF166B83AB95A2F5 ** get_address_of_source_3() { return &___source_3; }
	inline void set_source_3(List_1_t3F94120C77410A62EAE48421CF166B83AB95A2F5 * value)
	{
		___source_3 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___source_3), (void*)value);
	}

	inline static int32_t get_offset_of_predicate_4() { return static_cast<int32_t>(offsetof(WhereSelectListIterator_2_t49F3CEC3F8DE6BE9B2E0E65A36314CEEED603DE7, ___predicate_4)); }
	inline Func_2_t99409DECFF50F0FA9B427C863AC6C99C66E6F9F8 * get_predicate_4() const { return ___predicate_4; }
	inline Func_2_t99409DECFF50F0FA9B427C863AC6C99C66E6F9F8 ** get_address_of_predicate_4() { return &___predicate_4; }
	inline void set_predicate_4(Func_2_t99409DECFF50F0FA9B427C863AC6C99C66E6F9F8 * value)
	{
		___predicate_4 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___predicate_4), (void*)value);
	}

	inline static int32_t get_offset_of_selector_5() { return static_cast<int32_t>(offsetof(WhereSelectListIterator_2_t49F3CEC3F8DE6BE9B2E0E65A36314CEEED603DE7, ___selector_5)); }
	inline Func_2_t3818905EA774DF4C16A3B852ECBDEAA1B10478B4 * get_selector_5() const { return ___selector_5; }
	inline Func_2_t3818905EA774DF4C16A3B852ECBDEAA1B10478B4 ** get_address_of_selector_5() { return &___selector_5; }
	inline void set_selector_5(Func_2_t3818905EA774DF4C16A3B852ECBDEAA1B10478B4 * value)
	{
		___selector_5 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___selector_5), (void*)value);
	}

	inline static int32_t get_offset_of_enumerator_6() { return static_cast<int32_t>(offsetof(WhereSelectListIterator_2_t49F3CEC3F8DE6BE9B2E0E65A36314CEEED603DE7, ___enumerator_6)); }
	inline Enumerator_tB6009981BD4E3881E3EC83627255A24198F902D6  get_enumerator_6() const { return ___enumerator_6; }
	inline Enumerator_tB6009981BD4E3881E3EC83627255A24198F902D6 * get_address_of_enumerator_6() { return &___enumerator_6; }
	inline void set_enumerator_6(Enumerator_tB6009981BD4E3881E3EC83627255A24198F902D6  value)
	{
		___enumerator_6 = value;
		Il2CppCodeGenWriteBarrier((void**)&(((&___enumerator_6))->___list_0), (void*)NULL);
		#if IL2CPP_ENABLE_STRICT_WRITE_BARRIERS
		Il2CppCodeGenWriteBarrier((void**)&(((&___enumerator_6))->___current_3), (void*)NULL);
		#endif
	}
};


// System.Linq.Parallel.QuerySettings
struct QuerySettings_t45D8808D6FB4096670C5DDCA198AD4523EE0B974 
{
public:
	// System.Threading.Tasks.TaskScheduler System.Linq.Parallel.QuerySettings::_taskScheduler
	TaskScheduler_t74FBEEEDBDD5E0088FF0EEC18F45CD866B098D5D * ____taskScheduler_0;
	// System.Nullable`1<System.Int32> System.Linq.Parallel.QuerySettings::_degreeOfParallelism
	Nullable_1_t864FD0051A05D37F91C857AB496BFCB3FE756103  ____degreeOfParallelism_1;
	// System.Linq.Parallel.CancellationState System.Linq.Parallel.QuerySettings::_cancellationState
	CancellationState_t302EEDE088D5E82EBE9A74EE31029F9CB981E9CC * ____cancellationState_2;
	// System.Nullable`1<System.Linq.ParallelExecutionMode> System.Linq.Parallel.QuerySettings::_executionMode
	Nullable_1_tD63DBB63DE91B264EBCACCCAE3F99B2F8C1585CF  ____executionMode_3;
	// System.Nullable`1<System.Linq.ParallelMergeOptions> System.Linq.Parallel.QuerySettings::_mergeOptions
	Nullable_1_tC765C1F31F62FF67DE02D2D0A514159758445B48  ____mergeOptions_4;
	// System.Int32 System.Linq.Parallel.QuerySettings::_queryId
	int32_t ____queryId_5;

public:
	inline static int32_t get_offset_of__taskScheduler_0() { return static_cast<int32_t>(offsetof(QuerySettings_t45D8808D6FB4096670C5DDCA198AD4523EE0B974, ____taskScheduler_0)); }
	inline TaskScheduler_t74FBEEEDBDD5E0088FF0EEC18F45CD866B098D5D * get__taskScheduler_0() const { return ____taskScheduler_0; }
	inline TaskScheduler_t74FBEEEDBDD5E0088FF0EEC18F45CD866B098D5D ** get_address_of__taskScheduler_0() { return &____taskScheduler_0; }
	inline void set__taskScheduler_0(TaskScheduler_t74FBEEEDBDD5E0088FF0EEC18F45CD866B098D5D * value)
	{
		____taskScheduler_0 = value;
		Il2CppCodeGenWriteBarrier((void**)(&____taskScheduler_0), (void*)value);
	}

	inline static int32_t get_offset_of__degreeOfParallelism_1() { return static_cast<int32_t>(offsetof(QuerySettings_t45D8808D6FB4096670C5DDCA198AD4523EE0B974, ____degreeOfParallelism_1)); }
	inline Nullable_1_t864FD0051A05D37F91C857AB496BFCB3FE756103  get__degreeOfParallelism_1() const { return ____degreeOfParallelism_1; }
	inline Nullable_1_t864FD0051A05D37F91C857AB496BFCB3FE756103 * get_address_of__degreeOfParallelism_1() { return &____degreeOfParallelism_1; }
	inline void set__degreeOfParallelism_1(Nullable_1_t864FD0051A05D37F91C857AB496BFCB3FE756103  value)
	{
		____degreeOfParallelism_1 = value;
	}

	inline static int32_t get_offset_of__cancellationState_2() { return static_cast<int32_t>(offsetof(QuerySettings_t45D8808D6FB4096670C5DDCA198AD4523EE0B974, ____cancellationState_2)); }
	inline CancellationState_t302EEDE088D5E82EBE9A74EE31029F9CB981E9CC * get__cancellationState_2() const { return ____cancellationState_2; }
	inline CancellationState_t302EEDE088D5E82EBE9A74EE31029F9CB981E9CC ** get_address_of__cancellationState_2() { return &____cancellationState_2; }
	inline void set__cancellationState_2(CancellationState_t302EEDE088D5E82EBE9A74EE31029F9CB981E9CC * value)
	{
		____cancellationState_2 = value;
		Il2CppCodeGenWriteBarrier((void**)(&____cancellationState_2), (void*)value);
	}

	inline static int32_t get_offset_of__executionMode_3() { return static_cast<int32_t>(offsetof(QuerySettings_t45D8808D6FB4096670C5DDCA198AD4523EE0B974, ____executionMode_3)); }
	inline Nullable_1_tD63DBB63DE91B264EBCACCCAE3F99B2F8C1585CF  get__executionMode_3() const { return ____executionMode_3; }
	inline Nullable_1_tD63DBB63DE91B264EBCACCCAE3F99B2F8C1585CF * get_address_of__executionMode_3() { return &____executionMode_3; }
	inline void set__executionMode_3(Nullable_1_tD63DBB63DE91B264EBCACCCAE3F99B2F8C1585CF  value)
	{
		____executionMode_3 = value;
	}

	inline static int32_t get_offset_of__mergeOptions_4() { return static_cast<int32_t>(offsetof(QuerySettings_t45D8808D6FB4096670C5DDCA198AD4523EE0B974, ____mergeOptions_4)); }
	inline Nullable_1_tC765C1F31F62FF67DE02D2D0A514159758445B48  get__mergeOptions_4() const { return ____mergeOptions_4; }
	inline Nullable_1_tC765C1F31F62FF67DE02D2D0A514159758445B48 * get_address_of__mergeOptions_4() { return &____mergeOptions_4; }
	inline void set__mergeOptions_4(Nullable_1_tC765C1F31F62FF67DE02D2D0A514159758445B48  value)
	{
		____mergeOptions_4 = value;
	}

	inline static int32_t get_offset_of__queryId_5() { return static_cast<int32_t>(offsetof(QuerySettings_t45D8808D6FB4096670C5DDCA198AD4523EE0B974, ____queryId_5)); }
	inline int32_t get__queryId_5() const { return ____queryId_5; }
	inline int32_t* get_address_of__queryId_5() { return &____queryId_5; }
	inline void set__queryId_5(int32_t value)
	{
		____queryId_5 = value;
	}
};

// Native definition for P/Invoke marshalling of System.Linq.Parallel.QuerySettings
struct QuerySettings_t45D8808D6FB4096670C5DDCA198AD4523EE0B974_marshaled_pinvoke
{
	TaskScheduler_t74FBEEEDBDD5E0088FF0EEC18F45CD866B098D5D * ____taskScheduler_0;
	Nullable_1_t864FD0051A05D37F91C857AB496BFCB3FE756103  ____degreeOfParallelism_1;
	CancellationState_t302EEDE088D5E82EBE9A74EE31029F9CB981E9CC * ____cancellationState_2;
	Nullable_1_tD63DBB63DE91B264EBCACCCAE3F99B2F8C1585CF  ____executionMode_3;
	Nullable_1_tC765C1F31F62FF67DE02D2D0A514159758445B48  ____mergeOptions_4;
	int32_t ____queryId_5;
};
// Native definition for COM marshalling of System.Linq.Parallel.QuerySettings
struct QuerySettings_t45D8808D6FB4096670C5DDCA198AD4523EE0B974_marshaled_com
{
	TaskScheduler_t74FBEEEDBDD5E0088FF0EEC18F45CD866B098D5D * ____taskScheduler_0;
	Nullable_1_t864FD0051A05D37F91C857AB496BFCB3FE756103  ____degreeOfParallelism_1;
	CancellationState_t302EEDE088D5E82EBE9A74EE31029F9CB981E9CC * ____cancellationState_2;
	Nullable_1_tD63DBB63DE91B264EBCACCCAE3F99B2F8C1585CF  ____executionMode_3;
	Nullable_1_tC765C1F31F62FF67DE02D2D0A514159758445B48  ____mergeOptions_4;
	int32_t ____queryId_5;
};

// System.Linq.ParallelQuery
struct ParallelQuery_tA2D9886CB464C3FA8EB1BB56036F35E3AB55DEF4  : public RuntimeObject
{
public:
	// System.Linq.Parallel.QuerySettings System.Linq.ParallelQuery::_specifiedSettings
	QuerySettings_t45D8808D6FB4096670C5DDCA198AD4523EE0B974  ____specifiedSettings_0;

public:
	inline static int32_t get_offset_of__specifiedSettings_0() { return static_cast<int32_t>(offsetof(ParallelQuery_tA2D9886CB464C3FA8EB1BB56036F35E3AB55DEF4, ____specifiedSettings_0)); }
	inline QuerySettings_t45D8808D6FB4096670C5DDCA198AD4523EE0B974  get__specifiedSettings_0() const { return ____specifiedSettings_0; }
	inline QuerySettings_t45D8808D6FB4096670C5DDCA198AD4523EE0B974 * get_address_of__specifiedSettings_0() { return &____specifiedSettings_0; }
	inline void set__specifiedSettings_0(QuerySettings_t45D8808D6FB4096670C5DDCA198AD4523EE0B974  value)
	{
		____specifiedSettings_0 = value;
		Il2CppCodeGenWriteBarrier((void**)&(((&____specifiedSettings_0))->____taskScheduler_0), (void*)NULL);
		#if IL2CPP_ENABLE_STRICT_WRITE_BARRIERS
		Il2CppCodeGenWriteBarrier((void**)&(((&____specifiedSettings_0))->____cancellationState_2), (void*)NULL);
		#endif
	}
};


// System.Linq.ParallelQuery`1<System.Object>
struct ParallelQuery_1_t27EE69EA11DD2EF16DC5DCA17156F1CC9C5D3638  : public ParallelQuery_tA2D9886CB464C3FA8EB1BB56036F35E3AB55DEF4
{
public:

public:
};


// System.Linq.Parallel.QueryOperator`1<System.Object>
struct QueryOperator_1_t2F4038BA1C7627FB9361A0BC79E4F2A421AEF668  : public ParallelQuery_1_t27EE69EA11DD2EF16DC5DCA17156F1CC9C5D3638
{
public:
	// System.Boolean System.Linq.Parallel.QueryOperator`1::_outputOrdered
	bool ____outputOrdered_1;

public:
	inline static int32_t get_offset_of__outputOrdered_1() { return static_cast<int32_t>(offsetof(QueryOperator_1_t2F4038BA1C7627FB9361A0BC79E4F2A421AEF668, ____outputOrdered_1)); }
	inline bool get__outputOrdered_1() const { return ____outputOrdered_1; }
	inline bool* get_address_of__outputOrdered_1() { return &____outputOrdered_1; }
	inline void set__outputOrdered_1(bool value)
	{
		____outputOrdered_1 = value;
	}
};


// System.Linq.Parallel.ZipQueryOperator`3<System.Object,System.Object,System.Object>
struct ZipQueryOperator_3_t2D0121637CE51185E2CBB640EEAF8876A893637E  : public QueryOperator_1_t2F4038BA1C7627FB9361A0BC79E4F2A421AEF668
{
public:
	// System.Func`3<TLeftInput,TRightInput,TOutput> System.Linq.Parallel.ZipQueryOperator`3::_resultSelector
	Func_3_tBBBFF266D23D5A9A7940D16DA73BCD5DE0753A27 * ____resultSelector_2;
	// System.Linq.Parallel.QueryOperator`1<TLeftInput> System.Linq.Parallel.ZipQueryOperator`3::_leftChild
	QueryOperator_1_t2F4038BA1C7627FB9361A0BC79E4F2A421AEF668 * ____leftChild_3;
	// System.Linq.Parallel.QueryOperator`1<TRightInput> System.Linq.Parallel.ZipQueryOperator`3::_rightChild
	QueryOperator_1_t2F4038BA1C7627FB9361A0BC79E4F2A421AEF668 * ____rightChild_4;
	// System.Boolean System.Linq.Parallel.ZipQueryOperator`3::_prematureMergeLeft
	bool ____prematureMergeLeft_5;
	// System.Boolean System.Linq.Parallel.ZipQueryOperator`3::_prematureMergeRight
	bool ____prematureMergeRight_6;
	// System.Boolean System.Linq.Parallel.ZipQueryOperator`3::_limitsParallelism
	bool ____limitsParallelism_7;

public:
	inline static int32_t get_offset_of__resultSelector_2() { return static_cast<int32_t>(offsetof(ZipQueryOperator_3_t2D0121637CE51185E2CBB640EEAF8876A893637E, ____resultSelector_2)); }
	inline Func_3_tBBBFF266D23D5A9A7940D16DA73BCD5DE0753A27 * get__resultSelector_2() const { return ____resultSelector_2; }
	inline Func_3_tBBBFF266D23D5A9A7940D16DA73BCD5DE0753A27 ** get_address_of__resultSelector_2() { return &____resultSelector_2; }
	inline void set__resultSelector_2(Func_3_tBBBFF266D23D5A9A7940D16DA73BCD5DE0753A27 * value)
	{
		____resultSelector_2 = value;
		Il2CppCodeGenWriteBarrier((void**)(&____resultSelector_2), (void*)value);
	}

	inline static int32_t get_offset_of__leftChild_3() { return static_cast<int32_t>(offsetof(ZipQueryOperator_3_t2D0121637CE51185E2CBB640EEAF8876A893637E, ____leftChild_3)); }
	inline QueryOperator_1_t2F4038BA1C7627FB9361A0BC79E4F2A421AEF668 * get__leftChild_3() const { return ____leftChild_3; }
	inline QueryOperator_1_t2F4038BA1C7627FB9361A0BC79E4F2A421AEF668 ** get_address_of__leftChild_3() { return &____leftChild_3; }
	inline void set__leftChild_3(QueryOperator_1_t2F4038BA1C7627FB9361A0BC79E4F2A421AEF668 * value)
	{
		____leftChild_3 = value;
		Il2CppCodeGenWriteBarrier((void**)(&____leftChild_3), (void*)value);
	}

	inline static int32_t get_offset_of__rightChild_4() { return static_cast<int32_t>(offsetof(ZipQueryOperator_3_t2D0121637CE51185E2CBB640EEAF8876A893637E, ____rightChild_4)); }
	inline QueryOperator_1_t2F4038BA1C7627FB9361A0BC79E4F2A421AEF668 * get__rightChild_4() const { return ____rightChild_4; }
	inline QueryOperator_1_t2F4038BA1C7627FB9361A0BC79E4F2A421AEF668 ** get_address_of__rightChild_4() { return &____rightChild_4; }
	inline void set__rightChild_4(QueryOperator_1_t2F4038BA1C7627FB9361A0BC79E4F2A421AEF668 * value)
	{
		____rightChild_4 = value;
		Il2CppCodeGenWriteBarrier((void**)(&____rightChild_4), (void*)value);
	}

	inline static int32_t get_offset_of__prematureMergeLeft_5() { return static_cast<int32_t>(offsetof(ZipQueryOperator_3_t2D0121637CE51185E2CBB640EEAF8876A893637E, ____prematureMergeLeft_5)); }
	inline bool get__prematureMergeLeft_5() const { return ____prematureMergeLeft_5; }
	inline bool* get_address_of__prematureMergeLeft_5() { return &____prematureMergeLeft_5; }
	inline void set__prematureMergeLeft_5(bool value)
	{
		____prematureMergeLeft_5 = value;
	}

	inline static int32_t get_offset_of__prematureMergeRight_6() { return static_cast<int32_t>(offsetof(ZipQueryOperator_3_t2D0121637CE51185E2CBB640EEAF8876A893637E, ____prematureMergeRight_6)); }
	inline bool get__prematureMergeRight_6() const { return ____prematureMergeRight_6; }
	inline bool* get_address_of__prematureMergeRight_6() { return &____prematureMergeRight_6; }
	inline void set__prematureMergeRight_6(bool value)
	{
		____prematureMergeRight_6 = value;
	}

	inline static int32_t get_offset_of__limitsParallelism_7() { return static_cast<int32_t>(offsetof(ZipQueryOperator_3_t2D0121637CE51185E2CBB640EEAF8876A893637E, ____limitsParallelism_7)); }
	inline bool get__limitsParallelism_7() const { return ____limitsParallelism_7; }
	inline bool* get_address_of__limitsParallelism_7() { return &____limitsParallelism_7; }
	inline void set__limitsParallelism_7(bool value)
	{
		____limitsParallelism_7 = value;
	}
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


// !0 System.Collections.Generic.List`1/Enumerator<System.ValueTuple`2<System.Object,System.Object>>::get_Current()
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR ValueTuple_2_t69671C4973C1A3829B2193E4C598B1AE7162E403  Enumerator_get_Current_m8B737F0ABD2247C4E13D52C15DEAB59C34368B56_gshared_inline (Enumerator_tCF455A92CC670AF169DFC7D0E19B47CAB2BD1DA0 * __this, const RuntimeMethod* method);
// System.Boolean System.Collections.Generic.List`1/Enumerator<System.ValueTuple`2<System.Object,System.Object>>::MoveNext()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR bool Enumerator_MoveNext_mC34E84789B18F4A0FE38F5A6D20958052D39F587_gshared (Enumerator_tCF455A92CC670AF169DFC7D0E19B47CAB2BD1DA0 * __this, const RuntimeMethod* method);
// !0 System.Collections.Generic.List`1/Enumerator<System.Boolean>::get_Current()
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR bool Enumerator_get_Current_m19632EFFAA50F452EA487CBA0F1781963A3B5396_gshared_inline (Enumerator_t3F9663F5F32B0D733380A76CCEAA3ADFA3AE34A9 * __this, const RuntimeMethod* method);
// System.Boolean System.Collections.Generic.List`1/Enumerator<System.Boolean>::MoveNext()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR bool Enumerator_MoveNext_m829A3B1476C9E85C909907D33E9A81B4CFD5728F_gshared (Enumerator_t3F9663F5F32B0D733380A76CCEAA3ADFA3AE34A9 * __this, const RuntimeMethod* method);
// !0 System.Collections.Generic.List`1/Enumerator<UnityEngine.Experimental.Rendering.Universal.LibTessDotNet.ContourVertex>::get_Current()
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR ContourVertex_tF9E27CB6BCC62DF5F4202153BBBECDE5E3283536  Enumerator_get_Current_mB9DED66EBA82669AB83832B40F60E1710B5179B4_gshared_inline (Enumerator_t0A364062D6EEDD0B306D570939B5709AEAA88D11 * __this, const RuntimeMethod* method);
// System.Boolean System.Collections.Generic.List`1/Enumerator<UnityEngine.Experimental.Rendering.Universal.LibTessDotNet.ContourVertex>::MoveNext()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR bool Enumerator_MoveNext_mACDC401A875ECF83AEF9477068CDF02545A1D997_gshared (Enumerator_t0A364062D6EEDD0B306D570939B5709AEAA88D11 * __this, const RuntimeMethod* method);
// !0 System.Collections.Generic.List`1/Enumerator<System.Decimal>::get_Current()
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR Decimal_t2978B229CA86D3B7BA66A0AEEE014E0DE4F940D7  Enumerator_get_Current_m463788CB5D0E8998F983E802C69ABFD0DF8F10DF_gshared_inline (Enumerator_t97AF9DDC8F349478939A4899D22F6CC1A2FA7021 * __this, const RuntimeMethod* method);
// System.Boolean System.Collections.Generic.List`1/Enumerator<System.Decimal>::MoveNext()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR bool Enumerator_MoveNext_m94DEBE5F36416BB0664E8C3F1E0C3E3E03DBFA8F_gshared (Enumerator_t97AF9DDC8F349478939A4899D22F6CC1A2FA7021 * __this, const RuntimeMethod* method);
// !0 System.Collections.Generic.List`1/Enumerator<System.Double>::get_Current()
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR double Enumerator_get_Current_m14C2F2917DC59AB94B8E9875EEF5E57AB7DE82B8_gshared_inline (Enumerator_tDB7E887EC564EBF2D244915021ED0896BFD7A8A2 * __this, const RuntimeMethod* method);
// System.Boolean System.Collections.Generic.List`1/Enumerator<System.Double>::MoveNext()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR bool Enumerator_MoveNext_m3F9800297946765598836D838E09AE04C76A3322_gshared (Enumerator_tDB7E887EC564EBF2D244915021ED0896BFD7A8A2 * __this, const RuntimeMethod* method);
// !0 System.Collections.Generic.List`1/Enumerator<System.Int32>::get_Current()
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR int32_t Enumerator_get_Current_m6BBD624C51F7E20D347FE5894A6ECA94B8011181_gshared_inline (Enumerator_t7BA00929E14A2F2A62CE085585044A3FEB2C5F3C * __this, const RuntimeMethod* method);
// System.Boolean System.Collections.Generic.List`1/Enumerator<System.Int32>::MoveNext()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR bool Enumerator_MoveNext_m40FD166B6757334A2BBCF67238EFDF70D727A4A6_gshared (Enumerator_t7BA00929E14A2F2A62CE085585044A3FEB2C5F3C * __this, const RuntimeMethod* method);
// !0 System.Collections.Generic.List`1/Enumerator<System.Int64>::get_Current()
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR int64_t Enumerator_get_Current_m9EBEA7E72E64499B4BED94F77DF82E7B8C3F1CE0_gshared_inline (Enumerator_t1C02C38119DFDA075166A979AE2B70CCA911ED37 * __this, const RuntimeMethod* method);
// System.Boolean System.Collections.Generic.List`1/Enumerator<System.Int64>::MoveNext()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR bool Enumerator_MoveNext_m25DAE3260BFED34CE518F60AF8D6768AF47A2DF2_gshared (Enumerator_t1C02C38119DFDA075166A979AE2B70CCA911ED37 * __this, const RuntimeMethod* method);
// !0 System.Collections.Generic.List`1/Enumerator<System.Object>::get_Current()
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR RuntimeObject * Enumerator_get_Current_m9C4EBBD2108B51885E750F927D7936290C8E20EE_gshared_inline (Enumerator_tB6009981BD4E3881E3EC83627255A24198F902D6 * __this, const RuntimeMethod* method);
// System.Boolean System.Collections.Generic.List`1/Enumerator<System.Object>::MoveNext()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR bool Enumerator_MoveNext_m2E56233762839CE55C67E00AC8DD3D4D3F6C0DF0_gshared (Enumerator_tB6009981BD4E3881E3EC83627255A24198F902D6 * __this, const RuntimeMethod* method);
// !0 System.Collections.Generic.List`1/Enumerator<System.Single>::get_Current()
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR float Enumerator_get_Current_m1DC0B40110173B7E2D13319164F7657C3BE3536D_gshared_inline (Enumerator_tC1FD01C8BB5327D442D71FD022B4338ACD701783 * __this, const RuntimeMethod* method);
// System.Boolean System.Collections.Generic.List`1/Enumerator<System.Single>::MoveNext()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR bool Enumerator_MoveNext_mF6D031AEDDDEEAF750E0BFE7866FBBA9C9752C7E_gshared (Enumerator_tC1FD01C8BB5327D442D71FD022B4338ACD701783 * __this, const RuntimeMethod* method);
// System.Void System.Linq.Parallel.WrapperEqualityComparer`1<System.Object>::.ctor(System.Collections.Generic.IEqualityComparer`1<T>)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void WrapperEqualityComparer_1__ctor_m2981537A54B3ACE5E4831F93BDC81CF92F476679_gshared (WrapperEqualityComparer_1_t4AD211C5560CD8CDAD6255CC8B0CCCC3E20A3D42 * __this, RuntimeObject* ___comparer0, const RuntimeMethod* method);
// System.Boolean System.Linq.Parallel.WrapperEqualityComparer`1<System.Object>::Equals(System.Linq.Parallel.Wrapper`1<T>,System.Linq.Parallel.Wrapper`1<T>)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR bool WrapperEqualityComparer_1_Equals_m36BCEEDC130CD064FA2A9CC53175BC69844F775A_gshared (WrapperEqualityComparer_1_t4AD211C5560CD8CDAD6255CC8B0CCCC3E20A3D42 * __this, Wrapper_1_tDDD2ABAF8D432140BA7A444ED61075E20B73095F  ___x0, Wrapper_1_tDDD2ABAF8D432140BA7A444ED61075E20B73095F  ___y1, const RuntimeMethod* method);
// System.Int32 System.Linq.Parallel.WrapperEqualityComparer`1<System.Object>::GetHashCode(System.Linq.Parallel.Wrapper`1<T>)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR int32_t WrapperEqualityComparer_1_GetHashCode_mCC9EDB08CDAB096AD02A9A008B21824E9B023A59_gshared (WrapperEqualityComparer_1_t4AD211C5560CD8CDAD6255CC8B0CCCC3E20A3D42 * __this, Wrapper_1_tDDD2ABAF8D432140BA7A444ED61075E20B73095F  ___x0, const RuntimeMethod* method);
// System.Void System.Linq.Parallel.Wrapper`1<System.Object>::.ctor(T)
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR void Wrapper_1__ctor_m6A362088D2F7EEC44415BC9C40FE51B2E7E48B80_gshared_inline (Wrapper_1_tDDD2ABAF8D432140BA7A444ED61075E20B73095F * __this, RuntimeObject * ___value0, const RuntimeMethod* method);
// !0 System.Nullable`1<System.Int32>::get_Value()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR int32_t Nullable_1_get_Value_mA0CB54A62D31AFC51F165263F2DB953605F2458D_gshared (Nullable_1_t864FD0051A05D37F91C857AB496BFCB3FE756103 * __this, const RuntimeMethod* method);

// !0 System.Collections.Generic.List`1/Enumerator<System.ValueTuple`2<System.Object,System.Object>>::get_Current()
inline ValueTuple_2_t69671C4973C1A3829B2193E4C598B1AE7162E403  Enumerator_get_Current_m8B737F0ABD2247C4E13D52C15DEAB59C34368B56_inline (Enumerator_tCF455A92CC670AF169DFC7D0E19B47CAB2BD1DA0 * __this, const RuntimeMethod* method)
{
	return ((  ValueTuple_2_t69671C4973C1A3829B2193E4C598B1AE7162E403  (*) (Enumerator_tCF455A92CC670AF169DFC7D0E19B47CAB2BD1DA0 *, const RuntimeMethod*))Enumerator_get_Current_m8B737F0ABD2247C4E13D52C15DEAB59C34368B56_gshared_inline)(__this, method);
}
// System.Boolean System.Collections.Generic.List`1/Enumerator<System.ValueTuple`2<System.Object,System.Object>>::MoveNext()
inline bool Enumerator_MoveNext_mC34E84789B18F4A0FE38F5A6D20958052D39F587 (Enumerator_tCF455A92CC670AF169DFC7D0E19B47CAB2BD1DA0 * __this, const RuntimeMethod* method)
{
	return ((  bool (*) (Enumerator_tCF455A92CC670AF169DFC7D0E19B47CAB2BD1DA0 *, const RuntimeMethod*))Enumerator_MoveNext_mC34E84789B18F4A0FE38F5A6D20958052D39F587_gshared)(__this, method);
}
// !0 System.Collections.Generic.List`1/Enumerator<System.Boolean>::get_Current()
inline bool Enumerator_get_Current_m19632EFFAA50F452EA487CBA0F1781963A3B5396_inline (Enumerator_t3F9663F5F32B0D733380A76CCEAA3ADFA3AE34A9 * __this, const RuntimeMethod* method)
{
	return ((  bool (*) (Enumerator_t3F9663F5F32B0D733380A76CCEAA3ADFA3AE34A9 *, const RuntimeMethod*))Enumerator_get_Current_m19632EFFAA50F452EA487CBA0F1781963A3B5396_gshared_inline)(__this, method);
}
// System.Boolean System.Collections.Generic.List`1/Enumerator<System.Boolean>::MoveNext()
inline bool Enumerator_MoveNext_m829A3B1476C9E85C909907D33E9A81B4CFD5728F (Enumerator_t3F9663F5F32B0D733380A76CCEAA3ADFA3AE34A9 * __this, const RuntimeMethod* method)
{
	return ((  bool (*) (Enumerator_t3F9663F5F32B0D733380A76CCEAA3ADFA3AE34A9 *, const RuntimeMethod*))Enumerator_MoveNext_m829A3B1476C9E85C909907D33E9A81B4CFD5728F_gshared)(__this, method);
}
// !0 System.Collections.Generic.List`1/Enumerator<UnityEngine.Experimental.Rendering.Universal.LibTessDotNet.ContourVertex>::get_Current()
inline ContourVertex_tF9E27CB6BCC62DF5F4202153BBBECDE5E3283536  Enumerator_get_Current_mB9DED66EBA82669AB83832B40F60E1710B5179B4_inline (Enumerator_t0A364062D6EEDD0B306D570939B5709AEAA88D11 * __this, const RuntimeMethod* method)
{
	return ((  ContourVertex_tF9E27CB6BCC62DF5F4202153BBBECDE5E3283536  (*) (Enumerator_t0A364062D6EEDD0B306D570939B5709AEAA88D11 *, const RuntimeMethod*))Enumerator_get_Current_mB9DED66EBA82669AB83832B40F60E1710B5179B4_gshared_inline)(__this, method);
}
// System.Boolean System.Collections.Generic.List`1/Enumerator<UnityEngine.Experimental.Rendering.Universal.LibTessDotNet.ContourVertex>::MoveNext()
inline bool Enumerator_MoveNext_mACDC401A875ECF83AEF9477068CDF02545A1D997 (Enumerator_t0A364062D6EEDD0B306D570939B5709AEAA88D11 * __this, const RuntimeMethod* method)
{
	return ((  bool (*) (Enumerator_t0A364062D6EEDD0B306D570939B5709AEAA88D11 *, const RuntimeMethod*))Enumerator_MoveNext_mACDC401A875ECF83AEF9477068CDF02545A1D997_gshared)(__this, method);
}
// !0 System.Collections.Generic.List`1/Enumerator<System.Decimal>::get_Current()
inline Decimal_t2978B229CA86D3B7BA66A0AEEE014E0DE4F940D7  Enumerator_get_Current_m463788CB5D0E8998F983E802C69ABFD0DF8F10DF_inline (Enumerator_t97AF9DDC8F349478939A4899D22F6CC1A2FA7021 * __this, const RuntimeMethod* method)
{
	return ((  Decimal_t2978B229CA86D3B7BA66A0AEEE014E0DE4F940D7  (*) (Enumerator_t97AF9DDC8F349478939A4899D22F6CC1A2FA7021 *, const RuntimeMethod*))Enumerator_get_Current_m463788CB5D0E8998F983E802C69ABFD0DF8F10DF_gshared_inline)(__this, method);
}
// System.Boolean System.Collections.Generic.List`1/Enumerator<System.Decimal>::MoveNext()
inline bool Enumerator_MoveNext_m94DEBE5F36416BB0664E8C3F1E0C3E3E03DBFA8F (Enumerator_t97AF9DDC8F349478939A4899D22F6CC1A2FA7021 * __this, const RuntimeMethod* method)
{
	return ((  bool (*) (Enumerator_t97AF9DDC8F349478939A4899D22F6CC1A2FA7021 *, const RuntimeMethod*))Enumerator_MoveNext_m94DEBE5F36416BB0664E8C3F1E0C3E3E03DBFA8F_gshared)(__this, method);
}
// !0 System.Collections.Generic.List`1/Enumerator<System.Double>::get_Current()
inline double Enumerator_get_Current_m14C2F2917DC59AB94B8E9875EEF5E57AB7DE82B8_inline (Enumerator_tDB7E887EC564EBF2D244915021ED0896BFD7A8A2 * __this, const RuntimeMethod* method)
{
	return ((  double (*) (Enumerator_tDB7E887EC564EBF2D244915021ED0896BFD7A8A2 *, const RuntimeMethod*))Enumerator_get_Current_m14C2F2917DC59AB94B8E9875EEF5E57AB7DE82B8_gshared_inline)(__this, method);
}
// System.Boolean System.Collections.Generic.List`1/Enumerator<System.Double>::MoveNext()
inline bool Enumerator_MoveNext_m3F9800297946765598836D838E09AE04C76A3322 (Enumerator_tDB7E887EC564EBF2D244915021ED0896BFD7A8A2 * __this, const RuntimeMethod* method)
{
	return ((  bool (*) (Enumerator_tDB7E887EC564EBF2D244915021ED0896BFD7A8A2 *, const RuntimeMethod*))Enumerator_MoveNext_m3F9800297946765598836D838E09AE04C76A3322_gshared)(__this, method);
}
// !0 System.Collections.Generic.List`1/Enumerator<System.Int32>::get_Current()
inline int32_t Enumerator_get_Current_m6BBD624C51F7E20D347FE5894A6ECA94B8011181_inline (Enumerator_t7BA00929E14A2F2A62CE085585044A3FEB2C5F3C * __this, const RuntimeMethod* method)
{
	return ((  int32_t (*) (Enumerator_t7BA00929E14A2F2A62CE085585044A3FEB2C5F3C *, const RuntimeMethod*))Enumerator_get_Current_m6BBD624C51F7E20D347FE5894A6ECA94B8011181_gshared_inline)(__this, method);
}
// System.Boolean System.Collections.Generic.List`1/Enumerator<System.Int32>::MoveNext()
inline bool Enumerator_MoveNext_m40FD166B6757334A2BBCF67238EFDF70D727A4A6 (Enumerator_t7BA00929E14A2F2A62CE085585044A3FEB2C5F3C * __this, const RuntimeMethod* method)
{
	return ((  bool (*) (Enumerator_t7BA00929E14A2F2A62CE085585044A3FEB2C5F3C *, const RuntimeMethod*))Enumerator_MoveNext_m40FD166B6757334A2BBCF67238EFDF70D727A4A6_gshared)(__this, method);
}
// !0 System.Collections.Generic.List`1/Enumerator<System.Int64>::get_Current()
inline int64_t Enumerator_get_Current_m9EBEA7E72E64499B4BED94F77DF82E7B8C3F1CE0_inline (Enumerator_t1C02C38119DFDA075166A979AE2B70CCA911ED37 * __this, const RuntimeMethod* method)
{
	return ((  int64_t (*) (Enumerator_t1C02C38119DFDA075166A979AE2B70CCA911ED37 *, const RuntimeMethod*))Enumerator_get_Current_m9EBEA7E72E64499B4BED94F77DF82E7B8C3F1CE0_gshared_inline)(__this, method);
}
// System.Boolean System.Collections.Generic.List`1/Enumerator<System.Int64>::MoveNext()
inline bool Enumerator_MoveNext_m25DAE3260BFED34CE518F60AF8D6768AF47A2DF2 (Enumerator_t1C02C38119DFDA075166A979AE2B70CCA911ED37 * __this, const RuntimeMethod* method)
{
	return ((  bool (*) (Enumerator_t1C02C38119DFDA075166A979AE2B70CCA911ED37 *, const RuntimeMethod*))Enumerator_MoveNext_m25DAE3260BFED34CE518F60AF8D6768AF47A2DF2_gshared)(__this, method);
}
// !0 System.Collections.Generic.List`1/Enumerator<System.Object>::get_Current()
inline RuntimeObject * Enumerator_get_Current_m9C4EBBD2108B51885E750F927D7936290C8E20EE_inline (Enumerator_tB6009981BD4E3881E3EC83627255A24198F902D6 * __this, const RuntimeMethod* method)
{
	return ((  RuntimeObject * (*) (Enumerator_tB6009981BD4E3881E3EC83627255A24198F902D6 *, const RuntimeMethod*))Enumerator_get_Current_m9C4EBBD2108B51885E750F927D7936290C8E20EE_gshared_inline)(__this, method);
}
// System.Boolean System.Collections.Generic.List`1/Enumerator<System.Object>::MoveNext()
inline bool Enumerator_MoveNext_m2E56233762839CE55C67E00AC8DD3D4D3F6C0DF0 (Enumerator_tB6009981BD4E3881E3EC83627255A24198F902D6 * __this, const RuntimeMethod* method)
{
	return ((  bool (*) (Enumerator_tB6009981BD4E3881E3EC83627255A24198F902D6 *, const RuntimeMethod*))Enumerator_MoveNext_m2E56233762839CE55C67E00AC8DD3D4D3F6C0DF0_gshared)(__this, method);
}
// !0 System.Collections.Generic.List`1/Enumerator<System.Single>::get_Current()
inline float Enumerator_get_Current_m1DC0B40110173B7E2D13319164F7657C3BE3536D_inline (Enumerator_tC1FD01C8BB5327D442D71FD022B4338ACD701783 * __this, const RuntimeMethod* method)
{
	return ((  float (*) (Enumerator_tC1FD01C8BB5327D442D71FD022B4338ACD701783 *, const RuntimeMethod*))Enumerator_get_Current_m1DC0B40110173B7E2D13319164F7657C3BE3536D_gshared_inline)(__this, method);
}
// System.Boolean System.Collections.Generic.List`1/Enumerator<System.Single>::MoveNext()
inline bool Enumerator_MoveNext_mF6D031AEDDDEEAF750E0BFE7866FBBA9C9752C7E (Enumerator_tC1FD01C8BB5327D442D71FD022B4338ACD701783 * __this, const RuntimeMethod* method)
{
	return ((  bool (*) (Enumerator_tC1FD01C8BB5327D442D71FD022B4338ACD701783 *, const RuntimeMethod*))Enumerator_MoveNext_mF6D031AEDDDEEAF750E0BFE7866FBBA9C9752C7E_gshared)(__this, method);
}
// System.Void System.Object::.ctor()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Object__ctor_m88880E0413421D13FD95325EDCE231707CE1F405 (RuntimeObject * __this, const RuntimeMethod* method);
// System.Int32 System.Environment::get_CurrentManagedThreadId()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR int32_t Environment_get_CurrentManagedThreadId_m09DBD4166BFD399056B2F81C77A3A182339BF92D (const RuntimeMethod* method);
// System.Int32 System.Threading.Interlocked::Exchange(System.Int32&,System.Int32)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR int32_t Interlocked_Exchange_mCB69CAC317F723A1CB6B52194C5917B49C456794 (int32_t* ___location10, int32_t ___value1, const RuntimeMethod* method);
// System.Void System.Threading.Monitor::Enter(System.Object,System.Boolean&)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Monitor_Enter_mBEB6CC84184B46F26375EC3FC8921D16E48EA4C4 (RuntimeObject * ___obj0, bool* ___lockTaken1, const RuntimeMethod* method);
// System.Void System.Threading.Monitor::Exit(System.Object)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Monitor_Exit_mA776B403DA88AC77CDEEF67AB9F0D0E77ABD254A (RuntimeObject * ___obj0, const RuntimeMethod* method);
// System.Void System.Array::Copy(System.Array,System.Int32,System.Array,System.Int32,System.Int32)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Array_Copy_m3F127FFB5149532135043FFE285F9177C80CB877 (RuntimeArray * ___sourceArray0, int32_t ___sourceIndex1, RuntimeArray * ___destinationArray2, int32_t ___destinationIndex3, int32_t ___length4, const RuntimeMethod* method);
// System.Void System.Array::Clear(System.Array,System.Int32,System.Int32)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Array_Clear_mEB42D172C5E0825D340F6209F28578BDDDDCE34F (RuntimeArray * ___array0, int32_t ___index1, int32_t ___length2, const RuntimeMethod* method);
// System.Void System.Linq.Parallel.WrapperEqualityComparer`1<System.Object>::.ctor(System.Collections.Generic.IEqualityComparer`1<T>)
inline void WrapperEqualityComparer_1__ctor_m2981537A54B3ACE5E4831F93BDC81CF92F476679 (WrapperEqualityComparer_1_t4AD211C5560CD8CDAD6255CC8B0CCCC3E20A3D42 * __this, RuntimeObject* ___comparer0, const RuntimeMethod* method)
{
	((  void (*) (WrapperEqualityComparer_1_t4AD211C5560CD8CDAD6255CC8B0CCCC3E20A3D42 *, RuntimeObject*, const RuntimeMethod*))WrapperEqualityComparer_1__ctor_m2981537A54B3ACE5E4831F93BDC81CF92F476679_gshared)(__this, ___comparer0, method);
}
// System.Boolean System.Linq.Parallel.WrapperEqualityComparer`1<System.Object>::Equals(System.Linq.Parallel.Wrapper`1<T>,System.Linq.Parallel.Wrapper`1<T>)
inline bool WrapperEqualityComparer_1_Equals_m36BCEEDC130CD064FA2A9CC53175BC69844F775A (WrapperEqualityComparer_1_t4AD211C5560CD8CDAD6255CC8B0CCCC3E20A3D42 * __this, Wrapper_1_tDDD2ABAF8D432140BA7A444ED61075E20B73095F  ___x0, Wrapper_1_tDDD2ABAF8D432140BA7A444ED61075E20B73095F  ___y1, const RuntimeMethod* method)
{
	return ((  bool (*) (WrapperEqualityComparer_1_t4AD211C5560CD8CDAD6255CC8B0CCCC3E20A3D42 *, Wrapper_1_tDDD2ABAF8D432140BA7A444ED61075E20B73095F , Wrapper_1_tDDD2ABAF8D432140BA7A444ED61075E20B73095F , const RuntimeMethod*))WrapperEqualityComparer_1_Equals_m36BCEEDC130CD064FA2A9CC53175BC69844F775A_gshared)(__this, ___x0, ___y1, method);
}
// System.Int32 System.Linq.Parallel.WrapperEqualityComparer`1<System.Object>::GetHashCode(System.Linq.Parallel.Wrapper`1<T>)
inline int32_t WrapperEqualityComparer_1_GetHashCode_mCC9EDB08CDAB096AD02A9A008B21824E9B023A59 (WrapperEqualityComparer_1_t4AD211C5560CD8CDAD6255CC8B0CCCC3E20A3D42 * __this, Wrapper_1_tDDD2ABAF8D432140BA7A444ED61075E20B73095F  ___x0, const RuntimeMethod* method)
{
	return ((  int32_t (*) (WrapperEqualityComparer_1_t4AD211C5560CD8CDAD6255CC8B0CCCC3E20A3D42 *, Wrapper_1_tDDD2ABAF8D432140BA7A444ED61075E20B73095F , const RuntimeMethod*))WrapperEqualityComparer_1_GetHashCode_mCC9EDB08CDAB096AD02A9A008B21824E9B023A59_gshared)(__this, ___x0, method);
}
// System.Void System.Linq.Parallel.Wrapper`1<System.Object>::.ctor(T)
inline void Wrapper_1__ctor_m6A362088D2F7EEC44415BC9C40FE51B2E7E48B80_inline (Wrapper_1_tDDD2ABAF8D432140BA7A444ED61075E20B73095F * __this, RuntimeObject * ___value0, const RuntimeMethod* method)
{
	((  void (*) (Wrapper_1_tDDD2ABAF8D432140BA7A444ED61075E20B73095F *, RuntimeObject *, const RuntimeMethod*))Wrapper_1__ctor_m6A362088D2F7EEC44415BC9C40FE51B2E7E48B80_gshared_inline)(__this, ___value0, method);
}
// System.Int32 System.Math::Min(System.Int32,System.Int32)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR int32_t Math_Min_m4C6E1589800A3AA57C1F430C3903847E8D7B4574 (int32_t ___val10, int32_t ___val21, const RuntimeMethod* method);
// System.Linq.Parallel.QuerySettings System.Linq.ParallelQuery::get_SpecifiedQuerySettings()
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR QuerySettings_t45D8808D6FB4096670C5DDCA198AD4523EE0B974  ParallelQuery_get_SpecifiedQuerySettings_m567824488025D3A0038F414E67F3CAA65525417D_inline (ParallelQuery_tA2D9886CB464C3FA8EB1BB56036F35E3AB55DEF4 * __this, const RuntimeMethod* method);
// System.Linq.Parallel.QuerySettings System.Linq.Parallel.QuerySettings::Merge(System.Linq.Parallel.QuerySettings)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR QuerySettings_t45D8808D6FB4096670C5DDCA198AD4523EE0B974  QuerySettings_Merge_m4DEE1E7D80EA56EFC0148C6EF916CDB5DE8D92AC (QuerySettings_t45D8808D6FB4096670C5DDCA198AD4523EE0B974 * __this, QuerySettings_t45D8808D6FB4096670C5DDCA198AD4523EE0B974  ___settings20, const RuntimeMethod* method);
// System.Nullable`1<System.Int32> System.Linq.Parallel.QuerySettings::get_DegreeOfParallelism()
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR Nullable_1_t864FD0051A05D37F91C857AB496BFCB3FE756103  QuerySettings_get_DegreeOfParallelism_mCA5E77A72EA27EFA3C7C98707937196BB51F5482_inline (QuerySettings_t45D8808D6FB4096670C5DDCA198AD4523EE0B974 * __this, const RuntimeMethod* method);
// !0 System.Nullable`1<System.Int32>::get_Value()
inline int32_t Nullable_1_get_Value_mA0CB54A62D31AFC51F165263F2DB953605F2458D (Nullable_1_t864FD0051A05D37F91C857AB496BFCB3FE756103 * __this, const RuntimeMethod* method)
{
	return ((  int32_t (*) (Nullable_1_t864FD0051A05D37F91C857AB496BFCB3FE756103 *, const RuntimeMethod*))Nullable_1_get_Value_mA0CB54A62D31AFC51F165263F2DB953605F2458D_gshared)(__this, method);
}
// System.Threading.Tasks.TaskScheduler System.Linq.Parallel.QuerySettings::get_TaskScheduler()
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR TaskScheduler_t74FBEEEDBDD5E0088FF0EEC18F45CD866B098D5D * QuerySettings_get_TaskScheduler_m759B7D8E10ED54FFDFF56B8015677274E119EA3D_inline (QuerySettings_t45D8808D6FB4096670C5DDCA198AD4523EE0B974 * __this, const RuntimeMethod* method);
// System.Linq.Parallel.CancellationState System.Linq.Parallel.QuerySettings::get_CancellationState()
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR CancellationState_t302EEDE088D5E82EBE9A74EE31029F9CB981E9CC * QuerySettings_get_CancellationState_m83D1086517B2A38D891CBDB22977EC9519818F3D_inline (QuerySettings_t45D8808D6FB4096670C5DDCA198AD4523EE0B974 * __this, const RuntimeMethod* method);
// System.Int32 System.Linq.Parallel.QuerySettings::get_QueryId()
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR int32_t QuerySettings_get_QueryId_m79A03407AAD4A5BCB2BC58BD9CCDA659413BB35E_inline (QuerySettings_t45D8808D6FB4096670C5DDCA198AD4523EE0B974 * __this, const RuntimeMethod* method);
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif
// System.Void System.Linq.Enumerable/WhereSelectListIterator`2<System.ValueTuple`2<System.Object,System.Object>,System.Int32>::.ctor(System.Collections.Generic.List`1<TSource>,System.Func`2<TSource,System.Boolean>,System.Func`2<TSource,TResult>)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void WhereSelectListIterator_2__ctor_m705B4C2BD7171AA71002421E87AC25D9C3D3E9AA_gshared (WhereSelectListIterator_2_t6DF338AD50F89D3140CE0D070D507B13786150AC * __this, List_1_tF837281ACA0AE5696644C85291C841E8820C7AAC * ___source0, Func_2_t139EF32B1D20FBA53B5FC13859124C746B2D3C04 * ___predicate1, Func_2_tEB5259FF5AA54436077282823F2EEBED7C80AECF * ___selector2, const RuntimeMethod* method)
{
	{
		NullCheck((Iterator_1_tCFFC952B03DBE4E956DE317DB9704D936AEA2379 *)__this);
		((  void (*) (Iterator_1_tCFFC952B03DBE4E956DE317DB9704D936AEA2379 *, const RuntimeMethod*))IL2CPP_RGCTX_METHOD_INFO(method->klass->rgctx_data, 0)->methodPointer)((Iterator_1_tCFFC952B03DBE4E956DE317DB9704D936AEA2379 *)__this, /*hidden argument*/IL2CPP_RGCTX_METHOD_INFO(method->klass->rgctx_data, 0));
		List_1_tF837281ACA0AE5696644C85291C841E8820C7AAC * L_0 = ___source0;
		__this->set_source_3(L_0);
		Func_2_t139EF32B1D20FBA53B5FC13859124C746B2D3C04 * L_1 = ___predicate1;
		__this->set_predicate_4(L_1);
		Func_2_tEB5259FF5AA54436077282823F2EEBED7C80AECF * L_2 = ___selector2;
		__this->set_selector_5(L_2);
		return;
	}
}
// System.Linq.Enumerable/Iterator`1<TResult> System.Linq.Enumerable/WhereSelectListIterator`2<System.ValueTuple`2<System.Object,System.Object>,System.Int32>::Clone()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR Iterator_1_tCFFC952B03DBE4E956DE317DB9704D936AEA2379 * WhereSelectListIterator_2_Clone_mC6F369ADF3E2361AA9CBFE28F1743A0372B999B6_gshared (WhereSelectListIterator_2_t6DF338AD50F89D3140CE0D070D507B13786150AC * __this, const RuntimeMethod* method)
{
	{
		List_1_tF837281ACA0AE5696644C85291C841E8820C7AAC * L_0 = (List_1_tF837281ACA0AE5696644C85291C841E8820C7AAC *)__this->get_source_3();
		Func_2_t139EF32B1D20FBA53B5FC13859124C746B2D3C04 * L_1 = (Func_2_t139EF32B1D20FBA53B5FC13859124C746B2D3C04 *)__this->get_predicate_4();
		Func_2_tEB5259FF5AA54436077282823F2EEBED7C80AECF * L_2 = (Func_2_tEB5259FF5AA54436077282823F2EEBED7C80AECF *)__this->get_selector_5();
		WhereSelectListIterator_2_t6DF338AD50F89D3140CE0D070D507B13786150AC * L_3 = (WhereSelectListIterator_2_t6DF338AD50F89D3140CE0D070D507B13786150AC *)il2cpp_codegen_object_new(IL2CPP_RGCTX_DATA(method->klass->rgctx_data, 2));
		((  void (*) (WhereSelectListIterator_2_t6DF338AD50F89D3140CE0D070D507B13786150AC *, List_1_tF837281ACA0AE5696644C85291C841E8820C7AAC *, Func_2_t139EF32B1D20FBA53B5FC13859124C746B2D3C04 *, Func_2_tEB5259FF5AA54436077282823F2EEBED7C80AECF *, const RuntimeMethod*))IL2CPP_RGCTX_METHOD_INFO(method->klass->rgctx_data, 3)->methodPointer)(L_3, (List_1_tF837281ACA0AE5696644C85291C841E8820C7AAC *)L_0, (Func_2_t139EF32B1D20FBA53B5FC13859124C746B2D3C04 *)L_1, (Func_2_tEB5259FF5AA54436077282823F2EEBED7C80AECF *)L_2, /*hidden argument*/IL2CPP_RGCTX_METHOD_INFO(method->klass->rgctx_data, 3));
		return (Iterator_1_tCFFC952B03DBE4E956DE317DB9704D936AEA2379 *)L_3;
	}
}
// System.Boolean System.Linq.Enumerable/WhereSelectListIterator`2<System.ValueTuple`2<System.Object,System.Object>,System.Int32>::MoveNext()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR bool WhereSelectListIterator_2_MoveNext_m87AA7B6ACAAE21E4677FC7B4A7E33B007085C6FF_gshared (WhereSelectListIterator_2_t6DF338AD50F89D3140CE0D070D507B13786150AC * __this, const RuntimeMethod* method)
{
	int32_t V_0 = 0;
	ValueTuple_2_t69671C4973C1A3829B2193E4C598B1AE7162E403  V_1;
	memset((&V_1), 0, sizeof(V_1));
	{
		int32_t L_0 = (int32_t)((Iterator_1_tCFFC952B03DBE4E956DE317DB9704D936AEA2379 *)__this)->get_state_1();
		V_0 = (int32_t)L_0;
		int32_t L_1 = V_0;
		if ((((int32_t)L_1) == ((int32_t)1)))
		{
			goto IL_0011;
		}
	}
	{
		int32_t L_2 = V_0;
		if ((((int32_t)L_2) == ((int32_t)2)))
		{
			goto IL_0061;
		}
	}
	{
		goto IL_0074;
	}

IL_0011:
	{
		List_1_tF837281ACA0AE5696644C85291C841E8820C7AAC * L_3 = (List_1_tF837281ACA0AE5696644C85291C841E8820C7AAC *)__this->get_source_3();
		NullCheck((List_1_tF837281ACA0AE5696644C85291C841E8820C7AAC *)L_3);
		Enumerator_tCF455A92CC670AF169DFC7D0E19B47CAB2BD1DA0  L_4;
		L_4 = ((  Enumerator_tCF455A92CC670AF169DFC7D0E19B47CAB2BD1DA0  (*) (List_1_tF837281ACA0AE5696644C85291C841E8820C7AAC *, const RuntimeMethod*))IL2CPP_RGCTX_METHOD_INFO(method->klass->rgctx_data, 4)->methodPointer)((List_1_tF837281ACA0AE5696644C85291C841E8820C7AAC *)L_3, /*hidden argument*/IL2CPP_RGCTX_METHOD_INFO(method->klass->rgctx_data, 4));
		__this->set_enumerator_6(L_4);
		((Iterator_1_tCFFC952B03DBE4E956DE317DB9704D936AEA2379 *)__this)->set_state_1(2);
		goto IL_0061;
	}

IL_002b:
	{
		Enumerator_tCF455A92CC670AF169DFC7D0E19B47CAB2BD1DA0 * L_5 = (Enumerator_tCF455A92CC670AF169DFC7D0E19B47CAB2BD1DA0 *)__this->get_address_of_enumerator_6();
		ValueTuple_2_t69671C4973C1A3829B2193E4C598B1AE7162E403  L_6;
		L_6 = Enumerator_get_Current_m8B737F0ABD2247C4E13D52C15DEAB59C34368B56_inline((Enumerator_tCF455A92CC670AF169DFC7D0E19B47CAB2BD1DA0 *)(Enumerator_tCF455A92CC670AF169DFC7D0E19B47CAB2BD1DA0 *)L_5, /*hidden argument*/IL2CPP_RGCTX_METHOD_INFO(method->klass->rgctx_data, 5));
		V_1 = (ValueTuple_2_t69671C4973C1A3829B2193E4C598B1AE7162E403 )L_6;
		Func_2_t139EF32B1D20FBA53B5FC13859124C746B2D3C04 * L_7 = (Func_2_t139EF32B1D20FBA53B5FC13859124C746B2D3C04 *)__this->get_predicate_4();
		if (!L_7)
		{
			goto IL_004d;
		}
	}
	{
		Func_2_t139EF32B1D20FBA53B5FC13859124C746B2D3C04 * L_8 = (Func_2_t139EF32B1D20FBA53B5FC13859124C746B2D3C04 *)__this->get_predicate_4();
		ValueTuple_2_t69671C4973C1A3829B2193E4C598B1AE7162E403  L_9 = V_1;
		NullCheck((Func_2_t139EF32B1D20FBA53B5FC13859124C746B2D3C04 *)L_8);
		bool L_10;
		L_10 = ((  bool (*) (Func_2_t139EF32B1D20FBA53B5FC13859124C746B2D3C04 *, ValueTuple_2_t69671C4973C1A3829B2193E4C598B1AE7162E403 , const RuntimeMethod*))IL2CPP_RGCTX_METHOD_INFO(method->klass->rgctx_data, 6)->methodPointer)((Func_2_t139EF32B1D20FBA53B5FC13859124C746B2D3C04 *)L_8, (ValueTuple_2_t69671C4973C1A3829B2193E4C598B1AE7162E403 )L_9, /*hidden argument*/IL2CPP_RGCTX_METHOD_INFO(method->klass->rgctx_data, 6));
		if (!L_10)
		{
			goto IL_0061;
		}
	}

IL_004d:
	{
		Func_2_tEB5259FF5AA54436077282823F2EEBED7C80AECF * L_11 = (Func_2_tEB5259FF5AA54436077282823F2EEBED7C80AECF *)__this->get_selector_5();
		ValueTuple_2_t69671C4973C1A3829B2193E4C598B1AE7162E403  L_12 = V_1;
		NullCheck((Func_2_tEB5259FF5AA54436077282823F2EEBED7C80AECF *)L_11);
		int32_t L_13;
		L_13 = ((  int32_t (*) (Func_2_tEB5259FF5AA54436077282823F2EEBED7C80AECF *, ValueTuple_2_t69671C4973C1A3829B2193E4C598B1AE7162E403 , const RuntimeMethod*))IL2CPP_RGCTX_METHOD_INFO(method->klass->rgctx_data, 7)->methodPointer)((Func_2_tEB5259FF5AA54436077282823F2EEBED7C80AECF *)L_11, (ValueTuple_2_t69671C4973C1A3829B2193E4C598B1AE7162E403 )L_12, /*hidden argument*/IL2CPP_RGCTX_METHOD_INFO(method->klass->rgctx_data, 7));
		((Iterator_1_tCFFC952B03DBE4E956DE317DB9704D936AEA2379 *)__this)->set_current_2(L_13);
		return (bool)1;
	}

IL_0061:
	{
		Enumerator_tCF455A92CC670AF169DFC7D0E19B47CAB2BD1DA0 * L_14 = (Enumerator_tCF455A92CC670AF169DFC7D0E19B47CAB2BD1DA0 *)__this->get_address_of_enumerator_6();
		bool L_15;
		L_15 = Enumerator_MoveNext_mC34E84789B18F4A0FE38F5A6D20958052D39F587((Enumerator_tCF455A92CC670AF169DFC7D0E19B47CAB2BD1DA0 *)(Enumerator_tCF455A92CC670AF169DFC7D0E19B47CAB2BD1DA0 *)L_14, /*hidden argument*/IL2CPP_RGCTX_METHOD_INFO(method->klass->rgctx_data, 8));
		if (L_15)
		{
			goto IL_002b;
		}
	}
	{
		NullCheck((Iterator_1_tCFFC952B03DBE4E956DE317DB9704D936AEA2379 *)__this);
		VirtActionInvoker0::Invoke(12 /* System.Void System.Linq.Enumerable/Iterator`1<System.Int32>::Dispose() */, (Iterator_1_tCFFC952B03DBE4E956DE317DB9704D936AEA2379 *)__this);
	}

IL_0074:
	{
		return (bool)0;
	}
}
// System.Collections.Generic.IEnumerable`1<TResult> System.Linq.Enumerable/WhereSelectListIterator`2<System.ValueTuple`2<System.Object,System.Object>,System.Int32>::Where(System.Func`2<TResult,System.Boolean>)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR RuntimeObject* WhereSelectListIterator_2_Where_mB8044E83C3F255421D77355D8847D0C29FCEEF72_gshared (WhereSelectListIterator_2_t6DF338AD50F89D3140CE0D070D507B13786150AC * __this, Func_2_t2EBF98B0BA555D9F0633C9BCCBE3DF332B9C1274 * ___predicate0, const RuntimeMethod* method)
{
	{
		Func_2_t2EBF98B0BA555D9F0633C9BCCBE3DF332B9C1274 * L_0 = ___predicate0;
		WhereEnumerableIterator_1_t9F4DDC70173BABD72AEC7AA00D62F4FAE2613CEA * L_1 = (WhereEnumerableIterator_1_t9F4DDC70173BABD72AEC7AA00D62F4FAE2613CEA *)il2cpp_codegen_object_new(IL2CPP_RGCTX_DATA(method->klass->rgctx_data, 10));
		((  void (*) (WhereEnumerableIterator_1_t9F4DDC70173BABD72AEC7AA00D62F4FAE2613CEA *, RuntimeObject*, Func_2_t2EBF98B0BA555D9F0633C9BCCBE3DF332B9C1274 *, const RuntimeMethod*))IL2CPP_RGCTX_METHOD_INFO(method->klass->rgctx_data, 11)->methodPointer)(L_1, (RuntimeObject*)__this, (Func_2_t2EBF98B0BA555D9F0633C9BCCBE3DF332B9C1274 *)L_0, /*hidden argument*/IL2CPP_RGCTX_METHOD_INFO(method->klass->rgctx_data, 11));
		return (RuntimeObject*)L_1;
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
// System.Void System.Linq.Enumerable/WhereSelectListIterator`2<System.ValueTuple`2<System.Object,System.Object>,System.Int64>::.ctor(System.Collections.Generic.List`1<TSource>,System.Func`2<TSource,System.Boolean>,System.Func`2<TSource,TResult>)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void WhereSelectListIterator_2__ctor_mC0F4975881CA1D6D2B9E1DAD5E7C4BE04E4073E6_gshared (WhereSelectListIterator_2_t74BEECDFAC30D3415AFB22B70C33682938B5343B * __this, List_1_tF837281ACA0AE5696644C85291C841E8820C7AAC * ___source0, Func_2_t139EF32B1D20FBA53B5FC13859124C746B2D3C04 * ___predicate1, Func_2_tCCE8B772536DC33F644E3A0108AA7059ABA2EDB3 * ___selector2, const RuntimeMethod* method)
{
	{
		NullCheck((Iterator_1_tF88FA02D56A55D26D525180DE0108FA4F019BECE *)__this);
		((  void (*) (Iterator_1_tF88FA02D56A55D26D525180DE0108FA4F019BECE *, const RuntimeMethod*))IL2CPP_RGCTX_METHOD_INFO(method->klass->rgctx_data, 0)->methodPointer)((Iterator_1_tF88FA02D56A55D26D525180DE0108FA4F019BECE *)__this, /*hidden argument*/IL2CPP_RGCTX_METHOD_INFO(method->klass->rgctx_data, 0));
		List_1_tF837281ACA0AE5696644C85291C841E8820C7AAC * L_0 = ___source0;
		__this->set_source_3(L_0);
		Func_2_t139EF32B1D20FBA53B5FC13859124C746B2D3C04 * L_1 = ___predicate1;
		__this->set_predicate_4(L_1);
		Func_2_tCCE8B772536DC33F644E3A0108AA7059ABA2EDB3 * L_2 = ___selector2;
		__this->set_selector_5(L_2);
		return;
	}
}
// System.Linq.Enumerable/Iterator`1<TResult> System.Linq.Enumerable/WhereSelectListIterator`2<System.ValueTuple`2<System.Object,System.Object>,System.Int64>::Clone()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR Iterator_1_tF88FA02D56A55D26D525180DE0108FA4F019BECE * WhereSelectListIterator_2_Clone_m114BDBCCB97A70D5C0C19B85781E6A73BFA5CD8A_gshared (WhereSelectListIterator_2_t74BEECDFAC30D3415AFB22B70C33682938B5343B * __this, const RuntimeMethod* method)
{
	{
		List_1_tF837281ACA0AE5696644C85291C841E8820C7AAC * L_0 = (List_1_tF837281ACA0AE5696644C85291C841E8820C7AAC *)__this->get_source_3();
		Func_2_t139EF32B1D20FBA53B5FC13859124C746B2D3C04 * L_1 = (Func_2_t139EF32B1D20FBA53B5FC13859124C746B2D3C04 *)__this->get_predicate_4();
		Func_2_tCCE8B772536DC33F644E3A0108AA7059ABA2EDB3 * L_2 = (Func_2_tCCE8B772536DC33F644E3A0108AA7059ABA2EDB3 *)__this->get_selector_5();
		WhereSelectListIterator_2_t74BEECDFAC30D3415AFB22B70C33682938B5343B * L_3 = (WhereSelectListIterator_2_t74BEECDFAC30D3415AFB22B70C33682938B5343B *)il2cpp_codegen_object_new(IL2CPP_RGCTX_DATA(method->klass->rgctx_data, 2));
		((  void (*) (WhereSelectListIterator_2_t74BEECDFAC30D3415AFB22B70C33682938B5343B *, List_1_tF837281ACA0AE5696644C85291C841E8820C7AAC *, Func_2_t139EF32B1D20FBA53B5FC13859124C746B2D3C04 *, Func_2_tCCE8B772536DC33F644E3A0108AA7059ABA2EDB3 *, const RuntimeMethod*))IL2CPP_RGCTX_METHOD_INFO(method->klass->rgctx_data, 3)->methodPointer)(L_3, (List_1_tF837281ACA0AE5696644C85291C841E8820C7AAC *)L_0, (Func_2_t139EF32B1D20FBA53B5FC13859124C746B2D3C04 *)L_1, (Func_2_tCCE8B772536DC33F644E3A0108AA7059ABA2EDB3 *)L_2, /*hidden argument*/IL2CPP_RGCTX_METHOD_INFO(method->klass->rgctx_data, 3));
		return (Iterator_1_tF88FA02D56A55D26D525180DE0108FA4F019BECE *)L_3;
	}
}
// System.Boolean System.Linq.Enumerable/WhereSelectListIterator`2<System.ValueTuple`2<System.Object,System.Object>,System.Int64>::MoveNext()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR bool WhereSelectListIterator_2_MoveNext_m148D90C9430DA29773D7A3100075B478EDBA4231_gshared (WhereSelectListIterator_2_t74BEECDFAC30D3415AFB22B70C33682938B5343B * __this, const RuntimeMethod* method)
{
	int32_t V_0 = 0;
	ValueTuple_2_t69671C4973C1A3829B2193E4C598B1AE7162E403  V_1;
	memset((&V_1), 0, sizeof(V_1));
	{
		int32_t L_0 = (int32_t)((Iterator_1_tF88FA02D56A55D26D525180DE0108FA4F019BECE *)__this)->get_state_1();
		V_0 = (int32_t)L_0;
		int32_t L_1 = V_0;
		if ((((int32_t)L_1) == ((int32_t)1)))
		{
			goto IL_0011;
		}
	}
	{
		int32_t L_2 = V_0;
		if ((((int32_t)L_2) == ((int32_t)2)))
		{
			goto IL_0061;
		}
	}
	{
		goto IL_0074;
	}

IL_0011:
	{
		List_1_tF837281ACA0AE5696644C85291C841E8820C7AAC * L_3 = (List_1_tF837281ACA0AE5696644C85291C841E8820C7AAC *)__this->get_source_3();
		NullCheck((List_1_tF837281ACA0AE5696644C85291C841E8820C7AAC *)L_3);
		Enumerator_tCF455A92CC670AF169DFC7D0E19B47CAB2BD1DA0  L_4;
		L_4 = ((  Enumerator_tCF455A92CC670AF169DFC7D0E19B47CAB2BD1DA0  (*) (List_1_tF837281ACA0AE5696644C85291C841E8820C7AAC *, const RuntimeMethod*))IL2CPP_RGCTX_METHOD_INFO(method->klass->rgctx_data, 4)->methodPointer)((List_1_tF837281ACA0AE5696644C85291C841E8820C7AAC *)L_3, /*hidden argument*/IL2CPP_RGCTX_METHOD_INFO(method->klass->rgctx_data, 4));
		__this->set_enumerator_6(L_4);
		((Iterator_1_tF88FA02D56A55D26D525180DE0108FA4F019BECE *)__this)->set_state_1(2);
		goto IL_0061;
	}

IL_002b:
	{
		Enumerator_tCF455A92CC670AF169DFC7D0E19B47CAB2BD1DA0 * L_5 = (Enumerator_tCF455A92CC670AF169DFC7D0E19B47CAB2BD1DA0 *)__this->get_address_of_enumerator_6();
		ValueTuple_2_t69671C4973C1A3829B2193E4C598B1AE7162E403  L_6;
		L_6 = Enumerator_get_Current_m8B737F0ABD2247C4E13D52C15DEAB59C34368B56_inline((Enumerator_tCF455A92CC670AF169DFC7D0E19B47CAB2BD1DA0 *)(Enumerator_tCF455A92CC670AF169DFC7D0E19B47CAB2BD1DA0 *)L_5, /*hidden argument*/IL2CPP_RGCTX_METHOD_INFO(method->klass->rgctx_data, 5));
		V_1 = (ValueTuple_2_t69671C4973C1A3829B2193E4C598B1AE7162E403 )L_6;
		Func_2_t139EF32B1D20FBA53B5FC13859124C746B2D3C04 * L_7 = (Func_2_t139EF32B1D20FBA53B5FC13859124C746B2D3C04 *)__this->get_predicate_4();
		if (!L_7)
		{
			goto IL_004d;
		}
	}
	{
		Func_2_t139EF32B1D20FBA53B5FC13859124C746B2D3C04 * L_8 = (Func_2_t139EF32B1D20FBA53B5FC13859124C746B2D3C04 *)__this->get_predicate_4();
		ValueTuple_2_t69671C4973C1A3829B2193E4C598B1AE7162E403  L_9 = V_1;
		NullCheck((Func_2_t139EF32B1D20FBA53B5FC13859124C746B2D3C04 *)L_8);
		bool L_10;
		L_10 = ((  bool (*) (Func_2_t139EF32B1D20FBA53B5FC13859124C746B2D3C04 *, ValueTuple_2_t69671C4973C1A3829B2193E4C598B1AE7162E403 , const RuntimeMethod*))IL2CPP_RGCTX_METHOD_INFO(method->klass->rgctx_data, 6)->methodPointer)((Func_2_t139EF32B1D20FBA53B5FC13859124C746B2D3C04 *)L_8, (ValueTuple_2_t69671C4973C1A3829B2193E4C598B1AE7162E403 )L_9, /*hidden argument*/IL2CPP_RGCTX_METHOD_INFO(method->klass->rgctx_data, 6));
		if (!L_10)
		{
			goto IL_0061;
		}
	}

IL_004d:
	{
		Func_2_tCCE8B772536DC33F644E3A0108AA7059ABA2EDB3 * L_11 = (Func_2_tCCE8B772536DC33F644E3A0108AA7059ABA2EDB3 *)__this->get_selector_5();
		ValueTuple_2_t69671C4973C1A3829B2193E4C598B1AE7162E403  L_12 = V_1;
		NullCheck((Func_2_tCCE8B772536DC33F644E3A0108AA7059ABA2EDB3 *)L_11);
		int64_t L_13;
		L_13 = ((  int64_t (*) (Func_2_tCCE8B772536DC33F644E3A0108AA7059ABA2EDB3 *, ValueTuple_2_t69671C4973C1A3829B2193E4C598B1AE7162E403 , const RuntimeMethod*))IL2CPP_RGCTX_METHOD_INFO(method->klass->rgctx_data, 7)->methodPointer)((Func_2_tCCE8B772536DC33F644E3A0108AA7059ABA2EDB3 *)L_11, (ValueTuple_2_t69671C4973C1A3829B2193E4C598B1AE7162E403 )L_12, /*hidden argument*/IL2CPP_RGCTX_METHOD_INFO(method->klass->rgctx_data, 7));
		((Iterator_1_tF88FA02D56A55D26D525180DE0108FA4F019BECE *)__this)->set_current_2(L_13);
		return (bool)1;
	}

IL_0061:
	{
		Enumerator_tCF455A92CC670AF169DFC7D0E19B47CAB2BD1DA0 * L_14 = (Enumerator_tCF455A92CC670AF169DFC7D0E19B47CAB2BD1DA0 *)__this->get_address_of_enumerator_6();
		bool L_15;
		L_15 = Enumerator_MoveNext_mC34E84789B18F4A0FE38F5A6D20958052D39F587((Enumerator_tCF455A92CC670AF169DFC7D0E19B47CAB2BD1DA0 *)(Enumerator_tCF455A92CC670AF169DFC7D0E19B47CAB2BD1DA0 *)L_14, /*hidden argument*/IL2CPP_RGCTX_METHOD_INFO(method->klass->rgctx_data, 8));
		if (L_15)
		{
			goto IL_002b;
		}
	}
	{
		NullCheck((Iterator_1_tF88FA02D56A55D26D525180DE0108FA4F019BECE *)__this);
		VirtActionInvoker0::Invoke(12 /* System.Void System.Linq.Enumerable/Iterator`1<System.Int64>::Dispose() */, (Iterator_1_tF88FA02D56A55D26D525180DE0108FA4F019BECE *)__this);
	}

IL_0074:
	{
		return (bool)0;
	}
}
// System.Collections.Generic.IEnumerable`1<TResult> System.Linq.Enumerable/WhereSelectListIterator`2<System.ValueTuple`2<System.Object,System.Object>,System.Int64>::Where(System.Func`2<TResult,System.Boolean>)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR RuntimeObject* WhereSelectListIterator_2_Where_m42E88C4DEE9E896F87B33D8AB007ED62F2F46234_gshared (WhereSelectListIterator_2_t74BEECDFAC30D3415AFB22B70C33682938B5343B * __this, Func_2_t03B9AF86FB7E93B62590F1CBD16276EF7AA1B215 * ___predicate0, const RuntimeMethod* method)
{
	{
		Func_2_t03B9AF86FB7E93B62590F1CBD16276EF7AA1B215 * L_0 = ___predicate0;
		WhereEnumerableIterator_1_tBAC8281C998E41429788C96260CB05A7E0471BC1 * L_1 = (WhereEnumerableIterator_1_tBAC8281C998E41429788C96260CB05A7E0471BC1 *)il2cpp_codegen_object_new(IL2CPP_RGCTX_DATA(method->klass->rgctx_data, 10));
		((  void (*) (WhereEnumerableIterator_1_tBAC8281C998E41429788C96260CB05A7E0471BC1 *, RuntimeObject*, Func_2_t03B9AF86FB7E93B62590F1CBD16276EF7AA1B215 *, const RuntimeMethod*))IL2CPP_RGCTX_METHOD_INFO(method->klass->rgctx_data, 11)->methodPointer)(L_1, (RuntimeObject*)__this, (Func_2_t03B9AF86FB7E93B62590F1CBD16276EF7AA1B215 *)L_0, /*hidden argument*/IL2CPP_RGCTX_METHOD_INFO(method->klass->rgctx_data, 11));
		return (RuntimeObject*)L_1;
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
// System.Void System.Linq.Enumerable/WhereSelectListIterator`2<System.ValueTuple`2<System.Object,System.Object>,System.Object>::.ctor(System.Collections.Generic.List`1<TSource>,System.Func`2<TSource,System.Boolean>,System.Func`2<TSource,TResult>)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void WhereSelectListIterator_2__ctor_mF569CC89F53F5F80C77643FE538082B8CD90713B_gshared (WhereSelectListIterator_2_tF4580FBFA67D084FC48A2A4D3CCD114BE92FAD20 * __this, List_1_tF837281ACA0AE5696644C85291C841E8820C7AAC * ___source0, Func_2_t139EF32B1D20FBA53B5FC13859124C746B2D3C04 * ___predicate1, Func_2_tD5B31A0553FE51700369DE1E4E6F33189C45045A * ___selector2, const RuntimeMethod* method)
{
	{
		NullCheck((Iterator_1_t674ABE41CF4096D4BE4D51E21FEBDADBF74CC279 *)__this);
		((  void (*) (Iterator_1_t674ABE41CF4096D4BE4D51E21FEBDADBF74CC279 *, const RuntimeMethod*))IL2CPP_RGCTX_METHOD_INFO(method->klass->rgctx_data, 0)->methodPointer)((Iterator_1_t674ABE41CF4096D4BE4D51E21FEBDADBF74CC279 *)__this, /*hidden argument*/IL2CPP_RGCTX_METHOD_INFO(method->klass->rgctx_data, 0));
		List_1_tF837281ACA0AE5696644C85291C841E8820C7AAC * L_0 = ___source0;
		__this->set_source_3(L_0);
		Func_2_t139EF32B1D20FBA53B5FC13859124C746B2D3C04 * L_1 = ___predicate1;
		__this->set_predicate_4(L_1);
		Func_2_tD5B31A0553FE51700369DE1E4E6F33189C45045A * L_2 = ___selector2;
		__this->set_selector_5(L_2);
		return;
	}
}
// System.Linq.Enumerable/Iterator`1<TResult> System.Linq.Enumerable/WhereSelectListIterator`2<System.ValueTuple`2<System.Object,System.Object>,System.Object>::Clone()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR Iterator_1_t674ABE41CF4096D4BE4D51E21FEBDADBF74CC279 * WhereSelectListIterator_2_Clone_m12AD8ADA69284442E5C75AAD5E125633694B679E_gshared (WhereSelectListIterator_2_tF4580FBFA67D084FC48A2A4D3CCD114BE92FAD20 * __this, const RuntimeMethod* method)
{
	{
		List_1_tF837281ACA0AE5696644C85291C841E8820C7AAC * L_0 = (List_1_tF837281ACA0AE5696644C85291C841E8820C7AAC *)__this->get_source_3();
		Func_2_t139EF32B1D20FBA53B5FC13859124C746B2D3C04 * L_1 = (Func_2_t139EF32B1D20FBA53B5FC13859124C746B2D3C04 *)__this->get_predicate_4();
		Func_2_tD5B31A0553FE51700369DE1E4E6F33189C45045A * L_2 = (Func_2_tD5B31A0553FE51700369DE1E4E6F33189C45045A *)__this->get_selector_5();
		WhereSelectListIterator_2_tF4580FBFA67D084FC48A2A4D3CCD114BE92FAD20 * L_3 = (WhereSelectListIterator_2_tF4580FBFA67D084FC48A2A4D3CCD114BE92FAD20 *)il2cpp_codegen_object_new(IL2CPP_RGCTX_DATA(method->klass->rgctx_data, 2));
		((  void (*) (WhereSelectListIterator_2_tF4580FBFA67D084FC48A2A4D3CCD114BE92FAD20 *, List_1_tF837281ACA0AE5696644C85291C841E8820C7AAC *, Func_2_t139EF32B1D20FBA53B5FC13859124C746B2D3C04 *, Func_2_tD5B31A0553FE51700369DE1E4E6F33189C45045A *, const RuntimeMethod*))IL2CPP_RGCTX_METHOD_INFO(method->klass->rgctx_data, 3)->methodPointer)(L_3, (List_1_tF837281ACA0AE5696644C85291C841E8820C7AAC *)L_0, (Func_2_t139EF32B1D20FBA53B5FC13859124C746B2D3C04 *)L_1, (Func_2_tD5B31A0553FE51700369DE1E4E6F33189C45045A *)L_2, /*hidden argument*/IL2CPP_RGCTX_METHOD_INFO(method->klass->rgctx_data, 3));
		return (Iterator_1_t674ABE41CF4096D4BE4D51E21FEBDADBF74CC279 *)L_3;
	}
}
// System.Boolean System.Linq.Enumerable/WhereSelectListIterator`2<System.ValueTuple`2<System.Object,System.Object>,System.Object>::MoveNext()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR bool WhereSelectListIterator_2_MoveNext_mF99E19BF2FE76C09A36252696113AFA6CFDB6EB6_gshared (WhereSelectListIterator_2_tF4580FBFA67D084FC48A2A4D3CCD114BE92FAD20 * __this, const RuntimeMethod* method)
{
	int32_t V_0 = 0;
	ValueTuple_2_t69671C4973C1A3829B2193E4C598B1AE7162E403  V_1;
	memset((&V_1), 0, sizeof(V_1));
	{
		int32_t L_0 = (int32_t)((Iterator_1_t674ABE41CF4096D4BE4D51E21FEBDADBF74CC279 *)__this)->get_state_1();
		V_0 = (int32_t)L_0;
		int32_t L_1 = V_0;
		if ((((int32_t)L_1) == ((int32_t)1)))
		{
			goto IL_0011;
		}
	}
	{
		int32_t L_2 = V_0;
		if ((((int32_t)L_2) == ((int32_t)2)))
		{
			goto IL_0061;
		}
	}
	{
		goto IL_0074;
	}

IL_0011:
	{
		List_1_tF837281ACA0AE5696644C85291C841E8820C7AAC * L_3 = (List_1_tF837281ACA0AE5696644C85291C841E8820C7AAC *)__this->get_source_3();
		NullCheck((List_1_tF837281ACA0AE5696644C85291C841E8820C7AAC *)L_3);
		Enumerator_tCF455A92CC670AF169DFC7D0E19B47CAB2BD1DA0  L_4;
		L_4 = ((  Enumerator_tCF455A92CC670AF169DFC7D0E19B47CAB2BD1DA0  (*) (List_1_tF837281ACA0AE5696644C85291C841E8820C7AAC *, const RuntimeMethod*))IL2CPP_RGCTX_METHOD_INFO(method->klass->rgctx_data, 4)->methodPointer)((List_1_tF837281ACA0AE5696644C85291C841E8820C7AAC *)L_3, /*hidden argument*/IL2CPP_RGCTX_METHOD_INFO(method->klass->rgctx_data, 4));
		__this->set_enumerator_6(L_4);
		((Iterator_1_t674ABE41CF4096D4BE4D51E21FEBDADBF74CC279 *)__this)->set_state_1(2);
		goto IL_0061;
	}

IL_002b:
	{
		Enumerator_tCF455A92CC670AF169DFC7D0E19B47CAB2BD1DA0 * L_5 = (Enumerator_tCF455A92CC670AF169DFC7D0E19B47CAB2BD1DA0 *)__this->get_address_of_enumerator_6();
		ValueTuple_2_t69671C4973C1A3829B2193E4C598B1AE7162E403  L_6;
		L_6 = Enumerator_get_Current_m8B737F0ABD2247C4E13D52C15DEAB59C34368B56_inline((Enumerator_tCF455A92CC670AF169DFC7D0E19B47CAB2BD1DA0 *)(Enumerator_tCF455A92CC670AF169DFC7D0E19B47CAB2BD1DA0 *)L_5, /*hidden argument*/IL2CPP_RGCTX_METHOD_INFO(method->klass->rgctx_data, 5));
		V_1 = (ValueTuple_2_t69671C4973C1A3829B2193E4C598B1AE7162E403 )L_6;
		Func_2_t139EF32B1D20FBA53B5FC13859124C746B2D3C04 * L_7 = (Func_2_t139EF32B1D20FBA53B5FC13859124C746B2D3C04 *)__this->get_predicate_4();
		if (!L_7)
		{
			goto IL_004d;
		}
	}
	{
		Func_2_t139EF32B1D20FBA53B5FC13859124C746B2D3C04 * L_8 = (Func_2_t139EF32B1D20FBA53B5FC13859124C746B2D3C04 *)__this->get_predicate_4();
		ValueTuple_2_t69671C4973C1A3829B2193E4C598B1AE7162E403  L_9 = V_1;
		NullCheck((Func_2_t139EF32B1D20FBA53B5FC13859124C746B2D3C04 *)L_8);
		bool L_10;
		L_10 = ((  bool (*) (Func_2_t139EF32B1D20FBA53B5FC13859124C746B2D3C04 *, ValueTuple_2_t69671C4973C1A3829B2193E4C598B1AE7162E403 , const RuntimeMethod*))IL2CPP_RGCTX_METHOD_INFO(method->klass->rgctx_data, 6)->methodPointer)((Func_2_t139EF32B1D20FBA53B5FC13859124C746B2D3C04 *)L_8, (ValueTuple_2_t69671C4973C1A3829B2193E4C598B1AE7162E403 )L_9, /*hidden argument*/IL2CPP_RGCTX_METHOD_INFO(method->klass->rgctx_data, 6));
		if (!L_10)
		{
			goto IL_0061;
		}
	}

IL_004d:
	{
		Func_2_tD5B31A0553FE51700369DE1E4E6F33189C45045A * L_11 = (Func_2_tD5B31A0553FE51700369DE1E4E6F33189C45045A *)__this->get_selector_5();
		ValueTuple_2_t69671C4973C1A3829B2193E4C598B1AE7162E403  L_12 = V_1;
		NullCheck((Func_2_tD5B31A0553FE51700369DE1E4E6F33189C45045A *)L_11);
		RuntimeObject * L_13;
		L_13 = ((  RuntimeObject * (*) (Func_2_tD5B31A0553FE51700369DE1E4E6F33189C45045A *, ValueTuple_2_t69671C4973C1A3829B2193E4C598B1AE7162E403 , const RuntimeMethod*))IL2CPP_RGCTX_METHOD_INFO(method->klass->rgctx_data, 7)->methodPointer)((Func_2_tD5B31A0553FE51700369DE1E4E6F33189C45045A *)L_11, (ValueTuple_2_t69671C4973C1A3829B2193E4C598B1AE7162E403 )L_12, /*hidden argument*/IL2CPP_RGCTX_METHOD_INFO(method->klass->rgctx_data, 7));
		((Iterator_1_t674ABE41CF4096D4BE4D51E21FEBDADBF74CC279 *)__this)->set_current_2(L_13);
		return (bool)1;
	}

IL_0061:
	{
		Enumerator_tCF455A92CC670AF169DFC7D0E19B47CAB2BD1DA0 * L_14 = (Enumerator_tCF455A92CC670AF169DFC7D0E19B47CAB2BD1DA0 *)__this->get_address_of_enumerator_6();
		bool L_15;
		L_15 = Enumerator_MoveNext_mC34E84789B18F4A0FE38F5A6D20958052D39F587((Enumerator_tCF455A92CC670AF169DFC7D0E19B47CAB2BD1DA0 *)(Enumerator_tCF455A92CC670AF169DFC7D0E19B47CAB2BD1DA0 *)L_14, /*hidden argument*/IL2CPP_RGCTX_METHOD_INFO(method->klass->rgctx_data, 8));
		if (L_15)
		{
			goto IL_002b;
		}
	}
	{
		NullCheck((Iterator_1_t674ABE41CF4096D4BE4D51E21FEBDADBF74CC279 *)__this);
		VirtActionInvoker0::Invoke(12 /* System.Void System.Linq.Enumerable/Iterator`1<System.Object>::Dispose() */, (Iterator_1_t674ABE41CF4096D4BE4D51E21FEBDADBF74CC279 *)__this);
	}

IL_0074:
	{
		return (bool)0;
	}
}
// System.Collections.Generic.IEnumerable`1<TResult> System.Linq.Enumerable/WhereSelectListIterator`2<System.ValueTuple`2<System.Object,System.Object>,System.Object>::Where(System.Func`2<TResult,System.Boolean>)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR RuntimeObject* WhereSelectListIterator_2_Where_m745D1E411CD958F2B7D1F83F958E6372412128DE_gshared (WhereSelectListIterator_2_tF4580FBFA67D084FC48A2A4D3CCD114BE92FAD20 * __this, Func_2_t99409DECFF50F0FA9B427C863AC6C99C66E6F9F8 * ___predicate0, const RuntimeMethod* method)
{
	{
		Func_2_t99409DECFF50F0FA9B427C863AC6C99C66E6F9F8 * L_0 = ___predicate0;
		WhereEnumerableIterator_1_t1E9FDCFD8F8136C6A5A5740C1E093EF03F0B5CE0 * L_1 = (WhereEnumerableIterator_1_t1E9FDCFD8F8136C6A5A5740C1E093EF03F0B5CE0 *)il2cpp_codegen_object_new(IL2CPP_RGCTX_DATA(method->klass->rgctx_data, 10));
		((  void (*) (WhereEnumerableIterator_1_t1E9FDCFD8F8136C6A5A5740C1E093EF03F0B5CE0 *, RuntimeObject*, Func_2_t99409DECFF50F0FA9B427C863AC6C99C66E6F9F8 *, const RuntimeMethod*))IL2CPP_RGCTX_METHOD_INFO(method->klass->rgctx_data, 11)->methodPointer)(L_1, (RuntimeObject*)__this, (Func_2_t99409DECFF50F0FA9B427C863AC6C99C66E6F9F8 *)L_0, /*hidden argument*/IL2CPP_RGCTX_METHOD_INFO(method->klass->rgctx_data, 11));
		return (RuntimeObject*)L_1;
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
// System.Void System.Linq.Enumerable/WhereSelectListIterator`2<System.ValueTuple`2<System.Object,System.Object>,System.Single>::.ctor(System.Collections.Generic.List`1<TSource>,System.Func`2<TSource,System.Boolean>,System.Func`2<TSource,TResult>)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void WhereSelectListIterator_2__ctor_mC44548394571530B3EF2181312383BBF0D58DD0F_gshared (WhereSelectListIterator_2_tBC8201B4C00B3004BB33AA252E6112F87595F077 * __this, List_1_tF837281ACA0AE5696644C85291C841E8820C7AAC * ___source0, Func_2_t139EF32B1D20FBA53B5FC13859124C746B2D3C04 * ___predicate1, Func_2_tCFA319B29B51C5B4FA9EE912CCB3BB9525555F72 * ___selector2, const RuntimeMethod* method)
{
	{
		NullCheck((Iterator_1_t859CAAB8DD3B63D3758E13D2802ED7523B331199 *)__this);
		((  void (*) (Iterator_1_t859CAAB8DD3B63D3758E13D2802ED7523B331199 *, const RuntimeMethod*))IL2CPP_RGCTX_METHOD_INFO(method->klass->rgctx_data, 0)->methodPointer)((Iterator_1_t859CAAB8DD3B63D3758E13D2802ED7523B331199 *)__this, /*hidden argument*/IL2CPP_RGCTX_METHOD_INFO(method->klass->rgctx_data, 0));
		List_1_tF837281ACA0AE5696644C85291C841E8820C7AAC * L_0 = ___source0;
		__this->set_source_3(L_0);
		Func_2_t139EF32B1D20FBA53B5FC13859124C746B2D3C04 * L_1 = ___predicate1;
		__this->set_predicate_4(L_1);
		Func_2_tCFA319B29B51C5B4FA9EE912CCB3BB9525555F72 * L_2 = ___selector2;
		__this->set_selector_5(L_2);
		return;
	}
}
// System.Linq.Enumerable/Iterator`1<TResult> System.Linq.Enumerable/WhereSelectListIterator`2<System.ValueTuple`2<System.Object,System.Object>,System.Single>::Clone()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR Iterator_1_t859CAAB8DD3B63D3758E13D2802ED7523B331199 * WhereSelectListIterator_2_Clone_m05D4A401DE905C3E7182A641F3484324B5F658A9_gshared (WhereSelectListIterator_2_tBC8201B4C00B3004BB33AA252E6112F87595F077 * __this, const RuntimeMethod* method)
{
	{
		List_1_tF837281ACA0AE5696644C85291C841E8820C7AAC * L_0 = (List_1_tF837281ACA0AE5696644C85291C841E8820C7AAC *)__this->get_source_3();
		Func_2_t139EF32B1D20FBA53B5FC13859124C746B2D3C04 * L_1 = (Func_2_t139EF32B1D20FBA53B5FC13859124C746B2D3C04 *)__this->get_predicate_4();
		Func_2_tCFA319B29B51C5B4FA9EE912CCB3BB9525555F72 * L_2 = (Func_2_tCFA319B29B51C5B4FA9EE912CCB3BB9525555F72 *)__this->get_selector_5();
		WhereSelectListIterator_2_tBC8201B4C00B3004BB33AA252E6112F87595F077 * L_3 = (WhereSelectListIterator_2_tBC8201B4C00B3004BB33AA252E6112F87595F077 *)il2cpp_codegen_object_new(IL2CPP_RGCTX_DATA(method->klass->rgctx_data, 2));
		((  void (*) (WhereSelectListIterator_2_tBC8201B4C00B3004BB33AA252E6112F87595F077 *, List_1_tF837281ACA0AE5696644C85291C841E8820C7AAC *, Func_2_t139EF32B1D20FBA53B5FC13859124C746B2D3C04 *, Func_2_tCFA319B29B51C5B4FA9EE912CCB3BB9525555F72 *, const RuntimeMethod*))IL2CPP_RGCTX_METHOD_INFO(method->klass->rgctx_data, 3)->methodPointer)(L_3, (List_1_tF837281ACA0AE5696644C85291C841E8820C7AAC *)L_0, (Func_2_t139EF32B1D20FBA53B5FC13859124C746B2D3C04 *)L_1, (Func_2_tCFA319B29B51C5B4FA9EE912CCB3BB9525555F72 *)L_2, /*hidden argument*/IL2CPP_RGCTX_METHOD_INFO(method->klass->rgctx_data, 3));
		return (Iterator_1_t859CAAB8DD3B63D3758E13D2802ED7523B331199 *)L_3;
	}
}
// System.Boolean System.Linq.Enumerable/WhereSelectListIterator`2<System.ValueTuple`2<System.Object,System.Object>,System.Single>::MoveNext()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR bool WhereSelectListIterator_2_MoveNext_mC5E59DFCB615EFDE7EC0147460C713B010104F2C_gshared (WhereSelectListIterator_2_tBC8201B4C00B3004BB33AA252E6112F87595F077 * __this, const RuntimeMethod* method)
{
	int32_t V_0 = 0;
	ValueTuple_2_t69671C4973C1A3829B2193E4C598B1AE7162E403  V_1;
	memset((&V_1), 0, sizeof(V_1));
	{
		int32_t L_0 = (int32_t)((Iterator_1_t859CAAB8DD3B63D3758E13D2802ED7523B331199 *)__this)->get_state_1();
		V_0 = (int32_t)L_0;
		int32_t L_1 = V_0;
		if ((((int32_t)L_1) == ((int32_t)1)))
		{
			goto IL_0011;
		}
	}
	{
		int32_t L_2 = V_0;
		if ((((int32_t)L_2) == ((int32_t)2)))
		{
			goto IL_0061;
		}
	}
	{
		goto IL_0074;
	}

IL_0011:
	{
		List_1_tF837281ACA0AE5696644C85291C841E8820C7AAC * L_3 = (List_1_tF837281ACA0AE5696644C85291C841E8820C7AAC *)__this->get_source_3();
		NullCheck((List_1_tF837281ACA0AE5696644C85291C841E8820C7AAC *)L_3);
		Enumerator_tCF455A92CC670AF169DFC7D0E19B47CAB2BD1DA0  L_4;
		L_4 = ((  Enumerator_tCF455A92CC670AF169DFC7D0E19B47CAB2BD1DA0  (*) (List_1_tF837281ACA0AE5696644C85291C841E8820C7AAC *, const RuntimeMethod*))IL2CPP_RGCTX_METHOD_INFO(method->klass->rgctx_data, 4)->methodPointer)((List_1_tF837281ACA0AE5696644C85291C841E8820C7AAC *)L_3, /*hidden argument*/IL2CPP_RGCTX_METHOD_INFO(method->klass->rgctx_data, 4));
		__this->set_enumerator_6(L_4);
		((Iterator_1_t859CAAB8DD3B63D3758E13D2802ED7523B331199 *)__this)->set_state_1(2);
		goto IL_0061;
	}

IL_002b:
	{
		Enumerator_tCF455A92CC670AF169DFC7D0E19B47CAB2BD1DA0 * L_5 = (Enumerator_tCF455A92CC670AF169DFC7D0E19B47CAB2BD1DA0 *)__this->get_address_of_enumerator_6();
		ValueTuple_2_t69671C4973C1A3829B2193E4C598B1AE7162E403  L_6;
		L_6 = Enumerator_get_Current_m8B737F0ABD2247C4E13D52C15DEAB59C34368B56_inline((Enumerator_tCF455A92CC670AF169DFC7D0E19B47CAB2BD1DA0 *)(Enumerator_tCF455A92CC670AF169DFC7D0E19B47CAB2BD1DA0 *)L_5, /*hidden argument*/IL2CPP_RGCTX_METHOD_INFO(method->klass->rgctx_data, 5));
		V_1 = (ValueTuple_2_t69671C4973C1A3829B2193E4C598B1AE7162E403 )L_6;
		Func_2_t139EF32B1D20FBA53B5FC13859124C746B2D3C04 * L_7 = (Func_2_t139EF32B1D20FBA53B5FC13859124C746B2D3C04 *)__this->get_predicate_4();
		if (!L_7)
		{
			goto IL_004d;
		}
	}
	{
		Func_2_t139EF32B1D20FBA53B5FC13859124C746B2D3C04 * L_8 = (Func_2_t139EF32B1D20FBA53B5FC13859124C746B2D3C04 *)__this->get_predicate_4();
		ValueTuple_2_t69671C4973C1A3829B2193E4C598B1AE7162E403  L_9 = V_1;
		NullCheck((Func_2_t139EF32B1D20FBA53B5FC13859124C746B2D3C04 *)L_8);
		bool L_10;
		L_10 = ((  bool (*) (Func_2_t139EF32B1D20FBA53B5FC13859124C746B2D3C04 *, ValueTuple_2_t69671C4973C1A3829B2193E4C598B1AE7162E403 , const RuntimeMethod*))IL2CPP_RGCTX_METHOD_INFO(method->klass->rgctx_data, 6)->methodPointer)((Func_2_t139EF32B1D20FBA53B5FC13859124C746B2D3C04 *)L_8, (ValueTuple_2_t69671C4973C1A3829B2193E4C598B1AE7162E403 )L_9, /*hidden argument*/IL2CPP_RGCTX_METHOD_INFO(method->klass->rgctx_data, 6));
		if (!L_10)
		{
			goto IL_0061;
		}
	}

IL_004d:
	{
		Func_2_tCFA319B29B51C5B4FA9EE912CCB3BB9525555F72 * L_11 = (Func_2_tCFA319B29B51C5B4FA9EE912CCB3BB9525555F72 *)__this->get_selector_5();
		ValueTuple_2_t69671C4973C1A3829B2193E4C598B1AE7162E403  L_12 = V_1;
		NullCheck((Func_2_tCFA319B29B51C5B4FA9EE912CCB3BB9525555F72 *)L_11);
		float L_13;
		L_13 = ((  float (*) (Func_2_tCFA319B29B51C5B4FA9EE912CCB3BB9525555F72 *, ValueTuple_2_t69671C4973C1A3829B2193E4C598B1AE7162E403 , const RuntimeMethod*))IL2CPP_RGCTX_METHOD_INFO(method->klass->rgctx_data, 7)->methodPointer)((Func_2_tCFA319B29B51C5B4FA9EE912CCB3BB9525555F72 *)L_11, (ValueTuple_2_t69671C4973C1A3829B2193E4C598B1AE7162E403 )L_12, /*hidden argument*/IL2CPP_RGCTX_METHOD_INFO(method->klass->rgctx_data, 7));
		((Iterator_1_t859CAAB8DD3B63D3758E13D2802ED7523B331199 *)__this)->set_current_2(L_13);
		return (bool)1;
	}

IL_0061:
	{
		Enumerator_tCF455A92CC670AF169DFC7D0E19B47CAB2BD1DA0 * L_14 = (Enumerator_tCF455A92CC670AF169DFC7D0E19B47CAB2BD1DA0 *)__this->get_address_of_enumerator_6();
		bool L_15;
		L_15 = Enumerator_MoveNext_mC34E84789B18F4A0FE38F5A6D20958052D39F587((Enumerator_tCF455A92CC670AF169DFC7D0E19B47CAB2BD1DA0 *)(Enumerator_tCF455A92CC670AF169DFC7D0E19B47CAB2BD1DA0 *)L_14, /*hidden argument*/IL2CPP_RGCTX_METHOD_INFO(method->klass->rgctx_data, 8));
		if (L_15)
		{
			goto IL_002b;
		}
	}
	{
		NullCheck((Iterator_1_t859CAAB8DD3B63D3758E13D2802ED7523B331199 *)__this);
		VirtActionInvoker0::Invoke(12 /* System.Void System.Linq.Enumerable/Iterator`1<System.Single>::Dispose() */, (Iterator_1_t859CAAB8DD3B63D3758E13D2802ED7523B331199 *)__this);
	}

IL_0074:
	{
		return (bool)0;
	}
}
// System.Collections.Generic.IEnumerable`1<TResult> System.Linq.Enumerable/WhereSelectListIterator`2<System.ValueTuple`2<System.Object,System.Object>,System.Single>::Where(System.Func`2<TResult,System.Boolean>)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR RuntimeObject* WhereSelectListIterator_2_Where_mC8E2503F5756BA739E78D3641D608F15C41D3149_gshared (WhereSelectListIterator_2_tBC8201B4C00B3004BB33AA252E6112F87595F077 * __this, Func_2_t7214BC9C9A47482C751067B9A197D164F4041A3A * ___predicate0, const RuntimeMethod* method)
{
	{
		Func_2_t7214BC9C9A47482C751067B9A197D164F4041A3A * L_0 = ___predicate0;
		WhereEnumerableIterator_1_tC5339F8E75587CBA511FF3EDFBA6D5A81E54057F * L_1 = (WhereEnumerableIterator_1_tC5339F8E75587CBA511FF3EDFBA6D5A81E54057F *)il2cpp_codegen_object_new(IL2CPP_RGCTX_DATA(method->klass->rgctx_data, 10));
		((  void (*) (WhereEnumerableIterator_1_tC5339F8E75587CBA511FF3EDFBA6D5A81E54057F *, RuntimeObject*, Func_2_t7214BC9C9A47482C751067B9A197D164F4041A3A *, const RuntimeMethod*))IL2CPP_RGCTX_METHOD_INFO(method->klass->rgctx_data, 11)->methodPointer)(L_1, (RuntimeObject*)__this, (Func_2_t7214BC9C9A47482C751067B9A197D164F4041A3A *)L_0, /*hidden argument*/IL2CPP_RGCTX_METHOD_INFO(method->klass->rgctx_data, 11));
		return (RuntimeObject*)L_1;
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
// System.Void System.Linq.Enumerable/WhereSelectListIterator`2<System.Boolean,System.Object>::.ctor(System.Collections.Generic.List`1<TSource>,System.Func`2<TSource,System.Boolean>,System.Func`2<TSource,TResult>)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void WhereSelectListIterator_2__ctor_m367F2F09D26B827DCE613AB0B1DBDE114E401DB9_gshared (WhereSelectListIterator_2_t7686D2FCD0C149BEF2A7DDFD0203E102E436E876 * __this, List_1_tD4D2BACE5281B6C85799892C1F12F5F2F81A2DF3 * ___source0, Func_2_t50F598941CFDF02619DC5D52FFDBC329473C5F7B * ___predicate1, Func_2_t51AFCB712DCD56A45EE1645FC1762C549DA040FB * ___selector2, const RuntimeMethod* method)
{
	{
		NullCheck((Iterator_1_t674ABE41CF4096D4BE4D51E21FEBDADBF74CC279 *)__this);
		((  void (*) (Iterator_1_t674ABE41CF4096D4BE4D51E21FEBDADBF74CC279 *, const RuntimeMethod*))IL2CPP_RGCTX_METHOD_INFO(method->klass->rgctx_data, 0)->methodPointer)((Iterator_1_t674ABE41CF4096D4BE4D51E21FEBDADBF74CC279 *)__this, /*hidden argument*/IL2CPP_RGCTX_METHOD_INFO(method->klass->rgctx_data, 0));
		List_1_tD4D2BACE5281B6C85799892C1F12F5F2F81A2DF3 * L_0 = ___source0;
		__this->set_source_3(L_0);
		Func_2_t50F598941CFDF02619DC5D52FFDBC329473C5F7B * L_1 = ___predicate1;
		__this->set_predicate_4(L_1);
		Func_2_t51AFCB712DCD56A45EE1645FC1762C549DA040FB * L_2 = ___selector2;
		__this->set_selector_5(L_2);
		return;
	}
}
// System.Linq.Enumerable/Iterator`1<TResult> System.Linq.Enumerable/WhereSelectListIterator`2<System.Boolean,System.Object>::Clone()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR Iterator_1_t674ABE41CF4096D4BE4D51E21FEBDADBF74CC279 * WhereSelectListIterator_2_Clone_mF2AF4A7446A7B4431DAABC853B1376E5E8ADE4EB_gshared (WhereSelectListIterator_2_t7686D2FCD0C149BEF2A7DDFD0203E102E436E876 * __this, const RuntimeMethod* method)
{
	{
		List_1_tD4D2BACE5281B6C85799892C1F12F5F2F81A2DF3 * L_0 = (List_1_tD4D2BACE5281B6C85799892C1F12F5F2F81A2DF3 *)__this->get_source_3();
		Func_2_t50F598941CFDF02619DC5D52FFDBC329473C5F7B * L_1 = (Func_2_t50F598941CFDF02619DC5D52FFDBC329473C5F7B *)__this->get_predicate_4();
		Func_2_t51AFCB712DCD56A45EE1645FC1762C549DA040FB * L_2 = (Func_2_t51AFCB712DCD56A45EE1645FC1762C549DA040FB *)__this->get_selector_5();
		WhereSelectListIterator_2_t7686D2FCD0C149BEF2A7DDFD0203E102E436E876 * L_3 = (WhereSelectListIterator_2_t7686D2FCD0C149BEF2A7DDFD0203E102E436E876 *)il2cpp_codegen_object_new(IL2CPP_RGCTX_DATA(method->klass->rgctx_data, 2));
		((  void (*) (WhereSelectListIterator_2_t7686D2FCD0C149BEF2A7DDFD0203E102E436E876 *, List_1_tD4D2BACE5281B6C85799892C1F12F5F2F81A2DF3 *, Func_2_t50F598941CFDF02619DC5D52FFDBC329473C5F7B *, Func_2_t51AFCB712DCD56A45EE1645FC1762C549DA040FB *, const RuntimeMethod*))IL2CPP_RGCTX_METHOD_INFO(method->klass->rgctx_data, 3)->methodPointer)(L_3, (List_1_tD4D2BACE5281B6C85799892C1F12F5F2F81A2DF3 *)L_0, (Func_2_t50F598941CFDF02619DC5D52FFDBC329473C5F7B *)L_1, (Func_2_t51AFCB712DCD56A45EE1645FC1762C549DA040FB *)L_2, /*hidden argument*/IL2CPP_RGCTX_METHOD_INFO(method->klass->rgctx_data, 3));
		return (Iterator_1_t674ABE41CF4096D4BE4D51E21FEBDADBF74CC279 *)L_3;
	}
}
// System.Boolean System.Linq.Enumerable/WhereSelectListIterator`2<System.Boolean,System.Object>::MoveNext()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR bool WhereSelectListIterator_2_MoveNext_mCF7F542680811D33505E587DF872ECD9445B75F8_gshared (WhereSelectListIterator_2_t7686D2FCD0C149BEF2A7DDFD0203E102E436E876 * __this, const RuntimeMethod* method)
{
	int32_t V_0 = 0;
	bool V_1 = false;
	{
		int32_t L_0 = (int32_t)((Iterator_1_t674ABE41CF4096D4BE4D51E21FEBDADBF74CC279 *)__this)->get_state_1();
		V_0 = (int32_t)L_0;
		int32_t L_1 = V_0;
		if ((((int32_t)L_1) == ((int32_t)1)))
		{
			goto IL_0011;
		}
	}
	{
		int32_t L_2 = V_0;
		if ((((int32_t)L_2) == ((int32_t)2)))
		{
			goto IL_0061;
		}
	}
	{
		goto IL_0074;
	}

IL_0011:
	{
		List_1_tD4D2BACE5281B6C85799892C1F12F5F2F81A2DF3 * L_3 = (List_1_tD4D2BACE5281B6C85799892C1F12F5F2F81A2DF3 *)__this->get_source_3();
		NullCheck((List_1_tD4D2BACE5281B6C85799892C1F12F5F2F81A2DF3 *)L_3);
		Enumerator_t3F9663F5F32B0D733380A76CCEAA3ADFA3AE34A9  L_4;
		L_4 = ((  Enumerator_t3F9663F5F32B0D733380A76CCEAA3ADFA3AE34A9  (*) (List_1_tD4D2BACE5281B6C85799892C1F12F5F2F81A2DF3 *, const RuntimeMethod*))IL2CPP_RGCTX_METHOD_INFO(method->klass->rgctx_data, 4)->methodPointer)((List_1_tD4D2BACE5281B6C85799892C1F12F5F2F81A2DF3 *)L_3, /*hidden argument*/IL2CPP_RGCTX_METHOD_INFO(method->klass->rgctx_data, 4));
		__this->set_enumerator_6(L_4);
		((Iterator_1_t674ABE41CF4096D4BE4D51E21FEBDADBF74CC279 *)__this)->set_state_1(2);
		goto IL_0061;
	}

IL_002b:
	{
		Enumerator_t3F9663F5F32B0D733380A76CCEAA3ADFA3AE34A9 * L_5 = (Enumerator_t3F9663F5F32B0D733380A76CCEAA3ADFA3AE34A9 *)__this->get_address_of_enumerator_6();
		bool L_6;
		L_6 = Enumerator_get_Current_m19632EFFAA50F452EA487CBA0F1781963A3B5396_inline((Enumerator_t3F9663F5F32B0D733380A76CCEAA3ADFA3AE34A9 *)(Enumerator_t3F9663F5F32B0D733380A76CCEAA3ADFA3AE34A9 *)L_5, /*hidden argument*/IL2CPP_RGCTX_METHOD_INFO(method->klass->rgctx_data, 5));
		V_1 = (bool)L_6;
		Func_2_t50F598941CFDF02619DC5D52FFDBC329473C5F7B * L_7 = (Func_2_t50F598941CFDF02619DC5D52FFDBC329473C5F7B *)__this->get_predicate_4();
		if (!L_7)
		{
			goto IL_004d;
		}
	}
	{
		Func_2_t50F598941CFDF02619DC5D52FFDBC329473C5F7B * L_8 = (Func_2_t50F598941CFDF02619DC5D52FFDBC329473C5F7B *)__this->get_predicate_4();
		bool L_9 = V_1;
		NullCheck((Func_2_t50F598941CFDF02619DC5D52FFDBC329473C5F7B *)L_8);
		bool L_10;
		L_10 = ((  bool (*) (Func_2_t50F598941CFDF02619DC5D52FFDBC329473C5F7B *, bool, const RuntimeMethod*))IL2CPP_RGCTX_METHOD_INFO(method->klass->rgctx_data, 6)->methodPointer)((Func_2_t50F598941CFDF02619DC5D52FFDBC329473C5F7B *)L_8, (bool)L_9, /*hidden argument*/IL2CPP_RGCTX_METHOD_INFO(method->klass->rgctx_data, 6));
		if (!L_10)
		{
			goto IL_0061;
		}
	}

IL_004d:
	{
		Func_2_t51AFCB712DCD56A45EE1645FC1762C549DA040FB * L_11 = (Func_2_t51AFCB712DCD56A45EE1645FC1762C549DA040FB *)__this->get_selector_5();
		bool L_12 = V_1;
		NullCheck((Func_2_t51AFCB712DCD56A45EE1645FC1762C549DA040FB *)L_11);
		RuntimeObject * L_13;
		L_13 = ((  RuntimeObject * (*) (Func_2_t51AFCB712DCD56A45EE1645FC1762C549DA040FB *, bool, const RuntimeMethod*))IL2CPP_RGCTX_METHOD_INFO(method->klass->rgctx_data, 7)->methodPointer)((Func_2_t51AFCB712DCD56A45EE1645FC1762C549DA040FB *)L_11, (bool)L_12, /*hidden argument*/IL2CPP_RGCTX_METHOD_INFO(method->klass->rgctx_data, 7));
		((Iterator_1_t674ABE41CF4096D4BE4D51E21FEBDADBF74CC279 *)__this)->set_current_2(L_13);
		return (bool)1;
	}

IL_0061:
	{
		Enumerator_t3F9663F5F32B0D733380A76CCEAA3ADFA3AE34A9 * L_14 = (Enumerator_t3F9663F5F32B0D733380A76CCEAA3ADFA3AE34A9 *)__this->get_address_of_enumerator_6();
		bool L_15;
		L_15 = Enumerator_MoveNext_m829A3B1476C9E85C909907D33E9A81B4CFD5728F((Enumerator_t3F9663F5F32B0D733380A76CCEAA3ADFA3AE34A9 *)(Enumerator_t3F9663F5F32B0D733380A76CCEAA3ADFA3AE34A9 *)L_14, /*hidden argument*/IL2CPP_RGCTX_METHOD_INFO(method->klass->rgctx_data, 8));
		if (L_15)
		{
			goto IL_002b;
		}
	}
	{
		NullCheck((Iterator_1_t674ABE41CF4096D4BE4D51E21FEBDADBF74CC279 *)__this);
		VirtActionInvoker0::Invoke(12 /* System.Void System.Linq.Enumerable/Iterator`1<System.Object>::Dispose() */, (Iterator_1_t674ABE41CF4096D4BE4D51E21FEBDADBF74CC279 *)__this);
	}

IL_0074:
	{
		return (bool)0;
	}
}
// System.Collections.Generic.IEnumerable`1<TResult> System.Linq.Enumerable/WhereSelectListIterator`2<System.Boolean,System.Object>::Where(System.Func`2<TResult,System.Boolean>)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR RuntimeObject* WhereSelectListIterator_2_Where_m1D4CFF746BCE93BE6D84E0899E0D6CC635F21504_gshared (WhereSelectListIterator_2_t7686D2FCD0C149BEF2A7DDFD0203E102E436E876 * __this, Func_2_t99409DECFF50F0FA9B427C863AC6C99C66E6F9F8 * ___predicate0, const RuntimeMethod* method)
{
	{
		Func_2_t99409DECFF50F0FA9B427C863AC6C99C66E6F9F8 * L_0 = ___predicate0;
		WhereEnumerableIterator_1_t1E9FDCFD8F8136C6A5A5740C1E093EF03F0B5CE0 * L_1 = (WhereEnumerableIterator_1_t1E9FDCFD8F8136C6A5A5740C1E093EF03F0B5CE0 *)il2cpp_codegen_object_new(IL2CPP_RGCTX_DATA(method->klass->rgctx_data, 10));
		((  void (*) (WhereEnumerableIterator_1_t1E9FDCFD8F8136C6A5A5740C1E093EF03F0B5CE0 *, RuntimeObject*, Func_2_t99409DECFF50F0FA9B427C863AC6C99C66E6F9F8 *, const RuntimeMethod*))IL2CPP_RGCTX_METHOD_INFO(method->klass->rgctx_data, 11)->methodPointer)(L_1, (RuntimeObject*)__this, (Func_2_t99409DECFF50F0FA9B427C863AC6C99C66E6F9F8 *)L_0, /*hidden argument*/IL2CPP_RGCTX_METHOD_INFO(method->klass->rgctx_data, 11));
		return (RuntimeObject*)L_1;
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
// System.Void System.Linq.Enumerable/WhereSelectListIterator`2<UnityEngine.Experimental.Rendering.Universal.LibTessDotNet.ContourVertex,UnityEngine.Color>::.ctor(System.Collections.Generic.List`1<TSource>,System.Func`2<TSource,System.Boolean>,System.Func`2<TSource,TResult>)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void WhereSelectListIterator_2__ctor_m4ECBB9EDB81DC5D81C2F729F3A528B5345D36418_gshared (WhereSelectListIterator_2_t08B768B4AD54F201B800C51471E1C1C5FD1A8E8C * __this, List_1_t793A994CE01AE29FEE85500B7E3540653BFE5A0C * ___source0, Func_2_tD4EF074F88731E713305C48E156AB9F6F0F9324A * ___predicate1, Func_2_t07574F1E7EF84CF543A9B2FF0E62BB6B96696C64 * ___selector2, const RuntimeMethod* method)
{
	{
		NullCheck((Iterator_1_tDEF6AC46E52D8687C27A6E60B6E0200D50011D76 *)__this);
		((  void (*) (Iterator_1_tDEF6AC46E52D8687C27A6E60B6E0200D50011D76 *, const RuntimeMethod*))IL2CPP_RGCTX_METHOD_INFO(method->klass->rgctx_data, 0)->methodPointer)((Iterator_1_tDEF6AC46E52D8687C27A6E60B6E0200D50011D76 *)__this, /*hidden argument*/IL2CPP_RGCTX_METHOD_INFO(method->klass->rgctx_data, 0));
		List_1_t793A994CE01AE29FEE85500B7E3540653BFE5A0C * L_0 = ___source0;
		__this->set_source_3(L_0);
		Func_2_tD4EF074F88731E713305C48E156AB9F6F0F9324A * L_1 = ___predicate1;
		__this->set_predicate_4(L_1);
		Func_2_t07574F1E7EF84CF543A9B2FF0E62BB6B96696C64 * L_2 = ___selector2;
		__this->set_selector_5(L_2);
		return;
	}
}
// System.Linq.Enumerable/Iterator`1<TResult> System.Linq.Enumerable/WhereSelectListIterator`2<UnityEngine.Experimental.Rendering.Universal.LibTessDotNet.ContourVertex,UnityEngine.Color>::Clone()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR Iterator_1_tDEF6AC46E52D8687C27A6E60B6E0200D50011D76 * WhereSelectListIterator_2_Clone_m002D801C6321DC9447528A3FC50556077FBF5AAE_gshared (WhereSelectListIterator_2_t08B768B4AD54F201B800C51471E1C1C5FD1A8E8C * __this, const RuntimeMethod* method)
{
	{
		List_1_t793A994CE01AE29FEE85500B7E3540653BFE5A0C * L_0 = (List_1_t793A994CE01AE29FEE85500B7E3540653BFE5A0C *)__this->get_source_3();
		Func_2_tD4EF074F88731E713305C48E156AB9F6F0F9324A * L_1 = (Func_2_tD4EF074F88731E713305C48E156AB9F6F0F9324A *)__this->get_predicate_4();
		Func_2_t07574F1E7EF84CF543A9B2FF0E62BB6B96696C64 * L_2 = (Func_2_t07574F1E7EF84CF543A9B2FF0E62BB6B96696C64 *)__this->get_selector_5();
		WhereSelectListIterator_2_t08B768B4AD54F201B800C51471E1C1C5FD1A8E8C * L_3 = (WhereSelectListIterator_2_t08B768B4AD54F201B800C51471E1C1C5FD1A8E8C *)il2cpp_codegen_object_new(IL2CPP_RGCTX_DATA(method->klass->rgctx_data, 2));
		((  void (*) (WhereSelectListIterator_2_t08B768B4AD54F201B800C51471E1C1C5FD1A8E8C *, List_1_t793A994CE01AE29FEE85500B7E3540653BFE5A0C *, Func_2_tD4EF074F88731E713305C48E156AB9F6F0F9324A *, Func_2_t07574F1E7EF84CF543A9B2FF0E62BB6B96696C64 *, const RuntimeMethod*))IL2CPP_RGCTX_METHOD_INFO(method->klass->rgctx_data, 3)->methodPointer)(L_3, (List_1_t793A994CE01AE29FEE85500B7E3540653BFE5A0C *)L_0, (Func_2_tD4EF074F88731E713305C48E156AB9F6F0F9324A *)L_1, (Func_2_t07574F1E7EF84CF543A9B2FF0E62BB6B96696C64 *)L_2, /*hidden argument*/IL2CPP_RGCTX_METHOD_INFO(method->klass->rgctx_data, 3));
		return (Iterator_1_tDEF6AC46E52D8687C27A6E60B6E0200D50011D76 *)L_3;
	}
}
// System.Boolean System.Linq.Enumerable/WhereSelectListIterator`2<UnityEngine.Experimental.Rendering.Universal.LibTessDotNet.ContourVertex,UnityEngine.Color>::MoveNext()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR bool WhereSelectListIterator_2_MoveNext_m5C99254EED16684A96D5361E3BE8A8406B86C533_gshared (WhereSelectListIterator_2_t08B768B4AD54F201B800C51471E1C1C5FD1A8E8C * __this, const RuntimeMethod* method)
{
	int32_t V_0 = 0;
	ContourVertex_tF9E27CB6BCC62DF5F4202153BBBECDE5E3283536  V_1;
	memset((&V_1), 0, sizeof(V_1));
	{
		int32_t L_0 = (int32_t)((Iterator_1_tDEF6AC46E52D8687C27A6E60B6E0200D50011D76 *)__this)->get_state_1();
		V_0 = (int32_t)L_0;
		int32_t L_1 = V_0;
		if ((((int32_t)L_1) == ((int32_t)1)))
		{
			goto IL_0011;
		}
	}
	{
		int32_t L_2 = V_0;
		if ((((int32_t)L_2) == ((int32_t)2)))
		{
			goto IL_0061;
		}
	}
	{
		goto IL_0074;
	}

IL_0011:
	{
		List_1_t793A994CE01AE29FEE85500B7E3540653BFE5A0C * L_3 = (List_1_t793A994CE01AE29FEE85500B7E3540653BFE5A0C *)__this->get_source_3();
		NullCheck((List_1_t793A994CE01AE29FEE85500B7E3540653BFE5A0C *)L_3);
		Enumerator_t0A364062D6EEDD0B306D570939B5709AEAA88D11  L_4;
		L_4 = ((  Enumerator_t0A364062D6EEDD0B306D570939B5709AEAA88D11  (*) (List_1_t793A994CE01AE29FEE85500B7E3540653BFE5A0C *, const RuntimeMethod*))IL2CPP_RGCTX_METHOD_INFO(method->klass->rgctx_data, 4)->methodPointer)((List_1_t793A994CE01AE29FEE85500B7E3540653BFE5A0C *)L_3, /*hidden argument*/IL2CPP_RGCTX_METHOD_INFO(method->klass->rgctx_data, 4));
		__this->set_enumerator_6(L_4);
		((Iterator_1_tDEF6AC46E52D8687C27A6E60B6E0200D50011D76 *)__this)->set_state_1(2);
		goto IL_0061;
	}

IL_002b:
	{
		Enumerator_t0A364062D6EEDD0B306D570939B5709AEAA88D11 * L_5 = (Enumerator_t0A364062D6EEDD0B306D570939B5709AEAA88D11 *)__this->get_address_of_enumerator_6();
		ContourVertex_tF9E27CB6BCC62DF5F4202153BBBECDE5E3283536  L_6;
		L_6 = Enumerator_get_Current_mB9DED66EBA82669AB83832B40F60E1710B5179B4_inline((Enumerator_t0A364062D6EEDD0B306D570939B5709AEAA88D11 *)(Enumerator_t0A364062D6EEDD0B306D570939B5709AEAA88D11 *)L_5, /*hidden argument*/IL2CPP_RGCTX_METHOD_INFO(method->klass->rgctx_data, 5));
		V_1 = (ContourVertex_tF9E27CB6BCC62DF5F4202153BBBECDE5E3283536 )L_6;
		Func_2_tD4EF074F88731E713305C48E156AB9F6F0F9324A * L_7 = (Func_2_tD4EF074F88731E713305C48E156AB9F6F0F9324A *)__this->get_predicate_4();
		if (!L_7)
		{
			goto IL_004d;
		}
	}
	{
		Func_2_tD4EF074F88731E713305C48E156AB9F6F0F9324A * L_8 = (Func_2_tD4EF074F88731E713305C48E156AB9F6F0F9324A *)__this->get_predicate_4();
		ContourVertex_tF9E27CB6BCC62DF5F4202153BBBECDE5E3283536  L_9 = V_1;
		NullCheck((Func_2_tD4EF074F88731E713305C48E156AB9F6F0F9324A *)L_8);
		bool L_10;
		L_10 = ((  bool (*) (Func_2_tD4EF074F88731E713305C48E156AB9F6F0F9324A *, ContourVertex_tF9E27CB6BCC62DF5F4202153BBBECDE5E3283536 , const RuntimeMethod*))IL2CPP_RGCTX_METHOD_INFO(method->klass->rgctx_data, 6)->methodPointer)((Func_2_tD4EF074F88731E713305C48E156AB9F6F0F9324A *)L_8, (ContourVertex_tF9E27CB6BCC62DF5F4202153BBBECDE5E3283536 )L_9, /*hidden argument*/IL2CPP_RGCTX_METHOD_INFO(method->klass->rgctx_data, 6));
		if (!L_10)
		{
			goto IL_0061;
		}
	}

IL_004d:
	{
		Func_2_t07574F1E7EF84CF543A9B2FF0E62BB6B96696C64 * L_11 = (Func_2_t07574F1E7EF84CF543A9B2FF0E62BB6B96696C64 *)__this->get_selector_5();
		ContourVertex_tF9E27CB6BCC62DF5F4202153BBBECDE5E3283536  L_12 = V_1;
		NullCheck((Func_2_t07574F1E7EF84CF543A9B2FF0E62BB6B96696C64 *)L_11);
		Color_tF40DAF76C04FFECF3FE6024F85A294741C9CC659  L_13;
		L_13 = ((  Color_tF40DAF76C04FFECF3FE6024F85A294741C9CC659  (*) (Func_2_t07574F1E7EF84CF543A9B2FF0E62BB6B96696C64 *, ContourVertex_tF9E27CB6BCC62DF5F4202153BBBECDE5E3283536 , const RuntimeMethod*))IL2CPP_RGCTX_METHOD_INFO(method->klass->rgctx_data, 7)->methodPointer)((Func_2_t07574F1E7EF84CF543A9B2FF0E62BB6B96696C64 *)L_11, (ContourVertex_tF9E27CB6BCC62DF5F4202153BBBECDE5E3283536 )L_12, /*hidden argument*/IL2CPP_RGCTX_METHOD_INFO(method->klass->rgctx_data, 7));
		((Iterator_1_tDEF6AC46E52D8687C27A6E60B6E0200D50011D76 *)__this)->set_current_2(L_13);
		return (bool)1;
	}

IL_0061:
	{
		Enumerator_t0A364062D6EEDD0B306D570939B5709AEAA88D11 * L_14 = (Enumerator_t0A364062D6EEDD0B306D570939B5709AEAA88D11 *)__this->get_address_of_enumerator_6();
		bool L_15;
		L_15 = Enumerator_MoveNext_mACDC401A875ECF83AEF9477068CDF02545A1D997((Enumerator_t0A364062D6EEDD0B306D570939B5709AEAA88D11 *)(Enumerator_t0A364062D6EEDD0B306D570939B5709AEAA88D11 *)L_14, /*hidden argument*/IL2CPP_RGCTX_METHOD_INFO(method->klass->rgctx_data, 8));
		if (L_15)
		{
			goto IL_002b;
		}
	}
	{
		NullCheck((Iterator_1_tDEF6AC46E52D8687C27A6E60B6E0200D50011D76 *)__this);
		VirtActionInvoker0::Invoke(12 /* System.Void System.Linq.Enumerable/Iterator`1<UnityEngine.Color>::Dispose() */, (Iterator_1_tDEF6AC46E52D8687C27A6E60B6E0200D50011D76 *)__this);
	}

IL_0074:
	{
		return (bool)0;
	}
}
// System.Collections.Generic.IEnumerable`1<TResult> System.Linq.Enumerable/WhereSelectListIterator`2<UnityEngine.Experimental.Rendering.Universal.LibTessDotNet.ContourVertex,UnityEngine.Color>::Where(System.Func`2<TResult,System.Boolean>)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR RuntimeObject* WhereSelectListIterator_2_Where_mDECC30954B416D7786855DD9643B46A7E6DEB8C2_gshared (WhereSelectListIterator_2_t08B768B4AD54F201B800C51471E1C1C5FD1A8E8C * __this, Func_2_t3985FFDAB0D05F8E97E8EA849D5A24F16EFFC4FD * ___predicate0, const RuntimeMethod* method)
{
	{
		Func_2_t3985FFDAB0D05F8E97E8EA849D5A24F16EFFC4FD * L_0 = ___predicate0;
		WhereEnumerableIterator_1_tEDD9A2C48D1FE8BE0706121F2B6C8A796196FFF2 * L_1 = (WhereEnumerableIterator_1_tEDD9A2C48D1FE8BE0706121F2B6C8A796196FFF2 *)il2cpp_codegen_object_new(IL2CPP_RGCTX_DATA(method->klass->rgctx_data, 10));
		((  void (*) (WhereEnumerableIterator_1_tEDD9A2C48D1FE8BE0706121F2B6C8A796196FFF2 *, RuntimeObject*, Func_2_t3985FFDAB0D05F8E97E8EA849D5A24F16EFFC4FD *, const RuntimeMethod*))IL2CPP_RGCTX_METHOD_INFO(method->klass->rgctx_data, 11)->methodPointer)(L_1, (RuntimeObject*)__this, (Func_2_t3985FFDAB0D05F8E97E8EA849D5A24F16EFFC4FD *)L_0, /*hidden argument*/IL2CPP_RGCTX_METHOD_INFO(method->klass->rgctx_data, 11));
		return (RuntimeObject*)L_1;
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
// System.Void System.Linq.Enumerable/WhereSelectListIterator`2<UnityEngine.Experimental.Rendering.Universal.LibTessDotNet.ContourVertex,UnityEngine.Vector3>::.ctor(System.Collections.Generic.List`1<TSource>,System.Func`2<TSource,System.Boolean>,System.Func`2<TSource,TResult>)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void WhereSelectListIterator_2__ctor_mD3F8F885B0AF6977BCFCC072276C87068F087FB2_gshared (WhereSelectListIterator_2_t94F415FEA624816E42FAE1274A4EC29F5D5C1625 * __this, List_1_t793A994CE01AE29FEE85500B7E3540653BFE5A0C * ___source0, Func_2_tD4EF074F88731E713305C48E156AB9F6F0F9324A * ___predicate1, Func_2_tA55660D7B36BC919063457215A12594F309CFDF1 * ___selector2, const RuntimeMethod* method)
{
	{
		NullCheck((Iterator_1_t04F5D870FD247BBBEE27254587FA10F440D4EEFF *)__this);
		((  void (*) (Iterator_1_t04F5D870FD247BBBEE27254587FA10F440D4EEFF *, const RuntimeMethod*))IL2CPP_RGCTX_METHOD_INFO(method->klass->rgctx_data, 0)->methodPointer)((Iterator_1_t04F5D870FD247BBBEE27254587FA10F440D4EEFF *)__this, /*hidden argument*/IL2CPP_RGCTX_METHOD_INFO(method->klass->rgctx_data, 0));
		List_1_t793A994CE01AE29FEE85500B7E3540653BFE5A0C * L_0 = ___source0;
		__this->set_source_3(L_0);
		Func_2_tD4EF074F88731E713305C48E156AB9F6F0F9324A * L_1 = ___predicate1;
		__this->set_predicate_4(L_1);
		Func_2_tA55660D7B36BC919063457215A12594F309CFDF1 * L_2 = ___selector2;
		__this->set_selector_5(L_2);
		return;
	}
}
// System.Linq.Enumerable/Iterator`1<TResult> System.Linq.Enumerable/WhereSelectListIterator`2<UnityEngine.Experimental.Rendering.Universal.LibTessDotNet.ContourVertex,UnityEngine.Vector3>::Clone()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR Iterator_1_t04F5D870FD247BBBEE27254587FA10F440D4EEFF * WhereSelectListIterator_2_Clone_m699590CC3733CE2DB41ABA02182719C678DAE562_gshared (WhereSelectListIterator_2_t94F415FEA624816E42FAE1274A4EC29F5D5C1625 * __this, const RuntimeMethod* method)
{
	{
		List_1_t793A994CE01AE29FEE85500B7E3540653BFE5A0C * L_0 = (List_1_t793A994CE01AE29FEE85500B7E3540653BFE5A0C *)__this->get_source_3();
		Func_2_tD4EF074F88731E713305C48E156AB9F6F0F9324A * L_1 = (Func_2_tD4EF074F88731E713305C48E156AB9F6F0F9324A *)__this->get_predicate_4();
		Func_2_tA55660D7B36BC919063457215A12594F309CFDF1 * L_2 = (Func_2_tA55660D7B36BC919063457215A12594F309CFDF1 *)__this->get_selector_5();
		WhereSelectListIterator_2_t94F415FEA624816E42FAE1274A4EC29F5D5C1625 * L_3 = (WhereSelectListIterator_2_t94F415FEA624816E42FAE1274A4EC29F5D5C1625 *)il2cpp_codegen_object_new(IL2CPP_RGCTX_DATA(method->klass->rgctx_data, 2));
		((  void (*) (WhereSelectListIterator_2_t94F415FEA624816E42FAE1274A4EC29F5D5C1625 *, List_1_t793A994CE01AE29FEE85500B7E3540653BFE5A0C *, Func_2_tD4EF074F88731E713305C48E156AB9F6F0F9324A *, Func_2_tA55660D7B36BC919063457215A12594F309CFDF1 *, const RuntimeMethod*))IL2CPP_RGCTX_METHOD_INFO(method->klass->rgctx_data, 3)->methodPointer)(L_3, (List_1_t793A994CE01AE29FEE85500B7E3540653BFE5A0C *)L_0, (Func_2_tD4EF074F88731E713305C48E156AB9F6F0F9324A *)L_1, (Func_2_tA55660D7B36BC919063457215A12594F309CFDF1 *)L_2, /*hidden argument*/IL2CPP_RGCTX_METHOD_INFO(method->klass->rgctx_data, 3));
		return (Iterator_1_t04F5D870FD247BBBEE27254587FA10F440D4EEFF *)L_3;
	}
}
// System.Boolean System.Linq.Enumerable/WhereSelectListIterator`2<UnityEngine.Experimental.Rendering.Universal.LibTessDotNet.ContourVertex,UnityEngine.Vector3>::MoveNext()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR bool WhereSelectListIterator_2_MoveNext_m9FEC951E923EFC23AC8A86016D6A795C3275319E_gshared (WhereSelectListIterator_2_t94F415FEA624816E42FAE1274A4EC29F5D5C1625 * __this, const RuntimeMethod* method)
{
	int32_t V_0 = 0;
	ContourVertex_tF9E27CB6BCC62DF5F4202153BBBECDE5E3283536  V_1;
	memset((&V_1), 0, sizeof(V_1));
	{
		int32_t L_0 = (int32_t)((Iterator_1_t04F5D870FD247BBBEE27254587FA10F440D4EEFF *)__this)->get_state_1();
		V_0 = (int32_t)L_0;
		int32_t L_1 = V_0;
		if ((((int32_t)L_1) == ((int32_t)1)))
		{
			goto IL_0011;
		}
	}
	{
		int32_t L_2 = V_0;
		if ((((int32_t)L_2) == ((int32_t)2)))
		{
			goto IL_0061;
		}
	}
	{
		goto IL_0074;
	}

IL_0011:
	{
		List_1_t793A994CE01AE29FEE85500B7E3540653BFE5A0C * L_3 = (List_1_t793A994CE01AE29FEE85500B7E3540653BFE5A0C *)__this->get_source_3();
		NullCheck((List_1_t793A994CE01AE29FEE85500B7E3540653BFE5A0C *)L_3);
		Enumerator_t0A364062D6EEDD0B306D570939B5709AEAA88D11  L_4;
		L_4 = ((  Enumerator_t0A364062D6EEDD0B306D570939B5709AEAA88D11  (*) (List_1_t793A994CE01AE29FEE85500B7E3540653BFE5A0C *, const RuntimeMethod*))IL2CPP_RGCTX_METHOD_INFO(method->klass->rgctx_data, 4)->methodPointer)((List_1_t793A994CE01AE29FEE85500B7E3540653BFE5A0C *)L_3, /*hidden argument*/IL2CPP_RGCTX_METHOD_INFO(method->klass->rgctx_data, 4));
		__this->set_enumerator_6(L_4);
		((Iterator_1_t04F5D870FD247BBBEE27254587FA10F440D4EEFF *)__this)->set_state_1(2);
		goto IL_0061;
	}

IL_002b:
	{
		Enumerator_t0A364062D6EEDD0B306D570939B5709AEAA88D11 * L_5 = (Enumerator_t0A364062D6EEDD0B306D570939B5709AEAA88D11 *)__this->get_address_of_enumerator_6();
		ContourVertex_tF9E27CB6BCC62DF5F4202153BBBECDE5E3283536  L_6;
		L_6 = Enumerator_get_Current_mB9DED66EBA82669AB83832B40F60E1710B5179B4_inline((Enumerator_t0A364062D6EEDD0B306D570939B5709AEAA88D11 *)(Enumerator_t0A364062D6EEDD0B306D570939B5709AEAA88D11 *)L_5, /*hidden argument*/IL2CPP_RGCTX_METHOD_INFO(method->klass->rgctx_data, 5));
		V_1 = (ContourVertex_tF9E27CB6BCC62DF5F4202153BBBECDE5E3283536 )L_6;
		Func_2_tD4EF074F88731E713305C48E156AB9F6F0F9324A * L_7 = (Func_2_tD4EF074F88731E713305C48E156AB9F6F0F9324A *)__this->get_predicate_4();
		if (!L_7)
		{
			goto IL_004d;
		}
	}
	{
		Func_2_tD4EF074F88731E713305C48E156AB9F6F0F9324A * L_8 = (Func_2_tD4EF074F88731E713305C48E156AB9F6F0F9324A *)__this->get_predicate_4();
		ContourVertex_tF9E27CB6BCC62DF5F4202153BBBECDE5E3283536  L_9 = V_1;
		NullCheck((Func_2_tD4EF074F88731E713305C48E156AB9F6F0F9324A *)L_8);
		bool L_10;
		L_10 = ((  bool (*) (Func_2_tD4EF074F88731E713305C48E156AB9F6F0F9324A *, ContourVertex_tF9E27CB6BCC62DF5F4202153BBBECDE5E3283536 , const RuntimeMethod*))IL2CPP_RGCTX_METHOD_INFO(method->klass->rgctx_data, 6)->methodPointer)((Func_2_tD4EF074F88731E713305C48E156AB9F6F0F9324A *)L_8, (ContourVertex_tF9E27CB6BCC62DF5F4202153BBBECDE5E3283536 )L_9, /*hidden argument*/IL2CPP_RGCTX_METHOD_INFO(method->klass->rgctx_data, 6));
		if (!L_10)
		{
			goto IL_0061;
		}
	}

IL_004d:
	{
		Func_2_tA55660D7B36BC919063457215A12594F309CFDF1 * L_11 = (Func_2_tA55660D7B36BC919063457215A12594F309CFDF1 *)__this->get_selector_5();
		ContourVertex_tF9E27CB6BCC62DF5F4202153BBBECDE5E3283536  L_12 = V_1;
		NullCheck((Func_2_tA55660D7B36BC919063457215A12594F309CFDF1 *)L_11);
		Vector3_t65B972D6A585A0A5B63153CF1177A90D3C90D65E  L_13;
		L_13 = ((  Vector3_t65B972D6A585A0A5B63153CF1177A90D3C90D65E  (*) (Func_2_tA55660D7B36BC919063457215A12594F309CFDF1 *, ContourVertex_tF9E27CB6BCC62DF5F4202153BBBECDE5E3283536 , const RuntimeMethod*))IL2CPP_RGCTX_METHOD_INFO(method->klass->rgctx_data, 7)->methodPointer)((Func_2_tA55660D7B36BC919063457215A12594F309CFDF1 *)L_11, (ContourVertex_tF9E27CB6BCC62DF5F4202153BBBECDE5E3283536 )L_12, /*hidden argument*/IL2CPP_RGCTX_METHOD_INFO(method->klass->rgctx_data, 7));
		((Iterator_1_t04F5D870FD247BBBEE27254587FA10F440D4EEFF *)__this)->set_current_2(L_13);
		return (bool)1;
	}

IL_0061:
	{
		Enumerator_t0A364062D6EEDD0B306D570939B5709AEAA88D11 * L_14 = (Enumerator_t0A364062D6EEDD0B306D570939B5709AEAA88D11 *)__this->get_address_of_enumerator_6();
		bool L_15;
		L_15 = Enumerator_MoveNext_mACDC401A875ECF83AEF9477068CDF02545A1D997((Enumerator_t0A364062D6EEDD0B306D570939B5709AEAA88D11 *)(Enumerator_t0A364062D6EEDD0B306D570939B5709AEAA88D11 *)L_14, /*hidden argument*/IL2CPP_RGCTX_METHOD_INFO(method->klass->rgctx_data, 8));
		if (L_15)
		{
			goto IL_002b;
		}
	}
	{
		NullCheck((Iterator_1_t04F5D870FD247BBBEE27254587FA10F440D4EEFF *)__this);
		VirtActionInvoker0::Invoke(12 /* System.Void System.Linq.Enumerable/Iterator`1<UnityEngine.Vector3>::Dispose() */, (Iterator_1_t04F5D870FD247BBBEE27254587FA10F440D4EEFF *)__this);
	}

IL_0074:
	{
		return (bool)0;
	}
}
// System.Collections.Generic.IEnumerable`1<TResult> System.Linq.Enumerable/WhereSelectListIterator`2<UnityEngine.Experimental.Rendering.Universal.LibTessDotNet.ContourVertex,UnityEngine.Vector3>::Where(System.Func`2<TResult,System.Boolean>)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR RuntimeObject* WhereSelectListIterator_2_Where_mA49B2D74E495EFA26A1F215E3E809BAD571BCDA2_gshared (WhereSelectListIterator_2_t94F415FEA624816E42FAE1274A4EC29F5D5C1625 * __this, Func_2_t3041FD3183D19FE8416AE2E43A6398B2C06B7269 * ___predicate0, const RuntimeMethod* method)
{
	{
		Func_2_t3041FD3183D19FE8416AE2E43A6398B2C06B7269 * L_0 = ___predicate0;
		WhereEnumerableIterator_1_t0E01F06572EA26BE9E79530811037753CF6B3BF8 * L_1 = (WhereEnumerableIterator_1_t0E01F06572EA26BE9E79530811037753CF6B3BF8 *)il2cpp_codegen_object_new(IL2CPP_RGCTX_DATA(method->klass->rgctx_data, 10));
		((  void (*) (WhereEnumerableIterator_1_t0E01F06572EA26BE9E79530811037753CF6B3BF8 *, RuntimeObject*, Func_2_t3041FD3183D19FE8416AE2E43A6398B2C06B7269 *, const RuntimeMethod*))IL2CPP_RGCTX_METHOD_INFO(method->klass->rgctx_data, 11)->methodPointer)(L_1, (RuntimeObject*)__this, (Func_2_t3041FD3183D19FE8416AE2E43A6398B2C06B7269 *)L_0, /*hidden argument*/IL2CPP_RGCTX_METHOD_INFO(method->klass->rgctx_data, 11));
		return (RuntimeObject*)L_1;
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
// System.Void System.Linq.Enumerable/WhereSelectListIterator`2<UnityEngine.Experimental.Rendering.Universal.LibTessDotNet.ContourVertex,Unity.Mathematics.float3>::.ctor(System.Collections.Generic.List`1<TSource>,System.Func`2<TSource,System.Boolean>,System.Func`2<TSource,TResult>)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void WhereSelectListIterator_2__ctor_m429BD6BE31891961B06ECB6C64AF6D8BCE978A14_gshared (WhereSelectListIterator_2_t8005F348CC0B870A84DE3E85429A840305201D6E * __this, List_1_t793A994CE01AE29FEE85500B7E3540653BFE5A0C * ___source0, Func_2_tD4EF074F88731E713305C48E156AB9F6F0F9324A * ___predicate1, Func_2_t4ADAECFAD3DFE1FE3B6834A49502FA772B85CB3C * ___selector2, const RuntimeMethod* method)
{
	{
		NullCheck((Iterator_1_tCEC2E244A64F110B247B6A3DF34DE60D4456BA1A *)__this);
		((  void (*) (Iterator_1_tCEC2E244A64F110B247B6A3DF34DE60D4456BA1A *, const RuntimeMethod*))IL2CPP_RGCTX_METHOD_INFO(method->klass->rgctx_data, 0)->methodPointer)((Iterator_1_tCEC2E244A64F110B247B6A3DF34DE60D4456BA1A *)__this, /*hidden argument*/IL2CPP_RGCTX_METHOD_INFO(method->klass->rgctx_data, 0));
		List_1_t793A994CE01AE29FEE85500B7E3540653BFE5A0C * L_0 = ___source0;
		__this->set_source_3(L_0);
		Func_2_tD4EF074F88731E713305C48E156AB9F6F0F9324A * L_1 = ___predicate1;
		__this->set_predicate_4(L_1);
		Func_2_t4ADAECFAD3DFE1FE3B6834A49502FA772B85CB3C * L_2 = ___selector2;
		__this->set_selector_5(L_2);
		return;
	}
}
// System.Linq.Enumerable/Iterator`1<TResult> System.Linq.Enumerable/WhereSelectListIterator`2<UnityEngine.Experimental.Rendering.Universal.LibTessDotNet.ContourVertex,Unity.Mathematics.float3>::Clone()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR Iterator_1_tCEC2E244A64F110B247B6A3DF34DE60D4456BA1A * WhereSelectListIterator_2_Clone_m1B6B9C419A94F245358A5FCE850E012EB6F3C51D_gshared (WhereSelectListIterator_2_t8005F348CC0B870A84DE3E85429A840305201D6E * __this, const RuntimeMethod* method)
{
	{
		List_1_t793A994CE01AE29FEE85500B7E3540653BFE5A0C * L_0 = (List_1_t793A994CE01AE29FEE85500B7E3540653BFE5A0C *)__this->get_source_3();
		Func_2_tD4EF074F88731E713305C48E156AB9F6F0F9324A * L_1 = (Func_2_tD4EF074F88731E713305C48E156AB9F6F0F9324A *)__this->get_predicate_4();
		Func_2_t4ADAECFAD3DFE1FE3B6834A49502FA772B85CB3C * L_2 = (Func_2_t4ADAECFAD3DFE1FE3B6834A49502FA772B85CB3C *)__this->get_selector_5();
		WhereSelectListIterator_2_t8005F348CC0B870A84DE3E85429A840305201D6E * L_3 = (WhereSelectListIterator_2_t8005F348CC0B870A84DE3E85429A840305201D6E *)il2cpp_codegen_object_new(IL2CPP_RGCTX_DATA(method->klass->rgctx_data, 2));
		((  void (*) (WhereSelectListIterator_2_t8005F348CC0B870A84DE3E85429A840305201D6E *, List_1_t793A994CE01AE29FEE85500B7E3540653BFE5A0C *, Func_2_tD4EF074F88731E713305C48E156AB9F6F0F9324A *, Func_2_t4ADAECFAD3DFE1FE3B6834A49502FA772B85CB3C *, const RuntimeMethod*))IL2CPP_RGCTX_METHOD_INFO(method->klass->rgctx_data, 3)->methodPointer)(L_3, (List_1_t793A994CE01AE29FEE85500B7E3540653BFE5A0C *)L_0, (Func_2_tD4EF074F88731E713305C48E156AB9F6F0F9324A *)L_1, (Func_2_t4ADAECFAD3DFE1FE3B6834A49502FA772B85CB3C *)L_2, /*hidden argument*/IL2CPP_RGCTX_METHOD_INFO(method->klass->rgctx_data, 3));
		return (Iterator_1_tCEC2E244A64F110B247B6A3DF34DE60D4456BA1A *)L_3;
	}
}
// System.Boolean System.Linq.Enumerable/WhereSelectListIterator`2<UnityEngine.Experimental.Rendering.Universal.LibTessDotNet.ContourVertex,Unity.Mathematics.float3>::MoveNext()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR bool WhereSelectListIterator_2_MoveNext_mC1816C78F69033DDC9FC62D30AAD5FC4D9A3AF18_gshared (WhereSelectListIterator_2_t8005F348CC0B870A84DE3E85429A840305201D6E * __this, const RuntimeMethod* method)
{
	int32_t V_0 = 0;
	ContourVertex_tF9E27CB6BCC62DF5F4202153BBBECDE5E3283536  V_1;
	memset((&V_1), 0, sizeof(V_1));
	{
		int32_t L_0 = (int32_t)((Iterator_1_tCEC2E244A64F110B247B6A3DF34DE60D4456BA1A *)__this)->get_state_1();
		V_0 = (int32_t)L_0;
		int32_t L_1 = V_0;
		if ((((int32_t)L_1) == ((int32_t)1)))
		{
			goto IL_0011;
		}
	}
	{
		int32_t L_2 = V_0;
		if ((((int32_t)L_2) == ((int32_t)2)))
		{
			goto IL_0061;
		}
	}
	{
		goto IL_0074;
	}

IL_0011:
	{
		List_1_t793A994CE01AE29FEE85500B7E3540653BFE5A0C * L_3 = (List_1_t793A994CE01AE29FEE85500B7E3540653BFE5A0C *)__this->get_source_3();
		NullCheck((List_1_t793A994CE01AE29FEE85500B7E3540653BFE5A0C *)L_3);
		Enumerator_t0A364062D6EEDD0B306D570939B5709AEAA88D11  L_4;
		L_4 = ((  Enumerator_t0A364062D6EEDD0B306D570939B5709AEAA88D11  (*) (List_1_t793A994CE01AE29FEE85500B7E3540653BFE5A0C *, const RuntimeMethod*))IL2CPP_RGCTX_METHOD_INFO(method->klass->rgctx_data, 4)->methodPointer)((List_1_t793A994CE01AE29FEE85500B7E3540653BFE5A0C *)L_3, /*hidden argument*/IL2CPP_RGCTX_METHOD_INFO(method->klass->rgctx_data, 4));
		__this->set_enumerator_6(L_4);
		((Iterator_1_tCEC2E244A64F110B247B6A3DF34DE60D4456BA1A *)__this)->set_state_1(2);
		goto IL_0061;
	}

IL_002b:
	{
		Enumerator_t0A364062D6EEDD0B306D570939B5709AEAA88D11 * L_5 = (Enumerator_t0A364062D6EEDD0B306D570939B5709AEAA88D11 *)__this->get_address_of_enumerator_6();
		ContourVertex_tF9E27CB6BCC62DF5F4202153BBBECDE5E3283536  L_6;
		L_6 = Enumerator_get_Current_mB9DED66EBA82669AB83832B40F60E1710B5179B4_inline((Enumerator_t0A364062D6EEDD0B306D570939B5709AEAA88D11 *)(Enumerator_t0A364062D6EEDD0B306D570939B5709AEAA88D11 *)L_5, /*hidden argument*/IL2CPP_RGCTX_METHOD_INFO(method->klass->rgctx_data, 5));
		V_1 = (ContourVertex_tF9E27CB6BCC62DF5F4202153BBBECDE5E3283536 )L_6;
		Func_2_tD4EF074F88731E713305C48E156AB9F6F0F9324A * L_7 = (Func_2_tD4EF074F88731E713305C48E156AB9F6F0F9324A *)__this->get_predicate_4();
		if (!L_7)
		{
			goto IL_004d;
		}
	}
	{
		Func_2_tD4EF074F88731E713305C48E156AB9F6F0F9324A * L_8 = (Func_2_tD4EF074F88731E713305C48E156AB9F6F0F9324A *)__this->get_predicate_4();
		ContourVertex_tF9E27CB6BCC62DF5F4202153BBBECDE5E3283536  L_9 = V_1;
		NullCheck((Func_2_tD4EF074F88731E713305C48E156AB9F6F0F9324A *)L_8);
		bool L_10;
		L_10 = ((  bool (*) (Func_2_tD4EF074F88731E713305C48E156AB9F6F0F9324A *, ContourVertex_tF9E27CB6BCC62DF5F4202153BBBECDE5E3283536 , const RuntimeMethod*))IL2CPP_RGCTX_METHOD_INFO(method->klass->rgctx_data, 6)->methodPointer)((Func_2_tD4EF074F88731E713305C48E156AB9F6F0F9324A *)L_8, (ContourVertex_tF9E27CB6BCC62DF5F4202153BBBECDE5E3283536 )L_9, /*hidden argument*/IL2CPP_RGCTX_METHOD_INFO(method->klass->rgctx_data, 6));
		if (!L_10)
		{
			goto IL_0061;
		}
	}

IL_004d:
	{
		Func_2_t4ADAECFAD3DFE1FE3B6834A49502FA772B85CB3C * L_11 = (Func_2_t4ADAECFAD3DFE1FE3B6834A49502FA772B85CB3C *)__this->get_selector_5();
		ContourVertex_tF9E27CB6BCC62DF5F4202153BBBECDE5E3283536  L_12 = V_1;
		NullCheck((Func_2_t4ADAECFAD3DFE1FE3B6834A49502FA772B85CB3C *)L_11);
		float3_tE0DD2FF13F818025945C9AC314390D2A1F55E37D  L_13;
		L_13 = ((  float3_tE0DD2FF13F818025945C9AC314390D2A1F55E37D  (*) (Func_2_t4ADAECFAD3DFE1FE3B6834A49502FA772B85CB3C *, ContourVertex_tF9E27CB6BCC62DF5F4202153BBBECDE5E3283536 , const RuntimeMethod*))IL2CPP_RGCTX_METHOD_INFO(method->klass->rgctx_data, 7)->methodPointer)((Func_2_t4ADAECFAD3DFE1FE3B6834A49502FA772B85CB3C *)L_11, (ContourVertex_tF9E27CB6BCC62DF5F4202153BBBECDE5E3283536 )L_12, /*hidden argument*/IL2CPP_RGCTX_METHOD_INFO(method->klass->rgctx_data, 7));
		((Iterator_1_tCEC2E244A64F110B247B6A3DF34DE60D4456BA1A *)__this)->set_current_2(L_13);
		return (bool)1;
	}

IL_0061:
	{
		Enumerator_t0A364062D6EEDD0B306D570939B5709AEAA88D11 * L_14 = (Enumerator_t0A364062D6EEDD0B306D570939B5709AEAA88D11 *)__this->get_address_of_enumerator_6();
		bool L_15;
		L_15 = Enumerator_MoveNext_mACDC401A875ECF83AEF9477068CDF02545A1D997((Enumerator_t0A364062D6EEDD0B306D570939B5709AEAA88D11 *)(Enumerator_t0A364062D6EEDD0B306D570939B5709AEAA88D11 *)L_14, /*hidden argument*/IL2CPP_RGCTX_METHOD_INFO(method->klass->rgctx_data, 8));
		if (L_15)
		{
			goto IL_002b;
		}
	}
	{
		NullCheck((Iterator_1_tCEC2E244A64F110B247B6A3DF34DE60D4456BA1A *)__this);
		VirtActionInvoker0::Invoke(12 /* System.Void System.Linq.Enumerable/Iterator`1<Unity.Mathematics.float3>::Dispose() */, (Iterator_1_tCEC2E244A64F110B247B6A3DF34DE60D4456BA1A *)__this);
	}

IL_0074:
	{
		return (bool)0;
	}
}
// System.Collections.Generic.IEnumerable`1<TResult> System.Linq.Enumerable/WhereSelectListIterator`2<UnityEngine.Experimental.Rendering.Universal.LibTessDotNet.ContourVertex,Unity.Mathematics.float3>::Where(System.Func`2<TResult,System.Boolean>)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR RuntimeObject* WhereSelectListIterator_2_Where_m918384340B3A615C024FE2469E19186423B5ECC1_gshared (WhereSelectListIterator_2_t8005F348CC0B870A84DE3E85429A840305201D6E * __this, Func_2_t43355C55B1BBA93635101F6AF90867509812D7E5 * ___predicate0, const RuntimeMethod* method)
{
	{
		Func_2_t43355C55B1BBA93635101F6AF90867509812D7E5 * L_0 = ___predicate0;
		WhereEnumerableIterator_1_t3450D7A9CB5BBEE711BB0ADD51AC530BD969D13F * L_1 = (WhereEnumerableIterator_1_t3450D7A9CB5BBEE711BB0ADD51AC530BD969D13F *)il2cpp_codegen_object_new(IL2CPP_RGCTX_DATA(method->klass->rgctx_data, 10));
		((  void (*) (WhereEnumerableIterator_1_t3450D7A9CB5BBEE711BB0ADD51AC530BD969D13F *, RuntimeObject*, Func_2_t43355C55B1BBA93635101F6AF90867509812D7E5 *, const RuntimeMethod*))IL2CPP_RGCTX_METHOD_INFO(method->klass->rgctx_data, 11)->methodPointer)(L_1, (RuntimeObject*)__this, (Func_2_t43355C55B1BBA93635101F6AF90867509812D7E5 *)L_0, /*hidden argument*/IL2CPP_RGCTX_METHOD_INFO(method->klass->rgctx_data, 11));
		return (RuntimeObject*)L_1;
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
// System.Void System.Linq.Enumerable/WhereSelectListIterator`2<System.Decimal,System.Object>::.ctor(System.Collections.Generic.List`1<TSource>,System.Func`2<TSource,System.Boolean>,System.Func`2<TSource,TResult>)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void WhereSelectListIterator_2__ctor_m55CC684E6693FA7C78A986F91F6BE0AA9F6257BE_gshared (WhereSelectListIterator_2_tAACFFE54E7C18BF4B0567FEF884C49B920B0FA6F * __this, List_1_t137B540BF717527106254AA05BE36A51A068C8F5 * ___source0, Func_2_t85912C5553CB5462E74F14A32388FC1004CC7C2E * ___predicate1, Func_2_t19AF92FE90E4D29194E67E9C39AA7BDBF405CD01 * ___selector2, const RuntimeMethod* method)
{
	{
		NullCheck((Iterator_1_t674ABE41CF4096D4BE4D51E21FEBDADBF74CC279 *)__this);
		((  void (*) (Iterator_1_t674ABE41CF4096D4BE4D51E21FEBDADBF74CC279 *, const RuntimeMethod*))IL2CPP_RGCTX_METHOD_INFO(method->klass->rgctx_data, 0)->methodPointer)((Iterator_1_t674ABE41CF4096D4BE4D51E21FEBDADBF74CC279 *)__this, /*hidden argument*/IL2CPP_RGCTX_METHOD_INFO(method->klass->rgctx_data, 0));
		List_1_t137B540BF717527106254AA05BE36A51A068C8F5 * L_0 = ___source0;
		__this->set_source_3(L_0);
		Func_2_t85912C5553CB5462E74F14A32388FC1004CC7C2E * L_1 = ___predicate1;
		__this->set_predicate_4(L_1);
		Func_2_t19AF92FE90E4D29194E67E9C39AA7BDBF405CD01 * L_2 = ___selector2;
		__this->set_selector_5(L_2);
		return;
	}
}
// System.Linq.Enumerable/Iterator`1<TResult> System.Linq.Enumerable/WhereSelectListIterator`2<System.Decimal,System.Object>::Clone()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR Iterator_1_t674ABE41CF4096D4BE4D51E21FEBDADBF74CC279 * WhereSelectListIterator_2_Clone_m11D576C843CA9A5E7818AA668B88E8E899581EAC_gshared (WhereSelectListIterator_2_tAACFFE54E7C18BF4B0567FEF884C49B920B0FA6F * __this, const RuntimeMethod* method)
{
	{
		List_1_t137B540BF717527106254AA05BE36A51A068C8F5 * L_0 = (List_1_t137B540BF717527106254AA05BE36A51A068C8F5 *)__this->get_source_3();
		Func_2_t85912C5553CB5462E74F14A32388FC1004CC7C2E * L_1 = (Func_2_t85912C5553CB5462E74F14A32388FC1004CC7C2E *)__this->get_predicate_4();
		Func_2_t19AF92FE90E4D29194E67E9C39AA7BDBF405CD01 * L_2 = (Func_2_t19AF92FE90E4D29194E67E9C39AA7BDBF405CD01 *)__this->get_selector_5();
		WhereSelectListIterator_2_tAACFFE54E7C18BF4B0567FEF884C49B920B0FA6F * L_3 = (WhereSelectListIterator_2_tAACFFE54E7C18BF4B0567FEF884C49B920B0FA6F *)il2cpp_codegen_object_new(IL2CPP_RGCTX_DATA(method->klass->rgctx_data, 2));
		((  void (*) (WhereSelectListIterator_2_tAACFFE54E7C18BF4B0567FEF884C49B920B0FA6F *, List_1_t137B540BF717527106254AA05BE36A51A068C8F5 *, Func_2_t85912C5553CB5462E74F14A32388FC1004CC7C2E *, Func_2_t19AF92FE90E4D29194E67E9C39AA7BDBF405CD01 *, const RuntimeMethod*))IL2CPP_RGCTX_METHOD_INFO(method->klass->rgctx_data, 3)->methodPointer)(L_3, (List_1_t137B540BF717527106254AA05BE36A51A068C8F5 *)L_0, (Func_2_t85912C5553CB5462E74F14A32388FC1004CC7C2E *)L_1, (Func_2_t19AF92FE90E4D29194E67E9C39AA7BDBF405CD01 *)L_2, /*hidden argument*/IL2CPP_RGCTX_METHOD_INFO(method->klass->rgctx_data, 3));
		return (Iterator_1_t674ABE41CF4096D4BE4D51E21FEBDADBF74CC279 *)L_3;
	}
}
// System.Boolean System.Linq.Enumerable/WhereSelectListIterator`2<System.Decimal,System.Object>::MoveNext()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR bool WhereSelectListIterator_2_MoveNext_mFD9F42409C0C4DE35802B89F91DF94CE87BD1301_gshared (WhereSelectListIterator_2_tAACFFE54E7C18BF4B0567FEF884C49B920B0FA6F * __this, const RuntimeMethod* method)
{
	int32_t V_0 = 0;
	Decimal_t2978B229CA86D3B7BA66A0AEEE014E0DE4F940D7  V_1;
	memset((&V_1), 0, sizeof(V_1));
	{
		int32_t L_0 = (int32_t)((Iterator_1_t674ABE41CF4096D4BE4D51E21FEBDADBF74CC279 *)__this)->get_state_1();
		V_0 = (int32_t)L_0;
		int32_t L_1 = V_0;
		if ((((int32_t)L_1) == ((int32_t)1)))
		{
			goto IL_0011;
		}
	}
	{
		int32_t L_2 = V_0;
		if ((((int32_t)L_2) == ((int32_t)2)))
		{
			goto IL_0061;
		}
	}
	{
		goto IL_0074;
	}

IL_0011:
	{
		List_1_t137B540BF717527106254AA05BE36A51A068C8F5 * L_3 = (List_1_t137B540BF717527106254AA05BE36A51A068C8F5 *)__this->get_source_3();
		NullCheck((List_1_t137B540BF717527106254AA05BE36A51A068C8F5 *)L_3);
		Enumerator_t97AF9DDC8F349478939A4899D22F6CC1A2FA7021  L_4;
		L_4 = ((  Enumerator_t97AF9DDC8F349478939A4899D22F6CC1A2FA7021  (*) (List_1_t137B540BF717527106254AA05BE36A51A068C8F5 *, const RuntimeMethod*))IL2CPP_RGCTX_METHOD_INFO(method->klass->rgctx_data, 4)->methodPointer)((List_1_t137B540BF717527106254AA05BE36A51A068C8F5 *)L_3, /*hidden argument*/IL2CPP_RGCTX_METHOD_INFO(method->klass->rgctx_data, 4));
		__this->set_enumerator_6(L_4);
		((Iterator_1_t674ABE41CF4096D4BE4D51E21FEBDADBF74CC279 *)__this)->set_state_1(2);
		goto IL_0061;
	}

IL_002b:
	{
		Enumerator_t97AF9DDC8F349478939A4899D22F6CC1A2FA7021 * L_5 = (Enumerator_t97AF9DDC8F349478939A4899D22F6CC1A2FA7021 *)__this->get_address_of_enumerator_6();
		Decimal_t2978B229CA86D3B7BA66A0AEEE014E0DE4F940D7  L_6;
		L_6 = Enumerator_get_Current_m463788CB5D0E8998F983E802C69ABFD0DF8F10DF_inline((Enumerator_t97AF9DDC8F349478939A4899D22F6CC1A2FA7021 *)(Enumerator_t97AF9DDC8F349478939A4899D22F6CC1A2FA7021 *)L_5, /*hidden argument*/IL2CPP_RGCTX_METHOD_INFO(method->klass->rgctx_data, 5));
		V_1 = (Decimal_t2978B229CA86D3B7BA66A0AEEE014E0DE4F940D7 )L_6;
		Func_2_t85912C5553CB5462E74F14A32388FC1004CC7C2E * L_7 = (Func_2_t85912C5553CB5462E74F14A32388FC1004CC7C2E *)__this->get_predicate_4();
		if (!L_7)
		{
			goto IL_004d;
		}
	}
	{
		Func_2_t85912C5553CB5462E74F14A32388FC1004CC7C2E * L_8 = (Func_2_t85912C5553CB5462E74F14A32388FC1004CC7C2E *)__this->get_predicate_4();
		Decimal_t2978B229CA86D3B7BA66A0AEEE014E0DE4F940D7  L_9 = V_1;
		NullCheck((Func_2_t85912C5553CB5462E74F14A32388FC1004CC7C2E *)L_8);
		bool L_10;
		L_10 = ((  bool (*) (Func_2_t85912C5553CB5462E74F14A32388FC1004CC7C2E *, Decimal_t2978B229CA86D3B7BA66A0AEEE014E0DE4F940D7 , const RuntimeMethod*))IL2CPP_RGCTX_METHOD_INFO(method->klass->rgctx_data, 6)->methodPointer)((Func_2_t85912C5553CB5462E74F14A32388FC1004CC7C2E *)L_8, (Decimal_t2978B229CA86D3B7BA66A0AEEE014E0DE4F940D7 )L_9, /*hidden argument*/IL2CPP_RGCTX_METHOD_INFO(method->klass->rgctx_data, 6));
		if (!L_10)
		{
			goto IL_0061;
		}
	}

IL_004d:
	{
		Func_2_t19AF92FE90E4D29194E67E9C39AA7BDBF405CD01 * L_11 = (Func_2_t19AF92FE90E4D29194E67E9C39AA7BDBF405CD01 *)__this->get_selector_5();
		Decimal_t2978B229CA86D3B7BA66A0AEEE014E0DE4F940D7  L_12 = V_1;
		NullCheck((Func_2_t19AF92FE90E4D29194E67E9C39AA7BDBF405CD01 *)L_11);
		RuntimeObject * L_13;
		L_13 = ((  RuntimeObject * (*) (Func_2_t19AF92FE90E4D29194E67E9C39AA7BDBF405CD01 *, Decimal_t2978B229CA86D3B7BA66A0AEEE014E0DE4F940D7 , const RuntimeMethod*))IL2CPP_RGCTX_METHOD_INFO(method->klass->rgctx_data, 7)->methodPointer)((Func_2_t19AF92FE90E4D29194E67E9C39AA7BDBF405CD01 *)L_11, (Decimal_t2978B229CA86D3B7BA66A0AEEE014E0DE4F940D7 )L_12, /*hidden argument*/IL2CPP_RGCTX_METHOD_INFO(method->klass->rgctx_data, 7));
		((Iterator_1_t674ABE41CF4096D4BE4D51E21FEBDADBF74CC279 *)__this)->set_current_2(L_13);
		return (bool)1;
	}

IL_0061:
	{
		Enumerator_t97AF9DDC8F349478939A4899D22F6CC1A2FA7021 * L_14 = (Enumerator_t97AF9DDC8F349478939A4899D22F6CC1A2FA7021 *)__this->get_address_of_enumerator_6();
		bool L_15;
		L_15 = Enumerator_MoveNext_m94DEBE5F36416BB0664E8C3F1E0C3E3E03DBFA8F((Enumerator_t97AF9DDC8F349478939A4899D22F6CC1A2FA7021 *)(Enumerator_t97AF9DDC8F349478939A4899D22F6CC1A2FA7021 *)L_14, /*hidden argument*/IL2CPP_RGCTX_METHOD_INFO(method->klass->rgctx_data, 8));
		if (L_15)
		{
			goto IL_002b;
		}
	}
	{
		NullCheck((Iterator_1_t674ABE41CF4096D4BE4D51E21FEBDADBF74CC279 *)__this);
		VirtActionInvoker0::Invoke(12 /* System.Void System.Linq.Enumerable/Iterator`1<System.Object>::Dispose() */, (Iterator_1_t674ABE41CF4096D4BE4D51E21FEBDADBF74CC279 *)__this);
	}

IL_0074:
	{
		return (bool)0;
	}
}
// System.Collections.Generic.IEnumerable`1<TResult> System.Linq.Enumerable/WhereSelectListIterator`2<System.Decimal,System.Object>::Where(System.Func`2<TResult,System.Boolean>)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR RuntimeObject* WhereSelectListIterator_2_Where_m36B711F68908FFFAE80A54B151F099206CD69596_gshared (WhereSelectListIterator_2_tAACFFE54E7C18BF4B0567FEF884C49B920B0FA6F * __this, Func_2_t99409DECFF50F0FA9B427C863AC6C99C66E6F9F8 * ___predicate0, const RuntimeMethod* method)
{
	{
		Func_2_t99409DECFF50F0FA9B427C863AC6C99C66E6F9F8 * L_0 = ___predicate0;
		WhereEnumerableIterator_1_t1E9FDCFD8F8136C6A5A5740C1E093EF03F0B5CE0 * L_1 = (WhereEnumerableIterator_1_t1E9FDCFD8F8136C6A5A5740C1E093EF03F0B5CE0 *)il2cpp_codegen_object_new(IL2CPP_RGCTX_DATA(method->klass->rgctx_data, 10));
		((  void (*) (WhereEnumerableIterator_1_t1E9FDCFD8F8136C6A5A5740C1E093EF03F0B5CE0 *, RuntimeObject*, Func_2_t99409DECFF50F0FA9B427C863AC6C99C66E6F9F8 *, const RuntimeMethod*))IL2CPP_RGCTX_METHOD_INFO(method->klass->rgctx_data, 11)->methodPointer)(L_1, (RuntimeObject*)__this, (Func_2_t99409DECFF50F0FA9B427C863AC6C99C66E6F9F8 *)L_0, /*hidden argument*/IL2CPP_RGCTX_METHOD_INFO(method->klass->rgctx_data, 11));
		return (RuntimeObject*)L_1;
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
// System.Void System.Linq.Enumerable/WhereSelectListIterator`2<System.Double,System.Object>::.ctor(System.Collections.Generic.List`1<TSource>,System.Func`2<TSource,System.Boolean>,System.Func`2<TSource,TResult>)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void WhereSelectListIterator_2__ctor_m465BC7BF6D981AB9FDEE193D48F42AB011C1E02D_gshared (WhereSelectListIterator_2_tEAC6442837D35900886655E6EBECD17A00D72FF1 * __this, List_1_t760D7EED86247E3493CD5F22F0E822BF6AE1C2BC * ___source0, Func_2_t4E607BF9FA9E115F43BD77F92F4285E3B8C7FB0D * ___predicate1, Func_2_t9250D6A3AAE1BC9DC97036CF116D97FC17C08719 * ___selector2, const RuntimeMethod* method)
{
	{
		NullCheck((Iterator_1_t674ABE41CF4096D4BE4D51E21FEBDADBF74CC279 *)__this);
		((  void (*) (Iterator_1_t674ABE41CF4096D4BE4D51E21FEBDADBF74CC279 *, const RuntimeMethod*))IL2CPP_RGCTX_METHOD_INFO(method->klass->rgctx_data, 0)->methodPointer)((Iterator_1_t674ABE41CF4096D4BE4D51E21FEBDADBF74CC279 *)__this, /*hidden argument*/IL2CPP_RGCTX_METHOD_INFO(method->klass->rgctx_data, 0));
		List_1_t760D7EED86247E3493CD5F22F0E822BF6AE1C2BC * L_0 = ___source0;
		__this->set_source_3(L_0);
		Func_2_t4E607BF9FA9E115F43BD77F92F4285E3B8C7FB0D * L_1 = ___predicate1;
		__this->set_predicate_4(L_1);
		Func_2_t9250D6A3AAE1BC9DC97036CF116D97FC17C08719 * L_2 = ___selector2;
		__this->set_selector_5(L_2);
		return;
	}
}
// System.Linq.Enumerable/Iterator`1<TResult> System.Linq.Enumerable/WhereSelectListIterator`2<System.Double,System.Object>::Clone()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR Iterator_1_t674ABE41CF4096D4BE4D51E21FEBDADBF74CC279 * WhereSelectListIterator_2_Clone_m097AFFAC1CB339EF3DE1A0A65D08891C61C5D69E_gshared (WhereSelectListIterator_2_tEAC6442837D35900886655E6EBECD17A00D72FF1 * __this, const RuntimeMethod* method)
{
	{
		List_1_t760D7EED86247E3493CD5F22F0E822BF6AE1C2BC * L_0 = (List_1_t760D7EED86247E3493CD5F22F0E822BF6AE1C2BC *)__this->get_source_3();
		Func_2_t4E607BF9FA9E115F43BD77F92F4285E3B8C7FB0D * L_1 = (Func_2_t4E607BF9FA9E115F43BD77F92F4285E3B8C7FB0D *)__this->get_predicate_4();
		Func_2_t9250D6A3AAE1BC9DC97036CF116D97FC17C08719 * L_2 = (Func_2_t9250D6A3AAE1BC9DC97036CF116D97FC17C08719 *)__this->get_selector_5();
		WhereSelectListIterator_2_tEAC6442837D35900886655E6EBECD17A00D72FF1 * L_3 = (WhereSelectListIterator_2_tEAC6442837D35900886655E6EBECD17A00D72FF1 *)il2cpp_codegen_object_new(IL2CPP_RGCTX_DATA(method->klass->rgctx_data, 2));
		((  void (*) (WhereSelectListIterator_2_tEAC6442837D35900886655E6EBECD17A00D72FF1 *, List_1_t760D7EED86247E3493CD5F22F0E822BF6AE1C2BC *, Func_2_t4E607BF9FA9E115F43BD77F92F4285E3B8C7FB0D *, Func_2_t9250D6A3AAE1BC9DC97036CF116D97FC17C08719 *, const RuntimeMethod*))IL2CPP_RGCTX_METHOD_INFO(method->klass->rgctx_data, 3)->methodPointer)(L_3, (List_1_t760D7EED86247E3493CD5F22F0E822BF6AE1C2BC *)L_0, (Func_2_t4E607BF9FA9E115F43BD77F92F4285E3B8C7FB0D *)L_1, (Func_2_t9250D6A3AAE1BC9DC97036CF116D97FC17C08719 *)L_2, /*hidden argument*/IL2CPP_RGCTX_METHOD_INFO(method->klass->rgctx_data, 3));
		return (Iterator_1_t674ABE41CF4096D4BE4D51E21FEBDADBF74CC279 *)L_3;
	}
}
// System.Boolean System.Linq.Enumerable/WhereSelectListIterator`2<System.Double,System.Object>::MoveNext()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR bool WhereSelectListIterator_2_MoveNext_mE0CECB87D750D80D0F5192D7474C76DBD71F2524_gshared (WhereSelectListIterator_2_tEAC6442837D35900886655E6EBECD17A00D72FF1 * __this, const RuntimeMethod* method)
{
	int32_t V_0 = 0;
	double V_1 = 0.0;
	{
		int32_t L_0 = (int32_t)((Iterator_1_t674ABE41CF4096D4BE4D51E21FEBDADBF74CC279 *)__this)->get_state_1();
		V_0 = (int32_t)L_0;
		int32_t L_1 = V_0;
		if ((((int32_t)L_1) == ((int32_t)1)))
		{
			goto IL_0011;
		}
	}
	{
		int32_t L_2 = V_0;
		if ((((int32_t)L_2) == ((int32_t)2)))
		{
			goto IL_0061;
		}
	}
	{
		goto IL_0074;
	}

IL_0011:
	{
		List_1_t760D7EED86247E3493CD5F22F0E822BF6AE1C2BC * L_3 = (List_1_t760D7EED86247E3493CD5F22F0E822BF6AE1C2BC *)__this->get_source_3();
		NullCheck((List_1_t760D7EED86247E3493CD5F22F0E822BF6AE1C2BC *)L_3);
		Enumerator_tDB7E887EC564EBF2D244915021ED0896BFD7A8A2  L_4;
		L_4 = ((  Enumerator_tDB7E887EC564EBF2D244915021ED0896BFD7A8A2  (*) (List_1_t760D7EED86247E3493CD5F22F0E822BF6AE1C2BC *, const RuntimeMethod*))IL2CPP_RGCTX_METHOD_INFO(method->klass->rgctx_data, 4)->methodPointer)((List_1_t760D7EED86247E3493CD5F22F0E822BF6AE1C2BC *)L_3, /*hidden argument*/IL2CPP_RGCTX_METHOD_INFO(method->klass->rgctx_data, 4));
		__this->set_enumerator_6(L_4);
		((Iterator_1_t674ABE41CF4096D4BE4D51E21FEBDADBF74CC279 *)__this)->set_state_1(2);
		goto IL_0061;
	}

IL_002b:
	{
		Enumerator_tDB7E887EC564EBF2D244915021ED0896BFD7A8A2 * L_5 = (Enumerator_tDB7E887EC564EBF2D244915021ED0896BFD7A8A2 *)__this->get_address_of_enumerator_6();
		double L_6;
		L_6 = Enumerator_get_Current_m14C2F2917DC59AB94B8E9875EEF5E57AB7DE82B8_inline((Enumerator_tDB7E887EC564EBF2D244915021ED0896BFD7A8A2 *)(Enumerator_tDB7E887EC564EBF2D244915021ED0896BFD7A8A2 *)L_5, /*hidden argument*/IL2CPP_RGCTX_METHOD_INFO(method->klass->rgctx_data, 5));
		V_1 = (double)L_6;
		Func_2_t4E607BF9FA9E115F43BD77F92F4285E3B8C7FB0D * L_7 = (Func_2_t4E607BF9FA9E115F43BD77F92F4285E3B8C7FB0D *)__this->get_predicate_4();
		if (!L_7)
		{
			goto IL_004d;
		}
	}
	{
		Func_2_t4E607BF9FA9E115F43BD77F92F4285E3B8C7FB0D * L_8 = (Func_2_t4E607BF9FA9E115F43BD77F92F4285E3B8C7FB0D *)__this->get_predicate_4();
		double L_9 = V_1;
		NullCheck((Func_2_t4E607BF9FA9E115F43BD77F92F4285E3B8C7FB0D *)L_8);
		bool L_10;
		L_10 = ((  bool (*) (Func_2_t4E607BF9FA9E115F43BD77F92F4285E3B8C7FB0D *, double, const RuntimeMethod*))IL2CPP_RGCTX_METHOD_INFO(method->klass->rgctx_data, 6)->methodPointer)((Func_2_t4E607BF9FA9E115F43BD77F92F4285E3B8C7FB0D *)L_8, (double)L_9, /*hidden argument*/IL2CPP_RGCTX_METHOD_INFO(method->klass->rgctx_data, 6));
		if (!L_10)
		{
			goto IL_0061;
		}
	}

IL_004d:
	{
		Func_2_t9250D6A3AAE1BC9DC97036CF116D97FC17C08719 * L_11 = (Func_2_t9250D6A3AAE1BC9DC97036CF116D97FC17C08719 *)__this->get_selector_5();
		double L_12 = V_1;
		NullCheck((Func_2_t9250D6A3AAE1BC9DC97036CF116D97FC17C08719 *)L_11);
		RuntimeObject * L_13;
		L_13 = ((  RuntimeObject * (*) (Func_2_t9250D6A3AAE1BC9DC97036CF116D97FC17C08719 *, double, const RuntimeMethod*))IL2CPP_RGCTX_METHOD_INFO(method->klass->rgctx_data, 7)->methodPointer)((Func_2_t9250D6A3AAE1BC9DC97036CF116D97FC17C08719 *)L_11, (double)L_12, /*hidden argument*/IL2CPP_RGCTX_METHOD_INFO(method->klass->rgctx_data, 7));
		((Iterator_1_t674ABE41CF4096D4BE4D51E21FEBDADBF74CC279 *)__this)->set_current_2(L_13);
		return (bool)1;
	}

IL_0061:
	{
		Enumerator_tDB7E887EC564EBF2D244915021ED0896BFD7A8A2 * L_14 = (Enumerator_tDB7E887EC564EBF2D244915021ED0896BFD7A8A2 *)__this->get_address_of_enumerator_6();
		bool L_15;
		L_15 = Enumerator_MoveNext_m3F9800297946765598836D838E09AE04C76A3322((Enumerator_tDB7E887EC564EBF2D244915021ED0896BFD7A8A2 *)(Enumerator_tDB7E887EC564EBF2D244915021ED0896BFD7A8A2 *)L_14, /*hidden argument*/IL2CPP_RGCTX_METHOD_INFO(method->klass->rgctx_data, 8));
		if (L_15)
		{
			goto IL_002b;
		}
	}
	{
		NullCheck((Iterator_1_t674ABE41CF4096D4BE4D51E21FEBDADBF74CC279 *)__this);
		VirtActionInvoker0::Invoke(12 /* System.Void System.Linq.Enumerable/Iterator`1<System.Object>::Dispose() */, (Iterator_1_t674ABE41CF4096D4BE4D51E21FEBDADBF74CC279 *)__this);
	}

IL_0074:
	{
		return (bool)0;
	}
}
// System.Collections.Generic.IEnumerable`1<TResult> System.Linq.Enumerable/WhereSelectListIterator`2<System.Double,System.Object>::Where(System.Func`2<TResult,System.Boolean>)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR RuntimeObject* WhereSelectListIterator_2_Where_mC36639AE39A4B8A386B654A31E2FC60CE5FBB5BB_gshared (WhereSelectListIterator_2_tEAC6442837D35900886655E6EBECD17A00D72FF1 * __this, Func_2_t99409DECFF50F0FA9B427C863AC6C99C66E6F9F8 * ___predicate0, const RuntimeMethod* method)
{
	{
		Func_2_t99409DECFF50F0FA9B427C863AC6C99C66E6F9F8 * L_0 = ___predicate0;
		WhereEnumerableIterator_1_t1E9FDCFD8F8136C6A5A5740C1E093EF03F0B5CE0 * L_1 = (WhereEnumerableIterator_1_t1E9FDCFD8F8136C6A5A5740C1E093EF03F0B5CE0 *)il2cpp_codegen_object_new(IL2CPP_RGCTX_DATA(method->klass->rgctx_data, 10));
		((  void (*) (WhereEnumerableIterator_1_t1E9FDCFD8F8136C6A5A5740C1E093EF03F0B5CE0 *, RuntimeObject*, Func_2_t99409DECFF50F0FA9B427C863AC6C99C66E6F9F8 *, const RuntimeMethod*))IL2CPP_RGCTX_METHOD_INFO(method->klass->rgctx_data, 11)->methodPointer)(L_1, (RuntimeObject*)__this, (Func_2_t99409DECFF50F0FA9B427C863AC6C99C66E6F9F8 *)L_0, /*hidden argument*/IL2CPP_RGCTX_METHOD_INFO(method->klass->rgctx_data, 11));
		return (RuntimeObject*)L_1;
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
// System.Void System.Linq.Enumerable/WhereSelectListIterator`2<System.Int32,System.Nullable`1<System.Decimal>>::.ctor(System.Collections.Generic.List`1<TSource>,System.Func`2<TSource,System.Boolean>,System.Func`2<TSource,TResult>)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void WhereSelectListIterator_2__ctor_m8E06A609ABF9F823F504C70BCC9ED4F9A9E6EACE_gshared (WhereSelectListIterator_2_tE0E6511BEA6332534ECB4BFFD7FF61385E8B4D37 * __this, List_1_t260B41F956D673396C33A4CF94E8D6C4389EACB7 * ___source0, Func_2_t2EBF98B0BA555D9F0633C9BCCBE3DF332B9C1274 * ___predicate1, Func_2_t2CF7067ECC6F2E1B8FC552857749A03DC1E5AE1E * ___selector2, const RuntimeMethod* method)
{
	{
		NullCheck((Iterator_1_tC3AC38DE0A9857A77F64882DC49BB78318A5EF00 *)__this);
		((  void (*) (Iterator_1_tC3AC38DE0A9857A77F64882DC49BB78318A5EF00 *, const RuntimeMethod*))IL2CPP_RGCTX_METHOD_INFO(method->klass->rgctx_data, 0)->methodPointer)((Iterator_1_tC3AC38DE0A9857A77F64882DC49BB78318A5EF00 *)__this, /*hidden argument*/IL2CPP_RGCTX_METHOD_INFO(method->klass->rgctx_data, 0));
		List_1_t260B41F956D673396C33A4CF94E8D6C4389EACB7 * L_0 = ___source0;
		__this->set_source_3(L_0);
		Func_2_t2EBF98B0BA555D9F0633C9BCCBE3DF332B9C1274 * L_1 = ___predicate1;
		__this->set_predicate_4(L_1);
		Func_2_t2CF7067ECC6F2E1B8FC552857749A03DC1E5AE1E * L_2 = ___selector2;
		__this->set_selector_5(L_2);
		return;
	}
}
// System.Linq.Enumerable/Iterator`1<TResult> System.Linq.Enumerable/WhereSelectListIterator`2<System.Int32,System.Nullable`1<System.Decimal>>::Clone()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR Iterator_1_tC3AC38DE0A9857A77F64882DC49BB78318A5EF00 * WhereSelectListIterator_2_Clone_m7B6B2D57610909D1FA5A2DC72B83E9A229AA53B0_gshared (WhereSelectListIterator_2_tE0E6511BEA6332534ECB4BFFD7FF61385E8B4D37 * __this, const RuntimeMethod* method)
{
	{
		List_1_t260B41F956D673396C33A4CF94E8D6C4389EACB7 * L_0 = (List_1_t260B41F956D673396C33A4CF94E8D6C4389EACB7 *)__this->get_source_3();
		Func_2_t2EBF98B0BA555D9F0633C9BCCBE3DF332B9C1274 * L_1 = (Func_2_t2EBF98B0BA555D9F0633C9BCCBE3DF332B9C1274 *)__this->get_predicate_4();
		Func_2_t2CF7067ECC6F2E1B8FC552857749A03DC1E5AE1E * L_2 = (Func_2_t2CF7067ECC6F2E1B8FC552857749A03DC1E5AE1E *)__this->get_selector_5();
		WhereSelectListIterator_2_tE0E6511BEA6332534ECB4BFFD7FF61385E8B4D37 * L_3 = (WhereSelectListIterator_2_tE0E6511BEA6332534ECB4BFFD7FF61385E8B4D37 *)il2cpp_codegen_object_new(IL2CPP_RGCTX_DATA(method->klass->rgctx_data, 2));
		((  void (*) (WhereSelectListIterator_2_tE0E6511BEA6332534ECB4BFFD7FF61385E8B4D37 *, List_1_t260B41F956D673396C33A4CF94E8D6C4389EACB7 *, Func_2_t2EBF98B0BA555D9F0633C9BCCBE3DF332B9C1274 *, Func_2_t2CF7067ECC6F2E1B8FC552857749A03DC1E5AE1E *, const RuntimeMethod*))IL2CPP_RGCTX_METHOD_INFO(method->klass->rgctx_data, 3)->methodPointer)(L_3, (List_1_t260B41F956D673396C33A4CF94E8D6C4389EACB7 *)L_0, (Func_2_t2EBF98B0BA555D9F0633C9BCCBE3DF332B9C1274 *)L_1, (Func_2_t2CF7067ECC6F2E1B8FC552857749A03DC1E5AE1E *)L_2, /*hidden argument*/IL2CPP_RGCTX_METHOD_INFO(method->klass->rgctx_data, 3));
		return (Iterator_1_tC3AC38DE0A9857A77F64882DC49BB78318A5EF00 *)L_3;
	}
}
// System.Boolean System.Linq.Enumerable/WhereSelectListIterator`2<System.Int32,System.Nullable`1<System.Decimal>>::MoveNext()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR bool WhereSelectListIterator_2_MoveNext_m5316C270411B3DABA187B3A4771C93D7E566B55D_gshared (WhereSelectListIterator_2_tE0E6511BEA6332534ECB4BFFD7FF61385E8B4D37 * __this, const RuntimeMethod* method)
{
	int32_t V_0 = 0;
	int32_t V_1 = 0;
	{
		int32_t L_0 = (int32_t)((Iterator_1_tC3AC38DE0A9857A77F64882DC49BB78318A5EF00 *)__this)->get_state_1();
		V_0 = (int32_t)L_0;
		int32_t L_1 = V_0;
		if ((((int32_t)L_1) == ((int32_t)1)))
		{
			goto IL_0011;
		}
	}
	{
		int32_t L_2 = V_0;
		if ((((int32_t)L_2) == ((int32_t)2)))
		{
			goto IL_0061;
		}
	}
	{
		goto IL_0074;
	}

IL_0011:
	{
		List_1_t260B41F956D673396C33A4CF94E8D6C4389EACB7 * L_3 = (List_1_t260B41F956D673396C33A4CF94E8D6C4389EACB7 *)__this->get_source_3();
		NullCheck((List_1_t260B41F956D673396C33A4CF94E8D6C4389EACB7 *)L_3);
		Enumerator_t7BA00929E14A2F2A62CE085585044A3FEB2C5F3C  L_4;
		L_4 = ((  Enumerator_t7BA00929E14A2F2A62CE085585044A3FEB2C5F3C  (*) (List_1_t260B41F956D673396C33A4CF94E8D6C4389EACB7 *, const RuntimeMethod*))IL2CPP_RGCTX_METHOD_INFO(method->klass->rgctx_data, 4)->methodPointer)((List_1_t260B41F956D673396C33A4CF94E8D6C4389EACB7 *)L_3, /*hidden argument*/IL2CPP_RGCTX_METHOD_INFO(method->klass->rgctx_data, 4));
		__this->set_enumerator_6(L_4);
		((Iterator_1_tC3AC38DE0A9857A77F64882DC49BB78318A5EF00 *)__this)->set_state_1(2);
		goto IL_0061;
	}

IL_002b:
	{
		Enumerator_t7BA00929E14A2F2A62CE085585044A3FEB2C5F3C * L_5 = (Enumerator_t7BA00929E14A2F2A62CE085585044A3FEB2C5F3C *)__this->get_address_of_enumerator_6();
		int32_t L_6;
		L_6 = Enumerator_get_Current_m6BBD624C51F7E20D347FE5894A6ECA94B8011181_inline((Enumerator_t7BA00929E14A2F2A62CE085585044A3FEB2C5F3C *)(Enumerator_t7BA00929E14A2F2A62CE085585044A3FEB2C5F3C *)L_5, /*hidden argument*/IL2CPP_RGCTX_METHOD_INFO(method->klass->rgctx_data, 5));
		V_1 = (int32_t)L_6;
		Func_2_t2EBF98B0BA555D9F0633C9BCCBE3DF332B9C1274 * L_7 = (Func_2_t2EBF98B0BA555D9F0633C9BCCBE3DF332B9C1274 *)__this->get_predicate_4();
		if (!L_7)
		{
			goto IL_004d;
		}
	}
	{
		Func_2_t2EBF98B0BA555D9F0633C9BCCBE3DF332B9C1274 * L_8 = (Func_2_t2EBF98B0BA555D9F0633C9BCCBE3DF332B9C1274 *)__this->get_predicate_4();
		int32_t L_9 = V_1;
		NullCheck((Func_2_t2EBF98B0BA555D9F0633C9BCCBE3DF332B9C1274 *)L_8);
		bool L_10;
		L_10 = ((  bool (*) (Func_2_t2EBF98B0BA555D9F0633C9BCCBE3DF332B9C1274 *, int32_t, const RuntimeMethod*))IL2CPP_RGCTX_METHOD_INFO(method->klass->rgctx_data, 6)->methodPointer)((Func_2_t2EBF98B0BA555D9F0633C9BCCBE3DF332B9C1274 *)L_8, (int32_t)L_9, /*hidden argument*/IL2CPP_RGCTX_METHOD_INFO(method->klass->rgctx_data, 6));
		if (!L_10)
		{
			goto IL_0061;
		}
	}

IL_004d:
	{
		Func_2_t2CF7067ECC6F2E1B8FC552857749A03DC1E5AE1E * L_11 = (Func_2_t2CF7067ECC6F2E1B8FC552857749A03DC1E5AE1E *)__this->get_selector_5();
		int32_t L_12 = V_1;
		NullCheck((Func_2_t2CF7067ECC6F2E1B8FC552857749A03DC1E5AE1E *)L_11);
		Nullable_1_tD7EB7EB39E548910812AA4DC702F9C7E3E84A84E  L_13;
		L_13 = ((  Nullable_1_tD7EB7EB39E548910812AA4DC702F9C7E3E84A84E  (*) (Func_2_t2CF7067ECC6F2E1B8FC552857749A03DC1E5AE1E *, int32_t, const RuntimeMethod*))IL2CPP_RGCTX_METHOD_INFO(method->klass->rgctx_data, 7)->methodPointer)((Func_2_t2CF7067ECC6F2E1B8FC552857749A03DC1E5AE1E *)L_11, (int32_t)L_12, /*hidden argument*/IL2CPP_RGCTX_METHOD_INFO(method->klass->rgctx_data, 7));
		((Iterator_1_tC3AC38DE0A9857A77F64882DC49BB78318A5EF00 *)__this)->set_current_2(L_13);
		return (bool)1;
	}

IL_0061:
	{
		Enumerator_t7BA00929E14A2F2A62CE085585044A3FEB2C5F3C * L_14 = (Enumerator_t7BA00929E14A2F2A62CE085585044A3FEB2C5F3C *)__this->get_address_of_enumerator_6();
		bool L_15;
		L_15 = Enumerator_MoveNext_m40FD166B6757334A2BBCF67238EFDF70D727A4A6((Enumerator_t7BA00929E14A2F2A62CE085585044A3FEB2C5F3C *)(Enumerator_t7BA00929E14A2F2A62CE085585044A3FEB2C5F3C *)L_14, /*hidden argument*/IL2CPP_RGCTX_METHOD_INFO(method->klass->rgctx_data, 8));
		if (L_15)
		{
			goto IL_002b;
		}
	}
	{
		NullCheck((Iterator_1_tC3AC38DE0A9857A77F64882DC49BB78318A5EF00 *)__this);
		VirtActionInvoker0::Invoke(12 /* System.Void System.Linq.Enumerable/Iterator`1<System.Nullable`1<System.Decimal>>::Dispose() */, (Iterator_1_tC3AC38DE0A9857A77F64882DC49BB78318A5EF00 *)__this);
	}

IL_0074:
	{
		return (bool)0;
	}
}
// System.Collections.Generic.IEnumerable`1<TResult> System.Linq.Enumerable/WhereSelectListIterator`2<System.Int32,System.Nullable`1<System.Decimal>>::Where(System.Func`2<TResult,System.Boolean>)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR RuntimeObject* WhereSelectListIterator_2_Where_mEA04DC25124BACED558FD0B079356BF3BBFC4C22_gshared (WhereSelectListIterator_2_tE0E6511BEA6332534ECB4BFFD7FF61385E8B4D37 * __this, Func_2_t04450D4888681586D3F4812C491231E855EF5DE7 * ___predicate0, const RuntimeMethod* method)
{
	{
		Func_2_t04450D4888681586D3F4812C491231E855EF5DE7 * L_0 = ___predicate0;
		WhereEnumerableIterator_1_tC23C2A31FF955909EB9C6795D474D218DB84F0F5 * L_1 = (WhereEnumerableIterator_1_tC23C2A31FF955909EB9C6795D474D218DB84F0F5 *)il2cpp_codegen_object_new(IL2CPP_RGCTX_DATA(method->klass->rgctx_data, 10));
		((  void (*) (WhereEnumerableIterator_1_tC23C2A31FF955909EB9C6795D474D218DB84F0F5 *, RuntimeObject*, Func_2_t04450D4888681586D3F4812C491231E855EF5DE7 *, const RuntimeMethod*))IL2CPP_RGCTX_METHOD_INFO(method->klass->rgctx_data, 11)->methodPointer)(L_1, (RuntimeObject*)__this, (Func_2_t04450D4888681586D3F4812C491231E855EF5DE7 *)L_0, /*hidden argument*/IL2CPP_RGCTX_METHOD_INFO(method->klass->rgctx_data, 11));
		return (RuntimeObject*)L_1;
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
// System.Void System.Linq.Enumerable/WhereSelectListIterator`2<System.Int32,System.Nullable`1<System.Double>>::.ctor(System.Collections.Generic.List`1<TSource>,System.Func`2<TSource,System.Boolean>,System.Func`2<TSource,TResult>)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void WhereSelectListIterator_2__ctor_m8FDB48979FE535812E12CE716BEF4B7C51FFCCFE_gshared (WhereSelectListIterator_2_t1490C52A3F0E91B34D300F481F9E37F5F0FECEA4 * __this, List_1_t260B41F956D673396C33A4CF94E8D6C4389EACB7 * ___source0, Func_2_t2EBF98B0BA555D9F0633C9BCCBE3DF332B9C1274 * ___predicate1, Func_2_t6C7618E0D575852E15D00A9E3CA463CE2CF5D159 * ___selector2, const RuntimeMethod* method)
{
	{
		NullCheck((Iterator_1_t75B26B5E87871854D759A25738CFE42AF131D6A8 *)__this);
		((  void (*) (Iterator_1_t75B26B5E87871854D759A25738CFE42AF131D6A8 *, const RuntimeMethod*))IL2CPP_RGCTX_METHOD_INFO(method->klass->rgctx_data, 0)->methodPointer)((Iterator_1_t75B26B5E87871854D759A25738CFE42AF131D6A8 *)__this, /*hidden argument*/IL2CPP_RGCTX_METHOD_INFO(method->klass->rgctx_data, 0));
		List_1_t260B41F956D673396C33A4CF94E8D6C4389EACB7 * L_0 = ___source0;
		__this->set_source_3(L_0);
		Func_2_t2EBF98B0BA555D9F0633C9BCCBE3DF332B9C1274 * L_1 = ___predicate1;
		__this->set_predicate_4(L_1);
		Func_2_t6C7618E0D575852E15D00A9E3CA463CE2CF5D159 * L_2 = ___selector2;
		__this->set_selector_5(L_2);
		return;
	}
}
// System.Linq.Enumerable/Iterator`1<TResult> System.Linq.Enumerable/WhereSelectListIterator`2<System.Int32,System.Nullable`1<System.Double>>::Clone()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR Iterator_1_t75B26B5E87871854D759A25738CFE42AF131D6A8 * WhereSelectListIterator_2_Clone_m4A92E5FF207CF0AE1AE4D18B70BB8D9854F8C715_gshared (WhereSelectListIterator_2_t1490C52A3F0E91B34D300F481F9E37F5F0FECEA4 * __this, const RuntimeMethod* method)
{
	{
		List_1_t260B41F956D673396C33A4CF94E8D6C4389EACB7 * L_0 = (List_1_t260B41F956D673396C33A4CF94E8D6C4389EACB7 *)__this->get_source_3();
		Func_2_t2EBF98B0BA555D9F0633C9BCCBE3DF332B9C1274 * L_1 = (Func_2_t2EBF98B0BA555D9F0633C9BCCBE3DF332B9C1274 *)__this->get_predicate_4();
		Func_2_t6C7618E0D575852E15D00A9E3CA463CE2CF5D159 * L_2 = (Func_2_t6C7618E0D575852E15D00A9E3CA463CE2CF5D159 *)__this->get_selector_5();
		WhereSelectListIterator_2_t1490C52A3F0E91B34D300F481F9E37F5F0FECEA4 * L_3 = (WhereSelectListIterator_2_t1490C52A3F0E91B34D300F481F9E37F5F0FECEA4 *)il2cpp_codegen_object_new(IL2CPP_RGCTX_DATA(method->klass->rgctx_data, 2));
		((  void (*) (WhereSelectListIterator_2_t1490C52A3F0E91B34D300F481F9E37F5F0FECEA4 *, List_1_t260B41F956D673396C33A4CF94E8D6C4389EACB7 *, Func_2_t2EBF98B0BA555D9F0633C9BCCBE3DF332B9C1274 *, Func_2_t6C7618E0D575852E15D00A9E3CA463CE2CF5D159 *, const RuntimeMethod*))IL2CPP_RGCTX_METHOD_INFO(method->klass->rgctx_data, 3)->methodPointer)(L_3, (List_1_t260B41F956D673396C33A4CF94E8D6C4389EACB7 *)L_0, (Func_2_t2EBF98B0BA555D9F0633C9BCCBE3DF332B9C1274 *)L_1, (Func_2_t6C7618E0D575852E15D00A9E3CA463CE2CF5D159 *)L_2, /*hidden argument*/IL2CPP_RGCTX_METHOD_INFO(method->klass->rgctx_data, 3));
		return (Iterator_1_t75B26B5E87871854D759A25738CFE42AF131D6A8 *)L_3;
	}
}
// System.Boolean System.Linq.Enumerable/WhereSelectListIterator`2<System.Int32,System.Nullable`1<System.Double>>::MoveNext()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR bool WhereSelectListIterator_2_MoveNext_m75421E08E914CF261C87F960AF21826AF2F9CFC5_gshared (WhereSelectListIterator_2_t1490C52A3F0E91B34D300F481F9E37F5F0FECEA4 * __this, const RuntimeMethod* method)
{
	int32_t V_0 = 0;
	int32_t V_1 = 0;
	{
		int32_t L_0 = (int32_t)((Iterator_1_t75B26B5E87871854D759A25738CFE42AF131D6A8 *)__this)->get_state_1();
		V_0 = (int32_t)L_0;
		int32_t L_1 = V_0;
		if ((((int32_t)L_1) == ((int32_t)1)))
		{
			goto IL_0011;
		}
	}
	{
		int32_t L_2 = V_0;
		if ((((int32_t)L_2) == ((int32_t)2)))
		{
			goto IL_0061;
		}
	}
	{
		goto IL_0074;
	}

IL_0011:
	{
		List_1_t260B41F956D673396C33A4CF94E8D6C4389EACB7 * L_3 = (List_1_t260B41F956D673396C33A4CF94E8D6C4389EACB7 *)__this->get_source_3();
		NullCheck((List_1_t260B41F956D673396C33A4CF94E8D6C4389EACB7 *)L_3);
		Enumerator_t7BA00929E14A2F2A62CE085585044A3FEB2C5F3C  L_4;
		L_4 = ((  Enumerator_t7BA00929E14A2F2A62CE085585044A3FEB2C5F3C  (*) (List_1_t260B41F956D673396C33A4CF94E8D6C4389EACB7 *, const RuntimeMethod*))IL2CPP_RGCTX_METHOD_INFO(method->klass->rgctx_data, 4)->methodPointer)((List_1_t260B41F956D673396C33A4CF94E8D6C4389EACB7 *)L_3, /*hidden argument*/IL2CPP_RGCTX_METHOD_INFO(method->klass->rgctx_data, 4));
		__this->set_enumerator_6(L_4);
		((Iterator_1_t75B26B5E87871854D759A25738CFE42AF131D6A8 *)__this)->set_state_1(2);
		goto IL_0061;
	}

IL_002b:
	{
		Enumerator_t7BA00929E14A2F2A62CE085585044A3FEB2C5F3C * L_5 = (Enumerator_t7BA00929E14A2F2A62CE085585044A3FEB2C5F3C *)__this->get_address_of_enumerator_6();
		int32_t L_6;
		L_6 = Enumerator_get_Current_m6BBD624C51F7E20D347FE5894A6ECA94B8011181_inline((Enumerator_t7BA00929E14A2F2A62CE085585044A3FEB2C5F3C *)(Enumerator_t7BA00929E14A2F2A62CE085585044A3FEB2C5F3C *)L_5, /*hidden argument*/IL2CPP_RGCTX_METHOD_INFO(method->klass->rgctx_data, 5));
		V_1 = (int32_t)L_6;
		Func_2_t2EBF98B0BA555D9F0633C9BCCBE3DF332B9C1274 * L_7 = (Func_2_t2EBF98B0BA555D9F0633C9BCCBE3DF332B9C1274 *)__this->get_predicate_4();
		if (!L_7)
		{
			goto IL_004d;
		}
	}
	{
		Func_2_t2EBF98B0BA555D9F0633C9BCCBE3DF332B9C1274 * L_8 = (Func_2_t2EBF98B0BA555D9F0633C9BCCBE3DF332B9C1274 *)__this->get_predicate_4();
		int32_t L_9 = V_1;
		NullCheck((Func_2_t2EBF98B0BA555D9F0633C9BCCBE3DF332B9C1274 *)L_8);
		bool L_10;
		L_10 = ((  bool (*) (Func_2_t2EBF98B0BA555D9F0633C9BCCBE3DF332B9C1274 *, int32_t, const RuntimeMethod*))IL2CPP_RGCTX_METHOD_INFO(method->klass->rgctx_data, 6)->methodPointer)((Func_2_t2EBF98B0BA555D9F0633C9BCCBE3DF332B9C1274 *)L_8, (int32_t)L_9, /*hidden argument*/IL2CPP_RGCTX_METHOD_INFO(method->klass->rgctx_data, 6));
		if (!L_10)
		{
			goto IL_0061;
		}
	}

IL_004d:
	{
		Func_2_t6C7618E0D575852E15D00A9E3CA463CE2CF5D159 * L_11 = (Func_2_t6C7618E0D575852E15D00A9E3CA463CE2CF5D159 *)__this->get_selector_5();
		int32_t L_12 = V_1;
		NullCheck((Func_2_t6C7618E0D575852E15D00A9E3CA463CE2CF5D159 *)L_11);
		Nullable_1_t75730434CAD4E48A4EE117588CFD586FFBCAC209  L_13;
		L_13 = ((  Nullable_1_t75730434CAD4E48A4EE117588CFD586FFBCAC209  (*) (Func_2_t6C7618E0D575852E15D00A9E3CA463CE2CF5D159 *, int32_t, const RuntimeMethod*))IL2CPP_RGCTX_METHOD_INFO(method->klass->rgctx_data, 7)->methodPointer)((Func_2_t6C7618E0D575852E15D00A9E3CA463CE2CF5D159 *)L_11, (int32_t)L_12, /*hidden argument*/IL2CPP_RGCTX_METHOD_INFO(method->klass->rgctx_data, 7));
		((Iterator_1_t75B26B5E87871854D759A25738CFE42AF131D6A8 *)__this)->set_current_2(L_13);
		return (bool)1;
	}

IL_0061:
	{
		Enumerator_t7BA00929E14A2F2A62CE085585044A3FEB2C5F3C * L_14 = (Enumerator_t7BA00929E14A2F2A62CE085585044A3FEB2C5F3C *)__this->get_address_of_enumerator_6();
		bool L_15;
		L_15 = Enumerator_MoveNext_m40FD166B6757334A2BBCF67238EFDF70D727A4A6((Enumerator_t7BA00929E14A2F2A62CE085585044A3FEB2C5F3C *)(Enumerator_t7BA00929E14A2F2A62CE085585044A3FEB2C5F3C *)L_14, /*hidden argument*/IL2CPP_RGCTX_METHOD_INFO(method->klass->rgctx_data, 8));
		if (L_15)
		{
			goto IL_002b;
		}
	}
	{
		NullCheck((Iterator_1_t75B26B5E87871854D759A25738CFE42AF131D6A8 *)__this);
		VirtActionInvoker0::Invoke(12 /* System.Void System.Linq.Enumerable/Iterator`1<System.Nullable`1<System.Double>>::Dispose() */, (Iterator_1_t75B26B5E87871854D759A25738CFE42AF131D6A8 *)__this);
	}

IL_0074:
	{
		return (bool)0;
	}
}
// System.Collections.Generic.IEnumerable`1<TResult> System.Linq.Enumerable/WhereSelectListIterator`2<System.Int32,System.Nullable`1<System.Double>>::Where(System.Func`2<TResult,System.Boolean>)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR RuntimeObject* WhereSelectListIterator_2_Where_mE4B43205DE806D0B01D51A565DA21995FC9A86C2_gshared (WhereSelectListIterator_2_t1490C52A3F0E91B34D300F481F9E37F5F0FECEA4 * __this, Func_2_t4B7DAD120FE072A61F61F9158CB1013D6F95E130 * ___predicate0, const RuntimeMethod* method)
{
	{
		Func_2_t4B7DAD120FE072A61F61F9158CB1013D6F95E130 * L_0 = ___predicate0;
		WhereEnumerableIterator_1_t66C0068FA4DE078BBB4FF7511CF89C013E04A14D * L_1 = (WhereEnumerableIterator_1_t66C0068FA4DE078BBB4FF7511CF89C013E04A14D *)il2cpp_codegen_object_new(IL2CPP_RGCTX_DATA(method->klass->rgctx_data, 10));
		((  void (*) (WhereEnumerableIterator_1_t66C0068FA4DE078BBB4FF7511CF89C013E04A14D *, RuntimeObject*, Func_2_t4B7DAD120FE072A61F61F9158CB1013D6F95E130 *, const RuntimeMethod*))IL2CPP_RGCTX_METHOD_INFO(method->klass->rgctx_data, 11)->methodPointer)(L_1, (RuntimeObject*)__this, (Func_2_t4B7DAD120FE072A61F61F9158CB1013D6F95E130 *)L_0, /*hidden argument*/IL2CPP_RGCTX_METHOD_INFO(method->klass->rgctx_data, 11));
		return (RuntimeObject*)L_1;
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
// System.Void System.Linq.Enumerable/WhereSelectListIterator`2<System.Int32,System.Nullable`1<System.Int32>>::.ctor(System.Collections.Generic.List`1<TSource>,System.Func`2<TSource,System.Boolean>,System.Func`2<TSource,TResult>)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void WhereSelectListIterator_2__ctor_m3EBC4D89FF58494A88A7CF059803339BCA38CF85_gshared (WhereSelectListIterator_2_tDFB4A007D3032729411EC82D94FF3BD767D46B20 * __this, List_1_t260B41F956D673396C33A4CF94E8D6C4389EACB7 * ___source0, Func_2_t2EBF98B0BA555D9F0633C9BCCBE3DF332B9C1274 * ___predicate1, Func_2_t212214032B3E2E671F2871ED55DFBC92A4EBD9C3 * ___selector2, const RuntimeMethod* method)
{
	{
		NullCheck((Iterator_1_t88E927D3E5FC45C833C1A5146A04FBA17D02CA43 *)__this);
		((  void (*) (Iterator_1_t88E927D3E5FC45C833C1A5146A04FBA17D02CA43 *, const RuntimeMethod*))IL2CPP_RGCTX_METHOD_INFO(method->klass->rgctx_data, 0)->methodPointer)((Iterator_1_t88E927D3E5FC45C833C1A5146A04FBA17D02CA43 *)__this, /*hidden argument*/IL2CPP_RGCTX_METHOD_INFO(method->klass->rgctx_data, 0));
		List_1_t260B41F956D673396C33A4CF94E8D6C4389EACB7 * L_0 = ___source0;
		__this->set_source_3(L_0);
		Func_2_t2EBF98B0BA555D9F0633C9BCCBE3DF332B9C1274 * L_1 = ___predicate1;
		__this->set_predicate_4(L_1);
		Func_2_t212214032B3E2E671F2871ED55DFBC92A4EBD9C3 * L_2 = ___selector2;
		__this->set_selector_5(L_2);
		return;
	}
}
// System.Linq.Enumerable/Iterator`1<TResult> System.Linq.Enumerable/WhereSelectListIterator`2<System.Int32,System.Nullable`1<System.Int32>>::Clone()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR Iterator_1_t88E927D3E5FC45C833C1A5146A04FBA17D02CA43 * WhereSelectListIterator_2_Clone_m556CE9FA084DD8F32CD97413B77FF7BB4D00B631_gshared (WhereSelectListIterator_2_tDFB4A007D3032729411EC82D94FF3BD767D46B20 * __this, const RuntimeMethod* method)
{
	{
		List_1_t260B41F956D673396C33A4CF94E8D6C4389EACB7 * L_0 = (List_1_t260B41F956D673396C33A4CF94E8D6C4389EACB7 *)__this->get_source_3();
		Func_2_t2EBF98B0BA555D9F0633C9BCCBE3DF332B9C1274 * L_1 = (Func_2_t2EBF98B0BA555D9F0633C9BCCBE3DF332B9C1274 *)__this->get_predicate_4();
		Func_2_t212214032B3E2E671F2871ED55DFBC92A4EBD9C3 * L_2 = (Func_2_t212214032B3E2E671F2871ED55DFBC92A4EBD9C3 *)__this->get_selector_5();
		WhereSelectListIterator_2_tDFB4A007D3032729411EC82D94FF3BD767D46B20 * L_3 = (WhereSelectListIterator_2_tDFB4A007D3032729411EC82D94FF3BD767D46B20 *)il2cpp_codegen_object_new(IL2CPP_RGCTX_DATA(method->klass->rgctx_data, 2));
		((  void (*) (WhereSelectListIterator_2_tDFB4A007D3032729411EC82D94FF3BD767D46B20 *, List_1_t260B41F956D673396C33A4CF94E8D6C4389EACB7 *, Func_2_t2EBF98B0BA555D9F0633C9BCCBE3DF332B9C1274 *, Func_2_t212214032B3E2E671F2871ED55DFBC92A4EBD9C3 *, const RuntimeMethod*))IL2CPP_RGCTX_METHOD_INFO(method->klass->rgctx_data, 3)->methodPointer)(L_3, (List_1_t260B41F956D673396C33A4CF94E8D6C4389EACB7 *)L_0, (Func_2_t2EBF98B0BA555D9F0633C9BCCBE3DF332B9C1274 *)L_1, (Func_2_t212214032B3E2E671F2871ED55DFBC92A4EBD9C3 *)L_2, /*hidden argument*/IL2CPP_RGCTX_METHOD_INFO(method->klass->rgctx_data, 3));
		return (Iterator_1_t88E927D3E5FC45C833C1A5146A04FBA17D02CA43 *)L_3;
	}
}
// System.Boolean System.Linq.Enumerable/WhereSelectListIterator`2<System.Int32,System.Nullable`1<System.Int32>>::MoveNext()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR bool WhereSelectListIterator_2_MoveNext_mF1CA181361C202AF2BAF8DEA7DEF85DFF9D09AA3_gshared (WhereSelectListIterator_2_tDFB4A007D3032729411EC82D94FF3BD767D46B20 * __this, const RuntimeMethod* method)
{
	int32_t V_0 = 0;
	int32_t V_1 = 0;
	{
		int32_t L_0 = (int32_t)((Iterator_1_t88E927D3E5FC45C833C1A5146A04FBA17D02CA43 *)__this)->get_state_1();
		V_0 = (int32_t)L_0;
		int32_t L_1 = V_0;
		if ((((int32_t)L_1) == ((int32_t)1)))
		{
			goto IL_0011;
		}
	}
	{
		int32_t L_2 = V_0;
		if ((((int32_t)L_2) == ((int32_t)2)))
		{
			goto IL_0061;
		}
	}
	{
		goto IL_0074;
	}

IL_0011:
	{
		List_1_t260B41F956D673396C33A4CF94E8D6C4389EACB7 * L_3 = (List_1_t260B41F956D673396C33A4CF94E8D6C4389EACB7 *)__this->get_source_3();
		NullCheck((List_1_t260B41F956D673396C33A4CF94E8D6C4389EACB7 *)L_3);
		Enumerator_t7BA00929E14A2F2A62CE085585044A3FEB2C5F3C  L_4;
		L_4 = ((  Enumerator_t7BA00929E14A2F2A62CE085585044A3FEB2C5F3C  (*) (List_1_t260B41F956D673396C33A4CF94E8D6C4389EACB7 *, const RuntimeMethod*))IL2CPP_RGCTX_METHOD_INFO(method->klass->rgctx_data, 4)->methodPointer)((List_1_t260B41F956D673396C33A4CF94E8D6C4389EACB7 *)L_3, /*hidden argument*/IL2CPP_RGCTX_METHOD_INFO(method->klass->rgctx_data, 4));
		__this->set_enumerator_6(L_4);
		((Iterator_1_t88E927D3E5FC45C833C1A5146A04FBA17D02CA43 *)__this)->set_state_1(2);
		goto IL_0061;
	}

IL_002b:
	{
		Enumerator_t7BA00929E14A2F2A62CE085585044A3FEB2C5F3C * L_5 = (Enumerator_t7BA00929E14A2F2A62CE085585044A3FEB2C5F3C *)__this->get_address_of_enumerator_6();
		int32_t L_6;
		L_6 = Enumerator_get_Current_m6BBD624C51F7E20D347FE5894A6ECA94B8011181_inline((Enumerator_t7BA00929E14A2F2A62CE085585044A3FEB2C5F3C *)(Enumerator_t7BA00929E14A2F2A62CE085585044A3FEB2C5F3C *)L_5, /*hidden argument*/IL2CPP_RGCTX_METHOD_INFO(method->klass->rgctx_data, 5));
		V_1 = (int32_t)L_6;
		Func_2_t2EBF98B0BA555D9F0633C9BCCBE3DF332B9C1274 * L_7 = (Func_2_t2EBF98B0BA555D9F0633C9BCCBE3DF332B9C1274 *)__this->get_predicate_4();
		if (!L_7)
		{
			goto IL_004d;
		}
	}
	{
		Func_2_t2EBF98B0BA555D9F0633C9BCCBE3DF332B9C1274 * L_8 = (Func_2_t2EBF98B0BA555D9F0633C9BCCBE3DF332B9C1274 *)__this->get_predicate_4();
		int32_t L_9 = V_1;
		NullCheck((Func_2_t2EBF98B0BA555D9F0633C9BCCBE3DF332B9C1274 *)L_8);
		bool L_10;
		L_10 = ((  bool (*) (Func_2_t2EBF98B0BA555D9F0633C9BCCBE3DF332B9C1274 *, int32_t, const RuntimeMethod*))IL2CPP_RGCTX_METHOD_INFO(method->klass->rgctx_data, 6)->methodPointer)((Func_2_t2EBF98B0BA555D9F0633C9BCCBE3DF332B9C1274 *)L_8, (int32_t)L_9, /*hidden argument*/IL2CPP_RGCTX_METHOD_INFO(method->klass->rgctx_data, 6));
		if (!L_10)
		{
			goto IL_0061;
		}
	}

IL_004d:
	{
		Func_2_t212214032B3E2E671F2871ED55DFBC92A4EBD9C3 * L_11 = (Func_2_t212214032B3E2E671F2871ED55DFBC92A4EBD9C3 *)__this->get_selector_5();
		int32_t L_12 = V_1;
		NullCheck((Func_2_t212214032B3E2E671F2871ED55DFBC92A4EBD9C3 *)L_11);
		Nullable_1_t864FD0051A05D37F91C857AB496BFCB3FE756103  L_13;
		L_13 = ((  Nullable_1_t864FD0051A05D37F91C857AB496BFCB3FE756103  (*) (Func_2_t212214032B3E2E671F2871ED55DFBC92A4EBD9C3 *, int32_t, const RuntimeMethod*))IL2CPP_RGCTX_METHOD_INFO(method->klass->rgctx_data, 7)->methodPointer)((Func_2_t212214032B3E2E671F2871ED55DFBC92A4EBD9C3 *)L_11, (int32_t)L_12, /*hidden argument*/IL2CPP_RGCTX_METHOD_INFO(method->klass->rgctx_data, 7));
		((Iterator_1_t88E927D3E5FC45C833C1A5146A04FBA17D02CA43 *)__this)->set_current_2(L_13);
		return (bool)1;
	}

IL_0061:
	{
		Enumerator_t7BA00929E14A2F2A62CE085585044A3FEB2C5F3C * L_14 = (Enumerator_t7BA00929E14A2F2A62CE085585044A3FEB2C5F3C *)__this->get_address_of_enumerator_6();
		bool L_15;
		L_15 = Enumerator_MoveNext_m40FD166B6757334A2BBCF67238EFDF70D727A4A6((Enumerator_t7BA00929E14A2F2A62CE085585044A3FEB2C5F3C *)(Enumerator_t7BA00929E14A2F2A62CE085585044A3FEB2C5F3C *)L_14, /*hidden argument*/IL2CPP_RGCTX_METHOD_INFO(method->klass->rgctx_data, 8));
		if (L_15)
		{
			goto IL_002b;
		}
	}
	{
		NullCheck((Iterator_1_t88E927D3E5FC45C833C1A5146A04FBA17D02CA43 *)__this);
		VirtActionInvoker0::Invoke(12 /* System.Void System.Linq.Enumerable/Iterator`1<System.Nullable`1<System.Int32>>::Dispose() */, (Iterator_1_t88E927D3E5FC45C833C1A5146A04FBA17D02CA43 *)__this);
	}

IL_0074:
	{
		return (bool)0;
	}
}
// System.Collections.Generic.IEnumerable`1<TResult> System.Linq.Enumerable/WhereSelectListIterator`2<System.Int32,System.Nullable`1<System.Int32>>::Where(System.Func`2<TResult,System.Boolean>)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR RuntimeObject* WhereSelectListIterator_2_Where_m899B11DBE2DB8D6CA453266093C6FCB9F4D1A87C_gshared (WhereSelectListIterator_2_tDFB4A007D3032729411EC82D94FF3BD767D46B20 * __this, Func_2_t42993C24F11175D8FA98C3DB6E40DC467687C57D * ___predicate0, const RuntimeMethod* method)
{
	{
		Func_2_t42993C24F11175D8FA98C3DB6E40DC467687C57D * L_0 = ___predicate0;
		WhereEnumerableIterator_1_t1B1B27D3E99C914ABE052FAFE0F219BB76A0E566 * L_1 = (WhereEnumerableIterator_1_t1B1B27D3E99C914ABE052FAFE0F219BB76A0E566 *)il2cpp_codegen_object_new(IL2CPP_RGCTX_DATA(method->klass->rgctx_data, 10));
		((  void (*) (WhereEnumerableIterator_1_t1B1B27D3E99C914ABE052FAFE0F219BB76A0E566 *, RuntimeObject*, Func_2_t42993C24F11175D8FA98C3DB6E40DC467687C57D *, const RuntimeMethod*))IL2CPP_RGCTX_METHOD_INFO(method->klass->rgctx_data, 11)->methodPointer)(L_1, (RuntimeObject*)__this, (Func_2_t42993C24F11175D8FA98C3DB6E40DC467687C57D *)L_0, /*hidden argument*/IL2CPP_RGCTX_METHOD_INFO(method->klass->rgctx_data, 11));
		return (RuntimeObject*)L_1;
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
// System.Void System.Linq.Enumerable/WhereSelectListIterator`2<System.Int32,System.Nullable`1<System.Int64>>::.ctor(System.Collections.Generic.List`1<TSource>,System.Func`2<TSource,System.Boolean>,System.Func`2<TSource,TResult>)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void WhereSelectListIterator_2__ctor_mAF1A1F012784F580E2187FDB0F133AE4D3EA5ED4_gshared (WhereSelectListIterator_2_t976CDD198DB8AC61A9A22BA501F3C314F00E2C78 * __this, List_1_t260B41F956D673396C33A4CF94E8D6C4389EACB7 * ___source0, Func_2_t2EBF98B0BA555D9F0633C9BCCBE3DF332B9C1274 * ___predicate1, Func_2_tC286DBD1D3140BC4FC4D1DCF2D41DE03E72D8CAF * ___selector2, const RuntimeMethod* method)
{
	{
		NullCheck((Iterator_1_t7714579EDED47F91E8FBA7AF6D3F0674241FDF6C *)__this);
		((  void (*) (Iterator_1_t7714579EDED47F91E8FBA7AF6D3F0674241FDF6C *, const RuntimeMethod*))IL2CPP_RGCTX_METHOD_INFO(method->klass->rgctx_data, 0)->methodPointer)((Iterator_1_t7714579EDED47F91E8FBA7AF6D3F0674241FDF6C *)__this, /*hidden argument*/IL2CPP_RGCTX_METHOD_INFO(method->klass->rgctx_data, 0));
		List_1_t260B41F956D673396C33A4CF94E8D6C4389EACB7 * L_0 = ___source0;
		__this->set_source_3(L_0);
		Func_2_t2EBF98B0BA555D9F0633C9BCCBE3DF332B9C1274 * L_1 = ___predicate1;
		__this->set_predicate_4(L_1);
		Func_2_tC286DBD1D3140BC4FC4D1DCF2D41DE03E72D8CAF * L_2 = ___selector2;
		__this->set_selector_5(L_2);
		return;
	}
}
// System.Linq.Enumerable/Iterator`1<TResult> System.Linq.Enumerable/WhereSelectListIterator`2<System.Int32,System.Nullable`1<System.Int64>>::Clone()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR Iterator_1_t7714579EDED47F91E8FBA7AF6D3F0674241FDF6C * WhereSelectListIterator_2_Clone_m808283B10B46E302D785489E3A0C37C1C5BFFAFE_gshared (WhereSelectListIterator_2_t976CDD198DB8AC61A9A22BA501F3C314F00E2C78 * __this, const RuntimeMethod* method)
{
	{
		List_1_t260B41F956D673396C33A4CF94E8D6C4389EACB7 * L_0 = (List_1_t260B41F956D673396C33A4CF94E8D6C4389EACB7 *)__this->get_source_3();
		Func_2_t2EBF98B0BA555D9F0633C9BCCBE3DF332B9C1274 * L_1 = (Func_2_t2EBF98B0BA555D9F0633C9BCCBE3DF332B9C1274 *)__this->get_predicate_4();
		Func_2_tC286DBD1D3140BC4FC4D1DCF2D41DE03E72D8CAF * L_2 = (Func_2_tC286DBD1D3140BC4FC4D1DCF2D41DE03E72D8CAF *)__this->get_selector_5();
		WhereSelectListIterator_2_t976CDD198DB8AC61A9A22BA501F3C314F00E2C78 * L_3 = (WhereSelectListIterator_2_t976CDD198DB8AC61A9A22BA501F3C314F00E2C78 *)il2cpp_codegen_object_new(IL2CPP_RGCTX_DATA(method->klass->rgctx_data, 2));
		((  void (*) (WhereSelectListIterator_2_t976CDD198DB8AC61A9A22BA501F3C314F00E2C78 *, List_1_t260B41F956D673396C33A4CF94E8D6C4389EACB7 *, Func_2_t2EBF98B0BA555D9F0633C9BCCBE3DF332B9C1274 *, Func_2_tC286DBD1D3140BC4FC4D1DCF2D41DE03E72D8CAF *, const RuntimeMethod*))IL2CPP_RGCTX_METHOD_INFO(method->klass->rgctx_data, 3)->methodPointer)(L_3, (List_1_t260B41F956D673396C33A4CF94E8D6C4389EACB7 *)L_0, (Func_2_t2EBF98B0BA555D9F0633C9BCCBE3DF332B9C1274 *)L_1, (Func_2_tC286DBD1D3140BC4FC4D1DCF2D41DE03E72D8CAF *)L_2, /*hidden argument*/IL2CPP_RGCTX_METHOD_INFO(method->klass->rgctx_data, 3));
		return (Iterator_1_t7714579EDED47F91E8FBA7AF6D3F0674241FDF6C *)L_3;
	}
}
// System.Boolean System.Linq.Enumerable/WhereSelectListIterator`2<System.Int32,System.Nullable`1<System.Int64>>::MoveNext()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR bool WhereSelectListIterator_2_MoveNext_mC129EFA97C040CBDB8C5C3018EC729FCDDDB04AD_gshared (WhereSelectListIterator_2_t976CDD198DB8AC61A9A22BA501F3C314F00E2C78 * __this, const RuntimeMethod* method)
{
	int32_t V_0 = 0;
	int32_t V_1 = 0;
	{
		int32_t L_0 = (int32_t)((Iterator_1_t7714579EDED47F91E8FBA7AF6D3F0674241FDF6C *)__this)->get_state_1();
		V_0 = (int32_t)L_0;
		int32_t L_1 = V_0;
		if ((((int32_t)L_1) == ((int32_t)1)))
		{
			goto IL_0011;
		}
	}
	{
		int32_t L_2 = V_0;
		if ((((int32_t)L_2) == ((int32_t)2)))
		{
			goto IL_0061;
		}
	}
	{
		goto IL_0074;
	}

IL_0011:
	{
		List_1_t260B41F956D673396C33A4CF94E8D6C4389EACB7 * L_3 = (List_1_t260B41F956D673396C33A4CF94E8D6C4389EACB7 *)__this->get_source_3();
		NullCheck((List_1_t260B41F956D673396C33A4CF94E8D6C4389EACB7 *)L_3);
		Enumerator_t7BA00929E14A2F2A62CE085585044A3FEB2C5F3C  L_4;
		L_4 = ((  Enumerator_t7BA00929E14A2F2A62CE085585044A3FEB2C5F3C  (*) (List_1_t260B41F956D673396C33A4CF94E8D6C4389EACB7 *, const RuntimeMethod*))IL2CPP_RGCTX_METHOD_INFO(method->klass->rgctx_data, 4)->methodPointer)((List_1_t260B41F956D673396C33A4CF94E8D6C4389EACB7 *)L_3, /*hidden argument*/IL2CPP_RGCTX_METHOD_INFO(method->klass->rgctx_data, 4));
		__this->set_enumerator_6(L_4);
		((Iterator_1_t7714579EDED47F91E8FBA7AF6D3F0674241FDF6C *)__this)->set_state_1(2);
		goto IL_0061;
	}

IL_002b:
	{
		Enumerator_t7BA00929E14A2F2A62CE085585044A3FEB2C5F3C * L_5 = (Enumerator_t7BA00929E14A2F2A62CE085585044A3FEB2C5F3C *)__this->get_address_of_enumerator_6();
		int32_t L_6;
		L_6 = Enumerator_get_Current_m6BBD624C51F7E20D347FE5894A6ECA94B8011181_inline((Enumerator_t7BA00929E14A2F2A62CE085585044A3FEB2C5F3C *)(Enumerator_t7BA00929E14A2F2A62CE085585044A3FEB2C5F3C *)L_5, /*hidden argument*/IL2CPP_RGCTX_METHOD_INFO(method->klass->rgctx_data, 5));
		V_1 = (int32_t)L_6;
		Func_2_t2EBF98B0BA555D9F0633C9BCCBE3DF332B9C1274 * L_7 = (Func_2_t2EBF98B0BA555D9F0633C9BCCBE3DF332B9C1274 *)__this->get_predicate_4();
		if (!L_7)
		{
			goto IL_004d;
		}
	}
	{
		Func_2_t2EBF98B0BA555D9F0633C9BCCBE3DF332B9C1274 * L_8 = (Func_2_t2EBF98B0BA555D9F0633C9BCCBE3DF332B9C1274 *)__this->get_predicate_4();
		int32_t L_9 = V_1;
		NullCheck((Func_2_t2EBF98B0BA555D9F0633C9BCCBE3DF332B9C1274 *)L_8);
		bool L_10;
		L_10 = ((  bool (*) (Func_2_t2EBF98B0BA555D9F0633C9BCCBE3DF332B9C1274 *, int32_t, const RuntimeMethod*))IL2CPP_RGCTX_METHOD_INFO(method->klass->rgctx_data, 6)->methodPointer)((Func_2_t2EBF98B0BA555D9F0633C9BCCBE3DF332B9C1274 *)L_8, (int32_t)L_9, /*hidden argument*/IL2CPP_RGCTX_METHOD_INFO(method->klass->rgctx_data, 6));
		if (!L_10)
		{
			goto IL_0061;
		}
	}

IL_004d:
	{
		Func_2_tC286DBD1D3140BC4FC4D1DCF2D41DE03E72D8CAF * L_11 = (Func_2_tC286DBD1D3140BC4FC4D1DCF2D41DE03E72D8CAF *)__this->get_selector_5();
		int32_t L_12 = V_1;
		NullCheck((Func_2_tC286DBD1D3140BC4FC4D1DCF2D41DE03E72D8CAF *)L_11);
		Nullable_1_t340361C8134256120F5769AC5A3F743DB6C11D1F  L_13;
		L_13 = ((  Nullable_1_t340361C8134256120F5769AC5A3F743DB6C11D1F  (*) (Func_2_tC286DBD1D3140BC4FC4D1DCF2D41DE03E72D8CAF *, int32_t, const RuntimeMethod*))IL2CPP_RGCTX_METHOD_INFO(method->klass->rgctx_data, 7)->methodPointer)((Func_2_tC286DBD1D3140BC4FC4D1DCF2D41DE03E72D8CAF *)L_11, (int32_t)L_12, /*hidden argument*/IL2CPP_RGCTX_METHOD_INFO(method->klass->rgctx_data, 7));
		((Iterator_1_t7714579EDED47F91E8FBA7AF6D3F0674241FDF6C *)__this)->set_current_2(L_13);
		return (bool)1;
	}

IL_0061:
	{
		Enumerator_t7BA00929E14A2F2A62CE085585044A3FEB2C5F3C * L_14 = (Enumerator_t7BA00929E14A2F2A62CE085585044A3FEB2C5F3C *)__this->get_address_of_enumerator_6();
		bool L_15;
		L_15 = Enumerator_MoveNext_m40FD166B6757334A2BBCF67238EFDF70D727A4A6((Enumerator_t7BA00929E14A2F2A62CE085585044A3FEB2C5F3C *)(Enumerator_t7BA00929E14A2F2A62CE085585044A3FEB2C5F3C *)L_14, /*hidden argument*/IL2CPP_RGCTX_METHOD_INFO(method->klass->rgctx_data, 8));
		if (L_15)
		{
			goto IL_002b;
		}
	}
	{
		NullCheck((Iterator_1_t7714579EDED47F91E8FBA7AF6D3F0674241FDF6C *)__this);
		VirtActionInvoker0::Invoke(12 /* System.Void System.Linq.Enumerable/Iterator`1<System.Nullable`1<System.Int64>>::Dispose() */, (Iterator_1_t7714579EDED47F91E8FBA7AF6D3F0674241FDF6C *)__this);
	}

IL_0074:
	{
		return (bool)0;
	}
}
// System.Collections.Generic.IEnumerable`1<TResult> System.Linq.Enumerable/WhereSelectListIterator`2<System.Int32,System.Nullable`1<System.Int64>>::Where(System.Func`2<TResult,System.Boolean>)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR RuntimeObject* WhereSelectListIterator_2_Where_mAA483D50C01CF4663F581CEA4E84A8616FB9D70D_gshared (WhereSelectListIterator_2_t976CDD198DB8AC61A9A22BA501F3C314F00E2C78 * __this, Func_2_t1637E276420B054B58108E2AD51B1537DEC785D9 * ___predicate0, const RuntimeMethod* method)
{
	{
		Func_2_t1637E276420B054B58108E2AD51B1537DEC785D9 * L_0 = ___predicate0;
		WhereEnumerableIterator_1_t0354BCB72E2636F60E4B00786DDDE24A1EA42885 * L_1 = (WhereEnumerableIterator_1_t0354BCB72E2636F60E4B00786DDDE24A1EA42885 *)il2cpp_codegen_object_new(IL2CPP_RGCTX_DATA(method->klass->rgctx_data, 10));
		((  void (*) (WhereEnumerableIterator_1_t0354BCB72E2636F60E4B00786DDDE24A1EA42885 *, RuntimeObject*, Func_2_t1637E276420B054B58108E2AD51B1537DEC785D9 *, const RuntimeMethod*))IL2CPP_RGCTX_METHOD_INFO(method->klass->rgctx_data, 11)->methodPointer)(L_1, (RuntimeObject*)__this, (Func_2_t1637E276420B054B58108E2AD51B1537DEC785D9 *)L_0, /*hidden argument*/IL2CPP_RGCTX_METHOD_INFO(method->klass->rgctx_data, 11));
		return (RuntimeObject*)L_1;
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
// System.Void System.Linq.Enumerable/WhereSelectListIterator`2<System.Int32,System.Nullable`1<System.Single>>::.ctor(System.Collections.Generic.List`1<TSource>,System.Func`2<TSource,System.Boolean>,System.Func`2<TSource,TResult>)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void WhereSelectListIterator_2__ctor_mE7833450DF4F1C306264D443153442D33BC5A383_gshared (WhereSelectListIterator_2_tACE6C37EC1B04DF78ECD3C22632AB334307C46DB * __this, List_1_t260B41F956D673396C33A4CF94E8D6C4389EACB7 * ___source0, Func_2_t2EBF98B0BA555D9F0633C9BCCBE3DF332B9C1274 * ___predicate1, Func_2_t6663A9FD2A53E3B599DF99EC970BF2320E8D9D40 * ___selector2, const RuntimeMethod* method)
{
	{
		NullCheck((Iterator_1_t5F8CC81E7DD3167D5EC5BFC0984EBCEE64F5B45E *)__this);
		((  void (*) (Iterator_1_t5F8CC81E7DD3167D5EC5BFC0984EBCEE64F5B45E *, const RuntimeMethod*))IL2CPP_RGCTX_METHOD_INFO(method->klass->rgctx_data, 0)->methodPointer)((Iterator_1_t5F8CC81E7DD3167D5EC5BFC0984EBCEE64F5B45E *)__this, /*hidden argument*/IL2CPP_RGCTX_METHOD_INFO(method->klass->rgctx_data, 0));
		List_1_t260B41F956D673396C33A4CF94E8D6C4389EACB7 * L_0 = ___source0;
		__this->set_source_3(L_0);
		Func_2_t2EBF98B0BA555D9F0633C9BCCBE3DF332B9C1274 * L_1 = ___predicate1;
		__this->set_predicate_4(L_1);
		Func_2_t6663A9FD2A53E3B599DF99EC970BF2320E8D9D40 * L_2 = ___selector2;
		__this->set_selector_5(L_2);
		return;
	}
}
// System.Linq.Enumerable/Iterator`1<TResult> System.Linq.Enumerable/WhereSelectListIterator`2<System.Int32,System.Nullable`1<System.Single>>::Clone()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR Iterator_1_t5F8CC81E7DD3167D5EC5BFC0984EBCEE64F5B45E * WhereSelectListIterator_2_Clone_m47BE5B2065F2C42785C83B707D8FBFD66D6A0533_gshared (WhereSelectListIterator_2_tACE6C37EC1B04DF78ECD3C22632AB334307C46DB * __this, const RuntimeMethod* method)
{
	{
		List_1_t260B41F956D673396C33A4CF94E8D6C4389EACB7 * L_0 = (List_1_t260B41F956D673396C33A4CF94E8D6C4389EACB7 *)__this->get_source_3();
		Func_2_t2EBF98B0BA555D9F0633C9BCCBE3DF332B9C1274 * L_1 = (Func_2_t2EBF98B0BA555D9F0633C9BCCBE3DF332B9C1274 *)__this->get_predicate_4();
		Func_2_t6663A9FD2A53E3B599DF99EC970BF2320E8D9D40 * L_2 = (Func_2_t6663A9FD2A53E3B599DF99EC970BF2320E8D9D40 *)__this->get_selector_5();
		WhereSelectListIterator_2_tACE6C37EC1B04DF78ECD3C22632AB334307C46DB * L_3 = (WhereSelectListIterator_2_tACE6C37EC1B04DF78ECD3C22632AB334307C46DB *)il2cpp_codegen_object_new(IL2CPP_RGCTX_DATA(method->klass->rgctx_data, 2));
		((  void (*) (WhereSelectListIterator_2_tACE6C37EC1B04DF78ECD3C22632AB334307C46DB *, List_1_t260B41F956D673396C33A4CF94E8D6C4389EACB7 *, Func_2_t2EBF98B0BA555D9F0633C9BCCBE3DF332B9C1274 *, Func_2_t6663A9FD2A53E3B599DF99EC970BF2320E8D9D40 *, const RuntimeMethod*))IL2CPP_RGCTX_METHOD_INFO(method->klass->rgctx_data, 3)->methodPointer)(L_3, (List_1_t260B41F956D673396C33A4CF94E8D6C4389EACB7 *)L_0, (Func_2_t2EBF98B0BA555D9F0633C9BCCBE3DF332B9C1274 *)L_1, (Func_2_t6663A9FD2A53E3B599DF99EC970BF2320E8D9D40 *)L_2, /*hidden argument*/IL2CPP_RGCTX_METHOD_INFO(method->klass->rgctx_data, 3));
		return (Iterator_1_t5F8CC81E7DD3167D5EC5BFC0984EBCEE64F5B45E *)L_3;
	}
}
// System.Boolean System.Linq.Enumerable/WhereSelectListIterator`2<System.Int32,System.Nullable`1<System.Single>>::MoveNext()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR bool WhereSelectListIterator_2_MoveNext_m5039D2D78E88726885F879BD055208A3B7967D6F_gshared (WhereSelectListIterator_2_tACE6C37EC1B04DF78ECD3C22632AB334307C46DB * __this, const RuntimeMethod* method)
{
	int32_t V_0 = 0;
	int32_t V_1 = 0;
	{
		int32_t L_0 = (int32_t)((Iterator_1_t5F8CC81E7DD3167D5EC5BFC0984EBCEE64F5B45E *)__this)->get_state_1();
		V_0 = (int32_t)L_0;
		int32_t L_1 = V_0;
		if ((((int32_t)L_1) == ((int32_t)1)))
		{
			goto IL_0011;
		}
	}
	{
		int32_t L_2 = V_0;
		if ((((int32_t)L_2) == ((int32_t)2)))
		{
			goto IL_0061;
		}
	}
	{
		goto IL_0074;
	}

IL_0011:
	{
		List_1_t260B41F956D673396C33A4CF94E8D6C4389EACB7 * L_3 = (List_1_t260B41F956D673396C33A4CF94E8D6C4389EACB7 *)__this->get_source_3();
		NullCheck((List_1_t260B41F956D673396C33A4CF94E8D6C4389EACB7 *)L_3);
		Enumerator_t7BA00929E14A2F2A62CE085585044A3FEB2C5F3C  L_4;
		L_4 = ((  Enumerator_t7BA00929E14A2F2A62CE085585044A3FEB2C5F3C  (*) (List_1_t260B41F956D673396C33A4CF94E8D6C4389EACB7 *, const RuntimeMethod*))IL2CPP_RGCTX_METHOD_INFO(method->klass->rgctx_data, 4)->methodPointer)((List_1_t260B41F956D673396C33A4CF94E8D6C4389EACB7 *)L_3, /*hidden argument*/IL2CPP_RGCTX_METHOD_INFO(method->klass->rgctx_data, 4));
		__this->set_enumerator_6(L_4);
		((Iterator_1_t5F8CC81E7DD3167D5EC5BFC0984EBCEE64F5B45E *)__this)->set_state_1(2);
		goto IL_0061;
	}

IL_002b:
	{
		Enumerator_t7BA00929E14A2F2A62CE085585044A3FEB2C5F3C * L_5 = (Enumerator_t7BA00929E14A2F2A62CE085585044A3FEB2C5F3C *)__this->get_address_of_enumerator_6();
		int32_t L_6;
		L_6 = Enumerator_get_Current_m6BBD624C51F7E20D347FE5894A6ECA94B8011181_inline((Enumerator_t7BA00929E14A2F2A62CE085585044A3FEB2C5F3C *)(Enumerator_t7BA00929E14A2F2A62CE085585044A3FEB2C5F3C *)L_5, /*hidden argument*/IL2CPP_RGCTX_METHOD_INFO(method->klass->rgctx_data, 5));
		V_1 = (int32_t)L_6;
		Func_2_t2EBF98B0BA555D9F0633C9BCCBE3DF332B9C1274 * L_7 = (Func_2_t2EBF98B0BA555D9F0633C9BCCBE3DF332B9C1274 *)__this->get_predicate_4();
		if (!L_7)
		{
			goto IL_004d;
		}
	}
	{
		Func_2_t2EBF98B0BA555D9F0633C9BCCBE3DF332B9C1274 * L_8 = (Func_2_t2EBF98B0BA555D9F0633C9BCCBE3DF332B9C1274 *)__this->get_predicate_4();
		int32_t L_9 = V_1;
		NullCheck((Func_2_t2EBF98B0BA555D9F0633C9BCCBE3DF332B9C1274 *)L_8);
		bool L_10;
		L_10 = ((  bool (*) (Func_2_t2EBF98B0BA555D9F0633C9BCCBE3DF332B9C1274 *, int32_t, const RuntimeMethod*))IL2CPP_RGCTX_METHOD_INFO(method->klass->rgctx_data, 6)->methodPointer)((Func_2_t2EBF98B0BA555D9F0633C9BCCBE3DF332B9C1274 *)L_8, (int32_t)L_9, /*hidden argument*/IL2CPP_RGCTX_METHOD_INFO(method->klass->rgctx_data, 6));
		if (!L_10)
		{
			goto IL_0061;
		}
	}

IL_004d:
	{
		Func_2_t6663A9FD2A53E3B599DF99EC970BF2320E8D9D40 * L_11 = (Func_2_t6663A9FD2A53E3B599DF99EC970BF2320E8D9D40 *)__this->get_selector_5();
		int32_t L_12 = V_1;
		NullCheck((Func_2_t6663A9FD2A53E3B599DF99EC970BF2320E8D9D40 *)L_11);
		Nullable_1_t0C4AC2E457C437FA106160547FD9BA5B50B1888A  L_13;
		L_13 = ((  Nullable_1_t0C4AC2E457C437FA106160547FD9BA5B50B1888A  (*) (Func_2_t6663A9FD2A53E3B599DF99EC970BF2320E8D9D40 *, int32_t, const RuntimeMethod*))IL2CPP_RGCTX_METHOD_INFO(method->klass->rgctx_data, 7)->methodPointer)((Func_2_t6663A9FD2A53E3B599DF99EC970BF2320E8D9D40 *)L_11, (int32_t)L_12, /*hidden argument*/IL2CPP_RGCTX_METHOD_INFO(method->klass->rgctx_data, 7));
		((Iterator_1_t5F8CC81E7DD3167D5EC5BFC0984EBCEE64F5B45E *)__this)->set_current_2(L_13);
		return (bool)1;
	}

IL_0061:
	{
		Enumerator_t7BA00929E14A2F2A62CE085585044A3FEB2C5F3C * L_14 = (Enumerator_t7BA00929E14A2F2A62CE085585044A3FEB2C5F3C *)__this->get_address_of_enumerator_6();
		bool L_15;
		L_15 = Enumerator_MoveNext_m40FD166B6757334A2BBCF67238EFDF70D727A4A6((Enumerator_t7BA00929E14A2F2A62CE085585044A3FEB2C5F3C *)(Enumerator_t7BA00929E14A2F2A62CE085585044A3FEB2C5F3C *)L_14, /*hidden argument*/IL2CPP_RGCTX_METHOD_INFO(method->klass->rgctx_data, 8));
		if (L_15)
		{
			goto IL_002b;
		}
	}
	{
		NullCheck((Iterator_1_t5F8CC81E7DD3167D5EC5BFC0984EBCEE64F5B45E *)__this);
		VirtActionInvoker0::Invoke(12 /* System.Void System.Linq.Enumerable/Iterator`1<System.Nullable`1<System.Single>>::Dispose() */, (Iterator_1_t5F8CC81E7DD3167D5EC5BFC0984EBCEE64F5B45E *)__this);
	}

IL_0074:
	{
		return (bool)0;
	}
}
// System.Collections.Generic.IEnumerable`1<TResult> System.Linq.Enumerable/WhereSelectListIterator`2<System.Int32,System.Nullable`1<System.Single>>::Where(System.Func`2<TResult,System.Boolean>)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR RuntimeObject* WhereSelectListIterator_2_Where_m0CAAA4757AF7039353271721220CD1DC6DAA1EFD_gshared (WhereSelectListIterator_2_tACE6C37EC1B04DF78ECD3C22632AB334307C46DB * __this, Func_2_t9B3CA7186DE9A33B978124F5B7131DD16456B41A * ___predicate0, const RuntimeMethod* method)
{
	{
		Func_2_t9B3CA7186DE9A33B978124F5B7131DD16456B41A * L_0 = ___predicate0;
		WhereEnumerableIterator_1_tEA993B6947A5D38439F1B98DAAA3D3EE22BAF126 * L_1 = (WhereEnumerableIterator_1_tEA993B6947A5D38439F1B98DAAA3D3EE22BAF126 *)il2cpp_codegen_object_new(IL2CPP_RGCTX_DATA(method->klass->rgctx_data, 10));
		((  void (*) (WhereEnumerableIterator_1_tEA993B6947A5D38439F1B98DAAA3D3EE22BAF126 *, RuntimeObject*, Func_2_t9B3CA7186DE9A33B978124F5B7131DD16456B41A *, const RuntimeMethod*))IL2CPP_RGCTX_METHOD_INFO(method->klass->rgctx_data, 11)->methodPointer)(L_1, (RuntimeObject*)__this, (Func_2_t9B3CA7186DE9A33B978124F5B7131DD16456B41A *)L_0, /*hidden argument*/IL2CPP_RGCTX_METHOD_INFO(method->klass->rgctx_data, 11));
		return (RuntimeObject*)L_1;
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
// System.Void System.Linq.Enumerable/WhereSelectListIterator`2<System.Int32,System.Boolean>::.ctor(System.Collections.Generic.List`1<TSource>,System.Func`2<TSource,System.Boolean>,System.Func`2<TSource,TResult>)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void WhereSelectListIterator_2__ctor_mB5D8932742054FB1AEA4CB7E088013CCCC52F511_gshared (WhereSelectListIterator_2_t2989AC7E9CA6D1FB0231FD52E44E7AFC843ACA21 * __this, List_1_t260B41F956D673396C33A4CF94E8D6C4389EACB7 * ___source0, Func_2_t2EBF98B0BA555D9F0633C9BCCBE3DF332B9C1274 * ___predicate1, Func_2_t2EBF98B0BA555D9F0633C9BCCBE3DF332B9C1274 * ___selector2, const RuntimeMethod* method)
{
	{
		NullCheck((Iterator_1_tF558BC64630CA9038F999F5A16CC3DD5A0DB6933 *)__this);
		((  void (*) (Iterator_1_tF558BC64630CA9038F999F5A16CC3DD5A0DB6933 *, const RuntimeMethod*))IL2CPP_RGCTX_METHOD_INFO(method->klass->rgctx_data, 0)->methodPointer)((Iterator_1_tF558BC64630CA9038F999F5A16CC3DD5A0DB6933 *)__this, /*hidden argument*/IL2CPP_RGCTX_METHOD_INFO(method->klass->rgctx_data, 0));
		List_1_t260B41F956D673396C33A4CF94E8D6C4389EACB7 * L_0 = ___source0;
		__this->set_source_3(L_0);
		Func_2_t2EBF98B0BA555D9F0633C9BCCBE3DF332B9C1274 * L_1 = ___predicate1;
		__this->set_predicate_4(L_1);
		Func_2_t2EBF98B0BA555D9F0633C9BCCBE3DF332B9C1274 * L_2 = ___selector2;
		__this->set_selector_5(L_2);
		return;
	}
}
// System.Linq.Enumerable/Iterator`1<TResult> System.Linq.Enumerable/WhereSelectListIterator`2<System.Int32,System.Boolean>::Clone()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR Iterator_1_tF558BC64630CA9038F999F5A16CC3DD5A0DB6933 * WhereSelectListIterator_2_Clone_m615E9B0DB6684CAC150EE7AB0A4CD1FBB9B788B1_gshared (WhereSelectListIterator_2_t2989AC7E9CA6D1FB0231FD52E44E7AFC843ACA21 * __this, const RuntimeMethod* method)
{
	{
		List_1_t260B41F956D673396C33A4CF94E8D6C4389EACB7 * L_0 = (List_1_t260B41F956D673396C33A4CF94E8D6C4389EACB7 *)__this->get_source_3();
		Func_2_t2EBF98B0BA555D9F0633C9BCCBE3DF332B9C1274 * L_1 = (Func_2_t2EBF98B0BA555D9F0633C9BCCBE3DF332B9C1274 *)__this->get_predicate_4();
		Func_2_t2EBF98B0BA555D9F0633C9BCCBE3DF332B9C1274 * L_2 = (Func_2_t2EBF98B0BA555D9F0633C9BCCBE3DF332B9C1274 *)__this->get_selector_5();
		WhereSelectListIterator_2_t2989AC7E9CA6D1FB0231FD52E44E7AFC843ACA21 * L_3 = (WhereSelectListIterator_2_t2989AC7E9CA6D1FB0231FD52E44E7AFC843ACA21 *)il2cpp_codegen_object_new(IL2CPP_RGCTX_DATA(method->klass->rgctx_data, 2));
		((  void (*) (WhereSelectListIterator_2_t2989AC7E9CA6D1FB0231FD52E44E7AFC843ACA21 *, List_1_t260B41F956D673396C33A4CF94E8D6C4389EACB7 *, Func_2_t2EBF98B0BA555D9F0633C9BCCBE3DF332B9C1274 *, Func_2_t2EBF98B0BA555D9F0633C9BCCBE3DF332B9C1274 *, const RuntimeMethod*))IL2CPP_RGCTX_METHOD_INFO(method->klass->rgctx_data, 3)->methodPointer)(L_3, (List_1_t260B41F956D673396C33A4CF94E8D6C4389EACB7 *)L_0, (Func_2_t2EBF98B0BA555D9F0633C9BCCBE3DF332B9C1274 *)L_1, (Func_2_t2EBF98B0BA555D9F0633C9BCCBE3DF332B9C1274 *)L_2, /*hidden argument*/IL2CPP_RGCTX_METHOD_INFO(method->klass->rgctx_data, 3));
		return (Iterator_1_tF558BC64630CA9038F999F5A16CC3DD5A0DB6933 *)L_3;
	}
}
// System.Boolean System.Linq.Enumerable/WhereSelectListIterator`2<System.Int32,System.Boolean>::MoveNext()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR bool WhereSelectListIterator_2_MoveNext_m86C1EBD7AC602F954B3461FEBB5BC7E03007FC6C_gshared (WhereSelectListIterator_2_t2989AC7E9CA6D1FB0231FD52E44E7AFC843ACA21 * __this, const RuntimeMethod* method)
{
	int32_t V_0 = 0;
	int32_t V_1 = 0;
	{
		int32_t L_0 = (int32_t)((Iterator_1_tF558BC64630CA9038F999F5A16CC3DD5A0DB6933 *)__this)->get_state_1();
		V_0 = (int32_t)L_0;
		int32_t L_1 = V_0;
		if ((((int32_t)L_1) == ((int32_t)1)))
		{
			goto IL_0011;
		}
	}
	{
		int32_t L_2 = V_0;
		if ((((int32_t)L_2) == ((int32_t)2)))
		{
			goto IL_0061;
		}
	}
	{
		goto IL_0074;
	}

IL_0011:
	{
		List_1_t260B41F956D673396C33A4CF94E8D6C4389EACB7 * L_3 = (List_1_t260B41F956D673396C33A4CF94E8D6C4389EACB7 *)__this->get_source_3();
		NullCheck((List_1_t260B41F956D673396C33A4CF94E8D6C4389EACB7 *)L_3);
		Enumerator_t7BA00929E14A2F2A62CE085585044A3FEB2C5F3C  L_4;
		L_4 = ((  Enumerator_t7BA00929E14A2F2A62CE085585044A3FEB2C5F3C  (*) (List_1_t260B41F956D673396C33A4CF94E8D6C4389EACB7 *, const RuntimeMethod*))IL2CPP_RGCTX_METHOD_INFO(method->klass->rgctx_data, 4)->methodPointer)((List_1_t260B41F956D673396C33A4CF94E8D6C4389EACB7 *)L_3, /*hidden argument*/IL2CPP_RGCTX_METHOD_INFO(method->klass->rgctx_data, 4));
		__this->set_enumerator_6(L_4);
		((Iterator_1_tF558BC64630CA9038F999F5A16CC3DD5A0DB6933 *)__this)->set_state_1(2);
		goto IL_0061;
	}

IL_002b:
	{
		Enumerator_t7BA00929E14A2F2A62CE085585044A3FEB2C5F3C * L_5 = (Enumerator_t7BA00929E14A2F2A62CE085585044A3FEB2C5F3C *)__this->get_address_of_enumerator_6();
		int32_t L_6;
		L_6 = Enumerator_get_Current_m6BBD624C51F7E20D347FE5894A6ECA94B8011181_inline((Enumerator_t7BA00929E14A2F2A62CE085585044A3FEB2C5F3C *)(Enumerator_t7BA00929E14A2F2A62CE085585044A3FEB2C5F3C *)L_5, /*hidden argument*/IL2CPP_RGCTX_METHOD_INFO(method->klass->rgctx_data, 5));
		V_1 = (int32_t)L_6;
		Func_2_t2EBF98B0BA555D9F0633C9BCCBE3DF332B9C1274 * L_7 = (Func_2_t2EBF98B0BA555D9F0633C9BCCBE3DF332B9C1274 *)__this->get_predicate_4();
		if (!L_7)
		{
			goto IL_004d;
		}
	}
	{
		Func_2_t2EBF98B0BA555D9F0633C9BCCBE3DF332B9C1274 * L_8 = (Func_2_t2EBF98B0BA555D9F0633C9BCCBE3DF332B9C1274 *)__this->get_predicate_4();
		int32_t L_9 = V_1;
		NullCheck((Func_2_t2EBF98B0BA555D9F0633C9BCCBE3DF332B9C1274 *)L_8);
		bool L_10;
		L_10 = ((  bool (*) (Func_2_t2EBF98B0BA555D9F0633C9BCCBE3DF332B9C1274 *, int32_t, const RuntimeMethod*))IL2CPP_RGCTX_METHOD_INFO(method->klass->rgctx_data, 6)->methodPointer)((Func_2_t2EBF98B0BA555D9F0633C9BCCBE3DF332B9C1274 *)L_8, (int32_t)L_9, /*hidden argument*/IL2CPP_RGCTX_METHOD_INFO(method->klass->rgctx_data, 6));
		if (!L_10)
		{
			goto IL_0061;
		}
	}

IL_004d:
	{
		Func_2_t2EBF98B0BA555D9F0633C9BCCBE3DF332B9C1274 * L_11 = (Func_2_t2EBF98B0BA555D9F0633C9BCCBE3DF332B9C1274 *)__this->get_selector_5();
		int32_t L_12 = V_1;
		NullCheck((Func_2_t2EBF98B0BA555D9F0633C9BCCBE3DF332B9C1274 *)L_11);
		bool L_13;
		L_13 = ((  bool (*) (Func_2_t2EBF98B0BA555D9F0633C9BCCBE3DF332B9C1274 *, int32_t, const RuntimeMethod*))IL2CPP_RGCTX_METHOD_INFO(method->klass->rgctx_data, 7)->methodPointer)((Func_2_t2EBF98B0BA555D9F0633C9BCCBE3DF332B9C1274 *)L_11, (int32_t)L_12, /*hidden argument*/IL2CPP_RGCTX_METHOD_INFO(method->klass->rgctx_data, 7));
		((Iterator_1_tF558BC64630CA9038F999F5A16CC3DD5A0DB6933 *)__this)->set_current_2(L_13);
		return (bool)1;
	}

IL_0061:
	{
		Enumerator_t7BA00929E14A2F2A62CE085585044A3FEB2C5F3C * L_14 = (Enumerator_t7BA00929E14A2F2A62CE085585044A3FEB2C5F3C *)__this->get_address_of_enumerator_6();
		bool L_15;
		L_15 = Enumerator_MoveNext_m40FD166B6757334A2BBCF67238EFDF70D727A4A6((Enumerator_t7BA00929E14A2F2A62CE085585044A3FEB2C5F3C *)(Enumerator_t7BA00929E14A2F2A62CE085585044A3FEB2C5F3C *)L_14, /*hidden argument*/IL2CPP_RGCTX_METHOD_INFO(method->klass->rgctx_data, 8));
		if (L_15)
		{
			goto IL_002b;
		}
	}
	{
		NullCheck((Iterator_1_tF558BC64630CA9038F999F5A16CC3DD5A0DB6933 *)__this);
		VirtActionInvoker0::Invoke(12 /* System.Void System.Linq.Enumerable/Iterator`1<System.Boolean>::Dispose() */, (Iterator_1_tF558BC64630CA9038F999F5A16CC3DD5A0DB6933 *)__this);
	}

IL_0074:
	{
		return (bool)0;
	}
}
// System.Collections.Generic.IEnumerable`1<TResult> System.Linq.Enumerable/WhereSelectListIterator`2<System.Int32,System.Boolean>::Where(System.Func`2<TResult,System.Boolean>)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR RuntimeObject* WhereSelectListIterator_2_Where_mD7CF6F8783B4A96355DFD4C1C9115169244B9228_gshared (WhereSelectListIterator_2_t2989AC7E9CA6D1FB0231FD52E44E7AFC843ACA21 * __this, Func_2_t50F598941CFDF02619DC5D52FFDBC329473C5F7B * ___predicate0, const RuntimeMethod* method)
{
	{
		Func_2_t50F598941CFDF02619DC5D52FFDBC329473C5F7B * L_0 = ___predicate0;
		WhereEnumerableIterator_1_t3A84EA4A91D206312F2931E2BC9124FFF81BFE22 * L_1 = (WhereEnumerableIterator_1_t3A84EA4A91D206312F2931E2BC9124FFF81BFE22 *)il2cpp_codegen_object_new(IL2CPP_RGCTX_DATA(method->klass->rgctx_data, 10));
		((  void (*) (WhereEnumerableIterator_1_t3A84EA4A91D206312F2931E2BC9124FFF81BFE22 *, RuntimeObject*, Func_2_t50F598941CFDF02619DC5D52FFDBC329473C5F7B *, const RuntimeMethod*))IL2CPP_RGCTX_METHOD_INFO(method->klass->rgctx_data, 11)->methodPointer)(L_1, (RuntimeObject*)__this, (Func_2_t50F598941CFDF02619DC5D52FFDBC329473C5F7B *)L_0, /*hidden argument*/IL2CPP_RGCTX_METHOD_INFO(method->klass->rgctx_data, 11));
		return (RuntimeObject*)L_1;
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
// System.Void System.Linq.Enumerable/WhereSelectListIterator`2<System.Int32,System.Decimal>::.ctor(System.Collections.Generic.List`1<TSource>,System.Func`2<TSource,System.Boolean>,System.Func`2<TSource,TResult>)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void WhereSelectListIterator_2__ctor_m747995C4F15DDB291ED479CFDDA30417BA59EB7C_gshared (WhereSelectListIterator_2_t2EBF84FB2CE39E9E5B9DD3AC4C33E4F0D6142BBC * __this, List_1_t260B41F956D673396C33A4CF94E8D6C4389EACB7 * ___source0, Func_2_t2EBF98B0BA555D9F0633C9BCCBE3DF332B9C1274 * ___predicate1, Func_2_tBF5E42259B30DEB08B8F01DEAD14034173D7F115 * ___selector2, const RuntimeMethod* method)
{
	{
		NullCheck((Iterator_1_t4861EDEAC91472CDE6F71F17BA6EF43B5D56F78E *)__this);
		((  void (*) (Iterator_1_t4861EDEAC91472CDE6F71F17BA6EF43B5D56F78E *, const RuntimeMethod*))IL2CPP_RGCTX_METHOD_INFO(method->klass->rgctx_data, 0)->methodPointer)((Iterator_1_t4861EDEAC91472CDE6F71F17BA6EF43B5D56F78E *)__this, /*hidden argument*/IL2CPP_RGCTX_METHOD_INFO(method->klass->rgctx_data, 0));
		List_1_t260B41F956D673396C33A4CF94E8D6C4389EACB7 * L_0 = ___source0;
		__this->set_source_3(L_0);
		Func_2_t2EBF98B0BA555D9F0633C9BCCBE3DF332B9C1274 * L_1 = ___predicate1;
		__this->set_predicate_4(L_1);
		Func_2_tBF5E42259B30DEB08B8F01DEAD14034173D7F115 * L_2 = ___selector2;
		__this->set_selector_5(L_2);
		return;
	}
}
// System.Linq.Enumerable/Iterator`1<TResult> System.Linq.Enumerable/WhereSelectListIterator`2<System.Int32,System.Decimal>::Clone()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR Iterator_1_t4861EDEAC91472CDE6F71F17BA6EF43B5D56F78E * WhereSelectListIterator_2_Clone_m15CED54F2AF7FAC423F30568840E276C7501C1D1_gshared (WhereSelectListIterator_2_t2EBF84FB2CE39E9E5B9DD3AC4C33E4F0D6142BBC * __this, const RuntimeMethod* method)
{
	{
		List_1_t260B41F956D673396C33A4CF94E8D6C4389EACB7 * L_0 = (List_1_t260B41F956D673396C33A4CF94E8D6C4389EACB7 *)__this->get_source_3();
		Func_2_t2EBF98B0BA555D9F0633C9BCCBE3DF332B9C1274 * L_1 = (Func_2_t2EBF98B0BA555D9F0633C9BCCBE3DF332B9C1274 *)__this->get_predicate_4();
		Func_2_tBF5E42259B30DEB08B8F01DEAD14034173D7F115 * L_2 = (Func_2_tBF5E42259B30DEB08B8F01DEAD14034173D7F115 *)__this->get_selector_5();
		WhereSelectListIterator_2_t2EBF84FB2CE39E9E5B9DD3AC4C33E4F0D6142BBC * L_3 = (WhereSelectListIterator_2_t2EBF84FB2CE39E9E5B9DD3AC4C33E4F0D6142BBC *)il2cpp_codegen_object_new(IL2CPP_RGCTX_DATA(method->klass->rgctx_data, 2));
		((  void (*) (WhereSelectListIterator_2_t2EBF84FB2CE39E9E5B9DD3AC4C33E4F0D6142BBC *, List_1_t260B41F956D673396C33A4CF94E8D6C4389EACB7 *, Func_2_t2EBF98B0BA555D9F0633C9BCCBE3DF332B9C1274 *, Func_2_tBF5E42259B30DEB08B8F01DEAD14034173D7F115 *, const RuntimeMethod*))IL2CPP_RGCTX_METHOD_INFO(method->klass->rgctx_data, 3)->methodPointer)(L_3, (List_1_t260B41F956D673396C33A4CF94E8D6C4389EACB7 *)L_0, (Func_2_t2EBF98B0BA555D9F0633C9BCCBE3DF332B9C1274 *)L_1, (Func_2_tBF5E42259B30DEB08B8F01DEAD14034173D7F115 *)L_2, /*hidden argument*/IL2CPP_RGCTX_METHOD_INFO(method->klass->rgctx_data, 3));
		return (Iterator_1_t4861EDEAC91472CDE6F71F17BA6EF43B5D56F78E *)L_3;
	}
}
// System.Boolean System.Linq.Enumerable/WhereSelectListIterator`2<System.Int32,System.Decimal>::MoveNext()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR bool WhereSelectListIterator_2_MoveNext_mB3E2EB0EDDE4C43F956272A73FBFD5F15C229ED9_gshared (WhereSelectListIterator_2_t2EBF84FB2CE39E9E5B9DD3AC4C33E4F0D6142BBC * __this, const RuntimeMethod* method)
{
	int32_t V_0 = 0;
	int32_t V_1 = 0;
	{
		int32_t L_0 = (int32_t)((Iterator_1_t4861EDEAC91472CDE6F71F17BA6EF43B5D56F78E *)__this)->get_state_1();
		V_0 = (int32_t)L_0;
		int32_t L_1 = V_0;
		if ((((int32_t)L_1) == ((int32_t)1)))
		{
			goto IL_0011;
		}
	}
	{
		int32_t L_2 = V_0;
		if ((((int32_t)L_2) == ((int32_t)2)))
		{
			goto IL_0061;
		}
	}
	{
		goto IL_0074;
	}

IL_0011:
	{
		List_1_t260B41F956D673396C33A4CF94E8D6C4389EACB7 * L_3 = (List_1_t260B41F956D673396C33A4CF94E8D6C4389EACB7 *)__this->get_source_3();
		NullCheck((List_1_t260B41F956D673396C33A4CF94E8D6C4389EACB7 *)L_3);
		Enumerator_t7BA00929E14A2F2A62CE085585044A3FEB2C5F3C  L_4;
		L_4 = ((  Enumerator_t7BA00929E14A2F2A62CE085585044A3FEB2C5F3C  (*) (List_1_t260B41F956D673396C33A4CF94E8D6C4389EACB7 *, const RuntimeMethod*))IL2CPP_RGCTX_METHOD_INFO(method->klass->rgctx_data, 4)->methodPointer)((List_1_t260B41F956D673396C33A4CF94E8D6C4389EACB7 *)L_3, /*hidden argument*/IL2CPP_RGCTX_METHOD_INFO(method->klass->rgctx_data, 4));
		__this->set_enumerator_6(L_4);
		((Iterator_1_t4861EDEAC91472CDE6F71F17BA6EF43B5D56F78E *)__this)->set_state_1(2);
		goto IL_0061;
	}

IL_002b:
	{
		Enumerator_t7BA00929E14A2F2A62CE085585044A3FEB2C5F3C * L_5 = (Enumerator_t7BA00929E14A2F2A62CE085585044A3FEB2C5F3C *)__this->get_address_of_enumerator_6();
		int32_t L_6;
		L_6 = Enumerator_get_Current_m6BBD624C51F7E20D347FE5894A6ECA94B8011181_inline((Enumerator_t7BA00929E14A2F2A62CE085585044A3FEB2C5F3C *)(Enumerator_t7BA00929E14A2F2A62CE085585044A3FEB2C5F3C *)L_5, /*hidden argument*/IL2CPP_RGCTX_METHOD_INFO(method->klass->rgctx_data, 5));
		V_1 = (int32_t)L_6;
		Func_2_t2EBF98B0BA555D9F0633C9BCCBE3DF332B9C1274 * L_7 = (Func_2_t2EBF98B0BA555D9F0633C9BCCBE3DF332B9C1274 *)__this->get_predicate_4();
		if (!L_7)
		{
			goto IL_004d;
		}
	}
	{
		Func_2_t2EBF98B0BA555D9F0633C9BCCBE3DF332B9C1274 * L_8 = (Func_2_t2EBF98B0BA555D9F0633C9BCCBE3DF332B9C1274 *)__this->get_predicate_4();
		int32_t L_9 = V_1;
		NullCheck((Func_2_t2EBF98B0BA555D9F0633C9BCCBE3DF332B9C1274 *)L_8);
		bool L_10;
		L_10 = ((  bool (*) (Func_2_t2EBF98B0BA555D9F0633C9BCCBE3DF332B9C1274 *, int32_t, const RuntimeMethod*))IL2CPP_RGCTX_METHOD_INFO(method->klass->rgctx_data, 6)->methodPointer)((Func_2_t2EBF98B0BA555D9F0633C9BCCBE3DF332B9C1274 *)L_8, (int32_t)L_9, /*hidden argument*/IL2CPP_RGCTX_METHOD_INFO(method->klass->rgctx_data, 6));
		if (!L_10)
		{
			goto IL_0061;
		}
	}

IL_004d:
	{
		Func_2_tBF5E42259B30DEB08B8F01DEAD14034173D7F115 * L_11 = (Func_2_tBF5E42259B30DEB08B8F01DEAD14034173D7F115 *)__this->get_selector_5();
		int32_t L_12 = V_1;
		NullCheck((Func_2_tBF5E42259B30DEB08B8F01DEAD14034173D7F115 *)L_11);
		Decimal_t2978B229CA86D3B7BA66A0AEEE014E0DE4F940D7  L_13;
		L_13 = ((  Decimal_t2978B229CA86D3B7BA66A0AEEE014E0DE4F940D7  (*) (Func_2_tBF5E42259B30DEB08B8F01DEAD14034173D7F115 *, int32_t, const RuntimeMethod*))IL2CPP_RGCTX_METHOD_INFO(method->klass->rgctx_data, 7)->methodPointer)((Func_2_tBF5E42259B30DEB08B8F01DEAD14034173D7F115 *)L_11, (int32_t)L_12, /*hidden argument*/IL2CPP_RGCTX_METHOD_INFO(method->klass->rgctx_data, 7));
		((Iterator_1_t4861EDEAC91472CDE6F71F17BA6EF43B5D56F78E *)__this)->set_current_2(L_13);
		return (bool)1;
	}

IL_0061:
	{
		Enumerator_t7BA00929E14A2F2A62CE085585044A3FEB2C5F3C * L_14 = (Enumerator_t7BA00929E14A2F2A62CE085585044A3FEB2C5F3C *)__this->get_address_of_enumerator_6();
		bool L_15;
		L_15 = Enumerator_MoveNext_m40FD166B6757334A2BBCF67238EFDF70D727A4A6((Enumerator_t7BA00929E14A2F2A62CE085585044A3FEB2C5F3C *)(Enumerator_t7BA00929E14A2F2A62CE085585044A3FEB2C5F3C *)L_14, /*hidden argument*/IL2CPP_RGCTX_METHOD_INFO(method->klass->rgctx_data, 8));
		if (L_15)
		{
			goto IL_002b;
		}
	}
	{
		NullCheck((Iterator_1_t4861EDEAC91472CDE6F71F17BA6EF43B5D56F78E *)__this);
		VirtActionInvoker0::Invoke(12 /* System.Void System.Linq.Enumerable/Iterator`1<System.Decimal>::Dispose() */, (Iterator_1_t4861EDEAC91472CDE6F71F17BA6EF43B5D56F78E *)__this);
	}

IL_0074:
	{
		return (bool)0;
	}
}
// System.Collections.Generic.IEnumerable`1<TResult> System.Linq.Enumerable/WhereSelectListIterator`2<System.Int32,System.Decimal>::Where(System.Func`2<TResult,System.Boolean>)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR RuntimeObject* WhereSelectListIterator_2_Where_mF7F6CE2935F828E7FBD864595A7BCA0E3723CA50_gshared (WhereSelectListIterator_2_t2EBF84FB2CE39E9E5B9DD3AC4C33E4F0D6142BBC * __this, Func_2_t85912C5553CB5462E74F14A32388FC1004CC7C2E * ___predicate0, const RuntimeMethod* method)
{
	{
		Func_2_t85912C5553CB5462E74F14A32388FC1004CC7C2E * L_0 = ___predicate0;
		WhereEnumerableIterator_1_t681EE290755A32EDFF9E6FDD4DF16CD94CA1A371 * L_1 = (WhereEnumerableIterator_1_t681EE290755A32EDFF9E6FDD4DF16CD94CA1A371 *)il2cpp_codegen_object_new(IL2CPP_RGCTX_DATA(method->klass->rgctx_data, 10));
		((  void (*) (WhereEnumerableIterator_1_t681EE290755A32EDFF9E6FDD4DF16CD94CA1A371 *, RuntimeObject*, Func_2_t85912C5553CB5462E74F14A32388FC1004CC7C2E *, const RuntimeMethod*))IL2CPP_RGCTX_METHOD_INFO(method->klass->rgctx_data, 11)->methodPointer)(L_1, (RuntimeObject*)__this, (Func_2_t85912C5553CB5462E74F14A32388FC1004CC7C2E *)L_0, /*hidden argument*/IL2CPP_RGCTX_METHOD_INFO(method->klass->rgctx_data, 11));
		return (RuntimeObject*)L_1;
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
// System.Void System.Linq.Enumerable/WhereSelectListIterator`2<System.Int32,System.Double>::.ctor(System.Collections.Generic.List`1<TSource>,System.Func`2<TSource,System.Boolean>,System.Func`2<TSource,TResult>)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void WhereSelectListIterator_2__ctor_m6F68B6733EB00EB56BE6AB2D34F59F7932E228BD_gshared (WhereSelectListIterator_2_tF60E714CAFC3118F16C82A15D86A38A42EFEDFA7 * __this, List_1_t260B41F956D673396C33A4CF94E8D6C4389EACB7 * ___source0, Func_2_t2EBF98B0BA555D9F0633C9BCCBE3DF332B9C1274 * ___predicate1, Func_2_t23C797B165C3B4B97ADF0BE92281F030E672AD4B * ___selector2, const RuntimeMethod* method)
{
	{
		NullCheck((Iterator_1_t167C775670D48A9186D95126BDB6A078470CAE8D *)__this);
		((  void (*) (Iterator_1_t167C775670D48A9186D95126BDB6A078470CAE8D *, const RuntimeMethod*))IL2CPP_RGCTX_METHOD_INFO(method->klass->rgctx_data, 0)->methodPointer)((Iterator_1_t167C775670D48A9186D95126BDB6A078470CAE8D *)__this, /*hidden argument*/IL2CPP_RGCTX_METHOD_INFO(method->klass->rgctx_data, 0));
		List_1_t260B41F956D673396C33A4CF94E8D6C4389EACB7 * L_0 = ___source0;
		__this->set_source_3(L_0);
		Func_2_t2EBF98B0BA555D9F0633C9BCCBE3DF332B9C1274 * L_1 = ___predicate1;
		__this->set_predicate_4(L_1);
		Func_2_t23C797B165C3B4B97ADF0BE92281F030E672AD4B * L_2 = ___selector2;
		__this->set_selector_5(L_2);
		return;
	}
}
// System.Linq.Enumerable/Iterator`1<TResult> System.Linq.Enumerable/WhereSelectListIterator`2<System.Int32,System.Double>::Clone()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR Iterator_1_t167C775670D48A9186D95126BDB6A078470CAE8D * WhereSelectListIterator_2_Clone_mFD1385E2DA0B85B69A717DF88429648813F0AE09_gshared (WhereSelectListIterator_2_tF60E714CAFC3118F16C82A15D86A38A42EFEDFA7 * __this, const RuntimeMethod* method)
{
	{
		List_1_t260B41F956D673396C33A4CF94E8D6C4389EACB7 * L_0 = (List_1_t260B41F956D673396C33A4CF94E8D6C4389EACB7 *)__this->get_source_3();
		Func_2_t2EBF98B0BA555D9F0633C9BCCBE3DF332B9C1274 * L_1 = (Func_2_t2EBF98B0BA555D9F0633C9BCCBE3DF332B9C1274 *)__this->get_predicate_4();
		Func_2_t23C797B165C3B4B97ADF0BE92281F030E672AD4B * L_2 = (Func_2_t23C797B165C3B4B97ADF0BE92281F030E672AD4B *)__this->get_selector_5();
		WhereSelectListIterator_2_tF60E714CAFC3118F16C82A15D86A38A42EFEDFA7 * L_3 = (WhereSelectListIterator_2_tF60E714CAFC3118F16C82A15D86A38A42EFEDFA7 *)il2cpp_codegen_object_new(IL2CPP_RGCTX_DATA(method->klass->rgctx_data, 2));
		((  void (*) (WhereSelectListIterator_2_tF60E714CAFC3118F16C82A15D86A38A42EFEDFA7 *, List_1_t260B41F956D673396C33A4CF94E8D6C4389EACB7 *, Func_2_t2EBF98B0BA555D9F0633C9BCCBE3DF332B9C1274 *, Func_2_t23C797B165C3B4B97ADF0BE92281F030E672AD4B *, const RuntimeMethod*))IL2CPP_RGCTX_METHOD_INFO(method->klass->rgctx_data, 3)->methodPointer)(L_3, (List_1_t260B41F956D673396C33A4CF94E8D6C4389EACB7 *)L_0, (Func_2_t2EBF98B0BA555D9F0633C9BCCBE3DF332B9C1274 *)L_1, (Func_2_t23C797B165C3B4B97ADF0BE92281F030E672AD4B *)L_2, /*hidden argument*/IL2CPP_RGCTX_METHOD_INFO(method->klass->rgctx_data, 3));
		return (Iterator_1_t167C775670D48A9186D95126BDB6A078470CAE8D *)L_3;
	}
}
// System.Boolean System.Linq.Enumerable/WhereSelectListIterator`2<System.Int32,System.Double>::MoveNext()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR bool WhereSelectListIterator_2_MoveNext_m37385C16C88F3C27D63F951C844A8B2374736FCB_gshared (WhereSelectListIterator_2_tF60E714CAFC3118F16C82A15D86A38A42EFEDFA7 * __this, const RuntimeMethod* method)
{
	int32_t V_0 = 0;
	int32_t V_1 = 0;
	{
		int32_t L_0 = (int32_t)((Iterator_1_t167C775670D48A9186D95126BDB6A078470CAE8D *)__this)->get_state_1();
		V_0 = (int32_t)L_0;
		int32_t L_1 = V_0;
		if ((((int32_t)L_1) == ((int32_t)1)))
		{
			goto IL_0011;
		}
	}
	{
		int32_t L_2 = V_0;
		if ((((int32_t)L_2) == ((int32_t)2)))
		{
			goto IL_0061;
		}
	}
	{
		goto IL_0074;
	}

IL_0011:
	{
		List_1_t260B41F956D673396C33A4CF94E8D6C4389EACB7 * L_3 = (List_1_t260B41F956D673396C33A4CF94E8D6C4389EACB7 *)__this->get_source_3();
		NullCheck((List_1_t260B41F956D673396C33A4CF94E8D6C4389EACB7 *)L_3);
		Enumerator_t7BA00929E14A2F2A62CE085585044A3FEB2C5F3C  L_4;
		L_4 = ((  Enumerator_t7BA00929E14A2F2A62CE085585044A3FEB2C5F3C  (*) (List_1_t260B41F956D673396C33A4CF94E8D6C4389EACB7 *, const RuntimeMethod*))IL2CPP_RGCTX_METHOD_INFO(method->klass->rgctx_data, 4)->methodPointer)((List_1_t260B41F956D673396C33A4CF94E8D6C4389EACB7 *)L_3, /*hidden argument*/IL2CPP_RGCTX_METHOD_INFO(method->klass->rgctx_data, 4));
		__this->set_enumerator_6(L_4);
		((Iterator_1_t167C775670D48A9186D95126BDB6A078470CAE8D *)__this)->set_state_1(2);
		goto IL_0061;
	}

IL_002b:
	{
		Enumerator_t7BA00929E14A2F2A62CE085585044A3FEB2C5F3C * L_5 = (Enumerator_t7BA00929E14A2F2A62CE085585044A3FEB2C5F3C *)__this->get_address_of_enumerator_6();
		int32_t L_6;
		L_6 = Enumerator_get_Current_m6BBD624C51F7E20D347FE5894A6ECA94B8011181_inline((Enumerator_t7BA00929E14A2F2A62CE085585044A3FEB2C5F3C *)(Enumerator_t7BA00929E14A2F2A62CE085585044A3FEB2C5F3C *)L_5, /*hidden argument*/IL2CPP_RGCTX_METHOD_INFO(method->klass->rgctx_data, 5));
		V_1 = (int32_t)L_6;
		Func_2_t2EBF98B0BA555D9F0633C9BCCBE3DF332B9C1274 * L_7 = (Func_2_t2EBF98B0BA555D9F0633C9BCCBE3DF332B9C1274 *)__this->get_predicate_4();
		if (!L_7)
		{
			goto IL_004d;
		}
	}
	{
		Func_2_t2EBF98B0BA555D9F0633C9BCCBE3DF332B9C1274 * L_8 = (Func_2_t2EBF98B0BA555D9F0633C9BCCBE3DF332B9C1274 *)__this->get_predicate_4();
		int32_t L_9 = V_1;
		NullCheck((Func_2_t2EBF98B0BA555D9F0633C9BCCBE3DF332B9C1274 *)L_8);
		bool L_10;
		L_10 = ((  bool (*) (Func_2_t2EBF98B0BA555D9F0633C9BCCBE3DF332B9C1274 *, int32_t, const RuntimeMethod*))IL2CPP_RGCTX_METHOD_INFO(method->klass->rgctx_data, 6)->methodPointer)((Func_2_t2EBF98B0BA555D9F0633C9BCCBE3DF332B9C1274 *)L_8, (int32_t)L_9, /*hidden argument*/IL2CPP_RGCTX_METHOD_INFO(method->klass->rgctx_data, 6));
		if (!L_10)
		{
			goto IL_0061;
		}
	}

IL_004d:
	{
		Func_2_t23C797B165C3B4B97ADF0BE92281F030E672AD4B * L_11 = (Func_2_t23C797B165C3B4B97ADF0BE92281F030E672AD4B *)__this->get_selector_5();
		int32_t L_12 = V_1;
		NullCheck((Func_2_t23C797B165C3B4B97ADF0BE92281F030E672AD4B *)L_11);
		double L_13;
		L_13 = ((  double (*) (Func_2_t23C797B165C3B4B97ADF0BE92281F030E672AD4B *, int32_t, const RuntimeMethod*))IL2CPP_RGCTX_METHOD_INFO(method->klass->rgctx_data, 7)->methodPointer)((Func_2_t23C797B165C3B4B97ADF0BE92281F030E672AD4B *)L_11, (int32_t)L_12, /*hidden argument*/IL2CPP_RGCTX_METHOD_INFO(method->klass->rgctx_data, 7));
		((Iterator_1_t167C775670D48A9186D95126BDB6A078470CAE8D *)__this)->set_current_2(L_13);
		return (bool)1;
	}

IL_0061:
	{
		Enumerator_t7BA00929E14A2F2A62CE085585044A3FEB2C5F3C * L_14 = (Enumerator_t7BA00929E14A2F2A62CE085585044A3FEB2C5F3C *)__this->get_address_of_enumerator_6();
		bool L_15;
		L_15 = Enumerator_MoveNext_m40FD166B6757334A2BBCF67238EFDF70D727A4A6((Enumerator_t7BA00929E14A2F2A62CE085585044A3FEB2C5F3C *)(Enumerator_t7BA00929E14A2F2A62CE085585044A3FEB2C5F3C *)L_14, /*hidden argument*/IL2CPP_RGCTX_METHOD_INFO(method->klass->rgctx_data, 8));
		if (L_15)
		{
			goto IL_002b;
		}
	}
	{
		NullCheck((Iterator_1_t167C775670D48A9186D95126BDB6A078470CAE8D *)__this);
		VirtActionInvoker0::Invoke(12 /* System.Void System.Linq.Enumerable/Iterator`1<System.Double>::Dispose() */, (Iterator_1_t167C775670D48A9186D95126BDB6A078470CAE8D *)__this);
	}

IL_0074:
	{
		return (bool)0;
	}
}
// System.Collections.Generic.IEnumerable`1<TResult> System.Linq.Enumerable/WhereSelectListIterator`2<System.Int32,System.Double>::Where(System.Func`2<TResult,System.Boolean>)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR RuntimeObject* WhereSelectListIterator_2_Where_m0D546A9C5A12AC622F12D73D592DA3821B1D279B_gshared (WhereSelectListIterator_2_tF60E714CAFC3118F16C82A15D86A38A42EFEDFA7 * __this, Func_2_t4E607BF9FA9E115F43BD77F92F4285E3B8C7FB0D * ___predicate0, const RuntimeMethod* method)
{
	{
		Func_2_t4E607BF9FA9E115F43BD77F92F4285E3B8C7FB0D * L_0 = ___predicate0;
		WhereEnumerableIterator_1_tB738E509FB63FFBEF5774573271E95894BA5679F * L_1 = (WhereEnumerableIterator_1_tB738E509FB63FFBEF5774573271E95894BA5679F *)il2cpp_codegen_object_new(IL2CPP_RGCTX_DATA(method->klass->rgctx_data, 10));
		((  void (*) (WhereEnumerableIterator_1_tB738E509FB63FFBEF5774573271E95894BA5679F *, RuntimeObject*, Func_2_t4E607BF9FA9E115F43BD77F92F4285E3B8C7FB0D *, const RuntimeMethod*))IL2CPP_RGCTX_METHOD_INFO(method->klass->rgctx_data, 11)->methodPointer)(L_1, (RuntimeObject*)__this, (Func_2_t4E607BF9FA9E115F43BD77F92F4285E3B8C7FB0D *)L_0, /*hidden argument*/IL2CPP_RGCTX_METHOD_INFO(method->klass->rgctx_data, 11));
		return (RuntimeObject*)L_1;
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
// System.Void System.Linq.Enumerable/WhereSelectListIterator`2<System.Int32,System.Int32>::.ctor(System.Collections.Generic.List`1<TSource>,System.Func`2<TSource,System.Boolean>,System.Func`2<TSource,TResult>)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void WhereSelectListIterator_2__ctor_m895E21AE9AB1E3F19B3147EDC913BB567B1A65C7_gshared (WhereSelectListIterator_2_t4CC3FE3A35610DC6F761EE7DB863B845957AD325 * __this, List_1_t260B41F956D673396C33A4CF94E8D6C4389EACB7 * ___source0, Func_2_t2EBF98B0BA555D9F0633C9BCCBE3DF332B9C1274 * ___predicate1, Func_2_tFF6AE79EFD0857556AD37A1A1594C43F76012FEA * ___selector2, const RuntimeMethod* method)
{
	{
		NullCheck((Iterator_1_tCFFC952B03DBE4E956DE317DB9704D936AEA2379 *)__this);
		((  void (*) (Iterator_1_tCFFC952B03DBE4E956DE317DB9704D936AEA2379 *, const RuntimeMethod*))IL2CPP_RGCTX_METHOD_INFO(method->klass->rgctx_data, 0)->methodPointer)((Iterator_1_tCFFC952B03DBE4E956DE317DB9704D936AEA2379 *)__this, /*hidden argument*/IL2CPP_RGCTX_METHOD_INFO(method->klass->rgctx_data, 0));
		List_1_t260B41F956D673396C33A4CF94E8D6C4389EACB7 * L_0 = ___source0;
		__this->set_source_3(L_0);
		Func_2_t2EBF98B0BA555D9F0633C9BCCBE3DF332B9C1274 * L_1 = ___predicate1;
		__this->set_predicate_4(L_1);
		Func_2_tFF6AE79EFD0857556AD37A1A1594C43F76012FEA * L_2 = ___selector2;
		__this->set_selector_5(L_2);
		return;
	}
}
// System.Linq.Enumerable/Iterator`1<TResult> System.Linq.Enumerable/WhereSelectListIterator`2<System.Int32,System.Int32>::Clone()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR Iterator_1_tCFFC952B03DBE4E956DE317DB9704D936AEA2379 * WhereSelectListIterator_2_Clone_mEE6375B2C79172E13732CA49AAF389493C1C7100_gshared (WhereSelectListIterator_2_t4CC3FE3A35610DC6F761EE7DB863B845957AD325 * __this, const RuntimeMethod* method)
{
	{
		List_1_t260B41F956D673396C33A4CF94E8D6C4389EACB7 * L_0 = (List_1_t260B41F956D673396C33A4CF94E8D6C4389EACB7 *)__this->get_source_3();
		Func_2_t2EBF98B0BA555D9F0633C9BCCBE3DF332B9C1274 * L_1 = (Func_2_t2EBF98B0BA555D9F0633C9BCCBE3DF332B9C1274 *)__this->get_predicate_4();
		Func_2_tFF6AE79EFD0857556AD37A1A1594C43F76012FEA * L_2 = (Func_2_tFF6AE79EFD0857556AD37A1A1594C43F76012FEA *)__this->get_selector_5();
		WhereSelectListIterator_2_t4CC3FE3A35610DC6F761EE7DB863B845957AD325 * L_3 = (WhereSelectListIterator_2_t4CC3FE3A35610DC6F761EE7DB863B845957AD325 *)il2cpp_codegen_object_new(IL2CPP_RGCTX_DATA(method->klass->rgctx_data, 2));
		((  void (*) (WhereSelectListIterator_2_t4CC3FE3A35610DC6F761EE7DB863B845957AD325 *, List_1_t260B41F956D673396C33A4CF94E8D6C4389EACB7 *, Func_2_t2EBF98B0BA555D9F0633C9BCCBE3DF332B9C1274 *, Func_2_tFF6AE79EFD0857556AD37A1A1594C43F76012FEA *, const RuntimeMethod*))IL2CPP_RGCTX_METHOD_INFO(method->klass->rgctx_data, 3)->methodPointer)(L_3, (List_1_t260B41F956D673396C33A4CF94E8D6C4389EACB7 *)L_0, (Func_2_t2EBF98B0BA555D9F0633C9BCCBE3DF332B9C1274 *)L_1, (Func_2_tFF6AE79EFD0857556AD37A1A1594C43F76012FEA *)L_2, /*hidden argument*/IL2CPP_RGCTX_METHOD_INFO(method->klass->rgctx_data, 3));
		return (Iterator_1_tCFFC952B03DBE4E956DE317DB9704D936AEA2379 *)L_3;
	}
}
// System.Boolean System.Linq.Enumerable/WhereSelectListIterator`2<System.Int32,System.Int32>::MoveNext()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR bool WhereSelectListIterator_2_MoveNext_m637B802A50BA94CD511636CAF5D912C6B96B18A1_gshared (WhereSelectListIterator_2_t4CC3FE3A35610DC6F761EE7DB863B845957AD325 * __this, const RuntimeMethod* method)
{
	int32_t V_0 = 0;
	int32_t V_1 = 0;
	{
		int32_t L_0 = (int32_t)((Iterator_1_tCFFC952B03DBE4E956DE317DB9704D936AEA2379 *)__this)->get_state_1();
		V_0 = (int32_t)L_0;
		int32_t L_1 = V_0;
		if ((((int32_t)L_1) == ((int32_t)1)))
		{
			goto IL_0011;
		}
	}
	{
		int32_t L_2 = V_0;
		if ((((int32_t)L_2) == ((int32_t)2)))
		{
			goto IL_0061;
		}
	}
	{
		goto IL_0074;
	}

IL_0011:
	{
		List_1_t260B41F956D673396C33A4CF94E8D6C4389EACB7 * L_3 = (List_1_t260B41F956D673396C33A4CF94E8D6C4389EACB7 *)__this->get_source_3();
		NullCheck((List_1_t260B41F956D673396C33A4CF94E8D6C4389EACB7 *)L_3);
		Enumerator_t7BA00929E14A2F2A62CE085585044A3FEB2C5F3C  L_4;
		L_4 = ((  Enumerator_t7BA00929E14A2F2A62CE085585044A3FEB2C5F3C  (*) (List_1_t260B41F956D673396C33A4CF94E8D6C4389EACB7 *, const RuntimeMethod*))IL2CPP_RGCTX_METHOD_INFO(method->klass->rgctx_data, 4)->methodPointer)((List_1_t260B41F956D673396C33A4CF94E8D6C4389EACB7 *)L_3, /*hidden argument*/IL2CPP_RGCTX_METHOD_INFO(method->klass->rgctx_data, 4));
		__this->set_enumerator_6(L_4);
		((Iterator_1_tCFFC952B03DBE4E956DE317DB9704D936AEA2379 *)__this)->set_state_1(2);
		goto IL_0061;
	}

IL_002b:
	{
		Enumerator_t7BA00929E14A2F2A62CE085585044A3FEB2C5F3C * L_5 = (Enumerator_t7BA00929E14A2F2A62CE085585044A3FEB2C5F3C *)__this->get_address_of_enumerator_6();
		int32_t L_6;
		L_6 = Enumerator_get_Current_m6BBD624C51F7E20D347FE5894A6ECA94B8011181_inline((Enumerator_t7BA00929E14A2F2A62CE085585044A3FEB2C5F3C *)(Enumerator_t7BA00929E14A2F2A62CE085585044A3FEB2C5F3C *)L_5, /*hidden argument*/IL2CPP_RGCTX_METHOD_INFO(method->klass->rgctx_data, 5));
		V_1 = (int32_t)L_6;
		Func_2_t2EBF98B0BA555D9F0633C9BCCBE3DF332B9C1274 * L_7 = (Func_2_t2EBF98B0BA555D9F0633C9BCCBE3DF332B9C1274 *)__this->get_predicate_4();
		if (!L_7)
		{
			goto IL_004d;
		}
	}
	{
		Func_2_t2EBF98B0BA555D9F0633C9BCCBE3DF332B9C1274 * L_8 = (Func_2_t2EBF98B0BA555D9F0633C9BCCBE3DF332B9C1274 *)__this->get_predicate_4();
		int32_t L_9 = V_1;
		NullCheck((Func_2_t2EBF98B0BA555D9F0633C9BCCBE3DF332B9C1274 *)L_8);
		bool L_10;
		L_10 = ((  bool (*) (Func_2_t2EBF98B0BA555D9F0633C9BCCBE3DF332B9C1274 *, int32_t, const RuntimeMethod*))IL2CPP_RGCTX_METHOD_INFO(method->klass->rgctx_data, 6)->methodPointer)((Func_2_t2EBF98B0BA555D9F0633C9BCCBE3DF332B9C1274 *)L_8, (int32_t)L_9, /*hidden argument*/IL2CPP_RGCTX_METHOD_INFO(method->klass->rgctx_data, 6));
		if (!L_10)
		{
			goto IL_0061;
		}
	}

IL_004d:
	{
		Func_2_tFF6AE79EFD0857556AD37A1A1594C43F76012FEA * L_11 = (Func_2_tFF6AE79EFD0857556AD37A1A1594C43F76012FEA *)__this->get_selector_5();
		int32_t L_12 = V_1;
		NullCheck((Func_2_tFF6AE79EFD0857556AD37A1A1594C43F76012FEA *)L_11);
		int32_t L_13;
		L_13 = ((  int32_t (*) (Func_2_tFF6AE79EFD0857556AD37A1A1594C43F76012FEA *, int32_t, const RuntimeMethod*))IL2CPP_RGCTX_METHOD_INFO(method->klass->rgctx_data, 7)->methodPointer)((Func_2_tFF6AE79EFD0857556AD37A1A1594C43F76012FEA *)L_11, (int32_t)L_12, /*hidden argument*/IL2CPP_RGCTX_METHOD_INFO(method->klass->rgctx_data, 7));
		((Iterator_1_tCFFC952B03DBE4E956DE317DB9704D936AEA2379 *)__this)->set_current_2(L_13);
		return (bool)1;
	}

IL_0061:
	{
		Enumerator_t7BA00929E14A2F2A62CE085585044A3FEB2C5F3C * L_14 = (Enumerator_t7BA00929E14A2F2A62CE085585044A3FEB2C5F3C *)__this->get_address_of_enumerator_6();
		bool L_15;
		L_15 = Enumerator_MoveNext_m40FD166B6757334A2BBCF67238EFDF70D727A4A6((Enumerator_t7BA00929E14A2F2A62CE085585044A3FEB2C5F3C *)(Enumerator_t7BA00929E14A2F2A62CE085585044A3FEB2C5F3C *)L_14, /*hidden argument*/IL2CPP_RGCTX_METHOD_INFO(method->klass->rgctx_data, 8));
		if (L_15)
		{
			goto IL_002b;
		}
	}
	{
		NullCheck((Iterator_1_tCFFC952B03DBE4E956DE317DB9704D936AEA2379 *)__this);
		VirtActionInvoker0::Invoke(12 /* System.Void System.Linq.Enumerable/Iterator`1<System.Int32>::Dispose() */, (Iterator_1_tCFFC952B03DBE4E956DE317DB9704D936AEA2379 *)__this);
	}

IL_0074:
	{
		return (bool)0;
	}
}
// System.Collections.Generic.IEnumerable`1<TResult> System.Linq.Enumerable/WhereSelectListIterator`2<System.Int32,System.Int32>::Where(System.Func`2<TResult,System.Boolean>)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR RuntimeObject* WhereSelectListIterator_2_Where_m7F75FF628D2E99D2BA127B84FDD08DD88048ADB0_gshared (WhereSelectListIterator_2_t4CC3FE3A35610DC6F761EE7DB863B845957AD325 * __this, Func_2_t2EBF98B0BA555D9F0633C9BCCBE3DF332B9C1274 * ___predicate0, const RuntimeMethod* method)
{
	{
		Func_2_t2EBF98B0BA555D9F0633C9BCCBE3DF332B9C1274 * L_0 = ___predicate0;
		WhereEnumerableIterator_1_t9F4DDC70173BABD72AEC7AA00D62F4FAE2613CEA * L_1 = (WhereEnumerableIterator_1_t9F4DDC70173BABD72AEC7AA00D62F4FAE2613CEA *)il2cpp_codegen_object_new(IL2CPP_RGCTX_DATA(method->klass->rgctx_data, 10));
		((  void (*) (WhereEnumerableIterator_1_t9F4DDC70173BABD72AEC7AA00D62F4FAE2613CEA *, RuntimeObject*, Func_2_t2EBF98B0BA555D9F0633C9BCCBE3DF332B9C1274 *, const RuntimeMethod*))IL2CPP_RGCTX_METHOD_INFO(method->klass->rgctx_data, 11)->methodPointer)(L_1, (RuntimeObject*)__this, (Func_2_t2EBF98B0BA555D9F0633C9BCCBE3DF332B9C1274 *)L_0, /*hidden argument*/IL2CPP_RGCTX_METHOD_INFO(method->klass->rgctx_data, 11));
		return (RuntimeObject*)L_1;
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
// System.Void System.Linq.Enumerable/WhereSelectListIterator`2<System.Int32,System.Int64>::.ctor(System.Collections.Generic.List`1<TSource>,System.Func`2<TSource,System.Boolean>,System.Func`2<TSource,TResult>)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void WhereSelectListIterator_2__ctor_mAEB750612D1BB9E1154D74150FC0E4CD5030210B_gshared (WhereSelectListIterator_2_t029DF87EF6C1A59C1658F051FF560E0216888A24 * __this, List_1_t260B41F956D673396C33A4CF94E8D6C4389EACB7 * ___source0, Func_2_t2EBF98B0BA555D9F0633C9BCCBE3DF332B9C1274 * ___predicate1, Func_2_tAB99B2018719C6ADFD37FB04A207F07169AE46E0 * ___selector2, const RuntimeMethod* method)
{
	{
		NullCheck((Iterator_1_tF88FA02D56A55D26D525180DE0108FA4F019BECE *)__this);
		((  void (*) (Iterator_1_tF88FA02D56A55D26D525180DE0108FA4F019BECE *, const RuntimeMethod*))IL2CPP_RGCTX_METHOD_INFO(method->klass->rgctx_data, 0)->methodPointer)((Iterator_1_tF88FA02D56A55D26D525180DE0108FA4F019BECE *)__this, /*hidden argument*/IL2CPP_RGCTX_METHOD_INFO(method->klass->rgctx_data, 0));
		List_1_t260B41F956D673396C33A4CF94E8D6C4389EACB7 * L_0 = ___source0;
		__this->set_source_3(L_0);
		Func_2_t2EBF98B0BA555D9F0633C9BCCBE3DF332B9C1274 * L_1 = ___predicate1;
		__this->set_predicate_4(L_1);
		Func_2_tAB99B2018719C6ADFD37FB04A207F07169AE46E0 * L_2 = ___selector2;
		__this->set_selector_5(L_2);
		return;
	}
}
// System.Linq.Enumerable/Iterator`1<TResult> System.Linq.Enumerable/WhereSelectListIterator`2<System.Int32,System.Int64>::Clone()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR Iterator_1_tF88FA02D56A55D26D525180DE0108FA4F019BECE * WhereSelectListIterator_2_Clone_mEBD5153828922B237893DBF318DF67E3623B5E85_gshared (WhereSelectListIterator_2_t029DF87EF6C1A59C1658F051FF560E0216888A24 * __this, const RuntimeMethod* method)
{
	{
		List_1_t260B41F956D673396C33A4CF94E8D6C4389EACB7 * L_0 = (List_1_t260B41F956D673396C33A4CF94E8D6C4389EACB7 *)__this->get_source_3();
		Func_2_t2EBF98B0BA555D9F0633C9BCCBE3DF332B9C1274 * L_1 = (Func_2_t2EBF98B0BA555D9F0633C9BCCBE3DF332B9C1274 *)__this->get_predicate_4();
		Func_2_tAB99B2018719C6ADFD37FB04A207F07169AE46E0 * L_2 = (Func_2_tAB99B2018719C6ADFD37FB04A207F07169AE46E0 *)__this->get_selector_5();
		WhereSelectListIterator_2_t029DF87EF6C1A59C1658F051FF560E0216888A24 * L_3 = (WhereSelectListIterator_2_t029DF87EF6C1A59C1658F051FF560E0216888A24 *)il2cpp_codegen_object_new(IL2CPP_RGCTX_DATA(method->klass->rgctx_data, 2));
		((  void (*) (WhereSelectListIterator_2_t029DF87EF6C1A59C1658F051FF560E0216888A24 *, List_1_t260B41F956D673396C33A4CF94E8D6C4389EACB7 *, Func_2_t2EBF98B0BA555D9F0633C9BCCBE3DF332B9C1274 *, Func_2_tAB99B2018719C6ADFD37FB04A207F07169AE46E0 *, const RuntimeMethod*))IL2CPP_RGCTX_METHOD_INFO(method->klass->rgctx_data, 3)->methodPointer)(L_3, (List_1_t260B41F956D673396C33A4CF94E8D6C4389EACB7 *)L_0, (Func_2_t2EBF98B0BA555D9F0633C9BCCBE3DF332B9C1274 *)L_1, (Func_2_tAB99B2018719C6ADFD37FB04A207F07169AE46E0 *)L_2, /*hidden argument*/IL2CPP_RGCTX_METHOD_INFO(method->klass->rgctx_data, 3));
		return (Iterator_1_tF88FA02D56A55D26D525180DE0108FA4F019BECE *)L_3;
	}
}
// System.Boolean System.Linq.Enumerable/WhereSelectListIterator`2<System.Int32,System.Int64>::MoveNext()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR bool WhereSelectListIterator_2_MoveNext_m5762E37F469AADADE40067C2350AD0DD2F311E99_gshared (WhereSelectListIterator_2_t029DF87EF6C1A59C1658F051FF560E0216888A24 * __this, const RuntimeMethod* method)
{
	int32_t V_0 = 0;
	int32_t V_1 = 0;
	{
		int32_t L_0 = (int32_t)((Iterator_1_tF88FA02D56A55D26D525180DE0108FA4F019BECE *)__this)->get_state_1();
		V_0 = (int32_t)L_0;
		int32_t L_1 = V_0;
		if ((((int32_t)L_1) == ((int32_t)1)))
		{
			goto IL_0011;
		}
	}
	{
		int32_t L_2 = V_0;
		if ((((int32_t)L_2) == ((int32_t)2)))
		{
			goto IL_0061;
		}
	}
	{
		goto IL_0074;
	}

IL_0011:
	{
		List_1_t260B41F956D673396C33A4CF94E8D6C4389EACB7 * L_3 = (List_1_t260B41F956D673396C33A4CF94E8D6C4389EACB7 *)__this->get_source_3();
		NullCheck((List_1_t260B41F956D673396C33A4CF94E8D6C4389EACB7 *)L_3);
		Enumerator_t7BA00929E14A2F2A62CE085585044A3FEB2C5F3C  L_4;
		L_4 = ((  Enumerator_t7BA00929E14A2F2A62CE085585044A3FEB2C5F3C  (*) (List_1_t260B41F956D673396C33A4CF94E8D6C4389EACB7 *, const RuntimeMethod*))IL2CPP_RGCTX_METHOD_INFO(method->klass->rgctx_data, 4)->methodPointer)((List_1_t260B41F956D673396C33A4CF94E8D6C4389EACB7 *)L_3, /*hidden argument*/IL2CPP_RGCTX_METHOD_INFO(method->klass->rgctx_data, 4));
		__this->set_enumerator_6(L_4);
		((Iterator_1_tF88FA02D56A55D26D525180DE0108FA4F019BECE *)__this)->set_state_1(2);
		goto IL_0061;
	}

IL_002b:
	{
		Enumerator_t7BA00929E14A2F2A62CE085585044A3FEB2C5F3C * L_5 = (Enumerator_t7BA00929E14A2F2A62CE085585044A3FEB2C5F3C *)__this->get_address_of_enumerator_6();
		int32_t L_6;
		L_6 = Enumerator_get_Current_m6BBD624C51F7E20D347FE5894A6ECA94B8011181_inline((Enumerator_t7BA00929E14A2F2A62CE085585044A3FEB2C5F3C *)(Enumerator_t7BA00929E14A2F2A62CE085585044A3FEB2C5F3C *)L_5, /*hidden argument*/IL2CPP_RGCTX_METHOD_INFO(method->klass->rgctx_data, 5));
		V_1 = (int32_t)L_6;
		Func_2_t2EBF98B0BA555D9F0633C9BCCBE3DF332B9C1274 * L_7 = (Func_2_t2EBF98B0BA555D9F0633C9BCCBE3DF332B9C1274 *)__this->get_predicate_4();
		if (!L_7)
		{
			goto IL_004d;
		}
	}
	{
		Func_2_t2EBF98B0BA555D9F0633C9BCCBE3DF332B9C1274 * L_8 = (Func_2_t2EBF98B0BA555D9F0633C9BCCBE3DF332B9C1274 *)__this->get_predicate_4();
		int32_t L_9 = V_1;
		NullCheck((Func_2_t2EBF98B0BA555D9F0633C9BCCBE3DF332B9C1274 *)L_8);
		bool L_10;
		L_10 = ((  bool (*) (Func_2_t2EBF98B0BA555D9F0633C9BCCBE3DF332B9C1274 *, int32_t, const RuntimeMethod*))IL2CPP_RGCTX_METHOD_INFO(method->klass->rgctx_data, 6)->methodPointer)((Func_2_t2EBF98B0BA555D9F0633C9BCCBE3DF332B9C1274 *)L_8, (int32_t)L_9, /*hidden argument*/IL2CPP_RGCTX_METHOD_INFO(method->klass->rgctx_data, 6));
		if (!L_10)
		{
			goto IL_0061;
		}
	}

IL_004d:
	{
		Func_2_tAB99B2018719C6ADFD37FB04A207F07169AE46E0 * L_11 = (Func_2_tAB99B2018719C6ADFD37FB04A207F07169AE46E0 *)__this->get_selector_5();
		int32_t L_12 = V_1;
		NullCheck((Func_2_tAB99B2018719C6ADFD37FB04A207F07169AE46E0 *)L_11);
		int64_t L_13;
		L_13 = ((  int64_t (*) (Func_2_tAB99B2018719C6ADFD37FB04A207F07169AE46E0 *, int32_t, const RuntimeMethod*))IL2CPP_RGCTX_METHOD_INFO(method->klass->rgctx_data, 7)->methodPointer)((Func_2_tAB99B2018719C6ADFD37FB04A207F07169AE46E0 *)L_11, (int32_t)L_12, /*hidden argument*/IL2CPP_RGCTX_METHOD_INFO(method->klass->rgctx_data, 7));
		((Iterator_1_tF88FA02D56A55D26D525180DE0108FA4F019BECE *)__this)->set_current_2(L_13);
		return (bool)1;
	}

IL_0061:
	{
		Enumerator_t7BA00929E14A2F2A62CE085585044A3FEB2C5F3C * L_14 = (Enumerator_t7BA00929E14A2F2A62CE085585044A3FEB2C5F3C *)__this->get_address_of_enumerator_6();
		bool L_15;
		L_15 = Enumerator_MoveNext_m40FD166B6757334A2BBCF67238EFDF70D727A4A6((Enumerator_t7BA00929E14A2F2A62CE085585044A3FEB2C5F3C *)(Enumerator_t7BA00929E14A2F2A62CE085585044A3FEB2C5F3C *)L_14, /*hidden argument*/IL2CPP_RGCTX_METHOD_INFO(method->klass->rgctx_data, 8));
		if (L_15)
		{
			goto IL_002b;
		}
	}
	{
		NullCheck((Iterator_1_tF88FA02D56A55D26D525180DE0108FA4F019BECE *)__this);
		VirtActionInvoker0::Invoke(12 /* System.Void System.Linq.Enumerable/Iterator`1<System.Int64>::Dispose() */, (Iterator_1_tF88FA02D56A55D26D525180DE0108FA4F019BECE *)__this);
	}

IL_0074:
	{
		return (bool)0;
	}
}
// System.Collections.Generic.IEnumerable`1<TResult> System.Linq.Enumerable/WhereSelectListIterator`2<System.Int32,System.Int64>::Where(System.Func`2<TResult,System.Boolean>)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR RuntimeObject* WhereSelectListIterator_2_Where_mC66A59B136CA953EE474B029D4F7FF9D9F53529C_gshared (WhereSelectListIterator_2_t029DF87EF6C1A59C1658F051FF560E0216888A24 * __this, Func_2_t03B9AF86FB7E93B62590F1CBD16276EF7AA1B215 * ___predicate0, const RuntimeMethod* method)
{
	{
		Func_2_t03B9AF86FB7E93B62590F1CBD16276EF7AA1B215 * L_0 = ___predicate0;
		WhereEnumerableIterator_1_tBAC8281C998E41429788C96260CB05A7E0471BC1 * L_1 = (WhereEnumerableIterator_1_tBAC8281C998E41429788C96260CB05A7E0471BC1 *)il2cpp_codegen_object_new(IL2CPP_RGCTX_DATA(method->klass->rgctx_data, 10));
		((  void (*) (WhereEnumerableIterator_1_tBAC8281C998E41429788C96260CB05A7E0471BC1 *, RuntimeObject*, Func_2_t03B9AF86FB7E93B62590F1CBD16276EF7AA1B215 *, const RuntimeMethod*))IL2CPP_RGCTX_METHOD_INFO(method->klass->rgctx_data, 11)->methodPointer)(L_1, (RuntimeObject*)__this, (Func_2_t03B9AF86FB7E93B62590F1CBD16276EF7AA1B215 *)L_0, /*hidden argument*/IL2CPP_RGCTX_METHOD_INFO(method->klass->rgctx_data, 11));
		return (RuntimeObject*)L_1;
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
// System.Void System.Linq.Enumerable/WhereSelectListIterator`2<System.Int32,System.Object>::.ctor(System.Collections.Generic.List`1<TSource>,System.Func`2<TSource,System.Boolean>,System.Func`2<TSource,TResult>)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void WhereSelectListIterator_2__ctor_mA0D61B688D5EE4E84300EA96C87ED9F3E10D5EA9_gshared (WhereSelectListIterator_2_tA41D93FF12E41BB5A5BEA27AEED367695ADACEA4 * __this, List_1_t260B41F956D673396C33A4CF94E8D6C4389EACB7 * ___source0, Func_2_t2EBF98B0BA555D9F0633C9BCCBE3DF332B9C1274 * ___predicate1, Func_2_t401E8A228CE43E56CCE9280AD9C6D87CC73A0123 * ___selector2, const RuntimeMethod* method)
{
	{
		NullCheck((Iterator_1_t674ABE41CF4096D4BE4D51E21FEBDADBF74CC279 *)__this);
		((  void (*) (Iterator_1_t674ABE41CF4096D4BE4D51E21FEBDADBF74CC279 *, const RuntimeMethod*))IL2CPP_RGCTX_METHOD_INFO(method->klass->rgctx_data, 0)->methodPointer)((Iterator_1_t674ABE41CF4096D4BE4D51E21FEBDADBF74CC279 *)__this, /*hidden argument*/IL2CPP_RGCTX_METHOD_INFO(method->klass->rgctx_data, 0));
		List_1_t260B41F956D673396C33A4CF94E8D6C4389EACB7 * L_0 = ___source0;
		__this->set_source_3(L_0);
		Func_2_t2EBF98B0BA555D9F0633C9BCCBE3DF332B9C1274 * L_1 = ___predicate1;
		__this->set_predicate_4(L_1);
		Func_2_t401E8A228CE43E56CCE9280AD9C6D87CC73A0123 * L_2 = ___selector2;
		__this->set_selector_5(L_2);
		return;
	}
}
// System.Linq.Enumerable/Iterator`1<TResult> System.Linq.Enumerable/WhereSelectListIterator`2<System.Int32,System.Object>::Clone()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR Iterator_1_t674ABE41CF4096D4BE4D51E21FEBDADBF74CC279 * WhereSelectListIterator_2_Clone_mE40F022902D030D86E465678E5DD79B3058FE2CB_gshared (WhereSelectListIterator_2_tA41D93FF12E41BB5A5BEA27AEED367695ADACEA4 * __this, const RuntimeMethod* method)
{
	{
		List_1_t260B41F956D673396C33A4CF94E8D6C4389EACB7 * L_0 = (List_1_t260B41F956D673396C33A4CF94E8D6C4389EACB7 *)__this->get_source_3();
		Func_2_t2EBF98B0BA555D9F0633C9BCCBE3DF332B9C1274 * L_1 = (Func_2_t2EBF98B0BA555D9F0633C9BCCBE3DF332B9C1274 *)__this->get_predicate_4();
		Func_2_t401E8A228CE43E56CCE9280AD9C6D87CC73A0123 * L_2 = (Func_2_t401E8A228CE43E56CCE9280AD9C6D87CC73A0123 *)__this->get_selector_5();
		WhereSelectListIterator_2_tA41D93FF12E41BB5A5BEA27AEED367695ADACEA4 * L_3 = (WhereSelectListIterator_2_tA41D93FF12E41BB5A5BEA27AEED367695ADACEA4 *)il2cpp_codegen_object_new(IL2CPP_RGCTX_DATA(method->klass->rgctx_data, 2));
		((  void (*) (WhereSelectListIterator_2_tA41D93FF12E41BB5A5BEA27AEED367695ADACEA4 *, List_1_t260B41F956D673396C33A4CF94E8D6C4389EACB7 *, Func_2_t2EBF98B0BA555D9F0633C9BCCBE3DF332B9C1274 *, Func_2_t401E8A228CE43E56CCE9280AD9C6D87CC73A0123 *, const RuntimeMethod*))IL2CPP_RGCTX_METHOD_INFO(method->klass->rgctx_data, 3)->methodPointer)(L_3, (List_1_t260B41F956D673396C33A4CF94E8D6C4389EACB7 *)L_0, (Func_2_t2EBF98B0BA555D9F0633C9BCCBE3DF332B9C1274 *)L_1, (Func_2_t401E8A228CE43E56CCE9280AD9C6D87CC73A0123 *)L_2, /*hidden argument*/IL2CPP_RGCTX_METHOD_INFO(method->klass->rgctx_data, 3));
		return (Iterator_1_t674ABE41CF4096D4BE4D51E21FEBDADBF74CC279 *)L_3;
	}
}
// System.Boolean System.Linq.Enumerable/WhereSelectListIterator`2<System.Int32,System.Object>::MoveNext()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR bool WhereSelectListIterator_2_MoveNext_mDEB78D7AB98D0FDC13661615FDBC0C01A621E84F_gshared (WhereSelectListIterator_2_tA41D93FF12E41BB5A5BEA27AEED367695ADACEA4 * __this, const RuntimeMethod* method)
{
	int32_t V_0 = 0;
	int32_t V_1 = 0;
	{
		int32_t L_0 = (int32_t)((Iterator_1_t674ABE41CF4096D4BE4D51E21FEBDADBF74CC279 *)__this)->get_state_1();
		V_0 = (int32_t)L_0;
		int32_t L_1 = V_0;
		if ((((int32_t)L_1) == ((int32_t)1)))
		{
			goto IL_0011;
		}
	}
	{
		int32_t L_2 = V_0;
		if ((((int32_t)L_2) == ((int32_t)2)))
		{
			goto IL_0061;
		}
	}
	{
		goto IL_0074;
	}

IL_0011:
	{
		List_1_t260B41F956D673396C33A4CF94E8D6C4389EACB7 * L_3 = (List_1_t260B41F956D673396C33A4CF94E8D6C4389EACB7 *)__this->get_source_3();
		NullCheck((List_1_t260B41F956D673396C33A4CF94E8D6C4389EACB7 *)L_3);
		Enumerator_t7BA00929E14A2F2A62CE085585044A3FEB2C5F3C  L_4;
		L_4 = ((  Enumerator_t7BA00929E14A2F2A62CE085585044A3FEB2C5F3C  (*) (List_1_t260B41F956D673396C33A4CF94E8D6C4389EACB7 *, const RuntimeMethod*))IL2CPP_RGCTX_METHOD_INFO(method->klass->rgctx_data, 4)->methodPointer)((List_1_t260B41F956D673396C33A4CF94E8D6C4389EACB7 *)L_3, /*hidden argument*/IL2CPP_RGCTX_METHOD_INFO(method->klass->rgctx_data, 4));
		__this->set_enumerator_6(L_4);
		((Iterator_1_t674ABE41CF4096D4BE4D51E21FEBDADBF74CC279 *)__this)->set_state_1(2);
		goto IL_0061;
	}

IL_002b:
	{
		Enumerator_t7BA00929E14A2F2A62CE085585044A3FEB2C5F3C * L_5 = (Enumerator_t7BA00929E14A2F2A62CE085585044A3FEB2C5F3C *)__this->get_address_of_enumerator_6();
		int32_t L_6;
		L_6 = Enumerator_get_Current_m6BBD624C51F7E20D347FE5894A6ECA94B8011181_inline((Enumerator_t7BA00929E14A2F2A62CE085585044A3FEB2C5F3C *)(Enumerator_t7BA00929E14A2F2A62CE085585044A3FEB2C5F3C *)L_5, /*hidden argument*/IL2CPP_RGCTX_METHOD_INFO(method->klass->rgctx_data, 5));
		V_1 = (int32_t)L_6;
		Func_2_t2EBF98B0BA555D9F0633C9BCCBE3DF332B9C1274 * L_7 = (Func_2_t2EBF98B0BA555D9F0633C9BCCBE3DF332B9C1274 *)__this->get_predicate_4();
		if (!L_7)
		{
			goto IL_004d;
		}
	}
	{
		Func_2_t2EBF98B0BA555D9F0633C9BCCBE3DF332B9C1274 * L_8 = (Func_2_t2EBF98B0BA555D9F0633C9BCCBE3DF332B9C1274 *)__this->get_predicate_4();
		int32_t L_9 = V_1;
		NullCheck((Func_2_t2EBF98B0BA555D9F0633C9BCCBE3DF332B9C1274 *)L_8);
		bool L_10;
		L_10 = ((  bool (*) (Func_2_t2EBF98B0BA555D9F0633C9BCCBE3DF332B9C1274 *, int32_t, const RuntimeMethod*))IL2CPP_RGCTX_METHOD_INFO(method->klass->rgctx_data, 6)->methodPointer)((Func_2_t2EBF98B0BA555D9F0633C9BCCBE3DF332B9C1274 *)L_8, (int32_t)L_9, /*hidden argument*/IL2CPP_RGCTX_METHOD_INFO(method->klass->rgctx_data, 6));
		if (!L_10)
		{
			goto IL_0061;
		}
	}

IL_004d:
	{
		Func_2_t401E8A228CE43E56CCE9280AD9C6D87CC73A0123 * L_11 = (Func_2_t401E8A228CE43E56CCE9280AD9C6D87CC73A0123 *)__this->get_selector_5();
		int32_t L_12 = V_1;
		NullCheck((Func_2_t401E8A228CE43E56CCE9280AD9C6D87CC73A0123 *)L_11);
		RuntimeObject * L_13;
		L_13 = ((  RuntimeObject * (*) (Func_2_t401E8A228CE43E56CCE9280AD9C6D87CC73A0123 *, int32_t, const RuntimeMethod*))IL2CPP_RGCTX_METHOD_INFO(method->klass->rgctx_data, 7)->methodPointer)((Func_2_t401E8A228CE43E56CCE9280AD9C6D87CC73A0123 *)L_11, (int32_t)L_12, /*hidden argument*/IL2CPP_RGCTX_METHOD_INFO(method->klass->rgctx_data, 7));
		((Iterator_1_t674ABE41CF4096D4BE4D51E21FEBDADBF74CC279 *)__this)->set_current_2(L_13);
		return (bool)1;
	}

IL_0061:
	{
		Enumerator_t7BA00929E14A2F2A62CE085585044A3FEB2C5F3C * L_14 = (Enumerator_t7BA00929E14A2F2A62CE085585044A3FEB2C5F3C *)__this->get_address_of_enumerator_6();
		bool L_15;
		L_15 = Enumerator_MoveNext_m40FD166B6757334A2BBCF67238EFDF70D727A4A6((Enumerator_t7BA00929E14A2F2A62CE085585044A3FEB2C5F3C *)(Enumerator_t7BA00929E14A2F2A62CE085585044A3FEB2C5F3C *)L_14, /*hidden argument*/IL2CPP_RGCTX_METHOD_INFO(method->klass->rgctx_data, 8));
		if (L_15)
		{
			goto IL_002b;
		}
	}
	{
		NullCheck((Iterator_1_t674ABE41CF4096D4BE4D51E21FEBDADBF74CC279 *)__this);
		VirtActionInvoker0::Invoke(12 /* System.Void System.Linq.Enumerable/Iterator`1<System.Object>::Dispose() */, (Iterator_1_t674ABE41CF4096D4BE4D51E21FEBDADBF74CC279 *)__this);
	}

IL_0074:
	{
		return (bool)0;
	}
}
// System.Collections.Generic.IEnumerable`1<TResult> System.Linq.Enumerable/WhereSelectListIterator`2<System.Int32,System.Object>::Where(System.Func`2<TResult,System.Boolean>)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR RuntimeObject* WhereSelectListIterator_2_Where_m9633A851E09C546940C2D5C7EF8CB7C501784EB3_gshared (WhereSelectListIterator_2_tA41D93FF12E41BB5A5BEA27AEED367695ADACEA4 * __this, Func_2_t99409DECFF50F0FA9B427C863AC6C99C66E6F9F8 * ___predicate0, const RuntimeMethod* method)
{
	{
		Func_2_t99409DECFF50F0FA9B427C863AC6C99C66E6F9F8 * L_0 = ___predicate0;
		WhereEnumerableIterator_1_t1E9FDCFD8F8136C6A5A5740C1E093EF03F0B5CE0 * L_1 = (WhereEnumerableIterator_1_t1E9FDCFD8F8136C6A5A5740C1E093EF03F0B5CE0 *)il2cpp_codegen_object_new(IL2CPP_RGCTX_DATA(method->klass->rgctx_data, 10));
		((  void (*) (WhereEnumerableIterator_1_t1E9FDCFD8F8136C6A5A5740C1E093EF03F0B5CE0 *, RuntimeObject*, Func_2_t99409DECFF50F0FA9B427C863AC6C99C66E6F9F8 *, const RuntimeMethod*))IL2CPP_RGCTX_METHOD_INFO(method->klass->rgctx_data, 11)->methodPointer)(L_1, (RuntimeObject*)__this, (Func_2_t99409DECFF50F0FA9B427C863AC6C99C66E6F9F8 *)L_0, /*hidden argument*/IL2CPP_RGCTX_METHOD_INFO(method->klass->rgctx_data, 11));
		return (RuntimeObject*)L_1;
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
// System.Void System.Linq.Enumerable/WhereSelectListIterator`2<System.Int32,System.Single>::.ctor(System.Collections.Generic.List`1<TSource>,System.Func`2<TSource,System.Boolean>,System.Func`2<TSource,TResult>)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void WhereSelectListIterator_2__ctor_mD0F22E680E4B429387D727945B0B06AF6B95820D_gshared (WhereSelectListIterator_2_tBCA9468991E9C8B9F4178D0FA0C99545886B7F06 * __this, List_1_t260B41F956D673396C33A4CF94E8D6C4389EACB7 * ___source0, Func_2_t2EBF98B0BA555D9F0633C9BCCBE3DF332B9C1274 * ___predicate1, Func_2_t1452DFFA61F60F54CF3A78C987C4F98906EFD2B6 * ___selector2, const RuntimeMethod* method)
{
	{
		NullCheck((Iterator_1_t859CAAB8DD3B63D3758E13D2802ED7523B331199 *)__this);
		((  void (*) (Iterator_1_t859CAAB8DD3B63D3758E13D2802ED7523B331199 *, const RuntimeMethod*))IL2CPP_RGCTX_METHOD_INFO(method->klass->rgctx_data, 0)->methodPointer)((Iterator_1_t859CAAB8DD3B63D3758E13D2802ED7523B331199 *)__this, /*hidden argument*/IL2CPP_RGCTX_METHOD_INFO(method->klass->rgctx_data, 0));
		List_1_t260B41F956D673396C33A4CF94E8D6C4389EACB7 * L_0 = ___source0;
		__this->set_source_3(L_0);
		Func_2_t2EBF98B0BA555D9F0633C9BCCBE3DF332B9C1274 * L_1 = ___predicate1;
		__this->set_predicate_4(L_1);
		Func_2_t1452DFFA61F60F54CF3A78C987C4F98906EFD2B6 * L_2 = ___selector2;
		__this->set_selector_5(L_2);
		return;
	}
}
// System.Linq.Enumerable/Iterator`1<TResult> System.Linq.Enumerable/WhereSelectListIterator`2<System.Int32,System.Single>::Clone()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR Iterator_1_t859CAAB8DD3B63D3758E13D2802ED7523B331199 * WhereSelectListIterator_2_Clone_mAE64D0D473635D8F2970A87ACAC846D2E9A986AF_gshared (WhereSelectListIterator_2_tBCA9468991E9C8B9F4178D0FA0C99545886B7F06 * __this, const RuntimeMethod* method)
{
	{
		List_1_t260B41F956D673396C33A4CF94E8D6C4389EACB7 * L_0 = (List_1_t260B41F956D673396C33A4CF94E8D6C4389EACB7 *)__this->get_source_3();
		Func_2_t2EBF98B0BA555D9F0633C9BCCBE3DF332B9C1274 * L_1 = (Func_2_t2EBF98B0BA555D9F0633C9BCCBE3DF332B9C1274 *)__this->get_predicate_4();
		Func_2_t1452DFFA61F60F54CF3A78C987C4F98906EFD2B6 * L_2 = (Func_2_t1452DFFA61F60F54CF3A78C987C4F98906EFD2B6 *)__this->get_selector_5();
		WhereSelectListIterator_2_tBCA9468991E9C8B9F4178D0FA0C99545886B7F06 * L_3 = (WhereSelectListIterator_2_tBCA9468991E9C8B9F4178D0FA0C99545886B7F06 *)il2cpp_codegen_object_new(IL2CPP_RGCTX_DATA(method->klass->rgctx_data, 2));
		((  void (*) (WhereSelectListIterator_2_tBCA9468991E9C8B9F4178D0FA0C99545886B7F06 *, List_1_t260B41F956D673396C33A4CF94E8D6C4389EACB7 *, Func_2_t2EBF98B0BA555D9F0633C9BCCBE3DF332B9C1274 *, Func_2_t1452DFFA61F60F54CF3A78C987C4F98906EFD2B6 *, const RuntimeMethod*))IL2CPP_RGCTX_METHOD_INFO(method->klass->rgctx_data, 3)->methodPointer)(L_3, (List_1_t260B41F956D673396C33A4CF94E8D6C4389EACB7 *)L_0, (Func_2_t2EBF98B0BA555D9F0633C9BCCBE3DF332B9C1274 *)L_1, (Func_2_t1452DFFA61F60F54CF3A78C987C4F98906EFD2B6 *)L_2, /*hidden argument*/IL2CPP_RGCTX_METHOD_INFO(method->klass->rgctx_data, 3));
		return (Iterator_1_t859CAAB8DD3B63D3758E13D2802ED7523B331199 *)L_3;
	}
}
// System.Boolean System.Linq.Enumerable/WhereSelectListIterator`2<System.Int32,System.Single>::MoveNext()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR bool WhereSelectListIterator_2_MoveNext_m29234E904F32B85A74F888428F60230FF7AE5ED7_gshared (WhereSelectListIterator_2_tBCA9468991E9C8B9F4178D0FA0C99545886B7F06 * __this, const RuntimeMethod* method)
{
	int32_t V_0 = 0;
	int32_t V_1 = 0;
	{
		int32_t L_0 = (int32_t)((Iterator_1_t859CAAB8DD3B63D3758E13D2802ED7523B331199 *)__this)->get_state_1();
		V_0 = (int32_t)L_0;
		int32_t L_1 = V_0;
		if ((((int32_t)L_1) == ((int32_t)1)))
		{
			goto IL_0011;
		}
	}
	{
		int32_t L_2 = V_0;
		if ((((int32_t)L_2) == ((int32_t)2)))
		{
			goto IL_0061;
		}
	}
	{
		goto IL_0074;
	}

IL_0011:
	{
		List_1_t260B41F956D673396C33A4CF94E8D6C4389EACB7 * L_3 = (List_1_t260B41F956D673396C33A4CF94E8D6C4389EACB7 *)__this->get_source_3();
		NullCheck((List_1_t260B41F956D673396C33A4CF94E8D6C4389EACB7 *)L_3);
		Enumerator_t7BA00929E14A2F2A62CE085585044A3FEB2C5F3C  L_4;
		L_4 = ((  Enumerator_t7BA00929E14A2F2A62CE085585044A3FEB2C5F3C  (*) (List_1_t260B41F956D673396C33A4CF94E8D6C4389EACB7 *, const RuntimeMethod*))IL2CPP_RGCTX_METHOD_INFO(method->klass->rgctx_data, 4)->methodPointer)((List_1_t260B41F956D673396C33A4CF94E8D6C4389EACB7 *)L_3, /*hidden argument*/IL2CPP_RGCTX_METHOD_INFO(method->klass->rgctx_data, 4));
		__this->set_enumerator_6(L_4);
		((Iterator_1_t859CAAB8DD3B63D3758E13D2802ED7523B331199 *)__this)->set_state_1(2);
		goto IL_0061;
	}

IL_002b:
	{
		Enumerator_t7BA00929E14A2F2A62CE085585044A3FEB2C5F3C * L_5 = (Enumerator_t7BA00929E14A2F2A62CE085585044A3FEB2C5F3C *)__this->get_address_of_enumerator_6();
		int32_t L_6;
		L_6 = Enumerator_get_Current_m6BBD624C51F7E20D347FE5894A6ECA94B8011181_inline((Enumerator_t7BA00929E14A2F2A62CE085585044A3FEB2C5F3C *)(Enumerator_t7BA00929E14A2F2A62CE085585044A3FEB2C5F3C *)L_5, /*hidden argument*/IL2CPP_RGCTX_METHOD_INFO(method->klass->rgctx_data, 5));
		V_1 = (int32_t)L_6;
		Func_2_t2EBF98B0BA555D9F0633C9BCCBE3DF332B9C1274 * L_7 = (Func_2_t2EBF98B0BA555D9F0633C9BCCBE3DF332B9C1274 *)__this->get_predicate_4();
		if (!L_7)
		{
			goto IL_004d;
		}
	}
	{
		Func_2_t2EBF98B0BA555D9F0633C9BCCBE3DF332B9C1274 * L_8 = (Func_2_t2EBF98B0BA555D9F0633C9BCCBE3DF332B9C1274 *)__this->get_predicate_4();
		int32_t L_9 = V_1;
		NullCheck((Func_2_t2EBF98B0BA555D9F0633C9BCCBE3DF332B9C1274 *)L_8);
		bool L_10;
		L_10 = ((  bool (*) (Func_2_t2EBF98B0BA555D9F0633C9BCCBE3DF332B9C1274 *, int32_t, const RuntimeMethod*))IL2CPP_RGCTX_METHOD_INFO(method->klass->rgctx_data, 6)->methodPointer)((Func_2_t2EBF98B0BA555D9F0633C9BCCBE3DF332B9C1274 *)L_8, (int32_t)L_9, /*hidden argument*/IL2CPP_RGCTX_METHOD_INFO(method->klass->rgctx_data, 6));
		if (!L_10)
		{
			goto IL_0061;
		}
	}

IL_004d:
	{
		Func_2_t1452DFFA61F60F54CF3A78C987C4F98906EFD2B6 * L_11 = (Func_2_t1452DFFA61F60F54CF3A78C987C4F98906EFD2B6 *)__this->get_selector_5();
		int32_t L_12 = V_1;
		NullCheck((Func_2_t1452DFFA61F60F54CF3A78C987C4F98906EFD2B6 *)L_11);
		float L_13;
		L_13 = ((  float (*) (Func_2_t1452DFFA61F60F54CF3A78C987C4F98906EFD2B6 *, int32_t, const RuntimeMethod*))IL2CPP_RGCTX_METHOD_INFO(method->klass->rgctx_data, 7)->methodPointer)((Func_2_t1452DFFA61F60F54CF3A78C987C4F98906EFD2B6 *)L_11, (int32_t)L_12, /*hidden argument*/IL2CPP_RGCTX_METHOD_INFO(method->klass->rgctx_data, 7));
		((Iterator_1_t859CAAB8DD3B63D3758E13D2802ED7523B331199 *)__this)->set_current_2(L_13);
		return (bool)1;
	}

IL_0061:
	{
		Enumerator_t7BA00929E14A2F2A62CE085585044A3FEB2C5F3C * L_14 = (Enumerator_t7BA00929E14A2F2A62CE085585044A3FEB2C5F3C *)__this->get_address_of_enumerator_6();
		bool L_15;
		L_15 = Enumerator_MoveNext_m40FD166B6757334A2BBCF67238EFDF70D727A4A6((Enumerator_t7BA00929E14A2F2A62CE085585044A3FEB2C5F3C *)(Enumerator_t7BA00929E14A2F2A62CE085585044A3FEB2C5F3C *)L_14, /*hidden argument*/IL2CPP_RGCTX_METHOD_INFO(method->klass->rgctx_data, 8));
		if (L_15)
		{
			goto IL_002b;
		}
	}
	{
		NullCheck((Iterator_1_t859CAAB8DD3B63D3758E13D2802ED7523B331199 *)__this);
		VirtActionInvoker0::Invoke(12 /* System.Void System.Linq.Enumerable/Iterator`1<System.Single>::Dispose() */, (Iterator_1_t859CAAB8DD3B63D3758E13D2802ED7523B331199 *)__this);
	}

IL_0074:
	{
		return (bool)0;
	}
}
// System.Collections.Generic.IEnumerable`1<TResult> System.Linq.Enumerable/WhereSelectListIterator`2<System.Int32,System.Single>::Where(System.Func`2<TResult,System.Boolean>)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR RuntimeObject* WhereSelectListIterator_2_Where_m1737FB827F03C5E8C7CA71544B9FD803C25A6315_gshared (WhereSelectListIterator_2_tBCA9468991E9C8B9F4178D0FA0C99545886B7F06 * __this, Func_2_t7214BC9C9A47482C751067B9A197D164F4041A3A * ___predicate0, const RuntimeMethod* method)
{
	{
		Func_2_t7214BC9C9A47482C751067B9A197D164F4041A3A * L_0 = ___predicate0;
		WhereEnumerableIterator_1_tC5339F8E75587CBA511FF3EDFBA6D5A81E54057F * L_1 = (WhereEnumerableIterator_1_tC5339F8E75587CBA511FF3EDFBA6D5A81E54057F *)il2cpp_codegen_object_new(IL2CPP_RGCTX_DATA(method->klass->rgctx_data, 10));
		((  void (*) (WhereEnumerableIterator_1_tC5339F8E75587CBA511FF3EDFBA6D5A81E54057F *, RuntimeObject*, Func_2_t7214BC9C9A47482C751067B9A197D164F4041A3A *, const RuntimeMethod*))IL2CPP_RGCTX_METHOD_INFO(method->klass->rgctx_data, 11)->methodPointer)(L_1, (RuntimeObject*)__this, (Func_2_t7214BC9C9A47482C751067B9A197D164F4041A3A *)L_0, /*hidden argument*/IL2CPP_RGCTX_METHOD_INFO(method->klass->rgctx_data, 11));
		return (RuntimeObject*)L_1;
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
// System.Void System.Linq.Enumerable/WhereSelectListIterator`2<System.Int64,System.Object>::.ctor(System.Collections.Generic.List`1<TSource>,System.Func`2<TSource,System.Boolean>,System.Func`2<TSource,TResult>)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void WhereSelectListIterator_2__ctor_mE0AAD2EB48AC6A8B6089170A8B810E713950A733_gshared (WhereSelectListIterator_2_t87107416F9D6AA1D41ED2E04567ABE36603547C9 * __this, List_1_tC465E4AAC82F54C0A79B2CE3B797531B10B9ACE4 * ___source0, Func_2_t03B9AF86FB7E93B62590F1CBD16276EF7AA1B215 * ___predicate1, Func_2_tB6B8AC34A03E8EEE1C7FF71178B07B46BC827B7B * ___selector2, const RuntimeMethod* method)
{
	{
		NullCheck((Iterator_1_t674ABE41CF4096D4BE4D51E21FEBDADBF74CC279 *)__this);
		((  void (*) (Iterator_1_t674ABE41CF4096D4BE4D51E21FEBDADBF74CC279 *, const RuntimeMethod*))IL2CPP_RGCTX_METHOD_INFO(method->klass->rgctx_data, 0)->methodPointer)((Iterator_1_t674ABE41CF4096D4BE4D51E21FEBDADBF74CC279 *)__this, /*hidden argument*/IL2CPP_RGCTX_METHOD_INFO(method->klass->rgctx_data, 0));
		List_1_tC465E4AAC82F54C0A79B2CE3B797531B10B9ACE4 * L_0 = ___source0;
		__this->set_source_3(L_0);
		Func_2_t03B9AF86FB7E93B62590F1CBD16276EF7AA1B215 * L_1 = ___predicate1;
		__this->set_predicate_4(L_1);
		Func_2_tB6B8AC34A03E8EEE1C7FF71178B07B46BC827B7B * L_2 = ___selector2;
		__this->set_selector_5(L_2);
		return;
	}
}
// System.Linq.Enumerable/Iterator`1<TResult> System.Linq.Enumerable/WhereSelectListIterator`2<System.Int64,System.Object>::Clone()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR Iterator_1_t674ABE41CF4096D4BE4D51E21FEBDADBF74CC279 * WhereSelectListIterator_2_Clone_m8A608BEFA82A82CD91B0892480E99A37B6E3BA2D_gshared (WhereSelectListIterator_2_t87107416F9D6AA1D41ED2E04567ABE36603547C9 * __this, const RuntimeMethod* method)
{
	{
		List_1_tC465E4AAC82F54C0A79B2CE3B797531B10B9ACE4 * L_0 = (List_1_tC465E4AAC82F54C0A79B2CE3B797531B10B9ACE4 *)__this->get_source_3();
		Func_2_t03B9AF86FB7E93B62590F1CBD16276EF7AA1B215 * L_1 = (Func_2_t03B9AF86FB7E93B62590F1CBD16276EF7AA1B215 *)__this->get_predicate_4();
		Func_2_tB6B8AC34A03E8EEE1C7FF71178B07B46BC827B7B * L_2 = (Func_2_tB6B8AC34A03E8EEE1C7FF71178B07B46BC827B7B *)__this->get_selector_5();
		WhereSelectListIterator_2_t87107416F9D6AA1D41ED2E04567ABE36603547C9 * L_3 = (WhereSelectListIterator_2_t87107416F9D6AA1D41ED2E04567ABE36603547C9 *)il2cpp_codegen_object_new(IL2CPP_RGCTX_DATA(method->klass->rgctx_data, 2));
		((  void (*) (WhereSelectListIterator_2_t87107416F9D6AA1D41ED2E04567ABE36603547C9 *, List_1_tC465E4AAC82F54C0A79B2CE3B797531B10B9ACE4 *, Func_2_t03B9AF86FB7E93B62590F1CBD16276EF7AA1B215 *, Func_2_tB6B8AC34A03E8EEE1C7FF71178B07B46BC827B7B *, const RuntimeMethod*))IL2CPP_RGCTX_METHOD_INFO(method->klass->rgctx_data, 3)->methodPointer)(L_3, (List_1_tC465E4AAC82F54C0A79B2CE3B797531B10B9ACE4 *)L_0, (Func_2_t03B9AF86FB7E93B62590F1CBD16276EF7AA1B215 *)L_1, (Func_2_tB6B8AC34A03E8EEE1C7FF71178B07B46BC827B7B *)L_2, /*hidden argument*/IL2CPP_RGCTX_METHOD_INFO(method->klass->rgctx_data, 3));
		return (Iterator_1_t674ABE41CF4096D4BE4D51E21FEBDADBF74CC279 *)L_3;
	}
}
// System.Boolean System.Linq.Enumerable/WhereSelectListIterator`2<System.Int64,System.Object>::MoveNext()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR bool WhereSelectListIterator_2_MoveNext_mE39226E6766D0AADD5DC6EA3010CE7AC33040E91_gshared (WhereSelectListIterator_2_t87107416F9D6AA1D41ED2E04567ABE36603547C9 * __this, const RuntimeMethod* method)
{
	int32_t V_0 = 0;
	int64_t V_1 = 0;
	{
		int32_t L_0 = (int32_t)((Iterator_1_t674ABE41CF4096D4BE4D51E21FEBDADBF74CC279 *)__this)->get_state_1();
		V_0 = (int32_t)L_0;
		int32_t L_1 = V_0;
		if ((((int32_t)L_1) == ((int32_t)1)))
		{
			goto IL_0011;
		}
	}
	{
		int32_t L_2 = V_0;
		if ((((int32_t)L_2) == ((int32_t)2)))
		{
			goto IL_0061;
		}
	}
	{
		goto IL_0074;
	}

IL_0011:
	{
		List_1_tC465E4AAC82F54C0A79B2CE3B797531B10B9ACE4 * L_3 = (List_1_tC465E4AAC82F54C0A79B2CE3B797531B10B9ACE4 *)__this->get_source_3();
		NullCheck((List_1_tC465E4AAC82F54C0A79B2CE3B797531B10B9ACE4 *)L_3);
		Enumerator_t1C02C38119DFDA075166A979AE2B70CCA911ED37  L_4;
		L_4 = ((  Enumerator_t1C02C38119DFDA075166A979AE2B70CCA911ED37  (*) (List_1_tC465E4AAC82F54C0A79B2CE3B797531B10B9ACE4 *, const RuntimeMethod*))IL2CPP_RGCTX_METHOD_INFO(method->klass->rgctx_data, 4)->methodPointer)((List_1_tC465E4AAC82F54C0A79B2CE3B797531B10B9ACE4 *)L_3, /*hidden argument*/IL2CPP_RGCTX_METHOD_INFO(method->klass->rgctx_data, 4));
		__this->set_enumerator_6(L_4);
		((Iterator_1_t674ABE41CF4096D4BE4D51E21FEBDADBF74CC279 *)__this)->set_state_1(2);
		goto IL_0061;
	}

IL_002b:
	{
		Enumerator_t1C02C38119DFDA075166A979AE2B70CCA911ED37 * L_5 = (Enumerator_t1C02C38119DFDA075166A979AE2B70CCA911ED37 *)__this->get_address_of_enumerator_6();
		int64_t L_6;
		L_6 = Enumerator_get_Current_m9EBEA7E72E64499B4BED94F77DF82E7B8C3F1CE0_inline((Enumerator_t1C02C38119DFDA075166A979AE2B70CCA911ED37 *)(Enumerator_t1C02C38119DFDA075166A979AE2B70CCA911ED37 *)L_5, /*hidden argument*/IL2CPP_RGCTX_METHOD_INFO(method->klass->rgctx_data, 5));
		V_1 = (int64_t)L_6;
		Func_2_t03B9AF86FB7E93B62590F1CBD16276EF7AA1B215 * L_7 = (Func_2_t03B9AF86FB7E93B62590F1CBD16276EF7AA1B215 *)__this->get_predicate_4();
		if (!L_7)
		{
			goto IL_004d;
		}
	}
	{
		Func_2_t03B9AF86FB7E93B62590F1CBD16276EF7AA1B215 * L_8 = (Func_2_t03B9AF86FB7E93B62590F1CBD16276EF7AA1B215 *)__this->get_predicate_4();
		int64_t L_9 = V_1;
		NullCheck((Func_2_t03B9AF86FB7E93B62590F1CBD16276EF7AA1B215 *)L_8);
		bool L_10;
		L_10 = ((  bool (*) (Func_2_t03B9AF86FB7E93B62590F1CBD16276EF7AA1B215 *, int64_t, const RuntimeMethod*))IL2CPP_RGCTX_METHOD_INFO(method->klass->rgctx_data, 6)->methodPointer)((Func_2_t03B9AF86FB7E93B62590F1CBD16276EF7AA1B215 *)L_8, (int64_t)L_9, /*hidden argument*/IL2CPP_RGCTX_METHOD_INFO(method->klass->rgctx_data, 6));
		if (!L_10)
		{
			goto IL_0061;
		}
	}

IL_004d:
	{
		Func_2_tB6B8AC34A03E8EEE1C7FF71178B07B46BC827B7B * L_11 = (Func_2_tB6B8AC34A03E8EEE1C7FF71178B07B46BC827B7B *)__this->get_selector_5();
		int64_t L_12 = V_1;
		NullCheck((Func_2_tB6B8AC34A03E8EEE1C7FF71178B07B46BC827B7B *)L_11);
		RuntimeObject * L_13;
		L_13 = ((  RuntimeObject * (*) (Func_2_tB6B8AC34A03E8EEE1C7FF71178B07B46BC827B7B *, int64_t, const RuntimeMethod*))IL2CPP_RGCTX_METHOD_INFO(method->klass->rgctx_data, 7)->methodPointer)((Func_2_tB6B8AC34A03E8EEE1C7FF71178B07B46BC827B7B *)L_11, (int64_t)L_12, /*hidden argument*/IL2CPP_RGCTX_METHOD_INFO(method->klass->rgctx_data, 7));
		((Iterator_1_t674ABE41CF4096D4BE4D51E21FEBDADBF74CC279 *)__this)->set_current_2(L_13);
		return (bool)1;
	}

IL_0061:
	{
		Enumerator_t1C02C38119DFDA075166A979AE2B70CCA911ED37 * L_14 = (Enumerator_t1C02C38119DFDA075166A979AE2B70CCA911ED37 *)__this->get_address_of_enumerator_6();
		bool L_15;
		L_15 = Enumerator_MoveNext_m25DAE3260BFED34CE518F60AF8D6768AF47A2DF2((Enumerator_t1C02C38119DFDA075166A979AE2B70CCA911ED37 *)(Enumerator_t1C02C38119DFDA075166A979AE2B70CCA911ED37 *)L_14, /*hidden argument*/IL2CPP_RGCTX_METHOD_INFO(method->klass->rgctx_data, 8));
		if (L_15)
		{
			goto IL_002b;
		}
	}
	{
		NullCheck((Iterator_1_t674ABE41CF4096D4BE4D51E21FEBDADBF74CC279 *)__this);
		VirtActionInvoker0::Invoke(12 /* System.Void System.Linq.Enumerable/Iterator`1<System.Object>::Dispose() */, (Iterator_1_t674ABE41CF4096D4BE4D51E21FEBDADBF74CC279 *)__this);
	}

IL_0074:
	{
		return (bool)0;
	}
}
// System.Collections.Generic.IEnumerable`1<TResult> System.Linq.Enumerable/WhereSelectListIterator`2<System.Int64,System.Object>::Where(System.Func`2<TResult,System.Boolean>)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR RuntimeObject* WhereSelectListIterator_2_Where_m173BA7B55D00AE56A0589B70FEEB3ED00076EEFB_gshared (WhereSelectListIterator_2_t87107416F9D6AA1D41ED2E04567ABE36603547C9 * __this, Func_2_t99409DECFF50F0FA9B427C863AC6C99C66E6F9F8 * ___predicate0, const RuntimeMethod* method)
{
	{
		Func_2_t99409DECFF50F0FA9B427C863AC6C99C66E6F9F8 * L_0 = ___predicate0;
		WhereEnumerableIterator_1_t1E9FDCFD8F8136C6A5A5740C1E093EF03F0B5CE0 * L_1 = (WhereEnumerableIterator_1_t1E9FDCFD8F8136C6A5A5740C1E093EF03F0B5CE0 *)il2cpp_codegen_object_new(IL2CPP_RGCTX_DATA(method->klass->rgctx_data, 10));
		((  void (*) (WhereEnumerableIterator_1_t1E9FDCFD8F8136C6A5A5740C1E093EF03F0B5CE0 *, RuntimeObject*, Func_2_t99409DECFF50F0FA9B427C863AC6C99C66E6F9F8 *, const RuntimeMethod*))IL2CPP_RGCTX_METHOD_INFO(method->klass->rgctx_data, 11)->methodPointer)(L_1, (RuntimeObject*)__this, (Func_2_t99409DECFF50F0FA9B427C863AC6C99C66E6F9F8 *)L_0, /*hidden argument*/IL2CPP_RGCTX_METHOD_INFO(method->klass->rgctx_data, 11));
		return (RuntimeObject*)L_1;
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
// System.Void System.Linq.Enumerable/WhereSelectListIterator`2<System.Object,System.Nullable`1<System.Decimal>>::.ctor(System.Collections.Generic.List`1<TSource>,System.Func`2<TSource,System.Boolean>,System.Func`2<TSource,TResult>)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void WhereSelectListIterator_2__ctor_mD66B977763AF267390344DA7C66D2F84382900A7_gshared (WhereSelectListIterator_2_t49F3CEC3F8DE6BE9B2E0E65A36314CEEED603DE7 * __this, List_1_t3F94120C77410A62EAE48421CF166B83AB95A2F5 * ___source0, Func_2_t99409DECFF50F0FA9B427C863AC6C99C66E6F9F8 * ___predicate1, Func_2_t3818905EA774DF4C16A3B852ECBDEAA1B10478B4 * ___selector2, const RuntimeMethod* method)
{
	{
		NullCheck((Iterator_1_tC3AC38DE0A9857A77F64882DC49BB78318A5EF00 *)__this);
		((  void (*) (Iterator_1_tC3AC38DE0A9857A77F64882DC49BB78318A5EF00 *, const RuntimeMethod*))IL2CPP_RGCTX_METHOD_INFO(method->klass->rgctx_data, 0)->methodPointer)((Iterator_1_tC3AC38DE0A9857A77F64882DC49BB78318A5EF00 *)__this, /*hidden argument*/IL2CPP_RGCTX_METHOD_INFO(method->klass->rgctx_data, 0));
		List_1_t3F94120C77410A62EAE48421CF166B83AB95A2F5 * L_0 = ___source0;
		__this->set_source_3(L_0);
		Func_2_t99409DECFF50F0FA9B427C863AC6C99C66E6F9F8 * L_1 = ___predicate1;
		__this->set_predicate_4(L_1);
		Func_2_t3818905EA774DF4C16A3B852ECBDEAA1B10478B4 * L_2 = ___selector2;
		__this->set_selector_5(L_2);
		return;
	}
}
// System.Linq.Enumerable/Iterator`1<TResult> System.Linq.Enumerable/WhereSelectListIterator`2<System.Object,System.Nullable`1<System.Decimal>>::Clone()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR Iterator_1_tC3AC38DE0A9857A77F64882DC49BB78318A5EF00 * WhereSelectListIterator_2_Clone_mC2EB492F43E66320AA63F8BDD6B52CEC254FFC81_gshared (WhereSelectListIterator_2_t49F3CEC3F8DE6BE9B2E0E65A36314CEEED603DE7 * __this, const RuntimeMethod* method)
{
	{
		List_1_t3F94120C77410A62EAE48421CF166B83AB95A2F5 * L_0 = (List_1_t3F94120C77410A62EAE48421CF166B83AB95A2F5 *)__this->get_source_3();
		Func_2_t99409DECFF50F0FA9B427C863AC6C99C66E6F9F8 * L_1 = (Func_2_t99409DECFF50F0FA9B427C863AC6C99C66E6F9F8 *)__this->get_predicate_4();
		Func_2_t3818905EA774DF4C16A3B852ECBDEAA1B10478B4 * L_2 = (Func_2_t3818905EA774DF4C16A3B852ECBDEAA1B10478B4 *)__this->get_selector_5();
		WhereSelectListIterator_2_t49F3CEC3F8DE6BE9B2E0E65A36314CEEED603DE7 * L_3 = (WhereSelectListIterator_2_t49F3CEC3F8DE6BE9B2E0E65A36314CEEED603DE7 *)il2cpp_codegen_object_new(IL2CPP_RGCTX_DATA(method->klass->rgctx_data, 2));
		((  void (*) (WhereSelectListIterator_2_t49F3CEC3F8DE6BE9B2E0E65A36314CEEED603DE7 *, List_1_t3F94120C77410A62EAE48421CF166B83AB95A2F5 *, Func_2_t99409DECFF50F0FA9B427C863AC6C99C66E6F9F8 *, Func_2_t3818905EA774DF4C16A3B852ECBDEAA1B10478B4 *, const RuntimeMethod*))IL2CPP_RGCTX_METHOD_INFO(method->klass->rgctx_data, 3)->methodPointer)(L_3, (List_1_t3F94120C77410A62EAE48421CF166B83AB95A2F5 *)L_0, (Func_2_t99409DECFF50F0FA9B427C863AC6C99C66E6F9F8 *)L_1, (Func_2_t3818905EA774DF4C16A3B852ECBDEAA1B10478B4 *)L_2, /*hidden argument*/IL2CPP_RGCTX_METHOD_INFO(method->klass->rgctx_data, 3));
		return (Iterator_1_tC3AC38DE0A9857A77F64882DC49BB78318A5EF00 *)L_3;
	}
}
// System.Boolean System.Linq.Enumerable/WhereSelectListIterator`2<System.Object,System.Nullable`1<System.Decimal>>::MoveNext()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR bool WhereSelectListIterator_2_MoveNext_m4E936CE48DF6C087B8EB8C34E0E96245930C4214_gshared (WhereSelectListIterator_2_t49F3CEC3F8DE6BE9B2E0E65A36314CEEED603DE7 * __this, const RuntimeMethod* method)
{
	int32_t V_0 = 0;
	RuntimeObject * V_1 = NULL;
	{
		int32_t L_0 = (int32_t)((Iterator_1_tC3AC38DE0A9857A77F64882DC49BB78318A5EF00 *)__this)->get_state_1();
		V_0 = (int32_t)L_0;
		int32_t L_1 = V_0;
		if ((((int32_t)L_1) == ((int32_t)1)))
		{
			goto IL_0011;
		}
	}
	{
		int32_t L_2 = V_0;
		if ((((int32_t)L_2) == ((int32_t)2)))
		{
			goto IL_0061;
		}
	}
	{
		goto IL_0074;
	}

IL_0011:
	{
		List_1_t3F94120C77410A62EAE48421CF166B83AB95A2F5 * L_3 = (List_1_t3F94120C77410A62EAE48421CF166B83AB95A2F5 *)__this->get_source_3();
		NullCheck((List_1_t3F94120C77410A62EAE48421CF166B83AB95A2F5 *)L_3);
		Enumerator_tB6009981BD4E3881E3EC83627255A24198F902D6  L_4;
		L_4 = ((  Enumerator_tB6009981BD4E3881E3EC83627255A24198F902D6  (*) (List_1_t3F94120C77410A62EAE48421CF166B83AB95A2F5 *, const RuntimeMethod*))IL2CPP_RGCTX_METHOD_INFO(method->klass->rgctx_data, 4)->methodPointer)((List_1_t3F94120C77410A62EAE48421CF166B83AB95A2F5 *)L_3, /*hidden argument*/IL2CPP_RGCTX_METHOD_INFO(method->klass->rgctx_data, 4));
		__this->set_enumerator_6(L_4);
		((Iterator_1_tC3AC38DE0A9857A77F64882DC49BB78318A5EF00 *)__this)->set_state_1(2);
		goto IL_0061;
	}

IL_002b:
	{
		Enumerator_tB6009981BD4E3881E3EC83627255A24198F902D6 * L_5 = (Enumerator_tB6009981BD4E3881E3EC83627255A24198F902D6 *)__this->get_address_of_enumerator_6();
		RuntimeObject * L_6;
		L_6 = Enumerator_get_Current_m9C4EBBD2108B51885E750F927D7936290C8E20EE_inline((Enumerator_tB6009981BD4E3881E3EC83627255A24198F902D6 *)(Enumerator_tB6009981BD4E3881E3EC83627255A24198F902D6 *)L_5, /*hidden argument*/IL2CPP_RGCTX_METHOD_INFO(method->klass->rgctx_data, 5));
		V_1 = (RuntimeObject *)L_6;
		Func_2_t99409DECFF50F0FA9B427C863AC6C99C66E6F9F8 * L_7 = (Func_2_t99409DECFF50F0FA9B427C863AC6C99C66E6F9F8 *)__this->get_predicate_4();
		if (!L_7)
		{
			goto IL_004d;
		}
	}
	{
		Func_2_t99409DECFF50F0FA9B427C863AC6C99C66E6F9F8 * L_8 = (Func_2_t99409DECFF50F0FA9B427C863AC6C99C66E6F9F8 *)__this->get_predicate_4();
		RuntimeObject * L_9 = V_1;
		NullCheck((Func_2_t99409DECFF50F0FA9B427C863AC6C99C66E6F9F8 *)L_8);
		bool L_10;
		L_10 = ((  bool (*) (Func_2_t99409DECFF50F0FA9B427C863AC6C99C66E6F9F8 *, RuntimeObject *, const RuntimeMethod*))IL2CPP_RGCTX_METHOD_INFO(method->klass->rgctx_data, 6)->methodPointer)((Func_2_t99409DECFF50F0FA9B427C863AC6C99C66E6F9F8 *)L_8, (RuntimeObject *)L_9, /*hidden argument*/IL2CPP_RGCTX_METHOD_INFO(method->klass->rgctx_data, 6));
		if (!L_10)
		{
			goto IL_0061;
		}
	}

IL_004d:
	{
		Func_2_t3818905EA774DF4C16A3B852ECBDEAA1B10478B4 * L_11 = (Func_2_t3818905EA774DF4C16A3B852ECBDEAA1B10478B4 *)__this->get_selector_5();
		RuntimeObject * L_12 = V_1;
		NullCheck((Func_2_t3818905EA774DF4C16A3B852ECBDEAA1B10478B4 *)L_11);
		Nullable_1_tD7EB7EB39E548910812AA4DC702F9C7E3E84A84E  L_13;
		L_13 = ((  Nullable_1_tD7EB7EB39E548910812AA4DC702F9C7E3E84A84E  (*) (Func_2_t3818905EA774DF4C16A3B852ECBDEAA1B10478B4 *, RuntimeObject *, const RuntimeMethod*))IL2CPP_RGCTX_METHOD_INFO(method->klass->rgctx_data, 7)->methodPointer)((Func_2_t3818905EA774DF4C16A3B852ECBDEAA1B10478B4 *)L_11, (RuntimeObject *)L_12, /*hidden argument*/IL2CPP_RGCTX_METHOD_INFO(method->klass->rgctx_data, 7));
		((Iterator_1_tC3AC38DE0A9857A77F64882DC49BB78318A5EF00 *)__this)->set_current_2(L_13);
		return (bool)1;
	}

IL_0061:
	{
		Enumerator_tB6009981BD4E3881E3EC83627255A24198F902D6 * L_14 = (Enumerator_tB6009981BD4E3881E3EC83627255A24198F902D6 *)__this->get_address_of_enumerator_6();
		bool L_15;
		L_15 = Enumerator_MoveNext_m2E56233762839CE55C67E00AC8DD3D4D3F6C0DF0((Enumerator_tB6009981BD4E3881E3EC83627255A24198F902D6 *)(Enumerator_tB6009981BD4E3881E3EC83627255A24198F902D6 *)L_14, /*hidden argument*/IL2CPP_RGCTX_METHOD_INFO(method->klass->rgctx_data, 8));
		if (L_15)
		{
			goto IL_002b;
		}
	}
	{
		NullCheck((Iterator_1_tC3AC38DE0A9857A77F64882DC49BB78318A5EF00 *)__this);
		VirtActionInvoker0::Invoke(12 /* System.Void System.Linq.Enumerable/Iterator`1<System.Nullable`1<System.Decimal>>::Dispose() */, (Iterator_1_tC3AC38DE0A9857A77F64882DC49BB78318A5EF00 *)__this);
	}

IL_0074:
	{
		return (bool)0;
	}
}
// System.Collections.Generic.IEnumerable`1<TResult> System.Linq.Enumerable/WhereSelectListIterator`2<System.Object,System.Nullable`1<System.Decimal>>::Where(System.Func`2<TResult,System.Boolean>)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR RuntimeObject* WhereSelectListIterator_2_Where_m51696332F82440298BF63DE396AB05086FE04DB0_gshared (WhereSelectListIterator_2_t49F3CEC3F8DE6BE9B2E0E65A36314CEEED603DE7 * __this, Func_2_t04450D4888681586D3F4812C491231E855EF5DE7 * ___predicate0, const RuntimeMethod* method)
{
	{
		Func_2_t04450D4888681586D3F4812C491231E855EF5DE7 * L_0 = ___predicate0;
		WhereEnumerableIterator_1_tC23C2A31FF955909EB9C6795D474D218DB84F0F5 * L_1 = (WhereEnumerableIterator_1_tC23C2A31FF955909EB9C6795D474D218DB84F0F5 *)il2cpp_codegen_object_new(IL2CPP_RGCTX_DATA(method->klass->rgctx_data, 10));
		((  void (*) (WhereEnumerableIterator_1_tC23C2A31FF955909EB9C6795D474D218DB84F0F5 *, RuntimeObject*, Func_2_t04450D4888681586D3F4812C491231E855EF5DE7 *, const RuntimeMethod*))IL2CPP_RGCTX_METHOD_INFO(method->klass->rgctx_data, 11)->methodPointer)(L_1, (RuntimeObject*)__this, (Func_2_t04450D4888681586D3F4812C491231E855EF5DE7 *)L_0, /*hidden argument*/IL2CPP_RGCTX_METHOD_INFO(method->klass->rgctx_data, 11));
		return (RuntimeObject*)L_1;
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
// System.Void System.Linq.Enumerable/WhereSelectListIterator`2<System.Object,System.Nullable`1<System.Double>>::.ctor(System.Collections.Generic.List`1<TSource>,System.Func`2<TSource,System.Boolean>,System.Func`2<TSource,TResult>)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void WhereSelectListIterator_2__ctor_mD7D0E6AAE5AA891ACD69AC3412AB2DC0C4E8A89E_gshared (WhereSelectListIterator_2_tEE6392F7E2CDC15C2F3490EE288AB2275DEF7D9A * __this, List_1_t3F94120C77410A62EAE48421CF166B83AB95A2F5 * ___source0, Func_2_t99409DECFF50F0FA9B427C863AC6C99C66E6F9F8 * ___predicate1, Func_2_t969BC5FC9B68C7023AE4F7C254A78F446A7609F8 * ___selector2, const RuntimeMethod* method)
{
	{
		NullCheck((Iterator_1_t75B26B5E87871854D759A25738CFE42AF131D6A8 *)__this);
		((  void (*) (Iterator_1_t75B26B5E87871854D759A25738CFE42AF131D6A8 *, const RuntimeMethod*))IL2CPP_RGCTX_METHOD_INFO(method->klass->rgctx_data, 0)->methodPointer)((Iterator_1_t75B26B5E87871854D759A25738CFE42AF131D6A8 *)__this, /*hidden argument*/IL2CPP_RGCTX_METHOD_INFO(method->klass->rgctx_data, 0));
		List_1_t3F94120C77410A62EAE48421CF166B83AB95A2F5 * L_0 = ___source0;
		__this->set_source_3(L_0);
		Func_2_t99409DECFF50F0FA9B427C863AC6C99C66E6F9F8 * L_1 = ___predicate1;
		__this->set_predicate_4(L_1);
		Func_2_t969BC5FC9B68C7023AE4F7C254A78F446A7609F8 * L_2 = ___selector2;
		__this->set_selector_5(L_2);
		return;
	}
}
// System.Linq.Enumerable/Iterator`1<TResult> System.Linq.Enumerable/WhereSelectListIterator`2<System.Object,System.Nullable`1<System.Double>>::Clone()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR Iterator_1_t75B26B5E87871854D759A25738CFE42AF131D6A8 * WhereSelectListIterator_2_Clone_mA972301D80350563FAA280C66A7A13F8FFFF2CEF_gshared (WhereSelectListIterator_2_tEE6392F7E2CDC15C2F3490EE288AB2275DEF7D9A * __this, const RuntimeMethod* method)
{
	{
		List_1_t3F94120C77410A62EAE48421CF166B83AB95A2F5 * L_0 = (List_1_t3F94120C77410A62EAE48421CF166B83AB95A2F5 *)__this->get_source_3();
		Func_2_t99409DECFF50F0FA9B427C863AC6C99C66E6F9F8 * L_1 = (Func_2_t99409DECFF50F0FA9B427C863AC6C99C66E6F9F8 *)__this->get_predicate_4();
		Func_2_t969BC5FC9B68C7023AE4F7C254A78F446A7609F8 * L_2 = (Func_2_t969BC5FC9B68C7023AE4F7C254A78F446A7609F8 *)__this->get_selector_5();
		WhereSelectListIterator_2_tEE6392F7E2CDC15C2F3490EE288AB2275DEF7D9A * L_3 = (WhereSelectListIterator_2_tEE6392F7E2CDC15C2F3490EE288AB2275DEF7D9A *)il2cpp_codegen_object_new(IL2CPP_RGCTX_DATA(method->klass->rgctx_data, 2));
		((  void (*) (WhereSelectListIterator_2_tEE6392F7E2CDC15C2F3490EE288AB2275DEF7D9A *, List_1_t3F94120C77410A62EAE48421CF166B83AB95A2F5 *, Func_2_t99409DECFF50F0FA9B427C863AC6C99C66E6F9F8 *, Func_2_t969BC5FC9B68C7023AE4F7C254A78F446A7609F8 *, const RuntimeMethod*))IL2CPP_RGCTX_METHOD_INFO(method->klass->rgctx_data, 3)->methodPointer)(L_3, (List_1_t3F94120C77410A62EAE48421CF166B83AB95A2F5 *)L_0, (Func_2_t99409DECFF50F0FA9B427C863AC6C99C66E6F9F8 *)L_1, (Func_2_t969BC5FC9B68C7023AE4F7C254A78F446A7609F8 *)L_2, /*hidden argument*/IL2CPP_RGCTX_METHOD_INFO(method->klass->rgctx_data, 3));
		return (Iterator_1_t75B26B5E87871854D759A25738CFE42AF131D6A8 *)L_3;
	}
}
// System.Boolean System.Linq.Enumerable/WhereSelectListIterator`2<System.Object,System.Nullable`1<System.Double>>::MoveNext()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR bool WhereSelectListIterator_2_MoveNext_m69A92676478FDC6F2AE124DCF92EB2CA23F273CE_gshared (WhereSelectListIterator_2_tEE6392F7E2CDC15C2F3490EE288AB2275DEF7D9A * __this, const RuntimeMethod* method)
{
	int32_t V_0 = 0;
	RuntimeObject * V_1 = NULL;
	{
		int32_t L_0 = (int32_t)((Iterator_1_t75B26B5E87871854D759A25738CFE42AF131D6A8 *)__this)->get_state_1();
		V_0 = (int32_t)L_0;
		int32_t L_1 = V_0;
		if ((((int32_t)L_1) == ((int32_t)1)))
		{
			goto IL_0011;
		}
	}
	{
		int32_t L_2 = V_0;
		if ((((int32_t)L_2) == ((int32_t)2)))
		{
			goto IL_0061;
		}
	}
	{
		goto IL_0074;
	}

IL_0011:
	{
		List_1_t3F94120C77410A62EAE48421CF166B83AB95A2F5 * L_3 = (List_1_t3F94120C77410A62EAE48421CF166B83AB95A2F5 *)__this->get_source_3();
		NullCheck((List_1_t3F94120C77410A62EAE48421CF166B83AB95A2F5 *)L_3);
		Enumerator_tB6009981BD4E3881E3EC83627255A24198F902D6  L_4;
		L_4 = ((  Enumerator_tB6009981BD4E3881E3EC83627255A24198F902D6  (*) (List_1_t3F94120C77410A62EAE48421CF166B83AB95A2F5 *, const RuntimeMethod*))IL2CPP_RGCTX_METHOD_INFO(method->klass->rgctx_data, 4)->methodPointer)((List_1_t3F94120C77410A62EAE48421CF166B83AB95A2F5 *)L_3, /*hidden argument*/IL2CPP_RGCTX_METHOD_INFO(method->klass->rgctx_data, 4));
		__this->set_enumerator_6(L_4);
		((Iterator_1_t75B26B5E87871854D759A25738CFE42AF131D6A8 *)__this)->set_state_1(2);
		goto IL_0061;
	}

IL_002b:
	{
		Enumerator_tB6009981BD4E3881E3EC83627255A24198F902D6 * L_5 = (Enumerator_tB6009981BD4E3881E3EC83627255A24198F902D6 *)__this->get_address_of_enumerator_6();
		RuntimeObject * L_6;
		L_6 = Enumerator_get_Current_m9C4EBBD2108B51885E750F927D7936290C8E20EE_inline((Enumerator_tB6009981BD4E3881E3EC83627255A24198F902D6 *)(Enumerator_tB6009981BD4E3881E3EC83627255A24198F902D6 *)L_5, /*hidden argument*/IL2CPP_RGCTX_METHOD_INFO(method->klass->rgctx_data, 5));
		V_1 = (RuntimeObject *)L_6;
		Func_2_t99409DECFF50F0FA9B427C863AC6C99C66E6F9F8 * L_7 = (Func_2_t99409DECFF50F0FA9B427C863AC6C99C66E6F9F8 *)__this->get_predicate_4();
		if (!L_7)
		{
			goto IL_004d;
		}
	}
	{
		Func_2_t99409DECFF50F0FA9B427C863AC6C99C66E6F9F8 * L_8 = (Func_2_t99409DECFF50F0FA9B427C863AC6C99C66E6F9F8 *)__this->get_predicate_4();
		RuntimeObject * L_9 = V_1;
		NullCheck((Func_2_t99409DECFF50F0FA9B427C863AC6C99C66E6F9F8 *)L_8);
		bool L_10;
		L_10 = ((  bool (*) (Func_2_t99409DECFF50F0FA9B427C863AC6C99C66E6F9F8 *, RuntimeObject *, const RuntimeMethod*))IL2CPP_RGCTX_METHOD_INFO(method->klass->rgctx_data, 6)->methodPointer)((Func_2_t99409DECFF50F0FA9B427C863AC6C99C66E6F9F8 *)L_8, (RuntimeObject *)L_9, /*hidden argument*/IL2CPP_RGCTX_METHOD_INFO(method->klass->rgctx_data, 6));
		if (!L_10)
		{
			goto IL_0061;
		}
	}

IL_004d:
	{
		Func_2_t969BC5FC9B68C7023AE4F7C254A78F446A7609F8 * L_11 = (Func_2_t969BC5FC9B68C7023AE4F7C254A78F446A7609F8 *)__this->get_selector_5();
		RuntimeObject * L_12 = V_1;
		NullCheck((Func_2_t969BC5FC9B68C7023AE4F7C254A78F446A7609F8 *)L_11);
		Nullable_1_t75730434CAD4E48A4EE117588CFD586FFBCAC209  L_13;
		L_13 = ((  Nullable_1_t75730434CAD4E48A4EE117588CFD586FFBCAC209  (*) (Func_2_t969BC5FC9B68C7023AE4F7C254A78F446A7609F8 *, RuntimeObject *, const RuntimeMethod*))IL2CPP_RGCTX_METHOD_INFO(method->klass->rgctx_data, 7)->methodPointer)((Func_2_t969BC5FC9B68C7023AE4F7C254A78F446A7609F8 *)L_11, (RuntimeObject *)L_12, /*hidden argument*/IL2CPP_RGCTX_METHOD_INFO(method->klass->rgctx_data, 7));
		((Iterator_1_t75B26B5E87871854D759A25738CFE42AF131D6A8 *)__this)->set_current_2(L_13);
		return (bool)1;
	}

IL_0061:
	{
		Enumerator_tB6009981BD4E3881E3EC83627255A24198F902D6 * L_14 = (Enumerator_tB6009981BD4E3881E3EC83627255A24198F902D6 *)__this->get_address_of_enumerator_6();
		bool L_15;
		L_15 = Enumerator_MoveNext_m2E56233762839CE55C67E00AC8DD3D4D3F6C0DF0((Enumerator_tB6009981BD4E3881E3EC83627255A24198F902D6 *)(Enumerator_tB6009981BD4E3881E3EC83627255A24198F902D6 *)L_14, /*hidden argument*/IL2CPP_RGCTX_METHOD_INFO(method->klass->rgctx_data, 8));
		if (L_15)
		{
			goto IL_002b;
		}
	}
	{
		NullCheck((Iterator_1_t75B26B5E87871854D759A25738CFE42AF131D6A8 *)__this);
		VirtActionInvoker0::Invoke(12 /* System.Void System.Linq.Enumerable/Iterator`1<System.Nullable`1<System.Double>>::Dispose() */, (Iterator_1_t75B26B5E87871854D759A25738CFE42AF131D6A8 *)__this);
	}

IL_0074:
	{
		return (bool)0;
	}
}
// System.Collections.Generic.IEnumerable`1<TResult> System.Linq.Enumerable/WhereSelectListIterator`2<System.Object,System.Nullable`1<System.Double>>::Where(System.Func`2<TResult,System.Boolean>)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR RuntimeObject* WhereSelectListIterator_2_Where_m1CECE5FAA07C458FC361E8DD3D274AEA2D605FEF_gshared (WhereSelectListIterator_2_tEE6392F7E2CDC15C2F3490EE288AB2275DEF7D9A * __this, Func_2_t4B7DAD120FE072A61F61F9158CB1013D6F95E130 * ___predicate0, const RuntimeMethod* method)
{
	{
		Func_2_t4B7DAD120FE072A61F61F9158CB1013D6F95E130 * L_0 = ___predicate0;
		WhereEnumerableIterator_1_t66C0068FA4DE078BBB4FF7511CF89C013E04A14D * L_1 = (WhereEnumerableIterator_1_t66C0068FA4DE078BBB4FF7511CF89C013E04A14D *)il2cpp_codegen_object_new(IL2CPP_RGCTX_DATA(method->klass->rgctx_data, 10));
		((  void (*) (WhereEnumerableIterator_1_t66C0068FA4DE078BBB4FF7511CF89C013E04A14D *, RuntimeObject*, Func_2_t4B7DAD120FE072A61F61F9158CB1013D6F95E130 *, const RuntimeMethod*))IL2CPP_RGCTX_METHOD_INFO(method->klass->rgctx_data, 11)->methodPointer)(L_1, (RuntimeObject*)__this, (Func_2_t4B7DAD120FE072A61F61F9158CB1013D6F95E130 *)L_0, /*hidden argument*/IL2CPP_RGCTX_METHOD_INFO(method->klass->rgctx_data, 11));
		return (RuntimeObject*)L_1;
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
// System.Void System.Linq.Enumerable/WhereSelectListIterator`2<System.Object,System.Nullable`1<System.Int32>>::.ctor(System.Collections.Generic.List`1<TSource>,System.Func`2<TSource,System.Boolean>,System.Func`2<TSource,TResult>)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void WhereSelectListIterator_2__ctor_m1C0CBBD8C328E69C552D5CF8705908DE87040DEB_gshared (WhereSelectListIterator_2_tAA7EB4891E566E311D0CC2850A8453EC4A1F2F1C * __this, List_1_t3F94120C77410A62EAE48421CF166B83AB95A2F5 * ___source0, Func_2_t99409DECFF50F0FA9B427C863AC6C99C66E6F9F8 * ___predicate1, Func_2_tF690BAA548D29EADC5635B1C8E7A7C6C9E4F7CFE * ___selector2, const RuntimeMethod* method)
{
	{
		NullCheck((Iterator_1_t88E927D3E5FC45C833C1A5146A04FBA17D02CA43 *)__this);
		((  void (*) (Iterator_1_t88E927D3E5FC45C833C1A5146A04FBA17D02CA43 *, const RuntimeMethod*))IL2CPP_RGCTX_METHOD_INFO(method->klass->rgctx_data, 0)->methodPointer)((Iterator_1_t88E927D3E5FC45C833C1A5146A04FBA17D02CA43 *)__this, /*hidden argument*/IL2CPP_RGCTX_METHOD_INFO(method->klass->rgctx_data, 0));
		List_1_t3F94120C77410A62EAE48421CF166B83AB95A2F5 * L_0 = ___source0;
		__this->set_source_3(L_0);
		Func_2_t99409DECFF50F0FA9B427C863AC6C99C66E6F9F8 * L_1 = ___predicate1;
		__this->set_predicate_4(L_1);
		Func_2_tF690BAA548D29EADC5635B1C8E7A7C6C9E4F7CFE * L_2 = ___selector2;
		__this->set_selector_5(L_2);
		return;
	}
}
// System.Linq.Enumerable/Iterator`1<TResult> System.Linq.Enumerable/WhereSelectListIterator`2<System.Object,System.Nullable`1<System.Int32>>::Clone()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR Iterator_1_t88E927D3E5FC45C833C1A5146A04FBA17D02CA43 * WhereSelectListIterator_2_Clone_m9F477FB5E5410EC30E925F4A581D2DD5F4ACB812_gshared (WhereSelectListIterator_2_tAA7EB4891E566E311D0CC2850A8453EC4A1F2F1C * __this, const RuntimeMethod* method)
{
	{
		List_1_t3F94120C77410A62EAE48421CF166B83AB95A2F5 * L_0 = (List_1_t3F94120C77410A62EAE48421CF166B83AB95A2F5 *)__this->get_source_3();
		Func_2_t99409DECFF50F0FA9B427C863AC6C99C66E6F9F8 * L_1 = (Func_2_t99409DECFF50F0FA9B427C863AC6C99C66E6F9F8 *)__this->get_predicate_4();
		Func_2_tF690BAA548D29EADC5635B1C8E7A7C6C9E4F7CFE * L_2 = (Func_2_tF690BAA548D29EADC5635B1C8E7A7C6C9E4F7CFE *)__this->get_selector_5();
		WhereSelectListIterator_2_tAA7EB4891E566E311D0CC2850A8453EC4A1F2F1C * L_3 = (WhereSelectListIterator_2_tAA7EB4891E566E311D0CC2850A8453EC4A1F2F1C *)il2cpp_codegen_object_new(IL2CPP_RGCTX_DATA(method->klass->rgctx_data, 2));
		((  void (*) (WhereSelectListIterator_2_tAA7EB4891E566E311D0CC2850A8453EC4A1F2F1C *, List_1_t3F94120C77410A62EAE48421CF166B83AB95A2F5 *, Func_2_t99409DECFF50F0FA9B427C863AC6C99C66E6F9F8 *, Func_2_tF690BAA548D29EADC5635B1C8E7A7C6C9E4F7CFE *, const RuntimeMethod*))IL2CPP_RGCTX_METHOD_INFO(method->klass->rgctx_data, 3)->methodPointer)(L_3, (List_1_t3F94120C77410A62EAE48421CF166B83AB95A2F5 *)L_0, (Func_2_t99409DECFF50F0FA9B427C863AC6C99C66E6F9F8 *)L_1, (Func_2_tF690BAA548D29EADC5635B1C8E7A7C6C9E4F7CFE *)L_2, /*hidden argument*/IL2CPP_RGCTX_METHOD_INFO(method->klass->rgctx_data, 3));
		return (Iterator_1_t88E927D3E5FC45C833C1A5146A04FBA17D02CA43 *)L_3;
	}
}
// System.Boolean System.Linq.Enumerable/WhereSelectListIterator`2<System.Object,System.Nullable`1<System.Int32>>::MoveNext()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR bool WhereSelectListIterator_2_MoveNext_mBC1DC3F53C99D4F4361224101CD0661512E5D97B_gshared (WhereSelectListIterator_2_tAA7EB4891E566E311D0CC2850A8453EC4A1F2F1C * __this, const RuntimeMethod* method)
{
	int32_t V_0 = 0;
	RuntimeObject * V_1 = NULL;
	{
		int32_t L_0 = (int32_t)((Iterator_1_t88E927D3E5FC45C833C1A5146A04FBA17D02CA43 *)__this)->get_state_1();
		V_0 = (int32_t)L_0;
		int32_t L_1 = V_0;
		if ((((int32_t)L_1) == ((int32_t)1)))
		{
			goto IL_0011;
		}
	}
	{
		int32_t L_2 = V_0;
		if ((((int32_t)L_2) == ((int32_t)2)))
		{
			goto IL_0061;
		}
	}
	{
		goto IL_0074;
	}

IL_0011:
	{
		List_1_t3F94120C77410A62EAE48421CF166B83AB95A2F5 * L_3 = (List_1_t3F94120C77410A62EAE48421CF166B83AB95A2F5 *)__this->get_source_3();
		NullCheck((List_1_t3F94120C77410A62EAE48421CF166B83AB95A2F5 *)L_3);
		Enumerator_tB6009981BD4E3881E3EC83627255A24198F902D6  L_4;
		L_4 = ((  Enumerator_tB6009981BD4E3881E3EC83627255A24198F902D6  (*) (List_1_t3F94120C77410A62EAE48421CF166B83AB95A2F5 *, const RuntimeMethod*))IL2CPP_RGCTX_METHOD_INFO(method->klass->rgctx_data, 4)->methodPointer)((List_1_t3F94120C77410A62EAE48421CF166B83AB95A2F5 *)L_3, /*hidden argument*/IL2CPP_RGCTX_METHOD_INFO(method->klass->rgctx_data, 4));
		__this->set_enumerator_6(L_4);
		((Iterator_1_t88E927D3E5FC45C833C1A5146A04FBA17D02CA43 *)__this)->set_state_1(2);
		goto IL_0061;
	}

IL_002b:
	{
		Enumerator_tB6009981BD4E3881E3EC83627255A24198F902D6 * L_5 = (Enumerator_tB6009981BD4E3881E3EC83627255A24198F902D6 *)__this->get_address_of_enumerator_6();
		RuntimeObject * L_6;
		L_6 = Enumerator_get_Current_m9C4EBBD2108B51885E750F927D7936290C8E20EE_inline((Enumerator_tB6009981BD4E3881E3EC83627255A24198F902D6 *)(Enumerator_tB6009981BD4E3881E3EC83627255A24198F902D6 *)L_5, /*hidden argument*/IL2CPP_RGCTX_METHOD_INFO(method->klass->rgctx_data, 5));
		V_1 = (RuntimeObject *)L_6;
		Func_2_t99409DECFF50F0FA9B427C863AC6C99C66E6F9F8 * L_7 = (Func_2_t99409DECFF50F0FA9B427C863AC6C99C66E6F9F8 *)__this->get_predicate_4();
		if (!L_7)
		{
			goto IL_004d;
		}
	}
	{
		Func_2_t99409DECFF50F0FA9B427C863AC6C99C66E6F9F8 * L_8 = (Func_2_t99409DECFF50F0FA9B427C863AC6C99C66E6F9F8 *)__this->get_predicate_4();
		RuntimeObject * L_9 = V_1;
		NullCheck((Func_2_t99409DECFF50F0FA9B427C863AC6C99C66E6F9F8 *)L_8);
		bool L_10;
		L_10 = ((  bool (*) (Func_2_t99409DECFF50F0FA9B427C863AC6C99C66E6F9F8 *, RuntimeObject *, const RuntimeMethod*))IL2CPP_RGCTX_METHOD_INFO(method->klass->rgctx_data, 6)->methodPointer)((Func_2_t99409DECFF50F0FA9B427C863AC6C99C66E6F9F8 *)L_8, (RuntimeObject *)L_9, /*hidden argument*/IL2CPP_RGCTX_METHOD_INFO(method->klass->rgctx_data, 6));
		if (!L_10)
		{
			goto IL_0061;
		}
	}

IL_004d:
	{
		Func_2_tF690BAA548D29EADC5635B1C8E7A7C6C9E4F7CFE * L_11 = (Func_2_tF690BAA548D29EADC5635B1C8E7A7C6C9E4F7CFE *)__this->get_selector_5();
		RuntimeObject * L_12 = V_1;
		NullCheck((Func_2_tF690BAA548D29EADC5635B1C8E7A7C6C9E4F7CFE *)L_11);
		Nullable_1_t864FD0051A05D37F91C857AB496BFCB3FE756103  L_13;
		L_13 = ((  Nullable_1_t864FD0051A05D37F91C857AB496BFCB3FE756103  (*) (Func_2_tF690BAA548D29EADC5635B1C8E7A7C6C9E4F7CFE *, RuntimeObject *, const RuntimeMethod*))IL2CPP_RGCTX_METHOD_INFO(method->klass->rgctx_data, 7)->methodPointer)((Func_2_tF690BAA548D29EADC5635B1C8E7A7C6C9E4F7CFE *)L_11, (RuntimeObject *)L_12, /*hidden argument*/IL2CPP_RGCTX_METHOD_INFO(method->klass->rgctx_data, 7));
		((Iterator_1_t88E927D3E5FC45C833C1A5146A04FBA17D02CA43 *)__this)->set_current_2(L_13);
		return (bool)1;
	}

IL_0061:
	{
		Enumerator_tB6009981BD4E3881E3EC83627255A24198F902D6 * L_14 = (Enumerator_tB6009981BD4E3881E3EC83627255A24198F902D6 *)__this->get_address_of_enumerator_6();
		bool L_15;
		L_15 = Enumerator_MoveNext_m2E56233762839CE55C67E00AC8DD3D4D3F6C0DF0((Enumerator_tB6009981BD4E3881E3EC83627255A24198F902D6 *)(Enumerator_tB6009981BD4E3881E3EC83627255A24198F902D6 *)L_14, /*hidden argument*/IL2CPP_RGCTX_METHOD_INFO(method->klass->rgctx_data, 8));
		if (L_15)
		{
			goto IL_002b;
		}
	}
	{
		NullCheck((Iterator_1_t88E927D3E5FC45C833C1A5146A04FBA17D02CA43 *)__this);
		VirtActionInvoker0::Invoke(12 /* System.Void System.Linq.Enumerable/Iterator`1<System.Nullable`1<System.Int32>>::Dispose() */, (Iterator_1_t88E927D3E5FC45C833C1A5146A04FBA17D02CA43 *)__this);
	}

IL_0074:
	{
		return (bool)0;
	}
}
// System.Collections.Generic.IEnumerable`1<TResult> System.Linq.Enumerable/WhereSelectListIterator`2<System.Object,System.Nullable`1<System.Int32>>::Where(System.Func`2<TResult,System.Boolean>)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR RuntimeObject* WhereSelectListIterator_2_Where_m73C6EE4FBC898257ABA12416742A03849B8651D2_gshared (WhereSelectListIterator_2_tAA7EB4891E566E311D0CC2850A8453EC4A1F2F1C * __this, Func_2_t42993C24F11175D8FA98C3DB6E40DC467687C57D * ___predicate0, const RuntimeMethod* method)
{
	{
		Func_2_t42993C24F11175D8FA98C3DB6E40DC467687C57D * L_0 = ___predicate0;
		WhereEnumerableIterator_1_t1B1B27D3E99C914ABE052FAFE0F219BB76A0E566 * L_1 = (WhereEnumerableIterator_1_t1B1B27D3E99C914ABE052FAFE0F219BB76A0E566 *)il2cpp_codegen_object_new(IL2CPP_RGCTX_DATA(method->klass->rgctx_data, 10));
		((  void (*) (WhereEnumerableIterator_1_t1B1B27D3E99C914ABE052FAFE0F219BB76A0E566 *, RuntimeObject*, Func_2_t42993C24F11175D8FA98C3DB6E40DC467687C57D *, const RuntimeMethod*))IL2CPP_RGCTX_METHOD_INFO(method->klass->rgctx_data, 11)->methodPointer)(L_1, (RuntimeObject*)__this, (Func_2_t42993C24F11175D8FA98C3DB6E40DC467687C57D *)L_0, /*hidden argument*/IL2CPP_RGCTX_METHOD_INFO(method->klass->rgctx_data, 11));
		return (RuntimeObject*)L_1;
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
// System.Void System.Linq.Enumerable/WhereSelectListIterator`2<System.Object,System.Nullable`1<System.Int64>>::.ctor(System.Collections.Generic.List`1<TSource>,System.Func`2<TSource,System.Boolean>,System.Func`2<TSource,TResult>)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void WhereSelectListIterator_2__ctor_m4583A0ECD42A9A3FD1CDA9ABF13C07848D164103_gshared (WhereSelectListIterator_2_tDE07EDB851C318005CF3E85AFC71DB625406AACB * __this, List_1_t3F94120C77410A62EAE48421CF166B83AB95A2F5 * ___source0, Func_2_t99409DECFF50F0FA9B427C863AC6C99C66E6F9F8 * ___predicate1, Func_2_tF1DB5D7EFA801A89D60CE3A973ABC6EC71457FD5 * ___selector2, const RuntimeMethod* method)
{
	{
		NullCheck((Iterator_1_t7714579EDED47F91E8FBA7AF6D3F0674241FDF6C *)__this);
		((  void (*) (Iterator_1_t7714579EDED47F91E8FBA7AF6D3F0674241FDF6C *, const RuntimeMethod*))IL2CPP_RGCTX_METHOD_INFO(method->klass->rgctx_data, 0)->methodPointer)((Iterator_1_t7714579EDED47F91E8FBA7AF6D3F0674241FDF6C *)__this, /*hidden argument*/IL2CPP_RGCTX_METHOD_INFO(method->klass->rgctx_data, 0));
		List_1_t3F94120C77410A62EAE48421CF166B83AB95A2F5 * L_0 = ___source0;
		__this->set_source_3(L_0);
		Func_2_t99409DECFF50F0FA9B427C863AC6C99C66E6F9F8 * L_1 = ___predicate1;
		__this->set_predicate_4(L_1);
		Func_2_tF1DB5D7EFA801A89D60CE3A973ABC6EC71457FD5 * L_2 = ___selector2;
		__this->set_selector_5(L_2);
		return;
	}
}
// System.Linq.Enumerable/Iterator`1<TResult> System.Linq.Enumerable/WhereSelectListIterator`2<System.Object,System.Nullable`1<System.Int64>>::Clone()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR Iterator_1_t7714579EDED47F91E8FBA7AF6D3F0674241FDF6C * WhereSelectListIterator_2_Clone_m63E0B7A7FC49FD1D34941655E813033A6C401EA6_gshared (WhereSelectListIterator_2_tDE07EDB851C318005CF3E85AFC71DB625406AACB * __this, const RuntimeMethod* method)
{
	{
		List_1_t3F94120C77410A62EAE48421CF166B83AB95A2F5 * L_0 = (List_1_t3F94120C77410A62EAE48421CF166B83AB95A2F5 *)__this->get_source_3();
		Func_2_t99409DECFF50F0FA9B427C863AC6C99C66E6F9F8 * L_1 = (Func_2_t99409DECFF50F0FA9B427C863AC6C99C66E6F9F8 *)__this->get_predicate_4();
		Func_2_tF1DB5D7EFA801A89D60CE3A973ABC6EC71457FD5 * L_2 = (Func_2_tF1DB5D7EFA801A89D60CE3A973ABC6EC71457FD5 *)__this->get_selector_5();
		WhereSelectListIterator_2_tDE07EDB851C318005CF3E85AFC71DB625406AACB * L_3 = (WhereSelectListIterator_2_tDE07EDB851C318005CF3E85AFC71DB625406AACB *)il2cpp_codegen_object_new(IL2CPP_RGCTX_DATA(method->klass->rgctx_data, 2));
		((  void (*) (WhereSelectListIterator_2_tDE07EDB851C318005CF3E85AFC71DB625406AACB *, List_1_t3F94120C77410A62EAE48421CF166B83AB95A2F5 *, Func_2_t99409DECFF50F0FA9B427C863AC6C99C66E6F9F8 *, Func_2_tF1DB5D7EFA801A89D60CE3A973ABC6EC71457FD5 *, const RuntimeMethod*))IL2CPP_RGCTX_METHOD_INFO(method->klass->rgctx_data, 3)->methodPointer)(L_3, (List_1_t3F94120C77410A62EAE48421CF166B83AB95A2F5 *)L_0, (Func_2_t99409DECFF50F0FA9B427C863AC6C99C66E6F9F8 *)L_1, (Func_2_tF1DB5D7EFA801A89D60CE3A973ABC6EC71457FD5 *)L_2, /*hidden argument*/IL2CPP_RGCTX_METHOD_INFO(method->klass->rgctx_data, 3));
		return (Iterator_1_t7714579EDED47F91E8FBA7AF6D3F0674241FDF6C *)L_3;
	}
}
// System.Boolean System.Linq.Enumerable/WhereSelectListIterator`2<System.Object,System.Nullable`1<System.Int64>>::MoveNext()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR bool WhereSelectListIterator_2_MoveNext_mB4B695DCC7E20A0B4122E5D9D7116CC2D10CB6A1_gshared (WhereSelectListIterator_2_tDE07EDB851C318005CF3E85AFC71DB625406AACB * __this, const RuntimeMethod* method)
{
	int32_t V_0 = 0;
	RuntimeObject * V_1 = NULL;
	{
		int32_t L_0 = (int32_t)((Iterator_1_t7714579EDED47F91E8FBA7AF6D3F0674241FDF6C *)__this)->get_state_1();
		V_0 = (int32_t)L_0;
		int32_t L_1 = V_0;
		if ((((int32_t)L_1) == ((int32_t)1)))
		{
			goto IL_0011;
		}
	}
	{
		int32_t L_2 = V_0;
		if ((((int32_t)L_2) == ((int32_t)2)))
		{
			goto IL_0061;
		}
	}
	{
		goto IL_0074;
	}

IL_0011:
	{
		List_1_t3F94120C77410A62EAE48421CF166B83AB95A2F5 * L_3 = (List_1_t3F94120C77410A62EAE48421CF166B83AB95A2F5 *)__this->get_source_3();
		NullCheck((List_1_t3F94120C77410A62EAE48421CF166B83AB95A2F5 *)L_3);
		Enumerator_tB6009981BD4E3881E3EC83627255A24198F902D6  L_4;
		L_4 = ((  Enumerator_tB6009981BD4E3881E3EC83627255A24198F902D6  (*) (List_1_t3F94120C77410A62EAE48421CF166B83AB95A2F5 *, const RuntimeMethod*))IL2CPP_RGCTX_METHOD_INFO(method->klass->rgctx_data, 4)->methodPointer)((List_1_t3F94120C77410A62EAE48421CF166B83AB95A2F5 *)L_3, /*hidden argument*/IL2CPP_RGCTX_METHOD_INFO(method->klass->rgctx_data, 4));
		__this->set_enumerator_6(L_4);
		((Iterator_1_t7714579EDED47F91E8FBA7AF6D3F0674241FDF6C *)__this)->set_state_1(2);
		goto IL_0061;
	}

IL_002b:
	{
		Enumerator_tB6009981BD4E3881E3EC83627255A24198F902D6 * L_5 = (Enumerator_tB6009981BD4E3881E3EC83627255A24198F902D6 *)__this->get_address_of_enumerator_6();
		RuntimeObject * L_6;
		L_6 = Enumerator_get_Current_m9C4EBBD2108B51885E750F927D7936290C8E20EE_inline((Enumerator_tB6009981BD4E3881E3EC83627255A24198F902D6 *)(Enumerator_tB6009981BD4E3881E3EC83627255A24198F902D6 *)L_5, /*hidden argument*/IL2CPP_RGCTX_METHOD_INFO(method->klass->rgctx_data, 5));
		V_1 = (RuntimeObject *)L_6;
		Func_2_t99409DECFF50F0FA9B427C863AC6C99C66E6F9F8 * L_7 = (Func_2_t99409DECFF50F0FA9B427C863AC6C99C66E6F9F8 *)__this->get_predicate_4();
		if (!L_7)
		{
			goto IL_004d;
		}
	}
	{
		Func_2_t99409DECFF50F0FA9B427C863AC6C99C66E6F9F8 * L_8 = (Func_2_t99409DECFF50F0FA9B427C863AC6C99C66E6F9F8 *)__this->get_predicate_4();
		RuntimeObject * L_9 = V_1;
		NullCheck((Func_2_t99409DECFF50F0FA9B427C863AC6C99C66E6F9F8 *)L_8);
		bool L_10;
		L_10 = ((  bool (*) (Func_2_t99409DECFF50F0FA9B427C863AC6C99C66E6F9F8 *, RuntimeObject *, const RuntimeMethod*))IL2CPP_RGCTX_METHOD_INFO(method->klass->rgctx_data, 6)->methodPointer)((Func_2_t99409DECFF50F0FA9B427C863AC6C99C66E6F9F8 *)L_8, (RuntimeObject *)L_9, /*hidden argument*/IL2CPP_RGCTX_METHOD_INFO(method->klass->rgctx_data, 6));
		if (!L_10)
		{
			goto IL_0061;
		}
	}

IL_004d:
	{
		Func_2_tF1DB5D7EFA801A89D60CE3A973ABC6EC71457FD5 * L_11 = (Func_2_tF1DB5D7EFA801A89D60CE3A973ABC6EC71457FD5 *)__this->get_selector_5();
		RuntimeObject * L_12 = V_1;
		NullCheck((Func_2_tF1DB5D7EFA801A89D60CE3A973ABC6EC71457FD5 *)L_11);
		Nullable_1_t340361C8134256120F5769AC5A3F743DB6C11D1F  L_13;
		L_13 = ((  Nullable_1_t340361C8134256120F5769AC5A3F743DB6C11D1F  (*) (Func_2_tF1DB5D7EFA801A89D60CE3A973ABC6EC71457FD5 *, RuntimeObject *, const RuntimeMethod*))IL2CPP_RGCTX_METHOD_INFO(method->klass->rgctx_data, 7)->methodPointer)((Func_2_tF1DB5D7EFA801A89D60CE3A973ABC6EC71457FD5 *)L_11, (RuntimeObject *)L_12, /*hidden argument*/IL2CPP_RGCTX_METHOD_INFO(method->klass->rgctx_data, 7));
		((Iterator_1_t7714579EDED47F91E8FBA7AF6D3F0674241FDF6C *)__this)->set_current_2(L_13);
		return (bool)1;
	}

IL_0061:
	{
		Enumerator_tB6009981BD4E3881E3EC83627255A24198F902D6 * L_14 = (Enumerator_tB6009981BD4E3881E3EC83627255A24198F902D6 *)__this->get_address_of_enumerator_6();
		bool L_15;
		L_15 = Enumerator_MoveNext_m2E56233762839CE55C67E00AC8DD3D4D3F6C0DF0((Enumerator_tB6009981BD4E3881E3EC83627255A24198F902D6 *)(Enumerator_tB6009981BD4E3881E3EC83627255A24198F902D6 *)L_14, /*hidden argument*/IL2CPP_RGCTX_METHOD_INFO(method->klass->rgctx_data, 8));
		if (L_15)
		{
			goto IL_002b;
		}
	}
	{
		NullCheck((Iterator_1_t7714579EDED47F91E8FBA7AF6D3F0674241FDF6C *)__this);
		VirtActionInvoker0::Invoke(12 /* System.Void System.Linq.Enumerable/Iterator`1<System.Nullable`1<System.Int64>>::Dispose() */, (Iterator_1_t7714579EDED47F91E8FBA7AF6D3F0674241FDF6C *)__this);
	}

IL_0074:
	{
		return (bool)0;
	}
}
// System.Collections.Generic.IEnumerable`1<TResult> System.Linq.Enumerable/WhereSelectListIterator`2<System.Object,System.Nullable`1<System.Int64>>::Where(System.Func`2<TResult,System.Boolean>)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR RuntimeObject* WhereSelectListIterator_2_Where_m1EBFC648C237649E315E92AA49517FF321297028_gshared (WhereSelectListIterator_2_tDE07EDB851C318005CF3E85AFC71DB625406AACB * __this, Func_2_t1637E276420B054B58108E2AD51B1537DEC785D9 * ___predicate0, const RuntimeMethod* method)
{
	{
		Func_2_t1637E276420B054B58108E2AD51B1537DEC785D9 * L_0 = ___predicate0;
		WhereEnumerableIterator_1_t0354BCB72E2636F60E4B00786DDDE24A1EA42885 * L_1 = (WhereEnumerableIterator_1_t0354BCB72E2636F60E4B00786DDDE24A1EA42885 *)il2cpp_codegen_object_new(IL2CPP_RGCTX_DATA(method->klass->rgctx_data, 10));
		((  void (*) (WhereEnumerableIterator_1_t0354BCB72E2636F60E4B00786DDDE24A1EA42885 *, RuntimeObject*, Func_2_t1637E276420B054B58108E2AD51B1537DEC785D9 *, const RuntimeMethod*))IL2CPP_RGCTX_METHOD_INFO(method->klass->rgctx_data, 11)->methodPointer)(L_1, (RuntimeObject*)__this, (Func_2_t1637E276420B054B58108E2AD51B1537DEC785D9 *)L_0, /*hidden argument*/IL2CPP_RGCTX_METHOD_INFO(method->klass->rgctx_data, 11));
		return (RuntimeObject*)L_1;
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
// System.Void System.Linq.Enumerable/WhereSelectListIterator`2<System.Object,System.Nullable`1<System.Single>>::.ctor(System.Collections.Generic.List`1<TSource>,System.Func`2<TSource,System.Boolean>,System.Func`2<TSource,TResult>)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void WhereSelectListIterator_2__ctor_m38E7D9ABCDBB8A3CF843867FF42B7C969056A162_gshared (WhereSelectListIterator_2_tA3FAD38D0543C622EB734E603C9C973343DA791B * __this, List_1_t3F94120C77410A62EAE48421CF166B83AB95A2F5 * ___source0, Func_2_t99409DECFF50F0FA9B427C863AC6C99C66E6F9F8 * ___predicate1, Func_2_t936E494B9795BDACAC731255502447EA0D04753F * ___selector2, const RuntimeMethod* method)
{
	{
		NullCheck((Iterator_1_t5F8CC81E7DD3167D5EC5BFC0984EBCEE64F5B45E *)__this);
		((  void (*) (Iterator_1_t5F8CC81E7DD3167D5EC5BFC0984EBCEE64F5B45E *, const RuntimeMethod*))IL2CPP_RGCTX_METHOD_INFO(method->klass->rgctx_data, 0)->methodPointer)((Iterator_1_t5F8CC81E7DD3167D5EC5BFC0984EBCEE64F5B45E *)__this, /*hidden argument*/IL2CPP_RGCTX_METHOD_INFO(method->klass->rgctx_data, 0));
		List_1_t3F94120C77410A62EAE48421CF166B83AB95A2F5 * L_0 = ___source0;
		__this->set_source_3(L_0);
		Func_2_t99409DECFF50F0FA9B427C863AC6C99C66E6F9F8 * L_1 = ___predicate1;
		__this->set_predicate_4(L_1);
		Func_2_t936E494B9795BDACAC731255502447EA0D04753F * L_2 = ___selector2;
		__this->set_selector_5(L_2);
		return;
	}
}
// System.Linq.Enumerable/Iterator`1<TResult> System.Linq.Enumerable/WhereSelectListIterator`2<System.Object,System.Nullable`1<System.Single>>::Clone()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR Iterator_1_t5F8CC81E7DD3167D5EC5BFC0984EBCEE64F5B45E * WhereSelectListIterator_2_Clone_m1111003328C6CEA51F24CC327C405AF0403D3796_gshared (WhereSelectListIterator_2_tA3FAD38D0543C622EB734E603C9C973343DA791B * __this, const RuntimeMethod* method)
{
	{
		List_1_t3F94120C77410A62EAE48421CF166B83AB95A2F5 * L_0 = (List_1_t3F94120C77410A62EAE48421CF166B83AB95A2F5 *)__this->get_source_3();
		Func_2_t99409DECFF50F0FA9B427C863AC6C99C66E6F9F8 * L_1 = (Func_2_t99409DECFF50F0FA9B427C863AC6C99C66E6F9F8 *)__this->get_predicate_4();
		Func_2_t936E494B9795BDACAC731255502447EA0D04753F * L_2 = (Func_2_t936E494B9795BDACAC731255502447EA0D04753F *)__this->get_selector_5();
		WhereSelectListIterator_2_tA3FAD38D0543C622EB734E603C9C973343DA791B * L_3 = (WhereSelectListIterator_2_tA3FAD38D0543C622EB734E603C9C973343DA791B *)il2cpp_codegen_object_new(IL2CPP_RGCTX_DATA(method->klass->rgctx_data, 2));
		((  void (*) (WhereSelectListIterator_2_tA3FAD38D0543C622EB734E603C9C973343DA791B *, List_1_t3F94120C77410A62EAE48421CF166B83AB95A2F5 *, Func_2_t99409DECFF50F0FA9B427C863AC6C99C66E6F9F8 *, Func_2_t936E494B9795BDACAC731255502447EA0D04753F *, const RuntimeMethod*))IL2CPP_RGCTX_METHOD_INFO(method->klass->rgctx_data, 3)->methodPointer)(L_3, (List_1_t3F94120C77410A62EAE48421CF166B83AB95A2F5 *)L_0, (Func_2_t99409DECFF50F0FA9B427C863AC6C99C66E6F9F8 *)L_1, (Func_2_t936E494B9795BDACAC731255502447EA0D04753F *)L_2, /*hidden argument*/IL2CPP_RGCTX_METHOD_INFO(method->klass->rgctx_data, 3));
		return (Iterator_1_t5F8CC81E7DD3167D5EC5BFC0984EBCEE64F5B45E *)L_3;
	}
}
// System.Boolean System.Linq.Enumerable/WhereSelectListIterator`2<System.Object,System.Nullable`1<System.Single>>::MoveNext()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR bool WhereSelectListIterator_2_MoveNext_m7FC52143500D10ABE0B3D118BD956EF0B3F00BD5_gshared (WhereSelectListIterator_2_tA3FAD38D0543C622EB734E603C9C973343DA791B * __this, const RuntimeMethod* method)
{
	int32_t V_0 = 0;
	RuntimeObject * V_1 = NULL;
	{
		int32_t L_0 = (int32_t)((Iterator_1_t5F8CC81E7DD3167D5EC5BFC0984EBCEE64F5B45E *)__this)->get_state_1();
		V_0 = (int32_t)L_0;
		int32_t L_1 = V_0;
		if ((((int32_t)L_1) == ((int32_t)1)))
		{
			goto IL_0011;
		}
	}
	{
		int32_t L_2 = V_0;
		if ((((int32_t)L_2) == ((int32_t)2)))
		{
			goto IL_0061;
		}
	}
	{
		goto IL_0074;
	}

IL_0011:
	{
		List_1_t3F94120C77410A62EAE48421CF166B83AB95A2F5 * L_3 = (List_1_t3F94120C77410A62EAE48421CF166B83AB95A2F5 *)__this->get_source_3();
		NullCheck((List_1_t3F94120C77410A62EAE48421CF166B83AB95A2F5 *)L_3);
		Enumerator_tB6009981BD4E3881E3EC83627255A24198F902D6  L_4;
		L_4 = ((  Enumerator_tB6009981BD4E3881E3EC83627255A24198F902D6  (*) (List_1_t3F94120C77410A62EAE48421CF166B83AB95A2F5 *, const RuntimeMethod*))IL2CPP_RGCTX_METHOD_INFO(method->klass->rgctx_data, 4)->methodPointer)((List_1_t3F94120C77410A62EAE48421CF166B83AB95A2F5 *)L_3, /*hidden argument*/IL2CPP_RGCTX_METHOD_INFO(method->klass->rgctx_data, 4));
		__this->set_enumerator_6(L_4);
		((Iterator_1_t5F8CC81E7DD3167D5EC5BFC0984EBCEE64F5B45E *)__this)->set_state_1(2);
		goto IL_0061;
	}

IL_002b:
	{
		Enumerator_tB6009981BD4E3881E3EC83627255A24198F902D6 * L_5 = (Enumerator_tB6009981BD4E3881E3EC83627255A24198F902D6 *)__this->get_address_of_enumerator_6();
		RuntimeObject * L_6;
		L_6 = Enumerator_get_Current_m9C4EBBD2108B51885E750F927D7936290C8E20EE_inline((Enumerator_tB6009981BD4E3881E3EC83627255A24198F902D6 *)(Enumerator_tB6009981BD4E3881E3EC83627255A24198F902D6 *)L_5, /*hidden argument*/IL2CPP_RGCTX_METHOD_INFO(method->klass->rgctx_data, 5));
		V_1 = (RuntimeObject *)L_6;
		Func_2_t99409DECFF50F0FA9B427C863AC6C99C66E6F9F8 * L_7 = (Func_2_t99409DECFF50F0FA9B427C863AC6C99C66E6F9F8 *)__this->get_predicate_4();
		if (!L_7)
		{
			goto IL_004d;
		}
	}
	{
		Func_2_t99409DECFF50F0FA9B427C863AC6C99C66E6F9F8 * L_8 = (Func_2_t99409DECFF50F0FA9B427C863AC6C99C66E6F9F8 *)__this->get_predicate_4();
		RuntimeObject * L_9 = V_1;
		NullCheck((Func_2_t99409DECFF50F0FA9B427C863AC6C99C66E6F9F8 *)L_8);
		bool L_10;
		L_10 = ((  bool (*) (Func_2_t99409DECFF50F0FA9B427C863AC6C99C66E6F9F8 *, RuntimeObject *, const RuntimeMethod*))IL2CPP_RGCTX_METHOD_INFO(method->klass->rgctx_data, 6)->methodPointer)((Func_2_t99409DECFF50F0FA9B427C863AC6C99C66E6F9F8 *)L_8, (RuntimeObject *)L_9, /*hidden argument*/IL2CPP_RGCTX_METHOD_INFO(method->klass->rgctx_data, 6));
		if (!L_10)
		{
			goto IL_0061;
		}
	}

IL_004d:
	{
		Func_2_t936E494B9795BDACAC731255502447EA0D04753F * L_11 = (Func_2_t936E494B9795BDACAC731255502447EA0D04753F *)__this->get_selector_5();
		RuntimeObject * L_12 = V_1;
		NullCheck((Func_2_t936E494B9795BDACAC731255502447EA0D04753F *)L_11);
		Nullable_1_t0C4AC2E457C437FA106160547FD9BA5B50B1888A  L_13;
		L_13 = ((  Nullable_1_t0C4AC2E457C437FA106160547FD9BA5B50B1888A  (*) (Func_2_t936E494B9795BDACAC731255502447EA0D04753F *, RuntimeObject *, const RuntimeMethod*))IL2CPP_RGCTX_METHOD_INFO(method->klass->rgctx_data, 7)->methodPointer)((Func_2_t936E494B9795BDACAC731255502447EA0D04753F *)L_11, (RuntimeObject *)L_12, /*hidden argument*/IL2CPP_RGCTX_METHOD_INFO(method->klass->rgctx_data, 7));
		((Iterator_1_t5F8CC81E7DD3167D5EC5BFC0984EBCEE64F5B45E *)__this)->set_current_2(L_13);
		return (bool)1;
	}

IL_0061:
	{
		Enumerator_tB6009981BD4E3881E3EC83627255A24198F902D6 * L_14 = (Enumerator_tB6009981BD4E3881E3EC83627255A24198F902D6 *)__this->get_address_of_enumerator_6();
		bool L_15;
		L_15 = Enumerator_MoveNext_m2E56233762839CE55C67E00AC8DD3D4D3F6C0DF0((Enumerator_tB6009981BD4E3881E3EC83627255A24198F902D6 *)(Enumerator_tB6009981BD4E3881E3EC83627255A24198F902D6 *)L_14, /*hidden argument*/IL2CPP_RGCTX_METHOD_INFO(method->klass->rgctx_data, 8));
		if (L_15)
		{
			goto IL_002b;
		}
	}
	{
		NullCheck((Iterator_1_t5F8CC81E7DD3167D5EC5BFC0984EBCEE64F5B45E *)__this);
		VirtActionInvoker0::Invoke(12 /* System.Void System.Linq.Enumerable/Iterator`1<System.Nullable`1<System.Single>>::Dispose() */, (Iterator_1_t5F8CC81E7DD3167D5EC5BFC0984EBCEE64F5B45E *)__this);
	}

IL_0074:
	{
		return (bool)0;
	}
}
// System.Collections.Generic.IEnumerable`1<TResult> System.Linq.Enumerable/WhereSelectListIterator`2<System.Object,System.Nullable`1<System.Single>>::Where(System.Func`2<TResult,System.Boolean>)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR RuntimeObject* WhereSelectListIterator_2_Where_mB0D4106E6D5258727BE4D3E60B5F3C827BF7DD85_gshared (WhereSelectListIterator_2_tA3FAD38D0543C622EB734E603C9C973343DA791B * __this, Func_2_t9B3CA7186DE9A33B978124F5B7131DD16456B41A * ___predicate0, const RuntimeMethod* method)
{
	{
		Func_2_t9B3CA7186DE9A33B978124F5B7131DD16456B41A * L_0 = ___predicate0;
		WhereEnumerableIterator_1_tEA993B6947A5D38439F1B98DAAA3D3EE22BAF126 * L_1 = (WhereEnumerableIterator_1_tEA993B6947A5D38439F1B98DAAA3D3EE22BAF126 *)il2cpp_codegen_object_new(IL2CPP_RGCTX_DATA(method->klass->rgctx_data, 10));
		((  void (*) (WhereEnumerableIterator_1_tEA993B6947A5D38439F1B98DAAA3D3EE22BAF126 *, RuntimeObject*, Func_2_t9B3CA7186DE9A33B978124F5B7131DD16456B41A *, const RuntimeMethod*))IL2CPP_RGCTX_METHOD_INFO(method->klass->rgctx_data, 11)->methodPointer)(L_1, (RuntimeObject*)__this, (Func_2_t9B3CA7186DE9A33B978124F5B7131DD16456B41A *)L_0, /*hidden argument*/IL2CPP_RGCTX_METHOD_INFO(method->klass->rgctx_data, 11));
		return (RuntimeObject*)L_1;
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
// System.Void System.Linq.Enumerable/WhereSelectListIterator`2<System.Object,System.Boolean>::.ctor(System.Collections.Generic.List`1<TSource>,System.Func`2<TSource,System.Boolean>,System.Func`2<TSource,TResult>)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void WhereSelectListIterator_2__ctor_mAD2213DC47AA95FF2D1A6651C35A6D2DA6468CB1_gshared (WhereSelectListIterator_2_t1135F63EC4A3B58BB9EDE8324AD11A2B64F209E2 * __this, List_1_t3F94120C77410A62EAE48421CF166B83AB95A2F5 * ___source0, Func_2_t99409DECFF50F0FA9B427C863AC6C99C66E6F9F8 * ___predicate1, Func_2_t99409DECFF50F0FA9B427C863AC6C99C66E6F9F8 * ___selector2, const RuntimeMethod* method)
{
	{
		NullCheck((Iterator_1_tF558BC64630CA9038F999F5A16CC3DD5A0DB6933 *)__this);
		((  void (*) (Iterator_1_tF558BC64630CA9038F999F5A16CC3DD5A0DB6933 *, const RuntimeMethod*))IL2CPP_RGCTX_METHOD_INFO(method->klass->rgctx_data, 0)->methodPointer)((Iterator_1_tF558BC64630CA9038F999F5A16CC3DD5A0DB6933 *)__this, /*hidden argument*/IL2CPP_RGCTX_METHOD_INFO(method->klass->rgctx_data, 0));
		List_1_t3F94120C77410A62EAE48421CF166B83AB95A2F5 * L_0 = ___source0;
		__this->set_source_3(L_0);
		Func_2_t99409DECFF50F0FA9B427C863AC6C99C66E6F9F8 * L_1 = ___predicate1;
		__this->set_predicate_4(L_1);
		Func_2_t99409DECFF50F0FA9B427C863AC6C99C66E6F9F8 * L_2 = ___selector2;
		__this->set_selector_5(L_2);
		return;
	}
}
// System.Linq.Enumerable/Iterator`1<TResult> System.Linq.Enumerable/WhereSelectListIterator`2<System.Object,System.Boolean>::Clone()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR Iterator_1_tF558BC64630CA9038F999F5A16CC3DD5A0DB6933 * WhereSelectListIterator_2_Clone_m3D586D710F13095D06B4257C1EB35EAF2D438BFC_gshared (WhereSelectListIterator_2_t1135F63EC4A3B58BB9EDE8324AD11A2B64F209E2 * __this, const RuntimeMethod* method)
{
	{
		List_1_t3F94120C77410A62EAE48421CF166B83AB95A2F5 * L_0 = (List_1_t3F94120C77410A62EAE48421CF166B83AB95A2F5 *)__this->get_source_3();
		Func_2_t99409DECFF50F0FA9B427C863AC6C99C66E6F9F8 * L_1 = (Func_2_t99409DECFF50F0FA9B427C863AC6C99C66E6F9F8 *)__this->get_predicate_4();
		Func_2_t99409DECFF50F0FA9B427C863AC6C99C66E6F9F8 * L_2 = (Func_2_t99409DECFF50F0FA9B427C863AC6C99C66E6F9F8 *)__this->get_selector_5();
		WhereSelectListIterator_2_t1135F63EC4A3B58BB9EDE8324AD11A2B64F209E2 * L_3 = (WhereSelectListIterator_2_t1135F63EC4A3B58BB9EDE8324AD11A2B64F209E2 *)il2cpp_codegen_object_new(IL2CPP_RGCTX_DATA(method->klass->rgctx_data, 2));
		((  void (*) (WhereSelectListIterator_2_t1135F63EC4A3B58BB9EDE8324AD11A2B64F209E2 *, List_1_t3F94120C77410A62EAE48421CF166B83AB95A2F5 *, Func_2_t99409DECFF50F0FA9B427C863AC6C99C66E6F9F8 *, Func_2_t99409DECFF50F0FA9B427C863AC6C99C66E6F9F8 *, const RuntimeMethod*))IL2CPP_RGCTX_METHOD_INFO(method->klass->rgctx_data, 3)->methodPointer)(L_3, (List_1_t3F94120C77410A62EAE48421CF166B83AB95A2F5 *)L_0, (Func_2_t99409DECFF50F0FA9B427C863AC6C99C66E6F9F8 *)L_1, (Func_2_t99409DECFF50F0FA9B427C863AC6C99C66E6F9F8 *)L_2, /*hidden argument*/IL2CPP_RGCTX_METHOD_INFO(method->klass->rgctx_data, 3));
		return (Iterator_1_tF558BC64630CA9038F999F5A16CC3DD5A0DB6933 *)L_3;
	}
}
// System.Boolean System.Linq.Enumerable/WhereSelectListIterator`2<System.Object,System.Boolean>::MoveNext()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR bool WhereSelectListIterator_2_MoveNext_mB94D16C026FC155B40EC9AA5B22866B02C8CDE89_gshared (WhereSelectListIterator_2_t1135F63EC4A3B58BB9EDE8324AD11A2B64F209E2 * __this, const RuntimeMethod* method)
{
	int32_t V_0 = 0;
	RuntimeObject * V_1 = NULL;
	{
		int32_t L_0 = (int32_t)((Iterator_1_tF558BC64630CA9038F999F5A16CC3DD5A0DB6933 *)__this)->get_state_1();
		V_0 = (int32_t)L_0;
		int32_t L_1 = V_0;
		if ((((int32_t)L_1) == ((int32_t)1)))
		{
			goto IL_0011;
		}
	}
	{
		int32_t L_2 = V_0;
		if ((((int32_t)L_2) == ((int32_t)2)))
		{
			goto IL_0061;
		}
	}
	{
		goto IL_0074;
	}

IL_0011:
	{
		List_1_t3F94120C77410A62EAE48421CF166B83AB95A2F5 * L_3 = (List_1_t3F94120C77410A62EAE48421CF166B83AB95A2F5 *)__this->get_source_3();
		NullCheck((List_1_t3F94120C77410A62EAE48421CF166B83AB95A2F5 *)L_3);
		Enumerator_tB6009981BD4E3881E3EC83627255A24198F902D6  L_4;
		L_4 = ((  Enumerator_tB6009981BD4E3881E3EC83627255A24198F902D6  (*) (List_1_t3F94120C77410A62EAE48421CF166B83AB95A2F5 *, const RuntimeMethod*))IL2CPP_RGCTX_METHOD_INFO(method->klass->rgctx_data, 4)->methodPointer)((List_1_t3F94120C77410A62EAE48421CF166B83AB95A2F5 *)L_3, /*hidden argument*/IL2CPP_RGCTX_METHOD_INFO(method->klass->rgctx_data, 4));
		__this->set_enumerator_6(L_4);
		((Iterator_1_tF558BC64630CA9038F999F5A16CC3DD5A0DB6933 *)__this)->set_state_1(2);
		goto IL_0061;
	}

IL_002b:
	{
		Enumerator_tB6009981BD4E3881E3EC83627255A24198F902D6 * L_5 = (Enumerator_tB6009981BD4E3881E3EC83627255A24198F902D6 *)__this->get_address_of_enumerator_6();
		RuntimeObject * L_6;
		L_6 = Enumerator_get_Current_m9C4EBBD2108B51885E750F927D7936290C8E20EE_inline((Enumerator_tB6009981BD4E3881E3EC83627255A24198F902D6 *)(Enumerator_tB6009981BD4E3881E3EC83627255A24198F902D6 *)L_5, /*hidden argument*/IL2CPP_RGCTX_METHOD_INFO(method->klass->rgctx_data, 5));
		V_1 = (RuntimeObject *)L_6;
		Func_2_t99409DECFF50F0FA9B427C863AC6C99C66E6F9F8 * L_7 = (Func_2_t99409DECFF50F0FA9B427C863AC6C99C66E6F9F8 *)__this->get_predicate_4();
		if (!L_7)
		{
			goto IL_004d;
		}
	}
	{
		Func_2_t99409DECFF50F0FA9B427C863AC6C99C66E6F9F8 * L_8 = (Func_2_t99409DECFF50F0FA9B427C863AC6C99C66E6F9F8 *)__this->get_predicate_4();
		RuntimeObject * L_9 = V_1;
		NullCheck((Func_2_t99409DECFF50F0FA9B427C863AC6C99C66E6F9F8 *)L_8);
		bool L_10;
		L_10 = ((  bool (*) (Func_2_t99409DECFF50F0FA9B427C863AC6C99C66E6F9F8 *, RuntimeObject *, const RuntimeMethod*))IL2CPP_RGCTX_METHOD_INFO(method->klass->rgctx_data, 6)->methodPointer)((Func_2_t99409DECFF50F0FA9B427C863AC6C99C66E6F9F8 *)L_8, (RuntimeObject *)L_9, /*hidden argument*/IL2CPP_RGCTX_METHOD_INFO(method->klass->rgctx_data, 6));
		if (!L_10)
		{
			goto IL_0061;
		}
	}

IL_004d:
	{
		Func_2_t99409DECFF50F0FA9B427C863AC6C99C66E6F9F8 * L_11 = (Func_2_t99409DECFF50F0FA9B427C863AC6C99C66E6F9F8 *)__this->get_selector_5();
		RuntimeObject * L_12 = V_1;
		NullCheck((Func_2_t99409DECFF50F0FA9B427C863AC6C99C66E6F9F8 *)L_11);
		bool L_13;
		L_13 = ((  bool (*) (Func_2_t99409DECFF50F0FA9B427C863AC6C99C66E6F9F8 *, RuntimeObject *, const RuntimeMethod*))IL2CPP_RGCTX_METHOD_INFO(method->klass->rgctx_data, 7)->methodPointer)((Func_2_t99409DECFF50F0FA9B427C863AC6C99C66E6F9F8 *)L_11, (RuntimeObject *)L_12, /*hidden argument*/IL2CPP_RGCTX_METHOD_INFO(method->klass->rgctx_data, 7));
		((Iterator_1_tF558BC64630CA9038F999F5A16CC3DD5A0DB6933 *)__this)->set_current_2(L_13);
		return (bool)1;
	}

IL_0061:
	{
		Enumerator_tB6009981BD4E3881E3EC83627255A24198F902D6 * L_14 = (Enumerator_tB6009981BD4E3881E3EC83627255A24198F902D6 *)__this->get_address_of_enumerator_6();
		bool L_15;
		L_15 = Enumerator_MoveNext_m2E56233762839CE55C67E00AC8DD3D4D3F6C0DF0((Enumerator_tB6009981BD4E3881E3EC83627255A24198F902D6 *)(Enumerator_tB6009981BD4E3881E3EC83627255A24198F902D6 *)L_14, /*hidden argument*/IL2CPP_RGCTX_METHOD_INFO(method->klass->rgctx_data, 8));
		if (L_15)
		{
			goto IL_002b;
		}
	}
	{
		NullCheck((Iterator_1_tF558BC64630CA9038F999F5A16CC3DD5A0DB6933 *)__this);
		VirtActionInvoker0::Invoke(12 /* System.Void System.Linq.Enumerable/Iterator`1<System.Boolean>::Dispose() */, (Iterator_1_tF558BC64630CA9038F999F5A16CC3DD5A0DB6933 *)__this);
	}

IL_0074:
	{
		return (bool)0;
	}
}
// System.Collections.Generic.IEnumerable`1<TResult> System.Linq.Enumerable/WhereSelectListIterator`2<System.Object,System.Boolean>::Where(System.Func`2<TResult,System.Boolean>)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR RuntimeObject* WhereSelectListIterator_2_Where_mA28A80FD896B11F671BF4EC49E044EC1EF51F050_gshared (WhereSelectListIterator_2_t1135F63EC4A3B58BB9EDE8324AD11A2B64F209E2 * __this, Func_2_t50F598941CFDF02619DC5D52FFDBC329473C5F7B * ___predicate0, const RuntimeMethod* method)
{
	{
		Func_2_t50F598941CFDF02619DC5D52FFDBC329473C5F7B * L_0 = ___predicate0;
		WhereEnumerableIterator_1_t3A84EA4A91D206312F2931E2BC9124FFF81BFE22 * L_1 = (WhereEnumerableIterator_1_t3A84EA4A91D206312F2931E2BC9124FFF81BFE22 *)il2cpp_codegen_object_new(IL2CPP_RGCTX_DATA(method->klass->rgctx_data, 10));
		((  void (*) (WhereEnumerableIterator_1_t3A84EA4A91D206312F2931E2BC9124FFF81BFE22 *, RuntimeObject*, Func_2_t50F598941CFDF02619DC5D52FFDBC329473C5F7B *, const RuntimeMethod*))IL2CPP_RGCTX_METHOD_INFO(method->klass->rgctx_data, 11)->methodPointer)(L_1, (RuntimeObject*)__this, (Func_2_t50F598941CFDF02619DC5D52FFDBC329473C5F7B *)L_0, /*hidden argument*/IL2CPP_RGCTX_METHOD_INFO(method->klass->rgctx_data, 11));
		return (RuntimeObject*)L_1;
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
// System.Void System.Linq.Enumerable/WhereSelectListIterator`2<System.Object,System.Decimal>::.ctor(System.Collections.Generic.List`1<TSource>,System.Func`2<TSource,System.Boolean>,System.Func`2<TSource,TResult>)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void WhereSelectListIterator_2__ctor_mAD1D9E914C1DBACB629286D1B25F6A2076F24460_gshared (WhereSelectListIterator_2_t613751E34DF4E5DB1F8E3A1B3B14696B0408ED62 * __this, List_1_t3F94120C77410A62EAE48421CF166B83AB95A2F5 * ___source0, Func_2_t99409DECFF50F0FA9B427C863AC6C99C66E6F9F8 * ___predicate1, Func_2_t849BC6BC29946D6D8A1A3EB4E4406C8ADBD11CAA * ___selector2, const RuntimeMethod* method)
{
	{
		NullCheck((Iterator_1_t4861EDEAC91472CDE6F71F17BA6EF43B5D56F78E *)__this);
		((  void (*) (Iterator_1_t4861EDEAC91472CDE6F71F17BA6EF43B5D56F78E *, const RuntimeMethod*))IL2CPP_RGCTX_METHOD_INFO(method->klass->rgctx_data, 0)->methodPointer)((Iterator_1_t4861EDEAC91472CDE6F71F17BA6EF43B5D56F78E *)__this, /*hidden argument*/IL2CPP_RGCTX_METHOD_INFO(method->klass->rgctx_data, 0));
		List_1_t3F94120C77410A62EAE48421CF166B83AB95A2F5 * L_0 = ___source0;
		__this->set_source_3(L_0);
		Func_2_t99409DECFF50F0FA9B427C863AC6C99C66E6F9F8 * L_1 = ___predicate1;
		__this->set_predicate_4(L_1);
		Func_2_t849BC6BC29946D6D8A1A3EB4E4406C8ADBD11CAA * L_2 = ___selector2;
		__this->set_selector_5(L_2);
		return;
	}
}
// System.Linq.Enumerable/Iterator`1<TResult> System.Linq.Enumerable/WhereSelectListIterator`2<System.Object,System.Decimal>::Clone()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR Iterator_1_t4861EDEAC91472CDE6F71F17BA6EF43B5D56F78E * WhereSelectListIterator_2_Clone_m9F28D7206A1B5A39E02EB7A4E386D9557C5AE372_gshared (WhereSelectListIterator_2_t613751E34DF4E5DB1F8E3A1B3B14696B0408ED62 * __this, const RuntimeMethod* method)
{
	{
		List_1_t3F94120C77410A62EAE48421CF166B83AB95A2F5 * L_0 = (List_1_t3F94120C77410A62EAE48421CF166B83AB95A2F5 *)__this->get_source_3();
		Func_2_t99409DECFF50F0FA9B427C863AC6C99C66E6F9F8 * L_1 = (Func_2_t99409DECFF50F0FA9B427C863AC6C99C66E6F9F8 *)__this->get_predicate_4();
		Func_2_t849BC6BC29946D6D8A1A3EB4E4406C8ADBD11CAA * L_2 = (Func_2_t849BC6BC29946D6D8A1A3EB4E4406C8ADBD11CAA *)__this->get_selector_5();
		WhereSelectListIterator_2_t613751E34DF4E5DB1F8E3A1B3B14696B0408ED62 * L_3 = (WhereSelectListIterator_2_t613751E34DF4E5DB1F8E3A1B3B14696B0408ED62 *)il2cpp_codegen_object_new(IL2CPP_RGCTX_DATA(method->klass->rgctx_data, 2));
		((  void (*) (WhereSelectListIterator_2_t613751E34DF4E5DB1F8E3A1B3B14696B0408ED62 *, List_1_t3F94120C77410A62EAE48421CF166B83AB95A2F5 *, Func_2_t99409DECFF50F0FA9B427C863AC6C99C66E6F9F8 *, Func_2_t849BC6BC29946D6D8A1A3EB4E4406C8ADBD11CAA *, const RuntimeMethod*))IL2CPP_RGCTX_METHOD_INFO(method->klass->rgctx_data, 3)->methodPointer)(L_3, (List_1_t3F94120C77410A62EAE48421CF166B83AB95A2F5 *)L_0, (Func_2_t99409DECFF50F0FA9B427C863AC6C99C66E6F9F8 *)L_1, (Func_2_t849BC6BC29946D6D8A1A3EB4E4406C8ADBD11CAA *)L_2, /*hidden argument*/IL2CPP_RGCTX_METHOD_INFO(method->klass->rgctx_data, 3));
		return (Iterator_1_t4861EDEAC91472CDE6F71F17BA6EF43B5D56F78E *)L_3;
	}
}
// System.Boolean System.Linq.Enumerable/WhereSelectListIterator`2<System.Object,System.Decimal>::MoveNext()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR bool WhereSelectListIterator_2_MoveNext_m5BF3B44FAAF9BD7246F1CF0FA932F4C6EAE2C485_gshared (WhereSelectListIterator_2_t613751E34DF4E5DB1F8E3A1B3B14696B0408ED62 * __this, const RuntimeMethod* method)
{
	int32_t V_0 = 0;
	RuntimeObject * V_1 = NULL;
	{
		int32_t L_0 = (int32_t)((Iterator_1_t4861EDEAC91472CDE6F71F17BA6EF43B5D56F78E *)__this)->get_state_1();
		V_0 = (int32_t)L_0;
		int32_t L_1 = V_0;
		if ((((int32_t)L_1) == ((int32_t)1)))
		{
			goto IL_0011;
		}
	}
	{
		int32_t L_2 = V_0;
		if ((((int32_t)L_2) == ((int32_t)2)))
		{
			goto IL_0061;
		}
	}
	{
		goto IL_0074;
	}

IL_0011:
	{
		List_1_t3F94120C77410A62EAE48421CF166B83AB95A2F5 * L_3 = (List_1_t3F94120C77410A62EAE48421CF166B83AB95A2F5 *)__this->get_source_3();
		NullCheck((List_1_t3F94120C77410A62EAE48421CF166B83AB95A2F5 *)L_3);
		Enumerator_tB6009981BD4E3881E3EC83627255A24198F902D6  L_4;
		L_4 = ((  Enumerator_tB6009981BD4E3881E3EC83627255A24198F902D6  (*) (List_1_t3F94120C77410A62EAE48421CF166B83AB95A2F5 *, const RuntimeMethod*))IL2CPP_RGCTX_METHOD_INFO(method->klass->rgctx_data, 4)->methodPointer)((List_1_t3F94120C77410A62EAE48421CF166B83AB95A2F5 *)L_3, /*hidden argument*/IL2CPP_RGCTX_METHOD_INFO(method->klass->rgctx_data, 4));
		__this->set_enumerator_6(L_4);
		((Iterator_1_t4861EDEAC91472CDE6F71F17BA6EF43B5D56F78E *)__this)->set_state_1(2);
		goto IL_0061;
	}

IL_002b:
	{
		Enumerator_tB6009981BD4E3881E3EC83627255A24198F902D6 * L_5 = (Enumerator_tB6009981BD4E3881E3EC83627255A24198F902D6 *)__this->get_address_of_enumerator_6();
		RuntimeObject * L_6;
		L_6 = Enumerator_get_Current_m9C4EBBD2108B51885E750F927D7936290C8E20EE_inline((Enumerator_tB6009981BD4E3881E3EC83627255A24198F902D6 *)(Enumerator_tB6009981BD4E3881E3EC83627255A24198F902D6 *)L_5, /*hidden argument*/IL2CPP_RGCTX_METHOD_INFO(method->klass->rgctx_data, 5));
		V_1 = (RuntimeObject *)L_6;
		Func_2_t99409DECFF50F0FA9B427C863AC6C99C66E6F9F8 * L_7 = (Func_2_t99409DECFF50F0FA9B427C863AC6C99C66E6F9F8 *)__this->get_predicate_4();
		if (!L_7)
		{
			goto IL_004d;
		}
	}
	{
		Func_2_t99409DECFF50F0FA9B427C863AC6C99C66E6F9F8 * L_8 = (Func_2_t99409DECFF50F0FA9B427C863AC6C99C66E6F9F8 *)__this->get_predicate_4();
		RuntimeObject * L_9 = V_1;
		NullCheck((Func_2_t99409DECFF50F0FA9B427C863AC6C99C66E6F9F8 *)L_8);
		bool L_10;
		L_10 = ((  bool (*) (Func_2_t99409DECFF50F0FA9B427C863AC6C99C66E6F9F8 *, RuntimeObject *, const RuntimeMethod*))IL2CPP_RGCTX_METHOD_INFO(method->klass->rgctx_data, 6)->methodPointer)((Func_2_t99409DECFF50F0FA9B427C863AC6C99C66E6F9F8 *)L_8, (RuntimeObject *)L_9, /*hidden argument*/IL2CPP_RGCTX_METHOD_INFO(method->klass->rgctx_data, 6));
		if (!L_10)
		{
			goto IL_0061;
		}
	}

IL_004d:
	{
		Func_2_t849BC6BC29946D6D8A1A3EB4E4406C8ADBD11CAA * L_11 = (Func_2_t849BC6BC29946D6D8A1A3EB4E4406C8ADBD11CAA *)__this->get_selector_5();
		RuntimeObject * L_12 = V_1;
		NullCheck((Func_2_t849BC6BC29946D6D8A1A3EB4E4406C8ADBD11CAA *)L_11);
		Decimal_t2978B229CA86D3B7BA66A0AEEE014E0DE4F940D7  L_13;
		L_13 = ((  Decimal_t2978B229CA86D3B7BA66A0AEEE014E0DE4F940D7  (*) (Func_2_t849BC6BC29946D6D8A1A3EB4E4406C8ADBD11CAA *, RuntimeObject *, const RuntimeMethod*))IL2CPP_RGCTX_METHOD_INFO(method->klass->rgctx_data, 7)->methodPointer)((Func_2_t849BC6BC29946D6D8A1A3EB4E4406C8ADBD11CAA *)L_11, (RuntimeObject *)L_12, /*hidden argument*/IL2CPP_RGCTX_METHOD_INFO(method->klass->rgctx_data, 7));
		((Iterator_1_t4861EDEAC91472CDE6F71F17BA6EF43B5D56F78E *)__this)->set_current_2(L_13);
		return (bool)1;
	}

IL_0061:
	{
		Enumerator_tB6009981BD4E3881E3EC83627255A24198F902D6 * L_14 = (Enumerator_tB6009981BD4E3881E3EC83627255A24198F902D6 *)__this->get_address_of_enumerator_6();
		bool L_15;
		L_15 = Enumerator_MoveNext_m2E56233762839CE55C67E00AC8DD3D4D3F6C0DF0((Enumerator_tB6009981BD4E3881E3EC83627255A24198F902D6 *)(Enumerator_tB6009981BD4E3881E3EC83627255A24198F902D6 *)L_14, /*hidden argument*/IL2CPP_RGCTX_METHOD_INFO(method->klass->rgctx_data, 8));
		if (L_15)
		{
			goto IL_002b;
		}
	}
	{
		NullCheck((Iterator_1_t4861EDEAC91472CDE6F71F17BA6EF43B5D56F78E *)__this);
		VirtActionInvoker0::Invoke(12 /* System.Void System.Linq.Enumerable/Iterator`1<System.Decimal>::Dispose() */, (Iterator_1_t4861EDEAC91472CDE6F71F17BA6EF43B5D56F78E *)__this);
	}

IL_0074:
	{
		return (bool)0;
	}
}
// System.Collections.Generic.IEnumerable`1<TResult> System.Linq.Enumerable/WhereSelectListIterator`2<System.Object,System.Decimal>::Where(System.Func`2<TResult,System.Boolean>)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR RuntimeObject* WhereSelectListIterator_2_Where_mF30BE2725507BD0FACD590AE69A367FB79B0D28B_gshared (WhereSelectListIterator_2_t613751E34DF4E5DB1F8E3A1B3B14696B0408ED62 * __this, Func_2_t85912C5553CB5462E74F14A32388FC1004CC7C2E * ___predicate0, const RuntimeMethod* method)
{
	{
		Func_2_t85912C5553CB5462E74F14A32388FC1004CC7C2E * L_0 = ___predicate0;
		WhereEnumerableIterator_1_t681EE290755A32EDFF9E6FDD4DF16CD94CA1A371 * L_1 = (WhereEnumerableIterator_1_t681EE290755A32EDFF9E6FDD4DF16CD94CA1A371 *)il2cpp_codegen_object_new(IL2CPP_RGCTX_DATA(method->klass->rgctx_data, 10));
		((  void (*) (WhereEnumerableIterator_1_t681EE290755A32EDFF9E6FDD4DF16CD94CA1A371 *, RuntimeObject*, Func_2_t85912C5553CB5462E74F14A32388FC1004CC7C2E *, const RuntimeMethod*))IL2CPP_RGCTX_METHOD_INFO(method->klass->rgctx_data, 11)->methodPointer)(L_1, (RuntimeObject*)__this, (Func_2_t85912C5553CB5462E74F14A32388FC1004CC7C2E *)L_0, /*hidden argument*/IL2CPP_RGCTX_METHOD_INFO(method->klass->rgctx_data, 11));
		return (RuntimeObject*)L_1;
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
// System.Void System.Linq.Enumerable/WhereSelectListIterator`2<System.Object,System.Double>::.ctor(System.Collections.Generic.List`1<TSource>,System.Func`2<TSource,System.Boolean>,System.Func`2<TSource,TResult>)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void WhereSelectListIterator_2__ctor_m955E2514E86A33DE8552507441A67AA3CE1FD4FE_gshared (WhereSelectListIterator_2_tFD5E5F4E072C47EE9200C7D42018559EEAA4E0CD * __this, List_1_t3F94120C77410A62EAE48421CF166B83AB95A2F5 * ___source0, Func_2_t99409DECFF50F0FA9B427C863AC6C99C66E6F9F8 * ___predicate1, Func_2_t32F4E81162C0EB5B67EF4324ABCC54A453AB7B22 * ___selector2, const RuntimeMethod* method)
{
	{
		NullCheck((Iterator_1_t167C775670D48A9186D95126BDB6A078470CAE8D *)__this);
		((  void (*) (Iterator_1_t167C775670D48A9186D95126BDB6A078470CAE8D *, const RuntimeMethod*))IL2CPP_RGCTX_METHOD_INFO(method->klass->rgctx_data, 0)->methodPointer)((Iterator_1_t167C775670D48A9186D95126BDB6A078470CAE8D *)__this, /*hidden argument*/IL2CPP_RGCTX_METHOD_INFO(method->klass->rgctx_data, 0));
		List_1_t3F94120C77410A62EAE48421CF166B83AB95A2F5 * L_0 = ___source0;
		__this->set_source_3(L_0);
		Func_2_t99409DECFF50F0FA9B427C863AC6C99C66E6F9F8 * L_1 = ___predicate1;
		__this->set_predicate_4(L_1);
		Func_2_t32F4E81162C0EB5B67EF4324ABCC54A453AB7B22 * L_2 = ___selector2;
		__this->set_selector_5(L_2);
		return;
	}
}
// System.Linq.Enumerable/Iterator`1<TResult> System.Linq.Enumerable/WhereSelectListIterator`2<System.Object,System.Double>::Clone()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR Iterator_1_t167C775670D48A9186D95126BDB6A078470CAE8D * WhereSelectListIterator_2_Clone_m7DC6E52FFA0228540D8488C6702D100E84818337_gshared (WhereSelectListIterator_2_tFD5E5F4E072C47EE9200C7D42018559EEAA4E0CD * __this, const RuntimeMethod* method)
{
	{
		List_1_t3F94120C77410A62EAE48421CF166B83AB95A2F5 * L_0 = (List_1_t3F94120C77410A62EAE48421CF166B83AB95A2F5 *)__this->get_source_3();
		Func_2_t99409DECFF50F0FA9B427C863AC6C99C66E6F9F8 * L_1 = (Func_2_t99409DECFF50F0FA9B427C863AC6C99C66E6F9F8 *)__this->get_predicate_4();
		Func_2_t32F4E81162C0EB5B67EF4324ABCC54A453AB7B22 * L_2 = (Func_2_t32F4E81162C0EB5B67EF4324ABCC54A453AB7B22 *)__this->get_selector_5();
		WhereSelectListIterator_2_tFD5E5F4E072C47EE9200C7D42018559EEAA4E0CD * L_3 = (WhereSelectListIterator_2_tFD5E5F4E072C47EE9200C7D42018559EEAA4E0CD *)il2cpp_codegen_object_new(IL2CPP_RGCTX_DATA(method->klass->rgctx_data, 2));
		((  void (*) (WhereSelectListIterator_2_tFD5E5F4E072C47EE9200C7D42018559EEAA4E0CD *, List_1_t3F94120C77410A62EAE48421CF166B83AB95A2F5 *, Func_2_t99409DECFF50F0FA9B427C863AC6C99C66E6F9F8 *, Func_2_t32F4E81162C0EB5B67EF4324ABCC54A453AB7B22 *, const RuntimeMethod*))IL2CPP_RGCTX_METHOD_INFO(method->klass->rgctx_data, 3)->methodPointer)(L_3, (List_1_t3F94120C77410A62EAE48421CF166B83AB95A2F5 *)L_0, (Func_2_t99409DECFF50F0FA9B427C863AC6C99C66E6F9F8 *)L_1, (Func_2_t32F4E81162C0EB5B67EF4324ABCC54A453AB7B22 *)L_2, /*hidden argument*/IL2CPP_RGCTX_METHOD_INFO(method->klass->rgctx_data, 3));
		return (Iterator_1_t167C775670D48A9186D95126BDB6A078470CAE8D *)L_3;
	}
}
// System.Boolean System.Linq.Enumerable/WhereSelectListIterator`2<System.Object,System.Double>::MoveNext()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR bool WhereSelectListIterator_2_MoveNext_mBA84677C4E01FEA8700C2E80570BE669EB9F589E_gshared (WhereSelectListIterator_2_tFD5E5F4E072C47EE9200C7D42018559EEAA4E0CD * __this, const RuntimeMethod* method)
{
	int32_t V_0 = 0;
	RuntimeObject * V_1 = NULL;
	{
		int32_t L_0 = (int32_t)((Iterator_1_t167C775670D48A9186D95126BDB6A078470CAE8D *)__this)->get_state_1();
		V_0 = (int32_t)L_0;
		int32_t L_1 = V_0;
		if ((((int32_t)L_1) == ((int32_t)1)))
		{
			goto IL_0011;
		}
	}
	{
		int32_t L_2 = V_0;
		if ((((int32_t)L_2) == ((int32_t)2)))
		{
			goto IL_0061;
		}
	}
	{
		goto IL_0074;
	}

IL_0011:
	{
		List_1_t3F94120C77410A62EAE48421CF166B83AB95A2F5 * L_3 = (List_1_t3F94120C77410A62EAE48421CF166B83AB95A2F5 *)__this->get_source_3();
		NullCheck((List_1_t3F94120C77410A62EAE48421CF166B83AB95A2F5 *)L_3);
		Enumerator_tB6009981BD4E3881E3EC83627255A24198F902D6  L_4;
		L_4 = ((  Enumerator_tB6009981BD4E3881E3EC83627255A24198F902D6  (*) (List_1_t3F94120C77410A62EAE48421CF166B83AB95A2F5 *, const RuntimeMethod*))IL2CPP_RGCTX_METHOD_INFO(method->klass->rgctx_data, 4)->methodPointer)((List_1_t3F94120C77410A62EAE48421CF166B83AB95A2F5 *)L_3, /*hidden argument*/IL2CPP_RGCTX_METHOD_INFO(method->klass->rgctx_data, 4));
		__this->set_enumerator_6(L_4);
		((Iterator_1_t167C775670D48A9186D95126BDB6A078470CAE8D *)__this)->set_state_1(2);
		goto IL_0061;
	}

IL_002b:
	{
		Enumerator_tB6009981BD4E3881E3EC83627255A24198F902D6 * L_5 = (Enumerator_tB6009981BD4E3881E3EC83627255A24198F902D6 *)__this->get_address_of_enumerator_6();
		RuntimeObject * L_6;
		L_6 = Enumerator_get_Current_m9C4EBBD2108B51885E750F927D7936290C8E20EE_inline((Enumerator_tB6009981BD4E3881E3EC83627255A24198F902D6 *)(Enumerator_tB6009981BD4E3881E3EC83627255A24198F902D6 *)L_5, /*hidden argument*/IL2CPP_RGCTX_METHOD_INFO(method->klass->rgctx_data, 5));
		V_1 = (RuntimeObject *)L_6;
		Func_2_t99409DECFF50F0FA9B427C863AC6C99C66E6F9F8 * L_7 = (Func_2_t99409DECFF50F0FA9B427C863AC6C99C66E6F9F8 *)__this->get_predicate_4();
		if (!L_7)
		{
			goto IL_004d;
		}
	}
	{
		Func_2_t99409DECFF50F0FA9B427C863AC6C99C66E6F9F8 * L_8 = (Func_2_t99409DECFF50F0FA9B427C863AC6C99C66E6F9F8 *)__this->get_predicate_4();
		RuntimeObject * L_9 = V_1;
		NullCheck((Func_2_t99409DECFF50F0FA9B427C863AC6C99C66E6F9F8 *)L_8);
		bool L_10;
		L_10 = ((  bool (*) (Func_2_t99409DECFF50F0FA9B427C863AC6C99C66E6F9F8 *, RuntimeObject *, const RuntimeMethod*))IL2CPP_RGCTX_METHOD_INFO(method->klass->rgctx_data, 6)->methodPointer)((Func_2_t99409DECFF50F0FA9B427C863AC6C99C66E6F9F8 *)L_8, (RuntimeObject *)L_9, /*hidden argument*/IL2CPP_RGCTX_METHOD_INFO(method->klass->rgctx_data, 6));
		if (!L_10)
		{
			goto IL_0061;
		}
	}

IL_004d:
	{
		Func_2_t32F4E81162C0EB5B67EF4324ABCC54A453AB7B22 * L_11 = (Func_2_t32F4E81162C0EB5B67EF4324ABCC54A453AB7B22 *)__this->get_selector_5();
		RuntimeObject * L_12 = V_1;
		NullCheck((Func_2_t32F4E81162C0EB5B67EF4324ABCC54A453AB7B22 *)L_11);
		double L_13;
		L_13 = ((  double (*) (Func_2_t32F4E81162C0EB5B67EF4324ABCC54A453AB7B22 *, RuntimeObject *, const RuntimeMethod*))IL2CPP_RGCTX_METHOD_INFO(method->klass->rgctx_data, 7)->methodPointer)((Func_2_t32F4E81162C0EB5B67EF4324ABCC54A453AB7B22 *)L_11, (RuntimeObject *)L_12, /*hidden argument*/IL2CPP_RGCTX_METHOD_INFO(method->klass->rgctx_data, 7));
		((Iterator_1_t167C775670D48A9186D95126BDB6A078470CAE8D *)__this)->set_current_2(L_13);
		return (bool)1;
	}

IL_0061:
	{
		Enumerator_tB6009981BD4E3881E3EC83627255A24198F902D6 * L_14 = (Enumerator_tB6009981BD4E3881E3EC83627255A24198F902D6 *)__this->get_address_of_enumerator_6();
		bool L_15;
		L_15 = Enumerator_MoveNext_m2E56233762839CE55C67E00AC8DD3D4D3F6C0DF0((Enumerator_tB6009981BD4E3881E3EC83627255A24198F902D6 *)(Enumerator_tB6009981BD4E3881E3EC83627255A24198F902D6 *)L_14, /*hidden argument*/IL2CPP_RGCTX_METHOD_INFO(method->klass->rgctx_data, 8));
		if (L_15)
		{
			goto IL_002b;
		}
	}
	{
		NullCheck((Iterator_1_t167C775670D48A9186D95126BDB6A078470CAE8D *)__this);
		VirtActionInvoker0::Invoke(12 /* System.Void System.Linq.Enumerable/Iterator`1<System.Double>::Dispose() */, (Iterator_1_t167C775670D48A9186D95126BDB6A078470CAE8D *)__this);
	}

IL_0074:
	{
		return (bool)0;
	}
}
// System.Collections.Generic.IEnumerable`1<TResult> System.Linq.Enumerable/WhereSelectListIterator`2<System.Object,System.Double>::Where(System.Func`2<TResult,System.Boolean>)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR RuntimeObject* WhereSelectListIterator_2_Where_m09280E40D51146B668FDC2F097A8A3740F4F16D1_gshared (WhereSelectListIterator_2_tFD5E5F4E072C47EE9200C7D42018559EEAA4E0CD * __this, Func_2_t4E607BF9FA9E115F43BD77F92F4285E3B8C7FB0D * ___predicate0, const RuntimeMethod* method)
{
	{
		Func_2_t4E607BF9FA9E115F43BD77F92F4285E3B8C7FB0D * L_0 = ___predicate0;
		WhereEnumerableIterator_1_tB738E509FB63FFBEF5774573271E95894BA5679F * L_1 = (WhereEnumerableIterator_1_tB738E509FB63FFBEF5774573271E95894BA5679F *)il2cpp_codegen_object_new(IL2CPP_RGCTX_DATA(method->klass->rgctx_data, 10));
		((  void (*) (WhereEnumerableIterator_1_tB738E509FB63FFBEF5774573271E95894BA5679F *, RuntimeObject*, Func_2_t4E607BF9FA9E115F43BD77F92F4285E3B8C7FB0D *, const RuntimeMethod*))IL2CPP_RGCTX_METHOD_INFO(method->klass->rgctx_data, 11)->methodPointer)(L_1, (RuntimeObject*)__this, (Func_2_t4E607BF9FA9E115F43BD77F92F4285E3B8C7FB0D *)L_0, /*hidden argument*/IL2CPP_RGCTX_METHOD_INFO(method->klass->rgctx_data, 11));
		return (RuntimeObject*)L_1;
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
// System.Void System.Linq.Enumerable/WhereSelectListIterator`2<System.Object,System.Int32>::.ctor(System.Collections.Generic.List`1<TSource>,System.Func`2<TSource,System.Boolean>,System.Func`2<TSource,TResult>)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void WhereSelectListIterator_2__ctor_mA18E5B755DF06EAE14007C295ACE48C7E0615BAE_gshared (WhereSelectListIterator_2_tA7C52B3E46CAC7800298BB868DD54565FDCB75B6 * __this, List_1_t3F94120C77410A62EAE48421CF166B83AB95A2F5 * ___source0, Func_2_t99409DECFF50F0FA9B427C863AC6C99C66E6F9F8 * ___predicate1, Func_2_t0CEE9D1C856153BA9C23BB9D7E929D577AF37A2C * ___selector2, const RuntimeMethod* method)
{
	{
		NullCheck((Iterator_1_tCFFC952B03DBE4E956DE317DB9704D936AEA2379 *)__this);
		((  void (*) (Iterator_1_tCFFC952B03DBE4E956DE317DB9704D936AEA2379 *, const RuntimeMethod*))IL2CPP_RGCTX_METHOD_INFO(method->klass->rgctx_data, 0)->methodPointer)((Iterator_1_tCFFC952B03DBE4E956DE317DB9704D936AEA2379 *)__this, /*hidden argument*/IL2CPP_RGCTX_METHOD_INFO(method->klass->rgctx_data, 0));
		List_1_t3F94120C77410A62EAE48421CF166B83AB95A2F5 * L_0 = ___source0;
		__this->set_source_3(L_0);
		Func_2_t99409DECFF50F0FA9B427C863AC6C99C66E6F9F8 * L_1 = ___predicate1;
		__this->set_predicate_4(L_1);
		Func_2_t0CEE9D1C856153BA9C23BB9D7E929D577AF37A2C * L_2 = ___selector2;
		__this->set_selector_5(L_2);
		return;
	}
}
// System.Linq.Enumerable/Iterator`1<TResult> System.Linq.Enumerable/WhereSelectListIterator`2<System.Object,System.Int32>::Clone()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR Iterator_1_tCFFC952B03DBE4E956DE317DB9704D936AEA2379 * WhereSelectListIterator_2_Clone_mFEFF616AB589FF68AA4BCFE920814C287AC50268_gshared (WhereSelectListIterator_2_tA7C52B3E46CAC7800298BB868DD54565FDCB75B6 * __this, const RuntimeMethod* method)
{
	{
		List_1_t3F94120C77410A62EAE48421CF166B83AB95A2F5 * L_0 = (List_1_t3F94120C77410A62EAE48421CF166B83AB95A2F5 *)__this->get_source_3();
		Func_2_t99409DECFF50F0FA9B427C863AC6C99C66E6F9F8 * L_1 = (Func_2_t99409DECFF50F0FA9B427C863AC6C99C66E6F9F8 *)__this->get_predicate_4();
		Func_2_t0CEE9D1C856153BA9C23BB9D7E929D577AF37A2C * L_2 = (Func_2_t0CEE9D1C856153BA9C23BB9D7E929D577AF37A2C *)__this->get_selector_5();
		WhereSelectListIterator_2_tA7C52B3E46CAC7800298BB868DD54565FDCB75B6 * L_3 = (WhereSelectListIterator_2_tA7C52B3E46CAC7800298BB868DD54565FDCB75B6 *)il2cpp_codegen_object_new(IL2CPP_RGCTX_DATA(method->klass->rgctx_data, 2));
		((  void (*) (WhereSelectListIterator_2_tA7C52B3E46CAC7800298BB868DD54565FDCB75B6 *, List_1_t3F94120C77410A62EAE48421CF166B83AB95A2F5 *, Func_2_t99409DECFF50F0FA9B427C863AC6C99C66E6F9F8 *, Func_2_t0CEE9D1C856153BA9C23BB9D7E929D577AF37A2C *, const RuntimeMethod*))IL2CPP_RGCTX_METHOD_INFO(method->klass->rgctx_data, 3)->methodPointer)(L_3, (List_1_t3F94120C77410A62EAE48421CF166B83AB95A2F5 *)L_0, (Func_2_t99409DECFF50F0FA9B427C863AC6C99C66E6F9F8 *)L_1, (Func_2_t0CEE9D1C856153BA9C23BB9D7E929D577AF37A2C *)L_2, /*hidden argument*/IL2CPP_RGCTX_METHOD_INFO(method->klass->rgctx_data, 3));
		return (Iterator_1_tCFFC952B03DBE4E956DE317DB9704D936AEA2379 *)L_3;
	}
}
// System.Boolean System.Linq.Enumerable/WhereSelectListIterator`2<System.Object,System.Int32>::MoveNext()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR bool WhereSelectListIterator_2_MoveNext_m758147C75B5A6CB8C86D4FEA039965940D0BDD6C_gshared (WhereSelectListIterator_2_tA7C52B3E46CAC7800298BB868DD54565FDCB75B6 * __this, const RuntimeMethod* method)
{
	int32_t V_0 = 0;
	RuntimeObject * V_1 = NULL;
	{
		int32_t L_0 = (int32_t)((Iterator_1_tCFFC952B03DBE4E956DE317DB9704D936AEA2379 *)__this)->get_state_1();
		V_0 = (int32_t)L_0;
		int32_t L_1 = V_0;
		if ((((int32_t)L_1) == ((int32_t)1)))
		{
			goto IL_0011;
		}
	}
	{
		int32_t L_2 = V_0;
		if ((((int32_t)L_2) == ((int32_t)2)))
		{
			goto IL_0061;
		}
	}
	{
		goto IL_0074;
	}

IL_0011:
	{
		List_1_t3F94120C77410A62EAE48421CF166B83AB95A2F5 * L_3 = (List_1_t3F94120C77410A62EAE48421CF166B83AB95A2F5 *)__this->get_source_3();
		NullCheck((List_1_t3F94120C77410A62EAE48421CF166B83AB95A2F5 *)L_3);
		Enumerator_tB6009981BD4E3881E3EC83627255A24198F902D6  L_4;
		L_4 = ((  Enumerator_tB6009981BD4E3881E3EC83627255A24198F902D6  (*) (List_1_t3F94120C77410A62EAE48421CF166B83AB95A2F5 *, const RuntimeMethod*))IL2CPP_RGCTX_METHOD_INFO(method->klass->rgctx_data, 4)->methodPointer)((List_1_t3F94120C77410A62EAE48421CF166B83AB95A2F5 *)L_3, /*hidden argument*/IL2CPP_RGCTX_METHOD_INFO(method->klass->rgctx_data, 4));
		__this->set_enumerator_6(L_4);
		((Iterator_1_tCFFC952B03DBE4E956DE317DB9704D936AEA2379 *)__this)->set_state_1(2);
		goto IL_0061;
	}

IL_002b:
	{
		Enumerator_tB6009981BD4E3881E3EC83627255A24198F902D6 * L_5 = (Enumerator_tB6009981BD4E3881E3EC83627255A24198F902D6 *)__this->get_address_of_enumerator_6();
		RuntimeObject * L_6;
		L_6 = Enumerator_get_Current_m9C4EBBD2108B51885E750F927D7936290C8E20EE_inline((Enumerator_tB6009981BD4E3881E3EC83627255A24198F902D6 *)(Enumerator_tB6009981BD4E3881E3EC83627255A24198F902D6 *)L_5, /*hidden argument*/IL2CPP_RGCTX_METHOD_INFO(method->klass->rgctx_data, 5));
		V_1 = (RuntimeObject *)L_6;
		Func_2_t99409DECFF50F0FA9B427C863AC6C99C66E6F9F8 * L_7 = (Func_2_t99409DECFF50F0FA9B427C863AC6C99C66E6F9F8 *)__this->get_predicate_4();
		if (!L_7)
		{
			goto IL_004d;
		}
	}
	{
		Func_2_t99409DECFF50F0FA9B427C863AC6C99C66E6F9F8 * L_8 = (Func_2_t99409DECFF50F0FA9B427C863AC6C99C66E6F9F8 *)__this->get_predicate_4();
		RuntimeObject * L_9 = V_1;
		NullCheck((Func_2_t99409DECFF50F0FA9B427C863AC6C99C66E6F9F8 *)L_8);
		bool L_10;
		L_10 = ((  bool (*) (Func_2_t99409DECFF50F0FA9B427C863AC6C99C66E6F9F8 *, RuntimeObject *, const RuntimeMethod*))IL2CPP_RGCTX_METHOD_INFO(method->klass->rgctx_data, 6)->methodPointer)((Func_2_t99409DECFF50F0FA9B427C863AC6C99C66E6F9F8 *)L_8, (RuntimeObject *)L_9, /*hidden argument*/IL2CPP_RGCTX_METHOD_INFO(method->klass->rgctx_data, 6));
		if (!L_10)
		{
			goto IL_0061;
		}
	}

IL_004d:
	{
		Func_2_t0CEE9D1C856153BA9C23BB9D7E929D577AF37A2C * L_11 = (Func_2_t0CEE9D1C856153BA9C23BB9D7E929D577AF37A2C *)__this->get_selector_5();
		RuntimeObject * L_12 = V_1;
		NullCheck((Func_2_t0CEE9D1C856153BA9C23BB9D7E929D577AF37A2C *)L_11);
		int32_t L_13;
		L_13 = ((  int32_t (*) (Func_2_t0CEE9D1C856153BA9C23BB9D7E929D577AF37A2C *, RuntimeObject *, const RuntimeMethod*))IL2CPP_RGCTX_METHOD_INFO(method->klass->rgctx_data, 7)->methodPointer)((Func_2_t0CEE9D1C856153BA9C23BB9D7E929D577AF37A2C *)L_11, (RuntimeObject *)L_12, /*hidden argument*/IL2CPP_RGCTX_METHOD_INFO(method->klass->rgctx_data, 7));
		((Iterator_1_tCFFC952B03DBE4E956DE317DB9704D936AEA2379 *)__this)->set_current_2(L_13);
		return (bool)1;
	}

IL_0061:
	{
		Enumerator_tB6009981BD4E3881E3EC83627255A24198F902D6 * L_14 = (Enumerator_tB6009981BD4E3881E3EC83627255A24198F902D6 *)__this->get_address_of_enumerator_6();
		bool L_15;
		L_15 = Enumerator_MoveNext_m2E56233762839CE55C67E00AC8DD3D4D3F6C0DF0((Enumerator_tB6009981BD4E3881E3EC83627255A24198F902D6 *)(Enumerator_tB6009981BD4E3881E3EC83627255A24198F902D6 *)L_14, /*hidden argument*/IL2CPP_RGCTX_METHOD_INFO(method->klass->rgctx_data, 8));
		if (L_15)
		{
			goto IL_002b;
		}
	}
	{
		NullCheck((Iterator_1_tCFFC952B03DBE4E956DE317DB9704D936AEA2379 *)__this);
		VirtActionInvoker0::Invoke(12 /* System.Void System.Linq.Enumerable/Iterator`1<System.Int32>::Dispose() */, (Iterator_1_tCFFC952B03DBE4E956DE317DB9704D936AEA2379 *)__this);
	}

IL_0074:
	{
		return (bool)0;
	}
}
// System.Collections.Generic.IEnumerable`1<TResult> System.Linq.Enumerable/WhereSelectListIterator`2<System.Object,System.Int32>::Where(System.Func`2<TResult,System.Boolean>)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR RuntimeObject* WhereSelectListIterator_2_Where_mB03479084DC9989DEAC9938DC78329DC769EFA14_gshared (WhereSelectListIterator_2_tA7C52B3E46CAC7800298BB868DD54565FDCB75B6 * __this, Func_2_t2EBF98B0BA555D9F0633C9BCCBE3DF332B9C1274 * ___predicate0, const RuntimeMethod* method)
{
	{
		Func_2_t2EBF98B0BA555D9F0633C9BCCBE3DF332B9C1274 * L_0 = ___predicate0;
		WhereEnumerableIterator_1_t9F4DDC70173BABD72AEC7AA00D62F4FAE2613CEA * L_1 = (WhereEnumerableIterator_1_t9F4DDC70173BABD72AEC7AA00D62F4FAE2613CEA *)il2cpp_codegen_object_new(IL2CPP_RGCTX_DATA(method->klass->rgctx_data, 10));
		((  void (*) (WhereEnumerableIterator_1_t9F4DDC70173BABD72AEC7AA00D62F4FAE2613CEA *, RuntimeObject*, Func_2_t2EBF98B0BA555D9F0633C9BCCBE3DF332B9C1274 *, const RuntimeMethod*))IL2CPP_RGCTX_METHOD_INFO(method->klass->rgctx_data, 11)->methodPointer)(L_1, (RuntimeObject*)__this, (Func_2_t2EBF98B0BA555D9F0633C9BCCBE3DF332B9C1274 *)L_0, /*hidden argument*/IL2CPP_RGCTX_METHOD_INFO(method->klass->rgctx_data, 11));
		return (RuntimeObject*)L_1;
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
// System.Void System.Linq.Enumerable/WhereSelectListIterator`2<System.Object,System.Int64>::.ctor(System.Collections.Generic.List`1<TSource>,System.Func`2<TSource,System.Boolean>,System.Func`2<TSource,TResult>)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void WhereSelectListIterator_2__ctor_m5F84B643134CB0A72EE2744BF02ED2C51BD7729A_gshared (WhereSelectListIterator_2_tB72C4254D904FF99DDF6A7B544158C7E96DF5323 * __this, List_1_t3F94120C77410A62EAE48421CF166B83AB95A2F5 * ___source0, Func_2_t99409DECFF50F0FA9B427C863AC6C99C66E6F9F8 * ___predicate1, Func_2_tCA3E9A68051723CDABE44FC0BAE52FE7599059D6 * ___selector2, const RuntimeMethod* method)
{
	{
		NullCheck((Iterator_1_tF88FA02D56A55D26D525180DE0108FA4F019BECE *)__this);
		((  void (*) (Iterator_1_tF88FA02D56A55D26D525180DE0108FA4F019BECE *, const RuntimeMethod*))IL2CPP_RGCTX_METHOD_INFO(method->klass->rgctx_data, 0)->methodPointer)((Iterator_1_tF88FA02D56A55D26D525180DE0108FA4F019BECE *)__this, /*hidden argument*/IL2CPP_RGCTX_METHOD_INFO(method->klass->rgctx_data, 0));
		List_1_t3F94120C77410A62EAE48421CF166B83AB95A2F5 * L_0 = ___source0;
		__this->set_source_3(L_0);
		Func_2_t99409DECFF50F0FA9B427C863AC6C99C66E6F9F8 * L_1 = ___predicate1;
		__this->set_predicate_4(L_1);
		Func_2_tCA3E9A68051723CDABE44FC0BAE52FE7599059D6 * L_2 = ___selector2;
		__this->set_selector_5(L_2);
		return;
	}
}
// System.Linq.Enumerable/Iterator`1<TResult> System.Linq.Enumerable/WhereSelectListIterator`2<System.Object,System.Int64>::Clone()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR Iterator_1_tF88FA02D56A55D26D525180DE0108FA4F019BECE * WhereSelectListIterator_2_Clone_mBBDDAF037D47316823BF2F2618DD7B86B1C429F7_gshared (WhereSelectListIterator_2_tB72C4254D904FF99DDF6A7B544158C7E96DF5323 * __this, const RuntimeMethod* method)
{
	{
		List_1_t3F94120C77410A62EAE48421CF166B83AB95A2F5 * L_0 = (List_1_t3F94120C77410A62EAE48421CF166B83AB95A2F5 *)__this->get_source_3();
		Func_2_t99409DECFF50F0FA9B427C863AC6C99C66E6F9F8 * L_1 = (Func_2_t99409DECFF50F0FA9B427C863AC6C99C66E6F9F8 *)__this->get_predicate_4();
		Func_2_tCA3E9A68051723CDABE44FC0BAE52FE7599059D6 * L_2 = (Func_2_tCA3E9A68051723CDABE44FC0BAE52FE7599059D6 *)__this->get_selector_5();
		WhereSelectListIterator_2_tB72C4254D904FF99DDF6A7B544158C7E96DF5323 * L_3 = (WhereSelectListIterator_2_tB72C4254D904FF99DDF6A7B544158C7E96DF5323 *)il2cpp_codegen_object_new(IL2CPP_RGCTX_DATA(method->klass->rgctx_data, 2));
		((  void (*) (WhereSelectListIterator_2_tB72C4254D904FF99DDF6A7B544158C7E96DF5323 *, List_1_t3F94120C77410A62EAE48421CF166B83AB95A2F5 *, Func_2_t99409DECFF50F0FA9B427C863AC6C99C66E6F9F8 *, Func_2_tCA3E9A68051723CDABE44FC0BAE52FE7599059D6 *, const RuntimeMethod*))IL2CPP_RGCTX_METHOD_INFO(method->klass->rgctx_data, 3)->methodPointer)(L_3, (List_1_t3F94120C77410A62EAE48421CF166B83AB95A2F5 *)L_0, (Func_2_t99409DECFF50F0FA9B427C863AC6C99C66E6F9F8 *)L_1, (Func_2_tCA3E9A68051723CDABE44FC0BAE52FE7599059D6 *)L_2, /*hidden argument*/IL2CPP_RGCTX_METHOD_INFO(method->klass->rgctx_data, 3));
		return (Iterator_1_tF88FA02D56A55D26D525180DE0108FA4F019BECE *)L_3;
	}
}
// System.Boolean System.Linq.Enumerable/WhereSelectListIterator`2<System.Object,System.Int64>::MoveNext()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR bool WhereSelectListIterator_2_MoveNext_m3872D5CEA2C9BDF338C106938244AF47C95BCDB2_gshared (WhereSelectListIterator_2_tB72C4254D904FF99DDF6A7B544158C7E96DF5323 * __this, const RuntimeMethod* method)
{
	int32_t V_0 = 0;
	RuntimeObject * V_1 = NULL;
	{
		int32_t L_0 = (int32_t)((Iterator_1_tF88FA02D56A55D26D525180DE0108FA4F019BECE *)__this)->get_state_1();
		V_0 = (int32_t)L_0;
		int32_t L_1 = V_0;
		if ((((int32_t)L_1) == ((int32_t)1)))
		{
			goto IL_0011;
		}
	}
	{
		int32_t L_2 = V_0;
		if ((((int32_t)L_2) == ((int32_t)2)))
		{
			goto IL_0061;
		}
	}
	{
		goto IL_0074;
	}

IL_0011:
	{
		List_1_t3F94120C77410A62EAE48421CF166B83AB95A2F5 * L_3 = (List_1_t3F94120C77410A62EAE48421CF166B83AB95A2F5 *)__this->get_source_3();
		NullCheck((List_1_t3F94120C77410A62EAE48421CF166B83AB95A2F5 *)L_3);
		Enumerator_tB6009981BD4E3881E3EC83627255A24198F902D6  L_4;
		L_4 = ((  Enumerator_tB6009981BD4E3881E3EC83627255A24198F902D6  (*) (List_1_t3F94120C77410A62EAE48421CF166B83AB95A2F5 *, const RuntimeMethod*))IL2CPP_RGCTX_METHOD_INFO(method->klass->rgctx_data, 4)->methodPointer)((List_1_t3F94120C77410A62EAE48421CF166B83AB95A2F5 *)L_3, /*hidden argument*/IL2CPP_RGCTX_METHOD_INFO(method->klass->rgctx_data, 4));
		__this->set_enumerator_6(L_4);
		((Iterator_1_tF88FA02D56A55D26D525180DE0108FA4F019BECE *)__this)->set_state_1(2);
		goto IL_0061;
	}

IL_002b:
	{
		Enumerator_tB6009981BD4E3881E3EC83627255A24198F902D6 * L_5 = (Enumerator_tB6009981BD4E3881E3EC83627255A24198F902D6 *)__this->get_address_of_enumerator_6();
		RuntimeObject * L_6;
		L_6 = Enumerator_get_Current_m9C4EBBD2108B51885E750F927D7936290C8E20EE_inline((Enumerator_tB6009981BD4E3881E3EC83627255A24198F902D6 *)(Enumerator_tB6009981BD4E3881E3EC83627255A24198F902D6 *)L_5, /*hidden argument*/IL2CPP_RGCTX_METHOD_INFO(method->klass->rgctx_data, 5));
		V_1 = (RuntimeObject *)L_6;
		Func_2_t99409DECFF50F0FA9B427C863AC6C99C66E6F9F8 * L_7 = (Func_2_t99409DECFF50F0FA9B427C863AC6C99C66E6F9F8 *)__this->get_predicate_4();
		if (!L_7)
		{
			goto IL_004d;
		}
	}
	{
		Func_2_t99409DECFF50F0FA9B427C863AC6C99C66E6F9F8 * L_8 = (Func_2_t99409DECFF50F0FA9B427C863AC6C99C66E6F9F8 *)__this->get_predicate_4();
		RuntimeObject * L_9 = V_1;
		NullCheck((Func_2_t99409DECFF50F0FA9B427C863AC6C99C66E6F9F8 *)L_8);
		bool L_10;
		L_10 = ((  bool (*) (Func_2_t99409DECFF50F0FA9B427C863AC6C99C66E6F9F8 *, RuntimeObject *, const RuntimeMethod*))IL2CPP_RGCTX_METHOD_INFO(method->klass->rgctx_data, 6)->methodPointer)((Func_2_t99409DECFF50F0FA9B427C863AC6C99C66E6F9F8 *)L_8, (RuntimeObject *)L_9, /*hidden argument*/IL2CPP_RGCTX_METHOD_INFO(method->klass->rgctx_data, 6));
		if (!L_10)
		{
			goto IL_0061;
		}
	}

IL_004d:
	{
		Func_2_tCA3E9A68051723CDABE44FC0BAE52FE7599059D6 * L_11 = (Func_2_tCA3E9A68051723CDABE44FC0BAE52FE7599059D6 *)__this->get_selector_5();
		RuntimeObject * L_12 = V_1;
		NullCheck((Func_2_tCA3E9A68051723CDABE44FC0BAE52FE7599059D6 *)L_11);
		int64_t L_13;
		L_13 = ((  int64_t (*) (Func_2_tCA3E9A68051723CDABE44FC0BAE52FE7599059D6 *, RuntimeObject *, const RuntimeMethod*))IL2CPP_RGCTX_METHOD_INFO(method->klass->rgctx_data, 7)->methodPointer)((Func_2_tCA3E9A68051723CDABE44FC0BAE52FE7599059D6 *)L_11, (RuntimeObject *)L_12, /*hidden argument*/IL2CPP_RGCTX_METHOD_INFO(method->klass->rgctx_data, 7));
		((Iterator_1_tF88FA02D56A55D26D525180DE0108FA4F019BECE *)__this)->set_current_2(L_13);
		return (bool)1;
	}

IL_0061:
	{
		Enumerator_tB6009981BD4E3881E3EC83627255A24198F902D6 * L_14 = (Enumerator_tB6009981BD4E3881E3EC83627255A24198F902D6 *)__this->get_address_of_enumerator_6();
		bool L_15;
		L_15 = Enumerator_MoveNext_m2E56233762839CE55C67E00AC8DD3D4D3F6C0DF0((Enumerator_tB6009981BD4E3881E3EC83627255A24198F902D6 *)(Enumerator_tB6009981BD4E3881E3EC83627255A24198F902D6 *)L_14, /*hidden argument*/IL2CPP_RGCTX_METHOD_INFO(method->klass->rgctx_data, 8));
		if (L_15)
		{
			goto IL_002b;
		}
	}
	{
		NullCheck((Iterator_1_tF88FA02D56A55D26D525180DE0108FA4F019BECE *)__this);
		VirtActionInvoker0::Invoke(12 /* System.Void System.Linq.Enumerable/Iterator`1<System.Int64>::Dispose() */, (Iterator_1_tF88FA02D56A55D26D525180DE0108FA4F019BECE *)__this);
	}

IL_0074:
	{
		return (bool)0;
	}
}
// System.Collections.Generic.IEnumerable`1<TResult> System.Linq.Enumerable/WhereSelectListIterator`2<System.Object,System.Int64>::Where(System.Func`2<TResult,System.Boolean>)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR RuntimeObject* WhereSelectListIterator_2_Where_mBB616ADFF1E5BB22A53112DF8EF998F5049D4954_gshared (WhereSelectListIterator_2_tB72C4254D904FF99DDF6A7B544158C7E96DF5323 * __this, Func_2_t03B9AF86FB7E93B62590F1CBD16276EF7AA1B215 * ___predicate0, const RuntimeMethod* method)
{
	{
		Func_2_t03B9AF86FB7E93B62590F1CBD16276EF7AA1B215 * L_0 = ___predicate0;
		WhereEnumerableIterator_1_tBAC8281C998E41429788C96260CB05A7E0471BC1 * L_1 = (WhereEnumerableIterator_1_tBAC8281C998E41429788C96260CB05A7E0471BC1 *)il2cpp_codegen_object_new(IL2CPP_RGCTX_DATA(method->klass->rgctx_data, 10));
		((  void (*) (WhereEnumerableIterator_1_tBAC8281C998E41429788C96260CB05A7E0471BC1 *, RuntimeObject*, Func_2_t03B9AF86FB7E93B62590F1CBD16276EF7AA1B215 *, const RuntimeMethod*))IL2CPP_RGCTX_METHOD_INFO(method->klass->rgctx_data, 11)->methodPointer)(L_1, (RuntimeObject*)__this, (Func_2_t03B9AF86FB7E93B62590F1CBD16276EF7AA1B215 *)L_0, /*hidden argument*/IL2CPP_RGCTX_METHOD_INFO(method->klass->rgctx_data, 11));
		return (RuntimeObject*)L_1;
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
// System.Void System.Linq.Enumerable/WhereSelectListIterator`2<System.Object,System.Object>::.ctor(System.Collections.Generic.List`1<TSource>,System.Func`2<TSource,System.Boolean>,System.Func`2<TSource,TResult>)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void WhereSelectListIterator_2__ctor_mCF313A191371C8CCC2E79D89A3BF21714EFDB20E_gshared (WhereSelectListIterator_2_t85B78DFF0573BC95A62C79D6088FA39DFEBE1AF2 * __this, List_1_t3F94120C77410A62EAE48421CF166B83AB95A2F5 * ___source0, Func_2_t99409DECFF50F0FA9B427C863AC6C99C66E6F9F8 * ___predicate1, Func_2_tFF5BB8F40A35B1BEA00D4EBBC6CBE7184A584436 * ___selector2, const RuntimeMethod* method)
{
	{
		NullCheck((Iterator_1_t674ABE41CF4096D4BE4D51E21FEBDADBF74CC279 *)__this);
		((  void (*) (Iterator_1_t674ABE41CF4096D4BE4D51E21FEBDADBF74CC279 *, const RuntimeMethod*))IL2CPP_RGCTX_METHOD_INFO(method->klass->rgctx_data, 0)->methodPointer)((Iterator_1_t674ABE41CF4096D4BE4D51E21FEBDADBF74CC279 *)__this, /*hidden argument*/IL2CPP_RGCTX_METHOD_INFO(method->klass->rgctx_data, 0));
		List_1_t3F94120C77410A62EAE48421CF166B83AB95A2F5 * L_0 = ___source0;
		__this->set_source_3(L_0);
		Func_2_t99409DECFF50F0FA9B427C863AC6C99C66E6F9F8 * L_1 = ___predicate1;
		__this->set_predicate_4(L_1);
		Func_2_tFF5BB8F40A35B1BEA00D4EBBC6CBE7184A584436 * L_2 = ___selector2;
		__this->set_selector_5(L_2);
		return;
	}
}
// System.Linq.Enumerable/Iterator`1<TResult> System.Linq.Enumerable/WhereSelectListIterator`2<System.Object,System.Object>::Clone()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR Iterator_1_t674ABE41CF4096D4BE4D51E21FEBDADBF74CC279 * WhereSelectListIterator_2_Clone_m667BCD94E83BB3A02AF2D66E07B089FA86971342_gshared (WhereSelectListIterator_2_t85B78DFF0573BC95A62C79D6088FA39DFEBE1AF2 * __this, const RuntimeMethod* method)
{
	{
		List_1_t3F94120C77410A62EAE48421CF166B83AB95A2F5 * L_0 = (List_1_t3F94120C77410A62EAE48421CF166B83AB95A2F5 *)__this->get_source_3();
		Func_2_t99409DECFF50F0FA9B427C863AC6C99C66E6F9F8 * L_1 = (Func_2_t99409DECFF50F0FA9B427C863AC6C99C66E6F9F8 *)__this->get_predicate_4();
		Func_2_tFF5BB8F40A35B1BEA00D4EBBC6CBE7184A584436 * L_2 = (Func_2_tFF5BB8F40A35B1BEA00D4EBBC6CBE7184A584436 *)__this->get_selector_5();
		WhereSelectListIterator_2_t85B78DFF0573BC95A62C79D6088FA39DFEBE1AF2 * L_3 = (WhereSelectListIterator_2_t85B78DFF0573BC95A62C79D6088FA39DFEBE1AF2 *)il2cpp_codegen_object_new(IL2CPP_RGCTX_DATA(method->klass->rgctx_data, 2));
		((  void (*) (WhereSelectListIterator_2_t85B78DFF0573BC95A62C79D6088FA39DFEBE1AF2 *, List_1_t3F94120C77410A62EAE48421CF166B83AB95A2F5 *, Func_2_t99409DECFF50F0FA9B427C863AC6C99C66E6F9F8 *, Func_2_tFF5BB8F40A35B1BEA00D4EBBC6CBE7184A584436 *, const RuntimeMethod*))IL2CPP_RGCTX_METHOD_INFO(method->klass->rgctx_data, 3)->methodPointer)(L_3, (List_1_t3F94120C77410A62EAE48421CF166B83AB95A2F5 *)L_0, (Func_2_t99409DECFF50F0FA9B427C863AC6C99C66E6F9F8 *)L_1, (Func_2_tFF5BB8F40A35B1BEA00D4EBBC6CBE7184A584436 *)L_2, /*hidden argument*/IL2CPP_RGCTX_METHOD_INFO(method->klass->rgctx_data, 3));
		return (Iterator_1_t674ABE41CF4096D4BE4D51E21FEBDADBF74CC279 *)L_3;
	}
}
// System.Boolean System.Linq.Enumerable/WhereSelectListIterator`2<System.Object,System.Object>::MoveNext()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR bool WhereSelectListIterator_2_MoveNext_mEE0E8B173345B059100E0736D106FFAE0C2D29CA_gshared (WhereSelectListIterator_2_t85B78DFF0573BC95A62C79D6088FA39DFEBE1AF2 * __this, const RuntimeMethod* method)
{
	int32_t V_0 = 0;
	RuntimeObject * V_1 = NULL;
	{
		int32_t L_0 = (int32_t)((Iterator_1_t674ABE41CF4096D4BE4D51E21FEBDADBF74CC279 *)__this)->get_state_1();
		V_0 = (int32_t)L_0;
		int32_t L_1 = V_0;
		if ((((int32_t)L_1) == ((int32_t)1)))
		{
			goto IL_0011;
		}
	}
	{
		int32_t L_2 = V_0;
		if ((((int32_t)L_2) == ((int32_t)2)))
		{
			goto IL_0061;
		}
	}
	{
		goto IL_0074;
	}

IL_0011:
	{
		List_1_t3F94120C77410A62EAE48421CF166B83AB95A2F5 * L_3 = (List_1_t3F94120C77410A62EAE48421CF166B83AB95A2F5 *)__this->get_source_3();
		NullCheck((List_1_t3F94120C77410A62EAE48421CF166B83AB95A2F5 *)L_3);
		Enumerator_tB6009981BD4E3881E3EC83627255A24198F902D6  L_4;
		L_4 = ((  Enumerator_tB6009981BD4E3881E3EC83627255A24198F902D6  (*) (List_1_t3F94120C77410A62EAE48421CF166B83AB95A2F5 *, const RuntimeMethod*))IL2CPP_RGCTX_METHOD_INFO(method->klass->rgctx_data, 4)->methodPointer)((List_1_t3F94120C77410A62EAE48421CF166B83AB95A2F5 *)L_3, /*hidden argument*/IL2CPP_RGCTX_METHOD_INFO(method->klass->rgctx_data, 4));
		__this->set_enumerator_6(L_4);
		((Iterator_1_t674ABE41CF4096D4BE4D51E21FEBDADBF74CC279 *)__this)->set_state_1(2);
		goto IL_0061;
	}

IL_002b:
	{
		Enumerator_tB6009981BD4E3881E3EC83627255A24198F902D6 * L_5 = (Enumerator_tB6009981BD4E3881E3EC83627255A24198F902D6 *)__this->get_address_of_enumerator_6();
		RuntimeObject * L_6;
		L_6 = Enumerator_get_Current_m9C4EBBD2108B51885E750F927D7936290C8E20EE_inline((Enumerator_tB6009981BD4E3881E3EC83627255A24198F902D6 *)(Enumerator_tB6009981BD4E3881E3EC83627255A24198F902D6 *)L_5, /*hidden argument*/IL2CPP_RGCTX_METHOD_INFO(method->klass->rgctx_data, 5));
		V_1 = (RuntimeObject *)L_6;
		Func_2_t99409DECFF50F0FA9B427C863AC6C99C66E6F9F8 * L_7 = (Func_2_t99409DECFF50F0FA9B427C863AC6C99C66E6F9F8 *)__this->get_predicate_4();
		if (!L_7)
		{
			goto IL_004d;
		}
	}
	{
		Func_2_t99409DECFF50F0FA9B427C863AC6C99C66E6F9F8 * L_8 = (Func_2_t99409DECFF50F0FA9B427C863AC6C99C66E6F9F8 *)__this->get_predicate_4();
		RuntimeObject * L_9 = V_1;
		NullCheck((Func_2_t99409DECFF50F0FA9B427C863AC6C99C66E6F9F8 *)L_8);
		bool L_10;
		L_10 = ((  bool (*) (Func_2_t99409DECFF50F0FA9B427C863AC6C99C66E6F9F8 *, RuntimeObject *, const RuntimeMethod*))IL2CPP_RGCTX_METHOD_INFO(method->klass->rgctx_data, 6)->methodPointer)((Func_2_t99409DECFF50F0FA9B427C863AC6C99C66E6F9F8 *)L_8, (RuntimeObject *)L_9, /*hidden argument*/IL2CPP_RGCTX_METHOD_INFO(method->klass->rgctx_data, 6));
		if (!L_10)
		{
			goto IL_0061;
		}
	}

IL_004d:
	{
		Func_2_tFF5BB8F40A35B1BEA00D4EBBC6CBE7184A584436 * L_11 = (Func_2_tFF5BB8F40A35B1BEA00D4EBBC6CBE7184A584436 *)__this->get_selector_5();
		RuntimeObject * L_12 = V_1;
		NullCheck((Func_2_tFF5BB8F40A35B1BEA00D4EBBC6CBE7184A584436 *)L_11);
		RuntimeObject * L_13;
		L_13 = ((  RuntimeObject * (*) (Func_2_tFF5BB8F40A35B1BEA00D4EBBC6CBE7184A584436 *, RuntimeObject *, const RuntimeMethod*))IL2CPP_RGCTX_METHOD_INFO(method->klass->rgctx_data, 7)->methodPointer)((Func_2_tFF5BB8F40A35B1BEA00D4EBBC6CBE7184A584436 *)L_11, (RuntimeObject *)L_12, /*hidden argument*/IL2CPP_RGCTX_METHOD_INFO(method->klass->rgctx_data, 7));
		((Iterator_1_t674ABE41CF4096D4BE4D51E21FEBDADBF74CC279 *)__this)->set_current_2(L_13);
		return (bool)1;
	}

IL_0061:
	{
		Enumerator_tB6009981BD4E3881E3EC83627255A24198F902D6 * L_14 = (Enumerator_tB6009981BD4E3881E3EC83627255A24198F902D6 *)__this->get_address_of_enumerator_6();
		bool L_15;
		L_15 = Enumerator_MoveNext_m2E56233762839CE55C67E00AC8DD3D4D3F6C0DF0((Enumerator_tB6009981BD4E3881E3EC83627255A24198F902D6 *)(Enumerator_tB6009981BD4E3881E3EC83627255A24198F902D6 *)L_14, /*hidden argument*/IL2CPP_RGCTX_METHOD_INFO(method->klass->rgctx_data, 8));
		if (L_15)
		{
			goto IL_002b;
		}
	}
	{
		NullCheck((Iterator_1_t674ABE41CF4096D4BE4D51E21FEBDADBF74CC279 *)__this);
		VirtActionInvoker0::Invoke(12 /* System.Void System.Linq.Enumerable/Iterator`1<System.Object>::Dispose() */, (Iterator_1_t674ABE41CF4096D4BE4D51E21FEBDADBF74CC279 *)__this);
	}

IL_0074:
	{
		return (bool)0;
	}
}
// System.Collections.Generic.IEnumerable`1<TResult> System.Linq.Enumerable/WhereSelectListIterator`2<System.Object,System.Object>::Where(System.Func`2<TResult,System.Boolean>)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR RuntimeObject* WhereSelectListIterator_2_Where_mAC87184664F73DD7F3EC4AB4CE2BDE71BE76249D_gshared (WhereSelectListIterator_2_t85B78DFF0573BC95A62C79D6088FA39DFEBE1AF2 * __this, Func_2_t99409DECFF50F0FA9B427C863AC6C99C66E6F9F8 * ___predicate0, const RuntimeMethod* method)
{
	{
		Func_2_t99409DECFF50F0FA9B427C863AC6C99C66E6F9F8 * L_0 = ___predicate0;
		WhereEnumerableIterator_1_t1E9FDCFD8F8136C6A5A5740C1E093EF03F0B5CE0 * L_1 = (WhereEnumerableIterator_1_t1E9FDCFD8F8136C6A5A5740C1E093EF03F0B5CE0 *)il2cpp_codegen_object_new(IL2CPP_RGCTX_DATA(method->klass->rgctx_data, 10));
		((  void (*) (WhereEnumerableIterator_1_t1E9FDCFD8F8136C6A5A5740C1E093EF03F0B5CE0 *, RuntimeObject*, Func_2_t99409DECFF50F0FA9B427C863AC6C99C66E6F9F8 *, const RuntimeMethod*))IL2CPP_RGCTX_METHOD_INFO(method->klass->rgctx_data, 11)->methodPointer)(L_1, (RuntimeObject*)__this, (Func_2_t99409DECFF50F0FA9B427C863AC6C99C66E6F9F8 *)L_0, /*hidden argument*/IL2CPP_RGCTX_METHOD_INFO(method->klass->rgctx_data, 11));
		return (RuntimeObject*)L_1;
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
// System.Void System.Linq.Enumerable/WhereSelectListIterator`2<System.Object,System.Single>::.ctor(System.Collections.Generic.List`1<TSource>,System.Func`2<TSource,System.Boolean>,System.Func`2<TSource,TResult>)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void WhereSelectListIterator_2__ctor_m5B584B94A6D099E4BDD69EA2797218B8827C5F0F_gshared (WhereSelectListIterator_2_t20DB17268C20F9E95977E2485885C2547B573A2F * __this, List_1_t3F94120C77410A62EAE48421CF166B83AB95A2F5 * ___source0, Func_2_t99409DECFF50F0FA9B427C863AC6C99C66E6F9F8 * ___predicate1, Func_2_t78F21BB7B6C7D754A8C4D71ACB39668A8F967BA1 * ___selector2, const RuntimeMethod* method)
{
	{
		NullCheck((Iterator_1_t859CAAB8DD3B63D3758E13D2802ED7523B331199 *)__this);
		((  void (*) (Iterator_1_t859CAAB8DD3B63D3758E13D2802ED7523B331199 *, const RuntimeMethod*))IL2CPP_RGCTX_METHOD_INFO(method->klass->rgctx_data, 0)->methodPointer)((Iterator_1_t859CAAB8DD3B63D3758E13D2802ED7523B331199 *)__this, /*hidden argument*/IL2CPP_RGCTX_METHOD_INFO(method->klass->rgctx_data, 0));
		List_1_t3F94120C77410A62EAE48421CF166B83AB95A2F5 * L_0 = ___source0;
		__this->set_source_3(L_0);
		Func_2_t99409DECFF50F0FA9B427C863AC6C99C66E6F9F8 * L_1 = ___predicate1;
		__this->set_predicate_4(L_1);
		Func_2_t78F21BB7B6C7D754A8C4D71ACB39668A8F967BA1 * L_2 = ___selector2;
		__this->set_selector_5(L_2);
		return;
	}
}
// System.Linq.Enumerable/Iterator`1<TResult> System.Linq.Enumerable/WhereSelectListIterator`2<System.Object,System.Single>::Clone()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR Iterator_1_t859CAAB8DD3B63D3758E13D2802ED7523B331199 * WhereSelectListIterator_2_Clone_m5B14105AF5C08F50EEDA1BC3839CD2C0FC35393F_gshared (WhereSelectListIterator_2_t20DB17268C20F9E95977E2485885C2547B573A2F * __this, const RuntimeMethod* method)
{
	{
		List_1_t3F94120C77410A62EAE48421CF166B83AB95A2F5 * L_0 = (List_1_t3F94120C77410A62EAE48421CF166B83AB95A2F5 *)__this->get_source_3();
		Func_2_t99409DECFF50F0FA9B427C863AC6C99C66E6F9F8 * L_1 = (Func_2_t99409DECFF50F0FA9B427C863AC6C99C66E6F9F8 *)__this->get_predicate_4();
		Func_2_t78F21BB7B6C7D754A8C4D71ACB39668A8F967BA1 * L_2 = (Func_2_t78F21BB7B6C7D754A8C4D71ACB39668A8F967BA1 *)__this->get_selector_5();
		WhereSelectListIterator_2_t20DB17268C20F9E95977E2485885C2547B573A2F * L_3 = (WhereSelectListIterator_2_t20DB17268C20F9E95977E2485885C2547B573A2F *)il2cpp_codegen_object_new(IL2CPP_RGCTX_DATA(method->klass->rgctx_data, 2));
		((  void (*) (WhereSelectListIterator_2_t20DB17268C20F9E95977E2485885C2547B573A2F *, List_1_t3F94120C77410A62EAE48421CF166B83AB95A2F5 *, Func_2_t99409DECFF50F0FA9B427C863AC6C99C66E6F9F8 *, Func_2_t78F21BB7B6C7D754A8C4D71ACB39668A8F967BA1 *, const RuntimeMethod*))IL2CPP_RGCTX_METHOD_INFO(method->klass->rgctx_data, 3)->methodPointer)(L_3, (List_1_t3F94120C77410A62EAE48421CF166B83AB95A2F5 *)L_0, (Func_2_t99409DECFF50F0FA9B427C863AC6C99C66E6F9F8 *)L_1, (Func_2_t78F21BB7B6C7D754A8C4D71ACB39668A8F967BA1 *)L_2, /*hidden argument*/IL2CPP_RGCTX_METHOD_INFO(method->klass->rgctx_data, 3));
		return (Iterator_1_t859CAAB8DD3B63D3758E13D2802ED7523B331199 *)L_3;
	}
}
// System.Boolean System.Linq.Enumerable/WhereSelectListIterator`2<System.Object,System.Single>::MoveNext()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR bool WhereSelectListIterator_2_MoveNext_mF1AD1CD66F1D89CBD4853848B121B6C5D28353EE_gshared (WhereSelectListIterator_2_t20DB17268C20F9E95977E2485885C2547B573A2F * __this, const RuntimeMethod* method)
{
	int32_t V_0 = 0;
	RuntimeObject * V_1 = NULL;
	{
		int32_t L_0 = (int32_t)((Iterator_1_t859CAAB8DD3B63D3758E13D2802ED7523B331199 *)__this)->get_state_1();
		V_0 = (int32_t)L_0;
		int32_t L_1 = V_0;
		if ((((int32_t)L_1) == ((int32_t)1)))
		{
			goto IL_0011;
		}
	}
	{
		int32_t L_2 = V_0;
		if ((((int32_t)L_2) == ((int32_t)2)))
		{
			goto IL_0061;
		}
	}
	{
		goto IL_0074;
	}

IL_0011:
	{
		List_1_t3F94120C77410A62EAE48421CF166B83AB95A2F5 * L_3 = (List_1_t3F94120C77410A62EAE48421CF166B83AB95A2F5 *)__this->get_source_3();
		NullCheck((List_1_t3F94120C77410A62EAE48421CF166B83AB95A2F5 *)L_3);
		Enumerator_tB6009981BD4E3881E3EC83627255A24198F902D6  L_4;
		L_4 = ((  Enumerator_tB6009981BD4E3881E3EC83627255A24198F902D6  (*) (List_1_t3F94120C77410A62EAE48421CF166B83AB95A2F5 *, const RuntimeMethod*))IL2CPP_RGCTX_METHOD_INFO(method->klass->rgctx_data, 4)->methodPointer)((List_1_t3F94120C77410A62EAE48421CF166B83AB95A2F5 *)L_3, /*hidden argument*/IL2CPP_RGCTX_METHOD_INFO(method->klass->rgctx_data, 4));
		__this->set_enumerator_6(L_4);
		((Iterator_1_t859CAAB8DD3B63D3758E13D2802ED7523B331199 *)__this)->set_state_1(2);
		goto IL_0061;
	}

IL_002b:
	{
		Enumerator_tB6009981BD4E3881E3EC83627255A24198F902D6 * L_5 = (Enumerator_tB6009981BD4E3881E3EC83627255A24198F902D6 *)__this->get_address_of_enumerator_6();
		RuntimeObject * L_6;
		L_6 = Enumerator_get_Current_m9C4EBBD2108B51885E750F927D7936290C8E20EE_inline((Enumerator_tB6009981BD4E3881E3EC83627255A24198F902D6 *)(Enumerator_tB6009981BD4E3881E3EC83627255A24198F902D6 *)L_5, /*hidden argument*/IL2CPP_RGCTX_METHOD_INFO(method->klass->rgctx_data, 5));
		V_1 = (RuntimeObject *)L_6;
		Func_2_t99409DECFF50F0FA9B427C863AC6C99C66E6F9F8 * L_7 = (Func_2_t99409DECFF50F0FA9B427C863AC6C99C66E6F9F8 *)__this->get_predicate_4();
		if (!L_7)
		{
			goto IL_004d;
		}
	}
	{
		Func_2_t99409DECFF50F0FA9B427C863AC6C99C66E6F9F8 * L_8 = (Func_2_t99409DECFF50F0FA9B427C863AC6C99C66E6F9F8 *)__this->get_predicate_4();
		RuntimeObject * L_9 = V_1;
		NullCheck((Func_2_t99409DECFF50F0FA9B427C863AC6C99C66E6F9F8 *)L_8);
		bool L_10;
		L_10 = ((  bool (*) (Func_2_t99409DECFF50F0FA9B427C863AC6C99C66E6F9F8 *, RuntimeObject *, const RuntimeMethod*))IL2CPP_RGCTX_METHOD_INFO(method->klass->rgctx_data, 6)->methodPointer)((Func_2_t99409DECFF50F0FA9B427C863AC6C99C66E6F9F8 *)L_8, (RuntimeObject *)L_9, /*hidden argument*/IL2CPP_RGCTX_METHOD_INFO(method->klass->rgctx_data, 6));
		if (!L_10)
		{
			goto IL_0061;
		}
	}

IL_004d:
	{
		Func_2_t78F21BB7B6C7D754A8C4D71ACB39668A8F967BA1 * L_11 = (Func_2_t78F21BB7B6C7D754A8C4D71ACB39668A8F967BA1 *)__this->get_selector_5();
		RuntimeObject * L_12 = V_1;
		NullCheck((Func_2_t78F21BB7B6C7D754A8C4D71ACB39668A8F967BA1 *)L_11);
		float L_13;
		L_13 = ((  float (*) (Func_2_t78F21BB7B6C7D754A8C4D71ACB39668A8F967BA1 *, RuntimeObject *, const RuntimeMethod*))IL2CPP_RGCTX_METHOD_INFO(method->klass->rgctx_data, 7)->methodPointer)((Func_2_t78F21BB7B6C7D754A8C4D71ACB39668A8F967BA1 *)L_11, (RuntimeObject *)L_12, /*hidden argument*/IL2CPP_RGCTX_METHOD_INFO(method->klass->rgctx_data, 7));
		((Iterator_1_t859CAAB8DD3B63D3758E13D2802ED7523B331199 *)__this)->set_current_2(L_13);
		return (bool)1;
	}

IL_0061:
	{
		Enumerator_tB6009981BD4E3881E3EC83627255A24198F902D6 * L_14 = (Enumerator_tB6009981BD4E3881E3EC83627255A24198F902D6 *)__this->get_address_of_enumerator_6();
		bool L_15;
		L_15 = Enumerator_MoveNext_m2E56233762839CE55C67E00AC8DD3D4D3F6C0DF0((Enumerator_tB6009981BD4E3881E3EC83627255A24198F902D6 *)(Enumerator_tB6009981BD4E3881E3EC83627255A24198F902D6 *)L_14, /*hidden argument*/IL2CPP_RGCTX_METHOD_INFO(method->klass->rgctx_data, 8));
		if (L_15)
		{
			goto IL_002b;
		}
	}
	{
		NullCheck((Iterator_1_t859CAAB8DD3B63D3758E13D2802ED7523B331199 *)__this);
		VirtActionInvoker0::Invoke(12 /* System.Void System.Linq.Enumerable/Iterator`1<System.Single>::Dispose() */, (Iterator_1_t859CAAB8DD3B63D3758E13D2802ED7523B331199 *)__this);
	}

IL_0074:
	{
		return (bool)0;
	}
}
// System.Collections.Generic.IEnumerable`1<TResult> System.Linq.Enumerable/WhereSelectListIterator`2<System.Object,System.Single>::Where(System.Func`2<TResult,System.Boolean>)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR RuntimeObject* WhereSelectListIterator_2_Where_mB1F2866EF1FAB0E8292A272C59D73236A0091839_gshared (WhereSelectListIterator_2_t20DB17268C20F9E95977E2485885C2547B573A2F * __this, Func_2_t7214BC9C9A47482C751067B9A197D164F4041A3A * ___predicate0, const RuntimeMethod* method)
{
	{
		Func_2_t7214BC9C9A47482C751067B9A197D164F4041A3A * L_0 = ___predicate0;
		WhereEnumerableIterator_1_tC5339F8E75587CBA511FF3EDFBA6D5A81E54057F * L_1 = (WhereEnumerableIterator_1_tC5339F8E75587CBA511FF3EDFBA6D5A81E54057F *)il2cpp_codegen_object_new(IL2CPP_RGCTX_DATA(method->klass->rgctx_data, 10));
		((  void (*) (WhereEnumerableIterator_1_tC5339F8E75587CBA511FF3EDFBA6D5A81E54057F *, RuntimeObject*, Func_2_t7214BC9C9A47482C751067B9A197D164F4041A3A *, const RuntimeMethod*))IL2CPP_RGCTX_METHOD_INFO(method->klass->rgctx_data, 11)->methodPointer)(L_1, (RuntimeObject*)__this, (Func_2_t7214BC9C9A47482C751067B9A197D164F4041A3A *)L_0, /*hidden argument*/IL2CPP_RGCTX_METHOD_INFO(method->klass->rgctx_data, 11));
		return (RuntimeObject*)L_1;
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
// System.Void System.Linq.Enumerable/WhereSelectListIterator`2<System.Single,System.Object>::.ctor(System.Collections.Generic.List`1<TSource>,System.Func`2<TSource,System.Boolean>,System.Func`2<TSource,TResult>)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void WhereSelectListIterator_2__ctor_mE72A3E981B94D2502A4AFDA08A6E9867C64ED651_gshared (WhereSelectListIterator_2_t77C04C3B7AD0F11B52AC864B3B1635FBFC5D2259 * __this, List_1_t6726F9309570A0BDC5D42E10777F3E2931C487AA * ___source0, Func_2_t7214BC9C9A47482C751067B9A197D164F4041A3A * ___predicate1, Func_2_tE11BDF71BCB314E58F1A9CFC9DAE08A5F717E2A0 * ___selector2, const RuntimeMethod* method)
{
	{
		NullCheck((Iterator_1_t674ABE41CF4096D4BE4D51E21FEBDADBF74CC279 *)__this);
		((  void (*) (Iterator_1_t674ABE41CF4096D4BE4D51E21FEBDADBF74CC279 *, const RuntimeMethod*))IL2CPP_RGCTX_METHOD_INFO(method->klass->rgctx_data, 0)->methodPointer)((Iterator_1_t674ABE41CF4096D4BE4D51E21FEBDADBF74CC279 *)__this, /*hidden argument*/IL2CPP_RGCTX_METHOD_INFO(method->klass->rgctx_data, 0));
		List_1_t6726F9309570A0BDC5D42E10777F3E2931C487AA * L_0 = ___source0;
		__this->set_source_3(L_0);
		Func_2_t7214BC9C9A47482C751067B9A197D164F4041A3A * L_1 = ___predicate1;
		__this->set_predicate_4(L_1);
		Func_2_tE11BDF71BCB314E58F1A9CFC9DAE08A5F717E2A0 * L_2 = ___selector2;
		__this->set_selector_5(L_2);
		return;
	}
}
// System.Linq.Enumerable/Iterator`1<TResult> System.Linq.Enumerable/WhereSelectListIterator`2<System.Single,System.Object>::Clone()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR Iterator_1_t674ABE41CF4096D4BE4D51E21FEBDADBF74CC279 * WhereSelectListIterator_2_Clone_m932F0C8E73F1307B320D9321DECE070701BB780C_gshared (WhereSelectListIterator_2_t77C04C3B7AD0F11B52AC864B3B1635FBFC5D2259 * __this, const RuntimeMethod* method)
{
	{
		List_1_t6726F9309570A0BDC5D42E10777F3E2931C487AA * L_0 = (List_1_t6726F9309570A0BDC5D42E10777F3E2931C487AA *)__this->get_source_3();
		Func_2_t7214BC9C9A47482C751067B9A197D164F4041A3A * L_1 = (Func_2_t7214BC9C9A47482C751067B9A197D164F4041A3A *)__this->get_predicate_4();
		Func_2_tE11BDF71BCB314E58F1A9CFC9DAE08A5F717E2A0 * L_2 = (Func_2_tE11BDF71BCB314E58F1A9CFC9DAE08A5F717E2A0 *)__this->get_selector_5();
		WhereSelectListIterator_2_t77C04C3B7AD0F11B52AC864B3B1635FBFC5D2259 * L_3 = (WhereSelectListIterator_2_t77C04C3B7AD0F11B52AC864B3B1635FBFC5D2259 *)il2cpp_codegen_object_new(IL2CPP_RGCTX_DATA(method->klass->rgctx_data, 2));
		((  void (*) (WhereSelectListIterator_2_t77C04C3B7AD0F11B52AC864B3B1635FBFC5D2259 *, List_1_t6726F9309570A0BDC5D42E10777F3E2931C487AA *, Func_2_t7214BC9C9A47482C751067B9A197D164F4041A3A *, Func_2_tE11BDF71BCB314E58F1A9CFC9DAE08A5F717E2A0 *, const RuntimeMethod*))IL2CPP_RGCTX_METHOD_INFO(method->klass->rgctx_data, 3)->methodPointer)(L_3, (List_1_t6726F9309570A0BDC5D42E10777F3E2931C487AA *)L_0, (Func_2_t7214BC9C9A47482C751067B9A197D164F4041A3A *)L_1, (Func_2_tE11BDF71BCB314E58F1A9CFC9DAE08A5F717E2A0 *)L_2, /*hidden argument*/IL2CPP_RGCTX_METHOD_INFO(method->klass->rgctx_data, 3));
		return (Iterator_1_t674ABE41CF4096D4BE4D51E21FEBDADBF74CC279 *)L_3;
	}
}
// System.Boolean System.Linq.Enumerable/WhereSelectListIterator`2<System.Single,System.Object>::MoveNext()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR bool WhereSelectListIterator_2_MoveNext_m786886FF98DCF38B8D4705E8E73EDA2EFC9FCF46_gshared (WhereSelectListIterator_2_t77C04C3B7AD0F11B52AC864B3B1635FBFC5D2259 * __this, const RuntimeMethod* method)
{
	int32_t V_0 = 0;
	float V_1 = 0.0f;
	{
		int32_t L_0 = (int32_t)((Iterator_1_t674ABE41CF4096D4BE4D51E21FEBDADBF74CC279 *)__this)->get_state_1();
		V_0 = (int32_t)L_0;
		int32_t L_1 = V_0;
		if ((((int32_t)L_1) == ((int32_t)1)))
		{
			goto IL_0011;
		}
	}
	{
		int32_t L_2 = V_0;
		if ((((int32_t)L_2) == ((int32_t)2)))
		{
			goto IL_0061;
		}
	}
	{
		goto IL_0074;
	}

IL_0011:
	{
		List_1_t6726F9309570A0BDC5D42E10777F3E2931C487AA * L_3 = (List_1_t6726F9309570A0BDC5D42E10777F3E2931C487AA *)__this->get_source_3();
		NullCheck((List_1_t6726F9309570A0BDC5D42E10777F3E2931C487AA *)L_3);
		Enumerator_tC1FD01C8BB5327D442D71FD022B4338ACD701783  L_4;
		L_4 = ((  Enumerator_tC1FD01C8BB5327D442D71FD022B4338ACD701783  (*) (List_1_t6726F9309570A0BDC5D42E10777F3E2931C487AA *, const RuntimeMethod*))IL2CPP_RGCTX_METHOD_INFO(method->klass->rgctx_data, 4)->methodPointer)((List_1_t6726F9309570A0BDC5D42E10777F3E2931C487AA *)L_3, /*hidden argument*/IL2CPP_RGCTX_METHOD_INFO(method->klass->rgctx_data, 4));
		__this->set_enumerator_6(L_4);
		((Iterator_1_t674ABE41CF4096D4BE4D51E21FEBDADBF74CC279 *)__this)->set_state_1(2);
		goto IL_0061;
	}

IL_002b:
	{
		Enumerator_tC1FD01C8BB5327D442D71FD022B4338ACD701783 * L_5 = (Enumerator_tC1FD01C8BB5327D442D71FD022B4338ACD701783 *)__this->get_address_of_enumerator_6();
		float L_6;
		L_6 = Enumerator_get_Current_m1DC0B40110173B7E2D13319164F7657C3BE3536D_inline((Enumerator_tC1FD01C8BB5327D442D71FD022B4338ACD701783 *)(Enumerator_tC1FD01C8BB5327D442D71FD022B4338ACD701783 *)L_5, /*hidden argument*/IL2CPP_RGCTX_METHOD_INFO(method->klass->rgctx_data, 5));
		V_1 = (float)L_6;
		Func_2_t7214BC9C9A47482C751067B9A197D164F4041A3A * L_7 = (Func_2_t7214BC9C9A47482C751067B9A197D164F4041A3A *)__this->get_predicate_4();
		if (!L_7)
		{
			goto IL_004d;
		}
	}
	{
		Func_2_t7214BC9C9A47482C751067B9A197D164F4041A3A * L_8 = (Func_2_t7214BC9C9A47482C751067B9A197D164F4041A3A *)__this->get_predicate_4();
		float L_9 = V_1;
		NullCheck((Func_2_t7214BC9C9A47482C751067B9A197D164F4041A3A *)L_8);
		bool L_10;
		L_10 = ((  bool (*) (Func_2_t7214BC9C9A47482C751067B9A197D164F4041A3A *, float, const RuntimeMethod*))IL2CPP_RGCTX_METHOD_INFO(method->klass->rgctx_data, 6)->methodPointer)((Func_2_t7214BC9C9A47482C751067B9A197D164F4041A3A *)L_8, (float)L_9, /*hidden argument*/IL2CPP_RGCTX_METHOD_INFO(method->klass->rgctx_data, 6));
		if (!L_10)
		{
			goto IL_0061;
		}
	}

IL_004d:
	{
		Func_2_tE11BDF71BCB314E58F1A9CFC9DAE08A5F717E2A0 * L_11 = (Func_2_tE11BDF71BCB314E58F1A9CFC9DAE08A5F717E2A0 *)__this->get_selector_5();
		float L_12 = V_1;
		NullCheck((Func_2_tE11BDF71BCB314E58F1A9CFC9DAE08A5F717E2A0 *)L_11);
		RuntimeObject * L_13;
		L_13 = ((  RuntimeObject * (*) (Func_2_tE11BDF71BCB314E58F1A9CFC9DAE08A5F717E2A0 *, float, const RuntimeMethod*))IL2CPP_RGCTX_METHOD_INFO(method->klass->rgctx_data, 7)->methodPointer)((Func_2_tE11BDF71BCB314E58F1A9CFC9DAE08A5F717E2A0 *)L_11, (float)L_12, /*hidden argument*/IL2CPP_RGCTX_METHOD_INFO(method->klass->rgctx_data, 7));
		((Iterator_1_t674ABE41CF4096D4BE4D51E21FEBDADBF74CC279 *)__this)->set_current_2(L_13);
		return (bool)1;
	}

IL_0061:
	{
		Enumerator_tC1FD01C8BB5327D442D71FD022B4338ACD701783 * L_14 = (Enumerator_tC1FD01C8BB5327D442D71FD022B4338ACD701783 *)__this->get_address_of_enumerator_6();
		bool L_15;
		L_15 = Enumerator_MoveNext_mF6D031AEDDDEEAF750E0BFE7866FBBA9C9752C7E((Enumerator_tC1FD01C8BB5327D442D71FD022B4338ACD701783 *)(Enumerator_tC1FD01C8BB5327D442D71FD022B4338ACD701783 *)L_14, /*hidden argument*/IL2CPP_RGCTX_METHOD_INFO(method->klass->rgctx_data, 8));
		if (L_15)
		{
			goto IL_002b;
		}
	}
	{
		NullCheck((Iterator_1_t674ABE41CF4096D4BE4D51E21FEBDADBF74CC279 *)__this);
		VirtActionInvoker0::Invoke(12 /* System.Void System.Linq.Enumerable/Iterator`1<System.Object>::Dispose() */, (Iterator_1_t674ABE41CF4096D4BE4D51E21FEBDADBF74CC279 *)__this);
	}

IL_0074:
	{
		return (bool)0;
	}
}
// System.Collections.Generic.IEnumerable`1<TResult> System.Linq.Enumerable/WhereSelectListIterator`2<System.Single,System.Object>::Where(System.Func`2<TResult,System.Boolean>)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR RuntimeObject* WhereSelectListIterator_2_Where_m0CA9E839CED94CB32A63000C2B9318E221D5C580_gshared (WhereSelectListIterator_2_t77C04C3B7AD0F11B52AC864B3B1635FBFC5D2259 * __this, Func_2_t99409DECFF50F0FA9B427C863AC6C99C66E6F9F8 * ___predicate0, const RuntimeMethod* method)
{
	{
		Func_2_t99409DECFF50F0FA9B427C863AC6C99C66E6F9F8 * L_0 = ___predicate0;
		WhereEnumerableIterator_1_t1E9FDCFD8F8136C6A5A5740C1E093EF03F0B5CE0 * L_1 = (WhereEnumerableIterator_1_t1E9FDCFD8F8136C6A5A5740C1E093EF03F0B5CE0 *)il2cpp_codegen_object_new(IL2CPP_RGCTX_DATA(method->klass->rgctx_data, 10));
		((  void (*) (WhereEnumerableIterator_1_t1E9FDCFD8F8136C6A5A5740C1E093EF03F0B5CE0 *, RuntimeObject*, Func_2_t99409DECFF50F0FA9B427C863AC6C99C66E6F9F8 *, const RuntimeMethod*))IL2CPP_RGCTX_METHOD_INFO(method->klass->rgctx_data, 11)->methodPointer)(L_1, (RuntimeObject*)__this, (Func_2_t99409DECFF50F0FA9B427C863AC6C99C66E6F9F8 *)L_0, /*hidden argument*/IL2CPP_RGCTX_METHOD_INFO(method->klass->rgctx_data, 11));
		return (RuntimeObject*)L_1;
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
// System.Void System.Collections.Concurrent.ConcurrentBag`1/WorkStealingQueue<System.Object>::.ctor(System.Collections.Concurrent.ConcurrentBag`1/WorkStealingQueue<T>)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void WorkStealingQueue__ctor_m8192E8504B24B43C58401B29C010BFB42DB9241D_gshared (WorkStealingQueue_t46BF20180E5A47304513625C3E005065BA4B93D7 * __this, WorkStealingQueue_t46BF20180E5A47304513625C3E005065BA4B93D7 * ___nextQueue0, const RuntimeMethod* method)
{
	{
		ObjectU5BU5D_tC1F4EE0DB0B7300255F5FD4AF64FE4C585CF5ADE* L_0 = (ObjectU5BU5D_tC1F4EE0DB0B7300255F5FD4AF64FE4C585CF5ADE*)(ObjectU5BU5D_tC1F4EE0DB0B7300255F5FD4AF64FE4C585CF5ADE*)SZArrayNew(IL2CPP_RGCTX_DATA(method->klass->rgctx_data, 0), (uint32_t)((int32_t)32));
		il2cpp_codegen_memory_barrier();
		__this->set__array_4(L_0);
		il2cpp_codegen_memory_barrier();
		__this->set__mask_5(((int32_t)31));
		NullCheck((RuntimeObject *)__this);
		Object__ctor_m88880E0413421D13FD95325EDCE231707CE1F405((RuntimeObject *)__this, /*hidden argument*/NULL);
		int32_t L_1;
		L_1 = Environment_get_CurrentManagedThreadId_m09DBD4166BFD399056B2F81C77A3A182339BF92D(/*hidden argument*/NULL);
		__this->set__ownerThreadId_11(L_1);
		WorkStealingQueue_t46BF20180E5A47304513625C3E005065BA4B93D7 * L_2 = ___nextQueue0;
		__this->set__nextQueue_10(L_2);
		return;
	}
}
// System.Boolean System.Collections.Concurrent.ConcurrentBag`1/WorkStealingQueue<System.Object>::get_IsEmpty()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR bool WorkStealingQueue_get_IsEmpty_m11FCA81E8C3A74B1587CCDF9F05A754DA7ECDCAD_gshared (WorkStealingQueue_t46BF20180E5A47304513625C3E005065BA4B93D7 * __this, const RuntimeMethod* method)
{
	{
		int32_t L_0 = (int32_t)__this->get__headIndex_2();
		il2cpp_codegen_memory_barrier();
		int32_t L_1 = (int32_t)__this->get__tailIndex_3();
		il2cpp_codegen_memory_barrier();
		return (bool)((((int32_t)((((int32_t)L_0) < ((int32_t)L_1))? 1 : 0)) == ((int32_t)0))? 1 : 0);
	}
}
// System.Void System.Collections.Concurrent.ConcurrentBag`1/WorkStealingQueue<System.Object>::LocalPush(T)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void WorkStealingQueue_LocalPush_m21A75830BF02EE497FA709E0A39B7EE096F7EEED_gshared (WorkStealingQueue_t46BF20180E5A47304513625C3E005065BA4B93D7 * __this, RuntimeObject * ___item0, const RuntimeMethod* method)
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&WorkStealingQueue_LocalPush_m21A75830BF02EE497FA709E0A39B7EE096F7EEED_RuntimeMethod_var);
		s_Il2CppMethodInitialized = true;
	}
	bool V_0 = false;
	int32_t V_1 = 0;
	WorkStealingQueue_t46BF20180E5A47304513625C3E005065BA4B93D7 * V_2 = NULL;
	bool V_3 = false;
	int32_t V_4 = 0;
	int32_t V_5 = 0;
	ObjectU5BU5D_tC1F4EE0DB0B7300255F5FD4AF64FE4C585CF5ADE* V_6 = NULL;
	int32_t V_7 = 0;
	Exception_t * __last_unhandled_exception = 0;
	il2cpp::utils::ExceptionSupportStack<int32_t, 2> __leave_targets;
	{
		V_0 = (bool)0;
	}

IL_0002:
	try
	{ // begin try (depth: 1)
		{
			int32_t* L_0 = (int32_t*)__this->get_address_of__currentOp_8();
			il2cpp_codegen_memory_barrier();
			int32_t L_1;
			L_1 = Interlocked_Exchange_mCB69CAC317F723A1CB6B52194C5917B49C456794((int32_t*)(int32_t*)L_0, (int32_t)1, /*hidden argument*/NULL);
			int32_t L_2 = (int32_t)__this->get__tailIndex_3();
			il2cpp_codegen_memory_barrier();
			V_1 = (int32_t)L_2;
			int32_t L_3 = V_1;
			if ((!(((uint32_t)L_3) == ((uint32_t)((int32_t)2147483647LL)))))
			{
				goto IL_007e;
			}
		}

IL_0020:
		{
			il2cpp_codegen_memory_barrier();
			__this->set__currentOp_8(0);
			V_2 = (WorkStealingQueue_t46BF20180E5A47304513625C3E005065BA4B93D7 *)__this;
			V_3 = (bool)0;
		}

IL_002d:
		try
		{ // begin try (depth: 2)
			WorkStealingQueue_t46BF20180E5A47304513625C3E005065BA4B93D7 * L_4 = V_2;
			Monitor_Enter_mBEB6CC84184B46F26375EC3FC8921D16E48EA4C4((RuntimeObject *)L_4, (bool*)(bool*)(&V_3), /*hidden argument*/NULL);
			int32_t L_5 = (int32_t)__this->get__headIndex_2();
			il2cpp_codegen_memory_barrier();
			int32_t L_6 = (int32_t)__this->get__mask_5();
			il2cpp_codegen_memory_barrier();
			il2cpp_codegen_memory_barrier();
			__this->set__headIndex_2(((int32_t)((int32_t)L_5&(int32_t)L_6)));
			int32_t L_7 = (int32_t)__this->get__tailIndex_3();
			il2cpp_codegen_memory_barrier();
			int32_t L_8 = (int32_t)__this->get__mask_5();
			il2cpp_codegen_memory_barrier();
			int32_t L_9 = (int32_t)((int32_t)((int32_t)L_7&(int32_t)L_8));
			V_1 = (int32_t)L_9;
			il2cpp_codegen_memory_barrier();
			__this->set__tailIndex_3(L_9);
			il2cpp_codegen_memory_barrier();
			__this->set__currentOp_8(1);
			IL2CPP_LEAVE(0x7E, FINALLY_0074);
		} // end try (depth: 2)
		catch(Il2CppExceptionWrapper& e)
		{
			__last_unhandled_exception = (Exception_t *)e.ex;
			goto FINALLY_0074;
		}

FINALLY_0074:
		{ // begin finally (depth: 2)
			{
				bool L_10 = V_3;
				if (!L_10)
				{
					goto IL_007d;
				}
			}

IL_0077:
			{
				WorkStealingQueue_t46BF20180E5A47304513625C3E005065BA4B93D7 * L_11 = V_2;
				Monitor_Exit_mA776B403DA88AC77CDEEF67AB9F0D0E77ABD254A((RuntimeObject *)L_11, /*hidden argument*/NULL);
			}

IL_007d:
			{
				IL2CPP_END_FINALLY(116)
			}
		} // end finally (depth: 2)
		IL2CPP_CLEANUP(116)
		{
			IL2CPP_RETHROW_IF_UNHANDLED(Exception_t *)
			IL2CPP_JUMP_TBL(0x7E, IL_007e)
		}

IL_007e:
		{
			bool L_12 = (bool)__this->get__frozen_9();
			if (L_12)
			{
				goto IL_00c2;
			}
		}

IL_0086:
		{
			int32_t L_13 = V_1;
			int32_t L_14 = (int32_t)__this->get__headIndex_2();
			il2cpp_codegen_memory_barrier();
			int32_t L_15 = (int32_t)__this->get__mask_5();
			il2cpp_codegen_memory_barrier();
			if ((((int32_t)L_13) >= ((int32_t)((int32_t)il2cpp_codegen_add((int32_t)L_14, (int32_t)L_15)))))
			{
				goto IL_00c2;
			}
		}

IL_009a:
		{
			ObjectU5BU5D_tC1F4EE0DB0B7300255F5FD4AF64FE4C585CF5ADE* L_16 = (ObjectU5BU5D_tC1F4EE0DB0B7300255F5FD4AF64FE4C585CF5ADE*)__this->get__array_4();
			il2cpp_codegen_memory_barrier();
			int32_t L_17 = V_1;
			int32_t L_18 = (int32_t)__this->get__mask_5();
			il2cpp_codegen_memory_barrier();
			RuntimeObject * L_19 = ___item0;
			NullCheck(L_16);
			(L_16)->SetAt(static_cast<il2cpp_array_size_t>(((int32_t)((int32_t)L_17&(int32_t)L_18))), (RuntimeObject *)L_19);
			int32_t L_20 = V_1;
			il2cpp_codegen_memory_barrier();
			__this->set__tailIndex_3(((int32_t)il2cpp_codegen_add((int32_t)L_20, (int32_t)1)));
			goto IL_01ee;
		}

IL_00c2:
		{
			il2cpp_codegen_memory_barrier();
			__this->set__currentOp_8(0);
			Monitor_Enter_mBEB6CC84184B46F26375EC3FC8921D16E48EA4C4((RuntimeObject *)__this, (bool*)(bool*)(&V_0), /*hidden argument*/NULL);
			int32_t L_21 = (int32_t)__this->get__headIndex_2();
			il2cpp_codegen_memory_barrier();
			V_4 = (int32_t)L_21;
			int32_t L_22 = (int32_t)__this->get__tailIndex_3();
			il2cpp_codegen_memory_barrier();
			int32_t L_23 = (int32_t)__this->get__headIndex_2();
			il2cpp_codegen_memory_barrier();
			V_5 = (int32_t)((int32_t)il2cpp_codegen_subtract((int32_t)L_22, (int32_t)L_23));
			int32_t L_24 = V_5;
			int32_t L_25 = (int32_t)__this->get__mask_5();
			il2cpp_codegen_memory_barrier();
			if ((((int32_t)L_24) < ((int32_t)L_25)))
			{
				goto IL_01b1;
			}
		}

IL_00ff:
		{
			ObjectU5BU5D_tC1F4EE0DB0B7300255F5FD4AF64FE4C585CF5ADE* L_26 = (ObjectU5BU5D_tC1F4EE0DB0B7300255F5FD4AF64FE4C585CF5ADE*)__this->get__array_4();
			il2cpp_codegen_memory_barrier();
			NullCheck(L_26);
			ObjectU5BU5D_tC1F4EE0DB0B7300255F5FD4AF64FE4C585CF5ADE* L_27 = (ObjectU5BU5D_tC1F4EE0DB0B7300255F5FD4AF64FE4C585CF5ADE*)(ObjectU5BU5D_tC1F4EE0DB0B7300255F5FD4AF64FE4C585CF5ADE*)SZArrayNew(IL2CPP_RGCTX_DATA(method->klass->rgctx_data, 0), (uint32_t)((int32_t)((int32_t)((int32_t)((int32_t)(((RuntimeArray*)L_26)->max_length)))<<(int32_t)1)));
			V_6 = (ObjectU5BU5D_tC1F4EE0DB0B7300255F5FD4AF64FE4C585CF5ADE*)L_27;
			int32_t L_28 = V_4;
			int32_t L_29 = (int32_t)__this->get__mask_5();
			il2cpp_codegen_memory_barrier();
			V_7 = (int32_t)((int32_t)((int32_t)L_28&(int32_t)L_29));
			int32_t L_30 = V_7;
			if (L_30)
			{
				goto IL_0140;
			}
		}

IL_0123:
		{
			ObjectU5BU5D_tC1F4EE0DB0B7300255F5FD4AF64FE4C585CF5ADE* L_31 = (ObjectU5BU5D_tC1F4EE0DB0B7300255F5FD4AF64FE4C585CF5ADE*)__this->get__array_4();
			il2cpp_codegen_memory_barrier();
			ObjectU5BU5D_tC1F4EE0DB0B7300255F5FD4AF64FE4C585CF5ADE* L_32 = V_6;
			ObjectU5BU5D_tC1F4EE0DB0B7300255F5FD4AF64FE4C585CF5ADE* L_33 = (ObjectU5BU5D_tC1F4EE0DB0B7300255F5FD4AF64FE4C585CF5ADE*)__this->get__array_4();
			il2cpp_codegen_memory_barrier();
			NullCheck(L_33);
			Array_Copy_m3F127FFB5149532135043FFE285F9177C80CB877((RuntimeArray *)(RuntimeArray *)L_31, (int32_t)0, (RuntimeArray *)(RuntimeArray *)L_32, (int32_t)0, (int32_t)((int32_t)((int32_t)(((RuntimeArray*)L_33)->max_length))), /*hidden argument*/NULL);
			goto IL_017e;
		}

IL_0140:
		{
			ObjectU5BU5D_tC1F4EE0DB0B7300255F5FD4AF64FE4C585CF5ADE* L_34 = (ObjectU5BU5D_tC1F4EE0DB0B7300255F5FD4AF64FE4C585CF5ADE*)__this->get__array_4();
			il2cpp_codegen_memory_barrier();
			int32_t L_35 = V_7;
			ObjectU5BU5D_tC1F4EE0DB0B7300255F5FD4AF64FE4C585CF5ADE* L_36 = V_6;
			ObjectU5BU5D_tC1F4EE0DB0B7300255F5FD4AF64FE4C585CF5ADE* L_37 = (ObjectU5BU5D_tC1F4EE0DB0B7300255F5FD4AF64FE4C585CF5ADE*)__this->get__array_4();
			il2cpp_codegen_memory_barrier();
			NullCheck(L_37);
			int32_t L_38 = V_7;
			Array_Copy_m3F127FFB5149532135043FFE285F9177C80CB877((RuntimeArray *)(RuntimeArray *)L_34, (int32_t)L_35, (RuntimeArray *)(RuntimeArray *)L_36, (int32_t)0, (int32_t)((int32_t)il2cpp_codegen_subtract((int32_t)((int32_t)((int32_t)(((RuntimeArray*)L_37)->max_length))), (int32_t)L_38)), /*hidden argument*/NULL);
			ObjectU5BU5D_tC1F4EE0DB0B7300255F5FD4AF64FE4C585CF5ADE* L_39 = (ObjectU5BU5D_tC1F4EE0DB0B7300255F5FD4AF64FE4C585CF5ADE*)__this->get__array_4();
			il2cpp_codegen_memory_barrier();
			ObjectU5BU5D_tC1F4EE0DB0B7300255F5FD4AF64FE4C585CF5ADE* L_40 = V_6;
			ObjectU5BU5D_tC1F4EE0DB0B7300255F5FD4AF64FE4C585CF5ADE* L_41 = (ObjectU5BU5D_tC1F4EE0DB0B7300255F5FD4AF64FE4C585CF5ADE*)__this->get__array_4();
			il2cpp_codegen_memory_barrier();
			NullCheck(L_41);
			int32_t L_42 = V_7;
			int32_t L_43 = V_7;
			Array_Copy_m3F127FFB5149532135043FFE285F9177C80CB877((RuntimeArray *)(RuntimeArray *)L_39, (int32_t)0, (RuntimeArray *)(RuntimeArray *)L_40, (int32_t)((int32_t)il2cpp_codegen_subtract((int32_t)((int32_t)((int32_t)(((RuntimeArray*)L_41)->max_length))), (int32_t)L_42)), (int32_t)L_43, /*hidden argument*/NULL);
		}

IL_017e:
		{
			ObjectU5BU5D_tC1F4EE0DB0B7300255F5FD4AF64FE4C585CF5ADE* L_44 = V_6;
			il2cpp_codegen_memory_barrier();
			__this->set__array_4(L_44);
			il2cpp_codegen_memory_barrier();
			__this->set__headIndex_2(0);
			int32_t L_45 = V_5;
			int32_t L_46 = (int32_t)L_45;
			V_1 = (int32_t)L_46;
			il2cpp_codegen_memory_barrier();
			__this->set__tailIndex_3(L_46);
			int32_t L_47 = (int32_t)__this->get__mask_5();
			il2cpp_codegen_memory_barrier();
			il2cpp_codegen_memory_barrier();
			__this->set__mask_5(((int32_t)((int32_t)((int32_t)((int32_t)L_47<<(int32_t)1))|(int32_t)1)));
		}

IL_01b1:
		{
			ObjectU5BU5D_tC1F4EE0DB0B7300255F5FD4AF64FE4C585CF5ADE* L_48 = (ObjectU5BU5D_tC1F4EE0DB0B7300255F5FD4AF64FE4C585CF5ADE*)__this->get__array_4();
			il2cpp_codegen_memory_barrier();
			int32_t L_49 = V_1;
			int32_t L_50 = (int32_t)__this->get__mask_5();
			il2cpp_codegen_memory_barrier();
			RuntimeObject * L_51 = ___item0;
			NullCheck(L_48);
			(L_48)->SetAt(static_cast<il2cpp_array_size_t>(((int32_t)((int32_t)L_49&(int32_t)L_50))), (RuntimeObject *)L_51);
			int32_t L_52 = V_1;
			il2cpp_codegen_memory_barrier();
			__this->set__tailIndex_3(((int32_t)il2cpp_codegen_add((int32_t)L_52, (int32_t)1)));
			int32_t L_53 = (int32_t)__this->get__addTakeCount_6();
			int32_t L_54 = (int32_t)__this->get__stealCount_7();
			__this->set__addTakeCount_6(((int32_t)il2cpp_codegen_subtract((int32_t)L_53, (int32_t)L_54)));
			__this->set__stealCount_7(0);
		}

IL_01ee:
		{
			int32_t L_55 = (int32_t)__this->get__addTakeCount_6();
			if (((int64_t)L_55 + (int64_t)1 < (int64_t)kIl2CppInt32Min) || ((int64_t)L_55 + (int64_t)1 > (int64_t)kIl2CppInt32Max))
				IL2CPP_RAISE_MANAGED_EXCEPTION(il2cpp_codegen_get_overflow_exception(), WorkStealingQueue_LocalPush_m21A75830BF02EE497FA709E0A39B7EE096F7EEED_RuntimeMethod_var);
			__this->set__addTakeCount_6(((int32_t)il2cpp_codegen_add((int32_t)L_55, (int32_t)1)));
			IL2CPP_LEAVE(0x211, FINALLY_01fe);
		}
	} // end try (depth: 1)
	catch(Il2CppExceptionWrapper& e)
	{
		__last_unhandled_exception = (Exception_t *)e.ex;
		goto FINALLY_01fe;
	}

FINALLY_01fe:
	{ // begin finally (depth: 1)
		{
			il2cpp_codegen_memory_barrier();
			__this->set__currentOp_8(0);
			bool L_56 = V_0;
			if (!L_56)
			{
				goto IL_0210;
			}
		}

IL_020a:
		{
			Monitor_Exit_mA776B403DA88AC77CDEEF67AB9F0D0E77ABD254A((RuntimeObject *)__this, /*hidden argument*/NULL);
		}

IL_0210:
		{
			IL2CPP_END_FINALLY(510)
		}
	} // end finally (depth: 1)
	IL2CPP_CLEANUP(510)
	{
		IL2CPP_RETHROW_IF_UNHANDLED(Exception_t *)
		IL2CPP_JUMP_TBL(0x211, IL_0211)
	}

IL_0211:
	{
		return;
	}
}
// System.Void System.Collections.Concurrent.ConcurrentBag`1/WorkStealingQueue<System.Object>::LocalClear()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void WorkStealingQueue_LocalClear_mDC17E8A02D51CAA06B6C82A0640DC5D8A1C962C8_gshared (WorkStealingQueue_t46BF20180E5A47304513625C3E005065BA4B93D7 * __this, const RuntimeMethod* method)
{
	WorkStealingQueue_t46BF20180E5A47304513625C3E005065BA4B93D7 * V_0 = NULL;
	bool V_1 = false;
	int32_t V_2 = 0;
	Exception_t * __last_unhandled_exception = 0;
	il2cpp::utils::ExceptionSupportStack<int32_t, 1> __leave_targets;
	{
		V_0 = (WorkStealingQueue_t46BF20180E5A47304513625C3E005065BA4B93D7 *)__this;
		V_1 = (bool)0;
	}

IL_0004:
	try
	{ // begin try (depth: 1)
		{
			WorkStealingQueue_t46BF20180E5A47304513625C3E005065BA4B93D7 * L_0 = V_0;
			Monitor_Enter_mBEB6CC84184B46F26375EC3FC8921D16E48EA4C4((RuntimeObject *)L_0, (bool*)(bool*)(&V_1), /*hidden argument*/NULL);
			int32_t L_1 = (int32_t)__this->get__headIndex_2();
			il2cpp_codegen_memory_barrier();
			int32_t L_2 = (int32_t)__this->get__tailIndex_3();
			il2cpp_codegen_memory_barrier();
			if ((((int32_t)L_1) >= ((int32_t)L_2)))
			{
				goto IL_005a;
			}
		}

IL_001e:
		{
			int32_t L_3 = (int32_t)0;
			V_2 = (int32_t)L_3;
			il2cpp_codegen_memory_barrier();
			__this->set__tailIndex_3(L_3);
			int32_t L_4 = V_2;
			il2cpp_codegen_memory_barrier();
			__this->set__headIndex_2(L_4);
			int32_t L_5 = (int32_t)0;
			V_2 = (int32_t)L_5;
			__this->set__stealCount_7(L_5);
			int32_t L_6 = V_2;
			__this->set__addTakeCount_6(L_6);
			ObjectU5BU5D_tC1F4EE0DB0B7300255F5FD4AF64FE4C585CF5ADE* L_7 = (ObjectU5BU5D_tC1F4EE0DB0B7300255F5FD4AF64FE4C585CF5ADE*)__this->get__array_4();
			il2cpp_codegen_memory_barrier();
			ObjectU5BU5D_tC1F4EE0DB0B7300255F5FD4AF64FE4C585CF5ADE* L_8 = (ObjectU5BU5D_tC1F4EE0DB0B7300255F5FD4AF64FE4C585CF5ADE*)__this->get__array_4();
			il2cpp_codegen_memory_barrier();
			NullCheck(L_8);
			Array_Clear_mEB42D172C5E0825D340F6209F28578BDDDDCE34F((RuntimeArray *)(RuntimeArray *)L_7, (int32_t)0, (int32_t)((int32_t)((int32_t)(((RuntimeArray*)L_8)->max_length))), /*hidden argument*/NULL);
		}

IL_005a:
		{
			IL2CPP_LEAVE(0x66, FINALLY_005c);
		}
	} // end try (depth: 1)
	catch(Il2CppExceptionWrapper& e)
	{
		__last_unhandled_exception = (Exception_t *)e.ex;
		goto FINALLY_005c;
	}

FINALLY_005c:
	{ // begin finally (depth: 1)
		{
			bool L_9 = V_1;
			if (!L_9)
			{
				goto IL_0065;
			}
		}

IL_005f:
		{
			WorkStealingQueue_t46BF20180E5A47304513625C3E005065BA4B93D7 * L_10 = V_0;
			Monitor_Exit_mA776B403DA88AC77CDEEF67AB9F0D0E77ABD254A((RuntimeObject *)L_10, /*hidden argument*/NULL);
		}

IL_0065:
		{
			IL2CPP_END_FINALLY(92)
		}
	} // end finally (depth: 1)
	IL2CPP_CLEANUP(92)
	{
		IL2CPP_RETHROW_IF_UNHANDLED(Exception_t *)
		IL2CPP_JUMP_TBL(0x66, IL_0066)
	}

IL_0066:
	{
		return;
	}
}
// System.Boolean System.Collections.Concurrent.ConcurrentBag`1/WorkStealingQueue<System.Object>::TryLocalPop(T&)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR bool WorkStealingQueue_TryLocalPop_m22C5F53884DA11336C030DE89E30B511F085D564_gshared (WorkStealingQueue_t46BF20180E5A47304513625C3E005065BA4B93D7 * __this, RuntimeObject ** ___result0, const RuntimeMethod* method)
{
	int32_t V_0 = 0;
	bool V_1 = false;
	int32_t V_2 = 0;
	RuntimeObject * V_3 = NULL;
	bool V_4 = false;
	int32_t V_5 = 0;
	Exception_t * __last_unhandled_exception = 0;
	il2cpp::utils::ExceptionSupportStack<int32_t, 3> __leave_targets;
	{
		int32_t L_0 = (int32_t)__this->get__tailIndex_3();
		il2cpp_codegen_memory_barrier();
		V_0 = (int32_t)L_0;
		int32_t L_1 = (int32_t)__this->get__headIndex_2();
		il2cpp_codegen_memory_barrier();
		int32_t L_2 = V_0;
		if ((((int32_t)L_1) < ((int32_t)L_2)))
		{
			goto IL_001d;
		}
	}
	{
		RuntimeObject ** L_3 = ___result0;
		il2cpp_codegen_initobj(L_3, sizeof(RuntimeObject *));
		return (bool)0;
	}

IL_001d:
	{
		V_1 = (bool)0;
	}

IL_001f:
	try
	{ // begin try (depth: 1)
		{
			il2cpp_codegen_memory_barrier();
			__this->set__currentOp_8(2);
			int32_t* L_4 = (int32_t*)__this->get_address_of__tailIndex_3();
			il2cpp_codegen_memory_barrier();
			int32_t L_5 = V_0;
			int32_t L_6 = (int32_t)((int32_t)il2cpp_codegen_subtract((int32_t)L_5, (int32_t)1));
			V_0 = (int32_t)L_6;
			int32_t L_7;
			L_7 = Interlocked_Exchange_mCB69CAC317F723A1CB6B52194C5917B49C456794((int32_t*)(int32_t*)L_4, (int32_t)L_6, /*hidden argument*/NULL);
			bool L_8 = (bool)__this->get__frozen_9();
			if (L_8)
			{
				goto IL_0098;
			}
		}

IL_0041:
		{
			int32_t L_9 = (int32_t)__this->get__headIndex_2();
			il2cpp_codegen_memory_barrier();
			int32_t L_10 = V_0;
			if ((((int32_t)L_9) >= ((int32_t)L_10)))
			{
				goto IL_0098;
			}
		}

IL_004c:
		{
			int32_t L_11 = V_0;
			int32_t L_12 = (int32_t)__this->get__mask_5();
			il2cpp_codegen_memory_barrier();
			V_2 = (int32_t)((int32_t)((int32_t)L_11&(int32_t)L_12));
			RuntimeObject ** L_13 = ___result0;
			ObjectU5BU5D_tC1F4EE0DB0B7300255F5FD4AF64FE4C585CF5ADE* L_14 = (ObjectU5BU5D_tC1F4EE0DB0B7300255F5FD4AF64FE4C585CF5ADE*)__this->get__array_4();
			il2cpp_codegen_memory_barrier();
			int32_t L_15 = V_2;
			NullCheck(L_14);
			int32_t L_16 = L_15;
			RuntimeObject * L_17 = (L_14)->GetAt(static_cast<il2cpp_array_size_t>(L_16));
			*(RuntimeObject **)L_13 = L_17;
			Il2CppCodeGenWriteBarrier((void**)(RuntimeObject **)L_13, (void*)L_17);
			ObjectU5BU5D_tC1F4EE0DB0B7300255F5FD4AF64FE4C585CF5ADE* L_18 = (ObjectU5BU5D_tC1F4EE0DB0B7300255F5FD4AF64FE4C585CF5ADE*)__this->get__array_4();
			il2cpp_codegen_memory_barrier();
			int32_t L_19 = V_2;
			il2cpp_codegen_initobj((&V_3), sizeof(RuntimeObject *));
			RuntimeObject * L_20 = V_3;
			NullCheck(L_18);
			(L_18)->SetAt(static_cast<il2cpp_array_size_t>(L_19), (RuntimeObject *)L_20);
			int32_t L_21 = (int32_t)__this->get__addTakeCount_6();
			__this->set__addTakeCount_6(((int32_t)il2cpp_codegen_subtract((int32_t)L_21, (int32_t)1)));
			V_4 = (bool)1;
			IL2CPP_LEAVE(0x12A, FINALLY_0117);
		}

IL_0098:
		{
			il2cpp_codegen_memory_barrier();
			__this->set__currentOp_8(0);
			Monitor_Enter_mBEB6CC84184B46F26375EC3FC8921D16E48EA4C4((RuntimeObject *)__this, (bool*)(bool*)(&V_1), /*hidden argument*/NULL);
			int32_t L_22 = (int32_t)__this->get__headIndex_2();
			il2cpp_codegen_memory_barrier();
			int32_t L_23 = V_0;
			if ((((int32_t)L_22) > ((int32_t)L_23)))
			{
				goto IL_0100;
			}
		}

IL_00b4:
		{
			int32_t L_24 = V_0;
			int32_t L_25 = (int32_t)__this->get__mask_5();
			il2cpp_codegen_memory_barrier();
			V_5 = (int32_t)((int32_t)((int32_t)L_24&(int32_t)L_25));
			RuntimeObject ** L_26 = ___result0;
			ObjectU5BU5D_tC1F4EE0DB0B7300255F5FD4AF64FE4C585CF5ADE* L_27 = (ObjectU5BU5D_tC1F4EE0DB0B7300255F5FD4AF64FE4C585CF5ADE*)__this->get__array_4();
			il2cpp_codegen_memory_barrier();
			int32_t L_28 = V_5;
			NullCheck(L_27);
			int32_t L_29 = L_28;
			RuntimeObject * L_30 = (L_27)->GetAt(static_cast<il2cpp_array_size_t>(L_29));
			*(RuntimeObject **)L_26 = L_30;
			Il2CppCodeGenWriteBarrier((void**)(RuntimeObject **)L_26, (void*)L_30);
			ObjectU5BU5D_tC1F4EE0DB0B7300255F5FD4AF64FE4C585CF5ADE* L_31 = (ObjectU5BU5D_tC1F4EE0DB0B7300255F5FD4AF64FE4C585CF5ADE*)__this->get__array_4();
			il2cpp_codegen_memory_barrier();
			int32_t L_32 = V_5;
			il2cpp_codegen_initobj((&V_3), sizeof(RuntimeObject *));
			RuntimeObject * L_33 = V_3;
			NullCheck(L_31);
			(L_31)->SetAt(static_cast<il2cpp_array_size_t>(L_32), (RuntimeObject *)L_33);
			int32_t L_34 = (int32_t)__this->get__addTakeCount_6();
			__this->set__addTakeCount_6(((int32_t)il2cpp_codegen_subtract((int32_t)L_34, (int32_t)1)));
			V_4 = (bool)1;
			IL2CPP_LEAVE(0x12A, FINALLY_0117);
		}

IL_0100:
		{
			int32_t L_35 = V_0;
			il2cpp_codegen_memory_barrier();
			__this->set__tailIndex_3(((int32_t)il2cpp_codegen_add((int32_t)L_35, (int32_t)1)));
			RuntimeObject ** L_36 = ___result0;
			il2cpp_codegen_initobj(L_36, sizeof(RuntimeObject *));
			V_4 = (bool)0;
			IL2CPP_LEAVE(0x12A, FINALLY_0117);
		}
	} // end try (depth: 1)
	catch(Il2CppExceptionWrapper& e)
	{
		__last_unhandled_exception = (Exception_t *)e.ex;
		goto FINALLY_0117;
	}

FINALLY_0117:
	{ // begin finally (depth: 1)
		{
			il2cpp_codegen_memory_barrier();
			__this->set__currentOp_8(0);
			bool L_37 = V_1;
			if (!L_37)
			{
				goto IL_0129;
			}
		}

IL_0123:
		{
			Monitor_Exit_mA776B403DA88AC77CDEEF67AB9F0D0E77ABD254A((RuntimeObject *)__this, /*hidden argument*/NULL);
		}

IL_0129:
		{
			IL2CPP_END_FINALLY(279)
		}
	} // end finally (depth: 1)
	IL2CPP_CLEANUP(279)
	{
		IL2CPP_RETHROW_IF_UNHANDLED(Exception_t *)
		IL2CPP_JUMP_TBL(0x12A, IL_012a)
	}

IL_012a:
	{
		bool L_38 = V_4;
		return (bool)L_38;
	}
}
// System.Boolean System.Collections.Concurrent.ConcurrentBag`1/WorkStealingQueue<System.Object>::TryLocalPeek(T&)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR bool WorkStealingQueue_TryLocalPeek_mCA742D6E7F8B252FB04862466373D7F7F1559BE2_gshared (WorkStealingQueue_t46BF20180E5A47304513625C3E005065BA4B93D7 * __this, RuntimeObject ** ___result0, const RuntimeMethod* method)
{
	int32_t V_0 = 0;
	WorkStealingQueue_t46BF20180E5A47304513625C3E005065BA4B93D7 * V_1 = NULL;
	bool V_2 = false;
	bool V_3 = false;
	Exception_t * __last_unhandled_exception = 0;
	il2cpp::utils::ExceptionSupportStack<int32_t, 2> __leave_targets;
	{
		int32_t L_0 = (int32_t)__this->get__tailIndex_3();
		il2cpp_codegen_memory_barrier();
		V_0 = (int32_t)L_0;
		int32_t L_1 = (int32_t)__this->get__headIndex_2();
		il2cpp_codegen_memory_barrier();
		int32_t L_2 = V_0;
		if ((((int32_t)L_1) >= ((int32_t)L_2)))
		{
			goto IL_005a;
		}
	}
	{
		V_1 = (WorkStealingQueue_t46BF20180E5A47304513625C3E005065BA4B93D7 *)__this;
		V_2 = (bool)0;
	}

IL_0018:
	try
	{ // begin try (depth: 1)
		{
			WorkStealingQueue_t46BF20180E5A47304513625C3E005065BA4B93D7 * L_3 = V_1;
			Monitor_Enter_mBEB6CC84184B46F26375EC3FC8921D16E48EA4C4((RuntimeObject *)L_3, (bool*)(bool*)(&V_2), /*hidden argument*/NULL);
			int32_t L_4 = (int32_t)__this->get__headIndex_2();
			il2cpp_codegen_memory_barrier();
			int32_t L_5 = V_0;
			if ((((int32_t)L_4) >= ((int32_t)L_5)))
			{
				goto IL_004e;
			}
		}

IL_002b:
		{
			RuntimeObject ** L_6 = ___result0;
			ObjectU5BU5D_tC1F4EE0DB0B7300255F5FD4AF64FE4C585CF5ADE* L_7 = (ObjectU5BU5D_tC1F4EE0DB0B7300255F5FD4AF64FE4C585CF5ADE*)__this->get__array_4();
			il2cpp_codegen_memory_barrier();
			int32_t L_8 = V_0;
			int32_t L_9 = (int32_t)__this->get__mask_5();
			il2cpp_codegen_memory_barrier();
			NullCheck(L_7);
			int32_t L_10 = ((int32_t)((int32_t)((int32_t)il2cpp_codegen_subtract((int32_t)L_8, (int32_t)1))&(int32_t)L_9));
			RuntimeObject * L_11 = (L_7)->GetAt(static_cast<il2cpp_array_size_t>(L_10));
			*(RuntimeObject **)L_6 = L_11;
			Il2CppCodeGenWriteBarrier((void**)(RuntimeObject **)L_6, (void*)L_11);
			V_3 = (bool)1;
			IL2CPP_LEAVE(0x63, FINALLY_0050);
		}

IL_004e:
		{
			IL2CPP_LEAVE(0x5A, FINALLY_0050);
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
			bool L_12 = V_2;
			if (!L_12)
			{
				goto IL_0059;
			}
		}

IL_0053:
		{
			WorkStealingQueue_t46BF20180E5A47304513625C3E005065BA4B93D7 * L_13 = V_1;
			Monitor_Exit_mA776B403DA88AC77CDEEF67AB9F0D0E77ABD254A((RuntimeObject *)L_13, /*hidden argument*/NULL);
		}

IL_0059:
		{
			IL2CPP_END_FINALLY(80)
		}
	} // end finally (depth: 1)
	IL2CPP_CLEANUP(80)
	{
		IL2CPP_RETHROW_IF_UNHANDLED(Exception_t *)
		IL2CPP_JUMP_TBL(0x63, IL_0063)
		IL2CPP_JUMP_TBL(0x5A, IL_005a)
	}

IL_005a:
	{
		RuntimeObject ** L_14 = ___result0;
		il2cpp_codegen_initobj(L_14, sizeof(RuntimeObject *));
		return (bool)0;
	}

IL_0063:
	{
		bool L_15 = V_3;
		return (bool)L_15;
	}
}
// System.Boolean System.Collections.Concurrent.ConcurrentBag`1/WorkStealingQueue<System.Object>::TrySteal(T&,System.Boolean)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR bool WorkStealingQueue_TrySteal_m5E07DF4E5F8BC6025C502563C4D5369311557CAD_gshared (WorkStealingQueue_t46BF20180E5A47304513625C3E005065BA4B93D7 * __this, RuntimeObject ** ___result0, bool ___take1, const RuntimeMethod* method)
{
	WorkStealingQueue_t46BF20180E5A47304513625C3E005065BA4B93D7 * V_0 = NULL;
	bool V_1 = false;
	int32_t V_2 = 0;
	int32_t V_3 = 0;
	RuntimeObject * V_4 = NULL;
	bool V_5 = false;
	Exception_t * __last_unhandled_exception = 0;
	il2cpp::utils::ExceptionSupportStack<int32_t, 4> __leave_targets;
	{
		int32_t L_0 = (int32_t)__this->get__headIndex_2();
		il2cpp_codegen_memory_barrier();
		int32_t L_1 = (int32_t)__this->get__tailIndex_3();
		il2cpp_codegen_memory_barrier();
		if ((((int32_t)L_0) >= ((int32_t)L_1)))
		{
			goto IL_00d5;
		}
	}
	{
		V_0 = (WorkStealingQueue_t46BF20180E5A47304513625C3E005065BA4B93D7 *)__this;
		V_1 = (bool)0;
	}

IL_0019:
	try
	{ // begin try (depth: 1)
		{
			WorkStealingQueue_t46BF20180E5A47304513625C3E005065BA4B93D7 * L_2 = V_0;
			Monitor_Enter_mBEB6CC84184B46F26375EC3FC8921D16E48EA4C4((RuntimeObject *)L_2, (bool*)(bool*)(&V_1), /*hidden argument*/NULL);
			int32_t L_3 = (int32_t)__this->get__headIndex_2();
			il2cpp_codegen_memory_barrier();
			V_2 = (int32_t)L_3;
			bool L_4 = ___take1;
			if (!L_4)
			{
				goto IL_009c;
			}
		}

IL_002d:
		{
			int32_t* L_5 = (int32_t*)__this->get_address_of__headIndex_2();
			il2cpp_codegen_memory_barrier();
			int32_t L_6 = V_2;
			int32_t L_7;
			L_7 = Interlocked_Exchange_mCB69CAC317F723A1CB6B52194C5917B49C456794((int32_t*)(int32_t*)L_5, (int32_t)((int32_t)il2cpp_codegen_add((int32_t)L_6, (int32_t)1)), /*hidden argument*/NULL);
			int32_t L_8 = V_2;
			int32_t L_9 = (int32_t)__this->get__tailIndex_3();
			il2cpp_codegen_memory_barrier();
			if ((((int32_t)L_8) >= ((int32_t)L_9)))
			{
				goto IL_0091;
			}
		}

IL_0047:
		{
			int32_t L_10 = V_2;
			int32_t L_11 = (int32_t)__this->get__mask_5();
			il2cpp_codegen_memory_barrier();
			V_3 = (int32_t)((int32_t)((int32_t)L_10&(int32_t)L_11));
			RuntimeObject ** L_12 = ___result0;
			ObjectU5BU5D_tC1F4EE0DB0B7300255F5FD4AF64FE4C585CF5ADE* L_13 = (ObjectU5BU5D_tC1F4EE0DB0B7300255F5FD4AF64FE4C585CF5ADE*)__this->get__array_4();
			il2cpp_codegen_memory_barrier();
			int32_t L_14 = V_3;
			NullCheck(L_13);
			int32_t L_15 = L_14;
			RuntimeObject * L_16 = (L_13)->GetAt(static_cast<il2cpp_array_size_t>(L_15));
			*(RuntimeObject **)L_12 = L_16;
			Il2CppCodeGenWriteBarrier((void**)(RuntimeObject **)L_12, (void*)L_16);
			ObjectU5BU5D_tC1F4EE0DB0B7300255F5FD4AF64FE4C585CF5ADE* L_17 = (ObjectU5BU5D_tC1F4EE0DB0B7300255F5FD4AF64FE4C585CF5ADE*)__this->get__array_4();
			il2cpp_codegen_memory_barrier();
			int32_t L_18 = V_3;
			il2cpp_codegen_initobj((&V_4), sizeof(RuntimeObject *));
			RuntimeObject * L_19 = V_4;
			NullCheck(L_17);
			(L_17)->SetAt(static_cast<il2cpp_array_size_t>(L_18), (RuntimeObject *)L_19);
			int32_t L_20 = (int32_t)__this->get__stealCount_7();
			__this->set__stealCount_7(((int32_t)il2cpp_codegen_add((int32_t)L_20, (int32_t)1)));
			V_5 = (bool)1;
			IL2CPP_LEAVE(0xDE, FINALLY_00cb);
		}

IL_0091:
		{
			int32_t L_21 = V_2;
			il2cpp_codegen_memory_barrier();
			__this->set__headIndex_2(L_21);
			IL2CPP_LEAVE(0xD5, FINALLY_00cb);
		}

IL_009c:
		{
			int32_t L_22 = V_2;
			int32_t L_23 = (int32_t)__this->get__tailIndex_3();
			il2cpp_codegen_memory_barrier();
			if ((((int32_t)L_22) >= ((int32_t)L_23)))
			{
				goto IL_00c9;
			}
		}

IL_00a7:
		{
			RuntimeObject ** L_24 = ___result0;
			ObjectU5BU5D_tC1F4EE0DB0B7300255F5FD4AF64FE4C585CF5ADE* L_25 = (ObjectU5BU5D_tC1F4EE0DB0B7300255F5FD4AF64FE4C585CF5ADE*)__this->get__array_4();
			il2cpp_codegen_memory_barrier();
			int32_t L_26 = V_2;
			int32_t L_27 = (int32_t)__this->get__mask_5();
			il2cpp_codegen_memory_barrier();
			NullCheck(L_25);
			int32_t L_28 = ((int32_t)((int32_t)L_26&(int32_t)L_27));
			RuntimeObject * L_29 = (L_25)->GetAt(static_cast<il2cpp_array_size_t>(L_28));
			*(RuntimeObject **)L_24 = L_29;
			Il2CppCodeGenWriteBarrier((void**)(RuntimeObject **)L_24, (void*)L_29);
			V_5 = (bool)1;
			IL2CPP_LEAVE(0xDE, FINALLY_00cb);
		}

IL_00c9:
		{
			IL2CPP_LEAVE(0xD5, FINALLY_00cb);
		}
	} // end try (depth: 1)
	catch(Il2CppExceptionWrapper& e)
	{
		__last_unhandled_exception = (Exception_t *)e.ex;
		goto FINALLY_00cb;
	}

FINALLY_00cb:
	{ // begin finally (depth: 1)
		{
			bool L_30 = V_1;
			if (!L_30)
			{
				goto IL_00d4;
			}
		}

IL_00ce:
		{
			WorkStealingQueue_t46BF20180E5A47304513625C3E005065BA4B93D7 * L_31 = V_0;
			Monitor_Exit_mA776B403DA88AC77CDEEF67AB9F0D0E77ABD254A((RuntimeObject *)L_31, /*hidden argument*/NULL);
		}

IL_00d4:
		{
			IL2CPP_END_FINALLY(203)
		}
	} // end finally (depth: 1)
	IL2CPP_CLEANUP(203)
	{
		IL2CPP_RETHROW_IF_UNHANDLED(Exception_t *)
		IL2CPP_JUMP_TBL(0xDE, IL_00de)
		IL2CPP_JUMP_TBL(0xD5, IL_00d5)
	}

IL_00d5:
	{
		RuntimeObject ** L_32 = ___result0;
		il2cpp_codegen_initobj(L_32, sizeof(RuntimeObject *));
		return (bool)0;
	}

IL_00de:
	{
		bool L_33 = V_5;
		return (bool)L_33;
	}
}
// System.Int32 System.Collections.Concurrent.ConcurrentBag`1/WorkStealingQueue<System.Object>::DangerousCopyTo(T[],System.Int32)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR int32_t WorkStealingQueue_DangerousCopyTo_m14FDBCB9C9328303C9DF8727461C8A0607B6BC7C_gshared (WorkStealingQueue_t46BF20180E5A47304513625C3E005065BA4B93D7 * __this, ObjectU5BU5D_tC1F4EE0DB0B7300255F5FD4AF64FE4C585CF5ADE* ___array0, int32_t ___arrayIndex1, const RuntimeMethod* method)
{
	int32_t V_0 = 0;
	int32_t V_1 = 0;
	int32_t V_2 = 0;
	{
		int32_t L_0 = (int32_t)__this->get__headIndex_2();
		il2cpp_codegen_memory_barrier();
		V_0 = (int32_t)L_0;
		NullCheck((WorkStealingQueue_t46BF20180E5A47304513625C3E005065BA4B93D7 *)__this);
		int32_t L_1;
		L_1 = ((  int32_t (*) (WorkStealingQueue_t46BF20180E5A47304513625C3E005065BA4B93D7 *, const RuntimeMethod*))IL2CPP_RGCTX_METHOD_INFO(method->klass->rgctx_data, 1)->methodPointer)((WorkStealingQueue_t46BF20180E5A47304513625C3E005065BA4B93D7 *)__this, /*hidden argument*/IL2CPP_RGCTX_METHOD_INFO(method->klass->rgctx_data, 1));
		V_1 = (int32_t)L_1;
		int32_t L_2 = ___arrayIndex1;
		int32_t L_3 = V_1;
		V_2 = (int32_t)((int32_t)il2cpp_codegen_subtract((int32_t)((int32_t)il2cpp_codegen_add((int32_t)L_2, (int32_t)L_3)), (int32_t)1));
		goto IL_003e;
	}

IL_0018:
	{
		ObjectU5BU5D_tC1F4EE0DB0B7300255F5FD4AF64FE4C585CF5ADE* L_4 = ___array0;
		int32_t L_5 = V_2;
		ObjectU5BU5D_tC1F4EE0DB0B7300255F5FD4AF64FE4C585CF5ADE* L_6 = (ObjectU5BU5D_tC1F4EE0DB0B7300255F5FD4AF64FE4C585CF5ADE*)__this->get__array_4();
		il2cpp_codegen_memory_barrier();
		int32_t L_7 = V_0;
		int32_t L_8 = (int32_t)L_7;
		V_0 = (int32_t)((int32_t)il2cpp_codegen_add((int32_t)L_8, (int32_t)1));
		int32_t L_9 = (int32_t)__this->get__mask_5();
		il2cpp_codegen_memory_barrier();
		NullCheck(L_6);
		int32_t L_10 = ((int32_t)((int32_t)L_8&(int32_t)L_9));
		RuntimeObject * L_11 = (L_6)->GetAt(static_cast<il2cpp_array_size_t>(L_10));
		NullCheck(L_4);
		(L_4)->SetAt(static_cast<il2cpp_array_size_t>(L_5), (RuntimeObject *)L_11);
		int32_t L_12 = V_2;
		V_2 = (int32_t)((int32_t)il2cpp_codegen_subtract((int32_t)L_12, (int32_t)1));
	}

IL_003e:
	{
		int32_t L_13 = V_2;
		int32_t L_14 = ___arrayIndex1;
		if ((((int32_t)L_13) >= ((int32_t)L_14)))
		{
			goto IL_0018;
		}
	}
	{
		int32_t L_15 = V_1;
		return (int32_t)L_15;
	}
}
// System.Int32 System.Collections.Concurrent.ConcurrentBag`1/WorkStealingQueue<System.Object>::get_DangerousCount()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR int32_t WorkStealingQueue_get_DangerousCount_m7B7173F3AB4C7B59B72DB25546FDF944300604E7_gshared (WorkStealingQueue_t46BF20180E5A47304513625C3E005065BA4B93D7 * __this, const RuntimeMethod* method)
{
	{
		int32_t L_0 = (int32_t)__this->get__addTakeCount_6();
		int32_t L_1 = (int32_t)__this->get__stealCount_7();
		return (int32_t)((int32_t)il2cpp_codegen_subtract((int32_t)L_0, (int32_t)L_1));
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
// System.Void System.Linq.Parallel.WrapperEqualityComparer`1<System.Object>::.ctor(System.Collections.Generic.IEqualityComparer`1<T>)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void WrapperEqualityComparer_1__ctor_m2981537A54B3ACE5E4831F93BDC81CF92F476679_gshared (WrapperEqualityComparer_1_t4AD211C5560CD8CDAD6255CC8B0CCCC3E20A3D42 * __this, RuntimeObject* ___comparer0, const RuntimeMethod* method)
{
	{
		RuntimeObject* L_0 = ___comparer0;
		if (L_0)
		{
			goto IL_000f;
		}
	}
	{
		EqualityComparer_1_t469B0BBE7B6765C576211BEF8F2803A5AD411A20 * L_1;
		L_1 = ((  EqualityComparer_1_t469B0BBE7B6765C576211BEF8F2803A5AD411A20 * (*) (const RuntimeMethod*))IL2CPP_RGCTX_METHOD_INFO(InitializedTypeInfo(method->klass)->rgctx_data, 0)->methodPointer)(/*hidden argument*/IL2CPP_RGCTX_METHOD_INFO(InitializedTypeInfo(method->klass)->rgctx_data, 0));
		__this->set__comparer_0(L_1);
		return;
	}

IL_000f:
	{
		RuntimeObject* L_2 = ___comparer0;
		__this->set__comparer_0(L_2);
		return;
	}
}
IL2CPP_EXTERN_C  void WrapperEqualityComparer_1__ctor_m2981537A54B3ACE5E4831F93BDC81CF92F476679_AdjustorThunk (RuntimeObject * __this, RuntimeObject* ___comparer0, const RuntimeMethod* method)
{
	int32_t _offset = 1;
	WrapperEqualityComparer_1_t4AD211C5560CD8CDAD6255CC8B0CCCC3E20A3D42 * _thisAdjusted = reinterpret_cast<WrapperEqualityComparer_1_t4AD211C5560CD8CDAD6255CC8B0CCCC3E20A3D42 *>(__this + _offset);
	WrapperEqualityComparer_1__ctor_m2981537A54B3ACE5E4831F93BDC81CF92F476679(_thisAdjusted, ___comparer0, method);
}
// System.Boolean System.Linq.Parallel.WrapperEqualityComparer`1<System.Object>::Equals(System.Linq.Parallel.Wrapper`1<T>,System.Linq.Parallel.Wrapper`1<T>)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR bool WrapperEqualityComparer_1_Equals_m36BCEEDC130CD064FA2A9CC53175BC69844F775A_gshared (WrapperEqualityComparer_1_t4AD211C5560CD8CDAD6255CC8B0CCCC3E20A3D42 * __this, Wrapper_1_tDDD2ABAF8D432140BA7A444ED61075E20B73095F  ___x0, Wrapper_1_tDDD2ABAF8D432140BA7A444ED61075E20B73095F  ___y1, const RuntimeMethod* method)
{
	{
		RuntimeObject* L_0 = (RuntimeObject*)__this->get__comparer_0();
		Wrapper_1_tDDD2ABAF8D432140BA7A444ED61075E20B73095F  L_1 = ___x0;
		RuntimeObject * L_2 = (RuntimeObject *)L_1.get_Value_0();
		Wrapper_1_tDDD2ABAF8D432140BA7A444ED61075E20B73095F  L_3 = ___y1;
		RuntimeObject * L_4 = (RuntimeObject *)L_3.get_Value_0();
		NullCheck((RuntimeObject*)L_0);
		bool L_5;
		L_5 = InterfaceFuncInvoker2< bool, RuntimeObject *, RuntimeObject * >::Invoke(0 /* System.Boolean System.Collections.Generic.IEqualityComparer`1<System.Object>::Equals(!0,!0) */, IL2CPP_RGCTX_DATA(InitializedTypeInfo(method->klass)->rgctx_data, 2), (RuntimeObject*)L_0, (RuntimeObject *)L_2, (RuntimeObject *)L_4);
		return (bool)L_5;
	}
}
IL2CPP_EXTERN_C  bool WrapperEqualityComparer_1_Equals_m36BCEEDC130CD064FA2A9CC53175BC69844F775A_AdjustorThunk (RuntimeObject * __this, Wrapper_1_tDDD2ABAF8D432140BA7A444ED61075E20B73095F  ___x0, Wrapper_1_tDDD2ABAF8D432140BA7A444ED61075E20B73095F  ___y1, const RuntimeMethod* method)
{
	int32_t _offset = 1;
	WrapperEqualityComparer_1_t4AD211C5560CD8CDAD6255CC8B0CCCC3E20A3D42 * _thisAdjusted = reinterpret_cast<WrapperEqualityComparer_1_t4AD211C5560CD8CDAD6255CC8B0CCCC3E20A3D42 *>(__this + _offset);
	bool _returnValue;
	_returnValue = WrapperEqualityComparer_1_Equals_m36BCEEDC130CD064FA2A9CC53175BC69844F775A(_thisAdjusted, ___x0, ___y1, method);
	return _returnValue;
}
// System.Int32 System.Linq.Parallel.WrapperEqualityComparer`1<System.Object>::GetHashCode(System.Linq.Parallel.Wrapper`1<T>)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR int32_t WrapperEqualityComparer_1_GetHashCode_mCC9EDB08CDAB096AD02A9A008B21824E9B023A59_gshared (WrapperEqualityComparer_1_t4AD211C5560CD8CDAD6255CC8B0CCCC3E20A3D42 * __this, Wrapper_1_tDDD2ABAF8D432140BA7A444ED61075E20B73095F  ___x0, const RuntimeMethod* method)
{
	{
		RuntimeObject* L_0 = (RuntimeObject*)__this->get__comparer_0();
		Wrapper_1_tDDD2ABAF8D432140BA7A444ED61075E20B73095F  L_1 = ___x0;
		RuntimeObject * L_2 = (RuntimeObject *)L_1.get_Value_0();
		NullCheck((RuntimeObject*)L_0);
		int32_t L_3;
		L_3 = InterfaceFuncInvoker1< int32_t, RuntimeObject * >::Invoke(1 /* System.Int32 System.Collections.Generic.IEqualityComparer`1<System.Object>::GetHashCode(!0) */, IL2CPP_RGCTX_DATA(InitializedTypeInfo(method->klass)->rgctx_data, 2), (RuntimeObject*)L_0, (RuntimeObject *)L_2);
		return (int32_t)L_3;
	}
}
IL2CPP_EXTERN_C  int32_t WrapperEqualityComparer_1_GetHashCode_mCC9EDB08CDAB096AD02A9A008B21824E9B023A59_AdjustorThunk (RuntimeObject * __this, Wrapper_1_tDDD2ABAF8D432140BA7A444ED61075E20B73095F  ___x0, const RuntimeMethod* method)
{
	int32_t _offset = 1;
	WrapperEqualityComparer_1_t4AD211C5560CD8CDAD6255CC8B0CCCC3E20A3D42 * _thisAdjusted = reinterpret_cast<WrapperEqualityComparer_1_t4AD211C5560CD8CDAD6255CC8B0CCCC3E20A3D42 *>(__this + _offset);
	int32_t _returnValue;
	_returnValue = WrapperEqualityComparer_1_GetHashCode_mCC9EDB08CDAB096AD02A9A008B21824E9B023A59(_thisAdjusted, ___x0, method);
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
// System.Void System.Linq.Parallel.Wrapper`1<System.Object>::.ctor(T)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Wrapper_1__ctor_m6A362088D2F7EEC44415BC9C40FE51B2E7E48B80_gshared (Wrapper_1_tDDD2ABAF8D432140BA7A444ED61075E20B73095F * __this, RuntimeObject * ___value0, const RuntimeMethod* method)
{
	{
		RuntimeObject * L_0 = ___value0;
		__this->set_Value_0(L_0);
		return;
	}
}
IL2CPP_EXTERN_C  void Wrapper_1__ctor_m6A362088D2F7EEC44415BC9C40FE51B2E7E48B80_AdjustorThunk (RuntimeObject * __this, RuntimeObject * ___value0, const RuntimeMethod* method)
{
	int32_t _offset = 1;
	Wrapper_1_tDDD2ABAF8D432140BA7A444ED61075E20B73095F * _thisAdjusted = reinterpret_cast<Wrapper_1_tDDD2ABAF8D432140BA7A444ED61075E20B73095F *>(__this + _offset);
	Wrapper_1__ctor_m6A362088D2F7EEC44415BC9C40FE51B2E7E48B80_inline(_thisAdjusted, ___value0, method);
}
#ifdef __clang__
#pragma clang diagnostic pop
#endif
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif
// System.Void System.Linq.Parallel.ZipQueryOperator`3/ZipQueryOperatorResults<System.Object,System.Object,System.Object>::.ctor(System.Linq.Parallel.QueryResults`1<TLeftInput>,System.Linq.Parallel.QueryResults`1<TRightInput>,System.Func`3<TLeftInput,TRightInput,TOutput>,System.Int32,System.Boolean)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void ZipQueryOperatorResults__ctor_m08A1B2C875BDC0C386A99F43BF2DF69596CD8ACF_gshared (ZipQueryOperatorResults_tB9DD58D5EFCC60A84DADC3938A2FFA8BAA7A6367 * __this, QueryResults_1_t1956EED88B24434B080C8523FEDCF6843748F3D2 * ___leftChildResults0, QueryResults_1_t1956EED88B24434B080C8523FEDCF6843748F3D2 * ___rightChildResults1, Func_3_tBBBFF266D23D5A9A7940D16DA73BCD5DE0753A27 * ___resultSelector2, int32_t ___partitionCount3, bool ___preferStriping4, const RuntimeMethod* method)
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Math_tA269614262430118C9FC5C4D9EF4F61C812568F0_il2cpp_TypeInfo_var);
		s_Il2CppMethodInitialized = true;
	}
	{
		NullCheck((QueryResults_1_t1956EED88B24434B080C8523FEDCF6843748F3D2 *)__this);
		((  void (*) (QueryResults_1_t1956EED88B24434B080C8523FEDCF6843748F3D2 *, const RuntimeMethod*))IL2CPP_RGCTX_METHOD_INFO(method->klass->rgctx_data, 0)->methodPointer)((QueryResults_1_t1956EED88B24434B080C8523FEDCF6843748F3D2 *)__this, /*hidden argument*/IL2CPP_RGCTX_METHOD_INFO(method->klass->rgctx_data, 0));
		QueryResults_1_t1956EED88B24434B080C8523FEDCF6843748F3D2 * L_0 = ___leftChildResults0;
		__this->set__leftChildResults_0(L_0);
		QueryResults_1_t1956EED88B24434B080C8523FEDCF6843748F3D2 * L_1 = ___rightChildResults1;
		__this->set__rightChildResults_1(L_1);
		Func_3_tBBBFF266D23D5A9A7940D16DA73BCD5DE0753A27 * L_2 = ___resultSelector2;
		__this->set__resultSelector_2(L_2);
		int32_t L_3 = ___partitionCount3;
		__this->set__partitionCount_4(L_3);
		bool L_4 = ___preferStriping4;
		__this->set__preferStriping_5(L_4);
		QueryResults_1_t1956EED88B24434B080C8523FEDCF6843748F3D2 * L_5 = (QueryResults_1_t1956EED88B24434B080C8523FEDCF6843748F3D2 *)__this->get__leftChildResults_0();
		NullCheck((QueryResults_1_t1956EED88B24434B080C8523FEDCF6843748F3D2 *)L_5);
		int32_t L_6;
		L_6 = ((  int32_t (*) (QueryResults_1_t1956EED88B24434B080C8523FEDCF6843748F3D2 *, const RuntimeMethod*))IL2CPP_RGCTX_METHOD_INFO(method->klass->rgctx_data, 2)->methodPointer)((QueryResults_1_t1956EED88B24434B080C8523FEDCF6843748F3D2 *)L_5, /*hidden argument*/IL2CPP_RGCTX_METHOD_INFO(method->klass->rgctx_data, 2));
		QueryResults_1_t1956EED88B24434B080C8523FEDCF6843748F3D2 * L_7 = (QueryResults_1_t1956EED88B24434B080C8523FEDCF6843748F3D2 *)__this->get__rightChildResults_1();
		NullCheck((QueryResults_1_t1956EED88B24434B080C8523FEDCF6843748F3D2 *)L_7);
		int32_t L_8;
		L_8 = ((  int32_t (*) (QueryResults_1_t1956EED88B24434B080C8523FEDCF6843748F3D2 *, const RuntimeMethod*))IL2CPP_RGCTX_METHOD_INFO(method->klass->rgctx_data, 3)->methodPointer)((QueryResults_1_t1956EED88B24434B080C8523FEDCF6843748F3D2 *)L_7, /*hidden argument*/IL2CPP_RGCTX_METHOD_INFO(method->klass->rgctx_data, 3));
		IL2CPP_RUNTIME_CLASS_INIT(Math_tA269614262430118C9FC5C4D9EF4F61C812568F0_il2cpp_TypeInfo_var);
		int32_t L_9;
		L_9 = Math_Min_m4C6E1589800A3AA57C1F430C3903847E8D7B4574((int32_t)L_6, (int32_t)L_8, /*hidden argument*/NULL);
		__this->set__count_3(L_9);
		return;
	}
}
// System.Int32 System.Linq.Parallel.ZipQueryOperator`3/ZipQueryOperatorResults<System.Object,System.Object,System.Object>::get_ElementsCount()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR int32_t ZipQueryOperatorResults_get_ElementsCount_m679D4277F20AD5502212F4847E62809AD1C378ED_gshared (ZipQueryOperatorResults_tB9DD58D5EFCC60A84DADC3938A2FFA8BAA7A6367 * __this, const RuntimeMethod* method)
{
	{
		int32_t L_0 = (int32_t)__this->get__count_3();
		return (int32_t)L_0;
	}
}
// System.Boolean System.Linq.Parallel.ZipQueryOperator`3/ZipQueryOperatorResults<System.Object,System.Object,System.Object>::get_IsIndexible()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR bool ZipQueryOperatorResults_get_IsIndexible_m482D03CE6A894966C00671F163B610E40E6BDB08_gshared (ZipQueryOperatorResults_tB9DD58D5EFCC60A84DADC3938A2FFA8BAA7A6367 * __this, const RuntimeMethod* method)
{
	{
		return (bool)1;
	}
}
// TOutput System.Linq.Parallel.ZipQueryOperator`3/ZipQueryOperatorResults<System.Object,System.Object,System.Object>::GetElement(System.Int32)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR RuntimeObject * ZipQueryOperatorResults_GetElement_mCC7D64C4E4B87030AC9C86E68EF18D8F2C1B22B4_gshared (ZipQueryOperatorResults_tB9DD58D5EFCC60A84DADC3938A2FFA8BAA7A6367 * __this, int32_t ___index0, const RuntimeMethod* method)
{
	{
		Func_3_tBBBFF266D23D5A9A7940D16DA73BCD5DE0753A27 * L_0 = (Func_3_tBBBFF266D23D5A9A7940D16DA73BCD5DE0753A27 *)__this->get__resultSelector_2();
		QueryResults_1_t1956EED88B24434B080C8523FEDCF6843748F3D2 * L_1 = (QueryResults_1_t1956EED88B24434B080C8523FEDCF6843748F3D2 *)__this->get__leftChildResults_0();
		int32_t L_2 = ___index0;
		NullCheck((QueryResults_1_t1956EED88B24434B080C8523FEDCF6843748F3D2 *)L_1);
		RuntimeObject * L_3;
		L_3 = VirtFuncInvoker1< RuntimeObject *, int32_t >::Invoke(20 /* T System.Linq.Parallel.QueryResults`1<System.Object>::GetElement(System.Int32) */, (QueryResults_1_t1956EED88B24434B080C8523FEDCF6843748F3D2 *)L_1, (int32_t)L_2);
		QueryResults_1_t1956EED88B24434B080C8523FEDCF6843748F3D2 * L_4 = (QueryResults_1_t1956EED88B24434B080C8523FEDCF6843748F3D2 *)__this->get__rightChildResults_1();
		int32_t L_5 = ___index0;
		NullCheck((QueryResults_1_t1956EED88B24434B080C8523FEDCF6843748F3D2 *)L_4);
		RuntimeObject * L_6;
		L_6 = VirtFuncInvoker1< RuntimeObject *, int32_t >::Invoke(20 /* T System.Linq.Parallel.QueryResults`1<System.Object>::GetElement(System.Int32) */, (QueryResults_1_t1956EED88B24434B080C8523FEDCF6843748F3D2 *)L_4, (int32_t)L_5);
		NullCheck((Func_3_tBBBFF266D23D5A9A7940D16DA73BCD5DE0753A27 *)L_0);
		RuntimeObject * L_7;
		L_7 = ((  RuntimeObject * (*) (Func_3_tBBBFF266D23D5A9A7940D16DA73BCD5DE0753A27 *, RuntimeObject *, RuntimeObject *, const RuntimeMethod*))IL2CPP_RGCTX_METHOD_INFO(method->klass->rgctx_data, 6)->methodPointer)((Func_3_tBBBFF266D23D5A9A7940D16DA73BCD5DE0753A27 *)L_0, (RuntimeObject *)L_3, (RuntimeObject *)L_6, /*hidden argument*/IL2CPP_RGCTX_METHOD_INFO(method->klass->rgctx_data, 6));
		return (RuntimeObject *)L_7;
	}
}
// System.Void System.Linq.Parallel.ZipQueryOperator`3/ZipQueryOperatorResults<System.Object,System.Object,System.Object>::GivePartitionedStream(System.Linq.Parallel.IPartitionedStreamRecipient`1<TOutput>)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void ZipQueryOperatorResults_GivePartitionedStream_m1FB113CD358A05F457919B92083AD8944DD1F647_gshared (ZipQueryOperatorResults_tB9DD58D5EFCC60A84DADC3938A2FFA8BAA7A6367 * __this, RuntimeObject* ___recipient0, const RuntimeMethod* method)
{
	PartitionedStream_2_tE1B2334EDFC774D178A02ACE8BB3C8CFF40AEB03 * V_0 = NULL;
	{
		int32_t L_0 = (int32_t)__this->get__partitionCount_4();
		bool L_1 = (bool)__this->get__preferStriping_5();
		PartitionedStream_2_tE1B2334EDFC774D178A02ACE8BB3C8CFF40AEB03 * L_2;
		L_2 = ((  PartitionedStream_2_tE1B2334EDFC774D178A02ACE8BB3C8CFF40AEB03 * (*) (RuntimeObject*, int32_t, bool, const RuntimeMethod*))IL2CPP_RGCTX_METHOD_INFO(method->klass->rgctx_data, 7)->methodPointer)((RuntimeObject*)__this, (int32_t)L_0, (bool)L_1, /*hidden argument*/IL2CPP_RGCTX_METHOD_INFO(method->klass->rgctx_data, 7));
		V_0 = (PartitionedStream_2_tE1B2334EDFC774D178A02ACE8BB3C8CFF40AEB03 *)L_2;
		RuntimeObject* L_3 = ___recipient0;
		PartitionedStream_2_tE1B2334EDFC774D178A02ACE8BB3C8CFF40AEB03 * L_4 = V_0;
		NullCheck((RuntimeObject*)L_3);
		GenericInterfaceActionInvoker1< PartitionedStream_2_tE1B2334EDFC774D178A02ACE8BB3C8CFF40AEB03 * >::Invoke(IL2CPP_RGCTX_METHOD_INFO(method->klass->rgctx_data, 8), (RuntimeObject*)L_3, (PartitionedStream_2_tE1B2334EDFC774D178A02ACE8BB3C8CFF40AEB03 *)L_4);
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
// System.Void System.Linq.Parallel.ZipQueryOperator`3<System.Object,System.Object,System.Object>::.ctor(System.Linq.ParallelQuery`1<TLeftInput>,System.Linq.ParallelQuery`1<TRightInput>,System.Func`3<TLeftInput,TRightInput,TOutput>)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void ZipQueryOperator_3__ctor_m2142EE5393155E141A307750B59DC63BE5B4C8A6_gshared (ZipQueryOperator_3_t2D0121637CE51185E2CBB640EEAF8876A893637E * __this, ParallelQuery_1_t27EE69EA11DD2EF16DC5DCA17156F1CC9C5D3638 * ___leftChildSource0, ParallelQuery_1_t27EE69EA11DD2EF16DC5DCA17156F1CC9C5D3638 * ___rightChildSource1, Func_3_tBBBFF266D23D5A9A7940D16DA73BCD5DE0753A27 * ___resultSelector2, const RuntimeMethod* method)
{
	{
		ParallelQuery_1_t27EE69EA11DD2EF16DC5DCA17156F1CC9C5D3638 * L_0 = ___leftChildSource0;
		QueryOperator_1_t2F4038BA1C7627FB9361A0BC79E4F2A421AEF668 * L_1;
		L_1 = ((  QueryOperator_1_t2F4038BA1C7627FB9361A0BC79E4F2A421AEF668 * (*) (RuntimeObject*, const RuntimeMethod*))IL2CPP_RGCTX_METHOD_INFO(method->klass->rgctx_data, 0)->methodPointer)((RuntimeObject*)L_0, /*hidden argument*/IL2CPP_RGCTX_METHOD_INFO(method->klass->rgctx_data, 0));
		ParallelQuery_1_t27EE69EA11DD2EF16DC5DCA17156F1CC9C5D3638 * L_2 = ___rightChildSource1;
		QueryOperator_1_t2F4038BA1C7627FB9361A0BC79E4F2A421AEF668 * L_3;
		L_3 = ((  QueryOperator_1_t2F4038BA1C7627FB9361A0BC79E4F2A421AEF668 * (*) (RuntimeObject*, const RuntimeMethod*))IL2CPP_RGCTX_METHOD_INFO(method->klass->rgctx_data, 3)->methodPointer)((RuntimeObject*)L_2, /*hidden argument*/IL2CPP_RGCTX_METHOD_INFO(method->klass->rgctx_data, 3));
		Func_3_tBBBFF266D23D5A9A7940D16DA73BCD5DE0753A27 * L_4 = ___resultSelector2;
		NullCheck((ZipQueryOperator_3_t2D0121637CE51185E2CBB640EEAF8876A893637E *)__this);
		((  void (*) (ZipQueryOperator_3_t2D0121637CE51185E2CBB640EEAF8876A893637E *, QueryOperator_1_t2F4038BA1C7627FB9361A0BC79E4F2A421AEF668 *, QueryOperator_1_t2F4038BA1C7627FB9361A0BC79E4F2A421AEF668 *, Func_3_tBBBFF266D23D5A9A7940D16DA73BCD5DE0753A27 *, const RuntimeMethod*))IL2CPP_RGCTX_METHOD_INFO(method->klass->rgctx_data, 6)->methodPointer)((ZipQueryOperator_3_t2D0121637CE51185E2CBB640EEAF8876A893637E *)__this, (QueryOperator_1_t2F4038BA1C7627FB9361A0BC79E4F2A421AEF668 *)L_1, (QueryOperator_1_t2F4038BA1C7627FB9361A0BC79E4F2A421AEF668 *)L_3, (Func_3_tBBBFF266D23D5A9A7940D16DA73BCD5DE0753A27 *)L_4, /*hidden argument*/IL2CPP_RGCTX_METHOD_INFO(method->klass->rgctx_data, 6));
		return;
	}
}
// System.Void System.Linq.Parallel.ZipQueryOperator`3<System.Object,System.Object,System.Object>::.ctor(System.Linq.Parallel.QueryOperator`1<TLeftInput>,System.Linq.Parallel.QueryOperator`1<TRightInput>,System.Func`3<TLeftInput,TRightInput,TOutput>)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void ZipQueryOperator_3__ctor_mC9B0BD4734CD61FCE0371738DC57A21B2A1585FC_gshared (ZipQueryOperator_3_t2D0121637CE51185E2CBB640EEAF8876A893637E * __this, QueryOperator_1_t2F4038BA1C7627FB9361A0BC79E4F2A421AEF668 * ___left0, QueryOperator_1_t2F4038BA1C7627FB9361A0BC79E4F2A421AEF668 * ___right1, Func_3_tBBBFF266D23D5A9A7940D16DA73BCD5DE0753A27 * ___resultSelector2, const RuntimeMethod* method)
{
	QuerySettings_t45D8808D6FB4096670C5DDCA198AD4523EE0B974  V_0;
	memset((&V_0), 0, sizeof(V_0));
	uint8_t V_1 = 0;
	uint8_t V_2 = 0;
	ZipQueryOperator_3_t2D0121637CE51185E2CBB640EEAF8876A893637E * G_B2_0 = NULL;
	ZipQueryOperator_3_t2D0121637CE51185E2CBB640EEAF8876A893637E * G_B1_0 = NULL;
	int32_t G_B3_0 = 0;
	ZipQueryOperator_3_t2D0121637CE51185E2CBB640EEAF8876A893637E * G_B3_1 = NULL;
	ZipQueryOperator_3_t2D0121637CE51185E2CBB640EEAF8876A893637E * G_B5_0 = NULL;
	ZipQueryOperator_3_t2D0121637CE51185E2CBB640EEAF8876A893637E * G_B4_0 = NULL;
	ZipQueryOperator_3_t2D0121637CE51185E2CBB640EEAF8876A893637E * G_B8_0 = NULL;
	ZipQueryOperator_3_t2D0121637CE51185E2CBB640EEAF8876A893637E * G_B7_0 = NULL;
	ZipQueryOperator_3_t2D0121637CE51185E2CBB640EEAF8876A893637E * G_B6_0 = NULL;
	int32_t G_B9_0 = 0;
	ZipQueryOperator_3_t2D0121637CE51185E2CBB640EEAF8876A893637E * G_B9_1 = NULL;
	{
		QueryOperator_1_t2F4038BA1C7627FB9361A0BC79E4F2A421AEF668 * L_0 = ___left0;
		NullCheck((ParallelQuery_tA2D9886CB464C3FA8EB1BB56036F35E3AB55DEF4 *)L_0);
		QuerySettings_t45D8808D6FB4096670C5DDCA198AD4523EE0B974  L_1;
		L_1 = ParallelQuery_get_SpecifiedQuerySettings_m567824488025D3A0038F414E67F3CAA65525417D_inline((ParallelQuery_tA2D9886CB464C3FA8EB1BB56036F35E3AB55DEF4 *)L_0, /*hidden argument*/NULL);
		V_0 = (QuerySettings_t45D8808D6FB4096670C5DDCA198AD4523EE0B974 )L_1;
		QueryOperator_1_t2F4038BA1C7627FB9361A0BC79E4F2A421AEF668 * L_2 = ___right1;
		NullCheck((ParallelQuery_tA2D9886CB464C3FA8EB1BB56036F35E3AB55DEF4 *)L_2);
		QuerySettings_t45D8808D6FB4096670C5DDCA198AD4523EE0B974  L_3;
		L_3 = ParallelQuery_get_SpecifiedQuerySettings_m567824488025D3A0038F414E67F3CAA65525417D_inline((ParallelQuery_tA2D9886CB464C3FA8EB1BB56036F35E3AB55DEF4 *)L_2, /*hidden argument*/NULL);
		QuerySettings_t45D8808D6FB4096670C5DDCA198AD4523EE0B974  L_4;
		L_4 = QuerySettings_Merge_m4DEE1E7D80EA56EFC0148C6EF916CDB5DE8D92AC((QuerySettings_t45D8808D6FB4096670C5DDCA198AD4523EE0B974 *)(QuerySettings_t45D8808D6FB4096670C5DDCA198AD4523EE0B974 *)(&V_0), (QuerySettings_t45D8808D6FB4096670C5DDCA198AD4523EE0B974 )L_3, /*hidden argument*/NULL);
		NullCheck((QueryOperator_1_t2F4038BA1C7627FB9361A0BC79E4F2A421AEF668 *)__this);
		((  void (*) (QueryOperator_1_t2F4038BA1C7627FB9361A0BC79E4F2A421AEF668 *, QuerySettings_t45D8808D6FB4096670C5DDCA198AD4523EE0B974 , const RuntimeMethod*))IL2CPP_RGCTX_METHOD_INFO(method->klass->rgctx_data, 7)->methodPointer)((QueryOperator_1_t2F4038BA1C7627FB9361A0BC79E4F2A421AEF668 *)__this, (QuerySettings_t45D8808D6FB4096670C5DDCA198AD4523EE0B974 )L_4, /*hidden argument*/IL2CPP_RGCTX_METHOD_INFO(method->klass->rgctx_data, 7));
		QueryOperator_1_t2F4038BA1C7627FB9361A0BC79E4F2A421AEF668 * L_5 = ___left0;
		__this->set__leftChild_3(L_5);
		QueryOperator_1_t2F4038BA1C7627FB9361A0BC79E4F2A421AEF668 * L_6 = ___right1;
		__this->set__rightChild_4(L_6);
		Func_3_tBBBFF266D23D5A9A7940D16DA73BCD5DE0753A27 * L_7 = ___resultSelector2;
		__this->set__resultSelector_2(L_7);
		QueryOperator_1_t2F4038BA1C7627FB9361A0BC79E4F2A421AEF668 * L_8 = (QueryOperator_1_t2F4038BA1C7627FB9361A0BC79E4F2A421AEF668 *)__this->get__leftChild_3();
		NullCheck((QueryOperator_1_t2F4038BA1C7627FB9361A0BC79E4F2A421AEF668 *)L_8);
		bool L_9;
		L_9 = ((  bool (*) (QueryOperator_1_t2F4038BA1C7627FB9361A0BC79E4F2A421AEF668 *, const RuntimeMethod*))IL2CPP_RGCTX_METHOD_INFO(method->klass->rgctx_data, 10)->methodPointer)((QueryOperator_1_t2F4038BA1C7627FB9361A0BC79E4F2A421AEF668 *)L_8, /*hidden argument*/IL2CPP_RGCTX_METHOD_INFO(method->klass->rgctx_data, 10));
		G_B1_0 = ((ZipQueryOperator_3_t2D0121637CE51185E2CBB640EEAF8876A893637E *)(__this));
		if (L_9)
		{
			G_B2_0 = ((ZipQueryOperator_3_t2D0121637CE51185E2CBB640EEAF8876A893637E *)(__this));
			goto IL_004a;
		}
	}
	{
		QueryOperator_1_t2F4038BA1C7627FB9361A0BC79E4F2A421AEF668 * L_10 = (QueryOperator_1_t2F4038BA1C7627FB9361A0BC79E4F2A421AEF668 *)__this->get__rightChild_4();
		NullCheck((QueryOperator_1_t2F4038BA1C7627FB9361A0BC79E4F2A421AEF668 *)L_10);
		bool L_11;
		L_11 = ((  bool (*) (QueryOperator_1_t2F4038BA1C7627FB9361A0BC79E4F2A421AEF668 *, const RuntimeMethod*))IL2CPP_RGCTX_METHOD_INFO(method->klass->rgctx_data, 11)->methodPointer)((QueryOperator_1_t2F4038BA1C7627FB9361A0BC79E4F2A421AEF668 *)L_10, /*hidden argument*/IL2CPP_RGCTX_METHOD_INFO(method->klass->rgctx_data, 11));
		G_B3_0 = ((int32_t)(L_11));
		G_B3_1 = ((ZipQueryOperator_3_t2D0121637CE51185E2CBB640EEAF8876A893637E *)(G_B1_0));
		goto IL_004b;
	}

IL_004a:
	{
		G_B3_0 = 1;
		G_B3_1 = ((ZipQueryOperator_3_t2D0121637CE51185E2CBB640EEAF8876A893637E *)(G_B2_0));
	}

IL_004b:
	{
		NullCheck(G_B3_1);
		((QueryOperator_1_t2F4038BA1C7627FB9361A0BC79E4F2A421AEF668 *)G_B3_1)->set__outputOrdered_1((bool)G_B3_0);
		QueryOperator_1_t2F4038BA1C7627FB9361A0BC79E4F2A421AEF668 * L_12 = (QueryOperator_1_t2F4038BA1C7627FB9361A0BC79E4F2A421AEF668 *)__this->get__leftChild_3();
		NullCheck((QueryOperator_1_t2F4038BA1C7627FB9361A0BC79E4F2A421AEF668 *)L_12);
		uint8_t L_13;
		L_13 = VirtFuncInvoker0< uint8_t >::Invoke(14 /* System.Linq.Parallel.OrdinalIndexState System.Linq.Parallel.QueryOperator`1<System.Object>::get_OrdinalIndexState() */, (QueryOperator_1_t2F4038BA1C7627FB9361A0BC79E4F2A421AEF668 *)L_12);
		V_1 = (uint8_t)L_13;
		QueryOperator_1_t2F4038BA1C7627FB9361A0BC79E4F2A421AEF668 * L_14 = (QueryOperator_1_t2F4038BA1C7627FB9361A0BC79E4F2A421AEF668 *)__this->get__rightChild_4();
		NullCheck((QueryOperator_1_t2F4038BA1C7627FB9361A0BC79E4F2A421AEF668 *)L_14);
		uint8_t L_15;
		L_15 = VirtFuncInvoker0< uint8_t >::Invoke(14 /* System.Linq.Parallel.OrdinalIndexState System.Linq.Parallel.QueryOperator`1<System.Object>::get_OrdinalIndexState() */, (QueryOperator_1_t2F4038BA1C7627FB9361A0BC79E4F2A421AEF668 *)L_14);
		V_2 = (uint8_t)L_15;
		uint8_t L_16 = V_1;
		__this->set__prematureMergeLeft_5((bool)((!(((uint32_t)L_16) <= ((uint32_t)0)))? 1 : 0));
		uint8_t L_17 = V_2;
		__this->set__prematureMergeRight_6((bool)((!(((uint32_t)L_17) <= ((uint32_t)0)))? 1 : 0));
		bool L_18 = (bool)__this->get__prematureMergeLeft_5();
		G_B4_0 = ((ZipQueryOperator_3_t2D0121637CE51185E2CBB640EEAF8876A893637E *)(__this));
		if (!L_18)
		{
			G_B5_0 = ((ZipQueryOperator_3_t2D0121637CE51185E2CBB640EEAF8876A893637E *)(__this));
			goto IL_0089;
		}
	}
	{
		uint8_t L_19 = V_1;
		G_B5_0 = ((ZipQueryOperator_3_t2D0121637CE51185E2CBB640EEAF8876A893637E *)(G_B4_0));
		if ((!(((uint32_t)L_19) == ((uint32_t)3))))
		{
			G_B8_0 = ((ZipQueryOperator_3_t2D0121637CE51185E2CBB640EEAF8876A893637E *)(G_B4_0));
			goto IL_009d;
		}
	}

IL_0089:
	{
		bool L_20 = (bool)__this->get__prematureMergeRight_6();
		G_B6_0 = ((ZipQueryOperator_3_t2D0121637CE51185E2CBB640EEAF8876A893637E *)(G_B5_0));
		if (!L_20)
		{
			G_B7_0 = ((ZipQueryOperator_3_t2D0121637CE51185E2CBB640EEAF8876A893637E *)(G_B5_0));
			goto IL_009a;
		}
	}
	{
		uint8_t L_21 = V_2;
		G_B9_0 = ((((int32_t)((((int32_t)L_21) == ((int32_t)3))? 1 : 0)) == ((int32_t)0))? 1 : 0);
		G_B9_1 = ((ZipQueryOperator_3_t2D0121637CE51185E2CBB640EEAF8876A893637E *)(G_B6_0));
		goto IL_009e;
	}

IL_009a:
	{
		G_B9_0 = 0;
		G_B9_1 = ((ZipQueryOperator_3_t2D0121637CE51185E2CBB640EEAF8876A893637E *)(G_B7_0));
		goto IL_009e;
	}

IL_009d:
	{
		G_B9_0 = 1;
		G_B9_1 = ((ZipQueryOperator_3_t2D0121637CE51185E2CBB640EEAF8876A893637E *)(G_B8_0));
	}

IL_009e:
	{
		NullCheck(G_B9_1);
		G_B9_1->set__limitsParallelism_7((bool)G_B9_0);
		return;
	}
}
// System.Linq.Parallel.QueryResults`1<TOutput> System.Linq.Parallel.ZipQueryOperator`3<System.Object,System.Object,System.Object>::Open(System.Linq.Parallel.QuerySettings,System.Boolean)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR QueryResults_1_t1956EED88B24434B080C8523FEDCF6843748F3D2 * ZipQueryOperator_3_Open_m31D1E7688DE5817E030B9C13C568B72A72722C0D_gshared (ZipQueryOperator_3_t2D0121637CE51185E2CBB640EEAF8876A893637E * __this, QuerySettings_t45D8808D6FB4096670C5DDCA198AD4523EE0B974  ___settings0, bool ___preferStriping1, const RuntimeMethod* method)
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Nullable_1_get_Value_mA0CB54A62D31AFC51F165263F2DB953605F2458D_RuntimeMethod_var);
		s_Il2CppMethodInitialized = true;
	}
	QueryResults_1_t1956EED88B24434B080C8523FEDCF6843748F3D2 * V_0 = NULL;
	QueryResults_1_t1956EED88B24434B080C8523FEDCF6843748F3D2 * V_1 = NULL;
	int32_t V_2 = 0;
	Nullable_1_t864FD0051A05D37F91C857AB496BFCB3FE756103  V_3;
	memset((&V_3), 0, sizeof(V_3));
	PartitionedStreamMerger_1_tF29B032A14C6BEEEFD1400E4349350A1F87F5364 * V_4 = NULL;
	PartitionedStreamMerger_1_tF29B032A14C6BEEEFD1400E4349350A1F87F5364 * V_5 = NULL;
	{
		QueryOperator_1_t2F4038BA1C7627FB9361A0BC79E4F2A421AEF668 * L_0 = (QueryOperator_1_t2F4038BA1C7627FB9361A0BC79E4F2A421AEF668 *)__this->get__leftChild_3();
		QuerySettings_t45D8808D6FB4096670C5DDCA198AD4523EE0B974  L_1 = ___settings0;
		bool L_2 = ___preferStriping1;
		NullCheck((QueryOperator_1_t2F4038BA1C7627FB9361A0BC79E4F2A421AEF668 *)L_0);
		QueryResults_1_t1956EED88B24434B080C8523FEDCF6843748F3D2 * L_3;
		L_3 = VirtFuncInvoker2< QueryResults_1_t1956EED88B24434B080C8523FEDCF6843748F3D2 *, QuerySettings_t45D8808D6FB4096670C5DDCA198AD4523EE0B974 , bool >::Invoke(10 /* System.Linq.Parallel.QueryResults`1<TOutput> System.Linq.Parallel.QueryOperator`1<System.Object>::Open(System.Linq.Parallel.QuerySettings,System.Boolean) */, (QueryOperator_1_t2F4038BA1C7627FB9361A0BC79E4F2A421AEF668 *)L_0, (QuerySettings_t45D8808D6FB4096670C5DDCA198AD4523EE0B974 )L_1, (bool)L_2);
		V_0 = (QueryResults_1_t1956EED88B24434B080C8523FEDCF6843748F3D2 *)L_3;
		QueryOperator_1_t2F4038BA1C7627FB9361A0BC79E4F2A421AEF668 * L_4 = (QueryOperator_1_t2F4038BA1C7627FB9361A0BC79E4F2A421AEF668 *)__this->get__rightChild_4();
		QuerySettings_t45D8808D6FB4096670C5DDCA198AD4523EE0B974  L_5 = ___settings0;
		bool L_6 = ___preferStriping1;
		NullCheck((QueryOperator_1_t2F4038BA1C7627FB9361A0BC79E4F2A421AEF668 *)L_4);
		QueryResults_1_t1956EED88B24434B080C8523FEDCF6843748F3D2 * L_7;
		L_7 = VirtFuncInvoker2< QueryResults_1_t1956EED88B24434B080C8523FEDCF6843748F3D2 *, QuerySettings_t45D8808D6FB4096670C5DDCA198AD4523EE0B974 , bool >::Invoke(10 /* System.Linq.Parallel.QueryResults`1<TOutput> System.Linq.Parallel.QueryOperator`1<System.Object>::Open(System.Linq.Parallel.QuerySettings,System.Boolean) */, (QueryOperator_1_t2F4038BA1C7627FB9361A0BC79E4F2A421AEF668 *)L_4, (QuerySettings_t45D8808D6FB4096670C5DDCA198AD4523EE0B974 )L_5, (bool)L_6);
		V_1 = (QueryResults_1_t1956EED88B24434B080C8523FEDCF6843748F3D2 *)L_7;
		Nullable_1_t864FD0051A05D37F91C857AB496BFCB3FE756103  L_8;
		L_8 = QuerySettings_get_DegreeOfParallelism_mCA5E77A72EA27EFA3C7C98707937196BB51F5482_inline((QuerySettings_t45D8808D6FB4096670C5DDCA198AD4523EE0B974 *)(QuerySettings_t45D8808D6FB4096670C5DDCA198AD4523EE0B974 *)(&___settings0), /*hidden argument*/NULL);
		V_3 = (Nullable_1_t864FD0051A05D37F91C857AB496BFCB3FE756103 )L_8;
		int32_t L_9;
		L_9 = Nullable_1_get_Value_mA0CB54A62D31AFC51F165263F2DB953605F2458D((Nullable_1_t864FD0051A05D37F91C857AB496BFCB3FE756103 *)(Nullable_1_t864FD0051A05D37F91C857AB496BFCB3FE756103 *)(&V_3), /*hidden argument*/Nullable_1_get_Value_mA0CB54A62D31AFC51F165263F2DB953605F2458D_RuntimeMethod_var);
		V_2 = (int32_t)L_9;
		bool L_10 = (bool)__this->get__prematureMergeLeft_5();
		if (!L_10)
		{
			goto IL_0079;
		}
	}
	{
		TaskScheduler_t74FBEEEDBDD5E0088FF0EEC18F45CD866B098D5D * L_11;
		L_11 = QuerySettings_get_TaskScheduler_m759B7D8E10ED54FFDFF56B8015677274E119EA3D_inline((QuerySettings_t45D8808D6FB4096670C5DDCA198AD4523EE0B974 *)(QuerySettings_t45D8808D6FB4096670C5DDCA198AD4523EE0B974 *)(&___settings0), /*hidden argument*/NULL);
		QueryOperator_1_t2F4038BA1C7627FB9361A0BC79E4F2A421AEF668 * L_12 = (QueryOperator_1_t2F4038BA1C7627FB9361A0BC79E4F2A421AEF668 *)__this->get__leftChild_3();
		NullCheck((QueryOperator_1_t2F4038BA1C7627FB9361A0BC79E4F2A421AEF668 *)L_12);
		bool L_13;
		L_13 = ((  bool (*) (QueryOperator_1_t2F4038BA1C7627FB9361A0BC79E4F2A421AEF668 *, const RuntimeMethod*))IL2CPP_RGCTX_METHOD_INFO(method->klass->rgctx_data, 10)->methodPointer)((QueryOperator_1_t2F4038BA1C7627FB9361A0BC79E4F2A421AEF668 *)L_12, /*hidden argument*/IL2CPP_RGCTX_METHOD_INFO(method->klass->rgctx_data, 10));
		CancellationState_t302EEDE088D5E82EBE9A74EE31029F9CB981E9CC * L_14;
		L_14 = QuerySettings_get_CancellationState_m83D1086517B2A38D891CBDB22977EC9519818F3D_inline((QuerySettings_t45D8808D6FB4096670C5DDCA198AD4523EE0B974 *)(QuerySettings_t45D8808D6FB4096670C5DDCA198AD4523EE0B974 *)(&___settings0), /*hidden argument*/NULL);
		int32_t L_15;
		L_15 = QuerySettings_get_QueryId_m79A03407AAD4A5BCB2BC58BD9CCDA659413BB35E_inline((QuerySettings_t45D8808D6FB4096670C5DDCA198AD4523EE0B974 *)(QuerySettings_t45D8808D6FB4096670C5DDCA198AD4523EE0B974 *)(&___settings0), /*hidden argument*/NULL);
		PartitionedStreamMerger_1_tF29B032A14C6BEEEFD1400E4349350A1F87F5364 * L_16 = (PartitionedStreamMerger_1_tF29B032A14C6BEEEFD1400E4349350A1F87F5364 *)il2cpp_codegen_object_new(IL2CPP_RGCTX_DATA(method->klass->rgctx_data, 16));
		((  void (*) (PartitionedStreamMerger_1_tF29B032A14C6BEEEFD1400E4349350A1F87F5364 *, bool, int32_t, TaskScheduler_t74FBEEEDBDD5E0088FF0EEC18F45CD866B098D5D *, bool, CancellationState_t302EEDE088D5E82EBE9A74EE31029F9CB981E9CC *, int32_t, const RuntimeMethod*))IL2CPP_RGCTX_METHOD_INFO(method->klass->rgctx_data, 17)->methodPointer)(L_16, (bool)0, (int32_t)3, (TaskScheduler_t74FBEEEDBDD5E0088FF0EEC18F45CD866B098D5D *)L_11, (bool)L_13, (CancellationState_t302EEDE088D5E82EBE9A74EE31029F9CB981E9CC *)L_14, (int32_t)L_15, /*hidden argument*/IL2CPP_RGCTX_METHOD_INFO(method->klass->rgctx_data, 17));
		V_4 = (PartitionedStreamMerger_1_tF29B032A14C6BEEEFD1400E4349350A1F87F5364 *)L_16;
		QueryResults_1_t1956EED88B24434B080C8523FEDCF6843748F3D2 * L_17 = V_0;
		PartitionedStreamMerger_1_tF29B032A14C6BEEEFD1400E4349350A1F87F5364 * L_18 = V_4;
		NullCheck((QueryResults_1_t1956EED88B24434B080C8523FEDCF6843748F3D2 *)L_17);
		VirtActionInvoker1< RuntimeObject* >::Invoke(18 /* System.Void System.Linq.Parallel.QueryResults`1<System.Object>::GivePartitionedStream(System.Linq.Parallel.IPartitionedStreamRecipient`1<T>) */, (QueryResults_1_t1956EED88B24434B080C8523FEDCF6843748F3D2 *)L_17, (RuntimeObject*)L_18);
		PartitionedStreamMerger_1_tF29B032A14C6BEEEFD1400E4349350A1F87F5364 * L_19 = V_4;
		NullCheck((PartitionedStreamMerger_1_tF29B032A14C6BEEEFD1400E4349350A1F87F5364 *)L_19);
		MergeExecutor_1_t53031849DE058B85127E8DDEEB6483EA88655E2D * L_20;
		L_20 = ((  MergeExecutor_1_t53031849DE058B85127E8DDEEB6483EA88655E2D * (*) (PartitionedStreamMerger_1_tF29B032A14C6BEEEFD1400E4349350A1F87F5364 *, const RuntimeMethod*))IL2CPP_RGCTX_METHOD_INFO(method->klass->rgctx_data, 19)->methodPointer)((PartitionedStreamMerger_1_tF29B032A14C6BEEEFD1400E4349350A1F87F5364 *)L_19, /*hidden argument*/IL2CPP_RGCTX_METHOD_INFO(method->klass->rgctx_data, 19));
		NullCheck((MergeExecutor_1_t53031849DE058B85127E8DDEEB6483EA88655E2D *)L_20);
		ObjectU5BU5D_tC1F4EE0DB0B7300255F5FD4AF64FE4C585CF5ADE* L_21;
		L_21 = ((  ObjectU5BU5D_tC1F4EE0DB0B7300255F5FD4AF64FE4C585CF5ADE* (*) (MergeExecutor_1_t53031849DE058B85127E8DDEEB6483EA88655E2D *, const RuntimeMethod*))IL2CPP_RGCTX_METHOD_INFO(method->klass->rgctx_data, 20)->methodPointer)((MergeExecutor_1_t53031849DE058B85127E8DDEEB6483EA88655E2D *)L_20, /*hidden argument*/IL2CPP_RGCTX_METHOD_INFO(method->klass->rgctx_data, 20));
		int32_t L_22 = V_2;
		bool L_23 = ___preferStriping1;
		ListQueryResults_1_t00D93FF58E931DC3CEE0650FBA675E7A368BE065 * L_24 = (ListQueryResults_1_t00D93FF58E931DC3CEE0650FBA675E7A368BE065 *)il2cpp_codegen_object_new(IL2CPP_RGCTX_DATA(method->klass->rgctx_data, 21));
		((  void (*) (ListQueryResults_1_t00D93FF58E931DC3CEE0650FBA675E7A368BE065 *, RuntimeObject*, int32_t, bool, const RuntimeMethod*))IL2CPP_RGCTX_METHOD_INFO(method->klass->rgctx_data, 22)->methodPointer)(L_24, (RuntimeObject*)(RuntimeObject*)L_21, (int32_t)L_22, (bool)L_23, /*hidden argument*/IL2CPP_RGCTX_METHOD_INFO(method->klass->rgctx_data, 22));
		V_0 = (QueryResults_1_t1956EED88B24434B080C8523FEDCF6843748F3D2 *)L_24;
	}

IL_0079:
	{
		bool L_25 = (bool)__this->get__prematureMergeRight_6();
		if (!L_25)
		{
			goto IL_00c6;
		}
	}
	{
		TaskScheduler_t74FBEEEDBDD5E0088FF0EEC18F45CD866B098D5D * L_26;
		L_26 = QuerySettings_get_TaskScheduler_m759B7D8E10ED54FFDFF56B8015677274E119EA3D_inline((QuerySettings_t45D8808D6FB4096670C5DDCA198AD4523EE0B974 *)(QuerySettings_t45D8808D6FB4096670C5DDCA198AD4523EE0B974 *)(&___settings0), /*hidden argument*/NULL);
		QueryOperator_1_t2F4038BA1C7627FB9361A0BC79E4F2A421AEF668 * L_27 = (QueryOperator_1_t2F4038BA1C7627FB9361A0BC79E4F2A421AEF668 *)__this->get__rightChild_4();
		NullCheck((QueryOperator_1_t2F4038BA1C7627FB9361A0BC79E4F2A421AEF668 *)L_27);
		bool L_28;
		L_28 = ((  bool (*) (QueryOperator_1_t2F4038BA1C7627FB9361A0BC79E4F2A421AEF668 *, const RuntimeMethod*))IL2CPP_RGCTX_METHOD_INFO(method->klass->rgctx_data, 11)->methodPointer)((QueryOperator_1_t2F4038BA1C7627FB9361A0BC79E4F2A421AEF668 *)L_27, /*hidden argument*/IL2CPP_RGCTX_METHOD_INFO(method->klass->rgctx_data, 11));
		CancellationState_t302EEDE088D5E82EBE9A74EE31029F9CB981E9CC * L_29;
		L_29 = QuerySettings_get_CancellationState_m83D1086517B2A38D891CBDB22977EC9519818F3D_inline((QuerySettings_t45D8808D6FB4096670C5DDCA198AD4523EE0B974 *)(QuerySettings_t45D8808D6FB4096670C5DDCA198AD4523EE0B974 *)(&___settings0), /*hidden argument*/NULL);
		int32_t L_30;
		L_30 = QuerySettings_get_QueryId_m79A03407AAD4A5BCB2BC58BD9CCDA659413BB35E_inline((QuerySettings_t45D8808D6FB4096670C5DDCA198AD4523EE0B974 *)(QuerySettings_t45D8808D6FB4096670C5DDCA198AD4523EE0B974 *)(&___settings0), /*hidden argument*/NULL);
		PartitionedStreamMerger_1_tF29B032A14C6BEEEFD1400E4349350A1F87F5364 * L_31 = (PartitionedStreamMerger_1_tF29B032A14C6BEEEFD1400E4349350A1F87F5364 *)il2cpp_codegen_object_new(IL2CPP_RGCTX_DATA(method->klass->rgctx_data, 23));
		((  void (*) (PartitionedStreamMerger_1_tF29B032A14C6BEEEFD1400E4349350A1F87F5364 *, bool, int32_t, TaskScheduler_t74FBEEEDBDD5E0088FF0EEC18F45CD866B098D5D *, bool, CancellationState_t302EEDE088D5E82EBE9A74EE31029F9CB981E9CC *, int32_t, const RuntimeMethod*))IL2CPP_RGCTX_METHOD_INFO(method->klass->rgctx_data, 24)->methodPointer)(L_31, (bool)0, (int32_t)3, (TaskScheduler_t74FBEEEDBDD5E0088FF0EEC18F45CD866B098D5D *)L_26, (bool)L_28, (CancellationState_t302EEDE088D5E82EBE9A74EE31029F9CB981E9CC *)L_29, (int32_t)L_30, /*hidden argument*/IL2CPP_RGCTX_METHOD_INFO(method->klass->rgctx_data, 24));
		V_5 = (PartitionedStreamMerger_1_tF29B032A14C6BEEEFD1400E4349350A1F87F5364 *)L_31;
		QueryResults_1_t1956EED88B24434B080C8523FEDCF6843748F3D2 * L_32 = V_1;
		PartitionedStreamMerger_1_tF29B032A14C6BEEEFD1400E4349350A1F87F5364 * L_33 = V_5;
		NullCheck((QueryResults_1_t1956EED88B24434B080C8523FEDCF6843748F3D2 *)L_32);
		VirtActionInvoker1< RuntimeObject* >::Invoke(18 /* System.Void System.Linq.Parallel.QueryResults`1<System.Object>::GivePartitionedStream(System.Linq.Parallel.IPartitionedStreamRecipient`1<T>) */, (QueryResults_1_t1956EED88B24434B080C8523FEDCF6843748F3D2 *)L_32, (RuntimeObject*)L_33);
		PartitionedStreamMerger_1_tF29B032A14C6BEEEFD1400E4349350A1F87F5364 * L_34 = V_5;
		NullCheck((PartitionedStreamMerger_1_tF29B032A14C6BEEEFD1400E4349350A1F87F5364 *)L_34);
		MergeExecutor_1_t53031849DE058B85127E8DDEEB6483EA88655E2D * L_35;
		L_35 = ((  MergeExecutor_1_t53031849DE058B85127E8DDEEB6483EA88655E2D * (*) (PartitionedStreamMerger_1_tF29B032A14C6BEEEFD1400E4349350A1F87F5364 *, const RuntimeMethod*))IL2CPP_RGCTX_METHOD_INFO(method->klass->rgctx_data, 26)->methodPointer)((PartitionedStreamMerger_1_tF29B032A14C6BEEEFD1400E4349350A1F87F5364 *)L_34, /*hidden argument*/IL2CPP_RGCTX_METHOD_INFO(method->klass->rgctx_data, 26));
		NullCheck((MergeExecutor_1_t53031849DE058B85127E8DDEEB6483EA88655E2D *)L_35);
		ObjectU5BU5D_tC1F4EE0DB0B7300255F5FD4AF64FE4C585CF5ADE* L_36;
		L_36 = ((  ObjectU5BU5D_tC1F4EE0DB0B7300255F5FD4AF64FE4C585CF5ADE* (*) (MergeExecutor_1_t53031849DE058B85127E8DDEEB6483EA88655E2D *, const RuntimeMethod*))IL2CPP_RGCTX_METHOD_INFO(method->klass->rgctx_data, 27)->methodPointer)((MergeExecutor_1_t53031849DE058B85127E8DDEEB6483EA88655E2D *)L_35, /*hidden argument*/IL2CPP_RGCTX_METHOD_INFO(method->klass->rgctx_data, 27));
		int32_t L_37 = V_2;
		bool L_38 = ___preferStriping1;
		ListQueryResults_1_t00D93FF58E931DC3CEE0650FBA675E7A368BE065 * L_39 = (ListQueryResults_1_t00D93FF58E931DC3CEE0650FBA675E7A368BE065 *)il2cpp_codegen_object_new(IL2CPP_RGCTX_DATA(method->klass->rgctx_data, 28));
		((  void (*) (ListQueryResults_1_t00D93FF58E931DC3CEE0650FBA675E7A368BE065 *, RuntimeObject*, int32_t, bool, const RuntimeMethod*))IL2CPP_RGCTX_METHOD_INFO(method->klass->rgctx_data, 29)->methodPointer)(L_39, (RuntimeObject*)(RuntimeObject*)L_36, (int32_t)L_37, (bool)L_38, /*hidden argument*/IL2CPP_RGCTX_METHOD_INFO(method->klass->rgctx_data, 29));
		V_1 = (QueryResults_1_t1956EED88B24434B080C8523FEDCF6843748F3D2 *)L_39;
	}

IL_00c6:
	{
		QueryResults_1_t1956EED88B24434B080C8523FEDCF6843748F3D2 * L_40 = V_0;
		QueryResults_1_t1956EED88B24434B080C8523FEDCF6843748F3D2 * L_41 = V_1;
		Func_3_tBBBFF266D23D5A9A7940D16DA73BCD5DE0753A27 * L_42 = (Func_3_tBBBFF266D23D5A9A7940D16DA73BCD5DE0753A27 *)__this->get__resultSelector_2();
		int32_t L_43 = V_2;
		bool L_44 = ___preferStriping1;
		ZipQueryOperatorResults_tB9DD58D5EFCC60A84DADC3938A2FFA8BAA7A6367 * L_45 = (ZipQueryOperatorResults_tB9DD58D5EFCC60A84DADC3938A2FFA8BAA7A6367 *)il2cpp_codegen_object_new(IL2CPP_RGCTX_DATA(method->klass->rgctx_data, 30));
		((  void (*) (ZipQueryOperatorResults_tB9DD58D5EFCC60A84DADC3938A2FFA8BAA7A6367 *, QueryResults_1_t1956EED88B24434B080C8523FEDCF6843748F3D2 *, QueryResults_1_t1956EED88B24434B080C8523FEDCF6843748F3D2 *, Func_3_tBBBFF266D23D5A9A7940D16DA73BCD5DE0753A27 *, int32_t, bool, const RuntimeMethod*))IL2CPP_RGCTX_METHOD_INFO(method->klass->rgctx_data, 31)->methodPointer)(L_45, (QueryResults_1_t1956EED88B24434B080C8523FEDCF6843748F3D2 *)L_40, (QueryResults_1_t1956EED88B24434B080C8523FEDCF6843748F3D2 *)L_41, (Func_3_tBBBFF266D23D5A9A7940D16DA73BCD5DE0753A27 *)L_42, (int32_t)L_43, (bool)L_44, /*hidden argument*/IL2CPP_RGCTX_METHOD_INFO(method->klass->rgctx_data, 31));
		return (QueryResults_1_t1956EED88B24434B080C8523FEDCF6843748F3D2 *)L_45;
	}
}
// System.Collections.Generic.IEnumerable`1<TOutput> System.Linq.Parallel.ZipQueryOperator`3<System.Object,System.Object,System.Object>::AsSequentialQuery(System.Threading.CancellationToken)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR RuntimeObject* ZipQueryOperator_3_AsSequentialQuery_m5B2C26D8463A6275305EE37DAFD6FBA38181010A_gshared (ZipQueryOperator_3_t2D0121637CE51185E2CBB640EEAF8876A893637E * __this, CancellationToken_tC9D68381C9164A4BA10397257E87ADC832AF5FFD  ___token0, const RuntimeMethod* method)
{
	{
		U3CAsSequentialQueryU3Ed__9_t72DBDAADFC463654715CB97A6C9639B8BE40A398 * L_0 = (U3CAsSequentialQueryU3Ed__9_t72DBDAADFC463654715CB97A6C9639B8BE40A398 *)il2cpp_codegen_object_new(IL2CPP_RGCTX_DATA(method->klass->rgctx_data, 32));
		((  void (*) (U3CAsSequentialQueryU3Ed__9_t72DBDAADFC463654715CB97A6C9639B8BE40A398 *, int32_t, const RuntimeMethod*))IL2CPP_RGCTX_METHOD_INFO(method->klass->rgctx_data, 33)->methodPointer)(L_0, (int32_t)((int32_t)-2), /*hidden argument*/IL2CPP_RGCTX_METHOD_INFO(method->klass->rgctx_data, 33));
		U3CAsSequentialQueryU3Ed__9_t72DBDAADFC463654715CB97A6C9639B8BE40A398 * L_1 = (U3CAsSequentialQueryU3Ed__9_t72DBDAADFC463654715CB97A6C9639B8BE40A398 *)L_0;
		NullCheck(L_1);
		L_1->set_U3CU3E4__this_3(__this);
		U3CAsSequentialQueryU3Ed__9_t72DBDAADFC463654715CB97A6C9639B8BE40A398 * L_2 = (U3CAsSequentialQueryU3Ed__9_t72DBDAADFC463654715CB97A6C9639B8BE40A398 *)L_1;
		CancellationToken_tC9D68381C9164A4BA10397257E87ADC832AF5FFD  L_3 = ___token0;
		NullCheck(L_2);
		L_2->set_U3CU3E3__token_5(L_3);
		return (RuntimeObject*)L_2;
	}
}
// System.Linq.Parallel.OrdinalIndexState System.Linq.Parallel.ZipQueryOperator`3<System.Object,System.Object,System.Object>::get_OrdinalIndexState()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR uint8_t ZipQueryOperator_3_get_OrdinalIndexState_m2837D7B5C77F431ECBD4300B4637ABB6CE008923_gshared (ZipQueryOperator_3_t2D0121637CE51185E2CBB640EEAF8876A893637E * __this, const RuntimeMethod* method)
{
	{
		return (uint8_t)(0);
	}
}
// System.Boolean System.Linq.Parallel.ZipQueryOperator`3<System.Object,System.Object,System.Object>::get_LimitsParallelism()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR bool ZipQueryOperator_3_get_LimitsParallelism_m447F2633A375CCD83CC430A41C0A77F6A54AA688_gshared (ZipQueryOperator_3_t2D0121637CE51185E2CBB640EEAF8876A893637E * __this, const RuntimeMethod* method)
{
	{
		bool L_0 = (bool)__this->get__limitsParallelism_7();
		return (bool)L_0;
	}
}
#ifdef __clang__
#pragma clang diagnostic pop
#endif
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR QuerySettings_t45D8808D6FB4096670C5DDCA198AD4523EE0B974  ParallelQuery_get_SpecifiedQuerySettings_m567824488025D3A0038F414E67F3CAA65525417D_inline (ParallelQuery_tA2D9886CB464C3FA8EB1BB56036F35E3AB55DEF4 * __this, const RuntimeMethod* method)
{
	{
		QuerySettings_t45D8808D6FB4096670C5DDCA198AD4523EE0B974  L_0 = __this->get__specifiedSettings_0();
		return L_0;
	}
}
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR Nullable_1_t864FD0051A05D37F91C857AB496BFCB3FE756103  QuerySettings_get_DegreeOfParallelism_mCA5E77A72EA27EFA3C7C98707937196BB51F5482_inline (QuerySettings_t45D8808D6FB4096670C5DDCA198AD4523EE0B974 * __this, const RuntimeMethod* method)
{
	{
		Nullable_1_t864FD0051A05D37F91C857AB496BFCB3FE756103  L_0 = __this->get__degreeOfParallelism_1();
		return L_0;
	}
}
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR TaskScheduler_t74FBEEEDBDD5E0088FF0EEC18F45CD866B098D5D * QuerySettings_get_TaskScheduler_m759B7D8E10ED54FFDFF56B8015677274E119EA3D_inline (QuerySettings_t45D8808D6FB4096670C5DDCA198AD4523EE0B974 * __this, const RuntimeMethod* method)
{
	{
		TaskScheduler_t74FBEEEDBDD5E0088FF0EEC18F45CD866B098D5D * L_0 = __this->get__taskScheduler_0();
		return L_0;
	}
}
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR CancellationState_t302EEDE088D5E82EBE9A74EE31029F9CB981E9CC * QuerySettings_get_CancellationState_m83D1086517B2A38D891CBDB22977EC9519818F3D_inline (QuerySettings_t45D8808D6FB4096670C5DDCA198AD4523EE0B974 * __this, const RuntimeMethod* method)
{
	{
		CancellationState_t302EEDE088D5E82EBE9A74EE31029F9CB981E9CC * L_0 = __this->get__cancellationState_2();
		return L_0;
	}
}
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR int32_t QuerySettings_get_QueryId_m79A03407AAD4A5BCB2BC58BD9CCDA659413BB35E_inline (QuerySettings_t45D8808D6FB4096670C5DDCA198AD4523EE0B974 * __this, const RuntimeMethod* method)
{
	{
		int32_t L_0 = __this->get__queryId_5();
		return L_0;
	}
}
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR ValueTuple_2_t69671C4973C1A3829B2193E4C598B1AE7162E403  Enumerator_get_Current_m8B737F0ABD2247C4E13D52C15DEAB59C34368B56_gshared_inline (Enumerator_tCF455A92CC670AF169DFC7D0E19B47CAB2BD1DA0 * __this, const RuntimeMethod* method)
{
	{
		ValueTuple_2_t69671C4973C1A3829B2193E4C598B1AE7162E403  L_0 = (ValueTuple_2_t69671C4973C1A3829B2193E4C598B1AE7162E403 )__this->get_current_3();
		return (ValueTuple_2_t69671C4973C1A3829B2193E4C598B1AE7162E403 )L_0;
	}
}
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR bool Enumerator_get_Current_m19632EFFAA50F452EA487CBA0F1781963A3B5396_gshared_inline (Enumerator_t3F9663F5F32B0D733380A76CCEAA3ADFA3AE34A9 * __this, const RuntimeMethod* method)
{
	{
		bool L_0 = (bool)__this->get_current_3();
		return (bool)L_0;
	}
}
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR ContourVertex_tF9E27CB6BCC62DF5F4202153BBBECDE5E3283536  Enumerator_get_Current_mB9DED66EBA82669AB83832B40F60E1710B5179B4_gshared_inline (Enumerator_t0A364062D6EEDD0B306D570939B5709AEAA88D11 * __this, const RuntimeMethod* method)
{
	{
		ContourVertex_tF9E27CB6BCC62DF5F4202153BBBECDE5E3283536  L_0 = (ContourVertex_tF9E27CB6BCC62DF5F4202153BBBECDE5E3283536 )__this->get_current_3();
		return (ContourVertex_tF9E27CB6BCC62DF5F4202153BBBECDE5E3283536 )L_0;
	}
}
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR Decimal_t2978B229CA86D3B7BA66A0AEEE014E0DE4F940D7  Enumerator_get_Current_m463788CB5D0E8998F983E802C69ABFD0DF8F10DF_gshared_inline (Enumerator_t97AF9DDC8F349478939A4899D22F6CC1A2FA7021 * __this, const RuntimeMethod* method)
{
	{
		Decimal_t2978B229CA86D3B7BA66A0AEEE014E0DE4F940D7  L_0 = (Decimal_t2978B229CA86D3B7BA66A0AEEE014E0DE4F940D7 )__this->get_current_3();
		return (Decimal_t2978B229CA86D3B7BA66A0AEEE014E0DE4F940D7 )L_0;
	}
}
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR double Enumerator_get_Current_m14C2F2917DC59AB94B8E9875EEF5E57AB7DE82B8_gshared_inline (Enumerator_tDB7E887EC564EBF2D244915021ED0896BFD7A8A2 * __this, const RuntimeMethod* method)
{
	{
		double L_0 = (double)__this->get_current_3();
		return (double)L_0;
	}
}
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR int32_t Enumerator_get_Current_m6BBD624C51F7E20D347FE5894A6ECA94B8011181_gshared_inline (Enumerator_t7BA00929E14A2F2A62CE085585044A3FEB2C5F3C * __this, const RuntimeMethod* method)
{
	{
		int32_t L_0 = (int32_t)__this->get_current_3();
		return (int32_t)L_0;
	}
}
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR int64_t Enumerator_get_Current_m9EBEA7E72E64499B4BED94F77DF82E7B8C3F1CE0_gshared_inline (Enumerator_t1C02C38119DFDA075166A979AE2B70CCA911ED37 * __this, const RuntimeMethod* method)
{
	{
		int64_t L_0 = (int64_t)__this->get_current_3();
		return (int64_t)L_0;
	}
}
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR RuntimeObject * Enumerator_get_Current_m9C4EBBD2108B51885E750F927D7936290C8E20EE_gshared_inline (Enumerator_tB6009981BD4E3881E3EC83627255A24198F902D6 * __this, const RuntimeMethod* method)
{
	{
		RuntimeObject * L_0 = (RuntimeObject *)__this->get_current_3();
		return (RuntimeObject *)L_0;
	}
}
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR float Enumerator_get_Current_m1DC0B40110173B7E2D13319164F7657C3BE3536D_gshared_inline (Enumerator_tC1FD01C8BB5327D442D71FD022B4338ACD701783 * __this, const RuntimeMethod* method)
{
	{
		float L_0 = (float)__this->get_current_3();
		return (float)L_0;
	}
}
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR void Wrapper_1__ctor_m6A362088D2F7EEC44415BC9C40FE51B2E7E48B80_gshared_inline (Wrapper_1_tDDD2ABAF8D432140BA7A444ED61075E20B73095F * __this, RuntimeObject * ___value0, const RuntimeMethod* method)
{
	{
		RuntimeObject * L_0 = ___value0;
		__this->set_Value_0(L_0);
		return;
	}
}
