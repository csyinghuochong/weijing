//
//  UOPTracker.h
//  UnionOpenPlatform
//
//  Created by ByteDance on 2021/6/17.
//

#import <Foundation/Foundation.h>

@class BDAutoTrack;

NS_ASSUME_NONNULL_BEGIN

@interface UOPTracker : NSObject

+ (instancetype)shareInstance;

#pragma mark - Private

/// 内部调用，外部避免直接使用
@property (nonatomic, strong, nullable, readonly) BDAutoTrack *sdkTracker;

+ (void)injectUnityParams:(NSDictionary *)params;

#pragma mark - schemeHandler

/// ET 使用
/// @discussion 如果是iOS 13以上，重写UISceneDelegate的回调方法 -scene:openURLContexts:
/// @discussion 如果iOS版本低于13，则重写UIApplicationDelegate的回调方法 -application:openURL:options:
- (BOOL)handleURL:(NSURL *)url scene:(id _Nullable)scene;

@end

NS_ASSUME_NONNULL_END
