//
//  DouyinOpenSDKExternalProfile.h
//  AWEAnywhereArena
//
//  Created by ByteDance on 2024/5/23.
//

#import <Foundation/Foundation.h>

NS_ASSUME_NONNULL_BEGIN

@class DouyinOpenSDKExternalProfileModel, DouyinOpenSDKExternalProfileVideoModel;

typedef enum : NSUInteger {
    DYOpenExternalProfileShowTypeLatest,
    DYOpenExternalProfileShowTypeCustom,
    DYOpenExternalProfileShowTypeHottest,
} DYOpenExternalProfileShowType;

typedef enum : NSUInteger {
    DouyinOpenExternalProfileErrorCodeInvalidParam = 20002,
    DouyinOpenExternalProfileErrorCodeNotSupportJumpProfile = 20007,
} DouyinOpenSDKExternalProfileErrorCode;

typedef void (^DouyinOpenSDKExternalJumpCompletion)(NSInteger errorCode, NSString* errorMsg);

@interface DouyinOpenSDKExternalProfileContext : NSObject
/// clientKey （必传）
@property (nonatomic, copy, nonnull) NSString *clientKey;
/// 登录用户 openID（建议必传，可以不传）
@property (nonatomic, copy, nonnull) NSString *openId;
/// 目标用户 openID （必传）
@property (nonatomic, copy, nonnull) NSString *targetOpenId;

/// 是否当前登录用户(是否是主态，根据openId和targetOpenId是否相等决定）
- (BOOL)isHost;

@end

@interface DouyinOpenSDKExternalProfile : NSObject

/// 获取名片数据
/// - Parameters:
///   - context: 请求主客态上下文
///   - completion: 结果回调
+ (void)fetchProfileModelWithContext:(DouyinOpenSDKExternalProfileContext *)context
                 customMaxVideoCount:(NSNumber *)customMaxVideoCount
                           completion:(void(^_Nullable)(NSError *error, DouyinOpenSDKExternalProfileModel *model))completion;

/// 获取视频列表
/// - Parameters:
///   - context: 请求主客态上下文
///   - videoIdList: 视频videoID列表
///   - completion: 结果回调
+ (void)getVideoURLListWithContext:(DouyinOpenSDKExternalProfileContext *)context
                       videoIDList:(NSArray<NSString *>*)videoIdList
               customMaxVideoCount:(NSNumber *)customMaxVideoCount
                        completion:(void(^ _Nullable)(NSError *error, NSArray<DouyinOpenSDKExternalProfileVideoModel *> *list))completion;


/// 切换名片模式，不同模式获取到的视频可能不同
/// - Parameters:
///   - context: 请求主客态上下文
///   - showType: 名片模式，目前支持@"custom"自定义模式 ;@"latest"最新模式 ;@"hottest"热度模式;
///   - completion: 结果回调
+ (void)switchCardShowModeWithContext:(DouyinOpenSDKExternalProfileContext *)context
                             showType:(NSString * _Nonnull)showType
                           completion:(void(^ _Nullable)(NSError *error))completion;

/// 设置固定视频
/// - Parameters:
///   - context: 请求主客态上下文
///   - videoID: 视频ID
///   - completion: 结果回调
+ (void)updateCoverVideoWithContext:(DouyinOpenSDKExternalProfileContext *)context
                            videoID:(NSString *)videoID
                         completion:(void(^ _Nullable)(NSError *error))completion;

/// 跳转抖音的名片管理页面（若要使用，请在前50位schema配置douyinOpenExternalProfile）
/// - Parameters:
///   - openId: 当前用户openID
///   - extraParams: 额外数据
///   - customMaxVideoCount: 自定义视频数量
///   - completion: 跳转回调
+ (void)jumpToAlbumWithWithOpenId:(NSString *)openId
                      extraParams:(nullable NSDictionary<NSObject *, id> *)extraParams
              customMaxVideoCount:(NSNumber *)customMaxVideoCount
                       completion:(DouyinOpenSDKExternalJumpCompletion)completion;

/// 跳转主客态个人页（若要使用，请在前50位schema配置douyinOpenExternalProfile）
/// - Parameters:
///   - openId: 当前用户openID
///   - targetOpenId: 目标用户openID
///   - extraParams: 额外数据
///   - completion: 跳转回调
+ (void)jumpToProfileWithOpenId:(NSString *)openId
                   targetOpenId:(NSString *)targetOpenId
                    extraParams:(nullable NSDictionary <NSObject *, id> *)extraParams
            customMaxVideoCount:(NSNumber *)customMaxVideoCount
                     completion:(nullable DouyinOpenSDKExternalJumpCompletion)completion;

/// 能否跳转到支持外部版本名片功能的抖音（若要使用，请在前50位schema配置douyinOpenExternalProfile）
+ (BOOL)canJump;

@end

NS_ASSUME_NONNULL_END
