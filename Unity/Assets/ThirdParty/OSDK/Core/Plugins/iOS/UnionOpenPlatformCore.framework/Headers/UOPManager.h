//
//  UOPManager.h
//  UnionOpenPlatform
//
//  Created by ByteDance on 2021/6/21.
//

#import <Foundation/Foundation.h>
#import <UnionOpenPlatformCore/UOPConfigManager.h>

NS_ASSUME_NONNULL_BEGIN

@interface UOPManager : NSObject

+ (instancetype)sharedManager;

/// SDK初始化
/// @param configFilePath 配置文件沙盒路径
/// @param completion 初始化完成回调
/// @discussion 读取 mainBundle 中的 UOPSDKConfig.json 文件
- (void)setupWithConfigFilePath:(NSString *)configFilePath
                     completion:(void(^)(NSError * _Nullable err))completion;

/// 是否已完成SDK初始化
- (BOOL)isInited;

/// sdk 版本号
@property (nonatomic, copy, readonly) NSString *sdkVersion;
/// sdk 名称
@property (nonatomic, copy, readonly) NSString *sdkName;

- (instancetype)init NS_UNAVAILABLE;
+ (instancetype)new NS_UNAVAILABLE;

#pragma mark - DEPRECATED
/// 禁止使用，即将移除
- (void)startConfig:(UOPConfigManager *)config
      launchOptions:(NSDictionary *)launchOptions
           complete:(void (^)(NSError * _Nullable err))complete API_DEPRECATED("This method will be deprecated soon, use -setupWithConfigFilePath:completion: instead.", ios(8.0, 10.0));

@end

NS_ASSUME_NONNULL_END
