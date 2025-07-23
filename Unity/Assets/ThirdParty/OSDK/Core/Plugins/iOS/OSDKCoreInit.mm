#import <UnionOpenPlatformCore/UOPManager.h>
#import <UnionOpenPlatformCore/UOPManager+IDFA.h>
#import <UnionOpenPlatformCore/UOPTracker.h>
#import "OSDKiOSUtils.h"
#if __has_include(<UnionOpenPlatformDouyin/UOPAuthManager.h>)
#import <UnionOpenPlatformDouyin/UOPAuthManager.h>
#import "OSDKDouyinAuthorizeContext.h"
#endif

typedef void(*OSDKInitialize_SuccessCallBack)(void);
typedef void(*OSDKInitialize_FailCallBack)(NSInteger errorCode, const char* errorMessage);

typedef void(*OSDKRequestIDFACallback)(BOOL hasAuthorized, const char* IDFAString);

static bool _finishInit = false;

#if defined (__cplusplus)
extern "C" {
#endif
    
void OSDKInitialize(OSDKInitialize_SuccessCallBack successCallBack, OSDKInitialize_FailCallBack failCallBack) {
    NSString *filePath = [[NSBundle mainBundle] pathForResource:@"UOPSDKConfig" ofType:@"json"];
    [[UOPManager sharedManager] setupWithConfigFilePath:filePath completion:^(NSError * _Nonnull err) {
        if (err) {// 初始化失败
            const char* errMsg = AutonomousStringCopy_initBridge([err.userInfo[@"message"] UTF8String]);
            if (failCallBack) {
                failCallBack(err.code, errMsg);
            }
        } else {// 初始化成功
#if __has_include(<UnionOpenPlatformDouyin/UOPAuthManager.h>)
            [[UOPAuthManager sharedInstance] injectDouyinAuthInfoDelegate:OSDKDouyinAuthorizeContext.shared];
#endif
            _finishInit = true;
            if (successCallBack) {
                successCallBack();
            }
        }
    }];
}

bool OSDKIsInited() {
    return _finishInit;
}

void OSDKiOSRequireIDFA(OSDKRequestIDFACallback requireIDFACallback) {
    [UOPManager requestIDFAWithHandler:^(BOOL trackEnable, NSString * _Nonnull idfa) {
        if (requireIDFACallback) {
            requireIDFACallback(trackEnable, AutonomousStringCopy_initBridge([idfa UTF8String]));
        }
    }];
}

void OSDKInjectUnityParams(const char* paramsJsonString) {
    NSString *jsonStringOC = [OSDKiOSUtils stringWithUTF8String:paramsJsonString];
    NSDictionary *dict = [OSDKiOSUtils dictionaryWithJSONString:jsonStringOC];

    [UOPTracker injectUnityParams:dict];
}

        
#if defined (__cplusplus)
}
#endif
