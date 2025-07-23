//
//  BDTrustEnclave.h
//  BDTrustEnclave
//
//  Created by chenzhendong.ok@bytedance.com on 2022/6/4.
//

#import <Foundation/Foundation.h>
#import <BDTicketGuard/BDTGNetwork.h>

NS_ASSUME_NONNULL_BEGIN


@interface BDTGTicketManager : NSObject

@property (nonatomic, copy, readonly, nullable) NSDictionary<NSString *, NSDictionary<NSString *, NSString *> *> *serverDataMap;

+ (instancetype _Nonnull)sharedInstance;

- (void)start;

- (dispatch_queue_t)requestFilterReadWriteQueue;

/// 给获取ticket的请求添加 bd-ticket-guard-version、bd-ticket-guard-client-cert or bd-ticket-guard-client-csr
/// error code：900 - 参数非法，request 为空；公私钥创建失败；
///          901 - 参数非法，request header 中没有 bd-ticket-guard-tag；
///          3000 - 公钥解析失败
///          3002 - csr签名失败
///          -1 - 未知错误 详见 error.localizedDescription；
/// - Parameter request: Http请求
- (NSError *_Nullable)handleGetTicketRequest:(id<BDTGHttpRequest>)request;

/// 处理返回ticket的请求response header中的bd-ticket-guard-server-data
/// error code：900 - 参数非法，request 为空；公私钥创建失败；
///          901 - 参数非法，request header 中没有 bd-ticket-guard-tag；
/// - Parameters:
///   - response: Http请求 response
///   - request: Http请求 request
- (void)handleGetTicketResponse:(id<BDTGHttpResponse>)response request:(id<BDTGHttpRequest>)request;

/// 给使用ticket的请求添加 bd-ticket-guard-version、bd-ticket-guard-client-cert、bd-ticket-guard-client-data
/// error code：900 - 参数非法，request 为空；公私钥创建失败；
///          902 - 参数非法，request header 中没有 bd-ticket-guard-target；
///          4000 - 本地无证书；
///          4001 - 本地无对应的server data；
///          3002 - 签名失败
/// - Parameter request: Http请求 request
- (NSError *_Nullable)handleUseTicketRequest:(id<BDTGHttpRequest>)request;

/// 给获取ticket的请求添加 bd-ticket-guard-version、bd-ticket-guard-client-cert or bd-ticket-guard-client-csr 证书和票据签名由外部自行管理
/// - Parameter request: 请求
/// - Parameter clientCert: 本地证书
+ (NSError *)addHeadersToGetTicketRequest:(id<BDTGHttpRequest>)request;

/// 给使用ticket的请求添加 bd-ticket-guard-version、bd-ticket-guard-client-cert、bd-ticket-guard-client-data 相关参数从外部传入
/// - Parameters:
///   - request: 请求
///   - ticket: 票据
///   - tsSign: 票据签名
///   - clientCert: 本地证书
+ (NSError *)addHeadersToUseTicketRequest:(id<BDTGHttpRequest>)request ticket:(NSString *)ticket tsSign:(NSString *)tsSign clientCert:(NSString *_Nullable)clientCert;

@end


@interface BDTGTicketManager (Adapter)

- (void)addNetworkFilter;

@end

NS_ASSUME_NONNULL_END
