#import <Foundation/Foundation.h>
#import <UnionOpenPlatformDataLink/UOPDataLinkManager.h>
#import "OSDKiOSUtils.h"

@interface OSDKDataLinkDelegateManager : NSObject<UOPDataLinkManagerDelegate>

@property (nonatomic, copy) void (^callback)(const char*, int, const char*);

@end

@implementation OSDKDataLinkDelegateManager

+ (instancetype)sharedManager {
    static OSDKDataLinkDelegateManager *manager;
    static dispatch_once_t onceToken;
    dispatch_once(&onceToken, ^{
        manager = [[self alloc] init];
    });
    return manager;
}

- (void)onDataLinkReportEvent:(NSString *)eventName code:(NSInteger)code message:(nullable NSString *)message
{
    if (self.callback) {
        self.callback([eventName UTF8String], (int)code, [message UTF8String]);
    }
}
@end
#if defined (__cplusplus)
extern "C" {
#endif

bool OSDKSetDataLinkDelegate(void(*callback)(const char*, int, const char*)) {
    OSDKDataLinkDelegateManager *delegate = [OSDKDataLinkDelegateManager sharedManager]; 
    delegate.callback = ^(const char* eventName, int code, const char* reportMessage) {
        callback(eventName, code, reportMessage);
    };
    [[UOPDataLinkManager sharedInstance] setDelegate:delegate];
    return true;
}

bool OSDKOnGameActive() {
    return [[UOPDataLinkManager sharedInstance] onGameActive];
}

bool OSDKOnAccountRegister(const char* gameUserID) {
    NSString *gameUserIDOC = [OSDKiOSUtils stringWithUTF8String:gameUserID];
    return [[UOPDataLinkManager sharedInstance] onAccountRegister:gameUserIDOC];
}

bool OSDKOnRoleRegister(const char* gameUserID, const char* gameRoleID) {
    NSString *gameUserIDOC = [OSDKiOSUtils stringWithUTF8String:gameUserID];
    NSString *gameRoleIDOC = [OSDKiOSUtils stringWithUTF8String:gameRoleID];
    return [[UOPDataLinkManager sharedInstance] onRoleRegister:gameUserIDOC gameRoleID:gameRoleIDOC];
}

bool OSDKOnAccountLogin(const char* gameUserID, long lastLoginTime) {
    NSString *gameUserIDOC = [OSDKiOSUtils stringWithUTF8String:gameUserID];
    return [[UOPDataLinkManager sharedInstance] onAccountLogin:gameUserIDOC lastLoginTime:lastLoginTime];
}

bool OSDKOnRoleLogin(const char* gameUserID, const char* gameRoleID, long lastRoleLoginTime) {
    NSString *gameUserIDOC = [OSDKiOSUtils stringWithUTF8String:gameUserID];
    NSString *gameRoleIDOC = [OSDKiOSUtils stringWithUTF8String:gameRoleID];
    return [[UOPDataLinkManager sharedInstance] onRoleLogin:gameUserIDOC gameRoleID:gameRoleIDOC lastRoleLoginTime:lastRoleLoginTime];
}

bool OSDKOnPay(const char* gameUserID, const char* gameRoleID, const char* gameOrderID, long totalAmount, const char* productID, const char* productName, const char* productDesc) {
    NSString *gameUserIDOC = [OSDKiOSUtils stringWithUTF8String:gameUserID];
    NSString *gameRoleIDOC = [OSDKiOSUtils stringWithUTF8String:gameRoleID];
    NSString *gameOrderIDOC = [OSDKiOSUtils stringWithUTF8String:gameOrderID];
    
    NSString *productIDOC = [OSDKiOSUtils stringWithUTF8String:productID];
    NSString *productNameOC = [OSDKiOSUtils stringWithUTF8String:productName];
    NSString *productDescOC = [OSDKiOSUtils stringWithUTF8String:productDesc];
    return [[UOPDataLinkManager sharedInstance] onPay:gameUserIDOC gameRoleID:gameRoleIDOC gameOrderID:gameOrderIDOC totalAmount:totalAmount productID:productIDOC productName:productNameOC productDesc:productDescOC];
}

bool OSDKOnPaySpecial(const char* gameUserID, const char* gameRoleID, const char* gameOrderID, const char* payType, long payRangeMin, long payRangeMax, const char* productID, const char* productName, const char* productDesc) {
    NSString *gameUserIDOC = [OSDKiOSUtils stringWithUTF8String:gameUserID];
    NSString *gameRoleIDOC = [OSDKiOSUtils stringWithUTF8String:gameRoleID];
    NSString *gameOrderIDOC = [OSDKiOSUtils stringWithUTF8String:gameOrderID];
    NSString *payTypeOC = [OSDKiOSUtils stringWithUTF8String:payType];
    NSString *productIDOC = [OSDKiOSUtils stringWithUTF8String:productID];
    NSString *productNameOC = [OSDKiOSUtils stringWithUTF8String:productName];
    NSString *productDescOC = [OSDKiOSUtils stringWithUTF8String:productDesc];
    return [[UOPDataLinkManager sharedInstance] onPaySpecial:gameUserIDOC gameRoleID:gameRoleIDOC gameOrderID:gameOrderIDOC payType:payTypeOC payRangeMin:payRangeMin payRangeMax:payRangeMax productID:productIDOC productName:productNameOC productDesc:productDescOC];
}

bool OSDKCustomEvent(const char* eventName, const char* paramsJsonString) {
    NSString *eventNameOC = [OSDKiOSUtils stringWithUTF8String:eventName];
    NSString *jsonStringOC = [OSDKiOSUtils stringWithUTF8String:paramsJsonString];
    NSDictionary *params = [OSDKiOSUtils dictionaryWithJSONString:jsonStringOC];
    return [[UOPDataLinkManager sharedInstance] customEvent:eventNameOC params:params];
}

#if defined (__cplusplus)
}
#endif