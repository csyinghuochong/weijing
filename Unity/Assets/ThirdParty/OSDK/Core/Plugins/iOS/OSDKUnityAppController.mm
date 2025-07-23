#import "UnityAppController.h"
#import <UIKit/UIKit.h>

#if __has_include(<UnionOpenPlatformTeamPlay/UOPInstantPlayManager.h>)
#import <UnionOpenPlatformTeamPlay/UOPInstantPlayManager.h>
#endif

#if __has_include(<UnionOpenPlatformDouyin/UOPAuthManager.h>)
#import <UnionOpenPlatformDouyin/UOPAuthManager.h>
#endif

#if __has_include(<UnionOpenPlatformDataLink/UOPDataLinkManager.h>)
#import <UnionOpenPlatformDataLink/UOPDataLinkManager.h>
#endif

@interface OSDKUnityAppController : UnityAppController
@end

IMPL_APP_CONTROLLER_SUBCLASS(OSDKUnityAppController)

@implementation OSDKUnityAppController

- (BOOL)application:(UIApplication *)application didFinishLaunchingWithOptions:(NSDictionary *)launchOptions {
    [super application:application didFinishLaunchingWithOptions:launchOptions];
#if __has_include(<UnionOpenPlatformDouyin/UOPAuthManager.h>)
    [UOPAuthManager didFinishLaunchingWithOptions:launchOptions];
#endif
    return YES;
}

- (BOOL)application:(UIApplication *)app openURL:(NSURL *)url options:(NSDictionary<UIApplicationOpenURLOptionsKey,id> *)options {
#if __has_include(<UnionOpenPlatformDataLink/UOPDataLinkManager.h>)
    if ([url.scheme hasPrefix:@"dygame"]) {
        [UOPDataLinkManager handleOpenURL:url options:options];
    }
#endif

#if __has_include(<UnionOpenPlatformTeamPlay/UOPInstantPlayManager.h>)
    if ([[UOPInstantPlayManager sharedManager] handleOpenURL:url options:options]) {
        return YES;
    }
#endif
    
#if __has_include(<UnionOpenPlatformDouyin/UOPAuthManager.h>)
    if ([UOPAuthManager handleOpenURL:url options:options]) {
        return YES;
    }
#endif
    return [super application:app openURL:url options:options];;
}

- (BOOL)application:(UIApplication *)application openURL:(NSURL *)url sourceApplication:(NSString *)sourceApplication annotation:(id)annotation {
    return [super application:application openURL:url sourceApplication:sourceApplication annotation:annotation];
}

@end
