#include "pch-cpp.hpp"

#ifndef _MSC_VER
# include <alloca.h>
#else
# include <malloc.h>
#endif


#include <limits>
#include <stdint.h>



// System.Delegate[]
struct DelegateU5BU5D_t677D8FE08A5F99E8EE49150B73966CD6E9BF7DB8;
// System.AsyncCallback
struct AsyncCallback_tA7921BEF974919C46FF8F9D9867C567B200BB0EA;
// System.DelegateData
struct DelegateData_t17DD30660E330C49381DAA99F934BE75CB11F288;
// System.IAsyncResult
struct IAsyncResult_tC9F97BF36FCF122D29D3101D80642278297BF370;
// System.Reflection.MethodInfo
struct MethodInfo_t;
// System.String
struct String_t;
// UnityEngine.Purchasing.UnityPurchasingCallback
struct UnityPurchasingCallback_t457119BEEE9736F72D09ED5F359DADF8C5348C83;
// System.Void
struct Void_t700C6383A2A510C2CF4DD86DABD5CA9FF70ADAC5;
// UnityEngine.Purchasing.iOSStoreBindings
struct iOSStoreBindings_t367691A4F2B495D574CD5156309A8D0A1EC2EBB2;

struct Delegate_t_marshaled_com;
struct Delegate_t_marshaled_pinvoke;


IL2CPP_EXTERN_C_BEGIN
IL2CPP_EXTERN_C_END

#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

// <Module>
struct U3CModuleU3E_t38DF58F79C1FC7D8F63E83E1AE469A6D00867B2D 
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

