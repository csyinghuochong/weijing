//
//  DYOpenExternalTicketService.h
//  AWEAnywhereArena
//
//  Created by ByteDance on 2024/5/30.
//

#import <Foundation/Foundation.h>
#import "DouyinOpenSDKConstants.h"

NS_ASSUME_NONNULL_BEGIN

/// 请求 clientCode 接口 （客态）
typedef void(^DYOpenExternalFinishRequestClientCodeBlock)(NSString *_Nullable clientCode, NSError *_Nullable codeError); // 业务异步获取成功后通过此 block 回调
typedef void(^DYOpenExternalRequestClientCodeBlock)(NSString *_Nonnull clientKey, DYOpenExternalFinishRequestClientCodeBlock _Nonnull finishRequestBlock); // 业务发请求

/// 请求 AccessCode 接口 （主态）
typedef void(^DYOpenExternalFinishRequestAccessCodeBlock)(NSString *_Nullable accessCode, NSString *_Nullable openId, NSError *_Nullable codeError); // 业务异步获取成功后通过此 block 回调
typedef void(^DYOpenExternalRequestAccessCodeBlock)(NSString *_Nonnull clientKey, DYOpenExternalFinishRequestAccessCodeBlock _Nonnull finishRequestBlock); // 业务发请求

/// OpenAPI 请求 block
typedef void(^DYOpenExternalOpenAPIExtraReqBlock)(NSMutableURLRequest *_Nonnull request, NSString *_Nullable clientTicket, NSString *_Nullable accessTicket); // req 额外操作
typedef void(^DYOpenExternalOpenAPICompleteBlock)(NSDictionary *_Nullable respDict, NSDictionary *_Nullable respHeaderDict, NSError *_Nullable error); // 请求 OpenAPI 的结果回调

@interface DYOpenExternalTicketService : NSObject

/// 单例
+ (instancetype)sharedInstance;

/// 清空当前注册的clientKey与注册的所有block
- (void)clearRegisterClientKeyAndBlock;

/// domain 域名
- (NSString *_Nonnull)clientTicketDomain;

#pragma -mark 客态client code 设置

/// 初始化，注册获取 client code 的请求回调，业务在 block 里自行发起请求
/// ！！！注意最后需要调用 finishRequestBlock 通知 openSDK 结果 ！！！
/// ！！！注意最后需要调用 finishRequestBlock 通知 openSDK 结果 ！！！
/// ！！！注意最后需要调用 finishRequestBlock 通知 openSDK 结果 ！！！
/// @param clientKey 开放平台上申请的应用 key
/// @param requestBlock 获取 clientCode 的网络请求操作，一般是由开发者客户端调用开发者服务端封装好的接口（为了安全，客户端不要本地内置 clientSecrect）
- (void)registerClientKey:(NSString *_Nonnull)clientKey requestClientCodeBlock:(DYOpenExternalRequestClientCodeBlock _Nonnull)requestBlock;

/// 如果本地没有ClientTicket，尝试获取ClientTicket
/// @param completion 结果回调
- (void)tryUpdateClientTicketWithCompletion:(void(^ _Nonnull)(NSString *clientTicket, NSError *error))completion;

/// 获取本地存储的ClientTicket
- (NSString *)getClientTicket;

/// 清空本地clientTicket
- (void)removeClientTicket;

#pragma -mark 主态access code 设置

/// 注册获取 Access Code 的请求回调，业务在 block 里自行发起请求
/// ！！！注意最后需要调用 finishRequestBlock 通知 openSDK 结果 ！！！
/// ！！！注意最后需要调用 finishRequestBlock 通知 openSDK 结果 ！！！
/// ！！！注意最后需要调用 finishRequestBlock 通知 openSDK 结果 ！！！
/// @param clientKey 开放平台上申请的应用 key
/// @param requestBlock 获取 accessCode 的网络请求操作，一般是由开发者客户端调用开发者服务端封装好的接口（为了安全，客户端不要本地内置 clientSecrect）
- (void)registerClientKey:(NSString *_Nonnull)clientKey requestAccessCodeBlock:(DYOpenExternalRequestAccessCodeBlock _Nonnull)requestBlock;

/// 如果本地当前的登陆用户没有AccessTicket，或者AccessTicket过期，尝试获取/更新ClientTicket
/// @param completion 结果回调
- (void)tryUpdateAccessTicketWithCompletion:(void(^ _Nonnull)(NSString *accessTicket, NSError *error))completion;

/// 根据openID获取当前的accessTicket（可能过期）
/// @param openID 登陆用户的openID
- (NSString *)getAccessTicketWithOpenID:(NSString *_Nonnull)openID;

/// 根据openID清空accessTicket
/// @param openID 登陆用户的openID
- (void)removeAccessTicketWithOpenID:(NSString *_Nonnull)openID;

/// 清空本地accessTicket
- (void)removeAllAccessTicket;

#pragma -mark 接口请求

/// 使用 client ticket / Access ticket 发送 GET 请求开放平台接口
/// @param domainAndPath 包含 domain + path
/// @param extraReqBlock 可以设置 req header 等参数
/// @param complete 请求回调
/// @param isHost YES主态(accessTicket)/NO客态(clientTicket)
/// @return 发起请求的实例，如果没发起请求则返回 nil（如果需要取消请求，可拿此实例自行取消）
- (NSURLSessionTask *_Nullable)requestGETOpenAPIWithDomainAndPath:(NSString *_Nonnull)domainAndPath
                                                           isHost:(BOOL)isHost
                                                    extraReqBlock:(DYOpenExternalOpenAPIExtraReqBlock _Nullable)extraReqBlock
                                                         complete:(DYOpenExternalOpenAPICompleteBlock _Nullable)complete;

/// 使用 client ticket / Access ticket 发送 POST 请求开放平台接口
/// @param domainAndPath 包含 domain + path
/// @param contentType form 或 json 等
/// @param bodyDict body 参数
/// @param extraReqBlock 可以设置 req header 等参数
/// @param complete 请求回调
/// @param isHost YES主态(accessTicket)/NO客态(clientTicket)
/// @return 发起请求的实例，如果没发起请求则返回 nil（如果需要取消请求，可拿此实例自行取消）
- (NSURLSessionTask *_Nullable)requestPOSTOpenAPIWithDomainAndPath:(NSString *_Nonnull)domainAndPath
                                                            isHost:(BOOL)isHost
                                                       contentType:(DYOpenNetworkContentType)contentType
                                                          bodyDict:(NSDictionary *_Nullable)bodyDict
                                                     extraReqBlock:(DYOpenExternalOpenAPIExtraReqBlock _Nullable)extraReqBlock
                                                          complete:(DYOpenExternalOpenAPICompleteBlock _Nullable)complete;

@end

NS_ASSUME_NONNULL_END
