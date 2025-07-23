//
//  DouyinOpenSDKWebAuthManager.h
//  DouyinOpenPlatformSDK-2666b058
//
//  Created by ByteDance on 2024/8/19.
//

#import <Foundation/Foundation.h>

NS_ASSUME_NONNULL_BEGIN

@interface DouyinOpenSDKWebAuthManager : NSObject

@property (atomic, readonly) BOOL currentIsWifi;

@property (atomic, readonly) BOOL isMonitorOpen;

+ (instancetype)shareManager;

- (void)startWifiStatusMonitor;

- (void)cancelWifiStatusMonitor;

@end

NS_ASSUME_NONNULL_END
