//
//  UJSInterface.m
//  Unity-iPhone
//
//  Created by MacMini on 14-5-15.
//
//

#import "IAPInterface.h"
#import <TapOpenApi/TapOpenApi.h>
#import <TapOpenApi/TapOpenApi-Swift.h>
#import <StoreKit/StoreKit.h>

@implementation IAPInterface


#define ARRAY_SIZE(a) sizeof(a)/sizeof(a[0])
 
const char* jailbreak_tool_pathes[] = {
    "/Applications/Cydia.app",
    "/Library/MobileSubstrate/MobileSubstrate.dylib",
    "/bin/bash",
    "/usr/sbin/sshd",
    "/etc/apt"
};
 


void FuncTapTapShare(const char *p1 )    
{

    NSString *messageNSString = [NSString stringWithUTF8String:p1];
    NSArray *components = [messageNSString componentsSeparatedByString:@"&"];
    
    for (NSString *component in components) {
        NSLog(@"%@", component);
    }
    
    
    
    NSString *appId = @"271100";
    NSString *title = [components objectAtIndex:0];
    NSString *contents =  [components objectAtIndex:1];
    NSString *groupLabelId = @"";
    NSString *hashtagIds = @"";
    NSArray *footerImages = @[];
    NSString *failUrl = @"";
    NSString *backUrl = @"";
    
    TapShareObj *obj = [[TapShareObj alloc] initWithAppId:appId
    title:title
    contents:contents
    groupLabelId:groupLabelId
    hashtagIds:hashtagIds
    footerImages:footerImages
    failUrl:failUrl
    backUrl:backUrl];
    [TapApi send:obj completion:^(NSInteger myInteger) {
     // do with result
        
     
        NSString *myString = [NSString stringWithFormat:@"%ld", (long)myInteger];
        // 或者使用 numberWithInt: 方法
        //NSString *myString = [NSString stringWithInt:myInteger];
        
        //NSLog(@"###%@", "FuncTapTapShare.result:  " +  result);
        UnitySendMessage("Global", "OnTapTapShareHandler", myString.UTF8String );
    }];
    
}


void CheckIphoneYueyu(const char *p)
{

    int t1 = 0;
    int t2 = 0;
    int t3 = 0;
  
   [ [ UIApplication sharedApplication] setIdleTimerDisabled:YES ] ;

}

// 新增：打开iOS评分界面
void _requestReview() {
    if([SKStoreReviewController respondsToSelector:@selector(requestReview)]) {
        if (@available(iOS 10.3, *)) {
            [SKStoreReviewController requestReview];
        }
    }
}

@end