// UnityEngine.Purchasing.iOSStoreBindings
struct iOSStoreBindings_t367691A4F2B495D574CD5156309A8D0A1EC2EBB2  : public RuntimeObject
{
public:

public:
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

// UnityEngine.Purchasing.UnityPurchasingCallback
struct UnityPurchasingCallback_t457119BEEE9736F72D09ED5F359DADF8C5348C83  : public MulticastDelegate_t
{
public:

public:
};

#ifdef __clang__
#pragma clang diagnostic pop
#endif



// System.Void UnityEngine.Purchasing.iOSStoreBindings::setUnityPurchasingCallback(UnityEngine.Purchasing.UnityPurchasingCallback)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void iOSStoreBindings_setUnityPurchasingCallback_mA6E7A9ED94FEB43EA79520C1D585E10F313F486B (UnityPurchasingCallback_t457119BEEE9736F72D09ED5F359DADF8C5348C83 * ___AsyncCallback0, const RuntimeMethod* method);
// System.String UnityEngine.Purchasing.iOSStoreBindings::getUnityPurchasingAppReceipt()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR String_t* iOSStoreBindings_getUnityPurchasingAppReceipt_m885518155FA4D780618C826DC7B410E3234E934E (const RuntimeMethod* method);
// System.Void UnityEngine.Purchasing.iOSStoreBindings::unityPurchasingRetrieveProducts(System.String)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void iOSStoreBindings_unityPurchasingRetrieveProducts_m4E5E381E9F971CFF56E51C822E16991F9C5807DE (String_t* ___json0, const RuntimeMethod* method);
// System.Void UnityEngine.Purchasing.iOSStoreBindings::unityPurchasingPurchase(System.String,System.String)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void iOSStoreBindings_unityPurchasingPurchase_mE829342E21E31B562F954190D68F83065F695954 (String_t* ___json0, String_t* ___developerPayload1, const RuntimeMethod* method);
// System.Void UnityEngine.Purchasing.iOSStoreBindings::unityPurchasingFinishTransaction(System.String,System.String)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void iOSStoreBindings_unityPurchasingFinishTransaction_mE91B99037CD6E185067C2E95712DA8DCC2C0EFC0 (String_t* ___productJSON0, String_t* ___transactionId1, const RuntimeMethod* method);
// System.Void UnityEngine.Purchasing.iOSStoreBindings::unityPurchasingRestoreTransactions()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void iOSStoreBindings_unityPurchasingRestoreTransactions_m7900E6D71255C26C1D1AA1C23CB66842804B252E (const RuntimeMethod* method);
// System.Void UnityEngine.Purchasing.iOSStoreBindings::unityPurchasingAddTransactionObserver()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void iOSStoreBindings_unityPurchasingAddTransactionObserver_m56D915D85C4C83F2CD66ED159642FDB434A74B21 (const RuntimeMethod* method);
// System.Void UnityEngine.Purchasing.iOSStoreBindings::unityPurchasingInterceptPromotionalPurchases()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void iOSStoreBindings_unityPurchasingInterceptPromotionalPurchases_mEC0781212E2492F0B440BF3B7994D3D866748058 (const RuntimeMethod* method);
// System.Void System.Object::.ctor()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Object__ctor_m88880E0413421D13FD95325EDCE231707CE1F405 (RuntimeObject * __this, const RuntimeMethod* method);
IL2CPP_EXTERN_C void DEFAULT_CALL unityPurchasingRetrieveProducts(char*);
IL2CPP_EXTERN_C void DEFAULT_CALL unityPurchasingPurchase(char*, char*);
IL2CPP_EXTERN_C void DEFAULT_CALL unityPurchasingFinishTransaction(char*, char*);
IL2CPP_EXTERN_C void DEFAULT_CALL unityPurchasingRestoreTransactions();
IL2CPP_EXTERN_C void DEFAULT_CALL unityPurchasingAddTransactionObserver();
IL2CPP_EXTERN_C void DEFAULT_CALL setUnityPurchasingCallback(Il2CppMethodPointer);
IL2CPP_EXTERN_C char* DEFAULT_CALL getUnityPurchasingAppReceipt();
IL2CPP_EXTERN_C void DEFAULT_CALL unityPurchasingInterceptPromotionalPurchases();
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
// System.Void UnityEngine.Purchasing.iOSStoreBindings::unityPurchasingRetrieveProducts(System.String)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void iOSStoreBindings_unityPurchasingRetrieveProducts_m4E5E381E9F971CFF56E51C822E16991F9C5807DE (String_t* ___json0, const RuntimeMethod* method)
{
	typedef void (DEFAULT_CALL *PInvokeFunc) (char*);

	// Marshaling of parameter '___json0' to native representation
	char* ____json0_marshaled = NULL;
	____json0_marshaled = il2cpp_codegen_marshal_string(___json0);

	// Native function invocation
	reinterpret_cast<PInvokeFunc>(unityPurchasingRetrieveProducts)(____json0_marshaled);

	// Marshaling cleanup of parameter '___json0' native representation
	il2cpp_codegen_marshal_free(____json0_marshaled);
	____json0_marshaled = NULL;

}
// System.Void UnityEngine.Purchasing.iOSStoreBindings::unityPurchasingPurchase(System.String,System.String)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void iOSStoreBindings_unityPurchasingPurchase_mE829342E21E31B562F954190D68F83065F695954 (String_t* ___json0, String_t* ___developerPayload1, const RuntimeMethod* method)
{
	typedef void (DEFAULT_CALL *PInvokeFunc) (char*, char*);

	// Marshaling of parameter '___json0' to native representation
	char* ____json0_marshaled = NULL;
	____json0_marshaled = il2cpp_codegen_marshal_string(___json0);

	// Marshaling of parameter '___developerPayload1' to native representation
	char* ____developerPayload1_marshaled = NULL;
	____developerPayload1_marshaled = il2cpp_codegen_marshal_string(___developerPayload1);

	// Native function invocation
	reinterpret_cast<PInvokeFunc>(unityPurchasingPurchase)(____json0_marshaled, ____developerPayload1_marshaled);

	// Marshaling cleanup of parameter '___json0' native representation
	il2cpp_codegen_marshal_free(____json0_marshaled);
	____json0_marshaled = NULL;

	// Marshaling cleanup of parameter '___developerPayload1' native representation
	il2cpp_codegen_marshal_free(____developerPayload1_marshaled);
	____developerPayload1_marshaled = NULL;

}
// System.Void UnityEngine.Purchasing.iOSStoreBindings::unityPurchasingFinishTransaction(System.String,System.String)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void iOSStoreBindings_unityPurchasingFinishTransaction_mE91B99037CD6E185067C2E95712DA8DCC2C0EFC0 (String_t* ___productJSON0, String_t* ___transactionId1, const RuntimeMethod* method)
{
	typedef void (DEFAULT_CALL *PInvokeFunc) (char*, char*);

	// Marshaling of parameter '___productJSON0' to native representation
	char* ____productJSON0_marshaled = NULL;
	____productJSON0_marshaled = il2cpp_codegen_marshal_string(___productJSON0);

	// Marshaling of parameter '___transactionId1' to native representation
	char* ____transactionId1_marshaled = NULL;
	____transactionId1_marshaled = il2cpp_codegen_marshal_string(___transactionId1);

	// Native function invocation
	reinterpret_cast<PInvokeFunc>(unityPurchasingFinishTransaction)(____productJSON0_marshaled, ____transactionId1_marshaled);

	// Marshaling cleanup of parameter '___productJSON0' native representation
	il2cpp_codegen_marshal_free(____productJSON0_marshaled);
	____productJSON0_marshaled = NULL;

	// Marshaling cleanup of parameter '___transactionId1' native representation
	il2cpp_codegen_marshal_free(____transactionId1_marshaled);
	____transactionId1_marshaled = NULL;

}
// System.Void UnityEngine.Purchasing.iOSStoreBindings::unityPurchasingRestoreTransactions()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void iOSStoreBindings_unityPurchasingRestoreTransactions_m7900E6D71255C26C1D1AA1C23CB66842804B252E (const RuntimeMethod* method)
{
	typedef void (DEFAULT_CALL *PInvokeFunc) ();

	// Native function invocation
	reinterpret_cast<PInvokeFunc>(unityPurchasingRestoreTransactions)();

}
// System.Void UnityEngine.Purchasing.iOSStoreBindings::unityPurchasingAddTransactionObserver()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void iOSStoreBindings_unityPurchasingAddTransactionObserver_m56D915D85C4C83F2CD66ED159642FDB434A74B21 (const RuntimeMethod* method)
{
	typedef void (DEFAULT_CALL *PInvokeFunc) ();

	// Native function invocation
	reinterpret_cast<PInvokeFunc>(unityPurchasingAddTransactionObserver)();

}
// System.Void UnityEngine.Purchasing.iOSStoreBindings::setUnityPurchasingCallback(UnityEngine.Purchasing.UnityPurchasingCallback)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void iOSStoreBindings_setUnityPurchasingCallback_mA6E7A9ED94FEB43EA79520C1D585E10F313F486B (UnityPurchasingCallback_t457119BEEE9736F72D09ED5F359DADF8C5348C83 * ___AsyncCallback0, const RuntimeMethod* method)
{
	typedef void (DEFAULT_CALL *PInvokeFunc) (Il2CppMethodPointer);

	// Marshaling of parameter '___AsyncCallback0' to native representation
	Il2CppMethodPointer ____AsyncCallback0_marshaled = NULL;
	____AsyncCallback0_marshaled = il2cpp_codegen_marshal_delegate(reinterpret_cast<MulticastDelegate_t*>(___AsyncCallback0));

	// Native function invocation
	reinterpret_cast<PInvokeFunc>(setUnityPurchasingCallback)(____AsyncCallback0_marshaled);

}
// System.String UnityEngine.Purchasing.iOSStoreBindings::getUnityPurchasingAppReceipt()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR String_t* iOSStoreBindings_getUnityPurchasingAppReceipt_m885518155FA4D780618C826DC7B410E3234E934E (const RuntimeMethod* method)
{
	typedef char* (DEFAULT_CALL *PInvokeFunc) ();

	// Native function invocation
	char* returnValue = reinterpret_cast<PInvokeFunc>(getUnityPurchasingAppReceipt)();

	// Marshaling of return value back from native representation
	String_t* _returnValue_unmarshaled = NULL;
	_returnValue_unmarshaled = il2cpp_codegen_marshal_string_result(returnValue);

	// Marshaling cleanup of return value native representation
	il2cpp_codegen_marshal_free(returnValue);
	returnValue = NULL;

	return _returnValue_unmarshaled;
}
// System.Void UnityEngine.Purchasing.iOSStoreBindings::unityPurchasingInterceptPromotionalPurchases()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void iOSStoreBindings_unityPurchasingInterceptPromotionalPurchases_mEC0781212E2492F0B440BF3B7994D3D866748058 (const RuntimeMethod* method)
{
	typedef void (DEFAULT_CALL *PInvokeFunc) ();

	// Native function invocation
	reinterpret_cast<PInvokeFunc>(unityPurchasingInterceptPromotionalPurchases)();

}
// System.Void UnityEngine.Purchasing.iOSStoreBindings::SetUnityPurchasingCallback(UnityEngine.Purchasing.UnityPurchasingCallback)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void iOSStoreBindings_SetUnityPurchasingCallback_mD3AD3FDB77C029BFA41D59FADAA8D7697D0C06B4 (iOSStoreBindings_t367691A4F2B495D574CD5156309A8D0A1EC2EBB2 * __this, UnityPurchasingCallback_t457119BEEE9736F72D09ED5F359DADF8C5348C83 * ___AsyncCallback0, const RuntimeMethod* method)
{
	{
		// setUnityPurchasingCallback(AsyncCallback);
		UnityPurchasingCallback_t457119BEEE9736F72D09ED5F359DADF8C5348C83 * L_0 = ___AsyncCallback0;
		iOSStoreBindings_setUnityPurchasingCallback_mA6E7A9ED94FEB43EA79520C1D585E10F313F486B(L_0, /*hidden argument*/NULL);
		// }
		return;
	}
}
// System.String UnityEngine.Purchasing.iOSStoreBindings::get_appReceipt()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR String_t* iOSStoreBindings_get_appReceipt_m597D9A5C940B329BBEB857B01EEF2E17DB624116 (iOSStoreBindings_t367691A4F2B495D574CD5156309A8D0A1EC2EBB2 * __this, const RuntimeMethod* method)
{
	{
		// return getUnityPurchasingAppReceipt();
		String_t* L_0;
		L_0 = iOSStoreBindings_getUnityPurchasingAppReceipt_m885518155FA4D780618C826DC7B410E3234E934E(/*hidden argument*/NULL);
		return L_0;
	}
}
// System.Void UnityEngine.Purchasing.iOSStoreBindings::RetrieveProducts(System.String)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void iOSStoreBindings_RetrieveProducts_m9A3D77232B6BF527EC724953A5181287CF22F49A (iOSStoreBindings_t367691A4F2B495D574CD5156309A8D0A1EC2EBB2 * __this, String_t* ___json0, const RuntimeMethod* method)
{
	{
		// unityPurchasingRetrieveProducts(json);
		String_t* L_0 = ___json0;
		iOSStoreBindings_unityPurchasingRetrieveProducts_m4E5E381E9F971CFF56E51C822E16991F9C5807DE(L_0, /*hidden argument*/NULL);
		// }
		return;
	}
}
// System.Void UnityEngine.Purchasing.iOSStoreBindings::Purchase(System.String,System.String)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void iOSStoreBindings_Purchase_mF735135A82CA122D9832E6036D661A6280B9EB51 (iOSStoreBindings_t367691A4F2B495D574CD5156309A8D0A1EC2EBB2 * __this, String_t* ___productJSON0, String_t* ___developerPayload1, const RuntimeMethod* method)
{
	{
		// unityPurchasingPurchase(productJSON, developerPayload);
		String_t* L_0 = ___productJSON0;
		String_t* L_1 = ___developerPayload1;
		iOSStoreBindings_unityPurchasingPurchase_mE829342E21E31B562F954190D68F83065F695954(L_0, L_1, /*hidden argument*/NULL);
		// }
		return;
	}
}
// System.Void UnityEngine.Purchasing.iOSStoreBindings::FinishTransaction(System.String,System.String)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void iOSStoreBindings_FinishTransaction_mCF186344110DC674B0FF28CDAF1705D37C5B1DF9 (iOSStoreBindings_t367691A4F2B495D574CD5156309A8D0A1EC2EBB2 * __this, String_t* ___productJSON0, String_t* ___transactionId1, const RuntimeMethod* method)
{
	{
		// unityPurchasingFinishTransaction(productJSON, transactionId);
		String_t* L_0 = ___productJSON0;
		String_t* L_1 = ___transactionId1;
		iOSStoreBindings_unityPurchasingFinishTransaction_mE91B99037CD6E185067C2E95712DA8DCC2C0EFC0(L_0, L_1, /*hidden argument*/NULL);
		// }
		return;
	}
}
// System.Void UnityEngine.Purchasing.iOSStoreBindings::RestoreTransactions()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void iOSStoreBindings_RestoreTransactions_m26838CAAFFB87410E59908B7F76E9E98C22DFC2B (iOSStoreBindings_t367691A4F2B495D574CD5156309A8D0A1EC2EBB2 * __this, const RuntimeMethod* method)
{
	{
		// unityPurchasingRestoreTransactions();
		iOSStoreBindings_unityPurchasingRestoreTransactions_m7900E6D71255C26C1D1AA1C23CB66842804B252E(/*hidden argument*/NULL);
		// }
		return;
	}
}
// System.Void UnityEngine.Purchasing.iOSStoreBindings::AddTransactionObserver()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void iOSStoreBindings_AddTransactionObserver_m56DA0CA68185EE64550D690245E2707408B80C7D (iOSStoreBindings_t367691A4F2B495D574CD5156309A8D0A1EC2EBB2 * __this, const RuntimeMethod* method)
{
	{
		// unityPurchasingAddTransactionObserver();
		iOSStoreBindings_unityPurchasingAddTransactionObserver_m56D915D85C4C83F2CD66ED159642FDB434A74B21(/*hidden argument*/NULL);
		// }
		return;
	}
}
// System.Void UnityEngine.Purchasing.iOSStoreBindings::InterceptPromotionalPurchases()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void iOSStoreBindings_InterceptPromotionalPurchases_mDCAEF82089D915A5C6AE7D0FAAFCC3541319BED0 (iOSStoreBindings_t367691A4F2B495D574CD5156309A8D0A1EC2EBB2 * __this, const RuntimeMethod* method)
{
	{
		// unityPurchasingInterceptPromotionalPurchases();
		iOSStoreBindings_unityPurchasingInterceptPromotionalPurchases_mEC0781212E2492F0B440BF3B7994D3D866748058(/*hidden argument*/NULL);
		// }
		return;
	}
}
// System.Void UnityEngine.Purchasing.iOSStoreBindings::.ctor()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void iOSStoreBindings__ctor_mC063A1F335653F7A6EC3EB6B1687122698A093F0 (iOSStoreBindings_t367691A4F2B495D574CD5156309A8D0A1EC2EBB2 * __this, const RuntimeMethod* method)
{
	{
		Object__ctor_m88880E0413421D13FD95325EDCE231707CE1F405(__this, /*hidden argument*/NULL);
		return;
	}
}
#ifdef __clang__
#pragma clang diagnostic pop
#endif
