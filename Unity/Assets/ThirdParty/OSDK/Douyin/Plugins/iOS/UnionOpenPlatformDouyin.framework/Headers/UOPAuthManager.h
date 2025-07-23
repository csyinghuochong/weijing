//
//  UOPAuthManager.h
//  UnionOpenPlatform
//
//  Created by ByteDance on 2021/6/3.
//

#import <Foundation/Foundation.h>
#import <UIKit/UIKit.h>

#import <UnionOpenPlatformDouyin/UOPAuthRequest.h>
#import <UnionOpenPlatformDouyin/UOPAuthResponse.h>
#import <UnionOpenPlatformDouyin/UOPAuthDefine.h>

NS_ASSUME_NONNULL_BEGIN

@interface UOPAuthManager : NSObject

+ (instancetype)sharedInstance;

/// 发起授权
/// @param request 授权请求结构
/// @param result 授权结果结构
- (void)authorize:(UOPAuthRequest *)request result:(void(^)(UOPAuthResponse *))result;

#pragma mark - handle URL
/// 响应 application:openURL:url options: 方法
/// @attention 必须在主线程中调用
/// @param url 第三方应用打开APP时传递过来的URL
/// @param options 第三方应用打开APP时传递过来的options
/// @return 处理成功返回YES，失败返回NO。
+ (BOOL)handleOpenURL:(NSURL *)url options:(NSDictionary<UIApplicationOpenURLOptionsKey,id> *)options;

@end

@class UOPDouyinAuthInfo;
@protocol UOPDouyinAuthInfoDelegate;

/// 可选能力通用的授权事件代理
/// @discussion 看播，一键上车 等能力需要实现
@interface UOPAuthManager (FeatureOAuth)

/// 向OSDK注册抖音授权交互回调
/// @discussion 如果厂商接入的可选业务需要用到抖音授权信息，则需要在OSDK初始化后实现该delegate
/// @param delegate delegate
- (void)injectDouyinAuthInfoDelegate:(id<UOPDouyinAuthInfoDelegate>)delegate;

/// 游戏厂商clearOSDK内部的抖音授权态，清理后OSDK内部业务需要抖音授权信息
- (void)clearDouyinAuthInfo;

@end

@interface UOPDouyinAuthInfo : NSObject

@property (nonatomic, copy) NSString *douyinAccessToken;

@property (nonatomic, copy) NSString *douyinOpenId;

@end

@protocol UOPDouyinAuthInfoDelegate <NSObject>

/// 获取授权信息
/// @discussion 若接入方有自行管理账号和抖音授权绑定关系，在SDK业务需求授权信息时会触发方法，需要在回调中传入授权信息；若没有维护绑定关系，则在回调中传nil，会触发update接口；
/// @param completion 完成回调，其中error字段是和安卓保持一致，内部不消费，无需传值
/// @attention 本地没有授权信息时，也需要触发完成回调，继续业务进程
- (void)getDouyinAuthInfo:(void(^_Nullable)(NSError *error, UOPDouyinAuthInfo *authInfo))completion;

/// 需要更新授权信息
/// @discussion 在get方法提供的抖音授权信息无效时，触发本代理方法，接入方需要执行完整授权流程，并在授权流程结束后实现回调；
/// @param completion 完成回调，其中error字段是和安卓保持一致，内部不消费，无需传值
/// @attention 无论授权流程成功或者失败，都需要触发完成回调，继续业务进程
- (void)updateDouyinAuthInfo:(void(^_Nullable)(NSError *error, UOPDouyinAuthInfo *authInfo))completion;

@end

#pragma mark - Deprecated

API_DEPRECATED("This enum will be deprecated soon.", ios(8.0, 10.0))
typedef NS_ENUM(NSInteger, UOPThirdAuthType) {
    UOPThirdAuthTypeNotSupport = -1,
    UOPThirdAuthTypeDouyin
};

@interface UOPAuthManager (Deprecated)

/// 调用指定平台的授权能力
/// @param type 指定的平台，目前仅支持抖音
/// @param request 授权请求结构
/// @param result 授权结果结构
- (void)authPlatform:(UOPThirdAuthType)type
             request:(UOPAuthRequest *)request
              result:(void(^)(UOPAuthResponse *))result API_DEPRECATED("Use -authorize:result: instead.", ios(8.0, 10.0));

/// @param appKey 开放平台提供的 ClientKey
/// @param type 指定的平台，目前仅支持抖音
- (void)registerAppKey:(NSString *)appKey forPlatform:(UOPThirdAuthType)type API_DEPRECATED("This method will be deprecated soon.", ios(8.0, 10.0));

/// 当前指定平台是否完成注册
/// @param type 指定的平台，目前仅支持抖音
- (BOOL)isRegistedForPlatform:(UOPThirdAuthType)type API_DEPRECATED("This method will be deprecated soon.", ios(8.0, 10.0));

/// 响应 AppDelegate 中的 didFinishLaunchingWithOptions 方法
/// @attention 必须在主线程中调用
/// @param launchOptions 为启动application:didFinishLaunchingWithOptions中的options
+ (void)didFinishLaunchingWithOptions:(NSDictionary *)launchOptions API_DEPRECATED("This method will be deprecated soon.", ios(8.0, 10.0));

@end

NS_ASSUME_NONNULL_END
