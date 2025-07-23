//
//  DouyinOpenSDKErrorCode.h
//  DouyinOpenPlatformSDK
//
//  Created by arvitwu on 2023/1/11.
//

#import <Foundation/Foundation.h>

/// 一级错误码
typedef NS_ENUM(NSInteger, DouyinOpenSDKErrorCode) {
    DouyinOpenSDKSuccess                            = 0, // 历史有些成功返回 0，有些返回 20000
    DouyinOpenSDKSuccess20000                       = 20000, // 历史有些成功返回 0，有些返回 20000
    
    // ===== SDK 旧通用错误码 ====
    DouyinOpenSDKErrorCodeCommon                    = -1,
    DouyinOpenSDKErrorCodeUserCanceled              = -2,
    DouyinOpenSDKErrorCodeSendFailed                = -3,
    DouyinOpenSDKErrorCodeAuthDenied                = -4, // 权限错误
    DouyinOpenSDKErrorCodeUnsupported               = -5, // 不支持
    DouyinOpenSDKErrorCodeNetDataError              = -6, // 网络返回错误，非字典类型，解析不了
    DouyinOpenSDKErrorCodeNetError                  = -7, // ttnet返回网络错误
    DouyinOpenSDKErrorCodeAccNotMatched             = -8, // 抖音账号和游戏账号不匹配
    DouyinOpenSDKErrorCodeGroupIdInvalid            = -9, // MLBB 加群 ID 不通过校验
    // ===== SDK 旧通用错误码 ====
    
    // ===== SDK 新通用错误码 ====
    DouyinOpenSDKErrorCodeUnknown                   = 40001, // 未知错误
    DouyinOpenSDKErrorCodeNotInitError              = 40002, // 初始化失败
    DouyinOpenSDKErrorCodeNotImplementService       = 40003, // 未实现相关能力
    DouyinOpenSDKErrorCodeParamError                = 40004, // 参数错误
    DouyinOpenSDKErrorCodeNetErrorNew               = 40005, // 网络错误
    // ===== SDK 新通用错误码 ====
    
    // ===== 网关错误码 =====
    DouyinOpenSDKErrorServerInvalidAccessToken      = 28001003, // access_token无效
    DouyinOpenSDKErrorServerInternalError           = 28001005, // 系统内部错误，请重试
    DouyinOpenSDKErrorServerNETWORK_ERR             = 28001006, // 网络调用错误，请重试
    DouyinOpenSDKErrorServerInvalidParam            = 28001007, // 参数不合法
    DouyinOpenSDKErrorServerExpiredAccessToken      = 28001008, // access_token 过期，请刷新或重新授权
    DouyinOpenSDKErrorServerUNKNOWN_ERROR           = 28001010, // 未知错误
    DouyinOpenSDKErrorServerUserNotAuth             = 28001012, // 用户未授权相关 scope
    DouyinOpenSDKErrorServerTargetUserNotAuth       = 28001013, // 目标用户未授权相关 scope
    DouyinOpenSDKErrorServerClientKeyUnauthorized   = 28001014, // 应用未授权任何能力
    DouyinOpenSDKErrorServerClientKeyDisabled       = 28001016, // 当前应用已被封禁或下线
    DouyinOpenSDKErrorServerClientKeyNotAuthScope   = 28001018, // 应用未获得该能力
    DouyinOpenSDKErrorServerClientKeyScopeForbidden = 28001019, // 应用该能力已被封禁
    DouyinOpenSDKErrorServerInvalidClientTicket     = 28001024, // ClientTicket 无效
    // ===== 网关错误码 =====
    
    // ===== Client Ticket 错误码 ====
    DouyinOpenSDKErrorCodeGetClientCode             = 41001, // 获取 clientCode 失败
    DouyinOpenSDKErrorCodeGetClientTicket           = 41002, // 获取 clientTicket 失败
    DouyinOpenSDKErrorCodeGetAccessCode             = 41101, // 获取 accessCode 失败
    DouyinOpenSDKErrorCodeGetAccessTicket           = 41102, // 获取 accessTicket 失败
    // ===== Client Ticket 错误码 ====
};

/// 二级错误码
typedef NS_ENUM(NSInteger, DouyinOpenSDKSubCode) {
    DouyinOpenSDKSubCodeNone                = 0, // 无须二级错误码
    DouyinOpenSDKSubCodeJumpFail            = 42000,  // (iOS)没有安装对应应用或用户不同意跳转或是其它系统错误 导致的没有跳转到抖音系App的错误
};

/// 获取一级错误码对应的文案描述
extern NSString *_Nullable DouyinOpenErrorMsg(DouyinOpenSDKErrorCode opCode);

/// 构造 NSError
/// @param opCode 错误码。如果有其它错误码也可直接传 NSInteger，但建议使用 DouyinOpenSDKErrorCode
/// @param customErrMsg 错误信息。不为空则直接使用，为空时内部会通过 opCode 生成对应错误信息
/// @param userInfo 自定义信息
extern NSError *_Nonnull DouyinOpenError(DouyinOpenSDKErrorCode opCode, NSString *_Nullable customErrMsg, NSDictionary <NSErrorUserInfoKey, id> *_Nullable userInfo);
