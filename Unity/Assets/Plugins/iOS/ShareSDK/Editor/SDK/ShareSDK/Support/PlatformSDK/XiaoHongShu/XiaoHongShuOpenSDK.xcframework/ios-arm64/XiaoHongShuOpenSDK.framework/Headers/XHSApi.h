//
//  XHSApi.h
//  XHSOpenSDK
//
//  Created by xuhuiming on 2022/12/9.
//  Copyright © 2016年 XingIn. All rights reserved.
//

#import <Foundation/Foundation.h>
#import "XHSApiObject.h"

NS_ASSUME_NONNULL_BEGIN

#pragma mark - XHSApiDelegate

/*! @brief 接收并处理来自小红书终端程序的事件消息
 *
 * 接收并处理来自小红书终端程序的事件消息，期间小红书界面会切换到第三方应用程序。
 * XHSApiDelegate 会在handleOpenURL:delegate:中使用并触发。
 */
@protocol XHSApiDelegate <NSObject>
@optional

/// 发送一个request后，收到小红书终端的回应
/// @param response 具体的回应内容，回应类型详见XHSApiObject.h
- (void)XHSApiDidReceiveResponse:(__kindof XHSOpenSDKBaseResponse *)response;

@end

#pragma mark - XHSSDKLogDelegate

@protocol XHSSDKLogDelegate <NSObject>

- (void)onLog:(NSString*)log logLevel:(XHSOpenSDKLogLevel)level;

@end

#pragma mark - XHSApi
/// 小红书Api接口函数类
/// 封装了小红书终端SDK的所有接口
@interface XHSApi : NSObject

/// 应用启动时调用此函数向小红书终端SDK注册第三方应用
/// @param appId 小红书开发者ID
/// @param universalLink 小红书开发者UniversalLink
/// @param delegate XHSApiDelegate对象，用来接收小红书触发的消息
/// @return 注册成功返回YES，失败返回NO
+ (BOOL)registerApp:(NSString *)appId universalLink:(NSString *)universalLink delegate:(nullable id<XHSApiDelegate>)delegate;

/// 检查小红书是否已被用户安装
/// @return 已安装返回YES，未安装返回NO
+ (BOOL)isXHSAppInstalled;

/// 获取当前小红书SDK的版本号
/// @return 小红书SDK版本号
+ (NSString *)apiVersion;

/// 发送请求到小红书
/// @param request 发送的请求对象
/// @param completion 调用结果回调block
+ (void)sendRequest:(XHSOpenSDKBaseRequest *)request completion:(void (^ __nullable)(BOOL success))completion;

/// 处理小红书通过scheme方式唤起第三方应用时传递的数据
/// 需要在 application:openURL:sourceApplication:annotation:或者application:handleOpenURL中调用
/// @param url 小红书唤起第三方应用时传递的url
/// @return 成功返回YES，失败返回NO
+ (BOOL)handleOpenURL:(NSURL *)url;

/// 处理小红书通过UniversalLink方式唤起第三方应用时传递的数据
/// 需要在AppDelegate或SceneDelegate的continueUserActivity中调用
/// @param userActivity 小红书唤起第三方应用时系统API传递过来的userActivity对象
/// @return 成功返回YES，失败返回NO
+ (BOOL)handleOpenUniversalLink:(NSUserActivity *)userActivity;

/// 日志打印方法
/// @param level 打印log级别
/// @param logDelegate log代理对象
+ (void)startLogByLevel:(XHSOpenSDKLogLevel)level logDelegate:(id<XHSSDKLogDelegate>)logDelegate;

+ (void)enableDebugLogSwitch:(BOOL)isEnableLog;

/// 打开小红书活动页面
/// @param urlStr 落地页 url string
+ (void)openActivityWebViewWithUrl:(NSString *)urlStr
                        completion:(void(^)(BOOL success, NSString *errorMsg))completion;

@end

NS_ASSUME_NONNULL_END
